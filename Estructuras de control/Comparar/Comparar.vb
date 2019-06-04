Imports System

Module Program
    '    Crear un proyecto y un módulo “Comparar” para resolver con If: se ingresan dos valores
    'numéricos e informar por pantalla cuál es la relación entre ambos: mayor, menor o igual. 
    Sub Main()

        Dim num1, num2, num3 As Int16

        Console.Write("Ingrese 2 numeros:")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()


        If num1 > num2 Then

            Console.Write("El primer numero ingresado es el mayor")

        ElseIf num1 < num2 Then

            Console.Write("el segundo numero ingresado es el mayor ")

        Else
            Console.Write("los numeros son iguales")

        End If

    End Sub

End Module
