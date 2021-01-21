Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        Label1.Text = Rnd()
        'random from 0 to 0.999999
        Label2.Text = Rnd() * 10
        'random from 0 to 9.999999
        Label3.Text = Int(Rnd() * 10)
        'random from 0 to 9
        Label4.Text = Int(Rnd() * 10) + 1
        'random from 1 to 10
        Label5.Text = Int(Rnd() * 5) + 3
        'random from 3 to 7
        ' 5 is the range number
        ' 3 is the modifier
        Label6.Text = Int(Rnd() * 7) + 2
        ' random number from 2 to 8
        Label7.Text = Int(Rnd() * 122) + 37
        ' random number from 37 to 158
        ' RANGE = high - low + 1
        ' 158 - 37 + 1
        ' MODIFIER = low
        Label8.Text = Int(Rnd() * 17) - 2
        ' random number from -2 to 14
        ' RANGE = 14 --2 +1
        ' MODIFIER = -2
    End Sub
End Class
