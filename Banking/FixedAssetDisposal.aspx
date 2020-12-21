<%@ Page Title="FIxed Asset Disposal Admin" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FixedAssetDisposal.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Fixed Asset Disposal Admin</h4>
        <p>This provides a means for Fixed Asset Disposal Admin.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Username</label>
                        <asp:TextBox ID="TxtCurrUser" runat="server"
                            Text=""
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            
          
              <div class="row mt-2">
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Asset Name</label>
                          <asp:DropDownList ID="DDAssetName" runat="server" AutoPostBack="True" CssClass="form-control">
                             </asp:DropDownList>
                           </div>
                </div>
                   <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Asset Description</label>
                     <asp:TextBox ID="TxtAssDesc" Text="" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
            </div>

              <div class="row mt-2">
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Asset Group</label>
                       <asp:TextBox ID="LblGroup" Text="Group" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>      
                           </div>
                </div>
                   <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Cost Value</label>
                     <asp:TextBox ID="LblCost" Text="Cost" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
            </div>

            
              <div class="row mt-2">
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Location</label>
                       <asp:TextBox ID="LblLocation" Text="Location" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>      
                           </div>
                </div>
                   <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Date Of Acquisition</label>
                     <asp:TextBox ID="LblDateAcq" Text="Date of Acquisition" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
            </div>

             <div class="row mt-2">
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Depreciated Value</label>
                       <asp:TextBox ID="TxtDeprValue" Text="" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>      
                           </div>
                </div>
                   <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Residual Value</label>
                     <asp:TextBox ID="TxtResidualVal" Text="" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
            </div>

            
             <div class="row mt-2">
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Beneficiary Name</label>
                       <asp:TextBox ID="TxtBeneficName" Text="" class="form-control input-style" runat="server"></asp:TextBox>      
                           </div>
                </div>
                   <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Sales Value</label>
                     <asp:TextBox ID="TxtSalesValue" Text="" class="form-control input-style" runat="server"></asp:TextBox>                          
            </div>
                </div>
            </div>
           
             
             <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Profit/Loss</label>
                        <asp:TextBox ID="TxtProfitLoss" runat="server" class="form-control input-style"
                            Text=""
                 Visible="True" ReadOnly="True"></asp:TextBox>
                       
                 </div>
                </div>
            </div>



            <div class="text-center mt-3 mb-3">
                <asp:Button ID="ButDispose" runat="server" class="btn btn-outline-primary mr-2"  Text="Dispose"  />
                <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary mr-2"  Text="Close"/>
            </div>


        </div>

    </div>

    

</asp:Content>



