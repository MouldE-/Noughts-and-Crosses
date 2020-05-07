' Title: Form2.vb
' Author: Timothy Revans
' Description: The form used to display the gameplay.

Public Class Game

    Property Player() As Char = "O"

    ' a variable to store the number of players in the game (possibly not needed)
    Private players As Integer

    ' an array to store the grid of buttons
    Public grid(,) As Part

    Private bot1 As Bot
    Private bot2 As Bot

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

            botTimer.Stop()

            If winner = "A" Then

                MessageBox.Show("It's a draw!")

            Else

                MessageBox.Show(winner & " is the winner!")

            End If

            Close()

        Else

            ' updates playerLabel if not finished
            playerLabel.Text = "Player: " & Player

            If players = 1 Then

                If Player = "X" Then

                    botTimer.Start()
                    Disable_Grid()

                Else

                    botTimer.Stop()
                    Enable_Grid()

                End If

            End If

        End If

    End Sub

    ' a sub to set up the game once the form is loaded
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' store all the buttons in a 2-dimensional array
        grid = {{Part1, Part2, Part3}, {Part4, Part5, Part6}, {Part7, Part8, Part9}}

        ' set the number of players based on the checked radiobutton
        Select Case True
            Case Launcher.players0.Checked
                players = 0
                Disable_Grid()
                bot1 = New Bot("X")
                bot2 = New Bot("O")
                botTimer.Start()
                Check_Win()
            Case Launcher.players1.Checked
                players = 1
                bot1 = New Bot("X")
            Case Launcher.players2.Checked
                players = 2
            Case Else
                MessageBox.Show("ERROR")
                Close()
        End Select

    End Sub

    ' a sub to re-show the launcher when the form is closed
    Private Sub Game_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Launcher.Show()

    End Sub

    ' a subroutine to time the bots actions
    Private Sub BotTimer_Tick(sender As Object, e As EventArgs) Handles botTimer.Tick

        ' make the apropriate bot play
        If Player = "X" Then

            bot1.Play()

        Else

            bot2.Play()

        End If

        ' disable the grid again if there are no players
        If players = 0 Then

            Disable_Grid()

        End If

    End Sub

    ' a subroutine to enable the buttons in the grid that have not been pressed
    Public Sub Enable_Grid()

        For Each item In grid

            If item.Text = "" Then

                item.Enabled = True

            End If

        Next

    End Sub

    ' a subroutine to disable all of the buttons in the grid
    Private Sub Disable_Grid()

        For Each item In grid

            item.Enabled = False

        Next

    End Sub

End Class
