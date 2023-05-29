Public Class Form1
    Dim Unidad As Integer = 0
    Dim Contador As Integer = 100
    Dim Centena As Integer
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While Contador < 1000
            Unidad = (Contador Mod 10)
            Centena = Int(Contador / 100)
            If (Unidad = Centena) Then
                ListBox1.Items.Add(Str(Contador))
            End If
            Contador = Contador + 1
        End While
    End Sub
End Class
