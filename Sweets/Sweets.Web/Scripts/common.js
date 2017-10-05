this.showPopup = function (url, callback) {
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            $(".modal-backdrop").remove();
            var popupWrapper = $("#PopupWrapper");
            popupWrapper.empty();
            popupWrapper.html(data);
            var popup = $(".modal", popupWrapper);
            $(".modal", popupWrapper).modal();
            callback(popup);
        }
    });
}