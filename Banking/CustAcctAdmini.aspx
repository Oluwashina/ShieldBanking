<%@ Page Title="Customer Registration" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustAcctAdmini.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Customer Registration" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                <div class="form-group mx auto">
                    <div class="input-group">
                        <asp:TextBox ID="TxtSurname" runat="server" CssClass="form-control input-style" placeholder="Enter Surname" AutoPostBack="True"></asp:TextBox>
                        <asp:Button ID="ButSearchSur" CssClass="btn btn-sm btn-outline-primary" runat="server" Text="Search By Surname" />
                    </div>
                </div>
                <div class="form-group mx-auto">
                    <label>Customer Name</label>
                    <asp:DropDownList ID="DDCustName" runat="server" CssClass="form-control select-style" AutoPostBack="True">
                        <asp:ListItem>New Customer</asp:ListItem>
                    </asp:DropDownList>                    
                </div>
                    <div class="form-group mx-auto">
                           <label>Account Type</label>
                            <asp:DropDownList ID="DDAcctType" runat="server" CssClass="form-control select-style"></asp:DropDownList>      
                    </div>

                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Account No</label>
                               <asp:TextBox ID="TxtCustNo" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                                <label>Firstname</label>
                                <asp:TextBox ID="TxtCustFirstrname" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>E-mail Address</label>
                                <asp:TextBox ID="TxtEmail" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Old Customer No</label>
                                <asp:TextBox ID="TxtAcctNo" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>

                             <div class="form-group mx-auto">
                                <label>Nationality</label>
                                <asp:TextBox ID="DDNationality" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>Marital Status</label>
                                <asp:TextBox ID="DDMaritalStatus" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>State</label>
                                <asp:TextBox ID="DDState" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                                <label>Surname</label>
                                <asp:TextBox ID="TxtCustName" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Middlename</label>
                                <asp:TextBox ID="TxtCustMiddleName" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>Mobile Phone</label>
                                <asp:TextBox ID="TxtMobile" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>Date Of Birth</label>
                                <asp:TextBox ID="TextBox6" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>Date Opened</label>
                                <asp:TextBox ID="TextBox8" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>Sex</label>
                                 <asp:DropDownList ID="DDListSex" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Corporate</asp:ListItem>
                                    <asp:ListItem>Group</asp:ListItem>
                                </asp:DropDownList>                               
                            </div>
                             <div class="form-group mx-auto">
                                <label>L.G.A</label>
                                <asp:TextBox ID="TxtLGA" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                </div>

                <div class="form-group mx-auto">
                    <label>City</label>
                    <asp:TextBox ID="TxtCity" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Home Address</label>
                    <asp:TextBox ID="TxtHomeAddr" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Postal Address</label>
                    <asp:TextBox ID="TxtPostAddr" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Group Name</label>
                    <asp:DropDownList ID="DDGroup" runat="server" CssClass="form-control select-style">
                        <asp:ListItem>None</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group mx-auto">
                    <label>Spouse Surname</label>
                    <asp:TextBox ID="TxtSpouseSurname" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Spouse Firstname</label>
                    <asp:TextBox ID="TxtSpouseFirstNAme" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Spouse Middlename</label>
                    <asp:TextBox ID="TxtSpouseMiddleName" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>B.V.N</label>
                    <asp:TextBox ID="TxtBVN" runat="server" class="form-control input-style"></asp:TextBox>
                </div>
                <div class="form-group mx-auto">
                    <label>Bank</label>
                    <asp:DropDownList ID="DDBanksName" CssClass="form-control select-style" runat="server">
                    </asp:DropDownList>                    
                </div>

                <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Business Category</label>
                               <asp:TextBox ID="DDBussCategory" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                                <label>C.S.O</label>
                                <asp:TextBox ID="TextBox21" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>Authorized By</label>
                                <asp:TextBox ID="TextBox22" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Activate SMS</label>
                                <asp:TextBox ID="TextBox23" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                                <label>Business Sector</label>
                                <asp:TextBox ID="TextBox27" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Account Officer</label>
                                <asp:TextBox ID="TextBox28" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            <div class="form-group mx-auto">
                                <label>New Customer</label>
                                <asp:TextBox ID="TextBox26" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>Activate Online</label>
                                <asp:TextBox ID="TextBox25" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                             <div class="form-group mx-auto">
                                <label>Salary/Special Account</label>
                                <asp:TextBox ID="TextBox24" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>
                            </div>
                            
                        </div>
                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Add New" />
            <asp:Button ID="ButDelete" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Save" />
            <asp:Button ID="ButSave" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Edit" />
            <asp:Button ID="ButEdit" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Print Group List" />
            <asp:Button ID="ButPrevious" CssClass="btn btn-outline-primary" runat="server" Text="Close" />
        </div>
    </div>
</asp:Content>