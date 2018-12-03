var ajax_call = function (ID) {
    document.getElementById('ajaxArea').innerHTML = null;

    var URL = "/Home/ItemDetails/" + ID;

    $ajax({
        type: "GET",
        dataType: "json",
        url: URL,
        success: function () {

        },
        error: errorOnAjax
    });
};

var interval = 1000 * 5;

window.setInterval(ajax_call, interval);