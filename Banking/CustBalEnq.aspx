<%@ Page Title="CustomerBalanceEnquiry" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustBalEnq.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Customer Balance Enquiry</h4>
        <p>Please kindly fill in your account number below for enquiry about your balance.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Username</label>
                        <asp:TextBox ID="TxtCurrUser" runat="server"
                            Text="admin"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Account No</label>
                        <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style"
                 Visible="True" AutoPostBack="True"></asp:TextBox>
            </div>
                </div>
            </div>

            
              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Holder's Name</label>
                        <asp:TextBox ID="LblHolder" runat="server" class="form-control input-style"
                 Visible="True" AutoPostBack="True" ReadOnly="true"></asp:TextBox>
                       
                 </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Branch Code</label>
                     <asp:TextBox ID="TxtBranchCode" Text="01" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Branch</label>
                        <asp:TextBox ID="TxtBranch" Text="Molete" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>  
            </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Trans Date</label>
                      <asp:TextBox ID="TxtTransDate" runat="server" class="form-control input-style"
                          Text="12/05/2020"
                     ReadOnly="True"></asp:TextBox>
            </div>
                </div>
            </div>


            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Account Balance</label>
                     <asp:TextBox ID="LblCurBal" Text="-138,000" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Loan Balance</label>
                        <asp:TextBox ID="LblLoan" Text="-26,200" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>  
            </div>
                </div>
            </div>

            
            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>C.O.T Balance</label>
                     <asp:TextBox ID="LblCOT" Text="0.00" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Uncleared Effect</label>
                        <asp:TextBox ID="LblUnCleared" Text="0.00" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>  
            </div>
                </div>
            </div>
             
             <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>Withdrawal Amount</label>
                        <asp:TextBox ID="LblWithAmt" runat="server" class="form-control input-style"
                            Text="-13,800"
                 Visible="True" ReadOnly="True"></asp:TextBox>
                       
                 </div>
                </div>
            </div>


            <div class="mt-2">
                <asp:Panel ID="Panel1" runat="server" Height="280px">
        <asp:GridView ID="GridViewAccounts" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="946px">
            <Columns>
                <asp:BoundField HeaderText="Account No">
                <ItemStyle Width="150px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Account Name">
                <ItemStyle Width="300px" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Account Balance">
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:ButtonField Text="See Details" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </asp:Panel>

            </div>

            <div class="text-center mt-2">
                <asp:Button ID="ButSig" runat="server" class="btn btn-primary mr-2"  Text="Signature & Photo"  />
                <asp:Button ID="ButClose" runat="server" class="btn btn-secondary"  Text="Close"/>
            </div>


        </div>

    </div>

    

</asp:Content>



