Public Class Form1
    Dim main As New Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        sender.Visible = False
    End Sub
End Class
