Public Class options
    Public Shared Fontv
    Public Shared Colorv
    Private Sub FontCaller_Click(sender As Object, e As EventArgs) Handles FontCaller.Click
        FontDialog1.ShowColor = True
        Fontv = FontDialog1.Font
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Fontv = FontDialog1.Font
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Display.speed = ComboBox1.SelectedItem

    End Sub

    Private Sub ColorCaller_Click(sender As Object, e As EventArgs) Handles ColorCaller.Click
        If ColorDialog1.ShowDialog() Then
            Colorv = ColorDialog1.Color
            If ColorDialog1.ShowDialog = DialogResult.OK Then
                Colorv = FontDialog1.Font
            End If
        End If
    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display.speedv = 150
        CheckBox1.Checked = checkbox1Save
        Location = New Point((Main.Width / 2) - (Width / 2), (Main.Height / 2) - (Height / 2) + 30)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            checkbox1Save = CheckBox1.Checked
            FontCaller.Enabled = False
            ColorCaller.Enabled = False
            ComboBox1.Enabled = False
            Fontv = FontDialog2.Font
            Colorv = ColorDialog2.Color
            Display.speed = 100
        End If
    End Sub
End Class