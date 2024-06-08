Public Class BridgePage
    Private Sub logoInput_Click(sender As Object, e As EventArgs) Handles logoInput.Click

        InputPage.Show()
        Me.Hide()

    End Sub

    Private Sub logoSetor_Click(sender As Object, e As EventArgs) Handles logoSetor.Click

        SetorPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        loginPage.Show()
        Me.Hide()

    End Sub
End Class