Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Timer = New Timer()

        Timer.Start()








    End Sub



    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Startbtn.Click


        Timer.Start()
    End Sub

    Private Sub Stop_Click(sender As Object, e As EventArgs) Handles Stopbtn.Click, Input_Years.ValueChanged, Input_Months.ValueChanged, Input_Days.ValueChanged, Input_Hours.ValueChanged, Input_Seconds.ValueChanged, Input_Minutes.ValueChanged



        Timer.Stop()
    End Sub




    Private Sub Update_Time(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim current_time As DateTime = DateTime.Now.ToString()


        current_time = current_time.AddDays(Input_Days.Value)
        current_time = current_time.AddMonths(Input_Months.Value)
        current_time = current_time.AddYears(Input_Years.Value)


        current_time = current_time.AddMinutes(Input_Minutes.Value)
        current_time = current_time.AddSeconds(Input_Seconds.Value)
        current_time = current_time.AddHours(Input_Hours.Value)





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
