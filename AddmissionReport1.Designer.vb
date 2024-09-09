<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddmissionReport1
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
        Me.AddmissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DLMDataSet = New DLMProject.DLMDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AddmissionTableAdapter = New DLMProject.DLMDataSetTableAdapters.AddmissionTableAdapter()
        CType(Me.AddmissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddmissionBindingSource
        '
        Me.AddmissionBindingSource.DataMember = "Addmission"
        Me.AddmissionBindingSource.DataSource = Me.DLMDataSet
        '
        'DLMDataSet
        '
        Me.DLMDataSet.DataSetName = "DLMDataSet"
        Me.DLMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.BackColor = System.Drawing.Color.Pink
        Me.ReportViewer1.BackgroundImage = Global.DLMProject.My.Resources.Resources.d1
        Me.ReportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AddmissionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DLMProject.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(31, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1165, 676)
        Me.ReportViewer1.TabIndex = 1
        '
        'AddmissionTableAdapter
        '
        Me.AddmissionTableAdapter.ClearBeforeFill = True
        '
        'AddmissionReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DLMProject.My.Resources.Resources.d33
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1468, 759)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AddmissionReport1"
        Me.Text = "AddmissionReport1"
        CType(Me.AddmissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DLMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DLMDataSet As DLMProject.DLMDataSet
    Friend WithEvents AddmissionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddmissionTableAdapter As DLMProject.DLMDataSetTableAdapters.AddmissionTableAdapter
End Class
