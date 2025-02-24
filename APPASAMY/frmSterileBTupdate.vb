Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmSterileBTupdate
    Dim table As New DataTable
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim cmd As SqlCommand

    Private Sub LotPrefixBind()
        Dim ds As New DataSet()
        Sql = "select distinct Lot_Prefix from Pouch_Label where  (Btc_No IS NULL) AND (Sterilization = '0') AND (Sterilization_After = 0) OR (Btc_No = '') AND (Sterilization = '0') AND (Sterilization_After = 0) "
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
        Sql = "select distinct Lot_No from Pouch_Label where sterilization = 0 and sterilization_After = 0 and Lot_Prefix = '" & cmbLotPrefix.Text & "' and  (Btc_No IS NULL or  Btc_No ='') order by Lot_No "
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
    Private Sub SterilizationlistBind()
        Dim ds As New DataSet()
        Dim i As Integer
        Sql = "select Lot_Srno,Lot_Prefix,Lot_No from Pouch_Label where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0 and Btc_No is NULL and UDI_Code is NULL order by Lot_srno"
        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add(ds.Tables(0).Rows(i)("Lot_Srno").ToString(), ds.Tables(0).Rows(i)("Lot_Prefix").ToString(), ds.Tables(0).Rows(i)("Lot_No").ToString())
        Next
        GRID2.DataSource = table
        lblcount.Text = table.Rows.Count.ToString()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        ' VALIDATION
        If cmbLotNo.SelectedItem Is Nothing Then
            err.SetError(cmbLotNo, "Please Select valid Lot Number")
            cmbLotNo.Focus()
            Exit Sub
        Else
            err.SetError(cmbLotNo, "")

        End If


        If ComboLotTo.SelectedItem Is Nothing Then
            err.SetError(ComboLotTo, "Please Select valid Lot Number")
            ComboLotTo.Focus()
            Exit Sub
        Else
            err.SetError(ComboLotTo, "")
        End If

        Try
            SterilizationlistBind()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        btnAdd.Visible = False
        cmbLotNo.Enabled = False
        ComboLotTo.Enabled = False
        cmbLotPrefix.Enabled = False
    End Sub
    Private Sub ComboLotTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboLotTo.SelectedIndexChanged

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub cmbLotNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLotNo.SelectedIndexChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmSterileBTupdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

        LotPrefixBind()
    End Sub

    Private Sub cmbLotPrefix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLotPrefix.SelectedIndexChanged
        ComboLotTo.Text = ""
        LotNoBind()

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        btnAdd.Visible = True
        cmbLotNo.Enabled = True
        ComboLotTo.Enabled = True
        cmbLotPrefix.Enabled = True
        GRID2.ClearSelection()
        table.Clear()
        lblcount.Text = 0
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click

        'sundar 08-05-2024-- Plan based report

        If cmb_Order_Type.SelectedItem Is Nothing Then
            err.SetError(cmb_Order_Type, "Please Select valid Order Type")
            cmb_Order_Type.Focus()
            Exit Sub
        Else
            err.SetError(cmb_Order_Type, "")
        End If

        If cmb_Order_Type.Text = "" Then
            err.SetError(cmb_Order_Type, "This information is required")
            Exit Sub
        Else
            err.SetError(cmb_Order_Type, "")
        End If

        If cmb_Order_Country.SelectedItem Is Nothing Then
            err.SetError(cmb_Order_Country, "Please Select valid Order Country")
            cmb_Order_Country.Focus()
            Exit Sub
        Else
            err.SetError(cmb_Order_Country, "")
        End If

        If cmb_Order_Country.Text = "" Then
            err.SetError(cmb_Order_Country, "This information is required")
            Exit Sub
        Else
            err.SetError(cmb_Order_Country, "")
        End If
        '--

        Try
            If txtbtno.Text = "" Then
                MsgBox("Please Enter Batch No", MsgBoxStyle.Information)
                txtbtno.Focus()
                Exit Sub
            End If

            If GRID2.Rows.Count < 2 Then
                MsgBox("Add atleast 1 serial number.", MsgBoxStyle.Information)
                Exit Sub
            End If


            ' Update Batch Number Sterilization
            Dim Sql As String
            Sql = "Update POUCH_LABEL set    Pouch_Order_Type='" & cmb_Order_Type.Text & "', Pouch_Order_Country='" & cmb_Order_Country.Text & "',Created_By ='" & StrLoginUser & "'  , Created_Date = GETDATE(), PouchStation ='" & station & "'  , Btc_No='" & txtbtno.Text & "' where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0 and Btc_No is NULL and UDI_Code is NULL "
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            ' Update UDI Code Sterilization
            Dim Sql1 As String
            Sql1 = "UPDATE    POUCH_LABEL SET Lot_SrNo=REPLACE(Lot_SrNo, ' ', ''), Udi_code = '01' + GS_Code + '10' + Btc_No + '11' + SUBSTRING(CONVERT(varchar(10), Mfd_Year), 3, 2) + RIGHT('0' + CAST(Mfd_Month AS varchar), 2) " & _
                                " + '00' + '17' + SUBSTRING(CONVERT(varchar(10), Exp_Year), 3, 2) + RIGHT('0' + CAST(Exp_Month AS varchar), 2) + '00' + '21' + REPLACE(Lot_SrNo, ' ', '') where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and Sterilization=0 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=0  and UDI_Code is NULL "
            cmd = New SqlCommand(Sql1, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()


            MsgBox("Saved ")
            cmbLotPrefix.Text = ""
            cmbLotNo.Text = ""
            ComboLotTo.Text = ""
            cmb_Order_Type.Text = ""
            cmb_Order_Country.Text = ""
            txtbtno.Text = ""
            table.Rows.Clear()
            btnAdd.Visible = True
            cmbLotNo.Enabled = True
            ComboLotTo.Enabled = True
            cmbLotPrefix.Enabled = True
            LotPrefixBind()
            lblcount.Text = 0
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

    Private Sub cmb_Order_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Order_Type.SelectedIndexChanged

        cmb_Order_Country.Text = ""
        Sql = "SELECT DISTINCT Order_Country from Pouch_Order_Country_Master  Where Order_Type='" & cmb_Order_Type.Text & "' order by Order_Country"
        Ds = SQL_SelectQuery_Execute(Sql)
        cmb_Order_Country.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmb_Order_Country.Items.Add(eachRow1("Order_Country"))
        Next

    End Sub
End Class