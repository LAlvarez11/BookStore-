<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Checkout:" CssClass="h4"></asp:Label>
    
    <asp:Table ID="Table1" runat="server" CssClass="table table-striped" Width="622px">
        <asp:TableRow runat="server" Visible="True">
            
            <asp:TableCell runat="server">
                <asp:Label ID="SummaryLabel" runat="server" Text="Order Summary" CssClass="h5"></asp:Label>
         
                <br />
                <br />
                <asp:Label ID="QuantityLabel" runat="server" Text="Quanity: "></asp:Label>
              
                <br />
                <br />
                <asp:Label ID="WeightLabel" runat="server" Text="Weight: "></asp:Label>

                <br />
                <br />
                <asp:Label ID="OrderTotalLabel" runat="server" Text="Order Total: "></asp:Label>
            
         
            </asp:TableCell>
           
            
            <asp:TableCell runat="server">
                 <asp:Label  runat="server" Text="Item Total Cost: " ID="ItemTotalCostLabel"></asp:Label>
                <br />
                <asp:Label ID="ShippingCostLabel" runat="server" Text="Shipping Cost: "></asp:Label>
                <br />
                <asp:Label ID="TotalLabel" runat="server" Text="Total: "></asp:Label>
            </asp:TableCell>

            
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                <asp:Label ID="ShippingLabel" runat="server" Text="Shipping Information" CssClass="h5"></asp:Label>
                

                <br />
                <asp:Label ID="NameLabel" runat="server" Text="Name: "></asp:Label>
                
<asp:TextBox ID="NameTextBox" runat="server" placeholder="Name"></asp:TextBox>
                
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
                

                <br /> 
                <asp:Label ID="StreetLabel" runat="server" Text="Street: "></asp:Label>
                
<asp:TextBox ID="StreetTextBox" runat="server" placeholder ="Street"></asp:TextBox>
                 
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
                

                <br />
                <asp:Label ID="CityLabel" runat="server" Text="City:   "></asp:Label>
                
<asp:TextBox ID="CityTextBox" runat="server" placeholder="City"></asp:TextBox>
                 
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
                

                <br />
                <asp:Label ID="StateLabel" runat="server" Text="State: "></asp:Label>
                
<asp:TextBox ID="StateTextBox" runat="server" placeholder="State"></asp:TextBox>
                 
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
                

                <br />
                <asp:Label ID="ZipLabel" runat="server" Text="Zip:      "></asp:Label>
                
<asp:TextBox ID="ZipTextBox" runat="server" placeholder="Zip"></asp:TextBox>
                 
<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
                

                <br />
                <asp:Label ID="EmailLabel" runat="server" Text="Email:"></asp:Label>
                
<asp:TextBox ID="EmailTextBox" runat="server" placeholder="Email" ></asp:TextBox>
                 
<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Required Field" ControlToValidate="NameTextBox"
              ForeColor="Red" ></asp:RequiredFieldValidator>
            
</asp:TableCell>
        </asp:TableRow>

    </asp:Table>
    

    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    

    <asp:Button ID="continueButton" runat="server" OnClick="Button1_Click" Text="Continue Shopping" CssClass="btn btn-primary" />
    <asp:Button ID="submitButton" runat="server" Text="Submit Order" CssClass="btn btn-primary" OnClick="submitButton_Click" />

</asp:Content>

