'Blessing Abumere 0780311 Lab 4'
Imports System




Module Program

    Function Input(Question As String) As String
        Dim i As String

        Console.Write(Question)
        i = Console.ReadLine()

        Return i
    End Function

    Sub Part_1()
        Dim Q1 As String = Environment.NewLine & "Part 1 Question 1" & Environment.NewLine
        Dim Q2 As String = Environment.NewLine & "Part 1 Question 2" & Environment.NewLine
        Dim Q3 As String = Environment.NewLine & "Part 1 Question 3" & Environment.NewLine

        'Question 1'
        For i = 0 To 10 Step 2
            Q1 &= i & Environment.NewLine
        Next
        Console.WriteLine(Q1)

        'Question 2'
        For i = 0 To 60 Step 3
            Q2 &= i & Environment.NewLine
        Next
        Console.WriteLine(Q2)

        'Question 3' 
        For i = 10 To 0 Step -1
            Q3 &= i & Environment.NewLine
        Next
        Console.WriteLine(Q3)
    End Sub

    Sub Part_2()

        Dim int_array(10) As Integer 'question 4'


        'question 5'
        Dim user_string As String
        Dim vowels, len As Integer

        Do
            user_string = Input("Enter A String that is atleast 20 letters: " & Environment.NewLine)
            len = user_string.Length

            If len < 20 Then
                Console.WriteLine($"What you provided was {len} characters and needs {20 - len} more characters")
            End If

        Loop Until len >= 20





    End Sub

    Sub Main(args As String())

        'Part_1()

        'Part_2()

        'question 6'
        Dim String_array(10) As String
        Dim search, searched As String
        Dim equal As Boolean

        Console.WriteLine("6. Provide 10 Strings")
        For i As Integer = 0 To 10
            String_array(i) = Input($"String {i}: ")
        Next

        search = Input("Provide a string to search the array: ")
        For i = 0 To String_array.Length - 1
            searched &= $"{String_array(i)} {Environment.NewLine}"

            equal = False
            If String.Compare(search, String_array(i)) = 0 Then
                equal = True
            End If

            If equal Then
                Console.WriteLine($"Found '{search}' within {i} strings of the array: {Environment.NewLine}{searched}")
                Exit For
            End If

            If (i = String_array.Length - 1 And Not equal) Then
                Console.WriteLine($"Did not find '{search}'")

            End If

        Next






    End Sub
End Module
