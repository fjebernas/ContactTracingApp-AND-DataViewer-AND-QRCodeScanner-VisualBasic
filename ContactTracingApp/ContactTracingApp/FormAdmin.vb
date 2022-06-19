Public Class FormAdmin
    Dim formMain As FormMain
    Dim formAdminLogin As FormAdminLogin

    Public Sub New(ByVal formMain As FormMain, ByVal formAdminLogin As FormAdminLogin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.formMain = formMain
        Me.formAdminLogin = formAdminLogin
    End Sub

    Private Sub FormAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Close()
        formAdminLogin.Close()
    End Sub
End Class