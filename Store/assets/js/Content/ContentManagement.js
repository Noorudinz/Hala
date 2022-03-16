
var rootURL = "https://localhost:44366/";

$(document).ready(function () {
    //alert('0');

    $.ajax({
        type: "get",
        url: rootURL + "api/content/FetchHomeMainBanner/BOTTOM_BANNER",
        data: '',
        contenttype: 'application/json; charset=utf-8',
        datatype: 'json',
        success: function (response) {            
            $('#bottomBanner').html(response.result.content);
        },
        error: function () {
            alert('error');
        }
    });

});