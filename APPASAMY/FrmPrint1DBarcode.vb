Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmPrint1DBarcode
    Dim getdetail As String
    Dim cmd As SqlCommand

    Dim read As SqlDataReader
    Dim sql As String

    Dim StrSqlSe1 As String
    Dim StrRsSe1 As SqlDataReader

    Dim StrMaxQty As Integer
    Dim StrPrtedQty As Integer
    Dim StrPrQty As Integer
    Dim StrBalQty As Integer

    Dim StrStPrQty As Integer
    Dim StrEnPrQty As Integer

    Dim StrSqlSePr As String
    Dim StrRsSePr As SqlDataReader

    Dim StrLotNo As String
    Dim StrB As String
    Dim StrT As String
    Dim StrExDate As String
    Dim StrMfDate As String
    Dim StrPower As String
    Dim StrlotBarNo As String
    Dim cmd1 As SqlCommand
    Dim read1 As SqlDataReader

    Dim sql1 As String

    Private Sub FrmPrint1DBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cmbmodel.Items.Clear()
        getdetail = "SELECT DISTINCT MODEL_NAME FROM LOT_MASTER "
        cmd = New SqlCommand(getdetail, con)
        read = cmd.ExecuteReader
        Do While read.Read
            cmbmodel.Items.Add(read.GetString(0))
        Loop
        cmd.Dispose()
        read.Close()

        cmblotno.Items.Clear()
        getdetail = "SELECT LOT_NO FROM LOT_MASTER"
        cmd = New SqlCommand(getdetail, con)
        read = cmd.ExecuteReader
        Do While read.Read
            cmblotno.Items.Add(read.GetString(0))
        Loop
        cmd.Dispose()
        read.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmblotno.Text = "" Then
            err.SetError(cmblotno, "Select Lot No")
            Exit Sub
        Else
            err.SetError(cmblotno, "")
        End If

        'If cmbmodel.Text = "" Then
        '    err.SetError(cmbmodel, "Select Lot No")
        '    Exit Sub
        'Else
        '    err.SetError(cmbmodel, "")
        'End If

        If txtquantity.Text = "" Then
            err.SetError(txtquantity, "Enter Qty")
            Exit Sub
        Else
            err.SetError(txtquantity, "")
        End If

        StrPrQty = txtquantity.Text
        If Val(StrPrQty) <= 0 Then
            MsgBox("Enter Minimum 1 Qty")
            txtquantity.Text = ""
            txtquantity.Focus()
            Exit Sub
        End If
        StrMaxQty = 300



        StrPrtedQty = 0
        StrSqlSe1 = "select Lot_Slno from LOT_MASTER where   Lot_No='" & cmblotno.Text & "' "
        cmd = New SqlCommand(StrSqlSe1, con)
        StrRsSe1 = cmd.ExecuteReader
        If StrRsSe1.Read Then
            lbllastsrno.Text = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
            StrPrtedQty = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
        Else
            lbllastsrno.Text = 0
            StrPrtedQty = 0
        End If
        cmd.Dispose()
        StrRsSe1.Close()







        StrBalQty = Val(StrMaxQty) - (Val(StrPrtedQty) + Val(StrPrQty))

        If Val(StrBalQty) < 0 Then
            MsgBox("Max Qty Reached")
            txtquantity.Text = ""
            txtquantity.Focus()
            Exit Sub
        End If

        StrStPrQty = StrPrtedQty + 1
        StrEnPrQty = StrPrtedQty + StrPrQty





        StrSqlSePr = "SELECT Lot_No,Lot_Power,Lot_Width,Lot_Height,Lot_Unit,MF_Date_Month,MF_Date_Year," & _
                     "Exp_Date_Month, Exp_Date_Year " & _
                     "FROM LOT_MASTER WHERE Lot_No='" & cmblotno.Text & "'"
        cmd = New SqlCommand(StrSqlSePr, con)
        StrRsSePr = cmd.ExecuteReader
        If StrRsSePr.Read Then
            StrLotNo = IIf(IsDBNull(StrRsSePr.GetValue(0)), "", StrRsSePr.GetValue(0))
            StrB = Format(IIf(IsDBNull(StrRsSePr.GetValue(2)), "", StrRsSePr.GetValue(2)), "0.00") & " " & IIf(IsDBNull(StrRsSePr.GetValue(4)), "", StrRsSePr.GetValue(4))
            StrT = Format(IIf(IsDBNull(StrRsSePr.GetValue(3)), "", StrRsSePr.GetValue(3)), "0.00") & " " & IIf(IsDBNull(StrRsSePr.GetValue(4)), "", StrRsSePr.GetValue(4))
            StrMfDate = IIf(IsDBNull(StrRsSePr.GetValue(5)), "", StrRsSePr.GetValue(5)) & "-" & IIf(IsDBNull(StrRsSePr.GetValue(6)), "", StrRsSePr.GetValue(6))
            StrExDate = IIf(IsDBNull(StrRsSePr.GetValue(7)), "", StrRsSePr.GetValue(7)) & "-" & IIf(IsDBNull(StrRsSePr.GetValue(8)), "", StrRsSePr.GetValue(8))
            StrPower = IIf(IsDBNull(StrRsSePr.GetValue(1)), "", StrRsSePr.GetValue(1))
        End If

        StrRsSePr.Close()
        cmd.Dispose()

        Dim x As New StreamWriter("c:\raj.txt")
        For StI As Integer = StrStPrQty To StrEnPrQty

            StrlotBarNo = StrLotNo & " " & Format(StI, "000")

          
            'x.WriteLine("^XA")
            'x.WriteLine("^SZ2^JMA")
            'x.WriteLine("^MCY^PMN")
            'x.WriteLine("^PW640")
            'x.WriteLine("~JSN")
            'x.WriteLine("^MD21")
            'x.WriteLine("^JZY")
            'x.WriteLine("^LH0,0^LRN")
            'x.WriteLine("^XZ")
            'x.WriteLine("~DGR:SSGFX000.GRF,3942,27,:Z64:eJzt0rFqAkEQBuBBRSy2PlJYbGGR8sAmXe5AfAaxuYBNSt/AOUnpC9jlQSw2+CIHPoCIjd2abmfE3+KQkGJ+OBj4mNvl7o8xxobuhn+fD0y+1Rag0GqL6cCA6u754gH1XwLa6g0KQD9fDlG9cfiF+KwsD+iGpwZtMT39G/7dX17hsuV7l4f7ZLFYLBaLxfI/8x4geUxlQQWgKQKiSSuaYVpi8gypInh5S6u8pXHFmnwa+YYGknQPh5J0D50k1cNRkKR6+NmkuWRVtvl3mse6h9vXNGe6h7WTtKzk0YIW5Ndii8VcctUBPdwxdcBWvCEH6bhThPKQrty/UVI=:6A3D")
            'x.WriteLine("^XA")
            'x.WriteLine("^FO53,43")
            ''x.WriteLine("^BY1^BCN,57,N,N^FD>:EA1>511109650>6 174^FS")
            'x.WriteLine("^BY1^BCN,57,N,N^FD>:" & StrlotBarNo & "^FS")
            'x.WriteLine("^FT14,126")
            'x.WriteLine("^CI0")
            'x.WriteLine("^A0N,8,20^FDB^FS")
            'x.WriteLine("^FT38,123")
            ''x.WriteLine("^A0N,14,15^FD6.00 mm^FS")
            'x.WriteLine("^A0N,14,15^FD" & StrB & "^FS")
            'x.WriteLine("^FT38,147")
            ''x.WriteLine("^A0N,14,15^FD12.50 mm^FS")
            'x.WriteLine("^A0N,14,15^FD" & StrT & "^FS")
            'x.WriteLine("^FT222,147")
            ''x.WriteLine("^A0N,14,15^FD04-2016^FS")
            'x.WriteLine("^A0N,14,15^FD" & StrExDate & "^FS")
            'x.WriteLine("^FT132,147")
            ''x.WriteLine("^A0N,14,15^FD03-2011^FS")
            'x.WriteLine("^A0N,14,15^FD" & StrMfDate & "^FS")
            'x.WriteLine("^FT110,123")
            'x.WriteLine("^A0N,14,19^FDPower:^FS")
            'x.WriteLine("^FT166,123")
            ''x.WriteLine("^A0N,14,15^FD20.00 D^FS")
            'x.WriteLine("^A0N,14,15^FD" & StrPower & "^FS")
            'x.WriteLine("^FT54,27")
            ''x.WriteLine("^A0N,23,32^FDEA111109650 174^FS")
            'x.WriteLine("^A0N,23,32^FD" & StrlotBarNo & "^FS")
            'x.WriteLine("^FO6,8")
            'x.WriteLine("^XGR:SSGFX000.GRF,1,1^FS")
            'x.WriteLine("^PQ1,0,1,Y")
            'x.WriteLine("^XZ")
            'x.WriteLine("^XA")
            'x.WriteLine("^IDR:SSGFX000.GRF^XZ")

            x.WriteLine("^XA")
            x.WriteLine("^SZ2^JMA")
            x.WriteLine("^MCY^PMN")
            x.WriteLine("^PW662")
            x.WriteLine("~JSN")
            x.WriteLine("^MD21")
            x.WriteLine("^JZY")
            x.WriteLine("^LH0,0^LRN")
            x.WriteLine("^XZ")
            x.WriteLine("~DGR:SSGFX000.GRF,3942,27,:Z64:eJztlqEKwlAUhi8yTAsGg0FwIJgXLLaJYjIsGAUFH8PgmcqiyeJb+AgbvohPIAOL7WrbOcP/hmEwnA8GB779uz/bCbPW2sJ8JftcIVYAR4p+rXJzL5A6jF7fjcnTzhqkEs+PoPKgOvrogXnqUJ01avgsUIrMj99h5lYAR8pxlsXL5oc3P8DnKYqiKIqi/B+9CKqAoBpHBuUm+IHTWmqOVYyVo/yOYHmlFt1ytCRVqxypotpcyT1sciU+ZTDjSuzhYMGV2MMZ+7PP5bItr+Xcl+py5mXFHiZpOQ9NvMrY0az8xgR7liKP1aDdnpUndtuJTIOn2GwrqgnV9iEUwqnePmpOzA==:58A6")
            x.WriteLine("^XA")
            x.WriteLine("^FO63,56")
            'x.WriteLine("^BY1^BCN,57,N,N^FD>:EA1>511109650>6 174^FS")
            x.WriteLine("^BY1^BCN,57,N,N^FD>:" & StrlotBarNo & "^FS")
            x.WriteLine("^FT24,138")
            x.WriteLine("^CI0")
            x.WriteLine("^A0N,8,20^FDB^FS")
            x.WriteLine("^FT49,135")
            'x.WriteLine("^A0N,14,15^FD6.00 mm^FS")
            x.WriteLine("^A0N,14,15^FD" & StrB & "'^FS")
            x.WriteLine("^FT48,159")
            'x.WriteLine("^A0N,14,15^FD12.50 mm^FS")
            x.WriteLine("^A0N,14,15^FD" & StrT & "^FS")
            x.WriteLine("^FT232,159")
            'x.WriteLine("^A0N,14,15^FD04-2016^FS")
            x.WriteLine("^A0N,14,15^FD" & StrExDate & "^FS")
            x.WriteLine("^FT142,159")
            x.WriteLine("^A0N,14,15^FD03-2011^FS")
            x.WriteLine("^A0N,14,15^FD" & StrMfDate & "^FS")
            x.WriteLine("^FT120,135")
            x.WriteLine("^A0N,14,19^FDPower:^FS")
            x.WriteLine("^FT176,135")
            'x.WriteLine("^A0N,14,15^FD20.00 D^FS")
            x.WriteLine("^A0N,14,15^FD" & StrPower & "^FS")
            x.WriteLine("^FT64,39")
            'x.WriteLine("^A0N,23,32^FDEA111109650 174^FS")
            x.WriteLine("^A0N,23,32^FD" & StrlotBarNo & "^FS")
            x.WriteLine("^FO16,20")
            x.WriteLine("^XGR:SSGFX000.GRF,1,1^FS")
            x.WriteLine("^PQ1,0,1,Y")
            x.WriteLine("^XZ")
            x.WriteLine("^XA")
            x.WriteLine("^IDR:SSGFX000.GRF^XZ")
            x.WriteLine("")
            x.WriteLine("")
            x.WriteLine("")
            x.WriteLine("")
            x.WriteLine("")
            x.WriteLine("")

          
            'File.Delete(Application.StartupPath & "\write.txt")


            'sql1 = "INSERT INTO PRINT_MASTER VALUES('" & cmblotno.Text & "','" & StI & "' ,'" & cmbmodel.Text & "','0')"
            'cmd1 = New SqlCommand(sql1, con)
            'cmd1.ExecuteNonQuery()
        Next


        x.Flush()
        x.Close()

        RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, "c:\raj.txt")


        sql1 = "UPDATE LOT_MASTER SET LOT_SLNO='" & StrEnPrQty & "'   WHERE LOT_NO='" & cmblotno.Text & "' AND MODEL_NAME='" & cmbmodel.Text & "'"
        cmd1 = New SqlCommand(sql1, con)
        cmd1.ExecuteNonQuery()
        cmd1.Dispose()
        MsgBox("Update Sucess")





    End Sub

    Private Sub Print_LotNo()









       



        ' Allow the user to select a file.
        'Dim ofd As New OpenFileDialog()
        ''If ofd.ShowDialog(Me) Then
        '' Allow the user to select a printer.
        'Dim pd As New PrintDialog()
        'pd.PrinterSettings = New PrinterSettings()
        'If (pd.ShowDialog() = DialogResult.OK) Then
        '    ' Print the file to the printer.
        '    RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, "C:\Documents and Settings\TataACE\Desktop\TFL\4-2.PRN")
        'End If
        ''End If

        'Dim a As Long
        'a = CLng(TextBox1.Text.Substring(0, 9))
        'a = a + 1
        'TextBox1.Text = a & TextBox1.Text.Substring(9, Len(TextBox1.Text) - 9)


        'File.Delete("c:\raj.txt")










        'Dim readPRN As New StreamReader(Application.StartupPath & "\2.prn")
        'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.txt")
        'Dim idx As Integer
        'Dim dt As String
        'While readPRN.Peek <> -1
        '    dt = readPRN.ReadLine
        '    idx = dt.IndexOf("VFIJLBBA50Y123456")
        '    If idx <> -1 Then
        '        dt = dt.Substring(0, idx) & vin.ToString
        '    Else
        '        idx = dt.IndexOf("ABCD12")
        '        If idx <> -1 Then
        '            dt = dt.Substring(0, idx) & col.ToString
        '        End If
        '    End If
        '    'dt.Replace("VFIJLBBA50Y123456", vin)
        '    'dt.Replace("ABCD12", col)
        '    writePRN.WriteLine(dt)
        'End While
        'readPRN.Close()
        'readPRN.Dispose()
        'writePRN.Flush()
        'writePRN.Close()
        'writePRN.Dispose()

        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.txt")

        'File.Delete(Application.StartupPath & "\write.txt")

    End Sub


    Private Sub cmbmodel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmodel.SelectedIndexChanged


        StrPrtedQty = 0
        StrSqlSe1 = "select Lot_Slno from LOT_MASTER where   Lot_No='" & cmblotno.Text & "' and Model_Name='" & cmbmodel.Text & "'"
        cmd = New SqlCommand(StrSqlSe1, con)
        StrRsSe1 = cmd.ExecuteReader
        If StrRsSe1.Read Then
            lbllastsrno.Text = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
            StrPrtedQty = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
        Else
            lbllastsrno.Text = 0
            StrPrtedQty = 0
        End If
        cmd.Dispose()
        StrRsSe1.Close()
        txtquantity.Focus()

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

    Private Sub cmblotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblotno.SelectedIndexChanged
        StrPrtedQty = 0
        StrSqlSe1 = "select Lot_Slno from LOT_MASTER where   Lot_No='" & cmblotno.Text & "' "
        cmd = New SqlCommand(StrSqlSe1, con)
        StrRsSe1 = cmd.ExecuteReader
        If StrRsSe1.Read Then
            lbllastsrno.Text = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
            StrPrtedQty = IIf(IsDBNull(StrRsSe1.GetValue(0)), 0, StrRsSe1.GetValue(0))
        Else
            lbllastsrno.Text = 0
            StrPrtedQty = 0
        End If
        cmd.Dispose()
        StrRsSe1.Close()
        txtquantity.Focus()
    End Sub
End Class