Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Partial Class LoanClassRep
    Inherits System.Web.UI.Page

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

    'Protected Sub CrystalReportViewer1_Drill(ByVal source As Object, ByVal e As CrystalDecisions.Web.DrillEventArgs) Handles CrystalReportViewer1.Drill
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

    'End Sub



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

    Protected Sub CrystalReportViewer1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        'Dim mDOBDay, mDOBMonth, mDOBYear, DDUserID, mm

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

            cryRpt.Load(Server.MapPath("LoanClassRep.rpt"))

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
            'Dim mySqlDataAdapterCust1 As Data.SqlClient.SqlDataAdapter
            'Dim mySqlDataAdaptype As Data.SqlClient.SqlDataAdapter

            myConnection = Session("myConnection")  'New Data.SqlClient.SqlConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
            If myConnection.State = Data.ConnectionState.Closed Then
                myConnection.Open()
            End If

            ' mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "' and  transdate=#" & Convert.ToDateTime(mDOBMonth + "/" + mDOBDay + "/" + mDOBYear) & "#", myConnection)
            'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where curruser='" & Trim(DDUserID) & "'", myConnection) ' and  transdate=#" & mm & "#", myConnection)
            'mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from transdetails where acctno='" & Session("mCustNo") & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)
            mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from Loanacct", myConnection)   'transdetails where acctno='" & Session("mCustNo") & "' and  transdate>=#" & Session("mFromDate") & "# and transdate<=#" & Session("mToDate") & "#", myConnection)


            '("Select * from transdetails", myConnection)

            Dim myDataSet2 As Data.DataSet = New Data.DataSet()
            Dim myDataRow2 As Data.DataRow


            ' Create command builder. This line automatically generates the update commands for you, so you don't 
            ' have to provide or create your own.
            Dim myDataRows2CommandBuilder As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

            ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
            ' key & unique key information to be retrieved unless AddWithKey is specified.
            mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

            mySqlDataAdapter.Fill(myDataSet2, "loanacct")

            If myDataSet2.Tables("loanacct").Rows.Count = 0 Then
                ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Loan File Empty !!!');", True)
                'MsgBox("Account Not Found in General Ledger !!!" + Session("mCashContAcct"), MsgBoxStyle.ApplicationModal)
                'Response.Redirect("RepSelGLDate.aspx")
                Exit Sub
            End If

            Dim mCount, mDateExpire, mBalamt, mCharged
            Dim mLoanExpDays As System.TimeSpan '  = 0
            mCount = 0

            Do While mCount < ((myDataSet2.Tables("loanacct").Rows.Count) - 1)

                myDataRow2 = myDataSet2.Tables("loanacct").Rows(mCount)
                mDateExpire = myDataRow2("dateexpired")

                'CHECK LOAN STATUS
                If Not IsDBNull(mDateExpire) Then
                    mBalamt = myDataRow2("loanbalance")
                    mLoanExpDays = Session("mTransDate") - mDateExpire 'mDategrant

                    'PERFORMING
                    'If mLoanExpDays < 30 Then
                    If mLoanExpDays.Days < 1 Then
                        mCharged = Val(mBalamt) * 0.01
                        myDataRow2("performing") = mCharged
                    Else
                        myDataRow2("performing") = 0
                    End If

                    'PASS AND WATCH
                    'If mLoanExpDays >= 30 And mLoanExpDays <= 89 Then
                    If mLoanExpDays.Days >= 1 And mLoanExpDays.Days <= 30 Then
                        mCharged = Val(mBalamt) * 0.05
                        myDataRow2("passwatch") = mCharged
                    Else
                        myDataRow2("passwatch") = 0
                    End If

                    'SUBSTANDARD
                    'If mLoanExpDays >= 90 And mLoanExpDays <= 179 Then
                    If mLoanExpDays.Days >= 31 And mLoanExpDays.Days <= 60 Then
                        mCharged = Val(mBalamt) * 0.2    '1
                        myDataRow2("substandard") = mCharged
                    Else
                        myDataRow2("substandard") = 0
                    End If

                    'DOUBTFULL
                    If mLoanExpDays.Days >= 61 And mLoanExpDays.Days <= 90 Then
                        mCharged = Val(mBalamt) * 0.5
                        myDataRow2("doubtfull") = mCharged
                    Else
                        myDataRow2("doubtfull") = 0
                    End If

                    'LOST
                    If mLoanExpDays.Days >= 91 Then
                        mCharged = Val(mBalamt) * 1
                        myDataRow2("loss") = mCharged
                    Else
                        myDataRow2("loss") = 0
                    End If

                    'CALCULATE DEFAULT DAYS
                    Dim mPeriod = 0
                    Dim mDefaultDays, mNextPay
                    mPeriod = myDataRow2("repayperiod")
                    mPeriod = Val(mPeriod) / 30


                    Dim dt1 As DateTime = Convert.ToDateTime(myDataRow2("lastbaldate"))
                    'Dim dt2 As DateTime = Convert.ToDateTime(ddl2.selectedvalue)
                    Dim nextduedate = dt1.AddDays(30)
                    mNextPay = nextduedate 'myDataRow2("lastbaldate") + 30

                    Dim currentdate As DateTime = Convert.ToDateTime(Session("mTransDate"))
                    Dim dt2 As DateTime = Convert.ToDateTime(mNextPay)
                    Dim diffInDays As Integer = dt2.Subtract(currentdate).Days
                    'Dim nextduedate = dt1.AddDays(30)

                    If diffInDays <= 0 Then
                        diffInDays = Math.Abs(diffInDays)
                    Else
                        diffInDays = 0
                    End If

                    mDefaultDays = diffInDays 'Session("mTransDate") - mNextPay
                    'mDefaultDays = Val(mDefaultDays) / 30
                    If mDefaultDays > 0 Then
                        myDataRow2("defaultdays") = mDefaultDays
                    Else
                        myDataRow2("defaultdays") = 0
                    End If

                    mySqlDataAdapter.Update(myDataSet2, "loanacct")

                    mCharged = 0
                    'myDataRow2 = myDataSet2.Tables("loanacct").Rows(mCount + 1)
                End If
                mCount = mCount + 1
            Loop
            'MsgBox("End Of Classification !!!")

            'CrystalReportViewer1.Visible = True
            'Dim myRpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'myRpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'myRpt.Load(Server.MapPath("LoanClassRep.rpt"))
            'myRpt.SetDataSource(myDataSet2)
            'CrystalReportViewer1.ReportSource = myRpt


            cryRpt.Load(Server.MapPath("LoanClassRep.rpt"))
            cryRpt.SetDataSource(myDataSet2)
            CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub
End Class
