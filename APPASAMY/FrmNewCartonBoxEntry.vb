Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmNewCartonBoxEntry


    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim TblSmall As New DataTable
    Dim TblBig As New DataTable
    Dim DtRow As DataRow

    Private Sub FrmNewCartonBoxEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create four typed columns in the DataTable.

        TblSmall.Columns.Add("Box No", GetType(Integer))
        TblSmall.Columns.Add("Power", GetType(Integer))
        GridSmall.DataSource = TblSmall

        With GridSmall.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With



        TblBig.Columns.Add("Box No", GetType(Integer))
        TblBig.Columns.Add("Power", GetType(Integer))
        GridBig.DataSource = TblBig

        With GridBig.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With



    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Dim IntTotalBox As Integer
        Dim IntBoxBalance As Integer
        Dim IntLineBox As Integer
        Dim IntFillBox As Integer
        Dim IntSmalllineNo As Integer
        Dim IntSmallEachBox As Integer
        Dim IntTotSmallBox As Integer
        IntTotalBox = txttotbox.Text
        IntBoxBalance = IntTotalBox
        IntLineBox = 0
        IntFillBox = 0
        IntSmallEachBox = txtSmallEach.Text
        IntTotSmallBox = txtsmallnoofBox.Text


        For i As Integer = 1 To IntTotSmallBox
            IntLineBox = 0
            If IntBoxBalance > IntSmallEachBox Then
                IntBoxBalance = Val(IntBoxBalance) - Val(IntSmallEachBox)
                IntLineBox = IntSmallEachBox
            Else
                IntLineBox = IntBoxBalance
            End If
            IntFillBox = Val(IntFillBox) + Val(IntLineBox)

            DtRow = TblSmall.NewRow
            TblSmall.Rows.Add(i, IntLineBox)
        Next



       
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class