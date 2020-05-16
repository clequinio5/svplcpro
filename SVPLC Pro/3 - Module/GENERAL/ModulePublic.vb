Module ModulePublic
    Public PlancheMax As Integer = 22
    Public Function Mois2Integer(ByVal mois As String) As Integer
        For i = 0 To 23
            If MoisCalendrier(i) = mois Then
                Return i
                Exit Function
            End If
        Next
        Return -1
    End Function

    Public Function Factorielle(ByVal N As Long) As Long
        If N = 0 Then
            Return 0
        End If
        Dim i As Long
        Dim result As Long = 1
        For i = 1 To N
            result = i * result
        Next
        Return result
    End Function

End Module
