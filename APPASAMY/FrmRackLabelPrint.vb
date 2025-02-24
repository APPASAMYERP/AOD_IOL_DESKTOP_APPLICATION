Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmRackLabelPrint

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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            ' Validations  

            If Not IsNumeric(TextBox3.Text) Then
                MessageBox.Show("Please Enter valid Rack From.")
                TextBox3.Focus()
                Exit Sub
            End If

            If Not IsNumeric(TextBox4.Text) Then
                MessageBox.Show("Please Enter valid Rack To.")
                TextBox4.Focus()
                Exit Sub
            End If

            If Not IsNumeric(TextBox5.Text) Then
                MessageBox.Show("Please Enter valid Column.")
                TextBox5.Focus()
                Exit Sub
            End If


            If Val(TextBox3.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox3.Text = ""
                TextBox3.Focus()
                Exit Sub
            End If
            If Val(TextBox4.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox4.Text = ""
                TextBox4.Focus()
                Exit Sub
            End If
            If Val(TextBox5.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox5.Text = ""
                TextBox5.Focus()
                Exit Sub
            End If

            If Val(TextBox4.Text) < Val(TextBox3.Text) Then
                MsgBox("Rack From is greater than Rack To. Please check")
                TextBox3.Text = ""
                TextBox3.Focus()
                Exit Sub
            End If


            Dim StrFName As String = "Rack_Label.btw"
            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If
            If CheckBox1.Checked = True Then
                Dim items As New List(Of String)(New String() {"A", "B", "C", "D", "E", "F", "G"})
                For i = Convert.ToInt32(TextBox3.Text) To Convert.ToInt32(TextBox4.Text)
                    For k = 0 To items.Count - 1
                        For j = Convert.ToInt32(TextBox5.Text) To Convert.ToInt32(TextBox5.Text)
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            Console.WriteLine("R" + i.ToString() + " - " + items(k).ToString() + "" + j.ToString())
                            bt.SetNamedSubStringValue("rackid", "R" + i.ToString() + "-" + items(k).ToString() + "" + j.ToString())
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        Next
                    Next
                Next
            Else
                Dim items As New List(Of String)(New String() {"A", "B", "C", "D", "E", "F", "G"})
                For i = Convert.ToInt32(TextBox3.Text) To Convert.ToInt32(TextBox4.Text)
                    For k = 0 To items.Count - 1
                        For j = 1 To Convert.ToInt32(TextBox5.Text)
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            Console.WriteLine("R" + i.ToString() + " - " + items(k).ToString() + "" + j.ToString())
                            bt.SetNamedSubStringValue("rackid", "R" + i.ToString() + "-" + items(k).ToString() + "" + j.ToString())
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        Next
                    Next
                Next
            End If
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
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

    Public Sub UpdateorInsertQuery_Execute(ByVal strQuery As String)

        Dim strsql As String
        strsql = strQuery
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub btn_Add_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Master.Click

        Try

            Dim strInsertQry As String = ""
            Dim rack_ids As String = ""


            ' Validations  
            If Not IsNumeric(TextBox3.Text) Then
                MessageBox.Show("Please Enter valid Rack From.")
                TextBox3.Focus()
                Exit Sub
            End If

            If Not IsNumeric(TextBox4.Text) Then
                MessageBox.Show("Please Enter valid Rack To.")
                TextBox4.Focus()
                Exit Sub
            End If

            If Not IsNumeric(TextBox5.Text) Then
                MessageBox.Show("Please Enter valid Column.")
                TextBox5.Focus()
                Exit Sub
            End If

            If Val(TextBox3.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox3.Text = ""
                TextBox3.Focus()
                Exit Sub
            End If
            If Val(TextBox4.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox4.Text = ""
                TextBox4.Focus()
                Exit Sub
            End If
            If Val(TextBox5.Text) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                TextBox5.Text = ""
                TextBox5.Focus()
                Exit Sub
            End If

            If Val(TextBox4.Text) < Val(TextBox3.Text) Then
                MsgBox("Rack From is greater than Rack To. Please check")
                TextBox3.Text = ""
                TextBox3.Focus()
                Exit Sub
            End If




            Dim items As New List(Of String)(New String() {"A", "B", "C", "D", "E", "F", "G"})
            For i = Convert.ToInt32(TextBox3.Text) To Convert.ToInt32(TextBox4.Text)
                For k = 0 To items.Count - 1
                    For j = 1 To Convert.ToInt32(TextBox5.Text)
                        rack_ids = rack_ids + "'" + "R" + i.ToString() + "-" + items(k).ToString() + "" + j.ToString() + "',"
                        strInsertQry = strInsertQry + "('" + "R" + i.ToString() + "-" + items(k).ToString() + "" + j.ToString() + "'),"
                    Next
                Next

            Next

            rack_ids = rack_ids.Remove(rack_ids.Length - 1, 1)
            Sql = "Select * from Rack_Master where RackId IN(" & rack_ids & ")  "
            Ds = SQL_SelectQuery_Execute(Sql)

            If Ds.Tables(0).Rows.Count < 1 Then
                strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                Sql = "Insert into Rack_Master (RackId) VALUES " & strInsertQry
                UpdateorInsertQuery_Execute(Sql)
                MsgBox("Rack Id Added Sucessfully.")
            Else
                MsgBox("Rack Id Already Created. Please Check")
                Exit Sub
            End If

            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Tray_No As String = ""
        Dim Tray_Unique As Integer = 70




        Sql = "SELECT     Lot_Prefix + Lot_No AS lotno, sum(qty_1) as Qty FROM         POUCH_LABEL WHERE     (Sterilization = '1') AND (Sterilization_After = '1') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND " & _
        " (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND (Model_Name='302') AND (Tray_No IS NULL) AND ( (Mfd_Year = '2024') AND (Mfd_Month = '01') OR  (Mfd_Year < '2024')) GROUP BY Lot_Prefix + Lot_No order by Lot_Prefix + Lot_No "
        Ds = SQL_SelectQuery_Execute(Sql)

        For Each eachRow As DataRow In Ds.Tables(0).Rows

            'eachRow("Qty")/60
            For j = 1 To Math.Ceiling(eachRow("Qty") / 150)
                Tray_Unique = Tray_Unique + 1
                Tray_No = "Tray/010324/" + Tray_Unique.ToString("0000")

                Sql = "UPDATE    POUCH_LABEL SET              Tray_No = '" & Tray_No & "'  " & _
         "WHERE     (Lot_SrNo IN  (SELECT    TOP(150) Lot_srno FROM         POUCH_LABEL WHERE     (Sterilization = '1') AND (Sterilization_After = '1') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND " & _
         " (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') and (Model_Name='302')  AND (Tray_No IS NULL) AND  Lot_Prefix+Lot_no = '" & eachRow("lotno") & "' AND ( (Mfd_Year = '2024') AND (Mfd_Month = '01') OR  (Mfd_Year < '2024')) ORDER BY Lot_SrNo)) "

                UpdateorInsertQuery_Execute(Sql)

            Next

        Next
       


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class