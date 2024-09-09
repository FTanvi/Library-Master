Imports System.Data.OleDb
Public Class AddmissionReport

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try

            If rbtAll.Checked = True Then

                'Me.Close()
                'AddmissionReport1.Show()
                AddmissionReport1.getValue1(cmbCourseName.Text)
            ElseIf rbtParticular.Checked = True Then

                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                AddmissionReport1.getValue(cmbCourseName.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            ElseIf rptSelect.Checked = True Then
                'AddmissionReport1.getFilterCname(cmbCustomer.Text)
                AddmissionReport1.getValue2(cmbCourseName.Text, cmbStudentName.Text)
                'Me.Close()
                'AddmissionReport1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        AddmissionReport1.ReportViewer1.RefreshReport()
        AddmissionReport1.Show()
    End Sub

    Private Sub rbtAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAll.CheckedChanged
        cmbCourseName.Text = ""
        cmbStudentName.Text = ""
        If rbtAll.Checked = True Then
            'rbtParticular.Enabled = False
            cmbCourseName.Enabled = False
            cmbStudentName.Enabled = False
        Else
            rbtParticular.Enabled = True
            cmbCourseName.Enabled = True
        End If
    End Sub

    Private Sub rbtParticular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtParticular.CheckedChanged
        cmbCourseName.Text = ""
        cmbStudentName.Text = ""
        If rbtParticular.Checked = True Then
            'rbtAll.Enabled = False
            cmbCourseName.Enabled = True
            cmbStudentName.Enabled = False
        Else
            'rbtAll.Enabled = True
            cmbCourseName.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        rbtAll.Checked = False
        rbtParticular.Checked = False
        cmbCourseName.Text = ""
        cmbStudentName.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AddmissionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCourseName.Items.Clear()
        cmbCourseName.Enabled = False
        cn.Open()
        Dim sql = "select distinct Course from Addmission order by Course"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbCourseName.Items.Clear()
        Do While r.Read()
            cmbCourseName.Items.Add(r("Course"))
        Loop
        cn.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptSelect.CheckedChanged
        If rptSelect.Checked = True Then
            rbtAll.Enabled = True
            cmbCourseName.Enabled = True
            cmbStudentName.Enabled = True
            Label1.Text = "Select Course Name :"
            Label2.Text = "Select Student Name :"
        Else
            rbtAll.Enabled = True

            Label1.Text = "Course Name :"
            Label2.Text = "Student Name :"
        End If

    End Sub
    Private Sub cmbCourseName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCourseName.SelectedIndexChanged
        cn.Open()
        Dim sql = "select StudentName from Addmission Where Course = '" & cmbCourseName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbStudentName.Items.Clear()
        Do While r.Read()
            cmbStudentName.Items.Add(r("StudentName"))
        Loop
        cn.Close()
    End Sub
End Class
