
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Seagull.BarTender.Print


Public Class FrmAssetId_LabelPrint
    Dim bt As New BarTender.Format
    Dim bApp As New BarTender.Application
    Dim btFile As String
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader

    Private Sub killProcess(ByRef StrProcessKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            'MsgBox(Proc(i).ProcessName)
            If Proc(i).ProcessName = StrProcessKill Then
                'MsgBox(Proc(i).ProcessName)
                Try
                    Proc(i).Kill()
                Catch ex As Exception
                End Try
            End If
        Next
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

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try

            If txtSequence.Text = "" Then
                MsgBox("Enter Enter Sequence")
                txtSequence.Focus()
                Exit Sub
            End If

            If Val(from_serial.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                from_serial.Text = ""
                from_serial.Focus()
                Exit Sub
            End If
            If Val(to_Serial.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                to_Serial.Text = ""
                to_Serial.Focus()
                Exit Sub
            End If

            If Val(to_Serial.Text) < Val(from_serial.Text) Then
                MsgBox("From Serial is greater than To Serial. Please check")
                to_Serial.Text = ""
                to_Serial.Focus()
                Exit Sub
            End If


            Dim StrFName As String = "Asset_Label.btw"
            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If


            For i = Convert.ToInt32(from_serial.Text) To Convert.ToInt32(to_Serial.Text)
                bt = bApp.Formats.Open(btFile, False, "")
                bt.Printer = "Microsoft Print to PDF"
                Console.WriteLine(txtSequence.Text + "" + i.ToString("00000"))
                bt.SetNamedSubStringValue("assetid", txtSequence.Text + "" + i.ToString("00000"))

                'save Btw file-2024-08-27


                Dim pdfFilePath As String = Application.StartupPath & "\TestFile\" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & "-" & StrFName & ".pdf"

                ' Ensure directory exists
                Dim directoryPath As String = Path.GetDirectoryName(pdfFilePath)
                If Not Directory.Exists(directoryPath) Then
                    Directory.CreateDirectory(directoryPath)
                End If

                bt.PageSetup.PaperName = pdfFilePath
                ' Save the Bartender file as a PDF

                'bt.ExportPrintPreviewToFile(pdfFilePath, btPrintPreviewFileType.PDF)


                bt.PrintOut()
                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

            Next



            from_serial.Text = ""
            to_Serial.Text = ""
            txtSequence.Text = ""
            'killProcess("bartend")
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Sql = "SELECT     Lot_SrNo, Optic, Length, Power, Mfd_Year, Mfd_Month, Exp_Year, Exp_Month, R_Power, Model_Name, GS_Code, Btc_No " & _
         " FROM         POUCH_LABEL " & _
         "WHERE       (Lot_SrNo = '" & txtSequence.Text & "') "

        Ds = SQL_SelectQuery_Execute(Sql)
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            Dim mfdTwod As String = eachRow("Mfd_Year").ToString().Substring(2, 2) & Format(eachRow("Mfd_Month"), "00") & "00"
            Dim expTwod As String = eachRow("Exp_Year").ToString().Substring(2, 2) & Format(eachRow("Exp_Month"), "00") & "00"
            Dim mfddate As String = eachRow("Mfd_Year").ToString() & "-" & Format(eachRow("Mfd_Month"), "00")
            Dim expdate As String = eachRow("Exp_Year").ToString() & "-" & Format(eachRow("Exp_Month"), "00")


            Dim writePRN As New StreamWriter(Application.StartupPath & "\np-pouch-2_write.prn")
            Dim readPRN As New StreamReader(Application.StartupPath & "\np-pouch-2.prn")

            Dim idx As Integer
            Dim dt As String

            ' Read from the original PRN file and modify its contents
            While readPRN.Peek <> -1
                dt = readPRN.ReadLine
                Debug.Print(dt) ' Debug output to check content
                'idx = dt.IndexOf("Lot_Serial_Number")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("Lot_SrNo")
                'End If

                'idx = dt.IndexOf("Optic")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & Format(eachRow("Optic"), "0.00")
                'End If

                'idx = dt.IndexOf("Length")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & Format(eachRow("Length"), "0.00")
                'End If

                'idx = dt.IndexOf("pwr")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("Power").ToString()
                'End If

                'idx = dt.IndexOf("mfddate")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & mfddate
                'End If

                'idx = dt.IndexOf("expdate")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & expdate
                'End If

                'idx = dt.IndexOf("apr")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("R_Power").ToString()
                'End If

                'idx = dt.IndexOf("Model_name")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("Model_Name")
                'End If

                'idx = dt.IndexOf("00000123000017")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("GS_Code").ToString()
                'End If

                'idx = dt.IndexOf("St_batch")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & eachRow("Btc_No")
                'End If

                'idx = dt.IndexOf("mfdTwod")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & mfdTwod
                'End If
                'idx = dt.IndexOf("expTwod")
                'If idx <> -1 Then
                '    dt = dt.Substring(0, idx) & expTwod
                'End If

                dt = ReplacePlaceholder(dt, "Lot_Serial_Number", eachRow("Lot_SrNo").ToString())
                dt = ReplacePlaceholder(dt, "Optic", Format(eachRow("Optic"), "0.00"))
                dt = ReplacePlaceholder(dt, "Length", Format(eachRow("Length"), "0.00"))
                dt = ReplacePlaceholder(dt, "pwr", eachRow("Power").ToString() + " D")
                dt = ReplacePlaceholder(dt, "mfddate", mfddate)
                dt = ReplacePlaceholder(dt, "expdate", expdate)
                dt = ReplacePlaceholder(dt, "apr", eachRow("R_Power").ToString() + " D")
                dt = ReplacePlaceholder(dt, "Model_name", eachRow("Model_Name").ToString())
                dt = ReplacePlaceholder(dt, "00000123000017", eachRow("GS_Code").ToString())
                dt = ReplacePlaceholder(dt, "St_batch", eachRow("Btc_No").ToString())
                dt = ReplacePlaceholder(dt, "mfdTwod", mfdTwod)
                dt = ReplacePlaceholder(dt, "expTwod", expTwod)

                ' Write the modified content to the new PRN file
                writePRN.WriteLine(dt)
                Debug.Print(dt) ' Debug output to check modified content
            End While

            ' Close and dispose of the readers and writers
            readPRN.Close()
            readPRN.Dispose()

            writePRN.Flush()
            writePRN.Close()
            writePRN.Dispose()

            ' Send the updated PRN file to the default printer
            RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\np-pouch-2_write.prn")

        Next

        

        

        'Correct
        '-------------------------------------------------------


       


       

        
    End Sub
    Private Function ReplacePlaceholder(ByVal input As String, ByVal placeholder As String, ByVal replacement As String) As String
        If input.Contains(placeholder) Then
            input = input.Replace(placeholder, replacement)
        End If
        Return input
    End Function

    Private Sub PrintPrnFile(ByVal prnFilePath As String)
        Try
            ' Set the printer path (network printer or shared printer)
            Dim printerPath As String = "\\192.168.0.170\Datamax4212e"

            ' Use the CMD copy command to send the PRN file to the printer
            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/C copy /b """ & prnFilePath & """ """ & printerPath & """"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()

            ' Check the exit code to determine if the process was successful
            If process.ExitCode = 0 Then
                Console.WriteLine("PRN file sent to printer successfully.")
            Else
                Console.WriteLine("Failed to send PRN file to printer.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Class