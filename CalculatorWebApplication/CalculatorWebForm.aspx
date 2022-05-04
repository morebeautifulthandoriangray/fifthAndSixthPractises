<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorWebForm.aspx.cs" Inherits="CalculatorWebApplication.CalculatorWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="FirstValue" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="SecondValue" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="+" />
&nbsp;<asp:Button ID="Subtract" runat="server" OnClick="Subtract_Click" Text="-" />
&nbsp;<asp:Button ID="Multiply" runat="server" OnClick="Multiply_Click" Text="*" />
&nbsp;<asp:Button ID="Divide" runat="server" OnClick="Divide_Click" Text="/" />
            <br />
            <br />
            <asp:Label ID="Result" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
