Public Class Main

    Private Sub bookBtn_Click(sender As Object, e As EventArgs) Handles bookBtn.Click
        'hide main
        GlobalVariable.main.Hide()
        'show bookSystem
        GlobalVariable.bookSystem.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariable.main Is Nothing Then
            GlobalVariable.main = Me
        End If
    End Sub

    Private Sub Main_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        'show bookSystem
        GlobalVariable.help.Show()
    End Sub
End Class
