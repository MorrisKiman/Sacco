Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Savings
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim MySqlConn As MySqlConnection

    Private Sub AttViewMem_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        TellerEntry.Show()
    End Sub

    Private Sub Savings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MySqlConn As MySqlConnection

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.savings"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            SavingsView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
        AccNames()
    End Sub

    Private Sub tafuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tafuta.TextChanged
        If tafuta.Text = "" Then
            tafuta.Focus()
        Else
            Dim DV As New DataView(dbDataset)
            DV.RowFilter = String.Format("MemberID  = '{0}'", tafuta.Text)
            SavingsView.DataSource = DV
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zima.Click
        TellerEntry.Show()
        Me.Close()
    End Sub

    Private Sub Laina_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AccNom.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("AccountName like '%{0}%'", AccNom.Text)
        SavingsView.DataSource = DV
    End Sub

    Private Sub AccNames()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; database=sacco; Convert Zero DateTime= true"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.accname"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("AccName")
                AccNom.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub


    Private Sub NambayaAcc_TextChanged(sender As System.Object, e As System.EventArgs) Handles NambayaAcc.TextChanged
        If NambayaAcc.Text = "" Then
            NambayaAcc.Focus()
        Else
            Dim DV As New DataView(dbDataset)
            DV.RowFilter = String.Format("AccountID = '{0}'", NambayaAcc.Text)
            SavingsView.DataSource = DV
        End If
    End Sub

    Private Sub reload_Click(sender As System.Object, e As System.EventArgs) Handles reload.Click
        Dim SDA2 As New MySqlDataAdapter
        Dim bSource2 As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query2 As String
            Query2 = "Select *from sacco.savings"
            COMMAND = New MySqlCommand(Query2, MySqlConn)
            SDA2.SelectCommand = COMMAND
            SDA2.Fill(dbDataset)
            bSource2.DataSource = dbDataset
            SavingsView.DataSource = bSource2
            SDA2.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class