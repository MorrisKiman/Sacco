<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BossTellers
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.Label()
        Me.SaccoDataSet = New SaccoProj.saccoDataSet()
        Me.TellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TellerTableAdapter = New SaccoProj.saccoDataSetTableAdapters.tellerTableAdapter()
        Me.TableAdapterManager = New SaccoProj.saccoDataSetTableAdapters.TableAdapterManager()
        Me.TellerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackTBoss = New System.Windows.Forms.Button()
        Me.SearchTell = New System.Windows.Forms.Button()
        Me.DelTell = New System.Windows.Forms.Button()
        Me.NuTell = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tellerid = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Sname = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.Refreshtbl = New System.Windows.Forms.Button()
        Me.EditTell = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tafuta = New System.Windows.Forms.TextBox()
        Me.Tellerview = New System.Windows.Forms.DataGridView()
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TellerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tellerview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(333, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "View And Edit Tellers"
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(190, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(929, 60)
        Me.logo.TabIndex = 2
        Me.logo.Text = "LOCA Sacco Management System"
        '
        'SaccoDataSet
        '
        Me.SaccoDataSet.DataSetName = "saccoDataSet"
        Me.SaccoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TellerBindingSource
        '
        Me.TellerBindingSource.DataMember = "teller"
        Me.TellerBindingSource.DataSource = Me.SaccoDataSet
        '
        'TellerTableAdapter
        '
        Me.TellerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendantTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bossTableAdapter = Nothing
        Me.TableAdapterManager.loansTableAdapter = Nothing
        Me.TableAdapterManager.membersTableAdapter = Nothing
        Me.TableAdapterManager.savingsTableAdapter = Nothing
        Me.TableAdapterManager.tellerTableAdapter = Me.TellerTableAdapter
        Me.TableAdapterManager.UpdateOrder = SaccoProj.saccoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TellerDataGridView
        '
        Me.TellerDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TellerDataGridView.AutoGenerateColumns = False
        Me.TellerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TellerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TellerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TellerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TellerDataGridView.DataSource = Me.TellerBindingSource
        Me.TellerDataGridView.Location = New System.Drawing.Point(46, 114)
        Me.TellerDataGridView.Name = "TellerDataGridView"
        Me.TellerDataGridView.ReadOnly = True
        Me.TellerDataGridView.Size = New System.Drawing.Size(837, 220)
        Me.TellerDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TellerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TellerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Teller_Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Teller_Fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Teller_Sname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teller_Sname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TellerPass"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TellerPass"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contacts"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contacts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'BackTBoss
        '
        Me.BackTBoss.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BackTBoss.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackTBoss.Location = New System.Drawing.Point(889, 279)
        Me.BackTBoss.Name = "BackTBoss"
        Me.BackTBoss.Size = New System.Drawing.Size(248, 43)
        Me.BackTBoss.TabIndex = 9
        Me.BackTBoss.Text = "Back"
        Me.BackTBoss.UseVisualStyleBackColor = True
        '
        'SearchTell
        '
        Me.SearchTell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SearchTell.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTell.Location = New System.Drawing.Point(695, 397)
        Me.SearchTell.Name = "SearchTell"
        Me.SearchTell.Size = New System.Drawing.Size(154, 43)
        Me.SearchTell.TabIndex = 8
        Me.SearchTell.Text = "Search"
        Me.SearchTell.UseVisualStyleBackColor = True
        '
        'DelTell
        '
        Me.DelTell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DelTell.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelTell.Location = New System.Drawing.Point(314, 506)
        Me.DelTell.Name = "DelTell"
        Me.DelTell.Size = New System.Drawing.Size(202, 43)
        Me.DelTell.TabIndex = 7
        Me.DelTell.Text = "Delete Teller"
        Me.DelTell.UseVisualStyleBackColor = True
        '
        'NuTell
        '
        Me.NuTell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NuTell.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuTell.Location = New System.Drawing.Point(314, 408)
        Me.NuTell.Name = "NuTell"
        Me.NuTell.Size = New System.Drawing.Size(202, 43)
        Me.NuTell.TabIndex = 6
        Me.NuTell.Text = "Save New Teller"
        Me.NuTell.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Add and Edit Teller"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Teller ID"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Surname"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 517)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Contacts"
        '
        'Tellerid
        '
        Me.Tellerid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Tellerid.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tellerid.Location = New System.Drawing.Point(119, 405)
        Me.Tellerid.Name = "Tellerid"
        Me.Tellerid.Size = New System.Drawing.Size(191, 28)
        Me.Tellerid.TabIndex = 16
        '
        'Fname
        '
        Me.Fname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Fname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.Location = New System.Drawing.Point(116, 442)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(191, 28)
        Me.Fname.TabIndex = 17
        '
        'Sname
        '
        Me.Sname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Sname.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sname.Location = New System.Drawing.Point(116, 479)
        Me.Sname.Name = "Sname"
        Me.Sname.Size = New System.Drawing.Size(191, 28)
        Me.Sname.TabIndex = 18
        '
        'password
        '
        Me.password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.password.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(116, 513)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(191, 28)
        Me.password.TabIndex = 19
        '
        'contact
        '
        Me.contact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.contact.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(116, 550)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(191, 28)
        Me.contact.TabIndex = 20
        '
        'Refreshtbl
        '
        Me.Refreshtbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Refreshtbl.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!)
        Me.Refreshtbl.Location = New System.Drawing.Point(889, 132)
        Me.Refreshtbl.Name = "Refreshtbl"
        Me.Refreshtbl.Size = New System.Drawing.Size(248, 43)
        Me.Refreshtbl.TabIndex = 21
        Me.Refreshtbl.Text = "Refresh Table"
        Me.Refreshtbl.UseVisualStyleBackColor = True
        '
        'EditTell
        '
        Me.EditTell.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditTell.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditTell.Location = New System.Drawing.Point(314, 457)
        Me.EditTell.Name = "EditTell"
        Me.EditTell.Size = New System.Drawing.Size(202, 43)
        Me.EditTell.TabIndex = 22
        Me.EditTell.Text = "Edit Teller"
        Me.EditTell.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1162, 592)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 638
        Me.LineShape2.X2 = 2139
        Me.LineShape2.Y1 = 346
        Me.LineShape2.Y2 = 346
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 640
        Me.LineShape1.X2 = 640
        Me.LineShape1.Y1 = 348
        Me.LineShape1.Y2 = 2589
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(804, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 32)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Search Box"
        '
        'Tafuta
        '
        Me.Tafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Tafuta.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.Tafuta.Location = New System.Drawing.Point(863, 397)
        Me.Tafuta.MinimumSize = New System.Drawing.Size(191, 47)
        Me.Tafuta.Name = "Tafuta"
        Me.Tafuta.Size = New System.Drawing.Size(262, 29)
        Me.Tafuta.TabIndex = 25
        '
        'Tellerview
        '
        Me.Tellerview.AllowUserToAddRows = False
        Me.Tellerview.AllowUserToDeleteRows = False
        Me.Tellerview.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Tellerview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tellerview.Location = New System.Drawing.Point(640, 448)
        Me.Tellerview.Name = "Tellerview"
        Me.Tellerview.ReadOnly = True
        Me.Tellerview.Size = New System.Drawing.Size(519, 150)
        Me.Tellerview.TabIndex = 26
        '
        'BossTellers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1162, 592)
        Me.Controls.Add(Me.Tellerview)
        Me.Controls.Add(Me.Tafuta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EditTell)
        Me.Controls.Add(Me.Refreshtbl)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Sname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Tellerid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BackTBoss)
        Me.Controls.Add(Me.SearchTell)
        Me.Controls.Add(Me.DelTell)
        Me.Controls.Add(Me.NuTell)
        Me.Controls.Add(Me.TellerDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "BossTellers"
        Me.Text = "Sacco Management System- Manager- Tellers"
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TellerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tellerview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents SaccoDataSet As SaccoProj.saccoDataSet
    Friend WithEvents TellerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TellerTableAdapter As SaccoProj.saccoDataSetTableAdapters.tellerTableAdapter
    Friend WithEvents TableAdapterManager As SaccoProj.saccoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TellerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackTBoss As System.Windows.Forms.Button
    Friend WithEvents SearchTell As System.Windows.Forms.Button
    Friend WithEvents DelTell As System.Windows.Forms.Button
    Friend WithEvents NuTell As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tellerid As System.Windows.Forms.TextBox
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Sname As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents Refreshtbl As System.Windows.Forms.Button
    Friend WithEvents EditTell As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tafuta As System.Windows.Forms.TextBox
    Friend WithEvents Tellerview As System.Windows.Forms.DataGridView
End Class
