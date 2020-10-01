Public Class Midterm1Program

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
        Dim Mynumber As Integer
        Mynumber = Val(txtNumber.Text)
        If Mynumber = 100 And Mynumber <= 199 Then
            txtLocation.Text = "Basement"
        Else
            If Mynumber >= 200 And Mynumber <= 500 Or Mynumber > 900 Then
                txtLocation.Text = "Main Floor"
            Else
                If Mynumber >= 501 And Mynumber <= 900 And Not Mynumber >= 700 And Mynumber <= 750 Then
                    txtLocation.Text = "Upper Floor"
                Else
                    If Mynumber >= 700 And Mynumber <= 750 Then
                        txtLocation.Text = "Archives"

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Midterm1Program_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
