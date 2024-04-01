Imports System.Data.OleDb
Imports System.Reflection

Module Module1

    Sub Main()
        Part1()
        wait()
    End Sub



    Sub Part1()

        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Chevrolet', 'Corvette', 2015)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Ford', 'Mustang', 2019)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Dodge', 'Viper', 2001)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Pontiac', 'Firebird', 1998)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Tesla', 'Model S', 2022)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Chrysler', '300', 2024)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Chevrolet', 'Camaro', 2002)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Ford', 'GT3', 2020)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Dodge', 'Challenger', 2019)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Pontiac', 'GTO', 2005)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Tesla', 'Roadster', 2026)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Dodge', 'Charger', 2025)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Chevrolet', 'Camaro', 2023)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Ford', 'Ranger', 2005)")
        ExecuteNonQuery("INSERT INTO Cars (Make, Model, CarYear) VALUES ('Jeep', 'Wagoneer', 2023)")

        'Putting this first so you can see it actually updates
        ExecuteNonQuery("UPDATE Cars SET Make='GM' WHERE Make='Pontiac'")

        'Commenting this out because it will delete the old GM cars
        'ExecuteNonQuery("DELETE FROM Cars WHERE CarYear <= 2010")

        ShowCarData()


    End Sub




    'Subprocedure for executing INSERT, UPDATE, and DELETE (not SELECT)
    Sub ExecuteNonQuery(strQuery As String)
        Dim con As New OleDb.OleDbConnection("Data Source=Lab7p1.mdb; Provider=Microsoft.Jet.OLEDB.4.0")
        Dim cmd As OleDb.OleDbCommand


        'So we can see our query before it's executed
        'Console.WriteLine(queryStr)
        'wait()


        'Execute the query
        cmd = New OleDbCommand(strQuery, con)

        con.Open()
        cmd.ExecuteNonQuery() 'Use this when you do not expect any results (records) to be returned
        con.Close()
    End Sub



    Sub ShowCarData()

        Dim con As New OleDb.OleDbConnection("Data Source=Lab7p1.mdb; Provider=Microsoft.Jet.OLEDB.4.0")
        Dim cmd As OleDb.OleDbCommand
        Dim strQuery As String

        strQuery = "SELECT Make,Model,CarYear FROM Cars"

        con.Open()

        'Initilize the command to execute the query
        cmd = New OleDbCommand(strQuery, con)

        'Execute the query and retrieve the data using a reader
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        'Loop while the reader still has something (another record) to read
        While reader.Read()
            'Retrieve the values based on the column name for the current record
            Dim strMake As String = reader.GetString(reader.GetOrdinal("Make"))
            Dim strModel As String = reader.GetString(reader.GetOrdinal("Model"))
            Dim intYear As Integer = reader.GetInt32(reader.GetOrdinal("CarYear"))
            Console.WriteLine(intYear & " " & strMake & " " & strModel)
        End While

        con.Close()

    End Sub



    Sub wait()
        Console.Write(Environment.NewLine & "Press any key to exit.")
        Console.ReadKey()
    End Sub




End Module
