Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class Login
    ''Inherits Page
    Inherits System.Web.UI.Page
    Dim Con As New Data.SqlClient.SqlConnection
    Public myConnection As Data.SqlClient.SqlConnection
    Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
    Dim mySqlDataAdapterInit As Data.OleDb.OleDbDataAdapter
    Dim ds As New Data.DataSet
    Dim da As Data.SqlClient.SqlDataAdapter
    Dim sql As String
    Dim myDataRow As Data.DataRow
    Dim mLocalChqcode, mTxtPassWord
    Dim mDOtDay, mDOtMonth, mDOtYear


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        ' Dim i
        'TxtUserID.Text = date(Format(TxtUserID.Text))    ' DateFormat.GeneralDate)
        TxtBankID.Focus()


        Session("thebranch") = "01"
        Session("TxtUserID") = Trim(TxtUserID.Text)

        'DOTDay.Items.Clear()
        'For i = 1 To 31
        '    DOTDay.Items.Add(i)
        'Next

        'DOTMonth.Items.Clear()
        'For i = 1 To 12
        '    DOTMonth.Items.Add(i)
        'Next

        'DOTYear.Items.Clear()
        'For i = 2000 To 3000
        '    DOTYear.Items.Add(i)
        'Next

        'Session("mUserID") = Trim(TxtUserID.Text)

        'Session("mTreasuryName") = myDataRow("treasuryname")



    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LblBankName.Text = Session("mBankName")
        TxtBankID.Focus()
        'TxtUserID.Attributes.Add("onkeypress", "alert('test');")
        'TxtUserID.Attributes.Add("onkeypress", TxtPassWord.Focus)
        'ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account does not exist !!!');", True)
        'MsgBox("Account Type does not exist !!!", MsgBoxStyle.Information = MsgBoxStyle.Critical)

    End Sub

    Protected Sub ButtonLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonLog.Click

        'Interaction.Shell()
        'If (Interaction.MsgBox("Do You want to Batch this Transaction ?", MsgBoxStyle.ApplicationModal, MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes) Then
        '    'Batchit()
        'End If

        'Dim myConnection As Data.SqlClient.SqlConnection
        Dim myConnectionInit As Data.OleDb.OleDbConnection
        'Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        Dim myDataRow As Data.DataRow
        'BranchManCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BranchMan.mdb;Mode=Read|Write|Share Deny None;Persist Security Info=False;"
        'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BranchMan.mdb;Mode=Read|Write|Share Deny None;Persist Security Info=False;")
        'You'll need to change the connexion string from “Provider=Microsoft.Jet.OLEDB.4.0; “ to “Provider=Microsoft.ACE.OLEDB.12.0;”   FOR WINDOWS 8 OR ANY 64BITS WINDOW.

        ''THIS IS FOR WINDOWS 8 OR ANY OTHER 64BIT WINDOWS
        'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|BranchMan.mdb;Persist Security Info=True;User ID=Admin")
        'Dim mcompname

        'Session("mCompID") = Trim(TxtCompID.Text)   '"Folion"

        ' Create a new Connection and SqlDataAdapter
        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        ' myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnectionInit = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=True;User ID=Admin;Data Source=|DataDirectory|\InitDoc.mdb")

        myConnectionInit.Open()
        Session("myConnectionInit") = myConnectionInit

        myConnectionInit = Session("myConnectionInit")
        mySqlDataAdapterInit = New Data.OleDb.OleDbDataAdapter("Select * from CompanyID where compalias='" & Trim(TxtBankID.Text) & "'", myConnectionInit)

        'Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilderx As Data.OleDb.OleDbCommandBuilder = New Data.OleDb.OleDbCommandBuilder(mySqlDataAdapterInit)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapterInit.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapterInit.Fill(myDataSet, "CompanyID")

        If myDataSet.Tables("CompanyID").Rows.Count > 0 Then
            myDataRow = myDataSet.Tables("CompanyID").Rows(0)
        Else
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Company Not Found !!!');", True)
            Exit Sub
        End If

        Session("mSuperUser") = myDataRow("userid")

        'If TxtUserID.Text <> myDataRow("userid") Then
        '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid User ID or Password !!!');", True)
        '    Exit Sub
        'End If

        'If TxtPassWord.Text <> myDataRow("userauthority") Then
        '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid User ID or Password !!!');", True)
        '    Exit Sub
        'End If

        Session("mCompID") = myDataRow("CompID")   'Trim(TxtCompID.Text)
        Session("mcompalias") = myDataRow("compalias")
        Session("mcompname") = myDataRow("compname")
        Session("maddress") = myDataRow("address")
        Session("mmobile") = myDataRow("mobile")
        Session("mydbname") = myDataRow("mydbname")
        Session("myusername") = myDataRow("myusername")
        Session("mydatasource") = myDataRow("mydatasource")

        ''ONLY SUPER USERS CAN ACTIVATE ALL OTHER USERS
        'If Session("mSuperUser") = Trim(TxtUserID.Text) Then
        '    If CheckOpenBranch.Checked Then
        '        myDataRow("activated") = True
        '        mySqlDataAdapter.Update(myDataSet.GetChanges, "CompanyID")
        '    End If
        'End If

        ' Create a new Connection and SqlDataAdapter
        Dim myConnection As New SqlConnection
        ''''************** SAMPLE OF HOW TO OPEN A PASSWORD PROTECTED DATABASE *****************
        'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Attendance\\AC215DataBase.mdb;Database Password=852972;User ID=Admin")
        Try
            'Con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BankerData.mdb;Persist Security Info=True"
            'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BankerData.mdb;Persist Security Info=True;User ID=Admin")
            'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb;Persist Security Info=True;User ID=Admin")
            myConnection.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;Connection Timeout=180;")
            'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=|DataDirectory|BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from datacont", myConnection)
            myConnection.Open()
        Catch
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Server not responding, try again later.....');", True)
            Exit Sub
        End Try

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "datacont")

        myDataRow = myDataSet.Tables("datacont").Rows(0)

        If IsDBNull(myDataRow("CashContAcct")) Then
            myDataRow("CashContAcct") = ""
        End If
        If IsDBNull(myDataRow("LastProcDate")) Then
            myDataRow("LastProcDate") = Date.Today
        End If
        'Session("myConnection") = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'Session("myConnection") = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\ShieldBanking\App_Data\BankerData.mdb;Persist Security Info=True")
        Session("SigPath") = "|DataDirectory|imgdata\"
        Session("Gpath") = "|DataDirectory|imgdata\"
        Session("myConnection") = myConnection 'New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb;Persist Security Info=True;User ID=Admin")
        'Session("myConnection") = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=|DataDirectory|BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd="";uid=admin")
        'Session("myConnection") = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=|DataDirectory|BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        Session("mCashContAcct") = myDataRow("CashContAcct")
        Session("mSingleTillAcctNo") = myDataRow("singletillacctno")
        Session("mLastProcDate") = myDataRow("LastProcDate")
        Session("mBankName") = myDataRow("bank")
        Session("mMultiCashCenter") = myDataRow("multicashcenter")
        Session("mCashTranscode") = myDataRow("cashtranscode")
        Session("mLocalChqcode") = myDataRow("localchqcode")
        Session("mInterstateChqcode") = myDataRow("interstatechqcode")
        Session("mTransId") = myDataRow("TransId")
        'Session("mbranchcode") = myDataRow("branchcode")
        Session("multicashcenter") = myDataRow("multicashcenter")
        Session("mloanintacctno") = myDataRow("loanintacctno")
        Session("munauditacct") = myDataRow("unauditacct")
        Session("uncleardays") = myDataRow("uncleardays")
        Session("nextworkingdate") = myDataRow("nextworkingdate")
        Session("accountdigits") = myDataRow("accountdigits")
        Session("PandLcode") = myDataRow("PandLcode")
        Session("fixedassetpost") = myDataRow("fixedassetpost")
        Session("custno") = myDataRow("custno")
        Session("payporate") = myDataRow("applypayporation")
        Session("entriescode") = myDataRow("entriescode")
        Session("branchactivated") = myDataRow("branchactivated")
        Session("intinsuspenceacct") = myDataRow("intinsuspenceacct")

        If Trim(TxtUserID.Text) = "admin" Then

        Else
            If Session("branchactivated") = False Then
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Branch not yet Openned....');", True)
                Exit Sub
            End If
        End If

        ''THIS IS FOR WINDOWS 7 32BITS OR ANY OTHER 32BIT WINDOWS
        ''myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Main\BookOneDB.mdb;Persist Security Info=True;User ID=Admin")
        'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=True;User ID=Admin;Data Source=|DataDirectory|\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb")

        'myConnection.Open()
        Session("myConnection") = myConnection

        TxtBankID.Text = Session("mCompID")

        'LOGIN TO COMPANY ACCOUNT
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1, RsGLAdmin As New ADODB.Recordset

        Try
            With Conn1
                .Provider = "SQLOLEDB"
                .ConnectionString = ("Provider=SQLOLEDB;Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
                .Open()
            End With
        Catch
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Server not responding, try again later !!!');", True)
            Exit Sub
        End Try
        Session("myADODBConnection") = Conn1



        'Session("myADODBConnection") = New ADODB.Connection
        'with Conn1
        '    .Provider = "Microsoft.JET.OLEDB.4.0"
        '    .ConnectionString = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb"
        '    .Open()
        'End With

        Rs1 = New ADODB.Recordset
        Rs1.Open("select * from PassAdmin where userid='" & Trim(TxtUserID.Text) & "'", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        With Rs1
            If .RecordCount > 0 Then

                If TxtUserID.Text <> .Fields("userid").Value Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid User ID or Password !!!');", True)
                    Exit Sub
                End If


                'HASH PASSWORD
                Dim strToHash As String
                strToHash = Trim(TxtPassWord.Text) 'Command$()

                Dim sha1Obj As New SHA1CryptoServiceProvider ' Security.Cryptography.SHA1CryptoServiceProvider
                Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

                bytesToHash = sha1Obj.ComputeHash(bytesToHash)

                Dim strResult As String = ""

                For Each b As Byte In bytesToHash
                    strResult += b.ToString("x2")
                Next

                mTxtPassWord = .Fields("accessno").Value

                'If TxtPassWord.Text <> .Fields("accessno").Value Then
                If Trim(mTxtPassWord) <> Trim(strResult) Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid Password !!!');", True)
                    Exit Sub
                End If

                Session("mbranchcode") = .Fields("branch").Value

                If IsDBNull(.Fields("ChkChangePWord").Value) Then .Fields("ChkChangePWord").Value = False
                If IsDBNull(.Fields("FrontOff").Value) Then .Fields("FrontOff").Value = False
                If IsDBNull(.Fields("BackOff").Value) Then .Fields("BackOff").Value = False
                If IsDBNull(.Fields("ChkStandMaint").Value) Then .Fields("ChkStandMaint").Value = False
                If IsDBNull(.Fields("ChkCustAcctOpen").Value) Then .Fields("ChkCustAcctOpen").Value = False
                If IsDBNull(.Fields("ChkCustAcctFlag").Value) Then .Fields("ChkCustAcctFlag").Value = False
                If IsDBNull(.Fields("ChkDailyproc").Value) Then .Fields("ChkDailyproc").Value = False
                If IsDBNull(.Fields("ChkRunMothlyAnaly").Value) Then .Fields("ChkRunMothlyAnaly").Value = False
                If IsDBNull(.Fields("ChkAnnualProc").Value) Then .Fields("ChkAnnualProc").Value = False
                If IsDBNull(.Fields("ChkDailyTransList").Value) Then .Fields("ChkDailyTransList").Value = False
                If IsDBNull(.Fields("ChkAuthorization").Value) Then .Fields("ChkAuthorization").Value = False
                If IsDBNull(.Fields("ChkAcctOffAdmin").Value) Then .Fields("ChkAcctOffAdmin").Value = False
                If IsDBNull(.Fields("ChkBranchSetup").Value) Then .Fields("ChkBranchSetup").Value = False
                If IsDBNull(.Fields("ChkLoadAdm").Value) Then .Fields("ChkLoadAdm").Value = False
                If IsDBNull(.Fields("ChkSalaryPosting").Value) Then .Fields("ChkSalaryPosting").Value = False
                If IsDBNull(.Fields("ChkAcctOfficerSum").Value) Then .Fields("ChkAcctOfficerSum").Value = False
                If IsDBNull(.Fields("ChkCustAcctBal").Value) Then .Fields("ChkCustAcctBal").Value = False
                If IsDBNull(.Fields("ChkUserPassAdm").Value) Then .Fields("ChkUserPassAdm").Value = False
                If IsDBNull(.Fields("ChkManRep").Value) Then .Fields("ChkManRep").Value = False
                If IsDBNull(.Fields("ChkLoanRepay").Value) Then .Fields("ChkLoanRepay").Value = False
                If IsDBNull(.Fields("ChkGLAcctBalance").Value) Then .Fields("ChkGLAcctBalance").Value = False
                If IsDBNull(.Fields("ChkGenLedgAdm").Value) Then .Fields("ChkGenLedgAdm").Value = False
                If IsDBNull(.Fields("ChkSMSChg").Value) Then .Fields("ChkSMSChg").Value = False
                If IsDBNull(.Fields("ChkAlertSet").Value) Then .Fields("ChkAlertSet").Value = False
                If IsDBNull(.Fields("ChkSpecChg").Value) Then .Fields("ChkSpecChg").Value = False
                If IsDBNull(.Fields("ChkSystemBack").Value) Then .Fields("ChkSystemBack").Value = False
                If IsDBNull(.Fields("ChkBankSet").Value) Then .Fields("ChkBankSet").Value = False
                If IsDBNull(.Fields("ChkProdMaint").Value) Then .Fields("ChkProdMaint").Value = False
                If IsDBNull(.Fields("ChkGroupAdmin").Value) Then .Fields("ChkGroupAdmin").Value = False
                If IsDBNull(.Fields("ChkVaultOPAdmin").Value) Then .Fields("ChkVaultOPAdmin").Value = False
                If IsDBNull(.Fields("ChkFDepositAdmin").Value) Then .Fields("ChkFDepositAdmin").Value = False
                If IsDBNull(.Fields("ChkFAssetGroupAdm").Value) Then .Fields("ChkFAssetGroupAdm").Value = False
                If IsDBNull(.Fields("ChkFAssetAdmin").Value) Then .Fields("ChkFAssetAdmin").Value = False
                If IsDBNull(.Fields("ChkFAssetDisposal").Value) Then .Fields("ChkFAssetDisposal").Value = False
                If IsDBNull(.Fields("ChkBudgetAdmin").Value) Then .Fields("ChkBudgetAdmin").Value = False
                If IsDBNull(.Fields("ChkAutoPosting").Value) Then .Fields("ChkAutoPosting").Value = False
                'If IsDBNull(.Fields("ChkFAssetDisposal").Value) Then .Fields("ChkFAssetDisposal").Value = False


                If .Fields("ChkChangePWord").Value = True Then
                    Session("ChkChangePWord") = True
                Else
                    Session("ChkChangePWord") = False
                End If

                If .Fields("FrontOff").Value = True Then
                    Session("FrontOff") = True
                Else
                    Session("FrontOff") = False
                End If

                If .Fields("BackOff").Value = True Then
                    Session("BackOff") = True
                Else
                    Session("BackOff") = False
                End If

                If .Fields("ChkStandMaint").Value = True Then
                    Session("ChkStandMaint") = True
                Else
                    Session("ChkStandMaint") = False
                End If

                If .Fields("ChkCustAcctOpen").Value = True Then
                    Session("ChkCustAcctOpen") = True
                Else
                    Session("ChkCustAcctOpen") = False
                End If

                If .Fields("ChkCustAcctFlag").Value = True Then
                    Session("ChkCustAcctFlag") = True
                Else
                    Session("ChkCustAcctFlag") = False
                End If

                If .Fields("ChkGenLedgAdm").Value = True Then
                    Session("ChkGenLedgAdm") = True
                Else
                    Session("ChkGenLedgAdm") = False
                End If

                If .Fields("ChkDailyproc").Value = True Then
                    Session("ChkDailyproc") = True
                Else
                    Session("ChkDailyproc") = False
                End If

                If .Fields("ChkRunMothlyAnaly").Value = True Then
                    Session("ChkRunMothlyAnaly") = True
                Else
                    Session("ChkRunMothlyAnaly") = False
                End If

                If .Fields("ChkAnnualProc").Value = True Then
                    Session("ChkAnnualProc") = True
                Else
                    Session("ChkAnnualProc") = False
                End If

                If .Fields("ChkDailyTransList").Value Then
                    Session("ChkDailyTransList") = True
                Else
                    Session("ChkDailyTransList") = False
                End If

                If .Fields("ChkAuthorization").Value Then
                    Session("ChkAuthorization") = True
                Else
                    Session("ChkAuthorization") = False
                End If

                If .Fields("ChkAcctOffAdmin").Value = True Then
                    Session("ChkAcctOffAdmin") = True
                Else
                    Session("ChkAcctOffAdmin") = False
                End If

                If .Fields("ChkBranchSetup").Value = True Then
                    Session("ChkBranchSetup") = True
                Else
                    Session("ChkBranchSetup") = False
                End If

                If .Fields("ChkLoadAdm").Value = True Then
                    Session("ChkLoadAdm") = True
                Else
                    Session("ChkLoadAdm") = False
                End If

                If .Fields("ChkSalaryPosting").Value = True Then
                    Session("ChkSalaryPosting") = True
                Else
                    Session("ChkSalaryPosting") = False
                End If

                If .Fields("ChkAcctOfficerSum").Value = True Then
                    Session("ChkAcctOfficerSum") = True
                Else
                    Session("ChkAcctOfficerSum") = False
                End If

                If .Fields("ChkCustAcctBal").Value = True Then
                    Session("ChkCustAcctBal") = True
                Else
                    Session("ChkCustAcctBal") = False
                End If

                If .Fields("ChkUserPassAdm").Value = True Then
                    Session("ChkUserPassAdm") = True
                Else
                    Session("ChkUserPassAdm") = False
                End If

                If .Fields("ChkManRep").Value = True Then
                    Session("ChkManRep") = True
                Else
                    Session("ChkManRep") = False
                End If

                If .Fields("ChkLoanRepay").Value = True Then
                    Session("ChkLoanRepay") = True
                Else
                    Session("ChkLoanRepay") = False
                End If

                If .Fields("ChkGLAcctBalance").Value = True Then
                    Session("ChkGLAcctBalance") = True
                Else
                    Session("ChkGLAcctBalance") = False
                End If

                If .Fields("ChkAlertSet").Value = True Then
                    Session("ChkAlertSet") = True
                Else
                    Session("ChkAlertSet") = False
                End If

                If .Fields("ChkSMSChg").Value = True Then
                    Session("ChkSMSChg") = True
                Else
                    Session("ChkSMSChg") = False
                End If

                If .Fields("ChkSpecChg").Value = True Then
                    Session("ChkSpecChg") = True
                Else
                    Session("ChkSpecChg") = False
                End If

                If .Fields("ChkSystemBack").Value = True Then
                    Session("ChkSystemBack") = True
                Else
                    Session("ChkSystemBack") = False
                End If

                If .Fields("ChkBankSet").Value = True Then
                    Session("ChkBankSet") = True
                Else
                    Session("ChkBankSet") = False
                End If

                If .Fields("ChkProdMaint").Value = True Then
                    Session("ChkProdMaint") = True
                Else
                    Session("ChkProdMaint") = False
                End If

                If .Fields("ChkGroupAdmin").Value = True Then
                    Session("ChkGroupAdmin") = True
                Else
                    Session("ChkGroupAdmin") = False
                End If

                If .Fields("ChkVaultOPAdmin").Value = True Then
                    Session("ChkVaultOPAdmin") = True
                Else
                    Session("ChkVaultOPAdmin") = False
                End If

                If .Fields("ChkFDepositAdmin").Value = True Then
                    Session("ChkFDepositAdmin") = True
                Else
                    Session("ChkFDepositAdmin") = False
                End If

                If .Fields("ChkFAssetGroupAdm").Value = True Then
                    Session("ChkFAssetGroupAdm") = True
                Else
                    Session("ChkFAssetGroupAdm") = False
                End If

                If .Fields("ChkFAssetAdmin").Value = True Then
                    Session("ChkFAssetAdmin") = True
                Else
                    Session("ChkFAssetAdmin") = False
                End If

                If .Fields("ChkFAssetDisposal").Value = True Then
                    Session("ChkFAssetDisposal") = True
                Else
                    Session("ChkFAssetDisposal") = False
                End If

                If .Fields("ChkBudgetAdmin").Value = True Then
                    Session("ChkBudgetAdmin") = True
                Else
                    Session("ChkBudgetAdmin") = False
                End If

                If .Fields("ChkAutoPosting").Value = True Then
                    Session("ChkAutoPosting") = True
                Else
                    Session("ChkAutoPosting") = False
                End If

                'Session("mTransDate") = LblTransDate.Text 'Convert.ToDateTime(mDOtMonth + "/" + mDOtDay + "/" + mDOtYear)
                'Session("mTransDate") = Trim(TxtTransDate.Text) 'Convert.ToDateTime(mDOtMonth + "/" + mDOtDay + "/" + mDOtYear)
                Session("mTransDate") = Session("nextworkingdate")
                Session("mUserID") = Trim(TxtUserID.Text)
                Session("Branch") = .Fields("Branch").Value
                'Session("thebranch") = .Fields("Branch").Value

                'THIS IS FOR WINDOWS 7 32BITS OR ANY OTHER 32BIT WINDOWS
                'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Main\BookOneDB.mdb;Persist Security Info=True;User ID=Admin")

                'THIS IS TO CHANGE TO THE ACTUAL BRANCH OF THE USER
                'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=True;User ID=Admin;Data Source=|DataDirectory|\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb")

                'myConnection.Open()
                'Session("myConnection") = myConnection

                'ButtonLog.PostBackUrl = ("welcome.aspx")
                Response.Redirect("welcome.aspx")
            Else

            End If
        End With

        ' Create a new Connection and SqlDataAdapter
        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnection = Session("myConnection")

        ''GET NEXT TRANSACTION DETAILS
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from POSControl", myConnection)

        'Dim myDataSetInv As Data.DataSet = New Data.DataSet()
        'Dim myDataRowInv As Data.DataRow

        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRowsInvCommandBuilder1 As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSetInv, "POSControl")

        'myDataRowInv = myDataSetInv.Tables("POSControl").Rows(0)

        'If IsDBNull(myDataRowInv("invno")) Then myDataRowInv("invno") = 0
        'If IsDBNull(myDataRowInv("transid")) Then myDataRowInv("transid") = 0
        'If IsDBNull(Session("Expiredate")) Then Session("Expiredate") = Date.Now

        'Session("TransDate") = myDataRowInv("transdate")
        'Session("endofday") = myDataRowInv("endofday")

        'If Session("TransDate") > Session("Expiredate") Then
        '    Session("Expired") = True
        '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Your Password has expired, you will not be able to perform some task, please update your password.');", True)
        'Else
        '    Session("Expired") = False
        'End If

        'Response.Redirect("Default.aspx")




        'Response.Redirect("http://www.supertextng.com/api.php?username=molusimfb&password=molusi12345&destination=2348050704771&message=Hi%20jim&sender=Gbenga")


        '' Create a new Connection and SqlDataAdapter
        'Dim Con As New Data.SqlClient.SqlConnection
        'Dim ds As New Data.DataSet
        'Dim da As Data.SqlClient.SqlDataAdapter
        'Dim sql As String
        ''Dim myDataRow As Data.DataRow
        ''Dim myDataSet As Data.DataSet = New Data.DataSet()


        'Dim mTxtUserID, mTxtUserName, mTxtPassWord, mTxtCreateDate, mDDUserType, mBranch
        ''Dim mCheckReports, mCheckUtil, mCheckAcctEnq, mCheckPosting, mCheckAcctAdmin, mCheckFileMaint, mCheckAll

        'myConnection = Session("myConnection") 'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from passadmin where userid='" & Trim(TxtUserID.Text) & "'", myConnection)

        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRowsCommandBuilder1 As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet, "passadmin")

        'TxtUserID.Enabled = True
        'TxtPassWord.Enabled = True

        'If myDataSet.Tables("passadmin").Rows.Count <= 0 Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Invalid User, Try Again !!!');", True)
        '    'MsgBox("Invalid User, Try Again !!!", MsgBoxStyle.SystemModal)
        '    TxtUserID.Focus()
        '    Exit Sub
        'End If

        'myDataRow = myDataSet.Tables("passadmin").Rows(0)

        'mTxtUserID = myDataRow("userid")
        'mTxtUserName = myDataRow("username")
        'mTxtPassWord = myDataRow("accessno")
        'mTxtCreateDate = myDataRow("datecreated")
        'mDDUserType = myDataRow("usertype")
        'mBranch = myDataRow("branch")

        ''MsgBox(mTxtPassWord)
        ''MsgBox(TxtPassWord.Text)

        'If TxtPassWord.Text <> Trim(mTxtPassWord) Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Invalid Password, Try Again !!!');", True)
        '    'MsgBox("Invalid Password, Try Again !!!", MsgBoxStyle.SystemModal)
        '    TxtUserID.Enabled = True
        '    TxtPassWord.Enabled = True
        '    TxtUserID.Focus()
        '    Exit Sub
        'End If

        'Session("mTxtCurrUser") = TxtUserID.Text

        ''myDataSet.Tables("passadmin").Rows.Add(myDataRow)
        ''mySqlDataAdapter.Update(myDataSet, "passadmin")

        ''If myDataRow("ChkAll") = True Then
        ''    Session("mChkAll") = True
        ''Else
        ''    Session("mChkAll") = False
        ''End If

        ''If myDataRow("ChkPostingOnly") = True Then
        ''    Session("mChkPostingOnly") = True
        ''Else
        ''    Session("mChkPostingOnly") = False
        ''End If

        ''If myDataRow("ChkInternet") = True Then
        ''    Session("mChkInternet") = True
        ''Else
        ''    Session("mChkInternet") = False
        ''End If

        ''If myDataRow("ChkReason") = True Then
        ''    Session("mChkReason") = True
        ''Else
        ''    Session("mChkReason") = False
        ''End If

        ''If myDataRow("ChkAcctOffAdmin") = True Then
        ''    Session("mChkAcctOffAdmin") = True
        ''Else
        ''    Session("mChkAcctOffAdmin") = False
        ''End If

        ''If myDataRow("ChkCashDenom") = True Then
        ''    Session("mChkCashDenom") = True
        ''Else
        ''    Session("mChkCashDenom") = False
        ''End If

        ''If myDataRow("ChkBranchSetup") = True Then
        ''    Session("mChkBranchSetup") = True
        ''Else
        ''    Session("mChkBranchSetup") = False
        ''End If

        ''If myDataRow("ChkUserType") = True Then
        ''    Session("mChkUserType") = True
        ''Else
        ''    Session("mChkUserType") = False
        ''End If

        ''If myDataRow("ChkGenLedgAdm") = True Then
        ''    Session("mChkUserType") = True
        ''Else
        ''    Session("mChkUserType") = False
        ''End If

        ''If myDataRow("ChkCustAcctOpen") = True Then
        ''    Session("mChkCustAcctOpen") = True
        ''Else
        ''    Session("mChkCustAcctOpen") = False
        ''End If

        ''If myDataRow("ChkWithdrawAdm") = True Then
        ''    Session("mChkWithdrawAdm") = True
        ''Else
        ''    Session("mChkWithdrawAdm") = False
        ''End If

        ''If myDataRow("ChkCustAcctFlag") = True Then
        ''    Session("mChkCustAcctFlag") = True
        ''Else
        ''    Session("mChkCustAcctFlag") = False
        ''End If

        ''If myDataRow("ChkStandMaint") = True Then
        ''    Session("mChkStandMaint") = True
        ''Else
        ''    Session("mChkStandMaint") = False
        ''End If

        ''If myDataRow("ChkFacAdm") = True Then
        ''    Session("mChkFacAdm") = True
        ''Else
        ''    Session("mChkFacAdm") = False
        ''End If

        ''If myDataRow("ChkCashCent") = True Then
        ''    Session("mChkCashCent") = True
        ''Else
        ''    Session("mChkCashCent") = False
        ''End If

        ''If myDataRow("ChkCashCollAdm") = True Then
        ''    Session("mChkCashCollAdm") = True
        ''Else
        ''    Session("mChkCashCollAdm") = False
        ''End If

        ''If myDataRow("ChkBudgDef") = True Then
        ''    Session("mChkBudgDef") = True
        ''Else
        ''    Session("mChkBudgDef") = False
        ''End If

        ''If myDataRow("ChkLoadAdm") = True Then
        ''    Session("mChkLoadAdm") = True
        ''Else
        ''    Session("mChkLoadAdm") = False
        ''End If

        ''If myDataRow("ChkPostRealTime") = True Then
        ''    Session("mChkPostRealTime") = True
        ''Else
        ''    Session("mChkPostRealTime") = False
        ''End If

        ''If myDataRow("ChkJournalPost") = True Then
        ''    Session("mChkJournalPost") = True
        ''Else
        ''    Session("mChkJournalPost") = False
        ''End If

        ''If myDataRow("ChkChkList") = True Then
        ''    Session("mChkChkList") = True
        ''Else
        ''    Session("mChkChkList") = False
        ''End If

        ''If myDataRow("ChkDailyproc") = True Then
        ''    Session("mChkDailyproc") = True
        ''Else
        ''    Session("mChkDailyproc") = False
        ''End If

        ''If myDataRow("ChkRunMothlyAnaly") = True Then
        ''    Session("mChkRunMothlyAnaly") = True
        ''Else
        ''    Session("mChkRunMothlyAnaly") = False
        ''End If

        ''If myDataRow("ChkCustAcctBal") = True Then
        ''    Session("mChkCustAcctBal") = True
        ''Else
        ''    Session("mChkCustAcctBal") = False
        ''End If

        ''If myDataRow("ChkCustAcctHist") = True Then
        ''    Session("mChkCustAcctHist") = True
        ''Else
        ''    Session("mChkCustAcctHist") = False
        ''End If

        ''If myDataRow("ChkGLAcctBal") = True Then
        ''    Session("mChkGLAcctBal") = True
        ''Else
        ''    Session("mChkGLAcctBal") = False
        ''End If

        ''If myDataRow("ChkAcctOfficerSum") = True Then
        ''    Session("mChkAcctOfficerSum") = True
        ''Else
        ''    Session("mChkAcctOfficerSum") = False
        ''End If

        ''If myDataRow("ChkUserPassAdm") = True Then
        ''    Session("mChkUserPassAdm") = True
        ''Else
        ''    Session("mChkUserPassAdm") = False
        ''End If

        ''If myDataRow("ChkBranchPassAdm") = True Then
        ''    Session("mChkBranchPassAdm") = True
        ''Else
        ''    Session("mChkBranchPassAdm") = False
        ''End If

        ''If myDataRow("ChkSpecChg") = True Then
        ''    Session("mChkSpecChg") = True
        ''Else
        ''    Session("mChkSpecChg") = True
        ''End If

        ''If myDataRow("ChkMatProfile") = True Then
        ''    Session("mChkMatProfile") = True
        ''Else
        ''    Session("mChkMatProfile") = False
        ''End If

        ''If myDataRow("ChkAlertSet") = True Then
        ''    Session("mChkAlertSet") = True
        ''Else
        ''    Session("mChkAlertSet") = False
        ''End If

        ''If myDataRow("ChkSystemBack") = True Then
        ''    Session("mChkSystemBack") = True
        ''Else
        ''    Session("mChkSystemBack") = False
        ''End If

        ''If myDataRow("ChkSystemRec") = True Then
        ''    Session("mChkSystemRec") = True
        ''Else
        ''    Session("mChkSystemRec") = False
        ''End If

        ''If myDataRow("ChkPurgeFile") = True Then
        ''    Session("mChkPurgeFile") = True
        ''Else
        ''    Session("mChkPurgeFile") = False
        ''End If

        ''If myDataRow("ChkManRep") = True Then
        ''    Session("mChkManRep") = True
        ''Else
        ''    Session("mChkManRep") = False
        ''End If


        'If myDataRow("FrontOff") = True Then
        '    Session("FrontOff") = True
        'Else
        '    Session("FrontOff") = False
        'End If

        'If myDataRow("BackOff") = True Then
        '    Session("BackOff") = True
        'Else
        '    Session("BackOff") = False
        'End If

        'If myDataRow("SMSCont") = True Then
        '    Session("SMSCont") = True
        'Else
        '    Session("SMSCont") = False
        'End If

        'If myDataRow("RunSMSChg") = True Then
        '    Session("RunSMSChg") = True
        'Else
        '    Session("RunSMSChg") = False
        'End If

        'If myDataRow("Processing") = True Then
        '    Session("Processing") = True
        'Else
        '    Session("Processing") = False
        'End If

        'If myDataRow("adminr") = True Then
        '    Session("adminr") = True
        'Else
        '    Session("adminr") = False
        'End If

        'If myDataRow("FileMaint") = True Then
        '    Session("FileMaint") = True
        'Else
        '    Session("FileMaint") = False
        'End If

        'If myDataRow("AcctAdmin") = True Then
        '    Session("AcctAdmin") = True
        'Else
        '    Session("AcctAdmin") = False
        'End If

        'If myDataRow("LoanAdmin") = True Then
        '    Session("LoanAdmin") = True
        'Else
        '    Session("LoanAdmin") = False
        'End If

        'If myDataRow("Utilities") = True Then
        '    Session("Utilities") = True
        'Else
        '    Session("Utilities") = False
        'End If

        'If myDataRow("Reports") = True Then
        '    Session("Reports") = True
        'Else
        '    Session("Reports") = False
        'End If

        ''mDOtDay = DOTDay.Text
        ''mDOtMonth = DOTMonth.Text
        ''mDOtYear = DOTYear.Text

        ''Session("mTransDate") = LblTransDate.Text 'Convert.ToDateTime(mDOtMonth + "/" + mDOtDay + "/" + mDOtYear)
        ''Session("mTransDate") = Convert.ToDateTime(mDOtMonth + "/" + mDOtDay + "/" + mDOtYear)
        'Session("mTransDate") = Convert.ToDateTime(TxtTransDate.Text)

        'Session("mUserID") = Trim(TxtUserID.Text)

        ''ButtonLog.PostBackUrl = ("welcome.aspx")
        'Response.Redirect("welcome.aspx")

        ''If TxtBranchCode.Text <> Trim(mBranch) Then
        ''    If myDataRow("branch") = False Then
        ''        MsgBox("You have no access to Other Branches !!!", MsgBoxStyle.SystemModal)
        ''        TxtUserID.Focus()
        ''        Exit Sub
        ''    Else
        ''        LblBranchPass.Visible = True
        ''        TxtBranchPass.Visible = True
        ''        ButBrLogin.Enabled = True
        ''        TxtUserID.Enabled = False
        ''        TxtPassWord.Enabled = False
        ''    End If
        ''Else
        ''    ButtonLog.PostBackUrl = ("welcome.aspx")
        ''End If



    End Sub



    'Protected Sub ButBrLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButBrLogin.Click
    '    ' Create a new Connection and SqlDataAdapter
    '    Dim myConnection As Data.SqlClient.SqlConnection
    '    Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
    '    Dim mTxtUserID, mTxtUserName, mTxtPassWord, mTxtCreateDate, mDDUserType, mBranch
    '    'Dim mCheckReports, mCheckUtil, mCheckAcctEnq, mCheckPosting, mCheckAcctAdmin, mCheckFileMaint, mCheckAll

    '    myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from BranchUserAdm where accessno='" & Trim(TxtBranchPass.Text) & "'", myConnection)

    '    Dim myDataSet As Data.DataSet = New Data.DataSet()
    '    Dim myDataRow As Data.DataRow

    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    ' have to provide or create your own.
    '    Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    mySqlDataAdapter.Fill(myDataSet, "BranchUserAdm")

    '    If myDataSet.Tables("BranchUserAdm").Rows.Count <= 0 Then
    '        MsgBox("Invalid User, Try Again !!!", MsgBoxStyle.SystemModal)
    '        TxtUserID.Focus()
    '        Exit Sub
    '    End If

    '    myDataRow = myDataSet.Tables("BranchUserAdm").Rows(0)

    '    mTxtUserID = myDataRow("userid")
    '    mTxtUserName = myDataRow("username")
    '    mTxtPassWord = myDataRow("accessno")
    '    mTxtCreateDate = myDataRow("datecreated")
    '    mDDUserType = myDataRow("usertype")
    '    mBranch = myDataRow("branch")

    '    If TxtPassWord.Text <> Trim(mTxtPassWord) Then
    '        MsgBox("Invalid Password, Try Again !!!", MsgBoxStyle.SystemModal)
    '        TxtUserID.Focus()
    '    End If
    '    'If TxtBranchCode.Text <> Trim(mBranch) Then
    '    '    If myDataRow("branch") = False Then
    '    '        MsgBox("You have no access to Other Branches !!!", MsgBoxStyle.SystemModal)
    '    '        TxtUserID.Focus()
    '    '    Else
    '    '        LblBranchPass.Visible = True
    '    '        TxtBranchPass.Visible = True
    '    '        ButBrLogin.Enabled = True
    '    '    End If
    '    'End If

    '    Session("mTxtCurrUser") = TxtUserID.Text

    '    'myDataSet.Tables("passadmin").Rows.Add(myDataRow)
    '    'mySqlDataAdapter.Update(myDataSet, "passadmin")

    '    If myDataRow("ChkAll") = True Then
    '        Session("mChkAll") = True
    '    Else
    '        Session("mChkAll") = False
    '    End If

    '    If myDataRow("ChkPostingOnly") = True Then
    '        Session("mChkPostingOnly") = True
    '    Else
    '        Session("mChkPostingOnly") = False
    '    End If

    '    If myDataRow("ChkInternet") = True Then
    '        Session("mChkInternet") = True
    '    Else
    '        Session("mChkInternet") = False
    '    End If

    '    If myDataRow("ChkReason") = True Then
    '        Session("mChkReason") = True
    '    Else
    '        Session("mChkReason") = False
    '    End If
    'End Sub


    'Protected Sub LinkButSignUp_Click(sender As Object, e As EventArgs) Handles LinkButSignUp.Click
    '    PanelSignUp.Visible = True
    '    PanelSignUp.Width = 512
    '    PanelSignUp.Height = 444
    '    PanelSignUp.Attributes.Add("style", "position: absolute; left: 270px; top: 238px; height: 440px; width: 663px")
    'End Sub

    'Protected Sub ButRegister_Click(sender As Object, e As EventArgs) Handles ButRegister.Click
    ''If ButSave.Text = "Add" Then
    ''    TxtCustID.Text = ""
    ''    TxtCompName.Text = ""
    ''    TxtCustAddr.Text = ""
    ''    TxtCompTel.Text = ""
    ''    Txtemail.Text = ""
    ''    'DDCountry.Text = ""
    ''    'DDState.Text = ""
    ''    'DDCity.Text = ""
    ''    TxtContact.Text = ""
    ''    TxtUserID.Text = ""
    ''    TxtPassWord.Text = ""
    ''    Exit Sub
    ''End If
    ''If TxtCustID.Text = " " Or TxtCustID.Text = "" Then
    ''    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Customer ID / Name cannot be empty !!!');", True)
    ''    Exit Sub
    ''End If

    'If TxtBankName.Text = " " Or TxtBankName.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Bank Name cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtBankRegID.Text = " " Or TxtBankRegID.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Bank ID cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtPhone.Text = " " Or TxtPhone.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Telephone No cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtEmail.Text = " " Or TxtEmail.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Email cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtContactPerson.Text = " " Or TxtContactPerson.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Contact Name cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtRegPassword.Text = " " Or TxtRegPassword.Text = "" Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Password cannot be empty !!!');", True)
    '    Exit Sub
    'End If

    'If TxtRegReenterPassword.Text <> TxtRegPassword.Text Then
    '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Password does not march, please try again !!!');", True)
    '    Exit Sub
    'End If

    '' Create a new Connection and SqlDataAdapter
    'Dim myConnection As Data.SqlClient.SqlConnection
    'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '' myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=True;User ID=Admin;Data Source=|DataDirectory|\InitDoc.mdb")

    'myConnection.Open()
    'Session("myConnection") = myConnection

    ' ''GENERATE RANDOM COMPANY ID NO

    ''Dim x As Double
    ''Dim i As Integer
    ' '' Dim Start = 0
    ' ''Dim mend = 12   '99999999
    ' ''Dim SampleArray(20) As Double
    ''Randomize()
    ' ''For i = 0 To 100
    ' '' Do While Start <= mend
    ' ''SampleArray(i) = Rnd() * 100
    ' ''randomvalue = Int(Int((9999999999# - 10 + 1) * Rnd() + 10))
    ''Dim randomvalue = Int((9999.0#) * Rnd() + 4)
    ''TxtCustID.Text = Trim(randomvalue)

    ' ''List1.AddItem(randomvalue)
    ' ''Next
    ' ''Start = Start + 1

    ' ''Loop

    ''END OF GENERATE COMPANY ID NO

    'myConnection = Session("myConnection")
    'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from CompanyID where compalias='" & Trim(TxtBankRegID.Text) & "'", myConnection)

    'Dim myDataSet As Data.DataSet = New Data.DataSet()
    'Dim myDataRow As Data.DataRow

    '' Create command builder. This line automatically generates the update commands for you, so you don't 
    '' have to provide or create your own.
    'Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '' key & unique key information to be retrieved unless AddWithKey is specified.
    'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    'mySqlDataAdapter.Fill(myDataSet, "CompanyID")


    ''If myDataSet.Tables("CompanyID").Rows.Count > 0 Then
    ''Do While myDataSet.Tables("CompanyID").Rows.Count > 0
    ''    'ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('GL Code already exist !!!');", True)
    ''    'MsgBox("Account Type does not exist !!!")

    ''    Randomize()
    ''    'For i = 0 To 100
    ''    ' Do While Start <= mend
    ''    'SampleArray(i) = Rnd() * 100
    ''    'randomvalue = Int(Int((9999999999# - 10 + 1) * Rnd() + 10))
    ''    randomvalue = Int((9999.0#) * Rnd() + 4)
    ''    TxtCustID.Text = Trim(randomvalue)

    ''    mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from CompanyID where compalias='" & Trim(TxtCompAlias.Text) & "'", myConnection)
    ''    Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)
    ''    mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey
    ''    mySqlDataAdapter.Fill(myDataSet, "CompanyID")

    ''    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Alias already exists !!!');", True)

    ''    Exit Sub
    ''Loop
    ''End If


    ''If Session("mEdit") = True Then
    'If myDataSet.Tables("CompanyID").Rows.Count > 0 Then
    '    'myDataRow = myDataSet.Tables("CompanyID").Rows(0)
    '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Bank ID already exists, type a unique Bank ID !!!');", True)
    '    Exit Sub
    'Else
    '    myDataRow = myDataSet.Tables("CompanyID").NewRow()
    'End If

    'myDataRow("compid") = TxtBankRegID.Text
    'myDataRow("compname") = TxtBankName.Text
    'myDataRow("compalias") = TxtBankRegID.Text
    'myDataRow("address") = TxtAddress.Text
    ''myDataRow("address2") = TxtCustAddr2.Text
    'myDataRow("mobile") = TxtPhone.Text
    'myDataRow("email") = TxtEmail.Text
    'myDataRow("country") = DDCountry.Text
    ''myDataRow("state") = DDState.Text
    ''myDataRow("city") = DDCity.Text
    'myDataRow("contact") = TxtContactPerson.Text
    'myDataRow("userid") = TxtUserRegID.Text
    'myDataRow("userauthority") = TxtRegPassword.Text


    'myDataSet.Tables("CompanyID").Rows.Add(myDataRow)
    ''End If
    'mySqlDataAdapter.Update(myDataSet.GetChanges, "CompanyID")


    ' ''RECORD CUSTOMER DR OR CR BALANCE
    ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from CustPayTrn", myConnection)

    ''Dim myDataSetCash As Data.DataSet = New Data.DataSet()
    ''Dim myDataRowCash As Data.DataRow

    ' '' Create command builder. This line automatically generates the update commands for you, so you don't 
    ' '' have to provide or create your own.
    ''Dim myDataRowsCashCommandBuilder1 As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    ' '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    ' '' key & unique key information to be retrieved unless AddWithKey is specified.
    ''mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    ''mySqlDataAdapter.Fill(myDataSetCash, "CustPayTrn")

    ''myDataRowCash = myDataSetCash.Tables("CustPayTrn").NewRow

    ''myDataRowCash("custid") = Trim(TxtCustID.Text)
    ''myDataRowCash("custname") = Trim(TxtCompName.Text)
    ''myDataRowCash("itemcode") = "Balance B/F"
    ''myDataRowCash("itemname") = "Balance B/F"
    ' '' myDataRowCash("unitprice") = Session("mTxtRate")
    ' '' myDataRowCash("qty") = Session("mTxtQty")
    ' ''myDataRowCash("totamt") = Trim(TxtTotAmt.Text)
    ' ''If DDPayType.Text = "Cash" Then
    ' ''If IsDBNull(myDataRowCash("amtpaid")) Then myDataRowCash("amtpaid") = 0
    ''If IsDBNull(myDataRowCash("balance")) Then myDataRowCash("balance") = 0
    ''If Txtemail.Text = "" Or Txtemail.Text = " " Then Txtemail.Text = 0
    ''If TxtCompTel.Text = "" Or TxtCompTel.Text = " " Then TxtCompTel.Text = 0

    ''If Txtemail.Text > 0 Then
    ''    myDataRowCash("balance") = Val(myDataRowCash("balance")) + Val(Txtemail.Text)
    ''End If
    ''If TxtCompTel.Text > 0 Then
    ''    myDataRowCash("balance") = Val(myDataRowCash("balance")) - Val(TxtCompTel.Text)
    ''End If
    ''myDataRowCash("trndate") = Date.Today
    ''myDataRowCash("purpose") = "Balance B/F:"
    ' ''myDataRowCash("balance") = Val(myDataRowCash("balance")) - Val(myDataRowCash("amtpaid"))

    ''myDataSetCash.Tables("CustPayTrn").Rows.Add(myDataRowCash)
    ''mySqlDataAdapter.Update(myDataSetCash, "CustPayTrn")

    'IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & TxtBankRegID.Text)        ' & "\" & Trim(TxtBranchName.Text))
    'IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & TxtBankRegID.Text & "\" & Session("thebranch"))
    'IO.File.Copy(System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\Bankerdata.mdb", System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & TxtBankRegID.Text & "\" & Session("thebranch") & "\Bankerdata.mdb")

    'Dim Conn1 as New ADODB.Connection
    'Dim Cmd1 As New ADODB.Command
    'Dim Rs1, RsAdmin As New ADODB.Recordset

    'Session("myADODBConnection") = New ADODB.Connection
    'with Conn1
    '    .Provider = "Microsoft.JET.OLEDB.4.0"
    '    .ConnectionString = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & TxtBankRegID.Text & "\" & Session("thebranch") & "\Bankerdata.mdb"
    '    .Open()
    'End With

    'RsAdmin = New ADODB.Recordset
    'RsAdmin.Open("select * from PassAdmin", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

    'With RsAdmin
    '    .AddNew()

    '    .Fields("userid").Value = TxtUserRegID.Text
    '    .Fields("username").Value = TxtBankRegID.Text
    '    .Fields("accessno").Value = TxtRegPassword.Text
    '    .Fields("datecreated").Value = Date.Now
    '    .Fields("dateexpires").Value = Date.Now.AddMonths(3)
    '    .Fields("createdby").Value = TxtBankName.Text
    '    .Fields("usertype").Value = "Admin"
    '    .Fields("branch").Value = "01"

    '    .Fields("FrontOff").Value = True
    '    .Fields("BackOff").Value = True
    '    .Fields("SMSCont").Value = True
    '    .Fields("RunSMSChg").Value = True
    '    .Fields("Processing").Value = True
    '    .Fields("adminr").Value = True
    '    .Fields("FileMaint").Value = True
    '    .Fields("AcctAdmin").Value = True
    '    .Fields("LoanAdmin").Value = True

    '    .Fields("Utilities").Value = True
    '    .Fields("Reports").Value = True
    '    '.Fields("AcctAdmin").Value = True
    '    '.Fields("LoanAdmin").Value = True

    '    .Update()
    'End With

    'ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Thank you for signing up with BookOne Accounting System. Your Company has been registered Sucessfully, you can now login to start your transactions.');", True)

    ''ButSave.Text = "Add"
    ''Session("mEdit") = False
    ''TxtCustID.Text = ""
    ''Txtemail.Text = 0
    ''TxtCompTel.Text = 0
    ''TxtGLName.Text = "None"
    'End Sub

    'Protected Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
    '    'ButClose.PostBackUrl = ("Login.aspx")
    '    PanelSignUp.Visible = False
    'End Sub

    Protected Sub TxtBankID_TextChanged(sender As Object, e As EventArgs) Handles TxtBankID.TextChanged

        Dim myConnectionInit As Data.OleDb.OleDbConnection
        'Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        Dim mySqlDataAdapterInit As Data.OleDb.OleDbDataAdapter

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        Dim myDataRow As Data.DataRow


        myConnectionInit = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=True;User ID=Admin;Data Source=|DataDirectory|\InitDoc.mdb")

        myConnectionInit.Open()
        Session("myConnectionInit") = myConnectionInit

        myConnectionInit = Session("myConnectionInit")
        mySqlDataAdapterInit = New Data.OleDb.OleDbDataAdapter("Select * from CompanyID where compalias='" & Trim(TxtBankID.Text) & "'", myConnectionInit)

        'Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilderx As Data.OleDb.OleDbCommandBuilder = New Data.OleDb.OleDbCommandBuilder(mySqlDataAdapterInit)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapterInit.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapterInit.Fill(myDataSet, "CompanyID")

        If myDataSet.Tables("CompanyID").Rows.Count > 0 Then
            myDataRow = myDataSet.Tables("CompanyID").Rows(0)
        Else
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Company Not Found !!!');", True)
            Exit Sub
        End If

        Session("mSuperUser") = myDataRow("userid")

        'If TxtUserID.Text <> myDataRow("userid") Then
        '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid User ID or Password !!!');", True)
        '    Exit Sub
        'End If

        'If TxtPassWord.Text <> myDataRow("userauthority") Then
        '    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Invalid User ID or Password !!!');", True)
        '    Exit Sub
        'End If

        Session("mCompID") = myDataRow("CompID")   'Trim(TxtCompID.Text)
        Session("mcompalias") = myDataRow("compalias")
        Session("mcompname") = myDataRow("compname")
        Session("maddress") = myDataRow("address")
        Session("mmobile") = myDataRow("mobile")
        Session("mydbname") = myDataRow("mydbname")
        Session("myusername") = myDataRow("myusername")
        Session("mydatasource") = myDataRow("mydatasource")



        ''ONLY SUPER USERS CAN ACTIVATE ALL OTHER USERS
        'If Session("mSuperUser") = Trim(TxtUserID.Text) Then
        '    If CheckOpenBranch.Checked Then
        '        myDataRow("activated") = True
        '        mySqlDataAdapter.Update(myDataSet.GetChanges, "CompanyID")
        '    End If
        'End If

        Try
            ' Create a new Connection and SqlDataAdapter

            ''''************** SAMPLE OF HOW TO OPEN A PASSWORD PROTECTED DATABASE *****************
            'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Attendance\\AC215DataBase.mdb;Database Password=852972;User ID=Admin")
            Dim myConnection As New SqlConnection
            'Con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BankerData.mdb;Persist Security Info=True"
            'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BankerData.mdb;Persist Security Info=True;User ID=Admin")
            'myConnection = New Data.SqlClient.SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb;Persist Security Info=True;User ID=Admin")
            myConnection.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;Connection Timeout=180;")
            'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=|DataDirectory|BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from datacont", myConnection)
            myConnection.Open()
        Catch
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Server not responding, please try again later.....');", True)
            Exit Sub
        End Try

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "datacont")

        myDataRow = myDataSet.Tables("datacont").Rows(0)

        If IsDBNull(myDataRow("CashContAcct")) Then
            myDataRow("CashContAcct") = ""
        End If
        If IsDBNull(myDataRow("LastProcDate")) Then
            myDataRow("LastProcDate") = Date.Today
        Else
            ''TxtTransDate.Text = myDataRow("LastProcDate")
        End If
    End Sub
End Class