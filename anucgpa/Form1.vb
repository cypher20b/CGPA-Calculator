Public Class Form1

    Dim A = 4
    Dim AM = 3.75
    Dim BP = 3.5
    Dim B = 3.25
    Dim BM = 3
    Dim CP = 2.75
    Dim C = 2.5
    Dim CM = 2.25
    Dim DP = 2
    Dim D = 1.75
    Dim DM = 1.5
    Dim hidden
    Dim hidden1
    Dim hdgpa
    Dim hdgpa1
    Dim hideme
    Dim hideme1
    Dim hdcredithrs
    Dim hdcredithrs1




    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        If gradepoint0.Text = "A" Then
            gpa.Text = 4 * credithrs0.Text
        ElseIf gradepoint0.Text = "AM" Then
            gpa.Text = 3.75 * credithrs0.Text
        ElseIf gradepoint0.Text = "BP" Then
            gpa.Text = 3.5 * credithrs0.Text
        ElseIf gradepoint0.Text = "B" Then
            gpa.Text = 3.25 * credithrs0.Text
        ElseIf gradepoint0.Text = "BM" Then
            gpa.Text = 3 * credithrs0.Text
        ElseIf gradepoint0.Text = "CP" Then
            gpa.Text = 2.75 * credithrs0.Text
        ElseIf gradepoint0.Text = "C" Then
            gpa.Text = 2.5 * credithrs0.Text
        ElseIf gradepoint0.Text = "CM" Then
            gpa.Text = 2.25 * credithrs0.Text
        ElseIf gradepoint0.Text = "DP" Then
            gpa.Text = 2 * credithrs0.Text
        ElseIf gradepoint0.Text = "D" Then
            gpa.Text = 1.75 * credithrs0.Text
        ElseIf gradepoint0.Text = "DM" Then
            gpa.Text = 1.5 * credithrs0.Text
        End If

        If gradepoint1.Text = "A" Then
            gpa1.Text = 4 * credithrs1.Text
        ElseIf gradepoint1.Text = "AM" Then
            gpa1.Text = 3.75 * credithrs1.Text
        ElseIf gradepoint1.Text = "BP" Then
            gpa1.Text = 3.5 * credithrs1.Text
        ElseIf gradepoint1.Text = "B" Then
            gpa1.Text = 3.25 * credithrs1.Text
        ElseIf gradepoint1.Text = "BM" Then
            gpa1.Text = 3 * credithrs1.Text
        ElseIf gradepoint1.Text = "CP" Then
            gpa1.Text = 2.75 * credithrs1.Text
        ElseIf gradepoint1.Text = "C" Then
            gpa1.Text = 2.5 * credithrs1.Text
        ElseIf gradepoint1.Text = "CM" Then
            gpa1.Text = 2.25 * credithrs1.Text
        ElseIf gradepoint1.Text = "DP" Then
            gpa1.Text = 2 * credithrs1.Text
        ElseIf gradepoint1.Text = "D" Then
            gpa1.Text = 1.75 * credithrs1.Text
        ElseIf gradepoint1.Text = "DM" Then
            gpa1.Text = 1.5 * credithrs1.Text
        End If
        If gradepoint2.Text = "A" Then
            gpa2.Text = 4 * credithrs2.Text
        ElseIf gradepoint2.Text = "AM" Then
            gpa2.Text = 3.75 * credithrs2.Text
        ElseIf gradepoint2.Text = "BP" Then
            gpa2.Text = 3.5 * credithrs2.Text
        ElseIf gradepoint2.Text = "B" Then
            gpa2.Text = 3.25 * credithrs2.Text
        ElseIf gradepoint2.Text = "BM" Then
            gpa2.Text = 3 * credithrs2.Text
        ElseIf gradepoint2.Text = "CP" Then
            gpa2.Text = 2.75 * credithrs2.Text
        ElseIf gradepoint2.Text = "C" Then
            gpa2.Text = 2.5 * credithrs2.Text
        ElseIf gradepoint2.Text = "CM" Then
            gpa2.Text = 2.25 * credithrs2.Text
        ElseIf gradepoint2.Text = "DP" Then
            gpa2.Text = 2 * credithrs2.Text
        ElseIf gradepoint2.Text = "D" Then
            gpa2.Text = 1.75 * credithrs2.Text
        ElseIf gradepoint2.Text = "DM" Then
            gpa2.Text = 1.5 * credithrs2.Text
        End If

        If gradepoint3.Text = "A" Then
            gpa3.Text = 4 * credithrs3.Text
        ElseIf gradepoint3.Text = "AM" Then
            gpa3.Text = 3.75 * credithrs3.Text
        ElseIf gradepoint3.Text = "BP" Then
            gpa3.Text = 3.5 * credithrs3.Text
        ElseIf gradepoint3.Text = "B" Then
            gpa3.Text = 3.25 * credithrs3.Text
        ElseIf gradepoint3.Text = "BM" Then
            gpa3.Text = 3 * credithrs3.Text
        ElseIf gradepoint3.Text = "CP" Then
            gpa3.Text = 2.75 * credithrs3.Text
        ElseIf gradepoint3.Text = "C" Then
            gpa3.Text = 2.5 * credithrs3.Text
        ElseIf gradepoint3.Text = "CM" Then
            gpa3.Text = 2.25 * credithrs3.Text
        ElseIf gradepoint3.Text = "DP" Then
            gpa3.Text = 2 * credithrs3.Text
        ElseIf gradepoint3.Text = "D" Then
            gpa3.Text = 1.75 * credithrs3.Text
        ElseIf gradepoint3.Text = "DM" Then
            gpa3.Text = 1.5 * credithrs3.Text
        End If

        If gradepoint4.Text = "A" Then
            gpa4.Text = 4 * credithrs4.Text
        ElseIf gradepoint4.Text = "AM" Then
            gpa4.Text = 3.75 * credithrs4.Text
        ElseIf gradepoint4.Text = "BP" Then
            gpa4.Text = 3.5 * credithrs4.Text
        ElseIf gradepoint4.Text = "B" Then
            gpa4.Text = 3.25 * credithrs4.Text
        ElseIf gradepoint4.Text = "BM" Then
            gpa4.Text = 3 * credithrs4.Text
        ElseIf gradepoint4.Text = "CP" Then
            gpa4.Text = 2.75 * credithrs4.Text
        ElseIf gradepoint4.Text = "C" Then
            gpa4.Text = 2.5 * credithrs4.Text
        ElseIf gradepoint4.Text = "CM" Then
            gpa4.Text = 2.25 * credithrs4.Text
        ElseIf gradepoint4.Text = "DP" Then
            gpa4.Text = 2 * credithrs4.Text
        ElseIf gradepoint4.Text = "D" Then
            gpa4.Text = 1.75 * credithrs4.Text
        ElseIf gradepoint4.Text = "DM" Then
            gpa4.Text = 1.5 * credithrs4.Text
        End If

        If gradepoint5.Text = "A" Then
            gpa5.Text = 4 * credithrs5.Text
        ElseIf gradepoint5.Text = "AM" Then
            gpa5.Text = 3.75 * credithrs5.Text
        ElseIf gradepoint5.Text = "BP" Then
            gpa5.Text = 3.5 * credithrs5.Text
        ElseIf gradepoint5.Text = "B" Then
            gpa5.Text = 3.25 * credithrs5.Text
        ElseIf gradepoint5.Text = "BM" Then
            gpa5.Text = 3 * credithrs5.Text
        ElseIf gradepoint5.Text = "CP" Then
            gpa5.Text = 2.75 * credithrs5.Text
        ElseIf gradepoint5.Text = "C" Then
            gpa5.Text = 2.5 * credithrs5.Text
        ElseIf gradepoint5.Text = "CM" Then
            gpa5.Text = 2.25 * credithrs5.Text
        ElseIf gradepoint5.Text = "DP" Then
            gpa5.Text = 2 * credithrs5.Text
        ElseIf gradepoint5.Text = "D" Then
            gpa5.Text = 1.75 * credithrs5.Text
        ElseIf gradepoint5.Text = "DM" Then
            gpa5.Text = 1.5 * credithrs5.Text
        End If

        If gradepoint6.Text = "A" Then
            gpa6.Text = 4 * credithrs6.Text
        ElseIf gradepoint6.Text = "AM" Then
            gpa6.Text = 3.75 * credithrs6.Text
        ElseIf gradepoint6.Text = "BP" Then
            gpa6.Text = 3.5 * credithrs6.Text
        ElseIf gradepoint6.Text = "B" Then
            gpa6.Text = 3.25 * credithrs6.Text
        ElseIf gradepoint6.Text = "BM" Then
            gpa6.Text = 3 * credithrs6.Text
        ElseIf gradepoint6.Text = "CP" Then
            gpa6.Text = 2.75 * credithrs6.Text
        ElseIf gradepoint6.Text = "C" Then
            gpa6.Text = 2.5 * credithrs6.Text
        ElseIf gradepoint6.Text = "CM" Then
            gpa6.Text = 2.25 * credithrs6.Text
        ElseIf gradepoint6.Text = "DP" Then
            gpa6.Text = 2 * credithrs6.Text
        ElseIf gradepoint6.Text = "D" Then
            gpa6.Text = 1.75 * credithrs6.Text
        ElseIf gradepoint6.Text = "DM" Then
            gpa6.Text = 1.5 * credithrs6.Text
        End If

        If gradepoint7.Text = "A" Then
            gpa7.Text = 4 * credithrs7.Text
        ElseIf gradepoint7.Text = "AM" Then
            gpa7.Text = 3.75 * credithrs7.Text
        ElseIf gradepoint7.Text = "BP" Then
            gpa7.Text = 3.5 * credithrs7.Text
        ElseIf gradepoint7.Text = "B" Then
            gpa7.Text = 3.25 * credithrs7.Text
        ElseIf gradepoint7.Text = "BM" Then
            gpa7.Text = 3 * credithrs7.Text
        ElseIf gradepoint7.Text = "CP" Then
            gpa7.Text = 2.75 * credithrs7.Text
        ElseIf gradepoint7.Text = "C" Then
            gpa7.Text = 2.5 * credithrs0.Text
        ElseIf gradepoint7.Text = "CM" Then
            gpa7.Text = 2.25 * credithrs7.Text
        ElseIf gradepoint7.Text = "DP" Then
            gpa7.Text = 2 * credithrs7.Text
        ElseIf gradepoint7.Text = "D" Then
            gpa7.Text = 1.75 * credithrs7.Text
        ElseIf gradepoint7.Text = "DM" Then
            gpa7.Text = 1.5 * credithrs7.Text
        End If

        If gradepoint8.Text = "A" Then
            gpa8.Text = 4 * credithrs8.Text
        ElseIf gradepoint8.Text = "AM" Then
            gpa8.Text = 3.75 * credithrs8.Text
        ElseIf gradepoint8.Text = "BP" Then
            gpa8.Text = 3.5 * credithrs8.Text
        ElseIf gradepoint8.Text = "B" Then
            gpa8.Text = 3.25 * credithrs8.Text
        ElseIf gradepoint8.Text = "BM" Then
            gpa8.Text = 3 * credithrs8.Text
        ElseIf gradepoint8.Text = "CP" Then
            gpa8.Text = 2.75 * credithrs8.Text
        ElseIf gradepoint8.Text = "C" Then
            gpa8.Text = 2.5 * credithrs8.Text
        ElseIf gradepoint8.Text = "CM" Then
            gpa8.Text = 2.25 * credithrs8.Text
        ElseIf gradepoint8.Text = "DP" Then
            gpa8.Text = 2 * credithrs8.Text
        ElseIf gradepoint8.Text = "D" Then
            gpa8.Text = 1.75 * credithrs8.Text
        ElseIf gradepoint8.Text = "DM" Then
            gpa8.Text = 1.5 * credithrs8.Text
        End If

        If gradepoint9.Text = "A" Then
            gpa9.Text = 4 * credithrs9.Text
        ElseIf gradepoint9.Text = "AM" Then
            gpa9.Text = 3.75 * credithrs9.Text
        ElseIf gradepoint9.Text = "BP" Then
            gpa9.Text = 3.5 * credithrs9.Text
        ElseIf gradepoint9.Text = "B" Then
            gpa9.Text = 3.25 * credithrs9.Text
        ElseIf gradepoint9.Text = "BM" Then
            gpa9.Text = 3 * credithrs9.Text
        ElseIf gradepoint9.Text = "CP" Then
            gpa9.Text = 2.75 * credithrs9.Text
        ElseIf gradepoint9.Text = "C" Then
            gpa9.Text = 2.5 * credithrs9.Text
        ElseIf gradepoint9.Text = "CM" Then
            gpa9.Text = 2.25 * credithrs9.Text
        ElseIf gradepoint9.Text = "DP" Then
            gpa9.Text = 2 * credithrs9.Text
        ElseIf gradepoint9.Text = "D" Then
            gpa9.Text = 1.75 * credithrs9.Text
        ElseIf gradepoint9.Text = "DM" Then
            gpa9.Text = 1.5 * credithrs9.Text
        End If

        If gradepoint10.Text = "A" Then
            gpa10.Text = 4 * credithrs10.Text
        ElseIf gradepoint10.Text = "AM" Then
            gpa10.Text = 3.75 * credithrs10.Text
        ElseIf gradepoint10.Text = "BP" Then
            gpa10.Text = 3.5 * credithrs10.Text
        ElseIf gradepoint10.Text = "B" Then
            gpa10.Text = 3.25 * credithrs10.Text
        ElseIf gradepoint10.Text = "BM" Then
            gpa10.Text = 3 * credithrs10.Text
        ElseIf gradepoint10.Text = "CP" Then
            gpa10.Text = 2.75 * credithrs10.Text
        ElseIf gradepoint10.Text = "C" Then
            gpa10.Text = 2.5 * credithrs10.Text
        ElseIf gradepoint10.Text = "CM" Then
            gpa10.Text = 2.25 * credithrs10.Text
        ElseIf gradepoint10.Text = "DP" Then
            gpa10.Text = 2 * credithrs10.Text
        ElseIf gradepoint10.Text = "D" Then
            gpa10.Text = 1.75 * credithrs10.Text
        ElseIf gradepoint10.Text = "DM" Then
            gpa10.Text = 1.5 * credithrs10.Text
        End If

        If gradepoint11.Text = "A" Then
            gpa11.Text = 4 * credithrs11.Text
        ElseIf gradepoint11.Text = "AM" Then
            gpa11.Text = 3.75 * credithrs11.Text
        ElseIf gradepoint11.Text = "BP" Then
            gpa11.Text = 3.5 * credithrs11.Text
        ElseIf gradepoint11.Text = "B" Then
            gpa11.Text = 3.25 * credithrs11.Text
        ElseIf gradepoint11.Text = "BM" Then
            gpa11.Text = 3 * credithrs11.Text
        ElseIf gradepoint11.Text = "CP" Then
            gpa11.Text = 2.75 * credithrs11.Text
        ElseIf gradepoint11.Text = "C" Then
            gpa11.Text = 2.5 * credithrs11.Text
        ElseIf gradepoint11.Text = "CM" Then
            gpa11.Text = 2.25 * credithrs11.Text
        ElseIf gradepoint11.Text = "DP" Then
            gpa11.Text = 2 * credithrs11.Text
        ElseIf gradepoint11.Text = "D" Then
            gpa11.Text = 1.75 * credithrs11.Text
        ElseIf gradepoint11.Text = "DM" Then
            gpa11.Text = 1.5 * credithrs11.Text
        End If

        


        cgpa.Text = (Val(hidden) + Val(hidden1)) / (Val(hdcredithrs) + Val(hdcredithrs1))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        btnnext.Text = (Val(gpa.Text) + Val(gpa1.Text) + Val(gpa2.Text) + Val(gpa3.Text) + Val(gpa4.Text) + Val(gpa5.Text) + Val(gpa6.Text) + Val(gpa7.Text) + Val(gpa8.Text) + Val(gpa9.Text) + Val(gpa10.Text) + Val(gpa11.Text))
        hidden = btnnext.Text
        gpa.Text = " "
        gpa1.Text = ""
        gpa2.Text = " "
        gpa3.Text = " "
        gpa4.Text = " "
        gpa5.Text = " "
        gpa6.Text = " "
        gpa7.Text = " "
        gpa8.Text = " "
        gpa9.Text = " "
        gpa10.Text = " "
        gpa11.Text = " "


        

        gradepoint0.Text = ""
        gradepoint1.Text = ""
        gradepoint2.Text = ""
        gradepoint3.Text = ""
        gradepoint4.Text = ""
        gradepoint5.Text = ""
        gradepoint6.Text = ""
        gradepoint7.Text = ""
        gradepoint8.Text = ""
        gradepoint9.Text = ""
        gradepoint10.Text = ""
        gradepoint11.Text = ""


    End Sub

    Private Sub btnnext1_Click(sender As Object, e As EventArgs) Handles btnnext1.Click
        btnnext.Text = (Val(gpa.Text) + Val(gpa1.Text) + Val(gpa2.Text) + Val(gpa3.Text) + Val(gpa4.Text) + Val(gpa5.Text) + Val(gpa6.Text) + Val(gpa7.Text) + Val(gpa8.Text) + Val(gpa9.Text) + Val(gpa10.Text) + Val(gpa11.Text))
        hidden = Val(btnnext1.Text)

        gpa.Text = " "
        gpa1.Text = ""
        gpa2.Text = " "
        gpa3.Text = " "
        gpa4.Text = " "
        gpa5.Text = " "
        gpa6.Text = " "
        gpa7.Text = " "
        gpa8.Text = " "
        gpa9.Text = " "
        gpa10.Text = " "
        gpa11.Text = " "


        

       

    End Sub

    Private Sub btnhide_Click(sender As Object, e As EventArgs) Handles btnhide.Click, btnhide.Click
        btnhide.Text = (Val(credithrs0.Text) + Val(credithrs1.Text) + Val(credithrs2.Text) + Val(credithrs3.Text) + Val(credithrs4.Text) + Val(credithrs5.Text) + Val(credithrs6.Text) + Val(credithrs7.Text) + Val(credithrs8.Text) + Val(credithrs9.Text) + Val(credithrs10.Text) + Val(credithrs11.Text))
        hdcredithrs = btnhide.Text
        credithrs0.Text = ""
        credithrs1.Text = ""
        credithrs2.Text = ""
        credithrs3.Text = ""
        credithrs4.Text = ""
        credithrs5.Text = ""
        credithrs6.Text = ""
        credithrs7.Text = ""
        credithrs8.Text = ""
        credithrs9.Text = ""
        credithrs10.Text = ""
        credithrs11.Text = ""

    End Sub

    Private Sub hide2_Click(sender As Object, e As EventArgs) Handles hide2.Click
        hide2.Text = (Val(credithrs0.Text) + Val(credithrs1.Text) + Val(credithrs2.Text) + Val(credithrs3.Text) + Val(credithrs4.Text) + Val(credithrs5.Text) + Val(credithrs6.Text) + Val(credithrs7.Text) + Val(credithrs8.Text) + Val(credithrs9.Text) + Val(credithrs10.Text) + Val(credithrs11.Text))
        hdcredithrs1 = hide2.Text
        credithrs0.Text = ""
        credithrs1.Text = ""
        credithrs2.Text = ""
        credithrs3.Text = ""
        credithrs4.Text = ""
        credithrs5.Text = ""
        credithrs6.Text = ""
        credithrs7.Text = ""
        credithrs8.Text = ""
        credithrs9.Text = ""
        credithrs10.Text = ""
        credithrs11.Text = ""

    End Sub

    Private Sub btngradepoint_Click(sender As Object, e As EventArgs) Handles btngradepoint.Click


        gradepoint0.Text = ""
        gradepoint1.Text = ""
        gradepoint2.Text = ""
        gradepoint3.Text = ""
        gradepoint4.Text = ""
        gradepoint5.Text = ""
        gradepoint6.Text = ""
        gradepoint7.Text = ""
        gradepoint8.Text = ""
        gradepoint9.Text = ""
        gradepoint10.Text = ""
        gradepoint11.Text = ""

    End Sub

End Class
