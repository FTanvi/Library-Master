<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueReport
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cmbBookName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtSelect = New System.Windows.Forms.RadioButton()
        Me.rbtParticular = New System.Windows.Forms.RadioButton()
        Me.rbtAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.cmbBookName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(50, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 332)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(291, 120)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 39)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(22, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Return Date :-"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(686, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 48)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(370, 241)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 48)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(37, 241)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(113, 48)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'cmbBookName
        '
        Me.cmbBookName.BackColor = System.Drawing.Color.LightPink
        Me.cmbBookName.FormattingEnabled = True
        Me.cmbBookName.Location = New System.Drawing.Point(291, 36)
        Me.cmbBookName.Name = "cmbBookName"
        Me.cmbBookName.Size = New System.Drawing.Size(325, 39)
        Me.cmbBookName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Book Name :-"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtSelect)
        Me.GroupBox1.Controls.Add(Me.rbtParticular)
        Me.GroupBox1.Controls.Add(Me.rbtAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 76)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'rbtSelect
        '
        Me.rbtSelect.AutoSize = True
        Me.rbtSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtSelect.Location = New System.Drawing.Point(696, 24)
        Me.rbtSelect.Name = "rbtSelect"
        Me.rbtSelect.Size = New System.Drawing.Size(105, 36)
        Me.rbtSelect.TabIndex = 2
        Me.rbtSelect.TabStop = True
        Me.rbtSelect.Text = "Select"
        Me.rbtSelect.UseVisualStyleBackColor = True
        '
        'rbtParticular
        '
        Me.rbtParticular.AutoSize = True
        Me.rbtParticular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtParticular.Location = New System.Drawing.Point(343, 24)
        Me.rbtParticular.Name = "rbtParticular"
        Me.rbtParticular.Size = New System.Drawing.Size(159, 36)
        Me.rbtParticular.TabIndex = 1
        Me.rbtParticular.TabStop = True
        Me.rbtParticular.Text = "Particular"
        Me.rbtParticular.UseVisualStyleBackColor = True
        '
        'rbtAll
        '
        Me.rbtAll.AutoSize = True
        Me.rbtAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtAll.Location = New System.Drawing.Point(37, 24)
        Me.rbtAll.Name = "rbtAll"
        Me.rbtAll.Size = New System.Drawing.Size(72, 36)
        Me.rbtAll.TabIndex = 0
        Me.rbtAll.TabStop = True
        Me.rbtAll.Text = "All"
        Me.rbtAll.UseVisualStyleBackColor = True
        '
        'IssueReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1169, 568)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "IssueReport"
        Me.Text = "IssueReport"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cmbBookName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSelect As System.Windows.Forms.RadioButton
    Friend WithEvents rbtParticular As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAll As System.Windows.Forms.RadioButton
End Class
