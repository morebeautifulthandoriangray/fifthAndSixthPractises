<%@ Page Title="" Language="C#" MasterPageFile="~/PracticeWithMasterPage.Master" AutoEventWireup="true" CodeBehind="WebFormSecondChild.aspx.cs" Inherits="_5Practice.WebFormSecondChild" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderChangeable" runat="server">
    <p>
        This is Child page</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderChildPlace" runat="server">
    <p>
        This is Child page</p>
</asp:Content>
