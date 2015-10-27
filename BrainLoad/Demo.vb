Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Demo
    Public Shared finishtime As Date
    Public Shared starttime As Date
    Public Shared Readtime As TimeSpan
    Public Shared WPM As String
    Public Shared NewWPM As String
    Public Shared SPW As String
    Private Sub Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setting the Size and locations of items
        ReadNor.Visible = False
        ReadNor.Location = New Point(12, 12)
        WelcomeText.Location = New Point(12, 12)
        WelcomeText.Visible = True
        Readnortext.Visible = True
        Readnortext.ForeColor = Color.White
        Stops.Visible = False
        RealBL.Visible = False
        RealBL.Location = New Point(12, 12)
        Label2.Location = New Point((Width / 2) - (Label2.Width / 2), 2)
        Next1De.Location = New Point((Width / 2) - (Next1De.Width / 2), (Label2.Height) + 100)
        ReadNor.Size = New Size(Width, Height)
        WelcomeText.Size = New Size(Width - 20, Height - 20)
        RealBL.Size = New Size(Width - 150, Height - 200)
        Start.Location = New Point((Width / 2) - (Start.Width / 2), (Height / 2) - (Start.Height / 2) + 200)
        Stops.Location = New Point((Width / 2) - (Stops.Width / 2), (Height / 2) - (Stops.Height / 2) + 200)
        Readnortext.Location = New Point((Width / 2) - (Readnortext.Width / 2), (Height / 2) - (Readnortext.Height) + 100)
        Readnortext.Size = New Point(Width, Height)
        Label1.Location = New Point((Width / 2) - (Label1.Width / 2), (Height / 2) - (Label1.Height * 2))
    End Sub 'Location and Size
    Private Sub Next1De_Click_1(sender As Object, e As EventArgs) 'Changing of visibilities
        ReadNor.Visible = True
        WelcomeText.Visible = False
    End Sub

    Private Sub Next2De_Click(sender As Object, e As EventArgs)
        Demo_Quizes.Show()
        Start.Visible = False
        Stops.Visible = False
        Readnortext.Visible = False
        Label1.Visible = False
        ReadNor.Visible = False
    End Sub

    Private Sub Next1De_Click(sender As Object, e As EventArgs) Handles Next1De.Click
        ReadNor.Visible = True
        ReadNor.BringToFront()
        WelcomeText.Visible = False
    End Sub

    Private Sub Start_Click_1(sender As Object, e As EventArgs) Handles Start.Click
        Start.Visible = False
        Stops.Visible = True
        starttime = Now
        'MsgBox(starttime)
        Readnortext.ForeColor = Color.Black
        Label1.Visible = False
    End Sub

    Private Sub Stops_Click_1(sender As Object, e As EventArgs) Handles Stops.Click
        Start.Visible = False
        Stops.Visible = False
        Readnortext.Visible = False
        finishtime = Now
        Readtime = (finishtime - starttime)
        WPM = 78 / (Readtime.Minutes + (Readtime.Seconds / 60))
        MsgBox("Your Speed was:" & WPM & " Words per minute")
        Demo_Quizes.Show()
        Label1.Visible = False
        ReadNor.Visible = True
        NewWPM = WPM * 2
        ReadNor.Visible = False
        WelcomeText.Visible = False
        RealBL.Visible = True

        If WPM > 400 Then
            NewWPM = WPM + 200
        End If
        SPW = (60 / NewWPM) * 1000
        'Label3.Text = "You read at a speed of " & WPM & " and a " & Demo_Quizes.CompRes & "Percent Comprehension Rate. Now we will read some new text at " & NewWPM &
        '". Remember
        'Don 't panic if you miss a word panicking will make you miss more
        'Dont ' Subvocalise (The voice in your head) just look at the word
        'Relax"
    End Sub
    Private Sub Start1bl_Click(sender As Object, e As EventArgs) Handles Start1bl.Click
        'Filtering
        Label3.Text = Nothing
        Dim userinput = EnText.Text
        Dim wCre = userinput.Replace(vbCr, " ").Replace(vbLf, " ")
        Dim wPu = Regex.Replace(wCre, "[^A-Za-z0-9? ]+", String.Empty)
        Dim SplitOutput = Split(wPu)
        ''End of filtering
        For Each x In SplitOutput
            DemoPlayer1.Text = x
            My.Application.DoEvents()
            Thread.Sleep(SPW)
        Next
        DemoPlayer1.Text = ""
        Demo_Quizes2.Show()
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Start1bl.TextChanged, Label3.TextChanged
        Label3.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub Demo_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Label2.Location = New Point((Width / 2) - (Label2.Width / 2), 2)
        Next1De.Location = New Point((Width / 2) - (Next1De.Width / 2), (Label2.Height) + 100)
        ReadNor.Size = New Size(Width, Height)
        WelcomeText.Size = New Size(Width - 20, Height - 20)
        RealBL.Size = New Size(Width - 150, Height - 200)
        Start.Location = New Point((Width / 2) - (Start.Width / 2), (Height / 2) - (Start.Height / 2))
        Stops.Location = New Point((Width / 2) - (Stops.Width / 2), (Height / 2) - (Stops.Height / 2))
        Readnortext.Location = New Point((Width / 2) - (Readnortext.Width / 2), (Height / 2) - (Readnortext.Height) - 200)
        Label1.Location = New Point((Width / 2) - (Label1.Width / 2), (Height / 2) - (Label1.Height / 2) - 200)
        ReadNor.Visible = False
        ReadNor.Location = New Point(12, 12)
        WelcomeText.Location = New Point(12, 12)
        'WelcomeText.Visible = True
        'Readnortext.Visible = True
        'Readnortext.ForeColor = Color.White
        'Stops.Visible = False
        'RealBL.Visible = False
        RealBL.Location = New Point(12, 12)
        Label2.Location = New Point((Width / 2) - (Label2.Width / 2), 2)
        Next1De.Location = New Point((Width / 2) - (Next1De.Width / 2), (Label2.Height) + 100)
        ReadNor.Size = New Size(Width, Height)
        WelcomeText.Size = New Size(Width - 20, Height - 20)
        RealBL.Size = New Size(Width - 150, Height - 200)
        Start.Location = New Point((Width / 2) - (Start.Width / 2), (Height / 2) - (Start.Height / 2))
        Stops.Location = New Point((Width / 2) - (Stops.Width / 2), (Height / 2) - (Stops.Height / 2))
        Readnortext.Location = New Point((Width / 2) - (Readnortext.Width / 2), (Height / 2) - (Readnortext.Height) - 200)
        Readnortext.Size = New Point(Width, Height)
        Label1.Location = New Point((Width / 2) - (Label1.Width / 2), (Height / 2) - (Label1.Height / 2) - 200)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class