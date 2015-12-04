var controllerHelper = function() {

    function generateChatMessage(user, message) {
        function addZero(num) {
            return (num >= 0 && num < 10) ? "0" + num : num + "";
        }

        var now = new Date();
        var strDateTime = [[addZero(now.getHours()), addZero(now.getMinutes())].join(":"), now.getHours() >= 12 ? "PM" : "AM"].join(" ");

        var htmlToAdd = '<div class="row">' +
                            '<div class="col-lg-12">' +
                                '<div class="media" >' +
                                    '<a class="pull-left" href="#/users/' + user.Id + '">' +
                                            '<img style="width: 50px" height="50px" class="media-object img-circle" src=' + '"' + user.AvatarUrl + '"' + ' alt="">' +
                                    '</a>' +
                                    '<div class="media-body">' +
                                        '<h4 class="media-heading">' +
                                            user.FirstName + ' ' + user.LastName +
                                            '<span class="small pull-right">' + strDateTime + '</span>' +
                                        '</h4>' +
                                        '<p>' + message + '</p>' +
                                    '</div>' +
                                    '<hr/>' +
                                '</div>' +
                            '</div>' +
                        '</div>';

        return htmlToAdd;
    }

    return {
        generateChatMessage: generateChatMessage
    };
}();