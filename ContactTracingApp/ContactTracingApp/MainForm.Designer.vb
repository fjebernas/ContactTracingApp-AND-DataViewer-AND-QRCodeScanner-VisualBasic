<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picBxAdmin = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcomeH2 = New System.Windows.Forms.Label()
        Me.lblWelcomeH1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.lblRequired6 = New System.Windows.Forms.Label()
        Me.lblRequired5 = New System.Windows.Forms.Label()
        Me.lblRequired4 = New System.Windows.Forms.Label()
        Me.lblRequired3 = New System.Windows.Forms.Label()
        Me.lblRequired2 = New System.Windows.Forms.Label()
        Me.lblRequired1 = New System.Windows.Forms.Label()
        Me.chkBxDB = New System.Windows.Forms.CheckBox()
        Me.chkBxCough = New System.Windows.Forms.CheckBox()
        Me.chkBxDiarrhea = New System.Windows.Forms.CheckBox()
        Me.chkBxSoreThroat = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chBxLossOfTasteAndSmell = New System.Windows.Forms.CheckBox()
        Me.chkBxFever = New System.Windows.Forms.CheckBox()
        Me.gbxSecondQuestion = New System.Windows.Forms.GroupBox()
        Me.rdoSecondQuestionNS = New System.Windows.Forms.RadioButton()
        Me.rdoSecondQuestionNo = New System.Windows.Forms.RadioButton()
        Me.rdoSecondQuestionYes = New System.Windows.Forms.RadioButton()
        Me.gbxFirstQuestion = New System.Windows.Forms.GroupBox()
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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSelectedLabel = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.timerDate = New System.Windows.Forms.Timer(Me.components)
        Me.panelOptions = New System.Windows.Forms.Panel()
        Me.picBxQRCode = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.picBxOptions = New System.Windows.Forms.PictureBox()
        Me.panelBottom.SuspendLayout()
        Me.panelTop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContent.SuspendLayout()
        Me.gbxSecondQuestion.SuspendLayout()
        Me.gbxFirstQuestion.SuspendLayout()
        Me.panelOptions.SuspendLayout()
        CType(Me.picBxQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBxOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.btnSubmit)
        Me.panelBottom.Controls.Add(Me.btnGuest)
        Me.panelBottom.Controls.Add(Me.btnStudent)
        Me.panelBottom.Controls.Add(Me.btnFaculty)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 131)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(658, 140)
        Me.panelBottom.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.PaleGreen
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
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(90, Byte), Integer))
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
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(192, Byte), Integer))
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
        Me.btnFaculty.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.panelTop.Controls.Add(Me.picBxOptions)
        Me.panelTop.Controls.Add(Me.panelOptions)
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'picBxAdmin
        '
        Me.picBxAdmin.Image = CType(resources.GetObject("picBxAdmin.Image"), System.Drawing.Image)
        Me.picBxAdmin.Location = New System.Drawing.Point(25, 5)
        Me.picBxAdmin.Name = "picBxAdmin"
        Me.picBxAdmin.Size = New System.Drawing.Size(68, 67)
        Me.picBxAdmin.TabIndex = 2
        Me.picBxAdmin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 67)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(97, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "(Admin access only)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(97, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click to see all records"
        '
        'lblWelcomeH2
        '
        Me.lblWelcomeH2.AutoSize = True
        Me.lblWelcomeH2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblWelcomeH2.Location = New System.Drawing.Point(206, 92)
        Me.lblWelcomeH2.Name = "lblWelcomeH2"
        Me.lblWelcomeH2.Size = New System.Drawing.Size(197, 33)
        Me.lblWelcomeH2.TabIndex = 0
        Me.lblWelcomeH2.Text = "       Are you a:"
        '
        'lblWelcomeH1
        '
        Me.lblWelcomeH1.AutoSize = True
        Me.lblWelcomeH1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblWelcomeH1.Location = New System.Drawing.Point(165, 40)
        Me.lblWelcomeH1.Name = "lblWelcomeH1"
        Me.lblWelcomeH1.Size = New System.Drawing.Size(379, 42)
        Me.lblWelcomeH1.TabIndex = 0
        Me.lblWelcomeH1.Text = "Contact Tracing App"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(559, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(290, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 18)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "**Date**"
        '
        'timer
        '
        Me.timer.Interval = 1
        '
        'panelContent
        '
        Me.panelContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelContent.Controls.Add(Me.btnCancel)
        Me.panelContent.Controls.Add(Me.lblDate)
        Me.panelContent.Controls.Add(Me.lblRequired6)
        Me.panelContent.Controls.Add(Me.lblRequired5)
        Me.panelContent.Controls.Add(Me.lblRequired4)
        Me.panelContent.Controls.Add(Me.lblRequired3)
        Me.panelContent.Controls.Add(Me.lblRequired2)
        Me.panelContent.Controls.Add(Me.lblRequired1)
        Me.panelContent.Controls.Add(Me.chkBxDB)
        Me.panelContent.Controls.Add(Me.chkBxCough)
        Me.panelContent.Controls.Add(Me.chkBxDiarrhea)
        Me.panelContent.Controls.Add(Me.chkBxSoreThroat)
        Me.panelContent.Controls.Add(Me.CheckBox3)
        Me.panelContent.Controls.Add(Me.CheckBox2)
        Me.panelContent.Controls.Add(Me.CheckBox1)
        Me.panelContent.Controls.Add(Me.chBxLossOfTasteAndSmell)
        Me.panelContent.Controls.Add(Me.chkBxFever)
        Me.panelContent.Controls.Add(Me.gbxSecondQuestion)
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
        Me.panelContent.Controls.Add(Me.lblSelected)
        Me.panelContent.Controls.Add(Me.lblSelectedLabel)
        Me.panelContent.Controls.Add(Me.lblFirstName)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 133)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(658, 0)
        Me.panelContent.TabIndex = 2
        '
        'lblRequired6
        '
        Me.lblRequired6.AutoSize = True
        Me.lblRequired6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired6.ForeColor = System.Drawing.Color.Red
        Me.lblRequired6.Location = New System.Drawing.Point(541, 295)
        Me.lblRequired6.Name = "lblRequired6"
        Me.lblRequired6.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired6.TabIndex = 17
        Me.lblRequired6.Tag = "lblSayingRequired"
        Me.lblRequired6.Text = "*required"
        Me.lblRequired6.Visible = False
        '
        'lblRequired5
        '
        Me.lblRequired5.AutoSize = True
        Me.lblRequired5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired5.ForeColor = System.Drawing.Color.Red
        Me.lblRequired5.Location = New System.Drawing.Point(541, 214)
        Me.lblRequired5.Name = "lblRequired5"
        Me.lblRequired5.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired5.TabIndex = 17
        Me.lblRequired5.Tag = "lblSayingRequired"
        Me.lblRequired5.Text = "*required"
        Me.lblRequired5.Visible = False
        '
        'lblRequired4
        '
        Me.lblRequired4.AutoSize = True
        Me.lblRequired4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired4.ForeColor = System.Drawing.Color.Red
        Me.lblRequired4.Location = New System.Drawing.Point(469, 117)
        Me.lblRequired4.Name = "lblRequired4"
        Me.lblRequired4.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired4.TabIndex = 17
        Me.lblRequired4.Tag = "lblSayingRequired"
        Me.lblRequired4.Text = "*required"
        Me.lblRequired4.Visible = False
        '
        'lblRequired3
        '
        Me.lblRequired3.AutoSize = True
        Me.lblRequired3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired3.ForeColor = System.Drawing.Color.Red
        Me.lblRequired3.Location = New System.Drawing.Point(588, 48)
        Me.lblRequired3.Name = "lblRequired3"
        Me.lblRequired3.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired3.TabIndex = 17
        Me.lblRequired3.Tag = "lblSayingRequired"
        Me.lblRequired3.Text = "*required"
        Me.lblRequired3.Visible = False
        '
        'lblRequired2
        '
        Me.lblRequired2.AutoSize = True
        Me.lblRequired2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired2.ForeColor = System.Drawing.Color.Red
        Me.lblRequired2.Location = New System.Drawing.Point(471, 48)
        Me.lblRequired2.Name = "lblRequired2"
        Me.lblRequired2.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired2.TabIndex = 17
        Me.lblRequired2.Tag = "lblSayingRequired"
        Me.lblRequired2.Text = "*required"
        Me.lblRequired2.Visible = False
        '
        'lblRequired1
        '
        Me.lblRequired1.AutoSize = True
        Me.lblRequired1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequired1.ForeColor = System.Drawing.Color.Red
        Me.lblRequired1.Location = New System.Drawing.Point(111, 48)
        Me.lblRequired1.Name = "lblRequired1"
        Me.lblRequired1.Size = New System.Drawing.Size(61, 15)
        Me.lblRequired1.TabIndex = 17
        Me.lblRequired1.Tag = "lblSayingRequired"
        Me.lblRequired1.Text = "*required"
        Me.lblRequired1.Visible = False
        '
        'chkBxDB
        '
        Me.chkBxDB.AutoSize = True
        Me.chkBxDB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxDB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxDB.Location = New System.Drawing.Point(34, 487)
        Me.chkBxDB.Name = "chkBxDB"
        Me.chkBxDB.Size = New System.Drawing.Size(151, 20)
        Me.chkBxDB.TabIndex = 16
        Me.chkBxDB.Text = "Difficulty breathing"
        Me.chkBxDB.UseVisualStyleBackColor = True
        '
        'chkBxCough
        '
        Me.chkBxCough.AutoSize = True
        Me.chkBxCough.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxCough.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxCough.Location = New System.Drawing.Point(34, 460)
        Me.chkBxCough.Name = "chkBxCough"
        Me.chkBxCough.Size = New System.Drawing.Size(69, 20)
        Me.chkBxCough.TabIndex = 15
        Me.chkBxCough.Text = "Cough"
        Me.chkBxCough.UseVisualStyleBackColor = True
        '
        'chkBxDiarrhea
        '
        Me.chkBxDiarrhea.AutoSize = True
        Me.chkBxDiarrhea.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxDiarrhea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxDiarrhea.Location = New System.Drawing.Point(233, 487)
        Me.chkBxDiarrhea.Name = "chkBxDiarrhea"
        Me.chkBxDiarrhea.Size = New System.Drawing.Size(83, 20)
        Me.chkBxDiarrhea.TabIndex = 14
        Me.chkBxDiarrhea.Text = "Diarrhea"
        Me.chkBxDiarrhea.UseVisualStyleBackColor = True
        '
        'chkBxSoreThroat
        '
        Me.chkBxSoreThroat.AutoSize = True
        Me.chkBxSoreThroat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxSoreThroat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxSoreThroat.Location = New System.Drawing.Point(233, 460)
        Me.chkBxSoreThroat.Name = "chkBxSoreThroat"
        Me.chkBxSoreThroat.Size = New System.Drawing.Size(96, 20)
        Me.chkBxSoreThroat.TabIndex = 14
        Me.chkBxSoreThroat.Text = "Sore throat"
        Me.chkBxSoreThroat.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(459, 487)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(100, 20)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Headaches"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(459, 460)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(86, 20)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Tiredness"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(459, 433)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 20)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Chest pain"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chBxLossOfTasteAndSmell
        '
        Me.chBxLossOfTasteAndSmell.AutoSize = True
        Me.chBxLossOfTasteAndSmell.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBxLossOfTasteAndSmell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chBxLossOfTasteAndSmell.Location = New System.Drawing.Point(233, 433)
        Me.chBxLossOfTasteAndSmell.Name = "chBxLossOfTasteAndSmell"
        Me.chBxLossOfTasteAndSmell.Size = New System.Drawing.Size(158, 20)
        Me.chBxLossOfTasteAndSmell.TabIndex = 14
        Me.chBxLossOfTasteAndSmell.Text = "Loss of taste or smell"
        Me.chBxLossOfTasteAndSmell.UseVisualStyleBackColor = True
        '
        'chkBxFever
        '
        Me.chkBxFever.AutoSize = True
        Me.chkBxFever.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBxFever.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.chkBxFever.Location = New System.Drawing.Point(34, 433)
        Me.chkBxFever.Name = "chkBxFever"
        Me.chkBxFever.Size = New System.Drawing.Size(60, 20)
        Me.chkBxFever.TabIndex = 14
        Me.chkBxFever.Text = "Fever"
        Me.chkBxFever.UseVisualStyleBackColor = True
        '
        'gbxSecondQuestion
        '
        Me.gbxSecondQuestion.Controls.Add(Me.rdoSecondQuestionNS)
        Me.gbxSecondQuestion.Controls.Add(Me.rdoSecondQuestionNo)
        Me.gbxSecondQuestion.Controls.Add(Me.rdoSecondQuestionYes)
        Me.gbxSecondQuestion.Location = New System.Drawing.Point(27, 319)
        Me.gbxSecondQuestion.Name = "gbxSecondQuestion"
        Me.gbxSecondQuestion.Size = New System.Drawing.Size(380, 42)
        Me.gbxSecondQuestion.TabIndex = 99
        Me.gbxSecondQuestion.TabStop = False
        '
        'rdoSecondQuestionNS
        '
        Me.rdoSecondQuestionNS.AutoSize = True
        Me.rdoSecondQuestionNS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionNS.ForeColor = System.Drawing.Color.Teal
        Me.rdoSecondQuestionNS.Location = New System.Drawing.Point(292, 15)
        Me.rdoSecondQuestionNS.Name = "rdoSecondQuestionNS"
        Me.rdoSecondQuestionNS.Size = New System.Drawing.Size(78, 20)
        Me.rdoSecondQuestionNS.TabIndex = 13
        Me.rdoSecondQuestionNS.TabStop = True
        Me.rdoSecondQuestionNS.Text = "Not sure"
        Me.rdoSecondQuestionNS.UseVisualStyleBackColor = True
        '
        'rdoSecondQuestionNo
        '
        Me.rdoSecondQuestionNo.AutoSize = True
        Me.rdoSecondQuestionNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionNo.ForeColor = System.Drawing.Color.Maroon
        Me.rdoSecondQuestionNo.Location = New System.Drawing.Point(153, 15)
        Me.rdoSecondQuestionNo.Name = "rdoSecondQuestionNo"
        Me.rdoSecondQuestionNo.Size = New System.Drawing.Size(43, 20)
        Me.rdoSecondQuestionNo.TabIndex = 12
        Me.rdoSecondQuestionNo.TabStop = True
        Me.rdoSecondQuestionNo.Text = "No"
        Me.rdoSecondQuestionNo.UseVisualStyleBackColor = True
        '
        'rdoSecondQuestionYes
        '
        Me.rdoSecondQuestionYes.AutoSize = True
        Me.rdoSecondQuestionYes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSecondQuestionYes.ForeColor = System.Drawing.Color.DarkGreen
        Me.rdoSecondQuestionYes.Location = New System.Drawing.Point(11, 15)
        Me.rdoSecondQuestionYes.Name = "rdoSecondQuestionYes"
        Me.rdoSecondQuestionYes.Size = New System.Drawing.Size(47, 20)
        Me.rdoSecondQuestionYes.TabIndex = 11
        Me.rdoSecondQuestionYes.TabStop = True
        Me.rdoSecondQuestionYes.Text = "Yes"
        Me.rdoSecondQuestionYes.UseVisualStyleBackColor = True
        '
        'gbxFirstQuestion
        '
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionNo)
        Me.gbxFirstQuestion.Controls.Add(Me.rdoFirstQuestionYes)
        Me.gbxFirstQuestion.Location = New System.Drawing.Point(27, 214)
        Me.gbxFirstQuestion.Name = "gbxFirstQuestion"
        Me.gbxFirstQuestion.Size = New System.Drawing.Size(209, 42)
        Me.gbxFirstQuestion.TabIndex = 99
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
        'txtBxCpNum
        '
        Me.txtBxCpNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxCpNum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCpNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxCpNum.Location = New System.Drawing.Point(378, 141)
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
        Me.lblCPnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblCPnum.Location = New System.Drawing.Point(374, 117)
        Me.lblCPnum.Name = "lblCPnum"
        Me.lblCPnum.Size = New System.Drawing.Size(89, 21)
        Me.lblCPnum.TabIndex = 0
        Me.lblCPnum.Text = "Phone No."
        '
        'txtBxGender
        '
        Me.txtBxGender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxGender.Location = New System.Drawing.Point(551, 141)
        Me.txtBxGender.Multiline = True
        Me.txtBxGender.Name = "txtBxGender"
        Me.txtBxGender.Size = New System.Drawing.Size(57, 32)
        Me.txtBxGender.TabIndex = 7
        Me.txtBxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBxAge
        '
        Me.txtBxAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAge.Location = New System.Drawing.Point(551, 74)
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
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(547, 115)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(70, 21)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Gender"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxLastName.Location = New System.Drawing.Point(376, 74)
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
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(547, 48)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Age"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(374, 48)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(91, 21)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxMiddleName.Location = New System.Drawing.Point(201, 74)
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
        Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblMiddleName.Location = New System.Drawing.Point(200, 48)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(113, 21)
        Me.lblMiddleName.TabIndex = 0
        Me.lblMiddleName.Text = "Middle name"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxAddress.Location = New System.Drawing.Point(27, 141)
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
        Me.lblSecondQuestion2.Location = New System.Drawing.Point(24, 295)
        Me.lblSecondQuestion2.Name = "lblSecondQuestion2"
        Me.lblSecondQuestion2.Size = New System.Drawing.Size(421, 21)
        Me.lblSecondQuestion2.TabIndex = 0
        Me.lblSecondQuestion2.Text = "country between the period of last month until now?"
        '
        'lblThirdQuestion2
        '
        Me.lblThirdQuestion2.AutoSize = True
        Me.lblThirdQuestion2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblThirdQuestion2.Location = New System.Drawing.Point(24, 400)
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
        Me.lblThirdQuestion1.Location = New System.Drawing.Point(24, 373)
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
        Me.lblSecondQuestion1.Location = New System.Drawing.Point(23, 268)
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
        Me.lblFirstQuestion.Location = New System.Drawing.Point(23, 190)
        Me.lblFirstQuestion.Name = "lblFirstQuestion"
        Me.lblFirstQuestion.Size = New System.Drawing.Size(589, 21)
        Me.lblFirstQuestion.TabIndex = 0
        Me.lblFirstQuestion.Text = "Have you traveled outside the country anytime from last month until now?"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(24, 115)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(72, 21)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtBxFirstName.Location = New System.Drawing.Point(26, 74)
        Me.txtBxFirstName.Multiline = True
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(168, 32)
        Me.txtBxFirstName.TabIndex = 1
        Me.txtBxFirstName.Tag = "requiredField"
        Me.txtBxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelected.ForeColor = System.Drawing.Color.Gray
        Me.lblSelected.Location = New System.Drawing.Point(111, 14)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(140, 19)
        Me.lblSelected.TabIndex = 0
        Me.lblSelected.Text = "**selected type**"
        '
        'lblSelectedLabel
        '
        Me.lblSelectedLabel.AutoSize = True
        Me.lblSelectedLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblSelectedLabel.Location = New System.Drawing.Point(22, 13)
        Me.lblSelectedLabel.Name = "lblSelectedLabel"
        Me.lblSelectedLabel.Size = New System.Drawing.Size(92, 21)
        Me.lblSelectedLabel.TabIndex = 0
        Me.lblSelectedLabel.Text = "Selected is"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(23, 48)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 21)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name"
        '
        'timerDate
        '
        Me.timerDate.Interval = 1000
        '
        'panelOptions
        '
        Me.panelOptions.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOptions.Controls.Add(Me.PictureBox4)
        Me.panelOptions.Controls.Add(Me.picBxQRCode)
        Me.panelOptions.Controls.Add(Me.PictureBox2)
        Me.panelOptions.Controls.Add(Me.picBxAdmin)
        Me.panelOptions.Controls.Add(Me.Label4)
        Me.panelOptions.Controls.Add(Me.Label2)
        Me.panelOptions.Controls.Add(Me.Label3)
        Me.panelOptions.Controls.Add(Me.Label1)
        Me.panelOptions.Location = New System.Drawing.Point(322, 1)
        Me.panelOptions.Name = "panelOptions"
        Me.panelOptions.Size = New System.Drawing.Size(339, 132)
        Me.panelOptions.TabIndex = 4
        Me.panelOptions.Visible = False
        '
        'picBxQRCode
        '
        Me.picBxQRCode.Image = CType(resources.GetObject("picBxQRCode.Image"), System.Drawing.Image)
        Me.picBxQRCode.Location = New System.Drawing.Point(199, 60)
        Me.picBxQRCode.Name = "picBxQRCode"
        Me.picBxQRCode.Size = New System.Drawing.Size(71, 67)
        Me.picBxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBxQRCode.TabIndex = 4
        Me.picBxQRCode.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(245, 102)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(97, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Click to go to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(74, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "QR code scanner"
        '
        'picBxOptions
        '
        Me.picBxOptions.BackColor = System.Drawing.Color.Transparent
        Me.picBxOptions.Image = CType(resources.GetObject("picBxOptions.Image"), System.Drawing.Image)
        Me.picBxOptions.Location = New System.Drawing.Point(606, 12)
        Me.picBxOptions.Name = "picBxOptions"
        Me.picBxOptions.Size = New System.Drawing.Size(40, 36)
        Me.picBxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBxOptions.TabIndex = 5
        Me.picBxOptions.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(658, 271)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(674, 840)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(674, 310)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Tracing App"
        Me.panelBottom.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContent.ResumeLayout(False)
        Me.panelContent.PerformLayout()
        Me.gbxSecondQuestion.ResumeLayout(False)
        Me.gbxSecondQuestion.PerformLayout()
        Me.gbxFirstQuestion.ResumeLayout(False)
        Me.gbxFirstQuestion.PerformLayout()
        Me.panelOptions.ResumeLayout(False)
        Me.panelOptions.PerformLayout()
        CType(Me.picBxQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBxOptions, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gbxSecondQuestion As GroupBox
    Friend WithEvents rdoSecondQuestionNS As RadioButton
    Friend WithEvents rdoSecondQuestionNo As RadioButton
    Friend WithEvents rdoSecondQuestionYes As RadioButton
    Friend WithEvents gbxFirstQuestion As GroupBox
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
    Friend WithEvents lblRequired4 As Label
    Friend WithEvents lblRequired3 As Label
    Friend WithEvents lblRequired2 As Label
    Friend WithEvents lblRequired1 As Label
    Friend WithEvents chkBxDiarrhea As CheckBox
    Friend WithEvents chkBxSoreThroat As CheckBox
    Friend WithEvents chBxLossOfTasteAndSmell As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblDate As Label
    Friend WithEvents timerDate As Timer
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSelectedLabel As Label
    Friend WithEvents lblRequired6 As Label
    Friend WithEvents lblRequired5 As Label
    Friend WithEvents picBxAdmin As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picBxOptions As PictureBox
    Friend WithEvents panelOptions As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents picBxQRCode As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
