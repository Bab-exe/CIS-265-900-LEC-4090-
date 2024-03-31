'1.	For this project you will need to create seven classes. Add these classes as separate files within your project (do Not put them in the same VB file as your main subprocedure)
'a)	The parent class Is called Device And has the following fields: Brand(Of String), Model (String), Operating System (String), IP Address, And MAC address (String).
'b)	Computer will have one additional field: ISP(Of String) which represents the internet service provider.
'c)	Mobile will have two additional fields: WirelessProvider(Of String) And CellNetwork (String).
'd)	The two child classes of Computer are Desktop And Laptop.
'e)	Desktop has the following fields: Monitor(String), Keyboard (String), And Mouse (String). These strings will represent the part numbers Of Each peripheral.
'f)	Laptop has the following fields: Screen Size(Double) And Touch Screen (Boolean).
'g)	The two child classes of Mobile are SmartPhone And Tablet.
'h)	SmartPhone will have a field named PhoneNumber (string).
'i)	Tablet will have a field named VoIPApp (string)



Public Class Device
    'a)	The parent class is called Device and has the following fields: Brand (string), Model (string), Operating System (string), IP Address, and MAC address (string).
    Private ReadOnly Brand, Model, OS, IP_Address, MAC_Address As String

    'nest = no getters and setters 

    Sub New()
    End Sub

    Sub New(__brand As String, __model As String, __os As String, __ip As String, __mac As String)
        Brand = __brand
        Model = __model
        OS = __os
        IP_Address = __ip
        MAC_Address = __mac
    End Sub

    Public Overrides Function ToString() As String

        Return $"Brand: {Brand}
Model: {Model} 
Operating System: {OS}
IP Address: {IP_Address}
MAC Address: {MAC_Address}"
    End Function



    'Device.Computer
    'b)	Computer will have one additional field: ISP (string) which represents the internet service provider.
    Public Class Computer
        Inherits Device 'for some reason nesting doesnt do this by default

        Private ReadOnly ISP As String

        Sub New(_brand As String, _model As String, _os As String, _ip As String, _mac As String, __isp As String)
            MyBase.New(_brand, _model, _os, _ip, _mac) 'Device

            ISP = __isp
        End Sub

        'same as above but with device parameter
        Sub New(_Device As Device, __isp As String)
            MyClass.New(_Device.Brand, _Device.Model, _Device.OS, _Device.IP_Address, _Device.MAC_Address, __isp)

        End Sub

        Sub New()
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}
ISP: {ISP}"

        End Function

        'd)	The two child classes of Computer are Desktop and Laptop.

        'Device.Computer.Desktop'
        'e)	Desktop has the following fields: Monitor (string), Keyboard (string), and Mouse (string). 
        Public Class Desktop
            Inherits Computer

            Private ReadOnly Monitor, Keyboard, Mouse As String

            Sub New()
            End Sub

            Sub New(_brand As String, _model As String, _os As String, _ip As String, _mac As String, _isp As String, _monitor As String, _keyboard As String, _mouse As String)
                MyBase.New(_brand, _model, _os, _ip, _mac, _isp) 'computer

                Monitor = _monitor
                Keyboard = _keyboard
                Mouse = _mouse

            End Sub

            'same as above but computer param
            Sub New(Computer As Computer, _monitor As String, _keyboard As String, _mouse As String)

                MyClass.New(Computer.Brand, Computer.Model, Computer.OS, Computer.IP_Address, Computer.MAC_Address, Computer.ISP, _monitor, _keyboard, _mouse)
            End Sub


            Public Overrides Function toString() As String
                Return $"{MyBase.ToString()}
