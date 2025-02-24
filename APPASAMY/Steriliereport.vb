Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Steriliereport
    Dim table As New DataTable
    Dim Sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim Ds As New DataSet
    Dim DtRow As DataRow
    Dim StrRs As SqlDataReader
    Dim lotprefix As String
    Dim lotno As String
    Dim StAd As New SqlDataAdapter
    Dim StAd2 As New SqlDataAdapter
    Dim StSet2 As New DataSet
    Dim StSet3 As New DataSet
    Dim StSet4 As New DataSet
    Dim StSet As New DataSet


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Steriliereport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Steriliereport As New Form()


            Steriliereport.AutoScroll = True


            table.Columns.Add("Before Sterile", GetType(String))
            table.Columns.Add("After Sterile", GetType(String))
            table.Columns.Add("Sample Taken", GetType(String))
            table.Columns.Add("Sterile Reject", GetType(String))
            ''table.Columns.Add("B", GetType(String))
            ''table.Columns.Add("T", GetType(String))
            ''table.Columns.Add("Unit", GetType(String))
            ''table.Columns.Add("Mfd_Date", GetType(String))
            ''table.Columns.Add("Exp_Date", GetType(String))
            ''table.Columns.Add("Sterilization No", GetType(Integer))
            'GRID2.DataSource = table


            'With GRID2.ColumnHeadersDefaultCellStyle
            '    .Alignment = DataGridViewContentAlignment.TopRight
            '    .BackColor = Color.DarkRed
            '    .ForeColor = Color.Gold
            '    .Font = New Font(.Font.FontFamily, .Font.Size, _
            '     .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            'End With
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'Sql = "select * from POUCH_LABEL where Btc_No='" & TextBox1.Text & "' and Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 "
        'cmd = New SqlCommand(Sql, con)
        'If con.State = Data.ConnectionState.Open Then
        '    con.Close()
        'End If
        'con.Open()
        'dr = cmd.ExecuteReader
        'While dr.Read

        '    DtRow = table.NewRow

        '    table.Rows.Add(dr.GetValue(15), dr.GetValue(15), dr.GetValue(15), dr.GetValue(15))

        'End While
        'dr.Close()
        'cmd.Dispose()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If (TextBox1.Text <> "") Then
                Dim cryrpt As New StrileStockBefore

                Sql = "SELECT Btc_No FROM POUCH_LABEL WHERE Btc_No='" & TextBox1.Text & "' "
                cmd = New SqlCommand(Sql, con)
                StrRs = cmd.ExecuteReader

                If (StrRs.Read) Then

                    'lotprefix = StrRs.GetValue(0)
                    'lotno = StrRs.GetValue(1)
                    StrRs.Close()
                    cmd.Dispose()
                    Sql = "SELECT Brand_Name, Model_Name, Power, Lot_SrNo FROM POUCH_LABEL WHERE (Sterilization = 1) AND  (Btc_No='" & TextBox1.Text & "')  Group By Brand_Name, Model_Name, Power,Lot_SrNo Order By   Lot_SrNo , Power  ,Brand_Name, Model_Name "
                    StAd = New SqlDataAdapter(Sql, con)
                    StAd.Fill(StSet)
                    DataGridView1.DataSource = StSet.Tables(0)

                    Sql = "SELECT Brand_Name, Model_Name, Power, Lot_SrNo FROM POUCH_LABEL WHERE (Sterilization = 1) AND (Sterilization_After = 1)  AND  (Btc_No='" & TextBox1.Text & "')  Group By Brand_Name, Model_Name, Power,Lot_SrNo Order By Lot_SrNo , Power  ,Brand_Name, Model_Name"
                    StAd2 = New SqlDataAdapter(Sql, con)
                    StAd2.Fill(StSet2)
                    DataGridView2.DataSource = StSet2.Tables(0)

                    Sql = "SELECT Brand_Name, Model_Name, Power, Lot_SrNo , Type_Sample  FROM POUCH_LABEL WHERE (Sterilization = 1) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Sample_Taken=1) AND (Btc_No='" & TextBox1.Text & "')  Group By Brand_Name, Model_Name, Power,Lot_SrNo ,Type_Sample Order By Lot_SrNo , Power  ,Brand_Name, Model_Name"
                    StAd2 = New SqlDataAdapter(Sql, con)
                    StAd2.Fill(StSet3)
                    DataGridView3.DataSource = StSet3.Tables(0)



                    Sql = "SELECT Brand_Name, Model_Name, Power, Lot_SrNo FROM POUCH_LABEL WHERE (Sterilization = 1) AND (Sterilization_After = 1) AND (Sterilization_Reject = 1) AND (Sample_Taken=0) AND (Btc_No='" & TextBox1.Text & "')  Group By Brand_Name, Model_Name, Power,Lot_SrNo Order By Lot_SrNo , Power  ,Brand_Name, Model_Name"
                    StAd2 = New SqlDataAdapter(Sql, con)
                    StAd2.Fill(StSet4)
                    DataGridView4.DataSource = StSet4.Tables(0)


                    'cryrpt.SetDataSource(StSet.Tables(0))
                    'CrystalReportViewer1.ReportSource = cryrpt
                    ''cryrpt.VerifyDatabase()
                    ''CrystalReportViewer1.Update()
                    'CrystalReportViewer1.Refresh()

                Else
                    StrRs.Close()
                    cmd.Dispose()
                    MsgBox("Invalid Lot Srno")
                    TextBox1.Text = ""

                End If

                Dim Strsql As String
                Strsql = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where Sterilization=1 and Btc_No='" & TextBox1.Text & "'"
                cmd = New SqlCommand(Strsql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox2.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                Else
                    TextBox2.Text = ""

                End If
                StrRs.Close()
                cmd.Dispose()


                Dim Strsql1 As String
                Strsql1 = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where Sterilization=1  and Sterilization_After =1 and Btc_No='" & TextBox1.Text & "'"
                cmd = New SqlCommand(Strsql1, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox3.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                Else
                    TextBox3.Text = ""

                End If
                StrRs.Close()
                cmd.Dispose()




                Dim Strsql2 As String
                Strsql2 = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where Sterilization=1 and Sterilization_After=1 and Sample_Taken=1 and Type_Sample='CST' and Sterilization_Reject= 0 and Btc_No='" & TextBox1.Text & "'"
                cmd = New SqlCommand(Strsql2, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox4.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                Else
                    TextBox4.Text = ""

                End If
                StrRs.Close()
                cmd.Dispose()



                Dim Strsql3 As String
                Strsql3 = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where Sterilization=1 and Sterilization_After=1 and Sample_Taken=1 and Type_Sample='SST' and Sterilization_Reject=0  and Btc_No='" & TextBox1.Text & "'"
                cmd = New SqlCommand(Strsql3, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox6.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                Else
                    TextBox6.Text = ""

                End If
                StrRs.Close()
                cmd.Dispose()


                Dim Strsql4 As String
                Strsql4 = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where Sterilization=1 and Sterilization_After=1 and Sterilization_Reject=1 and Btc_No='" & TextBox1.Text & "'"
                cmd = New SqlCommand(Strsql4, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox5.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                Else
                    TextBox5.Text = ""

                End If
                StrRs.Close()
                cmd.Dispose()




                'Strsql = "SELECT DISTINCT Befor_UserName from STERILIZATION where batchno ='" & TextBox1.Text & "' order by Befor_UserName"
                'cmd = New SqlCommand(Strsql, con)
                'StrRs = cmd.ExecuteReader
                'ComboBox5.Items.Clear()
                'While StrRs.Read
                '    ComboBox5.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                'End While
                'StrRs.Close()
                'cmd.Dispose()



                Strsql = "SELECT DISTINCT After_UserName from Sterilization_After where batchno ='" & TextBox1.Text & "' order by After_UserName"
                cmd = New SqlCommand(Strsql, con)
                StrRs = cmd.ExecuteReader
                ComboBox1.Items.Clear()
                While StrRs.Read
                    ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()


                Strsql = "SELECT DISTINCT Username from CONTROL_SAMPLE where BatchNo ='" & TextBox1.Text & "' order by Username"
                cmd = New SqlCommand(Strsql, con)
                StrRs = cmd.ExecuteReader
                ComboBox2.Items.Clear()
                While StrRs.Read
                    ComboBox2.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()


                Strsql = "SELECT DISTINCT UserName from STERILIZATION_TEST where batchno ='" & TextBox1.Text & "' order by UserName"
                cmd = New SqlCommand(Strsql, con)
                StrRs = cmd.ExecuteReader
                ComboBox3.Items.Clear()
                While StrRs.Read
                    ComboBox3.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()


                Strsql = "SELECT DISTINCT Username from Sterile_Rejection where Batch_no ='" & TextBox1.Text & "' order by Username"
                cmd = New SqlCommand(Strsql, con)
                StrRs = cmd.ExecuteReader
                ComboBox4.Items.Clear()
                While StrRs.Read
                    ComboBox4.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()







                TextBox1.Text = ""

            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll

    End Sub
End Class