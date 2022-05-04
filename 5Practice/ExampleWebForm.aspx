<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleWebForm.aspx.cs" Inherits="_5Practice.ExampleWebForm" %>

<%@ Register src="WebUserControl5Practice.ascx" tagname="WebUserControl5Practice" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:WebUserControl5Practice ID="WebUserControl5Practice1" runat="server" />
        </div>
    </form>
</body>
</html>
