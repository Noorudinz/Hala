

function addToCart() {
   
    $.ajax({
        type: "POST",
        url: "ProductDetail.aspx/GetReport",
        data: '{skuId: "' + $('#skuID').html() + '", qty: "' + $('#selectQty').find(":selected").text() + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {            
            if (response != null && response.d != null) {                                    
                var parsed_data = JSON.parse(response.d);  
                //alert((parsed_data.amt).toFixed(2));
                $('#spnCartItem').html(parsed_data.qty);                
                $('#spnCartAmount').html("₹" + (parsed_data.amt).toFixed(2));
            }
        },
        error: function () {
            alert('error');
        }
    });
}

function removeCartItem(v) {

       $.ajax({
        type: "POST",
        url: "Cart.aspx/RemoveItemFromCart",
        data: '{productId: "' + v + '" }',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
            if (response != null && response.d != null) {
                var parsed_data = JSON.parse(response.d);     
                Message.add('Item removed !', { type: 'success' });
                //$('#hdrRem').html("Removed");
                //$('#spnCartAmount').html("₹" + (parsed_data.amt).toFixed(2));
            }
        },
        error: function () {
            alert('error');
        }
    });
}


//function removeCartItem() {
//    alert(1);

//    $.ajax({
//        type: "POST",
//        url: "Cart.aspx/RemoveItemFromCart",
//        data: '{productId: "1001" }',
//        contentType: 'application/json; charset=utf-8',
//        dataType: 'json',
//        success: function (response) {
//            if (response != null && response.d != null) {
//                //var parsed_data = JSON.parse(response.d);              
//                //$('#spnCartItem').html(parsed_data.qty);
//                //$('#spnCartAmount').html("₹" + (parsed_data.amt).toFixed(2));
//            }
//        },
//        error: function () {
//            alert('error');
//        }
//    });
//}


