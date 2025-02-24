Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class overall_stock
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim cryRpt As New Overallreport
    Dim ds As New DataSet
    Public Function getDistinctTrayNumber(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub Btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnview.Click

        Try
            Dim PHI As String = ""
            If productline = "PHILIC" Then
                PHI = " PHILIC "

            ElseIf productline = "PHOBIC" Or productline = "SUPERPHOB" Or productline = "PHOBIC NONPRELOADED" Then
                PHI = " PHOBIC "

            ElseIf productline = "PMMA" Then
                PHI = " PMMA  "

            End If
            StrSql = " WITH BeforeData AS (SELECT Brand_Name, Model_Name, CAST(Power AS float) AS Power, SUM(Qty_1) AS Before FROM POUCH_LABEL WHERE Sterilization = '1' AND Sample_Taken = '0' AND Dc_No IS NULL AND Sterilization_After = '0' AND BPL_Taken = '0' AND Sterilization_Reject = '0' AND Box_Packing = '0' AND BPL_NO IS NULL AND Box_Reject = '0' AND Dc_Packing = '0' AND Areation_Status IS NULL GROUP BY Brand_Name, Model_Name, CAST(Power AS float)), " & _
            " AfterData AS (SELECT Brand_Name, Model_Name, CAST(Power AS float) AS Power, SUM(Qty_1) AS After FROM POUCH_LABEL WHERE Sterilization = '1' AND Sample_Taken = '0' AND Dc_No IS NULL AND Sterilization_After = '1' AND BPL_Taken = '0' AND Sterilization_Reject = '0' AND Box_Packing = '0' AND BPL_NO IS NULL AND Box_Reject = '0' AND Dc_Packing = '0' AND Areation_Status IS NULL GROUP BY Brand_Name, Model_Name, CAST(Power AS float)), " & _
            " AereationData AS (SELECT Brand_Name, Model_Name, CAST(Power AS float) AS Power, SUM(Qty_1) AS Aereation FROM POUCH_LABEL WHERE BPL_NO IS NULL AND Sterilization = '1' AND Sample_Taken = '0' AND Sterilization_After = '1' AND Box_Packing = '0' AND Box_Reject = '0' AND BPL_Taken = '0' AND Dc_Packing = '0' AND Sterilization_Reject = '0' AND Dc_No IS NULL AND Areation_Status = '1' GROUP BY Brand_Name, Model_Name, CAST(Power AS float)), " & _
            "  BPLWithoutPackingData AS (SELECT Brand_Name, Model_Name, CAST(Power AS float) AS Power, SUM(Qty_1) AS bplwithoutpacking FROM POUCH_LABEL WHERE Sterilization = '1' AND Sample_Taken = '0' AND BPL_Taken = '1' AND Box_Packing = '0' AND Dc_Packing = '0' AND Sterilization_After = '1' AND Sterilization_Reject = '0' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' AND Sterility_Status = '1' AND BPL_Collection_Status = '1' GROUP BY Brand_Name, Model_Name, CAST(Power AS float)), " & _
            " RelevantBPL AS (SELECT DISTINCT BPL_No FROM BPL_GEN WHERE BoxPack_to_Despatch_Move_Status IS NULL), ShrinkPackStockData AS (SELECT Brand_Name, Model_Name, CAST(Power AS float) AS Power, SUM(Qty_1) AS shrinkpackstock FROM POUCH_LABEL WHERE BPL_NO IN (SELECT bid.BPL_No FROM Box_Inspection_Details AS bid INNER JOIN RelevantBPL AS r ON bid.BPL_No = r.BPL_No GROUP BY bid.BPL_No HAVING SUM(bid.Acc_Qty) = (SELECT SUM(Qty_1) FROM POUCH_LABEL WHERE BPL_NO = bid.BPL_No AND Box_Packing = '1')) AND Box_Packing = '1' AND Box_Reject = '0' GROUP BY Brand_Name, Model_Name, CAST(Power AS float))" & _
            " SELECT COALESCE(b.Brand_Name, a.Brand_Name, aer.Brand_Name, bw.Brand_Name, s.Brand_Name) AS Brand_Name, COALESCE(b.Model_Name, a.Model_Name, aer.Model_Name, bw.Model_Name, s.Model_Name) AS Model_Name, COALESCE(b.Power, a.Power, aer.Power, bw.Power, s.Power) AS Power, COALESCE(b.Before, 0) AS Before, COALESCE(a.After, 0) AS After, COALESCE(aer.Aereation, 0) AS Aereation, COALESCE(bw.bplwithoutpacking, 0) AS bplwithoutpacking, COALESCE(s.shrinkpackstock, 0) AS shrinkpackstock " & _
            " FROM BeforeData AS b FULL OUTER JOIN AfterData AS a ON b.Brand_Name = a.Brand_Name AND b.Model_Name = a.Model_Name AND b.Power = a.Power FULL OUTER JOIN AereationData AS aer ON COALESCE(b.Brand_Name, a.Brand_Name) = aer.Brand_Name AND COALESCE(b.Model_Name, a.Model_Name) = aer.Model_Name AND COALESCE(b.Power, a.Power) = aer.Power FULL OUTER JOIN BPLWithoutPackingData AS bw ON COALESCE(b.Brand_Name, a.Brand_Name, aer.Brand_Name) = bw.Brand_Name AND COALESCE(b.Model_Name, a.Model_Name, aer.Model_Name) = bw.Model_Name AND COALESCE(b.Power, a.Power, aer.Power) = bw.Power FULL OUTER JOIN ShrinkPackStockData AS s ON COALESCE(b.Brand_Name, a.Brand_Name, aer.Brand_Name, bw.Brand_Name) = s.Brand_Name AND COALESCE(b.Model_Name, a.Model_Name, aer.Model_Name, bw.Model_Name) = s.Model_Name AND COALESCE(b.Power, a.Power, aer.Power, bw.Power) = s.Power "


            ds = getDistinctTrayNumber(StrSql)

            cryRpt.SetDataSource(ds.Tables(0))

            CrystalReportViewer1.ReportSource = cryRpt

            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub
End Class