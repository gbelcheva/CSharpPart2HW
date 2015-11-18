var postModel = (function () {

    function sendNewPost(data) {
            return jsonRequester.post('http://localhost:9941/api/Posts', {
                headers: { 'Authorization': modelHelpers.getBearerCode() },
                data: JSON.stringify(data)
            })
            .then(function (res) {
                return res;
            });
        }

    return {
        sendNewPost : sendNewPost
    };

}());