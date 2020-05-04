' Title: Form1.vb
' Author: Timothy Revans
' Description: A form used as a launcher to select the number of players for the game

Public Class Launcher

    ' a subroutine to load up the second form
    Private Sub StartButton_Clicked(sender As Object, e As EventArgs) Handles startButton.Click

        Game.Show()

    End Sub

End Class
