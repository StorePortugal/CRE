Public Class menuForm

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        livros.Show()
        Me.Hide()
    End Sub
End Class