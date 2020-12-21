
<%@ Page Title="Posting Authorization" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Authorise.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Postings Authorization</h4>
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

            <div class="mt-2">
                 <asp:Panel ID="PanDetails" runat="server" Height="246px" ScrollBars="Auto">
                       <asp:GridView ID="GridViewDet" runat="server" AutoGenerateSelectButton="True" CellPadding="4" Font-Size="X-Small" Width="919px" Font-Bold="True" Caption="Transaction Details" ForeColor="#333333" AutoGenerateColumns="False" AllowSorting="True" BorderStyle="None" BorderWidth="1px">
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="transid" HeaderText="transid" SortExpression="transid" />
                                <asp:BoundField DataField="transdate" HeaderText="transdate" SortExpression="transdate" />
                                <asp:BoundField DataField="acctno" HeaderText="acctno" SortExpression="acctno" />
                                <asp:BoundField DataField="acctname" HeaderText="acctname" SortExpression="acctname" />
                                <asp:BoundField DataField="instruno" HeaderText="Instrument No" SortExpression="instruno" />
                                <asp:BoundField DataField="amount" HeaderText="Amount" SortExpression="amount" />
                                <asp:BoundField DataField="drcr" HeaderText="Dr/Cr" SortExpression="drcr" />
                                <asp:BoundField DataField="particular" HeaderText="Particulars" SortExpression="particular" />
                                <asp:BoundField DataField="transno" HeaderText="Trans.No" SortExpression="transno" />
                                <asp:BoundField DataField="curruser" HeaderText="User" SortExpression="curruser" />
                            </Columns>
                            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                    </asp:Panel>

            </div>


            <div class="text-center mt-2">
                 <asp:Button ID="ButPostAll" runat="server" Text="Post All" class="btn btn-primary mr-2" />
                <asp:Button ID="ButClose" runat="server" Text="Close" CssClass="btn btn-secondary" />
            </div>

           

                 
        </div>
    </div>

    
    

</asp:Content>




