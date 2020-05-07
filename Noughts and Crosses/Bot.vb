' Title: Bot.vb
' Author: Timothy Revans
' Description: A class used as the computer player(s) the user wants

Public Class Bot

    Private player As Char
    Private enemy As Char
    Private grid(,) As Part

    Public Sub New(ByVal pl As Char)

        player = pl
        grid = Game.grid

        If pl = "X" Then

            enemy = "O"

        Else

            enemy = "X"

        End If

    End Sub

    ' a sub for the bot to click the appropriate button
    Public Sub Play()

        ' allow randomisation
        Randomize()

        Dim randomnessFactor As Single = 0.5

        ' the part to be returned
        Dim chosenPart As Part

        ' a replica of the grid using only characters to increase the efficiency
        Dim charGrid(2, 2) As Char

        ' an array comtaining the previous best result to determine if a solution is better than previous solutions
        Dim prevBest(2) As Integer

        ' set the values for the best case to the worst possible values to ensure a selection is made
        prevBest(0) = Integer.MinValue
        prevBest(2) = Integer.MaxValue

        ' loop though the entire charGrid array, setting it equal to the corresponding text in the grid
        For i As Integer = 0 To 2

            For j As Integer = 0 To 2

                charGrid(i, j) = grid(i, j).Text

            Next

        Next

        ' loop through the charGrid array to test every possible move to be made
        For i As Integer = 0 To 2

            For j As Integer = 0 To 2

                If charGrid(i, j) = vbNullChar Then

                    ' "make" the move
                    charGrid(i, j) = player

                    ' find out the reprocussions of the move
                    Dim results() As Integer = Find_Best_Move(charGrid, enemy)

                    ' undo the move so it does not affect future itterations
                    charGrid(i, j) = vbNullChar

                    ' decide if the result is better, with a small element of randomness to make the game feel less repetetive
                    If results(2) < prevBest(2) OrElse (results(2) = prevBest(2) AndAlso results(0) > prevBest(0)) Then

                        prevBest = results
                        chosenPart = grid(i, j)

                    End If

                    ' decide if the results are the same, and if so make it a random chance to switch to the new result
                    If results(0) = prevBest(0) AndAlso results(2) = prevBest(2) AndAlso Rnd() > randomnessFactor Then

                        chosenPart = grid(i, j)
                        randomnessFactor ^= 2

                    End If

                End If

            Next

        Next

        ' makes sure the grid is enabled before performing the action
        Game.Enable_Grid()

        ' make the bot click the correct button
        chosenPart.PerformClick()

    End Sub

    ' sums up the outcomes of all the possible moves up to a certain depth
    Private Function Find_Best_Move(ByVal charGrid(,) As Char, ByVal playerTurn As Char, ByVal Optional depth As Integer = 1) As Integer()

        ' array to store the total number of wins, draws, and losses
        Dim total(2) As Integer

        ' add loop to test each possible combination
        For i As Integer = 0 To 2

            For j As Integer = 0 To 2

                ' if statement to make sure that the choice is valid
                If charGrid(i, j) = vbNullChar AndAlso depth <= 2 Then

                    ' "makes" the move
                    charGrid(i, j) = playerTurn

                    ' figures out if the game is won, lost, draw or in progress
                    Dim winner As Char = Check_Win(charGrid)

                    ' select an operation based on the winner
                    Select Case winner
                        Case player
                            total(0) += (1)
                        Case "A"
                            Dim nextPlayerTurn As Char
                            If playerTurn = player Then
                                nextPlayerTurn = enemy
                            Else
                                nextPlayerTurn = player
                            End If
                            Dim holder As Integer() = Find_Best_Move(charGrid, nextPlayerTurn, depth + 1)
                            total(0) += holder(0)
                            total(1) += holder(1)
                            total(2) += holder(2)
                        Case enemy
                            total(2) = total(2) + (1)
                        Case "D"
                            total(1) += (1)
                    End Select

                    ' reset the grid for future itterations
                    charGrid(i, j) = vbNullChar

                End If

            Next

        Next

        Return total

    End Function

    ' a function to return the winner of the game, or return "D" if its a draw or "A"  if the game Is In progress
    Private Function Check_Win(charGrid(,) As Char) As Char

        ' make the default ending a draw
        Dim won As Char = "D"

        ' if there are still valid mvoes make the game incomplete
        For Each character In charGrid

            If character = vbNullChar Then

                won = "A"

            End If

        Next

        ' search each row and column for a set of 3

        For i As Integer = 0 To 2

            If charGrid(i, 0) = charGrid(i, 1) AndAlso charGrid(i, 0) = charGrid(i, 2) AndAlso charGrid(i, 0) <> vbNullChar Then

                won = charGrid(i, 0)

            End If

            If charGrid(0, i) = charGrid(1, i) AndAlso charGrid(0, i) = charGrid(2, i) AndAlso charGrid(0, i) <> vbNullChar Then

                won = charGrid(0, i)

            End If

        Next

        ' checks both diagonals for a 3 in a row
        If ((charGrid(0, 0) = charGrid(1, 1) AndAlso charGrid(0, 0) = charGrid(2, 2)) OrElse (charGrid(0, 2) = charGrid(1, 1) AndAlso charGrid(0, 2) = charGrid(2, 0))) AndAlso charGrid(1, 1) <> vbNullChar Then

            won = charGrid(1, 1)

        End If

        ' return the winner
        Return won

    End Function

End Class
