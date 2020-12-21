<%@ Page Title="Register" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.vb" Inherits="Banking._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
        <div>
            <h4>Shield Banking</h4>
        </div>
    </div>

    <!-- Welcome heading -->


    <div class="row">
        <div class="col-lg-5 mt-5 d-none d-md-block d-lg-block">
            <div class="" style="display: flex; flex-direction: column; align-items: center;">
                 <img src="img/bank.svg" class="img-fluid" />
            </div>
           
        </div>
        <div class="col-lg-7">

             <div class="mt-3">
              <h4 class="text-center text-lg-left">Create an account</h4>
            </div>

            <div class="row mt-4">
                <div class="col-lg-6">

                    <div class="form-group">
                    <label>Bank Name</label>
                      <asp:TextBox ID="TxtBankName" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
                     </div>

                </div>
                <div class="col-lg-6">
                     <div class="form-group">
                        <label>Bank ID</label>
                         <asp:TextBox ID="TxtBankRegID" runat="server" class="form-control input-style"></asp:TextBox>     
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-6">

                    
              <div class="form-group">
                <label>Email</label>
                 <asp:TextBox ID="TxtEmail" runat="server" class="form-control input-style"></asp:TextBox>     
            </div>
                 </div>

                <div class="col-lg-6">
                         <div class="form-group">
                    <label>Address</label>
                    <asp:TextBox ID="TxtAddress" runat="server" class="form-control input-style"></asp:TextBox>           
                </div>

                </div>
              </div>

            
            <div class="row">
                <div class="col-lg-6">
   
            <div class="form-group">
                <label>Phone</label>
                <asp:TextBox ID="TxtPhone" runat="server" class="form-control input-style"></asp:TextBox>           
            </div>
                 </div>

                <div class="col-lg-6">
                     
            <div class="form-group">
                <label for="DDCountry">Country</label>
                <asp:DropDownList ID="DDCountry" runat="server" CssClass="form-control select-style">
                    <asp:ListItem>Nigeria</asp:ListItem>
                    <asp:ListItem>Kenya</asp:ListItem>
                    <asp:ListItem>Ghana</asp:ListItem>
                </asp:DropDownList>
                    
            
            </div>

                </div>
              </div>

             <div class="row">
                <div class="col-lg-6">
   
            <div class="form-group">
                <label>Contact Person</label>
                <asp:TextBox ID="TxtContactPerson" runat="server" class="form-control input-style"></asp:TextBox>           
            </div>

                 </div>

                <div class="col-lg-6">
          
            <div class="form-group">
                <label>User ID</label>
                <asp:TextBox ID="TxtUserRegID" runat="server" class="form-control input-style"></asp:TextBox>           
            </div>

                </div>
              </div>

             <div class="row">
                <div class="col-lg-6">
   
           <div class="form-group">
                <label>Password</label>
                <asp:TextBox ID="TxtRegPassword" runat="server" class="form-control input-style" TextMode="Password"></asp:TextBox>           
            </div>

                 </div>

                <div class="col-lg-6">
                
              <div class="form-group">
                <label>Re-enter Password</label>
                <asp:TextBox ID="TxtRegReenterPassword" runat="server" class="form-control input-style"  TextMode="Password" TabIndex="2"></asp:TextBox>           
            </div>

                </div>
              </div>

            
            <div class="text-center mt-4 mx-auto">
                <asp:Button ID="ButRegister" runat="server" class="btn btn-primary" Text="Register" style="width: 100%; padding: 13px 13px;   " TabIndex="3" /> 
            </div>

            <div class="text-center mt-3">
            <p style="color: #212529; text-decoration: none;">Already have an account? <a href="Default.aspx" style="text-decoration: none;">Login</a></p>
            </div>
                

            </div>

        </div>

</asp:Content>
