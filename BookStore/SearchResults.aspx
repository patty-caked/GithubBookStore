
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchResults.aspx.cs" Inherits="SearchResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1 style="text-align: center">
            Search Results
        </h1>

        <asp:Panel ID="Results" runat="server">
            <asp:GridView ID="resultsGrid" runat="server" >
            </asp:GridView>
        </asp:Panel>

    </div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </form>
</body>
</html>