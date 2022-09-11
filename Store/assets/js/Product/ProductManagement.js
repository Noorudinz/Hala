var rootURL = "https://localhost:44366/";

function getUrlVars() {
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < hashes.length; i++) {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}

$(document).ready(function () {

    //var productId = getUrlVars()["product"];

    //$.ajax({
    //    type: "POST",
    //    url: "Product.asmx/ProductDetails",
    //    data: JSON.stringify({ 'productId': productId }),
    //    contenttype: 'application/json; charset=utf-8',
    //    datatype: 'json',
    //    success: function (response) {
    //        console.log(response.result);

    //        //var prodList = response.result.on_Sale_ProductList;

    //    },
    //    error: function () {
    //        alert('error');
    //    }
    //});

});