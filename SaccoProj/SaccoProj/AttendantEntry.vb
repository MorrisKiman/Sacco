Public Class AttendantEntry

    Private Sub AddMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMem.Click
        AttAddMem.Show()
        Me.Close()
    End Sub

    Private Sub ViewMem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMem.Click
        AttViewMem.Show()
        Me.Close()
    End Sub

    Private Sub zima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zima.Click
        MessageBox.Show("You are about to be logged out.")
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Savingscreate.Show()
        Me.Close()
    End Sub

    Private Sub AttendantEntry_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub
End Class