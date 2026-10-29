Imports System.Data.SQLite

Public Class frmAttendentFlights
    Private Sub cboattendent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboattendent.SelectedIndexChanged
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Dim strQuery As String =
            $"SELECT TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeOfdeparture, TF.dtmTimeOfLanding 
            FROM TAttendants as TA
            JOIN TAttendantFlights AS TAF
            ON TA.intAttendantID = TAF.intAttendantID
            JOIN TFlights as TF
            ON TAF.intflightID = TF.intflightID
            WHERE TA.strLastName = '{cboattendent.SelectedItem}' "

        lstattendentflights.Items.Clear()

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFlightNumber As String = reader.GetString(0)
                        Dim dtmFlightDate As String = reader.GetString(1)
                        Dim dtmTimeOfdeparture As String = reader.GetString(2)
                        Dim dtmTimeOfLanding As String = reader.GetString(3)
                        lstattendentflights.Items.Add($"{strFlightNumber}, {dtmFlightDate}, {dtmTimeOfdeparture}, {dtmTimeOfLanding}")
                    End While
                End Using
            End Using

        End Using
    End Sub

    Private Sub frmAttendentFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strQuery As String = "SELECT strLastName FROM TAttendants"

        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLastName As String = reader.GetString(0)
                        cboattendent.Items.Add($"{strLastName}")
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class