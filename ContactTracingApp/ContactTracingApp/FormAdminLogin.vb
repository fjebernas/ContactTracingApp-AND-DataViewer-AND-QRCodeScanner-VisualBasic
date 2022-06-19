Public Class FormAdminLogin
    Dim formMain As FormMain
    Public Sub New(ByVal formMain As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.formMain = formMain
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBxPassword.Text = "123" Then
            Dim formAdmin As FormAdmin = New FormAdmin
            formMain.Hide()
            Me.Hide()
            formAdmin.Show()
        Else
            MessageBox.Show("wrong password!")
        End If
    End Sub
End Class