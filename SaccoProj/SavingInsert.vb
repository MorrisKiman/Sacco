Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class SavingInsert
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource

    Private Sub SavingInsert_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        TellerEntry.Show()
    End Sub

    Private Sub SavingInsert_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"
        AccNumberLoad()
        saveRec.Enabled = False
    End Sub

    Private Sub LoadAcc_Click(sender As System.Object, e As System.EventArgs) Handles LoadAcc.Click
        Dim dbDataset As New DataTable
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris; database=sacco"

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Savings"
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

    Private Sub AccNumberLoad()
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.savings"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim AN = READER.GetString("AccountID")
                AcID.Items.Add(AN)
            End While
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub AcID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AcID.SelectedIndexChanged
        Dim READER As MySqlDataReader
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris"
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.savings where AccountID='" & AcID.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                AccNom.Text = READER.GetString("AccountName")
                curbal.Text = READER.GetString("Account_Value")
                membaID.Text = READER.GetString("MemberID")
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles vldate.Click
        Try
            Dim depositing As Double = Double.Parse(AccVal.Text, Globalization.NumberStyles.Float)
            Dim currentbln As Integer = Integer.Parse(curbal.Text, Globalization.NumberStyles.Number)
            Dim newB = depositing + currentbln
            If depositing < 2000 Then
                MessageBox.Show("This ammount is below the reasonable minimum of ksh2000.", "Database connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                nbalance.Text = newB.ToString()
                saveRec.Enabled = True
            End If
            
        Catch ex As Exception
            MessageBox.Show("Non Numerical Character entered in the marks. Please check your input and try again.", "Logic Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        saveRec.Enabled = True
        vldate.Enabled = False
    End Sub

    Private Sub saveRec_Click(sender As System.Object, e As System.EventArgs) Handles saveRec.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        If nbalance.Text = "" Or AcID.Text = "" Or membaID.Text = "" Or AccNom.Text = "" Or AccVal.Text = "" Or curbal.Text = "" Then
            MessageBox.Show("Some Fields are not populated! Incomplete data data cannot be saved!", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Update sacco.savings set Account_Value='" & nbalance.Text & "', Date_Deposited=Now() where AccountID='" & AcID.Text & "' "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been updated.")
            nbalance.ResetText()
            AcID.ResetText()
            membaID.ResetText()
            AccNom.ResetText()
            AccVal.ResetText()
            curbal.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to save Record!! Check Server settings.")

        Finally
            MySqlConn.Dispose()
            End Try
        End If
        saveRec.Enabled = False
        vldate.Enabled = True
    End Sub

    Private Sub AccIDsrch_TextChanged(sender As System.Object, e As System.EventArgs) Handles AccIDsrch.TextChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TellerEntry.Show()
        Me.Close()
    End Sub
End Class