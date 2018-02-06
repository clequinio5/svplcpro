Public Class Entretien
    Private nam, typ As String
    Sub New()
        MyBase.New()
        Me.Name = nam
        Me.Type = typ
       
    End Sub
    Public Property Name() As String
        Get
            Return nam
        End Get
        Set(ByVal Value As String)
            nam = Value
        End Set
    End Property
    Public Property Type() As String
        Get
            Return typ
        End Get
        Set(ByVal Value As String)
            typ = Value
        End Set
    End Property
End Class
