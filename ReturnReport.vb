Imports System.Data.OleDb
Public Class ReturnReport

    Private Sub rbtAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAll.CheckedChanged
        If rbtAll.Checked = True Then
            cmbBookName.Text = ""
            'rbtParticular.Enabled = False
            cmbBookName.Enabled = False
            DateTimePicker1.Enabled = False
        Else
            cmbBookName.Text = ""
            rbtParticular.Enabled = True
            cmbBookName.Enabled = True
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub rbtParticular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtParticular.CheckedChanged
        If rbtParticular.Checked = True Then
            'rbtAll.Enabled = False
            cmbBookName.Enabled = True
            DateTimePicker1.Enabled = False
        Else
            'rbtAll.Enabled = True
            cmbBookName.Enabled = False
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub ReturnReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBookName.Items.Clear()
        cmbBookName.Enabled = False
        cn.Open()
        Dim sql = "select BookName from IssuedRecord order by IssueDate"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbBookName.Items.Clear()
        Do While r.Read()
            cmbBookName.Items.Add(r("BookName"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbBookName.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            If rbtAll.Checked = True Then
                'Me.Close()
                'AddmissionReport1.Show()
                ReturnReport1.getValue1(cmbBookName.Text)
            ElseIf rbtParticular.Checked = True Then

                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                ReturnReport1.getValue(cmbBookName.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            ElseIf rbtSelect.Checked = True Then
                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                ReturnReport1.getValue2(cmbBookName.Text, DateTimePicker1.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        ReturnReport1.ReportViewer1.RefreshReport()
        ReturnReport1.Show()
    End Sub

    Private Sub rbtSelect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSelect.CheckedChanged
        cmbBookName.Text = ""
        If rbtSelect.Checked = True Then
            'rbtAll.Enabled = False
            cmbBookName.Enabled = True
            DateTimePicker1.Enabled = True
        Else
            'rbtAll.Enabled = True
            cmbBookName.Enabled = False
            DateTimePicker1.Enabled = False
        End If
    End Sub
End Class