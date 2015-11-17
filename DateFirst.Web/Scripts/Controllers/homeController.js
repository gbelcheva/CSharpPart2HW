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

              $('#ta-shoutbox-message').keyup(function (event) {
                  if (event.keyCode == 13) {
                      $('#btn-send-message').click();
                  }
              });

              var currentLogginUserId;
              var promise = userModel.getLoggedUserId();
              $('#btn-send-message').click(function () {
                  $("#chat").animate({ scrollTop: $(document).height() }, "slow");

                  var messageToSend = $('#ta-shoutbox-message').val();
                  $('#ta-shoutbox-message').val('');

                  function addZero(num) {
                      return (num >= 0 && num < 10) ? "0" + num : num + "";
                  }

                  var now = new Date();
                  var strDateTime = [[addZero(now.getHours()), addZero(now.getMinutes())].join(":"), now.getHours() >= 12 ? "PM" : "AM"].join(" ");

                  
                  promise.then(function (res) {
                      currentLogginUserId = res;
                      
                      userModel.getUserInfo(currentLogginUserId)
                        .then(function (res) {
                            var loggedUserInfo = res;

                            var htmlToAdd = '<div class="row">' +
                                                 '<div class="col-lg-12">' +
                                                     '<div class="media" >' +
                                                         '<a class="pull-left" href="#">' +
                                                                  '<img style="width: 50px" height="50px" class="media-object img-circle" src=' + '"' + loggedUserInfo.AvatarUrl + '"' + ' alt="">' +
                                                         '</a>' +
                                                         '<div class="media-body">' +
                                                             '<h4 class="media-heading">' +
                                                                 loggedUserInfo.FirstName + ' ' + loggedUserInfo.LastName +
                                                                 '<span class="small pull-right">' + strDateTime + '</span>' +
                                                             '</h4>' +
                                                             '<p>' + messageToSend + '</p>' +
                                                         '</div>' +
                                                         '<hr/>' +
                                                     '</div>' +
                                                 '</div>' +
                                             '</div>';

                            $('#msg-content').append(htmlToAdd);
                            $('#msg-content').scrollTop($('#msg-content')[0].scrollHeight);

                            chat.publish({
                                channel: 'DateFirst',
                                message: {
                                    "Text": messageToSend,
                                    "Sender": loggedUserInfo
                                }
                            });
                    });
                  });

                  chat.subscribe({
                      channel: 'DateFirst',
                      message: function (message) {
                          var htmlToAdd = '<div class="row">' +
                                            '<div class="col-lg-12">' +
                                                '<div class="media" >' +
                                                    '<a class="pull-left" href="#">' +
                                                             '<img style="width: 50px" height="50px" class="media-object img-circle" src=' + '"' + message.Sender.AvatarUrl + '"' + ' alt="">' +
                                                    '</a>' +
                                                    '<div class="media-body">' +
                                                        '<h4 class="media-heading">' +
                                                            message.Sender.FirstName + ' ' + message.Sender.LastName +
                                                            '<span class="small pull-right">' + strDateTime + '</span>' +
                                                        '</h4>' +
                                                        '<p>' + message.Text + '</p>' +
                                                    '</div>' +
                                                    '<hr/>' +
                                                '</div>' +
                                            '</div>' +
                                        '</div>';
                          $('#msg-content').append(htmlToAdd);
                          $('#msg-content').scrollTop($('#msg-content')[0].scrollHeight);
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