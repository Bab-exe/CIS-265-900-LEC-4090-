
'Desktops cost $2000. Laptops cost $800. Smartphones cost $600. Tablets cost $450. 
Public Enum Cost
    Desktop = 2000
    Laptop = 800
    Smartphone = 600
    Tablet = 450
End Enum

'the 1 class in project
Public Class Device

    Private DeviceType, Brand, OS As String
    Private Price As Cost


    Sub New(_DeviceType As String, _Brand As String, _OS As String, _Cost As Cost)

        DeviceType = _DeviceType
        Brand = _Brand
        OS = _OS

        Price = _Cost
    End Sub

    Public Overrides Function ToString() As String

        Return $"Device: {DeviceType}
Brand: {Brand}
OS: {OS}
Price: {Price}"
    End Function



End Class
