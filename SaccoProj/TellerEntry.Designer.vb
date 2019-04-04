<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TellerEntry
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
        Me.RecLoan = New System.Windows.Forms.Button()
        Me.ViewLoan = New System.Windows.Forms.Button()
        Me.viewsaves = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(497, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 42)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Teller"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(117, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 12
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'RecLoan
        '
        Me.RecLoan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecLoan.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecLoan.Location = New System.Drawing.Point(127, 151)
        Me.RecLoan.Name = "RecLoan"
        Me.RecLoan.Size = New System.Drawing.Size(214, 60)
        Me.RecLoan.TabIndex = 14
        Me.RecLoan.Text = "Record Loan"
        Me.RecLoan.UseVisualStyleBackColor = True
        '
        'ViewLoan
        '
        Me.ViewLoan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ViewLoan.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewLoan.Location = New System.Drawing.Point(628, 293)
        Me.ViewLoan.Name = "ViewLoan"
        Me.ViewLoan.Size = New System.Drawing.Size(214, 60)
        Me.ViewLoan.TabIndex = 15
        Me.ViewLoan.Text = "View Loans"
        Me.ViewLoan.UseVisualStyleBackColor = True
        '
        'viewsaves
        '
        Me.viewsaves.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.viewsaves.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewsaves.Location = New System.Drawing.Point(246, 303)
        Me.viewsaves.Name = "viewsaves"
        Me.viewsaves.Size = New System.Drawing.Size(248, 60)
        Me.viewsaves.TabIndex = 16
        Me.viewsaves.Text = "View Savings Accounts"
        Me.viewsaves.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(463, 461)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 60)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(832, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 60)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Loan Repayment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Font = New System.Drawing.Font("Script MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(463, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(214, 60)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Deposit to Account"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TellerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.viewsaves)
        Me.Controls.Add(Me.ViewLoan)
        Me.Controls.Add(Me.RecLoan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Name = "TellerEntry"
        Me.Text = "Sacco Management System- Teller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents RecLoan As System.Windows.Forms.Button
    Friend WithEvents ViewLoan As System.Windows.Forms.Button
    Friend WithEvents viewsaves As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
