<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPage.aspx.cs" Inherits="BookPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Book Page</h1>

            <p>

                <asp:Image ID="cover" runat="server" />

            </p>
            <p>

                <asp:Label ID="isbn" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="title" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="author" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="semester" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="course" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="section" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="professor" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="crn" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="use" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="qnew" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="qused" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="qrent" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="qebook" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="pnew" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="pused" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="prent" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="pebook" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Label ID="descript" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:Button ID="Button1" runat="server" Text="Add To Shopping Cart;" />

            </p>
            
        </div>
    </form>
</body>
</html>
