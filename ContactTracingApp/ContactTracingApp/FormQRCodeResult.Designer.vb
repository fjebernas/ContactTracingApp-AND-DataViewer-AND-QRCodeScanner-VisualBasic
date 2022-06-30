<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQRCodeResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQRCodeResult))
        Me.labelDate = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.lblINFOConfirm = New System.Windows.Forms.Label()
        Me.btnNO = New System.Windows.Forms.Button()
        Me.btnYES = New System.Windows.Forms.Button()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelHeader = New System.Windows.Forms.Label()
        Me.lblINFOQuesOne = New System.Windows.Forms.Label()
        Me.lblINFOGender = New System.Windows.Forms.Label()
        Me.lblINFOAge = New System.Windows.Forms.Label()
        Me.lblINFOQuesTwo1 = New System.Windows.Forms.Label()
        Me.lblINFOQuesThree2 = New System.Windows.Forms.Label()
        Me.lblINFOQuesThree1 = New System.Windows.Forms.Label()
        Me.lblINFOQuesTwo2 = New System.Windows.Forms.Label()
        Me.lblINFOAddress = New System.Windows.Forms.Label()
        Me.lblINFOContactNo = New System.Windows.Forms.Label()
        Me.lblINFOFN = New System.Windows.Forms.Label()
        Me.txtBxQuesThree = New System.Windows.Forms.TextBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblFN = New System.Windows.Forms.Label()
        Me.lblContactno = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblQuesOneAns = New System.Windows.Forms.Label()
        Me.lblQuesTwoAns = New System.Windows.Forms.Label()
        Me.picBxLogo = New System.Windows.Forms.PictureBox()
        Me.lblINFOSelectedType = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        CType(Me.picBxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDate.ForeColor = System.Drawing.Color.DarkSalmon
        Me.labelDate.Location = New System.Drawing.Point(536, 75)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(125, 22)
        Me.labelDate.TabIndex = 51
        Me.labelDate.Text = "Feb 12, 2022"
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTime.ForeColor = System.Drawing.Color.PeachPuff
        Me.labelTime.Location = New System.Drawing.Point(535, 43)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(121, 22)
        Me.labelTime.TabIndex = 50
        Me.labelTime.Text = "12:00:00 am"
        '
        'lblINFOConfirm
        '
        Me.lblINFOConfirm.AutoSize = True
        Me.lblINFOConfirm.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblINFOConfirm.Location = New System.Drawing.Point(226, 595)
        Me.lblINFOConfirm.Name = "lblINFOConfirm"
        Me.lblINFOConfirm.Size = New System.Drawing.Size(244, 22)
        Me.lblINFOConfirm.TabIndex = 49
        Me.lblINFOConfirm.Text = "Are these details correct?"
        '
        'btnNO
        '
        Me.btnNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnNO.FlatAppearance.BorderSize = 0
        Me.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnNO.Location = New System.Drawing.Point(364, 631)
        Me.btnNO.Name = "btnNO"
        Me.btnNO.Size = New System.Drawing.Size(232, 44)
        Me.btnNO.TabIndex = 48
        Me.btnNO.Text = "NO, these are incorrect"
        Me.btnNO.UseVisualStyleBackColor = False
        '
        'btnYES
        '
        Me.btnYES.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnYES.FlatAppearance.BorderSize = 0
        Me.btnYES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnYES.Location = New System.Drawing.Point(116, 631)
        Me.btnYES.Name = "btnYES"
        Me.btnYES.Size = New System.Drawing.Size(214, 44)
        Me.btnYES.TabIndex = 47
        Me.btnYES.Text = "YES, these are correct"
        Me.btnYES.UseVisualStyleBackColor = False
        '
        'labelName
        '
        Me.labelName.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(125, 30)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(315, 33)
        Me.labelName.TabIndex = 46
        Me.labelName.Text = """Name""'s"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHeader
        '
        Me.labelHeader.AutoSize = True
        Me.labelHeader.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.labelHeader.Location = New System.Drawing.Point(125, 64)
        Me.labelHeader.Name = "labelHeader"
        Me.labelHeader.Size = New System.Drawing.Size(322, 33)
        Me.labelHeader.TabIndex = 45
        Me.labelHeader.Text = "Contact Tracing Details"
        '
        'lblINFOQuesOne
        '
        Me.lblINFOQuesOne.AutoSize = True
        Me.lblINFOQuesOne.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOQuesOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOQuesOne.Location = New System.Drawing.Point(45, 258)
        Me.lblINFOQuesOne.Name = "lblINFOQuesOne"
        Me.lblINFOQuesOne.Size = New System.Drawing.Size(589, 21)
        Me.lblINFOQuesOne.TabIndex = 35
        Me.lblINFOQuesOne.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'lblINFOGender
        '
        Me.lblINFOGender.AutoSize = True
        Me.lblINFOGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOGender.Location = New System.Drawing.Point(502, 164)
        Me.lblINFOGender.Name = "lblINFOGender"
        Me.lblINFOGender.Size = New System.Drawing.Size(74, 21)
        Me.lblINFOGender.TabIndex = 36
        Me.lblINFOGender.Text = "Gender:"
        '
        'lblINFOAge
        '
        Me.lblINFOAge.AutoSize = True
        Me.lblINFOAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOAge.Location = New System.Drawing.Point(392, 164)
        Me.lblINFOAge.Name = "lblINFOAge"
        Me.lblINFOAge.Size = New System.Drawing.Size(48, 21)
        Me.lblINFOAge.TabIndex = 37
        Me.lblINFOAge.Text = "Age:"
        '
        'lblINFOQuesTwo1
        '
        Me.lblINFOQuesTwo1.AutoSize = True
        Me.lblINFOQuesTwo1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOQuesTwo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOQuesTwo1.Location = New System.Drawing.Point(45, 357)
        Me.lblINFOQuesTwo1.Name = "lblINFOQuesTwo1"
        Me.lblINFOQuesTwo1.Size = New System.Drawing.Size(579, 21)
        Me.lblINFOQuesTwo1.TabIndex = 38
        Me.lblINFOQuesTwo1.Text = "Have you come into contact with anyone who has traveled outside your "
        '
        'lblINFOQuesThree2
        '
        Me.lblINFOQuesThree2.AutoSize = True
        Me.lblINFOQuesThree2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOQuesThree2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOQuesThree2.Location = New System.Drawing.Point(45, 499)
        Me.lblINFOQuesThree2.Name = "lblINFOQuesThree2"
        Me.lblINFOQuesThree2.Size = New System.Drawing.Size(348, 21)
        Me.lblINFOQuesThree2.TabIndex = 40
        Me.lblINFOQuesThree2.Text = "(e.g. fever, cough, breathing difficulty, etc.)"
        '
        'lblINFOQuesThree1
        '
        Me.lblINFOQuesThree1.AutoSize = True
        Me.lblINFOQuesThree1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOQuesThree1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOQuesThree1.Location = New System.Drawing.Point(46, 478)
        Me.lblINFOQuesThree1.Name = "lblINFOQuesThree1"
        Me.lblINFOQuesThree1.Size = New System.Drawing.Size(306, 21)
        Me.lblINFOQuesThree1.TabIndex = 39
        Me.lblINFOQuesThree1.Text = "Health conditions or flu-like symptoms: "
        '
        'lblINFOQuesTwo2
        '
        Me.lblINFOQuesTwo2.AutoSize = True
        Me.lblINFOQuesTwo2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOQuesTwo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOQuesTwo2.Location = New System.Drawing.Point(45, 383)
        Me.lblINFOQuesTwo2.Name = "lblINFOQuesTwo2"
        Me.lblINFOQuesTwo2.Size = New System.Drawing.Size(421, 21)
        Me.lblINFOQuesTwo2.TabIndex = 41
        Me.lblINFOQuesTwo2.Text = "country between the period of last month until now?"
        '
        'lblINFOAddress
        '
        Me.lblINFOAddress.AutoSize = True
        Me.lblINFOAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOAddress.Location = New System.Drawing.Point(278, 211)
        Me.lblINFOAddress.Name = "lblINFOAddress"
        Me.lblINFOAddress.Size = New System.Drawing.Size(76, 21)
        Me.lblINFOAddress.TabIndex = 42
        Me.lblINFOAddress.Text = "Address:"
        '
        'lblINFOContactNo
        '
        Me.lblINFOContactNo.AutoSize = True
        Me.lblINFOContactNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOContactNo.Location = New System.Drawing.Point(45, 211)
        Me.lblINFOContactNo.Name = "lblINFOContactNo"
        Me.lblINFOContactNo.Size = New System.Drawing.Size(110, 21)
        Me.lblINFOContactNo.TabIndex = 43
        Me.lblINFOContactNo.Text = "Contact no.:"
        '
        'lblINFOFN
        '
        Me.lblINFOFN.AutoSize = True
        Me.lblINFOFN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOFN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOFN.Location = New System.Drawing.Point(67, 168)
        Me.lblINFOFN.Name = "lblINFOFN"
        Me.lblINFOFN.Size = New System.Drawing.Size(88, 21)
        Me.lblINFOFN.TabIndex = 44
        Me.lblINFOFN.Text = "Full name:"
        '
        'txtBxQuesThree
        '
        Me.txtBxQuesThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtBxQuesThree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxQuesThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxQuesThree.ForeColor = System.Drawing.Color.PaleGreen
        Me.txtBxQuesThree.Location = New System.Drawing.Point(50, 537)
        Me.txtBxQuesThree.Multiline = True
        Me.txtBxQuesThree.Name = "txtBxQuesThree"
        Me.txtBxQuesThree.ReadOnly = True
        Me.txtBxQuesThree.Size = New System.Drawing.Size(604, 60)
        Me.txtBxQuesThree.TabIndex = 27
        Me.txtBxQuesThree.Text = "Answer"
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'lblFN
        '
        Me.lblFN.AutoSize = True
        Me.lblFN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblFN.Location = New System.Drawing.Point(157, 168)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(86, 21)
        Me.lblFN.TabIndex = 44
        Me.lblFN.Text = "Full Name"
        '
        'lblContactno
        '
        Me.lblContactno.AutoSize = True
        Me.lblContactno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactno.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblContactno.Location = New System.Drawing.Point(157, 211)
        Me.lblContactno.Name = "lblContactno"
        Me.lblContactno.Size = New System.Drawing.Size(100, 21)
        Me.lblContactno.TabIndex = 44
        Me.lblContactno.Text = "0955555555"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblAddress.Location = New System.Drawing.Point(354, 211)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 21)
        Me.lblAddress.TabIndex = 44
        Me.lblAddress.Text = "Address"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblGender.Location = New System.Drawing.Point(575, 164)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 21)
        Me.lblGender.TabIndex = 44
        Me.lblGender.Text = "XXXXXX"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblAge.Location = New System.Drawing.Point(440, 164)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 44
        Me.lblAge.Text = "Age"
        '
        'lblQuesOneAns
        '
        Me.lblQuesOneAns.AutoSize = True
        Me.lblQuesOneAns.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuesOneAns.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblQuesOneAns.Location = New System.Drawing.Point(46, 293)
        Me.lblQuesOneAns.Name = "lblQuesOneAns"
        Me.lblQuesOneAns.Size = New System.Drawing.Size(68, 21)
        Me.lblQuesOneAns.TabIndex = 44
        Me.lblQuesOneAns.Text = "Answer"
        '
        'lblQuesTwoAns
        '
        Me.lblQuesTwoAns.AutoSize = True
        Me.lblQuesTwoAns.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuesTwoAns.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblQuesTwoAns.Location = New System.Drawing.Point(46, 419)
        Me.lblQuesTwoAns.Name = "lblQuesTwoAns"
        Me.lblQuesTwoAns.Size = New System.Drawing.Size(68, 21)
        Me.lblQuesTwoAns.TabIndex = 44
        Me.lblQuesTwoAns.Text = "Answer"
        '
        'picBxLogo
        '
        Me.picBxLogo.BackColor = System.Drawing.Color.Transparent
        Me.picBxLogo.Image = CType(resources.GetObject("picBxLogo.Image"), System.Drawing.Image)
        Me.picBxLogo.Location = New System.Drawing.Point(48, 30)
        Me.picBxLogo.Name = "picBxLogo"
        Me.picBxLogo.Size = New System.Drawing.Size(71, 67)
        Me.picBxLogo.TabIndex = 52
        Me.picBxLogo.TabStop = False
        '
        'lblINFOSelectedType
        '
        Me.lblINFOSelectedType.AutoSize = True
        Me.lblINFOSelectedType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFOSelectedType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblINFOSelectedType.Location = New System.Drawing.Point(32, 128)
        Me.lblINFOSelectedType.Name = "lblINFOSelectedType"
        Me.lblINFOSelectedType.Size = New System.Drawing.Size(123, 21)
        Me.lblINFOSelectedType.TabIndex = 44
        Me.lblINFOSelectedType.Text = "Selected type:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblType.Location = New System.Drawing.Point(157, 128)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(47, 21)
        Me.lblType.TabIndex = 44
        Me.lblType.Text = "Type"
        '
        'FormQRCodeResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 716)
        Me.Controls.Add(Me.picBxLogo)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.lblINFOConfirm)
        Me.Controls.Add(Me.btnNO)
        Me.Controls.Add(Me.btnYES)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.labelHeader)
        Me.Controls.Add(Me.lblINFOQuesOne)
        Me.Controls.Add(Me.lblINFOGender)
        Me.Controls.Add(Me.lblINFOAge)
        Me.Controls.Add(Me.lblINFOQuesTwo1)
        Me.Controls.Add(Me.lblINFOQuesThree2)
        Me.Controls.Add(Me.lblINFOQuesThree1)
        Me.Controls.Add(Me.lblINFOQuesTwo2)
        Me.Controls.Add(Me.lblINFOAddress)
        Me.Controls.Add(Me.lblINFOContactNo)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblQuesTwoAns)
        Me.Controls.Add(Me.lblQuesOneAns)
        Me.Controls.Add(Me.lblContactno)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblINFOSelectedType)
        Me.Controls.Add(Me.lblFN)
        Me.Controls.Add(Me.lblINFOFN)
        Me.Controls.Add(Me.txtBxQuesThree)
        Me.Name = "FormQRCodeResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormQRCodeResult"
        CType(Me.picBxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelDate As Label
    Private WithEvents labelTime As Label
    Private WithEvents lblINFOConfirm As Label
    Private WithEvents btnNO As Button
    Private WithEvents btnYES As Button
    Private WithEvents labelName As Label
    Private WithEvents labelHeader As Label
    Private WithEvents lblINFOQuesOne As Label
    Private WithEvents lblINFOGender As Label
    Private WithEvents lblINFOAge As Label
    Private WithEvents lblINFOQuesTwo1 As Label
    Private WithEvents lblINFOQuesThree2 As Label
    Private WithEvents lblINFOQuesThree1 As Label
    Private WithEvents lblINFOQuesTwo2 As Label
    Private WithEvents lblINFOAddress As Label
    Private WithEvents lblINFOContactNo As Label
    Private WithEvents lblINFOFN As Label
    Private WithEvents txtBxQuesThree As TextBox
    Friend WithEvents timer As Timer
    Private WithEvents lblFN As Label
    Private WithEvents lblContactno As Label
    Private WithEvents lblAddress As Label
    Private WithEvents lblGender As Label
    Private WithEvents lblAge As Label
    Private WithEvents lblQuesOneAns As Label
    Private WithEvents lblQuesTwoAns As Label
    Friend WithEvents picBxLogo As PictureBox
    Private WithEvents lblINFOSelectedType As Label
    Private WithEvents lblType As Label
End Class
