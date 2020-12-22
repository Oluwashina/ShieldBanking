﻿
<%@ Page Title="GL Statement Of Accounts" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RepSelGLDate.aspx.vb" Inherits="RepSelGLDate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-2">
        <h4 style="font-weight: bold;">GL Statements Of Account</h4>
        <p>Please kindly fill in the details below for your GL statement of account.</p>
    </div>

    <!--Form-->
    <div class="row justify-content-center">
        <div class="col-lg-6">

             <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-4" style="">
                        <label>User Name</label>
                        <asp:TextBox ID="TxtCurrUser" runat="server" class="form-control input-style" Text="Admin" ReadOnly="true" TabIndex="1"></asp:TextBox>     
                    </div>
                </div>
            </div>

              <div class="row mt-2">
                <div class="col-lg-12">
                   <div class="form-group" style="">
                        <label>GL Account:</label>
                         <asp:DropDownList ID="DDGLNo" runat="server" CssClass="form-control">
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

            <%-- Date range picker --%>
                <div class="row">
                <div class="col-lg-6">
                    <div class="form-group mt-2" style="">
                        <label class="mr-3">From</label>
                        <asp:DropDownList ID="DOBDayFrom" runat="server" Width="40px">
                    </asp:DropDownList>
                           <asp:DropDownList ID="DOBMonthFrom" runat="server"  Width="48px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DOBYearFrom" runat="server"  Width="58px">
                    </asp:DropDownList>

                       
                    </div>
                </div>
                      <div class="col-lg-6">
                    <div class="form-group mt-2" style="">
                        <label class="mr-3">To</label>
                        <asp:DropDownList ID="DOBDayTo" runat="server" Width="40px">
                    </asp:DropDownList>
                           <asp:DropDownList ID="DOBMonthTo" runat="server"  Width="48px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DOBYearTo" runat="server"  Width="58px">
                    </asp:DropDownList>

                       
                    </div>
                </div>
            </div>



            <div class="text-center mt-2">
                 <asp:Button ID="ButOK" runat="server" Text="OK" class="btn btn-primary mr-2" />
            </div>

           

                 
        </div>
    </div>

    
    

</asp:Content>






