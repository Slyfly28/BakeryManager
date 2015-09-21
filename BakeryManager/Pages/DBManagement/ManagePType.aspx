<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManagePType.aspx.cs" Inherits="BakeryManager.Pages.DBManagement.ManagePType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Name:
    </p>
    <p>
        <asp:TextBox ID="txtbox_TName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btn_TName" runat="server" OnClick="btn_TName_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="lbl_Result" runat="server"></asp:Label>
    </p>
</asp:Content>
