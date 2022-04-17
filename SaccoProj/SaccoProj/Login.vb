Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"

        Try
            MySqlConn.Open()
            MessageBox.Show("The Database is online and ready for use", "LOCA SACCO")
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.", "LOCA SACCO - Connection Error")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Ingia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingia.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        If Teller.Checked Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from sacco.Teller where TellerID='" & username.Text & "' and TellerPass='" & pass.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MessageBox.Show("Login Successful")
                    TellerEntry.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicate")
                Else
                    MessageBox.Show("Login Failed")
                    pass.ResetText()
                    username.ResetText()
                    Teller.Checked = False
                    MessageBox.Show("Invalid User", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As MySqlException
                MessageBox.Show("Unable to connect to the database. Check Server settings.")
            Finally
                MySqlConn.Dispose()
            End Try

        ElseIf Attendant.Checked Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from sacco.Attendant where AttendantID='" & username.Text & "' and AttendantPass='" & pass.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MessageBox.Show("Login Successful")
                    AttendantEntry.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicate")
                Else
                    MessageBox.Show("Login Failed")
                    pass.ResetText()
                    username.ResetText()
                    Attendant.Checked = False
                    MessageBox.Show("Invalid User", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Catch ex As MySqlException
                MessageBox.Show("Unable to connect to the database. Check Server settings.")
            Finally
                MySqlConn.Dispose()
            End Try

        ElseIf Manager.Checked Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from sacco.Boss where UserName='" & username.Text & "' and Password='" & pass.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MessageBox.Show("Login Successful")
                    Boss.Show()
                    Me.Hide()
                ElseIf count > 1 Then
                    MessageBox.Show("Duplicate")
                Else
                    MessageBox.Show("Login Failed")
                    pass.ResetText()
                    username.ResetText()
                    Manager.Checked = False
                    MessageBox.Show("Invalid User", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()

                End If

            Catch ex As MySqlException
                MessageBox.Show("Unable to connect to the database. Check Server settings.")
            Finally
                MySqlConn.Dispose()
            End Try
        End If
        pass.ResetText()
        username.ResetText()
    End Sub

 
    Private Sub Zima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zima.Click
        Me.Close()
    End Sub
End Class
