Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim preço, consumo, distancia, res1, res2 As Double
        preço = TextBox1.Text
        consumo = TextBox2.Text
        distancia = TextBox3.Text

        res1 = consumo * distancia / 100
        res2 = res1 * preço

        TextBox4.Text = res1
        TextBox5.Text = res2


    End Sub
End Class
