Public Class Demo_Quizes
    Public Shared Question1Result As Integer
    Public Shared Question2Result As Integer
    Public Shared Question3Result As Integer
    Public Shared Question4Result As Integer
    Public Shared Question5Result As Integer
    Public Shared ComprehensionScore As Integer
    Private Sub Demo_Quizes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Question1.Location = New Point(0, 0)
        Question2.Location = New Point(0, 0)
        Question3.Location = New Point(0, 0)
        Question4.Location = New Point(0, 0)
        Question5.Location = New Point(0, 0)
    End Sub

    Private Sub Answer1a_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1a.CheckedChanged
        Question1Submit.Enabled = True
    End Sub

    Private Sub Answer1b_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1b.CheckedChanged
        Question1Submit.Enabled = True
    End Sub

    Private Sub Answer1c_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1c.CheckedChanged
        Question1Submit.Enabled = True
    End Sub

    Private Sub Answer1d_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1d.CheckedChanged
        Question1Submit.Enabled = True
    End Sub

    Private Sub Question1Submit_Click_1(sender As Object, e As EventArgs) Handles Question1Submit.Click
        If Answer1c.Checked = True Then
            Question1Result = 1
            Question1.Visible = False
            Question2.Visible = True
        Else
            Question1Result = 0
            Question1.Visible = False
            Question2.Visible = True
        End If
    End Sub

    Private Sub Question2Text_TextChanged(sender As Object, e As EventArgs) Handles Question2Text.TextChanged
        Question2Submit.Enabled = True
    End Sub

    Private Sub Question2Submit_Click(sender As Object, e As EventArgs) Handles Question2Submit.Click
        If Question2Text.Text = "Wagga Wagga" Then
            Question2Result = 1
            Question2.Visible = False
            Question3.Visible = True
        ElseIf Question2Text.Text = "Wagga"
            Question2Result = 1
            Question2.Visible = False
            Question3.Visible = True
        ElseIf Question2Text.Text = "wagga"
            Question2Result = 1
            Question2.Visible = False
            Question3.Visible = True
        ElseIf Question2Text.Text = "wagga wagga"
            Question2Result = 1
            Question2.Visible = False
            Question3.Visible = True
        Else
            Question2Result = 0
            Question2.Visible = False
            Question3.Visible = True
        End If
    End Sub

    Private Sub Answer3a_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3a.CheckedChanged
        Question3Submit.Enabled = True
    End Sub

    Private Sub Answer3b_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3b.CheckedChanged
        Question3Submit.Enabled = True
    End Sub

    Private Sub Answer3c_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3c.CheckedChanged
        Question3Submit.Enabled = True
    End Sub

    Private Sub Answer3d_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3d.CheckedChanged
        Question3Submit.Enabled = True
    End Sub

    Private Sub Question3Submit_Click(sender As Object, e As EventArgs) Handles Question3Submit.Click
        If Answer3d.Checked = True Then
            Question3Result = 1
            Question3.Visible = False
            Question4.Visible = True
        Else
            Question3Result = 0
            Question3.Visible = False
            Question4.Visible = True
        End If
    End Sub

    Private Sub Question4TB1_TextChanged(sender As Object, e As EventArgs) Handles Question4TB1.TextChanged
        Question4Submit.Enabled = True
    End Sub

    Private Sub Question4TB2_TextChanged(sender As Object, e As EventArgs) Handles Question4TB2.TextChanged
        Question4Submit.Enabled = True
    End Sub

    Private Sub Question4Submit_Click(sender As Object, e As EventArgs) Handles Question4Submit.Click
        If Question4TB1.Text = "4" And Question4TB2.Text = "8" Then
            Question4Result = 1
            Question4.Visible = False
            Question5.Visible = True
        ElseIf Question4TB1.Text = "Four" And Question4TB2.Text = "Eight" Then
            Question4Result = 1
            Question4.Visible = False
            Question5.Visible = True
        ElseIf Question4TB1.Text = "four" And Question4TB2.Text = "eight" Then
            Question4Result = 1
            Question4.Visible = False
            Question5.Visible = True
        Else
            Question4Result = 0
            Question4.Visible = False
            Question5.Visible = True
        End If
    End Sub

    Private Sub Question5TextBox_TextChanged(sender As Object, e As EventArgs) Handles Question5TextBox.TextChanged
        Question5Submit.Enabled = True
    End Sub

    Private Sub Question5Submit_Click(sender As Object, e As EventArgs) Handles Question5Submit.Click
        If Question5TextBox.Text = "6" Then
            Question5Result = 1
            Question5.Visible = False
            ComprehensionScore = (Question1Result + Question2Result + Question3Result + Question4Result + Question5Result) * 20
            MsgBox("Your comprehension was" & ComprehensionScore & "%")
        ElseIf Question5TextBox.Text = "Six" Then
            Question5Result = 1
            Question5Result = 1
            Question5.Visible = False
            ComprehensionScore = (Question1Result + Question2Result + Question3Result + Question4Result + Question5Result) * 20
            MsgBox("Your comprehension was" & ComprehensionScore & "%")
        ElseIf Question5TextBox.Text = "six" Then
            Question5Result = 1
            Question5.Visible = False
            ComprehensionScore = (Question1Result + Question2Result + Question3Result + Question4Result + Question5Result) * 20
            MsgBox("Your comprehension was" & ComprehensionScore & "%")
            Question5Result = 1
        Else
            Question5Result = 0
            Question5Result = 1
            Question5.Visible = False
            ComprehensionScore = (Question1Result + Question2Result + Question3Result + Question4Result + Question5Result) * 20
            MsgBox("Your comprehension was" & ComprehensionScore & "%")
        End If
    End Sub
End Class
