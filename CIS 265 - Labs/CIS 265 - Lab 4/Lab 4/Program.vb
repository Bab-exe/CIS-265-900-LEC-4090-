'Blessing Abumere
'Lab 4'
Imports System
Imports System.Text.RegularExpressions




Module Program


    Function Input(Question As String) As String
        Dim i As String

        Console.Write(Question)
        i = Console.ReadLine()

        Return i
    End Function

    'part 1'
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

    'part 2 question 5'
    Sub Part_2()

        'question 5'
        Console.WriteLine(Environment.NewLine & "Question 2.5 ")
        Dim user_string As String
        Dim vowels() As Char = {"a", "e", "i", "o", "u"}
        Dim vowels_count, len As Integer

        vowels_count = 0

        'still question 5'
        Do
            user_string = Input("Enter A String that is atleast 20 letters: " & Environment.NewLine)
            len = user_string.Length

            If len < 20 Then
                Console.WriteLine($"What you provided was {len} characters and needs {20 - len} more characters")
            End If

        Loop Until len >= 20


        'question 5 vowel part

        For Each character As Char In user_string
            For Each vowel As Char In vowels
                'converts to lowercase so case doesnt matter
                If Char.ToLower(character).Equals(vowel) Then
                    vowels_count += 1
                End If
            Next
        Next

        Console.WriteLine($"{vowels_count} vowels In '{user_string}'")
    End Sub

    Sub Main(args As String())

        'part 1
        'Part_1()


        'part 2 questions'

        ''question 1'
        'Console.WriteLine(Environment.NewLine & "Question 2.1 ")
        'Dim num4 As Integer = 10
        'Do
        '    Console.WriteLine(num4)
        '    num4 += 1
        'Loop Until (num4 > 20)

        ''question 2'
        'Console.WriteLine(Environment.NewLine & "Question 2.2 ")
        'Dim num5 As Integer = 5
        'Do
        '    If Not num5 Mod 2 = 0 Then
        '        Console.WriteLine(num5)
        '    End If
        '    num5 += 1

        'Loop Until (num5 > 15)

        ''question 3 '
        'Console.WriteLine(Environment.NewLine & "Question 2.3 ")
        'Dim num6 As String = 16

        'Do
        '    Console.WriteLine(num6)
        '    num6 -= 4
        'Loop While (num6 >= 0)


        'Dim int_array(10) As Integer 'question 4'

        'Part_2() 'all question 5 

        'question 6'
        Console.WriteLine(Environment.NewLine & "Question 2.6 ")
        Dim String_array(9) As String 'notetoself: means the highest index is 9. 0-9 are assignable but not 10
        Dim search, within As String
        Dim within_count As Integer = 0

        within = ""

        Console.WriteLine("Provide 10 Strings")
        For i As Integer = 0 To String_array.Length - 1
            String_array(i) = Input($"String {i + 1}: ")
        Next

        search = Input("Provide a string to search the array: ")
        For i = 0 To String_array.Length - 1

            'converts everything to lowercase so case doesnt matter when checking'
            If (search.ToLower().Contains(String_array(i)) > 0) Then
                within_count += 1
                within &= $"{String_array(i)} {Environment.NewLine}"
            End If

        Next

        Console.WriteLine(Environment.NewLine & "Question 2.7 ")
        'question 7'
        If (within_count = 0) Then
            Console.WriteLine($"Did not find '{search}'")
        Else
            Console.WriteLine($"Found '{search}' within {within_count} strings of the array: {Environment.NewLine}{within}")
        End If





    End Sub
End Module
