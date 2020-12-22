<%@ Page Title="General Ledger Account Admin" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="GLAcctAdmin.aspx.vb" Inherits="GLAcctAdmin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="General Ledger Account Admin" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                   <div class="form-group mx-auto">
                       <label>G/L Account No:</label>
                       <asp:TextBox ID="TxtGLAcctNo" runat="server" class="form-control input-style"></asp:TextBox>    
                   </div>
                    <div class="form-group mx-auto">
                           <label>G/L Account Name</label>
                           <asp:TextBox ID="TxtGLName" runat="server" class="form-control input-style" ></asp:TextBox>    
                    </div>

                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group" style="">
                                <label>G/L Account Type</label>  
                                <asp:DropDownList ID="DDGLAccTyp" runat="server" CssClass="form-control select-style">
                                    <asp:ListItem>Item1</asp:ListItem>
                                    <asp:ListItem>Item2</asp:ListItem>
                                    <asp:ListItem>Item3</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                      <div class="col-lg-6">
                        <div class="form-group" style="">
                            <label>G/L Header Type</label>
                            <asp:DropDownList ID="DDHeader" runat="server" CssClass="form-control select-style">
                                <asp:ListItem>Item1</asp:ListItem>
                                <asp:ListItem>Item2</asp:ListItem>
                                <asp:ListItem>Item3</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <div class="row mt-2">
                    <div class="col-lg-6">
                        <div class="form-group" style="">
                            <label>G/L Account Nature</label>
                             <asp:DropDownList ID="DDGLAcctNat" runat="server" CssClass="form-control select-style">
                                <asp:ListItem>P</asp:ListItem>
                                <asp:ListItem>N</asp:ListItem>
                                <asp:ListItem>None</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="form-group" style="">
                            <label>Date Opened</label>
                            <div class="input-group">
                                <asp:TextBox ID="TxtDateOpen" runat="server" CssClass="form-control input-style"></asp:TextBox>
                                <asp:Button ID="ButChgDate" CssClass="btn btn-sm btn-outline-primary"  runat="server" Text="Change Date" />
                                <asp:Calendar ID="CalStart" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
                                BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
                                ForeColor="#663399" Height="200px" ShowGridLines="True" Style="left: 297px; position: absolute;
                                top: 398px" Visible="False" Width="220px">
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                            </asp:Calendar>
                            </div>
                         </div>
                    </div>
                </div>
            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButClose" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Close" />
           
            <asp:Button ID="ButSave" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Save" />
            <asp:Button ID="ButEdit" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Edit" />
            
            <asp:Button ID="ButPrint" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Print GL List" />

            <asp:Button ID="ButSearch" CssClass="btn btn-outline-primary" runat="server" Text="Search" />
        </div>
    </div>
</asp:Content>