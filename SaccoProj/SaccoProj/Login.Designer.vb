<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.logo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ingia = New System.Windows.Forms.Button()
        Me.Zima = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Attendant = New System.Windows.Forms.RadioButton()
        Me.Teller = New System.Windows.Forms.RadioButton()
        Me.Manager = New System.Windows.Forms.RadioButton()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logo.Location = New System.Drawing.Point(194, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 0
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(460, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Login"
        '
        'Ingia
        '
        Me.Ingia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Ingia.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ingia.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingia.Location = New System.Drawing.Point(247, 535)
        Me.Ingia.Name = "Ingia"
        Me.Ingia.Size = New System.Drawing.Size(197, 51)
        Me.Ingia.TabIndex = 2
        Me.Ingia.Text = "Login"
        Me.Ingia.UseVisualStyleBackColor = False
        '
        'Zima
        '
        Me.Zima.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Zima.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Zima.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zima.Location = New System.Drawing.Point(593, 535)
        Me.Zima.Name = "Zima"
        Me.Zima.Size = New System.Drawing.Size(197, 51)
        Me.Zima.TabIndex = 3
        Me.Zima.Text = "Exit"
        Me.Zima.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(125, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(125, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(820, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 39)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Manager"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(65, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 39)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Attendant"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(460, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 39)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Teller"
        '
        'username
        '
        Me.username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.username.Font = New System.Drawing.Font("OCR A Extended", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(343, 284)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(601, 35)
        Me.username.TabIndex = 11
        '
        'Attendant
        '
        Me.Attendant.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Attendant.AutoSize = True
        Me.Attendant.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Attendant.Location = New System.Drawing.Point(299, 159)
        Me.Attendant.Name = "Attendant"
        Me.Attendant.Size = New System.Drawing.Size(14, 13)
        Me.Attendant.TabIndex = 12
        Me.Attendant.TabStop = True
        Me.Attendant.UseVisualStyleBackColor = True
        '
        'Teller
        '
        Me.Teller.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Teller.AutoSize = True
        Me.Teller.Location = New System.Drawing.Point(600, 159)
        Me.Teller.Name = "Teller"
        Me.Teller.Size = New System.Drawing.Size(14, 13)
        Me.Teller.TabIndex = 13
        Me.Teller.TabStop = True
        Me.Teller.UseVisualStyleBackColor = True
        '
        'Manager
        '
        Me.Manager.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Manager.AutoSize = True
        Me.Manager.Location = New System.Drawing.Point(1020, 159)
        Me.Manager.Name = "Manager"
        Me.Manager.Size = New System.Drawing.Size(14, 13)
        Me.Manager.TabIndex = 14
        Me.Manager.TabStop = True
        Me.Manager.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(343, 447)
        Me.pass.MinimumSize = New System.Drawing.Size(601, 35)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(601, 35)
        Me.pass.TabIndex = 15
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Manager)
        Me.Controls.Add(Me.Teller)
        Me.Controls.Add(Me.Attendant)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Zima)
        Me.Controls.Add(Me.Ingia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Location = New System.Drawing.Point(1, 2)
        Me.Name = "Login"
        Me.Text = "Sacco Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ingia As System.Windows.Forms.Button
    Friend WithEvents Zima As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Attendant As System.Windows.Forms.RadioButton
    Friend WithEvents Teller As System.Windows.Forms.RadioButton
    Friend WithEvents Manager As System.Windows.Forms.RadioButton
    Friend WithEvents pass As System.Windows.Forms.TextBox

End Class
