$(document).ready(function () {
    var a = $("[class~='price']");
    $.each(a, function (i, item) {
        a[i].innerHTML = "4000 Lei";
    });
})