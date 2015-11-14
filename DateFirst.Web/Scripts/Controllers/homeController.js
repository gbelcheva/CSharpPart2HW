var controllers = controllers || {};
(function (scope) {

    function getHomePage(context) {
        var homePage;
        var promise = homeModel.getHomePage();

        promise.then(function (resUsers) {
            homePage = resUsers;
            return templates.get('home');
        })
          .then(function (template) {
              context.$element().html(template(homePage));

              $('#btn-search').click(function () {
                  var foundUsers;
                  var gender = $('#search-gender').val();
                  var eyeColor = $('#search-eye-color').val();
                  var hairColor = $('#search-hair-color').val();
                  var starSign = $('#search-star-sign').val();

                  var data = {
                      'Gender': gender,
                      'EyeColor': eyeColor,
                      'HairColor': hairColor,
                      'StarSign': starSign
                  }

                  userModel.getSearchedUsers(data)
                  .then(function (resFoundUsers) {
                      foundUsers = resFoundUsers;
                      return templates.get('users');
                  })
                  .then(function (template) {
                      context.$element().html(template(foundUsers));
                      context.redirect('#/users/search-result');
                  })


                  //age dropdown?
              });
          })
    }

    scope.home = {
        getHomePage: getHomePage
    };
}(controllers));