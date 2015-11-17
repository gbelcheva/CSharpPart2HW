(function () {
    var sammyApp = Sammy('#content', function () {

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', controllers.home.getHomePage);

        this.get('#/users', controllers.users.getAllUsers);

        this.get('#/users/male-users', controllers.users.getAllMaleUsers)

        this.get('#/users/female-users', controllers.users.getAllFemaleUsers)

        this.get('#/users/search-result');

        this.get('#/users/:id', controllers.users.getUserProfilePage);

        this.get('#/users/:id/my-profile', controllers.users.editUserProfilePage);

        //this.get('#/users/:id/edit-profile', controllers.users.getUserProfilePage);
    });

    $(function () {
        sammyApp.run('#/');

        if (userModel.hasUser()) {
            userModel.getLoggedUserName()
            .then(function (userNames) {
                $('#logged-user-name').text(userNames);
                $('.login-containers').hide();
            });           
        } else {
            $('.logout-container').hide();
        }

        $('#home-btn').on('click', function () {
            document.location = '/#/home';
        });

        $('#my-profile').on('click', function () {
            userModel.getLoggedUserId()
            .then(function (res) {
                document.location = '/#/users/' + res + '/my-profile';
            });
        });

        $('#edit-profile').on('click', function () {
            userModel.getLoggedUserId()
            .then(function (res) {
                document.location = '/#/users/' + res + '/edit-profile';
            });
        });

        $('#sign-out').on('click', function () {
            userModel.signOut()
              .then(function () {
                  toastr.success('Goodbye!');
                  document.location.reload();
                  document.location = '#/home';
                  setTimeout(function () {
                      $('.logout-container').fadeOut(100, function () {
                          $('.login-containers').fadeIn(500);
                      });
                  }, 1000);
              });
        });

        $('#sign-in-btn').on('click', function (e) {
            var user = {
                username: $('#sign-in-email').val(),
                password: $('#sign-in-pass').val()
            };
            userModel.signIn(user)
              .then(function (user) {
                  toastr.success('Welcome back!');
                  document.location = '#/';
                  $('#login-modal').modal('toggle');

                  userModel.getLoggedUserName()
                  .then(function (res) {
                      $('#logged-user-name').text(res);
                  });

                  setTimeout(function () {
                      $('.login-containers').fadeOut(100, function () {
                          $('.logout-container').fadeIn(500);
                      });
                  }, 1000);
              }, function (err) {
                  toastr.error(err.responseJSON["error_description"]);
              });
        });

        $('#btn-register').on('click', function () {
            var user = {
                username: $('#tb-reg-email').val(),
                password: $('#tb-reg-pass').val(),
                firstName: $('#tb-reg-first-name').val(),
                lastName: $('#tb-reg-last-name').val()
            };

            userModel.register(user)
              .then(function () {
                  userModel.signIn(user)
                     .then(function (user) {
                         toastr.success('Registration successful!');
                         document.location = '#/';
                         $('#register-modal').modal('toggle');
                         $('#logged-user-name').text(user.firstName + ' ' + user.lastName);
                         setTimeout(function () {
                             $('.login-containers').fadeOut(100, function () {
                                 $('.logout-container').fadeIn(500);
                             });
                         }, 1000);
                     }, function (err) {
                         toastr.error(err.responseJSON["error_description"]);
                     });
              }, function (err) {
                  //toastr.error(err);
              });
        });
    });
}());