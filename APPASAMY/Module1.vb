Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Win32
Module initialize
    Dim dir As String = Directory.GetCurrentDirectory
    'Public conStr As String = "Data Source=shanmugam\sqlexpress;Initial Catalog=APS;User ID=sa;Password=admin@123"

    'Public constr As String = "Data Source=COM610\SQLEXPRESS;Initial Catalog=APS;User ID=sa;Password=admin123"
    'Public constr As String = "Data Source=T007\SQLEXPRESS_2005;Initial Catalog=APS;User ID=sa;Password=sa@123"
    Public tempflag As Boolean
    Public previllege As String
    Public userid As String
    'Public constr As String = "Data Source=COM610\SQLEXPRESS;Initial Catalog=APS;User ID=sa;Password=admin123"

    'Public constr As String = "Data Source=PHASEVIEW;Initial Catalog=APS;persist security info=False;Trusted_Connection=Yes"


    'Public con As New Global.System.Data.SqlClient.SqlConnection(conStr)
    Public Create As String
    Public Modify As String
    Public StrLoginUser As String
    Public con As SqlConnection
    Public conString As String
    Public productline As String
    Public station As String
    Public StrXScreen As Integer
    Public StrYScreen As Integer
    Public IsBoxPackRePrtUser As Integer = 0
    Public IsNotBoxPackUser As Integer = 0

    Public StrXMain As Integer
    Public StrYMain As Integer

    Public StrPicUnit As Integer


    Public Sub initial()

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Main()
        DisableDumpFiles()
        ' Application logic goes here
    End Sub

    Sub DisableDumpFiles()
        Try
            Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\Windows Error Reporting", True)
            If regKey Is Nothing Then
                regKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\Windows Error Reporting")
            End If
            regKey.SetValue("Disabled", 1, RegistryValueKind.DWord) ' Disable Error Reporting
            regKey.SetValue("DontShowUI", 1, RegistryValueKind.DWord) ' Prevent UI prompts
            regKey.Close()
        Catch ex As UnauthorizedAccessException
            Console.WriteLine("Administrator privileges are required to modify this setting.")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

End Module

