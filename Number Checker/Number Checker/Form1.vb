Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer
        Try
            number = Convert.ToInt32(TextBox1.Text)
            If number >= 0 Then
                TextBox2.Text = "Positive Number!"
            Else
                TextBox2.Text = "Negative Number!"
            End If
        Catch ex As Exception
            MessageBox.Show("Please input a number.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
