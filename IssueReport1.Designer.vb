<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueReport1
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.IssuedRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLMDataSet = New DLMProject.DLMDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IssuedRecordTableAdapter = New DLMProject.DLMDataSetTableAdapters.IssuedRecordTableAdapter()
        CType(Me.IssuedRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IssuedRecordBindingSource
        '
        Me.IssuedRecordBindingSource.DataMember = "IssuedRecord"
        Me.IssuedRecordBindingSource.DataSource = Me.DLMDataSet
        '
        'DLMDataSet
        '
        Me.DLMDataSet.DataSetName = "DLMDataSet"
        Me.DLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Pink
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.IssuedRecordBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DLMProject.Report7.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 65)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1140, 612)
        Me.ReportViewer1.TabIndex = 0
        '
        'IssuedRecordTableAdapter
        '
        Me.IssuedRecordTableAdapter.ClearBeforeFill = True
        '
        'IssueReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1395, 721)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "IssueReport1"
        Me.Text = "IssueReport1"
        CType(Me.IssuedRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IssuedRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DLMDataSet As DLMProject.DLMDataSet
    Friend WithEvents IssuedRecordTableAdapter As DLMProject.DLMDataSetTableAdapters.IssuedRecordTableAdapter
End Class
