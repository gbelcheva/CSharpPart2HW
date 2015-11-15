var controllers = controllers || {};
(function (scope) {

    function getHomePage(context) {
        var homePage;
        var promise = homeModel.getHomePage();

        promise.then(function (resUsers) {
            homePage = resUsers;
            return templates.get('home');
        })
          .then(function (template) {
              context.$element().html(template(homePage));

              

              var chat = PUBNUB.init({
                  publish_key: 'pub-c-34ecc75a-c5af-4e51-98bb-66b7f1accb20',
                  subscribe_key: 'sub-c-7e9a38a6-89c9-11e5-a04a-0619f8945a4f'
              });

              $('#btn-send-message').click(function () {
                  $("#chat").animate({ scrollTop: $(document).height() }, "slow");

                  var messageToSend = $('#ta-shoutbox-message').val();
                  $('#ta-shoutbox-message').val('');

                  function addZero(num) {
                      return (num >= 0 && num < 10) ? "0" + num : num + "";
                  }

                  var now = new Date();
                  var strDateTime = [[addZero(now.getHours()), addZero(now.getMinutes())].join(":"), now.getHours() >= 12 ? "PM" : "AM"].join(" ");

                  var currentLogginUser;
                  var promise = userModel.getLoggedUserName();
                  promise.then(function (res) {
                      currentLogginUser = res;

                      var htmlToAdd = '<a class="pull-left" href="#">' +
                                             '<img class="media-object img-circle" src="http://lorempixel.com/30/30/people/7/" alt="">' +
                                         '</a>' +
                                         '<div class="media-body">' +
                                            '<h4 class="media-heading">' +
                                                 currentLogginUser +
                                                 '<span class="small pull-right">' + strDateTime + '</span>' +
                                             '</h4>' +
                                             '<p>' + messageToSend + '</p>' +
                                         '</div>' +
                                          '<hr/>';

                      $('#msg-content').append(htmlToAdd);

                      chat.publish({
                          channel: 'DateFirst',
                          message: {
                              "Text": messageToSend,
                              "Sender": currentLogginUser
                          }
                      });
                  });

                  chat.subscribe({
                      channel: 'DateFirst',
                      message: function (m) {
                          var htmlToAdd = '<a class="pull-left" href="#">' +
                                           '<img class="media-object img-circle" src="http://lorempixel.com/30/30/people/7/" alt="">' +
                                       '</a>' +
                                       '<div class="media-body">' +
                                          '<h4 class="media-heading">' +
                                               m.Sender +
                                               '<span class="small pull-right">' + strDateTime + '</span>' +
                                           '</h4>' +
                                           '<p>' + m.Text + '</p>' +
                                       '</div>' +
                                        '<hr/>';
                          $('#msg-content').append(htmlToAdd);
                      }
                  });
              });



              $('#btn-search').click(function () {
                  var foundUsers;
                  var gender = $('#search-gender').val();
                  var eyeColor = $('#search-eye-color').val();
                  var hairColor = $('#search-hair-color').val();
                  var starSign = $('#search-star-sign').val();

                  var data = {
                      'Gender': gender,
                      'EyeColor': eyeColor,
                      'HairColor': hairColor,
                      'StarSign': starSign
                  }

                  userModel.getSearchedUsers(data)
                  .then(function (resFoundUsers) {
                      foundUsers = resFoundUsers;
                      return templates.get('users');
                  })
                  .then(function (template) {
                      context.$element().html(template(foundUsers));
                      context.redirect('#/users/search-result');
                  })


                  //age dropdown?
              });
          })
    }

    scope.home = {
        getHomePage: getHomePage
    };
}(controllers));