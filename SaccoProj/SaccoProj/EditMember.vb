Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class EditMember
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable
    Dim dbDataset2 As New DataTable
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource

    Private Sub EditMember_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; database=sacco; Convert Zero DateTime = True"
        Memid()
    End Sub

    Private Sub Memid()
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.members"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("MemberID")
                Mamber.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Mamber_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Mamber.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.members where MemberID='" & Mamber.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Fname.Text = READER.GetString("Fname")
                Lname.Text = READER.GetString("Lname")

                cont.Text = READER.GetString("Contacts")
                kazi.Text = READER.GetString("Occupation")
                resid.Text = READER.GetString("Residence")

                Bname.Text = READER.GetString("BeneficiaryName")
                BSname.Text = READER.GetString("BeneficiarySname")
                BIDno.Text = READER.GetString("BeneficiaryID")
                Bcont.Text = READER.GetString("BeneficiaryContacts")
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Update sacco.members set Fname='" & Fname.Text & "', Lname='" & Lname.Text & "' , Contacts='" & cont.Text & "' , Occupation='" & kazi.Text & "' , Residence='" & resid.Text & "' , BeneficiaryName='" & Bname.Text & "' , BeneficiarySName='" & BSname.Text & "' , BeneficiaryID='" & BIDno.Text & "' , BeneficiaryContacts='" & Bcont.Text & "' where MemberID='" & Mamber.Text & "' "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("The record has been updated.")
            Lname.ResetText()
            Fname.ResetText()
            cont.ResetText()
            kazi.ResetText()
            resid.ResetText()
            Bname.ResetText()
            BSname.ResetText()
            BIDno.ResetText()
            Bcont.ResetText()
            Mamber.ResetText()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to save Record!! Check Server settings.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AttAddMem.Show()
        Me.Close()
    End Sub
End Class