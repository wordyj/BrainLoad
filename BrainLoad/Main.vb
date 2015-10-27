Public Class Main
    Private Sub EnterTOpen_Click(sender As Object, e As EventArgs) Handles EnterTOpen.Click
        Display.Show()
    End Sub

    Private Sub DemoOpen_Click(sender As Object, e As EventArgs) Handles DemoOpen.Click
        Demo.Show()
    End Sub

    Private Sub OptionsOpen_Click(sender As Object, e As EventArgs) Handles OptionsOpen.Click
        options.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display.speedv = 150
        options.Fontv = options.FontDialog1.Font
        BrainLoadTitle.Location = New Point((Me.Width / 2) - (BrainLoadTitle.Width / 2), (Height / 4))
        DemoOpen.Location = New Point((Me.Width / 2) - (DemoOpen.Width / 2), (Me.Height / 2) - (DemoOpen.Height / 2))
        EnterTOpen.Location = New Point((DemoOpen.Location.X - 100), DemoOpen.Location.Y)
        OptionsOpen.Location = New Point((DemoOpen.Location.X + 100), DemoOpen.Location.Y)
    End Sub

    Private Sub Main_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        BrainLoadTitle.Location = New Point((Me.Width / 2) - (BrainLoadTitle.Width / 2), (Height / 4))
        DemoOpen.Location = New Point((Me.Width / 2) - (DemoOpen.Width / 2), (Me.Height / 2) - (DemoOpen.Height / 2))
        EnterTOpen.Location = New Point((DemoOpen.Location.X - 100), DemoOpen.Location.Y)
        OptionsOpen.Location = New Point((DemoOpen.Location.X + 100), DemoOpen.Location.Y)
    End Sub
End Class