﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeH2 = New System.Windows.Forms.Label()
        Me.lblWelcomeH1 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.chkBxDB = New System.Windows.Forms.CheckBox()
        Me.chkBxCough = New System.Windows.Forms.CheckBox()
        Me.chkBxFever = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoSecondQuestionNS = New System.Windows.Forms.RadioButton()
        Me.rdoSecondQuestionNo = New System.Windows.Forms.RadioButton()
        Me.rdoSecondQuestionYes = New System.Windows.Forms.RadioButton()
        Me.gbxFirstQuestion = New System.Windows.Forms.GroupBox()
        Me.rdoFirstQuestionNS = New System.Windows.Forms.RadioButton()
        Me.rdoFirstQuestionNo = New System.Windows.Forms.RadioButton()
        Me.rdoFirstQuestionYes = New System.Windows.Forms.RadioButton()
        Me.txtBxCpNum = New System.Windows.Forms.TextBox()
        Me.lblCPnum = New System.Windows.Forms.Label()
        Me.txtBxGender = New System.Windows.Forms.TextBox()
        Me.txtBxAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtBxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.lblSecondQuestion2 = New System.Windows.Forms.Label()
        Me.lblThirdQuestion2 = New System.Windows.Forms.Label()
        Me.lblThirdQuestion1 = New System.Windows.Forms.Label()
        Me.lblSecondQuestion1 = New System.Windows.Forms.Label()
        Me.lblFirstQuestion = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.panelBottom.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxFirstQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.btnSubmit)
        Me.panelBottom.Controls.Add(Me.btnGuest)
        Me.panelBottom.Controls.Add(Me.btnStudent)
        Me.panelBottom.Controls.Add(Me.btnFaculty)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 124)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(658, 140)
        Me.panelBottom.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.Location = New System.Drawing.Point(242, 21)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 86)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuest.FlatAppearance.BorderSize = 0
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGuest.Image = CType(resources.GetObject("btnGuest.Image"), System.Drawing.Image)
        Me.btnGuest.Location = New System.Drawing.Point(446, 21)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(165, 86)
        Me.btnGuest.TabIndex = 0
        Me.btnGuest.Text = "Guest"
        Me.btnGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Navy
        Me.btnStudent.Image = CType(resources.GetObject("btnStudent.Image"), System.Drawing.Image)
        Me.btnStudent.Location = New System.Drawing.Point(242, 21)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(165, 86)
        Me.btnStudent.TabIndex = 0
        Me.btnStudent.Text = "Student"
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnFaculty
        '
        Me.btnFaculty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnFaculty.FlatAppearance.BorderSize = 0
        Me.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnFaculty.Image = CType(resources.GetObject("btnFaculty.Image"), System.Drawing.Image)
        Me.btnFaculty.Location = New System.Drawing.Point(38, 21)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(167, 86)
        Me.btnFaculty.TabIndex = 0
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFaculty.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.panelTop.Controls.Add(Me.PictureBox1)
        Me.panelTop.Controls.Add(Me.lblWelcomeH2)
        Me.panelTop.Controls.Add(Me.lblWelcomeH1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.MinimumSize = New System.Drawing.Size(632, 110)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(658, 133)
        Me.panelTop.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblWelcomeH2
        '
        Me.lblWelcomeH2.AutoSize = True
        Me.lblWelcomeH2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblWelcomeH2.Location = New System.Drawing.Point(251, 96)
        Me.lblWelcomeH2.Name = "lblWelcomeH2"
        Me.lblWelcomeH2.Size = New System.Drawing.Size(148, 33)
        Me.lblWelcomeH2.TabIndex = 0
        Me.lblWelcomeH2.Text = "Are you a:"
        '
        'lblWelcomeH1
        '
        Me.lblWelcomeH1.AutoSize = True
        Me.lblWelcomeH1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.lblWelcomeH1.Location = New System.Drawing.Point(173, 40)
        Me.lblWelcomeH1.Name = "lblWelcomeH1"
        Me.lblWelcomeH1.Size = New System.Drawing.Size(379, 42)
        Me.lblWelcomeH1.TabIndex = 0
        Me.lblWelcomeH1.Text = "Contact Tracing App"
        '
        'timer
        '
        Me.timer.Interval = 1
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelContent.Controls.Add(Me.chkBxDB)
        Me.panelContent.Controls.Add(Me.chkBxCough)
        Me.panelContent.Controls.Add(Me.chkBxFever)
        Me.panelContent.Controls.Add(Me.GroupBox1)
        Me.panelContent.Controls.Add(Me.gbxFirstQuestion)
        Me.panelContent.Controls.Add(Me.txtBxCpNum)
        Me.panelContent.Controls.Add(Me.lblCPnum)
        Me.panelContent.Controls.Add(Me.txtBxGender)
        Me.panelContent.Controls.Add(Me.txtBxAge)
        Me.panelContent.Controls.Add(Me.lblGender)
        Me.panelContent.Controls.Add(Me.txtBxLastName)
        Me.panelContent.Controls.Add(Me.lblAge)
        Me.panelContent.Controls.Add(Me.lblLastName)
        Me.panelContent.Controls.Add(Me.txtBxMiddleName)
        Me.panelContent.Controls.Add(Me.lblMiddleName)
        Me.panelContent.Controls.Add(Me.txtBxAddress)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion2)
        Me.panelContent.Controls.Add(Me.lblThirdQuestion2)
        Me.panelContent.Controls.Add(Me.lblThirdQuestion1)
        Me.panelContent.Controls.Add(Me.lblSecondQuestion1)
        Me.panelContent.Controls.Add(Me.lblFirstQuestion)
        Me.panelContent.Controls.Add(Me.lblAddress)
        Me.panelContent.Controls.Add(Me.txtBxFirstName)
        Me.panelContent.Controls.Add(Me.lblFirstName)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 133)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(658, 0)
        Me.panelContent.TabIndex = 2
        '
        'chkBxDB
        '
        Me.chkBxDB.AutoSize = True
        Me.chkBxDB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxDB.Location = New System.Drawing.Point(34, 460)
        Me.chkBxDB.Name = "chkBxDB"
        Me.chkBxDB.Size = New System.Drawing.Size(148, 21)
        Me.chkBxDB.TabIndex = 16
        Me.chkBxDB.Text = "Difficulty breathing"
        Me.chkBxDB.UseVisualStyleBackColor = True
        '
        'chkBxCough
        '
        Me.chkBxCough.AutoSize = True
        Me.chkBxCough.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxCough.Location = New System.Drawing.Point(34, 433)
        Me.chkBxCough.Name = "chkBxCough"
        Me.chkBxCough.Size = New System.Drawing.Size(72, 21)
        Me.chkBxCough.TabIndex = 15
        Me.chkBxCough.Text = "Cough"
        Me.chkBxCough.UseVisualStyleBackColor = True
        '
        'chkBxFever
        '
        Me.chkBxFever.AutoSize = True
        Me.chkBxFever.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxFever.Location = New System.Drawing.Point(34, 406)
        Me.chkBxFever.Name = "chkBxFever"
        Me.chkBxFever.Size = New System.Drawing.Size(61, 21)
        Me.chkBxFever.TabIndex = 14
        Me.chkBxFever.Text = "Fever"
        Me.chkBxFever.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoSecondQuestionNS)
        Me.GroupBox1.Controls.Add(Me.rdoSecondQuestionNo)
        Me.GroupBox1.Controls.Add(Me.rdoSecondQuestionYes)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'rdoSecondQuestionNS
        '
        Me.rdoSecondQuestionNS.AutoSize = True
        Me.rdoSecondQuestionNS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionNS.ForeColor = System.Drawing.Color.Teal
        Me.rdoSecondQuestionNS.Location = New System.Drawing.Point(292, 15)
        Me.rdoSecondQuestionNS.Name = "rdoSecondQuestionNS"
        Me.rdoSecondQuestionNS.Size = New System.Drawing.Size(79, 21)
        Me.rdoSecondQuestionNS.TabIndex = 13
        Me.rdoSecondQuestionNS.TabStop = True
        Me.rdoSecondQuestionNS.Text = "Not sure"
        Me.rdoSecondQuestionNS.UseVisualStyleBackColor = True
        '
        'rdoSecondQuestionNo
        '
        Me.rdoSecondQuestionNo.AutoSize = True
        Me.rdoSecondQuestionNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionNo.ForeColor = System.Drawing.Color.Maroon
        Me.rdoSecondQuestionNo.Location = New System.Drawing.Point(153, 15)
        Me.rdoSecondQuestionNo.Name = "rdoSecondQuestionNo"
        Me.rdoSecondQuestionNo.Size = New System.Drawing.Size(45, 21)
        Me.rdoSecondQuestionNo.TabIndex = 12
        Me.rdoSecondQuestionNo.TabStop = True
        Me.rdoSecondQuestionNo.Text = "No"
        Me.rdoSecondQuestionNo.UseVisualStyleBackColor = True
        '
        'rdoSecondQuestionYes
        '
        Me.rdoSecondQuestionYes.AutoSize = True
        Me.rdoSecondQuestionYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionYes.ForeColor = System.Drawing.Color.DarkGreen
        Me.rdoSecondQuestionYes.Location = New System.Drawing.Point(11, 15)
        Me.rdoSecondQuestionYes.Name = "rdoSecondQuestionYes"
        Me.rdoSecondQuestionYes.Size = New System.Drawing.Size(46, 21)
        Me.rdoSecondQuestionYes.TabIndex = 11
        Me.rdoSecondQuestionYes.TabStop = True
        Me.rdoSecondQuestionYes.Text = "Yes"
        Me.rdoSecondQuestionYes.UseVisualStyleBackColor = True
        '
        'gbxFirstQuestion
        '
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionNS)
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionNo)
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionYes)
        Me.gbxFirstQuestion.Location = New System.Drawing.Point(27, 187)
        Me.gbxFirstQuestion.Name = "gbxFirstQuestion"
        Me.gbxFirstQuestion.Size = New System.Drawing.Size(371, 42)
        Me.gbxFirstQuestion.TabIndex = 2
        Me.gbxFirstQuestion.TabStop = False
        '
        'rdoFirstQuestionNS
        '
        Me.rdoFirstQuestionNS.AutoSize = True
        Me.rdoFirstQuestionNS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFirstQuestionNS.ForeColor = System.Drawing.Color.Teal
        Me.rdoFirstQuestionNS.Location = New System.Drawing.Point(292, 15)
        Me.rdoFirstQuestionNS.Name = "rdoFirstQuestionNS"
        Me.rdoFirstQuestionNS.Size = New System.Drawing.Size(79, 21)
        Me.rdoFirstQuestionNS.TabIndex = 10
        Me.rdoFirstQuestionNS.TabStop = True
        Me.rdoFirstQuestionNS.Text = "Not sure"
        Me.rdoFirstQuestionNS.UseVisualStyleBackColor = True
        '
        'rdoFirstQuestionNo
        '
        Me.rdoFirstQuestionNo.AutoSize = True
        Me.rdoFirstQuestionNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFirstQuestionNo.ForeColor = System.Drawing.Color.Maroon
        Me.rdoFirstQuestionNo.Location = New System.Drawing.Point(153, 15)
        Me.rdoFirstQuestionNo.Name = "rdoFirstQuestionNo"
        Me.rdoFirstQuestionNo.Size = New System.Drawing.Size(45, 21)
        Me.rdoFirstQuestionNo.TabIndex = 9
        Me.rdoFirstQuestionNo.TabStop = True
        Me.rdoFirstQuestionNo.Text = "No"
        Me.rdoFirstQuestionNo.UseVisualStyleBackColor = True
        '
        'rdoFirstQuestionYes
        '
        Me.rdoFirstQuestionYes.AutoSize = True
        Me.rdoFirstQuestionYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFirstQuestionYes.ForeColor = System.Drawing.Color.DarkGreen
        Me.rdoFirstQuestionYes.Location = New System.Drawing.Point(11, 15)
        Me.rdoFirstQuestionYes.Name = "rdoFirstQuestionYes"
        Me.rdoFirstQuestionYes.Size = New System.Drawing.Size(46, 21)
        Me.rdoFirstQuestionYes.TabIndex = 8
        Me.rdoFirstQuestionYes.TabStop = True
        Me.rdoFirstQuestionYes.Text = "Yes"
        Me.rdoFirstQuestionYes.UseVisualStyleBackColor = True
        '
        'txtBxCpNum
        '
        Me.txtBxCpNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxCpNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCpNum.Location = New System.Drawing.Point(378, 114)
        Me.txtBxCpNum.Multiline = True
        Me.txtBxCpNum.Name = "txtBxCpNum"
        Me.txtBxCpNum.Size = New System.Drawing.Size(166, 32)
        Me.txtBxCpNum.TabIndex = 6
        Me.txtBxCpNum.Tag = "requiredField"
        Me.txtBxCpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCPnum
        '
        Me.lblCPnum.AutoSize = True
        Me.lblCPnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPnum.Location = New System.Drawing.Point(374, 90)
        Me.lblCPnum.Name = "lblCPnum"
        Me.lblCPnum.Size = New System.Drawing.Size(157, 21)
        Me.lblCPnum.TabIndex = 0
        Me.lblCPnum.Text = "Cell Phone number"
        '
        'txtBxGender
        '
        Me.txtBxGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGender.Location = New System.Drawing.Point(551, 114)
        Me.txtBxGender.Multiline = True
        Me.txtBxGender.Name = "txtBxGender"
        Me.txtBxGender.Size = New System.Drawing.Size(57, 32)
        Me.txtBxGender.TabIndex = 7
        Me.txtBxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBxAge
        '
        Me.txtBxAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAge.Location = New System.Drawing.Point(551, 47)
        Me.txtBxAge.Multiline = True
        Me.txtBxAge.Name = "txtBxAge"
        Me.txtBxAge.Size = New System.Drawing.Size(57, 32)
        Me.txtBxAge.TabIndex = 4
        Me.txtBxAge.Tag = "requiredField"
        Me.txtBxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(547, 88)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(70, 21)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLastName.Location = New System.Drawing.Point(376, 47)
        Me.txtBxLastName.Multiline = True
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxLastName.TabIndex = 3
        Me.txtBxLastName.Tag = "requiredField"
        Me.txtBxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(547, 21)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(374, 21)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(91, 21)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMiddleName.Location = New System.Drawing.Point(201, 47)
        Me.txtBxMiddleName.Multiline = True
        Me.txtBxMiddleName.Name = "txtBxMiddleName"
        Me.txtBxMiddleName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxMiddleName.TabIndex = 2
        Me.txtBxMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(200, 21)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(113, 21)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle name"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.Location = New System.Drawing.Point(27, 114)
        Me.txtBxAddress.Multiline = True
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(342, 32)
        Me.txtBxAddress.TabIndex = 5
        Me.txtBxAddress.Tag = "requiredField"
        Me.txtBxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSecondQuestion2
        '
        Me.lblSecondQuestion2.AutoSize = True
        Me.lblSecondQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion2.ForeColor = System.Drawing.Color.Navy
        Me.lblSecondQuestion2.Location = New System.Drawing.Point(24, 268)
        Me.lblSecondQuestion2.Name = "lblSecondQuestion2"
        Me.lblSecondQuestion2.Size = New System.Drawing.Size(421, 21)
        Me.lblSecondQuestion2.TabIndex = 0
        Me.lblSecondQuestion2.Text = "country between the period of last month until now?"
        '
        'lblThirdQuestion2
        '
        Me.lblThirdQuestion2.AutoSize = True
        Me.lblThirdQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion2.Location = New System.Drawing.Point(24, 373)
        Me.lblThirdQuestion2.Name = "lblThirdQuestion2"
        Me.lblThirdQuestion2.Size = New System.Drawing.Size(185, 21)
        Me.lblThirdQuestion2.TabIndex = 0
        Me.lblThirdQuestion2.Text = "(Check all that apply):"
        '
        'lblThirdQuestion1
        '
        Me.lblThirdQuestion1.AutoSize = True
        Me.lblThirdQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion1.ForeColor = System.Drawing.Color.Navy
        Me.lblThirdQuestion1.Location = New System.Drawing.Point(24, 346)
        Me.lblThirdQuestion1.Name = "lblThirdQuestion1"
        Me.lblThirdQuestion1.Size = New System.Drawing.Size(553, 21)
        Me.lblThirdQuestion1.TabIndex = 0
        Me.lblThirdQuestion1.Text = "Do you currently have any of the following conditions during this time?"
        '
        'lblSecondQuestion1
        '
        Me.lblSecondQuestion1.AutoSize = True
        Me.lblSecondQuestion1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion1.ForeColor = System.Drawing.Color.Navy
        Me.lblSecondQuestion1.Location = New System.Drawing.Point(23, 241)
        Me.lblSecondQuestion1.Name = "lblSecondQuestion1"
        Me.lblSecondQuestion1.Size = New System.Drawing.Size(579, 21)
        Me.lblSecondQuestion1.TabIndex = 0
        Me.lblSecondQuestion1.Text = "Have you come into contact with anyone who has traveled outside your "
        '
        'lblFirstQuestion
        '
        Me.lblFirstQuestion.AutoSize = True
        Me.lblFirstQuestion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestion.ForeColor = System.Drawing.Color.Navy
        Me.lblFirstQuestion.Location = New System.Drawing.Point(23, 163)
        Me.lblFirstQuestion.Name = "lblFirstQuestion"
        Me.lblFirstQuestion.Size = New System.Drawing.Size(589, 21)
        Me.lblFirstQuestion.TabIndex = 0
        Me.lblFirstQuestion.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(24, 88)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 21)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFirstName.Location = New System.Drawing.Point(26, 47)
        Me.txtBxFirstName.Multiline = True
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxFirstName.TabIndex = 1
        Me.txtBxFirstName.Tag = "requiredField"
        Me.txtBxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(23, 21)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 21)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(658, 264)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMain"
        Me.Text = "Contact Tracing App"
        Me.panelBottom.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxFirstQuestion.ResumeLayout(False)
        Me.gbxFirstQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelBottom As Panel
    Friend WithEvents btnGuest As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents panelTop As Panel
    Friend WithEvents lblWelcomeH2 As Label
    Friend WithEvents lblWelcomeH1 As Label
    Friend WithEvents timer As Timer
    Friend WithEvents btnSubmit As Button
    Friend WithEvents panelContent As Panel
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtBxMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtBxCpNum As TextBox
    Friend WithEvents lblCPnum As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents chkBxDB As CheckBox
    Friend WithEvents chkBxCough As CheckBox
    Friend WithEvents chkBxFever As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoSecondQuestionNS As RadioButton
    Friend WithEvents rdoSecondQuestionNo As RadioButton
    Friend WithEvents rdoSecondQuestionYes As RadioButton
    Friend WithEvents gbxFirstQuestion As GroupBox
    Friend WithEvents rdoFirstQuestionNS As RadioButton
    Friend WithEvents rdoFirstQuestionNo As RadioButton
    Friend WithEvents rdoFirstQuestionYes As RadioButton
    Friend WithEvents txtBxGender As TextBox
    Friend WithEvents txtBxAge As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblSecondQuestion2 As Label
    Friend WithEvents lblThirdQuestion2 As Label
    Friend WithEvents lblThirdQuestion1 As Label
    Friend WithEvents lblSecondQuestion1 As Label
    Friend WithEvents lblFirstQuestion As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
