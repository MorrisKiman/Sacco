Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AttViewMem
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataset As New DataTable

    Private Sub AttViewMem_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        AttendantEntry.Show()
    End Sub

    Private Sub AttViewMem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; Convert Zero DateTime=True"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.members"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            MembersDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub SearchMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchMem.Click
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("MemberID = '{0}'", Tafuta.Text)
        MembersDataGridView.DataSource = DV
    End Sub

    Private Sub BackTBoss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackTBoss.Click
        AttendantEntry.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Delete from sacco.members where MemberID='" & Tafuta.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been Deleted.")
            Tafuta.ResetText()

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to Delete the record!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class