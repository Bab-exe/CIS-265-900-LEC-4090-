
Imports System.Data.OleDb

'for the anything related with getting data from the database; NOT A CLASS (exists for organization); all paramerized queries are here
Module Device_Database


    Private DeviceType_List, OS_List, Brand_List As List(Of String)

    Private Connection As OleDb.OleDbConnection

    '64 bit by default


    Sub DB_Connect(DataSource As String, Optional Provider As String = "Microsoft.ACE.OLEDB.12.0")

        Dim constr = $"Data Source={DataSource}; Provider={Provider};"

        Connection = New OleDb.OleDbConnection(constr)


        Connection.Open()
        DeviceType_List = sql_get(
            queryname:="OUTPUT_DeviceTypes",
            fieldname:="DeviceName"
            )

        OS_List = sql_get(
            queryname:="OUTPUT_OpSys",
            fieldname:="OS_Name"
            )

        Brand_List = sql_get(
            queryname:="OUTPUT_Brands",
            fieldname:="Brand_Name"
            )
        Connection.Close()


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

            command.Parameters.AddWithValue("DeviceType_ID", DeviceType)
            command.Parameters.AddWithValue("Brand_ID", Brand)
            command.Parameters.AddWithValue("OS_ID", OS)
            command.Parameters.AddWithValue("IP_Address", IP)
            command.Parameters.AddWithValue("MAC_Address", MAC)

            command.ExecuteNonQuery()
        End Using

    End Sub


    ''' <summary>
    ''' Generates Devices into database 
    ''' </summary>
    ''' <param name="Count"></param>
    Public Sub Generate_Devices(Count As UInteger)
        Dim DeviceType_ID As Integer
        Dim Brand_ID As Integer
        Dim OS_ID As Integer
        Dim IP As String
        Dim MAC As String

        Connection.Open()

        For i As UInteger = 1 To Count Step 1
            Brand_ID = Random_Number(1, Brand_List.Count - 1)

            DeviceType_ID = Random_Number(1, DeviceType_List.Count - 1)
            OS_ID = Random_Number(1, OS_List.Count - 1)

            IP = Random_IP()
            MAC = Random_Mac()


            INPUT_Device(DeviceType_ID, Brand_ID, OS_ID, IP, MAC)
        Next


        Connection.Close()

    End Sub



    ''' <summary>
    ''' for when the query has parameters;command type is made stored procedure when using this exists specifically for datatable parts;  
    ''' </summary>
    ''' <param name="queryname"></param>
    ''' <param name="command"></param>
    ''' <returns></returns>
    Private Function sql_get(queryname As String, command As OleDbCommand) As DataTable
        Dim dt As New DataTable()

        command.CommandType = CommandType.StoredProcedure

        Using adapter As New OleDbDataAdapter(command)
            adapter.Fill(dt)
        End Using

        Return dt

    End Function

    ''' <summary>
    ''' Code to execute a query stored on DB: CONNECTION MUST BE OPEN
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="queryname"></param>
    ''' <param name="fieldname"></param>
    ''' <returns></returns>
    Private Function sql_get(queryname As String, fieldname As String) As List(Of String)

        Dim list As New List(Of String)
        list.Add("")  'with respect to sql based indexing'

        Using command As New OleDb.OleDbCommand(queryname, Connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()

                    list.Add(reader(fieldname).ToString)
                End While
            End Using

        End Using



        Return list

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
            command.Parameters.AddWithValue("ID", ID)

            dt = sql_get(queryname, command)

        End Using

        Return dt

    End Function


    ''' <summary>
    ''' gets the device type based on the ID directly from database
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns></returns>
    Function get_DeviceType(ID As Integer) As String

        Return DeviceType_List(ID)

    End Function

    ''' <summary>
    ''' gets the brand based on id directly from database
    ''' </summary>
    Function get_Brand(ID As Integer) As String

        Return Brand_List(ID)

    End Function

    ''' <summary>
    ''' gets the OS based on id directly from database
    ''' </summary>
    Function get_OS(ID As Integer) As String

        Return OS_List(ID)

    End Function






End Module








