Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox1.Focus()
        '        TextBox5.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = Str(Val(TextBox1.Text) ^ 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox5.Text = Str(Val(TextBox1.Text) * Val(TextBox2.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Double = Val(TextBox1.Text)
        Dim b As Double = Val(TextBox2.Text)
        Dim y As Double = Val(TextBox4.Text)
        Dim s As Double
        If y <> 0 Then
            s = a * b * Math.Sin(y * Math.PI / 180) / 2
        Else
            Dim c As Double = Val(TextBox3.Text)
            Dim p As Double = (a + b + c) / 2
            s = (p * (p - a) * (p - b) * (p - c)) ^ 0.5
        End If
        s = Math.Round(s, 3)
        TextBox5.Text = Str(s)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Double = Val(TextBox1.Text)
        Dim b As Double = Val(TextBox2.Text)
        Dim y As Double = Val(TextBox4.Text)
        If y <> 0 Then
            Dim s As Double = a * b * Math.Sin(y * Math.PI / 180)
            s = Math.Round(s, 3)
            TextBox5.Text = Str(s)
        Else
            Button2_Click(sender, e)
        End If
    End Sub

End Class
