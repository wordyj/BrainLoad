Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Display
    Public Shared speed
    Public Shared speedv
    Private Sub RunPlay_Click(sender As Object, e As EventArgs) Handles RunPlay.Click
        PlayerText.Font = options.Fontv
        TextEntryPanel.Visible = False
        PlayerPanel.Visible = True
        'Filtering
        Dim userinput = UserTextEn.Text
        Dim wCre = userinput.Replace(vbCr, " ").Replace(vbLf, " ")
        Dim wPu = Regex.Replace(wCre, "[^A-Za-z0-9? ]+", String.Empty)
        Dim SplitOutput = Split(wPu)
        If speed = Nothing Then
            speed = 500
        End If
        speedv = (60 / speed) * 1000
        MsgBox(speed)
        MsgBox(speedv)
        ''End of filtering
        If speedv = vbNull Then
            MsgBox("")
        End If
        For Each x In SplitOutput
            PlayerText.Text = x
            My.Application.DoEvents()
            Thread.Sleep(speedv)
        Next
        PlayerText.Text = ""
        Close()
    End Sub
    Private Sub EnMore_Click(sender As Object, e As EventArgs) Handles EnMore.Click
        PlayerPanel.Visible = False
        TextEntryPanel.Visible = True
        EnMore.Visible = False
    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEntryPanel.Location = New Point((Me.Width / 2) - (TextEntryPanel.Width / 2), (Me.Height / 2) - (TextEntryPanel.Height / 2))
        PlayerPanel.Location = New Point((Width / 2) - (PlayerPanel.Width / 2), (Height / 2) - (PlayerPanel.Height / 2))
        EnMore.Location = New Point((Width / 2) - (EnMore.Width / 2), (Height / 2) - (EnMore.Height / 2))
        If options.Colorv = Nothing Then
            options.Colorv = Color.FromArgb(25, 25, 112)
        End If
        BackColor = options.Colorv
        PlayerText.Font = options.Fontv
        PlayerText.ForeColor = options.FontDialog1.Color
    End Sub

    Private Sub Display_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        TextEntryPanel.Location = New Point((Me.Width / 2) - (TextEntryPanel.Width / 2), (Me.Height / 2) - (TextEntryPanel.Height / 2))
        PlayerPanel.Location = New Point((Width / 2) - (PlayerPanel.Width / 2), (Height / 2) - (PlayerPanel.Height / 2))
        EnMore.Location = New Point((Width / 2) - (EnMore.Width / 2), (Height / 2) - (EnMore.Height / 2))
    End Sub
End Class