Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Partial Class DetailBalanceSheet
    Inherits System.Web.UI.Page
    'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Protected Sub CrystalReportViewer1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Disposed
        ''CrystalReportSource1.ReportDocument.Close()
        ''CrystalReportSource1.ReportDocument.Dispose()
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportViewer1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Init
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportViewer1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Unload
        ''CrystalReportSource1.ReportDocument.Close()
        ''CrystalReportSource1.ReportDocument.Dispose()
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        ''CrystalReportSource1.ReportDocument.Close()
        ''CrystalReportSource1.ReportDocument.Dispose()
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
        Response.Redirect("welcome.aspx")
    End Sub

    Protected Sub CrystalReportSource1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportSource1.Init
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportSource1_Load(sender As Object, e As EventArgs) Handles CrystalReportSource1.Load
        Dim CrTables As Tables
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim path1 As String = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\" & Trim(Session("mCompID")) & "\01\"  'My.Application.Info.DirectoryPath '' path

        Try
            'reportdoc object
            Dim cryRpt As New ReportDocument

            'load report
            'cryRpt.Load(My.Application.Info.DirectoryPath.ToString() & "\Report1.rpt")

            'parameters definition(if any)

            'provide connection info. This is important and you can change it as per your db location
            With crConnectionInfo
                .ServerName = path1 & "\Bankerdata.mdb"
                '.DatabaseName = ""
                '.UserID = ""
                '.Password = "password"
            End With

            cryRpt.Load(Server.MapPath("DetailBalanceSheet.rpt"))

            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            CrystalReportViewer1.ReportSource = cryRpt
            'CrystalReportViewer1.Refresh()

            Dim myConnectionBF As Data.SqlClient.SqlConnection
            Dim mySqlDataAdapterBF As Data.SqlClient.SqlDataAdapter
            'Dim mySqlDataAdapterCust1 As Data.OleDb.OleDbDataAdapter
            'Dim mySqlDataAdaptype As Data.OleDb.OleDbDataAdapter
            Dim MCOUNT, mCustBalBF, mCustBalBF2
            MCOUNT = 0
            mCustBalBF = 0
            mCustBalBF2 = 0

            myConnectionBF = Session("myConnection")  'New Data.OleDb.OleDbConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            If myConnectionBF.State = Data.ConnectionState.Closed Then
                myConnectionBF.Open()
            End If

            ' mySqlDataAdapter = New Data.OleDb.OleDbDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
            'mySqlDataAdapter = New Data.OleDb.OleDbDataAdapter("Select * from transdetails where curruser='" & Session("mCustNo") & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
            'mySqlDataAdapterBF = New Data.OleDb.OleDbDataAdapter("Select * from glaccountadminBRANCH where glacctno='" & Trim(mListAcctDr) & "' AND branchcode='" & Trim(Session("mbranchcode")) & "'", myConnectionBF)

            'If Session("SelectedBranch") = "All" Then
            mySqlDataAdapterBF = New Data.SqlClient.SqlDataAdapter("Select * from glaccountadmin", myConnectionBF)
            'Else
            'mySqlDataAdapterBF = New Data.OleDb.OleDbDataAdapter("Select * from glaccountadminBRANCH where branchcode='" & Trim(Session("SelectedBranch")) & "'", myConnectionBF)
            'End If

            '("Select * from transdetails", myConnection)

            Dim myDataSetBF As Data.DataSet = New Data.DataSet()
            Dim myDataRowBF As Data.DataRow


            ' Create command builder. This line automatically generates the update commands for you, so you don't 
            ' have to provide or create your own.
            Dim myDataRows2CommandBuilderBF As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapterBF)

            ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
            ' key & unique key information to be retrieved unless AddWithKey is specified.
            mySqlDataAdapterBF.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

            mySqlDataAdapterBF.Fill(myDataSetBF, "glaccountadmin")

            If myDataSetBF.Tables("glaccountadmin").Rows.Count <= 0 Then
                ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('No record for this branch !!!');", True)
                'MsgBox("Account Type does not exist !!!")
                Exit Sub
            End If

            'CrystalReportViewer1.Visible = True
            'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'CrystalReportViewer1.Visible = True
            ''Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'myRpt.Load(Server.MapPath("DetailTrialBalance.rpt"))
            'myRpt.SetDataSource(myDataSetBF)
            ''myRpt.ExportToHttpResponse(ExportFormatType.Text, Response, False, "ExportedReport")
            'CrystalReportViewer1.ReportSource = myRpt

            cryRpt.Load(Server.MapPath("DetailBalanceSheet.rpt"))
            cryRpt.SetDataSource(myDataSetBF)
            CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub CrystalReportSource1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportSource1.Unload
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub form1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Unload
        'myRpt.Close()
        'myRpt.Clone()
        'myRpt.Dispose()
        ''myRpt = null
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
    End Sub
End Class
