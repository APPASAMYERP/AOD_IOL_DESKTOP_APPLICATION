
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmNewDcSoft
    Private _msg As String
    Private _type As MessageType
    Private msg As String

    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String

    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader

    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader

    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrUniqueNo As String
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim StrSql As String
    Dim StrRs As SqlDataReader

    Dim strrs1 As SqlDataReader
    Dim strdcid As String
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim IntLotAvlQty As Integer
    Dim StrModel, StrBrand, StrType, StrPower, StrLotNo, StrScanTwoD, StrScanLotNo, StrOptic, StrLength, StrSmall_box, StrBig_box As String
    Dim IntBPLQty As Integer
    Dim IntBPLScanQty As Integer
    Dim IntBPLBalanceQty As Integer
    Dim IntBPLQty1 As Integer
    Dim IntBPLScanQty1 As Integer
    Dim IntBPLBalanceQty1 As Integer
    Dim intbgprint As Integer
    Dim intsmallbox As Integer
    Dim intcount As Integer
    Dim strcmpadd As String
    Dim smp As Integer
    Dim bgp As Integer

    Dim dctwod As String

    Dim model As New ArrayList
    Dim brand As New ArrayList
    Dim power As New ArrayList
    Dim type As New ArrayList
    Dim lotsrno As New ArrayList
    Dim smbox As New ArrayList
    Dim bgbox As New ArrayList
    Dim intcount111 As Integer


    Dim StrCompany_Name, StrAdd_1, StrAdd_2, StrLocation, StrState, StrCountry, StrPincode, StrContact_Person, StrMobile, StrTel_No, StrE_Mail As String
    Dim strmode, Strcstname, Strremrk, Strindentno, StrDCLno, Stradd1, Stradd2, Strloc, Strstate1, Strcountry1, Strpin, StrYouodr, Stradd As String

    Public Enum MessageType
        Incoming
        Outgoing
        Normal
        Warning
        [Error]
    End Enum
 

    Private Sub FrmNewDcSoft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If


        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        StrSql = "SELECT DISTINCT Company_Name from CUSTOMER_CATALOG order by Company_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbCusName.Items.Clear()
        While StrRs.Read
            CmbCusName.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()


        StrSql = "SELECT  distinct DCL_NO from DC_PACKING_LIST  where Dc_Print=0 and dc_Id=0 order by DCL_NO"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbDclNo.Items.Clear()
        While StrRs.Read
            CmbDclNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        ' Create four typed columns in the DataTable.

        table.Columns.Add("Model", GetType(String))
        table.Columns.Add("Brand", GetType(String))
        table.Columns.Add("Type", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("LotSrlNo", GetType(String))
        table.Columns.Add("Small_Box", GetType(String))
        table.Columns.Add("Big_Box", GetType(String))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        cbxdcno.Visible = False
        lblSterNo.Visible = False
        lblTotBplQty.Text = 0
    End Sub
    Public Sub Customer()
        StrRs.Close()
        cmd.Dispose()
        StrSql = "SELECT  * from CUSTOMER_CATALOG  where Company_Name='" & CmbCusName.Text & "'"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader

        If StrRs.Read Then

            'txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1)) & "," & IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2)))
            txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3)) & "," & IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4)))
            txtaddress.AppendText(Environment.NewLine)
            'txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4)))
            'txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)))
            txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)))
            txtaddress.AppendText(Environment.NewLine)
            txtaddress.AppendText(IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9)))

            StrCompany_Name = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            StrAdd_1 = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            StrAdd_2 = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
            StrLocation = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
            StrState = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
            StrCountry = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
            StrPincode = IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6))
            StrContact_Person = IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7))
            StrMobile = IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8))
            StrTel_No = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
            StrE_Mail = IIf(IsDBNull(StrRs.GetValue(10)), "", StrRs.GetValue(10))

            strcmpadd = StrAdd_1 & StrAdd_2 & StrLocation & StrState & StrCountry & StrPincode

        End If
        StrRs.Close()
        cmd.Dispose()
    End Sub
    Private Sub CmbCusName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCusName.SelectedIndexChanged
        Customer()
    End Sub

    Private Sub CmbDclNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDclNo.SelectedIndexChanged
        StrRs.Close()
        cmd.Dispose()
        StrSql = "select * from POUCH_LABEL where  DCL_NO='" & CmbDclNo.Text & "'"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        While StrRs.Read
            StrModel = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            StrBrand = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            StrType = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
            StrPower = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
            StrLotNo = IIf(IsDBNull(StrRs.GetValue(15)), "", StrRs.GetValue(15))

            DtRow = table.NewRow
            table.Rows.Add(StrModel, StrBrand, StrType, StrPower, StrLotNo)

        End While
        StrRs.Close()
        cmd.Dispose()

        IntBPLQty = 0
        IntBPLScanQty = 0
        IntBPLBalanceQty = 0

        StrSql = "select count(*) from POUCH_LABEL where  DCL_NO='" & CmbDclNo.Text & "'"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            IntBPLQty = IIf(IsDBNull(StrRs.GetValue(0)), 0, StrRs.GetValue(0))
            IntBPLScanQty = 0
            IntBPLBalanceQty = IntBPLQty
        End If
        StrRs.Close()
        cmd.Dispose()

        If rdbtnew.Checked = True Then
            LblScanBalanceQty.Text = IntBPLBalanceQty
            LblScancedQty.Text = IntBPLScanQty
            lblTotBplQty.Text = IntBPLQty

        Else
           
            LblScanBalanceQty.Text = IntBPLBalanceQty + IntBPLScanQty1
            LblScancedQty.Text = IntBPLScanQty + IntBPLBalanceQty1
            lblTotBplQty.Text = IntBPLQty + IntBPLQty1

        End If

       
    End Sub

    Private Sub txttwodBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttwodBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txttwodBarcode.Text <> "" Then

                StrScanTwoD = txttwodBarcode.Text

                Dim s As String = StrScanTwoD
                Dim Ck As Integer

                ' Split the string on the backslash character
                Dim parts As String() = s.Split(New Char() {","c})

                For e1 As Integer = 1 To 2
                    StrScanLotNo = parts(0)
                Next
                Ck = 0
                For i As Integer = 0 To GRID2.Rows.Count - 1
                    If GRID2.Rows(i).Cells(4).Value = StrScanLotNo Then
                        If GRID2.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                            MsgBox("Already Scaned", MsgBoxStyle.Critical)
                            txttwodBarcode.Text = ""
                            txttwodBarcode.Focus()
                            Exit Sub
                        End If

                        GRID2.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                        LblScancedQty.Text = Val(LblScancedQty.Text) + 1
                        LblScanBalanceQty.Text = Val(lblTotBplQty.Text) - Val(LblScancedQty.Text)
                        'LblScancedQty.Text = IntBPLScanQty
                        GRID2.Rows(i).Cells(5).Value = Val(lblsmbox.Text)
                        GRID2.Rows(i).Cells(6).Value = Val(lblbgbox.Text)

                        For x As Integer = intcount + 1 To Val(LblScancedQty.Text)
                            If (x Mod Val(txtnooflens.Text) = 0) Then
                                If Val(LblScancedQty.Text) = 0 Then
                                Else
                                    lblsmbox.Text = Val(lblsmbox.Text) + 1
                                    MsgBox("SMALL BOX PRINT")
                                    smp = smp + 1
                                    intcount = intcount + Val(txtnooflens.Text)

                                    If ((Val(lblsmbox.Text) - 1) Mod (Val(txtnoofsmbxinbbx.Text)) = 0) Then
                                        lblbgbox.Text = Val(lblbgbox.Text) + 1
                                        MsgBox("Big BOX PRINT")
                                        bgp = bgp + 1
                                        
                                    End If

                                End If
                                
                            End If
                        Next
                       
                        Ck = 1

                        txttwodBarcode.Text = ""
                        txttwodBarcode.Focus()
                        Exit Sub
                    End If
                Next
                If Ck = 0 Then
                    MsgBox("Scan Correct Id", MsgBoxStyle.Critical)
                    txttwodBarcode.Text = ""
                    txttwodBarcode.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub



    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        If LblScanBalanceQty.Text = 0 Then

            If smp = Val(txtnoofsmbox.Text) Then
            Else
                'MsgBox("SMALL BOX PRINT")
            End If
            If bgp = Val(txtnoofbgbox.Text) Then
            Else
                'MsgBox("Big BOX PRINT")
            End If

            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from DC_SOFT"
            cmd = New SqlCommand(StrSqlSeHd, con)
            StrRsSeHd = cmd.ExecuteReader
            If StrRsSeHd.Read Then
                Str_Header = IIf(IsDBNull(StrRsSeHd(0)), 0, StrRsSeHd(0))
            Else
                Str_Header = 0
            End If

            If Str_Header = 0 Then
                Str_Header = 1
            Else
                Str_Header = Str_Header + 1
            End If
            StrRsSeHd.Close()
            cmd.Dispose()


            Dim Sql As String
            Str_Detail = 0
            StrSqlSeDt = "Select Max(Detail_ID) from DC_SOFT"
            cmd = New SqlCommand(StrSqlSeDt, con)
            StrRsSeDt = cmd.ExecuteReader
            If StrRsSeDt.Read Then
                Str_Detail = IIf(IsDBNull(StrRsSeDt(0)), 0, StrRsSeDt(0))
            Else
                Str_Detail = 0
            End If

            If Str_Detail = 0 Then
                Str_Detail = 1
            Else
                Str_Detail = Str_Detail + 1
            End If

            StrRsSeDt.Close()
            cmd.Dispose()

            StrUniqueNo = "DC/S/" & Str_Header

            StrSql = "insert into DC_SOFT(Header_ID,Detail_ID, " & _
                            "Dc_No,Mode,Remarks	,IndentNo	,YourOrder	,Company_Name,Add_1,Add_2,Location,State,Country,Pincode,Contact_Person,Mobile,Tel_No,E_Mail,Address, " & _
                            "Created_By,Created_Date,Modified_By,Modified_Date,DC_comp) values ( " & _
                            "'" & Str_Header & "','" & Str_Detail & "','" & StrUniqueNo & "'," & _
                            "'" & CmbMode.Text & "','" & txtremarks.Text & "','" & txtindent.Text & "','" & cmbYourOrder.Text & "', '" & StrCompany_Name & " ',	'" & StrAdd_1 & "',	'" & StrAdd_2 & "',	'" & StrLocation & "',	'" & StrState & "',	'" & StrCountry & "',	'" & StrPincode & "',	'" & StrContact_Person & "',	'" & StrMobile & "',	'" & StrTel_No & "',	'" & StrE_Mail & "','" & txtaddress.Text & "'," & _
                            "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'1')"

            cmd = New SqlCommand(StrSql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Dim intpgno As Integer = 1
            Dim intt11 As Integer
            pgbcmp.Maximum = GRID2.Rows.Count - 1
            For s As Integer = 0 To GRID2.Rows.Count - 1
                StrSql = "update POUCH_LABEL set Dc_Packing=1,Dc_No='" & StrUniqueNo & "'  where  Lot_Srno='" & GRID2.Rows(s).Cells(4).Value & "'"
                cmd = New SqlCommand(StrSql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                pgbcmp.Increment(1)

                StrSql = "select Lot_srno,Model_Name,Power,Exp_Month,Exp_year from Pouch_Label where Lot_Srno='" & GRID2.Rows(s).Cells(4).Value & "'"
                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    dctwod = dctwod & "" & StrRs.GetValue(0) & "," & StrRs.GetValue(1) & "," & StrRs.GetValue(2) & "," & StrRs.GetValue(3) & "-" & StrRs.GetValue(4) & ";"
                    intcount111 += 1
                End If
                cmd.Dispose()
                StrRs.Close()

                If intcount111 = 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", StrUniqueNo)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    dctwod = ""
                ElseIf intcount111 = 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    dctwod = ""
                    intcount111 = 0
                    intpgno += 1
                End If

            Next

            If intcount111 <> 0 Then
                If intcount111 < 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", StrUniqueNo)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("DC2D22", " ")
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                ElseIf intcount111 > 80 And intcount111 < 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                End If


            End If



            'StrSql = "update POUCH_LABEL SET " & _
            '         "POUCH_LABEL.Numofsbox=tmp_newDCSOFT.Numofsbox, " & _
            '         "POUCH_LABEL.numoflens=tmp_newDCSOFT.numoflens, " & _
            '         "POUCH_LABEL.numofbigbox=tmp_newDCSOFT.numofbigbox, " & _
            '         "POUCH_LABEL.numofsbinbb=tmp_newDCSOFT.numofsbinbb, " & _
            '         "POUCH_LABEL.scan=tmp_newDCSOFT.scan," & _
            '         "POUCH_LABEL.Small_box=tmp_newDCSOFT.Small_box, " & _
            '         "POUCH_LABEL.Big_box = tmp_newDCSOFT.Big_box " & _
            '         "FROM(POUCH_LABEL, tmp_newDCSOFT) " & _
            '         "WHERE(POUCH_LABEL.Lot_Srno = tmp_newDCSOFT.Lot_Srno)" & _
            '         "AND tmp_newDCSOFT.DC_Id='" & cbxdcno.Text & "'"
            'cmd = New SqlCommand(StrSql, con)
            'cmd.ExecuteNonQuery()
            'cmd.Dispose()



            MsgBox(" Data Save Sucessfully")





            If rdbtnew.Checked Then
                StrSql = "delete from tmp_newDCSOFT where DC_Id='" & lblSterNo.Text & "' "
                cmd = New SqlCommand(StrSql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                StrSql = "delete from tmp_newDCSOFT where DC_Id='" & cbxdcno.Text & "' "
                cmd = New SqlCommand(StrSql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
        Else
            MsgBox("Scan All Qty", MsgBoxStyle.Critical)
            Exit Sub
        End If

        clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub


    Private Sub rdbtnew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnew.CheckedChanged


        lblSterNo.Visible = True
        cbxdcno.Visible = False

        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from tmp_newDCSOFT"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
        If StrRsSeHd.Read Then
            Str_Header = IIf(IsDBNull(StrRsSeHd(0)), 0, StrRsSeHd(0))
        Else
            Str_Header = 0
        End If

        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If
        StrRsSeHd.Close()
        cmd.Dispose()

        StrUniqueNo = "DC/T" & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo
        lblbgbox.Text = 1
        lblsmbox.Text = 1

    End Sub
    Public Function clear()
        lblbgbox.Text = ""
        LblScanBalanceQty.Text = ""
        LblScancedQty.Text = ""
        rdbtnew.Checked = False
        rdbtold.Checked = False
        txtaddress.Text = ""
        txtindent.Text = ""
        txtnoofsmbox.Text = ""
        txtremarks.Text = ""
        CmbMode.Text = ""
        CmbCusName.Text = ""
        cmbYourOrder.Text = ""
        cbxdcno.Text = ""
        lblTotBplQty.Text = ""
        table.Clear()
        lblsmbox.Text = ""
        txtnoofbgbox.Text = ""
        txtnooflens.Text = ""
        txtnoofsmbxinbbx.Text = ""

    End Function

    Private Sub rdbtold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtold.CheckedChanged

        lblSterNo.Visible = False
        cbxdcno.Visible = True


        StrSql = "SELECT  distinct DC_id from tmp_newDCSOFT "
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        cbxdcno.Items.Clear()
        While StrRs.Read
            cbxdcno.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()


    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
       

        Dim Sql As String
        Str_Detail = 0
      

        StrSqlSeDt = "Select Max(Detail_ID) from tmp_newDCSOFT"
        cmd = New SqlCommand(StrSqlSeDt, con)
        StrRsSeDt = cmd.ExecuteReader
        If StrRsSeDt.Read Then
            Str_Detail = IIf(IsDBNull(StrRsSeDt(0)), 0, StrRsSeDt(0))
        Else
            Str_Detail = 0
        End If

        If Str_Detail = 0 Then
            Str_Detail = 1
        Else
            Str_Detail = Str_Detail + 1
        End If

        StrRsSeDt.Close()
        cmd.Dispose()

        Dim i As Integer
        Dim j As Integer
        For i = 0 To GRID2.Rows.Count - 1
            model.Add(GRID2.Rows(i).Cells(0).Value)
            brand.Add(GRID2.Rows(i).Cells(1).Value)
            type.Add(GRID2.Rows(i).Cells(2).Value)
            power.Add(GRID2.Rows(i).Cells(3).Value)
            lotsrno.Add(GRID2.Rows(i).Cells(4).Value)
            smbox.Add(GRID2.Rows(i).Cells(5).Value)
            bgbox.Add(GRID2.Rows(i).Cells(6).Value)
        Next

        If rdbtnew.Checked = True Then
            strdcid = lblSterNo.Text
        Else
            strdcid = cbxdcno.Text
        End If
        StrRs.Close()
        cmd.Dispose()
        'StrSql = "delete from tmp_newDCSOFT where DC_id='" & strdcid & "'"
        'cmd = New SqlCommand(StrSql, con)
        'StrRs = cmd.ExecuteReader
        'StrRs.Close()
        'cmd.Dispose()

      
        For i = 0 To GRID2.Rows.Count - 2
            StrSql = "select * from tmp_newDCSOFT where Lot_srno='" & GRID2.Rows(i).Cells(4).Value & "'"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            If StrRs.Read Then
                StrRs.Close()
                cmd.Dispose()
                If GRID2.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                    StrSql = " update tmp_newDCSOFT set Add_1='" & strcmpadd & "',scan='1',Small_box='" & smbox.Item(i) & "',Big_box='" & bgbox.Item(i) & "' where Lot_srno='" & GRID2.Rows(i).Cells(4).Value & "'"
                    cmd = New SqlCommand(StrSql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    StrRs.Close()
                End If
                

            Else
                If GRID2.Rows(i).DefaultCellStyle.BackColor = Color.Yellow Then
                    StrRs.Close()
                    cmd.Dispose()
                    StrSql = "INSERT INTO tmp_newDCSOFT(Header_ID,Detail_ID, DC_ID,Add_1, Brand_Name, Model_Name, Power, Type_GS_Code, Lot_Srno, Qty, Company_Name, Created_By, " & _
                             "Created_Date, Numofsbox, numoflens, numofbigbox, numofsbinbb, scan,indentno,mode,remark,yourorder,Small_box,Big_box) VALUES ('" & Str_Header & "','" & Str_Detail & "','" & strdcid & "','" & txtaddress.Text & "','" & brand.Item(i) & "','" & model.Item(i) & "', " & _
                             " '" & power.Item(i) & "','" & type.Item(i) & "','" & lotsrno.Item(i) & "','1','" & CmbCusName.Text & "','" & StrLoginUser & "',GETDATE(), " & _
                             " '" & txtnoofsmbox.Text & "','" & txtnooflens.Text & "','" & txtnoofbgbox.Text & "','" & txtnoofsmbxinbbx.Text & "','1','" & txtindent.Text & "','" & CmbMode.Text & "','" & cmbYourOrder.Text & "','" & txtremarks.Text & "','" & smbox.Item(i) & "','" & bgbox.Item(i) & "')"

                    cmd = New SqlCommand(StrSql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    StrRs.Close()

                Else
                    StrRs.Close()
                    cmd.Dispose()
                    StrSql = "INSERT INTO tmp_newDCSOFT(Header_ID,Detail_ID, DC_ID,Add_1, Brand_Name, Model_Name, Power, Type_GS_Code, Lot_Srno, Qty, Company_Name, Created_By, " & _
                             "Created_Date, Numofsbox, numoflens, numofbigbox, numofsbinbb, scan,indentno,mode,remark,yourorder,Small_box,Big_box) VALUES ('" & Str_Header & "','" & Str_Detail & "','" & strdcid & "','" & txtaddress.Text & "','" & brand.Item(i) & "','" & model.Item(i) & "', " & _
                             " '" & power.Item(i) & "','" & type.Item(i) & "','" & lotsrno.Item(i) & "','1','" & CmbCusName.Text & "','" & StrLoginUser & "',GETDATE(), " & _
                             " '" & txtnoofsmbox.Text & "','" & txtnooflens.Text & "','" & txtnoofbgbox.Text & "','" & txtnoofsmbxinbbx.Text & "','0','" & txtindent.Text & "','" & CmbMode.Text & "','" & cmbYourOrder.Text & "','" & txtremarks.Text & "','" & smbox.Item(i) & "','" & bgbox.Item(i) & "')"

                    cmd = New SqlCommand(StrSql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    StrRs.Close()
                    cmd.Dispose()
                End If
                Str_Detail = Str_Detail + 1
            End If
        Next

        StrSql = "update DC_PACKING_LIST set Dc_Print=1,Dc_Id='" & strdcid & "'  where  DCL_NO='" & CmbDclNo.Text & "'"
        cmd = New SqlCommand(StrSql, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        MsgBox(" Data Save Sucessfully")
        clear()
    End Sub

    Private Sub cbxdcno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxdcno.SelectedIndexChanged
        If cbxdcno.Text <> "" Then
           
            StrSql = "Select * from tmp_newDCSOFT where DC_id='" & cbxdcno.Text & "' "
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            While StrRs.Read

                StrModel = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                StrBrand = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                StrType = IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6))
                StrPower = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
                StrLotNo = IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7))
                StrSmall_box = IIf(IsDBNull(StrRs.GetValue(22)), "", StrRs.GetValue(22))
                StrBig_box = IIf(IsDBNull(StrRs.GetValue(23)), "", StrRs.GetValue(23))
                DtRow = table.NewRow
                table.Rows.Add(StrModel, StrBrand, StrType, StrPower, StrLotNo, StrSmall_box, StrBig_box)
            End While
            StrRs.Close()
            cmd.Dispose()


            For k As Integer = 0 To GRID2.Rows.Count - 1

                StrSql = " select * from tmp_newDCSOFT where Lot_Srno='" & GRID2.Rows(k).Cells(4).Value & "'"
                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    If StrRs.GetValue(17) = 1 Then
                        GRID2.Rows(k).DefaultCellStyle.BackColor = Color.Yellow
                        intcount = intcount + 1
                    End If
                End If
                StrRs.Close()
                cmd.Dispose()
            Next


            StrSql = " SELECT distinct Company_Name, Add_1, Numofsbox, numoflens, numofbigbox, numofsbinbb, indentno, mode, remark, yourorder " & _
                     " from tmp_newDCSOFT where DC_Id= '" & cbxdcno.Text & "' "
            cmd = New SqlCommand(StrSql, con)
            strrs1 = cmd.ExecuteReader
            If strrs1.Read Then
                ' CmbCusName.Text = strrs1.GetValue(0)
                ' txtaddress.Text = StrRs.GetValue(1)
                txtindent.Text = strrs1.GetValue(6)
                CmbMode.Text = strrs1.GetValue(7)
                cmbYourOrder.Text = strrs1.GetValue(9)
                txtremarks.Text = strrs1.GetValue(8)
                txtnoofsmbox.Text = strrs1.GetValue(2)
                txtnooflens.Text = strrs1.GetValue(3)
                txtnoofbgbox.Text = strrs1.GetValue(4)
                txtnoofsmbxinbbx.Text = strrs1.GetValue(5)
            End If
            strrs1.Close()
            cmd.Dispose()
        End If

       
        StrRs.Close()
        cmd.Dispose()

        StrSql = "select count(*) from tmp_newDCSOFT where DC_Id='" & cbxdcno.Text & "' "
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            IntBPLQty1 = StrRs.GetValue(0)
        End If
        StrRs.Close()
        cmd.Dispose()
        StrSql = "select count(*) from tmp_newDCSOFT where DC_Id='" & cbxdcno.Text & "' and scan='0'"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            IntBPLScanQty1 = StrRs.GetValue(0)
        End If
        StrRs.Close()
        cmd.Dispose()
        StrSql = "select count(*) from tmp_newDCSOFT where DC_Id='" & cbxdcno.Text & "' and scan='1'"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            IntBPLBalanceQty1 = StrRs.GetValue(0)
        End If
        StrRs.Close()
        cmd.Dispose()
        LblScanBalanceQty.Text = IntBPLScanQty1
        LblScancedQty.Text = IntBPLBalanceQty1
        lblTotBplQty.Text = IntBPLQty1
        intsmallbox = 0
        intbgprint = 0

        For x As Integer = 1 To Val(LblScancedQty.Text)
            If (x Mod Val(txtnooflens.Text) = 0) Then
                intsmallbox = intsmallbox + 1
            End If
        Next
        lblsmbox.Text = intsmallbox + 1

        For b As Integer = 1 To Val(lblsmbox.Text)
            If (b Mod (Val(txtnoofsmbxinbbx.Text)) = 0) Then
                intbgprint = intbgprint + 1
            End If
        Next
        lblbgbox.Text = intbgprint + 1


        smp = Val(lblsmbox.Text)
        bgp = Val(lblbgbox.Text)
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub

  
    Private Sub txttwodBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttwodBarcode.TextChanged

    End Sub
    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function
End Class