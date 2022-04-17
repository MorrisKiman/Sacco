Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class BossAttentants
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable

    Private Sub BossAttendants_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Boss.Show()
    End Sub

    Private Sub BossAttentants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Attendant"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            Attendantview.DataSource = bSource
            AttendantDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Refreshtbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refreshtbl.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Attendant"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            Attendantview.DataSource = bSource
            AttendantDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub NuAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuAtt.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Insert into sacco.attendant (AttendantID, AttendantFname, AttendantLname, Contacts, AttendantPass) values('" & Attid.Text & "','" & Fname.Text & "','" & Sname.Text & "','" & contact.Text & "','" & password.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The new record has been added.")
            Attid.ResetText()
            Fname.ResetText()
            Sname.ResetText()
            password.ResetText()
            contact.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to save Record!! Check Server settings.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub EditAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditAtt.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Update sacco.Attendant set AttendantID='" & Attid.Text & "', AttendantFname='" & Fname.Text & "', AttendantLname='" & Sname.Text & "', Contacts='" & contact.Text & "', AttendantPass='" & password.Text & "' where AttendantID='" & Attid.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been updated.")
            Attid.ResetText()
            Fname.ResetText()
            Sname.ResetText()
            password.ResetText()
            contact.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to save Record!! Check Server settings.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Tafuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tafuta.TextChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("AttendantFname = '{0}'", Tafuta.Text)
        Attendantview.DataSource = DV
    End Sub

    Private Sub BackTBoss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackTBoss.Click
        Boss.Show()
        Me.Close()
    End Sub

    Private Sub DelAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelAtt.Click
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Delete from sacco.Attendant where AttendantID='" & Attid.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been Deleted.")
            Attid.ResetText()
            Fname.ResetText()
            Sname.ResetText()
            password.ResetText()
            contact.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to Delete the record!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

End Class