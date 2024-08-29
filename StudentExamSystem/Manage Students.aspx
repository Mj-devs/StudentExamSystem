<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage Students.aspx.cs" Inherits="StudentExamSystem.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <header class="d-flex justify-content-between align-items-center">
        <div>
            <h2 id="title">College of Sciences&nbsp;</h2>
            <h3>300 Level Students:</h3>
        </div>
            <!--search-->
            <div class="">
            <div class ="d-flex ">
            <asp:TextBox CssClass=" form-control" ID="txtsearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnsearch" runat="server" Text="Search" 
                CssClass ="btn btn-outline-primary rounded-2 mx-1" 
                ValidationGroup="SearchGroup" OnClick="btnsearch_Click" />
            </div>
            <!-- Required Field Validator for search -->
                <asp:RequiredFieldValidator
                    ID="rfvSearch"
                    runat="server"
                    ControlToValidate="txtsearch"
                    ErrorMessage="Search term is required."
                    CssClass="text-danger"
                    ValidationGroup="SearchGroup"
                    Display="Dynamic" />
        </div>
        </header>
        <!--database data-->
        <div class="container">
            <div class="d-flex align-items-center">
                <div class="col-md-5">
                    <asp:GridView ID="gvstudents" runat="server" OnRowCommand="gvstudents_RowCommand" DataKeyNames="MatricNo" CssClass="table table-bordered table-striped">
                        <Columns>
                          <asp:CommandField 
                                ShowSelectButton="true" 
                                SelectText="Upload Result" 
                                ButtonType="Button" />
                        </Columns>
                    </asp:GridView>
                </div>
              </div>
        </div>
         <div class="container">
            <!-- LinkButton to toggle visibility -->
            <asp:LinkButton ID="lbToggleFields" runat="server" Text="Add New Student +" CausesValidation="false" OnClick="lbToggleFields_Click" CssClass="btn btn-primary" />

            <!-- Panel for hidden fields -->
             <br />
            <asp:Panel ID="pnlHiddenFields" runat="server" CssClass="form-group" Visible="false">
                <div class="col-md-8">
            <p>First Name: <asp:TextBox ID="txtfirstname" runat="server" CssClass ="form-control h-25"></asp:TextBox> </p>
            <p>Last Name: <asp:TextBox ID="txtlastname" runat="server" CssClass="form-control h-25"></asp:TextBox> </p>
            <p>Matric No: <asp:TextBox ID="txtmatricno" runat="server" CssClass ="form-control h-25"></asp:TextBox></p> 
            
             <!-- Customvalidator to check matric no same-->
            <asp:CustomValidator 
                ID="cvMatricNo" 
                runat="server" 
                ControlToValidate="txtmatricno" 
                OnServerValidate="cvMatricNo_ServerValidate" 
                ErrorMessage="Matriculation number already exists." 
                Display="Dynamic"
                ValidationGroup="SaveGroup"
                ForeColor="Red">
            </asp:CustomValidator> <br />
            
            <!--Save button-->
            <asp:Button ID="btnsave" runat="server"  Text="Save" 
                        CssClass=" btn btn-primary h-25 w-25" 
                        OnClick="btnsave_Click" ValidationGroup="SaveGroup" />
                </div>
            </asp:Panel>
        </div>
    </main>     
</asp:Content>
