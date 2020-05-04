' Title: Part.vb
' Author: Timothy Revans
' Description: A class used as the buttons on the windows form that contain the Os and Xs

Class Part

    ' inherits the pre-existing properties of a button
    Inherits Button

    ' a subroutine to describe the behaviour of the button being clicked
    Private Sub Clicked(sender As Object, e As EventArgs) Handles Me.Click

        ' check if the button has been pressed
        If Text = "" Then

            ' set the text of the button to the current player
            Text = Game.player

            ' change the current player
            If Game.player = "X" Then

                Game.player = "O"

            Else

                Game.player = "X"

            End If

        End If

        ' check if the game has been won
        Game.Check_Win()

    End Sub

End Class