
'question 2 
Public Class Student
    Inherits Person

    Private _homeroom As Integer
    Private _grade As String

    Private _gpa As Double
    Public ReadOnly Property GPA() As Double
        Get
            Return _gpa
        End Get
    End Property

    Private _graduation As DateTime

    Public Sub New(first_name As String, last_name As String, birthday As DateTime, homeroom As String, grade As String, gpa As Double, graduation As DateTime)
        MyBase.New(first_name, last_name, birthday)
        _homeroom = homeroom
        _grade = grade
        _gpa = gpa
        _graduation = graduation
    End Sub


    Public Overrides Function ToString() As String
        Dim output As String = Environment.NewLine & MyBase.ToString()

        output &= $"Homeroom: {_homeroom}
Grade: {_grade}
GPA: {_gpa}
Graduation Year: {_graduation.Year}
"

        Return output
    End Function






End Class
