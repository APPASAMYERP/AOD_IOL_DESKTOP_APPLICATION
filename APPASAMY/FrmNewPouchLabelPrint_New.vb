
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Public Class FrmNewPouchLabelPrint_New

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim strmfdmon, strmfdyear, strmfd As String
    Dim Cmd As New SqlCommand
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String
    Dim Stract As String
    Dim Stracpwr As String
    Dim len As String
    Dim opt As String
    Dim StrgsCode As String
    Dim StrUDICode As String
    Dim Ds As New DataSet
    Dim StrOptic, strpwradd, StrRefName, Strcyl, StrInexp1, StrInmfd, StrLen, StrPwr, StrRef, StrExp, StrBrand, StrLotPrefix, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl, Strbtc, StrlotBarNo, StroneDBar, StrSronlyNo, strrefname1 As String



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        cmbreflot.Text = ""
        cmbpower.Text = ""
        TextBox2.Text = ""
        GRID1.DataSource = Nothing
        TextBox1.Text = ""
        ScanLot_srNo.Text = ""

    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        'Validation.
        If cmbreflot.Text = "" Then
            err.SetError(cmbreflot, "This information is required")
            cmbreflot.Focus()
            Exit Sub
        Else
            err.SetError(cmbreflot, "")
        End If

        If cmbpower.Text = "" Then
            err.SetError(cmbpower, "This information is required")
            cmbpower.Focus()
            Exit Sub
        Else
            err.SetError(cmbpower, "")
        End If

        If cmbreflot.SelectedItem Is Nothing Then
            err.SetError(cmbreflot, "Please Select valid RefLot")
            cmbreflot.Focus()
            Exit Sub
        Else
            err.SetError(cmbreflot, "")

        End If


        If cmbpower.SelectedItem Is Nothing Then
            err.SetError(cmbpower, "Please Select valid Power")
            cmbpower.Focus()
            Exit Sub
        Else
            err.SetError(cmbpower, "")
        End If

        If Val(TextBox2.Text) < 1 Then
            err.SetError(TextBox2, "Enter Minimum 1 Qty")
            TextBox2.Focus()
            Exit Sub
        Else
            err.SetError(TextBox2, "")
        End If

        StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Not Labelled' order by Lot_SrNo"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            'StrRs.Close()
        Else
            MsgBox("No Data Found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()

        'UPDATE POUCHSTATION
        If productline = "SUPERPHOB" Then
            StrSql = "Update  POUCH_LABEL set PouchStation ='" & station & "', Created_by='" & StrLoginUser & "' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  and pouchstation is null and Status ='Not Labelled'"
            Cmd = New SqlCommand(StrSql, con)
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()
        End If


        


        StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  AND  Status ='Not Labelled' order by Lot_SrNo "

        Cmd = New SqlCommand(StrSql, con)
        Dim pouchds As New DataSet
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(pouchds)

        For j = 0 To pouchds.Tables(0).Rows.Count - 1


            'For i As Integer = 1 To TextBox1.Text

            Dim StrFName As String
            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
            StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(3)), "", pouchds.Tables(0).Rows(j)(3))
            If productline <> "SUPERPHOB" Then
                StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(89)), "", pouchds.Tables(0).Rows(j)(89))
                Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(58)), "", pouchds.Tables(0).Rows(j)(58))
                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(65)), "", pouchds.Tables(0).Rows(j)(65))
            End If

            StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5)), "0.00")
            StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(6)), "", pouchds.Tables(0).Rows(j)(6)), "0.00")
            StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(4)), "", pouchds.Tables(0).Rows(j)(4))

            StrExp = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5))

            strmfdmon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(16)), "", pouchds.Tables(0).Rows(j)(16)), "00")
            strmfdyear = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(17)), "", pouchds.Tables(0).Rows(j)(17))

            StrEpMon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(18)), "", pouchds.Tables(0).Rows(j)(18)), "00")
            StrEpYr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(19)), "", pouchds.Tables(0).Rows(j)(19))
            StrBrand = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(0)), "", pouchds.Tables(0).Rows(j)(0))
            StrRefName = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(2)), "", pouchds.Tables(0).Rows(j)(2))
            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
            StrLotPrefix = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(13)), "", pouchds.Tables(0).Rows(j)(13))
            StrLotNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(14)), "", pouchds.Tables(0).Rows(j)(14))
            StrSrNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(15)), "", pouchds.Tables(0).Rows(j)(15))
            StrMdl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
            Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(66)), "", pouchds.Tables(0).Rows(j)(66))

            If productline = "SUPERPHOB" Then
                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(52)), "", pouchds.Tables(0).Rows(j)(52))
                Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(53)), "", pouchds.Tables(0).Rows(j)(53))
            End If




            StrExp = StrEpYr & "-" & StrEpMon
            strmfd = strmfdyear & "-" & strmfdmon

            StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)
            
            If StrFName = "" Then
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If



            If StrRef = "SP-TORIC T3" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T4" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T5" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T6" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T7" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T8" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "SP-TORIC T9" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
            ElseIf StrRef = "MFD605" Then
                strpwradd = StrPwr & " " & "D" & "     " & "Adl " & Strcyl

            ElseIf StrRef = "MFDY605" Then
                strpwradd = StrPwr & " " & "D" & "     " & "Adl " & Strcyl



            ElseIf StrRef = "SPMFD200" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"
            ElseIf StrRef = "SPMFDY200" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"
            ElseIf StrRef = "SPTFDY 200" Then
                strpwradd = StrPwr & " " & "D"
            ElseIf StrRef = "SUPRAPHOB MS" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"
            ElseIf StrRef = "SP INFO" Then
                strpwradd = StrPwr & " " & "D"
                'strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            Else
                strpwradd = StrPwr & " " & "D"
                Stracpwr = Stracpwr & " " & "D"
                len = StrLen & "  " & "mm"
                opt = StrOptic & "  " & "mm"
            End If



            If RdoRef.Checked = True Then
                strrefname1 = StrRef
            Else
                strrefname1 = StrBrand
            End If

            StrSronlyNo = StrLotPrefix & StrLotNo
            StroneDBar = StrSrNo



            'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

            'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

            'StrOptic = StrOptic & " " & "mm"
            'StrLen = StrLen & " " & "mm"
            'StrPwr = StrPwr & " " & "D"

            Dim StrEanCode As String
            StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

            Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
            StrInexp1 = strbtcexpiry & StrEpMon & "00"
            Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
            StrInmfd = strbtcmfd & strmfdmon & "00"


            If productline <> "SUPERPHOB" Then
                StroneDBar = StroneDBar.Replace(" ", "")
                If StrEanCode = "" Or Strbtc = "" Or StrUDICode = "" Then
                    MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                    Exit Sub
                End If
            End If



            btFile = Application.StartupPath & "\" & StrFName & ""
            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

            'If StrRef = "AE-01" Then
            bt.SetNamedSubStringValue("Ref", StrMdl)
            bt.SetNamedSubStringValue("Pwr", strpwradd)
            bt.SetNamedSubStringValue("Brandname", strrefname1)
            'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
            bt.SetNamedSubStringValue("LotNo", StroneDBar)
            bt.SetNamedSubStringValue("optic", StrOptic)
            bt.SetNamedSubStringValue("Length", StrLen)
            bt.SetNamedSubStringValue("Expdate", StrExp)
            bt.SetNamedSubStringValue("mfddate", strmfd)
            bt.SetNamedSubStringValue("apwr", Stracpwr)

            bt.SetNamedSubStringValue("EanCode", StrEanCode)
            bt.SetNamedSubStringValue("Btc", Strbtc)
            bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
            bt.SetNamedSubStringValue("exptwod", StrInexp1)

            If StrRef = "SPTFDY 200" Then
                bt.SetNamedSubStringValue("Add_N", "ADD N 3.50")
                bt.SetNamedSubStringValue("Add_I", "ADD I 1.75")
            End If
            strpwradd = StrPwr & " " & "D" & "    " & "ADD  3.50"

            bt.PrintOut()

            bt.Close()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


            'Next i




        Next j


        Cmd.Dispose()

        StrSql = "Update  POUCH_LABEL set PouchBTWLabelName ='" & cmbPrintLabel.Text & "', Status='Labelled' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Not Labelled'"
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        cmbreflot.Text = ""
        cmbpower.Text = ""
        TextBox1.Text = ""

        TextBox2.Text = ""



    End Sub




    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings

        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function

    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        StrSql = "select distinct LabelName from BTW_Master where Department = 'POUCH'"
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub
    Private Sub Form_Load()
        LabelNameBind()
        StrSql = "SELECT DISTINCT RefLot from POUCH_LABEL WHERE Status ='Not Labelled' order by RefLot"

        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbreflot.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbreflot.Items.Add(eachRow("RefLot"))
        Next



    End Sub

    Private Sub FrmNewPouchReprintPhobic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()

    End Sub

    Private Function BTWFileName(ByVal modelno As String, ByVal labelname As String) As String
        Dim ds As New DataSet()
        StrSql = "select * from BTW_Master where Department = 'POUCH' and ModelNo = '" & modelno & "' and LabelName = '" & labelname & "' "

        ds = SQL_SelectQuery_Execute(StrSql)

        'Dim cmd As New SqlCommand(StrSql, con)
        'Dim ad As New SqlDataAdapter(cmd)
        'ad.Fill(ds)

        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If


    End Function




    Private Sub cmbreflot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflot.SelectedIndexChanged

        StrSql = "WITH PouchLabelData AS (SELECT     CAST(Power AS float) AS Power, SUM(Qty_1) AS Qty " & _
        " FROM         POUCH_LABEL WHERE     (RefLot = '" & cmbreflot.Text & "')GROUP BY CAST(Power AS float)), " & _
        " MIinFQIData AS (SELECT     CAST(Power AS float) AS Power, SUM(AcceptedQty) AS Qty " & _
        " FROM          MOULDING.dbo.MIinFQI WHERE      (GlassyNo = '" & cmbreflot.Text & "') AND (AcceptedQty <> 0) GROUP BY CAST(Power AS float)) " & _
        " SELECT     CASE WHEN COUNT(*) = 0 THEN 'True' ELSE 'False' END AS Result " & _
        " FROM         (SELECT     COALESCE (p.Power, m.Power) AS Power, COALESCE (p.Qty, 0) AS PouchQty, COALESCE (m.Qty, 0) AS MIinFQIQty " & _
        " FROM          PouchLabelData AS p FULL OUTER JOIN MIinFQIData AS m ON p.Power = m.Power " & _
        " WHERE      (COALESCE (p.Qty, 0) <> COALESCE (m.Qty, 0))) AS Differences "

        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows(0)("Result") = "False" Then
            MessageBox.Show(" Please Check MINFQI Entry.")
            Exit Sub
        End If

        StrSql = "SELECT DISTINCT Power from POUCH_LABEL where RefLot='" & cmbreflot.Text & "' AND Status ='Not Labelled'  order by Power"
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbpower.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbpower.Items.Add(eachRow("Power"))
        Next


    End Sub

    Private Sub load_grid()
        Dim Strsql As String
        Strsql = "select Lot_SrNo,Status  from temp_POUCH_LABEL_Print where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  order by Lot_SrNo "
        Ds = SQL_SelectQuery_Execute(Strsql)
        GRID1.DataSource = Ds.Tables(0)

        TextBox2.Text = GRID1.Rows.Count - 1
        ColorCode_SerialLoad()
    End Sub

    Function CompareDataTables(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As Boolean

        If dt1.Columns.Count <> dt2.Columns.Count Then
            Return False
        End If


        If dt1.Rows.Count <> dt2.Rows.Count Then
            Return False
        End If


        For Each column As DataColumn In dt1.Columns
            For Each row As DataRow In dt1.Rows
                Dim rowIndex As Integer = dt1.Rows.IndexOf(row)
                Dim value1 As Object = row(column)
                Dim value2 As Object = dt2.Rows(rowIndex)(column.ColumnName)

                If Not value1.Equals(value2) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function


    Public Function check_reflot_data_created() As Boolean

        Dim temp_count, original_count As Integer
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT Count(*) As Total from temp_POUCH_LABEL_Print  " & _
        " WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If Val(ds.Tables(0).Rows(0)("Total")) < 1 Then
            Return False
        Else
            temp_count = Val(ds.Tables(0).Rows(0)("Total"))
        End If

        Dim ds1 As New DataSet
        StrSql = "SELECT Count(*) As Total from Pouch_Label  " & _
        "WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  "
        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(ds1)
        original_count = Val(ds1.Tables(0).Rows(0)("Total"))

        If temp_count = original_count Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function data_compare() As Boolean

        'Dim temp_count, original_count As Integer
        Dim dsTemp, dsOriginal As New DataSet
        Dim StrSql As String = "SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Optic, Length, A_Constant,Lot_Prefix, Lot_No,   " & _
        " Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month, Exp_Year, Btc_No, R_Power, Cylsize, rotlex_type, Label, RefLot  from temp_POUCH_LABEL_Print  " & _
        " where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  Order By Brand_Name,Model_Name,Power,Lot_SrNo  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(dsTemp)


        StrSql = "SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Optic, Length, A_Constant,Lot_Prefix, Lot_No,   " & _
        " Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month, Exp_Year, Btc_No, R_Power, Cylsize, rotlex_type, Label, RefLot  from POUCH_LABEL  " & _
        " where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  Order By Brand_Name,Model_Name,Power,Lot_SrNo  "

        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(dsOriginal)

        Return CompareDataTables(dsTemp.Tables(0), dsOriginal.Tables(0))

    End Function

    Private Sub to_create_records()
        Dim strLotSerials As String = ""
        StrSql = "SELECT  Lot_SrNo  from Pouch_Label   " & _
         " WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  "
        Ds = SQL_SelectQuery_Execute(StrSql)

        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            strLotSerials = strLotSerials + "'" + eachRow1("Lot_SrNo") + "',"
        Next

        If strLotSerials = "" Then
            strLotSerials = "''"
        Else
            strLotSerials = strLotSerials.Remove(strLotSerials.Length - 1, 1)
        End If

        StrSql = " SELECT DISTINCT Lot_SrNo,Status FROM temp_POUCH_LABEL_Print WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "' AND  " & _
            " Lot_SrNo Not IN (" & strLotSerials & ")"

        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            If eachRow("Status") = "Labelled" Then
                MessageBox.Show("Already labeled. You Cannot remove the Lot_srno (" + eachRow("Lot_SrNo") + ") from temp_POUCH_LABEL_Print.  Please contact ERP team ")
                Exit Sub
            End If
        Next

        'Removed the records 

        StrSql = " DELETE FROM temp_POUCH_LABEL_Print WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "' AND  " & _
            " Lot_SrNo Not IN (" & strLotSerials & ")"

        UpdateorInsertQuery_Execute(StrSql)


        'new record insert
        StrSql = " INSERT INTO temp_POUCH_LABEL_Print " & _
            " SELECT *  from Pouch_Label   " & _
         " WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'  AND  " & _
         " Lot_Srno not in(SELECT Lot_SrNo from temp_POUCH_LABEL_Print " & _
         " WHERE RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "' ) "

        UpdateorInsertQuery_Execute(StrSql)




    End Sub

    Private Sub cmbpower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpower.SelectedIndexChanged
        If cmbreflot.SelectedItem Is Nothing Then
            err.SetError(cmbreflot, "Please Select valid RefLot")
            cmbreflot.Focus()
            Exit Sub
        Else
            err.SetError(cmbreflot, "")

        End If

        Dim reflot_data_created As Boolean = False
        reflot_data_created = check_reflot_data_created()
        If reflot_data_created = True Then
            If data_compare() = True Then
                load_grid()
            Else
                MessageBox.Show("Data does not match (temp_POUCH_LABEL_Print & POUCH_LABEL). Please contact ERP team ")
                Exit Sub
            End If

        Else
            to_create_records()
            If data_compare() = True Then
                load_grid()
            Else
                MessageBox.Show("Data does not match (temp_POUCH_LABEL_Print & POUCH_LABEL). Please contact ERP team ")
                Exit Sub
            End If
        End If


    End Sub


    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To GRID1.Rows.Count - 2
            If Not IsDBNull(Me.GRID1.Rows(i).Cells("Status").Value) Then
                If Me.GRID1.Rows(i).Cells("Status").Value = "Labelled" Then
                    Me.GRID1.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        TextBox1.Text = scanedCount
    End Sub

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


    Private Sub ScanLot_srNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ScanLot_srNo.KeyDown


        If e.KeyCode = Keys.Enter Then

            Try

                'Validation.
                If cmbreflot.Text = "" Then
                    err.SetError(cmbreflot, "This information is required")
                    cmbreflot.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbreflot, "")
                End If

                If cmbpower.Text = "" Then
                    err.SetError(cmbpower, "This information is required")
                    cmbpower.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbpower, "")
                End If

                If cmbreflot.SelectedItem Is Nothing Then
                    err.SetError(cmbreflot, "Please Select valid RefLot")
                    cmbreflot.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbreflot, "")

                End If

                If cmbPrintLabel.SelectedItem Is Nothing Then
                    err.SetError(cmbPrintLabel, "Please Select valid Label")
                    cmbPrintLabel.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbPrintLabel, "")

                End If


                If cmbpower.SelectedItem Is Nothing Then
                    err.SetError(cmbpower, "Please Select valid Power")
                    cmbpower.Focus()
                    Exit Sub
                Else
                    err.SetError(cmbpower, "")
                End If

                If Val(TextBox2.Text) < 1 Then
                    err.SetError(TextBox2, "Enter Minimum 1 Qty")
                    TextBox2.Focus()
                    Exit Sub
                Else
                    err.SetError(TextBox2, "")
                End If

                If ScanLot_srNo.Text <> "" Then


                    Dim pouchds As New DataSet
                    StrSql = "select * from  temp_POUCH_LABEL_Print where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  AND  Status ='Not Labelled' and Lot_srno='" & ScanLot_srNo.Text & "' order by Lot_SrNo "
                    pouchds = SQL_SelectQuery_Execute(StrSql)

                    'Cmd = New SqlCommand(StrSql, con)
                    'Dim pouchds As New DataSet
                    'Dim ad As New SqlDataAdapter(Cmd)
                    'ad.Fill(pouchds)
                    'Cmd.Dispose()

                    If pouchds.Tables(0).Rows.Count = 1 Then

                        'Update in temp_pouch_label_print 
                        StrSql = "Update  temp_POUCH_LABEL_Print set PouchBTWLabelName ='" & cmbPrintLabel.Text & "', Status='Labelled',  PouchStation ='" & station & "', Created_by='" & StrLoginUser & "' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'   and Status ='Not Labelled' and Lot_srno='" & ScanLot_srNo.Text & "' "
                        UpdateorInsertQuery_Execute(StrSql)
                        'Cmd = New SqlCommand(StrSql, con)
                        'Cmd.ExecuteNonQuery()
                        'Cmd.Dispose()


                        For j = 0 To pouchds.Tables(0).Rows.Count - 1

                            Dim StrFName As String
                            'StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                            StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(3)), "", pouchds.Tables(0).Rows(j)(3))
                            If productline <> "SUPERPHOB" Then
                                StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(89)), "", pouchds.Tables(0).Rows(j)(89))
                                Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(58)), "", pouchds.Tables(0).Rows(j)(58))
                                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(65)), "", pouchds.Tables(0).Rows(j)(65))
                            End If

                            StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5)), "0.00")
                            StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(6)), "", pouchds.Tables(0).Rows(j)(6)), "0.00")
                            StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(4)), "", pouchds.Tables(0).Rows(j)(4))

                            'StrExp = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5))

                            strmfdmon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(16)), "", pouchds.Tables(0).Rows(j)(16)), "00")
                            strmfdyear = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(17)), "", pouchds.Tables(0).Rows(j)(17))

                            StrEpMon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(18)), "", pouchds.Tables(0).Rows(j)(18)), "00")
                            StrEpYr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(19)), "", pouchds.Tables(0).Rows(j)(19))
                            StrBrand = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(0)), "", pouchds.Tables(0).Rows(j)(0))
                            StrRefName = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(2)), "", pouchds.Tables(0).Rows(j)(2))
                            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                            StrLotPrefix = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(13)), "", pouchds.Tables(0).Rows(j)(13))
                            StrLotNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(14)), "", pouchds.Tables(0).Rows(j)(14))
                            StrSrNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(15)), "", pouchds.Tables(0).Rows(j)(15))
                            StrMdl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))

                            Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(66)), "", pouchds.Tables(0).Rows(j)(66))

                            If productline = "SUPERPHOB" Then
                                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(52)), "", pouchds.Tables(0).Rows(j)(52))
                                Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(53)), "", pouchds.Tables(0).Rows(j)(53))
                            End If






                            StrExp = StrEpYr & "-" & StrEpMon
                            strmfd = strmfdyear & "-" & strmfdmon

                            StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)


                            If StrFName = "" Then
                                MessageBox.Show("BTW file record not found")
                                ScanLot_srNo.Focus()
                                load_grid()
                                Exit Sub
                            End If

                            Dim cylType As String = ""
                            Dim swiToricModel As String = ""

                            If StrRef = "SP-TORIC T3" Or StrRef = "SP-TORIC T4" Or StrRef = "SP-TORIC T5" Or StrRef = "SP-TORIC T6" Or StrRef = "SP-TORIC T7" Or StrRef = "SP-TORIC T8" Or StrRef = "SP-TORIC T9" Or StrRef = "MFD605" Or StrRef = "MFDY605" Then
                                strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl



                            ElseIf StrRef = "SPHTORIC 300-T2" Or StrRef = "SPHTORIC 300-T3" Or StrRef = "SPHTORIC 300-T4" Or StrRef = "SPHTORIC 300-T5" Or StrRef = "SPHTORIC 300-T6" Or StrRef = "SPHTORIC 300-T7" Or StrRef = "SPHTORIC 300-T8" Or StrRef = "SPHTORIC 300-T9" Then
                                strpwradd = StrPwr & " " & "D" & "     " & "CYL : " & Strcyl
                                Dim splitResult As String() = StrRef.Split(New Char() {"-"c})
                                cylType = splitResult(1)
                                swiToricModel = splitResult(0)

                            ElseIf StrRef = "SPMFD200" Or StrRef = "SPMFDY200" Or StrRef = "SUPRAPHOB MS" Then
                                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                            ElseIf StrRef = "SPTFDY 200" Or StrRef = "SP INFO" Then
                                strpwradd = StrPwr & " " & "D"

                            Else
                                strpwradd = StrPwr & " " & "D"
                                Stracpwr = Stracpwr & " " & "D"
                                len = StrLen & "  " & "mm"
                                opt = StrOptic & "  " & "mm"
                            End If


                            strrefname1 = StrBrand
                            StrSronlyNo = StrLotPrefix & StrLotNo
                            StroneDBar = StrSrNo




                            'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                            'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                            'StrOptic = StrOptic & " " & "mm"
                            'StrLen = StrLen & " " & "mm"
                            'StrPwr = StrPwr & " " & "D"

                            Dim StrEanCode As String
                            StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                            Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                            StrInexp1 = strbtcexpiry & StrEpMon & "00"
                            Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                            StrInmfd = strbtcmfd & strmfdmon & "00"


                            If productline <> "SUPERPHOB" Then
                                StroneDBar = StroneDBar.Replace(" ", "")
                                If StrEanCode = "" Or Strbtc = "" Or StrUDICode = "" Then
                                    MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                                    ScanLot_srNo.Focus()
                                    load_grid()
                                    Exit Sub
                                End If
                            End If


                            btFile = Application.StartupPath & "\" & StrFName & ""
                            If System.IO.File.Exists(btFile) Then
                                'The file exists
                            Else
                                MessageBox.Show("BTW file record not found")
                                ScanLot_srNo.Focus()
                                load_grid()
                                Exit Sub
                            End If


                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            'If StrRef = "AE-01" Then
                            bt.SetNamedSubStringValue("Ref", StrMdl)
                            bt.SetNamedSubStringValue("Pwr", strpwradd)
                            bt.SetNamedSubStringValue("Brandname", strrefname1)
                            'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                            bt.SetNamedSubStringValue("LotNo", StroneDBar)
                            bt.SetNamedSubStringValue("optic", StrOptic)
                            bt.SetNamedSubStringValue("Length", StrLen)
                            bt.SetNamedSubStringValue("Expdate", StrExp)
                            bt.SetNamedSubStringValue("mfddate", strmfd)
                            bt.SetNamedSubStringValue("apwr", Stracpwr)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc)
                            bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            If strrefname1 = "SWISSPHOB TORIC" Then
                                bt.SetNamedSubStringValue("cylType", cylType)
                                bt.SetNamedSubStringValue("swiToricModel", swiToricModel)
                            End If

                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        Next j


                    Else
                        MsgBox("No Data Found Or Multiple time present", MsgBoxStyle.Critical)
                        Exit Sub
                    End If


                    ScanLot_srNo.Text = ""
                    ScanLot_srNo.Focus()

                    load_grid()
                End If


            Catch ex As Exception
                MsgBox("An unexpected error occurred.")
                Exit Sub

            End Try
            


        End If

    End Sub
    Private Function ReplacePlaceholder(ByVal input As String, ByVal placeholder As String, ByVal replacement As String) As String
        If input.Contains(placeholder) Then
            input = input.Replace(placeholder, replacement)
        End If
        Return input
    End Function

    Private Sub btn_Complete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Complete.Click

        If Val(TextBox1.Text) = Val(TextBox2.Text) Then

            Try
                If Val(TextBox2.Text) <> 0 Then

                    Dim lot_Serial_numbers As String = ""
                    For i = 0 To GRID1.Rows.Count - 2

                        lot_Serial_numbers = lot_Serial_numbers + "'" + GRID1.Rows(i).Cells("Lot_srno").Value.ToString() + "',"

                    Next i

                    lot_Serial_numbers = lot_Serial_numbers.Remove(lot_Serial_numbers.Length - 1, 1)



                    StrSql = "SELECT DISTINCT Status, PouchStation, PouchBTWLabelName " & _
                            "FROM         temp_POUCH_LABEL_Print " & _
                            " WHERE  RefLot = '" & cmbreflot.Text & "' and   Power = '" & cmbpower.Text & "' " & _
                            " and  Lot_SrNo IN (" & lot_Serial_numbers & ")"
                    Ds = SQL_SelectQuery_Execute(StrSql)

                    If Ds.Tables(0).Rows.Count = 1 Then

                        StrSql = "Update POUCH_LABEL " & _
                            "SET             PouchBTWLabelName = '" & Ds.Tables(0).Rows(0)("PouchBTWLabelName") & "', Status = '" & Ds.Tables(0).Rows(0)("Status") & "', " & _
                                        " PouchStation ='" & Ds.Tables(0).Rows(0)("PouchStation") & "',Created_By = '" & StrLoginUser & "' " & _
                            " where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  and Lot_SrNo IN (" & lot_Serial_numbers & ")"
                        UpdateorInsertQuery_Execute(StrSql)

                    Else
                        MsgBox("No Data found (or) Status or PouchStation or PouchBTWLabelName Multiple time present in  temp_POUCH_LABEL_Print against the reflot(" + cmbreflot.Text + ") and power(" + cmbpower.Text + ")")
                        ScanLot_srNo.Focus()
                        Exit Sub
                    End If





                    StrSql = "DELETE FROM temp_POUCH_LABEL_Print WHERE  RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  and Lot_SrNo IN (" & lot_Serial_numbers & ") "
                    UpdateorInsertQuery_Execute(StrSql)

                    MsgBox("Saved")
                    cmbreflot.Text = ""
                    cmbpower.Text = ""
                    TextBox2.Text = ""
                    GRID1.DataSource = Nothing
                    TextBox1.Text = ""
                    ScanLot_srNo.Text = ""

                    Form_Load()

                End If

            Catch ex As Exception
                MsgBox("An unexpected error occurred.")
                Exit Sub

            End Try

            



        Else
            MsgBox("Not fully scanned. Please check")
            ScanLot_srNo.Focus()
        End If


    End Sub
End Class