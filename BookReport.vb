Imports System.Data.OleDb
Public Class BookReport

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try

            If rbtAll.Checked = True Then

                'Me.Close()
                'AddmissionReport1.Show()
                BookReport1.getValue1(cmbBookName.Text)
            ElseIf rbtParticular.Checked = True Then

                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                BookReport1.getValue(cmbBookName.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            ElseIf rptSelect.Checked = True Then
                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                BookReport1.getValue2(cmbBookName.Text, cmbAuthorName.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        BookReport1.ReportViewer1.RefreshReport()
        BookReport1.Show()
    End Sub
    Private Sub rbtAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAll.CheckedChanged
        cmbBookName.Text = ""
        cmbAuthorName.Text = ""
        If rbtAll.Checked = True Then
            'rbtParticular.Enabled = False
            cmbBookName.Enabled = False
            cmbAuthorName.Enabled = False
        Else
            rbtParticular.Enabled = True
            cmbBookName.Enabled = True
        End If
    End Sub

    Private Sub rbtParticular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtParticular.CheckedChanged
        cmbBookName.Text = ""
        cmbAuthorName.Text = ""
        If rbtParticular.Checked = True Then
            'rbtAll.Enabled = False
            cmbBookName.Enabled = True
            cmbAuthorName.Enabled = False
        Else
            'rbtAll.Enabled = True
            cmbBookName.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        rbtAll.Checked = False
        rbtParticular.Checked = False
        cmbBookName.Text = ""
        cmbAuthorName.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BookReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBookName.Items.Clear()
        cmbBookName.Enabled = False
        cn.Open()
        Dim sql = "select distinct BookName from BookMaster order by BookName"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbBookName.Items.Clear()
        Do While r.Read()
            cmbBookName.Items.Add(r("BookName"))
        Loop
        cn.Close()
    End Sub

    Private Sub rptSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptSelect.CheckedChanged
        If rptSelect.Checked = True Then
            rbtAll.Enabled = True
            cmbBookName.Enabled = True
            cmbAuthorName.Enabled = True
            Label1.Text = "Select Book Name :"
            Label2.Text = "Select Author Name :"
        Else
            rbtAll.Enabled = True

            Label1.Text = "Book Name :"
            Label2.Text = "Author Name :"
        End If
    End Sub
    Private Sub cmbBookName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBookName.LostFocus
        cn.Open()
        Dim sql = "select BookAuthor from BookMaster Where BookName = '" & cmbBookName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbAuthorName.Items.Clear()
        Do While r.Read()
            cmbAuthorName.Items.Add(r("BookAuthor"))
        Loop
        cn.Close()
    End Sub
End Class