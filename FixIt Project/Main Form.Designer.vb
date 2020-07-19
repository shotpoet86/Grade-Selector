<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CoursesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyCoursesDataSet = New FixIt_Project.MyCoursesDataSet()
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.radGrade = New System.Windows.Forms.RadioButton()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.NumGradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoursesTableAdapter = New FixIt_Project.MyCoursesDataSetTableAdapters.CoursesTableAdapter()
        Me.TableAdapterManager = New FixIt_Project.MyCoursesDataSetTableAdapters.TableAdapterManager()
        Me.NumGradeTableAdapter = New FixIt_Project.MyCoursesDataSetTableAdapters.NumGradeTableAdapter()
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCoursesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumGradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoursesDataGridView
        '
        Me.CoursesDataGridView.AllowUserToAddRows = False
        Me.CoursesDataGridView.AllowUserToDeleteRows = False
        Me.CoursesDataGridView.AutoGenerateColumns = False
        Me.CoursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CoursesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.HoursDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.CoursesDataGridView.DataSource = Me.CoursesBindingSource
        Me.CoursesDataGridView.Location = New System.Drawing.Point(5, 2)
        Me.CoursesDataGridView.Name = "CoursesDataGridView"
        Me.CoursesDataGridView.ReadOnly = True
        Me.CoursesDataGridView.RowHeadersVisible = False
        Me.CoursesDataGridView.Size = New System.Drawing.Size(446, 166)
        Me.CoursesDataGridView.TabIndex = 2
        Me.CoursesDataGridView.TabStop = False
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 54
        '
        'HoursDataGridViewTextBoxColumn
        '
        Me.HoursDataGridViewTextBoxColumn.DataPropertyName = "Hours"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HoursDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.HoursDataGridViewTextBoxColumn.HeaderText = "Hours"
        Me.HoursDataGridViewTextBoxColumn.Name = "HoursDataGridViewTextBoxColumn"
        Me.HoursDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GradeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.MyCoursesDataSet
        '
        'MyCoursesDataSet
        '
        Me.MyCoursesDataSet.DataSetName = "MyCoursesDataSet"
        Me.MyCoursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Checked = True
        Me.radAll.Location = New System.Drawing.Point(486, 27)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(39, 19)
        Me.radAll.TabIndex = 3
        Me.radAll.TabStop = True
        Me.radAll.Text = "&All"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'radGrade
        '
        Me.radGrade.AutoSize = True
        Me.radGrade.Location = New System.Drawing.Point(486, 53)
        Me.radGrade.Name = "radGrade"
        Me.radGrade.Size = New System.Drawing.Size(56, 19)
        Me.radGrade.TabIndex = 4
        Me.radGrade.Text = "&Grade"
        Me.radGrade.UseVisualStyleBackColor = True
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(486, 78)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(39, 23)
        Me.txtGrade.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(486, 121)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(486, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NumGradeBindingSource, "Number", True))
        Me.lblCount.Location = New System.Drawing.Point(549, 77)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 23)
        Me.lblCount.TabIndex = 7
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumGradeBindingSource
        '
        Me.NumGradeBindingSource.DataMember = "NumGrade"
        Me.NumGradeBindingSource.DataSource = Me.MyCoursesDataSet
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoursesTableAdapter = Me.CoursesTableAdapter
        Me.TableAdapterManager.UpdateOrder = FixIt_Project.MyCoursesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NumGradeTableAdapter
        '
        Me.NumGradeTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 191)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.radGrade)
        Me.Controls.Add(Me.radAll)
        Me.Controls.Add(Me.CoursesDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Information"
        CType(Me.CoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCoursesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumGradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CoursesDataGridView As DataGridView
    Friend WithEvents radAll As RadioButton
    Friend WithEvents radGrade As RadioButton
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents MyCoursesDataSet As MyCoursesDataSet
    Friend WithEvents CoursesTableAdapter As MyCoursesDataSetTableAdapters.CoursesTableAdapter
    Friend WithEvents TableAdapterManager As MyCoursesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NumGradeTableAdapter As MyCoursesDataSetTableAdapters.NumGradeTableAdapter
    Friend WithEvents CoursesBindingSource As BindingSource
    Friend WithEvents NumGradeBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
