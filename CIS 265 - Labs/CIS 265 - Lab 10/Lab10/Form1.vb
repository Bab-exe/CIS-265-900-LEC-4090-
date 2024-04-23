Imports System.IO
Imports System.Data.OleDb

Public Class Form1

    Dim con As New OleDb.OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaultVisual(txt_DBDir)
        SetDefaultVisual(txt_DataFileDir)
    End Sub

    Private Sub SetDefaultVisual(textBox As System.Windows.Forms.TextBox)
        textBox.ReadOnly = True
        textBox.Text = "Browse for a file"
        textBox.Font = New Font(textBox.Font, FontStyle.Italic)
        textBox.ForeColor = Color.Gray
    End Sub
    Private Sub btn_BrowseDB_Click(sender As Object, e As EventArgs) Handles btn_BrowseDB.Click

        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select MDB or ACCDB File"
        ofd.Filter = "Access Database Files (*.mdb, *.accdb)|*.mdb;*.accdb"
        ofd.Multiselect = False
        ofd.InitialDirectory = Environment.CurrentDirectory

        If ofd.ShowDialog() = DialogResult.OK Then

            ' Retrieve the selected file path
            Dim selectedFilePath As String = ofd.FileName

            ' Now you can use the selected file path as needed
            txt_DBDir.Font = New Font(txt_DBDir.Font, FontStyle.Regular)
            txt_DBDir.ForeColor = Color.Black
            txt_DBDir.Text = selectedFilePath
            ' Move the cursor to the end of the text
            txt_DBDir.SelectionStart = txt_DBDir.Text.Length

            SetupDBCon(selectedFilePath)

            '1.	The Load Data button should be invisible until after the user has selected a database file and has selected the database."
            btn_LoadData.Visible = True

        End If

    End Sub

    Private Sub SetupDBCon(dbPath As String)

        Dim conStr As String = "Data Source=lab10.mdb; Provider=Microsoft.Jet.OLEDB.4.0;" '32bit
        'Dim conStr As String = "Data Source=lab10.accdb; Provider=Microsoft.ACE.OLEDB.12.0;" '64bit

        con = New OleDb.OleDbConnection(conStr)

    End Sub




    Private Sub btn_BrowseDataFile_Click(sender As Object, e As EventArgs) Handles btn_BrowseDataFile.Click

        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select a Text File"
        ofd.Filter = "Text Files (*.txt)|*.txt"
        ofd.Multiselect = False
        ofd.InitialDirectory = Environment.CurrentDirectory

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = ofd.FileName
            txt_DataFileDir.Font = New Font(txt_DBDir.Font, FontStyle.Regular)
            txt_DataFileDir.ForeColor = Color.Black
            txt_DataFileDir.Text = selectedFilePath
            txt_DataFileDir.SelectionStart = txt_DBDir.Text.Length
        End If

    End Sub

    Private Sub btn_LoadData_Click(sender As Object, e As EventArgs) Handles btn_LoadData.Click
        'Import the contents of the file into the database

        Dim filePath As String = txt_DataFileDir.Text

        Using connection As New OleDbConnection(con.ConnectionString)

            con.Open()

            ' Read the flat file line by line
            For Each line As String In File.ReadLines(filePath)

                ' Split the line into individual values based on commas
                'This is saved in the data array
                Dim data As String() = line.Split(","c)

                ' SQL command to insert data into the table
                Dim sql As String = "INSERT INTO Student (FirstName, LastName, GradeLevel, GPA) " &
                                    $"VALUES ('{data(0)}', '{data(1)}', {data(2)}, {data(3)})"

                Using cmd As New OleDbCommand(sql, con)
                    cmd.ExecuteNonQuery()

                End Using

            Next

            con.Close()
        End Using





        '2.	Display a message box to the user after the data has been successfully imported into the Student table.
        MsgBox("data has been successfully imported into the Student table.", MsgBoxStyle.Information, "Data Imported")




        '6.	Find Seniors button should not be clickable until after data has been imported into the Student table (Load Data has been clicked).
        btn_FindSeniors.Visible = True
        btn_FindSeniors.Enabled = True



    End Sub

    Private Sub btn_FindSeniors_Click(sender As Object, e As EventArgs) Handles btn_FindSeniors.Click

        Listbox_Data.Visible = True
        Listbox_Data.Items.Clear()


        '4.	Query the Student table to find all 12th graders. Add their StudentIDs into the ListBox.
        Using connection As New OleDbConnection(con.ConnectionString)

            con.Open()

            Dim sql As String = "SELECT StudentID FROM Student WHERE GradeLevel = 12"

            Using cmd As New OleDbCommand(sql, con)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Listbox_Data.Items.Add(reader("StudentID"))
                End While

            End Using

            con.Close()
        End Using

        ToolTip.Show($"{Listbox_Data.Items.Count} Senior IDS found.", btn_FindSeniors)
    End Sub
End Class
