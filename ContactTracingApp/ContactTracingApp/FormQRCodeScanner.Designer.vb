<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQRCodeScanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQRCodeScanner))
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.cboBxDevices = New System.Windows.Forms.ComboBox()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(167, 83)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(189, 30)
        Me.label2.TabIndex = 10
        Me.label2.Text = "using QR code"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(73, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(379, 42)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Contact Tracing App"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(37, 568)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(445, 44)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'pictureBox
        '
        Me.pictureBox.BackgroundImage = CType(resources.GetObject("pictureBox.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox.InitialImage = Nothing
        Me.pictureBox.Location = New System.Drawing.Point(37, 144)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(445, 407)
        Me.pictureBox.TabIndex = 8
        Me.pictureBox.TabStop = False
        '
        'cboBxDevices
        '
        Me.cboBxDevices.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.cboBxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBxDevices.FormattingEnabled = True
        Me.cboBxDevices.Location = New System.Drawing.Point(14, 15)
        Me.cboBxDevices.Name = "cboBxDevices"
        Me.cboBxDevices.Size = New System.Drawing.Size(21, 21)
        Me.cboBxDevices.TabIndex = 7
        Me.cboBxDevices.Visible = False
        '
        'FormQRCodeScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 642)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.cboBxDevices)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormQRCodeScanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing App - QR Code Scanner"
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnStart As Button
    Private WithEvents pictureBox As PictureBox
    Private WithEvents cboBxDevices As ComboBox
End Class
