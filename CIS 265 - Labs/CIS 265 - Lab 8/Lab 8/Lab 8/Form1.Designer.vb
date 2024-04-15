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
        components = New ComponentModel.Container()
        Startbtn = New Button()
        Stopbtn = New Button()
        Time_Display = New Panel()
        TimeText = New TextBox()
        Timer = New Timer(components)
        Input_Years = New NumericUpDown()
        Input_Group = New TableLayoutPanel()
        Input_Days = New NumericUpDown()
        Days_Label = New Label()
        Input_Months = New NumericUpDown()
        Label1 = New Label()
        Years_Label = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Input_Seconds = New NumericUpDown()
        Label2 = New Label()
        Input_Minutes = New NumericUpDown()
        Label3 = New Label()
        Input_Hours = New NumericUpDown()
        Label4 = New Label()
        Time_Display.SuspendLayout()
        CType(Input_Years, ComponentModel.ISupportInitialize).BeginInit()
        Input_Group.SuspendLayout()
        CType(Input_Days, ComponentModel.ISupportInitialize).BeginInit()
        CType(Input_Months, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(Input_Seconds, ComponentModel.ISupportInitialize).BeginInit()
        CType(Input_Minutes, ComponentModel.ISupportInitialize).BeginInit()
        CType(Input_Hours, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Startbtn
        ' 
        Startbtn.BackColor = Color.DimGray
        Startbtn.Cursor = Cursors.AppStarting
        Startbtn.Enabled = False
        Startbtn.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Startbtn.Location = New Point(597, 3)
        Startbtn.Name = "Startbtn"
        Startbtn.Size = New Size(100, 35)
        Startbtn.TabIndex = 1
        Startbtn.Text = "Start"
        Startbtn.UseVisualStyleBackColor = False
        ' 
        ' Stopbtn
        ' 
        Stopbtn.AccessibleName = "Stop"
        Stopbtn.BackColor = Color.Red
        Stopbtn.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stopbtn.Location = New Point(597, 37)
        Stopbtn.Name = "Stopbtn"
        Stopbtn.Size = New Size(100, 35)
        Stopbtn.TabIndex = 2
        Stopbtn.Text = "Stop"
        Stopbtn.UseVisualStyleBackColor = False
        ' 
        ' Time_Display
        ' 
        Time_Display.Controls.Add(TimeText)
        Time_Display.Controls.Add(Startbtn)
        Time_Display.Controls.Add(Stopbtn)
        Time_Display.Location = New Point(10, 40)
        Time_Display.Name = "Time_Display"
        Time_Display.Size = New Size(700, 80)
        Time_Display.TabIndex = 3
        ' 
        ' TimeText
        ' 
        TimeText.BorderStyle = BorderStyle.None
        TimeText.ForeColor = SystemColors.MenuText
        TimeText.Location = New Point(3, 3)
        TimeText.Name = "TimeText"
        TimeText.Size = New Size(590, 65)
        TimeText.TabIndex = 3
        TimeText.Text = "Time"
        TimeText.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer
        ' 
        Timer.Enabled = True
        ' 
        ' Input_Years
        ' 
        Input_Years.Font = New Font("Times New Roman", 15F)
        Input_Years.Location = New Point(129, 3)
        Input_Years.Name = "Input_Years"
        Input_Years.Size = New Size(180, 42)
        Input_Years.TabIndex = 5
        ' 
        ' Input_Group
        ' 
        Input_Group.ColumnCount = 2
        Input_Group.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        Input_Group.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        Input_Group.Controls.Add(Input_Days, 1, 2)
        Input_Group.Controls.Add(Days_Label, 0, 2)
        Input_Group.Controls.Add(Input_Months, 1, 1)
        Input_Group.Controls.Add(Label1, 0, 1)
        Input_Group.Controls.Add(Input_Years, 1, 0)
        Input_Group.Controls.Add(Years_Label, 0, 0)
        Input_Group.Font = New Font("Times New Roman", 15F)
        Input_Group.Location = New Point(10, 160)
        Input_Group.Name = "Input_Group"
        Input_Group.RowCount = 3
        Input_Group.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        Input_Group.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        Input_Group.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        Input_Group.Size = New Size(316, 182)
        Input_Group.TabIndex = 10
        ' 
        ' Input_Days
        ' 
        Input_Days.Font = New Font("Times New Roman", 15F)
        Input_Days.Location = New Point(129, 123)
        Input_Days.Name = "Input_Days"
        Input_Days.Size = New Size(180, 42)
        Input_Days.TabIndex = 11
        ' 
        ' Days_Label
        ' 
        Days_Label.Font = New Font("Times New Roman", 15F)
        Days_Label.Location = New Point(3, 120)
        Days_Label.Name = "Days_Label"
        Days_Label.Size = New Size(107, 40)
        Days_Label.TabIndex = 10
        Days_Label.Text = "Days:"
        Days_Label.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Input_Months
        ' 
        Input_Months.Font = New Font("Times New Roman", 15F)
        Input_Months.Location = New Point(129, 63)
        Input_Months.Name = "Input_Months"
        Input_Months.Size = New Size(180, 42)
        Input_Months.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Times New Roman", 15F)
        Label1.Location = New Point(3, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 40)
        Label1.TabIndex = 8
        Label1.Text = "Months:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Years_Label
        ' 
        Years_Label.Font = New Font("Times New Roman", 15F)
        Years_Label.Location = New Point(3, 0)
        Years_Label.Name = "Years_Label"
        Years_Label.Size = New Size(107, 40)
        Years_Label.TabIndex = 7
        Years_Label.Text = "Years:"
        Years_Label.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel1.Controls.Add(Input_Seconds, 1, 2)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(Input_Minutes, 1, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 1)
        TableLayoutPanel1.Controls.Add(Input_Hours, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 0)
        TableLayoutPanel1.Font = New Font("Times New Roman", 15F)
        TableLayoutPanel1.Location = New Point(394, 160)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(316, 182)
        TableLayoutPanel1.TabIndex = 11
        ' 
        ' Input_Seconds
        ' 
        Input_Seconds.Font = New Font("Times New Roman", 15F)
        Input_Seconds.Location = New Point(129, 123)
        Input_Seconds.Name = "Input_Seconds"
        Input_Seconds.Size = New Size(180, 42)
        Input_Seconds.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Times New Roman", 15F)
        Label2.Location = New Point(3, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 40)
        Label2.TabIndex = 10
        Label2.Text = "Second:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Input_Minutes
        ' 
        Input_Minutes.Font = New Font("Times New Roman", 15F)
        Input_Minutes.Location = New Point(129, 63)
        Input_Minutes.Name = "Input_Minutes"
        Input_Minutes.Size = New Size(180, 42)
        Input_Minutes.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Times New Roman", 15F)
        Label3.Location = New Point(3, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 40)
        Label3.TabIndex = 8
        Label3.Text = "Minute:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Input_Hours
        ' 
        Input_Hours.Font = New Font("Times New Roman", 15F)
        Input_Hours.Location = New Point(129, 3)
        Input_Hours.Name = "Input_Hours"
        Input_Hours.Size = New Size(180, 42)
        Input_Hours.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Times New Roman", 15F)
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 40)
        Label4.TabIndex = 7
        Label4.Text = "Hour:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(31F, 64F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(714, 380)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Input_Group)
        Controls.Add(Time_Display)
        Font = New Font("Times New Roman", 28F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(9, 8, 9, 8)
        MaximizeBox = False
        Name = "Form1"
        Text = "Lab 8"
        Time_Display.ResumeLayout(False)
        Time_Display.PerformLayout()
        CType(Input_Years, ComponentModel.ISupportInitialize).EndInit()
        Input_Group.ResumeLayout(False)
        CType(Input_Days, ComponentModel.ISupportInitialize).EndInit()
        CType(Input_Months, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(Input_Seconds, ComponentModel.ISupportInitialize).EndInit()
        CType(Input_Minutes, ComponentModel.ISupportInitialize).EndInit()
        CType(Input_Hours, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Startbtn As Button
    Friend WithEvents Stopbtn As Button
    Friend WithEvents Time_Display As Panel
    Friend WithEvents TimeText As TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents Input_Years As NumericUpDown
    Friend WithEvents Input_Group As TableLayoutPanel
    Friend WithEvents Years_Label As Label
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents Input_Days As NumericUpDown
    Friend WithEvents Days_Label As Label
    Friend WithEvents Input_Months As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Input_Seconds As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Input_Minutes As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Input_Hours As NumericUpDown
    Friend WithEvents Label4 As Label

End Class
