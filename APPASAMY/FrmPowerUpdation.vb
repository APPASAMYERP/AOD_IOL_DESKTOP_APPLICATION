
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPowerUpdation

    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim dt As DataTable
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim StrBrandName As String
    Dim StrMdlName As String
    Dim StrLotPower As String


    Private Sub lotsrno_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotsrno.KeyDown
        If (txtlotsrno.Text <> "") Then

            If e.KeyCode = Keys.Enter Then

                Sql = "select Brand_Name, Model_Name,Power from POUCH_LABEL where Lot_SrNo='" & txtlotsrno.Text & "'"
                cmd = New SqlCommand(Sql, con)
                'con.Open()
                read = cmd.ExecuteReader
                If read.Read Then
                    StrBrandName = IIf(IsDBNull(read.GetValue(0)), "", read.GetValue(0))
                    StrMdlName = IIf(IsDBNull(read.GetValue(1)), "", read.GetValue(1))
                    StrLotPower = IIf(IsDBNull(read.GetValue(2)), 0, read.GetValue(2))
                    txtBrand.Text = StrBrandName
                    txtModel.Text = StrMdlName
                    txtoldpower.Text = StrLotPower
                End If
                read.Close()
                cmd.Dispose()

                Sql = "Select Distinct Cast(Power as decimal(18,2)),GS_Code from LENS_MASTER where Brand_Name='" & txtBrand.Text & "' and Model_Name='" & txtModel.Text & "'"
                cmd = New SqlCommand(Sql, con)
                read = cmd.ExecuteReader
                While read.Read()
                    cmbnewpower.Items.Add(read.GetValue(0))
                End While
                read.Close()
                cmd.Dispose()
            End If
            'MessageBox.Show("Enter Correct Lot Srno")
        End If
    End Sub

    Private Sub cmbnewpower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnewpower.SelectedIndexChanged
        lblgscode.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (cmbnewpower.Text <> "" And ComboBox1.Text <> "" And lblgscode.Text <> "") Then
            Sql = "Update POUCH_LABEL set Power='" & cmbnewpower.Text & "', GS_Code='" & lblgscode.Text & "' Where Lot_SrNo='" & txtlotsrno.Text & "'"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            'con.Close()
            MessageBox.Show("Updated")
            clear()
        Else
            MessageBox.Show("Invalid Input")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (cmbnewpower.Text <> "" And ComboBox1.Text <> "") Then
            Sql = "Select Distinct GS_Code from LENS_MASTER where Brand_Name='" & txtBrand.Text & "' and Model_Name='" & txtModel.Text & "' and Power='" & cmbnewpower.Text & "' and Type_GS_Code='" & ComboBox1.Text & "'"
            cmd = New SqlCommand(Sql, con)
            read = cmd.ExecuteReader
            If (read.Read) Then
                lblgscode.Text = read.GetValue(0)
            Else
                lblgscode.Text = ""
            End If
            read.Close()
            cmd.Dispose()
        Else
            MessageBox.Show("Invalid Input")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub
    Private Sub clear()
        txtlotsrno.Text = ""
        txtBrand.Text = ""
        txtModel.Text = ""
        txtoldpower.Text = ""
        cmbnewpower.Items.Clear()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("AI")
        ComboBox1.Items.Add("AOD")
        lblgscode.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class