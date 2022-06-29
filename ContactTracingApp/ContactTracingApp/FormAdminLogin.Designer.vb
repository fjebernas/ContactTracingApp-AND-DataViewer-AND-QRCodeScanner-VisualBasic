<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdminLogin))
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtBxPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.gbxLogin = New System.Windows.Forms.GroupBox()
        Me.lblWrongPassword = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(23, 30)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 21)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password:"
        '
        'txtBxPassword
        '
        Me.txtBxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBxPassword.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPassword.Location = New System.Drawing.Point(27, 54)
        Me.txtBxPassword.Name = "txtBxPassword"
        Me.txtBxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPassword.Size = New System.Drawing.Size(124, 21)
        Me.txtBxPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 2
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(26, 97)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 41)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'gbxLogin
        '
        Me.gbxLogin.Controls.Add(Me.lblWrongPassword)
        Me.gbxLogin.Controls.Add(Me.lblPassword)
        Me.gbxLogin.Controls.Add(Me.btnLogin)
        Me.gbxLogin.Controls.Add(Me.txtBxPassword)
        Me.gbxLogin.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbxLogin.Location = New System.Drawing.Point(207, 24)
        Me.gbxLogin.Name = "gbxLogin"
        Me.gbxLogin.Size = New System.Drawing.Size(219, 154)
        Me.gbxLogin.TabIndex = 3
        Me.gbxLogin.TabStop = False
        Me.gbxLogin.Text = "Making sure it's you"
        '
        'lblWrongPassword
        '
        Me.lblWrongPassword.AutoSize = True
        Me.lblWrongPassword.ForeColor = System.Drawing.Color.Red
        Me.lblWrongPassword.Location = New System.Drawing.Point(114, 9)
        Me.lblWrongPassword.Name = "lblWrongPassword"
        Me.lblWrongPassword.Size = New System.Drawing.Size(99, 16)
        Me.lblWrongPassword.TabIndex = 3
        Me.lblWrongPassword.Text = "wrong password!"
        Me.lblWrongPassword.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 129)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FormAdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 200)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin login"
        Me.gbxLogin.ResumeLayout(False)
        Me.gbxLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPassword As Label
    Friend WithEvents txtBxPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents gbxLogin As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWrongPassword As Label
End Class
