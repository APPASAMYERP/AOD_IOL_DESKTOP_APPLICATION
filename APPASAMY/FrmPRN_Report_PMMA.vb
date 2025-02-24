Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration

Public Class FrmPRN_Report_PMMA
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

    Private Sub FrmPRN_Report_PMMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            StrSql = " SELECT DISTINCT   Btc_No  from Pouch_Label WHERE Sterility_Status ='1' AND (Created_Date > '2023-09-15') ORDER BY Btc_No DESC"
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbBatchNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbBatchNo.Items.Add(eachRow1("Btc_No"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            'Validation
            If CmbBatchNo.Text = "" Then
                err.SetError(CmbBatchNo, "This information is required")
                CmbBatchNo.Focus()
                Exit Sub
            Else
                err.SetError(CmbBatchNo, "")
            End If

            If CmbBatchNo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Sterile batch")
                CmbBatchNo.Focus()
                Exit Sub
            End If

            If txtESR_No.Text = "" Then
                err.SetError(txtESR_No, "This information is required")
                txtESR_No.Focus()
                Exit Sub
            Else
                err.SetError(txtESR_No, "")
            End If

            If txtPRN_No.Text = "" Then
                err.SetError(txtPRN_No, "This information is required")
                txtPRN_No.Focus()
                Exit Sub
            Else
                err.SetError(txtPRN_No, "")
            End If

            If CmbBatchNo.SelectedItem Is Nothing Then
                err.SetError(CmbBatchNo, "Please Select valid Sterile Batch")
                CmbBatchNo.Focus()
                Exit Sub
            Else
                err.SetError(CmbBatchNo, "")
            End If

            Dim cryRpt As New cryPRN_Report_PMMA
            StrSql = "SELECT     ROW_NUMBER() OVER (ORDER BY Lot_Prefix, Lot_No, Model_Name, Power) AS serial_number, Model_Name, Lot_Prefix + Lot_No AS Lot_Number, Power, SUM(Qty_1) AS Qty " & _
                    "FROM         POUCH_LABEL WHERE     (Btc_No = '" & CmbBatchNo.Text & "') AND (Sterilization = '1') AND (Sterilization_After = '1') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') and sterility_status='1' " & _
                    "GROUP BY Model_Name, Lot_Prefix, Lot_No, Power ORDER BY Lot_Prefix, Lot_No, Model_Name, Power"
            Ds = SQL_SelectQuery_Execute(StrSql)
            cryRpt.Database.Tables(0).SetDataSource(Ds.Tables(0))

            Dim txtPRN1, txtRelease_date1, txtSterilebatch, txtPRN, txtESRNo, txtRelease_date, txtTest_StartDate As CrystalDecisions.CrystalReports.Engine.TextObject
            txtSterilebatch = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtSterilebatch")
            txtPRN = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPRN")
            txtESRNo = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtESRNo")
            txtRelease_date = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtRelease_date")
            txtTest_StartDate = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtTest_StartDate")
            txtRelease_date1 = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtRelease_date1")
            txtPRN1 = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPRN1")


            txtSterilebatch.Text = CmbBatchNo.Text
            txtPRN.Text = "QC/" & txtPRN_No.Text
            txtPRN1.Text = txtPRN_No.Text
            txtESRNo.Text = txtESR_No.Text
            txtRelease_date.Text = Format(dtp_ReleaseDate.Value, "dd-MM-yyyy")
            txtRelease_date1.Text = Format(dtp_ReleaseDate.Value, "dd-MM-yyyy")
            txtTest_StartDate.Text = Format(dtp_TestStartDate.Value, "dd-MM-yyyy")


            CryViewBoxPackingRecord.ReportSource = cryRpt
            CryViewBoxPackingRecord.Refresh()
            CryViewBoxPackingRecord.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Private Sub CmbBatchNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBatchNo.SelectedIndexChanged
        'StrSql = "SELECT     Batch_no, Esr_no, PRN_no, Lot_size, Sterile_date, Release_date  FROM  PRN_Data_Table WHERE Batch_no = '" & CmbBatchNo.Text & "' "
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        '    dtp_TestStartDate.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
        '    txtPRN_No.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
        '    dtp_ReleaseDate.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
        'End If

    End Sub
End Class