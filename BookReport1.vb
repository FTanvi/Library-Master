Public Class BookReport1
    Public Shared Sub getValue(ByVal value As String)
        BookReport1.BookMasterTableAdapter.FillBy(BookReport1.DLMDataSet.BookMaster, value)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue1(ByVal value As String)
        BookReport1.BookMasterTableAdapter.FillBy1(BookReport1.DLMDataSet.BookMaster)
        'AddmissionReport1.ReportViewer1.RefreshReport()
    End Sub
    Public Shared Sub getValue2(ByVal BookName As String, ByVal BookAuthor As String)
        BookReport1.BookMasterTableAdapter.FillBy2(BookReport1.DLMDataSet.BookMaster, BookName, BookAuthor)
        BookReport1.ReportViewer1.RefreshReport()
    End Sub
End Class