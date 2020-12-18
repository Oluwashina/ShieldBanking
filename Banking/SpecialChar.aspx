
<%@ Page Title="Special Charges" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SpecialChar.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Special Charges</h4>
        <p>Please kindly fill in the following details.</p>
    </div>

      <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Radix</label>
                        <asp:TextBox ID="TxtReasonCode" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Amount</label>
                        <asp:TextBox ID="TxtReaNarrate" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            
            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Charges Type</label>
                        <asp:TextBox ID="TextBox1" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            
            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Date</label>
                        <asp:TextBox ID="TextBox2" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Radix</label>
                        <asp:TextBox ID="TextBox3" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Link Account</label>
                        <asp:TextBox ID="TextBox4" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>


            </div>
          </div>



    <div class="text-center mt-3 mb-3">
    <asp:Button ID="ButSave" runat="server" class="btn btn-outline-primary mr-2"  Text="Save"  />
            <asp:Button ID="ButEdit" runat="server" class="btn btn-outline-primary mr-2"  Text="Edit"/>
        <asp:Button ID="ButPrev" runat="server" class="btn btn-outline-primary mr-2"  Text="Previous"  />
            <asp:Button ID="ButNext" runat="server" class="btn btn-outline-primary mr-2"  Text="Next"/>
         <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
    </div>
                
         


</asp:Content>
