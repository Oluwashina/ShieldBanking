
Partial Class SMSControl
    Inherits System.Web.UI.Page
    Public mSMSTrnAcct, mSMSAcctName, mSMSCrAmt, mSMSDrAmt, mSMSBalAmt, mSMSTrnDate, mSMSAmtChg, Destination, mSMSParticular, mSMSAvailbal
    Public mSucessful, mTotSMSChg, mSource, Message, mKeyword, mFound, GridAcctDelete

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1, RsGLAdmin As New ADODB.Recordset

        Rs1 = New ADODB.Recordset
        Rs1.Open("delete from SMSTrnData WHERE SUCCESSFUL='" & "True" & "'", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
        SqlDataSource1.SelectCommand = "Select * from SMSTrnData"
        GridViewDet.DataSource = SqlDataSource1

        'AccessDataSource1.DataFile = System.AppDomain.CurrentDomain.BaseDirectory() & "App_Data\ShieldModules\SMSApp.mdb"

        'AccessDataSource1.SelectCommand = "select * from SMSTrnData"
        'GridViewDet.DataSource = AccessDataSource1
        GridViewDet.DataBind()

        GridViewDet.Enabled = True
        GridViewDet.Page.Validate()
        GridViewDet.EditIndex = -1

    End Sub

    Protected Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Response.Redirect("welcome.aspx")
    End Sub

    Protected Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Dim Conn1S As New ADODB.Connection
        Dim Cmd1S As New ADODB.Command
        Dim Rs1S, RsGLAdmin As New ADODB.Recordset

        GridViewDet_SelectedIndexChanged(Me, e)

        Rs1S = New ADODB.Recordset
        Rs1S.Open("delete from SMSTrnData WHERE acctno='" & Trim(GridAcctDelete) & "'", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

        SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
        SqlDataSource1.SelectCommand = "Select * from SMSTrnData"
        GridViewDet.DataSource = SqlDataSource1

        'AccessDataSource1.DataFile = System.AppDomain.CurrentDomain.BaseDirectory() & "App_Data\ShieldModules\SMSApp.mdb"

        'AccessDataSource1.SelectCommand = "select * from SMSTrnData"
        'GridViewDet.DataSource = AccessDataSource1
        GridViewDet.DataBind()

        GridViewDet.Enabled = True
        GridViewDet.Page.Validate()
        GridViewDet.EditIndex = -1
    End Sub

    Protected Sub ButSend_Click(sender As Object, e As EventArgs) Handles ButSend.Click
        'Send SMS to customer from SMS Transaction File

        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1, Rs2, Rs3 As New ADODB.Recordset

        'Dim row As GridViewRow = GridViewSum.SelectedRow

        'Conn1 = New ADODB.Connection
        'With Conn1
        '    .Provider = "Microsoft.JET.OLEDB.4.0"
        '    .ConnectionString = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\ShieldModules\SMSApp.mdb" 'Write your access Database name
        '    .Open()
        'End With

        Rs1 = New ADODB.Recordset
        Rs1.Open("select * from SMSTrnData", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        'Rs1.Close()

        With Rs1

            If .RecordCount > 0 Then
                .MoveFirst()
            Else
                MsgBox("SMS Transaction File Empty !!!")
                Exit Sub
            End If

            Dim NoPhone = False

            Do While Not .EOF

                'mSMSTrnRad = !radix
                mSMSTrnAcct = .Fields("acctno").Value
                mSMSAcctName = .Fields("acctname").Value
                mSMSCrAmt = .Fields("cramt").Value
                mSMSDrAmt = .Fields("dramt").Value
                mSMSBalAmt = .Fields("balamt").Value
                mSMSTrnDate = .Fields("trndate").Value
                mSMSAmtChg = .Fields("chgamount").Value
                Destination = .Fields("telno").Value
                mSMSParticular = .Fields("particular").Value
                mSMSAvailbal = .Fields("availbal").Value


                If IsDBNull(mSMSCrAmt) Then mSMSCrAmt = 0
                If IsDBNull(mSMSDrAmt) Then mSMSDrAmt = 0

                Dim mAcctNo = mSMSTrnAcct

                If IsDBNull(Destination) Then Destination = ""

                If Destination <> "" And Destination <> " " Then

                    'SEND SMS TO CUSTOMERS
                    If mSMSCrAmt > 0 Then
                        If Len(Destination) > 0 Then
                            SendSMSCr()
                            NoPhone = False
                        Else
                            NoPhone = True
                        End If
                    End If

                    If mSMSDrAmt > 0 Then
                        If Len(Destination) > 0 Then
                            SendSMSDr()
                            NoPhone = False
                        Else
                            NoPhone = True
                        End If
                    End If

                    If NoPhone = False Then

                        If mSucessful = False Then
                            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Check your Network Connection / Message details, the message failed to send.....');", True)
                            'MsgBox("Check your Network Connection / Message details, the message failed to send !!!")
                            Exit Sub
                        End If

                        'mSucessful = True
                        If mSucessful = True Then

                            'SAVE MESSAGES TO SMS FILE
                            Rs2 = New ADODB.Recordset
                            Rs2.Open("select * from SMSTrnData", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                            With Rs2
                                .AddNew()
                                .Fields("acctno").Value = mAcctNo
                                .Fields("acctname").Value = mSMSAcctName
                                If mSMSDrAmt > 0 Then
                                    .Fields("dramt").Value = mSMSDrAmt
                                    .Fields("cramt").Value = 0
                                End If
                                If mSMSCrAmt > 0 Then
                                    .Fields("dramt").Value = 0
                                    .Fields("cramt").Value = mSMSCrAmt
                                End If
                                .Fields("balamt").Value = mSMSBalAmt
                                .Fields("trndate").Value = mSMSTrnDate
                                .Fields("particular").Value = mSMSParticular
                                .Fields("chgamount").Value = mSMSAmtChg
                                .Fields("telno").Value = Destination
                                .Fields("successful").Value = True
                                .Update()
                            End With

                            'UPDATE SMSTRNFILE SUCESSFUL FILE
                            .Fields("successful").Value = True
                            .Update()

                        Else

                            'UPDATE SMSTRNFILE UNSUCESSFUL FILE
                            .Fields("successful").Value = False
                            .Update()

                        End If


                        'WAREHOUSE SMS CHARGES FOR EACH CUSTOMER
                        If mSucessful = True And mSMSAmtChg > 0 Then

                            Rs3 = New ADODB.Recordset
                            Rs3.Open("select * from SMSChargesTemp", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                            With Rs3
                                .Requery()
                                .Filter = 0
                                .Filter = "acctno ='" & Trim(mAcctNo) & "'"  'and radix='" & Trim(mSMSTrnRad) & "'"
                                If .RecordCount = 0 Then
                                    .AddNew()
                                End If

                                If IsDBNull(.Fields("chgamount").Value) Then .Fields("chgamount").Value = 0

                                .Fields("acctno").Value = mAcctNo 'mSMSTrnAcct
                                .Fields("acctname").Value = mSMSAcctName
                                .Fields("chgamount").Value = Val(.Fields("chgamount").Value) + Val(mSMSAmtChg)
                                .Update()
                            End With

                            mTotSMSChg = Val(mTotSMSChg) + Val(mSMSAmtChg)
                        End If

                    End If 'END IF OF IF NOPHONE = FALSE
                Else
                    Dim Conn1S As New ADODB.Connection
                    Dim Cmd1S As New ADODB.Command
                    Dim Rs1S, RsGLAdmin As New ADODB.Recordset

                    Rs1S = New ADODB.Recordset
                    Rs1S.Open("delete from SMSTrnData WHERE acctno='" & Trim(mAcctNo) & "'", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

                    SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
                    SqlDataSource1.SelectCommand = "Select * from SMSTrnData"
                    GridViewDet.DataSource = SqlDataSource1

                    'AccessDataSource1.DataFile = System.AppDomain.CurrentDomain.BaseDirectory() & "App_Data\ShieldModules\SMSApp.mdb"

                    'AccessDataSource1.SelectCommand = "select * from SMSTrnData"
                    'GridViewDet.DataSource = AccessDataSource1
                    GridViewDet.DataBind()

                    GridViewDet.Enabled = True
                    GridViewDet.Page.Validate()
                    GridViewDet.EditIndex = -1
                End If
                '.Requery()

                .MoveNext()
            Loop
            .Filter = 0
        End With

        ''CHARGE SMS FROM CHARGES WAREHOUSING FILE FOR GL ACCOUNT ONCE ONLY
        'With ShieldDatEnv.rsComGLAccountAdmin
        'If Not .EOF Then .MoveFirst
        'mSMSCrAcct = Trim(mSMSCrAcct)
        'sqlfind = "glacctno = '" & mSMSCrAcct & "'"
        ''sqlfind = Trim(sqlfind)
        '.Find sqlfind, , adSearchForward, 1
        'If Not .EOF Then
        '   !glcredit = CCur(!glcredit) + CCur(mTotSMSChg)
        '   !glbalance = CCur(!glcredit) - CCur(!gldebit)
        '   .Update
        'Else
        '   MsgBox ("Record not Found")
        '   Exit Sub
        'End If
        'End With
        '
        ''CHARGE SMS TO SMS SUSPENSE DR ACCOUNT
        'With ShieldDatEnv.rsComGLAccountAdmin
        'If Not .EOF Then .MoveFirst
        'mSMSDrAcct = Trim(mSMSDrAcct)
        'sqlfind = "glacctno = '" & mSMSDrAcct & "'"
        ''sqlfind = Trim(sqlfind)
        '.Find sqlfind, , adSearchForward, 1
        'If Not .EOF Then
        '   !gldebit = CCur(!gldebit) + CCur(mTotSMSChg)
        '   !glbalance = CCur(!glcredit) - CCur(!gldebit)
        '   .Update
        'Else
        '   MsgBox ("Record not Found")
        '   Exit Sub
        'End If
        'End With


        ''CHARGE SMS FROM CHARGES WAREHOUSING FILE FOR CUSTOMERS
        'With SMSDatEnv.rsComSMSChargesTemp
        '.Filter = 0
        '.Requery
        'If .RecordCount > 0 Then
        '.MoveFirst
        'Else
        'MsgBox ("SMS Charges Warehousing File Empty !!!")
        'Exit Sub
        'End If
        '
        'Do While Not .EOF
        '
        '
        'mSMSTrnRad = !radix
        'mSMSTrnAcct = !acctno
        'mSMSAcctName = !acctname
        'mSMSAmtChg = !chgamount
        '
        '
        'With rsRecordSet
        '
        ''.Filter = 0
        ''.Filter = "ACCRDX ='" & Trim(mSMSTrnRad) & "'and ACCNUM='" & Trim(mSMSTrnAcct) & "'"
        '
        'mBatchNo = "1.0" & mUser
        '
        ''CHECK IF CUSTOMER ALREADY HAVE SMSCHARGES THAT CAN WAREHOUSE OTHER SMS CHARGES
        ''If .RecordCount = 0 Then
        '.AddNew
        ''End If
        '
        '!ACCRDX = mSMSTrnRad
        '!ACCNUM = mSMSTrnAcct
        '!trnamt = 0 - mSMSAmtChg
        '!PARTLARS = "SMS Trans. Chg."
        '!trndate = mSMSTrnDate
        '!trncod = "300"
        '!instno = "entry"
        '!btchno = mBatchNo
        '.Update
        '.Filter = 0
        'End With
        '
        ''Update customerFile with amount
        'With CalbusDatEnv.rsComACCTFILE
        '
        'If .RecordCount > 0 Then
        '   .Filter = 0
        '   .Filter = "ACCRDX ='" & Trim(mSMSTrnRad) & "'and ACCNUM='" & Trim(mSMSTrnAcct) & "'"
        'Else
        '   MsgBox ("Record not Found !!!")
        '   Exit Sub
        'End If
        '
        'If .RecordCount > 0 Then
        '.MoveFirst
        '
        '!cramt = CCur(!cramt) + CCur(mSMSAmtChg)
        '.Update
        'End If
        '.Filter = 0
        'End With
        '
        'mSMSTrnRad = 0
        'mSMSTrnAcct = 0
        'mSMSAcctName = "None"
        'mSMSCrAmt = 0
        'mSMSDrAmt = 0
        'mSMSBalAmt = 0
        'mSMSAmtChg = 0
        'Destination = 0
        'mSMSParticular = "None"
        '
        '.MoveNext
        'Loop
        '
        'MsgBox ("Messages Sent !!!")
        'End With
        '
        'End If

        'MsgBox("Messages Sent !!!")
        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Messages Sent.....');", True)

        'DELETE SENT MESSAGES FROM SMS TRANSACTION FILE
        Page_Load(Me, e)


        ''DELETE CHARGES FROM CHARGES WAREHOUSE FILE
        'Dim rsComDelete1 As New ADODB.Recordset
        'If rsComDelete1.State = adStateOpen Then rsComDelete1.Close
        'If SMSDatEnv.rsComSMSChargesTemp.State = adStateOpen Then SMSDatEnv.rsComSMSChargesTemp.Close
        'rsComDelete1.Open "delete * from SMSChargesTemp", SMSDatEnv.ConSMS, adOpenKeyset, adLockOptimistic

        'DetDatGrid.Refresh()
    End Sub


    Public Sub SendSMSDr()
        Dim oHttp As Object
        Dim strUrl, strUsername, strPassword, strMessage, strMobileNumber As String
        'Set oHttp = CreateObject("Microsoft.XMLHTTP")
        oHttp = CreateObject("MSXML2.XMLHTTP.6.0")

        mSucessful = False

        mSource = "Trijof"

        mSMSTrnAcct = Left(mSMSTrnAcct, 3) & "xxxxx" & Right(mSMSTrnAcct, 4)

        'Message = "Trans Alert:     " & "Your A/C " & mSMSTrnAcct & " has been debited with " & "N" & Format(Round((CCur(mSMSDrAmt)), 2), "#####,###.00") & " being " & mSMSParticular & " A/C Bal: " & "N" & Format(Round((CCur(mSMSBalAmt)), 2), "#####,###.00") & " Date: " & mSMSTrnDate  '& " Avail Bal: " & "N" & Format(Round((CCur(mSMSAvailbal)), 2), "#####,###.00")
        Message = "Your A/C " & mSMSTrnAcct & " has been debited with " & "N" & Format(Math.Round((Val(mSMSDrAmt)), 2), "#####,###.00") & " being " & mSMSParticular & " A/C Bal: " & "N" & Format(Math.Round((Val(mSMSBalAmt)), 2), "#####,###.00") & " Date: " & mSMSTrnDate  '& " Avail Bal: " & "N" & Format(Round((CCur(mSMSAvailbal)), 2), "#####,###.00")

        'FOR KULLSMS TRIJOF
        strUrl = "https://kullsms.com/customer/api/?username=trijofmfi2017@gmail.com&password=trijofalert" & "&message=" & Message & "&sender=TRIJOF" & "&mobiles=" & Destination

        oHttp.Open("POST", strUrl, False)
        'On Error Resume Next

        'MsgBox ("About to Send")
        oHttp.send()
        'MsgBox ("Sent")

        'Dim xml_doc As New DOMDocument
        'Dim nde_Asset As IXMLDOMNode
        'Dim nde_Dividend As IXMLDOMNode

        'mSucessful = xml_doc.loadXML(oHttp.responseText) ' response text is the xml file being returned
        mSucessful = Trim(oHttp.responseText)

        'FOR KULLSMS
        mKeyword = "1701"
        mSucessful = Trim(Str(mSucessful))
        If Trim(mSucessful) = mKeyword Then
            'mFound = UCase(Trim(mSucessful)) Like UCase(mKeyword)
            mFound = True
        Else
            mFound = False
        End If

        If mFound Then
            mSucessful = True
        Else
            mSucessful = False
        End If
        '
        '    If mSucessful < 0 Or mSucessful = "" Then
        '       mSucessful = False
        '    Else
        '       mSucessful = True
        '    End If

        '    If xml_doc.selectSingleNode("//api_result/call_result/result").Text = "True" Then
        '      MsgBox ("Sending Successful. EventID: " + xml_doc.selectSingleNode("//api_result/send_info/eventid").Text)
        '     Else
        '      MsgBox (xml_doc.selectSingleNode("//api_result/call_result/error").Text)
        '    End If

        'xml_doc = Nothing
        oHttp = Nothing
    End Sub

    Public Sub SendSMSCr()
        Dim oHttp As Object
        Dim strUrl, strUsername, strPassword, strMessage, strMobileNumber As String
        '    Set oHttp = CreateObject("Microsoft.XMLHTTP")
        oHttp = CreateObject("MSXML2.XMLHTTP.6.0")

        mSucessful = False


        mSource = "Trijof"

        mSMSTrnAcct = Left(mSMSTrnAcct, 3) & "xxxxx" & Right(mSMSTrnAcct, 4)

        'Message = "Trans Alert:     " & "Your A/C " & mSMSTrnAcct & " has been credited with " & "N" & Format(Round((CCur(mSMSCrAmt)), 2), "#####,###.00") & " being " & mSMSParticular & " A/C Bal: " & "N" & Format(Round((CCur(mSMSBalAmt)), 2), "#####,###.00") & " Date: " & mSMSTrnDate '& " Avail Bal: " & "N" & Format(Round((CCur(mSMSAvailbal)), 2), "#####,###.00")
        Message = "Your A/C " & mSMSTrnAcct & " has been credited with " & "N" & Format(Math.Round((Val(mSMSCrAmt)), 2), "#####,###.00") & " being " & mSMSParticular & " A/C Bal: " & "N" & Format(Math.Round((Val(mSMSBalAmt)), 2), "#####,###.00") & " Date: " & mSMSTrnDate '& " Avail Bal: " & "N" & Format(Round((CCur(mSMSAvailbal)), 2), "#####,###.00")

        'FOR KULLSMS NUTOKEBOLA
        strUrl = "https://kullsms.com/customer/api/?username=trijofmfi2017@gmail.com&password=trijofalert" & "&message=" & Message & "&sender=TRIJOF" & "&mobiles=" & Destination

        oHttp.Open("POST", strUrl, False)
        'On Error Resume Next
        'MsgBox ("About to Send")
        oHttp.send()

        'Dim xml_doc As New DOMDocument
        'Dim nde_Asset As IXMLDOMNode
        'Dim nde_Dividend As IXMLDOMNode

        'mSucessful = xml_doc.loadXML(oHttp.responseText) ' response text is the xml file being returned
        mSucessful = Trim(oHttp.responseText)

        'FOR KULLSMS
        mKeyword = "1701"
        mSucessful = Trim(Str(mSucessful))
        If Trim(mSucessful) = mKeyword Then
            'mFound = UCase(Trim(mSucessful)) Like UCase(mKeyword)
            mFound = True
        Else
            mFound = False
        End If


        If mFound Then
            mSucessful = True
        Else
            mSucessful = False
        End If

        oHttp = Nothing
    End Sub

    Protected Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        Dim Conn1 As New ADODB.Connection
        Dim Cmd1 As New ADODB.Command
        Dim Rs1, RsGLAdmin As New ADODB.Recordset

        'Session("myADODBConnection") = New ADODB.Connection
        'with Conn1
        '    .Provider = "Microsoft.JET.OLEDB.4.0"
        '    .ConnectionString = System.AppDomain.CurrentDomain.BaseDirectory() & "\App_Data\BankerData.mdb" 'Write your access Database name
        '    .Open()
        'End With
        SqlDataSource1.ConnectionString = ("Data Source='" & Session("mydatasource") & "';Initial Catalog='" & Session("mydbname") & "';User Id='" & Session("myusername") & "';Password=gbenga5199;")
        Rs1 = New ADODB.Recordset
        Rs1.Open("delete from SMSTrnData", Session("myADODBConnection"), ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        SqlDataSource1.SelectCommand = "select * from SMSTrnData"
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

        ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Your record has been cleared !!!');", True)

        'TxtPostingAmt.Text = 0
    End Sub

    Protected Sub GridViewDet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridViewDet.SelectedIndexChanged
        Dim row As GridViewRow = GridViewDet.SelectedRow

        If GridViewDet.SelectedIndex < 0 Then
            'If row.Cells(1).Text = "ANATR" Then
            'e.Cancel = True
            'MessageLabel.Text = "You cannot select " + row.Cells(2).Text & "."
            ClientScript.RegisterStartupScript(Page.GetType(), "TestAlert", "alert('Select a record from the list !!!');", True)
            GridAcctDelete = "0"

            Exit Sub
        End If
        GridAcctDelete = Trim(row.Cells(1).Text)
        'GridInstDelete = Trim(row.Cells(6).Text)
        'GridAmtDelete = Trim(row.Cells(9).Text)
    End Sub

End Class
