Imports System

Module Program
    Sub Main(args As String())
        Dim n As UInteger ' Длина забора 
        Dim k As UInteger ' Величина длины расхода банки краски
        Dim c As UInteger ' Цена одной банки краски
        Console.Write("Введите длину забора (в метрах): ")
        UInteger.TryParse(Console.ReadLine(), n)
        Console.Write("На сколько метров хватает банки краски? ")
        UInteger.TryParse(Console.ReadLine(), k)
        Console.Write("Цена одной банки краски (в рублях): ")
        UInteger.TryParse(Console.ReadLine(), c)
        Dim b As UInteger = n \ k + n Mod k ' Количество банок краски на всю длину забора
        Dim p As UInteger = b * c ' Стоимость всех банок краски для всего забора
        ' -- Вывод информации на экран --
        Console.WriteLine($"На {n} метров забора нужно {b} банок(и) краски.")
        Console.WriteLine($"На {b} банок(и) краски надо потратить {p} рублей.")
        Console.Read() ' Нажать клавишу ввод для закрытия окна
    End Sub
End Module
