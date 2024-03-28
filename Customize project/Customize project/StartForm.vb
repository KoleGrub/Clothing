Public Class StartForm
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        Me.Hide()
        Dim F2 As New Form2
        F2.ShowDialog()
        Me.Show()

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        Me.Hide()
        Dim F3 As New Form3
        F3.ShowDialog()
        Me.Show()
    End Sub
End Class