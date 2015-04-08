<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1 style="text-align: center; ">SPSU Bookstore</h1>
    
            <p aria-orientation="horizontal" style="text-align: center">
                Username:&nbsp; 
                <asp:TextBox ID="username" runat="server" Text="" />
            </p>


            <p style="text-align: center">
                Password:&nbsp;
                <asp:TextBox ID="password" runat="server" Text="" TextMode="Password" />
            </p>

            <p style="text-align: center">
                <asp:Button ID="loginSubmit" runat="server" Text="Login" OnClick="loginSubmit_Click" />
            </p>
        </div>
    </form>
</body>
</html>
