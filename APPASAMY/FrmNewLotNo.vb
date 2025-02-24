Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Text.RegularExpressions



Public Class FrmNewLotNo

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand





    Private Sub FrmNewLotNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            StrSql = "SELECT DISTINCT Type from Lot_Type order by Type"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            CmbType.Items.Clear()
            While StrRs.Read
                CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                ComboType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        

        

    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If CmbType.Text = "" Then
            ErrFrmNewLot.SetError(CmbType, "Choose Type")
            CmbType.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(CmbType, "")
        End If

        If txtCreLotPrefix.Text = "" Then
            ErrFrmNewLot.SetError(txtCreLotPrefix, "Enter Lot No Prefix")
            txtCreLotPrefix.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(txtCreLotPrefix, "")
        End If

        If txtCrlotNo.Text = "" Then
            ErrFrmNewLot.SetError(txtCrlotNo, "Enter Lot No ")
            txtCrlotNo.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(txtCrlotNo, "")
        End If

        'KPMG ----------

        If CmbType.SelectedItem Is Nothing Then
            ErrFrmNewLot.SetError(CmbType, "Choose Type")
            CmbType.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(CmbType, "")
        End If

        Dim PrefixRegex As New Regex("^[a-zA-Z0-9]+$")
        If Not PrefixRegex.IsMatch(txtCreLotPrefix.Text.Trim()) Then
            MessageBox.Show("Lot Prefix should only contain alphanumeric characters (letters and digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim numericRgx As New Regex("^\d+$")
        If Not numericRgx.IsMatch(txtCrlotNo.Text.Trim()) Then
            MessageBox.Show("Lot Number should only contain numeric characters (digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not numericRgx.IsMatch(txtcrMaxQty.Text.Trim()) Then
            MessageBox.Show("Max Quantity should only contain numeric characters (digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'KPMG

        Try
            If BtnSave.Text = "Open" Then

                StrSql = "SELECT Lot_Prefix, Lot_No FROM LENS_LOT WHERE Lot_Prefix = @LotPrefix AND Lot_No = @LotNo"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)

                StrRs = Cmd.ExecuteReader()
                If StrRs.Read() Then
                    MsgBox("Lot Already Exists")
                    StrRs.Close()
                Else
                    StrRs.Close()

                    ' Insert New Lot
                    StrSql = "INSERT INTO LENS_LOT (Lot_Prefix, Lot_No, Max_Qty, Printed_Qty, Active, Created_By, Created_Date, Modified_By, Modified_Date, Type) " & _
                             "VALUES (@LotPrefix, @LotNo, @MaxQty, 0, 'YES', @CreatedBy, GETDATE(), @ModifiedBy, GETDATE(), @Type)"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                    Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)
                    Cmd.Parameters.AddWithValue("@MaxQty", txtcrMaxQty.Text)
                    Cmd.Parameters.AddWithValue("@CreatedBy", StrLoginUser)
                    Cmd.Parameters.AddWithValue("@ModifiedBy", StrLoginUser)
                    Cmd.Parameters.AddWithValue("@Type", CmbType.Text)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()

                    MsgBox("Open Successfully")

                    ' Retrieve Active Lots
                    StrSql = "SELECT * FROM LENS_LOT WHERE Active = 'YES' AND Type = @Type"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.Parameters.AddWithValue("@Type", CmbType.Text)

                    StrRs = Cmd.ExecuteReader()
                    If StrRs.Read() Then
                        txtCreLotPrefix.Text = If(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                        txtCrlotNo.Text = If(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                        BtnSave.Text = "Close"
                        txtCreLotPrefix.Enabled = False
                        txtCrlotNo.Enabled = False
                    Else
                        txtCrlotNo.Text = "0001"
                        BtnSave.Text = "Open"
                    End If
                    StrRs.Close()
                    Cmd.Dispose()
                End If

            ElseIf BtnSave.Text = "Close" Then

                If MsgBox("Are You Want Close This Lot", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    '-----
                    ' Retrieve Lot Details
                    StrSql = "SELECT * FROM LENS_LOT WHERE Type = @Type AND Lot_Prefix = @LotPrefix AND Lot_No = @LotNo"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.Parameters.AddWithValue("@Type", CmbType.Text)
                    Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                    Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)

                    StrRs = Cmd.ExecuteReader()
                    If StrRs.Read() Then
                        If Val(StrRs("Printed_Qty")) < 1 Then
                            StrRs.Close()

                            ' Delete Lot if Printed_Qty < 1
                            StrSql = "DELETE FROM LENS_LOT WHERE Type = @Type AND Lot_Prefix = @LotPrefix AND Lot_No = @LotNo"
                            Cmd = New SqlCommand(StrSql, con)
                            Cmd.Parameters.AddWithValue("@Type", CmbType.Text)
                            Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                            Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)
                            Cmd.ExecuteNonQuery()
                            Cmd.Dispose()

                            BtnSave.Text = "Open"
                            txtCreLotPrefix.Enabled = True
                            txtCrlotNo.Enabled = True
                        Else
                            StrRs.Close()

                            ' Update Lot to set Active = 'NO'
                            StrSql = "UPDATE LENS_LOT SET Active = 'NO' WHERE Type = @Type AND Lot_Prefix = @LotPrefix AND Lot_No = @LotNo"
                            Cmd = New SqlCommand(StrSql, con)
                            Cmd.Parameters.AddWithValue("@Type", CmbType.Text)
                            Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                            Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)
                            Cmd.ExecuteNonQuery()
                            Cmd.Dispose()

                            ' Update Lot to set Modified_By and Modified_Date
                            StrSql = "UPDATE LENS_LOT SET Active = 'NO', Modified_By = @ModifiedBy, Modified_Date = GETDATE() " & _
                                     "WHERE Lot_Prefix = @LotPrefix AND Lot_No = @LotNo AND Type = @Type"
                            Cmd = New SqlCommand(StrSql, con)
                            Cmd.Parameters.AddWithValue("@Type", CmbType.Text)
                            Cmd.Parameters.AddWithValue("@LotPrefix", txtCreLotPrefix.Text)
                            Cmd.Parameters.AddWithValue("@LotNo", txtCrlotNo.Text)
                            Cmd.Parameters.AddWithValue("@ModifiedBy", StrLoginUser)
                            Cmd.ExecuteNonQuery()
                            Cmd.Dispose()

                            BtnSave.Text = "Open"
                            txtCreLotPrefix.Enabled = True
                            txtCrlotNo.Enabled = True
                        End If
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, Button1.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged




        StrSql = "Select * from LENS_LOT where Active='YES' and Type=@Type"
        Cmd = New SqlCommand(StrSql, con)
        Cmd.Parameters.AddWithValue("@Type", CmbType.Text)

        StrRs = Cmd.ExecuteReader()
        If StrRs.Read Then
            txtCreLotPrefix.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            txtCrlotNo.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            txtcrMaxQty.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
            BtnSave.Text = "Close"
            txtCreLotPrefix.Enabled = False
            txtCrlotNo.Enabled = False
        Else
            txtCreLotPrefix.Text = ""
            txtCrlotNo.Text = ""
            txtcrMaxQty.Text = ""
            txtCrlotNo.Text = "0001"
            BtnSave.Text = "Open"
            txtCreLotPrefix.Enabled = True
            txtCrlotNo.Enabled = True
        End If
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub rdLot_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLot.CheckedChanged
        If rdLot.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
            rdBatch.Checked = False
        End If
    End Sub

    Private Sub rdBatch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdBatch.CheckedChanged
        If rdBatch.Checked = True Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
            rdLot.Checked = False
        End If
    End Sub

    Private Sub ComboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboType.SelectedIndexChanged
        StrSql = "Select * from LENS_BATCH where Active='YES' and Type=@Type"
        Cmd = New SqlCommand(StrSql, con)
        Cmd.Parameters.AddWithValue("@Type", ComboType.Text)
        StrRs = Cmd.ExecuteReader()
        If StrRs.Read Then

            txt_SterileBatch.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            txtMaxBatch.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
            Button2.Text = "Close"
        Else
            txt_SterileBatch.Text = ""
            txtMaxBatch.Text = ""
            Button2.Text = "Open"
        End If
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txt_SterileBatch.Text = "" Then
            ErrFrmNewLot.SetError(txt_SterileBatch, "Enter Batch Number")
            txt_SterileBatch.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(txt_SterileBatch, "")
        End If


        'KPMG ----------

        If ComboType.SelectedItem Is Nothing Then
            ErrFrmNewLot.SetError(ComboType, "Choose Type")
            ComboType.Focus()
            Exit Sub
        Else
            ErrFrmNewLot.SetError(ComboType, "")
        End If

        Dim SterileRegex As New Regex("^[a-zA-Z0-9\-]+$")
        If Not SterileRegex.IsMatch(txt_SterileBatch.Text.Trim()) Then
            MessageBox.Show("Sterile Batch should only contain alphanumeric characters (hyphen,letters and digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim numericRgx As New Regex("^\d+$")
        If Not numericRgx.IsMatch(txtCrlotNo.Text.Trim()) Then
            MessageBox.Show("Max.Qty should only contain numeric characters (digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        'KPMG


        If Button2.Text = "Open" Then
            StrSql = "SELECT btc_no FROM LENS_BATCH WHERE btc_no = @BatchNo"
            Cmd = New SqlCommand(StrSql, con)
            Cmd.Parameters.AddWithValue("@BatchNo", txt_SterileBatch.Text)

            StrRs = Cmd.ExecuteReader()
            If StrRs.Read() Then
                MsgBox("Batch Already Exists")
                StrRs.Close()
            Else
                StrRs.Close()

                ' Insert a new batch
                StrSql = "INSERT INTO LENS_BATCH (btc_no, Max_Qty, Printed_qty, Active, Created_By, Created_Date, Modified_By, Modified_Date, Type) " & _
                         "VALUES (@BatchNo, @MaxQty, 0, 'YES', @CreatedBy, GETDATE(), @ModifiedBy, GETDATE(), @Type)"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.Parameters.AddWithValue("@BatchNo", txt_SterileBatch.Text)
                Cmd.Parameters.AddWithValue("@MaxQty", txtMaxBatch.Text)
                Cmd.Parameters.AddWithValue("@CreatedBy", StrLoginUser)
                Cmd.Parameters.AddWithValue("@ModifiedBy", StrLoginUser)
                Cmd.Parameters.AddWithValue("@Type", ComboType.Text)

                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                MsgBox("Open Successfully")

                ' Retrieve active batch of the given type
                StrSql = "SELECT * FROM LENS_BATCH WHERE Active = 'YES' AND Type = @Type"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.Parameters.AddWithValue("@Type", ComboType.Text)

                StrRs = Cmd.ExecuteReader()
                If StrRs.Read() Then
                    txt_SterileBatch.Text = If(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    Button2.Text = "Close"
                Else
                    Button2.Text = "Open"
                End If
                StrRs.Close()
                Cmd.Dispose()
            End If
        ElseIf Button2.Text = "Close" Then

            If MsgBox("Are You Want Close This Batch", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                StrSql = "UPDATE LENS_BATCH SET Active = 'NO', Modified_By = @ModifiedBy, Modified_Date = GETDATE() WHERE btc_no = @BatchNo AND Type = @Type"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.Parameters.AddWithValue("@ModifiedBy", StrLoginUser)
                Cmd.Parameters.AddWithValue("@BatchNo", txt_SterileBatch.Text)
                Cmd.Parameters.AddWithValue("@Type", ComboType.Text)

                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                Button2.Text = "Open"

            End If

        End If
    End Sub
End Class