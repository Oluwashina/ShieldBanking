<%@ Page Title="CustomerBalanceEnquiry" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustBalEnq.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Customer Balance Enquiry</h4>
        <p>Please kindly fill in the details below for enquiry about your balance.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-4" style="">
                <label>Username</label>
                     <asp:TextBox ID="TxtUserID" runat="server" class="form-control input-style" Text="Admin" TabIndex="1"></asp:TextBox>     
            </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Account No</label>
                     <asp:TextBox ID="TextBox3" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
            </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Branch</label>
                     <asp:TextBox ID="TextBox1" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Holder's Name</label>
                     <asp:TextBox ID="TextBox2" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
            </div>
                </div>
            </div>
            



        </div>

    </div>

    

</asp:Content>



