
Public Class frmHelp

    Private Sub btnOk_Click(sender As System.Object, _
                            e As System.EventArgs) _
            Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub frmHelp_Load(sender As System.Object, _
                             e As System.EventArgs) _
            Handles MyBase.Load
        lblHelp.Text = My.Application.Info.Version.ToString & vbCrLf & "© fallenzeraphine 2011-2016" & vbCrLf & "Elder Scrolls V : Skyrim Icon by Bonscha @ Deviantart" & vbCrLf & "This Software is Free for Personal Use."
    End Sub

End Class
