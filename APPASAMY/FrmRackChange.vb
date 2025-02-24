Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmRackChange

    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

    Private Sub btnComplete_trayBased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete_trayBased.Click
        Try
            Dim strInsertQry As String = ""

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

            If cmbrackLocation.SelectedItem Is Nothing Then
                err.SetError(cmbrackLocation, "Please Select valid Rack Location To")
                cmbrackLocation.Focus()
                Exit Sub
            Else
                err.SetError(cmbrackLocation, "")
            End If

            If cmbrackLocation.Text = "" Then
                err.SetError(cmbrackLocation, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbrackLocation, "")
            End If


            ' Create TrayRack_Movement
            Sql = "SELECT Tray_No,Rack_Location, Sum(Qty_1) as Total from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayNo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No,Rack_Location"
            Ds = getTotalCountOfTray(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                strInsertQry = strInsertQry + "('" + eachRow1("Tray_No") + "','" + eachRow1("Tray_No") + "','" + eachRow1("Rack_Location") + "','" + cmbrackLocation.Text + "','" + eachRow1("Total").ToString() + "','" + StrLoginUser + "', GETDATE(),'0'),"
            Next
            strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "Insert into TrayRack_Movement (Tray_From, Tray_To, Rack_From, Rack_To, Qty, Created_By, Created_Date, Tray_label_updated) VALUES " & strInsertQry
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            Sql = "Update POUCH_LABEL set Rack_Location='" & cmbrackLocation.Text & "' where Tray_No='" & cmbTrayNo.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0 AND (Areation_Status = 1)"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Saved ")
            cmbTrayNo.Text = ""
            cmbrackLocation.Text = ""
            GRID2.DataSource = Nothing
            'LoadRackAndTray()
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

    Private Sub BtnComplete_rackBased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete_rackBased.Click

        Try
            Dim strInsertQry As String = ""

            If cmbRackFrom.SelectedItem Is Nothing Then
                err.SetError(cmbRackFrom, "Please Select valid Rack From")
                cmbRackFrom.Focus()
                Exit Sub
            Else
                err.SetError(cmbRackFrom, "")
            End If

            If cmbRackFrom.Text = "" Then
                err.SetError(cmbRackFrom, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbRackFrom, "")
            End If

            If cmbRackTo.SelectedItem Is Nothing Then
                err.SetError(cmbRackTo, "Please Select valid Rack To")
                cmbRackTo.Focus()
                Exit Sub
            Else
                err.SetError(cmbRackTo, "")
            End If

            If cmbRackTo.Text = "" Then
                err.SetError(cmbRackTo, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbRackTo, "")
            End If

            If cmbRackTo.Text = cmbRackFrom.Text Then
                MessageBox.Show("Rack From & Rack To same. Please chesk")
                Exit Sub
            End If


            ' Create TrayRack_Movement
            Sql = "SELECT Tray_No,Rack_Location, Sum(Qty_1) as Total from POUCH_LABEL  WHERE  Rack_Location='" & cmbRackFrom.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No,Rack_Location"
            Ds = getTotalCountOfTray(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                strInsertQry = strInsertQry + "('" + eachRow1("Tray_No") + "','" + eachRow1("Tray_No") + "','" + eachRow1("Rack_Location") + "','" + cmbRackTo.Text + "','" + eachRow1("Total").ToString() + "','" + StrLoginUser + "', GETDATE(),'0'),"
            Next

            strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            Sql = "Insert into TrayRack_Movement (Tray_From, Tray_To, Rack_From, Rack_To, Qty, Created_By, Created_Date, Tray_label_updated) VALUES " & strInsertQry
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            Sql = "Update POUCH_LABEL set Rack_Location='" & cmbRackTo.Text & "' where Rack_Location='" & cmbRackFrom.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 AND Sterilization_Reject = 0 AND (Areation_Status = 1)"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Saved ")
            cmbRackFrom.Text = ""
            cmbRackTo.Text = ""
            GRID1.DataSource = Nothing
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbRackFrom.Text = ""
        cmbRackTo.Text = ""
        GRID1.DataSource = Nothing
        toLocationGRID1.DataSource = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Public Function getDistinctTrayNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE   (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getDistinctRackLocation() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Rack_Location AS rack_location from POUCH_LABEL  WHERE   (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Rack_Location"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getAvailableRackLocation() As DataSet

        Dim ds, ds1 As New DataSet
        Dim StrSql As String = ""
        'Dim distinctRack As String = ""
        'Dim StrSql As String = "SELECT DISTINCT Rack_Location from POUCH_LABEL  WHERE    (Rack_Location IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0)"
        'Dim Cmd As New SqlCommand(StrSql, con)
        'Dim ad As New SqlDataAdapter(Cmd)
        'ad.Fill(ds)

        'For Each row As DataRow In ds.Tables(0).Rows
        '    distinctRack = distinctRack + "'" + row("Rack_Location") + "',"
        'Next

        'distinctRack = distinctRack.Remove(distinctRack.ToString().Length - 1, 1)


        StrSql = "SELECT DISTINCT RackId FROM  Rack_Master  Order by RackId"
        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(ds1)
        Return ds1

    End Function

    Public Sub LoadRackAndTray()
        'tray No load
        Ds = getDistinctTrayNumber()
        cmbTrayNo.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbTrayNo.Items.Add(eachRow1("tray_no"))
        Next

        Ds = getDistinctRackLocation()
        cmbRackFrom.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbRackFrom.Items.Add(eachRow1("rack_location"))
        Next

        ' Available rack Location Load
        Ds = getAvailableRackLocation()
        cmbRackTo.Items.Clear()
        cmbrackLocation.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbRackTo.Items.Add(eachRow1("RackId"))
            cmbrackLocation.Items.Add(eachRow1("RackId"))
        Next

    End Sub

    Private Sub FrmRackChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadRackAndTray()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        cmbTrayNo.Text = ""
        cmbrackLocation.Text = ""
        GRID2.DataSource = Nothing
        toLocationGRID2.DataSource = Nothing
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub rdRackBased_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdRackBased.CheckedChanged

        If rdRackBased.Checked = True Then
            GroupBox9.Visible = True
            GroupBox5.Visible = False
        Else
            GroupBox9.Visible = False
            GroupBox5.Visible = True
        End If

    End Sub

    Private Sub cmbRackFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRackFrom.SelectedIndexChanged
        Try
            Sql = "SELECT Tray_No, Sum(Qty_1) as Qty from POUCH_LABEL  WHERE  Rack_Location='" & cmbRackFrom.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No Order By Tray_No"
            Ds = getTotalCountOfTray(Sql)
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
        GRID1.DataSource = Ds.Tables(0)

    End Sub

    Private Sub cmbTrayNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrayNo.SelectedIndexChanged
        Try
            Sql = "SELECT Rack_Location, Sum(Qty_1) as Qty from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayNo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Rack_Location Order By Rack_Location"
            Ds = getTotalCountOfTray(Sql)
            GRID2.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Private Sub cmbRackTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRackTo.SelectedIndexChanged
        Try
            Sql = "SELECT Tray_No, Sum(Qty_1) as Qty from POUCH_LABEL  WHERE  Rack_Location='" & cmbRackTo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No Order By Tray_No"
            Ds = getTotalCountOfTray(Sql)
            toLocationGRID1.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub cmbrackLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbrackLocation.SelectedIndexChanged
        Try
            Sql = "SELECT Tray_No, Sum(Qty_1) as Qty from POUCH_LABEL  WHERE  Rack_Location='" & cmbRackTo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No Order By Tray_No"
            Ds = getTotalCountOfTray(Sql)
            toLocationGRID2.DataSource = Ds.Tables(0)
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