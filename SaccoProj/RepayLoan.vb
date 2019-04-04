Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"
        meza()
        loanIdload()
        saveRec.Enabled = False
    End Sub

    Private Sub Form1_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        TellerEntry.Show()
    End Sub


    Private Sub LoadLoans_Click(sender As System.Object, e As System.EventArgs) Handles LoadLoans.Click
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Loans"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGrid2.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub loanidsearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles loanidsearch.TextChanged
        Dim DV As New DataView(dbDataset)
        Try
            If loanidsearch.Text = "" Then
                loanidsearch.Focus()
            Else
                DV.RowFilter = String.Format("LoanID = '{0}'", loanidsearch.Text)
                DataGrid2.DataSource = DV
            End If
        Catch
            MessageBox.Show("Non-Numerical Value has been entered!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub vldate_Click(sender As System.Object, e As System.EventArgs) Handles vldate.Click
        Try
            Dim deposit As Double = Double.Parse(depo.Text, Globalization.NumberStyles.Float)
            Dim curbalamce As Double = Double.Parse(currentpaid.Text, Globalization.NumberStyles.Float)
            Dim LoanAm As Double = Double.Parse(ltaken.Text, Globalization.NumberStyles.Float)
            Dim nubalance = curbalamce + deposit
            Dim paidornot = LoanAm - nubalance
            nbalance.Text = paidornot.ToString()
            saveRec.Enabled = True
        Catch
            MessageBox.Show("Non Numerical Data has been entered or no data at all has been entered! Please review and try again", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

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
            DataGrid2.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub LoanIDentity_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LoanIDentity.SelectedIndexChanged
        Dim READER As MySqlDataReader
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris"
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.loans where LoanID='" & LoanIDentity.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                loanAina.Text = READER.GetString("Loan_Type")
                currentpaid.Text = READER.GetUInt32("paid")
                membaID.Text = READER.GetString("MemberID")
                ltaken.Text = READER.GetUInt32("payable")

            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Public Sub loanIdload()
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.loans where status like '%unpaid%'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("LoanID")
                LoanIDentity.Items.Add(AN)
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub saveRec_Click(sender As System.Object, e As System.EventArgs) Handles saveRec.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"
        Dim READER As MySqlDataReader
        Dim nBal As Decimal = Decimal.Parse(nbalance.Text, Globalization.NumberStyles.Float)
        If nbalance.Text = "" Or LoanIDentity.Text = "" Or membaID.Text = "" Or loanAina.Text = "" Or ltaken.Text = "" Or depo.Text = "" Or currentpaid.Text = "" Then
            MessageBox.Show("Some Fields are not populated! Incomplete data data cannot be saved!", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            saveRec.Enabled = False
        Else
            Try
                MySqlConn.Open()
                Dim Query As String
                If nBal = 0 Then
                    Query = "Update sacco.loans set paid='" & nbalance.Text & "', status = 'Complete' where LoanID='" & LoanIDentity.Text & "' "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("The record has been updated.")
                    LoanIDentity.ResetText()
                    membaID.ResetText()
                    loanAina.ResetText()
                    ltaken.ResetText()
                    depo.ResetText()
                    currentpaid.ResetText()
                    nbalance.ResetText()
                Else
                    Query = "Update sacco.loans set paid='" & depo.Text & "' where LoanID='" & LoanIDentity.Text & "' "
                    COMMAND = New MySqlCommand(Query, MySqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("The record has been updated.")
                    LoanIDentity.ResetText()
                    membaID.ResetText()
                    loanAina.ResetText()
                    ltaken.ResetText()
                    depo.ResetText()
                    currentpaid.ResetText()
                    nbalance.ResetText()
                End If
            Catch ex As MySqlException
                MessageBox.Show("Unable to save Record!! Check Server settings.")

            Finally
                MySqlConn.Dispose()
            End Try
        End If
        saveRec.Enabled = False
        vldate.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
        TellerEntry.Show()
    End Sub
End Class