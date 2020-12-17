<%@ Page Title="Customer Registration" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustAcctAdmini.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Customer Registration" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                   <div class="form-group mx-auto" style="width: 80%;">
                       <label>User ID</label>
                       <asp:TextBox ID="TxtOffInit" runat="server" class="form-control input-style" ></asp:TextBox>    
                   </div>
            </div>
            <div class="col-lg-6">
                    <!-- input fields -->
                    <div class="form-group mt-2 mx-auto" style="width: 80%;">
                        <label>Officer Name</label>
                         <asp:TextBox ID="TextBox2" runat="server" class="form-control input-style"></asp:TextBox>     
                    </div>
            </div>
        </div>
    </div>
</asp:Content>