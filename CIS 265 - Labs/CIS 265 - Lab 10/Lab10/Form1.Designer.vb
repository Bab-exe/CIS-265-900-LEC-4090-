<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_BrowseDB = New System.Windows.Forms.Button()
        Me.txt_DBDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_DataFileDir = New System.Windows.Forms.TextBox()
        Me.btn_BrowseDataFile = New System.Windows.Forms.Button()
        Me.btn_LoadData = New System.Windows.Forms.Button()
        Me.Listbox_Data = New System.Windows.Forms.ListBox()
        Me.btn_FindSeniors = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btn_BrowseDB
        '
        Me.btn_BrowseDB.Location = New System.Drawing.Point(510, 18)
        Me.btn_BrowseDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BrowseDB.Name = "btn_BrowseDB"
        Me.btn_BrowseDB.Size = New System.Drawing.Size(36, 35)
        Me.btn_BrowseDB.TabIndex = 1
        Me.btn_BrowseDB.Text = "..."
        Me.btn_BrowseDB.UseVisualStyleBackColor = True
        '
        'txt_DBDir
        '
        Me.txt_DBDir.Location = New System.Drawing.Point(111, 22)
        Me.txt_DBDir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DBDir.Name = "txt_DBDir"
        Me.txt_DBDir.Size = New System.Drawing.Size(388, 26)
        Me.txt_DBDir.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Database:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data File:"
        '
        'txt_DataFileDir
        '
        Me.txt_DataFileDir.Location = New System.Drawing.Point(111, 105)
        Me.txt_DataFileDir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_DataFileDir.Name = "txt_DataFileDir"
        Me.txt_DataFileDir.Size = New System.Drawing.Size(388, 26)
        Me.txt_DataFileDir.TabIndex = 5
        '
        'btn_BrowseDataFile
        '
        Me.btn_BrowseDataFile.Location = New System.Drawing.Point(510, 102)
        Me.btn_BrowseDataFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BrowseDataFile.Name = "btn_BrowseDataFile"
        Me.btn_BrowseDataFile.Size = New System.Drawing.Size(36, 35)
        Me.btn_BrowseDataFile.TabIndex = 1
        Me.btn_BrowseDataFile.Text = "..."
        Me.btn_BrowseDataFile.UseVisualStyleBackColor = True
        '
        'btn_LoadData
        '
        Me.btn_LoadData.Location = New System.Drawing.Point(111, 145)
        Me.btn_LoadData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_LoadData.Name = "btn_LoadData"
        Me.btn_LoadData.Size = New System.Drawing.Size(112, 35)
        Me.btn_LoadData.TabIndex = 6
        Me.btn_LoadData.Text = "Load Data"
        Me.btn_LoadData.UseVisualStyleBackColor = True
        Me.btn_LoadData.Visible = False
        '
        'Listbox_Data
        '
        Me.Listbox_Data.FormattingEnabled = True
        Me.Listbox_Data.HorizontalScrollbar = True
        Me.Listbox_Data.ItemHeight = 20
        Me.Listbox_Data.Location = New System.Drawing.Point(28, 199)
        Me.Listbox_Data.MultiColumn = True
        Me.Listbox_Data.Name = "Listbox_Data"
        Me.Listbox_Data.ScrollAlwaysVisible = True
        Me.Listbox_Data.Size = New System.Drawing.Size(518, 124)
        Me.Listbox_Data.TabIndex = 7
        Me.Listbox_Data.Visible = False
        '
        'btn_FindSeniors
        '
        Me.btn_FindSeniors.Enabled = False
        Me.btn_FindSeniors.Location = New System.Drawing.Point(434, 145)
        Me.btn_FindSeniors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_FindSeniors.Name = "btn_FindSeniors"
        Me.btn_FindSeniors.Size = New System.Drawing.Size(112, 35)
        Me.btn_FindSeniors.TabIndex = 9
        Me.btn_FindSeniors.Text = "Find Seniors"
        Me.btn_FindSeniors.UseVisualStyleBackColor = True
        Me.btn_FindSeniors.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 344)
        Me.Controls.Add(Me.btn_FindSeniors)
        Me.Controls.Add(Me.Listbox_Data)
        Me.Controls.Add(Me.btn_LoadData)
        Me.Controls.Add(Me.txt_DataFileDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_DBDir)
        Me.Controls.Add(Me.btn_BrowseDataFile)
        Me.Controls.Add(Me.btn_BrowseDB)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Lab10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_BrowseDB As Button
    Friend WithEvents txt_DBDir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_DataFileDir As TextBox
    Friend WithEvents btn_BrowseDataFile As Button
    Friend WithEvents btn_LoadData As Button
    Friend WithEvents Listbox_Data As ListBox
    Friend WithEvents btn_FindSeniors As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip As ToolTip
End Class
