<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="StudentExamSystem.StudentView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--database data-->
<div class="container">
    <div class="d-flex align-items-center">
        <div class="col-md-5">
            <asp:GridView ID="gvstudents" runat="server" OnRowCommand="gvstudents_RowCommand" DataKeyNames="Id" CssClass="table table-bordered table-striped">
                <Columns>
                   <asp:ButtonField Text="See Result" CommandName="ViewResult" />
                </Columns>
            </asp:GridView>
        </div>
      </div>
</div>
</asp:Content>
