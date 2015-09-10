import 'jquery'
import data from 'js/data.js'
import templates from 'js/templates.js'
import validator from 'js/validator.js'
import notifier from 'js/notifier.js'

export default {
    register: function () {
        //console.log('hello from usersController.register!!!');

        templates.load('register')
            .then(function (templateHtml) {
                $('#main').html(templateHtml());
            });

        $('#main').on('click', '#btn-register', function (ev) {
            var username = $('#inputEmail')[0].value;
            var password = $('#inputPassword')[0].value;

            validator.validatePassword(password, 6, 40)
                .then(function () {
                    return data.user.register(username, password);
                })
                .then(function () {
                    notifier.success('User ' + username + ' registered.');

                    window.location = '#/login';
                }, function(err){
                    notifier.error(err);
                });
        });
    },
    login: function () {
        console.log('hello from usersController.login!!!');

        templates.load('login')
            .then(function (templateHtml) {
                $('#main').html(templateHtml());
            });

        $('#main').on('click', '#btn-login', function (ev) {
            var username = $('#inputEmail')[0].value;
            var password = $('#inputPassword')[0].value;

            data.user.login(username, password)
            .then(function () {
                    notifier.success('User ' + username + ' logged in.');

                    window.location = window.location.origin;
                }, function(err){
                    notifier.error(err);
                });
        });
    },
    logout: function () {
        data.user.logout()
            .then(function () {
                notifier.success('User logged out.');

                window.location = window.location.origin;
            }, function(err){
                window.location = window.location.origin + '#/login';
            });
    }
}