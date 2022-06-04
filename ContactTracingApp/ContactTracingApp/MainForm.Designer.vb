<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnFaculty = New System.Windows.Forms.Button()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.lblWelcomeH2 = New System.Windows.Forms.Label()
        Me.lblWelcomeH1 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.panelBottom.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panelBottom.Controls.Add(Me.btnSubmit)
        Me.panelBottom.Controls.Add(Me.btnGuest)
        Me.panelBottom.Controls.Add(Me.btnStudent)
        Me.panelBottom.Controls.Add(Me.btnFaculty)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 131)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(632, 131)
        Me.panelBottom.TabIndex = 0
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.AliceBlue
        Me.btnGuest.FlatAppearance.BorderSize = 0
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.Navy
        Me.btnGuest.Location = New System.Drawing.Point(434, 32)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(165, 60)
        Me.btnGuest.TabIndex = 0
        Me.btnGuest.Text = "Guest"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.AliceBlue
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Navy
        Me.btnStudent.Location = New System.Drawing.Point(234, 32)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(165, 60)
        Me.btnStudent.TabIndex = 0
        Me.btnStudent.Text = "Student"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnFaculty
        '
        Me.btnFaculty.BackColor = System.Drawing.Color.AliceBlue
        Me.btnFaculty.FlatAppearance.BorderSize = 0
        Me.btnFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFaculty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.Navy
        Me.btnFaculty.Location = New System.Drawing.Point(34, 32)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.Size = New System.Drawing.Size(165, 60)
        Me.btnFaculty.TabIndex = 0
        Me.btnFaculty.Text = "Faculty"
        Me.btnFaculty.UseVisualStyleBackColor = False
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.AntiqueWhite
        Me.panelTop.Controls.Add(Me.lblWelcomeH2)
        Me.panelTop.Controls.Add(Me.lblWelcomeH1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.MinimumSize = New System.Drawing.Size(632, 110)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(632, 135)
        Me.panelTop.TabIndex = 1
        '
        'lblWelcomeH2
        '
        Me.lblWelcomeH2.AutoSize = True
        Me.lblWelcomeH2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblWelcomeH2.Location = New System.Drawing.Point(242, 86)
        Me.lblWelcomeH2.Name = "lblWelcomeH2"
        Me.lblWelcomeH2.Size = New System.Drawing.Size(148, 33)
        Me.lblWelcomeH2.TabIndex = 1
        Me.lblWelcomeH2.Text = "Are you a:"
        '
        'lblWelcomeH1
        '
        Me.lblWelcomeH1.AutoSize = True
        Me.lblWelcomeH1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeH1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblWelcomeH1.Location = New System.Drawing.Point(132, 32)
        Me.lblWelcomeH1.Name = "lblWelcomeH1"
        Me.lblWelcomeH1.Size = New System.Drawing.Size(379, 42)
        Me.lblWelcomeH1.TabIndex = 0
        Me.lblWelcomeH1.Text = "Contact Tracing App"
        '
        'timer
        '
        Me.timer.Interval = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightGreen
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSubmit.Location = New System.Drawing.Point(234, 32)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 60)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
        '
        'panelContent
        '
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(0, 135)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(632, 0)
        Me.panelContent.TabIndex = 2
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(632, 262)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelBottom)
        Me.Name = "FormMain"
        Me.Text = "Contact Tracing App"
        Me.panelBottom.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
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
End Class
