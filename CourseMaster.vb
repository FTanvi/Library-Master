Imports System.Data.OleDb
Public Class CourseMaster
    Dim sql As String
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            sql = "Select CourseCode from CourseMaster order by CourseCode"
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            Dim r As OleDbDataReader = cmd.ExecuteReader()
            Dim eno As Integer
            eno = 99
            Do While r.Read()
                eno = Strings.Right(r("CourseCode"), 3)
            Loop
            'MsgBox(eno)
            eno = eno + 1
            txtCourseID.Text = "CCode" + Trim(Str(eno))
            txtCourseName.Focus()
            cn.Close()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into CourseMaster Values('" & txtCourseID.Text & "', '" & txtCourseName.Text & "','" & txtCourseDuration.Text & "')"
            MsgBox(Sql)
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            cn.Close()
            txtCourseID.Text = ""
            txtCourseName.Text = ""
            txtCourseDuration.Text = ""
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Update"
            txtCourseID.Enabled = False
            enableON()
        Else
            btnEdit.Text = "&Edit"
            enableOFF()
            cn.Open()
            Dim sql As String
            sql = "update CourseMaster set CourseCode = '" & txtCourseID.Text & "', CourseName = '" & txtCourseName.Text & "' , CourseDuration = '" & txtCourseDuration.Text & "' where CourseCode = '" & cmbUID.Text & "'"
            MsgBox(sql)
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record modified successfully!", , "Update Success")
            cn.Close()
            txtCourseID.Text = ""
            txtCourseName.Text = ""
            txtCourseDuration.Text = ""
        End If
    End Sub
    Public Sub enableOFF()
        txtCourseID.Enabled = False
        txtCourseName.Enabled = False
        txtCourseDuration.Enabled = False

    End Sub
    Public Sub enableON()
        txtCourseID.Enabled = True
        txtCourseName.Enabled = True
        txtCourseDuration.Enabled = True

        txtCourseName.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        cn.Open()
        Dim sql As String
        sql = "select * from CourseMaster where CourseCode ='" & cmbUID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        txtCourseID.Text = r("CourseCode")
        txtCourseName.Text = r("CourseName")
        txtCourseDuration.Text = r("CourseDuration")
        btnGo.Visible = False
        txtCourseID.Visible = True
        cmbUID.Visible = False
        cn.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String
        sql = "delete from CourseMaster where CourseCode = '" & txtCourseID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteReader()
        MsgBox("Record deleted successfully!", , "Delete Success")
        cn.Close()
        txtCourseID.Text = ""
        txtCourseName.Text = ""
        txtCourseDuration.Text = ""
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        txtCourseID.Text = ""
        txtCourseName.Text = ""
        txtCourseDuration.Text = ""
        txtCourseID.Visible = False
        cmbUID.Visible = True
        btnGo.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select CourseCode from CourseMaster"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        Do While r.Read()
            cmbUID.Items.Add(r("CourseCode"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCourseID.Text = ""
        txtCourseName.Text = " "
        txtCourseDuration.Text = " "
        cmbUID.Text = ""
        DataGridView1.Visible = False

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        cn.Open()
        DataGridView1.Visible = True
        Dim sql As String
        sql = "select *from CourseMaster"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Course")
        cn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Course"
    End Sub

End Class