
<%@ Page Title="Loan Model Report Selection" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RepSelLoModel.aspx.vb" Inherits="RepSelLoModel" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-2">
        <h4 style="font-weight: bold;">Loan Model Report Selection</h4>
        <p>Please kindly fill in the details below.</p>
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


            <%-- Date range picker --%>
                <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-2" style="">
                        <label class="mr-3">Loan Model</label>
                     <asp:DropDownList ID="DDLendModel" runat="server" CssClass="form-control">
                            <asp:ListItem value="002" >None</asp:ListItem>
                            <asp:ListItem value="002" >Individuals</asp:ListItem>
                            <asp:ListItem value="002" >Solidarity Group</asp:ListItem>
                            <asp:ListItem value="002" >Cashier 4</asp:ListItem>
                            <asp:ListItem value="005" >Cashier 5</asp:ListItem>
                            <asp:ListItem value="006" >Cashier 6</asp:ListItem>
                            <asp:ListItem value="007" >OBC</asp:ListItem>
                            <asp:ListItem value="008" >Entries</asp:ListItem>
                           
                            
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







