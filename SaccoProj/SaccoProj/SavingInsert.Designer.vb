<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingInsert
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
        Me.AccVal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.saveRec = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        Me.curbal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nbalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoadAcc = New System.Windows.Forms.Button()
        Me.DataGrid2 = New System.Windows.Forms.DataGridView()
        Me.AccIDsrch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AcID = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AccNom = New System.Windows.Forms.TextBox()
        Me.membaID = New System.Windows.Forms.TextBox()
        Me.vldate = New System.Windows.Forms.Button()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccVal
        '
        Me.AccVal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AccVal.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccVal.Location = New System.Drawing.Point(234, 385)
        Me.AccVal.Name = "AccVal"
        Me.AccVal.Size = New System.Drawing.Size(260, 40)
        Me.AccVal.TabIndex = 42
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1083, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 44)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'saveRec
        '
        Me.saveRec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.saveRec.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveRec.Location = New System.Drawing.Point(708, 463)
        Me.saveRec.Name = "saveRec"
        Me.saveRec.Size = New System.Drawing.Size(183, 44)
        Me.saveRec.TabIndex = 40
        Me.saveRec.Text = "Save Record"
        Me.saveRec.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 34)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Deposit Amount"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 34)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Member ID"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 34)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Account Name"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(346, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 42)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Deposit Money Into Account"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.logo.Location = New System.Drawing.Point(123, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 45
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'curbal
        '
        Me.curbal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.curbal.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curbal.Location = New System.Drawing.Point(234, 445)
        Me.curbal.Name = "curbal"
        Me.curbal.ReadOnly = True
        Me.curbal.Size = New System.Drawing.Size(260, 40)
        Me.curbal.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 34)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Current Balance"
        '
        'nbalance
        '
        Me.nbalance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nbalance.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbalance.Location = New System.Drawing.Point(234, 500)
        Me.nbalance.Name = "nbalance"
        Me.nbalance.ReadOnly = True
        Me.nbalance.Size = New System.Drawing.Size(260, 40)
        Me.nbalance.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 34)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "New Balance"
        '
        'LoadAcc
        '
        Me.LoadAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadAcc.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.LoadAcc.Location = New System.Drawing.Point(708, 149)
        Me.LoadAcc.Name = "LoadAcc"
        Me.LoadAcc.Size = New System.Drawing.Size(183, 44)
        Me.LoadAcc.TabIndex = 52
        Me.LoadAcc.Text = "Load Accounts"
        Me.LoadAcc.UseVisualStyleBackColor = True
        '
        'DataGrid2
        '
        Me.DataGrid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid2.Location = New System.Drawing.Point(598, 199)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(552, 180)
        Me.DataGrid2.TabIndex = 51
        '
        'AccIDsrch
        '
        Me.AccIDsrch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AccIDsrch.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccIDsrch.Location = New System.Drawing.Point(1004, 388)
        Me.AccIDsrch.Name = "AccIDsrch"
        Me.AccIDsrch.Size = New System.Drawing.Size(156, 40)
        Me.AccIDsrch.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(742, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 34)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Search Account ID"
        '
        'AcID
        '
        Me.AcID.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.AcID.FormattingEnabled = True
        Me.AcID.Location = New System.Drawing.Point(234, 184)
        Me.AcID.Name = "AcID"
        Me.AcID.Size = New System.Drawing.Size(260, 42)
        Me.AcID.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 34)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Account Number"
        '
        'AccNom
        '
        Me.AccNom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AccNom.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNom.Location = New System.Drawing.Point(234, 313)
        Me.AccNom.Name = "AccNom"
        Me.AccNom.ReadOnly = True
        Me.AccNom.Size = New System.Drawing.Size(260, 40)
        Me.AccNom.TabIndex = 59
        '
        'membaID
        '
        Me.membaID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.membaID.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membaID.Location = New System.Drawing.Point(234, 248)
        Me.membaID.Name = "membaID"
        Me.membaID.ReadOnly = True
        Me.membaID.Size = New System.Drawing.Size(260, 40)
        Me.membaID.TabIndex = 60
        '
        'vldate
        '
        Me.vldate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vldate.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vldate.Location = New System.Drawing.Point(515, 398)
        Me.vldate.Name = "vldate"
        Me.vldate.Size = New System.Drawing.Size(183, 44)
        Me.vldate.TabIndex = 61
        Me.vldate.Text = "Validate"
        Me.vldate.UseVisualStyleBackColor = True
        '
        'SavingInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 635)
        Me.Controls.Add(Me.vldate)
        Me.Controls.Add(Me.membaID)
        Me.Controls.Add(Me.AccNom)
        Me.Controls.Add(Me.AcID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AccIDsrch)
        Me.Controls.Add(Me.LoadAcc)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.nbalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.curbal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.AccVal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.saveRec)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SavingInsert"
        Me.Text = "SavingInsert"
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccVal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents saveRec As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents curbal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nbalance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LoadAcc As System.Windows.Forms.Button
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGridView
    Friend WithEvents AccIDsrch As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AcID As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AccNom As System.Windows.Forms.TextBox
    Friend WithEvents membaID As System.Windows.Forms.TextBox
    Friend WithEvents vldate As System.Windows.Forms.Button
End Class
