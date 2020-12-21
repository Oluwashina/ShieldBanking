<%@ Page Title="Loan Repayment" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoanRepayment.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Loan Repayment"></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                    
                    <div class="form-group mx auto">
                        <div class="input-group">
                            <asp:TextBox ID="TxtFindLoan" runat="server" CssClass="form-control input-style" placeholder="Enter Customer Account No to Find Loan Account" AutoPostBack="True"></asp:TextBox>
                            <asp:Button ID="ButFindLoan" CssClass="btn btn-sm btn-outline-primary"  runat="server" Text="Find" />
                        </div>
                    </div>

                   <div class="form-group mx-auto">
                       <label>Username</label>
                       <asp:TextBox ID="TxtCurrUser" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>    
                   </div>
                    <div class="form-group mx-auto">
                           <label>Loan Account No</label>
                           <asp:TextBox ID="TxtLoanAcctNo" runat="server" class="form-control input-style"></asp:TextBox>    
                    </div>

                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Branch Code</label>
                               <asp:TextBox ID="TxtBranchCode" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Holder's Name</label>
                               <asp:TextBox ID="LblHolder" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Branch</label>
                           <asp:TextBox ID="LblSex" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Sex</label>
                           <asp:TextBox ID="TxtDateCreated" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                    </div>
                </div>

                <div class="form-group mx-auto">
                    <label>Account Balance</label>
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>    
                </div>
                <div class="form-group mx-auto">
                        <label>Cust. Account No</label>
                        <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                </div>

                <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Loan amount paid</label>
                               <asp:TextBox ID="TxtAmount" runat="server" class="form-control input-style"></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Interest Amount Paid</label>
                               <asp:TextBox ID="TxtIntAmt" runat="server" class="form-control input-style"></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Transaction Date</label>
                           <asp:TextBox ID="TxtProcDate" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Ref No</label>
                           <asp:TextBox ID="TxtRefNo" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                    </div>
                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButPostIt" CssClass="btn btn-outline-primary  mr-3" runat="server" Text="Post" />
    </div>
</asp:Content>