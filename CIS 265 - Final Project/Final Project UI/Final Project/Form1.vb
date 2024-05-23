Imports System.IO

Public Class Form1
    Private FileDialog As New OpenFileDialog
    Private ToolTip As New ToolTip


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'extra'
        ToolTip.InitialDelay = 100



        'The database text box should not be editable.
        Database_Output.ReadOnly = True

        'The Generate Devices button should be disabled from the start.
        Generate_btn.Enabled = False

        'The Device ComboBox should Not be editable.
        Device_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList


        'The Device ComboBox And Information GroupBox should be invisible from the start.
        Device_Panel.Visible = False

        'All textboxes within the GroupBox should Not be editable
        Type_Output.ReadOnly = True
        Brand_Output.ReadOnly = True
        OS_Output.ReadOnly = True
        IP_Output.ReadOnly = True
        MAC_Output.ReadOnly = True


        'phase 2 
        'Clicking the Browse Button will allow the user to browse for MDB and ACCDB files. 
        FileDialog.Filter = "Access Database Files (*.mdb, *.accdb)|*.mdb;*.accdb"

        FileDialog.Multiselect = False
        FileDialog.FileName = "Final Database"
        FileDialog.InitialDirectory = Environment.CurrentDirectory

    End Sub

    'When the user has selected a database, the Generate Devices button becomes clickable.
    'database connection 
    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles Browse_btn.Click
        If Not FileDialog.ShowDialog().Equals(DialogResult.OK) Then Return

        Generate_btn.Enabled = True

        Dim db_filepath = FileDialog.FileName

        Database_Output.Text = db_filepath
        ToolTip.SetToolTip(Database_Output, Path.GetFileName(db_filepath))

        'Dim Provider = "Microsoft.Jet.OLEDB.4.0" '32 bit'
        Dim Provider = "Microsoft.ACE.OLEDB.12.0" '64 bit'

        Device_Database.DB_Connect(
            DataSource:=db_filepath,
            Provider:=Provider
        )

        'Device_Database.Test()
    End Sub




    'When the user clicks the Generate Devices button, your program will create 50 random Devices(using a loop) that will populate the Devices Table. '
    Private Sub Generate_btn_Click(sender As Object, e As EventArgs) Handles Generate_btn.Click
        Dim count = 50

        Device_Database.Generate_Devices(count)

        MessageBox.Show("+" & count & " Devices Generated")

        Dim Datatable = Device_Database.get_DeviceIDs()

        Device_ComboBox.DataSource = Datatable

        Device_ComboBox.DisplayMember = "Device_ID"
        Device_ComboBox.ValueMember = "Device_ID"

        Device_ComboBox.SelectedIndex = 0

        Device_Panel.Visible = True
    End Sub


    '3.1 When a device is selected in the Device ComboBox, the relevant information should appear in the Textboxes within the GroupBox 
    Private Sub Device_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Device_ComboBox.SelectedIndexChanged

        'the sql index is the selected index +1; probably because combobox starts at 0 
        Dim sql_index = Device_ComboBox.SelectedIndex + 1

        DisplayDevice(sql_index)

    End Sub

    Private Function DisplayDevice(index As UInt128) As Boolean

        Dim DataTable = Device_Database.get_Device(index)

        'if the datatable is empty, then the device does not exist
        If DataTable.Rows.Count = 0 Then
            Type_Output.ForeColor = Color.Red
            Return False

        End If

        Type_Output.ForeColor = Color.Black

        'loads the data into the textboxes
        Type_Output.Text = DataTable.Rows(0)("DeviceType_ID")
        Brand_Output.Text = DataTable.Rows(0)("Brand_ID")
        OS_Output.Text = DataTable.Rows(0)("OS_ID")
        IP_Output.Text = DataTable.Rows(0)("IP_Address")
        MAC_Output.Text = DataTable.Rows(0)("MAC_Address")

        Return True
    End Function


End Class
