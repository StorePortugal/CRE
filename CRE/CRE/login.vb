Public Class login
    Dim user As String


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'I figured how to make comments in VB! Yeey
        'Temporarely redirecting to menuForm
        Dim strName As String
        Dim strPass As String
        Dim pesan As String 'pesan is Indonesian and it is the same with Message in english


        UsrData.Refresh()
        strName = txtUsr.Text
        strPass = txtPwd.Text


        Do Until UsrData.Recordset.EOF
            If UsrData.Recordset.Fields(username).Value = strName And UsrData.Recordset.Fields(password).Value = strPass Then
                Me.Hide()
                frmEmployee.Show()    'if the login succeed then form that contain employee info shown
                Exit Sub

            Else
                UsrData.Recordset.MoveNext()
            End If

        Loop

pesan = MsgBox(Invalid password, try again!, vbOKCancel,”Understanding What Is”)
        If (pesan = 1) Then
            Login_form.Show()
txtName.Text = 
txtpassword = 

        Else
            End
        End If


    End Sub

    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        credits.Show()
    End Sub
End Class
