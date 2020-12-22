
<%@ Page Title="SMS Control" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="SMSControl.aspx.vb" Inherits="SMSControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">SMS Control</h4>
        <p>This provides a means of controlling your sms.</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
           
              <div class="row mt-2">
                <div class="col-lg-12">
                    <div class="form-group" style="">
                <label>SMS Amount per message</label>
                        <asp:TextBox ID="TxtOffInit" runat="server" class="form-control input-style"
                 Visible="True" AutoPostBack="True"></asp:TextBox>
                       
                 </div>
                </div>
            </div>

            <%-- Tables Display --%>
            <div class="mt-2">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server" Height="238px" ScrollBars="Auto">
                <asp:GridView ID="GridViewDet" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="Small" Height="1px" Style="left: 230px; top: 299px" Width="771px">
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="acctno" HeaderText="Account No" SortExpression=" " />
                        <asp:BoundField DataField="acctname" HeaderText="Account Name" SortExpression=" " />
                        <asp:BoundField DataField="dramt" HeaderText="Debit Amount" />
                        <asp:BoundField DataField="cramt" HeaderText="Credit Amount" />
                        <asp:BoundField DataField="balamt" HeaderText="Account Balance" />
                        <asp:BoundField DataField="trndate" HeaderText="Trans. Date" />
                        <asp:BoundField DataField="particular" HeaderText="Particulars" />
                        <asp:BoundField DataField="chgamount" HeaderText="SMS Amount" />
                        <asp:BoundField DataField="successful" HeaderText="Sucessful" />
                    </Columns>
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                </asp:GridView>
            </asp:Panel>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>  
                </div>

        </div>

    </div>

    <div class="text-center mt-4 mb-3">
                <asp:Button ID="ButSend" runat="server" class="btn btn-outline-primary mr-2"  Text="Send"  />
                     <asp:Button ID="ButDelete" runat="server" class="btn btn-outline-primary mr-2"  Text="Delete"  />
                <asp:Button ID="ButClear" runat="server" class="btn btn-outline-primary mr-2"  Text="Clear"/>
                  <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
        </div>

    

</asp:Content>
