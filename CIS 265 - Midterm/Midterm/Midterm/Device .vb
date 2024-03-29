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

    Private _Brand, _Model, _OS, _IP_Address, _MAC_Address As String

    '-_-'
    Public ReadOnly Property Brand As String
        Get
            Return _Brand
        End Get
    End Property

    Public ReadOnly Property Model As String
        Get
            Return _Model
        End Get
    End Property

    Public ReadOnly Property OS As String
        Get
            Return _OS
        End Get
    End Property

    Public ReadOnly Property IP_Address As String
        Get
            Return _IP_Address
        End Get
    End Property

    Public ReadOnly Property MAC_Address As String
        Get
            Return _MAC_Address
        End Get
    End Property




    Sub New(__brand As String, __model As String, __os As String, __ip As String, __mac As String)
        _Brand = __brand
        _Model = __model
        _OS = __os
        _IP_Address = __ip
        _MAC_Address = __mac
    End Sub

    Sub New()
    End Sub


    Public Overrides Function ToString() As String


        Return $"Brand: {Brand}
Model: {Model} 
Operating System: {OS}
IP Address: {IP_Address}
MAC Address: {MAC_Address}

"
    End Function




End Class

'Computer
Public Class Computer

    Inherits Device

    Private _ISP As String
    Public ReadOnly Property ISP As String
        Get
            Return _ISP
        End Get
    End Property

    Sub New(_brand As String, _model As String, _os As String, _ip As String, _mac As String, __isp As String)

        MyBase.New(_brand, _model, _os, _ip, _mac)

        _ISP = __isp
    End Sub


    Sub New(_Device As Device, __isp As String)
        MyBase.New(_Device.Brand, _Device.Model, _Device.OS, _Device.IP_Address, _Device.MAC_Address)

        _ISP = __isp
    End Sub

    Public Function ToString() As String
        Return $"{MyBase.ToString()}
ISP: {ISP}"

    End Function



    'Computer.Desktop'
    Public Class Desktop

    End Class


    'Computer.Laptop
    Public Class Laptop

        Private ScreenSize As Double
        Private TouchScreen As Boolean


        Sub New(_screenSize As Double, _touchScreen As Boolean)

            ScreenSize = _screenSize
            TouchScreen = _touchScreen
        End Sub
    End Class

End Class


'Device.Mobile
'Public Class Mobile


'    Private WirelessProvider, CellNetwork As String

'    'Mobile.SmartPhone
'    Public Class SmartPhone

'    End Class


'    'Mobile.Tablet
'    Public Class Tablet

'    End Class

'End Class