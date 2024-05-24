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

        'phase 3


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



        Device_Panel.Visible = True
    End Sub


    '3.1 When a device is selected in the Device ComboBox, the relevant information should appear in the Textboxes within the GroupBox 
    Private Sub Device_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Device_ComboBox.SelectedIndexChanged

        'the sql index is the selected index +1; probably because combobox starts at 0 
        Dim sql_index = Device_ComboBox.SelectedIndex + 1

        DisplayDevice(sql_index)

    End Sub

    Private Sub DisplayDevice(index As Integer)

        Dim DataTable = Device_Database.get_Device(index)

        'if empty then it doesnt exist
        If DataTable.Rows.Count = 0 Then
            Return
        End If




        Dim Type_ID = DataTable.Rows(0)("DeviceType_ID")
        Dim Brand_ID = DataTable.Rows(0)("Brand_ID")
        Dim OS_ID = DataTable.Rows(0)("OS_ID")

        'loads the data into the textboxes
        Type_Output.Text = get_DeviceType(Type_ID)
        Brand_Output.Text = get_Brand(Brand_ID)
        OS_Output.Text = get_OS(OS_ID)

        IP_Output.Text = DataTable.Rows(0)("IP_Address")
        MAC_Output.Text = DataTable.Rows(0)("MAC_Address")
    End Sub

    Private Sub Purchase_btn_Click(sender As Object, e As EventArgs) Handles Purchase_btn.Click

        Dim price As Integer


        'to calculate the correct price
        Select Case Type_Output.Text
            Case "Desktop"
                price = Cost.Desktop
            Case "Laptop"
                price = Cost.Laptop
            Case "Smart Phone"
                price = Cost.Smartphone
            Case "Tablet"
                price = Cost.Tablet
        End Select

        Dim Current_Device As New Device(
           Type_Output.Text,
            Brand_Output.Text,
            OS_Output.Text,
            price
)

        Dim purchase_info = Order.Purchase(Current_Device, price)


        ToolTip.SetToolTip(CompleteOrder_btn, purchase_info)

        MessageBox.Show("Purchased: " & Environment.NewLine & Current_Device.ToString)


    End Sub

    Private Sub CompleteOrder_btn_Click(sender As Object, e As EventArgs) Handles CompleteOrder_btn.Click

        MessageBox.Show(Order.CompleteOrder() & " Devices Ordered")

        ToolTip.SetToolTip(CompleteOrder_btn, "Order Complete")
    End Sub
End Class
