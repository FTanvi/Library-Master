Imports System.Data.OleDb
Public Class Login
        Dim cn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sql As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\tanvi\graduation\6th sem\Project\DLMProject\DLM.accdb"
    End Sub
    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim sql = "SELECT UserID ,Password FROM Login WHERE UserID='" & txtUserID.Text & "' AND Password='" & txtPassword.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cn.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.Read = False Then
            MessageBox.Show("Incorrect ID & Password")
            Me.Show()
        Else

            MessageBox.Show("Login successfully...")

            MDIParent1.Show()

        End If

        cn.Close()
        txtUserID.Text = ""
        txtPassword.Text = ""
    End Sub

End Class