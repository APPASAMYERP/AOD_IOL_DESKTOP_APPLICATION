Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class NewPouchDetails

    Dim StrBrandName As String
    Dim StrMdlName As String
    Dim StrRefName As String
    Dim StrGSCode As String
    Dim StrLotPower As String
    Dim StrOptic As String
    Dim StrLength As String
    Dim StrAConst As String
    Dim StrGSType As String
    Dim StrLotBarNo As String
    Dim StrMfDMonth As String
    Dim StrMfDYear As String
    Dim StrExpmonth As String
    Dim StrExpYear As String
    Dim StrBfSter As String
    Dim StrBfSterNo As String
    Dim StrSamp As String
    Dim StrTypeSamp As String
    Dim StrBPLtakn As String
    Dim StrBPLNo As String
    Dim StrBoxpkg As String
    Dim StrDCpkglist As String
    Dim StrDCLno As String
    Dim StrDCpkg As String
    Dim StrDCNo As String
    Dim StrAfSter As String
    Dim StrAfSterNo As String
    Dim StrSterRej As String
    Dim StrType As String
    Dim StrBoxrej As String
    Dim StrBoxrejdate As String
    Dim StrBoxrejBy As String
    Dim StrSterdate As String
    Dim StrSterBy As String
    Dim SqlIn As String
    Dim StrMfD As String
    Dim StrExp As String
    Dim StrLotPrefix As String
    Dim StrLotSu As String
    Dim Strsize As String
    Dim Strbplcredate As String
    Dim Strbplcreby As String
    Dim Strdclcredate As String
    Dim Strdclcreby As String
    Dim Strdccredate As String
    Dim Strdccreby As String

    Private Sub NewPouchDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim StrSeSql As String
        Dim StrSeRs As SqlDataReader
        Dim Cmd As New SqlCommand

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown


        Dim StrSql As String
        Dim StrSeRs As SqlDataReader
        Dim Cmd As New SqlCommand

        If txtlotbarno.Text <> "" Then


            If e.KeyCode = Keys.Enter Then

                StrSql = "select * from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                StrSeRs = Cmd.ExecuteReader
                If StrSeRs.Read Then
                    StrBrandName = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                    StrMdlName = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                    StrRefName = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                    StrGSCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                    StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(4)), 0, StrSeRs.GetValue(4))
                    StrOptic = Format(IIf(IsDBNull(StrSeRs.GetValue(5)), 0, StrSeRs.GetValue(5)), "0.00")
                    StrLength = Format(IIf(IsDBNull(StrSeRs.GetValue(6)), 0, StrSeRs.GetValue(6)), "0.00")
                    StrAConst = IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8))
                    StrGSType = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))
                    StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(15)), "", StrSeRs.GetValue(15))
                    StrMfDMonth = IIf(IsDBNull(StrSeRs.GetValue(16)), "", StrSeRs.GetValue(16))
                    StrMfDYear = IIf(IsDBNull(StrSeRs.GetValue(17)), "", StrSeRs.GetValue(17))
                    StrExpmonth = IIf(IsDBNull(StrSeRs.GetValue(18)), "", StrSeRs.GetValue(18))
                    StrExpYear = IIf(IsDBNull(StrSeRs.GetValue(19)), "", StrSeRs.GetValue(19))
                    StrBfSterNo = IIf(IsDBNull(StrSeRs.GetValue(21)), "", StrSeRs.GetValue(21))
                    StrTypeSamp = IIf(IsDBNull(StrSeRs.GetValue(23)), "", StrSeRs.GetValue(23))
                    StrBPLNo = IIf(IsDBNull(StrSeRs.GetValue(25)), "", StrSeRs.GetValue(25))
                    StrDCLno = IIf(IsDBNull(StrSeRs.GetValue(28)), "", StrSeRs.GetValue(28))
                    StrDCNo = IIf(IsDBNull(StrSeRs.GetValue(30)), "", StrSeRs.GetValue(30))
                    StrType = IIf(IsDBNull(StrSeRs.GetValue(40)), "", StrSeRs.GetValue(40))
                    StrBoxrejdate = IIf(IsDBNull(StrSeRs.GetValue(42)), "", StrSeRs.GetValue(42))
                    StrBoxrejBy = IIf(IsDBNull(StrSeRs.GetValue(43)), "", StrSeRs.GetValue(43))
                    StrSterdate = IIf(IsDBNull(StrSeRs.GetValue(44)), "", StrSeRs.GetValue(44))
                    StrSterBy = IIf(IsDBNull(StrSeRs.GetValue(45)), "", StrSeRs.GetValue(45))


                    If IIf(IsDBNull(StrSeRs.GetValue(20)), "", StrSeRs.GetValue(20)) = "0" Then
                        StrBfSter = "NO"
                    Else
                        StrBfSter = "YES"
                    End If

                    If IIf(IsDBNull(StrSeRs.GetValue(22)), "", StrSeRs.GetValue(22)) = "0" Then
                        StrSamp = " No "
                    Else
                        StrSamp = "YES"
                    End If

                    If IIf(IsDBNull(StrSeRs.GetValue(24)), "", StrSeRs.GetValue(24)) = "0" Then
                        StrBPLtakn = " No "
                    Else
                        StrBPLtakn = "YES"
                    End If

                    If IIf(IsDBNull(StrSeRs.GetValue(26)), "", StrSeRs.GetValue(26)) = "0" Then
                        StrBoxpkg = " No "
                    Else
                        StrBoxpkg = "YES"

                    End If

                    If IIf(IsDBNull(StrSeRs.GetValue(27)), "", StrSeRs.GetValue(27)) = "0" Then
                        StrDCpkglist = " No "
                    Else
                        StrDCpkglist = "YES"

                    End If


                    If IIf(IsDBNull(StrSeRs.GetValue(29)), "", StrSeRs.GetValue(29)) = "0" Then
                        StrDCpkg = "NO"
                    Else
                        StrDCpkg = "YES"
                    End If


                    If IIf(IsDBNull(StrSeRs.GetValue(36)), "", StrSeRs.GetValue(36)) = "0" Then
                        StrAfSter = " No "
                    Else
                        StrAfSter = "YES"
                    End If


                    'StrAfSterNo = IIf(IsDBNull(StrSeRs.GetValue(37)), "", StrSeRs.GetValue(37))


                    If IIf(IsDBNull(StrSeRs.GetValue(38)), "", StrSeRs.GetValue(38)) = "0" Then
                        StrSterRej = "NO"
                    Else
                        StrSterRej = "YES"
                    End If


                    If IIf(IsDBNull(StrSeRs.GetValue(41)), "", StrSeRs.GetValue(41)) = "0" Then
                        StrBoxrej = "NO"
                    Else
                        StrBoxrej = "YES"
                    End If
                    
                Else
                    MsgBox("Scan correct Lot No", MsgBoxStyle.Information)
                    Exit Sub
                End If



                StrSeRs.Close()
                StrSql = "select b.Created_Date,b.Created_By from BPL_GEN b,POUCH_LABEL p where " & _
                       " p.Lot_SrNo='" & txtlotbarno.Text & "' and p.BPL_NO='" & StrBPLNo & "' " & _
                       "and p.BPL_NO=b.BPL_NO and b.Model_name='" & StrMdlName & "' and b.Power='" & StrLotPower & "'"
                Cmd = New SqlCommand(StrSql, con)
                StrSeRs = Cmd.ExecuteReader
                If StrSeRs.Read Then
                    Strbplcredate = StrSeRs.GetValue(0)
                    Strbplcreby = StrSeRs.GetValue(1)
                End If
                StrSeRs.Close()
                StrSql = " select  b.Created_Date,b.Created_By from DC_PACKING_LIST b,POUCH_LABEL p " & _
                        "where  p.Lot_SrNo='" & txtlotbarno.Text & "' and  p.DCL_NO='" & StrDCLno & "' and " & _
                        "p.DCL_NO=b.DCL_NO and b.Model_name='" & StrMdlName & "' and b.Power='" & StrLotPower & "'"

                Cmd = New SqlCommand(StrSql, con)
                StrSeRs = Cmd.ExecuteReader
                If StrSeRs.Read Then
                    Strdclcredate = StrSeRs.GetValue(0)
                    Strdclcreby = StrSeRs.GetValue(1)
                End If
                StrSeRs.Close()
                StrSql = "select  d.Created_Date,d.Created_By  from DC_SOFT d,POUCH_LABEL p" & _
                         " where p.Lot_SrNo='" & StrLotBarNo & "' and  p.DC_NO='" & StrDCNo & "'" & _
                         "and p.DC_NO=d.DC_NO and p.DCL_NO='" & StrDCLno & "' and " & _
                         " p.DCL_NO = d.DCL_NO"


                Cmd = New SqlCommand(StrSql, con)
                StrSeRs = Cmd.ExecuteReader
                If StrSeRs.Read Then
                    Strdccredate = StrSeRs.GetValue(0)
                    Strdccreby = StrSeRs.GetValue(1)
                End If
                StrSeRs.Close()


                StrMfD = StrMfDMonth & "-" & StrMfDYear
                StrExp = StrExpmonth & "-" & StrExpYear
                Strsize = StrOptic & "x" & StrLength & "mm"


                lbbrnamev.Text = StrBrandName
                lbmdnamev.Text = StrMdlName
                lbrefnamev.Text = StrRefName
                lbgscodev.Text = StrGSCode
                lblotsrnov.Text = StrLotBarNo
                lbsmpv.Text = StrSamp
                lsgstypev.Text = StrGSType
                lbpwrv.Text = StrLotPower
                lbsizev.Text = Strsize
                lbconstv.Text = StrAConst
                lbtypev.Text = StrType
                lbmfddatev.Text = StrMfD
                lbexpdatev.Text = StrExp
                lbtypesmpv.Text = StrTypeSamp
                lbbfsterv.Text = StrBfSter
                lbbfsternov.Text = StrBfSterNo
                lbafsterv.Text = StrAfSter

                lblsterrejv.Text = StrSterRej
                lbsterdatev.Text = StrSterdate
                lbsterbyv.Text = StrSterBy
                lbbpltknv.Text = StrBPLtakn
                lbbplnov.Text = StrBPLNo

                lbbplcdatev.Text = Strbplcredate
                lbbplcrebyv.Text = Strbplcreby

                lbbxpkgv.Text = StrBoxpkg
                lblbxrejv.Text = StrBoxrej
                lblbxrejdatev.Text = StrBoxrejdate
                lblbxrejbyv.Text = StrBoxrejBy
                lbdcpkglstv.Text = StrDCpkglist
                lbldclnov.Text = StrDCLno
                lbdcpkgv.Text = StrDCpkg
                lbdcnov.Text = StrDCNo

                lbdclcdatev.Text = Strdclcredate
                lbdclcrebyv.Text = Strdclcreby
                lbdccredatev.Text = Strdccredate
                lbdccrebyv.Text = Strdccreby

            End If

        End If


    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lbbfster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbbfster.Click

    End Sub

    Private Sub lbsterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbsterno.Click

    End Sub

    Private Sub lblsterrej_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsterrej.Click

    End Sub
End Class
