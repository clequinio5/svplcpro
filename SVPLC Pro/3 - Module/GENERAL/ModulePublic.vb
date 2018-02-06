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

End Module
