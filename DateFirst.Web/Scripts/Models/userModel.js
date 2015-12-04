var userModel = (function () {
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
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            contentType: 'application/x-www-form-urlencoded'
        })
          .then(function (resp) {
              localStorage.setItem(constants.USER_ACCESS_TOKEN, resp.access_token);
              localStorage.setItem(constants.TOKEN_TYPE, resp.token_type);
              return user;
          });
    }

    function signOut() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(constants.USER_ACCESS_TOKEN);
            localStorage.removeItem(constants.TOKEN_TYPE);
            resolve();
        });
        return promise;
    }

    function hasUser() {
        return !!localStorage.getItem(constants.USER_ACCESS_TOKEN);
    }

    function getUser(id) {
        return jsonRequester.get('http://localhost:9941/api/UserProfiles/' + id)
        .then(function (res) {
            return res;
        })
    }

    function getUserInfo(id) {
        return jsonRequester.get('http://localhost:9941/api/UserProfiles/' + id)
        .then(function (res) {
            if (res.AdditionalInfo !== null) {
                res.AdditionalInfo.Gender = enumerations.genderType[res.AdditionalInfo.Gender];
                res.AdditionalInfo.HairColor = enumerations.hairColorType[res.AdditionalInfo.HairColor];
                res.AdditionalInfo.EyeColor = enumerations.eyeColorType[res.AdditionalInfo.EyeColor];
                res.AdditionalInfo.StarSign = enumerations.starSignType[res.AdditionalInfo.StarSign];
            }

            return res;
        })
    }

    function getAllUsers() {
        return jsonRequester.get('http://localhost:9941/api/UserProfiles')
        .then(function (res) {
            return res;
        });
    }

    function getAllMaleUsers() {
        return jsonRequester.get('http://localhost:9941/api/MaleUserProfiles')
        .then(function (res) {
            return res;
        });
    }

    function getAllFemaleUsers() {
        return jsonRequester.get('http://localhost:9941/api/FemaleUserProfiles')
        .then(function (res) {
            return res;
        });
    }

    function getLoggedUserId() {
        return jsonRequester.get('http://localhost:9941/api/Account/LoggedUser', {
            headers: { 'Authorization': modelHelpers.getBearerCode() }
        })
            .then(function (res) {
                return res;
            });
    }

    function getLoggedUserName() {
        return jsonRequester.get('http://localhost:9941/api/Account/UserName', {
            headers: { 'Authorization': modelHelpers.getBearerCode() }
        })
            .then(function (res) {
                return res;
            });
    }

    function updateUserInfo(data) {

        data = JSON.stringify(data);

        return jsonRequester.put('http://localhost:9941/api/Account/UpdateUserInfo', {
            headers: { 'Authorization': modelHelpers.getBearerCode() },
            data: data
        })
        .then(function (res) {
            return res;
        });
    }

    function getSearchedUsers(data) {
        return jsonRequester.get('http://localhost:9941/api/UserProfiles/Search', {
            data: data
        })
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
        getAllMaleUsers: getAllMaleUsers,
        getAllFemaleUsers: getAllFemaleUsers,
        getUser: getUser,
        getUserInfo: getUserInfo,
        getLoggedUserId: getLoggedUserId,
        getLoggedUserName: getLoggedUserName,
        getSearchedUsers: getSearchedUsers,
        updateUserInfo: updateUserInfo
    };

}());