<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BossMembers
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
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackTBoss = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchMem = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.Label()
        Me.SaccoDataSet = New SaccoProj.saccoDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tafuta = New System.Windows.Forms.TextBox()
        Me.MembersTableAdapter = New SaccoProj.saccoDataSetTableAdapters.membersTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New SaccoProj.saccoDataSetTableAdapters.TableAdapterManager()
        Me.MembersDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DOE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DOE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(428, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 42)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "View And Edit Memebers"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Occupation"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Contacts"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contacts"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Residence"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Residence"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "BeneficiaryContacts"
        Me.DataGridViewTextBoxColumn13.HeaderText = "BeneficiaryContacts"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "BeneficiaryName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "BeneficiaryName"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "BeneficiaryID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "BeneficiaryID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "BeneficiarySName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "BeneficiarySName"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'BackTBoss
        '
        Me.BackTBoss.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BackTBoss.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackTBoss.Location = New System.Drawing.Point(703, 511)
        Me.BackTBoss.Name = "BackTBoss"
        Me.BackTBoss.Size = New System.Drawing.Size(248, 43)
        Me.BackTBoss.TabIndex = 30
        Me.BackTBoss.Text = "Back"
        Me.BackTBoss.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SearchMem
        '
        Me.SearchMem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SearchMem.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchMem.Location = New System.Drawing.Point(113, 511)
        Me.SearchMem.Name = "SearchMem"
        Me.SearchMem.Size = New System.Drawing.Size(248, 43)
        Me.SearchMem.TabIndex = 29
        Me.SearchMem.Text = "Search by ID"
        Me.SearchMem.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.logo.AutoSize = True
        Me.logo.Font = New System.Drawing.Font("Algerian", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logo.Location = New System.Drawing.Point(299, 17)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(779, 60)
        Me.logo.TabIndex = 27
        Me.logo.Text = "Sacco Management System"
        '
        'SaccoDataSet
        '
        Me.SaccoDataSet.DataSetName = "saccoDataSet"
        Me.SaccoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "members"
        Me.MembersBindingSource.DataSource = Me.SaccoDataSet
        '
        'Tafuta
        '
        Me.Tafuta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Tafuta.Font = New System.Drawing.Font("Modern No. 20", 15.0!)
        Me.Tafuta.Location = New System.Drawing.Point(378, 518)
        Me.Tafuta.MinimumSize = New System.Drawing.Size(191, 47)
        Me.Tafuta.Name = "Tafuta"
        Me.Tafuta.Size = New System.Drawing.Size(270, 29)
        Me.Tafuta.TabIndex = 32
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MemberID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MemberID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendantTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bossTableAdapter = Nothing
        Me.TableAdapterManager.loansTableAdapter = Nothing
        Me.TableAdapterManager.membersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.savingsTableAdapter = Nothing
        Me.TableAdapterManager.tellerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SaccoProj.saccoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MembersDataGridView
        '
        Me.MembersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MembersDataGridView.AutoGenerateColumns = False
        Me.MembersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MembersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MembersDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.MembersDataGridView.DataSource = Me.MembersBindingSource
        Me.MembersDataGridView.Location = New System.Drawing.Point(40, 122)
        Me.MembersDataGridView.Name = "MembersDataGridView"
        Me.MembersDataGridView.Size = New System.Drawing.Size(1302, 329)
        Me.MembersDataGridView.TabIndex = 31
        '
        'BossMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 592)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackTBoss)
        Me.Controls.Add(Me.SearchMem)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Tafuta)
        Me.Controls.Add(Me.MembersDataGridView)
        Me.Name = "BossMembers"
        Me.Text = "Sacco Management System-Members"
        CType(Me.SaccoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackTBoss As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SearchMem As System.Windows.Forms.Button
    Friend WithEvents logo As System.Windows.Forms.Label
    Friend WithEvents SaccoDataSet As SaccoProj.saccoDataSet
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tafuta As System.Windows.Forms.TextBox
    Friend WithEvents MembersTableAdapter As SaccoProj.saccoDataSetTableAdapters.membersTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As SaccoProj.saccoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembersDataGridView As System.Windows.Forms.DataGridView
End Class
