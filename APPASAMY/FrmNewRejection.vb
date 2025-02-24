

Imports System.Data
Imports System.IO
Imports System.Data.SqlClient








Public Class FrmNewRejection

    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader
    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader
    Dim IntBoxPAck As Integer
    Dim StrAConst As String
    Dim StrRefName As String
    Dim StrSeSql As String
    Dim StrSeRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim SqlIn As String
    Dim Ds As New DataSet
    Dim StrSql As String

    Dim StrUniqueNo As String


    Dim StrLotPrefix As String
    Dim StrLotSu As String
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    

    Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
        Dim Scan_SrNo As String = ""
        If e.KeyCode = Keys.Enter Then



            If txtlotbarno.Text <> "" Then

                Try

                    If rdorework.Checked = True Then

                        If rdLotSerial.Checked = True Then
                            StrSeSql = "select * from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
                           "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0  and Dc_Packing=0 AND Sterilization_After=1 AND Sterile_to_Areation_Move_status is NULL AND Sterilization_Reject=0 "
                        ElseIf rdUDICode.Checked = True Then
                            StrSeSql = "select * from POUCH_LABEL where Udi_code='" & txtlotbarno.Text & "' " & _
                           "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=0  and Dc_Packing=0 AND Sterilization_After=1 AND Sterile_to_Areation_Move_status is NULL AND Sterilization_Reject=0 "
                        Else
                            MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                            Exit Sub
                        End If

                        Ds = SQL_SelectQuery_Execute(StrSeSql)

                        If Ds.Tables(0).Rows.Count = 1 Then
                            lblSterileNo.Text = "Serial No : " & Ds.Tables(0).Rows(0)("Lot_SrNo") & "   Batch No :  " & Ds.Tables(0).Rows(0)("btc_no")
                            Scan_SrNo = Ds.Tables(0).Rows(0)("Lot_SrNo")

                            'Insert -
                            Dim utcTime As DateTime = DateTime.UtcNow
                            Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
                            Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
                            Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
                            Dim From_Loc As String = ""

                            StrSql = "Select Movement_No from Rejection_MTS_Details_Sterile Where Created_date between '" & startDate & "' and '" & endDate & "'  "
                            Ds = SQL_SelectQuery_Execute(StrSql)
                            If Ds.Tables(0).Rows.Count = 1 Then
                                StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
                                txtMTSNo.Text = StrUniqueNo
                            ElseIf Ds.Tables(0).Rows.Count < 1 Then
                                Str_Header = 0
                                Str_Detail = 0
                                StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Sterile"
                                Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

                                If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
                                    Str_Header = 0
                                Else
                                    Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
                                End If

                                If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
                                    Str_Detail = 0
                                Else
                                    Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
                                End If


                                If Str_Header = 0 Then
                                    Str_Header = 1
                                Else
                                    Str_Header = Str_Header + 1
                                End If

                                If Str_Detail = 0 Then
                                    Str_Detail = 1
                                Else
                                    Str_Detail = Str_Detail + 1
                                End If


                                If productline = "PMMA" Then
                                    StrUniqueNo = "PMMA-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                                    From_Loc = "PMMA STERILE"
                                ElseIf productline = "PHILIC" Then
                                    StrUniqueNo = "PHILIC-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                                    From_Loc = "PHILIC STERILE"
                                ElseIf productline = "PHOBIC" Then
                                    StrUniqueNo = "PHOBIC-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                                    From_Loc = "PHOBIC STERILE"
                                ElseIf productline = "PHOBIC NONPRELOADED" Then
                                    StrUniqueNo = "PHOBIC(NP)-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                                    From_Loc = "PHOBIC STERILE"
                                End If

                                txtMTSNo.Text = StrUniqueNo


                                StrSql = "Insert Into Rejection_MTS_Details_Sterile (  Header_ID, Detail_ID, Movement_No, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & _
                                "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + StrUniqueNo + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + From_Loc + "','Store')"
                                UpdateorInsertQuery_Execute(StrSql)


                            Else
                                MessageBox.Show("More than one MTS No contains.Please check")
                                Exit Sub

                            End If
                            'End insert -

                            If rdLotSerial.Checked = True Then
                                SqlIn = "update POUCH_LABEL set Sterilization =1 ,Sterilization_Reject=1 where Lot_SrNo='" & txtlotbarno.Text & "' "
                            ElseIf rdUDICode.Checked = True Then
                                SqlIn = "update POUCH_LABEL set Sterilization =1 ,Sterilization_Reject=1 where Udi_code='" & txtlotbarno.Text & "' "
                            Else
                                MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                                Exit Sub
                            End If
                            UpdateorInsertQuery_Execute(SqlIn)


                            ' Insert record to Sterile_Reject_Details
                            SqlIn = "Insert Into Sterile_Reject_Details (  Lot_SrNo, Created_By, Created_Date, Modified_By, Modified_Date,Movement_No ) values ( " & _
                                              " '" & Scan_SrNo & "', " & _
                                              " '" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & txtMTSNo.Text & "')"
                            UpdateorInsertQuery_Execute(SqlIn)

                            txtlotbarno.Text = ""

                        ElseIf Ds.Tables(0).Rows.Count < 1 Then
                            MsgBox(" Scan Correct Lot No ")
                            txtlotbarno.Text = ""
                            txtlotbarno.Focus()
                            Exit Sub

                        Else
                            MessageBox.Show("More than one MTS No contains.Please check")
                            txtlotbarno.Text = ""
                            txtlotbarno.Focus()
                            Exit Sub
                        End If


                    Else
                        MsgBox("Select Type Of Sample", MsgBoxStyle.Information)
                        Exit Sub

                    End If

                Catch ex As Exception

                    MsgBox("An unexpected error occurred.")
                    Exit Sub

                End Try
                

            End If

        End If
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
    Public Sub MTS_No_Load()

        Dim utcTime As DateTime = DateTime.UtcNow
        Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
        Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
        Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
        Dim From_Loc As String = ""

        StrSql = "Select Movement_No from Rejection_MTS_Details_Sterile Where Created_date between '" & startDate & "' and '" & endDate & "'  "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count = 1 Then
            StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
            txtMTSNo.Text = StrUniqueNo
        ElseIf Ds.Tables(0).Rows.Count < 1 Then
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Sterile"
            Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
                Str_Header = 0
            Else
                Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
            End If

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
                Str_Detail = 0
            Else
                Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
            End If


            If Str_Header = 0 Then
                Str_Header = 1
            Else
                Str_Header = Str_Header + 1
            End If

            If Str_Detail = 0 Then
                Str_Detail = 1
            Else
                Str_Detail = Str_Detail + 1
            End If


            If productline = "PMMA" Then
                StrUniqueNo = "PMMA-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PMMA STERILE"
            ElseIf productline = "PHILIC" Then
                StrUniqueNo = "PHILIC-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PHILIC STERILE"
            ElseIf productline = "PHOBIC" Then
                StrUniqueNo = "PHOBIC-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PHOBIC STERILE"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrUniqueNo = "PHOBIC(NP)-ST-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PHOBIC STERILE"
            End If

            txtMTSNo.Text = StrUniqueNo


            'StrSql = "Insert Into Rejection_MTS_Details_Sterile (  Header_ID, Detail_ID, Movement_No, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & _
            '"('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + StrUniqueNo + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + From_Loc + "','Store')"
            'UpdateorInsertQuery_Execute(StrSql)


        Else
            MessageBox.Show("More than one MTS No contains.Please check")
            Exit Sub

        End If



    End Sub

    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged

    End Sub

    Private Sub FrmNewRejection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MTS_No_Load()
    End Sub


End Class