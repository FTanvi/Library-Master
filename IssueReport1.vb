Public Class IssueReport1

    Public Shared Sub getValue(ByVal value As String)
        IssueReport1.IssuedRecordTableAdapter.FillBy(IssueReport1.DLMDataSet.IssuedRecord, value)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue1(ByVal value As String)
        IssueReport1.IssuedRecordTableAdapter.FillBy1(IssueReport1.DLMDataSet.IssuedRecord)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue2(ByVal IssueDate As String, ByVal BookName As String)
        IssueReport1.IssuedRecordTableAdapter.FillBy2(IssueReport1.DLMDataSet.IssuedRecord, IssueDate, BookName)
        IssueReport1.ReportViewer1.RefreshReport()
    End Sub

End Class