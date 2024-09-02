<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentExamSystem.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="d-flex justify-content-center align-items-center flex-column pt-3">
          <div class="w-100 text-center mb-3">
        <asp:Label Text="Welcome to the Grade Management System for ABUAD" runat="server" CssClass="h5" />
    </div>
    <div class="w-50">
      <div class="mb-3">
        <label class="form-label">Email address</label>
          <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
      </div>
      <div class="mb-3">
        <label class="form-label">Password</label>
          <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
      </div>
        <div class="d-flex justify-content-center">
        <asp:Button ID="btnlogin" runat="server" Text="Login" CssClass="btn btn-secondary w-25" OnClick="btnlogin_Click" />
        </div>
        <asp:Label ID="lblerror" Text="" runat="server" />
        <br />
        <asp:CustomValidator ID="cvUsernameFormat" runat="server"
            ControlToValidate="txtemail"
            ErrorMessage="Email must be a valid email address."
            OnServerValidate="cvEmailFormat_ServerValidate"
            ForeColor="Red"
            Display="Dynamic" />

    </div>
    </div>
</asp:Content>
    