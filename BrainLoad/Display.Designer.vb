<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
        Me.UserTextEn = New System.Windows.Forms.TextBox()
        Me.RunPlay = New System.Windows.Forms.Button()
        Me.TextEntryPanel = New System.Windows.Forms.Panel()
        Me.PlayerPanel = New System.Windows.Forms.Panel()
        Me.EnMore = New System.Windows.Forms.Button()
        Me.PlayerText = New System.Windows.Forms.Label()
        Me.TextEntryPanel.SuspendLayout()
        Me.PlayerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserTextEn
        '
        Me.UserTextEn.Location = New System.Drawing.Point(0, 0)
        Me.UserTextEn.Multiline = True
        Me.UserTextEn.Name = "UserTextEn"
        Me.UserTextEn.Size = New System.Drawing.Size(434, 316)
        Me.UserTextEn.TabIndex = 0
        '
        'RunPlay
        '
        Me.RunPlay.BackColor = System.Drawing.Color.Lime
        Me.RunPlay.FlatAppearance.BorderSize = 0
        Me.RunPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RunPlay.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunPlay.Location = New System.Drawing.Point(178, 322)
        Me.RunPlay.Name = "RunPlay"
        Me.RunPlay.Size = New System.Drawing.Size(79, 34)
        Me.RunPlay.TabIndex = 1
        Me.RunPlay.Text = "Run"
        Me.RunPlay.UseVisualStyleBackColor = False
        '
        'TextEntryPanel
        '
        Me.TextEntryPanel.BackColor = System.Drawing.Color.MidnightBlue
        Me.TextEntryPanel.Controls.Add(Me.UserTextEn)
        Me.TextEntryPanel.Controls.Add(Me.RunPlay)
        Me.TextEntryPanel.Location = New System.Drawing.Point(12, 203)
        Me.TextEntryPanel.Name = "TextEntryPanel"
        Me.TextEntryPanel.Size = New System.Drawing.Size(434, 359)
        Me.TextEntryPanel.TabIndex = 2
        '
        'PlayerPanel
        '
        Me.PlayerPanel.Controls.Add(Me.EnMore)
        Me.PlayerPanel.Controls.Add(Me.PlayerText)
        Me.PlayerPanel.Location = New System.Drawing.Point(1, 12)
        Me.PlayerPanel.Name = "PlayerPanel"
        Me.PlayerPanel.Size = New System.Drawing.Size(689, 265)
        Me.PlayerPanel.TabIndex = 3
        Me.PlayerPanel.Visible = False
        '
        'EnMore
        '
        Me.EnMore.BackColor = System.Drawing.Color.Lime
        Me.EnMore.FlatAppearance.BorderSize = 0
        Me.EnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnMore.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnMore.Location = New System.Drawing.Point(245, 226)
        Me.EnMore.Name = "EnMore"
        Me.EnMore.Size = New System.Drawing.Size(157, 36)
        Me.EnMore.TabIndex = 1
        Me.EnMore.Text = "Enter More Text"
        Me.EnMore.UseVisualStyleBackColor = False
        Me.EnMore.Visible = False
        '
        'PlayerText
        '
        Me.PlayerText.AutoSize = True
        Me.PlayerText.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerText.Location = New System.Drawing.Point(225, 0)
        Me.PlayerText.Name = "PlayerText"
        Me.PlayerText.Size = New System.Drawing.Size(0, 117)
        Me.PlayerText.TabIndex = 0
        Me.PlayerText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(819, 595)
        Me.Controls.Add(Me.PlayerPanel)
        Me.Controls.Add(Me.TextEntryPanel)
        Me.Name = "Display"
        Me.Text = "BrainLoad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TextEntryPanel.ResumeLayout(False)
        Me.TextEntryPanel.PerformLayout()
        Me.PlayerPanel.ResumeLayout(False)
        Me.PlayerPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserTextEn As TextBox
    Friend WithEvents RunPlay As Button
    Friend WithEvents TextEntryPanel As Panel
    Friend WithEvents PlayerPanel As Panel
    Friend WithEvents PlayerText As Label
    Friend WithEvents EnMore As Button
End Class
