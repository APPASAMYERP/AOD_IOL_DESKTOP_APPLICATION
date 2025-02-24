
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class cstreportform
    Dim StrSql, StrSql1 As String
    Dim StrRs, StrRss As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Cmdd As New SqlCommand
    Dim DAT As String
    Dim BTCNO As String
    Dim sample As String
    Dim ds As New DataSet

    Private Sub cstreportform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DAT = "2023-09-01 09:57:01.650"
            StrSql = "SELECT DISTINCT btc_no  from pouch_label WHERE  Created_Date >=  '" & DAT & "' and type_sample is not NULL and sample_taken=1 "
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            While StrRs.Read
                Batch.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub


    Public Function getDistinctTrayNumber(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        'Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE   (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub showbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showbtn.Click
        'CheckTMP_DCL_LIST()
        Try

            Dim sample_type1 As String = ""
            Dim sample_type2 As String = ""
            Dim sample_concat As String = ""
            Dim sample_sst As String = ""
            BTCNO = Batch.SelectedItem
            sample = samplecombo.SelectedItem
            Dim cryRpt As New CrystalReport9
            Dim dtee As String = ""
            dtee = Format(System.DateTime.Today(), "dd/MM/yyyy")
            Dim PHI As String = ""
            If productline = "PHILIC" Then
                PHI = " PHILIC STERILE "

            ElseIf productline = "PHOBIC" Or productline = "SUPERPHOB" Or productline = "PHOBIC NONPRELOADED" Then
                PHI = " PHOBIC STERILE "

            ElseIf productline = "PMMA" Then
                PHI = " PMMA STERILE "

            End If
            '  StrRs.Close()

            If Batch.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Batch")
                Batch.Focus()
                Exit Sub
            End If

            If samplecombo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid SampleType")
                samplecombo.Focus()
                Exit Sub
            End If

            If samplecombo.Text = "CST" Then
                sample_type1 = " Control Sample Lens Record "

                sample_type2 = "FR-0954/Iss.05-01.02.2022"


            ElseIf samplecombo.Text = "SST" Then
                sample_type1 = "Sample Lens Record-After Sterilization "
                sample_type2 = "FR-0954A/Iss.03-01.02.2022"
                sample_sst = "Sample Details:Sterility Test/BET/Physical Parameter/EO Residual"



            End If

            'StrSql = "SELECT     Power, SUM(Qty_1) AS qty, Model_Name, Brand_Name,lot_prefix+lot_no FROM POUCH_LABEL WHERE     Btc_No ='" & BTCNO & "' AND type_sample='" & sample & "'  GROUP BY Power, Model_Name, Brand_Name"


            ' StrSql = " SELECT    btc_no,bRAND_NAME, MODEL_NAME,sum(qty_1) as qty, POWER, Lot_Prefix, Lot_No AS lotNo, stuff ((SELECT DISTINCT ',   ' + CAST(ST_SRNO AS varchar(10)) FROM         POUCH_LABEL AS t2 WHERE     (t2.Lot_Prefix = t1.Lot_Prefix AND t2.Lot_NO = t1.Lot_no AND t2.power = t1.power AND t2.MODEL_NAME = t1.MODEL_NAME AND (Btc_No = '" & BTCNO & "') AND (Type_Sample = '" & sample & "'))  " & _
            ' "FOR XML PATH('')), 1, 1, '') AS serial, '" & sample_type & "' as fr ,'" & sample_sst & "' as ss ,'" & dtee & "' as dte,  '" & PHI & "' as strl " & _
            ' "INTO CSTTEMP FROM         POUCH_LABEL AS t1 WHERE     (Btc_No = '" & BTCNO & "' ) AND (Type_Sample = '" & sample & "' ) " & _
            ' "GROUP BY bRAND_NAME, MODEL_NAME, POWER, Lot_Prefix, Lot_NO,btc_no ORDER BY bRAND_NAME, MODEL_NAME, POWER, Lot_Prefix, Lot_NO,btc_no"



            StrSql = "SELECT  Brand_Name, Model_Name, Power, Lot_SrNo, Qty_1,BTC_NO,'" & sample_type1 & "' as fr ,'" & sample_type2 & "' as fr1,'" & dtee & "' as dte,'" & PHI & "' as strl ,'" & sample_sst & "' as ss   FROM POUCH_LABEL  WHERE      Btc_No ='" & BTCNO & "' AND type_sample='" & sample & "' order by power,lot_srno "
            'Cmd = New SqlCommand(StrSql, con)
            'StrRs = Cmd.ExecuteReader

            'StrRs.Close()
            'Cmd.Dispose()
            ds = getDistinctTrayNumber(StrSql)

            cryRpt.SetDataSource(ds.Tables(0))

            'StrRs.Close()
            'Cmd.Dispose()
            'Exit Sub



            CrystalReportViewer1.ReportSource = cryRpt

            ' CryViewBPLList.d()

            'cryRpt.VerifyDatabase()
            'CrystalReportViewer1.Update()
            'CrystalReportViewer1.Validate()


            Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
            txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")


            txtProductLine.Text = productline
            If productline = "PMMA" Then
                txtProductLine.Text = "Sterile Ophthalmic Intra Ocular Lens - PMMA"
            ElseIf productline = "PHILIC" Then
                txtProductLine.Text = "Sterile Ophthalmic Intra Ocular Lens - Foldable Hydrophilic"
            ElseIf productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Or productline = "SUPERPHOB" Then
                txtProductLine.Text = "Sterile Ophthalmic Intra Ocular Lens - Foldable Hydrophobic"
            End If
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub CheckTMP_DCL_LIST()
        Try
            StrSql = "Select * from ssttemp"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            If StrRs.Read Then
                StrRs.Close()
                Cmd.Dispose()
                StrSql1 = "Drop Table ssttemp"
                Cmdd = New SqlCommand(StrSql1, con)
                Cmdd.ExecuteNonQuery()
                Cmdd.Dispose()
            End If
            StrRss.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class