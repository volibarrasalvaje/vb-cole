Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As Double
        s = InputBox("Ingrese el sueldo del empleado.")
        s *= 1.1
        If s <= 3650.23 Then
            MsgBox("El empleado cobra " & s & " pesos.")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Single
        Dim pg As String
        c = InputBox("Ingrese el monto de la compra.")
        pg = InputBox("Ingrese la forma de pago de la compra.")
        If pg.ToLower() = "efectivo" Then
            c *= 0.8
        End If
        MsgBox("El monto final a pagar, es " & c & ".")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nota, faltas As Single
        nota = InputBox("Ingresar la nota del alumno.")
        faltas = InputBox("Ingresar las faltas del alumno.")
        If nota >= 7 And faltas <= 3 Then
            MsgBox("Aprobo.")
        Else
            MsgBox("Desaprobado. A Diciembre.")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As Double
        f = InputBox("Ingresar el monto de la factura.")
        If f >= 1000 And f <= 2000 Then
            f *= 0.7
        End If
        MsgBox("El importe total de la factura es: " & f)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a, b, c As Double
        a = InputBox("Ingrear la nota del primer trimestre.")
        b = InputBox("Ingrear la nota del segundo trimestre.")
        c = InputBox("Ingrear la nota del tercer trimestre.")
        If (a + b + c) / 3 >= 7 And c >= 6 Then
            MsgBox("Aprobado.")
        Else
            MsgBox("Desaprobado. A Diciembre.")
        End If
    End Sub
End Class
