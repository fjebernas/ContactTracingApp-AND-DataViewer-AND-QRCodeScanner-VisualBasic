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
        Me.labelDate = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnNO = New System.Windows.Forms.Button()
        Me.btnYES = New System.Windows.Forms.Button()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelHeader = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtBxQuesThree = New System.Windows.Forms.TextBox()
        Me.txtBxQuesTwo = New System.Windows.Forms.TextBox()
        Me.txtBxQuesOne = New System.Windows.Forms.TextBox()
        Me.txtBxGender = New System.Windows.Forms.TextBox()
        Me.txtBxAge = New System.Windows.Forms.TextBox()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.txtBxContactNo = New System.Windows.Forms.TextBox()
        Me.txtBxName = New System.Windows.Forms.TextBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(226, 648)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(244, 22)
        Me.label1.TabIndex = 49
        Me.label1.Text = "Are these details correct?"
        '
        'btnNO
        '
        Me.btnNO.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnNO.FlatAppearance.BorderSize = 0
        Me.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btnNO.Location = New System.Drawing.Point(364, 684)
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
        Me.btnYES.Location = New System.Drawing.Point(116, 684)
        Me.btnYES.Name = "btnYES"
        Me.btnYES.Size = New System.Drawing.Size(214, 44)
        Me.btnYES.TabIndex = 47
        Me.btnYES.Text = "YES, these are correct"
        Me.btnYES.UseVisualStyleBackColor = False
        '
        'labelName
        '
        Me.labelName.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(125, 30)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(322, 33)
        Me.labelName.TabIndex = 46
        Me.labelName.Text = """Name""'s"
        Me.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(45, 281)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(589, 21)
        Me.label6.TabIndex = 35
        Me.label6.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(502, 145)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(74, 21)
        Me.label5.TabIndex = 36
        Me.label5.Text = "Gender:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(392, 145)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(48, 21)
        Me.label4.TabIndex = 37
        Me.label4.Text = "Age:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(45, 380)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(579, 21)
        Me.label7.TabIndex = 38
        Me.label7.Text = "Have you come into contact with anyone who has traveled outside your "
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label10.Location = New System.Drawing.Point(45, 522)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(348, 21)
        Me.label10.TabIndex = 40
        Me.label10.Text = "(e.g. fever, cough, breathing difficulty, etc.)"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label9.Location = New System.Drawing.Point(46, 501)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(306, 21)
        Me.label9.TabIndex = 39
        Me.label9.Text = "Health conditions or flu-like symptoms: "
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(45, 406)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(421, 21)
        Me.label8.TabIndex = 41
        Me.label8.Text = "country between the period of last month until now?"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(304, 213)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 21)
        Me.label3.TabIndex = 42
        Me.label3.Text = "Address:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label11.Location = New System.Drawing.Point(45, 213)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(110, 21)
        Me.label11.TabIndex = 43
        Me.label11.Text = "Contact no.:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(45, 149)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 21)
        Me.label2.TabIndex = 44
        Me.label2.Text = "Full name:"
        '
        'txtBxQuesThree
        '
        Me.txtBxQuesThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxQuesThree.Location = New System.Drawing.Point(50, 555)
        Me.txtBxQuesThree.Multiline = True
        Me.txtBxQuesThree.Name = "txtBxQuesThree"
        Me.txtBxQuesThree.ReadOnly = True
        Me.txtBxQuesThree.Size = New System.Drawing.Size(604, 60)
        Me.txtBxQuesThree.TabIndex = 27
        '
        'txtBxQuesTwo
        '
        Me.txtBxQuesTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxQuesTwo.Location = New System.Drawing.Point(49, 447)
        Me.txtBxQuesTwo.Multiline = True
        Me.txtBxQuesTwo.Name = "txtBxQuesTwo"
        Me.txtBxQuesTwo.ReadOnly = True
        Me.txtBxQuesTwo.Size = New System.Drawing.Size(100, 30)
        Me.txtBxQuesTwo.TabIndex = 28
        '
        'txtBxQuesOne
        '
        Me.txtBxQuesOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxQuesOne.Location = New System.Drawing.Point(49, 324)
        Me.txtBxQuesOne.Multiline = True
        Me.txtBxQuesOne.Name = "txtBxQuesOne"
        Me.txtBxQuesOne.ReadOnly = True
        Me.txtBxQuesOne.Size = New System.Drawing.Size(100, 30)
        Me.txtBxQuesOne.TabIndex = 29
        '
        'txtBxGender
        '
        Me.txtBxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGender.Location = New System.Drawing.Point(582, 143)
        Me.txtBxGender.Multiline = True
        Me.txtBxGender.Name = "txtBxGender"
        Me.txtBxGender.ReadOnly = True
        Me.txtBxGender.Size = New System.Drawing.Size(72, 30)
        Me.txtBxGender.TabIndex = 30
        '
        'txtBxAge
        '
        Me.txtBxAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAge.Location = New System.Drawing.Point(446, 143)
        Me.txtBxAge.Multiline = True
        Me.txtBxAge.Name = "txtBxAge"
        Me.txtBxAge.ReadOnly = True
        Me.txtBxAge.Size = New System.Drawing.Size(45, 30)
        Me.txtBxAge.TabIndex = 31
        '
        'txtBxAddress
        '
        Me.txtBxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.Location = New System.Drawing.Point(386, 211)
        Me.txtBxAddress.Multiline = True
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.ReadOnly = True
        Me.txtBxAddress.Size = New System.Drawing.Size(268, 30)
        Me.txtBxAddress.TabIndex = 32
        '
        'txtBxContactNo
        '
        Me.txtBxContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxContactNo.Location = New System.Drawing.Point(161, 211)
        Me.txtBxContactNo.Multiline = True
        Me.txtBxContactNo.Name = "txtBxContactNo"
        Me.txtBxContactNo.ReadOnly = True
        Me.txtBxContactNo.Size = New System.Drawing.Size(127, 30)
        Me.txtBxContactNo.TabIndex = 34
        '
        'txtBxName
        '
        Me.txtBxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxName.Location = New System.Drawing.Point(139, 143)
        Me.txtBxName.Multiline = True
        Me.txtBxName.Name = "txtBxName"
        Me.txtBxName.ReadOnly = True
        Me.txtBxName.Size = New System.Drawing.Size(213, 30)
        Me.txtBxName.TabIndex = 33
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'FormQRCodeResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(707, 758)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnNO)
        Me.Controls.Add(Me.btnYES)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.labelHeader)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtBxQuesThree)
        Me.Controls.Add(Me.txtBxQuesTwo)
        Me.Controls.Add(Me.txtBxQuesOne)
        Me.Controls.Add(Me.txtBxGender)
        Me.Controls.Add(Me.txtBxAge)
        Me.Controls.Add(Me.txtBxAddress)
        Me.Controls.Add(Me.txtBxContactNo)
        Me.Controls.Add(Me.txtBxName)
        Me.Name = "FormQRCodeResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormQRCodeResult"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents labelDate As Label
    Private WithEvents labelTime As Label
    Private WithEvents label1 As Label
    Private WithEvents btnNO As Button
    Private WithEvents btnYES As Button
    Private WithEvents labelName As Label
    Private WithEvents labelHeader As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label7 As Label
    Private WithEvents label10 As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label3 As Label
    Private WithEvents label11 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtBxQuesThree As TextBox
    Private WithEvents txtBxQuesTwo As TextBox
    Private WithEvents txtBxQuesOne As TextBox
    Private WithEvents txtBxGender As TextBox
    Private WithEvents txtBxAge As TextBox
    Private WithEvents txtBxAddress As TextBox
    Private WithEvents txtBxContactNo As TextBox
    Private WithEvents txtBxName As TextBox
    Friend WithEvents timer As Timer
End Class
