
<%@ Page Title="Loan Amortization Selection Screen" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="RepSelCustLoanList.aspx.vb" Inherits="RepSelCustLoanList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

            <!--Heading-->
    <div class="text-center mt-2">
        <h4 style="font-weight: bold;">Loan Amortization Selection Screen</h4>
        <p>Please kindly fill in the form below.</p>
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
                        <label>Customer Account No:</label>
                     <div class="input-group mb-3">
                       <asp:TextBox ID="DDCustNo" Text="" class="form-control input-style" runat="server"></asp:TextBox>    
                      <div class="input-group-append">
                          <asp:Button ID="ButSearchBy" runat="server" CssClass="btn btn-primary" Text="Search By Surname" />
                      </div>
                    </div> 
                    </div>
                </div>
                 

                  </div>


            <div class="text-center mt-2">
                 <asp:Button ID="ButOK" runat="server" Text="OK" class="btn btn-primary mr-2" />
                  <asp:Button ID="ButClose" runat="server" Text="Close" class="btn btn-secondary mr-2" />
            </div>

           

                 
        </div>
    </div>

    
    

</asp:Content>







