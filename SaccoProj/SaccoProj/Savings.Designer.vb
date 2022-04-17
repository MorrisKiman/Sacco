<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Savings
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
        Me.SavingsView = New System.Windows.Forms.DataGridView()
        Me.tafuta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.zima = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccNom = New System.Windows.Forms.ComboBox()
        Me.NambayaAcc = New System.Windows.Forms.TextBox()
        Me.reload = New System.Windows.Forms.Button()
        CType(Me.SavingsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(320, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "View Savings Accounts"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(185, 1)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 8
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'SavingsView
        '
        Me.SavingsView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SavingsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SavingsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SavingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SavingsView.Location = New System.Drawing.Point(12, 166)
        Me.SavingsView.Name = "SavingsView"
        Me.SavingsView.ReadOnly = True
        Me.SavingsView.Size = New System.Drawing.Size(1138, 345)
        Me.SavingsView.TabIndex = 10
        '
        'tafuta
        '
        Me.tafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tafuta.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.tafuta.Location = New System.Drawing.Point(709, 136)
        Me.tafuta.Name = "tafuta"
        Me.tafuta.Size = New System.Drawing.Size(79, 24)
        Me.tafuta.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(589, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seach by:"
        '
        'zima
        '
        Me.zima.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.zima.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zima.Location = New System.Drawing.Point(24, 527)
        Me.zima.Name = "zima"
        Me.zima.Size = New System.Drawing.Size(161, 43)
        Me.zima.TabIndex = 13
        Me.zima.Text = "Exit"
        Me.zima.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("OCR-A BT", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label5.Location = New System.Drawing.Point(693, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Reports Categories"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(800, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Account Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1002, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Account Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(706, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Member ID"
        '
        'AccNom
        '
        Me.AccNom.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNom.FormattingEnabled = True
        Me.AccNom.Location = New System.Drawing.Point(803, 136)
        Me.AccNom.Name = "AccNom"
        Me.AccNom.Size = New System.Drawing.Size(196, 24)
        Me.AccNom.TabIndex = 39
        '
        'NambayaAcc
        '
        Me.NambayaAcc.Font = New System.Drawing.Font("OCR-A BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NambayaAcc.Location = New System.Drawing.Point(1005, 136)
        Me.NambayaAcc.Name = "NambayaAcc"
        Me.NambayaAcc.Size = New System.Drawing.Size(100, 24)
        Me.NambayaAcc.TabIndex = 45
        '
        'reload
        '
        Me.reload.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.reload.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reload.Location = New System.Drawing.Point(12, 114)
        Me.reload.Name = "reload"
        Me.reload.Size = New System.Drawing.Size(161, 43)
        Me.reload.TabIndex = 46
        Me.reload.Text = "Redresh"
        Me.reload.UseVisualStyleBackColor = True
        '
        'Savings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.reload)
        Me.Controls.Add(Me.NambayaAcc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AccNom)
        Me.Controls.Add(Me.zima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tafuta)
        Me.Controls.Add(Me.SavingsView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Name = "Savings"
        Me.Text = "Sacco Management System- Teller- Savings"
        CType(Me.SavingsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents SavingsView As System.Windows.Forms.DataGridView
    Friend WithEvents tafuta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents zima As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AccNom As System.Windows.Forms.ComboBox
    Friend WithEvents NambayaAcc As System.Windows.Forms.TextBox
    Friend WithEvents reload As System.Windows.Forms.Button
End Class
