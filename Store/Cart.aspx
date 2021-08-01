﻿<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Store.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- ========== MAIN CONTENT ========== -->
    <main id="content" role="main" class="cart-page">
        <!-- breadcrumb -->
        <div class="bg-gray-13 bg-md-transparent">
            <div class="container">
                <!-- breadcrumb -->
                <div class="my-md-3">
                    <nav aria-label="breadcrumb">
                        <ol class="breadcrumb mb-3 flex-nowrap flex-xl-wrap overflow-auto overflow-xl-visble">
                            <li class="breadcrumb-item flex-shrink-0 flex-xl-shrink-1"><a href="../home/index.html">Home</a></li>
                            <li class="breadcrumb-item flex-shrink-0 flex-xl-shrink-1 active" aria-current="page">Cart</li>
                        </ol>
                    </nav>
                </div>
                <!-- End breadcrumb -->
            </div>
        </div>
        <!-- End breadcrumb -->

        <div class="container">
            <div class="mb-4">
                <h1 class="text-center">Cart</h1>
            </div>
            <div class="mb-10 cart-table">
                <div class="mb-4">
                    <table class="table" cellspacing="0">
                        <thead>
                            <tr>
                                <th class="product-remove">&nbsp;</th>
                                <th class="product-thumbnail">&nbsp;</th>
                                <th class="product-name">Product</th>
                                <th class="product-price">Price</th>
                                <th class="product-quantity w-lg-15">Quantity</th>
                                <th class="product-subtotal">Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="">
                                <td class="text-center">
                                    <a href="javascript:void(0);" OnClick="removeCartItem('1020')" class="text-gray-32 font-size-26">×</a>
                                </td>
                                <td class="d-none d-md-table-cell">
                                    <a href="#"><img class="img-fluid max-width-100 p-1 border border-color-1" src="../../assets/img/300X300/img6.jpg" alt="Image Description"></a>
                                </td>

                                <td data-title="Product">
                                    <a href="#" class="text-gray-90">Ultra Wireless S50 Headphones S50 with Bluetooth</a>
                                </td>

                                <td data-title="Price">
                                    <span class="">₹1,100.00</span>
                                </td>

                                <td data-title="Quantity">
                                    <span class="sr-only">Quantity</span>
                                    <!-- Quantity -->
                                    <div class="border rounded-pill py-1 width-122 w-xl-80 px-3 border-color-1">
                                        <div class="js-quantity row align-items-center">
                                            <div class="col">
                                                <%--<input class="js-result form-control h-auto border-0 rounded p-0 shadow-none" type="text" value="1">--%>
                                                <span class="">3</span>
                                            </div>
                                           <%-- <div class="col-auto pr-1">
                                                <a class="js-minus btn btn-icon btn-xs btn-outline-secondary rounded-circle border-0" href="javascript:;">
                                                    <small class="fas fa-minus btn-icon__inner"></small>
                                                </a>
                                                <a class="js-plus btn btn-icon btn-xs btn-outline-secondary rounded-circle border-0" href="javascript:;">
                                                    <small class="fas fa-plus btn-icon__inner"></small>
                                                </a>
                                            </div>--%>
                                        </div>
                                    </div>
                                    <!-- End Quantity -->
                                </td>

                                <td data-title="Total">
                                    <span class="">₹1,100.00</span>
                                </td>
                            </tr>
                            <tr class="">
                                <td class="text-center">
                                    <a href="javascript:void(0);" OnClick="removeCartItem('1010')" class="text-gray-32 font-size-26">×</a>
                                </td>
                                <td class="d-none d-md-table-cell">
                                    <a href="#"><img class="img-fluid max-width-100 p-1 border border-color-1" src="../../assets/img/300X300/img7.png" alt="Image Description"></a>
                                </td>

                                <td data-title="Product">
                                    <a href="#" class="text-gray-90">Widescreen NX Mini F1 SMART NX</a>
                                </td>

                                <td data-title="Price">
                                    <span class="">₹685.00</span>
                                </td>

                                <td data-title="Quantity">
                                    <span class="sr-only">Quantity</span>
                                    <!-- Quantity -->
                                    <div class="border rounded-pill py-1 width-122 w-xl-80 px-3 border-color-1">
                                        <div class="js-quantity row align-items-center">
                                            <div class="col">
                                                <span class="">1</span>
                                            </div>                                           
                                        </div>
                                    </div>
                                    <!-- End Quantity -->
                                </td>

                                <td data-title="Total">
                                    <span class="">₹685.00</span>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="6" class="border-top space-top-2 justify-content-center">
                                    <div class="pt-md-3">
                                        <div class="d-block d-md-flex flex-center-between">
                                            <div class="mb-3 mb-md-0 w-xl-40">
                                                <!-- Apply coupon Form -->
                                                <!-- End Apply coupon Form -->
                                            </div>
                                            <div class="d-md-flex">
                                                <button type="button" class="btn btn-soft-secondary mb-3 mb-md-0 font-weight-normal px-5 px-md-4 px-lg-5 w-100 w-md-auto">Update cart</button>
                                                <a href="Checkout.aspx" class="btn btn-primary-dark-w ml-md-2 px-5 px-md-4 px-lg-5 w-100 w-md-auto d-none d-md-inline-block">Proceed to checkout</a>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="mb-8 cart-total">
                <div class="row">
                    <div class="col-xl-5 col-lg-6 offset-lg-6 offset-xl-7 col-md-8 offset-md-4">
                        <div class="border-bottom border-color-1 mb-3">
                            <h3 class="d-inline-block section-title mb-0 pb-2 font-size-26">Cart totals</h3>
                        </div>
                        <table class="table mb-3 mb-md-0">
                            <tbody>
                                <tr class="cart-subtotal">
                                    <th>Subtotal</th>
                                    <td data-title="Subtotal"><span class="amount">₹1,785.00</span></td>
                                </tr>
                                <tr class="shipping">
                                    <th>Shipping</th>
                                    <td data-title="Shipping">
                                        Flat Rate: <span class="amount">(Free shipping only local)</span>
                                        <div class="mt-1">
                                            <a class="font-size-12 text-gray-90 text-decoration-on underline-on-hover font-weight-bold mb-3 d-inline-block" data-toggle="collapse" href="#collapseExample" role="button" aria-expanded="false" aria-controls="collapseExample">
                                                Select Pincode
                                            </a>
                                            <div class="collapse mb-3" id="collapseExample">
                                                <div class="form-group mb-4">
                                                    <select class="js-select selectpicker dropdown-select right-dropdown-0-all w-100"
                                                            data-style="bg-white font-weight-normal border border-color-1 text-gray-20">
                                                        <option value="">Select a pincode…</option>
                                                        <option value="632503">632503</option>
                                                        <option value="632401">632401</option>
                                                        <option value="632509">632509</option>
                                                    </select>
                                                </div>

                                                <button type="button" class="btn btn-soft-secondary mb-3 mb-md-0 font-weight-normal px-5 px-md-4 px-lg-5 w-100 w-md-auto">Update Totals</button>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                                <tr class="order-total">
                                    <th>Total</th>
                                    <td data-title="Total"><strong><span class="amount">₹1,785.00</span></strong></td>
                                </tr>
                            </tbody>
                        </table>
                        <button type="button" class="btn btn-primary-dark-w ml-md-2 px-5 px-md-4 px-lg-5 w-100 w-md-auto d-md-none">Proceed to checkout</button>
                    </div>
                </div>
            </div>
        </div>
    </main>
    <!-- ========== END MAIN CONTENT ========== -->

</asp:Content>