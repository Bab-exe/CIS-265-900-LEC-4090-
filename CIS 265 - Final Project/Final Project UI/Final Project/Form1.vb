Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub


End Class
