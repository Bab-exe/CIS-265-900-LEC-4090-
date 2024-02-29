Imports System
'Blessing Abumere
'CIS 265 Lab 5 part 2' 

Module Program

    'question 3?'
    Public Function Input_Student() As Student
        Dim first_name, last_name As String
        Dim birthday As DateTime

        Dim homeroom As Integer
        Dim grade As String
        Dim gpa As Double
        Dim graduation As DateTime

        Console.WriteLine("Enter the student's first name: ")
        first_name = Console.ReadLine()

        Console.WriteLine("Enter the student's last name: ")
        last_name = Console.ReadLine()

        Console.WriteLine("Enter the student's birthday: ")
        birthday = Console.ReadLine()

        Console.WriteLine("Enter the student's homeroom number: ")
        homeroom = Console.ReadLine()

        Console.WriteLine("Enter the student's grade year: ")
        grade = Console.ReadLine()

        Console.WriteLine("Enter the student's gpa: ")
        gpa = Console.ReadLine()

        Console.WriteLine("Enter the student's graduation day: ")
        graduation = Console.ReadLine()

        Return New Student(first_name, last_name, birthday, homeroom, grade, gpa, graduation)
    End Function


    'question 4 '
    Public Sub GPA_Filter(Students As List(Of Student), Optional Filter As Double = 3.0)
        Dim output As String = ""

        For Each student In Students
            If student.GPA() >= Filter Then
                output &= $"{student.ToString()} {Environment.NewLine}"
            End If
        Next

        If output.Equals("") Then
            output = "None"
        End If

        Console.WriteLine($"{Environment.NewLine}Students with GPA's greater than or equal to {Filter}: {Environment.NewLine}{output}")

    End Sub

    Sub Main(args As String())

        Dim Students As New List(Of Student)

        'Dim test = New Student("first", "last", "2/28/2024", 203, "Year 2", 3, "6/2/2024")
        'question 3'
        For i As Integer = 1 To 5
            Students.Add(Input_Student())
            Console.WriteLine()
        Next

        'question 4'
        GPA_Filter(Students)



    End Sub
End Module
