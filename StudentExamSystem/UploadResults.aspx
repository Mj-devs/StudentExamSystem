<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadResults.aspx.cs" Inherits="StudentExamSystem.UploadResults" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblStudentId" runat="server" Height="50px" Text="Label" Width="159px"></asp:Label>
    
    <div class="justify-content-center">
    <asp:Label ID ="lblgrade" runat="server" Text="Grade: "></asp:Label>
    <asp:TextBox ID="txtgrade" runat="server" CssClass = "form-control"></asp:TextBox>
    <asp:Label ID ="lblcomment" runat="server" Text="Comment:"></asp:Label>
    <asp:TextBox ID="txtcomments" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <br />
    <asp:Button ID="btnupload" runat="server" Text="Upload" CssClass="btn btn-secondary" OnClick="btnupload_Click1" />
    <asp:Label ID="lblMessage" runat="server" Text="" CssClass ="text-danger-emphasis"></asp:Label>


</asp:Content>
