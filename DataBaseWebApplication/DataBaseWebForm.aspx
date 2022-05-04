<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBaseWebForm.aspx.cs" Inherits="DataBaseWebApplication.DataBaseWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="GetCustomers" runat="server" OnClick="GetCustomers_Click" Text="Get Customers" />
            <br />
            <br />
            <asp:GridView ID="Customers" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="Result" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
