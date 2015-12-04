﻿var controllers = controllers || {};
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
                  publish_key: constants.PUBNUB_PUBLISH_KEY,
                  subscribe_key: constants.PUBNUB_SUBSCRIBE_KEY
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
                            var htmlToAdd = controllerHelper.generateChatMessage(loggedUserInfo, messageToSend);

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
                          var htmlToAdd = controllerHelper.generateChatMessage(message.Sender, messageToSend);
                              //'<div class="row">' +
                              //              '<div class="col-lg-12">' +
                              //                  '<div class="media" >' +
                              //                      '<a class="pull-left" href="#/users/'+ message.Sender.Id +'">' +
                              //                               '<img style="width: 50px" height="50px" class="media-object img-circle" src=' + '"' + message.Sender.AvatarUrl + '"' + ' alt="">' +
                              //                      '</a>' +
                              //                      '<div class="media-body">' +
                              //                          '<h4 class="media-heading">' +
                              //                              message.Sender.FirstName + ' ' + message.Sender.LastName +
                              //                              '<span class="small pull-right">' + strDateTime + '</span>' +
                              //                          '</h4>' +
                              //                          '<p>' + message.Text + '</p>' +
                              //                      '</div>' +
                              //                      '<hr/>' +
                              //                  '</div>' +
                              //              '</div>' +
                              //          '</div>';
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
              });
          })
    }

    scope.home = {
        getHomePage: getHomePage
    };
}(controllers));