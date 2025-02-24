
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class pouchreportform
    Dim StrSql, StrSql1, sql, sql1, sqlm As String
    Dim StrRs, StrRss, StrRsss, strsm As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Cmdd As New SqlCommand
    Dim Cmdm As New SqlCommand
    Dim fromdte As String
    Dim toodate As String
    Dim ds As New DataSet


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromDate.ValueChanged

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pouchreportform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If productline = "PHOBIC" Or productline = "SUPERPHOB" Or productline = "PHOBIC NONPRELOADED" Or productline = "PHILIC" Then

                sql1 = "select distinct model_name from pouch_label "
                Cmdd = New SqlCommand(sql1, con)
                StrRsss = Cmdd.ExecuteReader
                MODEL_NAME.Items.Clear()
                While StrRsss.Read
                    MODEL_NAME.Items.Add(IIf(IsDBNull(StrRsss.GetValue(0)), "", StrRsss.GetValue(0)))
                End While
                StrRsss.Close()
                Cmdd.Dispose()

                sql = "select distinct type from lot_type "
                Cmd = New SqlCommand(sql, con)
                StrRs = Cmd.ExecuteReader
                type.Items.Clear()
                While StrRs.Read
                    type.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While

                StrRs.Close()
                Cmd.Dispose()
                sqlm = "SELECT DISTINCT CAST(Power AS DECIMAL(10, 2)) AS formatted_power FROM  LENS_MASTER"
                Cmdm = New SqlCommand(sqlm, con)
                strsm = Cmdm.ExecuteReader
                power.Items.Clear()
                While strsm.Read
                    power.Items.Add(IIf(IsDBNull(strsm.GetValue(0)), "", strsm.GetValue(0)))
                End While
                strsm.Close()
                Cmdm.Dispose()

            End If
            If productline = "PMMA" Then

                sqlm = "SELECT DISTINCT CAST(Power AS DECIMAL(10, 2)) AS formatted_power FROM         LENS_MASTER1"
                Cmdm = New SqlCommand(sqlm, con)
                strsm = Cmdm.ExecuteReader
                power.Items.Clear()
                While strsm.Read
                    power.Items.Add(IIf(IsDBNull(strsm.GetValue(0)), "", strsm.GetValue(0)))
                End While
                strsm.Close()
                Cmdm.Dispose()
                sql1 = "select distinct model_name from pouch_label "
                Cmdd = New SqlCommand(sql1, con)
                StrRsss = Cmdd.ExecuteReader
                MODEL_NAME.Items.Clear()
                While StrRsss.Read
                    MODEL_NAME.Items.Add(IIf(IsDBNull(StrRsss.GetValue(0)), "", StrRsss.GetValue(0)))
                End While
                StrRsss.Close()
                Cmdd.Dispose()

                sql = "select distinct type from lot_type "
                Cmd = New SqlCommand(sql, con)
                StrRs = Cmd.ExecuteReader
                type.Items.Clear()
                While StrRs.Read
                    type.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While

                StrRs.Close()
                Cmd.Dispose()

            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

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
            Dim dtee As String = ""
            dtee = Format(System.DateTime.Today(), "dd/MM/yyyy")
            Dim cryRpt As New pouchreport
            fromdte = FromDate.Text
            Dim dteefrm As String = ""
            dteefrm = Format(FromDate.Value, "yyyy-MM-dd") & " 00:00:01"
            toodate = Format(ToDate.Value, "yyyy-MM-dd") & " 23:59:59"


            If MODEL_NAME.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Model")
                MODEL_NAME.Focus()
                Exit Sub
            End If

            If power.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Power")
                power.Focus()
                Exit Sub
            End If

            If type.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Type")
                type.Focus()
                Exit Sub
            End If


            If (MODEL_NAME.Text = "" And power.Text = "" And type.Text = "" And FromDate.Text <> "" And ToDate.Text <> "") Then


                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  Created_Date  between  '" & dteefrm & "' and  '" & toodate & "' group by brand_name,model_name,power order by brand_name,model_name,power "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))


                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()


            ElseIf (power.Text = "" And type.Text = "" And FromDate.Text <> "" And ToDate.Text <> "" And MODEL_NAME.Text <> "") Then

                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  (Created_Date  between  '" & dteefrm & "' and  '" & toodate & "')  and  model_name ='" & MODEL_NAME.Text & "' group by brand_name,model_name,power order by brand_name,power,model_name "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))




                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()



            ElseIf (MODEL_NAME.Text = "" And power.Text = "" And type.Text <> "" And FromDate.Text <> "" And ToDate.Text <> "") Then

                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  (Created_Date  between  '" & dteefrm & "' and  '" & toodate & "')  and  Type='" & type.Text & "' group by brand_name,model_name,power order by brand_name,model_name,power "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))




                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()

            ElseIf (type.Text = "" And MODEL_NAME.Text <> "" And FromDate.Text <> "" And ToDate.Text <> "" And power.Text <> "") Then


                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  (Created_Date  between  '" & dteefrm & "' and  '" & toodate & "')  and  model_name ='" & MODEL_NAME.Text & "' and power= '" & power.Text & "'  group by brand_name,model_name,power order by brand_name,model_name,power "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))




                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()



            ElseIf (MODEL_NAME.Text = "" And type.Text = "" And power.Text <> "" And FromDate.Text <> "" And ToDate.Text <> "") Then

                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  (Created_Date  between  '" & dteefrm & "' and  '" & toodate & "')   and power= '" & power.Text & "'  group by brand_name,model_name,power order by brand_name,model_name,power "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))

                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()

            ElseIf (power.Text = "" And MODEL_NAME.Text <> "" And type.Text <> "" And FromDate.Text <> "" And ToDate.Text <> "") Then
                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  (Created_Date  between  '" & dteefrm & "' and  '" & toodate & "')   and model_name ='" & MODEL_NAME.Text & "' and  Type='" & type.Text & "'  group by brand_name,model_name,power order by brand_name,model_name,power "

                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))

                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()

            ElseIf (MODEL_NAME.Text <> "" And power.Text <> "" And type.Text <> "" And FromDate.Text <> "" And ToDate.Text <> "") Then

                StrSql = "SELECT DISTINCT brand_name,model_name,MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO,power,sum(qty_1) as qty ,'" & dtee & "' as dte,'" & PHI & "' as strl  from pouch_label WHERE  Created_Date  between  '" & dteefrm & "' and  '" & toodate & "' and model_name ='" & MODEL_NAME.Text & "' and  Type='" & type.Text & "'  and power= '" & power.Text & "' group by brand_name,model_name,power order by brand_name,model_name,power "


                ds = getDistinctTrayNumber(StrSql)

                cryRpt.SetDataSource(ds.Tables(0))


                CrystalReportViewer1.ReportSource = cryRpt

                'Dim txtProductLine As CrystalDecisions.CrystalReports.Engine.TextObject
                'txtProductLine = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtProduct")
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Show()



            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub


    Private Sub MODEL_NAME_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODEL_NAME.SelectedIndexChanged


        
    End Sub

   
    Private Sub ToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDate.ValueChanged
       

    End Sub
End Class

