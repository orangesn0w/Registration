Imports Registration.UserPass
Public Module UserPass
    Public username As String = ""
    Public password As String = ""
End Module 'not the best way to store stuff, would be reset on program launch, but whatever it's just an example

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = username And TextBox2.Text = password Then
            Form3.Show()
            Me.Close()
        Else
            MsgBox("Invalid Details", 0, "Wrong Username or Password")
        End If
    End Sub
End Class