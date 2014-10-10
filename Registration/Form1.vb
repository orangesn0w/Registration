Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Form3.Show()
            Me.Close()
        Else
            MsgBox("Invalid Details", 0, "Wrong Username or Password")
        End If
    End Sub
End Class