
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine

Public Class RptBPLView
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Sql As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Private Sub RptBPLView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            'StrSql = "select distinct BPL_No from BPL_GEN"

            'StrSql = " SELECT DISTINCT  top(30) BPL_NO,CONVERT(INT, SUBSTRING(BPL_NO,12,10) )AS BPL from Pouch_Label ORDER BY BPL DESC"
            StrSql = " SELECT DISTINCT   BPL_NO  from Pouch_Label ORDER BY BPL_NO DESC"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            CmbBPLNo.Items.Clear()
            While StrRs.Read
                CmbBPLNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()

            CheckTMP_BPL_LIST()

            CryViewBPLList.Width = Me.Width

            CryViewBPLList.Height = Me.Height - 100
            CryViewBPLList.Top = 51
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click

        Dim cryRpt As New BPLCollection

        'Dim cryRpt As New ReportDocument
        'cryRpt = New BPLCollection

        CheckTMP_BPL_LIST()

        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '         "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '         "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '         "B.BPL_No, B.Created_By, B.Created_Date " & _
        '         "from POUCH_LABEL P,BPL_GEN B where  " & _
        '         "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '         "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "


        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                 "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                 "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.BPL_No " & _
                 "from POUCH_LABEL P where" & _
                 " P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            'Dim STR As String
            'STR = StrRs.GetValue(0)


        Else
            MsgBox("Select Valid BPL No")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()




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


        'StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Reference_Name,P.GS_Code,P.Power as Power,P.Optic,P.Length,P.Lot_Unit," & _
        ' "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_No as LotNo,P.Lot_SrNo, " & _
        ' "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        ' "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No as BatchNo, " & _
        ' "B.BPL_No as BPLNo, B.Created_By, B.Created_Date " & _
        ' "from POUCH_LABEL P,BPL_GEN B where  " & _
        ' "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        ' "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "
        'Cmd = New SqlCommand(StrSql, con)
        'Cmd.ExecuteNonQuery()
        'Cmd.Dispose()

        'Brand()'
        'Model()'
        'Power()'
        'LotNo()'
        'TotSno()'
        'BPLNo()'
        'BatchNo()'

        'StrSql = "select P.Brand_Name as Brand,P.Model_Name as Model,P.Power as Power," & _
        '"P.Lot_No as LotNo, " & _
        '"right(Lot_srNo,3) as TotSno, " & _
        '"B.BPL_No as BPLNo,P.Sterilization_No as BatchNo " & _
        '"from POUCH_LABEL P,BPL_GEN B where  " & _
        '"P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '"P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model "


        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit," & _
        '        "P.A_Constant,P.Type_GS_Code,1 as Qty,P.Lot_SrNo, " & _
        '        "convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '        "convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, " & _
        '        "B.BPL_No, B.Created_By, CONVERT(VARCHAR(10),B.Created_Date ,103)  as Created_Date " & _
        '        "into BPLCollectionList from POUCH_LABEL P,BPL_GEN B where  " & _
        '        "P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND " & _
        '        "P.Power=B.Power AND P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "


        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
        '         "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
        '         "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, B.BPL_No, B.Created_By, " & _
        '         "CONVERT(VARCHAR(10),B.Created_Date ,103)  as Created_Date  " & _
        '         "into BPLCollectionList " & _
        '         "from POUCH_LABEL P,BPL_GEN B  " & _
        '         "where  P.BPL_NO=B.BPL_NO AND P.Model_Name=B.Model_Name AND P.Brand_Name=B.Brand_Name AND P.Power=B.Power AND " & _
        '         "P.Type_GS_Code=B.Type_GS_Code AND P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        CheckTMP_BPL_LIST()


        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
        '         "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
        '         "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '         " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.BPL_No " & _
        '         "into BPLCollectionList " & _
        '         "from POUCH_LABEL P where" & _
        '         " P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name,lOT_nO,SRNO "

        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
         "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
         "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
         " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.BPL_No ,p.Ord_Country " & _
         "into BPLCollectionList " & _
         "from POUCH_LABEL P where" & _
         " P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name,lOT_nO,SRNO "

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        'StAd = New SqlDataAdapter(StrSql, con)
        'StSet = New DataSet
        'StAd.Fill(StSet)

        'Dim cryRpt As New ReportDocument
        'cryRpt.Load(Application.StartupPath & "\BPLCollection.rpt")
        ''cryRpt.SetDataSource(StSet.Tables(0))
        'CryViewBPLList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()

        'CryViewBPLList.


        ' cryRpt.SetDatabaseLogon("sa", "iol123!@#")

        cryRpt.SetDatabaseLogon("sa", "data123!@#")
        CryViewBPLList.ReportSource = cryRpt
        ' CryViewBPLList.d()

        'cryRpt.VerifyDatabase()
        CryViewBPLList.Update()
        CryViewBPLList.Validate()
        CryViewBPLList.Refresh()
        CryViewBPLList.Show()
        'CryViewBPLList.set()


        'SqlCk2 = "Drop Table TMP_BPL_LIST"
        'Cmd2 = New SqlCommand(SqlCk2, con)
        'Cmd2.ExecuteNonQuery()
        'Cmd2.Dispsose()










        'Dim cryRpt As New ReportDocument
        'cryRpt.Load(Application.StartupPath & "\bACKlIST.rpt")
        ''cryRpt.SetDatabaseLogon("sa", "admin123")

        ''cryRpt.SetDatabaseLogon("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=APS;Data Source=PHASEVIEW")
        ''cryRpt.SetDataSource()
        'cryRpt.VerifyDatabase()



        'CryViewBPLList.Update()

        'CryViewBPLList.ReportSource = cryRpt
        'CryViewBPLList.Refresh()


        'SqlCk2 = "Drop Table TMP_BPL_LIST"
        'Cmd2 = New SqlCommand(SqlCk2, con)
        'Cmd2.ExecuteNonQuery()
        'Cmd2.Dispose()

    End Sub

    Private Sub CheckTMP_BPL_LIST()


      

        Try
       
            SqlCk2 = "Drop Table BPLCollectionList"
            Cmd2 = New SqlCommand(SqlCk2, con)
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()

            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
        '    "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
        '    "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
        '    " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate, P.btc_no  as Sterilization_No, P.BPL_No, p.Ord_Country " & _
        '    "from POUCH_LABEL P where" & _
        '    " P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name,Lot_srno,srno "   '"into BPLCollectionList " & _

        Try
            If CmbBPLNo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid BPL NO")
                CmbBPLNo.Focus() 
                Exit Sub
            End If

            StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                 "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                 "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No,P.BPL_No, P.Ord_Country, P.Btc_No,P.Tray_no as Tray_No, P.Rack_Location as Rack_No " & _
                 "from POUCH_LABEL P where" & _
                 " P.BPL_NO='" & CmbBPLNo.Text & "' order by Model_Name, Lot_srno,srno "

            Cmd = New SqlCommand(StrSql, con)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(ds)

            Dim cryRpt As New BPLCollection
            cryRpt.SetDataSource(ds.Tables(0))
            CryViewBPLList.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        



    End Sub
End Class