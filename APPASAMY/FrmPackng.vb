Imports System.Data
Imports System.IO
Imports System.Data.SqlClient


Public Class FrmPackng
    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader
    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader
    Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
        Dim StrSeSql As String
        Dim StrSeRs As SqlDataReader
        Dim Cmd As New SqlCommand
        Dim SqlIn As String


        Dim StrLotNo, StrLotBarNo, StrLotPower, StrWith, StrHeig, StrUnit, StrMfD, StrExp, StrUni As String
        Dim StrTwoDBar As String
        If txtlotbarno.Text <> "" Then
            If e.KeyCode = Keys.Enter Then

                If cmbbrand.Text = "" Then
                    err.SetError(cmbbrand, "Select Brand Name ")
                    txtlotbarno.Text = ""
                    cmbbrand.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbbrand, "")
                End If

                If txtref.Text = "" Then
                    err.SetError(cmbbrand, "Enter Ref Value ")
                    txtlotbarno.Text = ""
                    txtref.Focus()
                    Exit Sub
                Else
                    err.SetError(txtref, "")
                End If


                StrSeSql = "Select Lm.Lot_No,Um.Lot_Barcode,Lm.Lot_Power,Lm.Lot_Width,	Lm.Lot_height,	" & _
                           "Lm.Lot_Unit,	(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mfd_Date,	" & _
                           "(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date , Um.Unique_No " & _
                           "from LOT_MASTER Lm,UNIQUE_MASTER Um where Lm.Lot_No=Um.Lot_No and  Um.Lot_Barcode='" & txtlotbarno.Text & "'"
                Cmd = New SqlCommand(StrSeSql, con)
                StrSeRs = Cmd.ExecuteReader
                If StrSeRs.Read Then
                    StrLotNo = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                    StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                    StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                    StrWith = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                    StrHeig = IIf(IsDBNull(StrSeRs.GetValue(4)), "", StrSeRs.GetValue(4))
                    StrUnit = IIf(IsDBNull(StrSeRs.GetValue(5)), "", StrSeRs.GetValue(5))
                    StrMfD = IIf(IsDBNull(StrSeRs.GetValue(6)), "", StrSeRs.GetValue(6))
                    StrExp = IIf(IsDBNull(StrSeRs.GetValue(7)), "", StrSeRs.GetValue(7))
                    StrUni = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))

                Else
                    MsgBox(" Scan Correct Lot No")
                    txtlotbarno.Text = ""
                    txtlotbarno.Focus()
                    StrSeRs.Close()
                    Cmd.Dispose()
                    Exit Sub
                End If
                StrSeRs.Close()
                Cmd.Dispose()
                StrTwoDBar = StrLotBarNo & "," & StrMfD & "," & StrExp & "," & StrLotPower & "," & StrUni

                Dim x As New StreamWriter("c:\raj.txt")
                'x.WriteLine("^XA")
                'x.WriteLine("^SZ2^JMA")
                'x.WriteLine("^MCY^PMN")
                'x.WriteLine("^PW670")
                'x.WriteLine("~JSN")
                'x.WriteLine("^MD30")
                'x.WriteLine("^JZY")
                'x.WriteLine("^LH0,0^LRN")
                'x.WriteLine("^XZ")
                ''x.WriteLine("~DGR:SSGFX000.GRF,41238,58,:Z64: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:6983")
                ''x.WriteLine("~DGR:SSGFX000.GRF,41238,58,:Z64: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:6983")
                'x.WriteLine("~DGR:SSGFX000.GRF,41238,58,:Z64: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:6983")
                'x.WriteLine("^XA")
                'x.WriteLine("^FO28,233")
                ''x.WriteLine("^BY2^BCN,78,N,N^FD>:EA1>511109650>6 174^FS")
                'x.WriteLine("^BY2^BCN,78,N,N^FD>:" & StrLotBarNo & "^FS")
                'x.WriteLine("^FT95,333")
                'x.WriteLine("^CI0")
                ''x.WriteLine("^A0N,23,32^FDEA111109650 174^FS")
                'x.WriteLine("^A0N,23,32^FD" & StrLotBarNo & "^FS")
                'x.WriteLine("^FT246,138")
                'x.WriteLine("^A0N,20,41^FDB^FS")
                'x.WriteLine("^FT294,131")
                ''x.WriteLine("^A0N,23,30^FD6.00 mm^FS")
                'x.WriteLine("^A0N,23,30^FD" & StrWith & "^FS")
                'x.WriteLine("^FT502,131")
                ''x.WriteLine("^A0N,23,26^FD12.50 mm^FS")
                'x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                'x.WriteLine("^FT254,75")
                ''x.WriteLine("^A0N,23,26^FD04-2016^FS")
                'x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                'x.WriteLine("^FT70,75")
                ''x.WriteLine("^A0N,23,26^FD03-2011^FS")
                'x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                'x.WriteLine("^FT390,75")
                'x.WriteLine("^A0N,23,32^FDPower:^FS")
                'x.WriteLine("^FT509,75")
                ''x.WriteLine("^A0N,23,26^FD20.00 D^FS")
                'x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                'x.WriteLine("^FT94,197")
                ''x.WriteLine("^A0N,25,33^FDEA111109650 174^FS")
                'x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                'x.WriteLine("^FO445,166")
                ''x.WriteLine("^BQN,2,6^FDLA,EA111109650 174,03-2011,04-2016,20.00 D,02122011/03^FS")
                'x.WriteLine("^BQN,2,6^FDLA," & StrTwoDBar & "^FS")
                'x.WriteLine("^FT78,136")
                ''x.WriteLine("^A0N,28,37^FDSFAC6^FS")
                'x.WriteLine("^A0N,28,37^FD" & txtref.Text & "^FS")
                'x.WriteLine("^FO6,367")
                'x.WriteLine("^GB639,0,2^FS")
                'x.WriteLine("^FO6,566")
                'x.WriteLine("^GB639,0,2^FS")
                'x.WriteLine("^FT246,482")
                'x.WriteLine("^A0N,20,41^FDB^FS")
                'x.WriteLine("^FT294,475")
                'x.WriteLine("^A0N,23,30^FD" & StrWith & "^FS")
                'x.WriteLine("^FT502,475")
                'x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                'x.WriteLine("^FT254,419")
                'x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                'x.WriteLine("^FT70,419")
                'x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                'x.WriteLine("^FT390,419")
                'x.WriteLine("^A0N,23,32^FDPower:^FS")
                'x.WriteLine("^FT509,419")
                'x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                'x.WriteLine("^FT94,541")
                'x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                'x.WriteLine("^FT78,480")
                'x.WriteLine("^A0N,28,37^FDSFAC6^FS")
                'x.WriteLine("^FT245,681")
                'x.WriteLine("^A0N,20,41^FDB^FS")
                'x.WriteLine("^FT293,675")
                'x.WriteLine("^A0N,23,30^FD" & StrWith & "^FS")
                'x.WriteLine("^FT501,675")
                'x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                'x.WriteLine("^FT254,618")
                'x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                'x.WriteLine("^FT70,618")
                'x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                'x.WriteLine("^FT390,618")
                'x.WriteLine("^A0N,23,32^FDPower:^FS")
                'x.WriteLine("^FT509,618")
                'x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                'x.WriteLine("^FT94,740")
                'x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                'x.WriteLine("^FT78,679")
                'x.WriteLine("^A0N,28,37^FDSFAC6^FS")
                'x.WriteLine("^FO14,40")
                'x.WriteLine("^XGR:SSGFX000.GRF,1,1^FS")
                'x.WriteLine("^PQ1,0,1,Y")
                'x.WriteLine("^XZ")
                'x.WriteLine("^XA")
                'x.WriteLine("^IDR:SSGFX000.GRF^XZ")




          


                x.WriteLine("^XA")
                x.WriteLine("^SZ2^JMA")
                x.WriteLine("^MCY^PMN")
                x.WriteLine("^PW670")
                x.WriteLine("~JSN")
                x.WriteLine("^MD30")
                x.WriteLine("^JZY")
                x.WriteLine("^LH0,0^LRN")
                x.WriteLine("^XZ")
                x.WriteLine("~DGR:SSGFX000.GRF,41238,58,:Z64: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:6983")
                x.WriteLine("^XA")
                x.WriteLine("^FO28,233")
                x.WriteLine("^BY2^BCN,78,N,N^FD>:E" & StrLotBarNo & "^FS")
                x.WriteLine("^FT95,333")
                x.WriteLine("^CI0")
                x.WriteLine("^A0N,23,32^FD" & StrLotBarNo & "^FS")
                x.WriteLine("^FT246,138")
                x.WriteLine("^A0N,20,41^FDB^FS")
                x.WriteLine("^FT294,131")
                x.WriteLine("^A0N,23,30^FD" & StrWith & "^FS")
                x.WriteLine("^FT502,131")
                x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                x.WriteLine("^FT254,75")
                x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                x.WriteLine("^FT70,75")
                x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                x.WriteLine("^FT390,75")
                x.WriteLine("^A0N,23,32^FDPower:^FS")
                x.WriteLine("^FT509,75")
                x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                x.WriteLine("^FT94,197")
                x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                x.WriteLine("^FT78,136")
                x.WriteLine("^A0N,28,37^FD" & txtref.Text & "^FS")
                x.WriteLine("^FO6,367")
                x.WriteLine("^GB639,0,2^FS")
                x.WriteLine("^FO6,566")
                x.WriteLine("^GB639,0,2^FS")
                x.WriteLine("^FT246,482")
                x.WriteLine("^A0N,20,41^FDB^FS")
                x.WriteLine("^FT294,475")
                x.WriteLine("^A0N,23,30^FD" & StrWith & "'^FS")
                x.WriteLine("^FT502,475")
                x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                x.WriteLine("^FT254,419")
                x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                x.WriteLine("^FT70,419")
                x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                x.WriteLine("^FT390,419")
                x.WriteLine("^A0N,23,32^FDPower:^FS")
                x.WriteLine("^FT509,419")
                x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                x.WriteLine("^FT94,541")
                x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                x.WriteLine("^FT78,480")
                x.WriteLine("^A0N,28,37^FD" & txtref.Text & "^FS")
                x.WriteLine("^FT245,681")
                x.WriteLine("^A0N,20,41^FDB^FS")
                x.WriteLine("^FT293,675")
                x.WriteLine("^A0N,23,30^FD" & StrWith & "^FS")
                x.WriteLine("^FT501,675")
                x.WriteLine("^A0N,23,26^FD" & StrHeig & "^FS")
                x.WriteLine("^FT254,618")
                x.WriteLine("^A0N,23,26^FD" & StrExp & "^FS")
                x.WriteLine("^FT70,618")
                x.WriteLine("^A0N,23,26^FD" & StrMfD & "^FS")
                x.WriteLine("^FT390,618")
                x.WriteLine("^A0N,23,32^FDPower:^FS")
                x.WriteLine("^FT509,618")
                x.WriteLine("^A0N,23,26^FD" & StrLotPower & "^FS")
                x.WriteLine("^FT94,740")
                x.WriteLine("^A0N,25,33^FD" & StrLotBarNo & "^FS")
                x.WriteLine("^FT78,679")
                x.WriteLine("^A0N,28,37^FD" & txtref.Text & "^FS")
                x.WriteLine("^FO422,200")
                x.WriteLine("^BY6^BXN,6,200,24,24,3,_^FD" & StrTwoDBar & "^FS")
                x.WriteLine("^FO14,40")
                x.WriteLine("^XGR:SSGFX000.GRF,1,1^FS")
                x.WriteLine("^PQ1,0,1,Y")
                x.WriteLine("^XZ")
                x.WriteLine("^XA")
                x.WriteLine("^IDR:SSGFX000.GRF^XZ")


                x.Flush()
                x.Close()

                RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, "c:\raj.txt")


                Str_Header = 0
                StrSqlSeHd = "Select Max(Header_ID) from UNIQUE_MASTER"
                Cmd = New SqlCommand(StrSqlSeHd, con)
                StrRsSeHd = Cmd.ExecuteReader
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
                Cmd.Dispose()


                Str_Detail = 0
                StrSqlSeDt = "Select Max(Detail_ID) from UNIQUE_MASTER"
                Cmd = New SqlCommand(StrSqlSeDt, con)
                StrRsSeDt = Cmd.ExecuteReader
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
                Cmd.Dispose()

                SqlIn = " INSERT INTo MAT_PACKING (Header_Id,	Detail_Id,	Brand,Ref,Lot_BarNo,	" & _
                        " Unique_No,Pak_Barcode,Created_By,	Created_Date,Modified_By,Modified_Date) VALUES ( " & _
                        "'" & Str_Header & "','" & Str_Detail & "','" & cmbbrand.Text & "','" & txtref.Text & "'," & _
                        "'" & StrLotBarNo & "','" & StrUni & "','" & StrTwoDBar & "','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"

                Cmd = New SqlCommand(SqlIn, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

            End If
        End If

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
    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged

    End Sub

    Private Sub FrmPackng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class