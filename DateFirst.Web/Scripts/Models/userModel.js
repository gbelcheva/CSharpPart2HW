var userModel = (function () {
    const USER_ACCESS_TOKEN = 'access_token',
        TOKEN_TYPE = 'token_type';
    var Enums = {
        genderType: { 0: 'Male', 1: 'Female', 2: 'Other', 3: 'Unknown' },
        hairColorType: { 0: 'Blond', 1: 'Brown', 2: 'Red', 3: 'Ginger', 4: 'Black', 5: 'Grey', 6: 'Colored', 7: 'Albino', 8: 'Unknown' },
        eyeColorType: { 0: 'Albino', 1: 'Green', 2: 'Blue', 3: 'Brown', 4: 'Hazel', 5: 'Grey', 6: 'Unknown' },
        starSignType: { 0: 'Aries', 1: 'Taurus', 2: 'Gemini', 3: 'Cancer', 4: 'Leo', 5: 'Virgo', 6: 'Libra', 7: 'Scorpio', 8: 'Sagittarius', 9: 'Capricorn', 10: 'Aquarius', 11: 'Pisces', 12: 'Unknown' }
    };

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
              console.log(resp);
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

            return res;
        })
    }

    function getUserInfo(id) {

        return jsonRequester.get('http://localhost:9941/api/UserProfiles/' + id)
        .then(function (res) {

            if (res.AdditionalInfo !== null) {
                res.AdditionalInfo.Gender = Enums.genderType[res.AdditionalInfo.Gender];
                res.AdditionalInfo.HairColor = Enums.hairColorType[res.AdditionalInfo.HairColor];
                res.AdditionalInfo.EyeColor = Enums.eyeColorType[res.AdditionalInfo.EyeColor];
                res.AdditionalInfo.StarSign = Enums.starSignType[res.AdditionalInfo.StarSign];
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

        var bearerCode = localStorage.getItem(TOKEN_TYPE) + ' ' + localStorage.getItem(USER_ACCESS_TOKEN);

        return jsonRequester.get('http://localhost:9941/api/Account/LoggedUser', { headers: { 'Authorization': bearerCode } })
            .then(function (res) {
                return res;
            });
    }

    function getLoggedUserName() {

        var bearerCode = localStorage.getItem(TOKEN_TYPE) + ' ' + localStorage.getItem(USER_ACCESS_TOKEN);

        return jsonRequester.get('http://localhost:9941/api/Account/UserName', { headers: { 'Authorization': bearerCode } })
            .then(function (res) {
                return res;
            });
    }

    function updateUserInfo(data) {
        var bearerCode = localStorage.getItem(TOKEN_TYPE) + ' ' + localStorage.getItem(USER_ACCESS_TOKEN);
        console.log(data);
        data = JSON.stringify(data);
        console.log(data);

        return jsonRequester.put('http://localhost:9941/api/Account/UpdateUserInfo', {
            headers: { 'Authorization': bearerCode },
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
            console.log(res);
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
        getLoggedUserName : getLoggedUserName,
        getSearchedUsers: getSearchedUsers,
        updateUserInfo: updateUserInfo
    };

}());