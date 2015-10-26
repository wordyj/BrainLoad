<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Demo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Demo))
        Me.WelcomeText = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Next1De = New System.Windows.Forms.Button()
        Me.ReadNor = New System.Windows.Forms.Panel()
        Me.Readnortext = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stops = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.RealBL = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnText = New System.Windows.Forms.Label()
        Me.Start1bl = New System.Windows.Forms.Button()
        Me.DemoPlayer1 = New System.Windows.Forms.Label()
        Me.WelcomeText.SuspendLayout()
        Me.ReadNor.SuspendLayout()
        Me.RealBL.SuspendLayout()
        Me.SuspendLayout()
        '
        'WelcomeText
        '
        Me.WelcomeText.BackColor = System.Drawing.Color.MidnightBlue
        Me.WelcomeText.Controls.Add(Me.Label2)
        Me.WelcomeText.Controls.Add(Me.Next1De)
        Me.WelcomeText.Location = New System.Drawing.Point(27, 173)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Size = New System.Drawing.Size(123, 329)
        Me.WelcomeText.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(446, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(796, 492)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Next1De
        '
        Me.Next1De.BackColor = System.Drawing.Color.Lime
        Me.Next1De.FlatAppearance.BorderSize = 0
        Me.Next1De.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next1De.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next1De.Location = New System.Drawing.Point(701, 581)
        Me.Next1De.Name = "Next1De"
        Me.Next1De.Size = New System.Drawing.Size(107, 49)
        Me.Next1De.TabIndex = 0
        Me.Next1De.Text = "Next"
        Me.Next1De.UseVisualStyleBackColor = False
        '
        'ReadNor
        '
        Me.ReadNor.AutoSize = True
        Me.ReadNor.BackColor = System.Drawing.Color.MidnightBlue
        Me.ReadNor.Controls.Add(Me.Readnortext)
        Me.ReadNor.Controls.Add(Me.Label1)
        Me.ReadNor.Controls.Add(Me.Stops)
        Me.ReadNor.Controls.Add(Me.Start)
        Me.ReadNor.Location = New System.Drawing.Point(30, 23)
        Me.ReadNor.Name = "ReadNor"
        Me.ReadNor.Size = New System.Drawing.Size(2619, 675)
        Me.ReadNor.TabIndex = 5
        '
        'Readnortext
        '
        Me.Readnortext.AutoEllipsis = True
        Me.Readnortext.AutoSize = True
        Me.Readnortext.BackColor = System.Drawing.Color.White
        Me.Readnortext.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Readnortext.ForeColor = System.Drawing.Color.White
        Me.Readnortext.Location = New System.Drawing.Point(130, 283)
        Me.Readnortext.Name = "Readnortext"
        Me.Readnortext.Size = New System.Drawing.Size(675, 240)
        Me.Readnortext.TabIndex = 2
        Me.Readnortext.Text = resources.GetString("Readnortext.Text")
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(67, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 152)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Next you will read some simple text normaly," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then you will be tested on your com" &
    "prehension." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press start to start reading and press stop when" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you are done."
        '
        'Stops
        '
        Me.Stops.BackColor = System.Drawing.Color.Lime
        Me.Stops.FlatAppearance.BorderSize = 0
        Me.Stops.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stops.Location = New System.Drawing.Point(384, 193)
        Me.Stops.Name = "Stops"
        Me.Stops.Size = New System.Drawing.Size(75, 23)
        Me.Stops.TabIndex = 3
        Me.Stops.Text = "Stop"
        Me.Stops.UseVisualStyleBackColor = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Lime
        Me.Start.FlatAppearance.BorderSize = 0
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Location = New System.Drawing.Point(384, 193)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 4
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'RealBL
        '
        Me.RealBL.BackColor = System.Drawing.Color.MidnightBlue
        Me.RealBL.Controls.Add(Me.Label3)
        Me.RealBL.Controls.Add(Me.EnText)
        Me.RealBL.Controls.Add(Me.Start1bl)
        Me.RealBL.Controls.Add(Me.DemoPlayer1)
        Me.RealBL.Location = New System.Drawing.Point(259, 32)
        Me.RealBL.Name = "RealBL"
        Me.RealBL.Size = New System.Drawing.Size(773, 728)
        Me.RealBL.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(36, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EnText
        '
        Me.EnText.AutoSize = True
        Me.EnText.Location = New System.Drawing.Point(38, 690)
        Me.EnText.Name = "EnText"
        Me.EnText.Size = New System.Drawing.Size(2246, 26)
        Me.EnText.TabIndex = 4
        Me.EnText.Text = resources.GetString("EnText.Text")
        Me.EnText.Visible = False
        '
        'Start1bl
        '
        Me.Start1bl.BackColor = System.Drawing.Color.Lime
        Me.Start1bl.FlatAppearance.BorderSize = 0
        Me.Start1bl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start1bl.Location = New System.Drawing.Point(418, 321)
        Me.Start1bl.Name = "Start1bl"
        Me.Start1bl.Size = New System.Drawing.Size(75, 23)
        Me.Start1bl.TabIndex = 2
        Me.Start1bl.Text = "Go"
        Me.Start1bl.UseVisualStyleBackColor = False
        Me.Start1bl.Visible = False
        '
        'DemoPlayer1
        '
        Me.DemoPlayer1.AutoSize = True
        Me.DemoPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemoPlayer1.ForeColor = System.Drawing.Color.Yellow
        Me.DemoPlayer1.Location = New System.Drawing.Point(493, 336)
        Me.DemoPlayer1.Name = "DemoPlayer1"
        Me.DemoPlayer1.Size = New System.Drawing.Size(0, 108)
        Me.DemoPlayer1.TabIndex = 1
        '
        'Demo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.ReadNor)
        Me.Controls.Add(Me.WelcomeText)
        Me.Controls.Add(Me.RealBL)
        Me.Name = "Demo"
        Me.Text = "Demo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.WelcomeText.ResumeLayout(False)
        Me.WelcomeText.PerformLayout()
        Me.ReadNor.ResumeLayout(False)
        Me.ReadNor.PerformLayout()
        Me.RealBL.ResumeLayout(False)
        Me.RealBL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeText As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Next1De As Button
    Friend WithEvents ReadNor As Panel
    Friend WithEvents Stops As Button
    Friend WithEvents Readnortext As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Start As Button
    Friend WithEvents RealBL As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Start1bl As Button
    Friend WithEvents DemoPlayer1 As Label
    Friend WithEvents EnText As Label
End Class
