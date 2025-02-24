Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration
Imports System.Globalization



Public Class FrmBoxPackingRecord

    Dim StrRs, StrRs1 As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql As String
    Dim table As New DataTable
    Dim Ds, ds_Philic, ds_Phobic, ds_Np, ds_Pmma As New DataSet
    Private rowIndex As Integer = 0
    Dim totBPLQty As Integer = 0
    Dim StAd As New SqlDataAdapter

    Public Function SQL_SelectQuery_Execute_with_ConString(ByVal StrSql As String, ByVal conStr As SqlConnection) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, conStr)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

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

    Private Sub FrmBoxPackingRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            StrSql = " SELECT DISTINCT   BPL_NO  from Pouch_Label WHERE box_packing ='1' ORDER BY BPL_NO DESC"
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbBPLNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbBPLNo.Items.Add(eachRow1("BPL_NO"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub CheckTMP_BPL_LIST()
        Try
            StrSql = "Drop Table  temBPL_Model_with_Power"
            UpdateorInsertQuery_Execute(StrSql)
        Catch ex As Exception
        End Try

        Try
            StrSql = "Drop Table  tempBPL_Rejection"
            UpdateorInsertQuery_Execute(StrSql)
        Catch ex As Exception
        End Try

        Try
            StrSql = "Drop Table   tempBPL_Lot"
            UpdateorInsertQuery_Execute(StrSql)
        Catch ex As Exception
        End Try








    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            Dim prePackedBPL As String = ""

            'CheckTMP_BPL_LIST()
            If CmbBPLNo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid BPL No")
                CmbBPLNo.Focus() 
                Exit Sub
            End If


            'MODEL LENGTH POWER
            Dim cryRpt As New BoxPackingWithInspection
            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "'  SELECT     Model_Name, CAST(Length AS VARCHAR) AS Len, Min(Power) as From_Power, Max(Power) as To_Power  FROM    POUCH_LABEL  " & _
                    "Where BPL_NO=@BPL_NO GROUP BY Model_Name, Length  ORDER BY Model_Name, Length  "
            Ds = SQL_SelectQuery_Execute(StrSql)
            cryRpt.Database.Tables(0).SetDataSource(Ds.Tables(0))


            'INSPECTION
            StrSql = "SELECT     Lot_SrNo, CASE WHEN Reason_of_Rejection = 'DOUBLE LENS' THEN (SELECT     Icon FROM          icon_table    " & _
                    "WHERE      Name = 'tick') ELSE NULL END AS DOUBLE_LENS, CASE WHEN Reason_of_Rejection = 'SEALING OPEN' THEN " & _
            "(SELECT     Icon  FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS SEALING_OPEN, CASE WHEN Reason_of_Rejection = 'BURR' THEN  " & _
            "(SELECT     Icon FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS BURR, CASE WHEN Reason_of_Rejection = 'THREAD' THEN  " & _
            "(SELECT     Icon  FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS THREAD, CASE WHEN Reason_of_Rejection = 'LIQUID LEVEL' THEN " & _
            "(SELECT     Icon FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS LIQUID_LEVEL, CASE WHEN Reason_of_Rejection = 'TRIM' THEN " & _
            "(SELECT     Icon FROM          icon_table  WHERE      Name = 'tick') ELSE NULL END AS TRIM, CASE WHEN Reason_of_Rejection = 'DAMAGE' THEN " & _
            "(SELECT     Icon  FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS DAMAGE, CASE WHEN Reason_of_Rejection = 'DUST' THEN " & _
            "(SELECT     Icon  FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS DUST, CASE WHEN Reason_of_Rejection = 'DOTS' THEN " & _
            " (SELECT     Icon FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS DOTS, CASE WHEN Reason_of_Rejection = 'HAIR' THEN " & _
            " (SELECT     Icon FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS HAIR, CASE WHEN Reason_of_Rejection = 'OTHERS' THEN " & _
            "(SELECT     Icon  FROM          icon_table WHERE      Name = 'tick') ELSE NULL END AS OTHERS FROM         Box_Inspection_Rejection_Serials WHERE     (BPL_No = '" & CmbBPLNo.Text & "') "
            Ds = SQL_SelectQuery_Execute(StrSql)
            cryRpt.Database.Tables(1).SetDataSource(Ds.Tables(0))

            Dim txtInsrejQty, txtIns_date, txtInsMTS_No, txtCurPacked_exp, txtCurPacked_mfd, txtCurPackedEnd_time, txtCurPackedstart_time, txtCurPackedQty, txtCurPackedModel, txtCur_packedDate, txtStation, txtCur_BPL, txtIns_RecQty, txtIns_AccQty, txtIns_RejQty, txtInsBy, txtBPLNo, txtBoxDate, txtBrand As CrystalDecisions.CrystalReports.Engine.TextObject
            txtBPLNo = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtBPLNo")
            txtBPLNo.Text = CmbBPLNo.Text
            txtIns_RecQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtIns_RecQty")
            txtIns_AccQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtIns_AccQty")
            txtIns_RejQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtIns_RejQty")
            txtInsBy = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtInsBy")
            txtBoxDate = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtBoxDate")
            txtBrand = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtBrand")
            txtStation = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtStation")
            txtCur_BPL = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCur_BPL")
            txtCur_packedDate = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCur_packedDate")
            txtCurPackedModel = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPackedModel")
            txtCurPackedQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPackedQty")
            txtCurPackedstart_time = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPackedstart_time")
            txtCurPackedEnd_time = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPackedEnd_time")
            'txtCurPacked_mfd = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPacked_mfd")
            'txtCurPacked_exp = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtCurPacked_exp")
            txtInsrejQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtInsrejQty")
            txtIns_date = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtIns_date")
            txtInsMTS_No = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtInsMTS_No")

            'INSPECTION DETAILS-------------------------------------------
            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "' SELECT     Rec_Qty, Acc_Qty, Rej_Qty, (SELECT DISTINCT Emp_Name  FROM          LOGIN WHERE      (UserName =  (SELECT DISTINCT Inspection_By  FROM          Box_Inspection_Details WHERE      (BPL_No = @BPL_NO)))) AS Inspection_By, " & _
                    " REPLACE(CONVERT(varchar, Inspection_date, 111), '/', '-') AS Inspect_date,  MTS_No  FROM         Box_Inspection_Details " & _
            "WHERE     (BPL_No = @BPL_NO) "
            Ds = SQL_SelectQuery_Execute(StrSql)
            If Ds.Tables(0).Rows.Count = 1 Then
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    txtIns_RecQty.Text = eachRow1("Rec_Qty")
                    txtIns_AccQty.Text = eachRow1("Acc_Qty")
                    txtIns_RejQty.Text = eachRow1("Rej_Qty")
                    txtInsBy.Text = eachRow1("Inspection_By")

                    If Val(eachRow1("Rej_Qty")) > 0 Then
                        txtInsrejQty.Text = eachRow1("Rej_Qty")
                        txtIns_date.Text = Convert.ToDateTime(eachRow1("Inspect_date")).ToString("dd-MM-yyyy")
                        txtInsMTS_No.Text = eachRow1("MTS_No")
                    Else
                        txtInsrejQty.Text = ""
                        txtIns_date.Text = ""
                        txtInsMTS_No.Text = ""
                    End If

                    txtBoxDate.Text = Convert.ToDateTime(eachRow1("Inspect_date")).ToString("dd-MM-yyyy")
                Next
            Else
                MessageBox.Show("Inspection Details Not present or multiple time present. Please contact ERP Team")
                Exit Sub
            End If
            '--------------------------------------------------------------------------------------

            'Get Station name-------------------------------------------
            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "'  SELECT     distinct Station  FROM         POUCH_LABEL WHERE     (BPL_NO = @BPL_NO ) AND (Box_Packing = '1') AND (Station NOT IN ('POUCHSTATION1', 'POUCHSTATION2', 'PHOBICSTERILE1', 'SUPERVISOR',  'AREATION')) AND (Box_By NOT IN (SELECT DISTINCT UserName FROM          LOGIN WHERE      (boxLabelReprint = '1'))) "
            Ds = SQL_SelectQuery_Execute(StrSql)

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtStation.Text = eachRow1("Station")
                Exit For
            Next

            '--------------------------------------------------------------------------------------

            'CURRENT PACKED BPL DETAILS-------------------------------------------
            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "' SELECT      Brand_Name,Station, REPLACE(CONVERT(varchar, Boxtime, 111), '/', '-') AS Box_date, Model_Name, BPL_NO, SUM(Box_Packing) AS Packed_qty, MIN(CONVERT(char(5), Boxtime,   " & _
                    "108)) AS start_time, MAX(CONVERT(char(5), Boxtime, 108)) AS end_time, CAST(Mfd_Year AS varchar) + '/' + RIGHT('00' + CAST(Mfd_Month AS varchar), 2) AS mfd_date,  " & _
                    "CAST(Exp_Year AS varchar) + '/' + RIGHT('00' + CAST(Exp_Month AS varchar), 2) AS exp_date  " & _
                    "FROM         POUCH_LABEL WHERE     (BPL_NO = @BPL_NO) AND (Box_Packing = '1') " & _
                    "GROUP BY Station, REPLACE(CONVERT(varchar, Boxtime, 111), '/', '-'), Model_Name, BPL_NO, Mfd_Year, Mfd_Month, Exp_Year, Exp_Month,  Brand_Name  "
            Ds = SQL_SelectQuery_Execute(StrSql)

            Dim Cur_Packed_qty As Integer = 0
            Dim cur_mfd As String = ""
            Dim cur_exp As String = ""
            Dim cur_stratTime As TimeSpan = TimeSpan.Parse("23:59")
            Dim cur_endTime As TimeSpan = TimeSpan.Parse("00:01")

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtBrand.Text = eachRow1("Brand_Name")
                'txtBoxDate.Text = eachRow1("Box_date")
                'txtStation.Text = eachRow1("Station")
                txtCur_BPL.Text = eachRow1("BPL_NO")
                txtCur_packedDate.Text = Convert.ToDateTime(eachRow1("Box_date")).ToString("dd-MM-yyyy")
                txtCurPackedModel.Text = eachRow1("Model_Name")
                Exit For
            Next

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                Cur_Packed_qty = Cur_Packed_qty + eachRow1("Packed_qty")
                If Not cur_mfd.Contains(eachRow1("mfd_date")) Then
                    cur_mfd = eachRow1("mfd_date") + ", " + cur_mfd
                End If
                If Not cur_exp.Contains(eachRow1("exp_date")) Then
                    cur_exp = eachRow1("exp_date") + ", " + cur_exp
                End If

                If cur_stratTime > TimeSpan.Parse(eachRow1("start_time")) Then
                    cur_stratTime = TimeSpan.Parse(eachRow1("start_time"))
                End If
                If cur_endTime < TimeSpan.Parse(eachRow1("end_time")) Then
                    cur_endTime = TimeSpan.Parse(eachRow1("end_time"))
                End If
            Next
            cur_exp = cur_exp.Remove(cur_exp.Length - 2, 2)
            cur_mfd = cur_mfd.Remove(cur_mfd.Length - 2, 2)

            txtCurPackedQty.Text = Cur_Packed_qty
            txtCurPackedstart_time.Text = cur_stratTime.ToString()
            txtCurPackedEnd_time.Text = cur_endTime.ToString()
            'txtCurPacked_mfd.Text = cur_mfd
            'txtCurPacked_exp.Text = cur_exp
            '--------------------------------------------------------------------------------------

            'validation--------------------------------------------------------------------------------------
            If Val(txtCurPackedQty.Text) <> Val(txtIns_AccQty.Text) Then
                MessageBox.Show("The BPL is Not Fully packed. Please check")
                Exit Sub
            End If

            '--------------------------------------------------------------------------------------



            'PREVIOUS PACKED BPL DETAILS-------------------------------------------
            Dim start_time As String = ""

            Dim txtPrePacked_exp, txtPrePacked_mfd, txtPrePackedEnd_time, txtPrePackedstart_time, txtPrePackedQty, txtPrePackedModel, txtPre_packedDate, txtPre_BPL As CrystalDecisions.CrystalReports.Engine.TextObject
            txtPre_BPL = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPre_BPL")
            txtPre_packedDate = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPre_packedDate")
            txtPrePackedModel = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePackedModel")
            txtPrePackedQty = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePackedQty")
            txtPrePackedstart_time = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePackedstart_time")
            txtPrePackedEnd_time = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePackedEnd_time")
            'txtPrePacked_mfd = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePacked_mfd")
            'txtPrePacked_exp = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPrePacked_exp")

            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "' SELECT     MIN(Boxtime) AS start_time FROM         POUCH_LABEL WHERE     (BPL_NO = @BPL_NO) AND (Box_Packing = '1') AND (Station NOT IN ('POUCHSTATION1', 'POUCHSTATION2', 'PHOBICSTERILE1', 'SUPERVISOR',  'AREATION')) AND (Box_By NOT IN (SELECT DISTINCT UserName FROM          LOGIN WHERE      (boxLabelReprint = '1')))"
            Ds = SQL_SelectQuery_Execute(StrSql)
            If Ds.Tables(0).Rows.Count = 1 Then
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    start_time = DateTime.Parse(eachRow1("start_time")).ToString("yyyy-MM-dd HH:mm:ss")
                Next
            Else
                MessageBox.Show("The BPL is Not Packed.")
                Exit Sub
            End If

            StrSql = "DECLARE @Station VARCHAR(50)  = '" & txtStation.Text & "' SELECT     TOP (1) BPL_NO, Boxtime FROM         POUCH_LABEL WHERE     (Box_Packing = '1') AND (Boxtime < '" & start_time & "') AND (Station = @Station ) AND (Box_Packing = '1') AND (Station NOT IN ('POUCHSTATION1', 'POUCHSTATION2', 'PHOBICSTERILE1', 'SUPERVISOR',  'AREATION')) AND (BPL_NO IS NOT NULL) AND (Box_By NOT IN (SELECT DISTINCT UserName FROM          LOGIN WHERE      (boxLabelReprint = '1'))) ORDER BY Boxtime DESC "

            'PHILIC
            Dim conStringPhilic As String = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
            Dim conPhilic As SqlConnection
            conPhilic = New SqlConnection(conStringPhilic)
            'PHOBIC
            Dim conStringPhobic As String = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
            Dim conPhobic As SqlConnection
            conPhobic = New SqlConnection(conStringPhobic)
            'Non Preloaded
            Dim conStringNP As String = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
            Dim conNP As SqlConnection
            conNP = New SqlConnection(conStringNP)
            'PMMA
            Dim conStringPMMA As String = ConfigurationSettings.AppSettings("conStrPMMA").ToString()
            Dim conPMMA As SqlConnection
            conPMMA = New SqlConnection(conStringPMMA)


            ds_Philic = SQL_SelectQuery_Execute_with_ConString(StrSql, conPhilic)
            ds_Phobic = SQL_SelectQuery_Execute_with_ConString(StrSql, conPhobic)
            ds_Np = SQL_SelectQuery_Execute_with_ConString(StrSql, conNP)
            ds_Pmma = SQL_SelectQuery_Execute_with_ConString(StrSql, conPMMA)

            Dim philic_date, phobic_date, np_date, pmma_date As DateTime
            If ds_Philic.Tables(0).Rows.Count > 0 Then
                philic_date = ds_Philic.Tables(0).Rows(0)("Boxtime")
            Else
                philic_date = "2020-10-17 10:00:01"
            End If
            If ds_Phobic.Tables(0).Rows.Count > 0 Then
                phobic_date = ds_Phobic.Tables(0).Rows(0)("Boxtime")
            Else
                phobic_date = "2020-10-17 10:00:01"
            End If
            If ds_Np.Tables(0).Rows.Count > 0 Then
                np_date = ds_Np.Tables(0).Rows(0)("Boxtime")
            Else
                np_date = "2020-10-17 10:00:01"
            End If
            If ds_Pmma.Tables(0).Rows.Count > 0 Then
                pmma_date = ds_Pmma.Tables(0).Rows(0)("Boxtime")
            Else
                pmma_date = "2020-10-17 10:00:01"
            End If


            Dim prePackedProduct As String = ""

            If philic_date >= phobic_date AndAlso philic_date >= np_date AndAlso philic_date >= pmma_date Then
                prePackedBPL = ds_Philic.Tables(0).Rows(0)("BPL_NO")
                prePackedProduct = "PHILIC"
            ElseIf phobic_date >= philic_date AndAlso phobic_date >= np_date AndAlso phobic_date >= pmma_date Then
                prePackedBPL = ds_Phobic.Tables(0).Rows(0)("BPL_NO")
                prePackedProduct = "PHOBIC"
            ElseIf np_date >= philic_date AndAlso np_date >= phobic_date AndAlso np_date >= pmma_date Then
                prePackedBPL = ds_Np.Tables(0).Rows(0)("BPL_NO")
                prePackedProduct = "NP"
            Else
                prePackedBPL = ds_Pmma.Tables(0).Rows(0)("BPL_NO")
                prePackedProduct = "PMMA"
            End If



            StrSql = " DECLARE @BPL_NO NVARCHAR(50)  = '" & prePackedBPL & "'     SELECT     Station, REPLACE(CONVERT(varchar, Boxtime, 111), '/', '-') AS Box_date, Model_Name, BPL_NO, SUM(Box_Packing) AS Packed_qty, MIN(CONVERT(char(5), Boxtime, " & _
                    "108)) AS start_time, MAX(CONVERT(char(5), Boxtime, 108)) AS end_time, CAST(Mfd_Year AS varchar) + '/' + RIGHT('00' + CAST(Mfd_Month AS varchar), 2) AS mfd_date, " & _
            "CAST(Exp_Year AS varchar) + '/' + RIGHT('00' + CAST(Exp_Month AS varchar), 2) AS exp_date FROM         POUCH_LABEL " & _
            "WHERE     (BPL_NO = @BPL_NO ) AND (Box_Packing = '1') GROUP BY Station, REPLACE(CONVERT(varchar, Boxtime, 111), '/', '-'), Model_Name, BPL_NO, Mfd_Year, Mfd_Month, Exp_Year, Exp_Month "


            If prePackedProduct = "PHILIC" Then
                Ds = SQL_SelectQuery_Execute_with_ConString(StrSql, conPhilic)
            ElseIf prePackedProduct = "PHOBIC" Then
                Ds = SQL_SelectQuery_Execute_with_ConString(StrSql, conPhobic)
            ElseIf prePackedProduct = "NP" Then
                Ds = SQL_SelectQuery_Execute_with_ConString(StrSql, conNP)
            ElseIf prePackedProduct = "PMMA" Then
                Ds = SQL_SelectQuery_Execute_with_ConString(StrSql, conPMMA)
            End If


            Dim Pre_Packed_qty As Integer = 0
            Dim Pre_mfd As String = ""
            Dim Pre_exp As String = ""
            Dim Pre_stratTime As TimeSpan = TimeSpan.Parse("23:59")
            Dim Pre_endTime As TimeSpan = TimeSpan.Parse("00:01")

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtPre_BPL.Text = eachRow1("BPL_NO")
                txtPre_packedDate.Text = Convert.ToDateTime(eachRow1("Box_date")).ToString("dd-MM-yyyy")
                txtPrePackedModel.Text = eachRow1("Model_Name")
                Exit For
            Next

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                Pre_Packed_qty = Pre_Packed_qty + eachRow1("Packed_qty")
                If Not Pre_mfd.Contains(eachRow1("mfd_date")) Then
                    Pre_mfd = eachRow1("mfd_date") + ", " + Pre_mfd
                End If
                If Not Pre_exp.Contains(eachRow1("exp_date")) Then
                    Pre_exp = eachRow1("exp_date") + ", " + Pre_exp
                End If

                If Pre_stratTime > TimeSpan.Parse(eachRow1("start_time")) Then
                    Pre_stratTime = TimeSpan.Parse(eachRow1("start_time"))
                End If
                If Pre_endTime < TimeSpan.Parse(eachRow1("end_time")) Then
                    Pre_endTime = TimeSpan.Parse(eachRow1("end_time"))
                End If
            Next
            Pre_mfd = Pre_mfd.Remove(Pre_mfd.Length - 2, 2)
            Pre_exp = Pre_exp.Remove(Pre_exp.Length - 2, 2)

            txtPrePackedQty.Text = Pre_Packed_qty
            txtPrePackedstart_time.Text = Pre_stratTime.ToString()
            txtPrePackedEnd_time.Text = Pre_endTime.ToString()
            'txtPrePacked_mfd.Text = Pre_mfd
            'txtPrePacked_exp.Text = Pre_exp

            '--------------------------------------------------------------------------------------

            'LABEL PRINTED & PACKED BY DETAILS-------------------------------------------
            Dim txtLabelPrintedBy, txtLabelPackedBy, txtPriPackedBy As CrystalDecisions.CrystalReports.Engine.TextObject
            txtLabelPrintedBy = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtLabelPrintedBy")
            txtLabelPackedBy = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtLabelPackedBy")
            txtPriPackedBy = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtPriPackedBy")

            Dim LabelPrintedBy As String = ""
            Dim LabelPackedBy As String = ""
            Dim boxtime As String = ""
            Dim station As String = ""

            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "'   SELECT     TOP (1) Station, Box_By, Boxtime FROM         POUCH_LABEL  " & _
                    "WHERE     (BPL_NO = @BPL_NO) AND (Box_Packing = '1') AND (Box_Packing = '1') AND (Station NOT IN ('POUCHSTATION1', 'POUCHSTATION2', 'PHOBICSTERILE1', 'SUPERVISOR',  'AREATION')) AND (Box_By NOT IN (SELECT DISTINCT UserName FROM          LOGIN WHERE      (boxLabelReprint = '1'))) ORDER BY Boxtime "
            Ds = SQL_SelectQuery_Execute(StrSql)

            If Ds.Tables(0).Rows.Count = 1 Then
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    LabelPrintedBy = eachRow1("Box_By")
                    boxtime = eachRow1("Boxtime")
                    station = eachRow1("Station")
                Next
            Else
                MessageBox.Show("Packed Details Not present. Contact ERP Team")
                Exit Sub
            End If
            StrSql = "DECLARE @Station VARCHAR(50)  = '" & txtStation.Text & "'   SELECT DISTINCT Printed_By, Packed_By FROM         Reaon_of_Packing  " & _
                    "WHERE     ('" & boxtime & "' BETWEEN DateTimeFrom AND DateTimeTo) AND (Station = @Station) "
            Ds = SQL_SelectQuery_Execute(StrSql)

            If Ds.Tables(0).Rows.Count = 1 Then
                If Ds.Tables(0).Rows(0)("Printed_By").ToString().Contains(LabelPrintedBy) Then
                    LabelPrintedBy = Ds.Tables(0).Rows(0)("Printed_By").ToString().Split("-")(0)
                    LabelPackedBy = Ds.Tables(0).Rows(0)("Packed_By").ToString().Split("-")(0)
                Else
                    LabelPackedBy = Ds.Tables(0).Rows(0)("Printed_By").ToString().Split("-")(0)
                    LabelPrintedBy = Ds.Tables(0).Rows(0)("Packed_By").ToString().Split("-")(0)
                End If
            Else
                MessageBox.Show("Packing Entry details not present or multiple time present.   Contact ERP Team")
                Exit Sub
            End If

            txtLabelPrintedBy.Text = LabelPrintedBy
            txtLabelPackedBy.Text = LabelPackedBy
            txtPriPackedBy.Text = LabelPrintedBy + " / " + LabelPackedBy
            '--------------------------------------------------------------------------------------
            'Total Packed Lens  LOT WISE - QTY -------------------------------------------

            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "' SELECT     Lot_Prefix + Lot_No AS lot_number, SUM(Qty_1) AS Qty FROM         POUCH_LABEL  " & _
                    "WHERE     (BPL_NO = @BPL_NO) AND (Box_Packing = '1') GROUP BY Lot_Prefix, Lot_No ORDER BY Lot_Prefix, Lot_No "

            Ds = SQL_SelectQuery_Execute(StrSql)
            cryRpt.Database.Tables(2).SetDataSource(Ds.Tables(0))


            '--------------------------------------------------------------------------------------

            'Label Pasted Lot Serial No-------------------------------------------

            'StrSql = "SELECT     Btc_No, MIN(Lot_SrNo) AS From_Serial, MAX(Lot_SrNo) AS To_Serial FROM         POUCH_LABEL  " & _
            '        "WHERE     (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') GROUP BY Btc_No ORDER BY From_Serial "


            'StrSql = "SELECT     Btc_No,  " & _
            '        " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL WHERE      (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') AND (Btc_No = POUCH_LABEL_1.Btc_No) ORDER BY Lot_Prefix + Lot_No, Power,  Lot_SrNo) AS From_Serial, " & _
            '        " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL AS POUCH_LABEL_2 WHERE      (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') AND (Btc_No = POUCH_LABEL_1.Btc_No) ORDER BY Lot_Prefix + Lot_No DESC, Power DESC, Lot_SrNo DESC) AS To_Serial " & _
            '        "FROM         POUCH_LABEL AS POUCH_LABEL_1 WHERE     (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') GROUP BY Btc_No ORDER BY From_Serial "
            '----------------------------------
            'Dim batches As New List(Of String)
            'Dim dt As New DataTable

            'StrSql = "SELECT DISTINCT Btc_No, Lot_Prefix + Lot_No AS LotNo FROM         POUCH_LABEL  " & _
            '        "WHERE     (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') ORDER BY LotNo "
            'Ds = SQL_SelectQuery_Execute(StrSql)

            'For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            '    If Not batches.Contains(eachRow1("Btc_No")) Then
            '        batches.Add(eachRow1("Btc_No"))
            '    End If
            'Next

            'If batches.Count > 0 Then
            '    For i = 0 To batches.Count - 1
            '        StrSql = "SELECT     Btc_No,  " & _
            '                " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL WHERE      (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') AND (Btc_No = '" & batches(i) & "') ORDER BY Lot_Prefix + Lot_No, Power,  Lot_SrNo) AS From_Serial, " & _
            '                " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL AS POUCH_LABEL_2 WHERE      (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1') AND (Btc_No = '" & batches(i) & "') ORDER BY Lot_Prefix + Lot_No DESC, Power DESC, Lot_SrNo DESC) AS To_Serial " & _
            '                "FROM         POUCH_LABEL AS POUCH_LABEL_1 WHERE     (BPL_NO = '" & CmbBPLNo.Text & "') AND (Box_Packing = '1')   AND (Btc_No = '" & batches(i) & "' ) GROUP BY Btc_No ORDER BY From_Serial "
            '        Ds = SQL_SelectQuery_Execute(StrSql)
            '        dt.Merge(Ds.Tables(0))
            '    Next
            'End If
            '--------------------------------------------
            StrSql = "DECLARE @BPL_NO NVARCHAR(50)  = '" & CmbBPLNo.Text & "'    SELECT   TOP (1) ''  AS Btc_No,  " & _
                            " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL WHERE      (BPL_NO = @BPL_NO) AND (Box_Packing = '1') ORDER BY Lot_Prefix + Lot_No, Power, Tray_No, Lot_SrNo) AS From_Serial, " & _
                            " (SELECT     TOP (1) Lot_SrNo FROM          POUCH_LABEL AS POUCH_LABEL_2 WHERE      (BPL_NO = @BPL_NO) AND (Box_Packing = '1')   ORDER BY Lot_Prefix + Lot_No DESC, Power DESC, Tray_No DESC, Lot_SrNo DESC) AS To_Serial " & _
                            "FROM         POUCH_LABEL AS POUCH_LABEL_1 WHERE     (BPL_NO = @BPL_NO) AND (Box_Packing = '1')      ORDER BY From_Serial "
            Ds = SQL_SelectQuery_Execute(StrSql)

            cryRpt.Database.Tables(3).SetDataSource(Ds.Tables(0))


            '--------------------------------------------------------------------------------------

            CryViewBoxPackingRecord.ReportSource = cryRpt
            CryViewBoxPackingRecord.Refresh()
            CryViewBoxPackingRecord.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub
End Class