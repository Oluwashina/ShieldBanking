<%@ Page Title="Forgot Password" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="forgot.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h5 style="font-weight: bold;">Forgot your password?</h5>
        <p class="mt-2">Enter your registered user ID and email address below to receive password reset instructions.</p>
    </div>

    <div class="text-center mt-4">
        <img src="img/email.svg" width="100" height="100" alt="notify" />
    </div>

    <div class="form-group mt-4 mx-auto forgot-input">
        <input type="text" class="form-control input-style" id="username" placeholder="User ID" required>

     </div>

     <div class="form-group mt-4 mx-auto forgot-input">
        <input type="text" class="form-control input-style" id="email" placeholder="Email" required>

        <div class="text-center mt-1">
          <span font-size: 80%; color: #212529; text-decoration: none;">Remember password? <a href="Default.aspx" style="text-decoration: none;">Login</a></span>
        </div>
     </div>
     
                        
    <div class="text-center mt-4 mx-auto">
        <button type="submit" class="btn btn-primary forgot-input" style="padding: 13px 13px;">Send</button>
    </div>


</asp:Content>

