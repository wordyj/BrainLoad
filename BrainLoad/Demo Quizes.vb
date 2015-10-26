Public Class Demo_Quizes
    Public Shared Quest11 As Integer
    Public Shared Quest12 As Integer
    Public Shared Quest13 As Integer
    Public Shared Quest14 As Integer
    Public Shared Quest15 As Integer
    Public Shared CompRes

    Private Sub Demo_Quizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qu1q.Visible = True
        qu1q2.Visible = False
        qu1q3.Visible = False
        qu1q4.Visible = False
        qu1q5.Visible = False
        qu1q2.Location = New Point(12, 12)
        qu1q.Location = New Point(12, 12)
        qu1q3.Location = New Point(12, 12)
        qu1q4.Location = New Point(12, 12)
        qu1q5.Location = New Point(12, 12)
    End Sub

    Private Sub QuizNext1_Click(sender As Object, e As EventArgs) Handles QuizNext1.Click
        If Chicago.Checked = True Then
            Quest11 = 1
            'MsgBox("y")
        Else
            Quest11 = 0
        End If
        qu1q.Visible = False
        qu1q2.Visible = True
    End Sub
    Private Sub QuizNext5_Click(sender As Object, e As EventArgs) Handles QuizNext5.Click
        If CapB.Checked = True Then
            Quest15 = 1
            'MsgBox("y")
        Else
            Quest15 = 0
        End If
        qu1q5.Visible = False
        CompRes = (Quest15 + Quest14 + Quest13 + Quest12 + Quest11) * 20
        Demo.Start1bl.Visible = True
        Demo.Label3.Text =
          "You read at a speed of " & Demo.WPM & " Words Per Minute and a " & CompRes & " Percent Comprehension Rate.
          Now we will read some new text at " & Demo.NewWPM &
        " WPM. Remember,
          Don 't panic if you miss a word panicking will make you miss more
          Dont ' Subvocalise (The voice in your head) just look at the word
          Relax"
        Demo.Label3.TextAlign = ContentAlignment.TopCenter
        Close()
    End Sub

    Private Sub QuizNext2_Click(sender As Object, e As EventArgs) Handles QuizNext2.Click
        If Canberran.Checked = True Then
            Quest12 = 1
            'MsgBox("y")
        Else
            Quest12 = 0
        End If
        qu1q2.Visible = False
        qu1q3.Visible = True
    End Sub

    Private Sub QuizNext3_Click(sender As Object, e As EventArgs) Handles QuizNext3.Click
        If Turcor.Checked = True Then
            Quest13 = 1
            'MsgBox("y")
        Else
            Quest13 = 0
        End If
        qu1q3.Visible = False
        Qu1q4.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If F.Checked = True Then
            Quest14 = 1
            'MsgBox("y")
        Else
            Quest14 = 0
        End If
        Qu1q4.Visible = False
        qu1q5.Visible=True
    End Sub
End Class