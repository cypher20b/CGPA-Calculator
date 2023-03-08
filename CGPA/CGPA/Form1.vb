Public Class Form1
    Dim A
    Dim B
    Dim C
    Dim D
    Private Sub letter_TextChanged(sender As Object, e As EventArgs) Handles letter0.TextChanged
        letter0.Text = Val(letter0)
    End Sub

    Private Sub credithours_TextChanged(sender As Object, e As EventArgs) Handles credithours0.TextChanged
        credithours0.Text = Val(credithours0.Text)
    End Sub

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        calc.Text = Val(credithours0.Text) * Val(letter0.Text)
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        If letter0 = A Then
            gpa0.Text = 4
        ElseIf letter0 = A -
            gpa0 = 3.75 Then
        ElseIf letter0 = B +
            gpa0.Text = 3.5 Then
        ElseIf letter0 = B Then
            gpa0.Text = 3.25
        ElseIf letter0 = B -
        gpa0.Text = 3 Then
        ElseIf letter0 = C +
        gpa0.Text = 2.75 Then
        ElseIf letter0 = C Then
            gpa0.Text = 2.5
        ElseIf letter0 = C -
        gpa0.Text = 2.25 Then
        ElseIf letter0 = D +
            gpa0.Text = 2 Then
        ElseIf letter0 = D Then
            gpa0.Text = 1.75
        End If
    End Sub
End Class
