Imports System.Data.OleDb
Public Class BookMaster
    Dim sql As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            sql = "Select BookCode from BookMaster order by BookCode"
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            Dim r As OleDbDataReader = cmd.ExecuteReader()
            Dim eno As Integer
            eno = 99
            Do While r.Read()
                eno = Strings.Right(r("BookCode"), 3)
            Loop
            'MsgBox(eno)
            eno = eno + 1
            txtBookCode.Text = "BCode" + Trim(Str(eno))
            txtBookName.Focus()
            cn.Close()
        Else
            btnAdd.Text = "Add"
            sql = "Insert into BookMaster Values('" & txtBookCode.Text & "', '" & txtBookName.Text & "','" & txtBookAuthor.Text & "')"
            MsgBox(Sql)
            cn.Open()
            cmd = New OleDbCommand(Sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record Saved Successfully.")
            cn.Close()
            txtBookCode.Text = ""
            txtBookName.Text = ""
            txtBookAuthor.Text = ""
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBookCode.Text = ""
        txtBookName.Text = ""
        txtBookAuthor.Text = ""
        DataGridView1.Visible = False
        cmbBookCode.Text = ""
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Update"
            txtBookCode.Enabled = False
            enableON()
        Else
            btnEdit.Text = "&Edit"
            enableOFF()
            cn.Open()
            Dim sql As String
            sql = "update BookMaster set BookCode = '" & txtBookCode.Text & "', BookName = '" & txtBookName.Text & "' , BookAuthor = '" & txtBookAuthor.Text & "' where BookCode = '" & cmbBookCode.Text & "'"
            MsgBox(sql)
            cmd = New OleDbCommand(sql, cn)
            cmd.ExecuteReader()
            MsgBox("Record modified successfully!", , "Update Success")
            cn.Close()
            txtBookCode.Text = ""
            txtBookName.Text = ""
            txtBookAuthor.Text = ""
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        cn.Open()
        Dim sql As String
        sql = "delete from BookMaster where BookCode = '" & txtBookCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteReader()
        MsgBox("Record deleted successfully!", , "Delete Success")
        cn.Close()
        txtBookCode.Text = ""
        txtBookName.Text = ""
        txtBookAuthor.Text = ""
    End Sub
    Public Sub enableOFF()
        txtBookCode.Enabled = False
        txtBookName.Enabled = False
        txtBookAuthor.Enabled = False

    End Sub
    Public Sub enableON()
        txtBookCode.Enabled = True
        txtBookName.Enabled = True
        txtBookAuthor.Enabled = True
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        txtBookCode.Text = ""
        txtBookName.Text = ""
        txtBookAuthor.Text = ""
        txtBookCode.Enabled = False
        cmbBookCode.Visible = True
        btnGo.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select BookCode from BookMaster"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        Do While r.Read()
            cmbBookCode.Items.Add(r("BookCode"))
        Loop
        cn.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        DataGridView1.Visible = True
        cn.Open()
        Dim sql As String
        sql = "select * from BookMaster order by BookCode"
        Dim da As New OleDbDataAdapter(sql, cn)
        Dim ds As New DataSet()
        da.Fill(ds, "BookName")
        cn.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "BookName"
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        cn.Open()
        Dim sql As String
        sql = "select * from BookMaster where BookCode ='" & cmbBookCode.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        txtBookName.Text = r("BookName")
        txtBookCode.Text = r("BookCode")
        txtBookAuthor.Text = r("BookAuthor")
        ' btnGo.Visible = False
        cn.Close()
    End Sub
End Class