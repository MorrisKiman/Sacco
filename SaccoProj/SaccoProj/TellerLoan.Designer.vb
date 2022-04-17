<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TellerLoan
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.reason = New System.Windows.Forms.TextBox()
        Me.LoanAm = New System.Windows.Forms.TextBox()
        Me.payable = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MemID = New System.Windows.Forms.ComboBox()
        Me.TelliD = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Loantype = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(350, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Record Loans"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(136, -3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 10
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Reason"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 28)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Loan Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(650, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 28)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "TellerID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(639, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 28)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "MemberID"
        '
        'reason
        '
        Me.reason.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reason.Location = New System.Drawing.Point(190, 175)
        Me.reason.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.reason.Multiline = True
        Me.reason.Name = "reason"
        Me.reason.Size = New System.Drawing.Size(323, 90)
        Me.reason.TabIndex = 23
        '
        'LoanAm
        '
        Me.LoanAm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanAm.Location = New System.Drawing.Point(190, 273)
        Me.LoanAm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LoanAm.Name = "LoanAm"
        Me.LoanAm.Size = New System.Drawing.Size(323, 35)
        Me.LoanAm.TabIndex = 24
        '
        'payable
        '
        Me.payable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payable.Location = New System.Drawing.Point(657, 323)
        Me.payable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.payable.Name = "payable"
        Me.payable.ReadOnly = True
        Me.payable.Size = New System.Drawing.Size(323, 35)
        Me.payable.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(475, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 35)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(778, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 35)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MemID
        '
        Me.MemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.MemID.FormattingEnabled = True
        Me.MemID.Location = New System.Drawing.Point(756, 115)
        Me.MemID.Name = "MemID"
        Me.MemID.Size = New System.Drawing.Size(181, 37)
        Me.MemID.TabIndex = 73
        '
        'TelliD
        '
        Me.TelliD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TelliD.FormattingEnabled = True
        Me.TelliD.Location = New System.Drawing.Point(756, 206)
        Me.TelliD.Name = "TelliD"
        Me.TelliD.Size = New System.Drawing.Size(121, 37)
        Me.TelliD.TabIndex = 74
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(190, 463)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 35)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Validate Details"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Loantype
        '
        Me.Loantype.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Loantype.FormattingEnabled = True
        Me.Loantype.Location = New System.Drawing.Point(190, 115)
        Me.Loantype.Name = "Loantype"
        Me.Loantype.Size = New System.Drawing.Size(323, 37)
        Me.Loantype.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Loan type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(652, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 28)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Loan Payable"
        '
        'TellerLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Loantype)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TelliD)
        Me.Controls.Add(Me.MemID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.payable)
        Me.Controls.Add(Me.LoanAm)
        Me.Controls.Add(Me.reason)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TellerLoan"
        Me.Text = "Sacco Management System- Teller- Record Loans"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents reason As System.Windows.Forms.TextBox
    Friend WithEvents LoanAm As System.Windows.Forms.TextBox
    Friend WithEvents payable As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MemID As System.Windows.Forms.ComboBox
    Friend WithEvents TelliD As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Loantype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
