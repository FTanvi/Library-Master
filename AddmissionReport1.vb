Public Class AddmissionReport1

    ' Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    Public Shared Sub getValue(ByVal value As String)
        AddmissionReport1.AddmissionTableAdapter.FillBy(AddmissionReport1.DLMDataSet.Addmission, value)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue1(ByVal value As String)
        AddmissionReport1.AddmissionTableAdapter.FillBy1(AddmissionReport1.DLMDataSet.Addmission)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue2(ByVal Course As String, ByVal StudentName As String)
        AddmissionReport1.AddmissionTableAdapter.FillBy2(AddmissionReport1.DLMDataSet.Addmission, Course, StudentName)
        AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
End Class