Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A, B, C As Single
        A = InputBox("ingresar un numero")
        B = InputBox("ingresar un otro numero")
        C = A + B
        MsgBox("el resultado de la suma es " & C)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim A, B, C, D As Single
        A = InputBox("ingresar un numero")
        B = InputBox("ingresa otro valor numerico")
        C = InputBox("ingresar otro valor")
        D = A - B - C
        MsgBox("El resultado de la resta es " & D)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim A, B, C, D As Double
        A = InputBox("ingresar una edad")
        B = InputBox("ingresar otra edad")
        C = InputBox("ingresá una ultima edad")
        D = (A + B + C) / 3
        MsgBox("El promedio es " & D)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a, b, c, d, w, f As Single
        a = InputBox("Ingresar un número")
        b = InputBox("Ingresar otro número")
        c = InputBox("Ingresar otro número")
        d = InputBox("Ingresar otro número")
        w = a + b
        f = c * d
        MsgBox("La suma da como resultado " & w)
        MsgBox("El producto de la multiplicación es " & f)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim A, B, C As Double
        A = InputBox("Ingresar un número (divisor)")
        B = InputBox("Ingresar un número (dividendo)")
        C = B / A
        MsgBox("El cociente es " & C)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub
End Class
