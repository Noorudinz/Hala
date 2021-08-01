﻿<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Store.ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- ========== MAIN CONTENT ========== -->
    <main id="content" role="main">
        <!-- breadcrumb -->
        <div class="bg-gray-13 bg-md-transparent">
            <div class="container">
                <!-- breadcrumb -->
                <div class="my-md-3">
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb mb-3 flex-nowrap flex-xl-wrap overflow-auto overflow-xl-visble">
                            <li class="breadcrumb-item flex-shrink-0 flex-xl-shrink-1"><a href="Home.aspx">Electronics</a></li>
                            <li class="breadcrumb-item flex-shrink-0 flex-xl-shrink-1"><a href="../shop/shop.html">Headphones</a></li>
                            <li class="breadcrumb-item flex-shrink-0 flex-xl-shrink-1 active" aria-current="page">Ultra Wireless S50 Headphones S50 with Bluetooth</li>
                        </ol>
                    </nav>
                </div>
                <!-- End breadcrumb -->
            </div>
        </div>
        <!-- End breadcrumb -->
        <div class="container">

                  <div class="mb-14">
                    <div class="row">
                        <div class="col-md-6 col-lg-4 col-xl-5 mb-4 mb-md-0">
                            <div id="sliderSyncingNav" class="js-slick-carousel u-slick mb-2"
                                data-infinite="true"
                                data-arrows-classes="d-none d-lg-inline-block u-slick__arrow-classic u-slick__arrow-centered--y rounded-circle"
                                data-arrow-left-classes="fas fa-arrow-left u-slick__arrow-classic-inner u-slick__arrow-classic-inner--left ml-lg-2 ml-xl-4"
                                data-arrow-right-classes="fas fa-arrow-right u-slick__arrow-classic-inner u-slick__arrow-classic-inner--right mr-lg-2 mr-xl-4"
                                data-nav-for="#sliderSyncingThumb">
                                <div class="js-slide">
                                    <img class="img-fluid" src="../../assets/img/720X660/img1.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide">
                                    <img class="img-fluid" src="../../assets/img/720X660/img2.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide">
                                    <img class="img-fluid" src="../../assets/img/720X660/img3.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide">
                                    <img class="img-fluid" src="../../assets/img/720X660/img4.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide">
                                    <img class="img-fluid" src="../../assets/img/720X660/img5.jpg" alt="Image Description">
                                </div>
                            </div>

                            <div id="sliderSyncingThumb" class="js-slick-carousel u-slick u-slick--slider-syncing u-slick--slider-syncing-size u-slick--gutters-1 u-slick--transform-off"
                                data-infinite="true"
                                data-slides-show="5"
                                data-is-thumbs="true"
                                data-nav-for="#sliderSyncingNav">
                                <div class="js-slide" style="cursor: pointer;">
                                    <img class="img-fluid" src="../../assets/img/720X660/img1.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide" style="cursor: pointer;">
                                    <img class="img-fluid" src="../../assets/img/720X660/img2.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide" style="cursor: pointer;">
                                    <img class="img-fluid" src="../../assets/img/720X660/img3.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide" style="cursor: pointer;">
                                    <img class="img-fluid" src="../../assets/img/720X660/img4.jpg" alt="Image Description">
                                </div>
                                <div class="js-slide" style="cursor: pointer;">
                                    <img class="img-fluid" src="../../assets/img/720X660/img5.jpg" alt="Image Description">
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-lg-4 col-xl-4 mb-md-6 mb-lg-0">
                            <div class="mb-2">
                                <a href="#" class="font-size-12 text-gray-5 mb-2 d-inline-block">Headphones</a>
                                <h2 class="font-size-25 text-lh-1dot2">Ultra Wireless S50 Headphones S50 with Bluetooth</h2>
                                <div class="mb-2">
                                    <a class="d-inline-flex align-items-center small font-size-15 text-lh-1" href="#">
                                        <div class="text-warning mr-2">
                                            <small class="fas fa-star"></small>
                                            <small class="fas fa-star"></small>
                                            <small class="fas fa-star"></small>
                                            <small class="fas fa-star"></small>
                                            <small class="far fa-star text-muted"></small>
                                        </div>
                                        <span class="text-secondary font-size-13">(3 customer reviews)</span>
                                    </a>
                                </div>
                                <a href="#" class="d-inline-block max-width-150 ml-n2 mb-2"><img class="img-fluid" src="../../assets/img/200X60/img1.png" alt="Image Description"></a>
                                <div class="mb-2">
                                    <ul class="font-size-14 pl-3 ml-1 text-gray-110">
                                        <li>4.5 inch HD Touch Screen (1280 x 720)</li>
                                        <li>Android 4.4 KitKat OS</li>
                                        <li>1.4 GHz Quad Core™ Processor</li>
                                        <li>20 MP Electro and 28 megapixel CMOS rear camera</li>
                                    </ul>
                                </div>
                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt.</p>
                                <p><strong>SKU</strong>: FW511948218</p>
                            </div>
                        </div>
                        <div class="mx-md-auto mx-lg-0 col-md-6 col-lg-4 col-xl-3">
                            <div class="mb-2">
                                <div class="card p-5 border-width-2 border-color-1 borders-radius-17">
                                    <div class="text-gray-9 font-size-14 pb-2 border-color-1 border-bottom mb-3">Availability: <span class="text-green font-weight-bold">26 in stock</span></div>
                                    <div class="mb-3">
                                        <div class="font-size-36">$685.00</div>
                                    </div>
                                    <div class="mb-3">
                                        <h6 class="font-size-14">Quantity</h6>
                                        <!-- Quantity -->                                   
                                                 <select id="selectQty" class="js-select selectpicker dropdown-select btn-block col-12 px-0"
                                                         data-style="btn-sm bg-white font-weight-normal py-2 border">
                                                        <option value="1" selected>1</option>
                                                        <option value="2">2</option>
                                                        <option value="3">3</option>
                                                </select>                                               
                                        <!-- End Quantity -->
                                    </div>
                                    <div class="mb-3">
                                        <h6 class="font-size-14">Color</h6>
                                        <!-- Select -->
                                        <select class="js-select selectpicker dropdown-select btn-block col-12 px-0"
                                            data-style="btn-sm bg-white font-weight-normal py-2 border">
                                            <option value="one" selected>White with Gold</option>
                                            <option value="two">Red</option>
                                            <option value="three">Green</option>
                                            <option value="four">Blue</option>
                                        </select>                                   
                                        <!-- End Select -->
                                    </div>
                                    <div class="mb-2 pb-0dot5">
                                        <button type="button" onclick="addToCart()" class="btn btn-block btn-primary-dark"><i class="ec ec-add-to-cart mr-2 font-size-20"></i> Add to Cart</button>                                     
                                    </div>
                                    <div class="mb-3">
                                        <a href="Checkout.aspx" class="btn btn-block btn-dark">Buy Now</a>
                                    </div>
                                    <%--<div class="flex-content-center flex-wrap">
                                        <a href="#" class="text-gray-6 font-size-13 mr-2"><i class="ec ec-favorites mr-1 font-size-15"></i> Wishlist</a>
                                        <a href="#" class="text-gray-6 font-size-13 ml-2"><i class="ec ec-compare mr-1 font-size-15"></i> Compare</a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End Single Product Body -->


         
               
         </div>
            <!-- End Single Product Body -->
            <!-- Single Product Tab -->
            <div class="mb-8">
                <div class="position-relative position-md-static px-md-6">
                    <ul class="nav nav-classic nav-tab nav-tab-lg justify-content-xl-center flex-nowrap flex-xl-wrap overflow-auto overflow-xl-visble border-0 pb-1 pb-xl-0 mb-n1 mb-xl-0" id="pills-tab-8" role="tablist">
                        <!--<li class="nav-item flex-shrink-0 flex-xl-shrink-1 z-index-2">
                            <a class="nav-link active" id="Jpills-one-example1-tab" data-toggle="pill" href="#Jpills-one-example1" role="tab" aria-controls="Jpills-one-example1" aria-selected="true">Accessories</a>
                        </li>-->
                        <li class="nav-item flex-shrink-0 flex-xl-shrink-1 z-index-2">
                            <a class="nav-link active" id="Jpills-two-example1-tab" data-toggle="pill" href="#Jpills-two-example1" role="tab" aria-controls="Jpills-two-example1" aria-selected="true">Description</a>
                        </li>
                        <li class="nav-item flex-shrink-0 flex-xl-shrink-1 z-index-2">
                            <a class="nav-link" id="Jpills-three-example1-tab" data-toggle="pill" href="#Jpills-three-example1" role="tab" aria-controls="Jpills-three-example1" aria-selected="false">Specification</a>
                        </li>
                        <li class="nav-item flex-shrink-0 flex-xl-shrink-1 z-index-2">
                            <a class="nav-link" id="Jpills-four-example1-tab" data-toggle="pill" href="#Jpills-four-example1" role="tab" aria-controls="Jpills-four-example1" aria-selected="false">Reviews</a>
                        </li>
                    </ul>
                </div>
                <!-- Tab Content -->
                <div class="borders-radius-17 border p-4 mt-4 mt-md-0 px-lg-10 py-lg-9">
                    <div class="tab-content" id="Jpills-tabContent">

                        <div class="tab-pane fade active show" id="Jpills-two-example1" role="tabpanel" aria-labelledby="Jpills-two-example1-tab">
                            <h3 class="font-size-24 mb-3">Perfectly Done</h3>
                            <p>Praesent ornare, ex a interdum consectetur, lectus diam sodales elit, vitae egestas est enim ornare nisl. Nullam in lectus nec sem semper viverra. In lobortis egestas massa. Nam nec massa nisi. Suspendisse potenti. Quisque suscipit vulputate dui quis volutpat. Ut id elit facilisis, feugiat est in, tempus lacus. Ut ultrices dictum metus, a ultricies ex vulputate ac. Ut id cursus tellus, non tempor quam. Morbi porta diam nisi, id finibus nunc tincidunt eu.</p>
                        </div>
                        <div class="tab-pane fade" id="Jpills-three-example1" role="tabpanel" aria-labelledby="Jpills-three-example1-tab">
                            <div class="mx-md-5 pt-1">
                                <div class="table-responsive mb-4">
                                    <table class="table table-hover">
                                        <tbody>
                                            <tr>
                                                <th class="px-4 px-xl-5 border-top-0">Weight</th>
                                                <td class="border-top-0">7.25kg</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Dimensions</th>
                                                <td>90 x 60 x 90 cm</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Size</th>
                                                <td>One Size Fits all</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">color</th>
                                                <td>Black with Red, White with Gold</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Guarantee</th>
                                                <td>5 years</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <h3 class="font-size-18 mb-4">Technical Specifications</h3>
                                <div class="table-responsive">
                                    <table class="table table-hover">
                                        <tbody>
                                            <tr>
                                                <th class="px-4 px-xl-5 border-top-0">Brand</th>
                                                <td class="border-top-0">Apple</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Item Height</th>
                                                <td>18 Millimeters</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Item Width</th>
                                                <td>31.4 Centimeters</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Screen Size</th>
                                                <td>13 Inches</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Item Weight</th>
                                                <td>1.6 Kg</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Product Dimensions</th>
                                                <td>21.9 x 31.4 x 1.8 cm</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Item model number</th>
                                                <td>MF841HN/A</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Processor Brand</th>
                                                <td>Intel</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Processor Type</th>
                                                <td>Core i5</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Processor Speed</th>
                                                <td>2.9 GHz</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">RAM Size</th>
                                                <td>8 GB</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Hard Drive Size</th>
                                                <td>512 GB</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Hard Disk Technology</th>
                                                <td>Solid State Drive</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Graphics Coprocessor</th>
                                                <td>Intel Integrated Graphics</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Graphics Card Description</th>
                                                <td>Integrated Graphics Card</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Hardware Platform</th>
                                                <td>Mac</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Operating System</th>
                                                <td>Mac OS</td>
                                            </tr>
                                            <tr>
                                                <th class="px-4 px-xl-5">Average Battery Life (in hours)</th>
                                                <td>9</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div class="tab-pane fade" id="Jpills-four-example1" role="tabpanel" aria-labelledby="Jpills-four-example1-tab">
                            <div class="row mb-8">
                                <div class="col-md-6">
                                    <div class="mb-3">
                                        <h3 class="font-size-18 mb-6">Based on 3 reviews</h3>
                                        <h2 class="font-size-30 font-weight-bold text-lh-1 mb-0">4.3</h2>
                                        <div class="text-lh-1">overall</div>
                                    </div>

                                    <!-- Ratings -->
                                    <ul class="list-unstyled">
                                        <li class="py-1">
                                            <a class="row align-items-center mx-gutters-2 font-size-1" href="javascript:;">
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </div>
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="progress ml-xl-5" style="height: 10px; width: 200px;">
                                                        <div class="progress-bar" role="progressbar" style="width: 100%;" aria-valuenow="100" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                                <div class="col-auto text-right">
                                                    <span class="text-gray-90">205</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li class="py-1">
                                            <a class="row align-items-center mx-gutters-2 font-size-1" href="javascript:;">
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </div>
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="progress ml-xl-5" style="height: 10px; width: 200px;">
                                                        <div class="progress-bar" role="progressbar" style="width: 53%;" aria-valuenow="53" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                                <div class="col-auto text-right">
                                                    <span class="text-gray-90">55</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li class="py-1">
                                            <a class="row align-items-center mx-gutters-2 font-size-1" href="javascript:;">
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                                        <small class="fas fa-star"></small>
                                                        <small class="fas fa-star"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </div>
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="progress ml-xl-5" style="height: 10px; width: 200px;">
                                                        <div class="progress-bar" role="progressbar" style="width: 20%;" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                                <div class="col-auto text-right">
                                                    <span class="text-gray-90">23</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li class="py-1">
                                            <a class="row align-items-center mx-gutters-2 font-size-1" href="javascript:;">
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                                        <small class="fas fa-star"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </div>
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="progress ml-xl-5" style="height: 10px; width: 200px;">
                                                        <div class="progress-bar" role="progressbar" style="width: 0%;" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                                <div class="col-auto text-right">
                                                    <span class="text-muted">0</span>
                                                </div>
                                            </a>
                                        </li>
                                        <li class="py-1">
                                            <a class="row align-items-center mx-gutters-2 font-size-1" href="javascript:;">
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                                        <small class="fas fa-star"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </div>
                                                <div class="col-auto mb-2 mb-md-0">
                                                    <div class="progress ml-xl-5" style="height: 10px; width: 200px;">
                                                        <div class="progress-bar" role="progressbar" style="width: 1%;" aria-valuenow="1" aria-valuemin="0" aria-valuemax="100"></div>
                                                    </div>
                                                </div>
                                                <div class="col-auto text-right">
                                                    <span class="text-gray-90">4</span>
                                                </div>
                                            </a>
                                        </li>
                                    </ul>
                                    <!-- End Ratings -->
                                </div>
                                <div class="col-md-6">
                                    <h3 class="font-size-18 mb-5">Add a review</h3>
                                    <!-- Form -->
                                    <div class="js-validate">
                                        <div class="row align-items-center mb-4">
                                            <div class="col-md-4 col-lg-3">
                                                <label for="rating" class="form-label mb-0">Your Review</label>
                                            </div>
                                            <div class="col-md-8 col-lg-9">
                                                <a href="#" class="d-block">
                                                    <div class="text-warning text-ls-n2 font-size-16">
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                        <small class="far fa-star text-muted"></small>
                                                    </div>
                                                </a>
                                            </div>
                                        </div>
                                        <div class="js-form-message form-group mb-3 row">
                                            <div class="col-md-4 col-lg-3">
                                                <label for="descriptionTextarea" class="form-label">Your Review</label>
                                            </div>
                                            <div class="col-md-8 col-lg-9">
                                                <textarea class="form-control" rows="3" id="descriptionTextarea"
                                                    data-msg="Please enter your message."
                                                    data-error-class="u-has-error"
                                                    data-success-class="u-has-success"></textarea>
                                            </div>
                                        </div>
                                        <div class="js-form-message form-group mb-3 row">
                                            <div class="col-md-4 col-lg-3">
                                                <label for="inputName" class="form-label">Name <span class="text-danger">*</span></label>
                                            </div>
                                            <div class="col-md-8 col-lg-9">
                                                <input type="text" class="form-control" name="name" id="inputName" aria-label="Alex Hecker" required
                                                    data-msg="Please enter your name."
                                                    data-error-class="u-has-error"
                                                    data-success-class="u-has-success">
                                            </div>
                                        </div>
                                        <div class="js-form-message form-group mb-3 row">
                                            <div class="col-md-4 col-lg-3">
                                                <label for="emailAddress" class="form-label">Email <span class="text-danger">*</span></label>
                                            </div>
                                            <div class="col-md-8 col-lg-9">
                                                <input type="email" class="form-control" name="emailAddress" id="emailAddress" aria-label="alexhecker@pixeel.com" required
                                                    data-msg="Please enter a valid email address."
                                                    data-error-class="u-has-error"
                                                    data-success-class="u-has-success">
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="offset-md-4 offset-lg-3 col-auto">
                                                <button type="submit" class="btn btn-primary-dark btn-wide transition-3d-hover">Add Review</button>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- End Form -->
                                </div>
                            </div>
                            <!-- Review -->
                            <div class="border-bottom border-color-1 pb-4 mb-4">
                                <!-- Review Rating -->
                                <div class="d-flex justify-content-between align-items-center text-secondary font-size-1 mb-2">
                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="far fa-star text-muted"></small>
                                        <small class="far fa-star text-muted"></small>
                                    </div>
                                </div>
                                <!-- End Review Rating -->

                                <p class="text-gray-90">Fusce vitae nibh mi. Integer posuere, libero et ullamcorper facilisis, enim eros tincidunt orci, eget vestibulum sapien nisi ut leo. Cras finibus vel est ut mollis. Donec luctus condimentum ante et euismod.</p>

                                <!-- Reviewer -->
                                <div class="mb-2">
                                    <strong>John Doe</strong>
                                    <span class="font-size-13 text-gray-23">- April 3, 2019</span>
                                </div>
                                <!-- End Reviewer -->
                            </div>
                            <!-- End Review -->
                            <!-- Review -->
                            <div class="border-bottom border-color-1 pb-4 mb-4">
                                <!-- Review Rating -->
                                <div class="d-flex justify-content-between align-items-center text-secondary font-size-1 mb-2">
                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                    </div>
                                </div>
                                <!-- End Review Rating -->

                                <p class="text-gray-90">Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Suspendisse eget facilisis odio. Duis sodales augue eu tincidunt faucibus. Etiam justo ligula, placerat ac augue id, volutpat porta dui.</p>

                                <!-- Reviewer -->
                                <div class="mb-2">
                                    <strong>Anna Kowalsky</strong>
                                    <span class="font-size-13 text-gray-23">- April 3, 2019</span>
                                </div>
                                <!-- End Reviewer -->
                            </div>
                            <!-- End Review -->
                            <!-- Review -->
                            <div class="pb-4">
                                <!-- Review Rating -->
                                <div class="d-flex justify-content-between align-items-center text-secondary font-size-1 mb-2">
                                    <div class="text-warning text-ls-n2 font-size-16" style="width: 80px;">
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="fas fa-star"></small>
                                        <small class="far fa-star text-muted"></small>
                                    </div>
                                </div>
                                <!-- End Review Rating -->

                                <p class="text-gray-90">Sed id tincidunt sapien. Pellentesque cursus accumsan tellus, nec ultricies nulla sollicitudin eget. Donec feugiat orci vestibulum porttitor sagittis.</p>

                                <!-- Reviewer -->
                                <div class="mb-2">
                                    <strong>Peter Wargner</strong>
                                    <span class="font-size-13 text-gray-23">- April 3, 2019</span>
                                </div>
                                <!-- End Reviewer -->
                            </div>
                            <!-- End Review -->
                        </div>
                    </div>
                </div>
                <!-- End Tab Content -->
            </div>
            <!-- End Single Product Tab -->
            <!-- Related products -->
            <div class="mb-6">
                <div class="d-flex justify-content-between align-items-center border-bottom border-color-1 flex-lg-nowrap flex-wrap mb-4">
                    <h3 class="section-title mb-0 pb-2 font-size-22">Related products</h3>
                </div>
                <ul class="row list-unstyled products-group no-gutters">
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item">
                        <div class="product-item__outer h-100">
                            <div class="product-item__inner px-xl-4 p-3">
                                <div class="product-item__body pb-xl-2">
                                    <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                    <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Wireless Audio System Multiroom 360 degree Full base audio</a></h5>
                                    <div class="mb-2">
                                        <a href="ProductDetail.aspx" class="d-block text-center">
                                            <img class="img-fluid" src="../../assets/img/212X200/img1.jpg" alt="Image Description"></a>
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
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item">
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
                                            <del class="font-size-12 tex-gray-6 position-absolute bottom-100">₹2 299,00</del>
                                        </div>
                                      <%--  <div class="d-none d-xl-block prodcut-add-cart">
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
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item">
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
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item remove-divider-md-lg">
                        <div class="product-item__outer h-100">
                            <div class="product-item__inner px-xl-4 p-3">
                                <div class="product-item__body pb-xl-2">
                                    <div class="mb-2"><a href="#" class="font-size-12 text-gray-5">Speakers</a></div>
                                    <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Smartphone 6S 32GB LTE</a></h5>
                                    <div class="mb-2">
                                        <a href="ProductDetail.aspx" class="d-block text-center">
                                            <img class="img-fluid" src="../../assets/img/212X200/img4.jpg" alt="Image Description"></a>
                                    </div>
                                    <div class="flex-center-between mb-1">
                                        <div class="prodcut-price">
                                            <div class="text-gray-100">₹685,00</div>
                                        </div>
                                      <%--  <div class="d-none d-xl-block prodcut-add-cart">
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
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item remove-divider-xl">
                        <div class="product-item__outer h-100">
                            <div class="product-item__inner px-xl-4 p-3">
                                <div class="product-item__body pb-xl-2">
                                    <div class="mb-2"><a href="../shop/product-categories-7-column-full-width.html" class="font-size-12 text-gray-5">Speakers</a></div>
                                    <h5 class="mb-1 product-item__title"><a href="ProductDetail.aspx" class="text-blue font-weight-bold">Widescreen NX Mini F1 SMART NX</a></h5>
                                    <div class="mb-2">
                                        <a href="../shop/single-product-fullwidth.html" class="d-block text-center">
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
                    <li class="col-6 col-md-3 col-xl-2gdot4-only col-wd-2 product-item remove-divider-wd d-xl-none d-wd-block">
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
                                            <del class="font-size-12 tex-gray-6 position-absolute bottom-100">₹2 299,00</del>
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
                </ul>
            </div>
            <!-- End Related products -->
            <!-- Brand Carousel -->
            <!-- End Brand Carousel -->
        <%--</div>--%>
    </main>
    <!-- ========== END MAIN CONTENT ========== -->
        
</asp:Content>