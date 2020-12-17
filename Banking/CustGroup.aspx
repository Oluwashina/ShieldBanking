<%@ Page Title="Customer Group Admin" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustGroup.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header text-center mt-5">
            <asp:Label ID="Label7" runat="server" class="h4" Text="Customer Group Admin" ></asp:Label>
        </div>
        <%-- Form --%>
        <div class="row justify-content-center mt-3">
            <div class="col-lg-6">
                    <!-- input fields -->
                    <div class="form-group mx auto">
                        <div class="input-group">
                            <asp:TextBox ID="TxtSurname" runat="server" CssClass="form-control input-style" placeholder="Search.." AutoPostBack="True"></asp:TextBox>
                            <asp:Button ID="ButSearchSur" CssClass="btn btn-sm btn-outline-primary"  runat="server" Text="Search By Name" />
                        </div>
                    </div>
                   <div class="form-group mx-auto">
                       <label>Group No</label>
                       <asp:TextBox ID="TxtGroupNo" runat="server" class="form-control input-style" ReadOnly="true"></asp:TextBox>    
                   </div>
                    <div class="form-group mx-auto">
                           <label>Group Name</label>
                           <asp:TextBox ID="TxtGroupName" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                    </div>

                    <div class="row mt-2">
                        <div class="col-lg-6">
                            <div class="form-group mx-auto">
                               <label>Contact Person</label>
                               <asp:TextBox ID="TxtContPerson" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                            <div class="form-group mx-auto">
                               <label>E-mail Address</label>
                               <asp:TextBox ID="TxtEmail" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                            </div>

                        </div>

                      <div class="col-lg-6">
                        <div class="form-group mx-auto">
                           <label>Mobile Phone</label>
                           <asp:TextBox ID="TextMobile" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                          <div class="form-group mx-auto">
                           <label>Date Created</label>
                           <asp:TextBox ID="TxtDateCreated" runat="server" class="form-control input-style" ReadOnly="true" ></asp:TextBox>    
                        </div>

                    </div>
                </div>

            </div> 
        </div>
        <div class="buttons row justify-content-center">
            <asp:Button ID="ButClose" CssClass="btn btn-primary mr-3" runat="server" Text="Add New" />
            <asp:Button ID="ButDelete" CssClass="btn btn-primary mr-3" runat="server"  Text="Save" />
            <asp:Button ID="ButSave" CssClass="btn btn-primary mr-3" runat="server" Text="Edit" />
            <asp:Button ID="ButEdit" CssClass="btn btn-primary mr-3" runat="server" Text="Print Group List" />
            <asp:Button ID="ButPrevious" CssClass="btn btn-primary" runat="server" Text="Close" />
        </div>
    </div>
</asp:Content>