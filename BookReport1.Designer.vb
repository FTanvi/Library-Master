<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReport1
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
        Me.BookMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLMDataSet = New DLMProject.DLMDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BookMasterTableAdapter = New DLMProject.DLMDataSetTableAdapters.BookMasterTableAdapter()
        CType(Me.BookMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookMasterBindingSource
        '
        Me.BookMasterBindingSource.DataMember = "BookMaster"
        Me.BookMasterBindingSource.DataSource = Me.DLMDataSet
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
        ReportDataSource1.Value = Me.BookMasterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DLMProject.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 43)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1089, 688)
        Me.ReportViewer1.TabIndex = 0
        '
        'BookMasterTableAdapter
        '
        Me.BookMasterTableAdapter.ClearBeforeFill = True
        '
        'BookReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 762)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BookReport1"
        Me.Text = "BookReport1"
        CType(Me.BookMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BookMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DLMDataSet As DLMProject.DLMDataSet
    Friend WithEvents BookMasterTableAdapter As DLMProject.DLMDataSetTableAdapters.BookMasterTableAdapter
End Class
