<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginFailed.aspx.cs" Inherits="LoginFailed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="color: #FF0000; text-align: center;" >
                Your login information is invalid.
            </p>

            <p style="text-align: center">
                <asp:Button runat="server" Text="Try Again" OnClick="Unnamed1_Click" />
            </p>
            

        </div>
    </form>
</body>
</html>
