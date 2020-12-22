<%@ Page Title="Vault Out" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VaultOut.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Vault Out Single Entry" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Date</label>
                               <asp:TextBox ID="TxtTransDate" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>Vault Balance</label>
                               <asp:TextBox ID="LblVBalOut" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                             <div class="form-group mx-auto">
                               <label>Total Balance</label>
                               <asp:TextBox ID="LblToBalOut" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Vault Out</label>
                           <asp:TextBox ID="TxtVOut" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Till Balance</label>
                           <asp:TextBox ID="TBalOut" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>
                    </div>

                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButUpdate" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Update" />
            <asp:Button ID="ButClear" CssClass="btn btn-outline-primary mr-3" runat="server" Text="Clear" />
        </div>
    </div>
</asp:Content>
