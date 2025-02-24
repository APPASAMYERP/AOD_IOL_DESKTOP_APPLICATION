Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration



Public Class frmlotallotprint

    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable
    Dim serialTable As New DataTable
    Dim bt As New BarTender.Format
    Dim bApp As New BarTender.Application
    Dim btFile As String
    Dim getDetails As String

    Dim readdetail As SqlDataReader
    Dim Try_Header As Integer
    Dim Ttr_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader

    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader

    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrUniqueNo As String
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
    Dim isSaved As Boolean


    Private Sub killProcess(ByRef StrProcessKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            'MsgBox(Proc(i).ProcessName)
            If Proc(i).ProcessName = StrProcessKill Then
                'MsgBox(Proc(i).ProcessName)
                Try
                    Proc(i).Kill()
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
    Public Function getBatchNumbers() As String


        Dim btaches As String = ""
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No FROM         POUCH_LABEL   WHERE     (pouchRepack_staus = '1')"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        For Each eachRow1 As DataRow In ds.Tables(0).Rows
            btaches = btaches + "'" + eachRow1("Btc_No") + "',"

        Next
        If btaches <> "" Then
            btaches = btaches.Remove(btaches.Length - 1, 1)
        Else
            Return "''"
        End If

        Return btaches

    End Function


    Public Function SterileBatchBind() As DataSet
        Dim SterileBatches As String = ""
        SterileBatches = getBatchNumbers()

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No from POUCH_LABEL  WHERE    ( (Mfd_Year = '2023') AND (Mfd_Month NOT IN ('1', '2', '3', '4'))   OR (Mfd_Year >= '2024') ) AND (Tray_No IS NULL) AND (Tray_Label_Gen IS NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) and (pouchRepack_staus is NULL) and Btc_No not in(" & SterileBatches & ") AND (Areation_Status = 1) order by Btc_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function SterileBatchBindForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No from POUCH_LABEL  WHERE    ( (Mfd_Year = '2023') AND (Mfd_Month NOT IN ('1', '2', '3', '4'))   OR (Mfd_Year >= '2024') ) AND (Tray_No IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Btc_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getLotWiseQty() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No FROM POUCH_LABEL  WHERE  (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No ORDER BY Lot_Prefix, Lot_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function getAllSeialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno,St_SrNo, Qty_1 AS Qty FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) ORDER BY Model_Name, Lot_Prefix, Lot_No, Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getTotalStockOfBatch() As Integer

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT SUM(Qty_1) AS qty FROM POUCH_LABEL  WHERE    (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If Not IsDBNull(ds.Tables(0).Rows(0)("qty")) Then
            Return ds.Tables(0).Rows(0)("qty")
        Else
            Return 0
        End If


    End Function

    Public Function getLastHeaderId() As Integer

        Dim UTCTime As DateTime = Date.UtcNow
        Dim IndianTime As DateTime = UTCTime.AddHours(5.5)


        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     ID, Header_ID, MONTH(Created_Date) AS month FROM         TRAY_GEN WHERE     (ID = (SELECT     MAX(ID) AS Expr1  FROM          TRAY_GEN AS TRAY_GEN_1))"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            If IndianTime.Month = Convert.ToInt32(ds.Tables(0).Rows(0)("month")) Then
                If Not IsDBNull(ds.Tables(0).Rows(0)("Header_ID")) Then
                    Return Convert.ToInt32(ds.Tables(0).Rows(0)("Header_ID")) + 1
                Else
                    Return 1
                End If
            Else
                Return 1
            End If
        Else
            Return 1
        End If
        

    End Function
    Public Sub trayGenInsert(ByVal header_id As Integer, ByVal Qty As Integer, ByVal StrUniqueNo As String)

        Dim StrSql As String = "Insert into TRAY_GEN (Header_ID,Btc_No,Qty,Tray_No,	Created_By,	Created_Date,	Modified_By,	Modified_Date) VALUES   ('" & header_id & "','" & cmbStbatch.Text & "','" & Qty & "','" & StrUniqueNo & "','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
        Dim Cmd As New SqlCommand(StrSql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub PouchLabelUpdate(ByVal lot_no As String, ByVal serialFrom As String, ByVal serialTo As String, ByVal StrUniqueNo As String)
        'Dim lot_no As String = row("Lot_No").ToString()
        'Dim serialFrom As String = row("Serial_From").ToString()
        'Dim serialTo As String = row("Serial_To").ToString()

        Dim strsql As String
        strsql = " update POUCH_LABEL set Tray_No = '" & StrUniqueNo & "'  WHERE  (Lot_Prefix + Lot_No='" & lot_no & "') AND  (St_SrNo BETWEEN '" & serialFrom & "' AND '" & serialTo & "') AND (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)"
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Function getDistintModel() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = ""
        If productline = "PMMA" Then
            'StrSql = "SELECT     DISTINCT  Model_Name, Brand_Name FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1)  ORDER BY Model_Name "
            StrSql = "SELECT     DISTINCT  Model_Name, Brand_Name, Lot_Prefix + Lot_No AS LotNo FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) ORDER BY Model_Name, LotNo "
        ElseIf productline = "PHILIC" Then
            StrSql = "SELECT     DISTINCT  Model_Name, Brand_Name FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0)AND (Areation_Status = 1) ORDER BY Model_Name "
        ElseIf productline = "PHOBIC" Then
            StrSql = "SELECT     DISTINCT  Model_Name, Brand_Name, Lot_Prefix + Lot_No AS LotNo FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) ORDER BY Model_Name, LotNo "
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            StrSql = "SELECT     DISTINCT  Model_Name, Brand_Name, Lot_Prefix + Lot_No AS LotNo FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  ORDER BY Model_Name, LotNo "
        End If

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Public Function getMaximumTrayQty(ByVal brandName As String)

        If brandName = "NASPRO" Then
            Return 100
        ElseIf brandName = "ACRYFOLD" Then
            Return 150
        ElseIf brandName = "SWISSFOLD-HD" Then
            Return 100
        ElseIf brandName = "nAspro - BBY" Then
            Return 100
        ElseIf brandName = "HEERAFOLD" Then
            Return 150
        ElseIf brandName = "SWISSFOLD" Then
            Return 100
        ElseIf brandName = "SUPRAPHOB BBY" Then
            Return 60
        ElseIf brandName = "SUPRAPHOB" Then
            Return 60
        ElseIf brandName = "SWISSPHOB TORIC" Then
            Return 60
        ElseIf brandName = "SUPRAPHOB REGEN TRIFOCAL" Then
            Return 200
        ElseIf brandName = "SUPRAPHOB REGEN" Then
            Return 60
        ElseIf brandName = "SUPRAPHOB INFOCUS" Then
            Return 200
        ElseIf brandName = "SWISS PHOB" Then
            Return 200
        ElseIf brandName = "RIL TORIC" Then
            Return 60
        ElseIf brandName = "SUPRAPHOB TORIC" Then
            Return 60
        ElseIf brandName = "HYDROPHOBIC FOLDABLE SINGLE PIECE INTRAOCULAR LENS" Then
            Return 200
        ElseIf brandName = "APPALENS" Then
            Return 150
        ElseIf brandName = "APPALENS PLUS" Then
            Return 150
        ElseIf brandName = "HEERALENS" Then
            Return 150
        ElseIf brandName = "LIBERTY CAPSULAR RETRACTOR" Then
            Return 150
        ElseIf brandName = "LIBERTY IRIS CLAW LENS" Then
            Return 150
        ElseIf brandName = "LIBERTY IRIS RETRACTOR" Then
            Return 150
        ElseIf brandName = "LIBERTY RING" Then
            Return 150
        ElseIf brandName = "LIBERTY RINGS" Then
            Return 150
        ElseIf brandName = "LIBERTYLENS" Then
            Return 150
        ElseIf brandName = "LIBERTYLENS BBY" Then
            Return 150
        ElseIf brandName = "SWISS LENS" Then
            Return 150
        Else
            Return 0

        End If
    End Function



    Private Sub frmlotallotprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Ds = SterileBatchBind()
            cmbStbatch.Items.Clear()
            TextBox1.Text = ""
            For Each eachRow As DataRow In Ds.Tables(0).Rows
                cmbStbatch.Items.Add(eachRow("Btc_No"))
            Next

            'Reprint
            Ds = SterileBatchBindForReprint()
            cmbStrBatchReprint.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbStrBatchReprint.Items.Add(eachRow1("Btc_No"))
            Next


            'Unique Serial Grid View
            serialTable.Columns.Add("Model_Name", GetType(String))
            serialTable.Columns.Add("Power", GetType(String))
            serialTable.Columns.Add("Batch", GetType(String))
            serialTable.Columns.Add("Lot_Number", GetType(String))
            serialTable.Columns.Add("St_SrNo", GetType(String))
            serialTable.Columns.Add("Qty", GetType(String))
            serialTable.Columns.Add("TrayNo", GetType(String))
            DataGridView1.DataSource = serialTable


            With DataGridView1.ColumnHeadersDefaultCellStyle
                .Alignment = DataGridViewContentAlignment.TopRight
                .BackColor = Color.DarkRed
                .ForeColor = Color.Gold
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                 .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

        ''Grouped Serial Grid View
        'table.Columns.Add("Model_Name", GetType(String))
        'table.Columns.Add("Power", GetType(String))
        'table.Columns.Add("Batch", GetType(String))
        'table.Columns.Add("Lot_Number", GetType(String))
        'table.Columns.Add("Serial_From", GetType(String))
        'table.Columns.Add("Serial_To", GetType(String))
        'table.Columns.Add("Qty", GetType(String))
        'table.Columns.Add("TrayNo", GetType(String))
        'GRID2.DataSource = table


        'With GRID2.ColumnHeadersDefaultCellStyle
        '    .Alignment = DataGridViewContentAlignment.TopRight
        '    .BackColor = Color.DarkRed
        '    .ForeColor = Color.Gold
        '    .Font = New Font(.Font.FontFamily, .Font.Size, _
        '     .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        'End With


    End Sub

    Public Sub SterilebatchUpdate(ByVal query As String)
        Dim strsql As String
        strsql = query
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        

        ''**** sterilie batch update ****
        'Dim FILE_NAME As String = "C:\Users\Bhuvana\Desktop\sundar\updateBatchQuery.txt"
        'Dim TextLine As String
        'TextLine = ""
        'Dim i As Integer
        'i = 0
        'If System.IO.File.Exists(FILE_NAME) = True Then
        '    Dim objReader As New System.IO.StreamReader(FILE_NAME)
        '    Do While objReader.Peek() <> -1
        '        i = i + 1
        '        TextLine = objReader.ReadLine()
        '        SterilebatchUpdate(TextLine)
        '    Loop
        'Else
        '    MessageBox.Show("File Does Not Exist")
        'End If
        'MessageBox.Show(" " & i.ToString() & "  rows Updated")

        ''**** Stock Upload ****
        'Dim FILE_NAME As String = TextBox2.Text
        'Dim TextLine As String
        'Dim StrInsertQuery As String = ""
        'Dim Power As String = ""
        'Dim optic As String = ""
        'Dim length As String = ""
        'Dim mfd_month As String = ""
        'Dim mfd_year As String = ""
        'Dim exp_month As String = ""
        'Dim exp_year As String = ""
        'Dim lot_prefix As String = ""
        'Dim lot_no As String = ""
        'Dim A_constant As String = ""
        'Dim btc_no As String = ""
        'TextLine = ""
        'Dim i As Integer
        'i = 0
        'If System.IO.File.Exists(FILE_NAME) = True Then
        '    Dim objReader As New System.IO.StreamReader(FILE_NAME)
        '    Do While objReader.Peek() <> -1
        '        i = i + 1
        '        TextLine = objReader.ReadLine().Trim()
        '        Power = TextLine.Split(","c)(3).Remove(TextLine.Split(","c)(3).ToString().Length - 1, 1)
        '        optic = TextLine.Split(","c)(4).Remove(TextLine.Split(","c)(4).ToString().Length - 2, 2) + "00"
        '        length = TextLine.Split(","c)(5).Remove(TextLine.Split(","c)(5).ToString().Length - 2, 2) + "00"
        '        mfd_month = TextLine.Split(","c)(8).Split("-"c)(1)
        '        mfd_year = TextLine.Split(","c)(8).Split("-"c)(0)
        '        exp_month = TextLine.Split(","c)(9).Split("-"c)(1)
        '        exp_year = TextLine.Split(","c)(9).Split("-"c)(0)
        '        lot_prefix = TextLine.Split(","c)(0).Split(" "c)(0).Remove(TextLine.Split(","c)(0).Split(" "c)(0).ToString().Length - 4, 4)
        '        lot_no = Strings.Right(TextLine.Split(","c)(0).Split(" "c)(0), 4)
        '        A_constant = TextLine.Split(","c)(6) + "00"
        '        btc_no = Path.GetFileNameWithoutExtension(FILE_NAME)

        '        StrInsertQuery = StrInsertQuery + "('" + TextLine.Split(","c)(1) + "','" + TextLine.Split(","c)(2) + "','" + TextLine.Split(","c)(1) + "'," & _
        '        "NULL,'" + Power + "','" + optic + "','" + length + "','mm','" + A_constant + "'," & _
        '        "'AOD',100,1,100,'" + lot_prefix + "','" + lot_no + "','" + TextLine.Split(","c)(0) + "'," & _
        '        "'" + mfd_month + "','" + mfd_year + "','" + exp_month + "','" + exp_year + "',1,NULL,0,'NO',0,NULL,0,NULL,NULL,0,NULL,NULL,'APS',GETDATE(),'APS',GETDATE()," & _
        '        "1,NULL,0,1,'MUMBAI',0,NULL,NULL,NULL,NULL,NULL,NULL,'" + TextLine.Split(","c)(1) + "',NULL,NULL,'" + btc_no + "',NULL,NULL,1,NULL,'STOCK UPLOAD1'," & _
        '        "NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,850,NULL,NULL,'STOCK UPLOAD1',NULL,NULL,NULL,NULL),"

        '    Loop
        '    StrInsertQuery = StrInsertQuery.Remove(StrInsertQuery.ToString().Length - 1, 1)
        '    StrInsertQuery = "Insert into POUCH_LABEL Values" + StrInsertQuery
        '    Dim Cmd As New SqlCommand(StrInsertQuery, con)
        '    If con.State = Data.ConnectionState.Open Then
        '        con.Close()
        '    End If
        '    con.Open()
        '    Cmd.ExecuteNonQuery()
        '    con.Close()

        'Else
        '    MessageBox.Show("File Does Not Exist")
        'End If
        'MessageBox.Show(" " & i.ToString() & "  rows Updated")

        killProcess("bartend")
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub
    Public Function sampleLens() As DataSet

        Dim ds, dsPhobic, dsNP As New DataSet
        Dim dtPhobic, dtNP As New DataTable
        Dim conPHOBIC, conNP As New SqlConnection

        conPHOBIC.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
        conNP.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()

        Dim StrSql As String = "SELECT SUM(Qty_1)as Qty from POUCH_LABEL  WHERE  (Btc_No = '" & cmbStbatch.Text & "') AND (Sample_Taken = '1' OR BPL_NO LIKE 'CST%' ) "

       

        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            'Phobic
            Dim Cmd As New SqlCommand(StrSql, conPHOBIC)
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(dsPhobic)
            dtPhobic = dsPhobic.Tables(0)

            'NP
            Cmd = New SqlCommand(StrSql, conNP)
            ad = New SqlDataAdapter(Cmd)
            ad.Fill(dsNP)
            dtNP = dsNP.Tables(0)
            dtPhobic.Merge(dtNP)


            Return dtPhobic.DataSet

        Else
            Dim Cmd As New SqlCommand(StrSql, con)
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(ds)
            Return ds
        End If

        

    End Function

    Public Function getDistinctAllUsedTrayNumber(ByVal FrDate As String, ByVal ToDate As String) As DataSet

        Dim ds As New DataSet

        Dim StrSql As String = "SELECT DISTINCT Tray_No FROM  POUCH_LABEL  WHERE " & _
                " (Tray_No IN (SELECT DISTINCT Tray_From FROM  TrayRack_Movement WHERE  (Created_Date BETWEEN '" & FrDate & "' AND '" & ToDate & "') and Tray_label_updated ='0' )) OR" & _
                 " (Tray_No IN (SELECT DISTINCT Tray_To FROM  TrayRack_Movement WHERE  (Created_Date BETWEEN '" & FrDate & "' AND '" & ToDate & "')and Tray_label_updated ='0' )) "

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getDistinctTrayNumber(ByVal trayNumbers As String) As DataSet

        Dim ds As New DataSet

        Dim StrSql As String = "SELECT DISTINCT Tray_No FROM  POUCH_LABEL  WHERE " & _
                "(Tray_No IN (" & trayNumbers & ")) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0')  " & _
                "  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND (Dc_Packing = '0') AND (Areation_Status = 1)"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

        Try
            Dim header_id As Integer
            Dim dsAllSerial As DataSet
            Dim dsDistinctModel As DataSet
            Dim dsSampleLens, dsRackId As DataSet
            Dim maxTrayQty As Integer
            Dim sampleLensQty As Integer = 0

            ''Validation for daily label updation----------------------------------------
            'Dim strTrayNumbers As String = ""
            'Dim StrDtFr, StrDtTo As String
            'StrDtFr = Format(Date.Today().AddDays(-15), "yyyy-MM-dd") & " 00:00:01"
            'StrDtTo = Format(Date.Today(), "yyyy-MM-dd") & " 23:59:59"

            'Ds = getDistinctAllUsedTrayNumber(StrDtFr, StrDtTo)
            'For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            '    strTrayNumbers = strTrayNumbers + "'" + eachRow1("tray_no").ToString() + "',"
            'Next
            'strTrayNumbers = strTrayNumbers.Remove(strTrayNumbers.Length - 1, 1)
            'Ds = getDistinctTrayNumber(strTrayNumbers)
            'If Ds.Tables(0).Rows.Count > 0 Then
            '    MessageBox.Show("Daily Tray label Updation not Completed. Please check.")
            '    Exit Sub
            'End If
            '----------------------------------------

            If cmbStbatch.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Batch")
                cmbStbatch.Focus()
                Exit Sub
            End If

            ' Validation for sample lens must taken for each Batch
            dsSampleLens = sampleLens()
            For Each eachQty As DataRow In dsSampleLens.Tables(0).Rows
                If Not IsDBNull(eachQty("Qty")) Then
                    sampleLensQty = sampleLensQty + Convert.ToInt32(eachQty("Qty"))
                End If
            Next

            If productline = "PMMA" Then
                If sampleLensQty < 70 Then
                    GRID2.Rows.Clear()
                    DataGridView1.DataSource.Rows.Clear()
                    TextBox1.Text = ""
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHILIC" Then
                If sampleLensQty < 73 Then
                    GRID2.Rows.Clear()
                    DataGridView1.DataSource.Rows.Clear()
                    TextBox1.Text = ""
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHOBIC" Then
                If sampleLensQty < 64 Then
                    GRID2.Rows.Clear()
                    TextBox1.Text = ""
                    DataGridView1.DataSource.Rows.Clear()
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                If sampleLensQty < 64 Then
                    GRID2.Rows.Clear()
                    TextBox1.Text = ""
                    DataGridView1.DataSource.Rows.Clear()
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            End If


            Ds = getDistinctTrayNumber()
            If cmbStbatch.Text = "" Then
                MessageBox.Show("Please Select Batch Number")
                Exit Sub
            End If
            For Each eachRow As DataRow In Ds.Tables(0).Rows
                If Not IsDBNull(eachRow("tray_no")) Then
                    If eachRow("tray_no") <> "" Then
                        MessageBox.Show("Tray Number Already Generated")
                        Exit Sub
                    End If
                End If
            Next

            header_id = getLastHeaderId()


            GRID2.Rows.Clear()
            dsAllSerial = getAllSeialNumber()
            DataGridView1.DataSource.Rows.Clear()

            If productline = "PHILIC" Then 'Or productline = "PMMA"
                dsDistinctModel = getDistintModel()
                For Each eachModel As DataRow In dsDistinctModel.Tables(0).Rows
                    maxTrayQty = getMaximumTrayQty(eachModel("Brand_Name").ToString())
                    If maxTrayQty = 0 Then
                        MessageBox.Show("Maximum Quantity not assigned  " & eachModel("Brand_Name").ToString())
                        Exit Sub
                    End If
                    Dim i As Integer = 0
                    For Each eachRow As DataRow In dsAllSerial.Tables(0).Select("Model_Name = '" & eachModel("Model_Name").ToString() & "'")
                        serialTable.Rows.Add(eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_No"), eachRow("lotno"), eachRow("St_SrNo"), eachRow("Qty"), "Tray/" & Format(Now, "ddMMyy") & "/" & header_id.ToString("0000"))
                        i = i + 1
                        If i Mod maxTrayQty = 0 Then

                            header_id = header_id + 1
                        End If

                    Next
                    If i Mod maxTrayQty <> 0 Then

                        header_id = header_id + 1
                    End If
                Next
            Else
                dsDistinctModel = getDistintModel()
                For Each eachModel As DataRow In dsDistinctModel.Tables(0).Rows
                    maxTrayQty = getMaximumTrayQty(eachModel("Brand_Name").ToString())
                    If maxTrayQty = 0 Then
                        MessageBox.Show("Maximum Quantity not assigned  " & eachModel("Brand_Name").ToString())
                        Exit Sub
                    End If
                    Dim i As Integer = 0
                    For Each eachRow As DataRow In dsAllSerial.Tables(0).Select("Model_Name = '" & eachModel("Model_Name").ToString() & "' AND lotno = '" & eachModel("LotNo").ToString() & "'")
                        serialTable.Rows.Add(eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_No"), eachRow("lotno"), eachRow("St_SrNo"), eachRow("Qty"), "Tray/" & Format(Now, "ddMMyy") & "/" & header_id.ToString("0000"))
                        i = i + 1
                        If i Mod maxTrayQty = 0 Then
                            header_id = header_id + 1
                        End If

                    Next
                    If i Mod maxTrayQty <> 0 Then

                        header_id = header_id + 1
                    End If

                Next
            End If

            DataGridView1.DataSource = serialTable

            Dim tray_no As String = ""
            Dim LotNo As String = ""
            Dim serialFrom As String = ""
            Dim serialTo As String = ""
            Dim ModelName As String = ""
            Dim Power As String = ""
            Dim qty As Integer = 0
            For i = 0 To serialTable.Rows.Count - 1
                If LotNo <> serialTable.Rows(i)("Lot_Number") Or tray_no <> serialTable.Rows(i)("TrayNo") Or ModelName <> serialTable.Rows(i)("Model_Name") Or Power <> serialTable.Rows(i)("Power") Then
                    If LotNo <> "" Then
                        GRID2.Rows.Add(ModelName, Power, serialTable.Rows(i - 1)("Batch"), LotNo, serialFrom, serialTo, qty, tray_no)
                    End If
                    tray_no = serialTable.Rows(i)("TrayNo")
                    LotNo = serialTable.Rows(i)("Lot_Number")
                    serialFrom = serialTable.Rows(i)("St_SrNo")
                    serialTo = serialTable.Rows(i)("St_SrNo")
                    ModelName = serialTable.Rows(i)("Model_Name")
                    Power = serialTable.Rows(i)("Power")
                    qty = 1
                Else
                    serialTo = serialTable.Rows(i)("St_SrNo")
                    qty = qty + 1
                End If
                If i = serialTable.Rows.Count - 1 Then
                    GRID2.Rows.Add(ModelName, Power, serialTable.Rows(i)("Batch"), LotNo, serialFrom, serialTo, qty, tray_no)
                End If
            Next

            TextBox1.Text = (serialTable.Rows.Count).ToString()

            '17-08-2023
            DataGridView2.Rows.Clear()
            Try
                DataGridView2.Columns.Remove("RackNo")
            Catch ex As System.Exception

            End Try

            tray_no = ""
            ModelName = ""
            qty = 0
            For i = 0 To GRID2.Rows.Count - 1
                If tray_no <> GRID2.Rows(i).Cells("TrayNo").Value.ToString() Then
                    If tray_no <> "" Then
                        DataGridView2.Rows.Add(GRID2.Rows(i).Cells("Batch").Value.ToString(), qty, tray_no, ModelName)
                    End If
                    tray_no = GRID2.Rows(i).Cells("TrayNo").Value.ToString()
                    ModelName = GRID2.Rows(i).Cells("Model_Name").Value.ToString()
                    qty = Val(GRID2.Rows(i).Cells("Qty").Value)
                Else
                    qty = qty + Val(GRID2.Rows(i).Cells("Qty").Value)
                End If
                If i = GRID2.Rows.Count - 1 Then
                    DataGridView2.Rows.Add(GRID2.Rows(i).Cells("Batch").Value.ToString(), qty, tray_no, GRID2.Rows(i).Cells("Model_Name").Value.ToString())
                End If
            Next

            'Add a ComboBox Column to the DataGridView.
            Dim comboBoxColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
            comboBoxColumn.HeaderText = "RackNo"
            comboBoxColumn.Width = 80
            comboBoxColumn.Name = "RackNo"
            DataGridView2.Columns.Add(comboBoxColumn)

            dsRackId = getDistinctRackId()
            For Each row As DataGridViewRow In DataGridView2.Rows
                'Reference the ComboBoxCell.
                Dim comboBoxCell As DataGridViewComboBoxCell = CType(row.Cells(4), DataGridViewComboBoxCell)

                comboBoxCell.DataSource = dsRackId.Tables(0)
                comboBoxCell.DisplayMember = "RackId"
                'For Each drow As DataRow In dsRackId.Tables(0).Rows
                '    comboBoxCell.Items.Add(drow(0))
                'Next
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub
    Public Function getDistinctRackId() As DataSet

        Dim ds, ds1 As New DataSet
        Dim distinctRack As String = ""
        Dim StrSql As String = "SELECT DISTINCT Rack_Location from POUCH_LABEL  WHERE    (Rack_Location IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        For Each row As DataRow In ds.Tables(0).Rows
            distinctRack = distinctRack + "'" + row("Rack_Location") + "',"
        Next

        If distinctRack = "" Then
            distinctRack = "''"
        Else
            distinctRack = distinctRack.Remove(distinctRack.Length - 1, 1)
        End If

        'StrSql = "SELECT DISTINCT RackId FROM  Rack_Master WHERE RackId NOT IN (SELECT DISTINCT Rack_Location from POUCH_LABEL  WHERE    ( (Mfd_Year = '2023') AND (Mfd_Month NOT IN ('1', '2', '3', '4'))   OR (Mfd_Year >= '2024') ) AND (Rack_Location IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) ) Order by RackId"
        StrSql = "SELECT DISTINCT RackId FROM  Rack_Master WHERE RackId NOT IN (" + distinctRack + ") Order by RackId"
        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(ds1)
        Return ds1

    End Function

    Public Function getDistinctTrayNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE (Btc_No = '" & cmbStbatch.Text & "')  AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) AND (Tray_Label_Gen IS NULL) AND (Tray_No IS NULL) AND (Rack_Location IS NULL) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function getDistinctTrayNumberForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE (Btc_No = '" & cmbStrBatchReprint.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function getTrayDetail(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing
        If rdoReprint.Checked = True Then
            StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)    AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Btc_No = '" & cmbStrBatchReprint.Text & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"
        Else
            StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3) + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)    AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No, Rack_Location FROM POUCH_LABEL  WHERE  (Btc_No = '" & cmbStbatch.Text & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location  ORDER BY Lot_Prefix, Lot_No"
        End If

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        'For Each eachRow As DataRow In ds.Tables(0).Rows
        '    trayDetail = trayDetail + Environment.NewLine + eachRow("TrayDeatil").ToString()
        'Next
        'Return trayDetail
    End Function
    Public Sub Tray_Label_Gen_Update()
        Dim strsql As String
        strsql = " update POUCH_LABEL set  Tray_Label_Gen =1  WHERE  (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)"
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        Dim strsql1 As String
        strsql1 = " update TRAY_GEN set  Label_Printed =1  WHERE  (Btc_No = '" & cmbStbatch.Text & "')"
        Dim cmd1 As New SqlCommand(strsql1, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd1.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Function getDistinctTrayNumberForPrint(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Try
            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim dsTrayDetail As New DataSet
            Dim RackNo As String = Nothing

            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0
            Dim trayNos As String = ""


            For i = 0 To DataGridView2.Rows.Count - 1
                trayNos = trayNos + "'" + DataGridView2.Rows(i).Cells("TrayNo1").Value.ToString() + "',"
            Next
            If trayNos = "" Then
                trayNos = "''"
            Else
                trayNos = trayNos.Remove(trayNos.Length - 1, 1)
            End If
            Sql = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE (Btc_No = '" & cmbStbatch.Text & "')  AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) AND  (Tray_No in(" & trayNos & "))  order by Tray_No"

            Ds = getDistinctTrayNumberForPrint(Sql)
            'Ds = getDistinctTrayNumber()


            If isSaved = False Then
                MessageBox.Show("Please Click Save Button")
                Exit Sub
            End If

            For Each eachRow As DataRow In Ds.Tables(0).Rows
                trayDetail = ""
                trayModel = ""
                trayPower = ""
                trayLotNo = ""
                StSrNo = 200
                EnSrNo = 0
                totTrayQty = 0

                If Not IsDBNull(eachRow("tray_no")) Then

                    Dim StrFName As String = ""
                    If productline = "PMMA" Then
                        StrFName = "Tray_Label_PMMA.btw"
                    ElseIf productline = "PHILIC" Then
                        StrFName = "Tray_Label_philic.btw"
                    ElseIf productline = "PHOBIC" Then
                        StrFName = "Tray_Label_phobic.btw"
                    ElseIf productline = "PHOBIC NONPRELOADED" Then
                        StrFName = "Tray_Label_phobic.btw"
                    End If

                    btFile = Application.StartupPath & "\" & StrFName & ""
                    If System.IO.File.Exists(btFile) Then
                        'The file exists
                    Else
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If

                    Dim traydetailRowCount As Integer = 0
                    dsTrayDetail = getTrayDetail(eachRow("tray_no"))

                    For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows

                        trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                        trayModel = eachRecord("Model_Name").ToString()
                        RackNo = eachRecord("Rack_Location").ToString()

                        'PHOBIC
                        trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                        trayLotNo = eachRecord("lotno").ToString()
                        If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                            StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                        End If
                        If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                            EnSrNo = Convert.ToInt32(eachRecord("STO"))
                        End If
                        totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                        'Next Label print
                        traydetailRowCount = traydetailRowCount + 1
                        'If productline = "PHILIC" Then 'Or productline = "PMMA" 
                        If traydetailRowCount = 6 Then
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            bt.SetNamedSubStringValue("trayDetail", trayDetail)
                            bt.SetNamedSubStringValue("model", trayModel)
                            bt.SetNamedSubStringValue("trayNo", eachRow("tray_no").ToString())
                            bt.SetNamedSubStringValue("batchNo", cmbStbatch.Text)

                            'PHOBIC
                            bt.SetNamedSubStringValue("power", trayPower)
                            bt.SetNamedSubStringValue("lotno", trayLotNo)
                            bt.SetNamedSubStringValue("sFrom", StSrNo)
                            bt.SetNamedSubStringValue("sTo", EnSrNo)
                            bt.SetNamedSubStringValue("qty", totTrayQty)
                            bt.SetNamedSubStringValue("rackNo", RackNo)


                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                            traydetailRowCount = 0
                            trayDetail = ""
                            trayModel = ""
                            totTrayQty = 0

                        End If
                        'End If
                    Next


                    If traydetailRowCount = 0 Then 'Or productline = "PMMA" (productline = "PHILIC") And
                    Else
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                        bt.SetNamedSubStringValue("trayDetail", trayDetail)
                        bt.SetNamedSubStringValue("model", trayModel)
                        bt.SetNamedSubStringValue("trayNo", eachRow("tray_no").ToString())
                        bt.SetNamedSubStringValue("batchNo", cmbStbatch.Text)

                        'PHOBIC
                        bt.SetNamedSubStringValue("power", trayPower)
                        bt.SetNamedSubStringValue("lotno", trayLotNo)
                        bt.SetNamedSubStringValue("sFrom", StSrNo)
                        bt.SetNamedSubStringValue("sTo", EnSrNo)
                        bt.SetNamedSubStringValue("qty", totTrayQty)
                        bt.SetNamedSubStringValue("rackNo", RackNo)


                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    End If

                End If
            Next
            'Tray_Label_Gen_Update()
            GRID2.Rows.Clear()
            DataGridView2.Rows.Clear()
            DataGridView1.DataSource.Rows.Clear()
            TextBox1.Text = ""
            cmbStbatch.Text = ""
            isSaved = False
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
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

    Private Sub frmlotallotprint_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        killProcess("bartend")
        cmbStbatch.Text = ""
    End Sub

    Private Sub cmbStbatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStbatch.SelectedIndexChanged
        'Dim trayDetail1 As String = Nothing

        'trayDetail1 = cmbStbatch.Text
        'trayDetail1 = ""
    End Sub
    Public Sub PouchLabelUpdateNew(ByVal strsql As String)

        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
    Public Sub trayGenInsertNew(ByVal StrSql As String)

        Dim Cmd As New SqlCommand(StrSql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try

            Dim header_id As Integer
            Dim tray_no As String = ""
            Dim tray_qty As Integer
            Dim strUpdateQry As String = ""
            Dim strInsertQry As String = ""
            Dim lstRacks As List(Of String) = New List(Of String)

            If DataGridView1.Rows.Count = 0 Or GRID2.Rows.Count = 0 Then
                MessageBox.Show("Please Preview the Batch")
                Exit Sub
            End If

            For i = 0 To DataGridView2.Rows.Count - 1
                If DataGridView2.Rows(i).Cells("RackNo").Value Is Nothing Then
                    MessageBox.Show("Please Choose the Rack Id.")
                    Exit Sub
                End If
                'If Not lstRacks.Contains(DataGridView2.Rows(i).Cells("RackNo").Value.ToString()) Then
                '    lstRacks.Add(DataGridView2.Rows(i).Cells("RackNo").Value.ToString())
                'Else
                '    MessageBox.Show("You Choosed same RackNo for multiple TrayNo")
                '    Exit Sub
                'End If
            Next

            'For Speed testing
            For i = 0 To DataGridView1.Rows.Count - 1

                strUpdateQry = strUpdateQry + "('" + DataGridView1.Rows(i).Cells("TrayNo").Value.ToString() + "','" + DataGridView1.Rows(i).Cells("Lot_Number").Value.ToString() + "','" + DataGridView1.Rows(i).Cells("St_SrNo").Value.ToString() + "'),"

            Next
            strUpdateQry = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
            strUpdateQry = "MERGE INTO pouch_label USING(VALUES " & strUpdateQry & ") AS source(tray_no1, lot_no1,st_srno1) ON Lot_Prefix+Lot_No = source.lot_no1 AND St_SrNo =source.st_srno1 WHEN MATCHED THEN Update SET  Tray_No = source.tray_no1;"
            PouchLabelUpdateNew(strUpdateQry)

            For i = 0 To GRID2.Rows.Count - 1
                If tray_no <> GRID2.Rows(i).Cells("TrayNo").Value.ToString() Then
                    If i <> 0 Then
                        strInsertQry = strInsertQry + "(" + header_id.ToString() + ",'" + cmbStbatch.Text + "','" + tray_qty.ToString() + "','" + tray_no + "','" + StrLoginUser + "', GETDATE() ,'" + StrLoginUser + "', GETDATE()),"
                        tray_qty = 0
                    End If
                End If
                tray_no = GRID2.Rows(i).Cells("TrayNo").Value.ToString()
                tray_qty = tray_qty + Convert.ToInt32(GRID2.Rows(i).Cells("Qty").Value)
                header_id = Convert.ToInt32(tray_no.Split("/"c)(tray_no.Split("/"c).Length - 1))
                If i = GRID2.Rows.Count - 1 Then
                    strInsertQry = strInsertQry + "(" + header_id.ToString() + ",'" + cmbStbatch.Text + "','" + tray_qty.ToString() + "','" + tray_no + "','" + StrLoginUser + "', GETDATE() ,'" + StrLoginUser + "', GETDATE()),"
                End If
            Next
            strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
            strInsertQry = "Insert into TRAY_GEN (Header_ID,Btc_No,Qty,Tray_No,	Created_By,	Created_Date,	Modified_By,	Modified_Date) VALUES " & strInsertQry
            trayGenInsertNew(strInsertQry)






            'For i = 0 To GRID2.Rows.Count - 2
            '    If tray_no <> GRID2.Rows(i).Cells("TrayNo").Value.ToString() Then
            '        If i <> 0 Then
            '            trayGenInsert(header_id, tray_qty, tray_no)
            '            tray_qty = 0
            '        End If
            '    End If
            '    tray_no = GRID2.Rows(i).Cells("TrayNo").Value.ToString()
            '    tray_qty = tray_qty + Convert.ToInt32(GRID2.Rows(i).Cells("Qty").Value)
            '    header_id = Convert.ToInt32(tray_no.Split("/"c)(tray_no.Split("/"c).Length - 1))

            '    PouchLabelUpdate(GRID2.Rows(i).Cells("Lot_No").Value.ToString(), GRID2.Rows(i).Cells("Serial_From").Value.ToString(), GRID2.Rows(i).Cells("Serial_To").Value.ToString(), GRID2.Rows(i).Cells("TrayNo").Value.ToString())
            '    If i = GRID2.Rows.Count - 2 Then
            '        trayGenInsert(header_id, tray_qty, tray_no)
            '    End If
            'Next


            'Update Rack Id in Pouch_Label
            strUpdateQry = ""
            For i = 0 To DataGridView2.Rows.Count - 1

                strUpdateQry = strUpdateQry + "('" + DataGridView2.Rows(i).Cells("RackNo").Value.ToString() + "','" + DataGridView2.Rows(i).Cells("TrayNo1").Value.ToString() + "'),"

            Next
            strUpdateQry = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
            strUpdateQry = "MERGE INTO pouch_label USING(VALUES " & strUpdateQry & ") AS source(RackNo1, tray_no1) ON Tray_No = source.Tray_no1 WHEN MATCHED THEN Update SET       Rack_Location = source.RackNo1;"
            PouchLabelUpdateNew(strUpdateQry)

            isSaved = True
            Tray_Label_Gen_Update()
            DataGridView2.Columns(3).ReadOnly = True
            MessageBox.Show("Data Saved.")

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
    Public Function RackLocationBindForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Rack_Location from POUCH_LABEL  WHERE (Tray_No IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Rack_Location"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub rdoReprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoReprint.CheckedChanged
        If rdoReprint.Checked = True Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox7.Visible = False
            GRID2.Rows.Clear()
            TextBox1.Text = ""
            DataGridView1.DataSource.Rows.Clear()
            DataGridView2.Rows.Clear()
            Try
                cmbRackLocation.Items.Clear()
            Catch ex As Exception
            End Try
            Try
                cmbRackLocation.DataSource.Clear()
            Catch ex As Exception
            End Try
            Ds = RackLocationBindForReprint()
            cmbRackLocation.DataSource = Ds.Tables(0)
            cmbRackLocation.DisplayMember = "Rack_Location"

        ElseIf rdoReprint.Checked = False Then
            GroupBox1.Visible = False
            GroupBox3.Visible = False
            GroupBox7.Visible = True
            TextBox1.Text = ""
        End If
        
    End Sub



    Private Sub cmbStrBatchReprint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStrBatchReprint.SelectedIndexChanged
        Ds = getDistinctTrayNumberForReprint()
        cmbTrayNo.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbTrayNo.Items.Add(eachRow1("tray_no"))
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim RackNo As String = Nothing
            Dim dsTrayDetail As New DataSet


            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0

            If cmbStrBatchReprint.Text = "" Or cmbTrayNo.Text = "" Then
                MessageBox.Show("Please Choose the Tray Number")
                Exit Sub
            End If

            If cmbStrBatchReprint.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Batch")
                cmbStrBatchReprint.Focus()
                Exit Sub
            End If

            If cmbTrayNo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Tray No")
                cmbTrayNo.Focus()
                Exit Sub
            End If


            Dim StrFName As String = ""
            If productline = "PMMA" Then
                StrFName = "Tray_Label_PMMA.btw"
            ElseIf productline = "PHILIC" Then
                StrFName = "Tray_Label_philic.btw"
            ElseIf productline = "PHOBIC" Then
                StrFName = "Tray_Label_phobic.btw"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrFName = "Tray_Label_phobic.btw"
            End If

            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            Dim traydetailRowCount As Integer = 0
            dsTrayDetail = getTrayDetail(cmbTrayNo.Text)
            For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                trayModel = eachRecord("Model_Name").ToString()
                RackNo = eachRecord("Rack_Location").ToString()

                'PHOBIC
                trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                trayLotNo = eachRecord("lotno").ToString()
                If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                    StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                End If
                If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                    EnSrNo = Convert.ToInt32(eachRecord("STO"))
                End If
                totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                'Next Label print
                traydetailRowCount = traydetailRowCount + 1
                'If productline = "PHILIC" Then
                If traydetailRowCount = 6 Then
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", cmbTrayNo.Text)
                    bt.SetNamedSubStringValue("batchNo", cmbStrBatchReprint.Text)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    traydetailRowCount = 0
                    trayDetail = ""
                    trayModel = ""
                    totTrayQty = 0
                End If
                ' End If

            Next

            If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
            Else
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                bt.SetNamedSubStringValue("trayDetail", trayDetail)
                bt.SetNamedSubStringValue("model", trayModel)
                bt.SetNamedSubStringValue("trayNo", cmbTrayNo.Text)
                bt.SetNamedSubStringValue("batchNo", cmbStrBatchReprint.Text)

                'PHOBIC
                bt.SetNamedSubStringValue("power", trayPower)
                bt.SetNamedSubStringValue("lotno", trayLotNo)
                bt.SetNamedSubStringValue("sFrom", StSrNo)
                bt.SetNamedSubStringValue("sTo", EnSrNo)
                bt.SetNamedSubStringValue("qty", totTrayQty)

                bt.SetNamedSubStringValue("rackNo", RackNo)

                bt.PrintOut()
                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                cmbTrayNo.Text = ""
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
        
    End Sub

    Private Sub RdoPrint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoPrint.CheckedChanged
        If RdoPrint.Checked = True Then
            GroupBox1.Visible = False
            GroupBox7.Visible = True
            TextBox1.Text = ""
        ElseIf RdoPrint.Checked = False Then
            GroupBox1.Visible = True
            GroupBox7.Visible = False
            GRID2.Rows.Clear()
            TextBox1.Text = ""
            DataGridView1.DataSource.Rows.Clear()
        End If

        'Print
        Ds = SterileBatchBind()
        cmbStbatch.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbStbatch.Items.Add(eachRow("Btc_No"))
        Next

        'Reprint
        Ds = SterileBatchBindForReprint()
        cmbStrBatchReprint.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbStrBatchReprint.Items.Add(eachRow1("Btc_No"))
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Users\Bhuvana\Desktop\sundar\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = fd.FileName
        End If

    End Sub


    Public Function getTrayNumber(ByVal rackLocation As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        StrSql = "SELECT  DISTINCT Tray_No  FROM POUCH_LABEL  WHERE  (Rack_Location = '" & cmbRackLocation.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  ORDER BY Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
       
    End Function

    Public Function getTrayDetail_RackBased(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing
        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)   AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Rack_location = '" & cmbRackLocation.Text & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        'For Each eachRow As DataRow In ds.Tables(0).Rows
        '    trayDetail = trayDetail + Environment.NewLine + eachRow("TrayDeatil").ToString()
        'Next
        'Return trayDetail
    End Function

    Private Sub btnPrintRackWise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRackWise.Click
        Try

            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim RackNo As String = Nothing
            Dim dsTrayDetail, dsDistinctTray As New DataSet



            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim trayNo As String = Nothing
            Dim str_batch As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0

            If cmbRackLocation.Text = "" Then
                MessageBox.Show("Please Choose the Rack Location")
                Exit Sub
            End If

            If cmbRackLocation.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Rack Location")
                cmbRackLocation.Focus()
                Exit Sub
            End If

            Dim StrFName As String = ""
            If productline = "PMMA" Then
                StrFName = "Tray_Label_PMMA.btw"
            ElseIf productline = "PHILIC" Then
                StrFName = "Tray_Label_philic.btw"
            ElseIf productline = "PHOBIC" Then
                StrFName = "Tray_Label_phobic.btw"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrFName = "Tray_Label_phobic.btw"
            End If

            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            dsDistinctTray = getTrayNumber(cmbRackLocation.Text)

            Dim traydetailRowCount As Integer = 0
            For Each eachRow As DataRow In dsDistinctTray.Tables(0).Rows
                StSrNo = 200
                EnSrNo = 0
                traydetailRowCount = 0
                trayDetail = ""
                trayModel = ""
                totTrayQty = 0

                dsTrayDetail = getTrayDetail_RackBased(eachRow("Tray_No").ToString())
                For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                    trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                    trayModel = eachRecord("Model_Name").ToString()
                    RackNo = eachRecord("Rack_Location").ToString()
                    trayNo = eachRecord("Tray_No").ToString()
                    str_batch = eachRecord("Btc_No").ToString()
                    'PHOBIC
                    trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                    trayLotNo = eachRecord("lotno").ToString()
                    If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                        StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                    End If
                    If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                        EnSrNo = Convert.ToInt32(eachRecord("STO"))
                    End If
                    totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                    'Next Label print
                    traydetailRowCount = traydetailRowCount + 1
                    'If productline = "PHILIC" Then
                    If traydetailRowCount = 6 Then
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("trayDetail", trayDetail)
                        bt.SetNamedSubStringValue("model", trayModel)
                        bt.SetNamedSubStringValue("trayNo", trayNo)
                        bt.SetNamedSubStringValue("batchNo", str_batch)

                        'PHOBIC
                        bt.SetNamedSubStringValue("power", trayPower)
                        bt.SetNamedSubStringValue("lotno", trayLotNo)
                        bt.SetNamedSubStringValue("sFrom", StSrNo)
                        bt.SetNamedSubStringValue("sTo", EnSrNo)
                        bt.SetNamedSubStringValue("qty", totTrayQty)
                        bt.SetNamedSubStringValue("rackNo", RackNo)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        traydetailRowCount = 0
                        trayDetail = ""
                        trayModel = ""
                        totTrayQty = 0
                    End If
                    'End If

                Next

                If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
                Else
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", trayNo)
                    bt.SetNamedSubStringValue("batchNo", str_batch)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    cmbTrayNo.Text = ""
                End If
            Next

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        

        
    End Sub
End Class