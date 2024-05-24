'blessing abumere '
'cis 265 lab 5 part 1 

Imports System


Module Program

    Function random_index(lowest As Integer, biggest As Integer) As Integer

        Randomize()

        biggest -= 1


        Return ((biggest * Rnd()) + lowest)
    End Function
    'question 1 
    Function MaxOf(a As Integer, b As Integer) As Integer
        If a > b Then
            Return a
        End If

        Return b

    End Function

    'question 2
    Sub String_In(parent As String, child As String)
        If parent.Contains(child) Then
            Console.WriteLine($"'{child} was found in '{parent}'")
        Else
            Console.WriteLine($"'{child}' is not in '{parent}")
        End If

    End Sub



    Function Input_Car() As Car
        Dim make, model As String
        Dim year As Integer

        Console.WriteLine("Enter Maker:")
        make = Console.ReadLine()

        Console.WriteLine("Enter Model:")
        model = Console.ReadLine()

        Console.WriteLine("Enter Year:")
        year = Console.ReadLine()

        Return New Car(make, model, Year)
    End Function

    Sub Main(args As String())

        'question 4 
        Dim Cars As New List(Of Car)
        Dim display As String = $"Car Information: {Environment.NewLine}"

        'question 4 and 5 if user input;
        'question 4 doesnt ask for a prompt so commented out, True question 4 is from line 77

        'For i As Integer = 1 To 3

        '    Cars.Add(Input_Car())
        '    Console.WriteLine()

        '    display &= Cars(i - 1).toString() & Environment.NewLine

        'Next

        'Console.WriteLine(display)


        'True question 4 and 5 
        Dim Cars2 As New List(Of Car)

        Dim maker_list As String() = {"Toyota", "Peugeot", "Chevy", "Doge", "BMW", "Koenisegg", "Nissan"}
        Dim model_list As String() = {"Camry", "Corolla", "Altima", "Rogue", "Malibu", "Highlander", "eq", "concept car", "airbus", "limo", "tank", "Jesko", "Agera"}


        Dim loop_limit = 3
        For i As Integer = 1 To loop_limit

            Dim maker = maker_list(random_index(0, maker_list.Length))
            Dim model = model_list(random_index(0, model_list.Length))
            Dim year = 1980 + random_index(0, 44) 'big numbers dont work right for a math reason probably'

            'question 4
            Cars2.Add(New Car(maker, model, year))

            'question 5
            Console.WriteLine(Cars2(i - 1).toString())

        Next

    End Sub
End Module
