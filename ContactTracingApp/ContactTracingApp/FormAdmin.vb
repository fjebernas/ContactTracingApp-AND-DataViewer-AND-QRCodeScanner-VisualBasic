Imports System.IO

Public Class FormAdmin
    Dim formMain As FormMain
    Dim formAdminLogin As FormAdminLogin
    Dim fileNames() As String

    Public Sub New(ByVal formMain As FormMain, ByVal formAdminLogin As FormAdminLogin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.formMain = formMain
        Me.formAdminLogin = formAdminLogin
        fileNames = Directory.GetFiles(User.PATH)
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each fileName In fileNames
            fileName = Path.GetFileName(fileName)
            fileName = fileName.Replace(".txt", "")
            listBxEntries.Items.Add(fileName)
        Next
    End Sub

    Private Sub FormAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Close()
        formAdminLogin.Close()
    End Sub


End Class