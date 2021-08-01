
//On Page Load sign in or not 
$(document).ready(function () {  
   
    $('#lstSignIn').hide();
    $('#lstCustomerName').hide();

    $.ajax({
        type: "POST",
        url: "MyAccountServices.asmx/LoginService",
        data: '',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
           // console.log(response);
            if (response != null && response.d != null) {
                var parsed_data = JSON.parse(response.d);
                
                if (parsed_data.userName != null && parsed_data.userName.length != 0) {
                    $('#lstSignIn').hide();
                    $('#lstCustomerName').show();
                    $('#HomeMegaMenu').text(parsed_data.userName);
                }
                else {                   
                    $('#lstSignIn').show();
                    $('#lstCustomerName').hide();
                }
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


$(document).ready(function () {    

    //Sign In
    $('#btnLogin').on('click', function () {

        var email = $('#signinEmail').val();
        var pswd = $('#signinPassword').val();

        if (email.length != 0 &&
            pswd.length != 0) {

            $.ajax({
                type: "POST",
                url: "MyAccountServices.asmx/Login",
                data: JSON.stringify({ 'emailId': email, 'password': pswd }),
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (response) {
                    if (response != null && response.d != null) {  
                        var parsed_data = JSON.parse(response.d);
                        //alert(JSON.stringify(parsed_data.msg));
                        //alert(JSON.stringify(parsed_data.IsAvail));
                        if (parsed_data.IsAvail) {                            
                            $('#lstSignIn').hide();
                            $('#lstCustomerName').show();
                            $('#HomeMegaMenu').text(parsed_data.msg);
                            $('#closeSideBar').click();
                            Message.add('Loged Successfully  !', { type: 'success' });
                        }
                        else {
                            $('#pLogInMessage').text(parsed_data.msg);
                            $('#pLogInMessage').css({ "color": "red" });
                        }
                        
                    }
                },
                error: function () {
                    alert('error');
                }
            });
        }
        else {            
            $('#pLogInMessage').css({ "color": "red" });
        }
    });

    //Sign up
    $('#btnSignUp').on('click', function (e) {
       
        e.preventDefault();


        var signUp = {
            CustomerName: $('#signupUserName').val(),
            Email: $('#signupEmail').val(),
            Password: $('#signupConfirmPassword').val()
        }

        var password = $('#signupPassword').val();

        if (signUp.CustomerName.length != 0 &&
            signUp.Email.length != 0 &&
            signUp.Password.length != 0 &&
            password.length != 0) {

            if (validateEmail(signUp.Email)) {

                if (signUp.Password === password) {

                    $.ajax({
                        type: "POST",
                        url: "MyAccountServices.asmx/SignUp",
                        data: JSON.stringify({ signUpJson: signUp }),
                        contentType: 'application/json; charset=utf-8',
                        dataType: 'json',
                        success: function (response) {
                            if (response != null && response.d != null) {
                                var parsed_data = JSON.parse(response.d);
                                if (parsed_data.IsAvail) {                               
                                    $('#lstSignIn').hide();
                                    $('#lstCustomerName').show();
                                    $('#HomeMegaMenu').text(parsed_data.msg);
                                    $('#closeSideBar').click();
                                    Message.add('SignUp Successfully  !', { type: 'success' });
                                }                              
                            }
                        },
                        error: function () {
                            Message.add('Something went wrong  !', { type: 'error' });
                        }
                    });
                }

            }

        }
        else {
            $('#pSignUpMessage').css({ "color": "red" });
        }

    });

    //Recover Password
    $('#btnRecoverPassword').on('click', function () {
       
        var email = $('#recoverEmail').val();       

        if (email.length != 0 && validateEmail(email)) {

            $.ajax({
                type: "POST",
                url: "MyAccountServices.asmx/Recover",
                data: JSON.stringify({ 'emailId': email }),
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (response) {     
                  
                    if (response != null && response.d != null) {
                        var parsed_data = JSON.parse(response.d);
                      
                        if (parsed_data.IsSent) {
                            Message.add('Password Sent. Please check your mail  !', { type: 'success' });
                            $('#closeSideBar').click();
                        }
                        else {
                            Message.add("Email doesn't exist !", { type: 'error' });
                            $('#closeSideBar').click();
                        }                   

                    }
                },
                error: function () {
                    alert('error');
                }
            });
        }
        else {
            Message.add("Invalid email id !", { type: 'error' });
        }
    });
});

//Email Validation
function validateEmail(email) {
    var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
    if (!emailReg.test(email)) {
        return false;
    } else {
        return true;
    }
}

//LogOut
function LogOut() {
    document.cookie = 'HALAOnlineUserInfo =; Path=/; Expires=Thu, 01 Jan 1970 00:00:01 GMT;';    
    $('#lstSignIn').show();
    $('#lstCustomerName').hide();
    Message.add('Loged Out Successfully  !', { type: 'success' });

}

//function checkQueryStringExists() {
//    var vars = [], hash;
//    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
//    if (hashes.length > 0)
//        alert(1); //return true;
//    else
//        alert(0); // return false;
//}



