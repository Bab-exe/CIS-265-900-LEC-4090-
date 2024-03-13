'Blessing Abumere
'Lab 6 part 1 
Imports System
Imports System.IO

Module Program


    Function Random_Character() As Char
        Dim random_object As New Random()



        Dim number As Integer = random_object.Next(65, 90 + 1)

        Return Chr(number)
    End Function

    Sub Main(args As String())


        '1.	Display the current directory the program is executing in.
        Console.Write($"current directory: {Environment.CurrentDirectory}{Environment.NewLine}") ''question 1


        '2.	Use FileStream to create a new file.
        Dim fileName As String = "6.12 test.txt"

        Dim file_object As New FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)


        '3.	Use StreamWriter to write to the new file that was created.'
        fileName = "6.15 random.txt"

        Using write_object As StreamWriter = File.AppendText(fileName)


            '4.	Check if the new file exists already and display whether or not it does.
            If File.Exists(fileName) Then
                Console.Write($"{Environment.NewLine}file: ""{fileName}"" exists{Environment.NewLine}")
            Else
                Console.Write($"{Environment.NewLine}file: ""{fileName}"" did not exist{Environment.NewLine}")
            End If



            '5.	Create a new file and write random characters inside of it on multiple lines.
            write_object.Write(Environment.NewLine)

            For i = 1 To 5
                For j = 1 To 10
                    write_object.Write(Random_Character())
                Next

                write_object.Write(Environment.NewLine)
            Next

        End Using


        '6.	Read in the new file’s contents and store it into (1) a string and (2) an array (each line is an element of the array).
        Dim file_string As String = File.ReadAllText(fileName)

        Dim file_array() As String = File.ReadAllLines(fileName)












        file_object.Close()
    End Sub
End Module
