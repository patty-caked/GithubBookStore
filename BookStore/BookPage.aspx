<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookPage.aspx.cs" Inherits="BookPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align: center">Book Details</h1>

            <p>

                <asp:Image ID="cover" runat="server" />

            </p>
            <p>

                <strong>ISBN</strong>:

                <asp:Label ID="isbn" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Title</strong>:

                <asp:Label ID="title" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Author</strong>:

                <asp:Label ID="author" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Semester</strong>:

                <asp:Label ID="semester" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Course</strong>:

                <asp:Label ID="course" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Section</strong>:

                <asp:Label ID="section" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Professor</strong>:

                <asp:Label ID="professor" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>CRN</strong>:

                <asp:Label ID="crn" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Required/Recommended</strong>:

                <asp:Label ID="use" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>New Quantity</strong>:

                <asp:Label ID="qnew" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Used Quantity</strong>:

                <asp:Label ID="qused" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Rental Quantity</strong>:

                <asp:Label ID="qrent" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>E-Book</strong>:

                <asp:Label ID="qebook" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>New Price</strong>: $<asp:Label ID="pnew" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Used Price</strong>: $<asp:Label ID="pused" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Rental Price</strong>: $<asp:Label ID="prent" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>E-Book Price</strong>: $<asp:Label ID="pebook" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <strong>Description</strong>:<br />

                <asp:Label ID="descript" runat="server" Text="Label"></asp:Label>

            </p>
            <p>

                <asp:DropDownList ID="typeList" runat="server">
                    <asp:ListItem Value="0">New</asp:ListItem>
                    <asp:ListItem Value="1">Used</asp:ListItem>
                    <asp:ListItem Value="2">Rental</asp:ListItem>
                    <asp:ListItem Value="3">E-Book</asp:ListItem>
                </asp:DropDownList>

            </p>
            <p>

                <asp:Button ID="Button1" runat="server" Text="Add To Shopping Cart" OnClick="Button1_Click" />

            </p>
            
        </div>
    </form>
</body>
</html>
