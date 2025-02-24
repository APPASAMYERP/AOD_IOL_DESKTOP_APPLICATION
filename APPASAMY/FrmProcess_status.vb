Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Public Class FrmProcess_status
    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Private Sub FrmProcess_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSerch.Click

        If ChkModel.Checked = True And CmbShModel.Text = "" Then
            MsgBox("Select Model Name")
            CmbShModel.Focus()
            Exit Sub
        End If



        If ChkType.Checked = True And CmbType.Text = "" Then
            MsgBox("Select Type Name")
            CmbType.Focus()
            Exit Sub
        End If

        If rdoforster.Checked = True Then
            Forster_Report()
        ElseIf Rdosecster.Checked = True Then
            Forsecster_Report()
        ElseIf rdobpl.Checked = True Then
            ForBpl_Report()
        ElseIf rdobxpkg.Checked = True Then
            Forbxpkg_Report()
        ElseIf rdodc.Checked = True Then
            Fordc_Report()
        Else
            MsgBox("Select type Of Report", MsgBoxStyle.Information)
            Exit Sub

        End If
    End Sub
    Public Sub Forster_Report()
        Dim cryRpt As New Process_StatusCollection

        CheckTMP_Report()

        Dim StrDtFr As String
        Dim StrDtTo As String



        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"

        StrSql = "select distinct P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic," & _
                 " P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 " convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo," & _
                 " convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, " & _
                 " P.Sterilization_No  into Tmpprsstatus from POUCH_LABEL P where Sterilization='0' " & _
                 " and created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'"

        If ChkType.Checked = True Then
            StrSql = StrSql & " and Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and Model_Name='" & CmbShModel.Text & "'"
        End If
        'StrSql = StrSql & " group by Model_Name,Power,Type,Optic,Length " & _
        '"order by  Brand_Name,Model_Name,Power,Type"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()

    End Sub
    Public Sub Forsecster_Report()
        Dim cryRpt As New Process_StatusCollection

        CheckTMP_Report()

        Dim StrDtFr As String
        Dim StrDtTo As String



        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"

        StrSql = "select distinct P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic," & _
                 " P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 " convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo," & _
                 " convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, " & _
                 " P.Sterilization_No  into Tmpprsstatus from POUCH_LABEL P where Sterilization='1' " & _
                 " and  Sterilization_After='0' and BPL_Taken='0' and created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'"

        If ChkType.Checked = True Then
            StrSql = StrSql & " and Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and Model_Name='" & CmbShModel.Text & "'"
        End If
        'StrSql = StrSql & " group by Model_Name,Power,Type,Optic,Length " & _
        '         "order by  Model_Name,Power,Type"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()

    End Sub
    Public Sub ForBpl_Report()
        Dim cryRpt As New Process_StatusCollection

        CheckTMP_Report()

        Dim StrDtFr As String
        Dim StrDtTo As String



        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"

        StrSql = "select distinct P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic," & _
                 " P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 " convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo," & _
                 " convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, " & _
                 " P.Sterilization_No  into Tmpprsstatus from POUCH_LABEL P where Sterilization='1' and " & _
                 " Sterilization_After='1' and  Box_Packing='0' and sample_Taken='0' and BPL_Taken='0'" & _
                 " and created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'"

        If ChkType.Checked = True Then
            StrSql = StrSql & " and Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and Model_Name='" & CmbShModel.Text & "'"
        End If
        'StrSql = StrSql & " group by Model_Name,Power,Type,Optic,Length " & _
        '         "order by  Model_Name,Power,Type"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()

    End Sub
    Public Sub Forbxpkg_Report()
        Dim cryRpt As New Process_StatusCollection

        CheckTMP_Report()

        Dim StrDtFr As String
        Dim StrDtTo As String



        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"

        StrSql = "select distinct P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic," & _
                 " P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 " convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo," & _
                 " convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, " & _
                 " P.Sterilization_No  into Tmpprsstatus from POUCH_LABEL P where Sterilization='1' and " & _
                 " Sterilization_After='1' and Box_Packing='0' and sample_Taken='0' and BPL_Taken='1'" & _
                 " and created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'"

        If ChkType.Checked = True Then
            StrSql = StrSql & " and Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and Model_Name='" & CmbShModel.Text & "'"
        End If
        'StrSql = StrSql & " group by Model_Name,Power,Type,Optic,Length " & _
        '         "order by  Model_Name,Power,Type"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()
        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()


    End Sub
    Public Sub Fordc_Report()
        Dim cryRpt As New Process_StatusCollection

        CheckTMP_Report()

        Dim StrDtFr As String
        Dim StrDtTo As String



        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"

        StrSql = "select distinct P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic," & _
                 " P.Length,P.Lot_Unit,P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 " convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo," & _
                 " convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, " & _
                 " P.Sterilization_No  into Tmpprsstatus from POUCH_LABEL P where Sterilization='0' and " & _
                 "Sterilization_After='1' and Box_Packing='1' and sample_Taken='0' and BPL_Taken='1'" & _
                 " and DC_Packing_List='0' " & _
                 " and created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'"

        If ChkType.Checked = True Then
            StrSql = StrSql & " and Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and Model_Name='" & CmbShModel.Text & "'"
        End If
        'StrSql = StrSql & " group by Model_Name,Power,Type,Optic,Length " & _
        '         "order by  Model_Name,Power,Type"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        RptViwCollection.CryViewCollectList.Update()
        RptViwCollection.CryViewCollectList.Validate()
        RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()

    End Sub


    Private Sub CheckTMP_Report()


        'Try

        '    SqlCk2 = "Drop Table NotorReadyStock"
        '    Cmd2 = New SqlCommand(SqlCk2, con)
        '    Cmd2.ExecuteNonQuery()
        '    Cmd2.Dispose()

        'Catch ex As Exception
        '    Cmd2.Dispose()

        'End Try


        Try

            SqlCk2 = "Drop Table Tmpprsstatus"
            Cmd2 = New SqlCommand(SqlCk2, con)
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()

        Catch ex As Exception
            Cmd2.Dispose()

        End Try



        'Try

        '    SqlCk2 = "Drop Table Tmp3"
        '    Cmd2 = New SqlCommand(SqlCk2, con)
        '    Cmd2.ExecuteNonQuery()
        '    Cmd2.Dispose()

        'Catch ex As Exception
        '    Cmd2.Dispose()

        'End Try


    End Sub
    Private Sub ChkType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkType.CheckedChanged
        If ChkType.Checked = True Then
            CmbType.Enabled = True
        Else
            CmbType.Enabled = False
        End If
    End Sub

    Private Sub ChkModel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkModel.CheckedChanged
        If ChkModel.Checked = True Then
            CmbShModel.Enabled = True
        Else
            CmbShModel.Enabled = False
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class