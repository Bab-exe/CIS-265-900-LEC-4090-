'Blessing ABumere'
'midterm'

Imports System

Module Program
    Sub Main(args As String())

        Dim Devices = New List(Of Device)

        Dim Choice, Order_Amount As Integer
        Console.WriteLine("==== Device Order Page ====")

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(Environment.NewLine & "Please Select A Device To Order")
        Console.ResetColor()

        Console.WriteLine("1. Desktop
2. Laptop
3. Smartphone
4. Tablet
5. Complete Order")


        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.WriteLine("5. Complete Order
")
        Console.ResetColor()

        Console.Write("Choice: ")

        Choice = Console.ReadLine()


        Select Case Choice
            Case 1 'desktop
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("
How Many Desktops would you like to order?")
                Console.Write("Amount: ")

                Order_Amount = Console.ReadLine()

            Case 2 'laptop'
                Console.WriteLine("How Many Laptops would you like to order?")
                Console.Write("Amount: ")
                Order_Amount = Console.ReadLine()

            Case 3 'smartphone'
                Console.WriteLine("How Many Smartphones would you like to order?")
                Console.Write("Amount: ")
                Order_Amount = Console.ReadLine()


            Case Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine($"{Choice} is not a valid choice")
                Console.ResetColor()

        End Select


        Console.WriteLine(Order_Amount)



    End Sub



    Class Generate
        Private Function Device_Data() As Device
            brands


        End Function











    End Class

End Module
