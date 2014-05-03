Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'I figured how to make comments in VB! Yeey
        'Temporarely redirecting to menuForm
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        credits.Show()
    End Sub
End Class
