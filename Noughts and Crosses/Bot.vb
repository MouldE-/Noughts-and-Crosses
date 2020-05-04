' Title: Bot.vb
' Author: Timothy Revans
' Description: A class used as the computer player(s) the user wants

Public Class Bot

    ' a sub for the bot to click the appropriate button
    Public Sub Play()

        ' enable the random number generation
        Randomize()

        ' declare variables to store random numbers
        Dim rand1, rand2 As Integer

        ' assign random values to variables until it matches a free space
        Do

            rand1 = Math.Floor(3 * Rnd())
            rand2 = Math.Floor(3 * Rnd())

        Loop While Game.grid(rand1, rand2).Text <> ""

        ' make the bot click the correct button
        Game.grid(rand1, rand2).PerformClick()

    End Sub

End Class
