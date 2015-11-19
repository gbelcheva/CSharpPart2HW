var imageModel = (function () {

    function uploadImage(data) {
        return jsonRequester.post("http://localhost:9941//api/FileUpload", {
            data: data,
            headers: { 'Authorization': modelHelpers.getBearerCode() },
            contentType: false,
            processData: false
        })
        .then(function (res) {
            return res;
        });
    }

    function uploadAvatar(data) {
        return jsonRequester.post("http://localhost:9941//api/UploadProfilePicture", {
            data: data,
            headers: { 'Authorization': modelHelpers.getBearerCode() },
            contentType: false,
            processData: false
        })
        .then(function (res) {
            return res;
        });
    }

    return {
        uploadImage: uploadImage,
        uploadAvatar: uploadAvatar
    };
}());