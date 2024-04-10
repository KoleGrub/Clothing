Public Class StartForm
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()
    End Sub
End Class