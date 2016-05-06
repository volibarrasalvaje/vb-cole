Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim C, n, P, L, A As Single
        n = InputBox("Ingresar el número de lados del polígono.")
        L = InputBox("Ingresar la longuitud de los lados del polígono.")
        A = InputBox("Ingresar la apotema del polígono.")
        P = n * L
        C = (P * A) / 2
        MsgBox("Área: " & C)
        MsgBox("Perímetro: " & P)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ar, vl, b, h, p, a As Single
        a = InputBox("Ingresar longuitud lado de la base A.")
        b = InputBox("Ingresar longuitud lado de la base B.")
        h = InputBox("Ingresar la altura.")
        ar = a * b
        vl = h * ar
        p = 2 * a + 2 * b
        MsgBox("El área del prisma rectangular es: " & ar)
        MsgBox("El volumen del prisma rectangular es: " & vl)
        MsgBox("El perímetro de la base del prisma rectangular es: " & p)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x, r As Single
        x = InputBox("Ingrese un número entero por favor.")
        r = 3 + x ^ 3
        MsgBox("El resultado es: " & r)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal TTUTUTU As System.EventArgs) Handles Button4.Click
        Dim a, b, s, r, m As Single
        Dim d As Double
        a = InputBox("Ingrear un valor A.")
        b = InputBox("Ingresar un valor B.")
        s = a + b
        r = a - b
        m = a * b
        d = a / b
        MsgBox("Suma: " & s)
        MsgBox("Multiplicación: " & m)
        MsgBox("Resta: " & r)
        MsgBox("División: " & d)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pi As Double
        pi = 4 * System.Math.Atan(1)
    End Sub
End Class
