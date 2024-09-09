<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddmissionMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargeMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddmissionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuedBookReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedBookReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddmissionChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayChargesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageChargesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddmissionReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayChargesReciptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DamageChargesReceiptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem1, Me.ReceiptToolStripMenuItem, Me.ExitToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 31)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookMasterToolStripMenuItem, Me.CourseMasterToolStripMenuItem, Me.AddmissionMasterToolStripMenuItem, Me.ChargeMasterToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(74, 27)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'BookMasterToolStripMenuItem
        '
        Me.BookMasterToolStripMenuItem.Name = "BookMasterToolStripMenuItem"
        Me.BookMasterToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.BookMasterToolStripMenuItem.Text = "Book Master"
        '
        'CourseMasterToolStripMenuItem
        '
        Me.CourseMasterToolStripMenuItem.Name = "CourseMasterToolStripMenuItem"
        Me.CourseMasterToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.CourseMasterToolStripMenuItem.Text = "Course Master"
        '
        'AddmissionMasterToolStripMenuItem
        '
        Me.AddmissionMasterToolStripMenuItem.Name = "AddmissionMasterToolStripMenuItem"
        Me.AddmissionMasterToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.AddmissionMasterToolStripMenuItem.Text = "Addmission Master"
        '
        'ChargeMasterToolStripMenuItem
        '
        Me.ChargeMasterToolStripMenuItem.Name = "ChargeMasterToolStripMenuItem"
        Me.ChargeMasterToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.ChargeMasterToolStripMenuItem.Text = "Subject Master"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueBookToolStripMenuItem, Me.ReturnBookToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(109, 27)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'IssueBookToolStripMenuItem
        '
        Me.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem"
        Me.IssueBookToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.IssueBookToolStripMenuItem.Text = "Issue Book"
        '
        'ReturnBookToolStripMenuItem
        '
        Me.ReturnBookToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem"
        Me.ReturnBookToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.ReturnBookToolStripMenuItem.Text = "Return Book"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddmissionReportToolStripMenuItem, Me.BookReportToolStripMenuItem, Me.IssuedBookReportsToolStripMenuItem, Me.ReturnedBookReportsToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(73, 27)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'AddmissionReportToolStripMenuItem
        '
        Me.AddmissionReportToolStripMenuItem.Name = "AddmissionReportToolStripMenuItem"
        Me.AddmissionReportToolStripMenuItem.Size = New System.Drawing.Size(256, 28)
        Me.AddmissionReportToolStripMenuItem.Text = "Addmission Report"
        '
        'BookReportToolStripMenuItem
        '
        Me.BookReportToolStripMenuItem.Name = "BookReportToolStripMenuItem"
        Me.BookReportToolStripMenuItem.Size = New System.Drawing.Size(256, 28)
        Me.BookReportToolStripMenuItem.Text = "Book Report"
        '
        'IssuedBookReportsToolStripMenuItem
        '
        Me.IssuedBookReportsToolStripMenuItem.Name = "IssuedBookReportsToolStripMenuItem"
        Me.IssuedBookReportsToolStripMenuItem.Size = New System.Drawing.Size(256, 28)
        Me.IssuedBookReportsToolStripMenuItem.Text = "Issued Book Reports"
        '
        'ReturnedBookReportsToolStripMenuItem
        '
        Me.ReturnedBookReportsToolStripMenuItem.Name = "ReturnedBookReportsToolStripMenuItem"
        Me.ReturnedBookReportsToolStripMenuItem.Size = New System.Drawing.Size(256, 28)
        Me.ReturnedBookReportsToolStripMenuItem.Text = "Returned Book Reports"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddmissionChargeToolStripMenuItem, Me.DelayChargesToolStripMenuItem, Me.DamageChargesToolStripMenuItem})
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(84, 27)
        Me.ExitToolStripMenuItem1.Text = "Charges"
        '
        'AddmissionChargeToolStripMenuItem
        '
        Me.AddmissionChargeToolStripMenuItem.Name = "AddmissionChargeToolStripMenuItem"
        Me.AddmissionChargeToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.AddmissionChargeToolStripMenuItem.Text = "Addmission charge"
        '
        'DelayChargesToolStripMenuItem
        '
        Me.DelayChargesToolStripMenuItem.Name = "DelayChargesToolStripMenuItem"
        Me.DelayChargesToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.DelayChargesToolStripMenuItem.Text = "Delay charges"
        '
        'DamageChargesToolStripMenuItem
        '
        Me.DamageChargesToolStripMenuItem.Name = "DamageChargesToolStripMenuItem"
        Me.DamageChargesToolStripMenuItem.Size = New System.Drawing.Size(225, 28)
        Me.DamageChargesToolStripMenuItem.Text = "Damage Charges"
        '
        'ReceiptToolStripMenuItem
        '
        Me.ReceiptToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddmissionReceiptToolStripMenuItem, Me.DelayChargesReciptToolStripMenuItem, Me.DamageChargesReceiptToolStripMenuItem})
        Me.ReceiptToolStripMenuItem.Name = "ReceiptToolStripMenuItem"
        Me.ReceiptToolStripMenuItem.Size = New System.Drawing.Size(78, 27)
        Me.ReceiptToolStripMenuItem.Text = "Receipt"
        '
        'AddmissionReceiptToolStripMenuItem
        '
        Me.AddmissionReceiptToolStripMenuItem.Name = "AddmissionReceiptToolStripMenuItem"
        Me.AddmissionReceiptToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.AddmissionReceiptToolStripMenuItem.Text = "Addmission Receipt"
        '
        'DelayChargesReciptToolStripMenuItem
        '
        Me.DelayChargesReciptToolStripMenuItem.Name = "DelayChargesReciptToolStripMenuItem"
        Me.DelayChargesReciptToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.DelayChargesReciptToolStripMenuItem.Text = "DelayCharges Recipt"
        '
        'DamageChargesReceiptToolStripMenuItem
        '
        Me.DamageChargesReceiptToolStripMenuItem.Name = "DamageChargesReceiptToolStripMenuItem"
        Me.DamageChargesReceiptToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.DamageChargesReceiptToolStripMenuItem.Text = "DamageCharges Receipt"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(49, 27)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddmissionMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddmissionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssuedBookReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnedBookReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargeMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddmissionChargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelayChargesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamageChargesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddmissionReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelayChargesReciptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DamageChargesReceiptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
