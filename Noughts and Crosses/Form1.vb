Public Class Launcher

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startButton.Click

        Select Case True
            Case players0.Checked()
                MessageBox.Show("0 Players Selected!")
            Case players1.Checked()
                MessageBox.Show("1 Player Selected!")
            Case players2.Checked()
                Game.Show()
            Case Else
                MessageBox.Show("ERROR DETECTED!")
        End Select

    End Sub

End Class
