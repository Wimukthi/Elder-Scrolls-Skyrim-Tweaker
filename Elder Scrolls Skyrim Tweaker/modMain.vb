
Module modMain
    Public SkyrimEXEtoRun As String
    Public SkyrimUserFolder As String

    Public Function addTrailingSlash(StrPath As String) As String ' this function adds a trailing Slash if its not there

        Try

            If StrPath.EndsWith("\") = False Then
                StrPath = StrPath & "\"
            End If

        Catch ex As Exception
            MsgBox("Something went wrong : " & ex.Message, vbCritical)
        End Try

        Return StrPath
    End Function

    Public Function GetSkyrimSettingsDir()

        Dim Skyrimdir As String
        Skyrimdir = addTrailingSlash(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))

        If My.Computer.FileSystem.FileExists(Skyrimdir & "My Games\Skyrim\SkyrimPrefs.ini") = True Then
            SkyrimUserFolder = Skyrimdir & "My Games\Skyrim"

        ElseIf My.Computer.FileSystem.FileExists(Skyrimdir & "My Games\Skyrim\SkyrimPrefs.ini") = False Then

            If _
                My.Computer.FileSystem.FileExists(
                    addTrailingSlash(My.Application.Info.DirectoryPath) & "SkyrimPrefs.ini") = True Then
                SkyrimUserFolder = addTrailingSlash(My.Application.Info.DirectoryPath)

            ElseIf _
                My.Computer.FileSystem.FileExists(
                    addTrailingSlash(My.Application.Info.DirectoryPath) & "SkyrimPrefs.ini") = False Then

                Dim WitcherTwoSettings As New FolderBrowserDialog
                With WitcherTwoSettings
                    .RootFolder = Environment.SpecialFolder.Desktop
                    .Description = "Please Select the Elder Scrolls V : Skyrim User Settings Directory [\Skyrim]"

                    If .ShowDialog = DialogResult.OK Then

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(.SelectedPath) & "SkyrimPrefs.ini") = True _
                            Then
                            SkyrimUserFolder = addTrailingSlash(.SelectedPath)

                        Else
                            MsgBox(
                                "Selected folder Doesnt Appear to be the Elder Scrolls V : Skyrim User Settings folder, Please select the correct folder!",
                                vbCritical)
                            Return Nothing
                            Exit Function
                        End If

                    Else
                        Return Nothing
                        Exit Function
                    End If

                End With
            End If

        End If

        Return Nothing
    End Function
End Module
