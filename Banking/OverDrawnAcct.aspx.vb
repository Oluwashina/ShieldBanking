
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Partial Class OverDrawnAcct
    Inherits System.Web.UI.Page
    'Dim myReportDocument

    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        ' myReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        'myReportDocument.Close()
        'myReportDocument.Dispose()
    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
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

            cryRpt.Load(Server.MapPath("OverdrawnAcct.rpt"))

            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            CrystalReportViewer1.ReportSource = cryRpt
            'CrystalReportViewer1.Refresh()

            Dim myConnection As Data.SqlClient.SqlConnection
            Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter
            ' Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
            'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

            myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            If myConnection.State = Data.ConnectionState.Closed Then
                myConnection.Open()
            End If

            'mm = Convert.ToDateTime(mDOBMonth & "/" & mDOBDay & "/" & mDOBYear)


            'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  drcr='" & "Debit" & "'", myConnection)
            'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & UCase(Session("mUser")) & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)
            mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from CustAcctOpen", myConnection)

            '("Select * from transdetails", myConnection)

            Dim myDataSet2 As Data.DataSet = New Data.DataSet()
            'Dim myDataRow2 As Data.DataRow


            ' Create command builder. This line automatically generates the update commands for you, so you don't 
            ' have to provide or create your own.
            Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

            ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
            ' key & unique key information to be retrieved unless AddWithKey is specified.
            mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

            mySqlDataAdapter.Fill(myDataSet2, "CustAcctOpen")

            'CrystalReportViewer1.Visible = True
            ''Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'cryRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'cryRpt.Load(Server.MapPath("dailylisting.rpt"))
            'cryRpt.SetDataSource(myDataSet2)
            'CrystalReportViewer1.ReportSource = cryRpt

            cryRpt.Load(Server.MapPath("OverdrawnAcct.rpt"))
            cryRpt.SetDataSource(myDataSet2)
            CrystalReportViewer1.ReportSource = cryRpt

            'Dim objTextBF As CrystalDecisions.CrystalReports.Engine.TextObject = myRpt.ReportDefinition.Sections(1).ReportObjects("bank1")
            'objTextBF.Text = Session("mBankName")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
