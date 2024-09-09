Imports System.Data.OleDb
Public Class SubjectMaster
    Dim sql As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            sql = "Select SubID from SubjectMaster order by SubID"
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            Dim r As OleDbDataReader = cmd.ExecuteReader()
            Dim eno As Integer
            eno = 99
            Do While r.Read()
                eno = Strings.Right(r("SubID"), 3)
            Loop
            'MsgBox(eno)
            eno = eno + 1
            txtSubID.Text = "SUB" + Trim(Str(eno))
            cmbCourse.Focus()
            cn.Close()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into SubjectMaster Values('" & txtSubID.Text & "', '" & cmbCourse.Text & "','" & txtSubName.Text & "')"
            MsgBox(Sql)
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            cn.Close()
            txtSubID.Text = ""
            cmbCourse.Text = ""
            txtSubName.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSubID.Text = ""
        cmbCourse.Text = ""
        txtSubName.Text = ""
        DataGridView1.Visible = False
        cmbSubID.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub SubjectMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "Select CourseName from CourseMaster order by CourseName"
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbCourse.Items.Clear()

        Do While r.Read()
            cmbCourse.Items.Add(r("CourseName"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String
        sql = "delete from SubjectMaster where SubID = '" & txtSubID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteReader()
        MsgBox("Record deleted successfully!", , "Delete Success")
        cn.Close()
        txtSubID.Text = ""
        cmbCourse.Text = ""
        txtSubName.Text = ""
        cmbSubID.Text = ""
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        txtSubID.Text = ""
        cmbCourse.Text = ""
        txtSubName.Text = ""
        cmbSubID.Text = ""
        btnGo.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select SubID from SubjectMaster"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbSubID.Items.Clear()
        Do While r.Read()
            cmbSubID.Items.Add(r("SubID"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        cn.Open()
        Dim sql As String
        sql = "select * from SubjectMaster where SubID ='" & cmbSubID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        txtSubID.Text = r("SubID")
        cmbCourse.Text = r("Course")
        txtSubName.Text = r("SubjectName")
        btnGo.Visible = False
        cn.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Update"
            txtSubID.Enabled = False
        Else
            btnEdit.Text = "&Edit"
            cn.Open()
            Dim sql As String
            sql = "update SubjectMaster set SubID = '" & txtSubID.Text & "', Course = '" & cmbCourse.Text & "' , SubjectName = '" & txtSubName.Text & "' where SubID = '" & cmbSubID.Text & "'"
            MsgBox(sql)
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record modified successfully!", , "Update Success")
            cn.Close()
            txtSubID.Text = ""
            cmbCourse.Text = ""
            txtSubName.Text = ""
            cmbSubID.Text = ""
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        cn.Open()
        DataGridView1.Visible = True
        Dim sql As String
        sql = "select *from SubjectMaster"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Subject")
        cn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Subject"
    End Sub
End Class