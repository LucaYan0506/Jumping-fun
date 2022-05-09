Public Class Main
    Dim book_system As New book_form
    Dim help As New help_form
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        book_system.ShowDialog()
    End Sub

    Private Sub Main_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        Me.Hide()
        help.ShowDialog()
    End Sub
End Class