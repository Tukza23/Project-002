Public Class Admin

    Private Sub productsBtn_Click(sender As Object, e As EventArgs) Handles productsBtn.Click
        Products.ShowDialog()
        Products.Dispose()
    End Sub


    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        logoutBtn.Text = MessageBox.Show("Are you sure you want to log-out?", "Exiting Administration Form!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If logoutBtn.Text = DialogResult.Yes Then
            logoutBtn.Text = "Logout" & Environment.NewLine & Environment.NewLine & "Closes the Administration Form"
            Me.Close()
            Login.Show()
        Else
            logoutBtn.Text = "Logout" & Environment.NewLine & Environment.NewLine & "Closes the Administration Form"
        End If
    End Sub

    Private Sub customersBtn_Click(sender As Object, e As EventArgs) Handles customersBtn.Click
        Customers.ShowDialog()
        Customers.Dispose()
    End Sub

    Private Sub stocksBtn_Click(sender As Object, e As EventArgs) Handles stocksBtn.Click
        Stocks.ShowDialog()
        Stocks.Dispose()
    End Sub

    Private Sub transactionsBtn_Click(sender As Object, e As EventArgs) Handles transactionsBtn.Click
        Selection.ShowDialog()
        Selection.Dispose()
    End Sub

    Private Sub reportsBtn_Click(sender As Object, e As EventArgs) Handles reportsBtn.Click
        ReportSelection.ShowDialog()
        ReportSelection.Dispose()
    End Sub
End Class