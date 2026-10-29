Imports System.Data.SQLite

Public Class frmPilotFlights
    Private Sub frmPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strQuery As String = "SELECT strLastName FROM TPilots"

        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLastName As String = reader.GetString(0)
                        cbopilots.Items.Add($"{strLastName}")
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cbopilots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopilots.SelectedIndexChanged
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Dim strQuery As String =
            $"SELECT TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeOfdeparture, TF.dtmTimeOfLanding 
            FROM TPilots as TP
            JOIN TPilotFlights AS TPF
            ON TP.intpilotID = TPF.intpilotID
            JOIN TFlights as TF
            ON TPF.intflightID = TF.intflightID
            WHERE TP.strLastName = '{cbopilots.SelectedItem}' "

        lstpilotflights.Items.Clear()

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFlightNumber As String = reader.GetString(0)
                        Dim dtmFlightDate As String = reader.GetString(1)
                        Dim dtmTimeOfdeparture As String = reader.GetString(2)
                        Dim dtmTimeOfLanding As String = reader.GetString(3)
                        lstpilotflights.Items.Add($"{strFlightNumber}, {dtmFlightDate}, {dtmTimeOfdeparture}, {dtmTimeOfLanding}")
                    End While
                End Using
            End Using

        End Using
    End Sub
End Class