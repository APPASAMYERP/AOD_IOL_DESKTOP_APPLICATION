Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql


Public Class FrmTurkeyGS1Label

    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String


    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function

    Public Function brandNameBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Brand_Name from LENS_MASTER1   order by Brand_Name"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function ModelNameBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Model_Name from LENS_MASTER1 WHERE Brand_Name='" & cmbBrand.Text & "'   order by Model_Name"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function PowerBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Power from LENS_MASTER1 WHERE Brand_Name='" & cmbBrand.Text & "' and Model_Name='" & CmbModel.Text & "'  order by Power"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function GetGS1Details() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT Model_name, Power, GS_code  from LENS_MASTER1 WHERE Brand_Name='" & cmbBrand.Text & "' and Model_Name='" & CmbModel.Text & "' and POWER='" & cmbPower.Text & "' "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If cmbBrand.Text = "" Then
            err.SetError(cmbBrand, "This information is required")
            cmbBrand.Focus()
            Exit Sub
        Else
            err.SetError(cmbBrand, "")
        End If

        If CmbModel.Text = "" Then
            err.SetError(CmbModel, "This information is required")
            CmbModel.Focus()
            Exit Sub
        Else
            err.SetError(CmbModel, "")
        End If

        If cmbPower.Text = "" Then
            err.SetError(cmbPower, "This information is required")
            cmbPower.Focus()
            Exit Sub
        Else
            err.SetError(cmbPower, "")
        End If

        If txtQty.Text = "" Then
            err.SetError(txtQty, "This information is required")
            txtQty.Focus()
            Exit Sub
        Else
            err.SetError(txtQty, "")
        End If

        If Val(txtQty.Text) < 1 Then
            MsgBox("Enter Minimum 1 Qty")
            txtQty.Text = ""
            txtQty.Focus()
            Exit Sub
        End If

        Dim StrFName As String
        'Dim StrPrintedQty As String
        StrFName = "PMMA_Turkey_GS1_LABEL.btw"
        btFile = Application.StartupPath & "\" & StrFName & ""

        For i = 1 To Val(txtQty.Text)


            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
            bt.SetNamedSubStringValue("Model", LblShowModel.Text)
            bt.SetNamedSubStringValue("Pwr", Val(LblShowPower.Text).ToString("0.00") + "D")
            bt.SetNamedSubStringValue("gscode", LblShowGSCode.Text)
            bt.SetNamedSubStringValue("UDIgscode", LblShowGSCode.Text.Remove(LblShowGSCode.Text.Length - 1, 1))

            bt.PrintOut()
            bt.Close()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
            LblPrintedQty.Text = i

        Next

        
        txtQty.Text = ""
        LblShowModel.Text = ""
        LblShowPower.Text = ""
        LblShowGSCode.Text = ""

    End Sub

    Private Sub FrmTurkeyGS1Label_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ds = brandNameBind()
        cmbBrand.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbBrand.Items.Add(eachRow("Brand_Name"))
        Next

    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBrand.SelectedIndexChanged
        Ds = ModelNameBind()
        CmbModel.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            CmbModel.Items.Add(eachRow("Model_Name"))
        Next
    End Sub

    Private Sub CmbModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbModel.SelectedIndexChanged
        If cmbBrand.Text = "" Then
            err.SetError(cmbBrand, "This information is required")
            cmbBrand.Focus()
            Exit Sub
        Else
            err.SetError(cmbBrand, "")
        End If

        Ds = PowerBind()
        cmbPower.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbPower.Items.Add(eachRow("Power"))
        Next
    End Sub

    Private Sub cmbPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPower.SelectedIndexChanged
        If cmbBrand.Text = "" Then
            err.SetError(cmbBrand, "This information is required")
            cmbBrand.Focus()
            Exit Sub
        Else
            err.SetError(cmbBrand, "")
        End If

        If CmbModel.Text = "" Then
            err.SetError(CmbModel, "This information is required")
            CmbModel.Focus()
            Exit Sub
        Else
            err.SetError(CmbModel, "")
        End If

        Ds = GetGS1Details()
        If Ds.Tables(0).Rows.Count < 1 Then
            MessageBox.Show("GS1 not present. Please contact ERP team.")
            Exit Sub
        ElseIf Ds.Tables(0).Rows.Count > 1 Then
            MessageBox.Show("More than one GS1 present. Please contact ERP team.")
            Exit Sub
        Else
            LblShowModel.Text = Ds.Tables(0).Rows(0)("Model_name")
            LblShowPower.Text = Ds.Tables(0).Rows(0)("Power")
            LblShowGSCode.Text = Ds.Tables(0).Rows(0)("GS_code")
            
        End If
    End Sub


End Class