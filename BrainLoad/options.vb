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

        End If
    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display.speedv = 150
        Location = New Point((Main.Width / 2) - (Width / 2), (Main.Height / 2) - (Height / 2) + 30)
    End Sub
End Class