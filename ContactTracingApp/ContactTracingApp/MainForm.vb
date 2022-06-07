Imports System.Linq

Public Class FormMain
    Dim user As User
    Dim userType As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user = New User()
        userType = ""
    End Sub

    Private Sub btnUserType_Click(sender As Object, e As EventArgs) Handles btnStudent.Click, btnGuest.Click, btnFaculty.Click
        Dim btn As Button = (sender)
        For Each item As Button In panelBottom.Controls.OfType(Of Button)
            If Not (item.Text = btn.Text) Then
                item.Visible = False
            End If
        Next
        timer.Start()
        userType = btn.Text
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If Me.Height < 793 Then
            Me.Height += 20
        Else
            timer.Stop()
            For Each btn As Button In panelBottom.Controls.OfType(Of Button)
                btn.Visible = False
                If btn.Name = "btnSubmit" Then
                    btn.Visible = True
                End If
            Next
#Region "Change 'Are you a: ' label to 'Please fill out the following fields:'"
            lblWelcomeH2.Location = New Point(206, 105)
            lblWelcomeH2.Font = New Font("Century Gothic", "12")
            lblWelcomeH2.Text = "Kindly fill out the following fields:"
#End Region
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If CheckRequiredFields() Then
                user.UserType = userType
                user.FirstName = txtBxFirstName.Text
                user.MiddleName = txtBxMiddleName.Text
                user.LastName = txtBxLastName.Text
                user.Age = Convert.ToByte(txtBxAge.Text)
                user.Address = txtBxAddress.Text
                user.CpNum = txtBxCpNum.Text
                user.Gender = txtBxGender.Text
                user.FirstQuestionAnswer = gbxFirstQuestion.Controls.OfType(Of RadioButton).FirstOrDefault(Function(rdoBtn) rdoBtn.Checked = True).Text
                user.SecondQuestionAnswer = gbxSecondQuestion.Controls.OfType(Of RadioButton).FirstOrDefault(Function(rdoBtn) rdoBtn.Checked = True).Text
                'find all checked symptoms in the contract tracing form and add it to the user.array
                For Each chkBx As CheckBox In panelContent.Controls.OfType(Of CheckBox)
                    If chkBx.Checked Then
                        user.Symptoms = chkBx.Text
                    End If
                Next
                user.CreateTxtFile()
            Else
                For Each lbl As Label In panelContent.Controls.OfType(Of Label)
                    If lbl.Tag = "lblSayingRequired" Then
                        lbl.Visible = True
                    End If
                Next
                MessageBox.Show("Please fill out all required fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CheckRequiredFields() As Boolean
        For Each txtBx As TextBox In panelContent.Controls.OfType(Of TextBox)
            If txtBx.Tag = "requiredField" And txtBx.Text = "" Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub txtBx_Active(sender As Object, e As EventArgs) Handles txtBxMiddleName.Enter, txtBxLastName.Enter, txtBxGender.Enter, txtBxFirstName.Enter, txtBxCpNum.Enter, txtBxAge.Enter, txtBxAddress.Enter
        Dim txtBx As TextBox = sender
        txtBx.BackColor = Color.LightYellow
    End Sub

    Private Sub txtBx_NoLongerActive(sender As Object, e As EventArgs) Handles txtBxMiddleName.Leave, txtBxLastName.Leave, txtBxGender.Leave, txtBxFirstName.Leave, txtBxCpNum.Leave, txtBxAge.Leave, txtBxAddress.Leave
        Dim txtBx As TextBox = sender
        txtBx.BackColor = Color.White
    End Sub
End Class
