
<%@ Page Title="Daily Transaction Listing" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RepSelUserDate.aspx.vb" Inherits="Banking._Default" EnableSessionState="True" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Daily Transaction Listing</h4>
        <p>Please kindly fill in the details below for Daily Transaction Listing</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
           
              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>User Name</label>
                     <asp:TextBox ID="TxtCurrUser" Text="" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                      <label>User ID</label>
                         <asp:DropDownList ID="DDUserID" runat="server" CssClass="form-control select-style">
                            <asp:ListItem>admin</asp:ListItem>
                            <asp:ListItem>Cashier 1</asp:ListItem>
                            <asp:ListItem>Cashier 2</asp:ListItem>
                            <asp:ListItem>gbenga</asp:ListItem>
                            <asp:ListItem>tolu</asp:ListItem>   
                        </asp:DropDownList>
                      </div>
                </div>
            </div>

            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group">
                        <label>From:</label>
                          <asp:DropDownList ID="DOBDayFrom" runat="server"  Width="40px">
                        </asp:DropDownList>
                    <asp:DropDownList ID="DOBYearFrom" runat="server" Width="58px">
                    </asp:DropDownList>
                    <asp:DropDownList ID="DOBMonthFrom" runat="server"  Width="48px">
                    </asp:DropDownList>
                    </div>
          
                </div>
                <div class="col-lg-6">
                    <div class="form-group">
                        <label>To:</label>
                         <asp:DropDownList ID="DOBDayTo" runat="server"  Width="40px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="DOBYearTo" runat="server"  Width="58px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="DOBMonthTo" runat="server" Width="48px">
                        </asp:DropDownList>
                      </div>
                </div>          
            </div>

            <asp:Calendar ID="mCalendar" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
        BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
        ForeColor="#663399" Height="200px" ShowGridLines="True" Style="position: absolute; left: -265px; top: -49px;"
        Visible="False" Width="220px">
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        <SelectorStyle BackColor="#FFCC66" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
    </asp:Calendar>


             <div class="text-center mt-4 mb-3">
           <asp:Button ID="ButOK" runat="server" class="btn btn-primary mr-2"  Text="OK"  />      
      </div>
                     

        </div>
    </div>

   

    

</asp:Content>

