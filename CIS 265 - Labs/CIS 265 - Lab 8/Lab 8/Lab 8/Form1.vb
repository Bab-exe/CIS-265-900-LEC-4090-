'Blessing Abumere
'Lab 8

Public Class Form1

    Private _Goofy_Years, _Goofy_Days, _Goofy_Months As Integer
    Private _Goofy_Hours, _Goofy_Minutes, _Goofy_Seconds As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Timer = New Timer()
        Timer.Start()

        _Goofy_Days = 0
        _Goofy_Months = 0
        _Goofy_Years = 0

        _Goofy_Hours = 0
        _Goofy_Minutes = 0
        _Goofy_Seconds = 0
    End Sub



    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        Startbtn.Enabled = False
        Startbtn.BackColor = Color.DimGray

        Timer.Start()
    End Sub

    Private Sub Stop_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click, Input_Years.ValueChanged, Input_Months.ValueChanged, Input_Days.ValueChanged, Input_Hours.ValueChanged, Input_Seconds.ValueChanged, Input_Minutes.ValueChanged


        Timer.Stop()


        _Goofy_Years += Input_Years.Value
        _Goofy_Days += Input_Days.Value
        _Goofy_Months += Input_Months.Value

        _Goofy_Hours += Input_Hours.Value
        _Goofy_Minutes += Input_Minutes.Value
        _Goofy_Seconds += Input_Seconds.Value



        Startbtn.Enabled = True
        Startbtn.BackColor = Color.Lime

    End Sub




    Private Sub Update_Time(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim current_time As DateTime = DateTime.Now.ToString()


        current_time = current_time.AddDays(_Goofy_Days)
        current_time = current_time.AddMonths(_Goofy_Months)
        current_time = current_time.AddYears(_Goofy_Years)


        current_time = current_time.AddMinutes(_Goofy_Minutes)
        current_time = current_time.AddSeconds(_Goofy_Seconds)
        current_time = current_time.AddHours(_Goofy_Hours)



        If (current_time.Second Mod 2 = 0) Then
            TimeText.ForeColor = Color.Black
        Else
            TimeText.ForeColor = Color.Gray

        End If

        TimeText.Text = current_time
    End Sub

    Private Sub TimeText_TextChanged(sender As Object, e As EventArgs) Handles TimeText.TextChanged

    End Sub


End Class
