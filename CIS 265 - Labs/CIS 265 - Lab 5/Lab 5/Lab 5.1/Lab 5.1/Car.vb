'question 3'

Public Class Car

    Private _Make As String
    Private _Model As String
    Private _Year As String

    Sub New(make As String, model As String, year As Integer)
        _Make = make
        _Model = model
        _Year = year
    End Sub

    Public Overrides Function toString() As String

        Return $" Make: {_Make}
 Model: {_Model}
 Year: {_Year}
"
    End Function
End Class
