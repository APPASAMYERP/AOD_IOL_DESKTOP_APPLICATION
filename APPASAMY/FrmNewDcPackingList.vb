Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmNewDcPackingList


    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader

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
    Dim StrRs As SqlDataReader
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim IntLotAvlQty As Integer


    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Private Sub FrmNewDcPackingList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from DC_PACKING_LIST"
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



        StrUniqueNo = "DCL/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo

        StrSql = "SELECT DISTINCT Country_Name from Order_Country order by Country_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbOrderContry.Items.Clear()
        While StrRs.Read
            CmbOrderContry.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        ' Create four typed columns in the DataTable.

        table.Columns.Add("Model", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("Brand", GetType(String))
        table.Columns.Add("Print_Name", GetType(String))
        table.Columns.Add("Type", GetType(String))
        table.Columns.Add("Type_GS_Code", GetType(String))
        table.Columns.Add("Avl_Qty", GetType(String))
        table.Columns.Add("BPL_Qty", GetType(String))
        table.Columns.Add("TY_Packing", GetType(String))
        table.Columns.Add("Ord_Country", GetType(String))

        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

        lblTotBplQty.Text = 0
    End Sub




    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged
        If CmbShModel.Text <> "" Then
            StrSql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            CmbShPower.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()
            cbxtype.Items.Clear()


            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            
            TxtShowAvlQty.Text = ""
            txTbplQty.Text = ""
            While StrRs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged
        If CmbShPower.Text <> "" Then
            StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()
            cbxtype.Items.Clear()


            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""
            txTbplQty.Text = ""
            While StrRs.Read
                CmbShBrand.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShBrand.SelectedIndexChanged
        If CmbShBrand.Text <> "" Then
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
                cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While

            StrRs.Close()
            cmd.Dispose()

        End If



    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If IntLotAvlQty = 0 Then
            MsgBox("Available Qty Is Zero")
            Exit Sub
        End If




        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from DC_PACKING_LIST"
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




        For i = 0 To GRID2.Rows.Count - 2
            Dim Sql As String


            Str_Detail = 0
            StrSqlSeDt = "Select Max(Detail_ID) from DC_PACKING_LIST"
            cmd = New SqlCommand(StrSqlSeDt, con)
            StrRsSeDt = cmd.ExecuteReader
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
            cmd.Dispose()

            If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then
                Sql = "Insert Into DC_PACKING_LIST ( Header_ID,Detail_ID,		Model_Name,	Power,Brand_Name,Print_Name,Type,Type_GS_Code,Qty,DCL_No,Dc_Print,dc_Id,Created_By,	Created_Date,	Modified_By,	Modified_Date ) values ( " & _
                          "'" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(2, i).Value & "','" & GRID2.Item(3, i).Value & "','" & GRID2.Item(4, i).Value & "','AOD','" & GRID2.Item(7, i).Value & "','" & StrUniqueNo & "','0','0', " & _
                          "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                Sql = "Insert Into DC_PACKING_LIST ( Header_ID,Detail_ID,		Model_Name,	Power,Brand_Name,Print_Name,Type,Type_GS_Code,Qty,DCL_No,Dc_Print,dc_Id,Created_By,	Created_Date,	Modified_By,	Modified_Date ) values ( " & _
                                          "'" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(2, i).Value & "','" & GRID2.Item(3, i).Value & "','" & GRID2.Item(4, i).Value & "','" & GRID2.Item(5, i).Value & "','" & GRID2.Item(7, i).Value & "','" & StrUniqueNo & "','0','0', " & _
                                          "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If

            

           
            'Sql = "update POUCH_LABEL set Dc_Packing_List =1,DCL_No='" & StrUniqueNo & "' where Lot_SrNo in( " & _
            '     "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
            '     " and POWER='" & GRID2.Item(1, i).Value & "' and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and Type_GS_Code='" & GRID2.Item(5, i).Value & "' " & _
            '     "and Brand_Name='" & GRID2.Item(2, i).Value & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 " & _
            '     "and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and Sterilization_Reject=0 and  Box_Reject=0  AND Sterilization_After=1 order by Created_Date,Lot_SrNo)"

            'Sql = "update POUCH_LABEL set Dc_Packing_List =1,DCL_No='" & StrUniqueNo & "' where Lot_SrNo in( " & _
            '    "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
            '    " and POWER='" & GRID2.Item(1, i).Value & "' and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and Type_GS_Code='" & GRID2.Item(5, i).Value & "' " & _
            '    "and Brand_Name='" & GRID2.Item(2, i).Value & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Packing_Model='" & GRID2.Item(8, i).Value & "' " & _
            '    "and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and Sterilization_Reject=0 and  Box_Reject=0  AND Sterilization_After=1 order by Created_Date,Lot_SrNo)"


            If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then
                Sql = "update POUCH_LABEL set Dc_Packing_List =1,DCL_No='" & StrUniqueNo & "' where Lot_SrNo in( " & _
                             "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                             " and POWER='" & GRID2.Item(1, i).Value & "' and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and Type_GS_Code='AOD' " & _
                             "and Brand_Name='" & GRID2.Item(2, i).Value & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Packing_Model='" & GRID2.Item(8, i).Value & "' and Ord_Country='" & GRID2.Item(9, i).Value & "' " & _
                             "and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and Sterilization_Reject=0 and  Box_Reject=0  AND Sterilization_After=1 order by Created_Date,Lot_SrNo)"


            Else
                Sql = "update POUCH_LABEL set Dc_Packing_List =1,DCL_No='" & StrUniqueNo & "' where Lot_SrNo in( " & _
                             "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                             " and POWER='" & GRID2.Item(1, i).Value & "' and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and Type_GS_Code='" & GRID2.Item(5, i).Value & "' " & _
                             "and Brand_Name='" & GRID2.Item(2, i).Value & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Packing_Model='" & GRID2.Item(8, i).Value & "' and Ord_Country='" & GRID2.Item(9, i).Value & "' " & _
                             "and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and Sterilization_Reject=0 and  Box_Reject=0  AND Sterilization_After=1 order by Created_Date,Lot_SrNo)"


            End If

          

            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Next i

        'MsgBox("Saved ")

        Dim cryRpt As New DCLCollection

        CheckTMP_DCL_LIST()



        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                 "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                 "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.DCL_No " & _
                 "into TMP_DCL_LIST " & _
                 "from POUCH_LABEL P where" & _
                 " P.DCL_NO='" & StrUniqueNo & "' order by Model_Name "

        cmd = New SqlCommand(StrSql, con)
        cmd.ExecuteNonQuery()
        cmd.Dispose()





        RptViwCollection.CryViewCollectList.ReportSource = cryRpt


        cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()




        Clear()

        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from DC_PACKING_LIST"
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



        StrUniqueNo = "DCL/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo



        StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        ' Create four typed columns in the DataTable.


        'Try
        '    table.Dispose()
        'Catch ex As Exception

        'End Try

        'table.Columns.Add("Model", GetType(String))
        'table.Columns.Add("Power", GetType(String))
        'table.Columns.Add("Brand", GetType(String))
        'table.Columns.Add("Type", GetType(String))
        'table.Columns.Add("Avl_Qty", GetType(String))
        'table.Columns.Add("BPL_Qty", GetType(String))
        'GRID2.DataSource = table

        table.Clear()
        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

        lblTotBplQty.Text = 0
    End Sub


    Private Sub CheckTMP_DCL_LIST()
        Try
     
            SqlCk2 = "Drop Table TMP_DCL_LIST"
            Cmd2 = New SqlCommand(SqlCk2, con)
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()

          
        Catch ex As Exception

        End Try
    End Sub







    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click


        If CmbShBrand.Text.Trim = "" Then
            MsgBox("Select Brand Name ", MsgBoxStyle.Information)
            CmbShBrand.Text = ""
            CmbShBrand.Focus()

        End If

        If CmbShModel.Text.Trim = "" Then
            MsgBox("Select Model Name ", MsgBoxStyle.Information)
            CmbShModel.Text = ""
            CmbShModel.Focus()

        End If

        If CmbShPower.Text.Trim = "" Then
            MsgBox("Select Power  ", MsgBoxStyle.Information)
            CmbShPower.Text = ""
            CmbShPower.Focus()

        End If
        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Then
        Else
            If CmbShType.Text.Trim = "" Then
                MsgBox("Select Type  ", MsgBoxStyle.Information)
                CmbShType.Text = ""
                CmbShType.Focus()

            End If
        End If
       

        If cbxpname.Text.Trim = "" Then
            MsgBox("Select Print_Name  ", MsgBoxStyle.Information)
            CmbShType.Text = ""
            CmbShType.Focus()

        End If

        If cbxtype.Text.Trim = "" Then
            MsgBox("Select Type  ", MsgBoxStyle.Information)
            CmbShType.Text = ""
            CmbShType.Focus()

        End If


        If txTbplQty.Text.Trim = "" Then
            MsgBox("Enter Qty ", MsgBoxStyle.Information)
            txTbplQty.Focus()
            Exit Sub
        End If


        If Val(TxtShowAvlQty.Text) < Val(txTbplQty.Text) Then
            MsgBox("Check Qty", MsgBoxStyle.Critical)
            txTbplQty.Focus()
            Exit Sub
        End If

        

        DtRow = table.NewRow
        'table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text)


        'table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text, CmbTyPacking.Text)

        table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text, CmbTyPacking.Text, CmbOrderContry.Text)

        lblTotBplQty.Text = Val(lblTotBplQty.Text) + Val(txTbplQty.Text)

        TxtShowAvlQty.Text = ""
        txTbplQty.Text = ""

    End Sub

    Private Sub GRID2_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles GRID2.UserDeletedRow

    End Sub


    Private Sub GRID2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles GRID2.UserDeletingRow
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

            lblTotBplQty.Text = Val(lblTotBplQty.Text) - GRID2.Item(5, sre).Value
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
        lblTotBplQty.Text = ""
    End Sub

    Private Sub Clear()
        GRID2.ClearSelection()
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txTbplQty.Text = ""
        TxtShowAvlQty.Text = ""
        lblTotBplQty.Text = ""
    End Sub

    Private Sub txTbplQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txTbplQty.TextChanged

    End Sub

   
   
    Private Sub cbxtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxtype.SelectedIndexChanged
        'If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Then
        '    If cbxtype.Text <> "" Then
        '        CmbShType.Enabled = False
        '        StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
        '        "POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Sterilization=1 " & _
        '        "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0  AND Sterilization_After=1 " & _
        '        " and Sterilization_Reject=0 and  Box_Reject=0 and Packing_Model='" & CmbTyPacking.Text & "' and Ord_Country='" & CmbOrderContry.Text & "'"



        '        'StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
        '        '            "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
        '        '            "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
        '        '            " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1 and Packing_Model='" & CmbTyPacking.Text & "' and Ord_Country='" & CmbOrderContry.Text & "'"






        '        cmd = New SqlCommand(StrSql, con)
        '        StrRs = cmd.ExecuteReader

        '        If StrRs.Read Then

        '            LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
        '            LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(4)), 0, StrRs.GetValue(4)), "0.00")
        '            LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
        '            LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
        '            LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
        '            LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
        '            LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), 0, StrRs.GetValue(8)), "0.00")
        '            IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

        '            StrMfdMonth = IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16))
        '            StrMfdYear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))


        '            StrExpMonth = IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18))
        '            StrExpYear = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))

        '            LblShowMfdDate.Text = StrMfdMonth & "-" & StrMfdYear
        '            LblShowExpDate.Text = StrExpMonth & "-" & StrExpYear
        '            StrRs.Close()
        '            cmd.Dispose()

        '            StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0"
        '            cmd = New SqlCommand(StrSql, con)
        '            StrRs = cmd.ExecuteReader
        '            If StrRs.Read Then
        '                IntLotAvlQty = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
        '            End If
        '            StrRs.Close()
        '            cmd.Dispose()

        '            TxtShowAvlQty.Text = IntLotAvlQty

        '            If IntLotAvlQty = 0 Then
        '                MsgBox("Available Qty Is Zero")
        '                'Exit Sub
        '            End If

        '        Else
        '            MsgBox("No Data Found", MsgBoxStyle.Critical)
        '            StrRs.Close()
        '            cmd.Dispose()
        '            Exit Sub
        '        End If
        '        StrRs.Close()
        '        cmd.Dispose()
        '    End If

        'Else
        '    If cbxtype.Text <> "" Then
        '        CmbShType.Enabled = True
        '        StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
        '        cmd = New SqlCommand(StrSql, con)
        '        StrRs = cmd.ExecuteReader
        '        CmbShType.Items.Clear()
        '        CmbShType.Text = ""
        '        While StrRs.Read
        '            CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        '        End While
        '        StrRs.Close()
        '        cmd.Dispose()
        '    End If
        'End If






    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
        If CmbShType.Text <> "" Then

            'StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
            '             "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
            '             "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
            '             " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1"



            'StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
            '            "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
            '            "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
            '            " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1 and Packing_Model='" & CmbTyPacking.Text & "'"




            StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                        "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
                        "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
                        " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1 and Packing_Model='" & CmbTyPacking.Text & "' and Ord_Country='" & CmbOrderContry.Text & "'"


            cmd = New SqlCommand(StrSql, con)

            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(4)), 0, StrRs.GetValue(4)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), 0, StrRs.GetValue(8)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16))
                StrMfdYear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))


                StrExpMonth = IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18))
                StrExpYear = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))

                LblShowMfdDate.Text = StrMfdMonth & "-" & StrMfdYear
                LblShowExpDate.Text = StrExpMonth & "-" & StrExpYear
                StrRs.Close()
                cmd.Dispose()

                'StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                '         " Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 " & _
                '         "and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL  and Sterilization_Reject=0 and  Box_Reject=0"


                StrSql = "select count(*)from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                       "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
                       "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
                       " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1 and Packing_Model='" & CmbTyPacking.Text & "'"
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
                    'Exit Sub
                End If

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                StrRs.Close()
                cmd.Dispose()
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub cbxpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxpname.SelectedIndexChanged
        If cbxpname.Text <> "" Then
            StrSql = "select distinct type from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                                "and Brand_Name='" & CmbShBrand.Text & "'  and Print_NAme='" & cbxpname.Text & "'  "

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

    Private Sub TxtShowAvlQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShowAvlQty.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CmbOrderContry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbOrderContry.SelectedIndexChanged
        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then
            If cbxtype.Text <> "" Then
                CmbShType.Enabled = False
                StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
                "POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Sterilization=1 " & _
                "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0  AND Sterilization_After=1 " & _
                " and Sterilization_Reject=0 and  Box_Reject=0 and Packing_Model='" & CmbTyPacking.Text & "' and Ord_Country='" & CmbOrderContry.Text & "'"



                'StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                '            "Type_GS_Code='" & CmbShType.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  " & _
                '            "and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0 and DC_Packing_List is NULL and " & _
                '            " Sterilization_Reject=0 and  Box_Reject=0   AND Sterilization_After=1 and Packing_Model='" & CmbTyPacking.Text & "' and Ord_Country='" & CmbOrderContry.Text & "'"






                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader

                If StrRs.Read Then

                    LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                    LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(4)), 0, StrRs.GetValue(4)), "0.00")
                    LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                    LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                    LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                    LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
                    LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), 0, StrRs.GetValue(8)), "0.00")
                    IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                    StrMfdMonth = IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16))
                    StrMfdYear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))


                    StrExpMonth = IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18))
                    StrExpYear = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))

                    LblShowMfdDate.Text = StrMfdMonth & "-" & StrMfdYear
                    LblShowExpDate.Text = StrExpMonth & "-" & StrExpYear
                    StrRs.Close()
                    cmd.Dispose()

                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_NAme='" & cbxpname.Text & "' and Type_GS_Code='AOD' and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Box_Packing=1 and Dc_Packing=0"
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
                        'Exit Sub
                    End If

                Else
                    MsgBox("No Data Found", MsgBoxStyle.Critical)
                    StrRs.Close()
                    cmd.Dispose()
                    Exit Sub
                End If
                StrRs.Close()
                cmd.Dispose()
            End If

        Else
            If cbxtype.Text <> "" Then
                CmbShType.Enabled = True
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
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
        End If
    End Sub

    Private Sub CmbTyPacking_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTyPacking.SelectedIndexChanged

    End Sub
End Class