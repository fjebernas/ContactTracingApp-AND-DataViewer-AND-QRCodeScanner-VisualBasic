Public Class FormMain
    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click, btnSubmit.Click
        lblWelcomeH2.Visible = False
        timer.Start()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If Me.Height < 640 Then
            Me.Height += 20
            Me.panelTop.Height -= 2
        Else
            timer.Stop()
            For Each btn As Button In Me.panelBottom.Controls.OfType(Of Button)
                btn.Visible = False
                If btn.Name = "btnSubmit" Then
                    btn.Visible = True
                End If
            Next
        End If
    End Sub
End Class
