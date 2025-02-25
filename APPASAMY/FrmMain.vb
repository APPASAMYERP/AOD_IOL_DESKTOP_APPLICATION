Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Color
Imports System.Configuration
Public Class FrmMain
 

    Private Sub PicHomeHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LotTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotTypeToolStripMenuItem.Click
        Dim frmlot As New FrmNewLotNo
        frmlot.MdiParent = Me
        frmlot.Show()
    End Sub

    Private Sub LensMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LensMasterToolStripMenuItem.Click
        Dim ChildOfMDIChildNewmaster As New FrmNewMaster
        ChildOfMDIChildNewmaster.MdiParent = Me
        ChildOfMDIChildNewmaster.Show()

    End Sub

     



    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         


        If Not inactivityTimer.Enabled Then
            StartInactivityTracking()
        End If

        ' Attach activity tracking to all forms & controls
        AttachEventHandlersToForms()


        UsernameLabel.Text = StrLoginUser
        lblProductLine.Text = productline
        lblStation.Text = station
        Dim Cmd As New SqlCommand
        Dim sql As String
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter
        sql = "select * from Login where UserName = '" & StrLoginUser & "'"
        Cmd = New SqlCommand(sql, con)
        ad = New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then


            If ds.Tables(0).Rows(0)("boxLabelReprint").ToString() = "1" Then
                IsBoxPackRePrtUser = 1
            End If

            If productline = "PHILIC" Then
                InjectorToolStripMenuItem.Visible = True
                LotDetailsToolStripMenuItem.Visible = True
            Else
                InjectorToolStripMenuItem.Visible = False
                LotDetailsToolStripMenuItem.Visible = False
            End If


            If ds.Tables(0).Rows(0)("Admin").ToString() = "0" Or ds.Tables(0).Rows(0)("Admin").ToString() = "" Then
                InjectorToolStripMenuItem.Visible = False
                ArToolStripMenuItem.Visible = False
                AministratorToolStripMenuItem.Visible = False
                MasterToolStripMenuItem.Visible = False
                PouchLabelPrintToolStripMenuItem.Visible = False
                PouchLabelReprintToolStripMenuItem.Visible = False
                PowerLabelPrintToolStripMenuItem.Visible = False
                InjetLabelPrintToolStripMenuItem.Visible = False
                SterilizationToolStripMenuItem.Visible = False
                SampleTestToolStripMenuItem.Visible = False
                ToolStripMenuItem6.Visible = False
                SterilizationRejectToolStripMenuItem.Visible = False
                SampleTestTToolStripMenuItem.Visible = False
                ToolStripTextBox1.Visible = False
                ToolStripMenuItem5.Visible = False
                ToolStripMenuItem4.Visible = False
                BoxPackingListToolStripMenuItem.Visible = False
                PackingReportReasonToolStripMenuItem.Visible = False
                BPLCollectionCancelToolStripMenuItem.Visible = False
                BoxPackingToolStripMenuItem.Visible = False
                BoxInspectionToolStripMenuItem.Visible = False
                BoxPackingToolToolStripMenuItem.Visible = False
                EgyptReprintToolStripMenuItem.Visible = False
                StToolStripMenuItem.Visible = False
                TurkeyGSCodeLabelToolStripMenuItem.Visible = False
                BoxOutwardFormToolStripMenuItem.Visible = False
                BPLReportToolStripMenuItem.Visible = False
                CollectionListReportToolStripMenuItem.Visible = False
                BPLDashboardToolStripMenuItem.Visible = False
                BoxPackingRecordToolStripMenuItem.Visible = False
                LotSheetReportToolStripMenuItem.Visible = False
                SterileCheckReportToolStripMenuItem.Visible = False
                PRNReportToolStripMenuItem.Visible = False
                BoxPackingReportToolStripMenuItem.Visible = False
                ProcessStatusReportToolStripMenuItem.Visible = False
                CartonBoxEntryToolStripMenuItem.Visible = False
                StockVerificationToolStripMenuItem.Visible = False
                LotDetailsToolStripMenuItem.Visible = False
                OtherSampleScanToolStripMenuItem.Visible = False
                RackLabelStaticToolStripMenuItem.Visible = False
                LensTrackingReportToolStripMenuItem.Visible = False
                LotToolStripMenuItem.Visible = False
                BPLDASHBOARDToolStripMenuItem1.Visible = False
                BeforeSterilizationToolStripMenuItem.Visible = False
                AfterSterilizationScanToolStripMenuItem.Visible = False
                BeforeSterilizationToolStripMenuItem.Visible = False
                AfterSterilizationScanToolStripMenuItem.Visible = False
                LensTrackingBlanksBatchReportToolStripMenuItem.Visible = False
                AfterSterilizationToolStripMenuItem.Visible = False
                BoxPackToolStripMenuItem.Visible = False
                MTSReportToolStripMenuItem.Visible = False
                PouchRaeportToolStripMenuItem.Visible = False
                SampleReportToolStripMenuItem.Visible = False
                SterileToAreationMoveToolStripMenuItem.Visible = False
                MMSReportSterileToolStripMenuItem.Visible = False
                ShrinkWarpRejectionToolStripMenuItem.Visible = False
                PocuhPackToSterileMoveToolStripMenuItem.Visible = False
                MMToolStripMenuItem.Visible = False
                InjectorToSterileMoveToolStripMenuItem.Visible = False
                InjectorSterileToAerationMoveToolStripMenuItem.Visible = False

                If ds.Tables(0).Rows(0)("Injector_to_Sterile_move").ToString() = "1" Then
                    InjectorToSterileMoveToolStripMenuItem.Visible = True

                End If

                If ds.Tables(0).Rows(0)("Injector_aeration_to_Sterile_move").ToString() = "1" Then
                    InjectorSterileToAerationMoveToolStripMenuItem.Visible = True

                End If

                If ds.Tables(0).Rows(0)("MMS_Report_Pouch").ToString() = "1" Then
                    PocuhPackToSterileMoveToolStripMenuItem.Visible = True
                    MMToolStripMenuItem.Visible = True

                End If

                If ds.Tables(0).Rows(0)("Shrink_Warp_Rej").ToString() = "1" Then
                    ShrinkWarpRejectionToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("CST_SST_Report").ToString() = "1" And productline <> "SUPERPHOB" Then
                    SampleReportToolStripMenuItem.Visible = True
                End If
                If ds.Tables(0).Rows(0)("Pouch_Pkg_Report").ToString() = "1" Then
                    PouchRaeportToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Mts_report").ToString() = "1" And productline <> "SUPERPHOB" Then
                    MTSReportToolStripMenuItem.Visible = True
                End If
                If ds.Tables(0).Rows(0)("Bx_pack_to_Des").ToString() = "1" And productline <> "SUPERPHOB" Then
                    BoxPackToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("bpl_Dashboard").ToString() = "1" Then
                    BPLDASHBOARDToolStripMenuItem1.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Lens_Tracking_Report").ToString() = "1" Then
                    LensTrackingReportToolStripMenuItem.Visible = True
                    LotToolStripMenuItem.Visible = True
                    LensTrackingBlanksBatchReportToolStripMenuItem.Visible = True
                End If


                If ds.Tables(0).Rows(0)("Rack_Label_Print").ToString() = "1" Then
                    RackLabelStaticToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Ster_release").ToString() = "1" Then
                    ToolStripMenuItem5.Visible = True
                End If

                If ds.Tables(0).Rows(0)("stock_scan").ToString() = "1" Then
                    StockVerificationToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("prn_report").ToString() = "1" Then
                    PRNReportToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("ster_Ck_Report").ToString() = "1" Then
                    SterileCheckReportToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("lotsheet_report").ToString() = "1" Then
                    LotSheetReportToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("bx_annexure").ToString() = "1" Then
                    BoxPackingRecordToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Bpl_Report").ToString() = "1" Then
                    BPLReportToolStripMenuItem.Visible = True
                    CollectionListReportToolStripMenuItem.Visible = True
                    BPLDashboardToolStripMenuItem.Visible = True
                End If


                If ds.Tables(0).Rows(0)("Turkey_gs_lbl").ToString() = "1" Then
                    TurkeyGSCodeLabelToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("ster_batch_update").ToString() = "1" Then
                    StToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Bx_Ins").ToString() = "1" Then
                    BoxInspectionToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Bx_Pking").ToString() = "1" Then
                    BoxPackingToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Bx_Pking_Lst").ToString() = "1" Then
                    BoxPackingListToolStripMenuItem.Visible = True
                    PackingReportReasonToolStripMenuItem.Visible = True
                    BPLCollectionCancelToolStripMenuItem.Visible = True
                End If


                If ds.Tables(0).Rows(0)("inject").ToString() = "1" Then
                    InjectorToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("areation").ToString() = "1" Then
                    ArToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Pouch_Lbl").ToString() = "1" Then
                    MasterToolStripMenuItem.Visible = True
                    PouchLabelPrintToolStripMenuItem.Visible = True
                End If

                If ds.Tables(0).Rows(0)("Pch_lbl_Reprint").ToString() = "1" Then
                    PouchLabelReprintToolStripMenuItem.Visible = True
                End If


                If ds.Tables(0).Rows(0)("Pwr_Lbl").ToString() = "1" Then

                    If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Or productline = "SUPERPHOB" Then
                        PowerLabelPrintToolStripMenuItem.Visible = True
                    Else
                        PowerLabelPrintToolStripMenuItem.Visible = False
                    End If
                End If

                If ds.Tables(0).Rows(0)("inject_lbl").ToString() = "1" Then
                    If productline = "PHILIC" And station = "INJECTOR" Then
                        InjetLabelPrintToolStripMenuItem.Visible = True
                    Else
                        InjetLabelPrintToolStripMenuItem.Visible = False
                    End If
                End If


                If ds.Tables(0).Rows(0)("Ster").ToString() = "1" Then
                    SampleTestToolStripMenuItem.Visible = True
                    ToolStripMenuItem6.Visible = True
                    SterilizationRejectToolStripMenuItem.Visible = True
                    SampleTestTToolStripMenuItem.Visible = True
                    SterileToAreationMoveToolStripMenuItem.Visible = True

                    If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
                        SterilizationToolStripMenuItem.Visible = False
                        BeforeSterilizationToolStripMenuItem.Visible = True
                        AfterSterilizationScanToolStripMenuItem.Visible = False
                        AfterSterilizationToolStripMenuItem.Visible = True
                    Else
                        SterilizationToolStripMenuItem.Visible = True
                        BeforeSterilizationToolStripMenuItem.Visible = False
                        AfterSterilizationScanToolStripMenuItem.Visible = False
                        AfterSterilizationToolStripMenuItem.Visible = True
                    End If

                End If

                If ds.Tables(0).Rows(0)("MMS_Report_Ster").ToString() = "1" Then
                    MMSReportSterileToolStripMenuItem.Visible = True
                End If

                If IsNotBoxPackUser = 1 Then
                    BoxPackingToolStripMenuItem.Visible = False
                End If
                If ds.Tables(0).Rows(0)("lot_Detail").ToString() = "1" Then
                    LotDetailsToolStripMenuItem.Visible = True
                End If
                If ds.Tables(0).Rows(0)("Other_sample_scan").ToString() = "1" Then
                    OtherSampleScanToolStripMenuItem.Visible = True
                End If

            End If

            If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
                SterilizationToolStripMenuItem.Visible = False
                BeforeSterilizationToolStripMenuItem.Visible = True
                AfterSterilizationScanToolStripMenuItem.Visible = False
                AfterSterilizationToolStripMenuItem.Visible = True
            Else
                SterilizationToolStripMenuItem.Visible = True
                BeforeSterilizationToolStripMenuItem.Visible = False
                AfterSterilizationScanToolStripMenuItem.Visible = False
                AfterSterilizationToolStripMenuItem.Visible = True
            End If

            If productline = "PHILIC" And station = "INJECTOR" Then
            Else
                InjetLabelPrintToolStripMenuItem.Visible = False
            End If

            If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Or productline = "SUPERPHOB" Then
                MasterToolStripMenuItem.Visible = False
            Else
                PowerLabelPrintToolStripMenuItem.Visible = False
                StToolStripMenuItem.Visible = False
            End If

            If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Or productline = "SUPERPHOB" Or productline = "PHILIC" Then
                TurkeyGSCodeLabelToolStripMenuItem.Visible = False
            Else
                ToolStripMenuItem6.Visible = False
            End If


            If productline = "SUPERPHOB" Then
                OtherSampleScanToolStripMenuItem.Visible = False
                SampleTestToolStripMenuItem.Visible = False
                ToolStripMenuItem6.Visible = False
                SterilizationRejectToolStripMenuItem.Visible = False
                SampleTestTToolStripMenuItem.Visible = False
                SterilizationToolStripMenuItem.Visible = False
                BeforeSterilizationToolStripMenuItem.Visible = False
                AfterSterilizationScanToolStripMenuItem.Visible = False
                AfterSterilizationToolStripMenuItem.Visible = False
                ArToolStripMenuItem.Visible = False
                BoxPackingListToolStripMenuItem.Visible = False
                PackingReportReasonToolStripMenuItem.Visible = False
                BPLCollectionCancelToolStripMenuItem.Visible = False
                BoxInspectionToolStripMenuItem.Visible = False
                StToolStripMenuItem.Visible = False
                BPLReportToolStripMenuItem.Visible = False
                CollectionListReportToolStripMenuItem.Visible = False
                BPLDashboardToolStripMenuItem.Visible = False
                BoxPackingRecordToolStripMenuItem.Visible = False
                SterileCheckReportToolStripMenuItem.Visible = False
                LensTrackingReportToolStripMenuItem.Visible = False
                LotToolStripMenuItem.Visible = False
                LensTrackingBlanksBatchReportToolStripMenuItem.Visible = False
                StockVerificationToolStripMenuItem.Visible = False
                BPLDASHBOARDToolStripMenuItem1.Visible = False
                PRNReportToolStripMenuItem.Visible = False
                ToolStripMenuItem6.Visible = False
               
            End If


            If IsNotBoxPackUser = 1 Then
                BoxPackingToolStripMenuItem.Visible = False
            End If


            If productline = "SUPERPHOB" Then
                If ds.Tables(0).Rows(0)("Bx_Pking").ToString() = "1" Then
                    BoxPackingToolStripMenuItem.Visible = True
                End If
            End If


            StockVerificationToolStripMenuItem.Visible = False
            BPLDashboardToolStripMenuItem.Visible = False
            LotDetailsToolStripMenuItem.Visible = False
            'ToolStripMenuItem6.Visible = False

            ''In Testing--
            'BoxPackToolStripMenuItem.Visible = False
            'MTSReportToolStripMenuItem.Visible = False
            'PouchRaeportToolStripMenuItem.Visible = False
            'SampleReportToolStripMenuItem.Visible = False

            'If ds.Tables(0).Rows(0)("Sterlit").ToString() = "1" Then
            '    MasterToolStripMenuItem.Visible = False
            '    AministratorToolStripMenuItem.Visible = False
            '    ReportToolStripMenuItem.Visible = True
            '    PouchLabelPrintToolStripMenuItem.Visible = False
            '    PouchLabelReprintToolStripMenuItem.Visible = False
            '    PowerLabelPrintToolStripMenuItem.Visible = False
            '    InjetLabelPrintToolStripMenuItem.Visible = False


            '    BoxPackingListToolStripMenuItem.Visible = False
            '    BoxPackingToolStripMenuItem.Visible = False
            '    ToolStripMenuItem4.Visible = False

            '    SterilizationToolStripMenuItem.Visible = False
            '    SampleTestToolStripMenuItem.Visible = False
            '    SampleTestTToolStripMenuItem.Visible = False
            '    SterilizationRejectToolStripMenuItem.Visible = False


            '    BoxPackingToolToolStripMenuItem.Visible = False
            '    EgyptReprintToolStripMenuItem.Visible = False
            '    AreationTrayLabelToolStripMenuItem1.Visible = False
            '    StToolStripMenuItem.Visible = False
            '    PackingReportReasonToolStripMenuItem.Visible = False
            '    ArToolStripMenuItem.Visible = False
            '    StockVerificationToolStripMenuItem.Visible = False
            '    PRNReportToolStripMenuItem.Visible = True
            '    ProcessToolStripMenuItem.Visible = False
            '    BPLReportToolStripMenuItem.Visible = False
            '    CollectionListReportToolStripMenuItem.Visible = False
            '    CartonBoxEntryToolStripMenuItem.Visible = False
            '    ProcessStatusReportToolStripMenuItem.Visible = False
            '    BoxPackingReportToolStripMenuItem.Visible = False
            '    LotSheetReportToolStripMenuItem.Visible = False
            '    SterileCheckReportToolStripMenuItem.Visible = True
            '    BPLDashboardToolStripMenuItem.Visible = False
            '    BoxPackingRecordToolStripMenuItem.Visible = False
            '    InjectorToolStripMenuItem.Visible = False
            'End If



        End If

    End Sub

    Private Sub PouchLabelReprintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PouchLabelReprintToolStripMenuItem.Click
        If productline = "PMMA" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprint
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "PHILIC" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprintPhilic
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "PHOBIC" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprintPhobic
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprintPhobic
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "SUPERPHOB" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprintPhobic
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "TEST" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchReprint
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        End If


    End Sub

    Private Sub PouchLabelPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PouchLabelPrintToolStripMenuItem.Click
        If productline = "PMMA" Then
            Dim ChildOfMDIChildPouchLablePrint As New FrmNewPouchLablePrintPMMA
            ChildOfMDIChildPouchLablePrint.MdiParent = Me
            ChildOfMDIChildPouchLablePrint.Show()
        ElseIf productline = "PHILIC" Then
            Dim ChildOfMDIChildPouchLablePrint As New FrmNewPouchLablePrintPhilic
            ChildOfMDIChildPouchLablePrint.MdiParent = Me
            ChildOfMDIChildPouchLablePrint.Show()
        ElseIf productline = "PHOBIC" Then
            'Dim ChildOfMDIChildPouchLablePrint As New FrmNewPouchLablePrintPhobic
            Dim ChildOfMDIChildPouchLablePrint As New FrmPouchLabelPrint_Superphob
            ChildOfMDIChildPouchLablePrint.MdiParent = Me
            ChildOfMDIChildPouchLablePrint.Show()
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchLabelPrint_New
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "SUPERPHOB" Then
            'Dim ChildOfMDIChildNewPouchReprint As New FrmNewPouchLabelPrint_New
            Dim ChildOfMDIChildNewPouchReprint As New FrmPouchLabelPrint_Superphob
            ChildOfMDIChildNewPouchReprint.MdiParent = Me
            ChildOfMDIChildNewPouchReprint.Show()
        ElseIf productline = "TEST" Then
            Dim ChildOfMDIChildPouchLablePrint As New FrmNewPouchLablePrintPMMA
            ChildOfMDIChildPouchLablePrint.MdiParent = Me
            ChildOfMDIChildPouchLablePrint.Show()
        End If
        
    End Sub

    Private Sub PowerLabelPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerLabelPrintToolStripMenuItem.Click
        Dim ChildOfMDIChildPowerLabelPrint As New FrmPowerLabelPrint
        ChildOfMDIChildPowerLabelPrint.MdiParent = Me
        ChildOfMDIChildPowerLabelPrint.Show()

    End Sub

    Private Sub SterilizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterilizationToolStripMenuItem.Click
        If productline = "PMMA" Then
            Dim ChildOfMDIChildPowerLabelPrint As New frmBeforeSterilization_PMMA
            ChildOfMDIChildPowerLabelPrint.MdiParent = Me
            ChildOfMDIChildPowerLabelPrint.Show()
        Else
            Dim ChildOfMDIChildPowerLabelPrint As New frmBeforeSterilization
            ChildOfMDIChildPowerLabelPrint.MdiParent = Me
            ChildOfMDIChildPowerLabelPrint.Show()

        End If

        


    End Sub

    Private Sub SampleTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleTestToolStripMenuItem.Click
        Dim ChildOfMDIChildSterSample As New FrmNewSterSample
        ChildOfMDIChildSterSample.MdiParent = Me
        ChildOfMDIChildSterSample.Show()
    End Sub

    Private Sub BoxPackingListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingListToolStripMenuItem.Click
        Dim ChildOfMDIChildBPLGen As New FrmNewBPLGen
        ChildOfMDIChildBPLGen.MdiParent = Me
        ChildOfMDIChildBPLGen.Show()
    End Sub

    Private Sub BoxPackingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingToolStripMenuItem.Click
        If productline = "PMMA" Then
            Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingPMMA
            ChildOfMDIChildBoxPacking.MdiParent = Me
            ChildOfMDIChildBoxPacking.Show()
        ElseIf productline = "PHILIC" Then
            Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingPHILIC
            ChildOfMDIChildBoxPacking.MdiParent = Me
            ChildOfMDIChildBoxPacking.Show()
        ElseIf productline = "PHOBIC" Then
            Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingPHOBIC
            ChildOfMDIChildBoxPacking.MdiParent = Me
            ChildOfMDIChildBoxPacking.Show()
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingPHOBIC
            ChildOfMDIChildBoxPacking.MdiParent = Me
            ChildOfMDIChildBoxPacking.Show()
            'ElseIf productline = "GALAXYLENS" Then
            '    Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingPMMA
            '    ChildOfMDIChildBoxPacking.MdiParent = Me
            '    ChildOfMDIChildBoxPacking.Show()
        ElseIf productline = "SUPERPHOB" Then
            Dim ChildOfMDIChildBoxPacking As New FrmNewBoxPackingSUPERPHOB
            ChildOfMDIChildBoxPacking.MdiParent = Me
            ChildOfMDIChildBoxPacking.Show()
        End If
       
    End Sub

    Private Sub SampleTestTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleTestTToolStripMenuItem.Click
        Dim ChildOfMDIChildCtrlSample As New FrmNewCtrlSample
        ChildOfMDIChildCtrlSample.MdiParent = Me
        ChildOfMDIChildCtrlSample.Show()
    End Sub

    Private Sub UserCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserCreationToolStripMenuItem.Click
        Dim ChildOfMDIChildUserCreation As New FrmNewUserCreation
        ChildOfMDIChildUserCreation.MdiParent = Me
        ChildOfMDIChildUserCreation.Show()
    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim mainForm As New FrmMain()
        mainForm.Close()

        Dim loginForm As New LoginForm()
        loginForm.Show()

    End Sub

    Private Sub BPLReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPLReportToolStripMenuItem.Click
        Dim ChildOfMDIChildRptBPLView As New RptBPLView
        ChildOfMDIChildRptBPLView.MdiParent = Me
        ChildOfMDIChildRptBPLView.Show()
    End Sub

    Private Sub CollectionListReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectionListReportToolStripMenuItem.Click
        Dim ChildOfMDIChildNewrptCollection As New FrmNewRptCollection
        ChildOfMDIChildNewrptCollection.MdiParent = Me
        ChildOfMDIChildNewrptCollection.Show()
    End Sub

    Private Sub SterilizationRejectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterilizationRejectToolStripMenuItem.Click
        Dim reject As New FrmNewRejection
        reject.MdiParent = Me
        reject.Show()
    End Sub

    Private Sub BoxPackingToolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingToolToolStripMenuItem.Click
        Dim tool As New FrnNewGalaxyBoxPacking
        tool.MdiParent = Me
        tool.Show()
    End Sub

    Private Sub BTWMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTWMasterToolStripMenuItem.Click
        Dim btw As New frmBTWMaster
        btw.MdiParent = Me
        btw.Show()
    End Sub

    Private Sub StationMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationMasterToolStripMenuItem.Click
        Dim frm As New frmStationMaster
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Dim frm As New frmAerationStockStatus
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BoxPackingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingReportToolStripMenuItem.Click
        Dim frm As New frmBoxPackingReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EgyptReprintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EgyptReprintToolStripMenuItem.Click
        Dim frm As New FrnNewGalaxyBoxPacking_Egypt
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        'Dim frm As New frmSterilizationRelease
        Dim frm As New frmBatchRelease
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LotSheetReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotSheetReportToolStripMenuItem.Click
        Dim frm As New LotNoDataReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AreationTrayLabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmlotallotprint
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SterileCheckReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileCheckReportToolStripMenuItem.Click
        Dim frm As New Steriliereport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StToolStripMenuItem.Click
        Dim frm As New frmSterileBTupdate
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InjetLabelPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjetLabelPrintToolStripMenuItem.Click
        Dim frm As New FrmNewInjectLabel
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PackingReportReasonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingReportReasonToolStripMenuItem.Click
        Dim frm As New Reason_Dashboard
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TurkeyGSCodeLabelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurkeyGSCodeLabelToolStripMenuItem.Click
        'pandian sir instruction commanded seprate label print  option other than exe
        'Dim frm As New FrmTurkeyGS1Label
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub TrayMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayMovementToolStripMenuItem.Click
        Dim frm As New FrmTrayChange
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BPLCollectionCancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPLCollectionCancelToolStripMenuItem.Click
        Dim frm As New BPL_Cancellation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ScanSerialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanSerialToolStripMenuItem.Click
        Dim frm As New FrmNewStockValidation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RackMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RackMovementToolStripMenuItem.Click
        Dim frm As New FrmRackChange
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TrayLabelReprintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayLabelReprintToolStripMenuItem.Click
        Dim frm As New FrmTrayLabelReprint
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim frm As New frmSterileRepack
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BPLDashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPLDashboardToolStripMenuItem.Click
        Dim frm As New BPL_Dashboard
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CheckPendingLotsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckPendingLotsToolStripMenuItem.Click
        Dim frm As New FrmCheckPendingLotsToScan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AreationTrayLabelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreationTrayLabelToolStripMenuItem1.Click
        Dim frm As New frmlotallotprint
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BoxInspectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxInspectionToolStripMenuItem.Click
        Dim frm As New frmBoxInspection
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BoxPackingRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingRecordToolStripMenuItem.Click
        Dim frm As New FrmBoxPackingRecord
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub BoxOutwardFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxOutwardFormToolStripMenuItem.Click

        Dim frm As New frmBoxOutward
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        Dim frm As New frmSterileComple
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PRNReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRNReportToolStripMenuItem.Click
        If productline = "PMMA" Then
            Dim frm As New FrmPRN_Report_PMMA
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHILIC" Then
            Dim frm As New FrmPRN_Report_PHILIC
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHOBIC" Then
            Dim frm As New FrmPRN_Report_PHOBIC
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            Dim frm As New FrmPRN_Report_PHOBIC
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub


    Private Sub InjectorReceiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorReceiveToolStripMenuItem.Click
        Dim frm As New FrmInjectorStockReceive
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InjectorInspectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorInspectionToolStripMenuItem.Click
        Dim frm As New FrmInjectorInspection
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InjectorSampleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorSampleToolStripMenuItem.Click
        Dim frm As New FrmInjectorSample
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InjectorStockMovementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorStockMovementToolStripMenuItem.Click
        Dim frm As New FrmInjector_Movement
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub InjeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjeToolStripMenuItem.Click
        Dim frm As New injectorreportform
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LotDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotDetailsToolStripMenuItem.Click
        Dim frm As New FrmLotdetailsReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OtherSampleScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherSampleScanToolStripMenuItem.Click
        Dim frm As New frmSampleScan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SterilizationAfterScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frm As New FrmSterilization_After_Scan
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AreationScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreationScanToolStripMenuItem.Click


        If productline = "PMMA" Then
            Dim frm As New FrmSterilization_After_Scan_PMMA
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHILIC" Then
            Dim frm As New FrmSterilization_After_Scan
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHOBIC" Then
            Dim frm As New FrmSterilization_After_Scan_PMMA
            frm.MdiParent = Me
            frm.Show()
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            Dim frm As New FrmSterilization_After_Scan_PMMA
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub LensTrackingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LensTrackingReportToolStripMenuItem.Click
        Dim frm As New FrmReportLensTracking
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AreationTrayLabelReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreationTrayLabelReToolStripMenuItem.Click
        Dim frm As New frmTray_label_Reprint
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TraySampleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraySampleToolStripMenuItem.Click
        Dim frm As New frmNewTrayGenerationForm
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RackLabelStaticToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RackLabelStaticToolStripMenuItem.Click
        Dim frm As New FrmRackLabelPrint
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessToolStripMenuItem.Click

    End Sub

    Private Sub AfterSterilizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfterSterilizationToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmNewSterilization
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub RackLocationReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RackLocationReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmRackLocationDetails
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BPLDASHBOARDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPLDASHBOARDToolStripMenuItem1.Click

        Dim ChildOfMDIChildSterilization As New frmNewBPL_Dashboard
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.FormBorderStyle = FormBorderStyle.None
        ChildOfMDIChildSterilization.Dock = DockStyle.Fill
        ChildOfMDIChildSterilization.Show()

      
    End Sub

    Private Sub LotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmLotWiseTrackingReport
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub LensTrackingBlanksBatchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LensTrackingBlanksBatchReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New LensTracking
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub SterileToAreationMoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileToAreationMoveToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New frmSterileMTS_report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub SterileMTSReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ChildOfMDIChildSterilization As New frmSterileMTSReport_Reprint
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub BeforeSterilizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeforeSterilizationToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New frmBeforeSterilization_New1
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub AfterSterilizationScanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AfterSterilizationScanToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New frmSterilizationAfter_Scan
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub SterileMachineReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileMachineReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmSterileMachineReport
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BoxRejectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxRejectionToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmMTS_Report_Box_Reject
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub


    Private Sub BoxPackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmBoxPack_MTS_Report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BoxPackingMMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingMMSToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmBoxPack_MTS_Report_View
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub


    Private Sub SampleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SampleReportToolStripMenuItem.Click
        Dim frm As New cstreportform
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PouchReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PouchRaeportToolStripMenuItem.Click
        Dim frm As New pouchreportform
        frm.MdiParent = Me
        frm.Show()
    End Sub

  
    Private Sub SterileToAreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileToAreationToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmSterileMTSReport_Reprint
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub SterileRejectionMMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileRejectionMMSToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmMTS_Report_Sterile_Reject
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub AssetLabelPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssetLabelPrintToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmAssetId_LabelPrint
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BoxPackingReprintReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackingReprintReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmBoxPackingReprintReport
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub ShrinkWarpRejectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShrinkWarpRejectionToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmShrinkWarpReject
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub ShrinkWarpRejectionMMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShrinkWarpRejectionMMSToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmShrinkWarp_Rejection_MMS_Report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub InjectorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorToolStripMenuItem1.Click

        Dim ChildOfMDIChildSterilization As New frmMTS_Injector_Report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub InjectorRejectionMMSReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorRejectionMMSReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmInjectorRjectionMTS_Report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub PocuhPackToSterileMoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PocuhPackToSterileMoveToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmPouch_MMS_Report
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub MMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New frmPouchMMS_Report_RePrint
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub SterileToQualityMoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SterileToQualityMoveToolStripMenuItem.Click
        
    End Sub

    Private Sub OverallWIPPouchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverallWIPPouchToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New overall_stock
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub InjectorToSterileMoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorToSterileMoveToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New Frminjectot_to_sterile
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub InjectorSterileToAerationMoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectorSterileToAerationMoveToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New Frminjector_steriletoaereationmove
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub QCToSterileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCToSterileToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmsterilemms
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub QCToBoxPackingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QCToBoxPackingToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmQC_To_boxPacking
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BoxPackinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxPackinToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmBoxPacking_To_QC
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub MTSReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTSReportToolStripMenuItem.Click

    End Sub

   

    Private Sub TrayAllotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayAllotToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmNewTrayAllot
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub TrayAllotMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayAllotMasterToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New FrmReport_tray_Allot_Master
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub


 


     

     

    Private Sub LensReserveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LensReserveToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmLensReservation
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub EnquiryToOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryToOrderToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New frmEnquiry_to_order_reserve
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub ReservedOrderToBPLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservedOrderToBPLToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New FrmOverReserve_to_BPL
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub FGTNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FGTNToolStripMenuItem.Click

        Dim ChildOfMDIChildSterilization As New FrmCreateFGTNforBPL
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()

    End Sub

    Private Sub FGTNReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FGTNReportToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmFGTNReport
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BIDateUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIDateUpdateToolStripMenuItem.Click
        Dim ChildOfMDIChildSterilization As New frmBIComplete
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub BatchReleaseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchReleaseToolStripMenuItem1.Click
        Dim ChildOfMDIChildSterilization As New frmBatchRelease2
        ChildOfMDIChildSterilization.MdiParent = Me
        ChildOfMDIChildSterilization.Show()
    End Sub

    Private Sub FrmMain_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        AttachEventHandlersToForms()

    End Sub
End Class