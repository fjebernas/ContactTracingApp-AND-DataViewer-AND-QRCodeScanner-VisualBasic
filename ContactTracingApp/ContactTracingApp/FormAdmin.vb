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

    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click
        Dim lines() As String
        lines = File.ReadAllLines(fileNames(0))
        txtBxFirstName.Text = lines(5).Replace("   First name: ", "")
        txtBxMiddleName.Text = lines(6).Replace("   Middle name: ", "")
        txtBxLastName.Text = lines(7).Replace("   Last name: ", "")
        txtBxAge.Text = lines(8).Replace("   Age: ", "")
        txtBxCpNum.Text = lines(9).Replace("   Phone number: ", "")
        txtBxAddress.Text = lines(10).Replace("   Address: ", "")
        txtBxGender.Text = lines(11).Replace("   Gender: ", "")
        If lines(15).Equals("   Answer => Yes") Then
            rdoFirstQuestionYes.Checked = True
        Else
            rdoFirstQuestionNo.Checked = True
        End If
    End Sub
End Class