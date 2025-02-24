Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine



Public Class FrmDcViewRpt

    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Sql As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand

    Private Sub RptBPLView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        StrSql = "select distinct DCL_No from DC_PACKING_LIST"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbBPLNo.Items.Clear()
        While StrRs.Read
            CmbBPLNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

        CheckTMP_DCL_LIST()

        CryViewDCLList.Width = Me.Width

        CryViewDCLList.Height = Me.Height - 100
        CryViewDCLList.Top = 51
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Dim cryRpt As New DCLCollection

        CheckTMP_DCL_LIST()

       

        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                  "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                  "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                  " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.dcL_No " & _
                 "from POUCH_LABEL P where" & _
                  " P.DCL_NO='" & CmbBPLNo.Text & "' order by Model_Name "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
        Else
            MsgBox("Select Valid BPL No")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()

   
        StrSql = "select P.Brand_Name,P.Model_Name,P.Reference_Name,P.GS_Code,P.Power,P.Optic,P.Length,P.Lot_Unit,P.A_Constant, " & _
                 "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                 "P.Type_GS_Code,1 as Qty, convert(varchar(6),P.Mfd_Month)+'-'+convert(varchar(8),P.Mfd_Year) as MfdDate, " & _
                 " convert(varchar(6),P.Exp_Month)+'-'+convert(varchar(8),P.Exp_Year) as ExpDate,P.Sterilization_No, P.DCL_No " & _
                 "into TMP_DCL_LIST " & _
                 "from POUCH_LABEL P where" & _
                 " P.DCL_NO='" & CmbBPLNo.Text & "' order by Model_Name "

        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()




        cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")
        CryViewDCLList.ReportSource = cryRpt
        ' CryViewBPLList.d()

        'cryRpt.VerifyDatabase()
        CryViewDCLList.Update()
        CryViewDCLList.Validate()
        CryViewDCLList.Refresh()
        CryViewDCLList.Show()


   







    End Sub

 
    Private Sub CheckTMP_DCL_LIST()
        Try
            SqlCk1 = "Select * from TMP_DCL_LIST"
            Cmd = New SqlCommand(SqlCk1, con)
            RsCk1 = Cmd.ExecuteReader
            If RsCk1.Read Then
                RsCk1.Close()
                Cmd.Dispose()
                SqlCk2 = "Drop Table TMP_DCL_LIST"
                Cmd2 = New SqlCommand(SqlCk2, con)
                Cmd2.ExecuteNonQuery()
                Cmd2.Dispose()
            End If
            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CryViewDCLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CryViewDCLList.Load

    End Sub
End Class
