<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="container-fluid">

    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="container-fluid">
        <asp:Button ID="Button1" runat="server" Text="Add to cart" OnClick="Button1_Click" CssClass=" btn btn-primary" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
      
        <br />
        <br />
        <br />
    </asp:Panel>
    
</asp:Content>

