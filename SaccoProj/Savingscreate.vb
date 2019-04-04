Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Savingscreate
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim dbDataset2 As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource

    Private Sub Savingscreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'the form is initiated from this point.
        kombobox()
        jinaYaAccount()
        member()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; Convert Zero DateTime= true"
        Dim READER As MySqlDataReader
        If JinaAccount.Text = "" Or AccVal.Text = "" Or MemID.Text = "" Then
            MessageBox.Show("You have not entered Data into all the data fields", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            JinaAccount.Focus()
        Else
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Insert into sacco.savings (AccountID, AccountName, Account_Value, MemberID, Date_created, Date_Deposited) values('""','" & JinaAccount.Text & "','" & AccVal.Text & "','" & MemID.Text & "', Now(), Now())"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("The new record has been added.")
                JinaAccount.ResetText()
                AccVal.ResetText()
                MemID.ResetText()
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show("Unable to save Record!! Check Server settings.")

            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AttendantEntry.Show()
        Me.Close()

    End Sub

    Private Sub tafuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tafuta.TextChanged
        Dim DV As New DataView(dbDataset)
        If tafuta.Text = "" Then
            tafuta.Focus()
        Else
            DV.RowFilter = String.Format("MemberID = '{0}'", tafuta.Text)
            DataGridView1.DataSource = DV
        End If
    End Sub


    Private Sub DelAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelAcc.Click
        Dim READER As MySqlDataReader

        If Accntafuta.Text = "" Then
            MessageBox.Show("Enter the Account Number", "data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Accntafuta.Focus()
        Else

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Delete from sacco.Savings where AccountID='" & Accntafuta.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("The record has been Deleted.")
                Accntafuta.ResetText()
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show("Unable to Delete the record!! Check Server Connection.")

            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub LoadAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadAcc.Click
        Dim dbDataset2 As New DataTable
        Dim SDA2 As New MySqlDataAdapter
        Dim bSource2 As New BindingSource
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; convert zero datetime=true; userid=root; password=morris"

        Try
            MySqlConn.Open()
            Dim Query2 As String
            Query2 = "Select *from sacco.Savings"
            COMMAND = New MySqlCommand(Query2, MySqlConn)
            SDA2.SelectCommand = COMMAND
            SDA2.Fill(dbDataset2)
            bSource2.DataSource = dbDataset2
            DataGrid2.DataSource = bSource2
            SDA.Update(dbDataset2)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub member()
        DataGridView1.ResetText()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; convert zero datetime = true"

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select *from sacco.Members"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub
    Private Sub kombobox()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; database=sacco; Convert Zero DateTime= true"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.members"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("MemberID")
                MemID.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
    Private Sub jinaYaAccount()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; database=sacco; Convert Zero DateTime= true"
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim swali As String
            swali = "Select * from sacco.AccName"
            COMMAND = New MySqlCommand(swali, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("AccName")
                JinaAccount.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Accntafuta_TextChanged(sender As System.Object, e As System.EventArgs) Handles Accntafuta.TextChanged

    End Sub
End Class