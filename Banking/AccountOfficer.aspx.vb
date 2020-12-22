Public Class AccountOfficer
    Inherits System.Web.UI.Page

    Protected Sub ButSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButSave.Click
        ' Create a new Connection and SqlDataAdapter
        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter


        'myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from accountofficer", myConnection)

        Dim myDataSet As Data.DataSet = New Data.DataSet()
        Dim myDataRow As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSet, "accountofficer")

        myDataRow = myDataSet.Tables("accountofficer").NewRow()
        myDataRow("officerinitial") = TxtOffInit.Text '"NewID"
        myDataRow("narration") = TxtNarration.Text '"New Name"
        'myDataRow("CompanyName") = "New Company Name"

        myDataSet.Tables("accountofficer").Rows.Add(myDataRow)
        mySqlDataAdapter.Update(myDataSet, "accountofficer")

        SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
        SqlDataSource1.SelectCommand = "Select * from accountofficer"
        GridViewDet.DataSource = SqlDataSource1

        GridViewDet.DataBind()
        GridViewDet.Enabled = True
        GridViewDet.Page.Validate()
        GridViewDet.EditIndex = -1
        'GridViewJ.UpdateRow(0, True)
        Page.Validate()
        Page.EnableViewState = True
        Page.DataBind()
        'GridViewJ.DataSource = AccessDataSource1
        GridViewDet.DataBind()
        Page.Validate()



        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Record Created !!!');", True)



    End Sub

    'Protected Sub ButPrev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButPrev.Click
    '    If GridViewDet.SelectedIndex >= 0 Then
    '        TxtNarration.Text = GridViewDet.Columns(2).ToString
    '        GridViewDet.SelectedIndex = GridViewDet.SelectedIndex - 1
    '        TxtOffInit.Text = GridViewDet.Rows.Item(1).Cells.Item(1).Text
    '        TxtNarration.Text = GridViewDet.Rows.Item(2).Cells.Item(1).Text
    '    End If
    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim Conn1 as New ADODB.Connection
        'Dim Cmd1 As New ADODB.Command
        'Dim Errs1 As ADODB.Errors
        'Dim Rs1 As New ADODB.Recordset
        'Dim i As Integer
        'Dim AccessConnect As String

        ' ''AccessConnect = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|BankerData.mdb;Persist Security Info=True")
        ''AccessConnect = "Driver={Microsoft Access Driver (*.mdb)};" & "Dbq=BankerData.mdb;" & _
        ''"DefaultDir=|DataDirectory|;" & _
        ''"Uid=Admin;Pwd=;"
        ' '' Session("myConnection")

        ''Session("myADODBConnection").ConnectionString = AccessConnect
        ''Session("myADODBConnection").Open()
        ''Cmd1.ActiveConnection = Session("myADODBConnection")
        ''Cmd1.CommandText = ("select * from transactionmaintain where transcode='" & Trim(TxtTranscode.Text)) '& "'", Session("myADODBConnection"))
        ' ''("Select * from GLAccountAdmin where glacctno='" & Mid(Trim(TxtAcctNo.Text), 2, 8) & "'", myConnection)
        ''Rs1 = Cmd1.Execute

        'Session("myADODBConnection") = New ADODB.Connection
        'with Conn1
        '    .Provider = "Microsoft.JET.OLEDB.4.0"
        '    .ConnectionString = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\IreePoly\ireepolydbase.MDB" 'Write your access Database name
        '    .Open()
        'End With

        'Rs1 = New ADODB.Recordset
        'Rs1.Open("select * from SelectionControl where itemname='" & Trim(DDItemName.Text) & "'", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        'If Rs1.RecordCount = 0 Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Record Not Found !!!');", True)
        '    Exit Sub
        'Else
        '    With Rs1
        '        .MoveFirst()
        '        '.AddNew()
        '        .Fields("itemname").Value = Trim(DDItemName.Text)
        '        .Fields("itemdesc").Value = Trim(TxtItemDesc.Text)
        '        .Fields("valuetype").Value = Trim(DDValueType.Text)
        '        .Fields("pervalue").Value = Trim(TxtPercentValue.Text)
        '        .Fields("percentof").Value = Trim(DDPercentOf.Text)
        '        If CheckEnabled.Checked = True Then
        '            .Fields("enabled").Value = True
        '        Else
        '            .Fields("enabled").Value = False
        '        End If

        '        .Update()
        '    End With

        'End If


        'ButEdit.Text = "Edit"
        SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
        SqlDataSource1.SelectCommand = "Select * from accountofficer"
        GridViewDet.DataSource = SqlDataSource1

        GridViewDet.DataBind()
        GridViewDet.Enabled = True
        GridViewDet.Page.Validate()
        GridViewDet.EditIndex = -1
        'GridViewJ.UpdateRow(0, True)
        Page.Validate()
        Page.EnableViewState = True
        Page.DataBind()
        'GridViewJ.DataSource = AccessDataSource1
        GridViewDet.DataBind()
        Page.Validate()

    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub

    'Protected Sub ButNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButNext.Click
    '    If GridViewDet.Rows.Count > GridViewDet.SelectedIndex Then
    '        GridViewDet.SelectedIndex = GridViewDet.SelectedIndex + 1
    '        TxtOffInit.Text = GridViewDet.Rows.Item(1).Cells.Item(1).Text
    '        TxtNarration.Text = GridViewDet.Rows.Item(2).Cells.Item(1).Text
    '    End If
    'End Sub

    Protected Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        '' Create a new Connection and SqlDataAdapter
        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mTxtOffInit

        'mTxtOffInit = GridViewDet.SelectedRow.Cells(1).Text    '.Rows.Item(0).Cells.Item(0).Text

        ''myConnection = New Data.SqlClient.SqlConnection("Dsn=BankSource;dbq=C:\BankSolutions\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from accountofficer where officerinitial=" & Trim(mTxtOffInit) & "'", myConnection)

        'Dim myDataSet As Data.DataSet = New Data.DataSet()
        'Dim myDataRow As Data.DataRow

        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRowsCommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet, "accountofficer")

        'myDataRow = myDataSet.Tables("accountofficer").Rows(0)

        'If myDataSet.Tables("accountofficer").Rows.Count > 0 Then
        '    myDataRow.Delete()
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Record Created !!!');", True)
        'End If
    End Sub

End Class