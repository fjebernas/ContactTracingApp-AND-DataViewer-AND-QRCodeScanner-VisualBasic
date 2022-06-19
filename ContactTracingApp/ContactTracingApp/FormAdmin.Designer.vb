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
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.listBxEntries = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelTop.SuspendLayout()
        Me.panelNav.SuspendLayout()
        Me.panelContent.SuspendLayout()
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
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 492)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(944, 48)
        Me.panelBottom.TabIndex = 1
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelNav.Controls.Add(Me.listBxEntries)
        Me.panelNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelNav.Location = New System.Drawing.Point(0, 85)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(265, 407)
        Me.panelNav.TabIndex = 2
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.Label2)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(265, 85)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(679, 407)
        Me.panelContent.TabIndex = 3
        '
        'listBxEntries
        '
        Me.listBxEntries.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBxEntries.FormattingEnabled = True
        Me.listBxEntries.ItemHeight = 17
        Me.listBxEntries.Location = New System.Drawing.Point(23, 44)
        Me.listBxEntries.Name = "listBxEntries"
        Me.listBxEntries.Size = New System.Drawing.Size(220, 344)
        Me.listBxEntries.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label2"
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 540)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents panelBottom As Panel
    Friend WithEvents panelNav As Panel
    Friend WithEvents panelContent As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents listBxEntries As ListBox
    Friend WithEvents Label2 As Label
End Class
