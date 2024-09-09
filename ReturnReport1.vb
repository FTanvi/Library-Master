Public Class ReturnReport1
    Public Shared Sub getValue(ByVal value As String)
        ReturnReport1.ReturnRecordTableAdapter.FillBy(ReturnReport1.DLMDataSet.ReturnRecord, value)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue1(ByVal value As String)
        ReturnReport1.ReturnRecordTableAdapter.FillBy1(ReturnReport1.DLMDataSet.ReturnRecord)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue2(ByVal ReturnDate As String, ByVal BookName As String)
        ReturnReport1.ReturnRecordTableAdapter.FillBy2(ReturnReport1.DLMDataSet.ReturnRecord, ReturnDate, BookName)
        ReturnReport1.ReportViewer1.RefreshReport()
    End Sub

End Class