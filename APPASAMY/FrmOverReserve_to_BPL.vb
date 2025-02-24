
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class FrmOverReserve_to_BPL
    Dim Sql As String
    Dim Ds As New DataSet
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim serialTable As New DataTable

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

    Public Sub load_order_id()
        'tray No load


        Sql = "SELECT DISTINCT Reserved_Id FROM         Order_Reserved_Details WHERE Reserved_Ord_Country <> 'ENQUIRY'  and Reserved_Id in(Select Distinct Reserved_Id from Pouch_Label WHERE  Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1') AND (Lens_Reserved_status =1)  ) ORDER BY Reserved_Id "
        Ds = SQL_SelectQuery_Execute(Sql)
        cmbReserve_id.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbReserve_id.Items.Add(eachRow1("Reserved_Id"))
        Next

    End Sub

    Private Sub FrmOverReserve_to_BPL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_order_id()

        serialTable.Columns.Add("Brand_Name", GetType(String))
        serialTable.Columns.Add("Model_Name", GetType(String))
        serialTable.Columns.Add("Power", GetType(String))
        serialTable.Columns.Add("Batch", GetType(String))
        serialTable.Columns.Add("Lot_Number", GetType(String))
        serialTable.Columns.Add("St_SrNo", GetType(String))
        serialTable.Columns.Add("Qty", GetType(String))
        serialTable.Columns.Add("Reserved_Id", GetType(String))
        serialTable.Columns.Add("BPL_No", GetType(String))
        DataGridView2.DataSource = serialTable


        With DataGridView2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub


    Public Function getLastHeaderId() As Integer

        Dim UTCTime As DateTime = Date.UtcNow
        Dim IndianTime As DateTime = UTCTime.AddHours(5.5)

        Dim ds As New DataSet
        Dim StrSql As String = " SELECT   Max(Header_ID) as Header_ID  FROM    BPL_GEN  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return Convert.ToInt32(ds.Tables(0).Rows(0)("Header_ID")) + 1
        Else
            Return 1
        End If


    End Function

    Public Function getLastDetailId() As Integer

        Dim UTCTime As DateTime = Date.UtcNow
        Dim IndianTime As DateTime = UTCTime.AddHours(5.5)

        Dim ds As New DataSet
        Dim StrSql As String = " SELECT   Max(Detail_ID) as Detail_ID  FROM    BPL_GEN  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return Convert.ToInt32(ds.Tables(0).Rows(0)("Detail_ID")) + 1
        Else
            Return 1
        End If


    End Function

    Public Function getAllSeialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Brand_Name,Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno,St_SrNo, Qty_1 AS Qty,Reserved_Id  FROM POUCH_LABEL  " & _
                            " WHERE  Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1') AND (Lens_Reserved_status =1) and Reserved_Id='" & cmbReserve_id.Text & "' " & _
                            "  ORDER BY Model_Name, Power, Lot_Prefix, Lot_No, Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getDistintModel() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = ""
        StrSql = "SELECT     DISTINCT  Model_Name  FROM POUCH_LABEL  WHERE  Sterilization=1 and Sample_Taken=0 and BPL_Taken=0 and Box_Packing=0 and Dc_Packing=0 AND Sterilization_After=1 and Sterilization_Reject=0 and sterility_status = '1'  AND (Areation_Status = '1') AND (Lens_Reserved_status =1) and Reserved_Id='" & cmbReserve_id.Text & "'  ORDER BY Model_Name "

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Dim header_id As Integer
        Dim dsAllSerial As DataSet
        Dim dsDistinctModel As DataSet
        Dim maxBPLQty As Integer = 100

        header_id = getLastHeaderId()


        GRID2.Rows.Clear()
        dsAllSerial = getAllSeialNumber()
        DataGridView2.DataSource.Rows.Clear()


        dsDistinctModel = getDistintModel()
        For Each eachModel As DataRow In dsDistinctModel.Tables(0).Rows

             
            Dim i As Integer = 0
            For Each eachRow As DataRow In dsAllSerial.Tables(0).Select("Model_Name = '" & eachModel("Model_Name").ToString() & "'")
                serialTable.Rows.Add(eachRow("Brand_Name"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_No"), eachRow("lotno"), eachRow("St_SrNo"), eachRow("Qty"), eachRow("Reserved_Id"), "BPL/" & Format(Now, "ddMMyy") & "/" & header_id.ToString("0000"))
                i = i + 1
                If i Mod maxBPLQty = 0 Then

                    header_id = header_id + 1
                End If

            Next
            If i Mod maxBPLQty <> 0 Then

                header_id = header_id + 1
            End If
        Next

        DataGridView2.DataSource = serialTable

        

        Dim Brand_name As String = ""
        Dim bpl_no As String = ""
        Dim ModelName As String = ""
        Dim Power As String = ""
        Dim qty As Integer = 0


        Dim head_id As String = ""
        Dim detail_id As Integer = getLastDetailId()

        For i = 0 To serialTable.Rows.Count - 1 
            If bpl_no <> serialTable.Rows(i)("BPL_No") OrElse ModelName <> serialTable.Rows(i)("Model_Name") OrElse Power <> serialTable.Rows(i)("Power") Then 
                If bpl_no <> "" Then 
                    header_id = Convert.ToInt32(bpl_no.Split("/"c)(bpl_no.Split("/"c).Length - 1))
                    GRID2.Rows.Add(detail_id, header_id, Brand_name, ModelName, Power, qty, bpl_no)
                    detail_id += 1
                End If

                bpl_no = serialTable.Rows(i)("BPL_No").ToString()
                Brand_name = serialTable.Rows(i)("Brand_Name").ToString()
                ModelName = serialTable.Rows(i)("Model_Name").ToString()
                Power = serialTable.Rows(i)("Power").ToString()
                qty = Convert.ToInt32(serialTable.Rows(i)("Qty"))
            Else 
                qty += Convert.ToInt32(serialTable.Rows(i)("Qty"))
            End If


            If i = serialTable.Rows.Count - 1 Then
                header_id = Convert.ToInt32(bpl_no.Split("/"c)(bpl_no.Split("/"c).Length - 1))
                GRID2.Rows.Add(detail_id, header_id, Brand_name, ModelName, Power, qty, bpl_no)
            End If
        Next


        TextBox1.Text = (serialTable.Rows.Count).ToString()


        DataGridView3.Rows.Clear()
 

        bpl_no = ""
        ModelName = ""
        qty = 0
        For i = 0 To GRID2.Rows.Count - 1
            If bpl_no <> GRID2.Rows(i).Cells("BPL_No").Value.ToString() Then
                If bpl_no <> "" Then
                    DataGridView3.Rows.Add(bpl_no, ModelName, qty)
                End If
                bpl_no = GRID2.Rows(i).Cells("BPL_No").Value.ToString()
                ModelName = GRID2.Rows(i).Cells("Model_Name").Value.ToString()
                qty = Val(GRID2.Rows(i).Cells("Qty").Value)
            Else
                qty = qty + Val(GRID2.Rows(i).Cells("Qty").Value)
            End If
            If i = GRID2.Rows.Count - 1 Then
                DataGridView3.Rows.Add(bpl_no, ModelName, qty)
            End If
        Next

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

       
        Dim strUpdateQry As String = ""
        Dim strInsertQry As String = ""


        For i = 0 To DataGridView2.Rows.Count - 1

            strUpdateQry = strUpdateQry + "('" + DataGridView2.Rows(i).Cells("BPL_No").Value.ToString() + "','" + DataGridView2.Rows(i).Cells("Lot_Number").Value.ToString() + "','" + DataGridView2.Rows(i).Cells("St_SrNo").Value.ToString() + "'),"

        Next
        strUpdateQry = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
        strUpdateQry = "MERGE INTO pouch_label USING(VALUES " & strUpdateQry & ") AS source(bpl_no1, lot_no1,st_srno1) ON Lot_Prefix+Lot_No = source.lot_no1 AND St_SrNo =source.st_srno1 WHEN MATCHED THEN Update SET  BPL_No = source.bpl_no1, BPL_Taken =1 , Packing_Model='" & CmbTyPacking.Text & "', Ord_Country='" & CmbOrderContry.Text & "'  ;"
        UpdateorInsertQuery_Execute(strUpdateQry)

        For i = 0 To GRID2.Rows.Count - 1 
            strInsertQry = strInsertQry + "(" + GRID2.Rows(i).Cells("Detail_Id").Value.ToString() + ",'" + GRID2.Rows(i).Cells("Header_Id").Value.ToString() + "', '" + GRID2.Rows(i).Cells("Brand_Name").Value.ToString() + "', '" + GRID2.Rows(i).Cells("Model_Name").Value.ToString() + "', '" + GRID2.Rows(i).Cells("Power").Value.ToString() + "', 'AOD', '" + GRID2.Rows(i).Cells("Qty").Value.ToString() + "', '" + GRID2.Rows(i).Cells("BPL_No").Value.ToString() + "','" + StrLoginUser + "', GETDATE() ,'" + StrLoginUser + "', GETDATE()),"

        Next
        strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
        strInsertQry = "Insert into BPL_GEN (Detail_ID, Header_ID, Brand_Name, Model_Name, Power, Type_GS_Code, Qty, BPL_No, Created_By, Created_Date, Modified_By, Modified_Date ) VALUES " & strInsertQry
        UpdateorInsertQuery_Execute(strInsertQry)

        clear()
        MessageBox.Show("Data Saved.")
    End Sub


    Public Sub clear()

        cmbReserve_id.Text = ""
        txt_orderId.Text = ""
        CmbTyPacking.Text = ""
        CmbOrderContry.Text = "" 
        DataGridView1.DataSource = Nothing

        DataGridView3.Rows.Clear()
        GRID2.Rows.Clear() 
        DataGridView2.DataSource.Rows.Clear()

        load_order_id()
    End Sub
End Class