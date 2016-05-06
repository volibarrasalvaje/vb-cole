Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A, B, C As Single
        A = InputBox("Ingresar un número.")
        B = InputBox("Ingresar un otro número.")
        C = A + B
        MsgBox("El resultado de la suma es: " & C)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim A, B, C, D As Single
        A = InputBox("Ingresar un número.")
        B = InputBox("Ingresa otro valor numérico.")
        C = InputBox("Ingresar otro valor.")
        D = A - B - C
        MsgBox("El resultado de la resta es: " & D)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim A, B, C, D As Double
        A = InputBox("Ingresar un valor X.")
        B = InputBox("Ingresar un valor Y.")
        C = InputBox("Ingresar un valor Z.")
        D = (A + B + C) / 3
        MsgBox("El promedio es: " & D)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a, b, c As Single
        a = InputBox("Ingresar un número.")
        b = InputBox("Ingresar otro número.")
        c = a * b
        MsgBox("El producto de la multiplicación es: " & c)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim A, B, C As Double
        A = InputBox("Ingresar un número (divisor)")
        B = InputBox("Ingresar un número (dividendo)")
        C = B / A
        MsgBox("El cociente es " & C)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim a, b As Single
        a = InputBox("Ingrear un número A.")
        b = InputBox("Ingresar un número B.")
        If a > b Then
            MsgBox("El mayor es: " & a & " (A)")
        Else
            MsgBox("El mayor es: " & b & " (B)")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim a, b As Single
        a = InputBox("Ingresar un número A.")
        b = InputBox("Ingresar un número B.")
        If a = b Then
            MsgBox("ERROR: A y B no deben ser iguales. Intentelo otra vez.")
        Else
            If a < b Then
                MsgBox("El menor es: " & a & " (A)")
            Else
                MsgBox("El menor es: " & b & " (B)")
            End If
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim a, b, c, d, f As Double
        a = InputBox("Ingresar un número.")
        b = InputBox("Ingresar un número.")
        c = InputBox("Ingresar un número.")
        d = InputBox("Ingresar un número.")
        f = InputBox("Ingresar un número.")
        If b > c Then
            MsgBox("El promedio es: " & ((a + b + c + d + f) / 5))
        Else
            MsgBox("La multiplicación entre ellos es: " & (a * b * c * d * f))
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim a, b, c As Single
        a = InputBox("Ingresar una variable.")
        b = InputBox("Otra más por favor.")
        c = InputBox("Y para finalizar, una 3ra variable")
        If a <= 5 Then
            MsgBox("La suma del 2do y el 3ro es: " & (b + c))
        Else
            MsgBox("La suma del 1ro y el 2do es: " & (a + b))
        End If
    End Sub
End Class
