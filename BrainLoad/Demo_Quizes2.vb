Public Class Demo_Quizes2
    Public Shared que1
    Public Shared que2
    Public Shared que3
    Public Shared que4
    Public Shared que5
    Private Sub Demo_Quizes2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        q1.Visible = True
        q2.Visible = False
        q3.Visible = False
        q4.Visible = False
        q5.Visible = False
        Review.Visible = False
        q5.Location = New Point(12, 12)
        q4.Location = New Point(12, 12)
        q3.Location = New Point(12, 12)
        q2.Location = New Point(12, 12)
        q1.Location = New Point(12, 12)
        Review.Location = New Point(12, 12)
    End Sub

    Private Sub QuizNext1_Click(sender As Object, e As EventArgs) Handles QuizNext1.Click
        If RadioButton7.Checked = True Then
            que1 = 1
        Else que1 = 0
        End If
        q1.Visible = False
        q2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If xy.Checked = True Then
            que2 = 1
        Else
            que2 = 0
        End If
        q2.Visible = False
        q3.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If t.checked = True Then
            que3 = 1
        Else
            que3 = 0
        End If
        q3.Visible = False
        q4.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If p.Checked = True Then
            que4 = 1
        Else
            que4 = 0
        End If
        q4.Visible = False
        q5.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If v.Checked = True Then
            que5 = 1
        Else
            que5 = 0
        End If
        q5.Visible = False
        Dim core As String
        core = (que1 + que2 + que3 + que4 + que5) * 20
        Demo.Close()
        Review.Visible = True
        'Norcompres.Text = "Comprehension:" & Demo_Quizes.CompRes & "%"
        norspeed.Text = "Speed:" & Demo.WPM & " WPM"
        realcompres.Text = "Comprehension:" & core & "%"
        realspeed.Text = "Speed:" & Demo.NewWPM & " WPM"
    End Sub

    Private Sub q3_Paint(sender As Object, e As PaintEventArgs) Handles q3.Paint

    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged

    End Sub
End Class