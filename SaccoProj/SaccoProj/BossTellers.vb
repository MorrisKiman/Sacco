Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class BossTellers
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable

    Private Sub BossTellers_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Boss.Show()
    End Sub

    Private Sub BossTellers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Teller"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            Tellerview.DataSource = bSource
            TellerDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub NuTell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuTell.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Insert into sacco.teller (TellerID, Teller_Fname, Teller_Sname, TellerPass, Contacts) values('" & Tellerid.Text & "','" & Fname.Text & "','" & Sname.Text & "','" & password.Text & "','" & contact.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The new record has been added.")
            Tellerid.ResetText()
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

    Private Sub Refreshtbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refreshtbl.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Teller"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            TellerDataGridView.Refresh()
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            Tellerview.DataSource = bSource
            TellerDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Connection To The Database has failed. ")

        End Try
    End Sub

    Private Sub EditTell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTell.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Update sacco.teller set TellerID='" & Tellerid.Text & "',Teller_Fname='" & Fname.Text & "',Teller_Sname='" & Sname.Text & "',TellerPass='" & password.Text & "',Contacts='" & contact.Text & "' where TellerID='" & Tellerid.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been updated.")
            Tellerid.ResetText()
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

    Private Sub DelTell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelTell.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Delete from sacco.Teller where TellerID='" & Tellerid.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been deleted.")
            Tellerid.ResetText()
            Fname.ResetText()
            Sname.ResetText()
            password.ResetText()
            contact.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to delete the record!! Check Server co.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Tafuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tafuta.TextChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("TellerID = '{0}'", Tafuta.Text)
        Tellerview.DataSource = DV
    End Sub


    Private Sub BackTBoss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackTBoss.Click
        Boss.Show()
        Me.ResetText()
        Me.Close()
    End Sub

End Class