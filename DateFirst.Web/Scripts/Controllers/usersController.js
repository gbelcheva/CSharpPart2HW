var controllers = controllers || {};
(function (scope) {

    function getAllUsers(context) {
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

    function getAllMaleUsers(context) {
        var maleUsers;
        var promise = userModel.getAllMaleUsers();

        promise.then(function (resUsers) {
            maleUsers = resUsers;
            return templates.get('users');
        })
        .then(function (template) {
            context.$element().html(template(maleUsers));
        })
    }

    function getAllFemaleUsers(context) {
        var femaleUsers;
        var promise = userModel.getAllFemaleUsers();

        promise.then(function (resUsers) {
            femaleUsers = resUsers;
            return templates.get('users');
        })
        .then(function (template) {
            context.$element().html(template(femaleUsers));
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
                $(".btn-pref .btn").removeClass("btn-pressed").addClass("btn-user-profile");
                $(this).removeClass("btn-user-profile").addClass("btn-pressed");
            });

            $('#flirts').on('click', function () {
                $.ajax({
                    type: "PUT",
                    data: user,
                    url: "http://localhost:9941//api/Flirts",
                    headers: { 'Authorization': 'Bearer ' + localStorage.getItem('access_token') },
                    error: function (xhr, status, error) {
                        var err = eval("(" + xhr.responseText + ")");
                        toastr.error(err.Message);
                    }
                })
                .then(function () {
                    toastr.success('You flirted this profile!');
                    $.ajax({
                        type: "GET",
                        url: "http://localhost:9941/api/UserProfiles/" + user.Id,
                        headers: { 'Authorization': 'Bearer ' + localStorage.getItem('access_token') }
                    })
                        .then(function (res) {
                            $('#count').text(res.Flirts);
                        });
                });
            });

            $("#btn-add-post").click(function () {
                userModel.getLoggedUserId()
                .then(function (res) {
                    var content = $("#ta-post-content").val();
                    var senderId = res;
                    var receiverId = user.Id;

                    var data = {
                        'Content': content,
                        'SenderId': senderId,
                        'ReceiverId': receiverId
                    };

                    postModel.sendNewPost(data)
                    .then(function () {
                        window.location.reload();
                    });
                })
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

            $('#btnUploadFile').on('click', function () {
                var data = new FormData();

                var files = $("#fileUpload").get(0).files;

                if (files.length > 0) {
                    data.append("UploadedImage", files[0]);
                    console.log(files[0]);
                }

                var ajaxRequest = $.ajax({
                    type: "POST",
                    url: "http://localhost:9941//api/FileUpload",
                    contentType: false,
                    processData: false,
                    data: data,
                    headers: { 'Authorization': 'Bearer ' + localStorage.getItem('access_token') }
                });

                ajaxRequest.done(function (xhr, textStatus) {
                    // Do other operation
                });
            });

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
        getAllUsers: getAllUsers,
        getAllMaleUsers: getAllMaleUsers,
        getAllFemaleUsers: getAllFemaleUsers,
        getUserProfilePage: getUserProfilePage,
        editUserProfilePage: editUserProfilePage
    };
}(controllers));