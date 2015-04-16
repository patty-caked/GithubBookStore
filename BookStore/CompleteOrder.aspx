<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CompleteOrder.aspx.cs" Inherits="CompleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align: center">

            Your order has been completed!</h1>
        <p style="text-align: center">

            Thank you for your money!<br />
            Your cart has been cleared and you may leave forever and never come back.</p>
        <p style="text-align: center">

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return to search page" />

        </p>
    </div>
    </form>
</body>
</html>
