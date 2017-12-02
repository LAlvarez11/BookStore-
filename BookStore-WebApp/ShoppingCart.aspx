<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShopppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Shopping Cart Details:"></asp:Label>
        <br />
        <br />
        <asp:Table ID="tbl" runat="server"></asp:Table>
        <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" CssClass="btn btn-primary" OnClick="CheckoutButton_Click" />
        <asp:Button ID="ShoppingButton" runat="server" Text="Continue Shopping" CssClass="btn btn-primary" OnClick="ShoppingButton_Click" />
    </asp:Panel>
</asp:Content>

