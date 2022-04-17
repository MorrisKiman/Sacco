<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendantEntry
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
        Me.AddMem = New System.Windows.Forms.Button()
        Me.ViewMem = New System.Windows.Forms.Button()
        Me.zima = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(445, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Attendant"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(192, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(779, 60)
        Me.logo.TabIndex = 8
        Me.logo.Text = "Sacco Management System"
        '
        'AddMem
        '
        Me.AddMem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddMem.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMem.Location = New System.Drawing.Point(121, 215)
        Me.AddMem.Name = "AddMem"
        Me.AddMem.Size = New System.Drawing.Size(237, 80)
        Me.AddMem.TabIndex = 10
        Me.AddMem.Text = "Add New Member"
        Me.AddMem.UseVisualStyleBackColor = True
        '
        'ViewMem
        '
        Me.ViewMem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ViewMem.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMem.Location = New System.Drawing.Point(121, 381)
        Me.ViewMem.Name = "ViewMem"
        Me.ViewMem.Size = New System.Drawing.Size(237, 80)
        Me.ViewMem.TabIndex = 11
        Me.ViewMem.Text = "View Members"
        Me.ViewMem.UseVisualStyleBackColor = True
        '
        'zima
        '
        Me.zima.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.zima.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zima.Location = New System.Drawing.Point(771, 362)
        Me.zima.Name = "zima"
        Me.zima.Size = New System.Drawing.Size(237, 80)
        Me.zima.TabIndex = 13
        Me.zima.Text = "Exit"
        Me.zima.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Stencil", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(771, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 71)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Edit Savings Accounts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AttendantEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.zima)
        Me.Controls.Add(Me.ViewMem)
        Me.Controls.Add(Me.AddMem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Name = "AttendantEntry"
        Me.Text = "LOCA Sacco Management System- Attendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents AddMem As System.Windows.Forms.Button
    Friend WithEvents ViewMem As System.Windows.Forms.Button
    Friend WithEvents zima As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
