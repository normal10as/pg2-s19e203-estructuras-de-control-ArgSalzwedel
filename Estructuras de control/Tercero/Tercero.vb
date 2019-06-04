Imports System
'.Crear un proyecto y un módulo “Tercero” para resolver con IF: ingresar 5 valores enteros e
'informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
'valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.
Module Program
    Sub Main()
        Dim num1, num2, num3, num4, num5 As Int16

        Console.WriteLine("ingrese 5 numeros: ")
        num1 = Console.ReadLine
        num2 = Console.ReadLine
        num3 = Console.ReadLine
        num4 = Console.ReadLine
        num5 = Console.ReadLine

        If num1 > num2 Then
            Console.Write("el primer numero ingresado es el mayor: " & num1)

        ElseIf num2 > num1 And num2 > num3 Then
            Console.Write("el segundo numero ingresado es el mayor: " & num2)

        ElseIf num3 > num4 And num3 > num1 And num3 > num2 Then
            Console.Write("el tercer numero ingresado es el mayor: " & num3)

        ElseIf num4 > num3 And num4 > num2 And num4 > num1 Then
            Console.Write("el cuarto numero ingresado es el mayor: " & num4)

        ElseIf num5 > num4 And num5 > num3 And num5 > num2 And num5 > num1 Then

            Console.Write("el quinto valor ingresado es el mayor: " & num5)

        End If

    End Sub
End Module
