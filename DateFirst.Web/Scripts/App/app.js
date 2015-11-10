(function () {
    var sammyApp = Sammy('#content', function () {

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', controllers.home.getHomePage);

        this.get('#/users', controllers.users.getAllUsersPage);

        this.get('#/users/:id', controllers.users.getUserProfilePage);
    });

    $(function () {
        sammyApp.run('#/');

        if (userModel.hasUser()) {
            $('.login-containers').hide();
        } else {
            $('.logout-container').hide();
        }

        $('#my-profile').on('click', function () {
            userModel.getLoggedUser()
            .then(function (res) {
                document.location = '/#/users/' + res.Id;
                console.log($("#btn-edit-profile").text('Value'));              
            });
        });

        $('#sign-out').on('click', function () {
            userModel.signOut()
              .then(function () {
                  toastr.success('Goodbye!');
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
                  toastr.success('Welcome back ' + user.username);
                  document.location = '#/';
                  $('#login-modal').modal('toggle');
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