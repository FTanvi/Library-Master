<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddmisssionMaster
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dptDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSelectCourse = New System.Windows.Forms.ComboBox()
        Me.dtpAddmissionDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmbAddmissionClass = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.cmbSID = New System.Windows.Forms.ComboBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 26)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(33, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Name :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(33, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mobile Number :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(481, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email :-"
        '
        'txtSID
        '
        Me.txtSID.Location = New System.Drawing.Point(212, 30)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(231, 34)
        Me.txtSID.TabIndex = 1
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(217, 103)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(479, 34)
        Me.txtSName.TabIndex = 2
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(239, 373)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(204, 34)
        Me.txtMobileNumber.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(599, 378)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(389, 34)
        Me.txtEmail.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(33, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date of Birth:-"
        '
        'dptDateOfBirth
        '
        Me.dptDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptDateOfBirth.Location = New System.Drawing.Point(212, 195)
        Me.dptDateOfBirth.Name = "dptDateOfBirth"
        Me.dptDateOfBirth.Size = New System.Drawing.Size(163, 34)
        Me.dptDateOfBirth.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(33, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Select Course :-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(448, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 26)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Addmission Date:-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(733, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Gender :-"
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(852, 111)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(136, 33)
        Me.cmbGender.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(471, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 26)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Addmission Class:-"
        '
        'cmbSelectCourse
        '
        Me.cmbSelectCourse.FormattingEnabled = True
        Me.cmbSelectCourse.Location = New System.Drawing.Point(212, 282)
        Me.cmbSelectCourse.Name = "cmbSelectCourse"
        Me.cmbSelectCourse.Size = New System.Drawing.Size(214, 33)
        Me.cmbSelectCourse.TabIndex = 6
        '
        'dtpAddmissionDate
        '
        Me.dtpAddmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAddmissionDate.Location = New System.Drawing.Point(665, 195)
        Me.dtpAddmissionDate.Name = "dtpAddmissionDate"
        Me.dtpAddmissionDate.Size = New System.Drawing.Size(163, 34)
        Me.dtpAddmissionDate.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(24, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 35)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(24, 551)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 33)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(24, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 35)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmbAddmissionClass
        '
        Me.cmbAddmissionClass.FormattingEnabled = True
        Me.cmbAddmissionClass.Location = New System.Drawing.Point(684, 282)
        Me.cmbAddmissionClass.Name = "cmbAddmissionClass"
        Me.cmbAddmissionClass.Size = New System.Drawing.Size(214, 33)
        Me.cmbAddmissionClass.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1183, 58)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(415, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(325, 42)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Addmission Master"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.cmbSID)
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Controls.Add(Me.cmbAddmissionClass)
        Me.GroupBox1.Controls.Add(Me.dtpAddmissionDate)
        Me.GroupBox1.Controls.Add(Me.cmbSelectCourse)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dptDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtMobileNumber)
        Me.GroupBox1.Controls.Add(Me.txtSName)
        Me.GroupBox1.Controls.Add(Me.txtSID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(221, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 613)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(725, 29)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(59, 35)
        Me.btnGo.TabIndex = 28
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'cmbSID
        '
        Me.cmbSID.FormattingEnabled = True
        Me.cmbSID.Location = New System.Drawing.Point(560, 29)
        Me.cmbSID.Name = "cmbSID"
        Me.cmbSID.Size = New System.Drawing.Size(136, 33)
        Me.cmbSID.TabIndex = 27
        '
        'dgv1
        '
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(27, 418)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 24
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(1112, 174)
        Me.dgv1.TabIndex = 10
        Me.dgv1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnView)
        Me.GroupBox2.Controls.Add(Me.btnFind)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 613)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(24, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 35)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(24, 381)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(113, 35)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.White
        Me.btnFind.Location = New System.Drawing.Point(24, 297)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(113, 35)
        Me.btnFind.TabIndex = 26
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(24, 125)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(113, 35)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'AddmisssionMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1403, 701)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AddmisssionMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddmisssionMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSID As System.Windows.Forms.TextBox
    Friend WithEvents txtSName As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dptDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectCourse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAddmissionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmbAddmissionClass As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents cmbSID As System.Windows.Forms.ComboBox
End Class
