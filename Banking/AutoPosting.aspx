<%@ Page Title="Auto Posting" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoPosting.aspx.vb" Inherits="Banking._Default" EnableSessionState="True" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Auto Posting</h4>
        <p>Please kindly fill in the details below for Auto Posting</p>
    </div>

    
    <div class="row justify-content-center">
        <div class="col-lg-6">
            
           
              <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>User Name</label>
                     <asp:TextBox ID="TxtCurrUser" Text="admin" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Posting Balance</label>
                        <asp:TextBox ID="TxtPostingAmt" Text="0" class="form-control input-style" runat="server" ReadOnly="True"></asp:TextBox>  
            </div>
                </div>
            </div>
              <div class="row">
                <div class="col-lg-12">
                    <div class="form-group mt-3" style="">
                        <label>Trans Date</label>
                        <asp:TextBox ID="DTPJTransDate" runat="server"
                            Text="12/23/2020" ReadOnly="true"
                              class="form-control input-style"></asp:TextBox>
                        </div>
                    </div>
               </div>

            <div class="row mt-3">
                <div class="col-lg-12">
                     <asp:FileUpload ID="FileUpload1" runat="server" />
                     <asp:Button ID="ButUpLoad" runat="server" class="btn btn-primary mr-2"  Text="Upload"  />
                </div>
            </div>



            

        </div>

    </div>

    <div class="text-center mt-5 mb-3">
                <asp:Button ID="ButPost" runat="server" class="btn btn-outline-primary mr-2"  Text="Post"  />
                     <asp:Button ID="ButClear" runat="server" class="btn btn-outline-primary mr-2"  Text="Clear"/>
                  <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
        </div>

    

</asp:Content>
