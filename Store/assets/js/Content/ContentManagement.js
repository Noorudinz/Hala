

$(document).ready(function () {

    $.ajax({
        type: "POST",
        url: "MyAccountServices.asmx/HomeBanner",
        data: JSON.stringify({ 'type': 'HOME_MAIN_BANNER' }),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
            alert(1);
            if (response != null && response.d != null) {
                var parsed_data = JSON.parse(response.d);
                alert(parsed_data);
                $('#HomeBanner').html(parsed_data);
                
            }
        
        },
        error: function () {
            alert('error');
        }
    });

    });