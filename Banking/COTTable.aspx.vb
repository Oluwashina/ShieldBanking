Partial Class COTTable
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CrystalReportViewer1_AfterRender(ByVal source As Object, ByVal e As CrystalDecisions.Web.HtmlReportRender.AfterRenderEvent) Handles CrystalReportViewer1.AfterRender
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_BeforeRender(ByVal source As Object, ByVal e As CrystalDecisions.Web.HtmlReportRender.BeforeRenderEvent) Handles CrystalReportViewer1.BeforeRender
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_BeforeRenderContent(ByVal source As Object, ByVal e As CrystalDecisions.Web.HtmlReportRender.BeforeRenderContentEvent) Handles CrystalReportViewer1.BeforeRenderContent
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.DataBinding
        ''Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        ''mDOBDay = 12  'DOBDay.Text
        ''mDOBMonth = 12   ' DOBMonth.Text
        ''mDOBYear = 2009   'DOBYear.Text
        ''DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        ''Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        ''Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where glaccount='" & Session("mGLNo") & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        '' Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")

        'If myDataSet2.Tables("transdetails").Rows.Count = 0 Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account Not Found in General Ledger !!!');", True)
        '    'MsgBox("Account Not Found in General Ledger !!!" + Session("mCashContAcct"), MsgBoxStyle.ApplicationModal)
        '    Response.Redirect("RepSelGLDate.aspx")
        '    Exit Sub
        'End If

        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("GLStatements.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_Drill(ByVal source As Object, ByVal e As CrystalDecisions.Web.DrillEventArgs) Handles CrystalReportViewer1.Drill
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub



    Protected Sub CrystalReportViewer1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Init
        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where glaccount='" & Session("mGLNo") & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")

        'If myDataSet2.Tables("transdetails").Rows.Count = 0 Then
        '    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account Not Found in General Ledger !!!');", True)
        '    'MsgBox("Account Not Found in General Ledger !!!" + Session("mCashContAcct"), MsgBoxStyle.ApplicationModal)
        '    Exit Sub
        'End If
    End Sub

    Protected Sub CryRepDailyTrans_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CryRepDailyTrans.DataSourceChanged

    End Sub

    Protected Sub CryRepDailyTrans_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles CryRepDailyTrans.Init

    End Sub

    Protected Sub CryRepDailyTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CryRepDailyTrans.Load
        ''Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        ''mDOBDay = 12  'DOBDay.Text
        ''mDOBMonth = 12   ' DOBMonth.Text
        ''mDOBYear = 2009   'DOBYear.Text
        ''DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        ''Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        ''Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where glaccount='" & Session("mGLNo") & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        '' Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")

        ''If myDataSet2.Tables("transdetails").Rows.Count = 0 Then
        ''    ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Account Not Found in General Ledger !!!');", True)
        ''    'MsgBox("Account Not Found in General Ledger !!!" + Session("mCashContAcct"), MsgBoxStyle.ApplicationModal)
        ''    Response.Redirect("RepSelGLDate.aspx")
        ''    Exit Sub
        ''End If

        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("GLStatements.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_OnRenderScript(ByVal source As Object, ByVal e As CrystalDecisions.Web.HtmlReportRender.OnRenderScriptEvent) Handles CrystalReportViewer1.OnRenderScript
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")

        ''Dim aa
        ''aa = CrystalReportViewer1.Page.Items.Item(1)
        ''With myDataSet2
        ''    myDataRow2 = myDataSet2.Tables("transdetails").Rows(0)  ' .NewRow()
        ''    If myDataRow2("drcr") = "Debit" Or myDataRow2("drcr") = "Withdrawal" Then

        ''    End If

        ''End With
        ' ''CrystalReportViewer1.Visible = True
        ''Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ''myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ''myRpt.Load(Server.MapPath("dailylisting.rpt"))
        ''myRpt.SetDataSource(myDataSet2)
        ''CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub CrystalReportViewer1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.PreRender
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

        'mDOBDay = 12  'DOBDay.Text
        'mDOBMonth = 12   ' DOBMonth.Text
        'mDOBYear = 2009   'DOBYear.Text
        'DDUserID = "Gbenga"

        'Dim myConnection As Data.SqlClient.SqlConnection
        'Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
        'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

        'myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        'If myConnection.State = Data.ConnectionState.Closed Then
        '    myConnection.Open()
        'End If

        'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)

        '' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
        ''mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
        'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)


        ''("Select * from transdetails", myConnection)

        'Dim myDataSet2 As Data.DataSet = New Data.DataSet()
        'Dim myDataRow2 As Data.DataRow


        '' Create command builder. This line automatically generates the update commands for you, so you don't 
        '' have to provide or create your own.
        'Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        '' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        '' key & unique key information to be retrieved unless AddWithKey is specified.
        'mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        'mySqlDataAdapter.Fill(myDataSet2, "transdetails")
        ''CrystalReportViewer1.DataBind()
        ''GridView1.DataSource = myDataSet2
        ''GridView1.DataBind()
        ''mySqlDataAdapter.Dispose()
        'CrystalReportViewer1.Visible = True
        'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myRpt.Load(Server.MapPath("dailylisting.rpt"))
        'myRpt.SetDataSource(myDataSet2)
        'CrystalReportViewer1.ReportSource = myRpt

    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub
End Class

