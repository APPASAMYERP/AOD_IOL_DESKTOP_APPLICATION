Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class frmNewBPL_Dashboard
    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String, ByVal con As SqlConnection) As DataSet

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
    Private Sub LoadMethod()
        Dim ds, dsPhilic, dsPhobic, dsNP, dsPMMA As New DataSet
        Dim dt, dtPhilic, dtPhobic, dtNP, dtPMMA As New DataTable
        Dim conPhilic, conPhobic, conNP, conPMMA As New SqlConnection

        conPhobic.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
        conNP.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
        conPhilic.ConnectionString = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
        conPMMA.ConnectionString = ConfigurationSettings.AppSettings("conStrPMMA").ToString()

        


        'Sql = "WITH NotPackedBPLs AS (SELECT DISTINCT BPL_NO, BPL_Collection_Status FROM          POUCH_LABEL " & _
        '             " WHERE      (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) " & _
        '             " AND (Sterility_Status = '1') AND (Dc_No IS NULL) AND (BPL_NO IS NOT NULL) AND (Box_Reject = '0') AND " & _
        '             " (BPL_NO NOT IN (SELECT DISTINCT BPL_NO FROM          POUCH_LABEL AS POUCH_LABEL_1 WHERE      (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 1) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND " & _
        '             " (Sterilization_Reject = 0) AND (Sterility_Status = '1') AND (Dc_No IS NULL) AND (BPL_NO IS NOT NULL) AND (Box_Reject = '0')))), " & _
        '         " CollectedBPLs AS (SELECT DISTINCT BPL_NO FROM          NotPackedBPLs AS NotPackedBPLs_3 WHERE      (BPL_Collection_Status = '1')), " & _
        '         " NotCollectedBPLs AS (SELECT DISTINCT BPL_NO FROM   NotPackedBPLs AS NotPackedBPLs_2 WHERE  (BPL_Collection_Status IS NULL) OR (BPL_Collection_Status = '0')), " & _
        '         " InspectedBPLs AS (SELECT DISTINCT BPL_No FROM          Box_Inspection_Details WHERE      (BPL_No IN (SELECT     BPL_NO FROM          CollectedBPLs AS CollectedBPLs_3))) " & _
        ' " SELECT    'PRCTNAME' AS Product_Type, COUNT(DISTINCT BPL_NO) AS Not_Packed_BPL_Count, " & _
        '     " (SELECT     COUNT(*) AS Expr1 FROM          CollectedBPLs AS CollectedBPLs_2) AS Collected_BPL_Count, " & _
        '     " (SELECT     COUNT(*) AS Expr1 FROM          NotCollectedBPLs AS NotCollectedBPLs_1) AS Not_Collected_BPL_Count, " & _
        '     " (SELECT     COUNT(*) AS Expr1  FROM          InspectedBPLs AS InspectedBPLs_2) AS Inspected_BPL_Count, " & _
        '     " (SELECT     COUNT(*) AS Expr1 FROM          CollectedBPLs AS CollectedBPLs_1) - (SELECT     COUNT(*) AS Expr1 FROM          InspectedBPLs AS InspectedBPLs_1) AS Not_inspected_BPL_Count " & _
        ' " FROM         NotPackedBPLs AS NotPackedBPLs_1 "


        Sql = "SELECT 'PRCTNAME' AS Product_Type, SUM(Qty_1) AS Total_Not_Packed_Qty, COUNT(DISTINCT BPL_NO) AS Not_Packed_BPL_Count,   " & _
                            "(SELECT COUNT(DISTINCT BPL_NO) AS Total " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            ") AND BPL_Collection_Status = '1') AS Collected_BPL_Count, " & _
                            "(SELECT COUNT(DISTINCT BPL_NO) AS Total " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            ") AND (BPL_Collection_Status IS NULL OR BPL_Collection_Status = 0)) AS Not_Collected_BPL_Count, " & _
                            "(SELECT COUNT(DISTINCT BPL_No) AS Expr1 " & _
                            "FROM Box_Inspection_Details " & _
                            "WHERE BPL_No IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            ") AND BPL_Collection_Status = '1')) AS Inspected_BPL_Count, " & _
                            "(SELECT COUNT(DISTINCT BPL_NO) AS Total " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            ") AND BPL_Collection_Status = '1') - " & _
                            "(SELECT COUNT(DISTINCT BPL_No) AS Expr1 " & _
                            "FROM Box_Inspection_Details AS Box_Inspection_Details_1 " & _
                            "WHERE BPL_No IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0' " & _
                            ") AND BPL_Collection_Status = '1')) AS Not_inspected_BPL_Count " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE BPL_NO IS NOT NULL AND Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 0 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND Box_Reject = '0' " & _
                            "AND BPL_NO NOT IN ( " & _
                            "SELECT DISTINCT BPL_NO " & _
                            "FROM POUCH_LABEL AS POUCH_LABEL_1 " & _
                            "WHERE Sterilization = 1 AND Sample_Taken = 0 AND BPL_Taken = 1 AND Box_Packing = 1 AND Dc_Packing = 0 AND Sterilization_After = 1 AND Sterilization_Reject = 0 " & _
                            "AND Sterility_Status = '1' AND Dc_No IS NULL AND BPL_NO IS NOT NULL AND Box_Reject = '0')"

        dsPhilic = SQL_SelectQuery_Execute(Sql.Replace("PRCTNAME", "PHILIC"), conPhilic)
        dtPhilic = dsPhilic.Tables(0)

        dsPhobic = SQL_SelectQuery_Execute(Sql.Replace("PRCTNAME", "PHOBIC"), conPhobic)
        dtPhobic = dsPhobic.Tables(0)

        dsNP = SQL_SelectQuery_Execute(Sql.Replace("PRCTNAME", "NP"), conNP)
        dtNP = dsNP.Tables(0)

        dsPMMA = SQL_SelectQuery_Execute(Sql.Replace("PRCTNAME", "PMMA"), conPMMA)
        dtPMMA = dsPMMA.Tables(0)

        dtPhilic.Merge(dtPhobic)
        dtPhilic.Merge(dtNP)
        dtPhilic.Merge(dtPMMA)
        dt = dtPhilic
        grid.DataSource = dt


    End Sub

    Private Sub frmNewBPL_Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadMethod()
    End Sub

    Private Sub btnFetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFetch.Click
        LoadMethod()
    End Sub
End Class