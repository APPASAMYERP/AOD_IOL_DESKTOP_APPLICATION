
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class LotNoDataReport

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Sql As String
    Dim strtype As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim strsname As String
    Dim strdbname As String
    Dim tye As String

    Private Sub LotNoDataReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            strdbname = con.Database.ToString()
            strsname = con.DataSource.ToString()
            TypeBind()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        

    End Sub

    Private Sub TypeBind()
        Try
            StrSql = " SELECT DISTINCT Type from Pouch_Label where Type IS Not NULL  "
            Cmd = New SqlCommand(StrSql, con)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(ds)

            ComboBox2.DisplayMember = "Type"
            ComboBox2.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Try

            If productline = "PMMA" Then
                StrSql = "select Brand_Name,Model_Name,Reference_Name,Power,right(Lot_SrNo,3) As SrNo,convert(varchar(30),Lot_Prefix )+''+convert(varchar(30), Lot_No ) as Lot_No " & _
                         " from POUCH_LABEL where" & _
                         " (Lot_Prefix + '' + Lot_No) ='" & cmbLotNo.Text & "' order by Power, Lot_SrNo,SrNo "
            ElseIf productline = "SUPERPHOB" Then
                StrSql = "select Brand_Name,Model_Name,Reference_Name,Power,right(Lot_SrNo,5) As SrNo,convert(varchar(30),Lot_Prefix )+''+convert(varchar(30), Lot_No ) as Lot_No,RefLot " & _
                         " from POUCH_LABEL where" & _
                         " RefLot ='" & cmbLotNo.Text & "' order by Power, Lot_SrNo,SrNo "
            Else
                StrSql = "select Brand_Name,Model_Name,RefLot,Reference_Name,Power,right(Lot_SrNo,3) As SrNo,convert(varchar(30),Lot_Prefix )+''+convert(varchar(30), Lot_No ) as Lot_No " & _
                                    " from POUCH_LABEL where" & _
                                    " (Lot_Prefix + '' + Lot_No) ='" & cmbLotNo.Text & "' order by Power, Lot_SrNo,SrNo "
            End If

            Cmd = New SqlCommand(StrSql, con)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(ds)

            If productline = "PMMA" Then
                Dim cryRpt As New CrystalReport_PMMA
                cryRpt.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryRpt
            ElseIf productline = "PHILIC" Then
                Dim cryRpt As New CrystalReport_Philic
                cryRpt.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryRpt
            ElseIf productline = "PHOBIC" Then
                Dim cryRpt As New CrystalReport_Phobic
                cryRpt.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryRpt
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                Dim cryRpt As New CrystalReport_Phobic
                cryRpt.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryRpt
            ElseIf productline = "SUPERPHOB" Then
                Dim cryRpt As New CrystalReport_Superphob
                cryRpt.SetDataSource(ds.Tables(0))
                CrystalReportViewer1.ReportSource = cryRpt
            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub CheckTMP_BPL_LIST()

        Try
            SqlCk2 = "Drop Table LotCollectionList"
            Cmd2 = New SqlCommand(SqlCk2, con)
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()

            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        LotNoBind()
        
    End Sub

    Private Sub LotNoBind()

        If productline = "SUPERPHOB" Then
            StrSql = " SELECT DISTINCT  RefLot as Lot_No from Pouch_Label where Type='" & ComboBox2.Text & "' ORDER BY Lot_No desc "
        Else
            StrSql = " SELECT DISTINCT convert(varchar(30),Lot_Prefix )+''+convert(varchar(30), Lot_No ) as Lot_No from Pouch_Label where Type='" & ComboBox2.Text & "' ORDER BY Lot_No desc "
        End If
        Cmd = New SqlCommand(StrSql, con)
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        cmbLotNo.DisplayMember = "Lot_No"
        cmbLotNo.DataSource = ds.Tables(0)

    End Sub
End Class