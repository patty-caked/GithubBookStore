<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
    <style type="text/css">
        #Select1 {
            width: 131px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Logged in as: <asp:Label ID="name" runat="server" />
            </p>

            <h1 style="text-align: center">
                SPSU Bookstore
            </h1>

            <p style="font-weight: 700">
                ISBN:<asp:TextBox ID="isbn" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Title:<asp:TextBox ID="title" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Author:<asp:TextBox ID="author" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Semester:<asp:TextBox ID="semester" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Course:<asp:TextBox ID="course" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Section:<asp:TextBox ID="section" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                Professor:<asp:TextBox ID="professor" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                CRN:<asp:TextBox ID="crn" runat="server" Width="170px"></asp:TextBox>
            </p>
            <p style="font-weight: 700">
                <asp:Button ID="SearchButton" runat="server" Text="Search" Width="130px" OnClick="SearchButton_Click" />
            </p>
        </div>
    </form>
    </body>
</html>