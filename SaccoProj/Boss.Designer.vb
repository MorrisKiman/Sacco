<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boss
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        Me.vAttendants = New System.Windows.Forms.Button()
        Me.vTeller = New System.Windows.Forms.Button()
        Me.vMember = New System.Windows.Forms.Button()
        Me.vLoans = New System.Windows.Forms.Button()
        Me.Zimapage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(413, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Branch Manager"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logo.Location = New System.Drawing.Point(111, 2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 2
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'vAttendants
        '
        Me.vAttendants.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vAttendants.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.vAttendants.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vAttendants.Location = New System.Drawing.Point(139, 181)
        Me.vAttendants.Name = "vAttendants"
        Me.vAttendants.Size = New System.Drawing.Size(252, 67)
        Me.vAttendants.TabIndex = 4
        Me.vAttendants.Text = "View Attendants"
        Me.vAttendants.UseVisualStyleBackColor = False
        '
        'vTeller
        '
        Me.vTeller.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vTeller.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.vTeller.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vTeller.Location = New System.Drawing.Point(684, 181)
        Me.vTeller.Name = "vTeller"
        Me.vTeller.Size = New System.Drawing.Size(263, 67)
        Me.vTeller.TabIndex = 5
        Me.vTeller.Text = "View Tellers"
        Me.vTeller.UseVisualStyleBackColor = False
        '
        'vMember
        '
        Me.vMember.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vMember.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.vMember.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMember.Location = New System.Drawing.Point(139, 375)
        Me.vMember.Name = "vMember"
        Me.vMember.Size = New System.Drawing.Size(252, 67)
        Me.vMember.TabIndex = 6
        Me.vMember.Text = "View Members"
        Me.vMember.UseVisualStyleBackColor = False
        '
        'vLoans
        '
        Me.vLoans.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vLoans.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.vLoans.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLoans.Location = New System.Drawing.Point(684, 375)
        Me.vLoans.Name = "vLoans"
        Me.vLoans.Size = New System.Drawing.Size(263, 67)
        Me.vLoans.TabIndex = 7
        Me.vLoans.Text = "View Loans"
        Me.vLoans.UseVisualStyleBackColor = False
        '
        'Zimapage
        '
        Me.Zimapage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Zimapage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Zimapage.Font = New System.Drawing.Font("Script MT Bold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Zimapage.Location = New System.Drawing.Point(404, 277)
        Me.Zimapage.Name = "Zimapage"
        Me.Zimapage.Size = New System.Drawing.Size(263, 67)
        Me.Zimapage.TabIndex = 8
        Me.Zimapage.Text = "Exit"
        Me.Zimapage.UseVisualStyleBackColor = False
        '
        'Boss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Zimapage)
        Me.Controls.Add(Me.vLoans)
        Me.Controls.Add(Me.vMember)
        Me.Controls.Add(Me.vTeller)
        Me.Controls.Add(Me.vAttendants)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Name = "Boss"
        Me.Text = "LOCA Sacco Management System- Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents vAttendants As System.Windows.Forms.Button
    Friend WithEvents vTeller As System.Windows.Forms.Button
    Friend WithEvents vMember As System.Windows.Forms.Button
    Friend WithEvents vLoans As System.Windows.Forms.Button
    Friend WithEvents Zimapage As System.Windows.Forms.Button
End Class
