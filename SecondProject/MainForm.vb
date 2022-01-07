Public Class MainForm
    '

    Function sumSq(a As Double, b As Double) As Double
        sumSq = a ^ 2 + b ^ 2
    End Function

    Dim ind As Integer = 25
    Dim pName As String = "Примерен текст"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Label1.Click
        Dim A, B, C As Double
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = A + B
        TextBox3.Text = Str(C)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A, B, C As Double
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = A - B
        TextBox3.Text = Str(C)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A, B, C As Double
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        C = A * B
        TextBox3.Text = Str(C)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim M, Nb, c As Double
        M = Val(TextBox1.Text)
        Nb = Val(TextBox1.Text)
        c = M + Nb
        TextBox3.Text = Str(c)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = sumSq(Val(TextBox1.Text), Val(TextBox2.Text))
    End Sub
End Class
