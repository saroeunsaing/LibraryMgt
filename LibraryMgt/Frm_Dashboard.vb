Public Class Frm_Dashboard

    'sub make new sub form on dashboard
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.Panel_Content.Controls.Count > 0 Then
            Me.Panel_Content.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_Content.Controls.Add(fh)
        Me.Panel_Content.Tag = fh
        fh.Show()
    End Sub
    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        AbrirFormEnPanel(New Frm_Borrower)
    End Sub
End Class
