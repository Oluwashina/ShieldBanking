
<%@ Page Title="Account Summary Report" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RepSelAcctSumm.aspx.vb" Inherits="RepSelAcctSumm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-3">
        <h4 style="font-weight: bold;">Account Summary Report</h4>
        <p>Please kindly select an option to access a summary report.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
           
              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Username</label>
                     <asp:TextBox ID="TxtCurrUser" class="form-control input-style" runat="server"></asp:TextBox>                          
            </div>
                </div>
               
            </div>

                <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Account Type</label>
                     <asp:DropDownList ID="DDAcctType" runat="server" CssClass="form-control">
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
                
            </div>

        </div>

    </div>

    <div class="text-center mt-4 mb-3">
                <asp:Button ID="ButOK" runat="server" class="btn btn-outline-primary mr-2"  Text="OK"  />
        </div>

    

</asp:Content>





