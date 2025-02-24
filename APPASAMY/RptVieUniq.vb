Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptVieUniq
    Dim Sql As String
    Dim cmd As New SqlCommand
    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckTemp1()



        Sql = "Select Lm.Lot_No,Um.Lot_Barcode,Lm.Lot_Power,	Lm.Lot_Width,	Lm.Lot_height,	Lm.Lot_Unit,	" & _
              "(Lm.MF_Date_Month + ' - ' + Lm.MF_Date_Year) as Mfd_Date,	(Lm.Exp_Date_Month +' - '+ Lm.Exp_Date_Year) as Exp_Date , " & _
              "Um.Unique_No " & _
              "into Tmp1 from LOT_MASTER Lm,UNIQUE_MASTER Um where Lm.Lot_No=Um.Lot_No and  Lm.Lot_Power='" & CmbPower.Text & "'"
        cmd = New SqlCommand(Sql, con)
        cmd.ExecuteNonQuery()


        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\JEI\PROJECT\A\AppaSamy\Proj\APPASAMY\APPASAMY\RptUniView.rpt")

        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As ParameterFieldDefinition
        'Dim crParameterValues As New ParameterValues
        'Dim crParameterDiscreteValue As New ParameterDiscreteValue

        '     crParameterDiscreteValue.Value = TextBox1.Text
        '     crParameterFieldDefinitions =  -
        '     cryRpt.DataDefinition.ParameterFields()
        '     crParameterFieldDefinition = _
        'crParameterFieldDefinitions.Item("Customername")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        cryRpt.SetDatabaseLogon("sa", "admin123")


        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()


        SqlCk2 = "Drop Table Tmp1"
        Cmd2 = New SqlCommand(SqlCk2, con)
        Cmd2.ExecuteNonQuery()
        Cmd2.Dispose()


    End Sub
    Private Sub CheckTemp1()


        Try
            SqlCk1 = "Select * from Tmp1"
            cmd = New SqlCommand(SqlCk1, con)
            RsCk1 = cmd.ExecuteReader
            If RsCk1.Read Then
                RsCk1.Close()
                SqlCk2 = "Drop Table Tmp1"
                Cmd2 = New SqlCommand(SqlCk2, con)
                Cmd2.ExecuteNonQuery()
                Cmd2.Dispose()
            End If
            RsCk1.Close()
            cmd.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub RptVieUniq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbPower.Items.Clear()
        Dim getdetail As String
        Dim read As SqlDataReader

        getdetail = "SELECT DISTINCT Lot_Power FROM LOT_MASTER "
        cmd = New SqlCommand(getdetail, con)
        read = cmd.ExecuteReader
        Do While read.Read
            CmbPower.Items.Add(read.GetString(0))
        Loop
        cmd.Dispose()
        read.Close()
        configureCRYSTALREPORT()
    End Sub


    Private Sub configureCRYSTALREPORT()
        Dim myConnectionInfo As New ConnectionInfo()

        myConnectionInfo.DatabaseName = "COM610\SQLEXPRESS"
        myConnectionInfo.UserID = "sa"
        myConnectionInfo.Password = "admin123"
        setDBLOGONforREPORT(myConnectionInfo)
    End Sub

    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        'Dim mytableloginfos As New TableLogOnInfos()
        'mytableloginfos = CrystalReportViewer1.LogOnInfo
        'For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
        '    myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        'Next

    End Sub
End Class
