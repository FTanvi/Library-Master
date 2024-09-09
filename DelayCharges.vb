Public Class DelayCharges

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbStudentName.Text = ""
        cmbSelectCourse.Text = ""
        txtFees.Text = ""

    End Sub
End Class