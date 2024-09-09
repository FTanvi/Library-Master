Imports System.Data.OleDb
Public Class AddMissionCharges
    Dim sql As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        dtpDate.Visible = True
        cmbStudentName.Enabled = True
        cmbAddmissionClass.Enabled = True
        cmbSelectCourse.Enabled = True
        txtFees.Enabled = True
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            sql = "Select Distinct StudentName from Addmission order by StudentName"
            cn.Open()
            cmd = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = cmd.ExecuteReader()
            cn.Close()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into AddmissionCharges Values('" & dtpDate.Text & "','" & cmbStudentName.Text & "', '" & cmbSelectCourse.Text & "','" & cmbAddmissionClass.Text & "','" & txtFees.Text & "')"
            MsgBox(sql)
            cn.Open()
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            cn.Close()
            dtpDate.Text = ""
            cmbStudentName.Text = ""
            cmbAddmissionClass.Text = ""
            cmbSelectCourse.Text = ""
            txtFees.Text = ""
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        dgv1.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select *from AddmissionCharges "
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "AddmissionCharges")
        cn.Close()
        dgv1.DataSource = ds
        dgv1.DataMember = "AddmissionCharges"
    End Sub

    Private Sub AddMissionCharges_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "Select Distinct StudentName from Addmission order by StudentName"
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbStudentName.Items.Clear()

        Do While r.Read()
            cmbStudentName.Items.Add(r("StudentName"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dtpDate.Text = ""
        cmbStudentName.Text = ""
        cmbAddmissionClass.Text = ""
        cmbSelectCourse.Text = ""
        txtFees.Text = ""
        dgv1.Visible = False

    End Sub

    Private Sub cmbStudentName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStudentName.LostFocus
        sql = "Select Distinct CourseName from CourseMaster order by CourseName"
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbSelectCourse.Items.Clear()

        Do While r.Read()
            cmbSelectCourse.Items.Add(r("CourseName"))
        Loop
        cn.Close()
    End Sub

    Private Sub cmbSelectCourse_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectCourse.LostFocus
        sql = "Select Year from CourseMaster"
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbAddmissionClass.Items.Clear()

        Do While r.Read()
            cmbAddmissionClass.Items.Add(r("Year"))
        Loop
        cn.Close()
    End Sub
End Class