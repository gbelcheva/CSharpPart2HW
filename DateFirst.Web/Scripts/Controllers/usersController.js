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
        var promise = userModel.getUserInfo(this.params['id']);

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

    function editUserProfilePage(context) {
        var user;
        var promise = userModel.getUser(this.params['id']);

        promise.then(function (resUser) {
            user = resUser;
            return templates.get('editProfile');
        })
        .then(function (template) {
            context.$element().html(template(user));
            if (user.AdditionalInfo != null) {
                var currentGender = user.AdditionalInfo.Gender;
                var currentEyeColor = user.AdditionalInfo.EyeColor;
                var currentHairColor = user.AdditionalInfo.HairColor;
                var currentStarSign = user.AdditionalInfo.StarSign;
                var currentAge = user.AdditionalInfo.Age;
                var currentHeight = user.AdditionalInfo.Heigth;
                var currentWeight = user.AdditionalInfo.Weight;
                var currendJobTitle = user.AdditionalInfo.JobTitle;
                var currentSalary = user.AdditionalInfo.Salary;
                var currentAboutMe = user.AdditionalInfo.AboutMe;
            }

            $('#select-gender').val(currentGender);
            $('#select-eye-color').val(currentEyeColor);
            $('#select-hair-color').val(currentHairColor);
            $('#select-star-sign').val(currentStarSign);
            $('#tb-age').val(currentAge);
            $('#tb-height').val(currentHeight);
            $('#tb-weight').val(currentWeight);
            $('#tb-job-title').val(currendJobTitle);
            $('#tb-salary').val(currentSalary);
            $('#ta-about-me').val(currentAboutMe);

            $("#btn-save-changes").click(function myfunction() {

                var modifiedGender = $('#select-gender').val();
                var modifiedEyeColor = $('#select-eye-color').val();
                var modifiedHairColor = $('#select-hair-color').val();
                var modifiedStarSign = $('#select-star-sign').val();
                var modifiedAge = $('#tb-age').val();
                var modifiedHeight = $('#tb-height').val();
                var modifiedWeight = $('#tb-weight').val();
                var modifiedJobTitle = $('#tb-job-title').val();
                var modifiedSalary = $('#tb-salary').val();
                var modifiedAboutMe = $('#ta-about-me').val();

                var data = {
                    'Id': user.Id,
                    'Gender': modifiedGender,
                    'EyeColor': modifiedEyeColor,
                    'HairColor': modifiedHairColor,
                    'StarSign': modifiedStarSign,
                    'Age': modifiedAge,
                    'Heigth': modifiedHeight,
                    'Weight': modifiedWeight,
                    'JobTitle': modifiedJobTitle,
                    'Salary': modifiedSalary,
                    'AboutMe': modifiedAboutMe
                }

                userModel.updateUserInfo(data)
                    .then(function (res) {
                        
                        document.location = '/#/users/' + user.Id + '/my-profile';
                    });
            })
        })

    }

    scope.users = {
        getAllUsersPage: getAllUsersPage,
        getUserProfilePage: getUserProfilePage,
        editUserProfilePage: editUserProfilePage
    };
}(controllers));