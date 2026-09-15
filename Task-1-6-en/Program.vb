Imports System

Module Program
    Sub Main(args As String())
        Dim n As UInteger ' Fence length
        Dim k As UInteger ' Paint consumption rate
        Dim c As UInteger ' Cost of one can of paint
        Console.Write("Enter fence length (in meters): ")
        UInteger.TryParse(Console.ReadLine(), n)
        Console.Write("How many meters does a can of paint last for? ")
        UInteger.TryParse(Console.ReadLine(), k)
        Console.Write("Price of one can of paint (in rubles): ")
        UInteger.TryParse(Console.ReadLine(), c)
        Dim b As UInteger = Math.Ceiling(n / k) ' Number Of cans Of paint For the entire length Of the fence
        Dim p As UInteger = b * c ' Cost Of all cans Of paint For the entire fence
        ' -- Display information on the screen --
        Console.WriteLine($"{b} cans of paint are needed for {n} meters of fence.")
        Console.WriteLine($"{p} rubles are needed for {b} cans of paint.")
        Console.Read() ' Press key "Enter" to close window
    End Sub
End Module
