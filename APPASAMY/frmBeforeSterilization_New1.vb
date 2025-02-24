Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmBeforeSterilization_New1

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

    Private Sub Form_load()

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Before_Sterilization_Scan_Details"
        Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
            Str_Header = 0
        Else
            Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
        End If

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
            Str_Detail = 0
        Else
            Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
        End If


        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If

        If Str_Detail = 0 Then
            Str_Detail = 1
        Else
            Str_Detail = Str_Detail + 1
        End If


        StrUniqueNo = "STB/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo




        LotPrefixBind()
    End Sub

    Private Sub FrmNewSterilization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form_load()

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Lot_Prefix", GetType(String))
        table.Columns.Add("Lot_No", GetType(String))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub

    Private Sub LotPrefixBind()
        Dim ds As New DataSet()

        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            Sql = "select distinct Lot_Prefix from Pouch_Label where   (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') and Status='Labelled' "

        Else
            Sql = "select distinct Lot_Prefix from Pouch_Label where   (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')"

        End If

        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            cmbLotPrefix.DisplayMember = "Lot_Prefix"
            cmbLotPrefix.DataSource = ds.Tables(0)
        End If


    End Sub

    Private Sub LotNoBind()
        Dim ds As New DataSet()

        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            Sql = "Declare @Lot_Prefix nvarchar(50)= '" & cmbLotPrefix.Text & "' select distinct Lot_No from Pouch_Label where   (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') and Lot_Prefix = @Lot_Prefix  and Status='Labelled' order by Lot_No "
        Else
            Sql = "Declare @Lot_Prefix nvarchar(50)= '" & cmbLotPrefix.Text & "' select distinct Lot_No from Pouch_Label where  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') and Lot_Prefix = @Lot_Prefix  order by Lot_No "
        End If

        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        cmbLotNo.DisplayMember = "Lot_No"
        cmbLotNo.DataSource = ds.Tables(0)
        ComboLotTo.Items.Clear()
        For Each eachRow As DataRow In ds.Tables(0).Rows
            ComboLotTo.Items.Add(eachRow("Lot_No"))
        Next
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()

    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click

        Try

            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Before_Sterilization_Scan_Details"
            Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
                Str_Header = 0
            Else
                Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
            End If

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
                Str_Detail = 0
            Else
                Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
            End If


            If Str_Header = 0 Then
                Str_Header = 1
            Else
                Str_Header = Str_Header + 1
            End If

            If Str_Detail = 0 Then
                Str_Detail = 1
            Else
                Str_Detail = Str_Detail + 1
            End If
            StrUniqueNo = "STB/" & Format(Now, "ddMMyy") & "/" & Str_Header
            lblSterNo.Text = StrUniqueNo


            If txtbtno.Text = "" Then
                MsgBox("Please Enter Batch No", MsgBoxStyle.Information)
                txtbtno.Focus()
                Exit Sub

            End If


            ' Insert record to sterilization table
            Sql = "Insert Into Before_Sterilization_Scan_Details ( Header_ID, Detail_ID, Sterilization_Before_No, Created_By, Created_Date, Modified_By, Modified_Date, Btc_No, Qty ) values ( " & _
                              "'" & Str_Header & "','" & Str_Detail & "', '" & lblSterNo.Text & "', " & _
                              "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & txtbtno.Text & "', '" & Val(lblcount.Text) & "' )"
            UpdateorInsertQuery_Execute(Sql)


            If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
                Sql = "DECLARE  @Sterilization_No nvarchar(50) ='" & lblSterNo.Text & "',@Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' Update POUCH_LABEL set Sterilization=1, Sterilization_No=@Sterilization_No  where Lot_Prefix =@Lot_Prefix   and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  AND (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')   and Status='Labelled'  "
            Else
                Sql = "DECLARE  @Sterilization_No nvarchar(50) ='" & lblSterNo.Text & "',@Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' Update POUCH_LABEL set Sterilization=1, Sterilization_No=@Sterilization_No  where Lot_Prefix =@Lot_Prefix and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  AND (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')  "
            End If
            UpdateorInsertQuery_Execute(Sql)



            MsgBox("Saved ")
            Form_load()
            cmbLotPrefix.Text = ""
            cmbLotNo.Text = ""
            ComboLotTo.Text = ""
            txtbtno.Text = ""
            lblcount.Text = 0
            table.Rows.Clear()



            btnAdd.Visible = True
            cmbLotNo.Enabled = True
            ComboLotTo.Enabled = True
            cmbLotPrefix.Enabled = True



            'LotPrefixBind()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        


    End Sub


    Private Sub clear()


        cmbLotPrefix.Text = Nothing
        ComboLotTo.Text = Nothing
        cmbLotNo.Text = Nothing
        txtbtno.Text = Nothing
        btnAdd.Visible = True
        cmbLotNo.Enabled = True
        ComboLotTo.Enabled = True
        cmbLotPrefix.Enabled = True
        GRID2.ClearSelection()
        table.Clear()
        lblcount.Text = 0

    End Sub



    Private Sub cmbLotPrefix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLotPrefix.SelectedIndexChanged

        ComboLotTo.Text = ""
        LotNoBind()

    End Sub

    Private Sub SterilizationlistBind()

        Dim ds As New DataSet()
        Dim i As Integer

        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            Sql = "Declare @Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' select Lot_Srno,Lot_Prefix,Lot_No from Pouch_Label where Lot_Prefix = @Lot_Prefix  and Lot_No between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "' and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0 and Status='Labelled' order by Lot_srno"
        Else
            Sql = "Declare @Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' select Lot_Srno,Lot_Prefix,Lot_No from Pouch_Label where Lot_Prefix = @Lot_Prefix  and Lot_No between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "' and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0  order by Lot_srno"
        End If


        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)


        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add(ds.Tables(0).Rows(i)("Lot_Srno").ToString(), ds.Tables(0).Rows(i)("Lot_Prefix").ToString(), ds.Tables(0).Rows(i)("Lot_No").ToString())
        Next

        GRID2.DataSource = table
        lblcount.Text = table.Rows.Count.ToString()


    End Sub
    Private Function getDistinctBatchNo() As DataSet
        Dim ds As New DataSet()

        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            Sql = "Declare @Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' select DISTINCT Btc_No from Pouch_Label where Lot_Prefix = @Lot_Prefix and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0 and Status='Labelled' "
        Else
            Sql = "Declare @Lot_Prefix nvarchar(50) = '" & cmbLotPrefix.Text & "' select DISTINCT Btc_No from Pouch_Label where Lot_Prefix = @Lot_Prefix  and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0   "
        End If



        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try

            SterilizationlistBind()

            Dim dsDistinctBatch As New DataSet()
            dsDistinctBatch = getDistinctBatchNo()
            If dsDistinctBatch.Tables(0).Rows.Count > 1 Then
                MsgBox("Multiple Batch present, Please Check", MsgBoxStyle.Information)
                Exit Sub
            ElseIf dsDistinctBatch.Tables(0).Rows.Count < 1 Then
                MsgBox("Batch not Updated, Please Check", MsgBoxStyle.Information)
                Exit Sub
            Else
                txtbtno.Text = dsDistinctBatch.Tables(0).Rows(0)("Btc_No")
            End If


            ' For user do not change Lot number after click add button.
            btnAdd.Visible = False
            cmbLotNo.Enabled = False
            ComboLotTo.Enabled = False
            cmbLotPrefix.Enabled = False

        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try
        


    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub


End Class