<%@ Page Title="Posting Authorization" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustBalEnq.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Transaction Posting</h4>
        <p>Please kindly fill in the details below for Transaction Posting.</p>
    </div>

    <!--Form-->
    <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-4" style="">
                        <label>User Name</label>
                        <asp:TextBox ID="TxtCurrUser" runat="server" class="form-control input-style" Text="Admin" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>

             

              <div class="row mt-2">
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Account No:</label>
                       <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style" TabIndex="1" ></asp:TextBox>
                    </div>
                </div>


                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Holder's Name</label>
                        <asp:TextBox ID="LblHolder" runat="server" disabled="disabled " class="form-control input-style" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>
            
            <div class="row mt-2">
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Branch Code :</label>
                       <asp:TextBox ID="TxtBranchCode" runat="server" class="form-control input-style" TabIndex="1" ></asp:TextBox>
                    </div>
                </div>


                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Branch </label>
                        <asp:TextBox ID="TxtBranch" runat="server" disabled="disabled " class="form-control input-style" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Trans. Type:</label>
                       <asp:DropDownList ID="DDTransType" runat="server" CssClass="form-control">
                            <asp:ListItem value="002" >Cashier 1</asp:ListItem>
                            <asp:ListItem value="002" >Cashier 2</asp:ListItem>
                            <asp:ListItem value="002" >Cashier 3</asp:ListItem>
                            <asp:ListItem value="002" >Cashier 4</asp:ListItem>
                            <asp:ListItem value="005" >Cashier 5</asp:ListItem>
                            <asp:ListItem value="006" >Cashier 6</asp:ListItem>
                            <asp:ListItem value="007" >OBC</asp:ListItem>
                            <asp:ListItem value="008" >Entries</asp:ListItem>
                           
                            
                        </asp:DropDownList>
                    </div>
                </div>
                 

                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Insrument No:</label>
                        <asp:TextBox ID="TxtInstruNo" runat="server" disabled="disabled " class="form-control input-style" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>

             <div class="row mt-2">
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Trans Date:</label>
                   <asp:TextBox ID="TxtTransDate" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox> 
                    </div>
                </div>
                 

                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Dr /Cr:</label>
                        <asp:DropDownList ID="DDCrDr" runat="server" CssClass="form-control">
                            <asp:ListItem>Deposit</asp:ListItem>
                            <asp:ListItem>Withdrawal</asp:ListItem>
                        </asp:DropDownList>
                            
                    </div>
                </div>
            </div>

            <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                        <label>Particulars :</label>
                         <asp:TextBox ID="TxtParticular" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>


            <div class="row mt-2">
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Amount :</label>
                   <asp:TextBox ID="TxtTransAmt" runat="server" class="form-control input-style" TabIndex="1"></asp:TextBox> 
                    </div>
                </div>
                 

                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Contra Account:</label>
                        <asp:DropDownList ID="DDCashAcct" runat="server" CssClass="form-control" disabled="disabled " >
                            
                        </asp:DropDownList>
                            
                    </div>
                </div>
            </div>

            <div class="row mt-2">
                <div class="col-lg-12">
                   <div class="form-group" style="">
                        <label>Clear Cheque:</label>
                   <asp:CheckBox ID="CheckClearChq" runat="server"  />
                    </div>
                </div>
                 

                 
                </div>
            </div>

        </div>

    </div>

    

</asp:Content>



