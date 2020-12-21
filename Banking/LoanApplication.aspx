<%@ Page Title="Loan Application" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="LoanApplication.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Loan & Overdraft Processing (Standard)" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                   <div class="form-group mx-auto">
                       <label>Username</label>
                       <asp:TextBox ID="TxtCurrUser" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>    
                   </div>
                    <div class="form-group mx-auto">
                           <label>Trans.Type</label>
                             <asp:DropDownList ID="DDTransType" runat="server" CssClass="form-control select-style" AutoPostBack="True">
                                <asp:ListItem>Loan</asp:ListItem>
                                <asp:ListItem>Overdraft</asp:ListItem>
                            </asp:DropDownList>
                    </div>

                    <div class="form-group mx-auto">
                           <label>Loan Account No</label>
                           <asp:TextBox ID="TxtLoanAcctNo" runat="server" CssClass="form-control input-style" ></asp:TextBox>    
                    </div>
                    
                    <div class="row mt-2">
                        <div class="col-lg-6">
                             <div class="form-group mx-auto">
                                   <label>Holder's Name</label>
                                   <asp:TextBox ID="TextBox2" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>
                        </div>

                      <div class="col-lg-6">
                          <div class="form-group mx-auto">
                           <label>Sex</label>
                           <asp:TextBox ID="TextBox6" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>                            
                    </div>
                </div>    


                    <div class="form-group mx-auto">
                        <label>Account Balance</label>
                        <asp:TextBox ID="TextBox5" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>   
                    </div>
                    <div class="form-group mx-auto">
                        <label>Processing Date</label>
                        <asp:TextBox ID="TextBox7" runat="server" class="form-control input-style"></asp:TextBox>    
                     </div>

                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Branch</label>
                               <asp:TextBox ID="TxtBranchDesc" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Repayment Mode</label>
                               <asp:DropDownList ID="DDRepayMode" runat="server" CssClass="form-control select-style" AutoPostBack="True" >
                                    <asp:ListItem>Monthly</asp:ListItem>
                                    <asp:ListItem>Weekly</asp:ListItem>
                                    <asp:ListItem>Daily</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                        </div>

                      <div class="col-lg-6">                        
                          <div class="form-group mx-auto">
                            <label>Branch code</label>
                           <asp:TextBox ID="TxtBranchCode" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                           <div class="form-group mx-auto">
                           <label>Repayment Days</label>
                            <asp:DropDownList runat="server" ID="DDMonths" CssClass="form-control select-style" AutoPostBack="True">
                                   <asp:ListItem>1</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <div class="form-group mx-auto">
                    <label>Loan Amount</label>
                    <asp:TextBox ID="TxtAmount" runat="server" class="form-control input-style"></asp:TextBox>    
                 </div>
                <div class="form-group mx-auto">
                        <label>Cust.Account No</label>
                        <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style"></asp:TextBox>    
                </div>

                <div class="form-group mx-auto">
                        <label>Particulars</label>
                        <asp:TextBox ID="TxtParticulars" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                </div>

                <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Expiry Date</label>
                               <asp:TextBox ID="TxtExpDate" runat="server" class="form-control input-style"></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Interest Rate</label>
                               <asp:TextBox ID="TxtIntRate" runat="server" class="form-control input-style" ></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Auto Interest</label>
                           <asp:DropDownList ID="DDAuto" CssClass="form-control select-style" runat="server">
                                <asp:ListItem>No</asp:ListItem>
                                <asp:ListItem>Yes</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                          <div class="form-group mx-auto">
                           <label>Interest Type</label>
                           <asp:DropDownList ID="DDIntType" CssClass="form-control select-style" runat="server">
                                <asp:ListItem>Straight</asp:ListItem>
                                <asp:ListItem>Reducing</asp:ListItem>
                            </asp:DropDownList>
                        </div>                           
                    </div>
                </div>

                <div class="form-group mx-auto">
                        <label>Loan Officer</label>
                        <asp:TextBox ID="TextBox1" runat="server" class="form-control input-style" ></asp:TextBox>    
                </div>

                <div class="form-group mx-auto">
                        <label>Security</label>
                        <asp:TextBox ID="TextBox3" runat="server" class="form-control input-style"></asp:TextBox>    
                </div>

                <div class="form-group mx-auto">
                    <label>Lending Model</label>
                    <asp:DropDownList ID="DDLendModel" CssClass="form-control select-style" runat="server">
                        <asp:ListItem>None</asp:ListItem>
                        <asp:ListItem>Individuals</asp:ListItem>
                        <asp:ListItem>Solidarity Group</asp:ListItem>
                        <asp:ListItem>Neighborhood and Small Group Revolving Funds</asp:ListItem>
                        <asp:ListItem>Village Banking</asp:ListItem>
                        <asp:ListItem>Wholesale lending</asp:ListItem>
                        <asp:ListItem>Credit Unions</asp:ListItem>
                        <asp:ListItem>Staff</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Ref No</label>
                               <asp:TextBox ID="TxtRefNo" runat="server" class="form-control input-style" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Monthly Repayment</label>
                               <asp:TextBox ID="TxtMonthlyRepay" runat="server" class="form-control input-style" AutoPostBack="True" ></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Total Repayment Payable</label>
                           <asp:TextBox ID="TxtTotalPayable" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                          <div class="form-group mx-auto">
                           <label>Disbursed By:</label>
                           <asp:DropDownList ID="DDDisbursedBy" CssClass="form-control select-style" runat="server">
                                <asp:ListItem>None</asp:ListItem>
                            </asp:DropDownList>
                        </div>                           
                    </div>
                </div>

                 <div class="form-group mx-auto">
                    <label>Sector</label>
                    <asp:DropDownList ID="DDSector" CssClass="form-control select-style" runat="server">
                        <asp:ListItem>Agriculture &amp; Forestry</asp:ListItem>
                        <asp:ListItem>Mining &amp; Quarry	</asp:ListItem>
                        <asp:ListItem>Manufacturing &amp; Food Processing	</asp:ListItem>
                        <asp:ListItem>Trade &amp; Commerce	</asp:ListItem>
                        <asp:ListItem>Transport &amp; Communication	</asp:ListItem>
                        <asp:ListItem>Real Estate &amp; Construction	</asp:ListItem>
                        <asp:ListItem>Rent/Housing	</asp:ListItem>
                        <asp:ListItem>Consumer/Personal	</asp:ListItem>
                        <asp:ListItem>Health	</asp:ListItem>
                        <asp:ListItem>Education	</asp:ListItem>
                        <asp:ListItem>Tourism &amp; Hospitality	</asp:ListItem>
                        <asp:ListItem>Purchase of Shares	</asp:ListItem>
                        <asp:ListItem>Others </asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group mx-auto">
                    <label>Estimated Value</label>
                    <asp:TextBox ID="TextBox4" runat="server" class="form-control input-style" ></asp:TextBox>    
                </div>

                <div class="form-group mx-auto">
                    <label>Approved By</label>
                    <asp:TextBox ID="TextBox11" runat="server" class="form-control input-style" ></asp:TextBox>    
                </div>

                

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButPostIt" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Post" />
            <asp:Button ID="ButPrintAmort" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Amortization" />
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Close" />
        </div>
    </div>
</asp:Content>