
<%@ Page Title="Standing Order Admin" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StandOrderMaint.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Standing Order Admin</h4>
        <p>This provides a means for the standing order admin.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>A/C No</label>
                        <asp:TextBox ID="TxtAcctNo" runat="server"
                            Text="admin"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Account Name</label>
                        <asp:TextBox ID="LblHolder" runat="server" class="form-control input-style"
                 Visible="True" AutoPostBack="True"></asp:TextBox>
            </div>
                </div>
            </div>

            
          
              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Order No</label>
                     <asp:TextBox ID="TxtOrderNo" Text="298" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Order Type</label>
                            <asp:DropDownList ID="DDOrderType" runat="server" CssClass="form-control">
                                    <asp:ListItem>Monthly</asp:ListItem>
                                    <asp:ListItem>Yearly</asp:ListItem>                         
                               </asp:DropDownList>
                           </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Beneficiary Account No</label>
                      <asp:TextBox ID="TxtContraAcctNo" runat="server" class="form-control input-style"
                          Text=""
                     ReadOnly="True"></asp:TextBox>
            </div>
                </div>
            </div>

             <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Beneficiary Name</label>
                      <asp:TextBox ID="LblBeneName" runat="server" class="form-control input-style"
                          Text=""
                     ReadOnly="True"></asp:TextBox>
            </div>
                </div>
            </div>

            
             <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Particulars</label>
                      <asp:TextBox ID="TxtParticular" runat="server" class="form-control input-style"
                          Text=""
                     ></asp:TextBox>
            </div>
                </div>
            </div>

            
            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Start Date</label>
                    <div class="input-group mb-3">
                       <asp:TextBox ID="TxtStartDate" Text="12/31/2020" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>    
                      <div class="input-group-append">
                          <asp:Button ID="ButChgDate" runat="server" CssClass="btn btn-primary" Enabled="False" Text="Change Date" />
                      
                      </div>
                    </div>                              
                     </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>End Date</label>
                    <div class="input-group mb-3">
                       <asp:TextBox ID="TxtEndDate" Text="12/31/2020" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>    
                      <div class="input-group-append">
                          <asp:Button ID="ButChangeDate" runat="server" CssClass="btn btn-primary" Enabled="False" Text="Change Date" />
                      </div>
                    </div>                              
                     </div>
                </div>
            </div>
             
             <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Amount</label>
                        <asp:TextBox ID="TxtAmount" runat="server" class="form-control input-style"
                            Text=""
                 Visible="True" ReadOnly="True"></asp:TextBox>
                       
                 </div>
                </div>
            </div>



            <div class="text-center mt-4">
                <asp:Button ID="ButAdd" runat="server" class="btn btn-outline-primary mr-2"  Text="Add"  />
                <asp:Button ID="ButSave" runat="server" class="btn btn-outline-primary mr-2"  Text="Save"/>
                   <asp:Button ID="ButSearch" runat="server" class="btn btn-outline-primary mr-2"  Text="Search"  />
                <asp:Button ID="ButDelete" runat="server" class="btn btn-outline-primary mr-2"  Text="Delete"/>
                   <asp:Button ID="ButPrint" runat="server" class="btn btn-outline-primary mr-2"  Text="View/Print List"  />
                <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
            </div>


        </div>

    </div>

    

</asp:Content>



