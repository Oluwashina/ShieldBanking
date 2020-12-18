<%@ Page Title="Change Password" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Change Password Page</h4>
        <p>Please kindly fill in the form below to change your password.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-7">
            
           
              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>User ID</label>
                     <asp:TextBox ID="TxtUserID" class="form-control input-style" runat="server"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Username</label>
                        <asp:TextBox ID="TxtUserName" class="form-control input-style" runat="server"></asp:TextBox>  
            </div>
                </div>
            </div>

                <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Old Password</label>
                     <asp:TextBox ID="TxtOldPassword" class="form-control input-style" TextMode="Password" runat="server"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Date Created</label>
                      <asp:TextBox ID="TxtCreateDate" Text="12/17/2020" class="form-control input-style" runat="server" ReadOnly="true"></asp:TextBox>  
            </div>
                </div>
            </div>

        </div>

    </div>

    <div class="text-center mt-4 mb-3">
                <asp:Button ID="ButSave" runat="server" class="btn btn-outline-primary mr-2"  Text="Save"  />
                     <asp:Button ID="ButSearch" runat="server" class="btn btn-outline-primary mr-2"  Text="Search"  />
                <asp:Button ID="ButEdit" runat="server" class="btn btn-outline-primary mr-2"  Text="Edit"/>
                  <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
        </div>

    

</asp:Content>




