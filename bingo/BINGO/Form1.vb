Public Class Form1
    Public numero As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero = 1
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button1.Enabled = False
        ListBox1.Items.Add(numero)






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button101.Enabled = False
        Button101.Visible = False

    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        Button101.SendToBack()
        Button101.Enabled = False
        Button101.Visible = False




    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numero = 2
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button2.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numero = 3
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button3.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numero = 4
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button4.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numero = 5
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button5.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numero = 6
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button6.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numero = 7
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button7.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numero = 8
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button8.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numero = 9
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button9.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        numero = 10
        Button101.Enabled = True
        Button101.Visible = True
        Button101.Text = numero
        Button101.BringToFront()
        Button10.Enabled = False
        ListBox1.Items.Add(numero)

    End Sub
End Class
