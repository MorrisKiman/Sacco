<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.vldate = New System.Windows.Forms.Button()
        Me.membaID = New System.Windows.Forms.TextBox()
        Me.loanAina = New System.Windows.Forms.TextBox()
        Me.LoanIDentity = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.loanidsearch = New System.Windows.Forms.TextBox()
        Me.LoadLoans = New System.Windows.Forms.Button()
        Me.DataGrid2 = New System.Windows.Forms.DataGridView()
        Me.nbalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.currentpaid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        Me.depo = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.saveRec = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ltaken = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vldate
        '
        Me.vldate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vldate.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vldate.Location = New System.Drawing.Point(515, 392)
        Me.vldate.Name = "vldate"
        Me.vldate.Size = New System.Drawing.Size(183, 44)
        Me.vldate.TabIndex = 82
        Me.vldate.Text = "Validate"
        Me.vldate.UseVisualStyleBackColor = True
        '
        'membaID
        '
        Me.membaID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.membaID.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membaID.Location = New System.Drawing.Point(234, 242)
        Me.membaID.Name = "membaID"
        Me.membaID.ReadOnly = True
        Me.membaID.Size = New System.Drawing.Size(260, 40)
        Me.membaID.TabIndex = 81
        '
        'loanAina
        '
        Me.loanAina.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.loanAina.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanAina.Location = New System.Drawing.Point(234, 307)
        Me.loanAina.Name = "loanAina"
        Me.loanAina.ReadOnly = True
        Me.loanAina.Size = New System.Drawing.Size(260, 40)
        Me.loanAina.TabIndex = 80
        '
        'LoanIDentity
        '
        Me.LoanIDentity.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.LoanIDentity.FormattingEnabled = True
        Me.LoanIDentity.Location = New System.Drawing.Point(234, 178)
        Me.LoanIDentity.Name = "LoanIDentity"
        Me.LoanIDentity.Size = New System.Drawing.Size(260, 42)
        Me.LoanIDentity.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 34)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Loan Number"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(819, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 34)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Search Loan ID"
        '
        'loanidsearch
        '
        Me.loanidsearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.loanidsearch.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loanidsearch.Location = New System.Drawing.Point(1004, 382)
        Me.loanidsearch.Name = "loanidsearch"
        Me.loanidsearch.Size = New System.Drawing.Size(156, 40)
        Me.loanidsearch.TabIndex = 76
        '
        'LoadLoans
        '
        Me.LoadLoans.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadLoans.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.LoadLoans.Location = New System.Drawing.Point(708, 143)
        Me.LoadLoans.Name = "LoadLoans"
        Me.LoadLoans.Size = New System.Drawing.Size(183, 44)
        Me.LoadLoans.TabIndex = 75
        Me.LoadLoans.Text = "Load Accounts"
        Me.LoadLoans.UseVisualStyleBackColor = True
        '
        'DataGrid2
        '
        Me.DataGrid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid2.Location = New System.Drawing.Point(598, 193)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(552, 180)
        Me.DataGrid2.TabIndex = 74
        '
        'nbalance
        '
        Me.nbalance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nbalance.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbalance.Location = New System.Drawing.Point(234, 537)
        Me.nbalance.Name = "nbalance"
        Me.nbalance.ReadOnly = True
        Me.nbalance.Size = New System.Drawing.Size(260, 40)
        Me.nbalance.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 537)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 34)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "New Balance"
        '
        'currentpaid
        '
        Me.currentpaid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.currentpaid.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentpaid.Location = New System.Drawing.Point(234, 482)
        Me.currentpaid.Name = "currentpaid"
        Me.currentpaid.ReadOnly = True
        Me.currentpaid.Size = New System.Drawing.Size(260, 40)
        Me.currentpaid.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 34)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Current Balance"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(346, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 42)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Deposit Money Into Account"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.logo.Location = New System.Drawing.Point(123, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 68
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'depo
        '
        Me.depo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.depo.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depo.Location = New System.Drawing.Point(234, 422)
        Me.depo.Name = "depo"
        Me.depo.Size = New System.Drawing.Size(260, 40)
        Me.depo.TabIndex = 67
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1083, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 44)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'saveRec
        '
        Me.saveRec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.saveRec.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveRec.Location = New System.Drawing.Point(708, 457)
        Me.saveRec.Name = "saveRec"
        Me.saveRec.Size = New System.Drawing.Size(183, 44)
        Me.saveRec.TabIndex = 65
        Me.saveRec.Text = "Save Record"
        Me.saveRec.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 34)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Deposit Amount"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 34)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Member ID"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 34)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Loan Type"
        '
        'ltaken
        '
        Me.ltaken.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ltaken.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltaken.Location = New System.Drawing.Point(234, 367)
        Me.ltaken.Name = "ltaken"
        Me.ltaken.ReadOnly = True
        Me.ltaken.Size = New System.Drawing.Size(260, 40)
        Me.ltaken.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 34)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Loan Amount"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 635)
        Me.Controls.Add(Me.ltaken)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.vldate)
        Me.Controls.Add(Me.membaID)
        Me.Controls.Add(Me.loanAina)
        Me.Controls.Add(Me.LoanIDentity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.loanidsearch)
        Me.Controls.Add(Me.LoadLoans)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.nbalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.currentpaid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.depo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.saveRec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Loan Repayment"
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vldate As System.Windows.Forms.Button
    Friend WithEvents membaID As System.Windows.Forms.TextBox
    Friend WithEvents loanAina As System.Windows.Forms.TextBox
    Friend WithEvents LoanIDentity As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents loanidsearch As System.Windows.Forms.TextBox
    Friend WithEvents LoadLoans As System.Windows.Forms.Button
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGridView
    Friend WithEvents nbalance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents currentpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents depo As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents saveRec As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ltaken As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
