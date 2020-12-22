Public Class GLAcctAdmin
    Inherits System.Web.UI.Page
    Dim myConnection As Data.SqlClient.SqlConnection
    Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
    Public mEdit



    Protected Sub ButSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButSave.Click

        If TxtGLAcctNo.Text = 0 Or TxtGLAcctNo.Text = "" Then
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account cannot be empty !!!');", True)
            Exit Sub
        End If
        If TxtGLName.Text = " " Or TxtGLName.Text = "" Then
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('GL Name cannot be empty !!!');", True)
            Exit Sub
        End If
        If Not IsDate(Trim(TxtDateOpen.Text)) Then
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Date Opened Not a valid date !!!');", True)
            Exit Sub
        End If

        ' Create a new Connection and SqlDataAdapter
        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnection = Session("myConnection")
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin where glacctno='" & TxtGLAcctNo.Text & "'", myConnection)

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        Dim myDataRow As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")

        'If Session("mEdit") = False Then
        'If myDataSet.Tables("glaccountadmin").Rows.Count > 0 Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('GL Code already exist !!!');", True)
        '    'MsgBox("Account Type does not exist !!!")
        '    Exit Sub
        'End If
        'End If

        'If Session("mEdit") = True Then
        If myDataSet.Tables("glaccountadmin").Rows.Count > 0 Then
            myDataRow = myDataSet.Tables("glaccountadmin").Rows(0)
        Else
            myDataRow = myDataSet.Tables("glaccountadmin").NewRow()
        End If

        myDataRow("glacctno") = TxtGLAcctNo.Text
        myDataRow("acctname") = TxtGLName.Text
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Equity" Then
            myDataRow("accttype") = "Ass"   'Trim(DDGLAccTyp.Text)
        End If
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Liability" Then
            myDataRow("accttype") = "Lia"   'Trim(DDGLAccTyp.Text)
        End If
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Assets" Then
            myDataRow("accttype") = "Ass"   'Trim(DDGLAccTyp.Text)
        End If
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Interest And Commisions Receivables - Income" Then
            myDataRow("accttype") = "Inc"   'Trim(DDGLAccTyp.Text)
        End If
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Interest And Commisions Payables - Expenses" Then
            myDataRow("accttype") = "Exp"   'Trim(DDGLAccTyp.Text)
        End If
        If Trim(DDGLAccTyp.SelectedItem.Text) = "Admin and General Overheads" Then
            myDataRow("accttype") = "Adm"   'Trim(DDGLAccTyp.Text)
        End If
        myDataRow("acctdesc") = Trim(DDGLAccTyp.SelectedItem.Text)
        myDataRow("acctnature") = DDGLAcctNat.Text
        myDataRow("dateopened") = Trim(TxtDateOpen.Text)
        myDataRow("headercode") = Trim(DDHeader.SelectedValue)
        'myDataRow("gldebit") = 0
        'myDataRow("glcredit") = 0
        'myDataRow("glbalance") = 0

        'If Session("mEdit") = False Then
        If myDataSet.Tables("glaccountadmin").Rows.Count <= 0 Then
            myDataSet.Tables("glaccountadmin").Rows.Add(myDataRow)
        End If
        mySqlDataAdapter.Update(myDataSet.GetChanges, "glaccountadmin")
        Session("mEdit") = False
        TxtGLAcctNo.Text = 0
        TxtGLName.Text = "None"
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('File Updated !!!');", True)
    End Sub

    'Protected Sub ButPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButPrevious.Click

    '    '    ' Create a new Connection and SqlDataAdapter
    '    '    Dim myConnection As Data.SqlClient.SqlConnection
    '    '    Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
    '    '    Dim mTransTyp


    '    '    myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    '    mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin", myConnection)

    '    '    Dim myDataSet As Data.DataSet = New Data.DataSet()
    '    '    Dim myDataRow As Data.DataRow

    '    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    '    ' have to provide or create your own.
    '    '    Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

    '    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    '    mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    '    mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")

    '    '    'myDataRow = myDataSet.Tables("postingmemory").NewRow()

    '    '    Dim i, ro
    '    '    Dim mTxtGLAcctNo, mTxtGLName, mDDGLAccTyp, mDDGLAcctNat, mTxtDateOpen, mDDHeaDetail

    '    '    For i = 0 To myDataSet.Tables("glaccountadmin").Rows.Count - 1
    '    '        'ddacctno.Items(i).Attributes.Add("style", "color:"+ mydataset.Tables(0).Rows(i)"CategoryColor").ToString())
    '    '        ro = myDataSet.Tables("glaccountadmin").Rows(0)
    '    '        If myDataSet.Tables("glaccountadmin").Rows(0) Then '= myDataSet.Tables("glaccountadmin").Rows(0) Then
    '    '            MsgBox("Begining of File !!!", MsgBoxStyle.AbortRetryIgnore)
    '    '            Exit Sub
    '    '        End If
    '    '        i = i + 1
    '    '        myDataRow = myDataSet.Tables("glaccountadmin").Rows.Item(i)

    '    '        'mTxtGLAcctNo = myDataRow("glacctno")
    '    '        'mTxtGLName = myDataRow("acctname")
    '    '        'mDDGLAccTyp = myDataRow("accttype")
    '    '        'mDDGLAcctNat = myDataRow("acctnature")
    '    '        'mTxtDateOpen = myDataRow("dateopened")
    '    '        'mDDHeaDetail = myDataRow("headerordetail")

    '    '        TxtGLAcctNo.Text = myDataRow("glacctno")
    '    '        TxtGLName.Text = myDataRow("acctname")
    '    '        DDGLAccTyp.Text = myDataRow("accttype")
    '    '        DDGLAcctNat.Text = myDataRow("acctnature")
    '    '        TxtDateOpen.Text = myDataRow("dateopened")
    '    '        DDHeaDetail.Text = myDataRow("headerordetail")


    '    '    Next


    '    '    'myDataSet.Tables("post
    'End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        TxtDateOpen.Text = Date.Today

        ' Create a new Connection and SqlDataAdapter
        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


        myConnection = Session("myConnection") 'New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccttype", myConnection)   ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow
        'Dim i

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        DDGLAccTyp.Items.Clear()

        mySqlDataAdapter.Fill(myDataSet, "glaccttype")
        DDGLAccTyp.DataSource = myDataSet.Tables(0)
        DDGLAccTyp.DataTextField = myDataSet.Tables(0).Columns("accttypedesc").ColumnName.ToString
        DDGLAccTyp.DataValueField = myDataSet.Tables(0).Columns("Accttypecode").ColumnName.ToString
        DDGLAccTyp.DataBind()



        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from GLHeaderFile", myConnection)   ' where acctradix='" & Trim(DDRadixCode.Text) & "'", myConnection)

        Dim myDataSetH As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow
        'Dim i

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsHCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        DDHeader.Items.Clear()

        mySqlDataAdapter.Fill(myDataSetH, "GLHeaderFile")
        DDHeader.DataSource = myDataSetH.Tables(0)
        DDHeader.DataTextField = myDataSetH.Tables(0).Columns("Headername").ColumnName.ToString
        DDHeader.DataValueField = myDataSetH.Tables(0).Columns("Headercode").ColumnName.ToString
        DDHeader.DataBind()


        TxtGLAcctNo.Text = 0
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub ButChgDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButChgDate.Click
        CalStart.Visible = True
    End Sub

    Protected Sub CalStart_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalStart.SelectionChanged
        CalStart.Visible = False
        TxtDateOpen.Text = CalStart.SelectedDate
    End Sub

    'Protected Sub ButAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButAdd.Click
    '    TxtGLAcctNo.Enabled = True
    '    TxtGLName.Enabled = True
    '    'DDGLAccTyp.Enabled = True
    '    DDGLAccTyp.Enabled = True
    '    DDGLAcctNat.Enabled = True
    '    TxtDateOpen.Enabled = True
    'End Sub

    'Protected Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click

    '    myConnection = Session("myConnection")     'New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
    '    mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin where glacctno='" & TxtGLAcctNo.Text & "'", myConnection)

    '    Dim myDataSet As Data.DataSet = New Data.DataSet()
    '    Dim myDataRow As Data.DataRow

    '    ' Create command builder. This line automatically generates the update commands for you, so you don't 
    '    ' have to provide or create your own.
    '    Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)
    '    Dim mBoleenTyp

    '    ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
    '    ' key & unique key information to be retrieved unless AddWithKey is specified.
    '    mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

    '    mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")

    '    If myDataSet.Tables("glaccountadmin").Rows.Count > 0 Then
    '        'ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account Already exist !!!');", True)
    '        'MsgBox("Account Type does not exist !!!")

    '        myDataSet.Tables("glaccountadmin").Rows(0).Delete()

    '        'myDataSet.Tables("acctfile").Rows.Item(1).Delete()

    '        mySqlDataAdapter.Update(myDataSet, "glaccountadmin")
    '    End If
    'End Sub

    Protected Sub ButSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButSearch.Click

        If TxtGLAcctNo.Text = 0 Or TxtGLAcctNo.Text = "" Then
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account cannot be empty !!!');", True)
            Exit Sub
        End If

        ' Create a new Connection and SqlDataAdapter
        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


        myConnection = Session("myConnection")     'New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin where glacctno='" & TxtGLAcctNo.Text & "'", myConnection)

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        Dim myDataRow As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)
        Dim mBoleenTyp

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "glaccountadmin")

        If myDataSet.Tables("glaccountadmin").Rows.Count > 0 Then

            myDataRow = myDataSet.Tables("glaccountadmin").Rows(0)

            If IsDBNull(myDataRow("glacctno")) Then myDataRow("glacctno") = "0" '(DDAcctType.SelectedItem.Text)
            If IsDBNull(myDataRow("acctname")) Then myDataRow("acctname") = "None"
            If IsDBNull(myDataRow("acctdesc")) Then myDataRow("acctdesc") = "None"
            If IsDBNull(myDataRow("acctnature")) Then myDataRow("acctnature") = "P"
            If IsDBNull(myDataRow("dateopened")) Then myDataRow("dateopened") = Date.Today ' "None"
            'If IsDBNull(myDataRow("cot")) Then myDataRow("cot") = "None"

            TxtGLAcctNo.Text = myDataRow("glacctno")
            TxtGLName.Text = myDataRow("acctname")
            'myDataRow("accttype") = Trim(DDGLAccTyp.Text)
            DDGLAccTyp.SelectedItem.Text = myDataRow("acctdesc")
            DDGLAcctNat.Text = myDataRow("acctnature")
            TxtDateOpen.Text = myDataRow("dateopened")
            'myDataRow("gldebit") = 0
            'myDataRow("glcredit") = 0
            'myDataRow("glbalance") = 0
            TxtGLAcctNo.Enabled = False
            TxtGLName.Enabled = False
            DDGLAccTyp.Enabled = False
            DDGLAccTyp.Enabled = False
            DDGLAcctNat.Enabled = False
            TxtDateOpen.Enabled = False

        Else
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account not exist !!!');", True)
            TxtGLAcctNo.Text = 0
            TxtGLName.Text = "None"
            'DDGLAccTyp.Text = 0
            'DDGLAccTyp.Enabled = True
            'DDGLAcctNat.Enabled = True
            'TxtDateOpen.Enabled = True
        End If
    End Sub

    Protected Sub ButEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButEdit.Click
        'Dim mEdit
        Session("mEdit") = True
        TxtGLAcctNo.Enabled = False
        TxtGLName.Enabled = True
        DDGLAccTyp.Enabled = True
        DDGLAccTyp.Enabled = True
        DDGLAcctNat.Enabled = True
        TxtDateOpen.Enabled = True
    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub

    Protected Sub ButPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButPrint.Click
        Response.Redirect("GLBalanceREP.aspx")
    End Sub

End Class