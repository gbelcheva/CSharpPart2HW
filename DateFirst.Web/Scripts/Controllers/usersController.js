var controllers = controllers || {};
(function (scope) {

    function getAllUsersPage(context) {
        var allUsers;
        var promise = userModel.getAllUsers();

        promise.then(function (resUsers) {
            allUsers = resUsers;
            return templates.get('users');
        })
          .then(function (template) {
              context.$element().html(template(allUsers));
          })
    }

    function getUserProfilePage(context) {
        var user;
        var promise = userModel.getUser(this.params['id']);

        promise.then(function (resUser) {
            user = resUser;
            return templates.get('userProfile');
        })
        .then(function (template) {
            context.$element().html(template(user));
            $(".btn-pref .btn").click(function () {
                $(".btn-pref .btn").removeClass("btn-primary").addClass("btn-default");
                $(this).removeClass("btn-default").addClass("btn-primary");
            });
        })
    }

    scope.users = {
        getAllUsersPage: getAllUsersPage,
        getUserProfilePage: getUserProfilePage
    };
}(controllers));