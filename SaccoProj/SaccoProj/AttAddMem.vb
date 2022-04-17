Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AttAddMem
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Dim dbDataset As New DataTable

    Private Sub AttAddMem_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        AttendantEntry.Show()
    End Sub

    Private Sub AttAddMem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select MemberID from sacco.members"
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


    Private Sub Ingiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingiza.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader
        ' & MemID.Text & alafu " & DOE.Text & "

        If Fname.Text = "" Or Fname.Text = "" Or Lname.Text = "" Or IDno.Text = "" Or cont.Text = "" Or DOB.Text = "" Or kazi.Text = "" Or resid.Text = "" Or Bname.Text = "" Or BSname.Text = "" Or BIDno.Text = "" Or Bcont.Text = "" Then
            MessageBox.Show("You have not populated a field", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Fname.Focus()

           


        Else
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "insert into sacco.members (MemberID, Fname, Lname, IDno, Contacts, DOB, DOE, Occupation, Residence, BeneficiaryName, BeneficiarySName, BeneficiaryID, BeneficiaryContacts) values ('""', '" & Fname.Text & "', '" & Lname.Text & "', '" & IDno.Text & "', '" & cont.Text & "', '" & DOB.Text & "', NOW() , '" & kazi.Text & "', '" & resid.Text & "', '" & Bname.Text & "', '" & BSname.Text & "', '" & BIDno.Text & "', '" & Bcont.Text & "')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("The new record has been added.")
                Fname.ResetText()
                Lname.ResetText()
                IDno.ResetText()
                cont.ResetText()
                kazi.ResetText()
                resid.ResetText()
                DOB.ResetText()
                Bname.ResetText()
                BSname.ResetText()
                BIDno.ResetText()
                Bcont.ResetText()



            Catch ex As MySqlException
                MessageBox.Show("Unable to save Record!! Check Server settings.")

            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AttendantEntry.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        EditMember.Show()
        Me.Hide()
    End Sub
End Class