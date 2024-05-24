'for anything related to completing the order; (exists for organization)


Imports System.IO

Module Order
    Private Structure Filepath
        Const folder = "Device Order" & "\" 'folder name + \

        'folder + filename = filepath for each
        Const Order = folder & "Order Receipt.txt"
    End Structure

    Private Devices As New List(Of Device)
    Private Devices_Receipt As New List(Of String)

    Private Order_Total As Decimal = 0


    ''' <summary>
    ''' Adds the current selected device to the list of devices 
    ''' </summary>
    ''' <returns></returns>
    Public Function Purchase(Purchased_Device As Device, Price As Cost) As String

        If Devices_Receipt.Count = 0 Then
            Devices_Receipt.Add("Order Details")
        End If



        Devices_Receipt.Add("")

        Devices.Add(Purchased_Device)

        Devices_Receipt.Add(Purchased_Device.ToString)

        Order_Total += Price

        Return $"Total: {Order_Total:c} 
{Devices.Count} Devices"
    End Function

    Public Function CompleteOrder() As Integer

        Dim Dir = Environment.CurrentDirectory & "\" & Filepath.folder

        'to Delete all the files for new data
        If Directory.Exists(Dir) Then
            Directory.Delete(Dir, True)
            Directory.CreateDirectory(Dir)
        Else
            Directory.CreateDirectory(Dir)
        End If


        Devices_Receipt.Add(Environment.NewLine)
        Devices_Receipt.Add($"Order Total: {Order_Total:c}")


        File.WriteAllLines(Filepath.Order, Order.Devices_Receipt)

        Dim Orders = Devices.Count

        'clears for new order
        Devices = New List(Of Device)
        Devices_Receipt = New List(Of String)
        Order_Total = 0


        Return Orders

    End Function





End Module
