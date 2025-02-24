Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Color
Imports System.Configuration



Public Class Menulblmstdatacre

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StrXScreen = Screen.PrimaryScreen.Bounds.Width
        StrYScreen = Screen.PrimaryScreen.Bounds.Height

        StrXMain = Me.Width
        StrYMain = Me.Height

        lblHomeLogin.Left = StrXMain - 300
        Lblhomedatetime.Left = StrXMain - 300
        LblHomeWelcome.Left = StrXMain - 300

        'PicHomeCenteImage.Left = (Me.Width - PicHomeCenteImage.Width) / 2
        LblHomeHeadingName.Left = (Me.Width - LblHomeHeadingName.Width) / 2

        StrPicUnit = Me.Height - PicHomeHeader.Height - PicHomeDisplyBar.Height - PicHomeBottem.Height
        Lblhomedatetime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
        LblHomeWelcome.Text = "Welcome"

        PicHomeHeader.Width = StrXMain
        PicHomeBottem.Width = StrXMain
        PicHomeDisplyBar.Width = StrXMain

        PicHomeBottem.Top = (Me.Height) - PicHomeBottem.Height
        lblhomepoweredby.Left = StrXMain - 380
        lblhomepoweredby.Top = 10

        '''''''********* Parant Function Start *********''''''''''

        lblHohdrAppName.Parent = PicHomeHeader
        lblHohdrAppAssName.Parent = PicHomeHeader
        Lblhomedatetime.Parent = PicHomeHeader
        lblHomeLogin.Parent = PicHomeHeader
        LblHomeWelcome.Parent = PicHomeHeader
        LblHomeHeadingName.Parent = PicHomeHeader
        lblhomepoweredby.Parent = PicHomeBottem
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        '''''''********* Parant Function Start *********''''''''''


        '''''''********* Timer Function Start *********''''''''''

        TimHomeTime.Start()        'Home Date And Time Disply
        TimHomeSideDisply.Start()  'Home Side Picture Disply

        '''''''********* Timer Function Start *********''''''''''

        '''''''********* True Or Fale Function Start *********''''''''''

        '''''Menu Panel List Disply

        MenuPnlMasterCre.Visible = False
        MenuPnlProcess.Visible = False
        MenuPnlAdmin.Visible = False
        MenuPnlReport.Visible = False
        MenuPnlCatalog.Visible = False
        '''''Home Picture Side Disply
        'PicHomeSidePic1.Visible = False
        'PicHomeSidePic2.Visible = False
        'PicHomeSidePic3.Visible = False
    
        '''''Home Message Disply
        'LblHomeMsgDisply1.Visible = False
        'LblHomeMsgDisply2.Visible = False
        'LblHomeMsgDisplyHeader.Visible = False

        '''''Home Menu Name Disply
        LblHomeMenuDisplyName.Visible = False

        '''''''********* True Or Fale Function End *********''''''''''

        'PicHomeSidePic1.Left = StrXMain - 350
        'PicHomeSidePic2.Left = StrXMain - 350
        'PicHomeSidePic3.Left = StrXMain - 350
        'PicHomeSidePic4.Left = StrXMain - 350
        'PicHomeSidePic5.Left = StrXMain - 350

        'LblHomeMsgDisply1.Left

        'Dim BackCol1 As Color = Color.FromArgb(133, 200, 229)

        'Dim BackCol2 As Color = Color.FromArgb(216, 216, 216)

        'Me.BackColor = BackCol2

        'prnName = ops.PrinterName.ToString()
        conString = ConfigurationSettings.AppSettings("ConStr").ToString()
        con = New SqlConnection(conString)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StrXScreen = Screen.PrimaryScreen.Bounds.Width
        StrYScreen = Screen.PrimaryScreen.Bounds.Height

        StrXMain = Me.Width
        StrYMain = Me.Height

        'PicHomeBack.Width = StrXMain
        'PicHomeBack.Height = StrYMain

        PicHomeHeader.Width = StrXMain
        PicHomeBottem.Width = StrXMain

    End Sub
    Private Sub Clear_Home_Disply()
        '''''Menu Panel List Disply

        MenuPnlMasterCre.Visible = False
        MenuPnlProcess.Visible = False
        MenuPnlAdmin.Visible = False
        MenuPnlReport.Visible = False
        MenuPnlCatalog.Visible = False
        '''''Home Picture Side Disply
        'PicHomeSidePic1.Visible = False
        'PicHomeSidePic2.Visible = False
        'PicHomeSidePic3.Visible = False
        'PicHomeSidePic4.Visible = False
        'PicHomeSidePic5.Visible = False

        '''''Home Message Disply
        'LblHomeMsgDisply1.Visible = False
        'LblHomeMsgDisply2.Visible = False
        'LblHomeMsgDisplyHeader.Visible = False

        TimHomeSideDisply.Stop()
    End Sub

    Private Sub MenuPanl_Disply()
        MenuPnlMasterCre.Visible = False
        MenuPnlProcess.Visible = False
        MenuPnlAdmin.Visible = False
        MenuPnlReport.Visible = False
        MenuPnlCatalog.Visible = False
    End Sub
    Private Sub ToolStripContainer2_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub lblHomeLogin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblHomeLogin.LinkClicked
        'FrmNewLogin.Parent = Me

        'FrmNewLogin.Top = Me.Height - PicHomeHeader.Height - PicHomeDisplyBar.Height - 50
        ''FrmNewLogin.Parent = Me
        'FrmNewLogin.Show()



        If lblHomeLogin.Text = "&Login" Then
            Dim ChildOfMDIChildlOGIN As New FrmNewLogin
            With ChildOfMDIChildlOGIN
                .TopLevel = False
                .Parent = Me
                .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
                .Width = StrXMain
                .Height = StrPicUnit - 30
                .GroupBox1.Top = (ChildOfMDIChildlOGIN.Height - .GroupBox1.Height) / 2
                .GroupBox1.Left = (Me.Width - .GroupBox1.Width) / 2
                .txtUsername.Focus()
                .BringToFront()
                .Show()
            End With

            LblHomeMenuDisplyName.Text = " User Login"
            'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
            LblHomeMenuDisplyName.Visible = True
            LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
            LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
            LblHomeMenuDisplyName.Top = 10
            TimHomeSideDisply.Stop()
        Else
            Dim openForm As Form = Nothing

            'For index As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            '    openForm = My.Application.OpenForms.Item(index)
            '    If openForm IsNot Me AndAlso Not TypeOf openForm Is DevExpress.Utils.Win.TopFormBase Then
            '        openForm.Close()
            '        openForm.Dispose()
            '        openForm = Nothing
            '    End If
            'Next


            For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                If My.Application.OpenForms.Item(i) IsNot Me Then
                    My.Application.OpenForms.Item(i).Close()
                End If
            Next i



            StrLoginUser = ""
            LblHomeWelcome.Text = "Welcome"
            MenuBtnAdmin.Enabled = False
            MenuBtnMaster.Enabled = False
            MenuBtnProcess.Enabled = False
            MenuBtnReport.Enabled = False
            lblHomeLogin.Text = "&Login"

        End If


    End Sub

    Private Sub TimHomeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimHomeTime.Tick
        Lblhomedatetime.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub



    Private Sub MenuBtnMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBtnMaster.Click
        MenuPanl_Disply()
        MenuPnlMasterCre.Visible = True
        MenuPnlMasterCre.Left = 110
        MenuPnlMasterCre.Top = 102
    End Sub

    Private Sub PicHomeDisplyBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicHomeDisplyBar.Click

    End Sub

    Private Sub PicHomeDisplyBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicHomeDisplyBar.MouseMove
        MenuPanl_Disply()

    End Sub

    Private Sub MenuBtnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBtnProcess.Click
        MenuPanl_Disply()
        MenuPnlProcess.Visible = True
        MenuPnlProcess.Left = 110 + 93
        MenuPnlProcess.Top = 102

    End Sub

    Private Sub lblhomepoweredby_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhomepoweredby.Click

    End Sub

    Private Sub TimHomeSideDisply_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimHomeSideDisply.Tick
        Dim max As Integer = 5000

        Dim rnd As New Random

        Dim rand As Integer = rnd.Next(10, max + 1)

        Dim i As Integer = 1

        Dim number(max - 1) As Integer



        For i = 0 To max - 1

            If number(i) = rand Then

                rand = rnd.Next(1, max + 1)

                i = -1

            ElseIf number(i) = 0 Then

                number(i) = rand

                rand = rnd.Next(1, max + 1)

                If i = max - 1 Then

                    Exit For

                End If

                i = -1

            End If

        Next

        TimHomeSideDisply.Interval = number(i)

        i += 1


        ChangeImage()


    End Sub



    Private Sub ChangeImage()



        'Static Dim iImage1 As Integer



        'Select Case iImage1

        '    Case 0
        '        'PicHomeSidePic1.Visible = True
        '        'PicHomeSidePic2.Visible = False
        '        'PicHomeSidePic3.Visible = False
        '        'PicHomeSidePic4.Visible = False
        '        'PicHomeSidePic5.Visible = False

        '        'LblHomeMsgDisply1.Visible = True
        '        'LblHomeMsgDisply2.Visible = False
        '        'LblHomeMsgDisplyHeader.Visible = True
        '        'LblHomeMsgDisplyHeader.Text = "Lens Tracking System"

        '        iImage1 += 1

        '    Case 1


        '        'PicHomeSidePic1.Visible = False
        '        'PicHomeSidePic2.Visible = True
        '        'PicHomeSidePic3.Visible = False
        '        'PicHomeSidePic4.Visible = False
        '        'PicHomeSidePic5.Visible = False

        '        iImage1 += 1

        '        'LblHomeMsgDisply1.Visible = False
        '        'LblHomeMsgDisply2.Visible = True
        '        'LblHomeMsgDisplyHeader.Visible = True
        '        'LblHomeMsgDisplyHeader.Text = "Features"

        '        iImage1 += 1

        '    Case 2


        '        PicHomeSidePic1.Visible = False
        '        PicHomeSidePic2.Visible = True
        '        PicHomeSidePic3.Visible = False
        '        PicHomeSidePic4.Visible = False
        '        PicHomeSidePic5.Visible = False

        '        iImage1 += 1

        '    Case 3



        '        PicHomeSidePic1.Visible = False
        '        PicHomeSidePic2.Visible = False
        '        PicHomeSidePic3.Visible = False
        '        PicHomeSidePic4.Visible = True
        '        PicHomeSidePic5.Visible = False

        '        iImage1 += 1

        '    Case 4
        '        PicHomeSidePic1.Visible = False
        '        PicHomeSidePic2.Visible = False
        '        PicHomeSidePic3.Visible = False
        '        PicHomeSidePic4.Visible = False
        '        PicHomeSidePic5.Visible = True
        '        iImage1 = 0



        'End Select

    End Sub

    Private Sub PicHomeHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicHomeHeader.Click

    End Sub

    Private Sub MenuLblMCLotNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblMCLotNo.Click


        Dim ChildOfMDIChildLotNoCreate As New FrmNewLotNo
        With ChildOfMDIChildLotNoCreate
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildLotNoCreate.Width) / 2
            .Height = StrPicUnit - 30

            .txtCreLotPrefix.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Lot No Creation"
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()


    End Sub

    Private Sub MenuBtnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBtnAdmin.Click
        MenuPanl_Disply()
        MenuPnlAdmin.Visible = True
        MenuPnlAdmin.Left = 110 + 186
        MenuPnlAdmin.Top = 102
    End Sub

    Private Sub MenuLblAdmUserCrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblAdmUserCrt.Click

        Dim ChildOfMDIChildUserCreation As New FrmNewUserCreation
        With ChildOfMDIChildUserCreation
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildUserCreation.Width) / 2
            .Height = StrPicUnit - 30

            .txtCrName.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " User Creation"
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsPouchLabelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsPouchLabelPrint.Click
        Dim ChildOfMDIChildPouchLablePrint As New FrmNewPouchLablePrint
        With ChildOfMDIChildPouchLablePrint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildPouchLablePrint.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Pouch Lable Printing"
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsSerlization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsSerlization.Click
        Dim ChildOfMDIChildSterilization As New FrmNewSterilization
        With ChildOfMDIChildSterilization
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildSterilization.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Sterilization "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsGenPackList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsGenPackList.Click
        Dim ChildOfMDIChildBPLGen As New FrmNewBPLGen
        With ChildOfMDIChildBPLGen
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildBPLGen.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " BPL List "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblReportBPLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportBPLList.Click
        Dim ChildOfMDIChildRptBPLView As New RptBPLView
        ChildOfMDIChildRptBPLView.Show()
        'With ChildOfMDIChildRptBPLView
        '    '.TopLevel = False
        '    '.Parent = Me
        '    '.Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
        '    '.Left = (StrXMain - ChildOfMDIChildRptBPLView.Width) / 2
        '    '.Height = StrPicUnit - 30

        '    '.txt.Focus()
        '    .BringToFront()
        '    .Show()
        'End With

        LblHomeMenuDisplyName.Text = " BPL Print "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuBtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBtnReport.Click
        MenuPanl_Disply()
        MenuPnlReport.Visible = True
        MenuPnlReport.Left = 110 + 279
        MenuPnlReport.Top = 102
    End Sub

    Private Sub MenuLblPrsSST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsSST.Click
        Dim ChildOfMDIChildSterSample As New FrmNewSterSample
        With ChildOfMDIChildSterSample
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildSterSample.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " STERILIZATION SAMPLE COLLECTION "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsCST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsCST.Click
        Dim ChildOfMDIChildCtrlSample As New FrmNewCtrlSample
        With ChildOfMDIChildCtrlSample
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildCtrlSample.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " CONTROL SAMPLE COLLECTION "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuBtnCatalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBtnCatalog.Click
        MenuPanl_Disply()
        MenuPnlCatalog.Visible = True
        MenuPnlCatalog.Left = 110 + 372
        MenuPnlCatalog.Top = 102
    End Sub

    Private Sub MenuLblCatalogCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblCatalogCustomer.Click
        Dim ChildOfMDIChildCustomerCatalog As New FrmNewCustomerCatalog
        With ChildOfMDIChildCustomerCatalog
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildCustomerCatalog.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " CONTROL SAMPLE COLLECTION "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsdCpACKlIST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsdCpACKlIST.Click
        Dim ChildOfMDIChildDcPackingList As New FrmNewDcPackingList
        With ChildOfMDIChildDcPackingList
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildDcPackingList.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " DC PACKING LIST "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()

    End Sub

    Private Sub MenuLblPrsBoxPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsBoxPacking.Click
        Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPacking
        With ChildOfMDIChildBoxPacking
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildBoxPacking.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " BOX PACKING "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblReportDCLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportDCLList.Click
        Dim ChildOfMDIChildDcViewRpt As New FrmDcViewRpt
        ChildOfMDIChildDcViewRpt.Show()
        'With ChildOfMDIChildRptBPLView
        '    '.TopLevel = False
        '    '.Parent = Me
        '    '.Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
        '    '.Left = (StrXMain - ChildOfMDIChildRptBPLView.Width) / 2
        '    '.Height = StrPicUnit - 30

        '    '.txt.Focus()
        '    .BringToFront()
        '    .Show()
        'End With

        LblHomeMenuDisplyName.Text = " DCL Print "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrsDc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsDc.Click
        Dim ChildOfMDIChildNewDcSoft As New FrmNewDcSoft
        With ChildOfMDIChildNewDcSoft
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewDcSoft.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " DC PRINT - SOFT  "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblReportDCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportDCPrint.Click
        Dim ChildOfMDIChildDcPrintSoft As New FrmDcPrintSoft
        ChildOfMDIChildDcPrintSoft.Show()
        'With ChildOfMDIChildRptBPLView
        '    '.TopLevel = False
        '    '.Parent = Me
        '    '.Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
        '    '.Left = (StrXMain - ChildOfMDIChildRptBPLView.Width) / 2
        '    '.Height = StrPicUnit - 30

        '    '.txt.Focus()
        '    .BringToFront()
        '    .Show()
        'End With

        LblHomeMenuDisplyName.Text = " DC Print "
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()
    End Sub


    Private Sub MenuLblPrsPowerLabelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsPowerLabelPrint.Click
        Dim ChildOfMDIChildPowerLabelPrint As New FrmPowerLabelPrint
        With ChildOfMDIChildPowerLabelPrint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildPowerLabelPrint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " POWER LABEL PRINT "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblReportCartonBoxEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportCartonBoxEntry.Click
        Dim ChildOfMDIChildCartonBoxEntry As New FrmNewCartonBoxEntry
        With ChildOfMDIChildCartonBoxEntry
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildCartonBoxEntry.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " CARTON BOX ENTRY "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol1 As Color = Color.FromArgb(133, 200, 229)

        'Dim BackCol2 As Color = Color.FromArgb(216, 216, 216)



        Me.BackColor = BackCol1

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(216, 216, 216)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(164, 210, 226)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(228, 233, 239)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(221, 211, 184)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(145, 152, 160)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(221, 225, 228)



        Me.BackColor = BackCol2
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(145, 152, 160)
        Me.BackColor = White
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(112, 159, 179)
        Me.BackColor = BackCol2
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(192, 192, 192)
        Me.BackColor = BackCol2
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim BackCol2 As Color = Color.FromArgb(170, 200, 228)
        Me.BackColor = BackCol2
    End Sub

    Private Sub MenuLblPouchReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPouchReprint.Click
        Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprint
        With ChildOfMDIChildNewPouchReprint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewPouchReprint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " POUCH LABEL RE PRINT   "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblReportCollectionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportCollectionList.Click


        Dim ChildOfMDIChildNewrptCollection As New FrmNewRptCollection
        With ChildOfMDIChildNewrptCollection
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewrptCollection.Width) / 2
            .Height = StrPicUnit - 30

            '.txt.Focus()
            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Collection Report"
        'LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        'TimHomeSideDisply.Stop()
        Clear_Home_Disply()






    End Sub

    Private Sub MenuLblInjetprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblInjetprint.Click
        Dim ChildOfMDIChildNewInjectLabel As New FrmNewInjectLabel
        With ChildOfMDIChildNewInjectLabel
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewInjectLabel.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " INJET LABEL PRINT   "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblrewokreject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblrewokreject.Click
        Dim ChildOfMDIChildNewRejection As New FrmNewRejection
        With ChildOfMDIChildNewRejection
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewRejection.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Re_Work & Rejection   "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub



    Private Sub MenuLblPouchDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPouchDetails.Click
        Dim ChildOfMDIChildNewPchDetls As New NewPouchDetails
        With ChildOfMDIChildNewPchDetls
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewPchDetls.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Pouch Label Details  "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim ChildOfMDIChildNewmaster As New FrmNewMaster
        With ChildOfMDIChildNewmaster
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewmaster.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Pouch Label Details  "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

  
    
    Private Sub MenuLblReportProcesssts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblReportProcesssts.Click
        Dim ChildOfMDIChildProcesssts As New FrmProcess_status
        With ChildOfMDIChildProcesssts
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildProcesssts.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Process Ststus Reports  "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

   
    Private Sub MenuLblinjetReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblinjetReprint.Click
        Dim ChildOfMDIChildNewInjetLabelReprint As New FrmNewInjetLabelReprint
        With ChildOfMDIChildNewInjetLabelReprint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewInjetLabelReprint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " INJET LABEL RE PRINT   "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblPrinterCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrinterCustomer.Click
        Dim ChildOfMDIChildPrinterCatalog As New frmPrinter
        With ChildOfMDIChildPrinterCatalog
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildPrinterCatalog.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Printer Details "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblModelPrintCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblModelPrintCustomer.Click
        Dim ChildOfMDIChildModelPrintCatalog As New frmmodelprint
        With ChildOfMDIChildModelPrintCatalog
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildModelPrintCatalog.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Model Print Details "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim ChildOfMDIChilddesrpt As New frmDespatchrpt
        With ChildOfMDIChilddesrpt
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChilddesrpt.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " Despatch Reports  "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuLblSoftDc2d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblSoftDc2d.Click
        Dim ChildOfMDIChildNewDC2D As New FrmNewDC2D
        With ChildOfMDIChildNewDC2D
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewDC2D.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " DC 2D PRINT "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub MenuPnlAdmin_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MenuPnlAdmin.Paint

    End Sub

    
    Private Sub MenuLblPrsDcreprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuLblPrsDcreprint.Click
        Dim ChildOfMDIChildNewDCreprint As New FrmDC_RePrint
        With ChildOfMDIChildNewDCreprint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildNewDCreprint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " DC RE-Print "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim ChildOfMDIChildPowerLabelPrint As New FrmPowerUpdation
        With ChildOfMDIChildPowerLabelPrint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildPowerLabelPrint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " POWER UPDATION "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub

    Private Sub lbldispatchcollector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldispatchcollector.Click
        Dim ChildOfMDIChildPowerLabelPrint As New Report
        With ChildOfMDIChildPowerLabelPrint
            .TopLevel = False
            .Parent = Me
            .Top = PicHomeHeader.Height + PicHomeDisplyBar.Height + 10
            .Left = (StrXMain - ChildOfMDIChildPowerLabelPrint.Width) / 2
            .Height = StrPicUnit - 30

            .BringToFront()
            .Show()
        End With

        LblHomeMenuDisplyName.Text = " POWER UPDATION "
        LblHomeMenuDisplyName.Visible = True
        LblHomeMenuDisplyName.Parent = PicHomeDisplyBar
        LblHomeMenuDisplyName.Left = ((Me.Width) - (LblHomeMenuDisplyName.Width)) / 2
        LblHomeMenuDisplyName.Top = 10
        Clear_Home_Disply()
    End Sub
End Class