Monitor: {Monitor}
Keyboard: {Keyboard}
Mouse: {Mouse}"
            End Function

        End Class




        'Device.Computer.Laptop
        Public Class Laptop
            Inherits Computer

            Private ReadOnly ScreenSize As Double
            Private ReadOnly TouchScreen As Boolean

            Sub New()
            End Sub

            Sub New(_brand As String, _model As String, _os As String, _ip As String, _mac As String, __isp As String, _screensize As Double, _touchscreen As Boolean)

                MyBase.New(_brand, _model, _os, _ip, _mac, __isp) 'Device.Computer

                ScreenSize = _screensize
                TouchScreen = _touchscreen

            End Sub

            'same as above but computer param
            Sub New(Computer As Computer, _screenSize As Double, _touchScreen As Boolean)

                MyClass.New(Computer.Brand, Computer.Model, Computer.OS, Computer.IP_Address, Computer.MAC_Address, Computer.ISP, _screenSize, _touchScreen)
            End Sub


            Public Overrides Function ToString() As String
                Return $"{MyBase.ToString()}
Screen Size: {ScreenSize}
Touch Screen: {TouchScreen}"

            End Function

        End Class

    End Class



    'Device.Mobile
    'c)	Mobile will have two additional fields: WirelessProvider (string) and CellNetwork (string).
    Public Class Mobile
        Inherits Device

        Private ReadOnly WirelessProvider, CellNetwork As String

        Sub New()
        End Sub

        Sub New(brand As String, model As String, os As String, ip As String, mac As String, _wirelessProvider As String, _cellNetwork As String)
            MyBase.New(brand, model, os, ip, mac) 'device

            WirelessProvider = _wirelessProvider
            CellNetwork = _cellNetwork
        End Sub

        'device as parame
        Sub New(Device As Device, wirelessprovider As String, cellnetwork As String)
            MyClass.New(Device.Brand, Device.Model, Device.OS, Device.IP_Address, Device.MAC_Address, wirelessprovider, cellnetwork) 'above constructor

        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}
Wireless Provider: {WirelessProvider}
Cell Network: {CellNetwork}"

        End Function

        'g)	The two child classes of Mobile are SmartPhone and Tablet.

        'Device.Mobile.SmartPhone
        'h)	SmartPhone will have a field named PhoneNumber (string).
        Public Class SmartPhone
            Inherits Mobile

            Private ReadOnly PhoneNumber As String

            Sub New()
            End Sub

            Sub New(brand As String, model As String, os As String, ip As String, mac As String, wirelessprovider As String, cellnetwork As String, _phonenumber As String)
                MyBase.New(brand, model, os, ip, mac, wirelessprovider, cellnetwork) 'mobile

                PhoneNumber = _phonenumber
            End Sub

            Sub New(Mobile As Mobile, _phonenumber As String)
                MyClass.New(Mobile.Brand, Mobile.Model, Mobile.OS, Mobile.IP_Address, Mobile.MAC_Address, Mobile.WirelessProvider, Mobile.CellNetwork, _phonenumber)
            End Sub

            Public Overrides Function toString() As String
                Return $"{MyBase.ToString()}
Phone Number: {PhoneNumber}"

            End Function

        End Class


        'Device.Mobile.Tablet
        'i)	Tablet will have a field named VoIPApp (string)
        Public Class Tablet
            Inherits Mobile

            Private ReadOnly VoIPApp As String

            Sub New()
            End Sub

            Sub New(brand As String, model As String, os As String, ip As String, mac As String, wirelessprovider As String, cellnetwork As String, _voipapp As String)
                MyBase.New(brand, model, os, ip, mac, wirelessprovider, cellnetwork) 'mobile

                VoIPApp = _voipapp
            End Sub

            Sub New(Mobile As Mobile, voipapp As String)
                MyClass.New(Mobile.Brand, Mobile.Model, Mobile.OS, Mobile.IP_Address, Mobile.MAC_Address, Mobile.WirelessProvider, Mobile.CellNetwork, voipapp)

                'same as above but mobile param
            End Sub

            Public Overrides Function toString() As String
                Return $"{MyBase.ToString()}
Voice over IP App: {VoIPApp}"
            End Function

        End Class

    End Class

End Class



