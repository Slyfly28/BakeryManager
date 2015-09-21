<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BakeryManager.Pages.AccountManagement.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        :<br />
        <asp:TextBox ID="txtBox_UsrName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtBox_Psswrd" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Confirm Password:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtBox_CPsswrd" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="First Name:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtBox_FName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Last Name:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtBox_LName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Address:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtBox_Address" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Pos"></asp:Label>
        tal Code:</p>
    <p>
        <asp:TextBox ID="txtBox_PostalCode" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_RgstrSubmit" runat="server" CssClass="button" OnClick="Button1_Click" Text="Register" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
