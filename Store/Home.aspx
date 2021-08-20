<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Store._Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main id="content" role="main">
        <!-- Slider Section -->
        <div class="mb-5">
            <div class="bg-img-hero overflow-hidden" style="background-image: url(../../assets/img/1920X422/img1.jpg);">
                <div class="container min-height-420 overflow-hidden">
                    <div class="js-slick-carousel u-slick"
                        data-pagi-classes="text-center position-absolute right-0 bottom-0 left-0 u-slick__pagination u-slick__pagination--long justify-content-start mb-3 mb-md-4 offset-xl-3 pl-2 pb-1">
                     
                        <asp:Repeater runat="server" id="HomeBanner">
                            <ItemTemplate>
                                <%#Eval("ContentDetails")%>
                            </ItemTemplate>
                        </asp:Repeater>
                      
                    </div>
                </div>
            </div>
        </div>
        <!-- End Slider Section -->
        <div class="container">
            <!-- Banner -->
            <div class="mb-5">
                <div class="row">
                    <div class="col-md-6 mb-4 mb-xl-0 col-xl-3">
                        <a href="../shop/shop.html" class="d-black text-gray-90">
                            <div class="min-height-132 py-1 d-flex bg-gray-1 align-items-center">
                                <div class="col-6 col-xl-5 col-wd-6 pr-0">
                                    <img class="img-fluid" src="../../assets/img/190X150/img1.png" alt="Image Description">
                                </div>
                                <div class="col-6 col-xl-7 col-wd-6">
                                    <div class="mb-2 pb-1 font-size-18 font-weight-light text-ls-n1 text-lh-23">
                                        CATCH BIG <strong>DEALS</strong> ON THE ELECTRONICS
                                    </div>
                                    <div class="link text-gray-90 font-weight-bold font-size-15" href="#">
                                        Shop now
                                        <span class="link__icon ml-1">
                                            <span class="link__icon-inner"><i class="ec ec-arrow-right-categproes"></i></span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-md-6 mb-4 mb-xl-0 col-xl-3">
                        <a href="../shop/shop.html" class="d-black text-gray-90">
                            <div class="min-height-132 py-1 d-flex bg-gray-1 align-items-center">
                                <div class="col-6 col-xl-5 col-wd-6 pr-0">
                                    <img class="img-fluid" src="../../assets/img/190X150/img2.jpg" alt="Image Description">
                                </div>
                                <div class="col-6 col-xl-7 col-wd-6">
                                    <div class="mb-2 pb-1 font-size-18 font-weight-light text-ls-n1 text-lh-23">
                                        CATCH BIG <strong>DEALS</strong> ON THE WATCHES
                                    </div>
                                    <div class="link text-gray-90 font-weight-bold font-size-15" href="#">
                                        Shop now
                                        <span class="link__icon ml-1">
                                            <span class="link__icon-inner"><i class="ec ec-arrow-right-categproes"></i></span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-md-6 mb-4 mb-xl-0 col-xl-3">
                        <a href="../shop/shop.html" class="d-black text-gray-90">
                            <div class="min-height-132 py-1 d-flex bg-gray-1 align-items-center">
                                <div class="col-6 col-xl-5 col-wd-6 pr-0">
                                    <img class="img-fluid" src="../../assets/img/190X150/img3.jpg" alt="Image Description">
                                </div>
                                <div class="col-6 col-xl-7 col-wd-6">
                                    <div class="mb-2 pb-1 font-size-18 font-weight-light text-ls-n1 text-lh-23">
                                        CATCH BIG <strong>DEALS</strong> ON THE COSMETICS
                                    </div>
                                    <div class="link text-gray-90 font-weight-bold font-size-15" href="#">
                                        Shop now
                                        <span class="link__icon ml-1">
                                            <span class="link__icon-inner"><i class="ec ec-arrow-right-categproes"></i></span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class="col-md-6 mb-4 mb-xl-0 col-xl-3">
                        <a href="../shop/shop.html" class="d-black text-gray-90">
                            <div class="min-height-132 py-1 d-flex bg-gray-1 align-items-center">
                                <div class="col-6 col-xl-5 col-wd-6 pr-0">
                                    <img class="img-fluid" src="../../assets/img/190X150/img4.png" alt="Image Description">
                                </div>
                                <div class="col-6 col-xl-7 col-wd-6">
                                    <div class="mb-2 pb-1 font-size-18 font-weight-light text-ls-n1 text-lh-23">
                                        CATCH BIG <strong>DEALS</strong> ON THE FASHIONS
                                    </div>
                                    <div class="link text-gray-90 font-weight-bold font-size-15" href="#">
                                        Shop now
                                        <span class="link__icon ml-1">
                                            <span class="link__icon-inner"><i class="ec ec-arrow-right-categproes"></i></span>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
            <!-- End Banner -->
        </div>

        <div class="container">
            <!-- Tab Prodcut Section -->
            <div class="mb-6">
                <!-- Nav Classic -->
                <div class="position-relative bg-white text-center z-index-2">
                    <ul class="nav nav-classic nav-tab justify-content-center" id="pills-tab" role="tablist">
                        <li class="nav-item">
                            <a class="nav-link active js-animation-link" id="pills-one-example1-tab" data-toggle="pill" href="#pills-one-example1" role="tab" aria-controls="pills-one-example1" aria-selected="true"
                                data-target="#pills-one-example1"
                                data-link-group="groups"
                                data-animation-in="slideInUp">
                                <div class="d-md-flex justify-content-md-center align-items-md-center">
                                    On Sale
                                </div>
                            </a>
                        </li>

                    </ul>
                </div>
                <!-- End Nav Classic -->
                <!-- Tab Content -->
                <div class="tab-content" id="pills-tabContent">
                    <div class="tab-pane fade pt-2 show active" id="pills-one-example1" role="tabpanel" aria-labelledby="pills-one-example1-tab" data-target-group="groups">
                        <ul class="row list-unstyled products-group no-gutters">
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="#" class="text-blue font-weight-bold">Wireless Audio System Multiroom 360 degree Full base audio</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212x200/img1.jpg" alt="image description"></a>

                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price">
                                                    <div class="text-gray-100">₹685.00</div>
                                                </div>
                                                <%-- <div class="d-none d-xl-block prodcut-add-cart my-cart-btn">
                                                    <a href="#" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Tablet White EliteBook Revolve 810 G2</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img2.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price d-flex align-items-center position-relative">
                                                    <ins class="font-size-20 text-red text-decoration-none">₹1999,00</ins>
                                                    <del class="font-size-12 tex-gray-6 position-absolute bottom-100">₹2299,00</del>
                                                </div>
                                                <%-- <div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item remove-divider-md">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Purple Solo 2 Wireless</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img3.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price">
                                                    <div class="text-gray-100">₹685,00</div>
                                                </div>
                                                <%-- <div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item d-md-none d-lg-block remove-divider-lg">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="ProductDetail.aspx" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h1 class="mb-1 product-item__title"><a href="../shop/single-product-fullwidth.html" class="text-blue font-weight-bold">Smartphone 6S 32GB LTE</a></h1>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img4.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price">
                                                    <div class="text-gray-100">₹685,00</div>
                                                </div>
                                                <%--     <div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item d-md-none d-xl-block">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="../shop/single-product-fullwidth.html" class="text-blue font-weight-bold">Widescreen NX Mini F1 SMART NX</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img5.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price">
                                                    <div class="text-gray-100">₹685,00</div>
                                                </div>
                                                <%-- <div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item d-md-none d-xl-block remove-divider-xl">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Purple Solo 2 Wireless</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img3.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price">
                                                    <div class="text-gray-100">₹685,00</div>
                                                </div>
                                                <%--<div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class="col-6 col-md-4 col-lg-3 col-xl product-item d-md-none d-wd-block remove-divider-wd">
                                <div class="product-item__outer h-100">
                                    <div class="product-item__inner px-xl-4 p-3">
                                        <div class="product-item__body pb-xl-2">
                                            <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                            <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Tablet White EliteBook Revolve 810 G2</a></h5>
                                            <div class="mb-2">
                                                <a href="ProductDetail.aspx" class="d-block text-center">
                                                    <img class="img-fluid" src="../../assets/img/212X200/img2.jpg" alt="Image Description"></a>
                                            </div>
                                            <div class="flex-center-between mb-1">
                                                <div class="prodcut-price d-flex align-items-center position-relative">
                                                    <ins class="font-size-20 text-red text-decoration-none">$1999,00</ins>
                                                    <del class="font-size-12 tex-gray-6 position-absolute bottom-100">$2 299,00</del>
                                                </div>
                                                <%--<div class="d-none d-xl-block prodcut-add-cart">
                                                    <a href="ProductDetail.aspx" class="btn-add-cart btn-primary transition-3d-hover"><i class="ec ec-add-to-cart"></i></a>
                                                </div>--%>
                                            </div>
                                        </div>
                                        <div class="product-item__footer">
                                            <!--<div class="border-top pt-2 flex-center-between flex-wrap">
                                            <a href="../shop/compare.html" class="text-gray-6 font-size-13"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                            <a href="../shop/wishlist.html" class="text-gray-6 font-size-13"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        </div>-->
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>

                </div>
                <!-- End Tab Content -->
            </div>
            <!-- End Tab Prodcut Section -->

            <!-- Feature List -->
            <div class="mb-6 row border rounded-lg mx-0 flex-nowrap flex-xl-wrap overflow-auto overflow-xl-visble">
                <!-- Feature List -->
                <div class="media col px-6 px-xl-4 px-wd-8 flex-shrink-0 flex-xl-shrink-1 min-width-270-all py-3">
                    <div class="u-avatar mr-2">
                        <i class="text-primary ec ec-transport font-size-46"></i>
                    </div>
                    <div class="media-body text-center">
                        <span class="d-block font-weight-bold text-dark">Free Delivery</span>
                        <div class=" text-secondary">from $50</div>
                    </div>
                </div>
                <!-- End Feature List -->

                <!-- Feature List -->
                <div class="media col px-6 px-xl-4 px-wd-8 flex-shrink-0 flex-xl-shrink-1 min-width-270-all border-left py-3">
                    <div class="u-avatar mr-2">
                        <i class="text-primary ec ec-customers font-size-56"></i>
                    </div>
                    <div class="media-body text-center">
                        <span class="d-block font-weight-bold text-dark">99 % Customer</span>
                        <div class=" text-secondary">Feedbacks</div>
                    </div>
                </div>
                <!-- End Feature List -->

                <!-- Feature List -->
                <div class="media col px-6 px-xl-4 px-wd-8 flex-shrink-0 flex-xl-shrink-1 min-width-270-all border-left py-3">
                    <div class="u-avatar mr-2">
                        <i class="text-primary ec ec-returning font-size-46"></i>
                    </div>
                    <div class="media-body text-center">
                        <span class="d-block font-weight-bold text-dark">365 Days</span>
                        <div class=" text-secondary">for free return</div>
                    </div>
                </div>
                <!-- End Feature List -->

                <!-- Feature List -->
                <div class="media col px-6 px-xl-4 px-wd-8 flex-shrink-0 flex-xl-shrink-1 min-width-270-all border-left py-3">
                    <div class="u-avatar mr-2">
                        <i class="text-primary ec ec-payment font-size-46"></i>
                    </div>
                    <div class="media-body text-center">
                        <span class="d-block font-weight-bold text-dark">Payment</span>
                        <div class=" text-secondary">Secure System</div>
                    </div>
                </div>
                <!-- End Feature List -->

                <!-- Feature List -->
                <div class="media col px-6 px-xl-4 px-wd-8 flex-shrink-0 flex-xl-shrink-1 min-width-270-all border-left py-3">
                    <div class="u-avatar mr-2">
                        <i class="text-primary ec ec-tag font-size-46"></i>
                    </div>
                    <div class="media-body text-center">
                        <span class="d-block font-weight-bold text-dark">Only Best</span>
                        <div class=" text-secondary">Brands</div>
                    </div>
                </div>
                <!-- End Feature List -->
            </div>

            <!-- Full banner -->
            <!-- End Full banner -->
        </div>
        <!-- Week Deals limited -->
        <!-- End Week Deals limited -->
        <div class="container">
            <!-- Smartphones & Tablets -->
            <!-- End Smartphones & Tablets -->
            <!-- Music Headphones -->
            <!-- End Music Headphones -->
        </div>
        <!-- Top Categories this Week -->
        <!-- End Top Categories this Week -->
        <div class="container">
            <!-- Laptops & Computers -->
            <!-- End Laptops & Computers -->
            <!-- Home Enternteinment -->
            <!-- End Home Enternteinment -->
        </div>
        <!-- Brand Carousel -->
        <!-- End Brand Carousel -->
    </main>

</asp:Content>
