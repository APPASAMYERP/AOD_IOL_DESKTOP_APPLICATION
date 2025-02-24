





Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmBPLVIewFrm
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Sql As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand

    Private Sub RptBPLView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If con.State = Data.ConnectionState.Open Then
        '    con.Close()
        'End If

        'Try
        '    con.Open()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


        RptView()


    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        'CheckTMP_BPL_LIST()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        'Else
        '    MsgBox("Select Valid BPL No")
        '    StrRs.Close()
        '    Cmd.Dispose()
        '    Exit Sub
        'End If
        'StrRs.Close()
        'Cmd.Dispose()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "Into TMP_BPL_LIST " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        'Cmd = New SqlCommand(StrSql, con)
        'Cmd.ExecuteNonQuery()
        'Cmd.Dispose()


        'Dim cryRpt As New ReportDocument
        'cryRpt.Load(Application.StartupPath & "\bACKlIST.rpt")
        ''cryRpt.SetDatabaseLogon("sa", "admin123")

        ''cryRpt.SetDatabaseLogon("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=APS;Data Source=PHASEVIEW")
        ''cryRpt.SetDataSource()
        'cryRpt.VerifyDatabase()



        'CryViewBPLList.Update()

        'CryViewBPLList.ReportSource = cryRpt
        'CryViewBPLList.Refresh()









        'Dim cryRpt As New BPLCollection

        'CheckTMP_BPL_LIST()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        'Else
        '    MsgBox("Select Valid BPL No")
        '    StrRs.Close()
        '    Cmd.Dispose()
        '    Exit Sub
        'End If
        'StrRs.Close()
        'Cmd.Dispose()



        'StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Power as Power," & _
        '"P.Lot_No as LotNo, " & _
        '"right(Lot_srNo,3) as TotSno, " & _
        '"B.BPL_No as BPLNo,P.Sterilization_No as BatchNo " & _
        '"from POUCH_LABEL P,BPL_GEN B where  " & _
        '"P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '"P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "
        'Cmd = New SqlCommand(StrSql, con)
        'Cmd.ExecuteNonQuery()
        'Cmd.Dispose()

        'StAd = New SqlDataAdapter(StrSql, con)
        'StSet = New DataSet
        'StAd.Fill(StSet)

        ''Dim cryRpt As New ReportDocument
        ''cryRpt.Load(Application.StartupPath & "\DCPrintRpt.rpt")
        'cryRpt.SetDataSource(StSet.Tables(0))
        'CryViewBPLList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()



        'CryViewBPLList.Update()

        'CryViewBPLList.ReportSource = cryRpt
        'CryViewBPLList.Refresh()






        Dim cryRpt As New BPLCollection

        CheckTMP_BPL_LIST()

        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
                 "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Btc_No, " & _
                 "B.BPL_No, B.Created_By, B.Created_Date " & _
                 "from POUCH_LABEL P,BPL_GEN B where  " & _
                 "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
                 "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
        Else
            MsgBox("Select Valid BPL No.....")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()



        StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Power as Power," & _
        "P.Lot_No as LotNo, " & _
        "right(Lot_srNo,3) as TotSno, " & _
        "B.BPL_No as BPLNo,P.Btc_No as BatchNo " & _
        "from POUCH_LABEL P,BPL_GEN B where  " & _
        "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        StAd = New SqlDataAdapter(StrSql, con)
        StSet = New DataSet
        StAd.Fill(StSet)

        'Dim cryRpt As New ReportDocument
        'cryRpt.Load(Application.StartupPath & "\DCPrintRpt.rpt")
        cryRpt.SetDataSource(StSet.Tables(0))
        CryViewBPLList.ReportSource = cryRpt
        cryRpt.VerifyDatabase()



        CryViewBPLList.Update()

        CryViewBPLList.ReportSource = cryRpt
        CryViewBPLList.Refresh()








        'SqlCk2 = "Drop Table TMP_BPL_LIST"
        'Cmd2 = New SqlCommand(SqlCk2, con)
        'Cmd2.ExecuteNonQuery()
        'Cmd2.Dispose()

    End Sub
    Private Sub CheckTMP_BPL_LIST()


        Try
            SqlCk1 = "Select * from TMP_BPL_LIST"
            Cmd = New SqlCommand(SqlCk1, con)
            RsCk1 = Cmd.ExecuteReader
            If RsCk1.Read Then
                RsCk1.Close()
                Cmd.Dispose()
                SqlCk2 = "Drop Table TMP_BPL_LIST"
                Cmd2 = New SqlCommand(SqlCk2, con)
                Cmd2.ExecuteNonQuery()
                Cmd2.Dispose()
            End If
            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub RptView()
        CheckTMP_BPL_LIST()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        'Else
        '    MsgBox("Select Valid BPL No")
        '    StrRs.Close()
        '    Cmd.Dispose()
        '    Exit Sub
        'End If
        'StrRs.Close()
        'Cmd.Dispose()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "Into TMP_BPL_LIST " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        'Cmd = New SqlCommand(StrSql, con)
        'Cmd.ExecuteNonQuery()
        'Cmd.Dispose()


        'Dim cryRpt As New ReportDocument
        'Try


        '    cryRpt.Load(Application.StartupPath & "\bACKlIST.rpt")

        'Catch ex As Exception

        'End Try
        'cryRpt.SetDatabaseLogon("sa", "admin123")

        'cryRpt.SetDatabaseLogon("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=APS;Data Source=PHASEVIEW")
        'cryRpt.SetDataSource()
        'cryRpt.VerifyDatabase()



        'CryViewBPLList.Update()

        'CryViewBPLList.ReportSource = cryRpt
        'CryViewBPLList.Refresh()
        'CryViewBPLList.Width = Me.Width
        'CryViewBPLList.Height = Me.Width
        'CryViewBPLList.Top = 0

        'SqlCk2 = "Drop Table TMP_BPL_LIST"
        'Cmd2 = New SqlCommand(SqlCk2, con)
        'Cmd2.ExecuteNonQuery()
        'Cmd2.Dispose()


        '    Dim cryRpt As New BPLCollection

        '    CheckTMP_BPL_LIST()

        '    StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '             "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '             "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '             "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '             "B.BPL_No, B.Created_By, B.Created_Date " & _
        '             "from POUCH_LABEL P,BPL_GEN B where  " & _
        '             "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '             "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        '    Cmd = New SqlCommand(StrSql, con)
        '    StrRs = Cmd.ExecuteReader
        '    If StrRs.Read Then
        '    Else
        '        MsgBox("Select Valid BPL No")
        '        StrRs.Close()
        '        Cmd.Dispose()
        '        Exit Sub
        '    End If
        '    StrRs.Close()
        '    Cmd.Dispose()



        '    StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Power as Power," & _
        '    "P.Lot_No as LotNo, " & _
        '    "right(Lot_srNo,3) as TotSno, " & _
        '    "B.BPL_No as BPLNo,P.Sterilization_No as BatchNo " & _
        '    "from POUCH_LABEL P,BPL_GEN B where  " & _
        '    "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '    "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "
        '    Cmd = New SqlCommand(StrSql, con)
        '    Cmd.ExecuteNonQuery()
        '    Cmd.Dispose()

        '    StAd = New SqlDataAdapter(StrSql, con)
        '    StSet = New DataSet
        '    StAd.Fill(StSet)

        '    'Dim cryRpt As New ReportDocument
        '    'cryRpt.Load(Application.StartupPath & "\DCPrintRpt.rpt")
        '    cryRpt.SetDataSource(StSet.Tables(0))
        '    CryViewBPLList.ReportSource = cryRpt
        '    'cryRpt.VerifyDatabase()



        '    CryViewBPLList.Update()

        '    CryViewBPLList.ReportSource = cryRpt
        '    CryViewBPLList.Refresh()







        'End Sub
        'Private Sub CheckTMP_BPL_LIST()


        '    Try
        '        SqlCk1 = "Select * from TMP_BPL_LIST"
        '        Cmd = New SqlCommand(SqlCk1, con)
        '        RsCk1 = Cmd.ExecuteReader
        '        If RsCk1.Read Then
        '            RsCk1.Close()
        '            Cmd.Dispose()
        '            SqlCk2 = "Drop Table TMP_BPL_LIST"
        '            Cmd2 = New SqlCommand(SqlCk2, con)
        '            Cmd2.ExecuteNonQuery()
        '            Cmd2.Dispose()
        '        End If
        '        RsCk1.Close()
        '        Cmd.Dispose()
        '    Catch ex As Exception

        ' End Try


        Dim cryRpt As New BPLCollection

        CheckTMP_BPL_LIST()

        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
                 "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
                 "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Btc_No, " & _
                 "B.BPL_No, B.Created_By, B.Created_Date " & _
                 "from POUCH_LABEL P,BPL_GEN B where  " & _
                 "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
                 "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
        Else
            MsgBox("Select Valid BPL No")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()



        StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Power as Power," & _
        "P.Lot_No as LotNo, " & _
        "right(Lot_srNo,3) as TotSno, " & _
        "B.BPL_No as BPLNo,P.Btc_No as BatchNo " & _
        "from POUCH_LABEL P,BPL_GEN B where  " & _
        "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        StAd = New SqlDataAdapter(StrSql, con)
        StSet = New DataSet
        StAd.Fill(StSet)

        'Dim cryRpt As New ReportDocument
        'cryRpt.Load(Application.StartupPath & "\DCPrintRpt.rpt")
        cryRpt.SetDataSource(StSet.Tables(0))
        CryViewBPLList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()



        CryViewBPLList.Update()

        CryViewBPLList.ReportSource = cryRpt
        CryViewBPLList.Refresh()

    End Sub

    Private Sub CryViewBPLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CryViewBPLList.Load

    End Sub

    Private Sub CmbBPLNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBPLNo.SelectedIndexChanged

    End Sub
End Class