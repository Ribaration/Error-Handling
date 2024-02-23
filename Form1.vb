Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

            Try

                Dim userInput As Integer = Integer.Parse(TextBox1.Text)

                Dim result As Integer = userInput * 3

                Label1.Text = "Result: " & result.ToString()
            Catch ex As FormatException

                Label1.Text = "Error: Please enter a valid number."
            End Try
        End Sub


End Class
