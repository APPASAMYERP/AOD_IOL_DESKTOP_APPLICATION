Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frmBoxPackingReport

    Dim dt As New DataTable

    Private Sub BtnSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSerch.Click
        FromAPX_BOX()
        Report()
    End Sub

    Private Sub FromAPX_BOX()
        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrAPSBOX").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)
        Dim strsql As String = ""

        If productline = "PMMA" Then
            strsql = "select Distinct Brand_Name, Model_Name,  Power , Sum(Qty_1) as Qty from Pouch_Label where Created_Date >= '" & dtpfrom.Value & "' and created_Date <= '" & dtpto.Value & "' and Box_Packing = 1  AND (Brand_Name IN ('APPALENS', 'APPALENS PLUS', 'CAPSULAR RETRACTOR', 'HEERALENS', 'LIBERTY CAPSULAR RETRACTOR', 'LIBERTY IRIS CLAW LENS', "
            strsql = strsql & "'LIBERTY IRIS RETRACTOR', 'LIBERTY RING', 'LIBERTY RINGS', 'LIBERTYLENS', 'LIBERTYLENS BBY', 'LIBERTYLENS PLUS', 'SWISS ANIRIDIA IMPLANTS', 'SWISS LENS', 'SWISS LENS-HD', "
            strsql = strsql & " 'SWISS PHAKIC LENS'))   Group by Brand_Name,Model_Name,Power  order by power "
        ElseIf productline = "PHILIC" Then
            strsql = "select Distinct Brand_Name, Model_Name,  Power, Sum(Qty_1) as Qty from Pouch_Label where Created_Date >= '" & dtpfrom.Value & "' and Box_Packing = 1  and created_Date <= '" & dtpto.Value & "' AND (Brand_Name IN ('ACRYFOLD', 'HEERAFOLD', 'NASPRO', 'nAspro - BBY', 'SWISSFOLD', 'SWISSFOLD-HD'))"
            strsql = strsql & " Group by Brand_Name,Model_Name,Power order by power "
        ElseIf productline = "PHOBIC" Then
            strsql = "select Distinct Brand_Name, Model_Name,  Power, Sum(Qty_1) as Qty from Pouch_Label where Created_Date >= '" & dtpfrom.Value & "' and Box_Packing = 1  and created_Date <= '" & dtpto.Value & "'  AND (Brand_Name IN ('SUPRAPHOB', 'SUPRAPHOB BBY', 'SUPRAPHOB INFOCUS', 'SUPRAPHOB REGEN', 'SUPRAPHOB TORIC', 'SWISS PHOB', "
            strsql = strsql & " 'HYDROPHOBIC FOLDABLE SINGLE PIECE INTRAOCULAR LENS')) "
            strsql = strsql & "    Group by Brand_Name,Model_Name,Power order by power "
        End If

        Dim cmd As New SqlCommand(strsql, con1)
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        dt.Rows.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            dt.Rows.Add(ds.Tables(0).Rows(i)("Brand_Name"), ds.Tables(0).Rows(i)("Model_Name"), ds.Tables(0).Rows(i)("Power"), ds.Tables(0).Rows(i)("Qty"))
        Next

    End Sub

    Private Sub FromPhobic_NonPreloaded()
        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
        Dim con2 As SqlConnection
        con2 = New SqlConnection(conString1)
        Dim strsql As String = ""

       
        strsql = "select Distinct Brand_Name, Model_Name,  Power, Sum(Qty_1) as Qty from Pouch_Label where Created_Date >= '" & dtpfrom.Value & "' and Box_Packing = 1  and created_Date <= '" & dtpto.Value & "'  AND (Brand_Name IN ('SUPRAPHOB', 'SUPRAPHOB BBY', 'SUPRAPHOB INFOCUS', 'SUPRAPHOB REGEN', 'SUPRAPHOB TORIC', 'SWISS PHOB', "
        strsql = strsql & " 'HYDROPHOBIC FOLDABLE SINGLE PIECE INTRAOCULAR LENS')) "
        strsql = strsql & "    Group by Brand_Name,Model_Name,Power order by power "

        Dim cmd As New SqlCommand(strsql, con2)
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            dt.Rows.Add(ds.Tables(0).Rows(i)("Brand_Name"), ds.Tables(0).Rows(i)("Model_Name"), ds.Tables(0).Rows(i)("Power"), ds.Tables(0).Rows(i)("Qty"))
        Next

    End Sub

    Private Sub Report()
        Dim cryRpt As New crystal_BoxPackingReport()

        Dim strsql As String
        strsql = "select Distinct Brand_Name, Model_Name,  Power, Sum(Qty_1) As Qty from Pouch_Label where Created_Date  >= '" & dtpfrom.Value & "' and Created_Date  <= '" & dtpto.Value & "' and Box_Packing = 1   Group by Brand_Name,Model_Name,Power  order by power "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            dt.Rows.Add(ds.Tables(0).Rows(i)("Brand_Name"), ds.Tables(0).Rows(i)("Model_Name"), ds.Tables(0).Rows(i)("Power"), ds.Tables(0).Rows(i)("Qty"))
        Next

        If productline = "PHOBIC" Then
            FromPhobic_NonPreloaded()
        End If

        cryRpt.SummaryInfo.ReportComments = "From Date " & dtpfrom.Value & " To Date " & dtpto.Value
        cryRpt.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cryRpt
    End Sub

    Private Sub frmBoxPackingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = New DataTable
        dt.Columns.Add("Brand_Name", Type.GetType("System.String"))
        dt.Columns.Add("Model_Name", Type.GetType("System.String"))
        dt.Columns.Add("Power", Type.GetType("System.String"))
        dt.Columns.Add("Qty", Type.GetType("System.Int32"))


    End Sub
End Class