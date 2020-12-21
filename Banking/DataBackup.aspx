<%@ Page Title="Data Backup" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataBackup.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="text-center mt-5">
        <h4 style="font-weight: bold;">Data Backup</h4>
        <p>This provides a means to backup your files.</p>
    </div>


    <div class="row justify-content-center">
        <div class="col-lg-6">


            <div class="mt-2">
                <p class="mb-0">Select a process for backup</p>
                 <div class="mt-1">
                     <asp:RadioButton ID="RadPreProcess" runat="server" GroupName="backup" Checked="true" AutoPostBack="True" />
                    <label class="form-check-label ml-2" for="RadPreProcess">
                         Pre-processed
                    </label>
                    </div>

                 <div class="">
                     <asp:RadioButton  ID="RadProcessed" GroupName="backup" runat="server" AutoPostBack="True" />
                    <label class="form-check-label ml-2" for="exampleRadios1">
                         Processed
                    </label>
                    </div>

               </div>

   
               <div class="row mt-3">
                    <div class="col-lg-12">
                        <div class="form-group" style="">
                    <label>Backup Data to:</label>
                            <asp:TextBox ID="TxtBackupTo" runat="server" class="form-control input-style"
                                Text="C:\Inetpub\wwwroot\ShieldBanking\BackUpDir\Bankerdata.mdb"
                     Visible="True"></asp:TextBox>
                       
                     </div>
                    </div>
            </div>

        </div>
    </div>
    
    <div class="text-center mt-3">
         <asp:Button ID="ButBackup" runat="server" class="btn btn-primary mr-2"  Text="BackUp"  />
    </div>


</asp:Content>