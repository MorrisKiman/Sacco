Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class TellerLoan
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub TellerLoan_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        TellerEntry.Show()
    End Sub

    Private Sub TellerLoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris; Convert Zero DateTime=True"

        Try
            MySqlConn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Unable to connect to the database. Check Server settings.")
        Finally
            MySqlConn.Dispose()
        End Try

        loan_species()
        Memcid()
        telleridentitybox()
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=morris"
        Dim READER As MySqlDataReader

        If Loantype.Text = "" Or reason.Text = "" Or LoanAm.Text = "" Or MemID.Text = "" Or TelliD.Text = "" Or payable.Text = "" Then
            MessageBox.Show("Not All fields have been populated", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Loantype.Focus()
            Button1.Enabled = False
            Button3.Enabled = True
        Else
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Insert into sacco.loans (LoanID, Loan_Type, LoanReason, LoanAmount, Load_StartD, Load_EndD, MemberID, TellerID, payable, paid, status) values('','" & Loantype.Text & "','" & reason.Text & "','" & LoanAm.Text & "', Now() , now() , '" & MemID.Text & "', '" & TelliD.Text & "', '" & payable.Text & "', '', ' unpaid ')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("The new record has been added.")
                'LoanID.ResetText()
                Loantype.ResetText()
                reason.ResetText()
                LoanAm.ResetText()
                payable.ResetText()
                payable.ResetText()
                MemID.ResetText()
                TelliD.ResetText()
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show("Unable to save Record!! Check Server Connection.")

            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TellerEntry.Show()
        Me.Close()
    End Sub

    Private Sub SaveAmmount()
        Dim READER As MySqlDataReader
        Dim balance As Double

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select sum(Account_Value) from sacco.savings where MemberID = '" & MemID.Text & "' "
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                '.Text = READER.GetString("Contacts")
                'Dim sName = READER.GetUInt32("sum(Account_Value)")
                'MemID.Add(sName)
                balance = READER.GetUInt32("sum(Account_Value)")
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Memcid()
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
    Private Sub telleridentitybox()
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.teller"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("TellerID")
                TelliD.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub loan_species()
        Dim READER As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "Select * from sacco.loanType"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("typeName")
                Loantype.Items.Add(sName)
            End While
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim READER As MySqlDataReader
        Dim balance As Double
        Dim ln As Double = Double.Parse(LoanAm.Text, Globalization.NumberStyles.Float)
        Dim A, P, loan As Double
        If LoanAm.Text = "" Then
            MessageBox.Show("Please Enter the amount being borrowed", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Loantype.Text = "" Or reason.Text = "" Or LoanAm.Text = "" Or MemID.Text = "" Or TelliD.Text = "" Or payable.Text = "" Then
            MessageBox.Show("Not All fields have been populated", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Select sum(Account_Value) from sacco.savings where MemberID = '" & MemID.Text & "' "
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    '.Text = READER.GetString("Contacts")
                    'Dim sName = READER.GetUInt32("sum(Account_Value)")
                    'MemID.Add(sName)
                    Try
                        balance = READER.GetUInt32("sum(Account_Value)")
                    Catch
                        MessageBox.Show("This member's account is empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End While
                MySqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show("Unable to retrieve records!! Check Server Connection.")

            Finally
                MySqlConn.Dispose()
            End Try

            Const r = (9 / 100)
            Const t = (8 / 12)
            Const n = 1
            P = ln
            A = P * (1 + r / n) ^ (n * t)
            loan = balance * 3
        End If
        'start validation process
        If P > loan Then
            MessageBox.Show("The amount exceeds what is dispensable to the customer", "Loan Cannot be disbursed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Proceed to save the customer's loan application.", "Loan Application Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            payable.Text = A.ToString()
            Button1.Enabled = True
        End If

    End Sub


End Class