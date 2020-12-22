<%@ Page Title="Fixed Deposit" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FixedDeposit.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Fixed Deposit Admin"></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                <div class="form-group mx-auto">
                    <label>User Name</label>
                    <asp:TextBox ID="TxtCurrUser" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                </div>
                <div class="form-group mx-auto">
                    <label>Holder's Name</label>
                    <asp:TextBox ID="LblHolder" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                </div>
                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Branch Code</label>
                               <asp:TextBox ID="TxtBranchCode" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Account No</label>
                               <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style" ></asp:TextBox>    
                            </div>

                             <div class="form-group mx-auto">
                               <label>Amount</label>
                               <asp:TextBox ID="TxtAmount" runat="server" class="form-control input-style"></asp:TextBox>    
                            </div>
                            <div class="form-group mx-auto">
                           <label>Sex</label>
                           <asp:TextBox ID="TxtSex" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                            <div class="form-group mx-auto">
                           <label>Tenor(months)</label>
                            <asp:DropDownList ID="DDMonths" CssClass="form-control select-style" runat="server" AutoPostBack="True">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                            <div class="form-group mx-auto">
                           <label>Interest Rate</label>
                           <asp:TextBox ID="TxtIntRate" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                            <div class="form-group mx-auto">
                           <label>Ref No</label>
                           <asp:TextBox ID="TxtRefNo" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                            <div class="form-group mx-auto">
                                <label>Link A/C</label>
                                <asp:TextBox ID="TxtLinkAcct" runat="server" class="form-control input-style"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>A/C Name</label>
                                <asp:TextBox ID="AcctName" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>Other Rate</label>
                                <asp:TextBox ID="TxtOtherRate" runat="server" class="form-control input-style"></asp:TextBox>
                            </div>
                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Branch</label>
                           <asp:TextBox ID="TxtBrancDesc" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Account Balance</label>
                           <asp:TextBox ID="TxtAcctBal" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Value Date</label>
                           <asp:TextBox ID="TxtProcDate" runat="server" class="form-control input-style" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Witholding Tax</label>
                           <asp:DropDownList ID="DDWithHoldTax" CssClass="form-control select-style" runat="server" AutoPostBack="True">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                                <asp:ListItem>23</asp:ListItem>
                                <asp:ListItem>24</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                          <div class="form-group mx-auto">
                              <label>Officer In Charge</label>
                              <asp:DropDownList ID="DDLoanOfficer" CssClass="form-control select-style" runat="server">
                                  <asp:ListItem>None</asp:ListItem>
                              </asp:DropDownList>
                          </div>
                          <div class="form-group mx-auto">
                           <label>Particulars</label>
                           <asp:TextBox ID="TxtParticulars" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                          <div class="form-group mx-auto">
                           <label>Other Comments</label>
                           <asp:TextBox ID="TxtComments" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                          <div class="form-group mx-auto">
                           <label>Applied Rate</label>
                           <asp:TextBox ID="TxtAppliedRate" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                           <div class="form-group mx-auto">
                           <label>Maturity Date</label>
                           <asp:TextBox ID="TxtExpDate" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                          <div class="form-group mx-auto">
                           <label>Auto Interest</label>
                           <asp:DropDownList ID="DDAuto" CssClass="form-control select-style" runat="server">
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButPostIt" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Post" />
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Close" />
        </div>
    </div>
</asp:Content>
