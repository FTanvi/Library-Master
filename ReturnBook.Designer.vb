<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBook
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBCode = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBookAuthor = New System.Windows.Forms.ComboBox()
        Me.cmbBookName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtBCode)
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbBookAuthor)
        Me.GroupBox1.Controls.Add(Me.cmbBookName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 437)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'txtBCode
        '
        Me.txtBCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtBCode.Location = New System.Drawing.Point(163, 301)
        Me.txtBCode.Name = "txtBCode"
        Me.txtBCode.Size = New System.Drawing.Size(246, 34)
        Me.txtBCode.TabIndex = 41
        Me.txtBCode.Text = "       "
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(501, 128)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(58, 33)
        Me.btnGo.TabIndex = 40
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(18, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 26)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "BookCode : - "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(187, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 34)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(18, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 26)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Return Date : - "
        '
        'cmbBookAuthor
        '
        Me.cmbBookAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBookAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBookAuthor.FormattingEnabled = True
        Me.cmbBookAuthor.Location = New System.Drawing.Point(263, 224)
        Me.cmbBookAuthor.Name = "cmbBookAuthor"
        Me.cmbBookAuthor.Size = New System.Drawing.Size(296, 33)
        Me.cmbBookAuthor.TabIndex = 4
        '
        'cmbBookName
        '
        Me.cmbBookName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBookName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBookName.FormattingEnabled = True
        Me.cmbBookName.Location = New System.Drawing.Point(187, 129)
        Me.cmbBookName.Name = "cmbBookName"
        Me.cmbBookName.Size = New System.Drawing.Size(276, 33)
        Me.cmbBookName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(18, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 26)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Select Book Author : -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Select Book : -"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(581, 557)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 45)
        Me.btnExit.TabIndex = 45
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(306, 557)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 45)
        Me.btnClear.TabIndex = 44
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(43, 557)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(146, 45)
        Me.btnReturn.TabIndex = 43
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(684, 66)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(231, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 42)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Return Book"
        '
        'ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 658)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ReturnBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnBook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBCode As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbBookAuthor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBookName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
