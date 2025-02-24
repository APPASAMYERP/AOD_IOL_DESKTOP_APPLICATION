Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmPouch



    Dim ds As New DataSet
    Dim strsql As String
    'Dim stringToPrint As String
    Private Sub BTWFileName()
        lblFileName.Text = ""
        ds = New DataSet()
        strsql = "select * from BTW_Master where Department = '" & cmbDepartment.Text & "' and ModelNo = '" & cmbModelNo.Text & "' and LabelName = '" & cmbLabelName.Text & "' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            lblFileName.Text = ds.Tables(0).Rows(0)("FileName")
        End If


    End Sub
    Private Sub frmPouch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If


        LensMasterBind()
        LabelNameBind()
        'PrinterNameBind()
        TypeBind()


    End Sub

    Private Sub LensMasterBind()
        ds = New DataSet()
        If productline = "PMMA" Then
            strsql = "select distinct Model_Name from Lens_Master1 order by Model_Name"
        Else
            strsql = "select distinct Model_Name from Lens_Master order by Model_Name"
        End If
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbModelNo.DisplayMember = "Model_Name"
        cmbModelNo.DataSource = ds.Tables(0)

        'CheckedListBox1.Items.Clear()
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    CheckedListBox1.Items.Add(ds.Tables(0).Rows(i)("ModelNo").ToString())
        'Next
    End Sub

    Private Sub LabelNameBind()
        ds = New DataSet()
        strsql = "select distinct LabelName from BTW_Master "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbLabelName.DisplayMember = "LabelName"
        cmbLabelName.DataSource = ds.Tables(0)


    End Sub

    Private Sub TypeBind()
        ds = New DataSet()
        strsql = "select distinct Type from Lot_Type "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbTypeName.DisplayMember = "Type"
        cmbTypeName.DataSource = ds.Tables(0)


    End Sub

    Private Sub PrinterNameBind()
        ds = New DataSet()
        strsql = "select distinct PrinterName from BTW_Master "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        'cmbPrinterName.DisplayMember = "PrinterName"
        'cmbPrinterName.DataSource = ds.Tables(0)


    End Sub




    Private Sub btnShowbtwPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowbtwPreview.Click
        BTWFileName()

        Dim docName As String = Application.StartupPath & "\" & lblFileName.Text


        If File.Exists(docName) Then
            Process.Start(docName)
        Else
            MessageBox.Show("No file found!")
        End If

    End Sub


    Private Sub btnFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileName.Click
        BTWFileName()
    End Sub
End Class