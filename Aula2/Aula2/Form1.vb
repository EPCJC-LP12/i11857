Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        soma()


    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub soma()
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 + num2

        TextBox3.Text = res

    End Sub
    Private Sub subtracao()
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 - num2

        TextBox3.Text = res
    End Sub

    Private Sub mult()
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 * num2

        TextBox3.Text = res

    End Sub
    Private Sub div()
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res = num1 / num2

        TextBox3.Text = res

    End Sub


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        subtracao()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        div()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mult()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
