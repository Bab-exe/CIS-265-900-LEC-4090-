'Blessing ABumere'
'CIS 265 midterm'

Imports System.IO

Module Program
    'for some level of customization

    'filepath + filename for each
    Structure FilePath
        'folder name
        Const folder = "Device Order Files" & "\" 'folder name + \


        'folder + filename = filepath for each
        Const Desktop = folder & "Desktop Orders.txt"
        Const Laptop = folder & "Laptop Orders.txt"
        Const SmartPhone = folder & "SmartPhone Orders.txt"
        Const Tablet = folder & "Tablet Orders.txt"

        Const Totals As String = folder & "Totals Receipt.txt"

    End Structure

    'Pricing
    '5.	Desktops cost $2000. Laptops cost $800. Smartphones cost $600. Tablets cost $450. 
    Enum Price
        Desktop = 2000
        Laptop = 800

        Smartphone = 600
        Tablet = 450
    End Enum


    Sub Main(args As String())
        Dim random As New Generate() 'generate random objects

        Dim Device_List As New List(Of Device) 'question 7

        Dim Laptop_Count = 0, Desktop_Count = 0, Smartphone_Count = 0, Tablet_Count = 0 'for counts and calculating grand total
        Dim Desktop_Receipt, Laptop_Receipt, Smartphone_Receipt, Tablet_Receipt As New List(Of String) 'for file writing

        Dim Choice, Order_Amount As Integer 'for choices

        'directory 
        Dim dir As String = Environment.CurrentDirectory & "\" & FilePath.folder

        'to Delete all the files for new data
        If Directory.Exists(dir) Then
            Directory.Delete(dir, True)
            Directory.CreateDirectory(dir)


        Else

            Directory.CreateDirectory(dir)
        End If




        Console.WriteLine(
            "
====================================
          Device Order Page
====================================
")


        'User Input question 4 -  10
        Do Until (Choice = 5) 'until complete order

            Console.ForegroundColor = ConsoleColor.DarkYellow

            Console.WriteLine(Environment.NewLine)
            Console.Write("Please Select A Device To Order")

            Console.ResetColor()

            Console.WriteLine("
        1. Desktop
        2. Laptop
        3. Smartphone
        4. Tablet
        5. Complete Order
")
            Console.Write("Choice: ")
            Console.Title = "Select Device"

            Choice = Console.ReadLine()
            Console.WriteLine()

            Console.ForegroundColor = ConsoleColor.Cyan


            'determines message and sets choice to price

            Select Case Choice

                Case 1  'desktop
                    Choice = Price.Desktop
                    Console.WriteLine("How Many Desktops would you like to order?")
                    Console.Title = "Desktop Amount"

                Case 2 'laptop'
                    Choice = Price.Laptop
                    Console.WriteLine("How Many Laptops would you like to order?")
                    Console.Title = "Laptop Amount"


                Case 3 'smartphone'
                    Choice = Price.Smartphone
                    Console.WriteLine("How Many Smartphones would you like to order?")
                    Console.Title = "Smartphone Amount"

                Case 4 'tablet'
                    Choice = Price.Tablet
                    Console.WriteLine("How Many Tablets would you like to order?")
                    Console.Title = "Tablet Amount"


                Case 5 'Complete Order' ends loop runs 1x


                    'sub totals are the amount of it multiplied by the set price
                    Dim Desktop_Subtotal = (Desktop_Count * Price.Desktop)
                    Dim Laptop_Subtotal = (Laptop_Count * Price.Laptop)
                    Dim Smartphone_Subtotal = (Smartphone_Count * Price.Smartphone)
                    Dim Tablet_Subtotal = (Tablet_Count * Price.Tablet)

                    'grand total calc
                    Dim Grand_Total As Decimal = Desktop_Subtotal + Laptop_Subtotal + Smartphone_Subtotal + Tablet_Subtotal



                    'create totals string
                    Dim Totals As String = $"
Desktops: {Desktop_Count}  ({Desktop_Subtotal:c})
Laptops: {Laptop_Count}  ({Laptop_Subtotal:c})
Smartphones: {Smartphone_Count}  ({Smartphone_Subtotal:c})
Tablets: {Tablet_Count}  ({Tablet_Subtotal:c})

Grand Total: {Grand_Total:c}
                    "

                    'Write to totals receipt

                    File.WriteAllText(FilePath.Totals, Totals)

                    Console.ForegroundColor = ConsoleColor.Green

                    Console.WriteLine("Your Order has been completed. Your grand total Is " & Grand_Total.ToString("C"))

                    'write to desktop receipt
                    Desktop_Receipt.Add($"
Amount: {Desktop_Count}
Subtotal: {Desktop_Subtotal.ToString("C")}")
                    File.AppendAllLines(FilePath.Desktop, Desktop_Receipt)

                    'write to laptop receipt
                    Laptop_Receipt.Add($"
Amount: {Laptop_Count}
Subtotal: {Laptop_Subtotal.ToString("C")}")
                    File.AppendAllLines(FilePath.Laptop, Laptop_Receipt)

                    'write to smartphone receipt
                    Smartphone_Receipt.Add($"
Amount: {Smartphone_Count}
Subtotal: {Smartphone_Subtotal.ToString("C")}")
                    File.AppendAllLines(FilePath.SmartPhone, Smartphone_Receipt)

                    'write to tablet receipt
                    Tablet_Receipt.Add($"
Amount: {Tablet_Count}
Subtotal: {Tablet_Subtotal.ToString("C")}")
                    File.AppendAllLines(FilePath.Tablet, Tablet_Receipt)

                    Console.Title = "Finished"
                    Console.ResetColor()

                    Exit Do

                Case Else 'invalid
                    Console.ForegroundColor = ConsoleColor.Red

                    Console.WriteLine($"{Choice}? Invalid Choice. Please Try Again")

                    Console.ResetColor()
                    Continue Do
            End Select

            'order amount
            Console.WriteLine()
            Console.Write("Amount: ")


            Order_Amount = Console.ReadLine()

            Dim obj As Device

            'counts and adding to the main list 
            For i = 1 To Order_Amount
                Select Case Choice 'add to list and receipt
                    Case Price.Desktop
                        obj = random.Desktop_Object 'object

                        Device_List.Add(obj)
                        Desktop_Receipt.Add(obj.ToString & Environment.NewLine)

                        Desktop_Count += 1

                    Case Price.Laptop

                        obj = random.Laptop_Object 'object

                        Device_List.Add(obj)
                        Laptop_Receipt.Add(obj.ToString & Environment.NewLine)

                        Laptop_Count += 1

                    Case Price.Smartphone
                        obj = random.SmartPhone_Object 'object

                        Device_List.Add(obj)

                        Smartphone_Receipt.Add(obj.ToString & Environment.NewLine)

                        Smartphone_Count += 1

                    Case Price.Tablet
                        obj = random.Tablet_Object 'object



                        Device_List.Add(obj)
                        Tablet_Receipt.Add(obj.ToString & Environment.NewLine)

                        Tablet_Count += 1

                    Case Else 'it should always be one of the above values. if its not there is a programming problem
                        Throw New Exception("Variable Error: This Should never happen Check var")
                End Select


            Next


        Loop



        ''for testing
        'Test_Output(Desktop_Receipt, Laptop_Receipt, Smartphone_Receipt, Tablet_Receipt, Grand_Total)



    End Sub

    'for testing
    Sub Test_Output(Desktop_Receipt As List(Of String), Laptop_Receipt As List(Of String), Smartphone_Receipt As List(Of String), Tablet_Receipt As List(Of String), Grand_Total As Double)
        Console.ReadLine()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green

        Console.Write("Per Desktop: $" & Price.Desktop)
        Console.WriteLine(Desktop_Receipt.Last & Environment.NewLine)

        Console.Write("Per Laptop: $" & Price.Laptop)
        Console.WriteLine(Laptop_Receipt.Last & Environment.NewLine)

        Console.Write("Per Smartphone: $" & Price.Smartphone)
        Console.WriteLine(Smartphone_Receipt.Last & Environment.NewLine)

        Console.Write("Per Tablet: $" & Price.Tablet)
        Console.WriteLine(Tablet_Receipt.Last & Environment.NewLine & Environment.NewLine)

        Console.ResetColor()

        Console.WriteLine("Grand Total: " & Grand_Total.ToString("C"))


    End Sub


    'for the random part
    Module Generate
        Private ReadOnly random As New Random()

        'Device Properties that arent dependent on type ; Brand and OS cant be here
        Public ReadOnly Property Model As String

            Get
                Dim _model As String = ""

                '14.	Model numbers (Device Model, Monitor, Keyboard, Mouse) consist of 18 random characters, consisting only of A-Z and 0-9 characters.

                For i = 1 To 18

                    'uses character when its 1 and number when its 0
                    If (random.Next(0, 1 + 1) = 1) Then
                        _model &= Chr(random.Next(65, 90 + 1))
                    Else
                        _model &= random.Next(0, 9 + 1)
                    End If

                Next

                Return _model
            End Get
        End Property
        Public ReadOnly Property IP_Address As String
            Get

                '12.	IP Addresses will be randomly generated and have the form of ###.###.###.### where ### represents a number 0 to 255 inclusive. So, generate 4 random numbers and concatenate them with 3 periods.

                Return $"{random.Next(0, 255 + 1)}.{random.Next(0, 255 + 1)}.{random.Next(0, 255 + 1)}.{random.Next(0, 255 + 1)}"


            End Get
        End Property
        Public ReadOnly Property MAC_Address As String
            Get
                Dim Mac As String = ""
                Dim generated_number As UShort
                'mac address
                '13.	MAC addresses consist of 6 sets of two-digit hexadecimal numbers separated by colons. The digits of hexadecimal numbers can include A through F. For example: 00:1A:3F:F1:4C:C6
                '10=A, 11=B, 12=C, 13=D, 14=E, 15=F
                'So, Generate random numbers 0 through 15. If the number comes out To be 10, concatenate an A instead. If the number comes out As 13, concatenate a D instead. Etc.

                'mac address
                For i = 1 To 6
                    generated_number = random.Next(0, 15 + 1)

                    Select Case generated_number
                        Case 10
                            Mac &= "A"

                        Case 11
                            Mac &= "B"

                        Case 12
                            Mac &= "C"

                        Case 13
                            Mac &= "D"

                        Case 14
                            Mac &= "E"

                        Case 15
                            Mac &= "F"

                        Case Else
                            Mac &= generated_number
                    End Select

                    Mac &= random.Next(0, 9 + 1)

                    'no colon at the end
                    If i <> 6 Then
                        Mac &= ":"

                    End If


                Next

                Return Mac
            End Get
        End Property


        'Computer Specific
        'computer is just device + isp
        Public ReadOnly Property Computer_Object As Device.Computer
            Get
                'brands: Acer, Dell, HP, Apple
                Dim Brand_List() As String = {"Acer", "Dell", "HP", "Apple"}
                Dim Brand = Brand_List(random.Next(0, Brand_List.Length))

                'os:Windows, Linux, Unix, macOS
                Dim OS_List() As String = {"Windows", "Linux", "Unix", "macOS"}
                Dim OS = OS_List(random.Next(0, OS_List.Length))

                Return New Device.Computer(Brand, Model, OS, IP_Address, MAC_Address, ISP)
            End Get
        End Property

        Public ReadOnly Property ISP As String
            Get
                'ISP: Comcast, Verizon'
                Dim ISP_List() As String = {"Comcast", "Verizon"}

                Return ISP_List(random.Next(0, ISP_List.Length))

            End Get
        End Property

        'Laptop Specific
        'laptop is computer + screen size + touch screen
        Public ReadOnly Property Laptop_Object As Device.Computer.Laptop
            Get
                Return New Device.Computer.Laptop(Computer_Object, MyClass.ScreenSize, MyClass.TouchScreen)
            End Get
        End Property

        Public ReadOnly Property ScreenSize As Double
            Get
                Dim _whole As Double = random.Next(11, 17 + 1)

                Dim _decimal As Double = random.NextDouble()
                Return Math.Round(_whole + _decimal, 1)
            End Get
        End Property
        Public ReadOnly Property TouchScreen As Boolean
            Get
                Return random.Next(0, 1 + 1)
            End Get
        End Property

        'Desktop Specific
        'desktop is computer + monitor + keyboard + mouse
        Public ReadOnly Property Desktop_Object As Device.Computer.Desktop
            Get
                Dim Monitor = Me.Model
                Dim Keyboard = Me.Model
                Dim Mouse = Me.Model
                Return New Device.Computer.Desktop(Computer_Object, Monitor, Keyboard, Mouse)
            End Get
        End Property


        'Mobile Specific
        'mobile is device + wireless + cellnetwork
        Public ReadOnly Property Mobile_Object As Device.Mobile
            Get
                'brands :Samsung, Apple, Motorola, Google
                Dim Brand_List() As String = {"Samsung", "Apple", "Motorola", "Google"}
                Dim Brand = Brand_List(random.Next(0, Brand_List.Length))

                'os: Android, iOS
                Dim OS_List() As String = {"Android", "iOS"}
                Dim OS = OS_List(random.Next(0, OS_List.Length))

                Return New Device.Mobile(Brand, WirelessProvider, CellNetwork, IP_Address, MAC_Address, WirelessProvider, CellNetwork)
            End Get
        End Property
        Public ReadOnly Property WirelessProvider As String
            Get
                'Wireless Providers: T-Mobile, Verizon, AT&T
                Dim Wireless_List() As String = {"T-Mobile", "Verizon", "AT&T"}

                Return Wireless_List(random.Next(0, Wireless_List.Length))

            End Get
        End Property
        Public ReadOnly Property CellNetwork As String
            Get
                'Cell Networks: 4G(LTE), 5G
                Dim Cell_List() As String = {"4G(LTE)", "5G"}

                Return Cell_List(random.Next(0, Cell_List.Length))

            End Get
        End Property

        'smartphone specific' mobile + Phone number
        Public ReadOnly Property SmartPhone_Object As Device.Mobile.SmartPhone
            Get
                Return New Device.Mobile.SmartPhone(Mobile_Object, MyClass.PhoneNumber)
            End Get
        End Property

        Public ReadOnly Property PhoneNumber As String
            Get
                Dim number As String = ""

                '444-444-4444

                For i = 1 To 2
                    number &= random.Next(100, 999 + 1) & "-"
                Next

                number &= random.Next(1000, 9999 + 1)

                Return number
            End Get
        End Property

        'tablet specific' mobile + voipapp
        Public ReadOnly Property Tablet_Object As Device.Mobile.Tablet
            Get
                Return New Device.Mobile.Tablet(Mobile_Object, MyClass.VOIPApp)
            End Get
        End Property

        Public ReadOnly Property VOIPApp As String
            Get
                'VoIP Apps: Google Voice, Skype, WhatsApp, Zoom
                Dim VoIP_List() As String = {"Google Voice", "Skype", "WhatsApp", " Zoom"}

                Return VoIP_List(random.Next(0, VoIP_List.Length))

            End Get
        End Property
        End Class


    End Module
