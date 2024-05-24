Imports System

Module Program

    Function Input(Question As String) As Double
        Dim i As Double

        Console.Write(Question)
        i = Console.ReadLine()

        Return i

    End Function


    Sub Part_1()

        Const BASE_AGE = 18, BASE_HEIGHT = 70, BASE_WEIGHT = 180
        Dim age As Integer
        Dim weight, height As Double

        age = Input("Age: ")
        height = Input("Height: ")
        weight = Input("Weight: ")

        'age less than 18 || height less than 70 inches ||  weight less than 180 ' 
        If ((age < BASE_AGE) Or (weight < BASE_WEIGHT) Or (height < BASE_HEIGHT)) Then

            'issue message
            Dim message As String = Environment.NewLine
            message &= $"You cannot play football{Environment.NewLine}"

            If (age < BASE_AGE) Then
                message &= $"You are too young by {BASE_AGE - age} years(s). {Environment.NewLine}"
            End If

            If (height < BASE_HEIGHT) Then
                message &= $"You are too short by {BASE_HEIGHT - height} inch(es). {Environment.NewLine}"
            End If

            If (weight < BASE_WEIGHT) Then
                message &= $"You are underweight by {BASE_WEIGHT - weight} pounds(s). {Environment.NewLine}"
            End If

            Console.WriteLine(message)
            Return
        End If

        Console.WriteLine("You can play football")

    End Sub

    Sub Part_2()
        Dim taxed, tax_rate, tip, meal_cost As Double
        Dim sub_total, total As Double
        Dim Output As String = Environment.NewLine

        Const VIRGINIA = 5.3 / 100, MARYLAND = 6 / 100, DC = 10 / 100

        meal_cost = Input("Meal Cost: ").ToString("C")

        Output &= $"Meal Cost: ${meal_cost} {Environment.NewLine}" 'meal cost added to string output'


        Console.WriteLine(Environment.NewLine & "Choose The Tax Rate")
        Console.WriteLine($"1. Virginia: {VIRGINIA * 100}%")
        Console.WriteLine($"2. Maryland: {MARYLAND * 100}%")
        Console.WriteLine($"3. District Of Columbia: {DC * 100}%")

        Select Case Input("Choice: ") 'tax rate 
            Case 1
                tax_rate = VIRGINIA
            Case 2
                tax_rate = MARYLAND
            Case 3
                tax_rate = DC
            Case Else
                Console.WriteLine("Not A Choice")
                Return
        End Select


        Console.WriteLine($"{Environment.NewLine}How Good Was Your Service?: 
1. Excellent Service (20% tip)
2. Good Service (15% tip)
3. Average Service (10% tip)
4. Poor Service (0% tip)"
)
        Select Case Input("Choice: ") 'tip rate 
            Case 1
                tip = 0.2
            Case 2
                tip = 0.15
            Case 3
                tip = 0.1
            Case 4
                tip = 0
            Case Else
                Console.WriteLine("Not A Choice")
                Return
        End Select

        'calc
        taxed = meal_cost * tax_rate 'taxed amount


        'the one that depends on DC; when dc tip isnt calculated with the taxes 
        If (tax_rate = DC) Then
            tip = meal_cost * tip 'tip amount without taxes
        Else
            tip = (meal_cost + taxed) * tip 'tip amount with taxes'
        End If


        sub_total = meal_cost + taxed 'the one that doesnt include tip
        total = sub_total + tip 'everything'

        'put everything in output string'
        Output &= $"Subtotal: {sub_total.ToString("C")} {Environment.NewLine}"
        Output &= "Tip Amt: " & tip.ToString("C") & Environment.NewLine
        Output &= "Grand Total: " & total.ToString("C") & Environment.NewLine

        Console.WriteLine(Output)
    End Sub

    Sub Main(args As String())
        'Part 1 '
        Part_1()


        Console.WriteLine("Part 2 ")
        'Part 2 
        Part_2()








    End Sub
End Module
