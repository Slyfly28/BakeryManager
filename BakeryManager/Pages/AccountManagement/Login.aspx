<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BakeryManager.Pages.AccountManagement.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtBox_Usrname" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtBox_Psswrd" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btn_Login" runat="server" CssClass="button" OnClick="btn_Login_Click" Text="Login" />
    <br />
</p>
</asp:Content>
