

$(document).ready(function () {

    $.ajax({
        type: "POST",
        url: "MyAccountServices.asmx/HomeBanner",
        data: JSON.stringify({ 'type': 'HOME_MAIN_BANNER' }),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
           
            if (response != null && response.d != null) {
                var parsed_data = JSON.parse(response.d);
                $('#HomeBanner').html(parsed_data);
                //alert(parsed_data);

                //if (parsed_data.userName != null && parsed_data.userName.length != 0) {
                //    $('#lstSignIn').hide();
                //    $('#lstCustomerName').show();
                //    $('#HomeMegaMenu').text(parsed_data.userName);
                //}
                //else {
                //    $('#lstSignIn').show();
                //    $('#lstCustomerName').hide();
                //}
            }
            else {
                $('#lstSignIn').show();
                $('#lstCustomerName').hide();
            }
        },
        error: function () {
            alert('error');
        }
    });

    });