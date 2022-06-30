Imports System.IO
Imports ZXing

Public Class FormQRCodeResult
    Dim infos() As String
    Dim nameParts() As String
    Dim wN, fN, sN As String

    Public Sub New(ByVal result As Result)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        infos = (result.ToString()).Split("-")

        txtBxName.Text = " " & infos(0)
        txtBxAge.Text = " " & infos(1)
        txtBxAddress.Text = " " & infos(2)
        txtBxGender.Text = infos(3)
        txtBxContactNo.Text = " " & infos(4)
        txtBxQuesOne.Text = " " & infos(5)
        txtBxQuesTwo.Text = " " & infos(6)
        txtBxQuesThree.Text = " " & infos(7)

        nameParts = SplitName(txtBxName.Text)
        fN = nameParts(0)
        sN = nameParts(1)
        nameParts(0) = nameParts(0).Replace(" ", "-")
        nameParts(1) = nameParts(1).ToUpper()
        wN = nameParts(1) + "_" & nameParts(0)

        labelName.Text = fN & "'s"
    End Sub
    Private Sub FormQRCodeResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = labelHeader

        labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        labelDate.Text = DateTime.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub btnYES_Click(sender As Object, e As EventArgs) Handles btnYES.Click
        timer.Stop()

        Dim dataTxt As StreamWriter

        dataTxt = File.CreateText(User.PATH & wN & ".txt")
        dataTxt.WriteLine("---------------Contact Tracing using QR Code---------------" & vbCrLf & vbCrLf & vbCrLf &
                              "Time submitted: " & DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm:ss tt") & vbCrLf & vbCrLf &
                              "USER'S DETAILS:" & vbCrLf & vbCrLf &
                              "First name: " & fN & vbCrLf &
                              "Last name: " & sN & vbCrLf &
                              "Age: " & txtBxAge.Text & vbCrLf &
                              "Address: " & txtBxAddress.Text & vbCrLf &
                              "Gender: " & txtBxGender.Text & vbCrLf &
                              "Contact no.: " & txtBxContactNo.Text & vbCrLf & vbCrLf &
                              "USER'S ANSWERS:" & vbCrLf & vbCrLf &
                              "1. Have you traveled outside the country anytime from last month until now?" & vbCrLf &
                              "Answer:" & txtBxQuesOne.Text & vbCrLf &
                              "2. Have you come into contact with anyone who has traveled outside your country between the period of last month until now?" & vbCrLf &
                              "Answer:" & txtBxQuesTwo.Text & vbCrLf &
                              "3. Health conditions or flu-like symptoms: (e.g. fever, cough, breathing difficulty, etc.)" & vbCrLf &
                              "Answer:" & txtBxQuesThree.Text & vbCrLf
                              )
        dataTxt.Close()
        MessageBox.Show("Submitted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        StartOver()
    End Sub

    Private Sub btnNO_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        timer.Stop()
        MessageBox.Show("Not Submitted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        For Each txtBx As TextBox In Me.Controls.OfType(Of TextBox)
            txtBx.Text = ""
        Next

        StartOver()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        labelDate.Text = DateTime.Now.ToString("MMM dd, yyyy")
    End Sub

    Public Sub StartOver()
        Array.Clear(infos, 0, infos.Length)

        For Each txtBx As TextBox In Me.Controls.OfType(Of TextBox)
            txtBx.Text = ""
        Next

        Me.Close()
    End Sub

    Public Function SplitName(ByVal fullName As String) As String()
        Dim nameSurname(2) As String
        Dim nameSurnameTemp() As String = fullName.Split(" ")
        For i = 0 To nameSurnameTemp.Length - 1
            If i < nameSurnameTemp.Length - 1 Then
                If Not (String.IsNullOrEmpty(nameSurname(0))) Then
                    nameSurname(0) += " " & nameSurnameTemp(i)
                Else
                    nameSurname(0) += nameSurnameTemp(i)
                End If
            Else
                nameSurname(1) = nameSurnameTemp(i)
            End If
        Next
        Return nameSurname
    End Function
End Class