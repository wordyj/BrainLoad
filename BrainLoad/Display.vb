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
        MsgBox("Reading will start in 3 seconds.")
        Thread.Sleep(1000)
        Thread.Sleep(1000)
        Thread.Sleep(1000)
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
        PlayerPanel.Size = New Size(Width, Height)
        EnMore.Location = New Point((Width / 2) - (EnMore.Width / 2), (Height / 2) - (EnMore.Height / 2))
        If options.Colorv = Nothing Then
            options.Colorv = Color.Black
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

    Private Sub uClip_Click(sender As Object, e As EventArgs) Handles uClip.Click
        Call ClipReader()
        If Not ClipReader() = Nothing Then
            PlayerText.Font = options.Fontv
            TextEntryPanel.Visible = False
            PlayerPanel.Visible = True
            'Filtering
            Dim userinput = ClipReader()
            Dim wCre = userinput.Replace(vbCr, " ").Replace(vbLf, " ")
            Dim wPu = Regex.Replace(wCre, "[^A-Za-z0-9? ]+", String.Empty)
            Dim SplitOutput = Split(wPu)
            If speed = Nothing Then
                speed = 500
            End If
            speedv = (60 / speed) * 1000
            MsgBox("Reading will start in 3 seconds.")
            Thread.Sleep(1000)
            Thread.Sleep(1000)
            Thread.Sleep(1000)
            ''End of filtering
            For Each x In SplitOutput
                PlayerText.Text = x
                My.Application.DoEvents()
                Thread.Sleep(speedv)
            Next
            PlayerText.Text = ""
            Close()
        End If
    End Sub
    Function ClipReader()
        Dim returnText As String = Nothing
        If (Clipboard.ContainsText(TextDataFormat.Text)) Then
            returnText = Clipboard.GetText(TextDataFormat.Text)
        Else returnText = Nothing
        End If
        Return returnText
    End Function
End Class