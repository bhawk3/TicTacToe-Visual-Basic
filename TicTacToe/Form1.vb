'Project: Tic Tac Toe Exam
'Programmer: Brendan Hawk
'Date:05/08/2020
'Description: Make a Tic Tac Toe Game

Public Class Form1
    Dim R1XAcross, R2XAcross, R3XAcross, R1OAcross, R2OAcross, R3OAcross As Object
    Dim C1XDown, C2XDown, C3XDown, C1ODown, C2ODown, C3ODown As Object
    Dim R1XDiagnol, R3XDiagnol, R1ODiagnol, R3ODiagnol As Object

    Private Sub R1C1XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C1XCheckBox.CheckedChanged
        'Display the X image when clicked R1C1

        If R1C1XCheckBox.Checked = False Then
            R1C1XImage.Visible = False
        ElseIf R1C1XCheckBox.Checked = True Then
            R1C1XImage.Visible = True
            R1C1OImage.Visible = False
        End If
    End Sub

    Private Sub R1C1OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C1OCheckBox.CheckedChanged
        'Display the O image when clicked R1C1
        If R1C1OCheckBox.Checked = False Then
            R1C1OImage.Visible = False
        ElseIf R1C1OCheckBox.Checked = True Then
            R1C1OImage.Visible = True
            R1C1XImage.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles R2C1XCheckBox.CheckedChanged
        'Display the x image when clicked R2C1


        If R2C1XCheckBox.Checked = False Then
            R2C1XImage.Visible = False
        ElseIf R2C1XCheckBox.Checked = True Then
            R2C1XImage.Visible = True
            R2C1OImage.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles R2C1OCheckBox.CheckedChanged
        'Display the o image when clicked R2C1

        If R2C1OCheckBox.Checked = False Then
            R2C1OImage.Visible = False
        ElseIf R2C1OCheckBox.Checked = True Then
            R2C1OImage.Visible = True
            R2C1XImage.Visible = False
        End If
    End Sub
    Private Sub R3C1XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C1XCheckBox.CheckedChanged
        'Display the x image when clicked R3C1

        If R3C1XCheckBox.Checked = False Then
            R3C1XImage.Visible = False
        ElseIf R3C1XCheckBox.Checked = True Then
            R3C1XImage.Visible = True
            R3C1OImage.Visible = False
        End If
    End Sub

    Private Sub R3C1OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C1OCheckBox.CheckedChanged
        'Display the O image when clicked R3C1

        If R3C1OCheckBox.Checked = False Then
            R3C1OImage.Visible = False
        ElseIf R3C1OCheckBox.Checked = True Then
            R3C1OImage.Visible = True
            R3C1XImage.Visible = False
        End If
    End Sub
    Private Sub R1C2XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C2XCheckBox.CheckedChanged
        'Display the x image when clicked R1C2

        If R1C2XCheckBox.Checked = False Then
            R1C2XImage.Visible = False
        ElseIf R1C2XCheckBox.Checked = True Then
            R1C2XImage.Visible = True
            R1C2OImage.Visible = False
        End If
    End Sub

    Private Sub R1C2OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C2OCheckBox.CheckedChanged
        'Display the O image when clicked R1C2

        If R1C2OCheckBox.Checked = False Then
            R1C2OImage.Visible = False
        ElseIf R1C2OCheckBox.Checked = True Then
            R1C2OImage.Visible = True
            R1C2XImage.Visible = False
        End If
    End Sub

    Private Sub R2C2XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R2C2XCheckBox.CheckedChanged
        'Display the x imaage when clicked R2C2

        If R2C2XCheckBox.Checked = False Then
            R2C2XImage.Visible = False
        ElseIf R2C2XCheckBox.Checked = True Then
            R2C2XImage.Visible = True
            R2C2OImage.Visible = False
        End If
    End Sub

    Private Sub R2C2OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R2C2OCheckBox.CheckedChanged
        'Display the o image when clicked R2C2

        If R2C2OCheckBox.Checked = False Then
            R2C2OImage.Visible = False
        ElseIf R2C2OCheckBox.Checked = True Then
            R2C2OImage.Visible = True
            R2C2XImage.Visible = False
        End If
    End Sub

    Private Sub R3C2XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C2XCheckBox.CheckedChanged
        'Display the x image when clicked R3C2

        If R3C2XCheckBox.Checked = False Then
            R3C2XImage.Visible = False
        ElseIf R3C2XCheckBox.Checked = True Then
            R3C2XImage.Visible = True
            R3C2OImage.Visible = False
        End If
    End Sub

    Private Sub R3C2OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C2OCheckBox.CheckedChanged
        'Display the o image when clicked R3C2

        If R3C2OCheckBox.Checked = False Then
            R3C2OImage.Visible = False
        ElseIf R3C2OCheckBox.Checked = True Then
            R3C2OImage.Visible = True
            R3C2XImage.Visible = False
        End If
    End Sub
    Private Sub R1C3XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C3XCheckBox.CheckedChanged
        'Display the x image when cliked R1C3

        If R1C3XCheckBox.Checked = False Then
            R1C3XImage.Visible = False
        ElseIf R1C3XCheckBox.Checked = True Then
            R1C3XImage.Visible = True
            R1C3OImage.Visible = False
        End If
    End Sub

    Private Sub R1C3OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R1C3OCheckBox.CheckedChanged
        'Display the o image when clicked R1C3

        If R1C3OCheckBox.Checked = False Then
            R1C3OImage.Visible = False
        ElseIf R1C3OCheckBox.Checked = True Then
            R1C3OImage.Visible = True
            R1C3XImage.Visible = False
        End If
    End Sub

    Private Sub R2C3XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R2C3XCheckBox.CheckedChanged
        'Display the x image when clicked R2C3

        If R2C3XCheckBox.Checked = False Then
            R2C3XImage.Visible = False
        ElseIf R2C3XCheckBox.Checked = True Then
            R2C3XImage.Visible = True
            R2C3OImage.Visible = False
        End If
    End Sub

    Private Sub R2C3OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R2C3OCheckBox.CheckedChanged
        'Display the o image when clicked R2C3

        If R2C3OCheckBox.Checked = False Then
            R2C3OImage.Visible = False
        ElseIf R2C3OCheckBox.Checked = True Then
            R2C3OImage.Visible = True
            R2C3XImage.Visible = False
        End If
    End Sub

    Private Sub R3C3XCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C3XCheckBox.CheckedChanged
        'Display the x image when clicked R3C3

        If R3C3XCheckBox.Checked = False Then
            R3C3XImage.Visible = False
        ElseIf R3C3XCheckBox.Checked = True Then
            R3C3XImage.Visible = True
            R3C3OImage.Visible = False
        End If
    End Sub



    Private Sub R3C3OCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles R3C3OCheckBox.CheckedChanged
        'Display the o image when clicked R3C3

        If R3C3OCheckBox.Checked = False Then
            R3C3OImage.Visible = False
        ElseIf R3C3OCheckBox.Checked = True Then
            R3C3OImage.Visible = True
            R3C3XImage.Visible = False
        End If
    End Sub
    Private Sub WhoWonButton_Click(sender As Object, e As EventArgs) Handles WhoWonButton.Click
        'Display player X as the winner
        Dim MessageString As String

        'set all the possible ways to win for X to something simpler
        R1XAcross = R1C1XCheckBox.Checked = True AndAlso R1C2XCheckBox.Checked = True AndAlso R1C3XCheckBox.Checked = True
        R2XAcross = R2C1XCheckBox.Checked = True AndAlso R2C2XCheckBox.Checked = True AndAlso R2C3XCheckBox.Checked = True
        R3XAcross = R3C1XCheckBox.Checked = True AndAlso R3C2XCheckBox.Checked = True AndAlso R3C3XCheckBox.Checked = True
        C1XDown = R1C1XCheckBox.Checked = True AndAlso R2C1XCheckBox.Checked = True AndAlso R3C1XCheckBox.Checked = True
        C2XDown = R1C2XCheckBox.Checked = True AndAlso R2C2XCheckBox.Checked = True AndAlso R3C2XCheckBox.Checked = True
        C3XDown = R1C3XCheckBox.Checked = True AndAlso R2C3XCheckBox.Checked = True AndAlso R3C3XCheckBox.Checked = True
        R1XDiagnol = R1C1XCheckBox.Checked = True AndAlso R2C2XCheckBox.Checked = True AndAlso R3C3XCheckBox.Checked = True
        R3XDiagnol = R1C3XCheckBox.Checked = True AndAlso R2C2XCheckBox.Checked = True AndAlso R3C1XCheckBox.Checked = True

        'Set all the possible ways to win for O to something simpler
        R1OAcross = R1C1OCheckBox.Checked = True AndAlso R1C2OCheckBox.Checked = True AndAlso R1C3OCheckBox.Checked = True
        R2OAcross = R2C1OCheckBox.Checked = True AndAlso R2C2OCheckBox.Checked = True AndAlso R2C3OCheckBox.Checked = True
        R3OAcross = R3C1OCheckBox.Checked = True AndAlso R3C2OCheckBox.Checked = True AndAlso R3C3OCheckBox.Checked = True
        C1ODown = R1C1OCheckBox.Checked = True AndAlso R2C1OCheckBox.Checked = True AndAlso R3C1OCheckBox.Checked = True
        C2ODown = R1C2OCheckBox.Checked = True AndAlso R2C2OCheckBox.Checked = True AndAlso R3C2OCheckBox.Checked = True
        C3ODown = R1C3OCheckBox.Checked = True AndAlso R2C3OCheckBox.Checked = True AndAlso R3C3OCheckBox.Checked = True
        R1ODiagnol = R1C1OCheckBox.Checked = True AndAlso R2C2OCheckBox.Checked = True AndAlso R3C3OCheckBox.Checked = True
        R3ODiagnol = R1C3OCheckBox.Checked = True AndAlso R2C2OCheckBox.Checked = True AndAlso R3C1OCheckBox.Checked = True


        'Display message that x is winner if one of the ways for x to win is true
        If R1XAcross = True Or R2XAcross = True Or R3XAcross = True Or C1XDown = True Or C2XDown = True Or C3XDown = True Or R1XDiagnol = True Or R3XDiagnol = True Then
            MessageString = "X is the winner!"
            MessageBox.Show(MessageString)
        End If

        'Display message that O is winner if one of the ways for O to win is true
        If R1OAcross = True Or R2OAcross = True Or R3OAcross = True Or C1ODown = True Or C2ODown = True Or C3ODown = True Or R1ODiagnol = True Or R3ODiagnol = True Then
            MessageBox.Show("O is the winner!")
        End If

        'Display the message that it is a cat game if neither X or O wins
        If R1XAcross = False And R2XAcross = False And R3XAcross = False And C1XDown = False And C2XDown = False And C3XDown = False And R1XDiagnol = False And R3XDiagnol = False And R1OAcross = False And R2OAcross = False And R3OAcross = False And C1ODown = False And C2ODown = False And C3ODown = False And R1ODiagnol = False And R3ODiagnol = False Then
            MessageBox.Show("Cat game!!")
        End If
    End Sub
End Class
