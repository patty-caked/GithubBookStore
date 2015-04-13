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

            <p>
                Search:
                </p>

            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </form>
    </body>
</html>
