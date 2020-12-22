<%@ Page Title="Product Maintenance" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductMaintenance.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Product Maintenance"></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                <div class="form-group mx-auto">
                    <label>Product Code</label>
                    <asp:TextBox ID="TxtAcctType" runat="server" class="form-control input-style"></asp:TextBox>    
                </div>
                <div class="form-group mx-auto">
                    <label>Product Name</label>
                    <asp:TextBox ID="TxtAcctName" runat="server" class="form-control input-style" ></asp:TextBox>    
                </div>
                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Lending Rate</label>
                                <div class="row justify-content-center mt-3">
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="TxtLendRate" value="0" runat="server" class="form-control input-style" ></asp:TextBox>    
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:DropDownList ID="DDPaFlat" CssClass="form-control select-style" runat="server">
                                            <asp:ListItem>PA</asp:ListItem>
                                            <asp:ListItem>Flat</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group mx-auto">
                               <label>Deposit Rate</label>
                                <div class="row justify-content-center mt-3">
                                    <div class="col-lg-6">
                                       <asp:TextBox ID="TxtDepRate" value="0" runat="server" class="form-control input-style" ></asp:TextBox>    
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:DropDownList ID="DropDownList2" CssClass="form-control select-style" runat="server">
                                            <asp:ListItem>PA</asp:ListItem>
                                            <asp:ListItem>Flat</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                             <div class="form-group mx-auto">
                               <label>Type</label>
                               <asp:DropDownList CssClass="form-control select-style" ID="DDProdType" runat="server" AutoPostBack="True">
                                    <asp:ListItem>SAVINGS</asp:ListItem>
                                    <asp:ListItem>CURRENT</asp:ListItem>
                                    <asp:ListItem>LOANS</asp:ListItem>
                                    <asp:ListItem>OVERDRAFT</asp:ListItem>
                                    <asp:ListItem>FIXED</asp:ListItem>
                                    <asp:ListItem>OTHERS</asp:ListItem>
                                </asp:DropDownList>   
                            </div>                           
                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>MGT Free Rate/COT</label>
                            <div class="row justify-content-center mt-3">
                                <div class="col-lg-6">
                                    <asp:TextBox ID="TxtCOTRate" value="0" runat="server" class="form-control input-style" ></asp:TextBox>    
                                </div>
                                <div class="col-lg-6">
                                    <asp:DropDownList ID="DDProdDrCr" CssClass="form-control select-style" runat="server" AutoPostBack="True">
                                        <asp:ListItem>Credit</asp:ListItem>
                                        <asp:ListItem>Debit</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                          
                          <div class="form-group mx-auto">
                           <label>GL Mirror Account</label>
                              <asp:DropDownList ID="DDGLMirAcct" CssClass="form-control select-style" runat="server" AutoPostBack="True">
                              </asp:DropDownList>
                        </div>
                          <div class="form-group mx-auto">
                           <label>Int Min. Balance</label>
                           <asp:TextBox ID="TxtIntMinBal" value="0" runat="server" class="form-control input-style"></asp:TextBox>    
                        </div>
                    </div>

                </div>
            </div> 
        </div>

        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                <!-- input fields -->                
                <div class="row mt-2">
                    <div class="col-lg-6">
                        <div class="form-group mx-auto">
                            <label>GL Int Debit Account</label>
                            <asp:DropDownList ID="DDGLDrActDr" CssClass="form-control select-style" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group mx-auto">
                            <label>GL MGT Fee DR Account</label>
                            <asp:DropDownList ID="DDCOTActDr" CssClass="form-control select-style" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group mx-auto">
                            <label>Withdrawal Limit</label>
                            <asp:TextBox ID="TxtWithLimit" runat="server" value="0" class="form-control input-style"></asp:TextBox>
                        </div>
                         <div class="form-group mx-auto">
                            <label>Dormant Link</label>
                            <asp:DropDownList ID="DDorLink" runat="server" class="form-control input-style"></asp:DropDownList>
                        </div>
                        <div class="form-group mx-auto">
                            <label>Interest On Balance</label>
                            <asp:TextBox ID="DDIntOnBal" runat="server" class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-lg-6">
                        <div class="form-group mx-auto">
                            <label>GL Int Credit Account</label>
                            <asp:DropDownList ID="DDGLCrActDr" CssClass="form-control select-style" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group mx-auto">
                            <label>GL MGT Fee CR Account</label>
                            <asp:DropDownList ID="DDCOTActCr" CssClass="form-control select-style" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="form-group mx-auto">
                            <label>Dormant Period</label>
                            <asp:DropDownList ID="TxtDorPeriod" CssClass="form-control select-style" runat="server">
                            </asp:DropDownList>
                        </div>


                        <div class="form-group mx-auto">
                            <label>A/C No Auto Gen:</label>
                            <asp:DropDownList ID="DDAcctAutoGen" CssClass="form-control select-style" runat="server">
                                <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem>
                            </asp:DropDownList>
                        </div>                        
                        <div class="form-group mx-auto">
                            <label>Product Link</label>
                            <div class="row justify-content-center mt-3">
                                <div class="col-lg-6">
                                    <asp:DropDownList ID="DDProdLink" CssClass="form-control select-style" runat="server">
                                    </asp:DropDownList>
                                </div>
                                <div class="col-lg-6">
                                    <asp:DropDownList ID="DDProdLinkDrCr" CssClass="form-control select-style" runat="server">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                       
                    </div>

                </div>
            </div>
        </div>


        <div class="buttons row justify-content-center">
            <asp:Button ID="ButAdd" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Add" />
            <asp:Button ID="ButSave" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Save" />
            <asp:Button ID="ButSearch" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Search" />
            <asp:Button ID="ButEdit" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Edit" />
            <asp:Button ID="ButPrevious" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Previous" />
            <asp:Button ID="ButNext" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Next" />
            <asp:Button ID="ButPrint" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Print" />
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Close" />
        </div>
    </div>
</asp:Content>
