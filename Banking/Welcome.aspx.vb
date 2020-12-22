
Partial Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Session.Timeout = 70000

        'Dim con
        'Dim cmd
        'Dim ConnectMe
        'con = New AccessDataSource
        'cmd = New DataControlCommands
        'string connect="Data Source=MCN0100;Initial Catalog=RecordEdit; uid=sa; Pwd=";"
        'LblBank.Text = Session("mBankName")
        LblBankName.Text = Session("mBankName")
    End Sub

    'Protected Sub XmlDataSource1_Transforming(ByVal sender As Object, ByVal e As System.EventArgs) Handles XmlDataSource1.Transforming

    'End Sub

    'Protected Sub AdRotator1_AdCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AdCreatedEventArgs) Handles AdRotator1.AdCreated
    '    'e.ImageUrl = "advert/THIS IS ASTRA je.gif"
    '    'e.NavigateUrl = "http://localhost/ShieldBanking/"
    '    ''e.ImageUrl = "advert/THIS IS ASTRA.gif"
    '    'e.AlternateText = "Ad for Emolog, Ltd. Web site"
    'End Sub


    Protected Sub ButAcctOpen_Click(sender As Object, e As EventArgs) Handles ButAcctOpen.Click
        Response.Redirect("CustAcctAdmini.aspx")
    End Sub

    Protected Sub ButTransPosting_Click(sender As Object, e As EventArgs) Handles ButTransPosting.Click
        Response.Redirect("PostingRealTime.aspx")
    End Sub

    Protected Sub ButBalEnquiry_Click(sender As Object, e As EventArgs) Handles ButBalEnquiry.Click
        Response.Redirect("CustBalEnq.aspx")
    End Sub

    Protected Sub ButCustStatement_Click(sender As Object, e As EventArgs) Handles ButCustStatement.Click
        Response.Redirect("RepselCustNoDate.aspx")
    End Sub

    Protected Sub ButOpenBranch_Click(sender As Object, e As EventArgs) Handles ButOpenBranch.Click
        Dim myConnection As Data.SqlClient.SqlConnection
        Dim mySqlDataAdapter As Data.SqlClient.SqlDataAdapter

        'SAVE GENERATED INVOICE NO
        myConnection = Session("myConnection")  'New Data.OleDb.OleDbConnection("Dsn=BankerData;dbq=C:\ShieldBanking\App_Data\BankerData.mdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;pwd=gbenga;uid=admin")
        If myConnection.State = Data.ConnectionState.Closed Then
            myConnection.Open()
        End If

        mySqlDataAdapter = New Data.SqlClient.SqlDataAdapter("Select * from Datacont", myConnection)

        Dim myDataSetInv1 As Data.DataSet = New Data.DataSet()
        Dim myDataRowInv1 As Data.DataRow

        ' Create command builder. This line automatically generates the update commands for you, so you don't 
        ' have to provide or create your own.
        Dim myDataRowsInv1CommandBuilder1 As Data.SqlClient.SqlCommandBuilder = New Data.SqlClient.SqlCommandBuilder(mySqlDataAdapter)

        ' Set the MissingSchemaAction property to AddWithKey because Fill will not cause primary
        ' key & unique key information to be retrieved unless AddWithKey is specified.
        mySqlDataAdapter.MissingSchemaAction = Data.MissingSchemaAction.AddWithKey

        mySqlDataAdapter.Fill(myDataSetInv1, "Datacont")

        myDataRowInv1 = myDataSetInv1.Tables("Datacont").Rows(0)
        'If IsDBNull(myDataRowInv1("invno")) Then myDataRowInv1("invno") = 0

        myDataRowInv1("branchactivated") = True
        mySqlDataAdapter.Update(myDataSetInv1.GetChanges, "Datacont")

        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "TestAlert", "alert('Branch Operation Openned Sucessfully....');", True)

    End Sub

    Protected Sub ButPostAuthorize_Click(sender As Object, e As EventArgs) Handles ButPostAuthorize.Click
        Response.Redirect("Authorise.aspx")
    End Sub

    Protected Sub ButSMSControl_Click(sender As Object, e As EventArgs) Handles ButSMSControl.Click
        Response.Redirect("SMSControl.aspx")
    End Sub


    Protected Sub ButRunEOD_Click(sender As Object, e As EventArgs) Handles ButRunEOD.Click

        Response.Redirect("EndOfDay.aspx")
    End Sub

End Class
