' Title: Form2.vb
' Author: Timothy Revans
' Description: The form used to display the gameplay.

Public Class Game

    ' a variable to store the current player, with "O" being player 1
    Public player As Char = "O"

    ' a variable to store the number of players in the game (possibly not needed)
    Private players As Integer

    ' an array to store the grid of buttons
    Private grid(,) As Part

    ' a sub to check if the game has been won, and update playerLabel's text if it has not
    Sub Check_Win()

        ' if winner remains "A" then nobody has wons
        Dim winner As Char = "A"

        ' if finished remains true then the game has ended
        Dim finished As Boolean = True

        ' sets finish to false if there are empty spaces
        For i As Integer = 0 To 2

            For j As Integer = 0 To 2

                If grid(i, j).Text = "" Then

                    finished = False

                End If

            Next

        Next

        ' checks every collumn and row to see if either player has a 3 in a row
        For i As Integer = 0 To 2

            If grid(i, 0).Text = grid(i, 1).Text AndAlso grid(i, 0).Text = grid(i, 2).Text AndAlso grid(i, 0).Text <> "" Then

                winner = grid(i, 0).Text
                finished = True

            End If

            If grid(0, i).Text = grid(1, i).Text AndAlso grid(0, i).Text = grid(2, i).Text AndAlso grid(0, i).Text <> "" Then

                winner = grid(0, i).Text
                finished = True

            End If

        Next

        ' checks diagonals for a 3 in a row
        If ((grid(0, 0).Text = grid(1, 1).Text AndAlso grid(0, 0).Text = grid(2, 2).Text) OrElse (grid(0, 2).Text = grid(1, 1).Text AndAlso grid(0, 2).Text = grid(2, 0).Text)) AndAlso grid(1, 1).Text <> "" Then

            winner = grid(1, 1).Text
            finished = True

        End If

        ' displays messages if game has finished, then closes the form
        If finished Then

            If winner = "A" Then

                MessageBox.Show("It's a draw!")

            Else

                MessageBox.Show(winner & " is the winner!")

            End If

            Close()
        Else

            ' updates playerLabel if not finished
            playerLabel.Text = "Player: " & player

        End If

    End Sub

    ' a sub to set up the game once the form is loaded
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' disable the launcher
        Launcher.Enabled = False

        ' store all the buttons in a 2-dimensional array
        grid = {{Part1, Part2, Part3}, {Part4, Part5, Part6}, {Part7, Part8, Part9}}

        ' set the number of players based on the checked radiobutton
        Select Case True
            Case Launcher.players0.Checked
                players = 0
            Case Launcher.players1.Checked
                players = 1
            Case Launcher.players2.Checked
                players = 2
            Case Else
                MessageBox.Show("ERROR")
                Close()
        End Select

    End Sub

    ' a sub to re-enable the launcher when the form is closed
    Private Sub Game_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Launcher.Enabled = True

    End Sub

End Class
