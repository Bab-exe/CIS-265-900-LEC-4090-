'Blessing Abumere
'lab 6 part 2 
Imports System
Imports System.IO

Module Program



    Sub Main(args As String())

        'Quiz 2 Extra Credit:
        Dim dir As String = $"{Environment.CurrentDirectory}\File Dump"
        Console.WriteLine("Directory: " & dir & Environment.NewLine)

        If Directory.Exists(dir) Then
            Console.WriteLine("Directory already exists")
        Else
            Directory.CreateDirectory(dir)
            Console.WriteLine("Created directory")
        End If



        'contents
        Dim str_array As String() = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", Environment.NewLine}
        Dim str As String = "String"


        Const folder = "File Dump\"


        '•	File.WriteAllLines: Writes an array of strings to a file, one line per string.
        Dim file_path = $"{folder}WriteAllLines.txt"
        File.WriteAllLines(file_path, str_array)

        '•	File.WriteAllText Writes a string to a file.
        file_path = $"{folder}WriteAllText.txt"
        File.WriteAllText(file_path, str)


        '•	File.AppendAllLines Appends an array Of strings To a file, one line per string.
        file_path = $"{folder}AppendAllLines.txt"
        File.AppendAllLines(file_path, str_array)


        '•	File.AppendAllText Appends a string to a file.
        file_path = $"{folder}AppendAllText.txt"
        File.AppendAllText(file_path, str)











    End Sub
End Module


