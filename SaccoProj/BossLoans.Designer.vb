<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BossLoans
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
        Me.Refresh = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.midsrc = New System.Windows.Forms.TextBox()
        Me.Laina = New System.Windows.Forms.ComboBox()
        Me.stats = New System.Windows.Forms.ComboBox()
        Me.BackTBoss = New System.Windows.Forms.Button()
        Me.LoansDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        CType(Me.LoansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Refresh
        '
        Me.Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Refresh.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh.Location = New System.Drawing.Point(520, 144)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(174, 43)
        Me.Refresh.TabIndex = 38
        Me.Refresh.Text = "Refresh Table"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR-A BT", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(756, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Reports Categories"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(875, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Loan Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1007, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(756, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Member ID"
        '
        'midsrc
        '
        Me.midsrc.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midsrc.Location = New System.Drawing.Point(757, 157)
        Me.midsrc.Name = "midsrc"
        Me.midsrc.Size = New System.Drawing.Size(100, 24)
        Me.midsrc.TabIndex = 33
        '
        'Laina
        '
        Me.Laina.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Laina.FormattingEnabled = True
        Me.Laina.Location = New System.Drawing.Point(878, 157)
        Me.Laina.Name = "Laina"
        Me.Laina.Size = New System.Drawing.Size(121, 24)
        Me.Laina.TabIndex = 32
        '
        'stats
        '
        Me.stats.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stats.FormattingEnabled = True
        Me.stats.Location = New System.Drawing.Point(1010, 157)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(121, 24)
        Me.stats.TabIndex = 31
        '
        'BackTBoss
        '
        Me.BackTBoss.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BackTBoss.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackTBoss.Location = New System.Drawing.Point(12, 145)
        Me.BackTBoss.Name = "BackTBoss"
        Me.BackTBoss.Size = New System.Drawing.Size(125, 43)
        Me.BackTBoss.TabIndex = 30
        Me.BackTBoss.Text = "Back"
        Me.BackTBoss.UseVisualStyleBackColor = True
        '
        'LoansDataGridView
        '
        Me.LoansDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LoansDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.LoansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoansDataGridView.Location = New System.Drawing.Point(6, 193)
        Me.LoansDataGridView.Name = "LoansDataGridView"
        Me.LoansDataGridView.ReadOnly = True
        Me.LoansDataGridView.Size = New System.Drawing.Size(1150, 391)
        Me.LoansDataGridView.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(441, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "View Loans"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(185, 8)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 27
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'BossLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.midsrc)
        Me.Controls.Add(Me.Laina)
        Me.Controls.Add(Me.stats)
        Me.Controls.Add(Me.BackTBoss)
        Me.Controls.Add(Me.LoansDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Name = "BossLoans"
        Me.Text = "Sacco Members Management System- Loans"
        CType(Me.LoansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents midsrc As System.Windows.Forms.TextBox
    Friend WithEvents Laina As System.Windows.Forms.ComboBox
    Friend WithEvents stats As System.Windows.Forms.ComboBox
    Friend WithEvents BackTBoss As System.Windows.Forms.Button
    Friend WithEvents LoansDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
End Class
