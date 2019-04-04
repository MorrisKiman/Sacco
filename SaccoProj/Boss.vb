Public Class Boss

    Private Sub Boss_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub

    Private Sub vAttendants_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vAttendants.Click
        BossAttentants.Show()
        Me.Close()
    End Sub

    Private Sub vTeller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vTeller.Click
        BossTellers.Show()
        Me.Close()

    End Sub

    Private Sub vMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vMember.Click
        BossMembers.Show()
        Me.Close()
    End Sub

    Private Sub vLoans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vLoans.Click
        BossLoans.Show()
        Me.Close()

    End Sub

    Private Sub Zimapage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zimapage.Click
        Login.Show()
        Me.Close()

    End Sub
End Class