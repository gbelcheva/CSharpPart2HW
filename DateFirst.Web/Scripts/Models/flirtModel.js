var flirtModel = (function () {

    function getFlirtsCount(id) {
        return jsonRequester.get("http://localhost:9941/api/UserProfiles/" + id, {
            headers: { 'Authorization': modelHelpers.getBearerCode() }
        })
    }

    function updateFlirtsCount(data) {
        return jsonRequester.put("http://localhost:9941/api/Flirts", {
            data: JSON.stringify(data),
            headers: { 'Authorization': modelHelpers.getBearerCode() },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                toastr.error(err.Message)
            }
        })
        .then(function (res) {
            return res;
        });
    }

    return {
        getFlirtsCount: getFlirtsCount,
        updateFlirtsCount: updateFlirtsCount
    };

}());

