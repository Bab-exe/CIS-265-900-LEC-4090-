
Imports System.Data
Imports System.Data.OleDb

'for the anything related with getting data from the database; NOT A CLASS (exists for organization),
Module Device_Database


    Private DeviceTypes, OS, Brands As List(Of String)

    Private Connection As OleDb.OleDbConnection

    '64 bit by default
    Sub DB_Connect(DataSource As String, Optional Provider As String = "Microsoft.ACE.OLEDB.12.0")

        Dim constr = $"Data Source={DataSource}; Provider={Provider};"

        Connection = New OleDb.OleDbConnection(constr)
    End Sub



    ''' <summary>
    ''' Inputs a device into the database;Connection must be open'
    ''' </summary>
    ''' <param name="DeviceType"></param>
    ''' <param name="Brand"></param>
    ''' <param name="OS"></param>
    ''' <param name="IP"></param>
    ''' <param name="MAC"></param>
    Private Sub INPUT_Device(DeviceType As Integer, Brand As Integer, OS As Integer, IP As String, MAC As String)
        Dim queryname As String = "INPUT_Device"


        Using command As New OleDbCommand(queryname, Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Brand_ID", Brand)
            command.Parameters.AddWithValue("@DeviceType_ID", DeviceType)
            command.Parameters.AddWithValue("@OS_ID", OS)
            command.Parameters.AddWithValue("@IP_Address", IP)
            command.Parameters.AddWithValue("@MAC_Address", MAC)

            command.ExecuteNonQuery()
        End Using

    End Sub


    ''' <summary>
    ''' generates devices based on the count
    ''' </summary>
    ''' <param name="Count"></param>
    Public Sub Generate_Devices(Count As UShort) 'As List(Of Device)



        Dim queryname As String = "INPUT_Device"

        Dim DeviceType As Integer
        Dim Brand As Integer
        Dim OS As Integer
        Dim IP As String
        Dim MAC As String

        Connection.Open()
        For i = 1 To Count Step 1
            Brand = Generate.Random_Number(1, 10)
            DeviceType = Generate.Random_Number(1, 4)
            OS = Generate.Random_Number(1, 7)
            IP = Generate.Random_IP
            MAC = Generate.Random_Mac


            INPUT_Device(DeviceType, Brand, OS, IP, MAC)
        Next


        Connection.Close()

    End Sub



    ''' <summary>
    ''' Clears all devices;
    ''' </summary>
    Private Sub Clear_Devices()
        Dim queryname = "CLEAR_Devices"

        Connection.Open()
        Using command As New OleDb.OleDbCommand(queryname, Connection)
            command.CommandType = CommandType.StoredProcedure
            command.ExecuteNonQuery()
        End Using
        Connection.Close()
    End Sub


    'for parameterized query;command type is made stored procedure when using this ; command is 
    Private Function sql_get(queryname As String, command As OleDbCommand) As DataTable
        Dim dt As New DataTable()

        command.CommandType = CommandType.StoredProcedure

        Using adapter As New OleDbDataAdapter(command)
            adapter.Fill(dt)

        End Using

        Return dt

    End Function

    ''' <summary>
    ''' gets all device ids as a datatable; for phase2
    ''' </summary>
    ''' <returns></returns>
    Public Function get_DeviceIDs() As DataTable

        Dim queryname = "OUTPUT_DeviceIDs"
        Dim dt As New DataTable()

        Using command As New OleDbCommand(queryname, Connection)
            dt = sql_get(queryname, command)
        End Using

        Return dt
    End Function


    ''' <summary>
    ''' gets a specific device based on the ID
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns></returns>
    Public Function get_Device(ID As Integer) As DataTable
        Dim queryname = "OUTPUT_Device"

        Dim dt As New DataTable()

        Using command As New OleDbCommand(queryname, Connection)
            command.Parameters.AddWithValue("@ID", ID)

            dt = sql_get(queryname, command)

        End Using

        Return dt

    End Function

    'todo
    Private Function get_DeviceTypes() As List(Of String)
        Dim queryname = "OUTPUT_DeviceTypes"
        Dim deviceTypes As New List(Of String)

        Connection.Open()
        Using command As New OleDb.OleDbCommand(queryname, Connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()

                    deviceTypes.Add(reader("DeviceName"))
                End While
            End Using

        End Using
        Connection.Close()

        Return deviceTypes
    End Function


    'gets the device type based on the ID directly from database
    Function get_DeviceType(ID As Integer) As String

        Dim queryname = "OUTPUT_DeviceType"
        Dim fieldname = "DeviceName"

        Dim deviceType As String = ""

        Connection.Open()
        Using command As New OleDb.OleDbCommand(queryname, Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ID", ID)


        End Using

        Return deviceType


        Connection.Close()

    End Function





    Sub Test()
        Connection.Open()
        Connection.Close()
    End Sub

End Module








