Imports System

Module Program
    Sub Main()
        Dim x As Byte

        Console.Write("ingrese un angulo: ")
        x = Console.ReadLine

        Select Case x
            Case < 90
                Console.Write("el angulo es agudo")
            Case = 90
                Console.Write("el angulo es recto")

            Case > 90 And x < 180
                Console.Write("el angulo es obtuso")
            Case = 180
                Console.Write("el angulo es llano")

            Case > 180 And x < 360
                Console.Write("el angulo es concavo")

            Case < 0 And x > 360
                Console.Write("ERROR ")

            Case Else

        End Select















    End Sub
End Module
