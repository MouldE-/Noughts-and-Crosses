Public Class Game

    Public player As Char = "O"

    Dim grid(,) As Part

    Sub Check_Win()

        Dim winner As Char = "A"
        Dim finished As Boolean = True

        For i As Integer = 0 To 2

            For j As Integer = 0 To 2

                If grid(i, j).Text = "" Then

                    finished = False

                End If

            Next

        Next

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

        If ((grid(0, 0).Text = grid(1, 1).Text AndAlso grid(0, 0).Text = grid(2, 2).Text) OrElse (grid(0, 2).Text = grid(1, 1).Text AndAlso grid(0, 2).Text = grid(2, 0).Text)) AndAlso grid(1, 1).Text <> "" Then

            winner = grid(1, 1).Text
            finished = True

        End If

        If finished Then

            If winner = "A" Then

                MessageBox.Show("It's a draw!")

            Else

                MessageBox.Show(winner & " is the winner!")

            End If

            Close()

        End If

        playerLabel.Text = "Player: " & player

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grid = {{Part1, Part2, Part3}, {Part4, Part5, Part6}, {Part7, Part8, Part9}}
        Launcher.Enabled = False

    End Sub

    Private Sub Form2_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Launcher.Enabled = True

    End Sub

End Class

Class Part

    Inherits Button

    Private Sub Clicked(sender As Object, e As EventArgs) Handles Me.Click

        If Text = "" Then

            If Game.player = "X" Then

                Text = "X"
                Game.player = "O"

            Else

                Text = "O"
                Game.player = "X"

            End If

        End If

        Game.Check_Win()

    End Sub
End Class