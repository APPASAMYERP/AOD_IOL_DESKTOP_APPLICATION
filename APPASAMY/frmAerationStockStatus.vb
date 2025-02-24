Imports System.Data
Imports System.Data.SqlClient
Public Class frmAerationStockStatus

    Dim ds As New DataSet
    Dim strsql As String
    Private Sub TypeBind()
        ds = New DataSet()

        strsql = "select distinct Type from Lot_Type "
       
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbType.DisplayMember = "Type"
        cmbType.DataSource = ds.Tables(0)

    End Sub

    Private Sub ModelBind()
        ds = New DataSet()
        If productline = "PMMA" Then
            strsql = "select distinct model_name  from Lens_Master1 order by model_name"
        Else
            strsql = "select distinct model_name  from Lens_Master order by model_name "
        End If
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbModel.DisplayMember = "model_name"
        cmbModel.DataSource = ds.Tables(0)

    End Sub

    Private Sub PowerBind()
        ds = New DataSet()
        If productline = "PMMA" Then
            strsql = "select distinct cast(power as decimal(10,2)) as power from Lens_Master1 order by power "
        Else
            strsql = "select distinct cast(power as decimal(10,2)) as power from Lens_Master order by power "
        End If
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPower.DisplayMember = "power"
        cmbPower.DataSource = ds.Tables(0)

        cmbPower.Text = ""
    End Sub

    Private Sub View()
        ds = New DataSet()
        If cmbPower.Text = "" Then
            strsql = "Declare @model_name nvarchar(50) ='" & cmbModel.Text & "' , @Type nvarchar(25)='" & cmbType.Text & "' SELECT CONVERT(VARCHAR(10), Sterilization_Date, 120)AS SterilizationDate,CONVERT(VARCHAR(10), Created_Date, 120) as Created_Date ,Brand_Name,Model_Name, Power,SUM(Qty_1)AS qty, DATEADD(day,15,CONVERT(varchar(10),Sterilization_Date, 120)) AS ReadyDate,btc_no FROM POUCH_LABEL WHERE(Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL)  and  (Box_Packing = '0') AND (Sterilization_Reject = '0') AND (Box_Reject = '0')and model_name=@model_name and Type=@Type   "
        Else
            strsql = "Declare @model_name nvarchar(50) ='" & cmbModel.Text & "' , @Type nvarchar(25)='" & cmbType.Text & "',@Power varchar(10)='" & cmbPower.Text & "'   SELECT CONVERT(VARCHAR(10), Sterilization_Date, 120)AS SterilizationDate,CONVERT(VARCHAR(10), Created_Date, 120) as Created_Date  ,Brand_Name,Model_Name, Power,SUM(Qty_1)AS qty, DATEADD(day,15,CONVERT(varchar(10),Sterilization_Date, 120)) AS ReadyDate,btc_no FROM POUCH_LABEL WHERE(Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL)  and  (Box_Packing = '0') AND (Sterilization_Reject = '0') AND (Box_Reject = '0')and model_name=@model_name and Type=@Type and power=@Power  "
        End If

        If chkBefore_Sterilization.Checked Then
            strsql = strsql & "  and (sterilization='1') "
        End If

        If chkAfter_Sterilization.Checked Then
            strsql = strsql & " AND (sterilization_after='1')  "
        End If

        If chkSterilization.Checked Then
            strsql = strsql & "  and MFD_Year = '" & dtpYear.Value.Year & "'"
        End If

        strsql = strsql & "GROUP BY CONVERT(VARCHAR(10), Sterilization_Date, 120),CONVERT(VARCHAR(10), Created_Date, 120) ,Brand_Name,Model_Name, Power,Btc_no order by Brand_Name,Model_Name, Power, SterilizationDate, Created_Date,Btc_no "

        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
        Dim num1 As New Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If IsDBNull(DataGridView1.Rows(i).Cells("Qty").Value) Then
                num1 += 0
            Else
                num1 += Convert.ToInt32(DataGridView1.Rows(i).Cells("Qty").Value)
            End If
        Next
        txtTotalLens.Text = num1.ToString()
        If txtTotalLens.Text = "0" Then
            MessageBox.Show("No stock in this Model and Power")
        End If
    End Sub
    Private Sub frmAerationStockStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        ModelBind()
        TypeBind()
        PowerBind()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        txtTotalLens.Text = ""
        View()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class