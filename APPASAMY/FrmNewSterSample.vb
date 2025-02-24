
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO









Public Class FrmNewSterSample



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


    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String


    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String


    Dim IntBoxPAck As Integer
    Dim StrAConst As String
    Dim StrRefName As String


    Dim StrLotNo, StrLotBarNo, StrLotPower, StrOptic, StrLength, StrEanCode, StrUnit, StrMfDMonth, StrMfDYear, StrModel, StrExpmonth, StrExpYear, StrUni, StrMfD, StrExp As String
    Dim StrTwoDBar, StrBtc_No As String


    

    Dim StrSeSql As String
    Dim StrSeRs As SqlDataReader
    'Dim Cmd As New SqlCommand
    Dim SqlIn As String

    Dim StrLotPrefix As String
    Dim StrLotSu As String
    Dim StrOnlyLot As String



    Private Sub FrmNewSterSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try







        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from STERILIZATION_TEST"
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



        StrUniqueNo = "SST/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo



        'GetTable()

        ' Create four typed columns in the DataTable.

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Sterile_No", GetType(String))
        'table.Columns.Add("Lot_Prefix", GetType(String))
        'table.Columns.Add("Lot_No", GetType(String))
        ' ''table.Columns.Add("Power", GetType(String))
        ' ''table.Columns.Add("B", GetType(String))
        ' ''table.Columns.Add("T", GetType(String))
        ' ''table.Columns.Add("Unit", GetType(String))
        ' ''table.Columns.Add("Mfd_Date", GetType(String))
        ' ''table.Columns.Add("Exp_Date", GetType(String))
        ' ''table.Columns.Add("Sterilization No", GetType(Integer))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With


        'btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw"
        'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click

        Try

            Dim strUpdateQry As String = ""
            Dim strInsertQry As String = ""

            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from STERILIZATION_TEST"
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

            Str_Detail = 0
            StrSqlSeDt = "Select Max(Detail_ID) from STERILIZATION_TEST"
            cmd = New SqlCommand(StrSqlSeDt, con)
            StrRsSeDt = cmd.ExecuteReader
            If StrRsSeDt.Read Then
                Str_Detail = IIf(IsDBNull(StrRsSeDt(0)), 0, StrRsSeDt(0))
            Else
                Str_Detail = 0
            End If
            StrRsSeDt.Close()
            cmd.Dispose()

            For i = 0 To GRID2.Rows.Count - 2
                Dim Sql As String


                If Str_Detail = 0 Then
                    Str_Detail = 1
                Else
                    Str_Detail = Str_Detail + 1
                End If

                strUpdateQry = strUpdateQry + "'" + GRID2.Rows(i).Cells("Lot_Srl_No").Value.ToString() + "',"
                strInsertQry = strInsertQry + "('" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(0, i).Value & "','" & StrUniqueNo & "', " & _
                      "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE()),"
            Next i
            Sql = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "INSERT Into STERILIZATION_TEST (Header_ID,	Detail_ID,	Lot_SrNo,St_Test_No,	Created_By,	Created_Date,	Modified_By,	Modified_Date )VALUES " & Sql
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
            Sql = "Update POUCH_LABEL set Sample_Taken='1',type_Sample='SST' where Lot_SrNo IN (" & Sql & ")"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            MsgBox("Saved ")

            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from STERILIZATION_TEST"
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



            StrUniqueNo = "SST/" & Format(Now, "ddMMyy") & "/" & Str_Header
            lblSterNo.Text = StrUniqueNo

            GRID2.ClearSelection()
            table.Clear()
            table.Dispose()
            table.Columns.Clear()
            lblcount.Text = table.Rows.Count.ToString()



            table.Columns.Add("Lot_Srl_No", GetType(String))
            table.Columns.Add("Sterile_No", GetType(String))
            GRID2.DataSource = table



            With GRID2.ColumnHeadersDefaultCellStyle
                .Alignment = DataGridViewContentAlignment.TopRight
                .BackColor = Color.DarkRed
                .ForeColor = Color.Gold
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                 .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With

        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try


        

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
    Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
      


        If e.KeyCode = Keys.Enter Then
            Dim StrGrLot As String


            If txtlotbarno.Text <> "" Then

                Try

                    StrLorBarNo = UCase(Trim(txtlotbarno.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "select Lot_Prefix,Lot_No,Lot_SrNo,btc_no from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0"
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select Lot_Prefix,Lot_No,Lot_SrNo,btc_no from POUCH_LABEL where Udi_code='" & txtlotbarno.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0"

                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If



                    cmd = New SqlCommand(Sql, con)
                    Dr = cmd.ExecuteReader
                    If Dr.Read Then
                        'Dim str As String = Dr("btc_no")
                        For i = 0 To GRID2.Rows.Count - 2
                            StrGrLot = ""
                            StrGrLot = GRID2.Item(0, i).Value
                            If StrGrLot = Dr("Lot_SrNo") Then
                                MsgBox("Already Scan")
                                txtlotbarno.Text = ""
                                txtlotbarno.Focus()
                                i = GRID2.Rows.Count - 2
                                Dr.Close()
                                cmd.Dispose()
                                Exit Sub
                            End If
                        Next

                        DtRow = table.NewRow
                        table.Rows.Add(Dr("Lot_SrNo"), Dr("btc_no"))
                        Dr.Close()
                        cmd.Dispose()
                        lblcount.Text = table.Rows.Count.ToString()
                        txtlotbarno.Text = ""
                        txtlotbarno.Focus()
                    Else
                        MsgBox("Scan Correct Lot Sr No")
                        txtlotbarno.Text = ""
                        txtlotbarno.Focus()
                        Dr.Close()
                        cmd.Dispose()
                    End If
                    Dr.Close()
                    cmd.Dispose()

                Catch ex As Exception

                    MsgBox("An unexpected error occurred.")
                    Exit Sub

                End Try
                

            End If

        End If
    End Sub

    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        GRID2.ClearSelection()
        table.Clear()
        table.Dispose()
        table.Columns.Clear()
        lblcount.Text = table.Rows.Count.ToString()

        'GetTable()

        ' Create four typed columns in the DataTable.

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Sterile_No", GetType(String))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub

    Private Sub rdUDICode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUDICode.CheckedChanged

    End Sub
End Class