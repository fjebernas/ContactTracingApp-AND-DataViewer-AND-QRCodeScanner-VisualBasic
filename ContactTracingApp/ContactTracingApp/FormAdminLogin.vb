Public Class FormAdminLogin
    Dim formMain As FormMain
    Const PASSWORD As String = "123"
    Public Sub New(ByVal formMain As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.formMain = formMain
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBxPassword.Text.Equals(PASSWORD) Then
            formMain.Hide()
            Me.Hide()
            Dim formAdmin As FormAdmin = New FormAdmin(formMain, Me)
            formAdmin.Show()
        Else
            lblWrongPassword.Visible = True
            txtBxPassword.Text = ""
        End If
    End Sub

    Private Sub txtBxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class