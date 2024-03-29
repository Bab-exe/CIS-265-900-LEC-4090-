Imports System
Imports System.IO

Module Program

    Sub Main(args As String())

        Dim choice As Integer       'Menu choice from the user
        Dim numChars As Integer     'How many characters the user will provide

        Dim goodInput As Boolean = False    'Keep track if we get bad input or not
        Dim setOption1 As Boolean = False   'Keep track if the user went into menu option 1
        Dim setOption2 As Boolean = False   'Keep track if the user went into menu option 2

        Dim ListOfRogues As New List(Of Rogue)      'List for Rogue class

        Console.WriteLine("===============================")
        Console.WriteLine(" Rogue Character Creation Tool")
        Console.WriteLine("===============================")
        Console.WriteLine()

        'Loop the menu options
        Do
            'Display the menu and get user's choice
            DisplayMenu()
            choice = Console.ReadLine()
            goodInput = BadMenuChoice(choice) 'Determine if we got a bad choice

            If Not goodInput Then
                'If we got bad input, display the error
                ErrorMessage("Enter a valid menu option.")

            ElseIf choice = 4 Then

                Console.WriteLine("Exiting application.")

            ElseIf choice = 1 Then

                setOption1 = True 'Set this flag to true so the user can now access option 2

                numChars = GetNumCharacters() 'Ask the user how many characters and save the value 

                goodInput = False 'Set this to false so our menu loop repeats

            ElseIf choice = 2 Then

                If Not setOption1 Then 'If the user has not yet accessed option 1 display an error
                    ErrorMessage("You must first enter the number of characters.")
                    goodInput = False
                Else
                    setOption2 = True
                    ListOfRogues = SetCharacterData(numChars)
                    goodInput = False 'Set this to false so our menu loop repeats
                End If

            ElseIf choice = 3 Then

                If Not setOption2 Then 'If the user has not yet accessed option 2 display an error
                    ErrorMessage("You must first set character data.")
                    goodInput = False
                Else
                    WriteData(ListOfRogues)
                    goodInput = False 'Set this to false so our menu loop repeats
                End If

            Else
                ErrorMessage("Unexpected value: " & choice.ToString)
            End If

        Loop While Not goodInput 'Continue to run this loop if we do not get good input

    End Sub


    Sub DisplayMenu()
        Console.WriteLine("Select from one of the following options:")
        Console.WriteLine("1. Number of characters")
        Console.WriteLine("2. Set character data")
        Console.WriteLine("3. Write Characters data")
        Console.WriteLine("4. Quit")
        Console.WriteLine()
        Console.Write("Choice: ")
    End Sub


    Function BadMenuChoice(choice As Integer) As Boolean
        'Only options are 1 thru 4
        Return (choice >= 1 AndAlso choice <= 4)
    End Function


    ' Used to display red error messages
    Sub ErrorMessage(msg As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(msg & Environment.NewLine)
        Console.ResetColor()
    End Sub

    'Ask the user for how many characters they want and return the value
    Function GetNumCharacters() As Integer
        Dim numChars As Integer
        Console.WriteLine("How many characters are you creating?")
        Console.Write("Amount: ")
        numChars = Console.ReadLine()
        Console.WriteLine()
        Return numChars
    End Function


    Function SetCharacterData(numChars As Integer) As List(Of Rogue)
        Dim ListOfRogues As New List(Of Rogue)

        'User told us how many characters, so our loop will execute that many times
        For i = 1 To numChars
            Dim newRogue As New Rogue()

            Console.WriteLine(Environment.NewLine & "==================")
            Console.WriteLine(" Character {0} Data", i)
            Console.WriteLine("==================")

            Console.Write("Character Name: ")
            newRogue.Name = Console.ReadLine()

            Console.Write("Hit Points: ")
            newRogue.HitPoints = Console.ReadLine()

            Console.Write("Attack Damage: ")
            newRogue.AttackDamage = Console.ReadLine()

            Console.Write("Attack Range: ")
            newRogue.AttackRange = Console.ReadLine()

            Console.Write("Area of Effect: ")
            newRogue.AreaOfEffect = Console.ReadLine()

            Console.WriteLine()
            ListOfRogues.Add(newRogue)
        Next

        Return ListOfRogues

    End Function



    Sub WriteData(ListOfRogues As List(Of Rogue))

        Dim filePath As String = Environment.CurrentDirectory & "\CharacterData.txt"

        Using writer As New StreamWriter(filePath, False) ' False to overwrite the file
            For Each rogue In ListOfRogues
                writer.WriteLine(rogue.ToString())
                writer.WriteLine()
            Next
        End Using

        Console.WriteLine(Environment.NewLine & "Data has been written to: " & filePath)
        Console.WriteLine()

    End Sub





    ' !!!!!!!!!!!!!!!!!!!!!!!! CLASS DEFINITIONS !!!!!!!!!!!!!!!!!!!!!!!!
    ' !!!!!!!!!!!!!!!!!!!!!!!! CLASS DEFINITIONS !!!!!!!!!!!!!!!!!!!!!!!!
    ' !!!!!!!!!!!!!!!!!!!!!!!! CLASS DEFINITIONS !!!!!!!!!!!!!!!!!!!!!!!!


    Public Class Character

        Private _name As String
        Private _hitPoints As Integer
        Private _attackDamage As Integer
        Public Sub New()

        End Sub

        Public Sub New(name As String, hp As Integer, dmg As Integer)
            _name = name
            _hitPoints = hp
            _attackDamage = dmg
        End Sub

        Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Property HitPoints As Integer
            Get
                Return _hitPoints
            End Get
            Set(value As Integer)
                _hitPoints = value
            End Set
        End Property

        Property AttackDamage As Integer
            Get
                Return _attackDamage
            End Get
            Set(value As Integer)
                _attackDamage = value
            End Set
        End Property

    End Class








    Public Class Rogue

        Inherits Character

        Private _attackRange As Double
        Private _areaOfEffect As Double
        ReadOnly ClassName As String = "Rogue"

        Public Sub New()

        End Sub

        Public Sub New(name As String, hp As Integer, dmg As Integer, rng As Double, aoe As Double)
            MyBase.New(name, hp, dmg)
            _attackRange = rng
            _areaOfEffect = aoe
        End Sub

        Property AttackRange As Double
            Get
                Return _attackRange
            End Get
            Set(value As Double)
                _attackRange = value
            End Set
        End Property

        Property AreaOfEffect As Double
            Get
                Return _areaOfEffect
            End Get
            Set(value As Double)
                _areaOfEffect = value
            End Set
        End Property


        Public Overrides Function ToString() As String
            Return "Name: " & MyBase.Name & Environment.NewLine &
                "Class: " & ClassName & Environment.NewLine &
                "Hit Points: " & MyBase.HitPoints.ToString() & Environment.NewLine &
                "Attack Damage: " & MyBase.AttackDamage.ToString() & Environment.NewLine &
                "Attack Range: " & _attackRange.ToString()
        End Function


    End Class






End Module
