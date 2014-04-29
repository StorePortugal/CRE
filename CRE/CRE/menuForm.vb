Public Class menuForm

    Public isLoggedIn As Boolean = False

    Private Sub menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If isLoggedIn = False Then
            login.Show()
        End If
    End Sub

End Class