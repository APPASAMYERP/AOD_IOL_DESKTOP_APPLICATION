
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration
Public Class FrmLotdetailsReport

    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql As String
    Dim Ds As New DataSet
    Dim StAd As New SqlDataAdapter

    Public Function SQL_SelectQuery_Execute_with_ConString(ByVal StrSql As String, ByVal conStr As SqlConnection) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, conStr)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

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


    Private Sub FrmLotdetailsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StrSql = " SELECT DISTINCT   Reflot  from Pouch_Label  ORDER BY Reflot DESC"
        Ds = SQL_SelectQuery_Execute(StrSql)
        Cmbreflot.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            Cmbreflot.Items.Add(eachRow1("Reflot"))
        Next
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim dt, dt1 As New DataTable
        Dim packingLot, rtTime As String
        If Cmbreflot.SelectedItem Is Nothing Then
            Err.SetError(Cmbreflot, "Please Select valid Sterile Batch")
            Cmbreflot.Focus()
            Exit Sub
        Else
            Err.SetError(Cmbreflot, "")
        End If

        Dim cryRpt As New LotDetails
        StrSql = "SELECT     DISTINCT Lot_SrNo, Power, R_Power, RT_Time, Created_By, 'ACCEPTED' As Result FROM         POUCH_LABEL WHERE     RefLot ='" + Cmbreflot.Text + "'  and type ='appa' ORDER BY Lot_SrNo "
        Ds = SQL_SelectQuery_Execute(StrSql)
        dt = Ds.Tables(0)

        StrSql = "SELECT     DISTINCT Lot_Prefix+Lot_No as Lot_Number FROM         POUCH_LABEL WHERE     RefLot ='" + Cmbreflot.Text + "' and type ='appa' "
        Ds = SQL_SelectQuery_Execute(StrSql)
        packingLot = Ds.Tables(0).Rows(0)("Lot_Number")
        'rtTime = Ds.Tables(0).Rows(0)("RT_Timee")

        'MOULDING
        Dim conStringMoulding As String = ConfigurationSettings.AppSettings("conStrMOULDING").ToString()
        Dim conMoulding As SqlConnection
        conMoulding = New SqlConnection(conStringMoulding)

        StrSql = "SELECT     DISTINCT '" + packingLot + "' +  RIGHT('00' + CAST(Label AS varchar), 3) As Lot_SrNo, Power, R_Power,  RT_Time, Created_By, 'REJECTED' As Result FROM   PowerReject WHERE     RefLot ='" + Cmbreflot.Text + "'  "
        Ds = SQL_SelectQuery_Execute_with_ConString(StrSql, conMoulding)
        dt1 = Ds.Tables(0)
        dt.Merge(dt1)

        dt.DefaultView.Sort = "Lot_SrNo ASC"
        dt = dt.DefaultView.ToTable()

        cryRpt.Database.Tables(0).SetDataSource(dt)

        Dim txtReflot As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim txtlenso_id As CrystalDecisions.CrystalReports.Engine.TextObject
        txtReflot = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtReflot")
        txtlenso_id = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtlenso_id")
        txtlenso_id.Text = txtLensoID.Text
        txtReflot.Text = Cmbreflot.Text

        CryViewBoxPackingRecord.ReportSource = cryRpt
        CryViewBoxPackingRecord.Refresh()
        CryViewBoxPackingRecord.Show()

    End Sub
End Class