<%@ Page Title="Customer Registration" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustAcctAdmini.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Customer Registration" ></asp:Label>
            <p>Account Opening Authorization</p>
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
                                <asp:DropDownList ID="DDMaritalStatus" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>Married</asp:ListItem>
                                    <asp:ListItem>Single</asp:ListItem>
                                    <asp:ListItem>Widower</asp:ListItem>
                                    <asp:ListItem>Widow</asp:ListItem>
                                    <asp:ListItem>Divorced</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                             <div class="form-group mx-auto">
                                <label>State</label>
                                <asp:DropDownList ID="DDState" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>Abia</asp:ListItem>
                                    <asp:ListItem>Adamawa</asp:ListItem>
                                    <asp:ListItem>Akwa-Ibom</asp:ListItem>
                                    <asp:ListItem>Anambra</asp:ListItem>
                                    <asp:ListItem>Bauchi</asp:ListItem>
                                    <asp:ListItem>Bayelsa</asp:ListItem>
                                    <asp:ListItem>Benue</asp:ListItem>
                                    <asp:ListItem>Borno</asp:ListItem>
                                    <asp:ListItem>Cross river</asp:ListItem>
                                    <asp:ListItem>Delta</asp:ListItem>
                                    <asp:ListItem>Ebonyi</asp:ListItem>
                                    <asp:ListItem>Edo</asp:ListItem>
                                    <asp:ListItem>Ekiti</asp:ListItem>
                                    <asp:ListItem>Enugu</asp:ListItem>
                                    <asp:ListItem>Federal Capital Territory</asp:ListItem>
                                    <asp:ListItem>Gombe</asp:ListItem>
                                    <asp:ListItem>Imo</asp:ListItem>
                                    <asp:ListItem>Jigawa</asp:ListItem>
                                    <asp:ListItem>Kaduna</asp:ListItem>
                                    <asp:ListItem>Kano</asp:ListItem>
                                    <asp:ListItem>Katsina</asp:ListItem>
                                    <asp:ListItem>Kebbi</asp:ListItem>
                                    <asp:ListItem>Kogi</asp:ListItem>
                                    <asp:ListItem>Kwara</asp:ListItem>
                                    <asp:ListItem>Lagos</asp:ListItem>
                                    <asp:ListItem>Nasarawa</asp:ListItem>
                                    <asp:ListItem>Niger</asp:ListItem>
                                    <asp:ListItem>Ogun</asp:ListItem>
                                    <asp:ListItem>Ondo</asp:ListItem>
                                    <asp:ListItem>Osun</asp:ListItem>
                                    <asp:ListItem>Oyo</asp:ListItem>
                                    <asp:ListItem>Plateau</asp:ListItem>
                                    <asp:ListItem>Rivers</asp:ListItem>
                                    <asp:ListItem>Sokoto</asp:ListItem>
                                    <asp:ListItem>Taraba</asp:ListItem>
                                    <asp:ListItem>Yobe</asp:ListItem>
                                    <asp:ListItem>Zamfara</asp:ListItem>
                                </asp:DropDownList>
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
                <div class="form-group mx-auto">
                    <label>Authorized By</label>
                    <asp:TextBox ID="TxtAuthorizedBy" runat="server" class="form-control input-style"></asp:TextBox>
                </div>

                <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Business Category</label>
                               <asp:DropDownList
                                    ID="DDBussCategory" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>Small</asp:ListItem>
                                    <asp:ListItem>Medium</asp:ListItem>
                                    <asp:ListItem>Large</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                            <div class="form-group mx-auto">
                                <label>C.S.O</label>
                                <asp:TextBox ID="TxtCSO" runat="server" class="form-control input-style"></asp:TextBox>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Activate SMS</label>
                                <asp:CheckBox ID="CheckSMS" runat="server" />
                            </div>
                             <div class="form-group mx-auto">
                                <label>Salary/Special Account</label>
                                 <asp:CheckBox ID="ChkSalAcct" runat="server" />
                            </div>
                        </div>

                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                                <label>Business Sector</label>
                                <asp:DropDownList
                                    ID="DDBussSector" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>Agriculture/Forestry</asp:ListItem>
                                    <asp:ListItem>Building/Construction/Real Estate development</asp:ListItem>
                                    <asp:ListItem>Transportation/Storage</asp:ListItem>
                                    <asp:ListItem>Government/MDAs</asp:ListItem>
                                    <asp:ListItem>Manufacturing/Producing</asp:ListItem>
                                    <asp:ListItem>Mining/Quarrying/Mineral business</asp:ListItem>
                                    <asp:ListItem>Consumer durables/household items</asp:ListItem>
                                    <asp:ListItem>General Commerce/Traders/Importers/Exporters</asp:ListItem>
                                    <asp:ListItem>Professionals - Journalists/Lawyers/Accountants etc.</asp:ListItem>
                                    <asp:ListItem>Financial Services/banking/Insurance/capital Markets </asp:ListItem>
                                    <asp:ListItem>Communications/Tele-communications</asp:ListItem>
                                    <asp:ListItem>Hospitals/Healthcare/Pharmaceuticals</asp:ListItem>
                                    <asp:ListItem>Hotels/Hospitality/Leisure</asp:ListItem>
                                    <asp:ListItem>Automobiles/Automobile Products</asp:ListItem>
                                    <asp:ListItem>Education/Schools</asp:ListItem>
                                    <asp:ListItem>Oil &amp; Gas</asp:ListItem>
                                    <asp:ListItem>Power/Energy </asp:ListItem>
                                    <asp:ListItem>Water supply, sewage, waste management </asp:ListItem>
                                    <asp:ListItem>Arts/ entertainment </asp:ListItem>
                                    <asp:ListItem>Activities of extra-territorial organizations and bodies </asp:ListItem>
                                    <asp:ListItem>Military/Law Enforcement </asp:ListItem>
                                    <asp:ListItem>Religious services</asp:ListItem>
                                    <asp:ListItem>Others/Miscelaneous</asp:ListItem>
                                </asp:DropDownList>
                            </div>

                            <div class="form-group mx-auto">
                                <label>Account Officer</label>
                                 <asp:DropDownList
                                    ID="DDAcctOfficer" CssClass="form-control select-style" runat="server">
                                    <asp:ListItem>None</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group mx-auto">
                                <label>New Customer</label>
                                <asp:CheckBox ID="CheckNewCustomer" CssClass="" runat="server" AutoPostBack="True" />
                            </div>
                             <div class="form-group mx-auto">
                                <label>Activate Online</label>
                                <asp:CheckBox ID="CheckOnline" runat="server" />
                            </div>
                            
                        </div>
                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButGenNewAcct" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Add New Account No" />
            <asp:Button ID="ButSave" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Save" />
            <asp:Button ID="ButEdit" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Edit" />
            <asp:Button ID="Button2" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Print Customer List" />
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Close" />
            <asp:Button ID="ButAuthorize" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Authorize" />
            <asp:Button ID="ButDelete" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Delete" />
            <asp:Button ID="ButCreditBee" CssClass="btn btn-outline-primary" runat="server" Text="Credit Bureau Link"/>
        </div>
    </div>
</asp:Content>