var modelHelpers = function() {

    function getBearerCode() {
        return localStorage.getItem(constants.TOKEN_TYPE) + ' ' + localStorage.getItem(constants.USER_ACCESS_TOKEN);
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

    return {
        getBearerCode: getBearerCode,
        formatDate: formatDate,
        getDateOfPostCreation: getDateOfPostCreation
    };
}();