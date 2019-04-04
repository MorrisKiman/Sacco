<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BossAttentants
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
        Me.components = New System.ComponentModel.Container()
        Me.BackTBoss = New System.Windows.Forms.Button()
        Me.SaccoDataSet = New SaccoProj.saccoDataSet()
        Me.AttendantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendantTableAdapter = New SaccoProj.saccoDataSetTableAdapters.attendantTableAdapter()
        Me.TableAdapterManager = New SaccoProj.saccoDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.EditAtt = New System.Windows.Forms.Button()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Attid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DelAtt = New System.Windows.Forms.Button()
        Me.NuAtt = New System.Windows.Forms.Button()
        Me.Refreshtbl = New System.Windows.Forms.Button()
        Me.Attendantview = New System.Windows.Forms.DataGridView()
        Me.Tafuta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AttendantDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Attendantview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendantDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackTBoss
        '
        Me.BackTBoss.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BackTBoss.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackTBoss.Location = New System.Drawing.Point(946, 269)
        Me.BackTBoss.Name = "BackTBoss"
        Me.BackTBoss.Size = New System.Drawing.Size(131, 43)
        Me.BackTBoss.TabIndex = 5
        Me.BackTBoss.Text = "Back"
        Me.BackTBoss.UseVisualStyleBackColor = True
        '
        'SaccoDataSet
        '
        Me.SaccoDataSet.DataSetName = "saccoDataSet"
        Me.SaccoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendantBindingSource
        '
        Me.AttendantBindingSource.DataMember = "attendant"
        Me.AttendantBindingSource.DataSource = Me.SaccoDataSet
        '
        'AttendantTableAdapter
        '
        Me.AttendantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendantTableAdapter = Me.AttendantTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bossTableAdapter = Nothing
        Me.TableAdapterManager.loansTableAdapter = Nothing
        Me.TableAdapterManager.membersTableAdapter = Nothing
        Me.TableAdapterManager.savingsTableAdapter = Nothing
        Me.TableAdapterManager.tellerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SaccoProj.saccoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(315, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Edit and View Attendants"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.logo.Location = New System.Drawing.Point(178, -7)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 7
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -169
        Me.LineShape2.X2 = 1332
        Me.LineShape2.Y1 = -825
        Me.LineShape2.Y2 = -825
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -167
        Me.LineShape1.X2 = -167
        Me.LineShape1.Y1 = -823
        Me.LineShape1.Y2 = 1418
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1162, 637)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape4.BorderWidth = 5
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 616
        Me.LineShape4.X2 = 616
        Me.LineShape4.Y1 = 336
        Me.LineShape4.Y2 = 2577
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape3.BorderWidth = 5
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 614
        Me.LineShape3.X2 = 2115
        Me.LineShape3.Y1 = 334
        Me.LineShape3.Y2 = 334
        '
        'EditAtt
        '
        Me.EditAtt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditAtt.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditAtt.Location = New System.Drawing.Point(340, 487)
        Me.EditAtt.Name = "EditAtt"
        Me.EditAtt.Size = New System.Drawing.Size(202, 43)
        Me.EditAtt.TabIndex = 36
        Me.EditAtt.Text = "Edit Attendant"
        Me.EditAtt.UseVisualStyleBackColor = True
        '
        'contact
        '
        Me.contact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.contact.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(142, 580)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(191, 28)
        Me.contact.TabIndex = 35
        '
        'password
        '
        Me.password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.password.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(142, 543)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(191, 28)
        Me.password.TabIndex = 34
        '
        'Sname
        '
        Me.Sname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Sname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sname.Location = New System.Drawing.Point(142, 509)
        Me.Sname.Name = "Sname"
        Me.Sname.Size = New System.Drawing.Size(191, 28)
        Me.Sname.TabIndex = 33
        '
        'Fname
        '
        Me.Fname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Fname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.Location = New System.Drawing.Point(142, 472)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(191, 28)
        Me.Fname.TabIndex = 32
        '
        'Attid
        '
        Me.Attid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Attid.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Attid.Location = New System.Drawing.Point(142, 435)
        Me.Attid.Name = "Attid"
        Me.Attid.Size = New System.Drawing.Size(191, 28)
        Me.Attid.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 584)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Contacts"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Attendant ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 32)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Add and Edit Attendant"
        '
        'DelAtt
        '
        Me.DelAtt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DelAtt.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelAtt.Location = New System.Drawing.Point(340, 536)
        Me.DelAtt.Name = "DelAtt"
        Me.DelAtt.Size = New System.Drawing.Size(249, 43)
        Me.DelAtt.TabIndex = 24
        Me.DelAtt.Text = "Delete Attendant"
        Me.DelAtt.UseVisualStyleBackColor = True
        '
        'NuAtt
        '
        Me.NuAtt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NuAtt.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuAtt.Location = New System.Drawing.Point(340, 438)
        Me.NuAtt.Name = "NuAtt"
        Me.NuAtt.Size = New System.Drawing.Size(260, 43)
        Me.NuAtt.TabIndex = 23
        Me.NuAtt.Text = "Save New Attendant"
        Me.NuAtt.UseVisualStyleBackColor = True
        '
        'Refreshtbl
        '
        Me.Refreshtbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Refreshtbl.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!)
        Me.Refreshtbl.Location = New System.Drawing.Point(946, 117)
        Me.Refreshtbl.Name = "Refreshtbl"
        Me.Refreshtbl.Size = New System.Drawing.Size(173, 43)
        Me.Refreshtbl.TabIndex = 37
        Me.Refreshtbl.Text = "Refresh Table"
        Me.Refreshtbl.UseVisualStyleBackColor = True
        '
        'Attendantview
        '
        Me.Attendantview.AllowUserToAddRows = False
        Me.Attendantview.AllowUserToDeleteRows = False
        Me.Attendantview.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Attendantview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Attendantview.Location = New System.Drawing.Point(633, 459)
        Me.Attendantview.Name = "Attendantview"
        Me.Attendantview.ReadOnly = True
        Me.Attendantview.Size = New System.Drawing.Size(519, 150)
        Me.Attendantview.TabIndex = 41
        '
        'Tafuta
        '
        Me.Tafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Tafuta.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.Tafuta.Location = New System.Drawing.Point(902, 384)
        Me.Tafuta.MinimumSize = New System.Drawing.Size(191, 47)
        Me.Tafuta.Name = "Tafuta"
        Me.Tafuta.Size = New System.Drawing.Size(260, 29)
        Me.Tafuta.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(817, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 32)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Search Box"
        '
        'AttendantDataGridView
        '
        Me.AttendantDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AttendantDataGridView.AutoGenerateColumns = False
        Me.AttendantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AttendantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttendantDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AttendantDataGridView.DataSource = Me.AttendantBindingSource
        Me.AttendantDataGridView.Location = New System.Drawing.Point(22, 93)
        Me.AttendantDataGridView.Name = "AttendantDataGridView"
        Me.AttendantDataGridView.Size = New System.Drawing.Size(918, 220)
        Me.AttendantDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AttendantID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AttendantID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AttendantFname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AttendantFname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "AttendantLname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "AttendantLname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contacts"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contacts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AttendantPass"
        Me.DataGridViewTextBoxColumn6.HeaderText = "AttendantPass"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(618, 394)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(292, 32)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Search First Name"
        '
        'BossAttentants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 637)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AttendantDataGridView)
        Me.Controls.Add(Me.Attendantview)
        Me.Controls.Add(Me.Tafuta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Refreshtbl)
        Me.Controls.Add(Me.EditAtt)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Sname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Attid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DelAtt)
        Me.Controls.Add(Me.NuAtt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.BackTBoss)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "BossAttentants"
        Me.Text = "Sacco Management System- Manager- Attentants"
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Attendantview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendantDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackTBoss As System.Windows.Forms.Button
    Friend WithEvents SaccoDataSet As SaccoProj.saccoDataSet
    Friend WithEvents AttendantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AttendantTableAdapter As SaccoProj.saccoDataSetTableAdapters.attendantTableAdapter
    Friend WithEvents TableAdapterManager As SaccoProj.saccoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents EditAtt As System.Windows.Forms.Button
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Sname As System.Windows.Forms.TextBox
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Attid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DelAtt As System.Windows.Forms.Button
    Friend WithEvents NuAtt As System.Windows.Forms.Button
    Friend WithEvents Refreshtbl As System.Windows.Forms.Button
    Friend WithEvents Attendantview As System.Windows.Forms.DataGridView
    Friend WithEvents Tafuta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents AttendantDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
