<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMissionCharges
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFees = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStudentName = New System.Windows.Forms.ComboBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.cmbAddmissionClass = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSelectCourse = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(286, 463)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(113, 35)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(554, 463)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 33)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(849, 463)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 35)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(47, 463)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 35)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtFees)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbStudentName)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.cmbAddmissionClass)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.cmbSelectCourse)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 532)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'txtFees
        '
        Me.txtFees.Enabled = False
        Me.txtFees.Location = New System.Drawing.Point(286, 204)
        Me.txtFees.Name = "txtFees"
        Me.txtFees.Size = New System.Drawing.Size(221, 34)
        Me.txtFees.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(42, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 26)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Admission Charges :-"
        '
        'cmbStudentName
        '
        Me.cmbStudentName.Enabled = False
        Me.cmbStudentName.FormattingEnabled = True
        Me.cmbStudentName.Location = New System.Drawing.Point(243, 37)
        Me.cmbStudentName.Name = "cmbStudentName"
        Me.cmbStudentName.Size = New System.Drawing.Size(491, 33)
        Me.cmbStudentName.TabIndex = 28
        '
        'dgv1
        '
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(36, 261)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(926, 174)
        Me.dgv1.TabIndex = 10
        Me.dgv1.Visible = False
        '
        'cmbAddmissionClass
        '
        Me.cmbAddmissionClass.Enabled = False
        Me.cmbAddmissionClass.FormattingEnabled = True
        Me.cmbAddmissionClass.Location = New System.Drawing.Point(687, 123)
        Me.cmbAddmissionClass.Name = "cmbAddmissionClass"
        Me.cmbAddmissionClass.Size = New System.Drawing.Size(214, 33)
        Me.cmbAddmissionClass.TabIndex = 7
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(834, 33)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(163, 34)
        Me.dtpDate.TabIndex = 5
        Me.dtpDate.Visible = False
        '
        'cmbSelectCourse
        '
        Me.cmbSelectCourse.Enabled = False
        Me.cmbSelectCourse.FormattingEnabled = True
        Me.cmbSelectCourse.Location = New System.Drawing.Point(236, 123)
        Me.cmbSelectCourse.Name = "cmbSelectCourse"
        Me.cmbSelectCourse.Size = New System.Drawing.Size(214, 33)
        Me.cmbSelectCourse.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(474, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 26)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Addmission Class:-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(42, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Select Course :-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(43, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name :-"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1016, 58)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(348, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(344, 42)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Addmission Charges"
        '
        'AddMissionCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1063, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AddMissionCharges"
        Me.Text = "AddMissionCharges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbAddmissionClass As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSelectCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbStudentName As System.Windows.Forms.ComboBox
    Friend WithEvents txtFees As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
