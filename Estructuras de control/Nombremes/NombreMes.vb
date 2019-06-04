Imports System
'Crear un proyecto y un módulo “NombreMes” para resolver con Case. Crear una
'enumeración para los meses del año. Ingresar un valor numérico y mostrar a que mes
'corresponde.Si el valor es inválido mostrar el mensaje correspondiente.
Enum meses
    enero = 1
    febrero
    marzo
    abril
    mayo
    junio
    julio
    agosto
    septiembre
    octubre
    noviembre
    diciembre

End Enum
Module Program
    Sub Main()
        Dim x As meses
        Console.Write("ingrese un numer: ")


        x = Console.ReadLine

        Select Case x

            Case 1
                Console.Write("el mes es enero")
            Case 2
                Console.Write("el mes es feb")
            Case 3
                Console.Write("el mes es marz")
            Case 4
                Console.Write("el mes es abr")
            Case 5
                Console.Write("el mes es may")
            Case 6
                Console.Write("el mes es jun")
            Case 7
                Console.Write("el mes es jul")
            Case 8
                Console.Write("el mes es agos")
            Case 9
                Console.Write("el mes es sept")
            Case 10
                Console.Write("el mes es oct")
            Case 11
                Console.Write("el mes es noviembre")
            Case 12
                Console.Write("el mes es diciembre")

        End Select




    End Sub
End Module
