<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Savingscreate
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DelAcc = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AccVal = New System.Windows.Forms.TextBox()
        Me.tafuta = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGrid2 = New System.Windows.Forms.DataGridView()
        Me.LoadAcc = New System.Windows.Forms.Button()
        Me.MemID = New System.Windows.Forms.ComboBox()
        Me.Accntafuta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JinaAccount = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(356, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(708, 42)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Create and Delete Savings Accounts"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.logo.Location = New System.Drawing.Point(270, 0)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 9
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 34)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Account Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(278, 39)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Create New account"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 34)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Member ID"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 34)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Start Amount"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 26)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Search By Member ID"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(494, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 44)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Save Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DelAcc
        '
        Me.DelAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DelAcc.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelAcc.Location = New System.Drawing.Point(786, 336)
        Me.DelAcc.Name = "DelAcc"
        Me.DelAcc.Size = New System.Drawing.Size(191, 44)
        Me.DelAcc.TabIndex = 18
        Me.DelAcc.Text = "Delete Account"
        Me.DelAcc.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(494, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(166, 44)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AccVal
        '
        Me.AccVal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AccVal.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccVal.Location = New System.Drawing.Point(226, 238)
        Me.AccVal.Name = "AccVal"
        Me.AccVal.Size = New System.Drawing.Size(260, 40)
        Me.AccVal.TabIndex = 22
        '
        'tafuta
        '
        Me.tafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tafuta.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tafuta.Location = New System.Drawing.Point(291, 430)
        Me.tafuta.Name = "tafuta"
        Me.tafuta.Size = New System.Drawing.Size(118, 40)
        Me.tafuta.TabIndex = 24
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1162, 635)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 2000
        Me.LineShape1.Y1 = 420
        Me.LineShape1.Y2 = 420
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 478)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 150)
        Me.DataGridView1.TabIndex = 26
        '
        'DataGrid2
        '
        Me.DataGrid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid2.Location = New System.Drawing.Point(707, 150)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(442, 180)
        Me.DataGrid2.TabIndex = 28
        '
        'LoadAcc
        '
        Me.LoadAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoadAcc.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.LoadAcc.Location = New System.Drawing.Point(719, 102)
        Me.LoadAcc.Name = "LoadAcc"
        Me.LoadAcc.Size = New System.Drawing.Size(183, 44)
        Me.LoadAcc.TabIndex = 30
        Me.LoadAcc.Text = "Load Accounts"
        Me.LoadAcc.UseVisualStyleBackColor = True
        '
        'MemID
        '
        Me.MemID.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.MemID.FormattingEnabled = True
        Me.MemID.Location = New System.Drawing.Point(226, 300)
        Me.MemID.Name = "MemID"
        Me.MemID.Size = New System.Drawing.Size(260, 42)
        Me.MemID.TabIndex = 34
        '
        'Accntafuta
        '
        Me.Accntafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Accntafuta.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accntafuta.Location = New System.Drawing.Point(993, 365)
        Me.Accntafuta.Name = "Accntafuta"
        Me.Accntafuta.Size = New System.Drawing.Size(142, 21)
        Me.Accntafuta.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1015, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 26)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Account ID"
        '
        'JinaAccount
        '
        Me.JinaAccount.Font = New System.Drawing.Font("Impact", 20.25!)
        Me.JinaAccount.FormattingEnabled = True
        Me.JinaAccount.Location = New System.Drawing.Point(226, 172)
        Me.JinaAccount.Name = "JinaAccount"
        Me.JinaAccount.Size = New System.Drawing.Size(260, 42)
        Me.JinaAccount.TabIndex = 36
        '
        'Savingscreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 635)
        Me.Controls.Add(Me.JinaAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MemID)
        Me.Controls.Add(Me.LoadAcc)
        Me.Controls.Add(Me.Accntafuta)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tafuta)
        Me.Controls.Add(Me.AccVal)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DelAcc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Savingscreate"
        Me.Text = "Sacco Management System- Attendant- Savings Accounts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DelAcc As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AccVal As System.Windows.Forms.TextBox
    Friend WithEvents tafuta As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGridView
    Friend WithEvents LoadAcc As System.Windows.Forms.Button
    Friend WithEvents MemID As System.Windows.Forms.ComboBox
    Friend WithEvents Accntafuta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JinaAccount As System.Windows.Forms.ComboBox
End Class
