
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmEnquiry_to_order_reserve
    Dim Sql As String 
    Dim Ds As New DataSet
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand

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


    Private Sub cmbReserve_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReserve_id.SelectedIndexChanged
        If cmbReserve_id.Text <> "" Then
            Sql = "SELECT     Brand_Name, Model_Name, Power, Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country, SUM(Qty) AS Qty " & _
                    "FROM         Order_Reserved_Details  Where Reserved_Id='" & cmbReserve_id.Text & "'  " & _
                    "GROUP BY Brand_Name, Model_Name, Power, Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country  " & _
                    "ORDER BY Brand_Name, Model_Name, CAST(Power AS float), Order_ID, Reserved_Id, Reserved_Ord_Type, Reserved_Ord_Country  "

            Ds = SQL_SelectQuery_Execute(Sql)
            DataGridView1.DataSource = Ds.Tables(0)

            Sql = "SELECT DISTINCT Order_ID,Reserved_Ord_Country, Reserved_Ord_Type FROM         Order_Reserved_Details Where Reserved_Id='" & cmbReserve_id.Text & "' "
            Ds = SQL_SelectQuery_Execute(Sql)
            If Ds.Tables(0).Rows.Count = 1 Then
                CmbOrderContry.Items.Clear()
                For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                    CmbOrderContry.Items.Add(eachRow1("Reserved_Ord_Country"))
                Next
                CmbOrderContry.Text = Ds.Tables(0).Rows(0)("Reserved_Ord_Country")
                txt_orderId.Text = Ds.Tables(0).Rows(0)("Order_ID")
                CmbTyPacking.Text = Ds.Tables(0).Rows(0)("Reserved_Ord_Type")

            Else
                MsgBox("Multiple order id.")
                Exit Sub
            End If



        End If
    End Sub

    Private Sub frmEnquiry_to_order_reserve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_order_id()
        country_name_load()
    End Sub

    Public Sub load_order_id()
        'tray No load
        Sql = "SELECT DISTINCT Reserved_Id FROM         Order_Reserved_Details WHERE Reserved_Ord_Country = 'ENQUIRY' ORDER BY Reserved_Id "
        Ds = SQL_SelectQuery_Execute(Sql)
        cmbReserve_id.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbReserve_id.Items.Add(eachRow1("Reserved_Id"))
        Next

    End Sub

    Public Sub country_name_load()

        StrSql = "SELECT DISTINCT Country_Name from Order_Country order by Country_Name"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        cmb_Change_Ord_Country.Items.Clear()
        While StrRs.Read
            cmb_Change_Ord_Country.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        If cmbReserve_id.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Reserved_id")
            cmbReserve_id.Focus()
            Exit Sub
        End If
        If cmb_Change_Ord_Country.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Order Country")
            cmb_Change_Ord_Country.Focus()
            Exit Sub
        End If


        'update
        StrSql = " UPDATE    Order_Reserved_Details SET              Previous_Order_Country = Reserved_Ord_Country WHERE     (Reserved_Id = '" & cmbReserve_id.Text & "') "
        UpdateorInsertQuery_Execute(StrSql)

        StrSql = "UPDATE    Order_Reserved_Details " & _
        "SET              Reserved_Ord_Country = '" & cmb_Change_Ord_Country.Text & "', Modified_By = '" & StrLoginUser & "', Modified_Date = GETDATE() " & _
        "WHERE     (Reserved_Id = '" & cmbReserve_id.Text & "') "

        UpdateorInsertQuery_Execute(StrSql)

        clear()
        load_order_id()
        MessageBox.Show(" Order Country Changed.")
    End Sub

    Public Sub clear()

        cmbReserve_id.Text = ""
        txt_orderId.Text = ""
        CmbTyPacking.Text = ""
        CmbOrderContry.Text = ""
        cmb_Change_Ord_Country.Text = ""
        DataGridView1.DataSource = Nothing

    End Sub
End Class