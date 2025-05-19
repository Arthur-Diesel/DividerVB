Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim a, b As Integer

        If Not Integer.TryParse(txtA.Text, a) Then
            MessageBox.Show("E necessário informar um número inteiro para A.")
            txtA.Focus()
        ElseIf Not Integer.TryParse(txtB.Text, b) Then
            MessageBox.Show("E necessário informar um número inteiro para B.")
            txtB.Focus()
        ElseIf b = 0 Then
            MessageBox.Show("Não é possível dividir por zero.")
            txtB.Focus()
        Else
            Dim result As Integer = a \ b
            txtResult.Text = result.ToString()
        End If
    End Sub
End Class
