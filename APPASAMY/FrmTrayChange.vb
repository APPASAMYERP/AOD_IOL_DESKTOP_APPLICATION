Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmTrayChange
    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

    Public Function getDistinctTrayNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE   (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub FrmTrayChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            table.Columns.Add("Lot_Srl_No", GetType(String))
            table.Columns.Add("Tray_No", GetType(String))
            table.Columns.Add("Rack_Location", GetType(String))
            GRID2.DataSource = table

            With GRID2.ColumnHeadersDefaultCellStyle
                .Alignment = DataGridViewContentAlignment.TopRight
                .BackColor = Color.DarkRed
                .ForeColor = Color.Gold
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                 .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With

            Ds = getDistinctTrayNumber()
            cmbTrayNo.Items.Clear()
            cmbTrayFrom_TrayBased.Items.Clear()
            cmbTrayTo_TrayBased.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbTrayNo.Items.Add(eachRow1("tray_no"))
                cmbTrayFrom_TrayBased.Items.Add(eachRow1("tray_no"))
                cmbTrayTo_TrayBased.Items.Add(eachRow1("tray_no"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim StrGrLot As String


            If txtlotbarno.Text <> "" Then
                Try

                    StrLorBarNo = UCase(Trim(txtlotbarno.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "select Lot_Prefix,Lot_No,Lot_SrNo,Tray_No, Rack_Location from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0 AND (Areation_Status = 1)"
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select Lot_Prefix,Lot_No,Lot_SrNo,Tray_No, Rack_Location from POUCH_LABEL where Udi_code='" & txtlotbarno.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0 AND (Areation_Status = 1) "

                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If


                    cmd = New SqlCommand(Sql, con)
                    Dr = cmd.ExecuteReader
                    If Dr.Read Then
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
                        table.Rows.Add(Dr("Lot_SrNo"), Dr("Tray_No"), Dr("Rack_Location"))
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

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        GRID2.ClearSelection()
        table.Clear()
        table.Dispose()
        table.Columns.Clear()
        lblcount.Text = table.Rows.Count.ToString()

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Tray_No", GetType(String))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub
    'Exit button Tray based
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        Try
            Dim strInsertQry As String = ""
            Dim to_rack As String = ""
            Dim strLotSerials As String = ""
            'Validations

            If cmbTrayNo.SelectedItem Is Nothing Then
                err.SetError(cmbTrayNo, "Please Select valid Tray No")
                cmbTrayNo.Focus()
                Exit Sub
            Else
                err.SetError(cmbTrayNo, "")
            End If

            If cmbTrayNo.Text = "" Then
                err.SetError(cmbTrayNo, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbTrayNo, "")
            End If
            If GRID2.Rows.Count > 1 Then
            Else
                MsgBox("Please Add minimum 1 Serial Number.")
                Exit Sub
            End If

            'Dim strUpdateQry As String = ""
            For i = 0 To GRID2.Rows.Count - 2
                Dim Sql As String
                strLotSerials = strLotSerials + "'" + GRID2.Rows(i).Cells("Lot_Srl_No").Value.ToString() + "',"
            Next i

            If strLotSerials = "" Then
                strLotSerials = "''"
            Else
                strLotSerials = strLotSerials.Remove(strLotSerials.Length - 1, 1)
            End If


            Sql = "SELECT Tray_No, Rack_Location, Sum(Qty_1) as Total from POUCH_LABEL  WHERE   Lot_SrNo IN (" & strLotSerials & ") and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No, Rack_Location"
            Ds = getTotalCountOfTray(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                strInsertQry = strInsertQry + "('" + eachRow1("Tray_No") + "','" + cmbTrayNo.Text + "','" + eachRow1("Rack_Location") + "','" + eachRow1("Rack_Location") + "','" + eachRow1("Total").ToString() + "','" + StrLoginUser + "', GETDATE(), '0'),"
            Next
            strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "Insert into TrayRack_Movement (Tray_From, Tray_To,Rack_From, Rack_To, Qty, Created_By, Created_Date, Tray_label_updated) VALUES " & strInsertQry
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            ' Get Rack Location of destination tary
            Sql = "SELECT DISTINCT Rack_Location FROM         POUCH_LABEL  WHERE  Tray_No='" & cmbTrayNo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  "
            Ds = getTotalCountOfTray(Sql)
            If Ds.Tables(0).Rows.Count = 1 Then
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    to_rack = eachRow1("Rack_Location")
                Next
            Else
                MsgBox("More than One Rack Location is present, or No Rack Location Updated. Please Check")
                Exit Sub
            End If


            Sql = "Update POUCH_LABEL set Tray_No='" & cmbTrayNo.Text & "', Rack_Location ='" & to_rack & "'  where Lot_SrNo IN (" & strLotSerials & ")"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()



            MsgBox("Saved ")


            toTrayGRID2.DataSource = Nothing
            lblToTrayCount.Text = 0

            GRID2.ClearSelection()
            table.Clear()
            table.Dispose()
            table.Columns.Clear()
            lblcount.Text = table.Rows.Count.ToString()
            cmbTrayNo.Text = ""


            table.Columns.Add("Lot_Srl_No", GetType(String))
            table.Columns.Add("Tray_No", GetType(String))
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

    Public Function getTotalCountOfTray(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub btnComplete_trayBased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete_trayBased.Click

        Try
            Dim strInsertQry As String = ""
            Dim to_rack As String = ""


            If cmbTrayFrom_TrayBased.SelectedItem Is Nothing Then
                err.SetError(cmbTrayFrom_TrayBased, "Please Select valid Tray From")
                cmbTrayFrom_TrayBased.Focus()
                Exit Sub
            Else
                err.SetError(cmbTrayFrom_TrayBased, "")
            End If

            If cmbTrayFrom_TrayBased.Text = "" Then
                err.SetError(cmbTrayFrom_TrayBased, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbTrayFrom_TrayBased, "")
            End If

            If cmbTrayTo_TrayBased.SelectedItem Is Nothing Then
                err.SetError(cmbTrayTo_TrayBased, "Please Select valid Tray To")
                cmbTrayTo_TrayBased.Focus()
                Exit Sub
            Else
                err.SetError(cmbTrayTo_TrayBased, "")
            End If

            If cmbTrayTo_TrayBased.Text = "" Then
                err.SetError(cmbTrayTo_TrayBased, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbTrayTo_TrayBased, "")
            End If

            If cmbTrayFrom_TrayBased.Text = cmbTrayTo_TrayBased.Text Then
                MessageBox.Show("Tray From & Tray To same. Please chesk")
                Exit Sub
            End If

            ' Create TrayRack_Movement
            Sql = "SELECT Tray_No,Rack_Location, Sum(Qty_1) as Total from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayFrom_TrayBased.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No,Rack_Location"
            Ds = getTotalCountOfTray(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                strInsertQry = strInsertQry + "('" + eachRow1("Tray_No") + "','" + cmbTrayTo_TrayBased.Text + "','" + eachRow1("Rack_Location") + "','" + eachRow1("Rack_Location") + "','" + eachRow1("Total").ToString() + "','" + StrLoginUser + "', GETDATE(), '0'),"
            Next
            strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "Insert into TrayRack_Movement (Tray_From, Tray_To, Rack_From, Rack_To, Qty, Created_By, Created_Date, Tray_label_updated) VALUES " & strInsertQry
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            ' Get Rack Location of destination tray
            Sql = "SELECT DISTINCT Rack_Location FROM         POUCH_LABEL  WHERE  Tray_No='" & cmbTrayTo_TrayBased.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  "
            Ds = getTotalCountOfTray(Sql)
            If Ds.Tables(0).Rows.Count = 1 Then
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    to_rack = eachRow1("Rack_Location")
                Next
            Else
                MsgBox("More than One Rack Location is present (or) No Rack Location Updated. Please Check")
                Exit Sub
            End If




            Sql = "Update POUCH_LABEL set Tray_No='" & cmbTrayTo_TrayBased.Text & "', Rack_Location ='" & to_rack & "'  where Tray_No='" & cmbTrayFrom_TrayBased.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0 AND (Areation_Status = 1)"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            MsgBox("Saved ")
            cmbTrayFrom_TrayBased.Text = ""
            cmbTrayTo_TrayBased.Text = ""
            GRID1.DataSource = Nothing
            lblcount1.Text = 0
            toTrayGRID1.DataSource = Nothing
            lbltoTrayCount1.Text = 0
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub rdTrayBased_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdTrayBased.CheckedChanged
        Try
            If rdTrayBased.Checked = True Then
                GroupBox9.Visible = True
                GroupBox5.Visible = False
            Else
                GroupBox9.Visible = False
                GroupBox5.Visible = True
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbTrayFrom_TrayBased.Text = ""
        cmbTrayTo_TrayBased.Text = ""
        GRID1.DataSource = Nothing
        lblcount1.Text = 0
        toTrayGRID1.DataSource = Nothing
        lbltoTrayCount1.Text = 0
    End Sub

    Private Sub cmbTrayFrom_TrayBased_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrayFrom_TrayBased.SelectedIndexChanged
        Try
            Sql = "SELECT Lot_SrNO, Tray_No, Rack_Location from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayFrom_TrayBased.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Lot_SrNo "
            Ds = getTotalCountOfTray(Sql)
            GRID1.DataSource = Ds.Tables(0)
            lblcount1.Text = Ds.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub cmbTrayTo_TrayBased_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrayTo_TrayBased.SelectedIndexChanged
        Try
            Sql = "SELECT Lot_SrNO, Tray_No, Rack_Location   from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayTo_TrayBased.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  Order By Lot_SrNo "
            Ds = getTotalCountOfTray(Sql)
            toTrayGRID1.DataSource = Ds.Tables(0)
            lbltoTrayCount1.Text = Ds.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub cmbTrayNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrayNo.SelectedIndexChanged
        Try
            Sql = "SELECT Lot_SrNO, Tray_No, Rack_Location   from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayNo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  Order By Lot_SrNo "
            Ds = getTotalCountOfTray(Sql)
            toTrayGRID2.DataSource = Ds.Tables(0)
            lblToTrayCount.Text = Ds.Tables(0).Rows.Count
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
End Class