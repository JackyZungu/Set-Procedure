Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNum, secNum As Integer

        firstNum = Val(TextBox1.Text)
        secNum = Val(TextBox2.Text)

        sum(firstNum, secNum)
    End Sub
    Sub sum(a As Integer, b As Integer)
        Dim Total As Integer

        Total = a + b

        TextBox3.Text = Total

    End Sub
End Class
