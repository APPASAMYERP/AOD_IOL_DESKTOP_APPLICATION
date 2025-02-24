
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls



Public Class frmNewTrayGenerationForm
    Dim StrRs, Sql, StrRs1, StrRsSeHd, StrRsSeDt As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql, Str_Header, StrUniqueNo, StrSqlSeHd, Str_Detail, StrSqlSeDt, tryno As String
    Dim bplno As String = ""

    Dim ds As New DataSet

    Dim Ds1 As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        StrSql = "SELECT top(50)lot_srno FROM  POUCH_LABEL WHERE (Sterilization = '1') AND (Sterilization_After = '1') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND  (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND (Tray_No NOT NULL) and Brand_name= '" & cmbBrand.Text & "' and Model_Name='" & cmbModelNo.Text & "' GROUP BY lot_srno ORDER BY lot_srno"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            ' tryno = "Tray_New/" & Format(Now, "ddMMyy") & "/" & header_id.ToString("0000")

        End If
    End Sub
    Private Sub LensMasterBind()
        ds = New DataSet()
        If productline = "PMMA" Then
            StrSql = "select distinct Brand_Name from Lens_Master1 order by Brand_Name"
        Else
            StrSql = "select distinct Brand_Name from Lens_Master order by Brand_Name"
        End If
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbBrand.DisplayMember = "Brand_Name"
        cmbBrand.DataSource = ds.Tables(0)

    End Sub
    Private Sub LensMasterBind1()
        ds = New DataSet()
        If productline = "PMMA" Then
            StrSql = "select distinct Model_Name from Lens_Master1 order by Model_Name"
        Else
            StrSql = "select distinct Model_Name from Lens_Master order by Model_Name"
        End If
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbModelNo.DisplayMember = "Model_Name"
        cmbModelNo.DataSource = ds.Tables(0)

    End Sub

    Private Sub frmNewTrayGenerationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        LensMasterBind()
        LensMasterBind1()

    End Sub
End Class