var homeModel = (function () {

    function getHomePage() {

        return jsonRequester.get('http://localhost:9941/api/HomePageInfo')
        .then(function (res) {
            return res;
        });
    }

    return {
        getHomePage: getHomePage
    };
}());