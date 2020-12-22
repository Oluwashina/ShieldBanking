<%@ Page Title="Final Account Reports" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RepSelFinalDate.aspx.vb" Inherits="RepSelFinalDate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-2">
        <h4 style="font-weight: bold;">Final Account Reports</h4>
        <p>Please kindly fill in the details below for Posting Authorization.</p>
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
                <div class="col-lg-6">
                   <div class="form-group" style="">
                        <label>Report Type:</label>
                       <asp:DropDownList ID="DDRepType" runat="server" CssClass="form-control">
                            <asp:ListItem value="002" >Trial Balance</asp:ListItem>
                            <asp:ListItem value="002" >Profit & Loss</asp:ListItem>
                            <asp:ListItem value="002" >Balance Sheet</asp:ListItem>           
                        </asp:DropDownList>
                    </div>
                </div>
                 

                  <div class="col-lg-6">
                    <div class="form-group" style="">
                        <label>Period Type:</label>
                      <asp:DropDownList ID="DDPeriodType" runat="server" CssClass="form-control">
                            <asp:ListItem value="002" >Cummulative</asp:ListItem>
                            <asp:ListItem value="002" >Single</asp:ListItem>           
                          
                        </asp:DropDownList>
                </div>
            </div>
                  </div>

            <%-- Date range picker --%>
                <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-2" style="">
                        <label class="mr-3">As At</label>
                        <asp:DropDownList ID="DOBDayFrom" runat="server" Width="40px">
                    </asp:DropDownList>
                           <asp:DropDownList ID="DOBMonthFrom" runat="server"  Width="48px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DOBYearFrom" runat="server"  Width="58px">
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





