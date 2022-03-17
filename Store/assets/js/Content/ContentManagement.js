
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

    $.ajax({
        type: "get",
        url: rootURL + "api/content/FetchOnSales/ON_SALES_PRODUCT",
        data: '',
        contenttype: 'application/json; charset=utf-8',
        datatype: 'json',
        success: function (response) {
            console.log(response.result.on_Sale_ProductList);

            var prodList = response.result.on_Sale_ProductList;
            
            var prodCount = response.result.on_Sale_ProductList.length;
            for (i = 0; i < prodCount; i++) {
                $('#ulSalesProductList').append('<li class="col-6 col-md-4 col-lg-3 col-xl product-item">' +
                    '<div class= "product-item__outer h-100" >' +
                    '<div class="product-item__inner px-xl-4 p-3">' +
                    '<div class="product-item__body pb-xl-2">' +
                    '<div class="mb-2"><a href="#" class="font-size-12 text-gray-5">' + prodList[i].category_Name +'</a></div>' +
                    '<h5 class="mb-1 product-item__title"><a href="#" class="text-blue font-weight-bold">' + prodList[i].product_Name +'</a></h5>' +
                    '<div class="mb-2"> <a href="ProductDetail.aspx" class="d-block text-center">' +
                    '<img class="img-fluid" src="' + prodList[i].product_Image +'" alt="image description"></a></div>' +
                    '<div class="flex-center-between mb-1"> <div class="prodcut-price"> <div class="text-gray-100">₹' + prodList[i].product_Price +'</div>' +
                    '</div> </div>  </div>  <div class="product-item__footer"> </div>' +
                    '</div> </div> </li>');
            }
        },
        error: function () {
            alert('error');
        }
    });

});