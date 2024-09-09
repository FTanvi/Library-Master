<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReport
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
        Me.cmbAuthorName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cmbBookName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rptSelect = New System.Windows.Forms.RadioButton()
        Me.rbtParticular = New System.Windows.Forms.RadioButton()
        Me.rbtAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbAuthorName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.cmbBookName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(897, 419)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'cmbAuthorName
        '
        Me.cmbAuthorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAuthorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAuthorName.FormattingEnabled = True
        Me.cmbAuthorName.Location = New System.Drawing.Point(261, 150)
        Me.cmbAuthorName.Name = "cmbAuthorName"
        Me.cmbAuthorName.Size = New System.Drawing.Size(355, 33)
        Me.cmbAuthorName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Author Name :-"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(634, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 48)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(330, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 48)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(27, 283)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(113, 48)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'cmbBookName
        '
        Me.cmbBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBookName.FormattingEnabled = True
        Me.cmbBookName.Location = New System.Drawing.Point(261, 62)
        Me.cmbBookName.Name = "cmbBookName"
        Me.cmbBookName.Size = New System.Drawing.Size(355, 33)
        Me.cmbBookName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(39, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Book Name :-"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rptSelect)
        Me.GroupBox1.Controls.Add(Me.rbtParticular)
        Me.GroupBox1.Controls.Add(Me.rbtAll)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 76)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'rptSelect
        '
        Me.rptSelect.AutoSize = True
        Me.rptSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rptSelect.Location = New System.Drawing.Point(634, 24)
        Me.rptSelect.Name = "rptSelect"
        Me.rptSelect.Size = New System.Drawing.Size(94, 30)
        Me.rptSelect.TabIndex = 2
        Me.rptSelect.TabStop = True
        Me.rptSelect.Text = "Select"
        Me.rptSelect.UseVisualStyleBackColor = True
        '
        'rbtParticular
        '
        Me.rbtParticular.AutoSize = True
        Me.rbtParticular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbtParticular.Location = New System.Drawing.Point(303, 24)
        Me.rbtParticular.Name = "rbtParticular"
        Me.rbtParticular.Size = New System.Drawing.Size(140, 30)
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
        Me.rbtAll.Size = New System.Drawing.Size(64, 30)
        Me.rbtAll.TabIndex = 0
        Me.rbtAll.TabStop = True
        Me.rbtAll.Text = "All"
        Me.rbtAll.UseVisualStyleBackColor = True
        '
        'BookReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 614)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BookReport"
        Me.Text = "BookReport"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAuthorName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cmbBookName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rptSelect As System.Windows.Forms.RadioButton
    Friend WithEvents rbtParticular As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAll As System.Windows.Forms.RadioButton
End Class
