Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing

Public Class FrmSterileMachineReport
    Dim StrSql, Sql As String
    Dim Ds As New DataSet

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Try

            If txtSterileBatch.Text = "" Then
                err.SetError(txtSterileBatch, "This information is required")
                Exit Sub
            Else
                err.SetError(txtSterileBatch, "")
            End If

            Sql = "select  Distinct  Top(1)Machine_Report_Path from After_Sterilization_Scan_Details where btc_no='" & txtSterileBatch.Text & "' And Machine_Report_Path is not null "

            Ds = SQL_SelectQuery_Execute(Sql)
            If Ds.Tables(0).Rows.Count > 0 Then
                Dim imagePath As String = Ds.Tables(0).Rows(0)("Machine_Report_Path")
                If imagePath = "" Or imagePath Is Nothing Then
                    MsgBox("Image not found for the batch")
                    Exit Sub
                End If
                Try
                    PictureBox1.Image = Image.FromFile(imagePath)
                    PictureBox1.Tag = imagePath
                Catch ex As Exception
                    MessageBox.Show("Error loading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MsgBox("Image not found for the batch")
                Exit Sub
            End If


        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        If PictureBox1.Image IsNot Nothing AndAlso PictureBox1.Tag IsNot Nothing Then
            Dim imagePath As String = PictureBox1.Tag.ToString()

            ' Prompt user to select download location
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif"
            saveFileDialog.FileName = Path.GetFileName(imagePath)

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim savePath As String = saveFileDialog.FileName

                ' Copy the image file to the selected location
                Try
                    File.Copy(imagePath, savePath, True)
                    MessageBox.Show("Image downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error downloading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please open an image first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class