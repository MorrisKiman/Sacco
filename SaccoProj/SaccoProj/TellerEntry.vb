Public Class TellerEntry

    Private Sub RecLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecLoan.Click
        TellerLoan.Show()
        Me.Close()
    End Sub

    Private Sub TellerEntry_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub

    Private Sub ViewLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewLoan.Click
        TellervLoan.Show()
        Me.Close()
    End Sub

    Private Sub viewsaves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewsaves.Click
        Savings.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        SavingInsert.Show()
        Me.Close()
    End Sub
End Class