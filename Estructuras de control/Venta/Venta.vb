Imports System
'Crear un proyecto y un módulo “Venta” para resolver con If: ingresar dos valores
'relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'es 251 o más el descuento es del 20%. Informar subtotal (cantidad por precio unitario),
'porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto
'descontado).

Module Program
    Sub Main()

        Dim cantproductos, precio As Int16
        Dim subtotal, preciocantidad, montodescontado As Single

        Console.Write("Ingrese cantidad de productos: ")
        cantproductos = Console.ReadLine

        Console.Write("Ingrese el precio de productos: ")
        precio = Console.ReadLine

        If cantproductos < 50 Then

            Console.WriteLine("el descuento aplicado es del 5% ")
            subtotal = cantproductos * precio
            preciocantidad = subtotal * 5 / 100

        ElseIf cantproductos >= 50 And cantproductos < 250 Then

            Console.WriteLine("el descuento aplicado es del 10% ")
            subtotal = cantproductos * precio
            preciocantidad = subtotal * 10 / 100

        ElseIf cantproductos >= 251 Then

            Console.WriteLine("el descuento aplicado es del 20% ")
            subtotal = cantproductos * precio
            preciocantidad = subtotal * 20 / 100

        End If


        montodescontado =preciocantidad -subtotal 

        Console.Write("subtotal: " & subtotal)
        Console.WriteLine()
        Console.Write("monto descontado: " & montodescontado)

    End Sub
End Module
