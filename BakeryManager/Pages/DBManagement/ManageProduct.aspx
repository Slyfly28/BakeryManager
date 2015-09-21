<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="BakeryManager.Pages.DBManagement.ManageProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Name:
</p>
<p>
    <asp:TextBox ID="txtBox_Name" runat="server"></asp:TextBox>
</p>
<p>
    Type:</p>
<p>
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="PTypeDataSource" DataTextField="TName" DataValueField="Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="PTypeDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:BakeryDBConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [TName]"></asp:SqlDataSource>
</p>
<p>
    Price:</p>
<p>
    <asp:TextBox ID="txtBox_Price" runat="server"></asp:TextBox>
</p>
<p>
    Image:</p>
<p>
    <asp:DropDownList ID="ddlImage" runat="server">
    </asp:DropDownList>
</p>
<p>
    Info:</p>
<p>
    <asp:TextBox ID="txtBox_Info" runat="server" Height="80px" TextMode="MultiLine" Width="220px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
</p>
<p>
    <asp:Label ID="lbl_Result" runat="server"></asp:Label>
</p>
</asp:Content>
