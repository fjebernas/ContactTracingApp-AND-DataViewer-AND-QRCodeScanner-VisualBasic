Public Class FormMain
    Dim user As User
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user = New User()
    End Sub
    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        'lblWelcomeH2.Visible = False
        timer.Start()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click

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
                user.FirstName = txtBxFirstName.Text
                user.MiddleName = txtBxMiddleName.Text
                user.LastName = txtBxLastName.Text
                user.Age = Convert.ToByte(txtBxAge.Text)
                user.Address = txtBxAddress.Text
                user.CpNum = txtBxCpNum.Text
                user.Gender = txtBxGender.Text
                user.CreateTxtFile()
            Else
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

    Private Sub txtBx_Active(sender As Object, e As EventArgs) Handles txtBxFirstName.Enter, txtBxMiddleName.Enter, txtBxLastName.Enter, txtBxGender.Enter, txtBxCpNum.Enter, txtBxAge.Enter, txtBxAddress.Enter
        Dim txtBx As TextBox = sender
        txtBx.BackColor = Color.LightYellow
    End Sub

    Private Sub txtBx_NoLongerActive(sender As Object, e As EventArgs) Handles txtBxFirstName.Leave, txtBxMiddleName.Leave, txtBxLastName.Leave, txtBxGender.Leave, txtBxCpNum.Leave, txtBxAge.Leave, txtBxAddress.Leave
        Dim txtBx As TextBox = sender
        txtBx.BackColor = Color.White
    End Sub
End Class
