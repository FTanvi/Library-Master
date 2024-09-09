Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub AddmissionMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmissionMasterToolStripMenuItem.Click
        AddmisssionMaster.Show()
    End Sub
    Private Sub CourseMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseMasterToolStripMenuItem.Click
        CourseMaster.Show()
    End Sub
    Private Sub AddmissionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmissionReportToolStripMenuItem.Click
        AddmissionReport.Show()
    End Sub
    Private Sub BookMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookMasterToolStripMenuItem.Click
        BookMaster.Show()
    End Sub
    Private Sub BookReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookReportToolStripMenuItem.Click
        BookReport.Show()
    End Sub
    Private Sub IssueBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueBookToolStripMenuItem.Click
        IssueBook.Show()
    End Sub
    Private Sub IssuedBookReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuedBookReportsToolStripMenuItem.Click
        IssueReport.Show()
    End Sub
    Private Sub ReturnBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBookToolStripMenuItem.Click
        ReturnBook.show()
    End Sub
    Private Sub ReturnedBookReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnedBookReportsToolStripMenuItem.Click
        ReturnReport.Show()
    End Sub
    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        End
    End Sub
    Private Sub ChargeMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargeMasterToolStripMenuItem.Click
        SubjectMaster.Show()
    End Sub
    Private Sub AddmissionChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmissionChargeToolStripMenuItem.Click
        AddMissionCharges.Show()
    End Sub

    Private Sub DelayChargesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelayChargesToolStripMenuItem.Click
        DelayCharges.Show()
    End Sub

    Private Sub DamageChargesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageChargesToolStripMenuItem.Click
        DamageCharges.Show()
    End Sub

    Private Sub AddmissionReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddmissionReceiptToolStripMenuItem.Click
        AddmissionReceipt.Show()
    End Sub

    Private Sub DelayChargesReciptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelayChargesReciptToolStripMenuItem.Click
        DelayReceipt.Show()
    End Sub

    Private Sub DamageChargesReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageChargesReceiptToolStripMenuItem.Click
        DamageReceipt.Show()
    End Sub
End Class
