Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration

Public Class FrmPRN_Report_PHILIC
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql As String
    Dim Ds As New DataSet
    Dim StAd As New SqlDataAdapter

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

    Private Sub FrmPRN_Report_PHILIC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StrSql = " SELECT DISTINCT   Btc_No  from Pouch_Label WHERE Sterility_Status ='1' AND (Created_Date > '2023-09-15') ORDER BY Btc_No DESC"
        Ds = SQL_SelectQuery_Execute(StrSql)
        CmbBatchNo.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            CmbBatchNo.Items.Add(eachRow1("Btc_No"))
        Next
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        'Validation
        Dim TumblingLots As String =""
        If CmbBatchNo.Text = "" Then
            Err.SetError(CmbBatchNo, "This information is required")
            CmbBatchNo.Focus()
            Exit Sub
        Else
            Err.SetError(CmbBatchNo, "")
        End If

        If txtSSR_No.Text = "" Then
            err.SetError(txtSSR_No, "This information is required")
            txtSSR_No.Focus()
            Exit Sub
        Else
            err.SetError(txtSSR_No, "")
        End If

        If txtPRN_No.Text = "" Then
            Err.SetError(txtPRN_No, "This information is required")
            txtPRN_No.Focus()
            Exit Sub
        Else
            Err.SetError(txtPRN_No, "")
        End If

        If CmbBatchNo.SelectedItem Is Nothing Then
            Err.SetError(CmbBatchNo, "Please Select valid Sterile Batch")
            CmbBatchNo.Focus()
            Exit Sub
        Else
            Err.SetError(CmbBatchNo, "")
        End If

        If txtLot_size.Text = "" Then
            Err.SetError(CmbBatchNo, "This information is required")
            txtLot_size.Focus()
            Exit Sub
        Else
            Err.SetError(txtLot_size, "")
        End If

        If Val(txtLot_size.Text) <= 0 Then
            err.SetError(txtLot_size, "Please Enter valid Qty")
            txtLot_size.Focus()
            Exit Sub
        Else
            err.SetError(txtLot_size, "")
        End If

        Dim cryRpt As New cryPRN_Report_PHILIC
        StrSql = "SELECT     ROW_NUMBER() OVER (ORDER BY Lot_Prefix, Lot_No,Brand_name, Model_Name, Power) AS serial_number, Brand_name, Model_Name, Lot_Prefix + Lot_No AS Lot_Number, Power, SUM(Qty_1) AS Qty " & _
                "FROM         POUCH_LABEL WHERE     (Btc_No = '" & CmbBatchNo.Text & "') AND (Sterilization = '1') AND (Sterilization_After = '1') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') and sterility_status='1' " & _
                "GROUP BY Brand_name,Model_Name, Lot_Prefix, Lot_No, Power ORDER BY Lot_Prefix, Lot_No, Brand_name, Model_Name, Power"
        Ds = SQL_SelectQuery_Execute(StrSql)
        cryRpt.Database.Tables(0).SetDataSource(Ds.Tables(0))

        Dim txtTumblingLotNo, txtMfd_date, txtExp_date, txtSterilebatch, txtPRN, txtSSRNo, txtRelease_date, txtLotsize As CrystalDecisions.CrystalReports.Engine.TextObject
        txtSterilebatch = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtSterilebatch")
        txtPRN = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPRN")
        txtSSRNo = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtSSRNo")
        txtRelease_date = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtRelease_date")
        txtLotsize = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtLotsize")
        txtMfd_date = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtMfd_date")
        txtExp_date = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtExp_date")
        txtTumblingLotNo = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtTumblingLotNo")

        StrSql = "SELECT DISTINCT  CAST(Mfd_Year AS varchar) + '-' + RIGHT('0' + CAST(Mfd_Month AS varchar), 2) AS Mfd, CAST(Exp_Year AS varchar)  + '-' + RIGHT('0' + CAST(Exp_Month AS varchar), 2) AS Exp " & _
                "FROM         POUCH_LABEL WHERE     (Btc_No = '" & CmbBatchNo.Text & "') AND (Sterilization = '1') AND (Sterilization_After = '1') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') and sterility_status='1' "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count = 1 Then
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtMfd_date.Text = eachRow1("Mfd")
                txtExp_date.Text = eachRow1("Exp")
            Next
        Else
            MessageBox.Show("Zero or More Than one Mfd_date present. Please Contact ERP Team.")
            Exit Sub
        End If

        ' Tumbling lot number
        StrSql = "SELECT DISTINCT RefLot " & _
                "FROM         POUCH_LABEL WHERE     (Btc_No = '" & CmbBatchNo.Text & "') AND (Sterilization = '1') AND (Sterilization_After = '1') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') and sterility_status='1' ORDER BY RefLot DESC "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count > 0 Then
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                TumblingLots = eachRow1("RefLot") + ", " + TumblingLots
            Next
            If TumblingLots <> "" Then
                TumblingLots = TumblingLots.Remove(TumblingLots.Length - 2, 2)
            End If

        Else
            MessageBox.Show("No tumbling Lot number present. Please Contact ERP Team.")
            Exit Sub
        End If

        txtTumblingLotNo.Text = TumblingLots
        txtSterilebatch.Text = CmbBatchNo.Text
        txtPRN.Text = txtPRN_No.Text
        txtSSRNo.Text = txtSSR_No.Text
        txtRelease_date.Text = Format(dtp_ReleaseDate.Value, "dd-MM-yyyy")
        txtLotsize.Text = txtLot_size.Text




        CryViewBoxPackingRecord.ReportSource = cryRpt
        CryViewBoxPackingRecord.Refresh()
        CryViewBoxPackingRecord.Show()
    End Sub

    Private Sub CmbBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBatchNo.SelectedIndexChanged


        'StrSql = "SELECT     Batch_no, Esr_no, PRN_no, Lot_size, Sterile_date, Release_date  FROM  PRN_Data_Table WHERE Batch_no = '" & CmbBatchNo.Text & "' "
        'Ds = SQL_SelectQuery_Execute(StrSql)
        'CmbBatchNo.Items.Clear()
        'For Each eachRow1 As DataRow In Ds.Tables(0).Rows
        '    CmbBatchNo.Items.Add(eachRow1("Btc_No"))
        'Next


        
        'txtLot_size.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
        'txtPRN_No.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
        'dtp_ReleaseDate.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))


    End Sub
End Class