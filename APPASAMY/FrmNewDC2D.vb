Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows.Forms
Imports System.Net.Sockets
Imports System.Text
Imports CrystalDecisions.ReportSource
Imports System.Drawing
Imports System.Configuration
Imports System.IO
Imports System.Data
Public Class FrmNewDC2D
    'Dim RptForm As CrystalDecisions.CrystalReports.Engine.ReportDocument
    'Dim btFile As String
    'Dim StrReVin As String
    'Dim StrRePJI As String
    'Dim bc As String
    'Dim ipadd As String

    'Dim ops As New System.Drawing.Printing.PrinterSettings
    'Dim conString As String
    'Dim prnName As String
    'Dim port As String
    'Dim SData As String
    'Dim clientSocket As Socket
    'Dim serverStream As NetworkStream
    ''Dim RptForm As CrystalDecisions.CrystalReports.Engine.ReportDocument
    'Public Delegate Sub ADelegate(ByVal text As String)
    'Delegate Sub SetTextCallback(ByVal [text] As String)
    'Public Delegate Sub ADelegate1(ByVal text As String)
    'Delegate Sub SetTextCallback1(ByVal [text] As String)
    'Public temp_data As String, temp_vinno As String, temp_serialno As String
    'Public temp_processNo As String
    'Public temp_line As String
    'Dim StrChkCmd2 As SqlCommand
    'Public temp_PJI As String
    'Dim modelNo As String
    'Dim serialno As String

    ''Public temp_data As String, temp_vinno As String, temp_serialno As String
    ''Public temp_processNo As String
    ''Public temp_line As String
    'Public temp_Color As String
    'Public temp_Chk As String
    'Public temp_wt1 As String
    'Public temp_wt2 As String
    'Public temp_wt3 As String
    'Public temp_wt4 As String


    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim listlot As New ArrayList
    Dim i As Integer
    Dim intcount As Integer
    Dim dctwod As String
    Private Sub FrmNewDC2D_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim StrSql As String
        'Dim Cmd As SqlCommand
        'Dim StrRs As SqlDataReader


        'StrSql = "SELECT DISTINCT top(20)dc_NO,CONVERT(INT, SUBSTRING(dc_NO,6,10) )AS dc from Pouch_Label ORDER BY dc DESC"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'CmbDcNo.Items.Clear()
        'While StrRs.Read
        '    CmbDcNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'Cmd.Dispose()


        StrSql = "SELECT DISTINCT top(20)dc_NO,CONVERT(INT, SUBSTRING(dc_NO,6,10) )AS dc from Pouch_Label ORDER BY dc DESC"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        While StrRs.Read
            cbxdcno.Items.Add(StrRs.GetValue(0))
        End While
        StrRs.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If cbxdcno.Text <> "" Then
            StrSql = "select Distinct Lot_srno from Pouch_Label where DC_no='" & cbxdcno.Text & "'"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            While StrRs.Read
                listlot.Add(StrRs.GetValue(0))
            End While
            StrRs.Close()
            cmd.Dispose()
            Dim intpgno As Integer = 1
            For j As Integer = 1 To listlot.Count - 1

                StrSql = "select Lot_srno,Model_Name,Power,Exp_Month,Exp_year from Pouch_Label where Lot_Srno='" & listlot.Item(j) & "'"
                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    dctwod = dctwod & StrRs.GetValue(0) & "," & StrRs.GetValue(1) & "," & StrRs.GetValue(2) & "," & StrRs.GetValue(3) & "-" & StrRs.GetValue(4) & ";"
                    intcount += 1
                End If
                cmd.Dispose()
                StrRs.Close()

                If intcount = 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", cbxdcno.Text)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    dctwod = ""
                ElseIf intcount = 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    dctwod = ""
                    intcount = 0
                    intpgno += 1

                End If
            Next
            If intcount <> 0 Then
                If intcount < 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", cbxdcno.Text)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("DC2D22", " ")
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                ElseIf intcount > 80 And intcount < 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                End If
            End If

            StrRs.Close()
            cmd.Dispose()
        Else
            MsgBox("PLEASE SELECT DC NO")
        End If
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

    'Private Sub SaveBarcode()
    '    'Create a Barcode Professional object

    '    Dim bcp As New Neodynamic.WinControls.BarcodeProfessional.BarcodeProfessional()
    '    'Set the barcode symbology to Code 128

    '    bcp.Symbology = Neodynamic.WinControls.BarcodeProfessional.Symbology.Pdf417
    '    'Set the value to encode
    '    bc = ""
    '    'For i As Integer = 0 To lstDetails.Items.Count - 1
    '    '    If bc.Trim = "" Then
    '    '        bc = bc & lstDetails.Items(i).Text
    '    '    Else
    '    '        bc = bc & "," & lstDetails.Items(i).Text
    '    '    End If
    '    'Next

    '    'Dim StrSql As String
    '    'Dim StrRs As SqlDataReader
    '    'Dim cmd As SqlCommand
    '    'Dim StrVcd As String
    '    'Dim StrModelNo As String
    '    'modelNo = "TRFARDFD10EEAAAAAA"



    '    'StrSql = "Select * from TBLCONTROLCARD where VIN_NUMBER='" & txtVinno.Text & "'"
    '    'cmd = New SqlCommand(StrSql, con)
    '    'StrRs = cmd.ExecuteReader
    '    'If StrRs.Read Then
    '    '    StrModelNo = IIf(IsDBNull(StrRs.GetString(3)), "", StrRs.GetString(3))
    '    'Else
    '    '    StrModelNo = 0
    '    'End If
    '    'cmd.Dispose()
    '    'StrRs.Close()




    '    'StrSql = "Select * from VCD_Data where End_Item='" & StrModelNo & "'"
    '    'cmd = New SqlCommand(StrSql, con)
    '    'StrRs = cmd.ExecuteReader
    '    'If StrRs.Read Then
    '    '    StrVcd = IIf(IsDBNull(StrRs.GetString(1)), "", StrRs.GetString(1))
    '    'Else
    '    '    StrVcd = 0
    '    'End If
    '    'cmd.Dispose()
    '    'StrRs.Close()


    '    'bc = "108" & txtPJI.Text.ToString & txtVinno.Text.ToString & "CEDVD" & "JFLDSJFLADSFLKJDDLKJJJJJLDKLLLLLJKKLDJKJDDDSFKLJKLJSDDSFDSFKLJKDLJKLDSJF;LKJAKJJJJJJJLKDSJFJKDSHFKJHJHJHSGOEWRIUWEYRUYWEIUFHKJHDSJCVNBVNDKJGFDKJFHERWIUWYFIUOEWYRIUHDFAJBVMBJKDFSBADSNBVXVGADSLFHDSFJHDSABFADSKLFSJK"

    '    bc = "108" & "14274845448445614" & "/" & "564654516545154451" & "/CEDVD/"
    '    bcp.Code = bc    '"123451,123452,123453,123454,123455,123456,123457,123458,123459,123460"
    '    'Barcode dimensions settings (values measured in inches)

    '    bcp.BarHeight = 1.5F
    '    bcp.BarWidth = 0.02F
    '    'Resolution

    '    Dim dpi As Single = 200.0F
    '    'Save the TIFF barcode image on disk

    '    bcp.Save(AppDomain.CurrentDomain.BaseDirectory & "10157.Jpg", System.Drawing.Imaging.ImageFormat.Tiff, dpi, dpi)
    'End Sub


    'Public Sub getImage()
    '    Try
    '        ' here i have define a simple datatable inwhich image will recide
    '        Dim dt As New DataTable
    '        ' object of data row
    '        Dim drow As DataRow
    '        ' add the column in table to store the image of Byte array type
    '        dt.Columns.Add("Image", System.Type.GetType("System.Byte[]"))
    '        drow = dt.NewRow
    '        ' define the filestream object to read the image
    '        Dim fs As FileStream
    '        ' define te binary reader to read the bytes of image
    '        Dim br As BinaryReader
    '        ' check the existance of image
    '        If File.Exists(AppDomain.CurrentDomain.BaseDirectory & "10157.Jpg") Then
    '            ' open image in file stream
    '            fs = New FileStream(AppDomain.CurrentDomain.BaseDirectory & "10157.Jpg", FileMode.Open)
    '        Else ' if phot does not exist show the nophoto.jpg file
    '            fs = New FileStream(AppDomain.CurrentDomain.BaseDirectory & "NoPhoto.jpg", FileMode.Open)
    '        End If
    '        ' initialise the binary reader from file streamobject
    '        br = New BinaryReader(fs)
    '        ' define the byte array of filelength
    '        Dim imgbyte(fs.Length) As Byte
    '        ' read the bytes from the binary reader
    '        imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
    '        drow(0) = imgbyte       ' add the image in bytearray
    '        dt.Rows.Add(drow)       ' add row into the datatable
    '        br.Close()              ' close the binary reader
    '        fs.Close()              ' close the file stream
    '        Dim rptobj As New CrystalReport1    ' object of crystal report
    '        rptobj.SetDataSource(dt)
    '        RptForm = New CrystalDecisions.CrystalReports.Engine.ReportDocument

    '        'Dim T, T2, T3 As CrystalDecisions.CrystalReports.Engine.TextObject
    '        'Dim T1 As CrystalDecisions.CrystalReports.Engine.TextObject

    '        'RptForm = New CrystalReport1

    '        'CryViewBPLList.ReportSource = rptobj
    '        'CryViewBPLList.Show()

    '        'T = rptobj.ReportDefinition.Sections(0).ReportObjects("txtVin")
    '        'T1 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtSerialno")
    '        'T2 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtPJINo")
    '        'T3 = RptForm.ReportDefinition.Sections(0).ReportObjects("txtserialNoD")

    '        'T.Text = "*" & txtVinno.Text.ToString & "*"
    '        'T1.Text = "*" & txtSerialno.Text.ToString & "*"
    '        'T2.Text = "*" & txtPJI.Text.ToString & "*"
    '        'T1.Text = temp_serialno.ToString
    '        'T2.Text = temp_vinno.ToString.Substring(1, temp_vinno.ToString.Length - 2)
    '        'T3.Text = temp_serialno.ToString

    '        'CRVControlCard.ReportSource = RptForm
    '        'rptobj.PrintOptions.PrinterName = prnName

    '        ''CryViewBPLList.Update()
    '        ''CryViewBPLList.Validate()
    '        ''CryViewBPLList.Refresh()
    '        ''CryViewBPLList.Show()

    '        'rptobj.PrintToPrinter(1, False, 1, 1)
    '        'rptobj.Dispose()


    '        Exit Sub
    '        ' '' ''Dim T, T2, T3, T4, T5 As CrystalDecisions.CrystalReports.Engine.TextObject
    '        ' '' ''Dim T1 As CrystalDecisions.CrystalReports.Engine.TextObject
    '        ' '' ''T = rptobj.ReportDefinition.Sections(0).ReportObjects("txtItemCode")
    '        ' '' ''T1 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtCrop")
    '        ' '' ''T2 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtyear")
    '        ' '' ''T3 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtDOM")
    '        ' '' ''T4 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtWgt")
    '        ' '' ''T5 = rptobj.ReportDefinition.Sections(0).ReportObjects("txtlorryno")

    '        ' '' ''T.Text = txtitemcode.Text
    '        ' '' ''T1.Text = txtcrop.Text
    '        ' '' ''T2.Text = txtyear.Text
    '        ' '' ''T3.Text = txtdob.Text
    '        ' '' ''T4.Text = txtwgt.Text
    '        ' '' ''T5.Text = txtlorryno.Text

    '        'rptobj.PrintOptions.PrinterName = prnname
    '        'rptobj.PrintToPrinter(1, False, 1, 1)
    '        ' set the datasource of crystalreport object
    '        'CrystalReportViewer1.ReportSource = rptobj  'set the report source
    '        'CrystalReportViewer1.Visible = True
    '    Catch ex As Exception
    '        ' error handling
    '        MsgBox(ex.Message)
    '        MsgBox("Missing 10157.jpg or nophoto.jpg in application folder")
    '    End Try
    'End Sub

    'Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim StrSql As String
    '    Dim Cmd As SqlCommand
    '    Dim StrRs As SqlDataReader
    '    Dim LstSmB As New List(Of Integer)
    '    Dim LstSmL As New List(Of String)
    '    Dim StrDcNo As String
    '    Dim StrSmNo As String
    '    Dim StrBxNo As String
    '    Dim StrTotSm As String
    '    Dim StrTotBx As String
    '    Dim StrLot_All As String
    '    LstSmB.Clear()
    '    StrSql = "Select Distinct(Small_box) from Pouch_Label where Dc_No='" & CmbDcNo.Text & "'"
    '    Cmd = New SqlCommand(StrSql, con)
    '    StrRs = Cmd.ExecuteReader

    '    While StrRs.Read
    '        LstSmB.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
    '    End While

    '    Cmd.Dispose()
    '    StrRs.Close()

    '    'LstS.ToString()
    '    Dim nt1 As Integer
    '    StrSql = "dELETE FROM DC_TwoD_List"
    '    Cmd = New SqlCommand(StrSql, con)
    '    Cmd.ExecuteNonQuery()
    '    Cmd.Dispose()
    '    For StrSI = 0 To LstSmB.Count - 1
    '        LstSmB(StrSI).ToString()
    '        'StrSql = "select Lot_SrNo+','+convert(varchar(6),power)+' D,'+Model_Name+','+Reference_Name " & _
    '        '         "+','+convert(varchar(6),Optic)+' mm,'+convert(varchar(6),Length)+' mm,'+convert(varchar(6),Exp_Month)+'-'+convert(varchar(6),Exp_Year) " & _
    '        '         " AS sR, Numofsbox, numoflens, numofbigbox, numofsbinbb, scan, Small_box, Big_box, Dc_No " & _
    '        '         "from  Pouch_Label where dc_no='" & CmbDcNo.Text & "' and Small_box='" & LstSmB(StrSI) & "'"







    '        StrSql = "select Lot_SrNo+','+convert(varchar(6),power)+' D,'+Model_Name+','+Reference_Name " & _
    '                 "+','+convert(varchar(6),Exp_Month)+'-'+convert(varchar(6),Exp_Year) " & _
    '                 " AS sR, Numofsbox, numoflens, numofbigbox, numofsbinbb, scan, Small_box, Big_box, Dc_No " & _
    '                 "from  Pouch_Label where dc_no='" & CmbDcNo.Text & "' and Small_box='" & LstSmB(StrSI) & "'"
    '        Cmd = New SqlCommand(StrSql, con)
    '        StrRs = Cmd.ExecuteReader
    '        nt1 = 0
    '        While StrRs.Read
    '            nt1 = 1
    '            StrLot_All = StrLot_All & "#" & IIf(IsDBNull(StrRs.GetString(0)), "", StrRs.GetString(0))
    '            StrDcNo = IIf(IsDBNull(StrRs.GetString(8)), "", StrRs.GetString(8))
    '            StrSmNo = IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6))
    '            StrBxNo = IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7))
    '            StrTotSm = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
    '            StrTotBx = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
    '        End While

    '        Cmd.Dispose()
    '        StrRs.Close()


    '        If nt1 = 1 Then
    '            StrSql = "insert into DC_TwoD_List (Lot_All,Sm_No,Bx_No,Dc_No,No_SM,No_Bx)values " & _
    '                "('" & StrLot_All & "','" & StrSmNo & "','" & StrBxNo & "','" & StrDcNo & "','" & StrTotSm & "','" & StrTotBx & "')"
    '            Cmd = New SqlCommand(StrSql, con)
    '            Cmd.ExecuteNonQuery()
    '            Cmd.Dispose()
    '        End If



    '        StrLot_All = ""
    '        StrDcNo = ""
    '        StrSmNo = ""
    '        StrBxNo = ""
    '        StrTotSm = ""
    '        StrTotBx = ""

    '    Next



    '    'StrSql = "Select * from VCD_Data where End_Item='" & StrModelNo & "'"
    '    'cmd = New SqlCommand(StrSql, con)
    '    'StrRs = cmd.ExecuteReader
    '    'If StrRs.Read Then
    '    '    StrVcd = IIf(IsDBNull(StrRs.GetString(1)), "", StrRs.GetString(1))
    '    'Else
    '    '    StrVcd = 0
    '    'End If
    '    'cmd.Dispose()
    '    'StrRs.Close()
    '    'Dim cryRpt As New CrystalReport1
    '    ''cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")
    '    'CryViewBPLList.ReportSource = cryRpt
    '    '' CryViewBPLList.d()

    '    'cryRpt.VerifyDatabase()
    '    'SaveBarcode()
    '    'getImage()
    '    'CryViewBPLList.Update()
    '    'CryViewBPLList.Validate()
    '    'CryViewBPLList.Refresh()
    '    'CryViewBPLList.Show()
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cbxdcno.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class