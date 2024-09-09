Imports System.Data.OleDb
Public Class AddmisssionMaster
    Dim sql As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            sql = "Select StudentID from Addmission order by StudentID"
            cn.Open()
            cmd = New OleDbCommand(sql, cn)
            Dim r As OleDbDataReader = cmd.ExecuteReader()
            Dim eno As Integer
            eno = 99
            Do While r.Read()
                eno = Strings.Right(r("StudentID"), 3)
            Loop
            'MsgBox(eno)
            eno = eno + 1
            txtSID.Text = "SID" + Trim(Str(eno))
            txtSName.Focus()
            cn.Close()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into Addmission Values('" & txtSID.Text & "', '" & txtSName.Text & "','" & cmbGender.Text & "','" & dptDateOfBirth.Text & "','" & dtpAddmissionDate.Text & "','" & cmbSelectCourse.Text & "','" & cmbAddmissionClass.Text & "','" & txtMobileNumber.Text & "','" & txtEmail.Text & "')"
            MsgBox(sql)
            cn.Open()
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            cn.Close()
            txtSID.Text = ""
            txtSName.Text = ""
            cmbGender.Text = ""
            dptDateOfBirth.Text = ""
            dtpAddmissionDate.Text = ""
            cmbSelectCourse.Text = ""
            cmbAddmissionClass.Text = ""
            txtMobileNumber.Text = ""
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub dtpAddmissionDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpAddmissionDate.LostFocus
        sql = "Select CourseName from Course order by CourseName"
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbSelectCourse.Items.Clear()

        Do While r.Read()
            cmbSelectCourse.Items.Add(r("CourseName"))
        Loop
        cn.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSID.Text = ""
        txtSName.Text = ""
        cmbGender.Text = ""
        dptDateOfBirth.Text = ""
        dtpAddmissionDate.Text = ""
        cmbSelectCourse.Text = ""
        cmbAddmissionClass.Text = ""
        txtMobileNumber.Text = ""
        txtEmail.Text = ""
        dgv1.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbSelectCourse_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectCourse.LostFocus
        cn.Open()
        Dim LT As String
        LT = "select Year from Course order by Year"
        cmd = New OleDbCommand(LT, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        Do While r.Read()
            cmbAddmissionClass.Items.Add(r("Year"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Update"
            txtSID.Enabled = False
        Else
            btnEdit.Text = "&Edit"
            cn.Open()
            Dim sql As String
            sql = "update Addmission set StudentID = '" & txtSID.Text & "', StudentName = '" & txtSName.Text & "' , Gender = '" & cmbGender.Text & "', DateOfBirth = '" & dptDateOfBirth.Text & "', AddmissionDate = '" & dtpAddmissionDate.Text & "', Course = '" & cmbSelectCourse.Text & "', AddmissionClass = '" & cmbAddmissionClass.Text & "', MobileNumber = '" & txtMobileNumber.Text & "', Email = '" & txtEmail.Text & "' where SID = '" & txtSID.Text & "'"
            MsgBox(sql)
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record modified successfully!", , "Update Success")
            cn.Close()
            txtSID.Text = ""
            txtSName.Text = ""
            cmbGender.Text = ""
            dptDateOfBirth.Text = ""
            dtpAddmissionDate.Text = ""
            cmbSelectCourse.Text = ""
            cmbAddmissionClass.Text = ""
            txtMobileNumber.Text = ""
            txtEmail.Text = ""
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String
        sql = "delete from Addmission where StudentId = '" & txtSID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteReader()
        MsgBox("Record deleted successfully!", , "Delete Success")
        cn.Close()
        txtSID.Text = ""
        txtSName.Text = ""
        cmbGender.Text = ""
        dptDateOfBirth.Text = ""
        dtpAddmissionDate.Text = ""
        cmbSelectCourse.Text = ""
        cmbAddmissionClass.Text = ""
        txtMobileNumber.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        cmbSID.Text = ""
        txtSID.Text = ""
        txtSName.Text = ""
        cmbGender.Text = ""
        dptDateOfBirth.Text = ""
        dtpAddmissionDate.Text = ""
        cmbSelectCourse.Text = ""
        cmbAddmissionClass.Text = ""
        txtMobileNumber.Text = ""
        txtEmail.Text = ""
        txtSID.Enabled = False
        cmbSID.Visible = True
        btnGo.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select StudentID from Addmission order by StudentID"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        cmbSID.Items.Clear()
        Do While r.Read()
            cmbSID.Items.Add(r("StudentID"))
        Loop
        cn.Close()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        dgv1.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select *from Addmission order by StudentID"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "Addmission")
        cn.Close()
        dgv1.DataSource = ds
        dgv1.DataMember = "Addmission"
        
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        cn.Open()
        Dim sql As String
        sql = "select * from Addmission where StudentID ='" & cmbSID.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        txtSID.Text = r("StudentID")
        txtSName.Text = r("StudentName")
        cmbGender.Text = r("Gender")
        dptDateOfBirth.Text = r("DateOfBirth")
        dtpAddmissionDate.Text = r("AddmissionDate")
        cmbSelectCourse.Text = r("Course")
        cmbAddmissionClass.Text = r("AddmissionClass")
        txtMobileNumber.Text = r("MobileNumber")
        txtEmail.Text = r("Email")
        btnGo.Visible = False
        txtSID.Visible = True

        cmbSID.Visible = False
        cn.Close()
    End Sub
End Class