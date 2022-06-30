Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing

Public Class FormQRCodeScanner
    Dim formMain As FormMain

    Dim filterInfoCollection As FilterInfoCollection
    Dim captureDevice As VideoCaptureDevice

    Dim isCameraRunning As Boolean

    Public Sub New(ByVal passedForm As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        formMain = passedForm
    End Sub

    Private Sub FormQRCodeScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        For Each device As FilterInfo In filterInfoCollection
            cboBxDevices.Items.Add(device.Name)
            cboBxDevices.SelectedIndex = 0
        Next
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not (isCameraRunning) Then
            captureDevice = New VideoCaptureDevice(filterInfoCollection(cboBxDevices.SelectedIndex).MonikerString)
            AddHandler captureDevice.NewFrame, AddressOf CaptureDevice_NewFrame
            captureDevice.Start()
            isCameraRunning = True
            timer.Start()
            btnStart.Text = "Stop"
        ElseIf isCameraRunning Then
            DevicesReset()
        End If
    End Sub

    Private Sub CaptureDevice_NewFrame(sender As Object, eventArgs As AForge.Video.NewFrameEventArgs)
        pictureBox.Image = CType(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub FormQRCodeScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isCameraRunning Then
            captureDevice.Stop()
        End If
        formMain.Show()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If pictureBox.Image IsNot Nothing Then
            Dim barcodeReader As BarcodeReader = New BarcodeReader()
            Dim result As Result = barcodeReader.Decode(CType(pictureBox.Image, Bitmap))
            If result IsNot Nothing Then
                DevicesReset()

                Dim formQRCodeResult As FormQRCodeResult = New FormQRCodeResult(result)
                formQRCodeResult.Show()
            End If
        End If
    End Sub

    Public Sub DevicesReset()
        If isCameraRunning Then
            captureDevice.Stop()
        End If

        If pictureBox.Image IsNot Nothing Then
            pictureBox.Image = Nothing
        End If

        isCameraRunning = False
        btnStart.Text = "Start"
    End Sub
End Class