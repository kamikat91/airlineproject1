Imports System.Data.SQLite
Public Class frmPassengers
    Private Sub frmPassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strQuery As String = "SELECT strFirstName, strLastName FROM TPassengers"

        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFirstName As String = reader.GetString(0)
                        Dim strLastName As String = reader.GetString(1)
                        lstpassengers.Items.Add($"{strFirstName} {strLastName}")
                    End While
                End Using
            End Using
        End Using


    End Sub
End Class