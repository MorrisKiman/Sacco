Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class BossMembers
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataset As New DataTable

    Private Sub BossMembers_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Boss.Show()
    End Sub

    Private Sub BossMembers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        tableu()
    End Sub

    Private Sub SearchMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchMem.Click
        Tafuta.ResetText()
        tableu()
    End Sub

    Private Sub BackTBoss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackTBoss.Click
        Boss.Show()
        Me.Close()
    End Sub

    Private Sub Tafuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tafuta.TextChanged
        If Tafuta.Text = "" Then
            Tafuta.Focus()
        Else
            Dim DV As New DataView(dbDataset)
            DV.RowFilter = String.Format("MemberID = '{0}'", Tafuta.Text)
            MembersDataGridView.DataSource = DV
        End If
    End Sub

    Private Sub tableu()
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
End Class