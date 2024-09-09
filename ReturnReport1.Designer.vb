<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnReport1
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
        Me.ReturnRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLMDataSet = New DLMProject.DLMDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReturnRecordTableAdapter = New DLMProject.DLMDataSetTableAdapters.ReturnRecordTableAdapter()
        CType(Me.ReturnRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReturnRecordBindingSource
        '
        Me.ReturnRecordBindingSource.DataMember = "ReturnRecord"
        Me.ReturnRecordBindingSource.DataSource = Me.DLMDataSet
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
        ReportDataSource1.Value = Me.ReturnRecordBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DLMProject.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(30, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1089, 677)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReturnRecordTableAdapter
        '
        Me.ReturnRecordTableAdapter.ClearBeforeFill = True
        '
        'ReturnReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1218, 714)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReturnReport1"
        Me.Text = "ReturnReport1"
        CType(Me.ReturnRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReturnRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DLMDataSet As DLMProject.DLMDataSet
    Friend WithEvents ReturnRecordTableAdapter As DLMProject.DLMDataSetTableAdapters.ReturnRecordTableAdapter
End Class
