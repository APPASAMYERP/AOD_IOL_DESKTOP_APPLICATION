
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls
Public Class frmBoxOutward
    Dim StrRs, Sql, StrRs1, StrRsSeHd, StrRsSeDt As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql, Str_Header, StrUniqueNo, StrSqlSeHd, Str_Detail, StrSqlSeDt As String
    Dim bplno As String = ""
    Dim Ds1 As New DataSet

    Private Sub frmBoxOutward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
        
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click

        Str_Header = 0
        StrSqlSeHd = "Select Max(Header_ID) from DC_SOFT"
        Cmd = New SqlCommand(StrSqlSeHd, con)
        StrRsSeHd = Cmd.ExecuteReader
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
        Cmd.Dispose()

        StrUniqueNo = "DC/D/" & Str_Header

        Str_Detail = 0
        StrSqlSeDt = "Select Max(Detail_ID) from DC_SOFT"
        Cmd = New SqlCommand(StrSqlSeDt, con)
        StrRsSeDt = Cmd.ExecuteReader
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
        Cmd.Dispose()
        bplno = ""
        If ord_country.Text <> "" And packing_model.Text <> "" Then

            For i = 0 To DataGridView2.Rows.Count - 2
                bplno = DataGridView2.Rows(i).Cells("BPL_NO").Value.ToString()
                StrSql = "Update POUCH_LABEL set Dc_No= '" & StrUniqueNo & "' , Dc_Status=1 where BPL_NO = '" & bplno & "' "
                Ds1 = SQL_SelectQuery_Execute(StrSql)

            Next
            StrSql = "Insert Into DC_SOFT ( Header_ID,Detail_ID,Dc_No,Remarks,IndentNo,Created_By,Created_Date,DC_Comp) values ( " & _
                                        "'" & Str_Header & "','" & Str_Detail & "','" & StrUniqueNo & "','" & packing_model.Text & "','" & ord_country.Text & "', " & _
                                        "'" & StrLoginUser & "',GETDATE(),'1')"

            UpdateorInsertQuery_Execute(StrSql)
        Else
            MessageBox.Show("Please select Packing model and Order country")
        End If
        MessageBox.Show("DC Status updated successfully")
        DataGridView2.DataSource = Nothing
        LoadForm()
        packing_model.Text = ""
        ord_country.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dt As New DataTable()
        dt.Columns.Add("BPL_NO")
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("bplchk").Value)
            If isSelected Then
                dt.Rows.Add(row.Cells(1).Value)
            End If
        Next
        DataGridView2.DataSource = dt
        StrSql = "SELECT DISTINCT  Country_Name from Order_Country  order by  Country_Name"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        ord_country.Items.Clear()
        While StrRs.Read
            'dr(0).ToString()
            ord_country.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
       
    End Sub
    Public Sub LoadForm()
        StrSql = "SELECT DISTINCT BPL_NO  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 1) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE       ( created_date >= '2023-09-10')))  and Box_reject=0 and dc_status is null and dc_no is null order by bpl_no "

        Ds1 = SQL_SelectQuery_Execute(StrSql)
        DataGridView1.DataSource = Ds1
        DataGridView1.DataMember = "BPL_NO"
        
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        LoadForm()
        DataGridView2.DataSource = Nothing
        ord_country.Text = ""
        packing_model.Text = ""
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds, "BPL_NO")
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
End Class