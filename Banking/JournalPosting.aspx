
<%@ Page Title="Journal Posting" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JournalPosting.aspx.vb" Inherits="Banking._Default" EnableSessionState="True" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Journal Posting</h4>
        <p>Please kindly fill in the details below for Journal Posting</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
           
              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>User Name</label>
                     <asp:TextBox ID="TxtCurrUser" Text="admin" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Posting Balance</label>
                        <asp:TextBox ID="TxtPostingAmt" Text="0" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>  
            </div>
                </div>
            </div>
              <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Trans Date</label>
                        <asp:TextBox ID="DTPJTransDate" runat="server"
                            Text="12/23/2020" ReadOnly="true"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>GL Account</label>
                        <asp:TextBox ID="DDAcctNameDb" runat="server"
                            CausesValidation="True"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Customer Account</label>
                        <asp:TextBox ID="DDCustNameDb" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Particulars</label>
                        <asp:TextBox ID="DrParticular" runat="server"
                            CausesValidation="True"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            <div>
                <asp:ListBox ID="ListCrType" runat="server" BackColor="Yellow" ForeColor="Black" AutoPostBack="True" Visible="false">
            </asp:ListBox>
            </div>

            <div>
                 <asp:ListBox ID="ListDrType" runat="server" AutoPostBack="True" Visible="False"></asp:ListBox>
            </div>
             

            
             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Ref No</label>
                        <asp:TextBox ID="TxtRefNo" runat="server"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            
             <div class="row">
                <div class="col-lg-6">
                    <div class="form-group mt-3" style="">
                        <label>Dr/Cr</label>
                        <asp:DropDownList ID="DDDrCr" runat="server" CssClass="form-control select-style">
                            <asp:ListItem>Debit</asp:ListItem>
                            <asp:ListItem>Credit</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                  </div>
                  <div class="col-lg-6">
                    <div class="form-group mt-3" style="">
                        <label>Amount</label>
                       <asp:TextBox ID="TxtAmtDr" runat="server"
                              class="form-control input-style"></asp:TextBox>
                    </div>
               </div>
                 </div>


        </div>

    </div>

    <div class="text-center mt-4 mb-3">
                <asp:Button ID="ButPost" runat="server" class="btn btn-outline-primary mr-2"  Text="Post"  />
                     <asp:Button ID="ButBatch" runat="server" class="btn btn-outline-primary mr-2"  Text="Batch Entry"  />
                <asp:Button ID="ButEdit" runat="server" class="btn btn-outline-primary mr-2"  Text="Edit"/>
                  <asp:Button ID="ButDelete" runat="server" class="btn btn-outline-primary mr-2"  Text="Delete"/>
                     <asp:Button ID="ButClear" runat="server" class="btn btn-outline-primary mr-2"  Text="Clear"/>
                  <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
        </div>

    

</asp:Content>
