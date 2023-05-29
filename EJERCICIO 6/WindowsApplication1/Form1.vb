Public Class Form1
    Dim Num As Integer
    Dim Resultado As Integer = 1 'Cargamos en el resultado el elemento neutro de la multiplicación
    Dim a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged ' Aqui se carga el numero
        Num = Val(TextBox1.Text) ' Se lee el numero
        a = Num ' Se hace una copia del numero en a
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While (a >= 1) ' Mientras que la copia sea mayor o igual a uno procedera a sustituirla por su atenrior y sobre multiplicarlo
            Resultado = a * Resultado
            a = a - 1
        End While
        TextBox3.Text = Str(Resultado)
        Resultado = 1
    End Sub

    Public Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
