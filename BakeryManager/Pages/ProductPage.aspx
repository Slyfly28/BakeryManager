<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductPage.aspx.cs" Inherits="BakeryManager.Pages.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 268435456px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" /></td>
            <td>
                 <h2>
                     <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                     <hr />
                </h2>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="lblInfo" runat="server" CssClass="detailsInfo"></asp:Label></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label>
                <br />
                Quantity : 
                <asp:DropDownList ID="ddlAmount" runat="server" Width="69px"></asp:DropDownList>
                <br />
                <asp:Button ID="btn_AddProduct" runat="server" OnClick="btn_AddProduct_Click" Text="Add Product" CssClass="button" />
                <br/>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>

            
        </tr>
        
        <tr>
            <td>Product Number : <asp:Label ID="lblItemNmbr" runat="server" Text="Label"></asp:Label> </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label></td>
        </tr>
        
    </table>
</asp:Content>
