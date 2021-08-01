<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Store.Test" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head><title></title>
    <style type="text/css">  
            .gmailbutton {  
                background-color: #ff0000;  
                color: white;  
                width: 150px;  
            }  
        </style> 
</head>
<body>
    <form id="form1" runat="server">  
           <%-- <div>  
                <asp:Button ID="btnlogin" runat="server" Text="Login With Gmail" CssClass="gmailbutton"  OnClick="btnlogin_Click" /> </div>  --%>
   <%--     <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="Login" />--%>
<asp:Panel ID="pnlProfile" runat="server" Visible="false">
<hr />
<table>
    <tr>
        <td rowspan="6" valign="top">
            <asp:Image ID="ProfileImage" runat="server" Width="50" Height="50" />
        </td>
    </tr>
    <tr>
        <td>
            ID:
            <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Name:
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Email:
            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Verified Email:
            <asp:Label ID="lblVerified" runat="server" Text=""></asp:Label>
        </td>
    </tr>
        <tr>
        <td>
<%--            <asp:Button Text="Clear" runat="server" OnClick = "Clear" />--%>
        </td>
    </tr>
</table>
</asp:Panel>

        <h1><b><a class="nav-link u-header__sub-menu-nav-link" id="alogOut" href="javascript:LogOut1();">LogOut</a></b></h1>

        </form>  

    <script>
        function LogOut1() {
            alert(window.location.href);
        }
    </script>
</body>
</html>

