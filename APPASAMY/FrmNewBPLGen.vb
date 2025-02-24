
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmNewBPLGen
    Dim Ds1 As New DataSet
    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet
    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader
    Dim StrPrice As String

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
    Dim StrSql As String
    Dim StrSql1 As String
    Dim StrRs As SqlDataReader
    Dim StrRs1 As SqlDataReader
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim IntLotAvlQty As Integer

    Private Sub FrmBPLGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from BPL_GEN"
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



        StrUniqueNo = "BPL/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo


        If productline = "PMMA" Then
            StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
        Else
            StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        End If

        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()



        StrSql = "SELECT DISTINCT Country_Name from Order_Country order by Country_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        CmbOrderContry.Items.Clear()
        While StrRs.Read
            CmbOrderContry.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()




        ' Create four typed columns in the DataTable.
        Try
            table.Dispose()
        Catch ex As Exception

        End Try


        table.Columns.Add("Model", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("Brand", GetType(String))
        table.Columns.Add("Print_Name", GetType(String))
        table.Columns.Add("Type", GetType(String))
        table.Columns.Add("GS_Type", GetType(String))
        table.Columns.Add("Avl_Qty", GetType(String))
        table.Columns.Add("BPL_Qty", GetType(String))
        table.Columns.Add("Ty_Packing", GetType(String))
        table.Columns.Add("Ord_Country", GetType(String))
        table.Columns.Add("Mfd_Year", GetType(String))
        table.Columns.Add("Mfd_month", GetType(String))
        table.Columns.Add("reserved_id", GetType(String))

        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

        lblTotBplQty.Text = 0
    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged
        If CmbShModel.Text <> "" Then
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT POWER from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' order by POWER"
            Else
                StrSql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            End If
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            cbxtype.Items.Clear()
            CmbShPower.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()

            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""

            While StrRs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged
        If CmbShPower.Text <> "" Then
            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            Else
                StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            End If
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            cbxtype.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()
            cbxpname.Items.Clear()

            cbxpname.Text = ""
            cbxtype.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""
            While StrRs.Read
                CmbShBrand.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShBrand.SelectedIndexChanged
        If CmbShBrand.Text <> "" Then
            StrSql = "SELECT DISTINCT Print_Name from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' "
            
            cmd = New SqlCommand(StrSql, con)

            StrRs = cmd.ExecuteReader


            cbxtype.Items.Clear()
            cbxpname.Items.Clear()
            CmbShType.Items.Clear()
            
            cbxtype.Text = ""
            cbxpname.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""

            While StrRs.Read
                cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "NULL", StrRs.GetValue(0)))
            End While
        
          
            StrRs.Close()
            'StrSql1 = "SELECT DISTINCT price from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "'"
            'Cmd2 = New SqlCommand(StrSql1, con)
            'StrRs1 = Cmd2.ExecuteReader
            'While StrRs1.Read
            '    StrPrice = StrRs1.GetValue(0)
            'End While
            'StrRs1.Close()
            'cmd.Dispose()

        End If
       




      

    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged


        Dim todate As Date
        'todate = System.DateTime.Now
        'todate = DateAdd(DateInterval.Day, -14, todate)
        todate = Date.Now.AddDays(-14)
        If CmbShType.Text <> "" Then

            ''// For New Export
            txtmonth.Visible = True
            txtyear.Visible = True

            

            If txtyear.Text <> "" And txtmonth.Text <> "" Then

                If rdFreeStock.Checked = True Then
                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
                         "POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and (((Mfd_Month >= '" & txtmonth.Text & "') AND (Mfd_Year = '" & txtyear.Text & "')) or (Mfd_Year >= '" & txtyear.Text + 1 & "')) and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1 " & _
                         "and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
                Else
                    If cmbReserved_id.SelectedItem Is Nothing Then
                        MessageBox.Show("Please Select valid Reserved_Id")
                        cmbReserved_id.Focus()
                        Exit Sub
                    End If
                    If CmbTyPacking.SelectedItem Is Nothing Then
                        MessageBox.Show("Please Select valid Type of Packing")
                        CmbTyPacking.Focus()
                        Exit Sub
                    End If
                    If CmbOrderContry.SelectedItem Is Nothing Then
                        MessageBox.Show("Please Select valid Order Country")
                        CmbOrderContry.Focus()
                        Exit Sub
                    End If

                    StrSql = "SELECT DISTINCT Reserved_Ord_Type, Reserved_Ord_Country FROM         Order_Reserved_Details where Reserved_id='" & cmbReserved_id.Text & "' "
                    cmd = New SqlCommand(StrSql, con)
                    StrRs = cmd.ExecuteReader
                    If StrRs.Read Then
                        If CmbOrderContry.Text <> IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1)) Then
                            MessageBox.Show("Please Select Correct Order Country")
                            CmbOrderContry.Focus()
                            StrRs.Close()
                            cmd.Dispose()
                            Exit Sub
                        End If

                        If CmbTyPacking.Text <> IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)) Then
                            MessageBox.Show("Please Select Correct Type of Packing")
                            CmbTyPacking.Focus()
                            StrRs.Close()
                            cmd.Dispose()
                            Exit Sub
                        End If
                    End If
                    StrRs.Close()
                    cmd.Dispose()


                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and " & _
                         "POWER='" & CmbShPower.Text & "' and type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and (((Mfd_Month >= '" & txtmonth.Text & "') AND (Mfd_Year = '" & txtyear.Text & "')) or (Mfd_Year >= '" & txtyear.Text + 1 & "')) and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1 " & _
                         "and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1') AND (Lens_Reserved_status =1) and Reserved_Id='" & cmbReserved_id.Text & "'  "

                End If

                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    IntLotAvlQty = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
                End If
                StrRs.Close()
                cmd.Dispose()

                TxtShowAvlQty.Text = IntLotAvlQty

                If IntLotAvlQty = 0 Then
                    MsgBox("Available Qty Is Zero")
                    'Exit Sub
                End If

            Else
                MsgBox("Please Choose Mfd Year & Month")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Try

            If IntLotAvlQty = 0 Then
                MsgBox("Available Qty Is Zero")
                Exit Sub
            End If




            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from BPL_GEN"
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




            For i = 0 To GRID2.Rows.Count - 2
                Dim Sql As String


                Str_Detail = 0
                StrSqlSeDt = "Select Max(Detail_ID) from BPL_GEN"
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

                If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then

                    Sql = "Insert Into BPL_GEN ( Header_ID,Detail_ID,  Model_Name,	Power,Brand_Name,Print_Name,Type,Type_GS_Code,Qty,BPL_No,Created_By,	Created_Date,	Modified_By,	Modified_Date) values ( " & _
                                  "'" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(2, i).Value & "','AOD','" & GRID2.Item(4, i).Value & "','" & GRID2.Item(5, i).Value & "','" & GRID2.Item(7, i).Value & "','" & StrUniqueNo & "', " & _
                                  "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
                    cmd = New SqlCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    If rdFreeStock.Checked = True Then
                        Sql = "update POUCH_LABEL set BPL_Taken =1,BPL_NO='" & StrUniqueNo & "' , Packing_Model='" & GRID2.Item(8, i).Value & "', Ord_Country='" & GRID2.Item(9, i).Value & "', price ='" & StrPrice & "' where Lot_SrNo in( " & _
                   "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                   " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='AOD' " & _
                   "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "'  and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                   "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1')  AND (Lens_Reserved_status is NULL)   order by Created_Date,Lot_SrNo)"


                    Else
                        Sql = "update POUCH_LABEL set BPL_Taken =1,BPL_NO='" & StrUniqueNo & "' , Packing_Model='" & GRID2.Item(8, i).Value & "', Ord_Country='" & GRID2.Item(9, i).Value & "', price ='" & StrPrice & "' where Lot_SrNo in( " & _
                   "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                   " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='AOD' " & _
                   "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "'  and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                   "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1')  AND (Lens_Reserved_status =1)  and Reserved_Id='" & GRID2.Item(12, i).Value & "'  order by Created_Date,Lot_SrNo)"


                    End If
                    
                    cmd = New SqlCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else


                    Sql = "Insert Into BPL_GEN ( Header_ID,Detail_ID,	Model_Name,	Power,Brand_Name,Print_Name,Type,Type_GS_Code,Qty,BPL_No,Created_By,	Created_Date,	Modified_By,	Modified_Date ) values ( " & _
                                  "'" & Str_Header & "','" & Str_Detail & "','" & GRID2.Item(0, i).Value & "','" & GRID2.Item(1, i).Value & "','" & GRID2.Item(2, i).Value & "','" & GRID2.Item(3, i).Value & "','" & GRID2.Item(4, i).Value & "','" & GRID2.Item(5, i).Value & "','" & GRID2.Item(7, i).Value & "','" & StrUniqueNo & "', " & _
                                  "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
                    cmd = New SqlCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    If rdFreeStock.Checked = True Then
                        Sql = "update POUCH_LABEL set BPL_Taken =1,BPL_NO='" & StrUniqueNo & "' , Packing_Model='" & GRID2.Item(8, i).Value & "', Ord_Country='" & GRID2.Item(9, i).Value & "', price ='" & StrPrice & "' where Lot_SrNo in( " & _
                   "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                   " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='" & GRID2.Item(5, i).Value & "' " & _
                   "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and  Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                   "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)   order by Created_Date,Lot_SrNo)"
                    Else
                        Sql = "update POUCH_LABEL set BPL_Taken =1,BPL_NO='" & StrUniqueNo & "' , Packing_Model='" & GRID2.Item(8, i).Value & "', Ord_Country='" & GRID2.Item(9, i).Value & "', price ='" & StrPrice & "' where Lot_SrNo in( " & _
                   "select top " & GRID2.Item(7, i).Value & " Lot_SrNo from POUCH_LABEL where Model_Name='" & GRID2.Item(0, i).Value & "' " & _
                   " and POWER='" & GRID2.Item(1, i).Value & "' and Type_GS_Code='" & GRID2.Item(5, i).Value & "' " & _
                   "and Brand_Name='" & GRID2.Item(2, i).Value & "'and Print_Name='" & GRID2.Item(3, i).Value & "' and Type='" & GRID2.Item(4, i).Value & "' and (((Mfd_Month >= '" & GRID2.Item(11, i).Value & "') AND (Mfd_Year = '" & GRID2.Item(10, i).Value & "')) or (Mfd_Year >= '" & GRID2.Item(10, i).Value + 1 & "')) and  Sterilization=1  and Sample_Taken=0 and BPL_Taken=0   " & _
                   "and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  and Reserved_Id='" & GRID2.Item(12, i).Value & "'   order by Created_Date,Lot_SrNo)"

                    End If
                    


                    cmd = New SqlCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If

            Next i

            CheckTMP_BPL_LIST()


          


            StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                     "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                     "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                     " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No,P.BPL_No, P.Ord_Country, P.Btc_No,P.Tray_no as Tray_No, P.Rack_Location as Rack_No " & _
                     "from POUCH_LABEL P where" & _
                     " P.BPL_NO='" & StrUniqueNo & "' order by Model_Name, Lot_srno,srno "

            cmd = New SqlCommand(StrSql, con)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)


            Dim cryRpt As New BPLCollection
            cryRpt.SetDataSource(ds.Tables(0))
            RptViwCollection.CryViewCollectList.ReportSource = cryRpt
            RptViwCollection.Show()

            Clear()



            Str_Header = 0
            StrSqlSeHd = "Select Max(Header_ID) from BPL_GEN"
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



            StrUniqueNo = "BPL/" & Format(Now, "ddMMyy") & "/" & Str_Header
            lblSterNo.Text = StrUniqueNo


            If productline = "PMMA" Then
                StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
            Else
                StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
            End If

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            CmbShModel.Items.Clear()
            While StrRs.Read
                CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()

            ' Create four typed columns in the DataTable.
            'Try
            '    table.Dispose()
            'Catch ex As Exception

            'End Try


            'table.Columns.Add("Model", GetType(String))
            'table.Columns.Add("Power", GetType(String))
            'table.Columns.Add("Brand", GetType(String))
            'table.Columns.Add("Type", GetType(String))
            'table.Columns.Add("Avl_Qty", GetType(String))
            'table.Columns.Add("BPL_Qty", GetType(String))
            'GRID2.DataSource = table


            With GRID2.ColumnHeadersDefaultCellStyle
                .Alignment = DataGridViewContentAlignment.TopRight
                .BackColor = Color.DarkRed
                .ForeColor = Color.Gold
                .Font = New Font(.Font.FontFamily, .Font.Size, _
                 .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
            End With

            lblTotBplQty.Text = 0

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

        Try
            SqlCk1 = "Select * from BPLCollectionList"
            Cmd = New SqlCommand(SqlCk1, con)
            RsCk1 = Cmd.ExecuteReader
            If RsCk1.Read Then
                RsCk1.Close()
                Cmd.Dispose()
                SqlCk2 = "Drop Table BPLCollectionList"
                Cmd2 = New SqlCommand(SqlCk2, con)
                Cmd2.ExecuteNonQuery()
                Cmd2.Dispose()
            End If
            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try



    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If CmbShBrand.Text.Trim = "" Then
            MsgBox("Select Brand Name ", MsgBoxStyle.Information)
            CmbShBrand.Text = ""
            CmbShBrand.Focus()

        End If

        If CmbShModel.Text.Trim = "" Then
            MsgBox("Select Model Name ", MsgBoxStyle.Information)
            CmbShModel.Text = ""
            CmbShModel.Focus()

        End If

        If CmbShPower.Text.Trim = "" Then
            MsgBox("Select Power  ", MsgBoxStyle.Information)
            CmbShPower.Text = ""
            CmbShPower.Focus()

        End If
        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Then
        Else
            If CmbShType.Text.Trim = "" Then
                MsgBox("Select GS Type  ", MsgBoxStyle.Information)
                CmbShType.Text = ""
                CmbShType.Focus()

            End If
        End If
        

        If cbxpname.Text.Trim = "" Then
            MsgBox("Select Print_Name  ", MsgBoxStyle.Information)
            CmbShType.Text = ""
            CmbShType.Focus()

        End If

        If cbxtype.Text.Trim = "" Then
            MsgBox("Select Type  ", MsgBoxStyle.Information)
            CmbShType.Text = ""
            CmbShType.Focus()

        End If

        If txTbplQty.Text.Trim = "" Then
            MsgBox("Enter Qty Value", MsgBoxStyle.Information)
            txTbplQty.Focus()
            Exit Sub
        End If



        If Val(TxtShowAvlQty.Text) < Val(txTbplQty.Text) Then
            MsgBox("Check Qty", MsgBoxStyle.Critical)
            txTbplQty.Focus()
            Exit Sub
        End If
     

        'Same Model & power selection validation
        Dim duplicateFound As Boolean = False

        For Each row As DataGridViewRow In GRID2.Rows
            If Not row.IsNewRow Then
                If row.Cells("Model").Value.ToString() = CmbShModel.Text AndAlso row.Cells("Power").Value.ToString() = CmbShPower.Text AndAlso row.Cells("Brand").Value.ToString() = CmbShBrand.Text AndAlso row.Cells("Print_Name").Value.ToString() = cbxpname.Text AndAlso row.Cells("Type").Value.ToString() = cbxtype.Text AndAlso row.Cells("Mfd_Year").Value.ToString() = txtyear.Text AndAlso row.Cells("Mfd_month").Value.ToString() = txtmonth.Text Then
                    duplicateFound = True
                    Exit For
                End If
            End If
        Next

        If duplicateFound Then
            MsgBox("The same power and model are already added. Please check.", MsgBoxStyle.Critical, "Duplicate Entry")
            Exit Sub
        End If

        Try
            DtRow = table.NewRow
            'table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text)

            table.Rows.Add(CmbShModel.Text, CmbShPower.Text, CmbShBrand.Text, cbxpname.Text, cbxtype.Text, CmbShType.Text, TxtShowAvlQty.Text, txTbplQty.Text, CmbTyPacking.Text, CmbOrderContry.Text, txtyear.Text, txtmonth.Text, cmbReserved_id.Text)

            lblTotBplQty.Text = Val(lblTotBplQty.Text) + Val(txTbplQty.Text)

            TxtShowAvlQty.Text = ""
            txTbplQty.Text = ""

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        
    End Sub

    Private Sub GRID2_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles GRID2.UserDeletedRow
        
    End Sub

   
    Private Sub GRID2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles GRID2.UserDeletingRow
        If (Not e.Row.IsNewRow) Then
            Dim response As DialogResult = _
            MessageBox.Show( _
            "Are you sure you want to delete this row?", _
            "Delete row?", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2)
            If (response = DialogResult.No) Then
                e.Cancel = True


            Else

                e.Cancel = False
            End If

            'Dim a As


            Dim sre As Integer = e.Row.Index

            lblTotBplQty.Text = Val(lblTotBplQty.Text) - GRID2.Item(7, sre).Value
        End If
    End Sub

    Private Sub GRID2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID2.CellContentClick

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        GRID2.ClearSelection()
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txTbplQty.Text = ""
        TxtShowAvlQty.Text = ""
        txtyear.Text = ""
        txtmonth.Text = ""
        lblTotBplQty.Text = ""
        GRID2.DataSource.Rows.Clear()
        cmbReserved_id.Text = ""

    End Sub

    Private Sub Clear()
        GRID2.DataSource.Rows.Clear()
        GRID2.ClearSelection()
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txTbplQty.Text = ""
        TxtShowAvlQty.Text = ""
        lblTotBplQty.Text = ""
        txtyear.Text = ""
        txtmonth.Text = ""
        cmbReserved_id.Text = ""
    End Sub

    Private Sub txTbplQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txTbplQty.TextChanged

    End Sub

    Private Sub cbxtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxtype.SelectedIndexChanged
        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Then

            CmbShType.Enabled = False

            If rdFreeStock.Checked = True Then
                StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                 "and Brand_Name='" & CmbShBrand.Text & "' and Type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 " & _
                 "and Dc_Packing=0  AND Sterilization_After=1  AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
            Else
                StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                 "and Brand_Name='" & CmbShBrand.Text & "' and Type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 " & _
                 "and Dc_Packing=0  AND Sterilization_After=1  AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "
            End If

            


            'StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
            '         "and Brand_Name='" & CmbShBrand.Text & "'  and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 " & _
            '         "and Dc_Packing=0  AND Sterilization_After=1"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(4)), 0, StrRs.GetValue(4)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), 0, StrRs.GetValue(8)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16))
                StrMfdYear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))


                StrExpMonth = IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18))
                StrExpYear = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))

                LblShowMfdDate.Text = StrMfdMonth & "-" & StrMfdYear
                LblShowExpDate.Text = StrExpMonth & "-" & StrExpYear
                StrRs.Close()
                cmd.Dispose()

                If rdFreeStock.Checked = True Then
                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                         "Type_GS_Code='AOD' and Type='" & cbxtype.Text & "' and Brand_Name='" & CmbShBrand.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and " & _
                         "BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0   AND Sterilization_After=1 AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
                Else
                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                         "Type_GS_Code='AOD' and Type='" & cbxtype.Text & "' and Brand_Name='" & CmbShBrand.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and " & _
                         "BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0   AND Sterilization_After=1 AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "
                End If
                


                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    IntLotAvlQty = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
                End If
                StrRs.Close()
                cmd.Dispose()

                TxtShowAvlQty.Text = IntLotAvlQty

                If IntLotAvlQty = 0 Then
                    MsgBox("Available Qty Is Zero")
                    'Exit Sub
                End If

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                StrRs.Close()
                cmd.Dispose()
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()

        Else
            CmbShType.Enabled = True

            If cbxtype.Text <> "" Then
                If productline = "PMMA" Then
                    StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER1 where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                Else
                    StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                End If
                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                CmbShType.Items.Clear()
                CmbShType.Text = ""
                While StrRs.Read
                    CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()
            End If
            End If

    End Sub

    Private Sub cbxpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxpname.SelectedIndexChanged
        If cbxpname.Text <> "" Then

            If rdFreeStock.Checked = True Then
                StrSql = "select distinct type from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                                 "and Brand_Name='" & CmbShBrand.Text & "'  and Print_Name='" & cbxpname.Text & "'  and Sterilization=1  and Sample_Taken=0 and  BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
            Else
                StrSql = "select distinct type from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                                 "and Brand_Name='" & CmbShBrand.Text & "'  and Print_Name='" & cbxpname.Text & "'  and Sterilization=1  and Sample_Taken=0 and  BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "
            End If
            

        

            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            CmbShType.Items.Clear()
            cbxtype.Items.Clear()


            cbxtype.Text = ""
            CmbShType.Text = ""
            TxtShowAvlQty.Text = ""
            While StrRs.Read
                cbxtype.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub CmbOrderContry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbOrderContry.SelectedIndexChanged
        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then

            CmbShType.Enabled = False

            If rdFreeStock.Checked = True Then
                StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                 "and Brand_Name='" & CmbShBrand.Text & "' and Type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 " & _
                 "and Dc_Packing=0  AND Sterilization_After=1  AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
            Else
                StrSql = "select * from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' " & _
                 "and Brand_Name='" & CmbShBrand.Text & "' and Type='" & cbxtype.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 " & _
                 "and Dc_Packing=0  AND Sterilization_After=1  AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "
            End If
            


            
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(4)), 0, StrRs.GetValue(4)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(9)), "", StrRs.GetValue(9))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), 0, StrRs.GetValue(8)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16))
                StrMfdYear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))


                StrExpMonth = IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18))
                StrExpYear = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))

                LblShowMfdDate.Text = StrMfdMonth & "-" & StrMfdYear
                LblShowExpDate.Text = StrExpMonth & "-" & StrExpYear
                StrRs.Close()
                cmd.Dispose()

                If rdFreeStock.Checked = True Then
                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                         "Type_GS_Code='AOD' and Type='" & cbxtype.Text & "' and Brand_Name='" & CmbShBrand.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and " & _
                         "BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0   AND Sterilization_After=1 AND (Areation_Status = '1') AND (Lens_Reserved_status is NULL)  "
                Else
                    StrSql = "select count(*) from POUCH_LABEL where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and " & _
                         "Type_GS_Code='AOD' and Type='" & cbxtype.Text & "' and Brand_Name='" & CmbShBrand.Text & "' and Print_Name='" & cbxpname.Text & "' and Sterilization=1  and Sample_Taken=0 and " & _
                         "BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0   AND Sterilization_After=1 AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "
                End If
                


                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    IntLotAvlQty = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
                End If
                StrRs.Close()
                cmd.Dispose()

                TxtShowAvlQty.Text = IntLotAvlQty

                If IntLotAvlQty = 0 Then
                    MsgBox("Available Qty Is Zero")
                    'Exit Sub
                End If

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                StrRs.Close()
                cmd.Dispose()
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()

        Else
            CmbShType.Enabled = True

            If cbxtype.Text <> "" Then
                If productline = "PMMA" Then
                    StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER1 where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                Else
                    StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                End If

                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                CmbShType.Items.Clear()
                CmbShType.Text = ""
                While StrRs.Read
                    CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()
            End If

        End If


    End Sub

 
    Private Sub rdReservedStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdReservedStock.CheckedChanged

        If rdFreeStock.Checked = True Then
            Label25.Visible = False
            cmbReserved_id.Visible = False
            cmbReserved_id.Text = ""

        ElseIf rdReservedStock.Checked = True Then
            Label25.Visible = True
            cmbReserved_id.Visible = True

            StrSql = "select distinct Reserved_Id from POUCH_LABEL where  " & _
                                 "  Sterilization=1  and Sample_Taken=0 and  BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1' AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  "



            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader

            cmbReserved_id.Items.Clear()

            cmbReserved_id.Text = ""
            TxtShowAvlQty.Text = ""
            While StrRs.Read
                cmbReserved_id.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub
End Class