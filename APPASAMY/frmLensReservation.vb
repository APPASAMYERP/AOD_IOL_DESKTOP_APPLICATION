
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmLensReservation
    Dim Ds1 As New DataSet
    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader
    Dim StrPrice As String

    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader

    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrUniqueNo As String
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim StrSql As String
    Dim StrSql1 As String
    Dim StrRs As SqlDataReader
    Dim StrRs1 As SqlDataReader
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim IntLotAvlQty As Integer

    Public Sub reserved_id_load()
        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_id) from Order_Reserved_Details"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
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
        cmd.Dispose()



        StrUniqueNo = "LR/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo

    End Sub

    Public Sub country_name_load()
        StrSql = "SELECT DISTINCT Country_Name from Order_Country order by Country_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbOrderContry.Items.Clear()
        While StrRs.Read
            CmbOrderContry.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

    End Sub

    Public Sub load_order_id()
        'tray No load
        Sql = "SELECT DISTINCT Reserved_Id FROM         Order_Reserved_Details ORDER BY Reserved_Id "
        Ds = SQL_SelectQuery_Execute(Sql)
        cmbReserve_id.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbReserve_id.Items.Add(eachRow1("Reserved_Id"))
        Next

    End Sub

    Private Sub FrmBPLGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_id) from Order_Reserved_Details"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
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
        cmd.Dispose()



        StrUniqueNo = "LR/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo


        If productline = "PMMA" Then
            StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
        Else
            StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        End If

        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()



        country_name_load()



        ' Create four typed columns in the DataTable.
        Try
            table.Dispose()
        Catch ex As Exception

        End Try


        table.Columns.Add("Model", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("Brand", GetType(String))
        table.Columns.Add("Print_Name", GetType(String))
        table.Columns.Add("Type", GetType(String))
        table.Columns.Add("GS_Type", GetType(String))
        table.Columns.Add("Avl_Qty", GetType(String))
        table.Columns.Add("BPL_Qty", GetType(String))
        table.Columns.Add("Ty_Packing", GetType(String))
        table.Columns.Add("Ord_Country", GetType(String))
        table.Columns.Add("Mfd_Year", GetType(String))
        table.Columns.Add("Mfd_month", GetType(String))
        table.Columns.Add("Order_ID", GetType(String))
        table.Columns.Add("btc_no", GetType(String))
        table.Columns.Add("Reserved_id", GetType(String))


        
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

        lblTotBplQty1.Text = 0
    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged


        If CmbShModel.Text <> "" Then
            'Validation

            Dim yearRgx As New Regex("\b\d{4}\b")
            If Not yearRgx.IsMatch(txtyear.Text.Trim()) Then
                MessageBox.Show("Type valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim monthRgx As New Regex("\b(0[1-9]|1[0-2])\b")
            If Not monthRgx.IsMatch(txtmonth.Text.Trim()) Then
                MessageBox.Show("Type valid month.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT POWER from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' order by POWER"
            Else
                StrSql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            End If
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            cbxtype.Items.Clear()
            CmbShPower.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()

            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""

            While StrRs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged

        If CmbShPower.Text <> "" Then


            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus() 
                Exit Sub
            End If

            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            Else
                StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            End If
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            cbxtype.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()

            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""
            While StrRs.Read
                CmbShBrand.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShBrand.SelectedIndexChanged
        If CmbShBrand.Text <> "" Then

            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus()
                Exit Sub
            End If

            If CmbShPower.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                CmbShPower.Focus()
                Exit Sub
            End If
            StrSql = "SELECT DISTINCT Print_Name from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' "

            cmd = New SqlCommand(StrSql, con)

            StrRs = cmd.ExecuteReader


            cbxtype.Items.Clear()
            cbxpname.Items.Clear()
            CmbShType.Items.Clear()

            cbxtype.Text = ""
            cbxpname.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""

            While StrRs.Read
                cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "NULL", StrRs.GetValue(0)))
            End While


            StrRs.Close() 
            cmd.Dispose()
        End If

    End Sub

    Private Sub cbxpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxpname.SelectedIndexChanged
        If cbxpname.Text <> "" Then


            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus()
                Exit Sub
            End If

            If CmbShPower.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                CmbShPower.Focus()
                Exit Sub
            End If

            If CmbShBrand.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Brand Name")
                CmbShBrand.Focus()
                Exit Sub
            End If


            StrSql = "select distinct type from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                                 "and Brand_Name='" & CmbShBrand.Text & "'  and Print_Name='" & cbxpname.Text & "'  and Sterilization=1  and Sample_Taken=0 and  BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)   AND (Type <> 'APPA')"



            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            CmbShType.Items.Clear()
            cbxtype.Items.Clear()


            cbxtype.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""
            While StrRs.Read
                cbxtype.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub cbxtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxtype.SelectedIndexChanged
        If cbxtype.Text <> "" Then

            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus()
                Exit Sub
            End If

            If CmbShPower.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                CmbShPower.Focus()
                Exit Sub
            End If

            If CmbShBrand.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Brand Name")
                CmbShBrand.Focus()
                Exit Sub
            End If

            If cbxpname.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Print Name")
                cbxpname.Focus()
                Exit Sub
            End If


            StrSql = "select Distinct Btc_No from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                 "and Brand_Name='" & CmbShBrand.Text & "' and Type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "'  and Sterilization=1  and Sample_Taken=0 and  BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0  " & _
                 " AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL) "

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            cmb_Batch.Items.Clear()
            cmb_Batch.Text = ""
            While StrRs.Read
                cmb_Batch.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()


            CmbShType.Enabled = True

            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER1 where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            Else
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            End If

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            CmbShType.Items.Clear()
            CmbShType.Text = ""
            While StrRs.Read
                CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If


    End Sub

    

    Private Sub cmb_Batch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Batch.SelectedIndexChanged

        If cmb_Batch.Text <> "" Then
            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus()
                Exit Sub
            End If

            If CmbShPower.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                CmbShPower.Focus()
                Exit Sub
            End If

            If CmbShBrand.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Brand Name")
                CmbShBrand.Focus()
                Exit Sub
            End If

            CmbShType.Enabled = True
             
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER1 where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            Else
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            End If

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            CmbShType.Items.Clear()
            CmbShType.Text = ""
            While StrRs.Read
                CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose() 
        End If

    End Sub




    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
 
        If CmbShType.Text <> "" Then

            Dim yearRgx As New Regex("\b\d{4}\b")
            If Not yearRgx.IsMatch(txtyear.Text.Trim()) Then
                MessageBox.Show("Type valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim monthRgx As New Regex("\b(0[1-9]|1[0-2])\b")
            If Not monthRgx.IsMatch(txtmonth.Text.Trim()) Then
                MessageBox.Show("Type valid month.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If CmbShModel.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                CmbShModel.Focus()
                Exit Sub
            End If

            If CmbShPower.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                CmbShPower.Focus()
                Exit Sub
            End If

            If CmbShBrand.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Brand Name")
                CmbShBrand.Focus()
                Exit Sub
            End If

            If cbxpname.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Print Name")
                cbxpname.Focus()
                Exit Sub
            End If

            If cbxtype.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Type")
                cbxtype.Focus()
                Exit Sub
            End If

            If ckBatchBased.Checked = True Then
                If cmb_Batch.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid Batch")
                    cmb_Batch.Focus()
                    Exit Sub
                End If
            End If

            If CmbTyPacking.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Packing Type")
                CmbTyPacking.Focus()
                Exit Sub
            End If

            If CmbOrderContry.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Order Country")
                CmbOrderContry.Focus()
                Exit Sub
            End If


            If txt_orderId.Text = "" Then
                MessageBox.Show("Please Type valid Order Id")
                txt_orderId.Focus()
                Exit Sub
            End If


            If ckBatchBased.Checked = True Then

                StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
                         "POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and (((Mfd_Month >= '" & txtmonth.Text & "') AND (Mfd_Year = '" & txtyear.Text & "')) or (Mfd_Year >= '" & txtyear.Text + 1 & "')) and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1 " & _
                         "and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1')  and btc_no='" & cmb_Batch.Text & "' AND (Lens_Reserved_status is NULL) "
            Else

                StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
                         "POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and (((Mfd_Month >= '" & txtmonth.Text & "') AND (Mfd_Year = '" & txtyear.Text & "')) or (Mfd_Year >= '" & txtyear.Text + 1 & "')) and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1 " & _
                         "and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1')  AND (Lens_Reserved_status is NULL) "

            End If 

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            If StrRs.Read Then
                IntLotAvlQty = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
            End If
            StrRs.Close()
            cmd.Dispose()

            TxtShowAvlQty.Text = IntLotAvlQty

            If IntLotAvlQty = 0 Then
                MsgBox("Available Qty Is Zero")
                Exit Sub
            End If 

        End If
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

     
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim yearRgx As New Regex("\b\d{4}\b")
        If Not yearRgx.IsMatch(txtyear.Text.Trim()) Then
            MessageBox.Show("Type valid year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim monthRgx As New Regex("\b(0[1-9]|1[0-2])\b")
        If Not monthRgx.IsMatch(txtmonth.Text.Trim()) Then
            MessageBox.Show("Type valid month.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CmbShModel.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Model")
            CmbShModel.Focus()
            Exit Sub
        End If

        If CmbShPower.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Power")
            CmbShPower.Focus()
            Exit Sub
        End If

        If CmbShBrand.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Brand Name")
            CmbShBrand.Focus()
            Exit Sub
        End If

        If cbxpname.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Print Name")
            cbxpname.Focus()
            Exit Sub
        End If

        If cbxtype.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Type")
            cbxtype.Focus()
            Exit Sub
        End If

        If ckBatchBased.Checked = True Then
            If cmb_Batch.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Batch")
                cmb_Batch.Focus()
                Exit Sub
            End If
        End If

        If CmbTyPacking.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Packing Type")
            CmbTyPacking.Focus()
            Exit Sub
        End If

        If CmbOrderContry.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Order Country")
            CmbOrderContry.Focus()
            Exit Sub
        End If


        If txt_orderId.Text = "" Then
            MessageBox.Show("Please Type valid Order Id")
            txt_orderId.Focus()
            Exit Sub
        End If

        Dim bplQty_Rgx As New Regex("^\d+$")
        If Not bplQty_Rgx.IsMatch(txTbplQty.Text.Trim()) Then
            MessageBox.Show("Type valid Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If Val(TxtShowAvlQty.Text) < Val(txTbplQty.Text) Then
            MsgBox("Check Qty", MsgBoxStyle.Critical)
            txTbplQty.Focus()
            Exit Sub
        End If


        'Same Model & power selection validation
        Dim duplicateFound As Boolean = False
         
        For Each row As DataGridViewRow In GRID2.Rows 
            If Not row.IsNewRow Then
                If row.Cells("Model").Value.ToString() = CmbShModel.Text AndAlso row.Cells("Power").Value.ToString() = CmbShPower.Text  AndAlso row.Cells("Brand").Value.ToString() = CmbShBrand.Text AndAlso row.Cells("Print_Name").Value.ToString() = cbxpname.Text Andalso row.Cells("Type").Value.ToString() = cbxtype.Text  Andalso row.Cells("Mfd_Year").Value.ToString() = txtyear.Text Andalso row.Cells("Mfd_month").Value.ToString() = txtmonth.Text  Andalso row.Cells("btc_no").Value.ToString() = cmb_Batch.Text  then
                    duplicateFound = True
                    Exit For
                End If
            End If
        Next
         
        If duplicateFound Then
            MsgBox("The same power and model are already added. Please check.", MsgBoxStyle.Critical, "Duplicate Entry") 
            Exit Sub
        End If



        Try

            DtRow = table.NewRow
            table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text, CmbTyPacking.Text, CmbOrderContry.Text, txtyear.Text, txtmonth.Text, txt_orderId.Text, cmb_Batch.Text, lblSterNo.Text)
            lblTotBplQty1.Text = Val(lblTotBplQty1.Text) + Val(txTbplQty.Text)

            TxtShowAvlQty.Text = ""
            txTbplQty.Text = ""

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
    End Sub

     


    Private Sub GRID2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles GRID2.UserDeletingRow, DataGridView1.UserDeletingRow
        If (Not e.Row.IsNewRow) Then
            Dim response As DialogResult = _
            MessageBox.Show( _
            "Are you sure you want to delete this row?", _
            "Delete row?", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2)
            If (response = DialogResult.No) Then
                e.Cancel = True


            Else

                e.Cancel = False
            End If

            'Dim a As


            Dim sre As Integer = e.Row.Index

            lblTotBplQty1.Text = Val(lblTotBplQty1.Text) - GRID2.Item(7, sre).Value
        End If
    End Sub

     

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        GRID2.ClearSelection()
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txTbplQty.Text = ""
        TxtShowAvlQty.Text = ""
        txtyear.Text = ""
        txtmonth.Text = ""
        lblTotBplQty1.Text = ""
        GRID2.DataSource.Rows.Clear()
        txt_orderId.Text = ""
        cmb_Batch.Text = ""
        CheckBox1.Checked = False
        cmbReserve_id.Text = ""
        CmbTyPacking.Text = ""
        CmbOrderContry.Text = ""
        cbxpname.Text = ""
        cbxtype.Text = ""

    End Sub

    Private Sub Clear()
        GRID2.DataSource.Rows.Clear()
        GRID2.ClearSelection()
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txTbplQty.Text = ""
        TxtShowAvlQty.Text = ""
        lblTotBplQty1.Text = ""
        txtyear.Text = ""
        txtmonth.Text = ""
        txt_orderId.Text = ""
        cmb_Batch.Text = ""
        CheckBox1.Checked = False
        cmbReserve_id.Text = ""
        CmbTyPacking.Text = ""
        CmbOrderContry.Text = ""
        cbxpname.Text = ""
        cbxtype.Text = ""

    End Sub

     

    


     

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If IntLotAvlQty = 0 Then
            MsgBox("Available Qty Is Zero")
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

        

        'If CheckBox1.Checked = True Then
        '    StrUniqueNo = cmbReserve_id.Text
        'Else
        '    Str_Header = 0
        '    StrSqlSeHd = "Select Max(Header_id) from Order_Reserved_Details"
        '    cmd = New SqlCommand(StrSqlSeHd, con)
        '    StrRsSeHd = cmd.ExecuteReader
        '    If StrRsSeHd.Read Then
        '        Str_Header = IIf(IsDBNull(StrRsSeHd(0)), 0, StrRsSeHd(0))
        '    Else
        '        Str_Header = 0
        '    End If

        '    If Str_Header = 0 Then
        '        Str_Header = 1
        '    Else
        '        Str_Header = Str_Header + 1
        '    End If
        '    StrRsSeHd.Close()
        '    cmd.Dispose()

        '    StrUniqueNo = "LR/" & Format(Now, "ddMMyy") & "/" & Str_Header

        'End If

        

        

        For i = 0 To GRID2.Rows.Count - 2

            Dim input As String = GRID2.Item(14, i).Value
            Dim parts As String() = input.Split("/"c)
            Dim lastValue As String = parts(parts.Length - 1)


            Dim Sql As String


            Sql = "Insert Into Order_Reserved_Details ( Header_id,Brand_Name, Model_Name, Power, Qty, Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country, Btc_No, Created_By, Created_date ) values ( " & _
                          "'" & lastValue & "','" & GRID2.Item(2, i).Value & "','" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(7, i).Value & "','" & GRID2.Item(12, i).Value & "','" & GRID2.Item(14, i).Value & "','" & GRID2.Item(8, i).Value & "','" & GRID2.Item(9, i).Value & "','" & GRID2.Item(13, i).Value & "','" & StrLoginUser & "',GETDATE()) "
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            If GRID2.Item(13, i).Value.ToString() = "" Then
                Sql = "update POUCH_LABEL set Lens_Reserved_status =1,Reserved_Id='" & GRID2.Item(14, i).Value & "'  where Lot_SrNo in( " & _
                    "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                    " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='AOD' " & _
                    "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "'  and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                    "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)   order by Created_Date,Lot_SrNo)"

            Else
                Sql = "update POUCH_LABEL set Lens_Reserved_status =1,Reserved_Id='" & GRID2.Item(14, i).Value & "'  where Lot_SrNo in( " & _
                    "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                    " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='AOD' " & _
                    "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "'  and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                    "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL) and Btc_no='" & GRID2.Item(13, i).Value.ToString() & "'  order by Created_Date,Lot_SrNo)"

            End If


            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Next i

         

        Clear()


        

        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With


        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_id) from Order_Reserved_Details"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
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
        cmd.Dispose()

        StrUniqueNo = "LR/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo

        lblTotBplQty1.Text = 0
    End Sub
    
     
    Private Sub cmbReserve_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReserve_id.SelectedIndexChanged
        If cmbReserve_id.Text <> "" Then
            Sql = "SELECT     Brand_Name, Model_Name, Power, Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country, SUM(Qty) AS Qty " & _
                    "FROM         Order_Reserved_Details  Where Reserved_Id='" & cmbReserve_id.Text & "'  " & _
                    "GROUP BY Brand_Name, Model_Name, Power, Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country  " & _
                    "ORDER BY Brand_Name, Model_Name, CAST(Power AS float), Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country  "

            Ds = SQL_SelectQuery_Execute(Sql)
            DataGridView1.DataSource = Ds.Tables(0)


            lblSterNo.Text = cmbReserve_id.Text


            Sql = "SELECT DISTINCT Order_ID,Reserved_Ord_Country, Reserved_Ord_Type FROM         Order_Reserved_Details Where Reserved_Id='" & cmbReserve_id.Text & "' "
            Ds = SQL_SelectQuery_Execute(Sql)
            If Ds.Tables(0).Rows.Count = 1 Then
                CmbOrderContry.Items.Clear()
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    CmbOrderContry.Items.Add(eachRow1("Reserved_Ord_Country"))
                Next
                CmbOrderContry.Text = Ds.Tables(0).Rows(0)("Reserved_Ord_Country")
                txt_orderId.Text = Ds.Tables(0).Rows(0)("Order_ID")
                CmbTyPacking.Text = Ds.Tables(0).Rows(0)("Reserved_Ord_Type")

            Else
                MsgBox("Multiple order id.")
                Exit Sub
            End If
            
             

        End If
        

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            cmbReserve_id.Text = ""
            load_order_id()
            Label27.Visible = True
            cmbReserve_id.Visible = True

            CmbTyPacking.Enabled = False
            txt_orderId.Enabled = False
            DataGridView1.DataSource = Nothing
            DataGridView1.Visible = True

        Else
            cmbReserve_id.Text = ""
            reserved_id_load()
            txt_orderId.Text = ""
            CmbTyPacking.Text = ""


            Label27.Visible = False
            cmbReserve_id.Visible = False
            DataGridView1.DataSource = Nothing
            DataGridView1.Visible = False


            CmbTyPacking.Enabled = True
            txt_orderId.Enabled = True
            country_name_load()
        End If
        
    End Sub

    Private Sub ckBatchBased_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckBatchBased.CheckedChanged
        If ckBatchBased.Checked = True Then

            Label26.Visible = True
            cmb_Batch.Visible = True
        Else
            cmb_Batch.Text = ""
            Label26.Visible = False
            cmb_Batch.Visible = False

        End If
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub
End Class