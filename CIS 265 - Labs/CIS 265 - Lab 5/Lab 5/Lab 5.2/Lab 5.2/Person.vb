'question 1 
Public Class Person

    Private _first, _last As String

    Private _birthday As DateTime

    Public Sub New(first As String, last As String, birth As DateTime)
        _first = first
        _last = last
        Me._birthday = birth
    End Sub

    Public Overrides Function ToString() As String

        Return $"First name: {_first}
Last name: {_last}
Birthday: {_birthday}
"
    End Function


End Class
