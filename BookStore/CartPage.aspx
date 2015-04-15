<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CartPage.aspx.cs" Inherits="CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style3">
    
        <strong style="text-align: center"><span class="auto-style2">Shopping Cart</span></strong></h1>
        
        <asp:GridView ID="Cart" runat="server">
        </asp:GridView>
        <asp:Button ID="Update" runat="server" Text="Update Cart" OnClick="UpdateCart" />
        <br />


        Total:
        <asp:Label ID="TotalLabel" runat="server" Text="$0.00"></asp:Label>
        <br />


        <asp:Button ID="CheckoutButton" runat="server" Text="Proceed to Checkout" OnClick="CheckoutButton_Click" />
        <br />

        <br />
        </div>
    </form>
</body>
</html>
