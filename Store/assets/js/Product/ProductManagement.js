
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

    var productId = getUrlVars()["product"];

    $.ajax({
        type: "get",
        url: rootURL + "api/customer/GetProductDetailsByProductId/" + productId,
        data: '',
        contenttype: 'application/json; charset=utf-8',
        datatype: 'json',
        success: function (response) {

            var prodList = response.result;

            $('#category').text(prodList.category_Name);
            $('#subcategory').text(prodList.subCategory_Name);
            $('#product').text(prodList.product_Name);
        },
        error: function () {
            alert('error');
        }
    });
});