Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If menuForm.isLoggedIn = False Then
            menuForm.Hide()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'I figured how to make comments in VB! Yeey
        'Temporarely redirecting to menuForm 
        menuForm.isLoggedIn = True
        menuForm.Show()
        Me.Hide()
    End Sub
End Class
