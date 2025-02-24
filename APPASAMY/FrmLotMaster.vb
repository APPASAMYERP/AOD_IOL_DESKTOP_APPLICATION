Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql


Public Class FrmLotMaster

    Dim getDetails As String
    Dim cmd As SqlCommand
    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader


    'Public con As New Global.System.Data.SqlClient.SqlConnection(constr)
    'Dim constr As String = "Data Source=shanmugam\sqlexpress;Initial Catalog=APS;User ID=sa;Password=admin@123"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim StrSqlSeHd As String
        Dim StrRsSeHd As SqlDataReader

        Dim StrSqlSeDt As String
        Dim StrRsSeDt As SqlDataReader


        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If txtLotno.Text = "" Then
            err.SetError(txtLotno, "Enter Lot No")
            Exit Sub
        Else
            err.SetError(txtLotno, "")
        End If

        If txtpower.Text = "" Then
            err.SetError(txtpower, "Enter Power Value ")
            Exit Sub
        Else
            err.SetError(txtpower, "")
        End If

        'If txtmodelname.Text = "" Then
        '    err.SetError(txtmodelname, "Enter Model Name")
        '    Exit Sub
        'Else
        '    err.SetError(txtmodelname, "")
        'End If

        If cmbunit.Text = "" Then
            err.SetError(cmbunit, "Select Unit Name")
            Exit Sub
        Else
            err.SetError(cmbunit, "")
        End If

        If txtlotheight.Text = "" Then
            err.SetError(txtlotheight, "Enter Lot Height Value")
            Exit Sub
        Else
            err.SetError(txtlotheight, "")
        End If

        If txtlotwidth.Text = "" Then
            err.SetError(txtlotwidth, "Enter Lot Width Value")
            Exit Sub
        Else
            err.SetError(txtlotwidth, "")
        End If

        If CmbMDMonth.Text = "" Then
            err.SetError(CmbMDMonth, "Select Manufacturing Month ")
            Exit Sub
        Else
            err.SetError(CmbMDMonth, "")
        End If

        If CmbMDYear.Text = "" Then
            err.SetError(CmbMDYear, "Select Manufacturing Year ")
            Exit Sub
        Else
            err.SetError(CmbMDYear, "")
        End If

        If CmbExMonth.Text = "" Then
            err.SetError(CmbExMonth, "Select Expiry Month ")
            Exit Sub
        Else
            err.SetError(CmbExMonth, "")
        End If

        If CmbExYear.Text = "" Then
            err.SetError(CmbExYear, "Select Expiry Year ")
            Exit Sub
        Else
            err.SetError(CmbExYear, "")
        End If



        If BtnSave.Text = "Save" Then

            StrSqlSeHd = "Select Max(Header_ID) from Lot_Master"
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

            StrSqlSeDt = "Select Max(Detail_ID) from Lot_Master"
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




            getDetails = "Insert into LOT_MASTER( Header_ID,Detail_ID,Model_Name,Lot_No,Lot_Power,Lot_Width,Lot_height,Lot_Unit, " & _
                         "MF_Date_Month,MF_Date_Year,Exp_Date_Month,Exp_Date_Year,Lot_Slno,Created_By,Created_Date,Modified_By,Modified_Date ) values (" & _
                         "'" & Str_Header & "','" & Str_Detail & "','" & txtmodelname.Text & "','" & txtLotno.Text & "','" & txtpower.Text & "', " & _
                         "'" & txtlotwidth.Text & "','" & txtlotheight.Text & "','" & cmbunit.Text & "','" & CmbMDMonth.Text & "','" & CmbMDYear.Text & "', " & _
                         "'" & CmbExMonth.Text & "','" & CmbExYear.Text & "',0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"

            cmd = New SqlCommand(getDetails, con)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully")
            cmd.Dispose()
        Else
            getDetails = "Update LOT_MASTER set Model_Name='" & txtmodelname.Text & "',Lot_Power='" & txtpower.Text & "',Lot_Width='" & txtlotwidth.Text & "'," & _
                         " Lot_height='" & txtlotheight.Text & "',Lot_Unit='" & cmbunit.Text & "',MF_Date_Month='" & CmbMDMonth.Text & "',MF_Date_Year='" & CmbMDYear.Text & "'," & _
                         " Exp_Date_Month='" & CmbExMonth.Text & "',Exp_Date_Year='" & CmbExYear.Text & "', " & _
                         " Modified_By='" & StrLoginUser & "',Modified_Date='" & Now.ToString & "' where Lot_No='" & txtLotno.Text & "'"
            cmd = New SqlCommand(getDetails, con)
            cmd.ExecuteNonQuery()
            MsgBox("Update Successfully")
            cmd.Dispose()
        End If

        Clear()
    End Sub

    Private Sub FrmLotMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        txtLotno.Enabled = True
        BtnSave.Text = "Save"

        PictureBox1.Visible = True
      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub cmbunit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbunit.KeyDown
        e.SuppressKeyPress = True

    End Sub

    Private Sub txtLotno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLotno.LostFocus
        If txtLotno.Text <> "" Then
            StrSqlSel1 = "Select * FROM LOT_MASTER where Lot_No='" & txtLotno.Text & "'"
            cmd = New SqlCommand(StrSqlSel1, con)
            StrRsSel1 = cmd.ExecuteReader
            If StrRsSel1.Read Then
                txtpower.Text = IIf(IsDBNull(StrRsSel1.GetValue(5)), " ", StrRsSel1.GetValue(5))
                txtmodelname.Text = IIf(IsDBNull(StrRsSel1.GetValue(3)), " ", StrRsSel1.GetValue(3))
                cmbunit.Text = IIf(IsDBNull(StrRsSel1.GetValue(8)), " ", StrRsSel1.GetValue(8))
                txtlotheight.Text = IIf(IsDBNull(StrRsSel1.GetValue(7)), " ", StrRsSel1.GetValue(7))
                txtlotwidth.Text = IIf(IsDBNull(StrRsSel1.GetValue(6)), " ", StrRsSel1.GetValue(6))
                CmbMDMonth.Text = IIf(IsDBNull(StrRsSel1.GetValue(9)), " ", StrRsSel1.GetValue(9))
                CmbMDYear.Text = IIf(IsDBNull(StrRsSel1.GetValue(10)), " ", StrRsSel1.GetValue(10))
                CmbExMonth.Text = IIf(IsDBNull(StrRsSel1.GetValue(11)), " ", StrRsSel1.GetValue(11))
                CmbExYear.Text = IIf(IsDBNull(StrRsSel1.GetValue(12)), " ", StrRsSel1.GetValue(12))

                txtLotno.Enabled = False
                BtnSave.Text = "Update"
            Else
                txtLotno.Enabled = True
                BtnSave.Text = "Save"
            End If

            StrRsSel1.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub txtLotno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLotno.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtpower.Text = ""
        txtmodelname.Text = ""
        cmbunit.Text = ""
        txtlotheight.Text = ""
        txtlotwidth.Text = ""
        CmbMDMonth.Text = ""
        CmbMDYear.Text = ""
        CmbExMonth.Text = ""
        CmbExYear.Text = ""

        txtLotno.Enabled = True
        BtnSave.Text = "Save"
    End Sub
    Private Sub Clear()
        txtpower.Text = ""
        txtmodelname.Text = ""
        cmbunit.Text = ""
        txtlotheight.Text = ""
        txtlotwidth.Text = ""
        CmbMDMonth.Text = ""
        CmbMDYear.Text = ""
        CmbExMonth.Text = ""
        CmbExYear.Text = ""

        txtLotno.Enabled = True
        BtnSave.Text = "Save"
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMDYear.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
