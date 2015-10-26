<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontCaller = New System.Windows.Forms.Button()
        Me.ColorCaller = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Lime
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"100", "200", "300", "400", "500", "600", "700", "800", "900", "1000", "1100", "1200"})
        Me.ComboBox1.Location = New System.Drawing.Point(50, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(131, 31)
        Me.ComboBox1.TabIndex = 0
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.Color.Yellow
        Me.FontDialog1.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.MidnightBlue
        '
        'FontCaller
        '
        Me.FontCaller.BackColor = System.Drawing.Color.Lime
        Me.FontCaller.FlatAppearance.BorderSize = 0
        Me.FontCaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FontCaller.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontCaller.Location = New System.Drawing.Point(187, 36)
        Me.FontCaller.Name = "FontCaller"
        Me.FontCaller.Size = New System.Drawing.Size(99, 31)
        Me.FontCaller.TabIndex = 1
        Me.FontCaller.Text = "Font/Size"
        Me.FontCaller.UseVisualStyleBackColor = False
        '
        'ColorCaller
        '
        Me.ColorCaller.BackColor = System.Drawing.Color.Lime
        Me.ColorCaller.FlatAppearance.BorderSize = 0
        Me.ColorCaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorCaller.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorCaller.Location = New System.Drawing.Point(292, 36)
        Me.ColorCaller.Name = "ColorCaller"
        Me.ColorCaller.Size = New System.Drawing.Size(99, 31)
        Me.ColorCaller.TabIndex = 2
        Me.ColorCaller.Text = "Color"
        Me.ColorCaller.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Speed"
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(470, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColorCaller)
        Me.Controls.Add(Me.FontCaller)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "options"
        Me.Text = "BrainLoad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontCaller As Button
    Friend WithEvents ColorCaller As Button
    Friend WithEvents Label1 As Label
End Class
