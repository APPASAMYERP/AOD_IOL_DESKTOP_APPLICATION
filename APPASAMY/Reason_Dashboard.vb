
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class Reason_Dashboard
    Dim table As New DataTable
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim cmd As SqlCommand
    Dim newFromTime As DateTime
    Dim newToTime As DateTime
    Dim oldFromTime As DateTime
    Dim oldToTime As DateTime



    Private Sub LoadGrid()

        grid1.Rows.Clear()

        Dim StrDtFr As String
        Dim StrDtTo As String

        'If grid1.Columns.Count >= 10 Then
        '    For Each eachColumn As DataGridViewColumn In grid1.Columns
        '        If eachColumn.Name = "btnUpdate" Then
        '            grid1.Columns.Remove("btnUpdate")
        '            Exit For
        '        End If
        '    Next
        'End If

        StrDtFr = Format(dtpdate.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpdate.Value, "yyyy-MM-dd") & " 23:59:59"


        Dim ds As New DataSet()
        Sql = "SELECT Id, Station, Printed_By, Packed_By, Shift, DateTimeFrom, DateTimeTo, PackingStatus, Reason " & _
                "FROM  Reaon_of_Packing " & _
                 " WHERE (DateTimeFrom BETWEEN '" & StrDtFr & "' AND '" & StrDtTo & "') "
        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            For Each row As DataRow In ds.Tables(0).Rows
                grid1.Rows.Add(row("Id"), row("Station"), row("Printed_By"), row("Packed_By"), row("Shift"), row("DateTimeFrom"), row("DateTimeTo"), row("PackingStatus"), row("Reason"))
            Next

            'grid1.DataSource = ds.Tables(0)
        End If

        '' readonly
        'grid1.Columns(0).ReadOnly = True
        'grid1.Columns(1).ReadOnly = True
        'grid1.Columns(2).ReadOnly = True
        'grid1.Columns(3).ReadOnly = True
        'grid1.Columns(4).ReadOnly = True
        'grid1.Columns(7).ReadOnly = True
        'grid1.Columns(8).ReadOnly = True
        ''update Button
        'Dim updateBtnColumn As DataGridViewButtonColumn = New DataGridViewButtonColumn
        'updateBtnColumn.HeaderText = "Update"
        'updateBtnColumn.Width = 200
        'updateBtnColumn.Text = "Update"
        'updateBtnColumn.Name = "btnUpdate"
        'grid1.Columns.Add(updateBtnColumn)

        'For Each row As DataGridViewRow In grid1.Rows
        '    'Reference the ComboBoxCell.
        '    Dim updateBtnBoxCell As DataGridViewButtonCell = CType(row.Cells(9), DataGridViewButtonCell)

        'Next
        'update Button
    End Sub


    Private Sub Reason_Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
        LoadProduct_Type()
        LoadStation_Type()
        LoadEmpName()

    End Sub
    Private Sub LoadProduct_Type()
        Dim ds As New DataSet()
        Sql = "select distinct Emp_Dept from LOGIN"
        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)

        End If
    End Sub
    Private Sub LoadStation_Type()
        Dim ds As New DataSet()
        Sql = "select distinct StationName from Station_Master"
        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            cmbstatype.DisplayMember = "StationName"
            cmbstatype.DataSource = ds.Tables(0)
        End If
    End Sub
    Private Sub LoadEmpName()
        Dim ds As New DataSet()
        Sql = "select distinct Emp_Name + '- ' + UserName AS EmpName FROM  LOGIN"
        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            cmbempname.Items.Clear()
            cmbempname.DisplayMember = "EmpName"
            cmbempname.DataSource = ds.Tables(0)


            cmbempname2.Items.Clear()
            For Each eachRow As DataRow In ds.Tables(0).Rows
                cmbempname2.Items.Add(eachRow("EmpName"))
            Next
            
        End If

    End Sub

   

    Private Sub dtpdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdate.ValueChanged
        dtpFromTime.Value = dtpdate.Value
        dtpToTime.Value = dtpdate.Value
        LoadGrid()
    End Sub

    Private Sub chkPacking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPacking.CheckedChanged
        If chkPacking.Checked = True Then
            Label4.Visible = False
            RichTextBox1.Visible = False
        Else
            Label4.Visible = True
            RichTextBox1.Visible = True
        End If
        

    End Sub
    Private Sub clear()

        cmbstatype.Text = ""
        cmbempname.Text = ""
        cmbempname2.Text = ""
        RichTextBox1.Text = ""
        chkPacking.Checked = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim packing_status As Integer
        Dim StrStation As String = ""
        Dim StrUser1 As String = ""
        Dim StrUser2 As String = ""

        Dim Shift1_startTime As DateTime = DateTime.Parse("5:59:59 AM")
        Dim Shift1_endTime As DateTime = DateTime.Parse("2:00:01 PM")
        Dim Shift2_startTime As DateTime = DateTime.Parse("1:59:59 PM")
        Dim Shift2_endTime As DateTime = DateTime.Parse("10:00:01 PM")

        Dim ShiftG_startTime As DateTime = DateTime.Parse("8:59:59 AM")
        Dim ShiftG_endTime As DateTime = DateTime.Parse("5:30:01 PM")


        If chkPacking.Checked = True Then
            packing_status = 1
        Else
            packing_status = 0
        End If

        'KPMG
        If cmbstatype.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Station")
            cmbstatype.Focus()
            Exit Sub
        End If
        If cmbShift.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Shift")
            cmbShift.Focus()
            Exit Sub
        End If
        If cmbempname.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Printed By")
            cmbempname.Focus()
            Exit Sub
        End If
        If cmbempname2.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Packed By")
            cmbempname2.Focus()
            Exit Sub
        End If


        ' Validations
        If cmbstatype.Text = "" Then
            err.SetError(cmbstatype, "This information is required")
            cmbstatype.Focus()
            Exit Sub
        Else
            err.SetError(cmbstatype, "")
        End If


        If cmbempname.Text = "" Then
            err.SetError(cmbempname, "This information is required")
            cmbempname.Focus()
            Exit Sub
        Else
            err.SetError(cmbempname, "")
        End If

        If cmbempname2.Text = "" Then
            err.SetError(cmbempname2, "This information is required")
            Exit Sub
        Else
            err.SetError(cmbempname2, "")
        End If

        If cmbShift.Text = "" Then
            err.SetError(cmbShift, "This information is required")
            Exit Sub
        Else
            err.SetError(cmbShift, "")
        End If
        If dtpFromTime.Text = "" Then
            err.SetError(dtpFromTime, "This information is required")
            Exit Sub
        Else
            err.SetError(dtpFromTime, "")
        End If
        If dtpToTime.Text = "" Then
            err.SetError(dtpToTime, "This information is required")
            Exit Sub
        Else
            err.SetError(dtpToTime, "")
        End If

        If packing_status = 0 And RichTextBox1.Text = "" Then
            err.SetError(RichTextBox1, "This information is required")
            Exit Sub
        Else
            err.SetError(RichTextBox1, "")
        End If

        If dtpFromTime.Value <= DateTime.Now Then
            MsgBox("From_Time less than Current Time. Please check ")
            Exit Sub
        End If

        If dtpFromTime.Value >= dtpToTime.Value Then
            MsgBox("From_Time greater than To_Time. Please check ")
            Exit Sub
        End If

        If cmbempname.Text = cmbempname2.Text Then
            MsgBox("Printed By and Packed By Same. Please check ")
            Exit Sub
        End If

        If cmbShift.Text = "I" Then
            If dtpFromTime.Value.TimeOfDay > Shift1_startTime.TimeOfDay And dtpFromTime.Value.TimeOfDay < Shift1_endTime.TimeOfDay And dtpToTime.Value.TimeOfDay > Shift1_startTime.TimeOfDay And dtpToTime.Value.TimeOfDay < Shift1_endTime.TimeOfDay Then
            Else
                MsgBox("Please Enter Valid Time for 'I shift'")
                Exit Sub
            End If
        ElseIf cmbShift.Text = "II" Then
            If dtpFromTime.Value.TimeOfDay > Shift2_startTime.TimeOfDay And dtpFromTime.Value.TimeOfDay < Shift2_endTime.TimeOfDay And dtpToTime.Value.TimeOfDay > Shift2_startTime.TimeOfDay And dtpToTime.Value.TimeOfDay < Shift2_endTime.TimeOfDay Then
            Else
                MsgBox("Please Enter Valid Time for 'II shift'")
                Exit Sub
            End If

        ElseIf cmbShift.Text = "G" Then

            If dtpFromTime.Value.TimeOfDay > ShiftG_startTime.TimeOfDay And dtpFromTime.Value.TimeOfDay < ShiftG_endTime.TimeOfDay And dtpToTime.Value.TimeOfDay > ShiftG_startTime.TimeOfDay And dtpToTime.Value.TimeOfDay < ShiftG_endTime.TimeOfDay Then
            Else
                MsgBox("Please Enter Valid Time for 'G shift'")
                Exit Sub
            End If
        End If

        Try

            'Grid 2
            For i = 0 To GRID2.Rows.Count - 2


                StrStation = GRID2.Item(0, i).Value
                StrUser1 = GRID2.Item(1, i).Value
                StrUser2 = GRID2.Item(2, i).Value
                'station validation
                If StrStation = cmbstatype.Text Then

                    If (dtpFromTime.Value >= GRID2.Item(4, i).Value) And (dtpFromTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbstatype.Text + " Already Added this Time. Please Check")
                        cmbstatype.Text = ""
                        cmbstatype.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= GRID2.Item(4, i).Value) And (dtpToTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbstatype.Text + " Already Added this Time. Please Check")
                        cmbstatype.Text = ""
                        cmbstatype.Focus()
                        Exit Sub
                    End If

                End If

                'User Validation
                If StrUser1 = cmbempname.Text Then
                    If (dtpFromTime.Value >= GRID2.Item(4, i).Value) And (dtpFromTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= GRID2.Item(4, i).Value) And (dtpToTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser2 = cmbempname.Text Then
                    If (dtpFromTime.Value >= GRID2.Item(4, i).Value) And (dtpFromTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= GRID2.Item(4, i).Value) And (dtpToTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser1 = cmbempname2.Text Then
                    If (dtpFromTime.Value >= GRID2.Item(4, i).Value) And (dtpFromTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= GRID2.Item(4, i).Value) And (dtpToTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser2 = cmbempname2.Text Then
                    If (dtpFromTime.Value >= GRID2.Item(4, i).Value) And (dtpFromTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= GRID2.Item(4, i).Value) And (dtpToTime.Value <= GRID2.Item(5, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    End If
                End If


            Next

            'Grid 1
            For i = 0 To grid1.Rows.Count - 1
                StrStation = grid1.Item(1, i).Value
                StrUser1 = grid1.Item(2, i).Value
                StrUser2 = grid1.Item(3, i).Value
                'station validation
                If StrStation = cmbstatype.Text Then

                    If (dtpFromTime.Value >= grid1.Item(5, i).Value) And (dtpFromTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbstatype.Text + " Already Added this Time. Please Check")
                        cmbstatype.Text = ""
                        cmbstatype.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= grid1.Item(5, i).Value) And (dtpToTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbstatype.Text + " Already Added this Time. Please Check")
                        cmbstatype.Text = ""
                        cmbstatype.Focus()
                        Exit Sub
                    End If

                End If

                'User Validation
                If StrUser1 = cmbempname.Text Then
                    If (dtpFromTime.Value >= grid1.Item(5, i).Value) And (dtpFromTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= grid1.Item(5, i).Value) And (dtpToTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser2 = cmbempname.Text Then
                    If (dtpFromTime.Value >= grid1.Item(5, i).Value) And (dtpFromTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= grid1.Item(5, i).Value) And (dtpToTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname.Text + " Already Added this Time. Please Check")
                        cmbempname.Text = ""
                        cmbempname.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser1 = cmbempname2.Text Then
                    If (dtpFromTime.Value >= grid1.Item(5, i).Value) And (dtpFromTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= grid1.Item(5, i).Value) And (dtpToTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    End If


                ElseIf StrUser2 = cmbempname2.Text Then
                    If (dtpFromTime.Value >= grid1.Item(5, i).Value) And (dtpFromTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    ElseIf (dtpToTime.Value >= grid1.Item(5, i).Value) And (dtpToTime.Value <= grid1.Item(6, i).Value) Then
                        MsgBox(cmbempname2.Text + " Already Added this Time. Please Check")
                        cmbempname2.Text = ""
                        cmbempname2.Focus()
                        Exit Sub
                    End If
                End If


            Next

            GRID2.Rows.Add(cmbstatype.Text, cmbempname.Text, cmbempname2.Text, cmbShift.Text, dtpFromTime.Value, dtpToTime.Value, packing_status, RichTextBox1.Text)


            clear()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim strUpdateQry As String = ""
        Dim strInsertQry As String = ""
        Dim From_time, To_time As DateTime

        Try

            For i = 0 To GRID2.Rows.Count - 2
                From_time = GRID2.Item(4, i).Value
                To_time = GRID2.Item(5, i).Value
                strInsertQry = strInsertQry + "('" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(2, i).Value & "','" & GRID2.Item(3, i).Value & "', " & _
                      "'" & From_time.ToString("yyyy-MM-dd HH:mm:ss") & "','" & To_time.ToString("yyyy-MM-dd HH:mm:ss") & "','" & GRID2.Item(6, i).Value & "','" & GRID2.Item(7, i).Value & "', " & _
                      " '" & StrLoginUser & "',GETDATE(),'" & StrLoginUser & "',GETDATE()),"
            Next i

            Sql = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "INSERT Into Reaon_of_Packing (Station, Printed_By, Packed_By, Shift, DateTimeFrom, DateTimeTo, PackingStatus, Reason, Created_by, Created_date, Modified_by, Modified_date )VALUES " & Sql

            If productline = "PMMA" Then
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                'PHILIC
                Dim conStringPhilic As String = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
                Dim conPhilic As SqlConnection
                conPhilic = New SqlConnection(conStringPhilic)
                Try
                    conPhilic.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conPhilic)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                'PHOBIC
                Dim conStringPhobic As String = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
                Dim conPhobic As SqlConnection
                conPhobic = New SqlConnection(conStringPhobic)
                Try
                    conPhobic.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conPhobic)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                'Non Preloaded
                Dim conStringNP As String = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
                Dim conNP As SqlConnection
                conNP = New SqlConnection(conStringNP)
                Try
                    conNP.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conNP)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            MsgBox("Saved ")
            GRID2.ClearSelection()
            GRID2.Rows.Clear()
            LoadGrid()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub grid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim StrStation As String = ""
        Dim StrUser1 As String = ""
        Dim StrUser2 As String = ""
        Dim StrUpdatedStation As String = ""
        Dim StrUpdatedUser1 As String = ""
        Dim StrUpdatedUser2 As String = ""
        Dim fromDate As DateTime
        Dim toDate As DateTime
        Dim id As Integer

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            StrUpdatedStation = grid1.Item(1, e.RowIndex).Value
            StrUpdatedUser1 = grid1.Item(2, e.RowIndex).Value
            StrUpdatedUser2 = grid1.Item(3, e.RowIndex).Value
            fromDate = grid1.Item(5, e.RowIndex).Value
            toDate = grid1.Item(6, e.RowIndex).Value
            id = grid1.Item(0, e.RowIndex).Value
            'validations

            For i = 0 To grid1.Rows.Count - 1
                If i = e.RowIndex Then
                    Continue For
                End If

                StrStation = grid1.Item(1, i).Value
                StrUser1 = grid1.Item(2, i).Value
                StrUser2 = grid1.Item(3, i).Value
                'station validation
                If StrStation = StrUpdatedStation Then

                    If (fromDate >= grid1.Item(5, i).Value) And (fromDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedStation + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    ElseIf (toDate >= grid1.Item(5, i).Value) And (toDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedStation + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    End If

                End If

                'User Validation
                If StrUser1 = StrUpdatedUser1 Then
                    If (fromDate >= grid1.Item(5, i).Value) And (fromDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser1 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    ElseIf (toDate >= grid1.Item(5, i).Value) And (toDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser1 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    End If


                ElseIf StrUser2 = StrUpdatedUser1 Then
                    If (fromDate >= grid1.Item(5, i).Value) And (fromDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser1 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    ElseIf (toDate >= grid1.Item(5, i).Value) And (toDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser1 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    End If


                ElseIf StrUser1 = StrUpdatedUser2 Then
                    If (fromDate >= grid1.Item(5, i).Value) And (fromDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser2 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    ElseIf (toDate >= grid1.Item(5, i).Value) And (toDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser2 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    End If


                ElseIf StrUser2 = StrUpdatedUser2 Then
                    If (fromDate >= grid1.Item(5, i).Value) And (fromDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser2 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    ElseIf (toDate >= grid1.Item(5, i).Value) And (toDate <= grid1.Item(6, i).Value) Then
                        MsgBox(StrUpdatedUser2 + " Already Added this Time. Please Check")
                        LoadGrid()
                        Exit Sub
                    End If
                End If
            Next

            Sql = "UPDATE Reaon_of_Packing " & _
            "SET       DateTimeFrom = '" & fromDate.ToString("yyyy-MM-dd HH:mm:ss") & "', DateTimeTo = '" & toDate.ToString("yyyy-MM-dd HH:mm:ss") & "', " & _
            "Modified_by='" & StrLoginUser & "', Modified_date=GETDATE() " & _
            "WHERE (Station = '" & StrUpdatedStation & "') AND (Printed_By = '" & StrUpdatedUser1 & "') AND (Packed_By = '" & StrUpdatedUser2 & "') " & _
            "AND (id = '" & id & "')  "

            If productline = "PMMA" Then
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                'PHILIC
                Dim conStringPhilic As String = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
                Dim conPhilic As SqlConnection
                conPhilic = New SqlConnection(conStringPhilic)
                Try
                    conPhilic.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conPhilic)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                'PHOBIC
                Dim conStringPhobic As String = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
                Dim conPhobic As SqlConnection
                conPhobic = New SqlConnection(conStringPhobic)
                Try
                    conPhobic.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conPhobic)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                'Non Preloaded
                Dim conStringNP As String = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
                Dim conNP As SqlConnection
                conNP = New SqlConnection(conStringNP)
                Try
                    conNP.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                cmd = New SqlCommand(Sql, conNP)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If
            MsgBox("Updated Sucessfully. ")

            LoadGrid()


        End If

    End Sub

 


End Class