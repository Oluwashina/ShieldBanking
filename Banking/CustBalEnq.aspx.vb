Public Class CustBalEnq
    Inherits System.Web.UI.Page
    Public mBalance, mGlControl, mUnCleared, mLoan, mTransCode, mAcctType, mCurrBal, mCOTamt
    Public mThousandCount, mCOT, mGLBalance, mGLDebit, mGLCredit, mBranch
    Public mEdit, mSavings, mCurrent, mFixed, mOthers
    'Dim myConnection As Data.SqlClient.SqlConnection
    'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        'TxtCurrUser.Text = "Gbenga"
        TxtCurrUser.Text = Session("mUserID")  'Session("mTxtCurrUser")
        'Session("mUserID") = Trim(TxtUserID.Text)
        TxtTransDate.Text = Session("mTransDate")
        'DDCrDr.Text = "Deposit"

        'RadButCustName.Checked = True
        'RadButAcctNo.Checked = False
        'LblCustName.Visible = True
        'DDCustName.Visible = True
        LblTxtAcctNo.Visible = True
        TxtAcctNo.Visible = True

        'ButBatch.Enabled = False

        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapter1 As Data.SqlClient.SqlDataAdapter


        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        If myConnection.State = System.Data.ConnectionState.Closed Then
            myConnection.Open()
        End If
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from TransactionMaintain", myConnection)

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow
        Dim myDataSet1 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow1 As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "TransactionMaintain")

        'Dim ds As New Data.DataSet
        'Dim da As Data.SqlClient.SqlDataAdapter

        'sql = ("Select * from acctype")

        'DDTransType.ClearSelection()

        'da = New Data.SqlClient.SqlDataAdapter(sql, Con)

        'da.Fill(ds, "acctype")

        'DDTransType.DataSource = myDataSet.Tables(0)
        'DDTransType.DataTextField = myDataSet.Tables(0).Columns("narration").ColumnName.ToString
        'DDTransType.DataValueField = myDataSet.Tables(0).Columns("narration").ColumnName.ToString
        'DDTransType.DataBind()


        ' Create a new Connection and SqlDataAdapter
        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        If myConnection.State = Data.ConnectionState.Closed Then
            myConnection.Open()
        End If
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from branchsetup", myConnection)   ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

        'Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow
        'Dim i

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder1 As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'DDBraCo.ClearSelection()

        'mySqlDataAdapter.Fill(myDataSet, "branchsetup")
        'DDBraCo.DataSource = myDataSet.Tables(0)
        'DDBraCo.DataTextField = myDataSet.Tables(0).Columns("branchcode").ColumnName.ToString
        'DDBraCo.DataValueField = myDataSet.Tables(0).Columns("branchcode").ColumnName.ToString
        'DDBraCo.DataBind()


        ' Create a new Connection and SqlDataAdapter
        'Dim CashConnection As Data.SqlClient.SqlConnection
        Dim CashDataAdapter As Data.SqlClient.SqlDataAdapter

        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        CashDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from cashcentre", myConnection)   ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

        Dim CashDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow
        'Dim i

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim CashDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(CashDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        CashDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'DDCashAcct.ClearSelection()

        'CashDataAdapter.Fill(CashDataSet, "cashcentre")
        'DDCashAcct.DataSource = CashDataSet.Tables(0)
        'DDCashAcct.DataTextField = CashDataSet.Tables(0).Columns("narrative").ColumnName.ToString
        'DDCashAcct.DataValueField = CashDataSet.Tables(0).Columns("narrative").ColumnName.ToString
        'DDCashAcct.DataBind()


        ' Create a new Connection and SqlDataAdapter
        'Dim myConnectionCust As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapterCust As Data.SqlClient.SqlDataAdapter


        'myConnectionCust = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        mySqlDataAdapterCust = New Data.SqlClient.SqlDataAdapter("Select * from custacctopen", myConnection)

        Dim myDataSetCust As Data.DataSet = New Data.DataSet()
        'Dim myDataRowCust As Data.DataRow
        'Dim i

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilderCust As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapterCust)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapterCust.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'DDAcctNo.ClearSelection()

        'mySqlDataAdapterCust.Fill(myDataSetCust, "custacctopen")
        'DDAcctNo.DataSource = myDataSetCust.Tables(0)
        'DDAcctNo.DataTextField = myDataSetCust.Tables(0).Columns("acctno").ColumnName.ToString
        'DDAcctNo.DataValueField = myDataSetCust.Tables(0).Columns("acctno").ColumnName.ToString
        ''DDAcctNo.SelectedValue = myDataSet.Tables(0).Columns("holdername").ColumnName.ToString
        'DDAcctNo.DataBind()

        'DDCustName.ClearSelection()
        'mySqlDataAdapterCust.Fill(myDataSetCust, "custacctopen")
        'DDCustName.DataSource = myDataSetCust.Tables(0)
        'DDCustName.DataTextField = myDataSetCust.Tables(0).Columns("holdername").ColumnName.ToString
        'DDCustName.DataValueField = myDataSetCust.Tables(0).Columns("holdername").ColumnName.ToString
        ''DDAcctNo.SelectedValue = myDataSet.Tables(0).Columns("holdername").ColumnName.ToString
        'DDCustName.DataBind()


        ' LblHolder.Text = DDAcctNo.DataValueField

        '' Create a new Connection and SqlDataAdapter
        'Dim myConnectiona As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdaptera As Data.SqlClient.SqlDataAdapter


        'myConnectiona = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'mySqlDataAdaptera = New Data.SqlClient.SqlDataAdapter("Select * from custacctopen where acctradix='" & DDContraRadix.Text & "'", myConnectiona)   ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

        'Dim myDataSeta As Data.DataSet = New Data.DataSet()
        ''Dim myDataRow As Data.DataRow
        ''Dim i

        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRowsaCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdaptera)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdaptera.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'DDContraActNo.ClearSelection()

        'mySqlDataAdaptera.Fill(myDataSeta, "custacctopen")
        'DDContraActNo.DataSource = myDataSeta.Tables(0)
        'DDContraActNo.DataTextField = myDataSeta.Tables(0).Columns("acctno").ColumnName.ToString
        'DDContraActNo.DataValueField = myDataSeta.Tables(0).Columns("acctno").ColumnName.ToString
        'DDContraActNo.DataBind()
        'DDTransType.Enabled = False
        'TxtInstruNo.Enabled = False
        'DDCrDr.Enabled = False
        'TxtParticular.Enabled = False
        'TxtTransAmt.Enabled = False
        TxtAcctNo.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'DDTransType.Enabled = False
        'TxtInstruNo.Enabled = False
        'DDCrDr.Enabled = False
        'TxtParticular.Enabled = False
        'TxtTransAmt.Enabled = False

        mEdit = False
        mSavings = False
        mCurrent = False
        mLoan = False
        mFixed = False
        mOthers = False

        'If Session("mMultiCashCenter") = True Then
        '    LblCashCenter.Visible = True
        '    DDCenterName.Visible = True
        '    TxtCentCode.Visible = True
        '    TxtCentBal.Visible = True
        '    LblBalance.Visible = True
        'End If
        'TxtBranchCode.Text = Date.Today
        '        TransDate.Text = DateTime.Now

        'RaiseEvent DDAcctNo_SelectedIndexChanged()
        'RaiseEvent ButPost()
        'Convert.ToDouble(TotCompDebit)
        'Convert.ToDouble(TotCompCredit)
        'CashType()

        ' Create a new Connection and SqlDataAdapter

        If Session("MySigNo") <> "" Then
            TxtAcctNo.Text = Session("MySigNo")
            Me.TxtAcctNo_TextChanged(Me, e)
            Session("MySigNo") = ""
        End If

    End Sub

    'Protected Sub DDRadixCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDRadixCode.SelectedIndexChanged
    '    DDTransNo.Enabled = True
    '    If Trim(DDRadixCode.Text) = "999" Then


    '        ' Create a new Connection and SqlDataAdapter
    '        Dim myConnection As Data.SqlClient.SqlConnection
    '        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '        myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin", myConnection) ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

    '        Dim myDataSet As Data.DataSet = New Data.DataSet()
    '        Dim myDataRow As Data.DataRow
    '        'Dim i

    '        ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '        ' have to provide or create your own.
    '        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '        ' key & unique key information to be retrieved unless AddWithKey is specified.
    '        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '        DDAcctNo.ClearSelection()

    '        mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")
    '        DDAcctNo.DataSource = myDataSet.Tables(0)
    '        DDAcctNo.DataTextField = myDataSet.Tables(0).Columns("glacctno").ColumnName.ToString
    '        DDAcctNo.DataValueField = myDataSet.Tables(0).Columns("glacctno").ColumnName.ToString
    '        'DDAcctNo.SelectedValue = myDataSet.Tables(0).Columns("acctname").ColumnName.ToString
    '        DDAcctNo.DataBind()
    '        ' LblHolder.Text = DDAcctNo.SelectedValue

    '    Else

    '        ' Create a new Connection and SqlDataAdapter
    '        Dim myConnection As Data.SqlClient.SqlConnection
    '        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '        myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from custacctopen where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

    '        Dim myDataSet As Data.DataSet = New Data.DataSet()
    '        Dim myDataRow As Data.DataRow
    '        'Dim i

    '        ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '        ' have to provide or create your own.
    '        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '        ' key & unique key information to be retrieved unless AddWithKey is specified.
    '        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '        DDAcctNo.ClearSelection()

    '        mySqlDataAdapter.Fill(myDataSet, "custacctopen")
    '        DDAcctNo.DataSource = myDataSet.Tables(0)
    '        DDAcctNo.DataTextField = myDataSet.Tables(0).Columns("acctno").ColumnName.ToString
    '        DDAcctNo.DataValueField = myDataSet.Tables(0).Columns("acctno").ColumnName.ToString
    '        'DDAcctNo.SelectedValue = myDataSet.Tables(0).Columns("holdername").ColumnName.ToString
    '        DDAcctNo.DataBind()
    '        ' LblHolder.Text = DDAcctNo.DataValueField

    '    End If
    '    'LblRadix.Text = DDRadixCode.SelectedValue

    '    ' Create a new Connection and SqlDataAdapter
    '    Dim myConnectionx As Data.SqlClient.SqlConnection
    '    Dim mySqlDataAdapterx As Data.SqlClient.SqlDataAdapter


    '    myConnectionx = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    mySqlDataAdapterx = New Data.SqlClient.SqlDataAdapter("Select * from radixmaintain where radixcode='" & DDRadixCode.Text & "'", myConnectionx) ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

    '    Dim myDataSetx As Data.DataSet = New Data.DataSet()
    '    Dim myDataRowx As Data.DataRow
    '    Dim i

    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    ' have to provide or create your own.
    '    Dim myDataRowsxCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapterx)

    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    mySqlDataAdapterx.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    mySqlDataAdapterx.Fill(myDataSetx, "radixmaintain")

    '    myDataRowx = myDataSetx.Tables("radixmaintain").Rows(0)
    '    Dim mNarrate
    '    mNarrate = myDataRowx("narrative")
    '    LblRadix.Text = mNarrate



    '    If Trim(DDRadixCode.Text) = "999" Then


    '        ' Create a new Connection and SqlDataAdapter
    '        Dim myConnection As Data.SqlClient.SqlConnection
    '        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '        myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin where glacctno='" & DDAcctNo.Text & "'", myConnection) ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

    '        Dim myDataSet As Data.DataSet = New Data.DataSet()
    '        Dim myDataRow As Data.DataRow
    '        'Dim i

    '        ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '        ' have to provide or create your own.
    '        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '        ' key & unique key information to be retrieved unless AddWithKey is specified.
    '        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '        mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")

    '        myDataRow = myDataSet.Tables("glaccountadmin").Rows(0)
    '        Dim mNarratex
    '        mNarratex = myDataRow("acctname")
    '        LblHolder.Text = mNarratex


    '    Else

    '        ' Create a new Connection and SqlDataAdapter
    '        Dim myConnection As Data.SqlClient.SqlConnection
    '        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '        myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from custacctopen where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

    '        Dim myDataSet As Data.DataSet = New Data.DataSet()
    '        Dim myDataRow As Data.DataRow
    '        'Dim i

    '        ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '        ' have to provide or create your own.
    '        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '        ' key & unique key information to be retrieved unless AddWithKey is specified.
    '        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '        mySqlDataAdapter.Fill(myDataSet, "custacctopen")
    '        i = DDAcctNo.SelectedIndex

    '        myDataRow = myDataSet.Tables("custacctopen").Rows.Item(i)

    '        Dim mNarratez, mBalance
    '        mNarratez = myDataRow("holdername")
    '        mBalance = myDataRow("totbalance")
    '        LblHolder.Text = mNarratez

    '    End If



    '    ' Create a new Connection and SqlDataAdapter
    '    Dim myConnectionq As Data.SqlClient.SqlConnection
    '    Dim mySqlDataAdapterq As Data.SqlClient.SqlDataAdapter


    '    myConnectionq = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    mySqlDataAdapterq = New Data.SqlClient.SqlDataAdapter("Select * from transactionmaintain where narration='" & Trim(DDTransNo.Text) & "'", myConnectionq)

    '    Dim myDataSetq As Data.DataSet = New Data.DataSet()
    '    Dim myDataRowq As Data.DataRow
    '    'Dim i

    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    ' have to provide or create your own.
    '    Dim myDataRowsqCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapterq)

    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    mySqlDataAdapterq.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    mySqlDataAdapterq.Fill(myDataSetq, "transactionmaintain")
    '    i = DDAcctNo.SelectedIndex

    '    myDataRowq = myDataSetq.Tables("transactionmaintain").Rows.Item(i)

    '    Dim mNarrateq, mradcontracode, macctcontracode
    '    mNarrateq = myDataRowq("transcode")
    '    mradcontracode = myDataRowq("radcontracode")
    '    macctcontracode = myDataRowq("acctcontracode")
    '    TxtTransNo.Text = mradcontracode 'mNarrateq




    'End Sub

    'Protected Sub ButBatch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButBatch.Click
    '    If Not IsNumeric(TxtTransAmt.Text) Then
    '        MsgBox("Invalid Amount entry !!!")
    '        Exit Sub
    '    End If
    '    BatchIt()
    'End Sub

    Public Sub CashType()
        '' Create a new Connection and SqlDataAdapter
        'Dim myConnectionm As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapterm As Data.SqlClient.SqlDataAdapter


        'myConnectionm = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'mySqlDataAdapterm = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin where acctname='" & Trim(DDCenterName.Text) & "'", myConnectionm)

        'Dim myDataSetm As Data.DataSet = New Data.DataSet()
        'Dim myDataRowm As Data.DataRow
        'Dim i, xmyDataRowm

        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRowsmCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapterm)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapterm.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapterm.Fill(myDataSetm, "glaccountadmin")

        'xmyDataRowm = myDataSetm.Tables("glaccountadmin").Rows.Count

        ''If xmyDataRowm > 0 Then

        ''MsgBox("tran " & DDTransNo.Text, MsgBoxStyle.ApplicationModal)

        ''i = DDAcctNo.SelectedIndex

        'myDataRowm = myDataSetm.Tables("glaccountadmin").Rows(0)

        'Dim mNarrateq, mCentCode, mCentBal
        'mCentCode = myDataRowm("glacctno")
        'mNarrateq = myDataRowm("acctname")
        'mCentBal = myDataRowm("glbalance")
        'If IsDBNull(mCentBal) Then mCentBal = 0
        'If mCentBal < 0 Then mCentBal = mCentBal * (-1) 'CONVERT NEGATIVE TO POSITIVE
        'TxtCentCode.Text = mCentCode
        'TxtCentBal.Text = mCentBal
    End Sub


    'Public Sub BatchIt()
    '    If TxtTransAmt.Text = 0 Or TxtTransAmt.Text = "" Or TxtTransAmt.Text = " " Then
    '        MsgBox("Amount cannot be zero !!!", MsgBoxStyle.ApplicationModal)
    '        Exit Sub
    '    End If

    '    If TxtTransAmt.Text > TxtCurBal.Text And Trim(TxtTransNo.Text) = Trim(Session("mCashTranscode")) And DDCrDr.Text = "Withdrawal" Then
    '        MsgBox("Not enough Balance for this transaction !!!", MsgBoxStyle.SystemModal)
    '        Exit Sub
    '    End If

    '    ' Create a new Connection and SqlDataAdapter
    '    Dim myConnection As Data.SqlClient.SqlConnection
    '    Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


    '    myConnection = New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from postingmemory", myConnection)

    '    Dim myDataSet As Data.DataSet = New Data.DataSet()
    '    Dim myDataRow As Data.DataRow

    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    ' have to provide or create your own.
    '    Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    mySqlDataAdapter.Fill(myDataSet, "postingmemory")

    '    myDataRow = myDataSet.Tables("postingmemory").NewRow()

    '    If IsDBNull(TxtTransAmt.Text) Then
    '        MsgBox("Amount cannot be Zero !!!", MsgBoxStyle.ApplicationModal)
    '        Exit Sub
    '    End If


    '    myDataRow("cashaccount") = TxtCentCode.Text
    '    If RadButCustName.Checked Then
    '        myDataRow("acctno") = TxtAcctNo.Text
    '    End If
    '    If RadButAcctNo.Checked Then
    '        myDataRow("acctno") = DDAcctNo.Text
    '    End If
    '    myDataRow("instruno") = TxtInstruNo.Text
    '    myDataRow("transno") = TxtTransNo.Text
    '    myDataRow("transdate") = TxtBranchCode.Text
    '    myDataRow("particular") = TxtParticular.Text
    '    myDataRow("amount") = TxtTransAmt.Text
    '    myDataRow("drcr") = DDCrDr.Text
    '    myDataRow("branchcode") = DDBraCo.Text
    '    myDataRow("curruser") = TxtCurrUser.Text
    '    'myDataRow("contradrcr") = DDContraDrCr.Text


    '    myDataSet.Tables("postingmemory").Rows.Add(myDataRow)
    '    mySqlDataAdapter.Update(myDataSet, "postingmemory")

    '    'GridPosting.UpdateRow()
    '    GridPosting.DataBind()

    '    'Dim mTxtCurBal
    '    'TxtCurBal.Text = myDataSet.Tables("postingmemory").Rows(0)("particular").ToString  '= "Peach"

    '    'TxtCurBal.Text = myDataSet.Tables(0).Columns("particular").ColumnName.ToString()  '= "Peach"
    '    'TxtCurBal = mTxtCurBal

    '    'myDataSet.Tables("postingmemory").PrimaryKey.Equals("radixno")
    '    'Dim myDataRow1 As Data.DataRow = myDataSet.Tables("postingmemory", "radixno").Rows.Find("5555")
    '    'myDataRow1 = myDataRow1("particular") '= "Peach"
    '    TxtTransAmt.Text = 0
    'End Sub

    Protected Sub TxtAcctNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAcctNo.TextChanged

        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        If TxtAcctNo.Text <> " " And TxtAcctNo.Text <> "" Then

            'BIND THE ACCOUNT FOUND TO ACCOUNTS GRIDVIEW
            'AccessDataSource3.DataFile = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & Session("mCompID") & "\" & Session("thebranch") & "\Bankerdata.mdb"
            SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
            SqlDataSource1.DataBind()
            SqlDataSource1.SelectCommand = "Select * from custacctopen where custno='" & Mid(Trim(TxtAcctNo.Text), 5, 5) & "'"
            GridViewAccounts.DataSource = SqlDataSource1
            GridViewAccounts.DataBind()

            myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            If myConnection.State = Data.ConnectionState.Closed Then
                myConnection.Open()
            End If
            mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from custacctopen where acctno='" & Trim(TxtAcctNo.Text) & "'", myConnection)

            Dim myDataSetCust As Data.DataSet = New Data.DataSet()
            Dim myDataRowCust As Data.DataRow

            ' Create command builder. This line automatically generates the update commands for you, so you don't 
            ' have to provide or create your own.
            Dim myDataRowsCustCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

            ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
            ' key & unique key information to be retrieved unless AddWithKey is specified.
            mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

            mySqlDataAdapter.Fill(myDataSetCust, "custacctopen")

            If myDataSetCust.Tables("custacctopen").Rows.Count = 0 Then
                ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Customer Not Found !!!');", True)
                'MsgBox("Customer Not Found !!!", MsgBoxStyle.ApplicationModal)
                Exit Sub
            End If
            myDataRowCust = myDataSetCust.Tables("custacctopen").Rows(0)

            If IsDBNull(myDataRowCust("holdername")) Then myDataRowCust("holdername") = "None"
            If IsDBNull(myDataRowCust("totbalance")) Then myDataRowCust("totbalance") = 0
            If IsDBNull(myDataRowCust("totcot")) Then myDataRowCust("totcot") = 0
            If IsDBNull(myDataRowCust("uncleared")) Then myDataRowCust("uncleared") = 0
            If IsDBNull(myDataRowCust("loan")) Then myDataRowCust("loan") = 0
            If IsDBNull(myDataRowCust("branchcode")) Then myDataRowCust("branchcode") = "None"

            LblHolder.Text = myDataRowCust("holdername")
            LblCurBal.Text = Format(Val(myDataRowCust("totbalance")), "###,###,##0.00") 'Decimal.Round(myDataRowCust("totbalance"), 2)
            LblCOT.Text = Format(Val(myDataRowCust("totcot")), "###,###,##0.00")  'Decimal.ToDouble(myDataRowCust("totcot"))
            LblUnCleared.Text = Format(Val(myDataRowCust("uncleared")), "###,###,##0.00") 'Decimal.ToDouble(myDataRowCust("uncleared"))
            LblLoan.Text = Format(Val(myDataRowCust("loan")), "###,###,##0.00")  'Decimal.ToDouble(myDataRowCust("loan"))
            LblWithAmt.Text = Val(myDataRowCust("totbalance")) - Val(myDataRowCust("totcot"))
            TxtBranchCode.Text = myDataRowCust("branchcode")
            mBranch = myDataRowCust("branchcode")
            'ButPostIt.Enabled = True
        Else

            'MsgBox("Account No cannot be empty !!!")
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account No cannot be empty !!!');", True)
            TxtAcctNo.Focus()
            Exit Sub
        End If


        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from branchsetup where branchcode='" & mBranch & "'", myConnection)

        Dim myDataSetBra As Data.DataSet = New Data.DataSet()
        Dim myDataRowBra As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsBraCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSetBra, "branchsetup")

        If myDataSetBra.Tables("branchsetup").Rows.Count = 0 Then
            'MsgBox("Branch Not Found !!!", MsgBoxStyle.ApplicationModal)
            TxtBranch.Text = "NONE"
            Exit Sub
        End If
        myDataRowBra = myDataSetBra.Tables("branchsetup").Rows(0)

        TxtBranch.Text = myDataRowBra("branchdesc")

        'DDTransType.Enabled = True
        'TxtInstruNo.Enabled = True
        'DDCrDr.Enabled = True
        'TxtParticular.Enabled = True
        'TxtTransAmt.Enabled = True
        'ButPostIt.Enabled = True
        'if (event.code)==13 then
        '        End If
        'Pict_disp()
    End Sub

    Public Sub Init_FieldsPosting()
        TxtAcctNo.Text = ""
        LblHolder.Text = "None"
        'TxtInstruNo.Text = ""
        'TxtParticular.Text = ""
        'TxtTransAmt.Text = 0
        LblCurBal.Text = 0
        LblCOT.Text = 0
        LblUnCleared.Text = 0
        LblLoan.Text = 0
        LblWithAmt.Text = 0
        'CmdSearch.Enabled = False
        'ButPostIt.Enabled = False
    End Sub

    Public Sub Pict_disp()

        'Session("Sign") = Session("SigPath") & "c" & Trim(TxtAcctNo.Text) & ".bmp"  'pcx" ".bmp"
        'Session("Photo") = Session("Gpath") & "p" & Trim(TxtAcctNo.Text) & ".bmp"  'pcx"
        'Session("Sign") = "C:\Inetpub\wwwroot\ShieldBanking\Images\" & "c" & Trim(TxtAcctNo.Text) & ".jpg"  'pcx" ".bmp"
        'Session("Photo") = "C:\Inetpub\wwwroot\ShieldBanking\Images\" & "p" & Trim(TxtAcctNo.Text) & ".bmp"  'pcx"

        'Session("Sign") = "~\ShieldBanking\Images\" & "c" & Trim(TxtAcctNo.Text) & ".jpg"  'pcx" ".bmp"
        Session("notfound") = System.AppDomain.CurrentDomain.BaseDirectory() & "\Images\" & "notavail.bmp"


        Session("Sign") = System.AppDomain.CurrentDomain.BaseDirectory() & "\Images\" & "c" & Trim(TxtAcctNo.Text) & ".jpg"
        'Session("Sign") = System.AppDomain.CurrentDomain.BaseDirectory() & "\Images\" & "c" & Trim(TxtAcctNo.Text) & ".bmp"  'pcx" ".bmp"
        'Session("Photo") = System.AppDomain.CurrentDomain.BaseDirectory() & "\Images\" & "p" & Trim(TxtAcctNo.Text) & ".bmp"  'pcx"

        'If Dir(Session("Photo"), vbNormal) <> "" Then
        '    ImgPhoto.ImageUrl = (Session("Photo"))
        '    'ImgSig.ClearDisplay
        '    'PictPhoto.Picture = LoadPicture(Gpath)
        '    'imgPhoto.FitTo 2, True
        'Else
        '    'PictPhoto.Cls()
        '    ImgPhoto.ImageUrl = Session("Photo") & Session("GPath") & "notfound.bmp"
        '    '   imgPhoto.Display
        '    'PictCard.Cls()
        'End If

        If Dir(Session("Sign"), vbNormal) <> "" Then
            ' Display Signature of Cooperator
            '      ImgSig.ClearDisplay
            '      ImgSig.Image = sigpath
            '      ImgSig.FitTo 2, True
            '      ImgSig.Display
            Response.ContentType = "image/jpeg"
            Response.TransmitFile(Session("Sign"))
            'ImgCard.ImageUrl = Session("Sign")
            'LblNoCard.Visible = False
            'PictCard.Picture = LoadPicture(SigPath)
        Else
            Session("Sign") = System.AppDomain.CurrentDomain.BaseDirectory() & "\Images\" & "c" & Trim(TxtAcctNo.Text) & ".jpeg"

            If Dir(Session("Sign"), vbNormal) <> "" Then
                ' Display Signature of Cooperator
                '      ImgSig.ClearDisplay
                '      ImgSig.Image = sigpath
                '      ImgSig.FitTo 2, True
                '      ImgSig.Display
                Response.ContentType = "image/jpeg"
                Response.TransmitFile(Session("Sign"))
            Else
                'ImgCard.ImageUrl = Session("Sign") & "notavail.bmp"
                '   imgPhoto.Display
                'PictCard.Cls()
                Response.ContentType = "image/bmp"
                Response.TransmitFile(Session("notfound"))
            End If
        End If


        '   With CoopProDatEnv.rsComCoopDet
        '      If !coopName = "DisEngaged" Then
        '         ImgSig.Picture = LoadPicture(App.Path & "\imgdata\nomore.bmp")
        '      Else
        '         ImgSig.Picture = LoadPicture(App.Path & "\imgdata\notavail.bmp")
        '      End If
        '   End With
        'imgphoto.Picture = LoadPicture()
        'imgphoto.Picture = LoadPicture(gpath)
        'Else
        '   PictPhoto.Cls
        '   PictPhoto.Picture = LoadPicture(App.Path & "\imgdata\notfound.bmp")
        ''   imgPhoto.Display
        '   PictCard.Cls
        '   'LblNoCard.Visible = True
        '   With CoopProDatEnv.rsComCoopDet
        '      If .RecordCount <= 0 Then
        '         MsgBox ("The file is empty !!!, Press Enter to Continue.....")
        '         Init_FieldDed
        '         Exit Function
        '     End If
        '     If .EOF Then
        '        .MoveLast
        '        'Exit Sub
        '     End If
        'If !coopname = "DisEngaged" Then
        '   ImgSig.Image = App.Path & "\imgdata\nomore.bmp"
        'Else
        '         ImgSig.Image = App.Path & "\imgdata\notavail.bmp"
        'End If
        ' End With
        '  ImgSig.Display
        'End If

        ' Kill gPATH
        'End If
        'If GRIGIND = 2 Then
        ' mCHQ = DEnvCash.rscomTrans!CHEQNUMBER
        ' If Find_Image(retACCT, gREMOTEFLAG, mCHQ, DEnvCash.rscomTrans, gPATH) Then
        '  gVOUCPHOTO = VB
        '  DEnvCash.rscomAccount.MoveFirst
        '  DEnvCash.rscomAccount.Find "ACCTNUMBER = '" & retACCT & "'"
        '  frmVerify.Show vbModal
        '  If VA = 1 Then
        '   PictGrid.Visible = False
        '  Else
        '   If Load_Grid(retACCT) Then
        '    CmdVou.Enabled = False
        '    CmdPho.Enabled = False
        '    PictGrid.Visible = True
        '   Else
        '    PictGrid.Visible = False
        '   End If
        '  End If
        ' End If
        'Else
        ' gVOUCPHOTO = VB
        ' Call Acct_Show(retACCT)
        ' If VA = 1 Then
        '  PictGrid.Visible = False
        ' Else
        '  If Load_Grid(retACCT) Then
        '   CmdVou.Enabled = False
        '   CmdPho.Enabled = False
        '   PictGrid.Visible = True
        '  Else
        '   PictGrid.Visible = False
        '  End If
        ' End If
        'End If
    End Sub

    'Protected Sub ButSig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButSig.Click
    '    Pict_disp()
    'End Sub

    Protected Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub

End Class