Imports System.IO

Public Class FormAdmin
    Dim formMain As FormMain
    Dim formAdminLogin As FormAdminLogin
    Dim fileNames() As String
    Dim colorOn As Color = Color.FromArgb(10, 112, 41)
    Dim colorOff As Color = Color.FromArgb(180, 170, 169)

    Dim indexListBx As Byte

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

    Private Sub ClearControls()
        For Each txtBx As TextBox In panelContent.Controls.OfType(Of TextBox)
            txtBx.Text = ""
        Next
        For Each answer As Label In gbxFirstQuestion.Controls.OfType(Of Label)
            answer.ForeColor = colorOff
        Next
        For Each answer As Label In gbxSecondQuestion.Controls.OfType(Of Label)
            answer.ForeColor = colorOff
        Next
        For Each symptom As Label In gbxSymptoms.Controls.OfType(Of Label)
            symptom.ForeColor = colorOff
        Next
    End Sub

    Private Sub linklblGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblGithub.LinkClicked
        Process.Start("https://github.com/fjebernas/ContactTracingApp-AND-DataViewer-VisualBasic")
    End Sub

    Private Sub listBxEntries_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listBxEntries.MouseDoubleClick
        indexListBx = listBxEntries.IndexFromPoint(e.Location)
        If Not (indexListBx = ListBox.NoMatches) Then
            DisplayData(indexListBx)
        End If
    End Sub

    Private Sub DisplayData(ByRef indexListBx As Byte)
        ClearControls()
        Dim lines() As String
        lines = File.ReadAllLines(User.PATH & listBxEntries.Items(indexListBx) & ".txt")
        lblSelected.Text = lines(0).Replace("Selected type: ", "")
        lblDate.Text = lines(2).Replace("Time submitted: ", "")
        txtBxFirstName.Text = lines(5).Replace("   First name: ", "")
        txtBxMiddleName.Text = lines(6).Replace("   Middle name: ", "")
        txtBxLastName.Text = lines(7).Replace("   Last name: ", "")
        txtBxAge.Text = lines(8).Replace("   Age: ", "")
        txtBxCpNum.Text = lines(9).Replace("   Phone number: ", "")
        txtBxAddress.Text = lines(10).Replace("   Address: ", "")
        txtBxGender.Text = lines(11).Replace("   Gender: ", "")
        If lines(15).Equals("   Answer => Yes") Then
            lblFirstQuestionYes.ForeColor = colorOn
        Else
            lblFirstQuestionNo.ForeColor = colorOn
        End If
        If lines(17).Equals("   Answer => Yes") Then
            lblSecondQuestionYes.ForeColor = colorOn
        ElseIf lines(17).Equals("   Answer => No") Then
            lblSecondQuestionNo.ForeColor = colorOn
        Else
            lblSecondQuestionNS.ForeColor = colorOn
        End If
        For Each line As String In lines
            Select Case line
                Case "   Fever"
                    lblFever.ForeColor = colorOn
                Case "   Cough"
                    lblCough.ForeColor = colorOn
                Case "   Difficulty breathing"
                    lblDB.ForeColor = colorOn
                Case "   Loss of taste or smell"
                    lblLossOfTasteAndSmell.ForeColor = colorOn
                Case "   Sore throat"
                    lblSoreThroat.ForeColor = colorOn
                Case "   Diarrhea"
                    lblDiarrhea.ForeColor = colorOn
                Case "   Chest pain"
                    lblChestPain.ForeColor = colorOn
                Case "   Tiredness"
                    lblTiredness.ForeColor = colorOn
                Case "   Headaches"
                    lblHeadaches.ForeColor = colorOn
            End Select
        Next
    End Sub
End Class