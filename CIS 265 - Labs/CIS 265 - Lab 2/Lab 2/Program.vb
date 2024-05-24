'Blessing Abumere #0780311 : Lab 2
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Part 1 " & vbCrLf)

        Dim length, width, perimeter, area As Double '(2)

        'inputting length & width (3)
        Console.Write("Input Length: ")
        length = Console.ReadLine()

        Console.Write("Input Width: ")
        width = Console.ReadLine()

        'calc perimeter & area (4)'
        perimeter = 2 * (length + width)
        area = (length * width) 'rectangle area'

        'display part1 (5)'
        Console.WriteLine($"{vbCrLf}A rectangle with a Length of {length} and a Width of {width} has a Perimeter of {perimeter} units and an Area of {area} units squared{vbCrLf}")


        Console.WriteLine("Part 2" & vbCrLf)

        Const pi = 3.1415926535897931 '(6)
        Console.WriteLine("pi variable: " & pi) '(7)   3.1415926535897932384626433 gets shortened to 3.1415926535897931 in the source code and the output only shows  3.141592653589793. 

        Const pi1 As Double = 3.1415926535897931, pi2 As Decimal = 3.1415926535897931 '(8)'

        Const radius As Double = 6.56 * 6.56

        '(9)The same answer is not produced probably because the decimal data type probably exists for super exact fractions while the double data type probably exists to deal with big numbers 
        Console.WriteLine($"As Double {{pi1}}: {pi1 * radius}")
        Console.WriteLine($"As Decimal {{pi2}}: {pi2 * radius}")


    End Sub
End Module
