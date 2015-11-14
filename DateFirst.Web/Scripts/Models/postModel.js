var postModel = (function () {
    const USER_ACCESS_TOKEN = 'access_token',
        TOKEN_TYPE = 'token_type';

    function sendNewPost(data) {

            var bearerCode = localStorage.getItem(TOKEN_TYPE) + ' ' + localStorage.getItem(USER_ACCESS_TOKEN);
            console.log(data);
            data = JSON.stringify(data);
            console.log(data);

            return jsonRequester.post('http://localhost:9941/api/Posts', {
                headers: { 'Authorization': bearerCode },
                data: data
            })
            .then(function (res) {
                return res;
            });
        }

    return {
        sendNewPost : sendNewPost
    };

}());