
<%@ Page Title="User Maintenance" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAdmin.aspx.vb" Inherits="Banking._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="text-center mt-5">
        <h4 style="font-weight: bold;">User Maintenance</h4>
        <p>Here you can assign and maintain the users in your system.</p>
    </div>

    <div class="row justify-content-center">
        <div class="col-lg-7">
     
            <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>User ID</label>
                     <asp:TextBox ID="TxtUserID" class="form-control input-style" runat="server"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Username</label>
                        <asp:TextBox ID="TxtUserName" class="form-control input-style" runat="server"></asp:TextBox>  
            </div>
                </div>
            </div>

                <div class="row mt-2">
                <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Password</label>
                     <asp:TextBox ID="TxtPassword" class="form-control input-style" runat="server"></asp:TextBox>                          
            </div>
                </div>
                  <div class="col-lg-6">
                    <div class="form-group" style="">
                <label>Date Created</label>
                      <asp:TextBox ID="TxtCreateDate" class="form-control input-style" runat="server"></asp:TextBox>  
            </div>
                </div>
            </div>

            <%--Checkbox section--%>
            <div class="mt-3">
                <asp:CheckBox ID="ChkAll" runat="server"  AutoPostBack="True" />
                 <label class="form-check-label ml-2" for="RadPreProcess">
                             All rights
                     </label>

            </div>

            <div class="row mt-2">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkAuthorization" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                   Authorization
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkPostRealTime" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                  Front Office Posting
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkAcctOffAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                   Account Officer Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkGenLedgAdm" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                  General Ledger Admin
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkGroupAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                   Group A/C Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkBackOff" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                  Back Office Posting
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkBranchSetup" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                   Branch Setup
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkGLAcctBalance" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                  GL Account Balance
                                </label>

                      </div>
                </div>
            </div>
            
            <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkVaultOPAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                   Vault Operation Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkStandMaint" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Standing Order Maint.
                                </label>

                      </div>
                </div>
            </div>

               <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkLoadAdm" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                  Loan Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkChangePWord" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Change Password
                                </label>

                      </div>
                </div>
            </div>

             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkFDepositAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                  Fixed Deposit Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkCustAcctOpen" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Customer Account Opening
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkSalaryPosting" runat="server"  />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                 Salary Posting
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkSMSChg" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 SMS Charges
                                </label>

                      </div>
                </div>
            </div>

             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkFAssetGroupAdm" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                 Fixed Asset Group Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkCustAcctFlag" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Customer Account Flaging
                                </label>

                      </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkAcctOfficerSum" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                 Account Officer Summary
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkSMSCont" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 SMS Control
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkFAssetAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                 Fixed Asset Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkDailyproc" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Daily Process
                                </label>

                      </div>
                </div>
            </div>

              <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkCustAcctBal" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                 Customer Account Balance
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkSpecChg" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Special Charges
                                </label>

                      </div>
                </div>
            </div>

             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkFAssetDisposal" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                                Fixed Asset Disposal
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkRunMothlyAnaly" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                                 Run Monthly Analysis
                                </label>

                      </div>
                </div>
            </div>

             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkUserPassAdm" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                               User Password Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkSystemBack" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                               System Backup
                                </label>

                      </div>
                </div>
            </div>

            
             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkBudgetAdmin" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                              Budget Admin
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkAnnualProc" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                               Annual Processing
                                </label>

                      </div>
                </div>
            </div>

            
             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkManRep" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                             Management Reports
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkBankSet" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                               Bank Setup
                                </label>

                      </div>
                </div>
            </div>

            
             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkAutoPosting" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                               Auto Posting
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkDailyTransList" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                              Daily Transaction Listing
                                </label>

                      </div>
                </div>
            </div>

            
             <div class="row">
                <div class="col-lg-6 mb-2">
                        <div>
                        <asp:CheckBox ID="ChkLoanRepay" runat="server"  AutoPostBack="True" />
                         <label class="form-check-label ml-2" for="RadPreProcess">
                              Loan Repayment
                             </label>

                    </div>
                </div>
                <div class="col-lg-6 mb-2">
                     <div>
                        <asp:CheckBox ID="ChkProdMaint" runat="server"  AutoPostBack="True" />
                            <label class="form-check-label ml-2" for="RadPreProcess">
                               Product Maintenance
                                </label>

                      </div>
                </div>
            </div>
            
   
        </div>
    </div>


     <div class="text-center mt-4 mb-3">
                <asp:Button ID="ButSave" runat="server" class="btn btn-outline-primary mr-2"  Text="Save"  />
                <asp:Button ID="ButEdit" runat="server" class="btn btn-outline-primary mr-2"  Text="Edit"/>
                     <asp:Button ID="ButSearch" runat="server" class="btn btn-outline-primary mr-2"  Text="Search"  />
                <asp:Button ID="ButDelete" runat="server" class="btn btn-outline-primary mr-2"  Text="Delete"/>
                  <asp:Button ID="ButClose" runat="server" class="btn btn-outline-primary"  Text="Close"/>
            </div>


</asp:Content>
