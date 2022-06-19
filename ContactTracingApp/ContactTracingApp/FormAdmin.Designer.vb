<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.listBxEntries = New System.Windows.Forms.ListBox()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSelectedLabel = New System.Windows.Forms.Label()
        Me.chkBxDB = New System.Windows.Forms.CheckBox()
        Me.chkBxCough = New System.Windows.Forms.CheckBox()
        Me.chkBxDiarrhea = New System.Windows.Forms.CheckBox()
        Me.chkBxSoreThroat = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chBxLossOfTasteAndSmell = New System.Windows.Forms.CheckBox()
        Me.chkBxFever = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.gbxFirstQuestion = New System.Windows.Forms.GroupBox()
        Me.rdoFirstQuestionNo = New System.Windows.Forms.RadioButton()
        Me.rdoFirstQuestionYes = New System.Windows.Forms.RadioButton()
        Me.lblThirdQuestion1 = New System.Windows.Forms.Label()
        Me.lblSecondQuestion2 = New System.Windows.Forms.Label()
        Me.lblSecondQuestion1 = New System.Windows.Forms.Label()
        Me.lblFirstQuestion = New System.Windows.Forms.Label()
        Me.txtBxCpNum = New System.Windows.Forms.TextBox()
        Me.lblCPnum = New System.Windows.Forms.Label()
        Me.txtBxGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtBxAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtBxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.panelTop.SuspendLayout()
        Me.panelNav.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxFirstQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(944, 85)
        Me.panelTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing Data Viewer"
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 571)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(944, 48)
        Me.panelBottom.TabIndex = 1
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelNav.Controls.Add(Me.btnDisplayData)
        Me.panelNav.Controls.Add(Me.listBxEntries)
        Me.panelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelNav.Location = New System.Drawing.Point(0, 85)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(265, 486)
        Me.panelNav.TabIndex = 2
        '
        'listBxEntries
        '
        Me.listBxEntries.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBxEntries.FormattingEnabled = True
        Me.listBxEntries.ItemHeight = 17
        Me.listBxEntries.Location = New System.Drawing.Point(24, 54)
        Me.listBxEntries.Name = "listBxEntries"
        Me.listBxEntries.Size = New System.Drawing.Size(220, 378)
        Me.listBxEntries.TabIndex = 0
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.lblDate)
        Me.panelContent.Controls.Add(Me.lblSelected)
        Me.panelContent.Controls.Add(Me.lblSelectedLabel)
        Me.panelContent.Controls.Add(Me.chkBxDB)
        Me.panelContent.Controls.Add(Me.chkBxCough)
        Me.panelContent.Controls.Add(Me.chkBxDiarrhea)
        Me.panelContent.Controls.Add(Me.chkBxSoreThroat)
        Me.panelContent.Controls.Add(Me.CheckBox3)
        Me.panelContent.Controls.Add(Me.CheckBox2)
        Me.panelContent.Controls.Add(Me.CheckBox1)
        Me.panelContent.Controls.Add(Me.chBxLossOfTasteAndSmell)
        Me.panelContent.Controls.Add(Me.chkBxFever)
        Me.panelContent.Controls.Add(Me.GroupBox1)
        Me.panelContent.Controls.Add(Me.gbxFirstQuestion)
        Me.panelContent.Controls.Add(Me.lblThirdQuestion1)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion2)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion1)
        Me.panelContent.Controls.Add(Me.lblFirstQuestion)
        Me.panelContent.Controls.Add(Me.txtBxCpNum)
        Me.panelContent.Controls.Add(Me.lblCPnum)
        Me.panelContent.Controls.Add(Me.txtBxGender)
        Me.panelContent.Controls.Add(Me.lblGender)
        Me.panelContent.Controls.Add(Me.txtBxAddress)
        Me.panelContent.Controls.Add(Me.lblAddress)
        Me.panelContent.Controls.Add(Me.txtBxAge)
        Me.panelContent.Controls.Add(Me.lblAge)
        Me.panelContent.Controls.Add(Me.txtBxLastName)
        Me.panelContent.Controls.Add(Me.lblLastName)
        Me.panelContent.Controls.Add(Me.txtBxMiddleName)
        Me.panelContent.Controls.Add(Me.lblMiddleName)
        Me.panelContent.Controls.Add(Me.txtBxFirstName)
        Me.panelContent.Controls.Add(Me.lblFirstName)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(265, 85)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(679, 486)
        Me.panelContent.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(382, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 18)
        Me.lblDate.TabIndex = 113
        Me.lblDate.Text = "**Date**"
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.Gray
        Me.lblSelected.Location = New System.Drawing.Point(122, 13)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(140, 19)
        Me.lblSelected.TabIndex = 111
        Me.lblSelected.Text = "**selected type**"
        '
        'lblSelectedLabel
        '
        Me.lblSelectedLabel.AutoSize = True
        Me.lblSelectedLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedLabel.ForeColor = System.Drawing.Color.Black
        Me.lblSelectedLabel.Location = New System.Drawing.Point(33, 12)
        Me.lblSelectedLabel.Name = "lblSelectedLabel"
        Me.lblSelectedLabel.Size = New System.Drawing.Size(92, 21)
        Me.lblSelectedLabel.TabIndex = 112
        Me.lblSelectedLabel.Text = "Selected is"
        '
        'chkBxDB
        '
        Me.chkBxDB.AutoSize = True
        Me.chkBxDB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxDB.Location = New System.Drawing.Point(39, 448)
        Me.chkBxDB.Name = "chkBxDB"
        Me.chkBxDB.Size = New System.Drawing.Size(151, 20)
        Me.chkBxDB.TabIndex = 110
        Me.chkBxDB.Text = "Difficulty breathing"
        Me.chkBxDB.UseVisualStyleBackColor = True
        '
        'chkBxCough
        '
        Me.chkBxCough.AutoSize = True
        Me.chkBxCough.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxCough.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxCough.Location = New System.Drawing.Point(39, 421)
        Me.chkBxCough.Name = "chkBxCough"
        Me.chkBxCough.Size = New System.Drawing.Size(69, 20)
        Me.chkBxCough.TabIndex = 109
        Me.chkBxCough.Text = "Cough"
        Me.chkBxCough.UseVisualStyleBackColor = True
        '
        'chkBxDiarrhea
        '
        Me.chkBxDiarrhea.AutoSize = True
        Me.chkBxDiarrhea.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxDiarrhea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxDiarrhea.Location = New System.Drawing.Point(238, 448)
        Me.chkBxDiarrhea.Name = "chkBxDiarrhea"
        Me.chkBxDiarrhea.Size = New System.Drawing.Size(83, 20)
        Me.chkBxDiarrhea.TabIndex = 102
        Me.chkBxDiarrhea.Text = "Diarrhea"
        Me.chkBxDiarrhea.UseVisualStyleBackColor = True
        '
        'chkBxSoreThroat
        '
        Me.chkBxSoreThroat.AutoSize = True
        Me.chkBxSoreThroat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxSoreThroat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxSoreThroat.Location = New System.Drawing.Point(238, 421)
        Me.chkBxSoreThroat.Name = "chkBxSoreThroat"
        Me.chkBxSoreThroat.Size = New System.Drawing.Size(96, 20)
        Me.chkBxSoreThroat.TabIndex = 103
        Me.chkBxSoreThroat.Text = "Sore throat"
        Me.chkBxSoreThroat.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(464, 448)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox3.TabIndex = 104
        Me.CheckBox3.Text = "Headaches"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(464, 421)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(86, 20)
        Me.CheckBox2.TabIndex = 105
        Me.CheckBox2.Text = "Tiredness"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(464, 394)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 20)
        Me.CheckBox1.TabIndex = 106
        Me.CheckBox1.Text = "Chest pain"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chBxLossOfTasteAndSmell
        '
        Me.chBxLossOfTasteAndSmell.AutoSize = True
        Me.chBxLossOfTasteAndSmell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBxLossOfTasteAndSmell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chBxLossOfTasteAndSmell.Location = New System.Drawing.Point(238, 394)
        Me.chBxLossOfTasteAndSmell.Name = "chBxLossOfTasteAndSmell"
        Me.chBxLossOfTasteAndSmell.Size = New System.Drawing.Size(158, 20)
        Me.chBxLossOfTasteAndSmell.TabIndex = 107
        Me.chBxLossOfTasteAndSmell.Text = "Loss of taste or smell"
        Me.chBxLossOfTasteAndSmell.UseVisualStyleBackColor = True
        '
        'chkBxFever
        '
        Me.chkBxFever.AutoSize = True
        Me.chkBxFever.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxFever.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxFever.Location = New System.Drawing.Point(39, 394)
        Me.chkBxFever.Name = "chkBxFever"
        Me.chkBxFever.Size = New System.Drawing.Size(60, 20)
        Me.chkBxFever.TabIndex = 108
        Me.chkBxFever.Text = "Fever"
        Me.chkBxFever.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 42)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Maroon
        Me.RadioButton1.Location = New System.Drawing.Point(153, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 20)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "No"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkGreen
        Me.RadioButton2.Location = New System.Drawing.Point(11, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 20)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Yes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'gbxFirstQuestion
        '
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionNo)
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionYes)
        Me.gbxFirstQuestion.Location = New System.Drawing.Point(37, 204)
        Me.gbxFirstQuestion.Name = "gbxFirstQuestion"
        Me.gbxFirstQuestion.Size = New System.Drawing.Size(209, 42)
        Me.gbxFirstQuestion.TabIndex = 100
        Me.gbxFirstQuestion.TabStop = False
        '
        'rdoFirstQuestionNo
        '
        Me.rdoFirstQuestionNo.AutoSize = True
        Me.rdoFirstQuestionNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFirstQuestionNo.ForeColor = System.Drawing.Color.Maroon
        Me.rdoFirstQuestionNo.Location = New System.Drawing.Point(153, 15)
        Me.rdoFirstQuestionNo.Name = "rdoFirstQuestionNo"
        Me.rdoFirstQuestionNo.Size = New System.Drawing.Size(43, 20)
        Me.rdoFirstQuestionNo.TabIndex = 9
        Me.rdoFirstQuestionNo.TabStop = True
        Me.rdoFirstQuestionNo.Text = "No"
        Me.rdoFirstQuestionNo.UseVisualStyleBackColor = True
        '
        'rdoFirstQuestionYes
        '
        Me.rdoFirstQuestionYes.AutoSize = True
        Me.rdoFirstQuestionYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFirstQuestionYes.ForeColor = System.Drawing.Color.DarkGreen
        Me.rdoFirstQuestionYes.Location = New System.Drawing.Point(11, 15)
        Me.rdoFirstQuestionYes.Name = "rdoFirstQuestionYes"
        Me.rdoFirstQuestionYes.Size = New System.Drawing.Size(47, 20)
        Me.rdoFirstQuestionYes.TabIndex = 8
        Me.rdoFirstQuestionYes.TabStop = True
        Me.rdoFirstQuestionYes.Text = "Yes"
        Me.rdoFirstQuestionYes.UseVisualStyleBackColor = True
        '
        'lblThirdQuestion1
        '
        Me.lblThirdQuestion1.AutoSize = True
        Me.lblThirdQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion1.ForeColor = System.Drawing.Color.Black
        Me.lblThirdQuestion1.Location = New System.Drawing.Point(33, 365)
        Me.lblThirdQuestion1.Name = "lblThirdQuestion1"
        Me.lblThirdQuestion1.Size = New System.Drawing.Size(553, 21)
        Me.lblThirdQuestion1.TabIndex = 17
        Me.lblThirdQuestion1.Text = "Do you currently have any of the following conditions during this time?"
        '
        'lblSecondQuestion2
        '
        Me.lblSecondQuestion2.AutoSize = True
        Me.lblSecondQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion2.ForeColor = System.Drawing.Color.Black
        Me.lblSecondQuestion2.Location = New System.Drawing.Point(33, 285)
        Me.lblSecondQuestion2.Name = "lblSecondQuestion2"
        Me.lblSecondQuestion2.Size = New System.Drawing.Size(421, 21)
        Me.lblSecondQuestion2.TabIndex = 15
        Me.lblSecondQuestion2.Text = "country between the period of last month until now?"
        '
        'lblSecondQuestion1
        '
        Me.lblSecondQuestion1.AutoSize = True
        Me.lblSecondQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion1.ForeColor = System.Drawing.Color.Black
        Me.lblSecondQuestion1.Location = New System.Drawing.Point(33, 258)
        Me.lblSecondQuestion1.Name = "lblSecondQuestion1"
        Me.lblSecondQuestion1.Size = New System.Drawing.Size(579, 21)
        Me.lblSecondQuestion1.TabIndex = 16
        Me.lblSecondQuestion1.Text = "Have you come into contact with anyone who has traveled outside your "
        '
        'lblFirstQuestion
        '
        Me.lblFirstQuestion.AutoSize = True
        Me.lblFirstQuestion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestion.ForeColor = System.Drawing.Color.Black
        Me.lblFirstQuestion.Location = New System.Drawing.Point(34, 180)
        Me.lblFirstQuestion.Name = "lblFirstQuestion"
        Me.lblFirstQuestion.Size = New System.Drawing.Size(589, 21)
        Me.lblFirstQuestion.TabIndex = 14
        Me.lblFirstQuestion.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'txtBxCpNum
        '
        Me.txtBxCpNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxCpNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCpNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxCpNum.Location = New System.Drawing.Point(389, 138)
        Me.txtBxCpNum.Multiline = True
        Me.txtBxCpNum.Name = "txtBxCpNum"
        Me.txtBxCpNum.Size = New System.Drawing.Size(166, 32)
        Me.txtBxCpNum.TabIndex = 12
        Me.txtBxCpNum.Tag = "requiredField"
        Me.txtBxCpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCPnum
        '
        Me.lblCPnum.AutoSize = True
        Me.lblCPnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPnum.ForeColor = System.Drawing.Color.Black
        Me.lblCPnum.Location = New System.Drawing.Point(385, 114)
        Me.lblCPnum.Name = "lblCPnum"
        Me.lblCPnum.Size = New System.Drawing.Size(89, 21)
        Me.lblCPnum.TabIndex = 8
        Me.lblCPnum.Text = "Phone No."
        '
        'txtBxGender
        '
        Me.txtBxGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxGender.Location = New System.Drawing.Point(562, 138)
        Me.txtBxGender.Multiline = True
        Me.txtBxGender.Name = "txtBxGender"
        Me.txtBxGender.Size = New System.Drawing.Size(57, 32)
        Me.txtBxGender.TabIndex = 13
        Me.txtBxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(558, 112)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(70, 21)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAddress.Location = New System.Drawing.Point(38, 138)
        Me.txtBxAddress.Multiline = True
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(342, 32)
        Me.txtBxAddress.TabIndex = 11
        Me.txtBxAddress.Tag = "requiredField"
        Me.txtBxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(35, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 21)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address"
        '
        'txtBxAge
        '
        Me.txtBxAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAge.Location = New System.Drawing.Point(560, 69)
        Me.txtBxAge.Multiline = True
        Me.txtBxAge.Name = "txtBxAge"
        Me.txtBxAge.Size = New System.Drawing.Size(57, 32)
        Me.txtBxAge.TabIndex = 6
        Me.txtBxAge.Tag = "requiredField"
        Me.txtBxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(556, 43)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxLastName.Location = New System.Drawing.Point(386, 69)
        Me.txtBxLastName.Multiline = True
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxLastName.TabIndex = 2
        Me.txtBxLastName.Tag = "requiredField"
        Me.txtBxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(382, 45)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(93, 21)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxMiddleName.Location = New System.Drawing.Point(212, 69)
        Me.txtBxMiddleName.Multiline = True
        Me.txtBxMiddleName.Name = "txtBxMiddleName"
        Me.txtBxMiddleName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxMiddleName.TabIndex = 2
        Me.txtBxMiddleName.Tag = "requiredField"
        Me.txtBxMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(208, 45)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(115, 21)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxFirstName.Location = New System.Drawing.Point(38, 69)
        Me.txtBxFirstName.Multiline = True
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxFirstName.TabIndex = 2
        Me.txtBxFirstName.Tag = "requiredField"
        Me.txtBxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(34, 45)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(91, 21)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'btnDisplayData
        '
        Me.btnDisplayData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayData.Location = New System.Drawing.Point(76, 439)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(117, 36)
        Me.btnDisplayData.TabIndex = 1
        Me.btnDisplayData.Text = "Display Data"
        Me.btnDisplayData.UseVisualStyleBackColor = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 619)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.panelTop)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing Data Viewer"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelNav.ResumeLayout(False)
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxFirstQuestion.ResumeLayout(False)
        Me.gbxFirstQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents panelBottom As Panel
    Friend WithEvents panelNav As Panel
    Friend WithEvents panelContent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents listBxEntries As ListBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtBxMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents txtBxAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtBxCpNum As TextBox
    Friend WithEvents lblCPnum As Label
    Friend WithEvents txtBxGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFirstQuestion As Label
    Friend WithEvents lblSecondQuestion2 As Label
    Friend WithEvents lblSecondQuestion1 As Label
    Friend WithEvents lblThirdQuestion1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents gbxFirstQuestion As GroupBox
    Friend WithEvents rdoFirstQuestionNo As RadioButton
    Friend WithEvents rdoFirstQuestionYes As RadioButton
    Friend WithEvents chkBxDB As CheckBox
    Friend WithEvents chkBxCough As CheckBox
    Friend WithEvents chkBxDiarrhea As CheckBox
    Friend WithEvents chkBxSoreThroat As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chBxLossOfTasteAndSmell As CheckBox
    Friend WithEvents chkBxFever As CheckBox
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSelectedLabel As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnDisplayData As Button
End Class
