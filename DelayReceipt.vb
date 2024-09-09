Public Class DelayReceipt

    Private Sub DelayReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbSelectCourse.Text = ""
        cmbStudentName.Text = ""
        txtRCode.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class