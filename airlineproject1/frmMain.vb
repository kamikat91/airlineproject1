Public Class frmMain
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnpassengers_Click(sender As Object, e As EventArgs) Handles btnpassengers.Click
        Dim frmpassengersdisplay As New frmPassengers
        frmpassengersdisplay.ShowDialog()
    End Sub

    Private Sub btnpilotflights_Click(sender As Object, e As EventArgs) Handles btnpilotflights.Click
        Dim frmpilotflightsdisplay As New frmPilotFlights
        frmpilotflightsdisplay.ShowDialog()
    End Sub

    Private Sub btnattendantflights_Click(sender As Object, e As EventArgs) Handles btnattendantflights.Click
        Dim frmattendantflightsdisplay As New frmAttendentFlights
        frmattendantflightsdisplay.ShowDialog()
    End Sub
End Class
