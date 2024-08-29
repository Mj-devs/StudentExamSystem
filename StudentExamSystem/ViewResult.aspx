<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewResult.aspx.cs" Inherits="StudentExamSystem.ViewResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
<asp:Panel ID="pnlResult" runat="server" Visible="false">
    <h2>Student Result</h2>
    <asp:Label ID="lblStudentName" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblGrade" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblComments" runat="server" Text=""></asp:Label>
</asp:Panel>

</asp:Content>
