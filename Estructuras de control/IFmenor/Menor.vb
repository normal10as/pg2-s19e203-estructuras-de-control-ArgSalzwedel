Imports System
'Crear un proyecto y un módulo “Menor” para resolver con If: ingresar tres valores y mostrar
'el menor.
Module Program
    Sub Main(args As String())
        Dim num1, num2, num3 As Int16

        Console.WriteLine("ingrese 3 numeros:")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()
        num3 = Console.ReadLine()

        If num1 < num2 And num1 < num3 Then
            Console.Write("el menor es: " & num1)

        ElseIf num2 < num1 And num2 < num3 Then
            Console.Write("el menor es:" & num2)


        Else
            Console.Write("el menor es: " & num3)
        End If



    End Sub
End Module
