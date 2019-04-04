Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class TellervLoan
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable

    Private Sub TellervLoan_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        TellerEntry.Show()
    End Sub

    Private Sub BossLoans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        meza()
        Ltype()
        Stats_Items()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles midsrc.TextChanged
        Dim DV As New DataView(dbDataset)
        Try
            If midsrc.Text = "" Then
                midsrc.Focus()
            Else
                DV.RowFilter = String.Format("MemberID = '{0}'", midsrc.Text)
                LoansDataGridView.DataSource = DV
            End If
        Catch
            MessageBox.Show("Non-Numerical Value has been entered!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BackTBoss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackTBoss.Click
        TellerEntry.Show()
        Me.Close()
    End Sub

    Private Sub Ltype()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; database=sacco; Convert Zero DateTime= true"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.loantype"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("typeName")
                Laina.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Laina_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Laina.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Loan_Type like '%{0}%'", Laina.Text)
        LoansDataGridView.DataSource = DV
    End Sub

    Private Sub stats_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles stats.SelectedIndexChanged
        Dim DV As New DataView(dbDataset)
        DV.RowFilter = String.Format("Status like '%{0}%'", stats.Text)
        LoansDataGridView.DataSource = DV
    End Sub

    Private Sub meza()
        MySqlConn = New MySqlConnection

        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.loans"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            LoansDataGridView.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub Refresh_Click(sender As System.Object, e As System.EventArgs) Handles Refresh.Click
        '   meza()
        midsrc.ResetText()
        Laina.ResetText()
        stats.ResetText()
        Dim DV As New DataView(dbDataset)
        'DV.RowFilter = String.Format("Status like '%paid%' || '%unpaid%' || ''")
        'DV.RowFilter = String.Format("Status like '%unpaid%'")
        'DV.RowFilter = String.Format("Status like ''")
        LoansDataGridView.DataSource = DV
    End Sub
    Private Sub Stats_Items()
        stats.Items.Add("complete")
        stats.Items.Add("unpaid")

    End Sub

End Class
'DV.RowFilter = String.Format("AttendantFname like '%{0}%'", midsrc.Text)