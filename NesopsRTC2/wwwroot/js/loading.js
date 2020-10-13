function showLoadingScreen(second) {
    if (second == null) {
        second = 0;
    }
    setTimeout(function () {
        $body.addClass("loading");
    }, second);
}
function hideLoadingScreen(second) {
    if (second == null) {
        second = 100;
    }
    setTimeout(function () {
        $body.removeClass("loading");
    }, second);
}
$body = $("body");
$(document).ajaxSend(function () {
    showLoadingScreen()
});
$(document).ajaxComplete(function () {
    hideLoadingScreen()
});
document.onreadystatechange = function () {
    var state = document.readyState
    if (state == 'complete') {
        setTimeout(function () {
            document.getElementById('interactive');
            document.getElementById('pre-load-page').style.visibility = "hidden";
        }, 100);
    }
}
