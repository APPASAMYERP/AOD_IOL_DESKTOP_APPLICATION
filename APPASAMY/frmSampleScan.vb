


Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls


Public Class frmSampleScan
    Dim StrRs, StrRs1, StrRsSeHd, StrRsSeDt As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql, StrSql1, Str_Header, StrUniqueNo, StrSqlSeHd, Str_Detail, StrSqlSeDt As String
    Dim lotsrno As String = ""
    Dim Ds1 As New DataSet
    Dim Sql1 As String
    Dim Ds As New DataSet
    Dim Dr, Dr1 As SqlDataReader
    Dim Sql As String
    Dim DtRow As DataRow
    Dim cmd1 As SqlCommand
    Dim table, table1 As New DataTable
    Dim StrLorBarNo As String
    Private Sub frmSampleScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Public Sub LoadForm()


        LoadSampleType()

        loadTable()

    End Sub
    Public Sub LoadSampleType()
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        StrSql = "SELECT DISTINCT  SAMPLE_TYPE from Sample_Master  order by  SAMPLE_TYPE"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        drop_sampletype.Items.Clear()
        While StrRs.Read

            drop_sampletype.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

    End Sub
    Private Sub loadTable()
        table.Columns.Add("Model_Name", GetType(String))
        table.Columns.Add("Btc_no", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("Lot_srno", GetType(String))
        DataGridView1.DataSource = table

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
    End Sub

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Private Sub txt_lotscan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lotscan.KeyDown
        Dim StrGrLot As String
        If e.KeyCode = Keys.Enter Then

            If txt_lotscan.Text <> "" Then
                Try

                    

                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If

                    Try
                        con.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    StrLorBarNo = UCase(Trim(txt_lotscan.Text))

                    If rdUDICode.Checked = True Then
                        Sql = "select  Model_Name,Btc_no,Power,Lot_srno from pouch_label where Udi_Code='" & txt_lotscan.Text & "'  and  (BPL_Taken = 0) AND (BPL_NO IS NULL) AND (Sample_Taken = 0) AND (Box_Packing = 0) AND (Box_Reject = 0) AND (Sterilization_Reject = 0) and (Udi_code IS NOT NULL)  "
                    ElseIf rdLotSerial.Checked = True Then
                        Sql = "select  Model_Name,Btc_no,Power,Lot_srno from pouch_label where Lot_Srno='" & txt_lotscan.Text & "'  and  (BPL_Taken = 0) AND (BPL_NO IS NULL) AND (Sample_Taken = 0) AND (Box_Packing = 0) AND (Box_Reject = 0) AND (Sterilization_Reject = 0)   "
                    End If
                    Cmd = New SqlCommand(Sql, con)
                    Dr = Cmd.ExecuteReader()
                    If Dr.Read Then
                        '  If cmbbtc.Text = Dr("Btc_no") Then
                        For i = 0 To DataGridView1.Rows.Count - 2
                            StrGrLot = ""
                            StrGrLot = DataGridView1.Item(3, i).Value
                            If StrGrLot = Dr("Lot_srno") Then
                                MsgBox("Already Scan")
                                txt_lotscan.Text = ""
                                txt_lotscan.Focus()
                                i = DataGridView1.Rows.Count - 2
                                Dr.Close()
                                Exit Sub
                            End If
                        Next
                        DtRow = table.NewRow
                        table.Rows.Add(Dr("Model_Name"), Dr("Btc_no"), Dr("Power"), Dr("Lot_srno"))
                        Dr.Close()
                        Cmd.Dispose()
                        lens_count.Text = table.Rows.Count.ToString()
                        'Else
                        '    MsgBox("Batch does not match")
                        'End If

                    Else
                        MsgBox("Scan Correct Lot Sr No")
                        Dr.Close()
                        Cmd.Dispose()
                        txt_lotscan.Text = ""
                        txt_lotscan.Focus()
                    End If

                    Dr.Close()
                    Cmd.Dispose()

                    lens_count.Text = table.Rows.Count.ToString()
                    txt_lotscan.Text = ""
                    txt_lotscan.Focus()

                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try
                


            End If


        End If
    End Sub

    Private Sub btc_comple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btc_comple.Click

        Try
            If drop_sampletype.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Sample Type")
                drop_sampletype.Focus()
                Exit Sub
            End If

            If drop_sampletype.Text = "" Then
                MsgBox("Please Chosse Sample Type ")
                Exit Sub
            End If
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from DC_SOFT"
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

            StrUniqueNo = "DC/D/" & Str_Header


            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Str_Detail = 0
            StrSqlSeDt = "Select Max(Detail_ID) from DC_SOFT"
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
            'lotsrno = ""

            For i = 0 To DataGridView1.Rows.Count - 2
                lotsrno = DataGridView1.Rows(i).Cells("Lot_srno").Value.ToString()
                StrSql = "Update POUCH_LABEL set Dc_No= '" & StrUniqueNo & "' , Dc_Packing=1,Sample_Taken=1, Type_Sample='" & drop_sampletype.Text & "'  where Lot_srno = '" & lotsrno & "' and  (BPL_Taken = 0) AND (BPL_NO IS NULL) AND (Sample_Taken = 0) AND (Box_Packing = 0) AND (Box_Reject = 0) AND (Sterilization_Reject = 0) and (Udi_code IS NOT NULL)  "
                Ds1 = SQL_SelectQuery_Execute(StrSql)

            Next
            UpdateDc()

            MessageBox.Show("Sample updated Successfully...!!")
            DataGridView1.DataSource = Nothing
            'LoadForm()
            drop_sampletype.Text = ""
            cmb_remark.Text = ""
            'cmbbtc.Text = ""
            txt_lotscan.Text = ""
            txt_lotscan.Focus()

            DataGridView1.ClearSelection()
            table.Clear()
            table.Dispose()
            table.Columns.Clear()
            lens_count.Text = table.Rows.Count.ToString()
            loadTable()


        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Public Sub UpdateDc()

        StrSql = "Insert Into DC_SOFT ( Header_ID,Detail_ID,Dc_No,Remarks,Created_By,Created_Date,DC_Comp,IndentNo) values ( " & _
                                    "'" & Str_Header & "','" & Str_Detail & "','" & StrUniqueNo & "','" & cmb_remark.Text & "', " & _
                                    "'" & StrLoginUser & "',GETDATE(),'1','" & drop_sampletype.Text & "')"

        UpdateorInsertQuery_Execute(StrSql)

    End Sub
    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DataGridView1.ClearSelection()
        table.Clear()
        table.Dispose()
        table.Columns.Clear()
        lens_count.Text = table.Rows.Count.ToString()
        txt_lotscan.Text = ""
        txt_lotscan.Focus()
        cmb_remark.Text = ""
        'cmbbtc.Text = ""
        loadTable()
    End Sub
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

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

   
    Private Sub drop_sampletype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drop_sampletype.SelectedIndexChanged

        If drop_sampletype.Text = "OTHER SAMPLE" Then
            lbl_reason.Visible = True
            cmb_remark.Visible = True
        Else
            lbl_reason.Visible = False
            cmb_remark.Visible = False

        End If

    End Sub
End Class