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
        If pg = "efectivo" Then
            c *= 1.2
        End If
        MsgBox("El monto final a pagar, es " & c & ".")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nota, faltas As Single
        nota = InputBox("Ingresar la nota del alumno.")
        faltas = InputBox("Ingresar las faltas del alumno.")
        If nota >= 7 And faltas <= 3 Then
            MsgBox("Aprobo, felicitaciones.")
        Else
            MsgBox("A Diciembre.")
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        MsgBox("cajita invisible")
    End Sub
End Class
