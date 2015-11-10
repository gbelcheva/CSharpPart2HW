var userModel = (function () {
    const USER_ACCESS_TOKEN = 'access_token',
        TOKEN_TYPE = 'token_type';

    function register(user) {
        // Add validator

        var reqUser = {
            Email: user.username,
            Password: user.password,
            ConfirmPassword: user.password,
            FirstName: user.firstName,
            LastName: user.lastName
        };

        return jsonRequester.post('http://localhost:9941/api/Account/Register', {
            data: JSON.stringify(reqUser)
        })
          .then(function (resp) {
              $('#content').text(JSON.stringify(resp));
          });
    }

    function signIn(user) {
        // Add Validator

        var userInfo = 'grant_type=password&username=' + user.username + '&password=' + user.password;

        return jsonRequester.post('http://localhost:9941/Token', {
            data: userInfo,
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }, // TODO: check if header or contentType can be removed?
            contentType: 'application/x-www-form-urlencoded'
        })
          .then(function (resp) {
              localStorage.setItem(USER_ACCESS_TOKEN, resp.access_token);
              localStorage.setItem(TOKEN_TYPE, resp.token_type);
              return user;
          });
    }

    function signOut() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(USER_ACCESS_TOKEN);
            localStorage.removeItem(TOKEN_TYPE);
            resolve();
        });
        return promise;
    }

    function hasUser() {
        return !!localStorage.getItem(USER_ACCESS_TOKEN);
    }

    function getUser(id) {

        return jsonRequester.get('http://localhost:9941/api/UserProfiles/' + id)
        .then(function (res) {
            console.log(res);
            return res;
        })
    }

    function getAllUsers() {

        return jsonRequester.get('http://localhost:9941/api/UserProfiles')
        .then(function (res) {
            console.log(res);
            return res;
        });
    }

    function getLoggedUser() {

        var bearerCode = localStorage.getItem(TOKEN_TYPE) + ' ' + localStorage.getItem(USER_ACCESS_TOKEN);

        return jsonRequester.get('http://localhost:9941/api/Account/LoggedUser', { headers: { 'Authorization': bearerCode } })
       .then(function (res) {
           return res;
       });
    }

    return {
        register: register,
        signIn: signIn,
        signOut: signOut,
        hasUser: hasUser,
        getAllUsers: getAllUsers,
        getUser: getUser,
        getLoggedUser: getLoggedUser
    };

}());