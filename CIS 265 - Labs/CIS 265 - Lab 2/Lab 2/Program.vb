Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Part 1 ")

        Dim length, width, perimeter, area As Double

        Console.Write("Input Length: ")
        length = Console.ReadLine()

        Console.Write("Input Width: ")
        width = Console.ReadLine()


        'calc'
        perimeter = 2 * (length + width)
        area = (length * width) 'rectangle area'

        'display part1'
        Console.WriteLine($"{vbCrLf}A rectangle with a Length of {length} and a Width of {width} has a Perimeter of {perimeter} units and an Area of {area} units squared{vbCrLf}")


        Console.WriteLine("Part 2")


        Const pi As Double = 3.1415926535897931 '(7)   3.1415926535897932384626433 gets shortened to 3.1415926535897931 in the source code and the output 

        Const pi1 As Double = 3.1415926535897931, pi2 As Decimal = 3.1415926535897931 '(8)'


        '(9)The same answer is not produced probably because the decimal data type probably exists for super exact fractions while the double data type probably exists to deal with big numbers 
        Console.WriteLine($"Double: {pi1 * (6.56 * 6.56)} {vbCrLf}Decimal: {pi2 * (6.56 * 6.56)}")


    End Sub
End Module
