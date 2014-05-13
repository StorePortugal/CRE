Public Class login
    Dim user As String


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CreDataSet.users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.CreDataSet.users)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'I figured how to make comments in VB! Yeey
        'Temporarely redirecting to menuForm

        menuForm.Show()
        Me.Close()

        Me.UsersBindingSource.Filter = "username = '" & Me.username.Text & "'"
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        credits.Show()
    End Sub
End Class
