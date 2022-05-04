<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl5Practice.ascx.cs" Inherits="_5Practice.WebUserControl5Practice" %>
<asp:TextBox ID="FirstValue" runat="server"></asp:TextBox>
<p>
    <asp:TextBox ID="SecondValue" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ClickButton" runat="server" OnClick="ClickButton_Click" Text="Click me!!!" />
</p>
<p>
    <asp:Label ID="Result" runat="server"></asp:Label>
</p>

