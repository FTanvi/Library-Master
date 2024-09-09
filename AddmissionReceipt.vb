Public Class AddmissionReceipt

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbSelectCourse.Text = ""
        cmbStudentName.Text = ""
        txtRCode.Text = ""
    End Sub
End Class