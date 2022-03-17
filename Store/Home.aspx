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

            <div id="bottomBanner">
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
                        <ul class="row list-unstyled products-group no-gutters" id="ulSalesProductList">
                           
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
