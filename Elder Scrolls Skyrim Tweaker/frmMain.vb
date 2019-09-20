Imports IniFile

Public Class frmMain
    Dim myIniFile As xIniFile
    Dim CurrentSection As String = ""
    Dim FromSection As String = ""

    Private Sub frmMain_Load(sender As Object,
                             e As EventArgs) _
        Handles MyBase.Load
        Try


            If My.Settings.WindowHeight > 0 Then Me.Height = My.Settings.WindowHeight

            If My.Settings.WindowWidth > 0 Then Me.Width = My.Settings.WindowWidth

            If _
                My.Computer.FileSystem.FileExists(addTrailingSlash(My.Application.Info.DirectoryPath) & "\inifile.dll") =
                False Then
                MsgBox(
                    "ini file Manipulation Library is Missing, inifile.dll must be on the same directory as the Elder Scrolls V : Skyrim Tweaker Main executable, Press Ok to Shutdown the application",
                    vbCritical)
                Me.Close()
            End If

            GetSkyrimSettingsDir()

            doreadingstuff()
            cmbinifilename.SelectedIndex = 0
            Me.Text = "Elder Scrolls V : Skyrim Tweaker v" & My.Application.Info.Version.ToString & " [" &
                      SkyrimUserFolder & "]"
        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub doreadingstuff()

        Try

            If SkyrimUserFolder <> "" Then
                Me.Text = "Elder Scrolls V : Skyrim Tweaker v" & My.Application.Info.Version.ToString & " [" &
                          SkyrimUserFolder & "]"

                Dim SkyrimPerfIni As New ZIniFile(addTrailingSlash(SkyrimUserFolder) & "SkyrimPrefs.ini")
                iTexMipMapSkip.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapSkip", "")
                bFXAAEnabled.Text = SkyrimPerfIni.GetString("Display", "bFXAAEnabled", "")
                fMeshLODLevel2FadeDist.Text = SkyrimPerfIni.GetString("Display", "fMeshLODLevel2FadeDist", "")
                fMeshLODLevel1FadeDist.Text = SkyrimPerfIni.GetString("Display", "fMeshLODLevel1FadeDist", "")
                fSpecularLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fSpecularLODStartFade", "")
                fLightLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fLightLODStartFade", "")
                fTreesMidLODSwitchDist.Text = SkyrimPerfIni.GetString("Display", "fTreesMidLODSwitchDist", "")
                iShadowMapResolution.Text = SkyrimPerfIni.GetString("Display", "iShadowMapResolution", "")
                fShadowBiasScale.Text = SkyrimPerfIni.GetString("Display", "fShadowBiasScale", "")
                iShadowMaskQuarter.Text = SkyrimPerfIni.GetString("Display", "iShadowMaskQuarter", "")
                iBlurDeferredShadowMask.Text = SkyrimPerfIni.GetString("Display", "iBlurDeferredShadowMask", "")
                fShadowDistance.Text = SkyrimPerfIni.GetString("Display", "fShadowDistance", "")
                iMaxDecalsPerFrame.Text = SkyrimPerfIni.GetString("Display", "iMaxDecalsPerFrame", "")
                iMaxSkinDecalsPerFrame.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapSkip", "")
                iAdapter.Text = SkyrimPerfIni.GetString("Display", "iAdapter", "")
                iSizeW.Text = SkyrimPerfIni.GetString("Display", "iSize W", "")
                iSizeH.Text = SkyrimPerfIni.GetString("Display", "iSize H", "")
                iMultiSample.Text = SkyrimPerfIni.GetString("Display", "iMultiSample", "")
                iMaxAnisotropy.Text = SkyrimPerfIni.GetString("Display", "iMaxAnisotropy", "")
                iPresentInterval.Text = SkyrimPerfIni.GetString("Display", "iPresentInterval", "")
                bFullScreen.Text = SkyrimPerfIni.GetString("Display", "bFull Screen", "")
                sD3DDevice.Text = SkyrimPerfIni.GetString("Display", "sD3DDevice", "")
                fInteriorShadowDistance.Text = SkyrimPerfIni.GetString("Display", "fInteriorShadowDistance", "")
                bFloatPointRenderTarget.Text = SkyrimPerfIni.GetString("Display", "bFloatPointRenderTarget", "")
                fGamma.Text = SkyrimPerfIni.GetString("Display", "fGamma", "")
                iShadowFilter.Text = SkyrimPerfIni.GetString("Display", "iShadowFilter", "")
                fDecalLOD2.Text = SkyrimPerfIni.GetString("Display", "fDecalLOD2", "")
                fDecalLOD1.Text = SkyrimPerfIni.GetString("Display", "fDecalLOD1", "")
                fShadowLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fShadowLODStartFade", "")
                iTexMipMapMinimum.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapMinimum", "")
                bTransparencyMultisampling.Text = SkyrimPerfIni.GetString("Display", "bTransparencyMultisampling", "")
                iWaterMultiSamples.Text = SkyrimPerfIni.GetString("Display", "iWaterMultiSamples", "")
                iShadowMode.Text = SkyrimPerfIni.GetString("Display", "iShadowMode", "")
                bTreesReceiveShadows.Text = SkyrimPerfIni.GetString("Display", "bTreesReceiveShadows", "")
                bDrawLandShadows.Text = SkyrimPerfIni.GetString("Display", "bDrawLandShadows", "")
                bDrawShadows.Text = SkyrimPerfIni.GetString("Display", "bDrawShadows", "")
                fLeafAnimDampenDistEnd.Text = SkyrimPerfIni.GetString("Display", "fLeafAnimDampenDistEnd", "")
                fLeafAnimDampenDistStart.Text = SkyrimPerfIni.GetString("Display", "fLeafAnimDampenDistStart", "")
                fMeshLODFadePercentDefault.Text = SkyrimPerfIni.GetString("Display", "fMeshLODFadePercentDefault", "")
                fMeshLODFadeBoundDefault.Text = SkyrimPerfIni.GetString("Display", "fMeshLODFadeBoundDefault", "")
                fMeshLODLevel2FadeTreeDistance.Text = SkyrimPerfIni.GetString("Display",
                                                                              "fMeshLODLevel2FadeTreeDistance", "")
                fMeshLODLevel1FadeTreeDistance.Text = SkyrimPerfIni.GetString("Display",
                                                                              "fMeshLODLevel1FadeTreeDistance", "")
                iScreenShotIndex.Text = SkyrimPerfIni.GetString("Display", "iScreenShotIndex", "")
                bShadowMaskZPrepass.Text = SkyrimPerfIni.GetString("Display", "bShadowMaskZPrepass", "")
                bMainZPrepass.Text = SkyrimPerfIni.GetString("Display", "bMainZPrepass", "")
                '---------------------------------------------------------------------------
                fLODFadeOutMultActors.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultActors", "")
                fLODFadeOutMultItems.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultItems", "")
                fLODFadeOutMultObjects.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultObjects", "")
                fLODFadeOutMultSkyCell.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultSkyCell", "")
                '---------------------------------------------------------------------------
                bRenderSkinnedTrees.Text = SkyrimPerfIni.GetString("Trees", "bRenderSkinnedTrees", "")
                uiMaxSkinnedTreesToRender.Text = SkyrimPerfIni.GetString("Trees", "uiMaxSkinnedTreesToRender", "")
                '---------------------------------------------------------------------------
                fGrassStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassStartFadeDistance", "")
                b30GrassVS.Text = SkyrimPerfIni.GetString("Grass", "b30GrassVS", "")
                fGrassMaxStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassMaxStartFadeDistance", "")
                fGrassMinStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassMinStartFadeDistance", "")
                '---------------------------------------------------------------------------
                bDecals.Text = SkyrimPerfIni.GetString("Decals", "bDecals", "")
                bSkinnedDecals.Text = SkyrimPerfIni.GetString("Decals", "bSkinnedDecals", "")
                uMaxDecals.Text = SkyrimPerfIni.GetString("Decals", "uMaxDecals", "")
                uMaxSkinDecals.Text = SkyrimPerfIni.GetString("Decals", "uMaxSkinDecals", "")
                uMaxSkinDecalsPerActor.Text = SkyrimPerfIni.GetString("Decals", "uMaxSkinDecalsPerActor", "")
                '---------------------------------------------------------------------------
                fTreeLoadDistance.Text = SkyrimPerfIni.GetString("TerrainManager", "fTreeLoadDistance", "")
                fBlockMaximumDistance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockMaximumDistance", "")
                fBlockLevel1Distance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockLevel1Distance", "")
                fBlockLevel0Distance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockLevel0Distance", "")
                fSplitDistanceMult.Text = SkyrimPerfIni.GetString("TerrainManager", "fSplitDistanceMult", "")
                bShowLODInEditor.Text = SkyrimPerfIni.GetString("TerrainManager", "bShowLODInEditor", "")
                '---------------------------------------------------------------------------
                iWaterReflectHeight.Text = SkyrimPerfIni.GetString("Water", "iWaterReflectHeight", "")
                iWaterReflectWidth.Text = SkyrimPerfIni.GetString("Water", "iWaterReflectWidth", "")
                bUseWaterDisplacements.Text = SkyrimPerfIni.GetString("Water", "bUseWaterDisplacements", "")
                bUseWaterRefractions.Text = SkyrimPerfIni.GetString("Water", "bUseWaterRefractions", "")
                bUseWaterReflections.Text = SkyrimPerfIni.GetString("Water", "bUseWaterReflections", "")
                bUseWaterDepth.Text = SkyrimPerfIni.GetString("Water", "bUseWaterDepth", "")

                Dim SkyrimIni As New ZIniFile(addTrailingSlash(SkyrimUserFolder) & "Skyrim.ini")
                bReflectLODObjects.Text = SkyrimIni.GetString("Water", "bReflectLODObjects", "")
                bReflectLODLand.Text = SkyrimIni.GetString("Water", "bReflectLODLand", "")
                bReflectSky.Text = SkyrimIni.GetString("Water", "bReflectSky", "")
                bReflectLODTrees.Text = SkyrimIni.GetString("Water", "bReflectLODTrees", "")
                '---------------------------------------------------------------------------
                fCloudLevel2Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel2Distance", "")
                fCloudLevel1Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel1Distance", "")
                fCloudLevel0Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel0Distance", "")
                fCloudNearFadeDistance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudNearFadeDistance", "")
                '---------------------------------------------------------------------------
                iRadialBlurLevel.Text = SkyrimPerfIni.GetString("Imagespace", "iRadialBlurLevel", "")
                bDoDepthOfField.Text = SkyrimPerfIni.GetString("Imagespace", "bDoDepthOfField", "")
                '---------------------------------------------------------------------------
                bDoHighDynamicRange.Text = SkyrimPerfIni.GetString("BlurShaderHDR", "bDoHighDynamicRange", "")
                '---------------------------------------------------------------------------
                bUseBlurShader.Text = SkyrimPerfIni.GetString("BlurShader", "bUseBlurShader", "")

            Else
                Me.Text = "Elder Scrolls V : Skyrim Tweaker v" & My.Application.Info.Version.ToString & " [" &
                          "Could Not Locate the Skyrim Settings Folder" & "]"
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object,
                               e As EventArgs) _
        Handles btnReset.Click

        If SkyrimUserFolder <> "" Then

            Dim button As New DialogResult
            button =
                MessageBox.Show(
                    "Pressing Yes will Reload all the settings, You will loose any unsaved Changes! Continue ?",
                    "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then

                doreadingstuff()
            End If

        Else
            GetSkyrimSettingsDir()

            If SkyrimUserFolder <> "" Then

                doreadingstuff()
            End If

        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object,
                              e As EventArgs) _
        Handles btnPlay.Click

        Try

            If My.Settings.SkyrimMainexe <> "" Then
                Process.Start(My.Settings.SkyrimMainexe)

            ElseIf _
                My.Computer.FileSystem.FileExists(addTrailingSlash(My.Application.Info.DirectoryPath) & "\TESV.exe") =
                True Then
                My.Settings.SkyrimMainexe = addTrailingSlash(My.Application.Info.DirectoryPath) & "\TESV.exe"
                My.Settings.SkyrimLauncher = addTrailingSlash(My.Application.Info.DirectoryPath) & "\SkyrimLauncher.exe"
                My.Settings.Save()
                Process.Start(My.Settings.SkyrimMainexe)

            Else

                Dim SkyrimInsLocater As New FolderBrowserDialog
                With SkyrimInsLocater
                    .RootFolder = Environment.SpecialFolder.Desktop
                    .Description =
                        "Please Select the Skyrim Installation Directory, This is only a one time process, Skyrim Tweaker will Remeber This Setting"

                    If .ShowDialog = DialogResult.OK Then

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(.SelectedPath) & "TESV.exe") = True Then
                            My.Settings.SkyrimMainexe = addTrailingSlash(.SelectedPath & "\TESV.exe")
                            My.Settings.SkyrimLauncher = addTrailingSlash(.SelectedPath & "\SkyrimLauncher.exe")
                            My.Settings.Save()
                            Process.Start(My.Settings.SkyrimMainexe)

                        Else
                            MsgBox(
                                "Selected folder Doesn't Appear to be the Skyrim Installation Directory, Please select the correct Location!",
                                vbInformation)
                            My.Settings.SkyrimMainexe = ""
                            My.Settings.SkyrimLauncher = ""
                            Exit Sub
                        End If

                    End If

                End With
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnLaunch_Click(sender As Object,
                                e As EventArgs) _
        Handles btnLaunch.Click

        Try

            If My.Settings.SkyrimLauncher <> "" Then
                Process.Start(My.Settings.SkyrimLauncher)

            ElseIf _
                My.Computer.FileSystem.FileExists(
                    addTrailingSlash(My.Application.Info.DirectoryPath) & "\SkyrimLauncher.exe") = True Then
                My.Settings.SkyrimMainexe = addTrailingSlash(My.Application.Info.DirectoryPath) & "\TESV.exe"
                My.Settings.SkyrimLauncher = addTrailingSlash(My.Application.Info.DirectoryPath) & "\SkyrimLauncher.exe"
                My.Settings.Save()
                Process.Start(My.Settings.SkyrimLauncher)

            Else

                Dim SkyrimInsLocater As New FolderBrowserDialog
                With SkyrimInsLocater
                    .RootFolder = Environment.SpecialFolder.Desktop
                    .Description =
                        "Please Select the Skyrim Installation Directory, This is only a one time process, Skyrim Tweaker will Remeber This Setting"

                    If .ShowDialog = DialogResult.OK Then

                        If _
                            My.Computer.FileSystem.FileExists(addTrailingSlash(.SelectedPath) & "SkyrimLauncher.exe") =
                            True Then
                            My.Settings.SkyrimMainexe = addTrailingSlash(.SelectedPath & "\TESV.exe")
                            My.Settings.SkyrimLauncher = addTrailingSlash(.SelectedPath & "\SkyrimLauncher.exe")
                            My.Settings.Save()
                            Process.Start(My.Settings.SkyrimLauncher)

                        Else
                            MsgBox(
                                "Selected folder Doesn't Appear to be the Skyrim Installation Directory, Please select the correct Location!",
                                vbInformation)
                            My.Settings.SkyrimMainexe = ""
                            My.Settings.SkyrimLauncher = ""
                            Exit Sub
                        End If

                    End If

                End With
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnResetGame_Click(sender As Object,
                                   e As EventArgs) _
        Handles btnResetGame.Click

        Dim button As New DialogResult
        button =
            MessageBox.Show(
                "Pressing Yes will Clear the Game Installation Location settings, This will allow you to select a new location. Continue ?",
                "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If button = DialogResult.Yes Then
            My.Settings.Reset()
        End If
    End Sub

    Private Sub btnHelp_Click(sender As Object,
                              e As EventArgs) _
        Handles btnHelp.Click
        frmHelp.ShowDialog(Me)
    End Sub

    Private Sub btnAccept_Click(sender As Object,
                                e As EventArgs) _
        Handles btnAccept.Click

        Try

            If SkyrimUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Are you sure you want to Commit all the Changes?", "Are You Sure?",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button1)

                If button = DialogResult.Yes Then

                    Dim SkyrimPerfIni As New ZIniFile(addTrailingSlash(SkyrimUserFolder) & "SkyrimPrefs.ini")
                    SkyrimPerfIni.WriteString("Display", "iTexMipMapSkip", iTexMipMapSkip.Text)
                    SkyrimPerfIni.WriteString("Display", "bFXAAEnabled", bFXAAEnabled.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODLevel2FadeDist", fMeshLODLevel2FadeDist.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODLevel1FadeDist", fMeshLODLevel1FadeDist.Text)
                    SkyrimPerfIni.WriteString("Display", "fSpecularLODStartFade", fSpecularLODStartFade.Text)
                    SkyrimPerfIni.WriteString("Display", "fLightLODStartFade", fLightLODStartFade.Text)
                    SkyrimPerfIni.WriteString("Display", "fTreesMidLODSwitchDist", fTreesMidLODSwitchDist.Text)
                    SkyrimPerfIni.WriteString("Display", "iShadowMapResolution", iShadowMapResolution.Text)
                    SkyrimPerfIni.WriteString("Display", "fShadowBiasScale", fShadowBiasScale.Text)
                    SkyrimPerfIni.WriteString("Display", "iShadowMaskQuarter", iShadowMaskQuarter.Text)
                    SkyrimPerfIni.WriteString("Display", "iBlurDeferredShadowMask", iBlurDeferredShadowMask.Text)
                    SkyrimPerfIni.WriteString("Display", "fShadowDistance", fShadowDistance.Text)
                    SkyrimPerfIni.WriteString("Display", "iMaxDecalsPerFrame", iMaxDecalsPerFrame.Text)
                    SkyrimPerfIni.WriteString("Display", "iTexMipMapSkip", iMaxSkinDecalsPerFrame.Text)
                    SkyrimPerfIni.WriteString("Display", "iAdapter", iAdapter.Text)
                    SkyrimPerfIni.WriteString("Display", "iSize W", iSizeW.Text)
                    SkyrimPerfIni.WriteString("Display", "iSize H", iSizeH.Text)
                    SkyrimPerfIni.WriteString("Display", "iMultiSample", iMultiSample.Text)
                    SkyrimPerfIni.WriteString("Display", "iMaxAnisotropy", iMaxAnisotropy.Text)
                    SkyrimPerfIni.WriteString("Display", "iPresentInterval", iPresentInterval.Text)
                    SkyrimPerfIni.WriteString("Display", "bFull Screen", bFullScreen.Text)
                    SkyrimPerfIni.WriteString("Display", "sD3DDevice", sD3DDevice.Text)
                    SkyrimPerfIni.WriteString("Display", "fInteriorShadowDistance", fInteriorShadowDistance.Text)
                    SkyrimPerfIni.WriteString("Display", "bFloatPointRenderTarget", bFloatPointRenderTarget.Text)
                    SkyrimPerfIni.WriteString("Display", "fGamma", fGamma.Text)
                    SkyrimPerfIni.WriteString("Display", "iShadowFilter", iShadowFilter.Text)
                    SkyrimPerfIni.WriteString("Display", "fDecalLOD2", fDecalLOD2.Text)
                    SkyrimPerfIni.WriteString("Display", "fDecalLOD1", fDecalLOD1.Text)
                    SkyrimPerfIni.WriteString("Display", "fShadowLODStartFade", fShadowLODStartFade.Text)
                    SkyrimPerfIni.WriteString("Display", "iTexMipMapMinimum", iTexMipMapMinimum.Text)
                    SkyrimPerfIni.WriteString("Display", "bTransparencyMultisampling", bTransparencyMultisampling.Text)
                    SkyrimPerfIni.WriteString("Display", "iWaterMultiSamples", iWaterMultiSamples.Text)
                    SkyrimPerfIni.WriteString("Display", "iShadowMode", iShadowMode.Text)
                    SkyrimPerfIni.WriteString("Display", "bTreesReceiveShadows", bTreesReceiveShadows.Text)
                    SkyrimPerfIni.WriteString("Display", "bDrawLandShadows", bDrawLandShadows.Text)
                    SkyrimPerfIni.WriteString("Display", "bDrawShadows", bDrawShadows.Text)
                    SkyrimPerfIni.WriteString("Display", "fLeafAnimDampenDistEnd", fLeafAnimDampenDistEnd.Text)
                    SkyrimPerfIni.WriteString("Display", "fLeafAnimDampenDistStart", fLeafAnimDampenDistStart.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODFadePercentDefault", fMeshLODFadePercentDefault.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODFadeBoundDefault", fMeshLODFadeBoundDefault.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODLevel2FadeTreeDistance",
                                              fMeshLODLevel2FadeTreeDistance.Text)
                    SkyrimPerfIni.WriteString("Display", "fMeshLODLevel1FadeTreeDistance",
                                              fMeshLODLevel1FadeTreeDistance.Text)
                    SkyrimPerfIni.WriteString("Display", "iScreenShotIndex", iScreenShotIndex.Text)
                    SkyrimPerfIni.WriteString("Display", "bShadowMaskZPrepass", bShadowMaskZPrepass.Text)
                    SkyrimPerfIni.WriteString("Display", "bMainZPrepass", bMainZPrepass.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultActors", fLODFadeOutMultActors.Text)
                    SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultItems", fLODFadeOutMultItems.Text)
                    SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultObjects", fLODFadeOutMultObjects.Text)
                    SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultSkyCell", fLODFadeOutMultSkyCell.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Trees", "bRenderSkinnedTrees", bRenderSkinnedTrees.Text)
                    SkyrimPerfIni.WriteString("Trees", "uiMaxSkinnedTreesToRender", uiMaxSkinnedTreesToRender.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Grass", "fGrassStartFadeDistance", fGrassStartFadeDistance.Text)
                    SkyrimPerfIni.WriteString("Grass", "b30GrassVS", b30GrassVS.Text)
                    SkyrimPerfIni.WriteString("Grass", "fGrassMaxStartFadeDistance", fGrassMaxStartFadeDistance.Text)
                    SkyrimPerfIni.WriteString("Grass", "fGrassMinStartFadeDistance", fGrassMinStartFadeDistance.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Decals", "bDecals", bDecals.Text)
                    SkyrimPerfIni.WriteString("Decals", "bSkinnedDecals", bSkinnedDecals.Text)
                    SkyrimPerfIni.WriteString("Decals", "uMaxDecals", uMaxDecals.Text)
                    SkyrimPerfIni.WriteString("Decals", "uMaxSkinDecals", uMaxSkinDecals.Text)
                    SkyrimPerfIni.WriteString("Decals", "uMaxSkinDecalsPerActor", uMaxSkinDecalsPerActor.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("TerrainManager", "fTreeLoadDistance", fTreeLoadDistance.Text)
                    SkyrimPerfIni.WriteString("TerrainManager", "fBlockMaximumDistance", fBlockMaximumDistance.Text)
                    SkyrimPerfIni.WriteString("TerrainManager", "fBlockLevel1Distance", fBlockLevel1Distance.Text)
                    SkyrimPerfIni.WriteString("TerrainManager", "fBlockLevel0Distance", fBlockLevel0Distance.Text)
                    SkyrimPerfIni.WriteString("TerrainManager", "fSplitDistanceMult", fSplitDistanceMult.Text)
                    SkyrimPerfIni.WriteString("TerrainManager", "bShowLODInEditor", bShowLODInEditor.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Water", "iWaterReflectHeight", iWaterReflectHeight.Text)
                    SkyrimPerfIni.WriteString("Water", "iWaterReflectWidth", iWaterReflectWidth.Text)
                    SkyrimPerfIni.WriteString("Water", "bUseWaterDisplacements", bUseWaterDisplacements.Text)
                    SkyrimPerfIni.WriteString("Water", "bUseWaterRefractions", bUseWaterRefractions.Text)
                    SkyrimPerfIni.WriteString("Water", "bUseWaterReflections", bUseWaterReflections.Text)
                    SkyrimPerfIni.WriteString("Water", "bUseWaterDepth", bUseWaterDepth.Text)

                    Dim SkyrimIni As New ZIniFile(addTrailingSlash(SkyrimUserFolder) & "Skyrim.ini")
                    SkyrimIni.WriteString("Water", "bReflectLODObjects", bReflectLODObjects.Text)
                    SkyrimIni.WriteString("Water", "bReflectLODLand", bReflectLODLand.Text)
                    SkyrimIni.WriteString("Water", "bReflectSky", bReflectSky.Text)
                    SkyrimIni.WriteString("Water", "bReflectLODTrees", bReflectLODTrees.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Clouds", "fCloudLevel2Distance", fCloudLevel2Distance.Text)
                    SkyrimPerfIni.WriteString("Clouds", "fCloudLevel1Distance", fCloudLevel1Distance.Text)
                    SkyrimPerfIni.WriteString("Clouds", "fCloudLevel0Distance", fCloudLevel0Distance.Text)
                    SkyrimPerfIni.WriteString("Clouds", "fCloudNearFadeDistance", fCloudNearFadeDistance.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("Imagespace", "iRadialBlurLevel", iRadialBlurLevel.Text)
                    SkyrimPerfIni.WriteString("Imagespace", "bDoDepthOfField", bDoDepthOfField.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("BlurShaderHDR", "bDoHighDynamicRange", bDoHighDynamicRange.Text)
                    '---------------------------------------------------------------------------
                    SkyrimPerfIni.WriteString("BlurShader", "bUseBlurShader", bUseBlurShader.Text)
                End If

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object,
                                                 e As EventArgs) _
        Handles TabControl1.SelectedIndexChanged

        'Try

        '    Select Case Me.TabControl1.SelectedIndex

        '        Case 0
        '            If Me.Height > 600 Then Me.Height = Me.Height Else Me.Height = 600

        '        Case 1
        '            Me.Height = 313

        '        Case 2
        '            Me.Height = 313

        '        Case 3
        '            Me.Height = 313

        '        Case 4
        '            Me.Height = 345

        '        Case 5
        '            Me.Height = 366

        '        Case 6
        '            Me.Height = 476

        '        Case 7
        '            Me.Height = 313

        '        Case 8
        '            Me.Height = 313

        '        Case 9
        '            If Me.Height > 600 Then Me.Height = Me.Height Else Me.Height = 600
        '    End Select

        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub fShadowDistance_KeyPress(sender As Object,
                                         e As KeyPressEventArgs) _
        Handles iTexMipMapSkip.KeyPress, iSizeW.KeyPress, iSizeH.KeyPress, iShadowMaskQuarter.KeyPress,
                iShadowMapResolution.KeyPress, iPresentInterval.KeyPress, iMultiSample.KeyPress,
                iMaxSkinDecalsPerFrame.KeyPress, iMaxDecalsPerFrame.KeyPress, iMaxAnisotropy.KeyPress,
                iBlurDeferredShadowMask.KeyPress, iAdapter.KeyPress, fTreesMidLODSwitchDist.KeyPress,
                fSpecularLODStartFade.KeyPress, fShadowDistance.KeyPress, fShadowBiasScale.KeyPress,
                fMeshLODLevel2FadeDist.KeyPress, fMeshLODLevel1FadeDist.KeyPress, fLightLODStartFade.KeyPress,
                bFXAAEnabled.KeyPress, bFullScreen.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub fInteriorShadowDistance_KeyPress(sender As Object,
                                                 e As KeyPressEventArgs) _
        Handles iWaterMultiSamples.KeyPress, iTexMipMapMinimum.KeyPress, iShadowMode.KeyPress, iShadowFilter.KeyPress,
                iScreenShotIndex.KeyPress, fShadowLODStartFade.KeyPress, fMeshLODLevel2FadeTreeDistance.KeyPress,
                fMeshLODLevel1FadeTreeDistance.KeyPress, fMeshLODFadePercentDefault.KeyPress,
                fMeshLODFadeBoundDefault.KeyPress, fLeafAnimDampenDistStart.KeyPress, fLeafAnimDampenDistEnd.KeyPress,
                fInteriorShadowDistance.KeyPress, fGamma.KeyPress, fDecalLOD2.KeyPress, fDecalLOD1.KeyPress,
                bTreesReceiveShadows.KeyPress, bTransparencyMultisampling.KeyPress, bShadowMaskZPrepass.KeyPress,
                bMainZPrepass.KeyPress, bFloatPointRenderTarget.KeyPress, bDrawShadows.KeyPress,
                bDrawLandShadows.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub fLODFadeOutMultSkyCell_KeyPress(sender As Object,
                                                e As KeyPressEventArgs) _
        Handles fLODFadeOutMultSkyCell.KeyPress, fLODFadeOutMultObjects.KeyPress, fLODFadeOutMultItems.KeyPress,
                fLODFadeOutMultActors.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bRenderSkinnedTrees_KeyPress(sender As Object,
                                             e As KeyPressEventArgs) _
        Handles uiMaxSkinnedTreesToRender.KeyPress, bRenderSkinnedTrees.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub fGrassMaxStartFadeDistance_KeyPress(sender As Object,
                                                    e As KeyPressEventArgs) _
        Handles fGrassStartFadeDistance.KeyPress, fGrassMinStartFadeDistance.KeyPress,
                fGrassMaxStartFadeDistance.KeyPress, b30GrassVS.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub uMaxSkinDecalsPerActor_KeyPress(sender As Object,
                                                e As KeyPressEventArgs) _
        Handles uMaxSkinDecalsPerActor.KeyPress, uMaxSkinDecals.KeyPress, uMaxDecals.KeyPress, bSkinnedDecals.KeyPress,
                bDecals.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bShowLODInEditor_KeyPress(sender As Object,
                                          e As KeyPressEventArgs) _
        Handles fTreeLoadDistance.KeyPress, fSplitDistanceMult.KeyPress, fBlockMaximumDistance.KeyPress,
                fBlockLevel1Distance.KeyPress, fBlockLevel0Distance.KeyPress, bShowLODInEditor.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bReflectLODTrees_KeyPress(sender As Object,
                                          e As KeyPressEventArgs) _
        Handles iWaterReflectWidth.KeyPress, iWaterReflectHeight.KeyPress, bUseWaterRefractions.KeyPress,
                bUseWaterReflections.KeyPress, bUseWaterDisplacements.KeyPress, bUseWaterDepth.KeyPress,
                bReflectSky.KeyPress, bReflectLODTrees.KeyPress, bReflectLODObjects.KeyPress, bReflectLODLand.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub fCloudLevel0Distance_KeyPress(sender As Object,
                                              e As KeyPressEventArgs) _
        Handles fCloudNearFadeDistance.KeyPress, fCloudLevel2Distance.KeyPress, fCloudLevel1Distance.KeyPress,
                fCloudLevel0Distance.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub bDoDepthOfField_KeyPress(sender As Object,
                                         e As KeyPressEventArgs) _
        Handles iRadialBlurLevel.KeyPress, bUseBlurShader.KeyPress, bDoHighDynamicRange.KeyPress,
                bDoDepthOfField.KeyPress

        'allow only numbers, the Backspace key and the period
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object,
                                e As EventArgs) _
        Handles btnExport.Click

        Try

            Dim exportinifile As SaveFileDialog
            exportinifile = New SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Elder Scrolls V : Skyrim Tweaker Settings Export File(*.cfg) |*.cfg"
            exportinifile.Title = "Export Elder Scrolls V : Skyrim Tweaker Settings to a file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim SkyrimPerfIni As New ZIniFile(exportinifile.FileName)
                SkyrimPerfIni.WriteString("Display", "iTexMipMapSkip", iTexMipMapSkip.Text)
                SkyrimPerfIni.WriteString("Display", "bFXAAEnabled", bFXAAEnabled.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODLevel2FadeDist", fMeshLODLevel2FadeDist.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODLevel1FadeDist", fMeshLODLevel1FadeDist.Text)
                SkyrimPerfIni.WriteString("Display", "fSpecularLODStartFade", fSpecularLODStartFade.Text)
                SkyrimPerfIni.WriteString("Display", "fLightLODStartFade", fLightLODStartFade.Text)
                SkyrimPerfIni.WriteString("Display", "fTreesMidLODSwitchDist", fTreesMidLODSwitchDist.Text)
                SkyrimPerfIni.WriteString("Display", "iShadowMapResolution", iShadowMapResolution.Text)
                SkyrimPerfIni.WriteString("Display", "fShadowBiasScale", fShadowBiasScale.Text)
                SkyrimPerfIni.WriteString("Display", "iShadowMaskQuarter", iShadowMaskQuarter.Text)
                SkyrimPerfIni.WriteString("Display", "iBlurDeferredShadowMask", iBlurDeferredShadowMask.Text)
                SkyrimPerfIni.WriteString("Display", "fShadowDistance", fShadowDistance.Text)
                SkyrimPerfIni.WriteString("Display", "iMaxDecalsPerFrame", iMaxDecalsPerFrame.Text)
                SkyrimPerfIni.WriteString("Display", "iTexMipMapSkip", iMaxSkinDecalsPerFrame.Text)
                SkyrimPerfIni.WriteString("Display", "iAdapter", iAdapter.Text)
                SkyrimPerfIni.WriteString("Display", "iSize W", iSizeW.Text)
                SkyrimPerfIni.WriteString("Display", "iSize H", iSizeH.Text)
                SkyrimPerfIni.WriteString("Display", "iMultiSample", iMultiSample.Text)
                SkyrimPerfIni.WriteString("Display", "iMaxAnisotropy", iMaxAnisotropy.Text)
                SkyrimPerfIni.WriteString("Display", "iPresentInterval", iPresentInterval.Text)
                SkyrimPerfIni.WriteString("Display", "bFull Screen", bFullScreen.Text)
                SkyrimPerfIni.WriteString("Display", "sD3DDevice", sD3DDevice.Text)
                SkyrimPerfIni.WriteString("Display", "fInteriorShadowDistance", fInteriorShadowDistance.Text)
                SkyrimPerfIni.WriteString("Display", "bFloatPointRenderTarget", bFloatPointRenderTarget.Text)
                SkyrimPerfIni.WriteString("Display", "fGamma", fGamma.Text)
                SkyrimPerfIni.WriteString("Display", "iShadowFilter", iShadowFilter.Text)
                SkyrimPerfIni.WriteString("Display", "fDecalLOD2", fDecalLOD2.Text)
                SkyrimPerfIni.WriteString("Display", "fDecalLOD1", fDecalLOD1.Text)
                SkyrimPerfIni.WriteString("Display", "fShadowLODStartFade", fShadowLODStartFade.Text)
                SkyrimPerfIni.WriteString("Display", "iTexMipMapMinimum", iTexMipMapMinimum.Text)
                SkyrimPerfIni.WriteString("Display", "bTransparencyMultisampling", bTransparencyMultisampling.Text)
                SkyrimPerfIni.WriteString("Display", "iWaterMultiSamples", iWaterMultiSamples.Text)
                SkyrimPerfIni.WriteString("Display", "iShadowMode", iShadowMode.Text)
                SkyrimPerfIni.WriteString("Display", "bTreesReceiveShadows", bTreesReceiveShadows.Text)
                SkyrimPerfIni.WriteString("Display", "bDrawLandShadows", bDrawLandShadows.Text)
                SkyrimPerfIni.WriteString("Display", "bDrawShadows", bDrawShadows.Text)
                SkyrimPerfIni.WriteString("Display", "fLeafAnimDampenDistEnd", fLeafAnimDampenDistEnd.Text)
                SkyrimPerfIni.WriteString("Display", "fLeafAnimDampenDistStart", fLeafAnimDampenDistStart.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODFadePercentDefault", fMeshLODFadePercentDefault.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODFadeBoundDefault", fMeshLODFadeBoundDefault.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODLevel2FadeTreeDistance",
                                          fMeshLODLevel2FadeTreeDistance.Text)
                SkyrimPerfIni.WriteString("Display", "fMeshLODLevel1FadeTreeDistance",
                                          fMeshLODLevel1FadeTreeDistance.Text)
                SkyrimPerfIni.WriteString("Display", "iScreenShotIndex", iScreenShotIndex.Text)
                SkyrimPerfIni.WriteString("Display", "bShadowMaskZPrepass", bShadowMaskZPrepass.Text)
                SkyrimPerfIni.WriteString("Display", "bMainZPrepass", bMainZPrepass.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultActors", fLODFadeOutMultActors.Text)
                SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultItems", fLODFadeOutMultItems.Text)
                SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultObjects", fLODFadeOutMultObjects.Text)
                SkyrimPerfIni.WriteString("LOD", "fLODFadeOutMultSkyCell", fLODFadeOutMultSkyCell.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Trees", "bRenderSkinnedTrees", bRenderSkinnedTrees.Text)
                SkyrimPerfIni.WriteString("Trees", "uiMaxSkinnedTreesToRender", uiMaxSkinnedTreesToRender.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Grass", "fGrassStartFadeDistance", fGrassStartFadeDistance.Text)
                SkyrimPerfIni.WriteString("Grass", "b30GrassVS", b30GrassVS.Text)
                SkyrimPerfIni.WriteString("Grass", "fGrassMaxStartFadeDistance", fGrassMaxStartFadeDistance.Text)
                SkyrimPerfIni.WriteString("Grass", "fGrassMinStartFadeDistance", fGrassMinStartFadeDistance.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Decals", "bDecals", bDecals.Text)
                SkyrimPerfIni.WriteString("Decals", "bSkinnedDecals", bSkinnedDecals.Text)
                SkyrimPerfIni.WriteString("Decals", "uMaxDecals", uMaxDecals.Text)
                SkyrimPerfIni.WriteString("Decals", "uMaxSkinDecals", uMaxSkinDecals.Text)
                SkyrimPerfIni.WriteString("Decals", "uMaxSkinDecalsPerActor", uMaxSkinDecalsPerActor.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("TerrainManager", "fTreeLoadDistance", fTreeLoadDistance.Text)
                SkyrimPerfIni.WriteString("TerrainManager", "fBlockMaximumDistance", fBlockMaximumDistance.Text)
                SkyrimPerfIni.WriteString("TerrainManager", "fBlockLevel1Distance", fBlockLevel1Distance.Text)
                SkyrimPerfIni.WriteString("TerrainManager", "fBlockLevel0Distance", fBlockLevel0Distance.Text)
                SkyrimPerfIni.WriteString("TerrainManager", "fSplitDistanceMult", fSplitDistanceMult.Text)
                SkyrimPerfIni.WriteString("TerrainManager", "bShowLODInEditor", bShowLODInEditor.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Water", "iWaterReflectHeight", iWaterReflectHeight.Text)
                SkyrimPerfIni.WriteString("Water", "iWaterReflectWidth", iWaterReflectWidth.Text)
                SkyrimPerfIni.WriteString("Water", "bUseWaterDisplacements", bUseWaterDisplacements.Text)
                SkyrimPerfIni.WriteString("Water", "bUseWaterRefractions", bUseWaterRefractions.Text)
                SkyrimPerfIni.WriteString("Water", "bUseWaterReflections", bUseWaterReflections.Text)
                SkyrimPerfIni.WriteString("Water", "bUseWaterDepth", bUseWaterDepth.Text)
                SkyrimPerfIni.WriteString("Water", "bReflectLODObjects", bReflectLODObjects.Text)
                SkyrimPerfIni.WriteString("Water", "bReflectLODLand", bReflectLODLand.Text)
                SkyrimPerfIni.WriteString("Water", "bReflectSky", bReflectSky.Text)
                SkyrimPerfIni.WriteString("Water", "bReflectLODTrees", bReflectLODTrees.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Clouds", "fCloudLevel2Distance", fCloudLevel2Distance.Text)
                SkyrimPerfIni.WriteString("Clouds", "fCloudLevel1Distance", fCloudLevel1Distance.Text)
                SkyrimPerfIni.WriteString("Clouds", "fCloudLevel0Distance", fCloudLevel0Distance.Text)
                SkyrimPerfIni.WriteString("Clouds", "fCloudNearFadeDistance", fCloudNearFadeDistance.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("Imagespace", "iRadialBlurLevel", iRadialBlurLevel.Text)
                SkyrimPerfIni.WriteString("Imagespace", "bDoDepthOfField", bDoDepthOfField.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("BlurShaderHDR", "bDoHighDynamicRange", bDoHighDynamicRange.Text)
                '---------------------------------------------------------------------------
                SkyrimPerfIni.WriteString("BlurShader", "bUseBlurShader", bUseBlurShader.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object,
                                e As EventArgs) _
        Handles btnImport.Click

        Try

            Dim importinifile As OpenFileDialog
            importinifile = New OpenFileDialog()
            importinifile.Filter = "Elder Scrolls V : Skyrim Tweaker Settings Export File(*.cfg) |*.cfg"
            importinifile.Title = "Import Elder Scrolls V : Skyrim Tweaker Settings"

            If importinifile.ShowDialog() = DialogResult.OK Then

                Dim SkyrimPerfIni As New ZIniFile(importinifile.FileName)
                iTexMipMapSkip.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapSkip", "")
                bFXAAEnabled.Text = SkyrimPerfIni.GetString("Display", "bFXAAEnabled", "")
                fMeshLODLevel2FadeDist.Text = SkyrimPerfIni.GetString("Display", "fMeshLODLevel2FadeDist", "")
                fMeshLODLevel1FadeDist.Text = SkyrimPerfIni.GetString("Display", "fMeshLODLevel1FadeDist", "")
                fSpecularLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fSpecularLODStartFade", "")
                fLightLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fLightLODStartFade", "")
                fTreesMidLODSwitchDist.Text = SkyrimPerfIni.GetString("Display", "fTreesMidLODSwitchDist", "")
                iShadowMapResolution.Text = SkyrimPerfIni.GetString("Display", "iShadowMapResolution", "")
                fShadowBiasScale.Text = SkyrimPerfIni.GetString("Display", "fShadowBiasScale", "")
                iShadowMaskQuarter.Text = SkyrimPerfIni.GetString("Display", "iShadowMaskQuarter", "")
                iBlurDeferredShadowMask.Text = SkyrimPerfIni.GetString("Display", "iBlurDeferredShadowMask", "")
                fShadowDistance.Text = SkyrimPerfIni.GetString("Display", "fShadowDistance", "")
                iMaxDecalsPerFrame.Text = SkyrimPerfIni.GetString("Display", "iMaxDecalsPerFrame", "")
                iMaxSkinDecalsPerFrame.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapSkip", "")
                iAdapter.Text = SkyrimPerfIni.GetString("Display", "iAdapter", "")
                iSizeW.Text = SkyrimPerfIni.GetString("Display", "iSize W", "")
                iSizeH.Text = SkyrimPerfIni.GetString("Display", "iSize H", "")
                iMultiSample.Text = SkyrimPerfIni.GetString("Display", "iMultiSample", "")
                iMaxAnisotropy.Text = SkyrimPerfIni.GetString("Display", "iMaxAnisotropy", "")
                iPresentInterval.Text = SkyrimPerfIni.GetString("Display", "iPresentInterval", "")
                bFullScreen.Text = SkyrimPerfIni.GetString("Display", "bFull Screen", "")
                sD3DDevice.Text = SkyrimPerfIni.GetString("Display", "sD3DDevice", "")
                fInteriorShadowDistance.Text = SkyrimPerfIni.GetString("Display", "fInteriorShadowDistance", "")
                bFloatPointRenderTarget.Text = SkyrimPerfIni.GetString("Display", "bFloatPointRenderTarget", "")
                fGamma.Text = SkyrimPerfIni.GetString("Display", "fGamma", "")
                iShadowFilter.Text = SkyrimPerfIni.GetString("Display", "iShadowFilter", "")
                fDecalLOD2.Text = SkyrimPerfIni.GetString("Display", "fDecalLOD2", "")
                fDecalLOD1.Text = SkyrimPerfIni.GetString("Display", "fDecalLOD1", "")
                fShadowLODStartFade.Text = SkyrimPerfIni.GetString("Display", "fShadowLODStartFade", "")
                iTexMipMapMinimum.Text = SkyrimPerfIni.GetString("Display", "iTexMipMapMinimum", "")
                bTransparencyMultisampling.Text = SkyrimPerfIni.GetString("Display", "bTransparencyMultisampling", "")
                iWaterMultiSamples.Text = SkyrimPerfIni.GetString("Display", "iWaterMultiSamples", "")
                iShadowMode.Text = SkyrimPerfIni.GetString("Display", "iShadowMode", "")
                bTreesReceiveShadows.Text = SkyrimPerfIni.GetString("Display", "bTreesReceiveShadows", "")
                bDrawLandShadows.Text = SkyrimPerfIni.GetString("Display", "bDrawLandShadows", "")
                bDrawShadows.Text = SkyrimPerfIni.GetString("Display", "bDrawShadows", "")
                fLeafAnimDampenDistEnd.Text = SkyrimPerfIni.GetString("Display", "fLeafAnimDampenDistEnd", "")
                fLeafAnimDampenDistStart.Text = SkyrimPerfIni.GetString("Display", "fLeafAnimDampenDistStart", "")
                fMeshLODFadePercentDefault.Text = SkyrimPerfIni.GetString("Display", "fMeshLODFadePercentDefault", "")
                fMeshLODFadeBoundDefault.Text = SkyrimPerfIni.GetString("Display", "fMeshLODFadeBoundDefault", "")
                fMeshLODLevel2FadeTreeDistance.Text = SkyrimPerfIni.GetString("Display",
                                                                              "fMeshLODLevel2FadeTreeDistance", "")
                fMeshLODLevel1FadeTreeDistance.Text = SkyrimPerfIni.GetString("Display",
                                                                              "fMeshLODLevel1FadeTreeDistance", "")
                iScreenShotIndex.Text = SkyrimPerfIni.GetString("Display", "iScreenShotIndex", "")
                bShadowMaskZPrepass.Text = SkyrimPerfIni.GetString("Display", "bShadowMaskZPrepass", "")
                bMainZPrepass.Text = SkyrimPerfIni.GetString("Display", "bMainZPrepass", "")
                '---------------------------------------------------------------------------
                fLODFadeOutMultActors.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultActors", "")
                fLODFadeOutMultItems.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultItems", "")
                fLODFadeOutMultObjects.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultObjects", "")
                fLODFadeOutMultSkyCell.Text = SkyrimPerfIni.GetString("LOD", "fLODFadeOutMultSkyCell", "")
                '---------------------------------------------------------------------------
                bRenderSkinnedTrees.Text = SkyrimPerfIni.GetString("Trees", "bRenderSkinnedTrees", "")
                uiMaxSkinnedTreesToRender.Text = SkyrimPerfIni.GetString("Trees", "uiMaxSkinnedTreesToRender", "")
                '---------------------------------------------------------------------------
                fGrassStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassStartFadeDistance", "")
                b30GrassVS.Text = SkyrimPerfIni.GetString("Grass", "b30GrassVS", "")
                fGrassMaxStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassMaxStartFadeDistance", "")
                fGrassMinStartFadeDistance.Text = SkyrimPerfIni.GetString("Grass", "fGrassMinStartFadeDistance", "")
                '---------------------------------------------------------------------------
                bDecals.Text = SkyrimPerfIni.GetString("Decals", "bDecals", "")
                bSkinnedDecals.Text = SkyrimPerfIni.GetString("Decals", "bSkinnedDecals", "")
                uMaxDecals.Text = SkyrimPerfIni.GetString("Decals", "uMaxDecals", "")
                uMaxSkinDecals.Text = SkyrimPerfIni.GetString("Decals", "uMaxSkinDecals", "")
                uMaxSkinDecalsPerActor.Text = SkyrimPerfIni.GetString("Decals", "uMaxSkinDecalsPerActor", "")
                '---------------------------------------------------------------------------
                fTreeLoadDistance.Text = SkyrimPerfIni.GetString("TerrainManager", "fTreeLoadDistance", "")
                fBlockMaximumDistance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockMaximumDistance", "")
                fBlockLevel1Distance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockLevel1Distance", "")
                fBlockLevel0Distance.Text = SkyrimPerfIni.GetString("TerrainManager", "fBlockLevel0Distance", "")
                fSplitDistanceMult.Text = SkyrimPerfIni.GetString("TerrainManager", "fSplitDistanceMult", "")
                bShowLODInEditor.Text = SkyrimPerfIni.GetString("TerrainManager", "bShowLODInEditor", "")
                '---------------------------------------------------------------------------
                iWaterReflectHeight.Text = SkyrimPerfIni.GetString("Water", "iWaterReflectHeight", "")
                iWaterReflectWidth.Text = SkyrimPerfIni.GetString("Water", "iWaterReflectWidth", "")
                bUseWaterDisplacements.Text = SkyrimPerfIni.GetString("Water", "bUseWaterDisplacements", "")
                bUseWaterRefractions.Text = SkyrimPerfIni.GetString("Water", "bUseWaterRefractions", "")
                bUseWaterReflections.Text = SkyrimPerfIni.GetString("Water", "bUseWaterReflections", "")
                bUseWaterDepth.Text = SkyrimPerfIni.GetString("Water", "bUseWaterDepth", "")
                bReflectLODObjects.Text = SkyrimPerfIni.GetString("Water", "bReflectLODObjects", "")
                bReflectLODLand.Text = SkyrimPerfIni.GetString("Water", "bReflectLODLand", "")
                bReflectSky.Text = SkyrimPerfIni.GetString("Water", "bReflectSky", "")
                bReflectLODTrees.Text = SkyrimPerfIni.GetString("Water", "bReflectLODTrees", "")
                '---------------------------------------------------------------------------
                fCloudLevel2Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel2Distance", "")
                fCloudLevel1Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel1Distance", "")
                fCloudLevel0Distance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudLevel0Distance", "")
                fCloudNearFadeDistance.Text = SkyrimPerfIni.GetString("Clouds", "fCloudNearFadeDistance", "")
                '---------------------------------------------------------------------------
                iRadialBlurLevel.Text = SkyrimPerfIni.GetString("Imagespace", "iRadialBlurLevel", "")
                bDoDepthOfField.Text = SkyrimPerfIni.GetString("Imagespace", "bDoDepthOfField", "")
                '---------------------------------------------------------------------------
                bDoHighDynamicRange.Text = SkyrimPerfIni.GetString("BlurShaderHDR", "bDoHighDynamicRange", "")
                '---------------------------------------------------------------------------
                bUseBlurShader.Text = SkyrimPerfIni.GetString("BlurShader", "bUseBlurShader", "")
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub

    '____________________________________________________________________________________________________________________________________________
    Private Sub ListView1_ItemDrag(sender As Object,
                                   e As ItemDragEventArgs) _
        Handles LSTKeys.ItemDrag

        Try

            DoDragDrop(e.Item, DragDropEffects.Move)

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_MouseDown(sender As Object,
                                    e As MouseEventArgs) _
        Handles LSTKeys.MouseDown

        Try
            FromSection = CurrentSection

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object,
                                               e As EventArgs) _
        Handles LSTKeys.SelectedIndexChanged

        Try

            Dim Item As ListViewItem = GetSelectedKey()

            If Not Item Is Nothing Then
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Function GetSelectedKey() As ListViewItem

        Try

            Dim Item As ListViewItem

            For Each Item In LSTKeys.SelectedItems
                Return Item
            Next

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Function

    Private Sub TreeView1_AfterSelect(sender As Object,
                                      e As TreeViewEventArgs) _
        Handles TrSections.AfterSelect

        Try

            If TrSections.SelectedNode.Text <> "Settings" Then
                CurrentSection = TrSections.SelectedNode.Text
                RefreshKeys(CurrentSection)
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub RefreshKeys(ByVal SectionName As String)

        Try
            LSTKeys.Items.Clear()

            Dim Keys As ArrayList = myIniFile.GetKeys(SectionName)
            Dim myEnumerator As IEnumerator = Keys.GetEnumerator()

            While myEnumerator.MoveNext()

                Dim myItem As New ListViewItem
                myItem.Text = (myEnumerator.Current.Name)
                myItem.SubItems.Add(myEnumerator.Current.value)
                myItem.ImageIndex = 3

                If myEnumerator.Current.IsCommented Then myItem.ForeColor = Color.Green
                LSTKeys.Items.Add(myItem)
            End While

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_DragDrop(sender As Object,
                                   e As DragEventArgs) _
        Handles TrSections.DragDrop

        Try

            Dim lvItem As ListViewItem

            If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem", False) Then

                Dim pt As Point
                Dim DestinationNode As TreeNode
                pt = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
                DestinationNode = CType(sender, TreeView).GetNodeAt(pt)
                lvItem = CType(e.Data.GetData("System.Windows.Forms.ListViewItem"), ListViewItem)
                myIniFile.MoveKey(lvItem.Text, FromSection, DestinationNode.Text)
                RefreshKeys(CurrentSection)
                RefreshSections()
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub RefreshSections()

        Try
            TrSections.Nodes.Clear()

            Dim CurrentNode
            Dim Root As New TreeNode
            Root.Text = "Settings"
            Root.ImageIndex = 5

            Dim Sections As ArrayList = myIniFile.GetSections()
            Dim myEnumerator As IEnumerator = Sections.GetEnumerator()

            While myEnumerator.MoveNext()

                Dim myNode As New TreeNode
                myNode.Text = myEnumerator.Current.Name

                If myEnumerator.Current.iscommented Then myNode.ForeColor = Color.Green
                Root.Nodes.Add(myNode)
            End While

            Root.Expand()
            TrSections.Nodes.Add(Root)

            If CurrentSection = "" Then
                CurrentSection = Root.FirstNode.Text
                Root.TreeView.SelectedNode = Root.FirstNode
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_DragEnter(sender As Object,
                                    e As DragEventArgs) _
        Handles TrSections.DragEnter

        Try
            e.Effect = DragDropEffects.Move

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_DragOver(sender As Object,
                                   e As DragEventArgs) _
        Handles TrSections.DragOver

        Try

            Dim pt As Point
            Dim DestinationNode As TreeNode
            pt = CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
            DestinationNode = CType(sender, TreeView).GetNodeAt(pt)
            TrSections.Focus()
            TrSections.SelectedNode = DestinationNode

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_ItemDrag(sender As Object,
                                   e As ItemDragEventArgs) _
        Handles TrSections.ItemDrag

        Try

            DoDragDrop(e.Item, DragDropEffects.Move)

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuAddSection_Click(sender As Object,
                                     e As EventArgs) _
        Handles cmnuAddSection.Click

        Try

            Dim SectionName As String = InputBox("Enter a new section name", "Add Section", "")

            If SectionName <> "" Then myIniFile.AddSection(SectionName)
            RefreshSections()

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuEditSection_Click(sender As Object,
                                      e As EventArgs) _
        Handles cmnuEditSection.Click

        Try

            If Not TrSections.SelectedNode Is Nothing Then

                Dim SectionName As String = InputBox("Enter a new section name", "Rename Section", "")

                If SectionName <> "" Then myIniFile.RenameSection(TrSections.SelectedNode.Text, SectionName)
                RefreshKeys(CurrentSection)
                RefreshSections()
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuDeleteSection_Click(sender As Object,
                                        e As EventArgs) _
        Handles cmnuDeleteSection.Click

        Try

            If Not TrSections.SelectedNode Is Nothing Then
                myIniFile.DeleteSection(TrSections.SelectedNode.Text)
                RefreshKeys(CurrentSection)
                RefreshSections()
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuAddKey_Click(sender As Object,
                                 e As EventArgs) _
        Handles cmnuAddKey.Click

        Try

            Dim KeyValue As String

            If Not TrSections.SelectedNode Is Nothing Or LSTKeys.SelectedItems.Count > 0 Then

                Dim KeyName As String = InputBox("Enter a new Key name", "Add Key", "")

                If KeyName <> "" Then
                    KeyValue = InputBox("Enter a new Key value", "Add Key", "")
                Else : Exit Sub
                End If


                If KeyName <> "" And KeyValue <> "" Then

                    If Not LSTKeys.SelectedItems.Count = 0 Then
                        myIniFile.AddKey(KeyName, KeyValue, CurrentSection, False, GetSelectedKey().Text)
                        RefreshKeys(CurrentSection)
                        RefreshSections()

                    Else
                        myIniFile.AddKey(KeyName, KeyValue, CurrentSection)
                        RefreshKeys(CurrentSection)
                        RefreshSections()
                    End If

                End If

            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuRenameKey_Click(sender As Object,
                                    e As EventArgs) _
        Handles cmnuRenameKey.Click

        Try

            If LSTKeys.SelectedItems.Count > 0 Then

                Dim KeyName As String = InputBox("Enter a new Key name", "Rename Key", LSTKeys.SelectedItems(0).Text)
                If KeyName <> "" Then myIniFile.RenameKey(GetSelectedKey().Text, CurrentSection, KeyName)
                RefreshKeys(CurrentSection)
                RefreshSections()
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuDeleteKey_Click(sender As Object,
                                    e As EventArgs) _
        Handles cmnuDeleteKey.Click

        Try

            If LSTKeys.SelectedItems.Count > 0 Then
                myIniFile.DeleteKey(GetSelectedKey().Text, CurrentSection)
                RefreshKeys(CurrentSection)
                RefreshSections()
            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object,
                             e As EventArgs) _
        Handles btnAdd.Click

        Try

            Dim button As New DialogResult
            button = MessageBox.Show("Pressing Yes will Reload the file, You will loose any unsaved Changes! Continue ?",
                                     "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                     MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then

                If SkyrimUserFolder <> "" Then

                    If cmbinifilename.Text <> "" Then
                        CurrentSection = ""
                        TrSections.Enabled = True
                        LSTKeys.Enabled = True
                        myIniFile = New xIniFile(addTrailingSlash(SkyrimUserFolder) & "\" & cmbinifilename.Text)
                        RefreshSections()
                    End If

                End If
            End If
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmnuKeyValue_Click(sender As Object,
                                   e As EventArgs) _
        Handles cmnuKeyValue.Click

        Try

            If LSTKeys.SelectedItems.Count > 0 Then

                Dim KeyValue As String = InputBox("Enter a new Key value", "Key Value",
                                                  LSTKeys.SelectedItems(0).SubItems(1).Text)

                If KeyValue <> "" Then
                    myIniFile.ChangeValue(GetSelectedKey().Text, CurrentSection, KeyValue)
                    RefreshKeys(CurrentSection)
                    RefreshSections()
                End If

            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object,
                              e As EventArgs) _
        Handles Button1.Click

        Try

            If SkyrimUserFolder <> "" Then

                If cmbinifilename.Text <> "" Then

                    Dim button As New DialogResult
                    button = MessageBox.Show("Are you sure you want to Commit all the Changes?", "Are You Sure?",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                             MessageBoxDefaultButton.Button1)

                    If button = DialogResult.Yes Then
                        myIniFile.Save(addTrailingSlash(SkyrimUserFolder) & "\" & cmbinifilename.Text)

                        doreadingstuff()
                    End If

                End If

            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub cmbinifilename_SelectedIndexChanged(sender As Object,
                                                    e As EventArgs) _
        Handles cmbinifilename.SelectedIndexChanged

        Try

            If SkyrimUserFolder <> "" Then

                If cmbinifilename.Text <> "" Then
                    CurrentSection = ""
                    TrSections.Enabled = True
                    LSTKeys.Enabled = True
                    myIniFile = New xIniFile(addTrailingSlash(SkyrimUserFolder) & "\" & cmbinifilename.Text)
                    RefreshSections()
                End If

            End If

        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    Private Sub frmMain_Move(sender As Object, e As EventArgs) Handles Me.Move
    End Sub

    Private Sub frmMain_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        My.Settings.WindowHeight = Me.Height
        My.Settings.WindowWidth = Me.Width
    End Sub
End Class
