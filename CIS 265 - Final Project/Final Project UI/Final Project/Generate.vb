

'For the randomized devices part ;NOT A CLASS (exists for organization)
Module Generate
    Private Random As New Random()

    Function Random_Number(minimum As Integer, maximum As Integer) As Integer
        Return Random.Next(minimum, maximum + 1)
    End Function

    'generates ip address
    Function Random_IP() As String
        Return $"{Random.Next(0, 255 + 1)}.{Random.Next(0, 255 + 1)}.{Random.Next(0, 255 + 1)}.{Random.Next(0, 255 + 1)}"
    End Function

    'generates mac address
    Function Random_Mac() As String
        Dim Mac As String = ""
        Dim generated_number As UShort


        'mac address
        For i = 1 To 6
            generated_number = Random.Next(0, 15 + 1)

            Select Case generated_number
                Case 10
                    Mac &= "A"

                Case 11
                    Mac &= "B"

                Case 12
                    Mac &= "C"

                Case 13
                    Mac &= "D"

                Case 14
                    Mac &= "E"

                Case 15
                    Mac &= "F"

                Case Else
                    Mac &= generated_number
            End Select

            Mac &= Random.Next(0, 9 + 1)

            'no symbol at the end
            If i <> 6 Then
                Mac &= "-"

            End If
        Next

        Return Mac

    End Function

End Module
