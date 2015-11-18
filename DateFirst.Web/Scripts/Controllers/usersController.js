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

            for (var i = 0; i < user.Posts.length; i++) {
                var date = new Date(user.Posts[i].CreatedOn);
                var formatedDate = formatDate(date);
                user.Posts[i].CreatedOn = formatedDate;
            }

            return templates.get('userProfile');
        })
        .then(function (template) {
            context.$element().html(template(user));

            $('#btn-bio').removeClass("btn-user-profile").addClass("btn-pressed");

            $(".btn-pref .btn").click(function () {
                $(".btn-pref .btn").removeClass("btn-pressed").addClass("btn-user-profile");
                $(this).removeClass("btn-user-profile").addClass("btn-pressed");
            });

            var notification = PUBNUB.init({
                publish_key: 'pub-c-34ecc75a-c5af-4e51-98bb-66b7f1accb20',
                subscribe_key: 'sub-c-7e9a38a6-89c9-11e5-a04a-0619f8945a4f'
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
                    toastr.options = {
                        "positionClass": "toast-top-right",
                    }

                    $.ajax({
                        type: "GET",
                        url: "http://localhost:9941/api/UserProfiles/" + user.Id,
                        headers: { 'Authorization': 'Bearer ' + localStorage.getItem('access_token') }
                    })
                    .then(function (res) {
                        $('#count').text(res.Flirts);
                    });

                    toastr.success('You flirted with ' + user.FirstName + ' ' + user.LastName + '!');
                });
            });

            $('#flirts').on('click', function () {
                userModel.getLoggedUserId()
                    .then(function (res) {
                        var loggedUserId = res;

                        userModel.getUserInfo(loggedUserId)
                            .then(function (loggedUserInfo) {
                                var info = loggedUserInfo;
                                notification.publish({
                                    channel: 'Notification',
                                    message: {
                                        "Text": info.FirstName + ' ' + info.LastName + ' flirt your profile!',
                                        "Flirter": info
                                    }
                                });
                                notification.subscribe({
                                    channel: 'Notification',
                                    message: function (notification) {
                                        toastr.options = {
                                            "positionClass": "toast-top-center",
                                            onclick: function () {
                                                window.location = '#/users/' + notification.Flirter.Id;
                                            }
                                        }

                                        toastr.info(notification.Text, "Flirt Notifications:");
                                    }
                                });
                            });
                    });
            });

            $("#btn-send-comment").click(function () {
                userModel.getLoggedUserId()
                .then(function (res) {
                    var content = $("#ta-comment-message").val();
                    var senderId = res;
                    var receiverId = user.Id;

                    var data = {
                        'Content': content,
                        'SenderId': senderId,
                        'ReceiverId': receiverId
                    };

                    postModel.sendNewPost(data)
                    .then(function () {
                        userModel.getLoggedUserName()
                         .then(function (res) {
                             var createdOn = getDateOfPostCreation();

                             var commentToAppend = '<div class="post">' +
                                                  '<div class="poster-and-date">' +
                                                      '<div class="poster-name">' + res + '</div>' +
                                                      '<div class="posting-date">' + createdOn + '</div>' +
                                                  '</div>' +
                                                  '<div id="user-post-container" class="post-content triangle-border left">' +
                                                      '<div>' + content + '</div>' +
                                                  '</div>' +
                                              '</div>';

                             $('#comments-container').append(commentToAppend);
                         })
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

            for (var i = 0; i < user.Posts.length; i++) {
                var date = new Date(user.Posts[i].CreatedOn);
                var formatedDate = formatDate(date);
                user.Posts[i].CreatedOn = formatedDate;
            }

            return templates.get('editProfile');
        })
        .then(function (template) {
            context.$element().html(template(user));

            $('#btn-bio').removeClass("btn-user-profile").addClass("btn-pressed");

            $(".btn-pref .btn").click(function () {
                $(".btn-pref .btn").removeClass("btn-pressed").addClass("btn-user-profile");
                $(this).removeClass("btn-user-profile").addClass("btn-pressed");
            });

            $("#btn-send-comment").click(function () {
                userModel.getLoggedUserId()
                .then(function (res) {
                    console.log(res);
                    var content = $("#ta-comment-message").val();
                    var senderId = res;
                    var receiverId = user.Id;

                    var data = {
                        'Content': content,
                        'SenderId': senderId,
                        'ReceiverId': receiverId
                    };

                    postModel.sendNewPost(data)
                    .then(function () {
                        var createdOn = getDateOfPostCreation();

                        var commentToAppend = '<div class="post">' +
                                                  '<div class="poster-and-date">' +
                                                      '<div class="poster-name">' + user.FirstName + ' ' + user.LastName + '</div>' +
                                                      '<div class="posting-date">' + createdOn + '</div>' +
                                                  '</div>' +
                                                  '<div id="user-post-container" class="post-content triangle-border left">' +
                                                      '<div>' + content + '</div>' +
                                                  '</div>' +
                                              '</div>';

                        $('#comments-container').append(commentToAppend);
                    });
                })
            });

            $('#fileUpload').on('change', function myfunction() {
                var files = $("#fileUpload").get(0).files;
                $("#tb-selected-file").val(files[0].name);
            })

            $('#btnUploadFile').on('click', function () {
                var data = new FormData();

                var files = $("#fileUpload").get(0).files;

                if (files.length > 0) {
                    data.append("UploadedImage", files[0]);
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
                    toastr.success('Image uploaded!');
                    // Do other operation
                });
            });

            //Update profile picture
            $('#btn-UploadFile').on('click', function () {
                var data = new FormData();

                var files = $("#file-upload").get(0).files;

                if (files.length > 0) {
                    data.append("UploadedImage", files[0]);
                }

                var ajaxRequest = $.ajax({
                    type: "POST",
                    url: "http://localhost:9941//api/UploadProfilePicture",
                    contentType: false,
                    processData: false,
                    data: data,
                    headers: { 'Authorization': 'Bearer ' + localStorage.getItem('access_token') }
                });

                ajaxRequest.done(function (xhr, textStatus) {
                    toastr.success('Profile picture updated!');
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

    function formatDate(date) {
        var year = date.getFullYear(),
            month = date.getMonth() + 1,
            day = date.getDate(),
            hour = date.getHours() - 2,
            minute = date.getMinutes(),
            hourFormatted = hour % 12 || 12,
            minuteFormatted = minute < 10 ? "0" + minute : minute;

        return day + "/" + month + "/" + year + " " + hourFormatted + ":" +
                minuteFormatted;
    }

    function getDateOfPostCreation() {
        var dateTime = new Date();
        var createdOn = dateTime.getDate() + "/"
                        + (dateTime.getMonth() + 1) + "/"
                        + dateTime.getFullYear() + " "
                        + dateTime.getHours() + ":"
                        + (dateTime.getMinutes() < 10 ? '0' : '') + dateTime.getMinutes();
        return createdOn;
    }

    scope.users = {
        getAllUsers: getAllUsers,
        getAllMaleUsers: getAllMaleUsers,
        getAllFemaleUsers: getAllFemaleUsers,
        getUserProfilePage: getUserProfilePage,
        editUserProfilePage: editUserProfilePage
    };
}(controllers));