<%@ Page Title="Account officer" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AccountOfficer.aspx.vb" Inherits="AccountOfficer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Account Officer File" ></asp:Label>

        </div>
        
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                   <div class="form-group mx-auto" style="width: 80%;">
                       <label>User ID</label>
                       <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                       <asp:TextBox ID="TxtOffInit" runat="server" class="form-control input-style" ></asp:TextBox>    
                   </div>

                    <div class="form-group mt-2 mx-auto" style="width: 80%;">
                        <label>Officer Name</label>
                         <asp:TextBox ID="TxtNarration" runat="server" class="form-control input-style"></asp:TextBox>     
                    </div>
            </div>
        </div>
        <%-- table --%>
        <div class="row justify-content-center">
            <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" >
            <asp:GridView ID="GridViewDet" runat="server" AllowSorting="True" style="width: 100%;" AutoGenerateColumns="False">
                <RowStyle />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="officerinitial" HeaderText="Officer Initials" SortExpression="officerinitial" />
                    <asp:BoundField DataField="narration" HeaderText="Narration" SortExpression="narration" />
                </Columns>
                <FooterStyle />
                <PagerStyle />
                <SelectedRowStyle BackColor="#FFCC66"  />
                <HeaderStyle />
            </asp:GridView>
            </asp:Panel>
        </div>
         <%-- buttons --%>
            <div class="row justify-content-center mt-3 mb-3">
                <asp:Button ID="ButSave" runat="server" Text="Save" class="btn btn-outline-primary mr-3" />
                <asp:Button ID="ButEdit" runat="server" Text="Edit" class="btn btn-outline-primary mr-3" />
               <%-- <asp:Button ID="ButPrev" runat="server" Text="Previous" class="btn btn-outline-primary mr-3" />
                <asp:Button ID="ButNext" runat="server"  Text="Next" class="btn btn-outline-primary mr-3" />--%>
                <asp:Button ID="ButClose" runat="server" Text="Close" class="btn btn-outline-primary mr-3"/>
                <asp:Button ID="ButDelete" runat="server" Text="Delete" class="btn btn-outline-primary" />
            </div>
    </div>
</asp:Content>
