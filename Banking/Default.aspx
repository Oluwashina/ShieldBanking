<%@ Page Title="Login" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div>
            <h4>Shield Banking</h4>
        </div>
    </div>

    <!-- Welcome heading -->


       
        <div class="text-center mt-5">
            <h5>Welcome Back</h5>
        </div>
               

            
        <!-- input fields design -->

    <div class="row justify-content-center mt-3">

        <div class="col-lg-6">

               <div class="form-group mx-auto" style="width: 80%;">
                <label>User ID</label>
                     <asp:TextBox ID="TxtUserID" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
            </div>

            <div class="form-group mt-2 mx-auto" style="width: 80%;">
                <label>Bank ID</label>
                 <asp:TextBox ID="TxtBankID" runat="server" class="form-control input-style" AutoPostBack="true"></asp:TextBox>     
            </div>

            <div class="form-group mt-2 mx-auto" style="width: 80%;">
                <label>Password <span><a href="forgot.aspx" class="ml-2" style="cursor: pointer; font-size: 80%; color: #212529; text-decoration: none;">Forgot Password?</a></span></label>
                <asp:TextBox ID="TxtPassWord" runat="server" class="form-control input-style"  TextMode="Password" TabIndex="2"></asp:TextBox>
        
               
                        
            </div>

            <div class="text-center mt-4 mx-auto">
                <asp:Button ID="ButtonLog" runat="server" class="btn btn-primary" Text="Login" style="width: 80%; padding: 13px 13px;   " TabIndex="3" /> 
            </div>
                   
        <div class="text-center mt-3">
            <p style="color: #212529; text-decoration: none;">Don't have an account with us yet? <a href="Register.aspx" style="text-decoration: none;">Sign Up</a></p>
            </div>



        </div>


    </div>
                
         


</asp:Content>
