<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Database_Label = New Label()
        Database_Output = New TextBox()
        Database_Panel = New Panel()
        Generate_btn = New Button()
        Browse_btn = New Button()
        Device_Groupbox = New GroupBox()
        MAC_Output = New TextBox()
        MAC_Label = New Label()
        IP_Output = New TextBox()
        IP_Label = New Label()
        OS_Output = New TextBox()
        OS_Label = New Label()
        Brand_Output = New TextBox()
        Brand_Label = New Label()
        Type_Output = New TextBox()
        Type_Label = New Label()
        Device_Panel = New Panel()
        CompleteOrder_btn = New Button()
        Purchase_btn = New Button()
        Device_ComboBox = New ComboBox()
        Device_Label = New Label()
        Database_Panel.SuspendLayout()
        Device_Groupbox.SuspendLayout()
        Device_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Database_Label
        ' 
        Database_Label.AutoSize = True
        Database_Label.BackColor = Color.Transparent
        Database_Label.Location = New Point(3, 11)
        Database_Label.Name = "Database_Label"
        Database_Label.Size = New Size(90, 25)
        Database_Label.TabIndex = 0
        Database_Label.Text = "Database:"
        ' 
        ' Database_Output
        ' 
        Database_Output.Location = New Point(99, 9)
        Database_Output.Name = "Database_Output"
        Database_Output.Size = New Size(384, 31)
        Database_Output.TabIndex = 1
        ' 
        ' Database_Panel
        ' 
        Database_Panel.Controls.Add(Generate_btn)
        Database_Panel.Controls.Add(Browse_btn)
        Database_Panel.Controls.Add(Database_Label)
        Database_Panel.Controls.Add(Database_Output)
        Database_Panel.Location = New Point(32, 12)
        Database_Panel.Name = "Database_Panel"
        Database_Panel.Size = New Size(611, 105)
        Database_Panel.TabIndex = 2
        ' 
        ' Generate_btn
        ' 
        Generate_btn.Location = New Point(99, 56)
        Generate_btn.Name = "Generate_btn"
        Generate_btn.Size = New Size(198, 34)
        Generate_btn.TabIndex = 3
        Generate_btn.Text = "Generate Devices"
        Generate_btn.UseVisualStyleBackColor = True
        ' 
        ' Browse_btn
        ' 
        Browse_btn.Location = New Point(496, 9)
        Browse_btn.Name = "Browse_btn"
        Browse_btn.Size = New Size(112, 31)
        Browse_btn.TabIndex = 2
        Browse_btn.Text = "Browse"
        Browse_btn.UseVisualStyleBackColor = True
        ' 
        ' Device_Groupbox
        ' 
        Device_Groupbox.Controls.Add(MAC_Output)
        Device_Groupbox.Controls.Add(MAC_Label)
        Device_Groupbox.Controls.Add(IP_Output)
        Device_Groupbox.Controls.Add(IP_Label)
        Device_Groupbox.Controls.Add(OS_Output)
        Device_Groupbox.Controls.Add(OS_Label)
        Device_Groupbox.Controls.Add(Brand_Output)
        Device_Groupbox.Controls.Add(Brand_Label)
        Device_Groupbox.Controls.Add(Type_Output)
        Device_Groupbox.Controls.Add(Type_Label)
        Device_Groupbox.Location = New Point(12, 66)
        Device_Groupbox.Name = "Device_Groupbox"
        Device_Groupbox.Size = New Size(333, 306)
        Device_Groupbox.TabIndex = 3
        Device_Groupbox.TabStop = False
        Device_Groupbox.Text = "Device Information"
        ' 
        ' MAC_Output
        ' 
        MAC_Output.Location = New Point(87, 232)
        MAC_Output.Name = "MAC_Output"
        MAC_Output.Size = New Size(211, 31)
        MAC_Output.TabIndex = 9
        ' 
        ' MAC_Label
        ' 
        MAC_Label.AutoSize = True
        MAC_Label.Location = New Point(6, 238)
        MAC_Label.Name = "MAC_Label"
        MAC_Label.Size = New Size(55, 25)
        MAC_Label.TabIndex = 8
        MAC_Label.Text = "MAC:"
        ' 
        ' IP_Output
        ' 
        IP_Output.Location = New Point(87, 185)
        IP_Output.Name = "IP_Output"
        IP_Output.Size = New Size(211, 31)
        IP_Output.TabIndex = 7
        ' 
        ' IP_Label
        ' 
        IP_Label.AutoSize = True
        IP_Label.Location = New Point(6, 191)
        IP_Label.Name = "IP_Label"
        IP_Label.Size = New Size(31, 25)
        IP_Label.TabIndex = 6
        IP_Label.Text = "IP:"
        ' 
        ' OS_Output
        ' 
        OS_Output.Location = New Point(87, 139)
        OS_Output.Name = "OS_Output"
        OS_Output.Size = New Size(211, 31)
        OS_Output.TabIndex = 5
        ' 
        ' OS_Label
        ' 
        OS_Label.AutoSize = True
        OS_Label.Location = New Point(6, 145)
        OS_Label.Name = "OS_Label"
        OS_Label.Size = New Size(40, 25)
        OS_Label.TabIndex = 4
        OS_Label.Text = "OS:"
        ' 
        ' Brand_Output
        ' 
        Brand_Output.Location = New Point(87, 93)
        Brand_Output.Name = "Brand_Output"
        Brand_Output.Size = New Size(211, 31)
        Brand_Output.TabIndex = 3
        ' 
        ' Brand_Label
        ' 
        Brand_Label.AutoSize = True
        Brand_Label.Location = New Point(6, 99)
        Brand_Label.Name = "Brand_Label"
        Brand_Label.Size = New Size(62, 25)
        Brand_Label.TabIndex = 2
        Brand_Label.Text = "Brand:"
        ' 
        ' Type_Output
        ' 
        Type_Output.Location = New Point(87, 51)
        Type_Output.Name = "Type_Output"
        Type_Output.Size = New Size(211, 31)
        Type_Output.TabIndex = 1
        ' 
        ' Type_Label
        ' 
        Type_Label.AutoSize = True
        Type_Label.Location = New Point(6, 57)
        Type_Label.Name = "Type_Label"
        Type_Label.Size = New Size(53, 25)
        Type_Label.TabIndex = 0
        Type_Label.Text = "Type:"
        ' 
        ' Device_Panel
        ' 
        Device_Panel.Controls.Add(CompleteOrder_btn)
        Device_Panel.Controls.Add(Purchase_btn)
        Device_Panel.Controls.Add(Device_ComboBox)
        Device_Panel.Controls.Add(Device_Groupbox)
        Device_Panel.Controls.Add(Device_Label)
        Device_Panel.Location = New Point(32, 138)
        Device_Panel.Name = "Device_Panel"
        Device_Panel.Size = New Size(608, 394)
        Device_Panel.TabIndex = 5
        ' 
        ' CompleteOrder_btn
        ' 
        CompleteOrder_btn.BackColor = Color.Lime
        CompleteOrder_btn.FlatStyle = FlatStyle.Flat
        CompleteOrder_btn.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        CompleteOrder_btn.Location = New Point(399, 314)
        CompleteOrder_btn.Name = "CompleteOrder_btn"
        CompleteOrder_btn.Size = New Size(209, 80)
        CompleteOrder_btn.TabIndex = 5
        CompleteOrder_btn.Text = "COMPLETE ORDER"
        CompleteOrder_btn.UseVisualStyleBackColor = False
        ' 
        ' Purchase_btn
        ' 
        Purchase_btn.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Purchase_btn.Location = New Point(211, 6)
        Purchase_btn.Name = "Purchase_btn"
        Purchase_btn.Size = New Size(134, 34)
        Purchase_btn.TabIndex = 4
        Purchase_btn.Text = "PURCHASE"
        Purchase_btn.UseVisualStyleBackColor = False
        ' 
        ' Device_ComboBox
        ' 
        Device_ComboBox.FormattingEnabled = True
        Device_ComboBox.Location = New Point(99, 7)
        Device_ComboBox.Name = "Device_ComboBox"
        Device_ComboBox.Size = New Size(93, 33)
        Device_ComboBox.TabIndex = 1
        ' 
        ' Device_Label
        ' 
        Device_Label.AutoSize = True
        Device_Label.Location = New Point(12, 15)
        Device_Label.Name = "Device_Label"
        Device_Label.Size = New Size(68, 25)
        Device_Label.TabIndex = 0
        Device_Label.Text = "Device:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 544)
        Controls.Add(Device_Panel)
        Controls.Add(Database_Panel)
        Name = "Form1"
        Text = "Final Project"
        Database_Panel.ResumeLayout(False)
        Database_Panel.PerformLayout()
        Device_Groupbox.ResumeLayout(False)
        Device_Groupbox.PerformLayout()
        Device_Panel.ResumeLayout(False)
        Device_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Database_Label As Label
    Friend WithEvents Database_Output As TextBox
    Friend WithEvents Database_Panel As Panel
    Friend WithEvents Generate_btn As Button
    Friend WithEvents Browse_btn As Button
    Friend WithEvents Device_Groupbox As GroupBox
    Friend WithEvents Device_Panel As Panel
    Friend WithEvents Device_Label As Label
    Friend WithEvents Device_ComboBox As ComboBox
    Friend WithEvents Type_Label As Label
    Friend WithEvents Type_Output As TextBox
    Friend WithEvents OS_Output As TextBox
    Friend WithEvents OS_Label As Label
    Friend WithEvents Brand_Output As TextBox
    Friend WithEvents Brand_Label As Label
    Friend WithEvents IP_Output As TextBox
    Friend WithEvents IP_Label As Label
    Friend WithEvents MAC_Output As TextBox
    Friend WithEvents MAC_Label As Label
    Friend WithEvents Purchase_btn As Button
    Friend WithEvents CompleteOrder_btn As Button

End Class
