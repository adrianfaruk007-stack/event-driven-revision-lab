Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MessageBox.Show(txtPassword.Text)






    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        lblStatus.Text = "Handler 1 ran"
    End Sub
    Private Sub ShowSecondMessage(sender As Object, e As EventArgs)
        lblStatus.Text = "Handler 2 ran"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnTest.Click, AddressOf ShowSecondMessage
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveHandler btnTest.Click, AddressOf ShowSecondMessage
    End Sub
End Class
