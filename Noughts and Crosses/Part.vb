' Title: Part.vb
' Author: Timothy Revans
' Description: A class used as the buttons on the windows form that contain the Os and Xs

Public Class Part

    ' inherits the pre-existing properties of a button
    Inherits Button

    ' a subroutine to describe the behaviour of the button being clicked
    Private Sub Clicked(sender As Object, e As EventArgs) Handles Me.Click

        ' disable this button
        Enabled = False

        ' set the text of the button to the current player
        Text = Game.Player
        Refresh()

        ' change the current player
        If Game.Player = "X" Then

            Game.Player = "O"

        Else

            Game.Player = "X"

        End If

        ' check if the game has been won
        Game.Check_Win()

    End Sub

End Class