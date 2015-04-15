<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutPage.aspx.cs" Inherits="CheckoutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checkout</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align: center">
            Checkout
        </h1>
        <hr />
        <p>
            <strong>Total price of purchase</strong>:
            <asp:Label ID="price" runat="server" Text="price Label"></asp:Label>
        </p>
        <p>
            Please type in your credit card info below</p>
        <p>
            Credit Card number:
            <asp:TextBox ID="ccnumber" runat="server"></asp:TextBox>
            <br />
            Verification number:&nbsp;
            <asp:TextBox ID="ccverification" runat="server"></asp:TextBox>
        </p>
        <p>
            <strong>Credit Card Expiration Date</strong><br />
            Month:
            <asp:DropDownList ID="month" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>

            <br />Year:&nbsp; <asp:DropDownList ID="year" runat="server">
                <asp:ListItem>2015</asp:ListItem>
                <asp:ListItem>2016</asp:ListItem>
                <asp:ListItem>2017</asp:ListItem>
                <asp:ListItem>2018</asp:ListItem>
                <asp:ListItem>2019</asp:ListItem>
                <asp:ListItem>2020</asp:ListItem>
                <asp:ListItem>2021</asp:ListItem>
                <asp:ListItem>2021</asp:ListItem>
                <asp:ListItem>2023</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm Info" />
        </p>
    </div>
    </form>
</body>
</html>
