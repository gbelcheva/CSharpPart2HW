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
          })
    }

    scope.home = {
        getHomePage: getHomePage
    };
}(controllers));