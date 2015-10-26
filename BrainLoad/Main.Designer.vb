<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.EnterTOpen = New System.Windows.Forms.Button()
        Me.DemoOpen = New System.Windows.Forms.Button()
        Me.OptionsOpen = New System.Windows.Forms.Button()
        Me.BrainLoadTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EnterTOpen
        '
        Me.EnterTOpen.BackColor = System.Drawing.Color.Lime
        Me.EnterTOpen.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.EnterTOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnterTOpen.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterTOpen.Location = New System.Drawing.Point(453, 255)
        Me.EnterTOpen.Name = "EnterTOpen"
        Me.EnterTOpen.Size = New System.Drawing.Size(103, 48)
        Me.EnterTOpen.TabIndex = 0
        Me.EnterTOpen.Text = "EnterText"
        Me.EnterTOpen.UseVisualStyleBackColor = False
        '
        'DemoOpen
        '
        Me.DemoOpen.BackColor = System.Drawing.Color.Lime
        Me.DemoOpen.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.DemoOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DemoOpen.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemoOpen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DemoOpen.Location = New System.Drawing.Point(562, 255)
        Me.DemoOpen.Name = "DemoOpen"
        Me.DemoOpen.Size = New System.Drawing.Size(103, 48)
        Me.DemoOpen.TabIndex = 1
        Me.DemoOpen.Text = "Demo"
        Me.DemoOpen.UseVisualStyleBackColor = False
        '
        'OptionsOpen
        '
        Me.OptionsOpen.BackColor = System.Drawing.Color.Lime
        Me.OptionsOpen.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.OptionsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptionsOpen.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsOpen.Location = New System.Drawing.Point(344, 255)
        Me.OptionsOpen.Name = "OptionsOpen"
        Me.OptionsOpen.Size = New System.Drawing.Size(103, 48)
        Me.OptionsOpen.TabIndex = 2
        Me.OptionsOpen.Text = "Options"
        Me.OptionsOpen.UseVisualStyleBackColor = False
        '
        'BrainLoadTitle
        '
        Me.BrainLoadTitle.AutoSize = True
        Me.BrainLoadTitle.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainLoadTitle.ForeColor = System.Drawing.Color.Lime
        Me.BrainLoadTitle.Location = New System.Drawing.Point(353, 91)
        Me.BrainLoadTitle.Name = "BrainLoadTitle"
        Me.BrainLoadTitle.Size = New System.Drawing.Size(296, 80)
        Me.BrainLoadTitle.TabIndex = 3
        Me.BrainLoadTitle.Text = "BrainLoad"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(947, 489)
        Me.Controls.Add(Me.BrainLoadTitle)
        Me.Controls.Add(Me.OptionsOpen)
        Me.Controls.Add(Me.DemoOpen)
        Me.Controls.Add(Me.EnterTOpen)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "BrainLoad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnterTOpen As Button
    Friend WithEvents DemoOpen As Button
    Friend WithEvents OptionsOpen As Button
    Friend WithEvents BrainLoadTitle As Label
End Class
