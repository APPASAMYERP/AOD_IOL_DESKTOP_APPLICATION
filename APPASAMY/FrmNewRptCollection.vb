
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports Microsoft.Reporting.WinForms

    Public Class FrmNewRptCollection

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim cmd3 As New SqlCommand
    Dim strs As SqlDataReader
    Dim Ds As New DataSet
    Private Sub FrmNewRptCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.NotorReadyStock' table. You can move, or remove it, as needed.
        'Me.NotorReadyStockTableAdapter.Fill(Me.DataSet2.NotorReadyStock)
        'TODO: This line of code loads data into the 'DataSet2.NotorReadyStock' table. You can move, or remove it, as needed.
        'Me.NotorReadyStockTableAdapter.Fill(Me.DataSet2.NotorReadyStock)
        'TODO: This line of code loads data into the 'DataSet2.NotorReadyStock' table. You can move, or remove it, as needed.
        ' Me.NotorReadyStockTableAdapter.Fill(Me.DataSet2.NotorReadyStock)
        'TODO: This line of code loads data into the 'DataSet2.NotorReadyStock' table. You can move, or remove it, as needed.
        ' Me.NotorReadyStockTableAdapter.Fill(Me.DataSet2.NotorReadyStock)

        Try
            ReportViewer1.Visible = False

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            StrSql = "SELECT DISTINCT Type from Lot_Type order by Type"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            CmbType.Items.Clear()
            While StrRs.Read
                CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
            End If
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            CmbShModel.Items.Clear()
            While StrRs.Read
                CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            StrSql = "SELECT DISTINCT Print_Name from Pouch_Label order by Print_Name"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            ComboBox1.Items.Clear()
            While StrRs.Read
                ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            StrSql = "SELECT DISTINCT  Type_GS_Code from LENS_MASTER "
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT  Type_GS_Code from LENS_MASTER1 "
            End If
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            Cmbgscode.Items.Clear()
            While StrRs.Read
                Cmbgscode.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            StrSql = "SELECT DISTINCT CAST(Power As Decimal(18,2)) AS Power from LENS_MASTER order by Power"
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT CAST(Power As Decimal(18,2)) AS Power from LENS_MASTER1 order by Power"
            End If
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            cmbfrmpower.Items.Clear()
            While StrRs.Read
                cmbfrmpower.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            StrSql = "SELECT DISTINCT CAST(Power As Decimal(18,2)) AS Power from LENS_MASTER order by Power"
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT CAST(Power As Decimal(18,2)) AS Power from LENS_MASTER1 order by Power"
            End If
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            Cmbtopower.Items.Clear()
            While StrRs.Read
                Cmbtopower.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()


            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub BtnSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSerch.Click

        Try
            If CheckBox1.Checked = True Then
                If ComboBox1.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid Reference Name")
                    ComboBox1.Focus() 
                    Exit Sub
                End If
            End If
            If ChkModel.Checked = True Then
                If CmbShModel.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid Model Name")
                    CmbShModel.Focus()
                    Exit Sub
                End If
            End If

            If ChkType.Checked = True Then
                If CmbType.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid Type Name")
                    CmbType.Focus()
                    Exit Sub
                End If
            End If

            If CheckBox3.Checked = True Then
                If cmbfrmpower.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid From Power")
                    cmbfrmpower.Focus()
                    Exit Sub
                End If
                If Cmbtopower.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid To Power")
                    Cmbtopower.Focus()
                    Exit Sub
                End If
            End If
             

            If CheckBox1.Checked = True And ComboBox1.Text = "" Then
                MsgBox("Select Reference Name")
                ComboBox1.Focus()
                Exit Sub
            End If

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

            If CheckBox3.Checked = True And cmbfrmpower.Text = "" Then
                MsgBox("Select From Power")
                cmbfrmpower.Focus()
                Exit Sub
            End If
            If CheckBox3.Checked = True And Cmbtopower.Text = "" Then
                MsgBox("Select To Power")
                Cmbtopower.Focus()
                Exit Sub
            End If

            If cmbfrmpower.Text <> "" And Cmbtopower.Text <> "" Then
                If Val(cmbfrmpower.Text) < Val(Cmbtopower.Text) Then
                Else
                    MsgBox("Plese Select Valid Power")
                    Cmbtopower.Focus()
                    Exit Sub
                End If
            End If




            If rdoColl.Checked = True Then
                Collection_Report()
            ElseIf RdoArStkRpt.Checked = True Then
                Aeration_Report()
            Else
                MsgBox("Select type Of Report", MsgBoxStyle.Information)
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub
    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Private Sub Aeration_Report()
        Try

            Dim Ds_new As New DataSet
            Dim Model_Names As String = ""
            Dim Brand_Names As String = ""

            Dim sterileCompleteDate As String
            Dim cryRpt As New CrystalReport8
            CheckTMP_Aero_Report()
            Dim StrDtFr As String
            Dim StrDtTo As String
            StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
            StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"


            'get brand names
            StrSql = "SELECT DISTINCT Brand_Name FROM   dbo.POUCH_LABEL AS POUCH_LABEL_2 " & _
                    "WHERE (Created_Date BETWEEN '" & StrDtFr & "' AND '" & StrDtTo & "') AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND " & _
                    " (Dc_Packing = 0) AND (Sterilization_Reject = 0) AND (Box_Reject = 0) AND (Dc_No IS NULL) AND (Type_GS_Code = 'aod') AND (Sterilization_After = '1') ReplaceType ReplacePrintName ReplaceModel "
            If ChkType.Checked = True Then
                StrSql = StrSql.Replace("ReplaceType", " and Type='" & CmbType.Text & "' ")
            Else
                StrSql = StrSql.Replace("ReplaceType", "")
            End If

            If ChkModel.Checked = True Then
                StrSql = StrSql.Replace("ReplaceModel", " and  Model_Name='" & CmbShModel.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplaceModel", "")
            End If

            If CheckBox1.Checked = True Then  'ReferenceName
                StrSql = StrSql.Replace("ReplacePrintName", " and Print_Name='" & ComboBox1.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplacePrintName", "")
            End If

            Ds_new = SQL_SelectQuery_Execute(StrSql)
            For Each eachRow1 As DataRow In Ds_new.Tables(0).Rows
                Brand_Names = Brand_Names + "'" + eachRow1("Brand_Name") + "',"
            Next

            If Brand_Names = "" Then
                Brand_Names = "''"
            Else
                Brand_Names = Brand_Names.Remove(Brand_Names.Length - 1, 1)
            End If


            'get model names
            StrSql = "SELECT DISTINCT Model_Name FROM   dbo.POUCH_LABEL AS POUCH_LABEL_1 " & _
                    "WHERE (Created_Date BETWEEN '" & StrDtFr & "' AND '" & StrDtTo & "') AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND " & _
                    " (Dc_Packing = 0) AND (Sterilization_Reject = 0) AND (Box_Reject = 0) AND (Dc_No IS NULL) AND (Type_GS_Code = 'aod') AND (Sterilization_After = '1') ReplaceType ReplacePrintName ReplaceModel"

            If ChkType.Checked = True Then
                StrSql = StrSql.Replace("ReplaceType", " and Type='" & CmbType.Text & "' ")
            Else
                StrSql = StrSql.Replace("ReplaceType", "")
            End If

            If ChkModel.Checked = True Then
                StrSql = StrSql.Replace("ReplaceModel", " and  Model_Name='" & CmbShModel.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplaceModel", "")
            End If

            If CheckBox1.Checked = True Then  'ReferenceName
                StrSql = StrSql.Replace("ReplacePrintName", " and Print_Name='" & ComboBox1.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplacePrintName", "")
            End If


            Ds_new = SQL_SelectQuery_Execute(StrSql)
            For Each eachRow1 As DataRow In Ds_new.Tables(0).Rows
                Model_Names = Model_Names + "'" + eachRow1("Model_Name") + "',"
            Next

            If Model_Names = "" Then
                Model_Names = "''"
            Else
                Model_Names = Model_Names.Remove(Model_Names.Length - 1, 1)
            End If


            sterileCompleteDate = Format(DateTime.Today.AddDays(-14), "yyyy-MM-dd") & " 00:00:01".ToString()

            StrSql = "SELECT TOP (100) PERCENT dbo.LENS_MASTER.Brand_Name , dbo.LENS_MASTER.Model_Name, dbo.LENS_MASTER.Power, CAST(CAST(LENS_MASTER.Optic AS varchar)  " & _
                    "+ ' X ' + CAST(LENS_MASTER.Length AS varchar) AS varchar) AS Size, SUM(CAST(CASE WHEN (CAST(PL.Sterilization_Date AS datetime) <= '" & sterileCompleteDate & "') " & _
                    "THEN '1' ELSE '0' END AS Integer)) AS TotReadyQty, SUM(CAST(CASE WHEN (CAST(PL.Sterilization_Date AS datetime) > '" & sterileCompleteDate & "') THEN '1' ELSE '0' END AS Integer)) AS NotReadyQty " & _
                "INTO     PouchStockTemp " & _
                "FROM  dbo.LENS_MASTER FULL OUTER JOIN " & _
                    "(SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Qty_1, Sterilization_Date " & _
                    "FROM   dbo.POUCH_LABEL AS POUCH_LABEL_1 " & _
                    " WHERE (Created_Date BETWEEN '" & StrDtFr & "' AND '" & StrDtTo & "') AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND " & _
                    " (Dc_Packing = 0) AND (Sterilization_Reject = 0) AND (Box_Reject = 0) AND (Dc_No IS NULL) AND (Type_GS_Code = 'aod') AND (Sterilization_After = '1') ReplaceType ReplacePrintName ReplaceModel) " & _
                    " AS PL ON dbo.LENS_MASTER.Power = PL.Power AND dbo.LENS_MASTER.Brand_Name = PL.Brand_Name AND dbo.LENS_MASTER.Model_Name = PL.Model_Name " & _
                "WHERE (dbo.LENS_MASTER.Power BETWEEN 'ReplaceFromPower' AND 'ReplaceToPower') AND (dbo.LENS_MASTER.Model_Name IN " & _
                    "(" & Model_Names & ")) " & _
                    "AND (dbo.LENS_MASTER.Brand_Name IN (" & Brand_Names & ")) " & _
                "GROUP BY dbo.LENS_MASTER.Brand_Name, dbo.LENS_MASTER.Model_Name, dbo.LENS_MASTER.Power, CASE WHEN (CAST(PL.Sterilization_Date AS datetime) > '" & sterileCompleteDate & "') THEN '1' ELSE '1' END, CAST(CAST(LENS_MASTER.Optic AS varchar) + ' X ' + CAST(LENS_MASTER.Length AS varchar) AS varchar) " & _
                "ORDER BY dbo.LENS_MASTER.Brand_Name, dbo.LENS_MASTER.Model_Name, dbo.LENS_MASTER.Power "

            'PMMA
            If productline = "PMMA" Then
                StrSql = "SELECT TOP (100) PERCENT dbo.LENS_MASTER1.Brand_Name , dbo.LENS_MASTER1.Model_Name, dbo.LENS_MASTER1.Power, CAST(CAST(LENS_MASTER1.Optic AS varchar)  " & _
                    "+ ' X ' + CAST(LENS_MASTER1.Length AS varchar) AS varchar) AS Size, SUM(CAST(CASE WHEN (CAST(PL.Sterilization_Date AS datetime) <= '" & sterileCompleteDate & "') " & _
                    "THEN '1' ELSE '0' END AS Integer)) AS TotReadyQty, SUM(CAST(CASE WHEN (CAST(PL.Sterilization_Date AS datetime) > '" & sterileCompleteDate & "') THEN '1' ELSE '0' END AS Integer)) AS NotReadyQty " & _
                "INTO     PouchStockTemp " & _
                "FROM  dbo.LENS_MASTER1 FULL OUTER JOIN " & _
                    "(SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Qty_1, Sterilization_Date " & _
                    "FROM   dbo.POUCH_LABEL AS POUCH_LABEL_1 " & _
                    " WHERE (Created_Date BETWEEN '" & StrDtFr & "' AND '" & StrDtTo & "') AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND " & _
                    " (Dc_Packing = 0) AND (Sterilization_Reject = 0) AND (Box_Reject = 0) AND (Dc_No IS NULL) AND (Type_GS_Code = 'aod') AND (Sterilization_After = '1') ReplaceType ReplacePrintName ReplaceModel) " & _
                    " AS PL ON dbo.LENS_MASTER1.Power = PL.Power AND dbo.LENS_MASTER1.Brand_Name = PL.Brand_Name AND dbo.LENS_MASTER1.Model_Name = PL.Model_Name " & _
                "WHERE (dbo.LENS_MASTER1.Power BETWEEN 'ReplaceFromPower' AND 'ReplaceToPower') AND (dbo.LENS_MASTER1.Model_Name IN " & _
                    "(" & Model_Names & ")) " & _
                    "AND (dbo.LENS_MASTER1.Brand_Name IN (" & Brand_Names & ")) " & _
                "GROUP BY dbo.LENS_MASTER1.Brand_Name, dbo.LENS_MASTER1.Model_Name, dbo.LENS_MASTER1.Power, CASE WHEN (CAST(PL.Sterilization_Date AS datetime) > '" & sterileCompleteDate & "') THEN '1' ELSE '1' END, CAST(CAST(LENS_MASTER1.Optic AS varchar) + ' X ' + CAST(LENS_MASTER1.Length AS varchar) AS varchar) " & _
                "ORDER BY dbo.LENS_MASTER1.Brand_Name, dbo.LENS_MASTER1.Model_Name, dbo.LENS_MASTER1.Power"
            End If





            If ChkType.Checked = True Then
                StrSql = StrSql.Replace("ReplaceType", " and Type='" & CmbType.Text & "' ")
            Else
                StrSql = StrSql.Replace("ReplaceType", "")
            End If

            If ChkModel.Checked = True Then
                StrSql = StrSql.Replace("ReplaceModel", " and  Model_Name='" & CmbShModel.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplaceModel", "")
            End If

            If CheckBox1.Checked = True Then  'ReferenceName
                StrSql = StrSql.Replace("ReplacePrintName", " and Print_Name='" & ComboBox1.Text & "'")
            Else
                StrSql = StrSql.Replace("ReplacePrintName", "")
            End If

            If CheckBox3.Checked = True Then  'ReferenceName
                StrSql = StrSql.Replace("ReplaceFromPower", cmbfrmpower.Text).Replace("ReplaceToPower", Cmbtopower.Text)
            Else
                StrSql = StrSql.Replace("ReplaceFromPower", "-20.00").Replace("ReplaceToPower", "50.00")
            End If


            Cmd = New SqlCommand(StrSql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()






            Dim Sql As String = "SELECT * FROM PouchStockTemp"
            Dim dscmd As New SqlDataAdapter(Sql, con)
            Dim ds As New DataSet1
            dscmd.Fill(ds)



            cryRpt.SetDataSource(ds.Tables(0))
            RptViwCollection.CryViewCollectList.ReportSource = cryRpt
            RptViwCollection.CryViewCollectList.Refresh()

            Dim DtF, DtT, RtMdl, Rttype, rtrefer As CrystalDecisions.CrystalReports.Engine.TextObject

            DtF = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtFrDate")
            DtT = cryRpt.ReportDefinition.Sections(0).ReportObjects("txttodate")
            RtMdl = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtrptmdl")
            Rttype = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtrpttype")
            rtrefer = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtrefer")


            DtF.Text = dtpfrom.Value
            DtT.Text = dtpto.Value

            If CheckBox1.Checked = True Then
                rtrefer.Text = ComboBox1.Text
            Else
                rtrefer.Text = "All"
            End If

            If ChkModel.Checked = True Then
                RtMdl.Text = CmbShModel.Text
            Else
                RtMdl.Text = "All"
            End If

            If ChkType.Checked = True Then
                Rttype.Text = CmbType.Text
            Else
                Rttype.Text = "All"
            End If

            RptViwCollection.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        



    End Sub

    Private Sub Collection_Report()
        Dim cryRpt As New CollectList

        CheckTMP_Collection_LIST()

        Dim StrDtFr As String
        Dim StrDtTo As String

        StrDtFr = Format(dtpfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        StrDtTo = Format(dtpto.Value, "yyyy-MM-dd") & " 23:59:59"


        StrSql = "Select distinct  convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No, " & _
                 "P.Model_Name,convert(varchar(30),P.Optic)+''+ ' X '+''+ convert(varchar(30),Length) as Length, " & _
                 "P.Power," & _
                 "min(Right(P.Lot_SrNo,3)) as Sfrom,Max(Right(P.Lot_SrNo,3))as STo,sum(P.Qty_1) as noofLens,L.Type " & _
                 "into CollectionTemp " & _
                 "from POUCH_LABEL P ,LENS_LOT L " & _
                 "WHERE(P.Lot_Prefix = L.Lot_Prefix And P.Lot_No = L.Lot_No)and P.created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'  "



        StrSql = "Select distinct  convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No, " & _
                 "P.Model_Name,convert(varchar(30),P.Optic)+''+ ' X '+''+ convert(varchar(30),Length) as Length, " & _
                 " P.Power,min(Right(P.Lot_SrNo,3)) as Sfrom,Max(Right(P.Lot_SrNo,3))as STo,sum(P.Qty_1) as noofLens, " & _
                 "p.Type " & _
                 " into CollectionTemp " & _
                 "from POUCH_LABEL P  WHERE " & _
                 "P.created_Date BETWEEN '" & StrDtFr & "' and '" & StrDtTo & "'  "

        If ChkType.Checked = True Then
            StrSql = StrSql & " and p.Type='" & CmbType.Text & "' "
        End If
        If ChkModel.Checked = True Then
            StrSql = StrSql & " and P.Model_Name='" & CmbShModel.Text & "'"
        End If

        'If rdobrand.Checked = True Then
        '    StrSql = StrSql & " and P.Model_Name='" & CmbShModel.Text & "'"
        'End If


        StrSql = StrSql & " group by P.Lot_Prefix ,P.Lot_No  , P.Model_Name,P.Optic, P.Length,P.Power,p.Type " & _
                 "order by Lot_No  , P.Model_Name, Length,P.Power"

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()


        RptViwCollection.CryViewCollectList.ReportSource = cryRpt

        Dim DtF, DtT, RtMdl, Rttype As CrystalDecisions.CrystalReports.Engine.TextObject


        DtF = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtFrDate")
        DtT = cryRpt.ReportDefinition.Sections(0).ReportObjects("txttodate")
        RtMdl = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtrptmdl")
        Rttype = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtrpttype")


        DtF.Text = dtpfrom.Value
        DtT.Text = dtpto.Value
        If ChkModel.Checked = True Then
            RtMdl.Text = CmbShModel.Text
        Else
            RtMdl.Text = "All"
        End If

        If ChkType.Checked = True Then
            Rttype.Text = CmbType.Text
        Else
            Rttype.Text = "All"
        End If

        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")

        Dim Sql As String = "SELECT * FROM CollectionTemp"
        Dim dscmd As New SqlDataAdapter(Sql, con)
        Dim ds As New DataSet1
        dscmd.Fill(ds)



        cryRpt.SetDataSource(ds.Tables(0))
        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        RptViwCollection.CryViewCollectList.Refresh()

        'RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        'cryRpt.VerifyDatabase()
        'RptViwCollection.CryViewCollectList.Update()
        'RptViwCollection.CryViewCollectList.Validate()
        'RptViwCollection.CryViewCollectList.Refresh()
        RptViwCollection.Show()
    End Sub


    Private Sub CheckTMP_Aero_Report()
        Try

            SqlCk2 = "Drop Table PouchStockTemp"
            Cmd2 = New SqlCommand(SqlCk2, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()


        Catch ex As Exception
            Cmd2.Dispose()

        End Try
    End Sub


    Private Sub CheckTMP_Collection_LIST()

        Try

            SqlCk2 = "Drop Table CollectionTemp"
            Cmd2 = New SqlCommand(SqlCk2, con)
            Cmd2.ExecuteNonQuery()
            Cmd2.Dispose()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged

    End Sub



    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
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

    Private Sub RdoArStkRpt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoArStkRpt.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then


            Cmbgscode.Enabled = True
        Else
            Cmbgscode.Enabled = False
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            cmbfrmpower.Enabled = True
            Cmbtopower.Enabled = True
        Else
            cmbfrmpower.Enabled = False
            Cmbtopower.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CheckBox1.Checked = True Then


        '    Cmbtopower.Enabled = True
        'Else
        '    Cmbtopower.Enabled = False
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged



        If CheckBox1.Checked = True Then


            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class