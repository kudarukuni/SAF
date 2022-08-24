Public Class Form1
    Private Sub ApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationToolStripMenuItem.Click
        Dim f2 As New Form3
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub DisplayApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayApplicationToolStripMenuItem.Click
        Dim f2 As New Form2
        f2.MdiParent = Me
        f2.Show()
    End Sub
End Class
