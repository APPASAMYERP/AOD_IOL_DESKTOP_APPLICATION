
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmDcPrintSoft



    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim Sql As String

    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Dim StAd As New SqlDataAdapter
    Dim StSet As New DataSet

    Private Sub RptBPLView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        StrSql = "select distinct Dc_No from DC_SOFT"

        ' StrSql = "SELECT DISTINCT top(20)dc_NO,CONVERT(INT, SUBSTRING(dc_NO,5,10) )AS dc from Pouch_Label ORDER BY dc DESC"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbBPLNo.Items.Clear()
        While StrRs.Read
            CmbBPLNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

        SqlCk2 = "Delete from despatchtemp"
        Cmd2 = New SqlCommand(SqlCk2, con)
        Cmd2.ExecuteNonQuery()
        Cmd2.Dispose()

        'CheckTMP_DC_LIST()

        CryViewDC.Width = Me.Width

        CryViewDC.Height = Me.Height - 100
        CryViewDC.Top = 51
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        'CheckTMP_DC_LIST()
        Dim cryRpt As New DCPrintRpt
        Dim str As String

        StrSql = "select  count(*) from POUCH_LABEL L where  L.DC_NO='" & CmbBPLNo.Text & "' "
        'StrSql = "select  count(*) from  " & _
        '         "DC_PACKING_LIST P, DC_SOFT D,POUCH_LABEL L where p.DCL_No=d.DCL_No " & _
        '         "AND D.DC_No=L.DC_ID and L.DC_NO='" & CmbBPLNo.Text & "' "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
        Else
            MsgBox("Select Valid DC No")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()

        StrSql = "select  distinct L.Brand_Name as Brand,L.Model_Name as Model," & _
                 " convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm ' as size,L.Power, " & _
                 " (convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)) as LotNo ,sum(L.Qty_1) as IssueQty,sum(L.Qty_1) as StockQty, " & _
                 " D.Address, D.Company_Name as Toperson,D.DC_No as DCNo ,D.Mode,D.Remarks as Rmks,D.IndentNo	,D.No_Packing as NoPacking,  D.YourOrder " & _
                 " from  POUCH_LABEL L, DC_SOFT D " & _
                 " where  L.DC_No='" & CmbBPLNo.Text & "' and D.DC_No='" & CmbBPLNo.Text & "'  " & _
                 " Group by L.Brand_Name,L.Model_Name ,convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm ',L.Power,(convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)), " & _
                 " D.Address,D.Company_Name ,D.DC_No  ,D.Mode,D.Remarks, D.IndentNo, D.No_Packing,D.YourOrder, D.Created_Date "


        '"sum(L.Qty_1) as IssueQty,sum(L.Qty_1) as StockQty " & _

        'StrSql = "select  distinct L.Brand_Name as Brand,L.Model_Name as Model,convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm ' as size," & _
        '         "L.Power,(convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)) as LotNo ,  " & _
        '         "sum(L.Qty_1) as IssueQty,sum(L.Qty_1) as StockQty, " & _
        '         "D.Address,D.Company_Name as Toperson,D.DC_No as DCNo ,D.Mode,D.Remarks as Rmks,D.IndentNo	,D.No_Packing as NoPacking,  D.YourOrder,D.Created_Date as Despdate " & _
        '         " from  POUCH_LABEL L,DC_PACKING_LIST P, DC_SOFT D where L.Power=P.Power and D.DC_No='" & CmbBPLNo.Text & "' and P.DC_No='" & CmbBPLNo.Text & "' and L.DC_No='" & CmbBPLNo.Text & "'" & _
        '         "  and L.DCL_NO=P.DCL_NO " & _
        '         "Group by L.Brand_Name,L.Model_Name ,convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm '," & _
        '         "L.Power,(convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)),D.Address,D.Company_Name ,D.DC_No  ,D.Mode,D.Remarks, " & _
        '         "D.IndentNo, D.No_Packing, D.YourOrder, D.Created_Date"
        'StrSql = " select sum(Qty_1) from POUCH_LABEL where DC_No='DC/s/2' group by  power,(convert(varchar(10),Lot_Prefix)+convert(varchar(20),Lot_No))order by Power"


        'StrSql = "select  distinct L.Brand_Name as Brand,L.Model_Name as Model,convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm ' as size," & _
        '         " L.Power,(convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)) as LotNo , " & _
        '         "   D.Address,D.Company_Name as Toperson,D.DC_No as DCNo ,D.Mode,D.Remarks as Rmks, " & _
        '          " D.IndentNo	,D.No_Packing as NoPacking,  D.YourOrder,D.Created_Date as Despdate" & _
        '          " from DC_PACKING_LIST P, DC_SOFT D,POUCH_LABEL L where " & _
        '        " D.DC_No='" & CmbBPLNo.Text & "' and P.DC_No='" & CmbBPLNo.Text & "' and L.DC_No='" & CmbBPLNo.Text & "'" & _
        '        " and L.DCL_NO=P.DCL_NO and L.Power=P.Power"
        'StrSql = "select  distinct L.Brand_Name as Brand,L.Model_Name as Model,convert(varchar(6),L.Optic)+' X '+convert(varchar(8),L.Length)+' mm ' as size,L.Power, " & _
        '           "(convert(varchar(10),L.Lot_Prefix)+convert(varchar(20),L.Lot_No)) as LotNo , " & _
        '           "D.Address,D.Company_Name as Toperson,D.DC_No as DCNo ,D.Mode,D.Remarks as Rmks, " & _
        '           "D.IndentNo	,D.No_Packing as NoPacking, " & _
        '           " D.YourOrder,D.Created_Date as Despdate,P.qTY as IssueQty, p.qty as StockQty " & _
        '           "   from  " & _
        '           "DC_PACKING_LIST P, DC_SOFT D,POUCH_LABEL L where p.DCL_No=d.DCL_No " & _
        '           "AND D.DC_No=L.DC_No "

        StAd = New SqlDataAdapter(StrSql, con)
        StSet = New DataSet
        StAd.Fill(StSet)

        'Dim cryRpt As New ReportDocument

        'cryRpt.Load(Application.StartupPath & "\DCPrintRpt.rpt")
        cryRpt.SetDataSource(StSet.Tables(0))
        CryViewDC.ReportSource = cryRpt
        ''Cmd = New SqlCommand(StrSql, con)
        ''Cmd.ExecuteNonQuery()
        ''Cmd.Dispose()




        'cryRpt.SetDatabaseLogon("sa", "admin123")

        'cryRpt.SetDatabaseLogon("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=APS;Data Source=PHASEVIEW")
        'cryRpt.SetDataSource()
        cryRpt.VerifyDatabase()



        CryViewDC.Update()

        CryViewDC.ReportSource = cryRpt
        CryViewDC.Refresh()











        'SqlCk2 = "Drop Table TMP_BPL_LIST"
        'Cmd2 = New SqlCommand(SqlCk2, con)
        'Cmd2.ExecuteNonQuery()
        'Cmd2.Dispsose()

    End Sub

    Private Sub CheckTMP_DC_LIST()


        Try
            SqlCk1 = "Select * from despatchtemp"
            Cmd = New SqlCommand(SqlCk1, con)
            RsCk1 = Cmd.ExecuteReader
            If RsCk1.Read Then
                RsCk1.Close()
                Cmd.Dispose()
                SqlCk2 = "Drop Table despatchtemp"
                Cmd2 = New SqlCommand(SqlCk2, con)
                Cmd2.ExecuteNonQuery()
                Cmd2.Dispose()
            End If
            RsCk1.Close()
            Cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class
