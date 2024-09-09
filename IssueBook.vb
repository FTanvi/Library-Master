Imports System.Data.OleDb
Public Class IssueBook
    Dim sql As String
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbBookName.Text = ""
        cmbBookAuthor.Text = ""
        txtBCode.Text = ""
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        cn.Open()
        Dim sql As String
        sql = "select * from BookMaster where BookName ='" & cmbBookName.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        cmbBookName.Text = r("BookName")
        txtBCode.Text = r("BookCode")
        cmbBookAuthor.Text = r("BookAuthor")
        ' btnGo.Visible = False
        cn.Close()
    End Sub
    Private Sub IssueBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbBookAuthor.Items.Clear()
        cmbBookName.Items.Clear()
        cn.Open()
        Dim LT As String
        LT = "select  * from BookMaster order by BookName"
        cmd = New OleDbCommand(LT, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        Do While r.Read()
            cmbBookAuthor.Items.Add(r("BookAuthor"))
            cmbBookName.Items.Add(r("BookName"))
        Loop
        cn.Close()
    End Sub
    Private Sub cmbBookAuthor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBookAuthor.LostFocus
        cn.Open()
        Dim sql As String
        sql = "select BookCode from BookMasters where BookAuthor ='" & cmbBookAuthor.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader = cmd.ExecuteReader()
        r.Read()
        txtBCode.Text = r("BookCode")
        cn.Close()
    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click
        sql = "Insert into IssuedRecord Values('" & DateTimePicker1.Text & "', '" & txtBCode.Text & "','" & cmbBookName.Text & "','" & cmbBookAuthor.Text & "')"
        MsgBox(sql)
        cn.Open()
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteReader()
        MsgBox("Book Issued Succesfully but you have to return the book in 15 days.")
        cn.Close()
        cmbBookName.Text = ""
        cmbBookAuthor.Text = ""
        txtBCode.Text = ""
    End Sub
End Class