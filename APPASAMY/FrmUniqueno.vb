
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmUniqueno
    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID2.CellContentClick

    End Sub

    Private Sub FrmUniqueno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'cmbmodel.Items.Clear()
        'getdetail = "SELECT DISTINCT MODEL_NAME FROM LOT_MASTER "
        'cmd = New SqlCommand(getdetail, con)
        'read = cmd.ExecuteReader
        'Do While read.Read
        '    cmbmodel.Items.Add(read.GetString(0))
        'Loop
        'cmd.Dispose()
        'read.Close()

        lblUser.Text = StrLoginUser
        lbldate.Text = Format(Now, "dd/MM/yyyy")

        cmbTolotno.Items.Clear()
        getdetail = "SELECT LOT_NO FROM LOT_MASTER"
        cmd = New SqlCommand(getdetail, con)
        read = cmd.ExecuteReader
        Do While read.Read
            cmbTolotno.Items.Add(read.GetString(0))
        Loop
        cmd.Dispose()
        read.Close()




        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from UNIQUE_MASTER"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
        If StrRsSeHd.Read Then
            Str_Header = IIf(IsDBNull(StrRsSeHd(0)), 0, StrRsSeHd(0))
        Else
            Str_Header = 0
        End If

        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If
        StrRsSeHd.Close()
        cmd.Dispose()



        StrUniqueNo = Format(Now, "ddmmyyyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo



        'GetTable()

        ' Create four typed columns in the DataTable.

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Lot_No", GetType(String))
        ''table.Columns.Add("Power", GetType(String))
        ''table.Columns.Add("B", GetType(String))
        ''table.Columns.Add("T", GetType(String))
        ''table.Columns.Add("Unit", GetType(String))
        ''table.Columns.Add("Mfd_Date", GetType(String))
        ''table.Columns.Add("Exp_Date", GetType(String))
        ''table.Columns.Add("Sterilization No", GetType(Integer))
        GRID2.DataSource = table






        ' Init.
        ' Set up the Header Color and Font.
        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With
        ' Fill in some Text.
        'For i As Int32 = 0 To 20
        '    Dim arrStrings As String()
        '    arrStrings = New String() _
        '     { _
        '     i.ToString, "Text " & i.ToString, i.ToString, _
        '     "Text " & i.ToString, i.ToString _
        '     }
        '    GRID2.Rows.Add(arrStrings)
        '    arrStrings = Nothing
        'Next i
    End Sub





    'Function GetTable() As DataTable
    '    ' Create new DataTable instance.
    '    Dim table As New DataTable
    '    ' Create four typed columns in the DataTable.
    '    table.Columns.Add("Lot_No", GetType(String))
    '    table.Columns.Add("Model_Name", GetType(String))
    '    table.Columns.Add("Power", GetType(String))
    '    table.Columns.Add("Width", GetType(String))
    '    table.Columns.Add("Height", GetType(String))
    '    table.Columns.Add("Unit", GetType(String))
    '    table.Columns.Add("Mfd_Date", GetType(String))
    '    table.Columns.Add("Exp_Date", GetType(String))

    '    '' Add five rows with those columns filled in the DataTable.
    '    'table.Rows.Add(25, "Indocin", "David", DateTime.Now)
    '    'table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now)
    '    'table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now)
    '    'table.Rows.Add(21, "Combivent", "Janet", DateTime.Now)
    '    'table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now)
    '    Return table




    'End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        'Dim table As New DataTable
        '' Create four typed columns in the DataTable.
        'table.Columns.Add("Lot_No", GetType(String))
        'table.Columns.Add("Model_Name", GetType(String))
        'table.Columns.Add("Power", GetType(String))
        'table.Columns.Add("Width", GetType(String))
        'table.Columns.Add("Height", GetType(String))
        'table.Columns.Add("Unit", GetType(String))
        'table.Columns.Add("Mfd_Date", GetType(String))
        'table.Columns.Add("Exp_Date", GetType(String))
        'table.Columns.Add("Lot_SrNo", GetType(String))






        'Sql = "Select Lm.Lot_No,Lm.Model_Name,Lm.Lot_Power,	Lm.Lot_Width,	Lm.Lot_height,	" & _
        '      "Lm.Lot_Unit,	(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mnf_Date,	(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date,	 " & _
        '      "right('00' + convert(varchar(3), Pm.Lot_Slno), 3) as Lot_Slno " & _
        '      "from LOT_MASTER Lm,PRINT_MASTER Pm " & _
        '      "where(Lm.Lot_No = Pm.Lot_No And Pm.Unique_no = 0 and Lm.Model_Name=Pm.Model_Name and  Pm.Lot_Slno between " & txtfrmslno.Text & " and " & txttoslno.Text & " and Pm.Lot_no='" & cmbTolotno.Text & "' and Pm.Model_Name='" & cmbmodel.Text & "')"


        Sql = "Select Lm.Lot_No,Lm.Model_Name,	Lm.Lot_Power,	Lm.Lot_Width,	Lm.Lot_height,	" & _
              "Lm.Lot_Unit,	(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mfd_Date,	(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date " & _
              "from LOT_MASTER Lm where Lm.Lot_No='" & cmbTolotno.Text & "' "
        cmd = New SqlCommand(Sql, con)
        Dr = cmd.ExecuteReader
        While Dr.Read
            DtRow = table.NewRow
            'table.Rows.Add(Dr)
            table.Rows.Add(Dr.GetValue(0), Dr.GetValue(1), Dr.GetValue(2), Dr.GetValue(3), Dr.GetValue(4), Dr.GetValue(5), Dr.GetValue(6), Dr.GetValue(7), txtfrmslno.Text, txttoslno.Text)
        End While
        Dr.Close()
        cmd.Dispose()

        'Ds.Tables.Add(table)



        'sqla = New SqlDataAdapter(Sql, con)
        'sqla.Fill(Ds, "1")
        'GRID2.DataSource = Ds.Tables("1")


        'Ds.Tables.Add(table)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from UNIQUE_MASTER"
        cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = cmd.ExecuteReader
        If StrRsSeHd.Read Then
            Str_Header = IIf(IsDBNull(StrRsSeHd(0)), 0, StrRsSeHd(0))
        Else
            Str_Header = 0
        End If

        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If
        StrRsSeHd.Close()
        cmd.Dispose()

        'StrUniqueNo = Format(Now, "ddmmyyyy") & "/" & Str_Header

        For i = 0 To GRID2.Rows.Count - 2
            Dim Sql As String


            Str_Detail = 0
            StrSqlSeDt = "Select Max(Detail_ID) from UNIQUE_MASTER"
            cmd = New SqlCommand(StrSqlSeDt, con)
            StrRsSeDt = cmd.ExecuteReader
            If StrRsSeDt.Read Then
                Str_Detail = IIf(IsDBNull(StrRsSeDt(0)), 0, StrRsSeDt(0))
            Else
                Str_Detail = 0
            End If

            If Str_Detail = 0 Then
                Str_Detail = 1
            Else
                Str_Detail = Str_Detail + 1
            End If
            StrRsSeDt.Close()
            cmd.Dispose()


            Sql = "Insert Into UNIQUE_MASTER (Header_ID,Detail_ID,Lot_No,Lot_Barcode,St_Type,St_Oven_Id,Unique_No, " & _
                  "Created_By,Created_Date,Modified_By,Modified_Date) values " & _
                  "('" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(0, i).Value & "','" & CmbStType.Text & "','" & CmbStOvenid.Text & "','" & StrUniqueNo & "', " & _
                  "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
            cmd = New SqlCommand(Sql, con)
            cmd.ExecuteNonQuery()

        Next i

        MsgBox("Saved ")




    End Sub

    Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim StrGrLot As String


            If txtlotbarno.Text <> "" Then
                StrLorBarNo = UCase(Trim(txtlotbarno.Text))



                For i = 0 To GRID2.Rows.Count - 2
                    StrGrLot = ""
                    StrGrLot = GRID2.Item(0, i).Value
                    If StrGrLot = txtlotbarno.Text Then
                        MsgBox("Already Scan")
                        txtlotbarno.Text = ""
                        txtlotbarno.Focus()
                        i = GRID2.Rows.Count - 2
                        Exit Sub
                    End If
                Next




                StrLotLesBarNo = StrLorBarNo.Substring(0, StrLorBarNo.Length - 4)

                Sql = "Select Lm.Lot_No,	Lm.Lot_Power,	Lm.Lot_Width,	Lm.Lot_height,	" & _
                 "Lm.Lot_Unit,	(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mfd_Date,	(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date " & _
                 "from LOT_MASTER Lm where Lm.Lot_No='" & StrLotLesBarNo & "' "
                cmd = New SqlCommand(Sql, con)
                Dr = cmd.ExecuteReader
                If Dr.Read Then
                    DtRow = table.NewRow
                    'table.Rows.Add(Dr)
                    'table.Rows.Add(Dr.GetValue(0), txtlotbarno.Text, Dr.GetValue(1), Dr.GetValue(2), Dr.GetValue(3), Dr.GetValue(4), Dr.GetValue(5), Dr.GetValue(6))
                    table.Rows.Add(txtlotbarno.Text, Dr.GetValue(0))
                    lblcount.Text = Val(lblcount.Text) + 1
                    txtlotbarno.Text = ""
                    txtlotbarno.Focus()









                Else
                    MsgBox("Scan Correct Lot No")
                    txtlotbarno.Text = ""
                    txtlotbarno.Focus()
                End If
                Dr.Close()
                cmd.Dispose()

            End If

        End If
    End Sub

    Private Sub txtlotbarno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlotbarno.LostFocus
        'Dim Sql As String
        'Dim Dr As SqlDataReader
        'Dim StrGrLot As String


        'If txtlotbarno.Text <> "" Then
        '    StrLorBarNo = UCase(Trim(txtlotbarno.Text))



        '    For i = 0 To GRID2.Rows.Count - 2
        '        StrGrLot = ""
        '        StrGrLot = GRID2.Item(0, i).Value
        '        If StrGrLot = txtlotbarno.Text Then
        '            MsgBox("Already Scan")
        '            txtlotbarno.Text = ""
        '            txtlotbarno.Focus()
        '            i = GRID2.Rows.Count - 2
        '            Exit Sub
        '        End If
        '    Next




        '    StrLotLesBarNo = StrLorBarNo.Substring(0, StrLorBarNo.Length - 4)

        '    Sql = "Select Lm.Lot_No,	Lm.Lot_Power,	Lm.Lot_Width,	Lm.Lot_height,	" & _
        '     "Lm.Lot_Unit,	(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mfd_Date,	(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date " & _
        '     "from LOT_MASTER Lm where Lm.Lot_No='" & StrLotLesBarNo & "' "
        '    cmd = New SqlCommand(Sql, con)
        '    Dr = cmd.ExecuteReader
        '    If Dr.Read Then
        '        DtRow = table.NewRow
        '        'table.Rows.Add(Dr)
        '        'table.Rows.Add(Dr.GetValue(0), txtlotbarno.Text, Dr.GetValue(1), Dr.GetValue(2), Dr.GetValue(3), Dr.GetValue(4), Dr.GetValue(5), Dr.GetValue(6))
        '        table.Rows.Add(txtlotbarno.Text, Dr.GetValue(0))
        '        lblcount.Text = Val(lblcount.Text) + 1
        '        txtlotbarno.Text = ""
        '        txtlotbarno.Focus()
        '    Else
        '        MsgBox("Scan Correct Lot No")
        '        txtlotbarno.Text = ""
        '        txtlotbarno.Focus()
        '    End If
        '    Dr.Close()
        '    cmd.Dispose()

        'End If



    End Sub




    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Dim Uni As New FrmUniqueno

        Uni.Show()
        Me.Close()

    End Sub

    Private Sub lblUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUser.Click

    End Sub








    '''''''''''''''''* GRIDVIEW STYLE ''''''''''''''''''''''''

#Region " Constants "
    Private Enum DGVHeaderImageAlignments As Int32
        [Default] = 0
        FillCell = 1
        SingleCentered = 2
        SingleLeft = 3
        SingleRight = 4
        Stretch = [Default]
        Tile = 5
    End Enum
#End Region
#Region " Events "
#Region " Handlers "
    Private Sub GRID2_CellPainting(ByVal sender As Object, _
    ByVal e As DataGridViewCellPaintingEventArgs) _
    Handles GRID2.CellPainting
        ' Only the Header Row (which Index is -1) is to be affected.
        If e.RowIndex = -1 Then
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.Button_Gray_Stripe_01_050, _
            ' DGVHeaderImageAlignments.Stretch)
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.AquaBall_Blue, DGVHeaderImageAlignments.FillCell)
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.AquaBall_Blue, _
            ' DGVHeaderImageAlignments.SingleCentered)
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.AquaBall_Blue, DGVHeaderImageAlignments.SingleLeft)
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.AquaBall_Blue, DGVHeaderImageAlignments.SingleRight)
            'GridDrawCustomHeaderColumns(GRID2, e, _
            ' My.Resources.AquaBall_Blue, DGVHeaderImageAlignments.Tile)
        End If
    End Sub
    'Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) _
    ' Handles Me.Load
    '    ' Init.
    '    ' Set up the Header Color and Font.
    '    With GRID2.ColumnHeadersDefaultCellStyle
    '        .Alignment = DataGridViewContentAlignment.TopRight
    '        .BackColor = Color.DarkRed
    '        .ForeColor = Color.Gold
    '        .Font = New Font(.Font.FontFamily, .Font.Size, _
    '         .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
    '    End With
    '    ' Fill in some Text.
    '    For i As Int32 = 0 To 20
    '        Dim arrStrings As String()
    '        arrStrings = New String() _
    '         { _
    '         i.ToString, "Text " & i.ToString, i.ToString, _
    '         "Text " & i.ToString, i.ToString _
    '         }
    '        GRID2.Rows.Add(arrStrings)
    '        arrStrings = Nothing
    '    Next i
    'End Sub
#End Region
#End Region
#Region " Methods "
    Private Sub GridDrawCustomHeaderColumns(ByVal dgv As DataGridView, _
     ByVal e As DataGridViewCellPaintingEventArgs, ByVal img As Image, _
     ByVal Style As DGVHeaderImageAlignments)
        ' All of the graphical Processing is done here.
        Dim gr As Graphics = e.Graphics
        ' Fill the BackGround with the BackGroud Color of Headers.
        ' This step is necessary, for transparent images, or what's behind
        ' would be painted instead.
        gr.FillRectangle( _
         New SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor), _
         e.CellBounds)
        If img IsNot Nothing Then
            Select Case Style
                Case DGVHeaderImageAlignments.FillCell
                    gr.DrawImage( _
                     img, e.CellBounds.X, e.CellBounds.Y, _
                     e.CellBounds.Width, e.CellBounds.Height)
                Case DGVHeaderImageAlignments.SingleCentered
                    gr.DrawImage(img, _
                     ((e.CellBounds.Width - img.Width) \ 2) + e.CellBounds.X, _
                     ((e.CellBounds.Height - img.Height) \ 2) + e.CellBounds.Y, _
                     img.Width, img.Height)
                Case DGVHeaderImageAlignments.SingleLeft
                    gr.DrawImage(img, e.CellBounds.X, _
                     ((e.CellBounds.Height - img.Height) \ 2) + e.CellBounds.Y, _
                     img.Width, img.Height)
                Case DGVHeaderImageAlignments.SingleRight
                    gr.DrawImage(img, _
                     (e.CellBounds.Width - img.Width) + e.CellBounds.X, _
                     ((e.CellBounds.Height - img.Height) \ 2) + e.CellBounds.Y, _
                     img.Width, img.Height)
                Case DGVHeaderImageAlignments.Tile
                    ' ********************************************************
                    ' To correct: It sould display just a stripe of images,
                    ' long as the whole header, but centered in the header's
                    ' height.
                    ' This code WON'T WORK.
                    ' Any one got any better solution?
                    'Dim rect As New Rectangle(e.CellBounds.X, _
                    ' ((e.CellBounds.Height - img.Height) \ 2), _
                    ' e.ClipBounds.Width, _
                    ' ((e.CellBounds.Height \ 2 + img.Height \ 2)))
                    'Dim br As New TextureBrush(img, Drawing2D.WrapMode.Tile, _
                    ' rect)
                    ' ********************************************************
                    ' This one works... but poorly (the image is repeated
                    ' vertically, too).
                    Dim br As New TextureBrush(img, Drawing2D.WrapMode.Tile)
                    gr.FillRectangle(br, e.ClipBounds)
                Case Else
                    gr.DrawImage( _
                     img, e.CellBounds.X, e.CellBounds.Y, _
                     e.ClipBounds.Width, e.CellBounds.Height)
            End Select
        End If
        'e.PaintContent(e.CellBounds)
        If e.Value Is Nothing Then
            e.Handled = True
            Return
        End If
        Using sf As New StringFormat
            With sf
                Select Case dgv.ColumnHeadersDefaultCellStyle.Alignment
                    Case DataGridViewContentAlignment.BottomCenter
                        .Alignment = StringAlignment.Center
                        .LineAlignment = StringAlignment.Far
                    Case DataGridViewContentAlignment.BottomLeft
                        .Alignment = StringAlignment.Near
                        .LineAlignment = StringAlignment.Far
                    Case DataGridViewContentAlignment.BottomRight
                        .Alignment = StringAlignment.Far
                        .LineAlignment = StringAlignment.Far
                    Case DataGridViewContentAlignment.MiddleCenter
                        .Alignment = StringAlignment.Center
                        .LineAlignment = StringAlignment.Center
                    Case DataGridViewContentAlignment.MiddleLeft
                        .Alignment = StringAlignment.Near
                        .LineAlignment = StringAlignment.Center
                    Case DataGridViewContentAlignment.MiddleRight
                        .Alignment = StringAlignment.Far
                        .LineAlignment = StringAlignment.Center
                    Case DataGridViewContentAlignment.TopCenter
                        .Alignment = StringAlignment.Center
                        .LineAlignment = StringAlignment.Near
                    Case DataGridViewContentAlignment.TopLeft
                        .Alignment = StringAlignment.Near
                        .LineAlignment = StringAlignment.Near
                    Case DataGridViewContentAlignment.TopRight
                        .Alignment = StringAlignment.Far
                        .LineAlignment = StringAlignment.Near
                End Select
                ' This part could be handled...
                'Select Case dgv.ColumnHeadersDefaultCellStyle.WrapMode
                '	Case DataGridViewTriState.False
                '		.FormatFlags = StringFormatFlags.NoWrap
                '	Case DataGridViewTriState.NotSet
                '		.FormatFlags = StringFormatFlags.NoWrap
                '	Case DataGridViewTriState.True
                '		.FormatFlags = StringFormatFlags.FitBlackBox
                'End Select
                .HotkeyPrefix = Drawing.Text.HotkeyPrefix.None
                .Trimming = StringTrimming.None
            End With
            With dgv.ColumnHeadersDefaultCellStyle
                gr.DrawString(e.Value.ToString, .Font, _
                 New SolidBrush(.ForeColor), e.CellBounds, sf)
            End With
        End Using
        e.Handled = True
    End Sub
#End Region
End Class