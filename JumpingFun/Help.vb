Public Class Help
    Private Sub Help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'don't close Help, instead, hide
        e.Cancel = True
        'hide Help
        GlobalVariable.help.Hide()
        'show Main
        GlobalVariable.main.Show()
    End Sub
End Class