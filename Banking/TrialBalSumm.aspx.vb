Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Partial Class TrialBalSumm
    Inherits System.Web.UI.Page
    'Dim myReportDocument
    Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()

        Response.Redirect("welcome.aspx")
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        'myReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportSource1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportSource1.Load
        Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'myRpt.Close()
        'myRpt.Dispose()

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

            cryRpt.Load(Server.MapPath("TrialBalanceSum.rpt"))

            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            CrystalReportViewer1.ReportSource = cryRpt
            'CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportSource1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportSource1.Unload
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportViewer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub CrystalReportViewer1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Unload
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Protected Sub form1_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Unload
        myRpt.Close()
        myRpt.Clone()
        myRpt.Dispose()
        'myRpt = null
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
End Class
