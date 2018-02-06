Public Class Plante
    Private nam, fam, typ, viv, met, recolt As String
    Sub New()
        MyBase.New()
        Me.Name = nam
        Me.Famille = fam
        Me.Type = typ
        Me.Vivace = viv
        Me.Mise_en_Terre = met
        Me.Recolte = recolt
    End Sub
    Public Property Name() As String
        Get
            Return nam
        End Get
        Set(ByVal Value As String)
            nam = Value
        End Set
    End Property
    Public Property Famille() As String
        Get
            Return fam
        End Get
        Set(ByVal Value As String)
            fam = Value
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
    Public Property Vivace() As String
        Get
            Return viv
        End Get
        Set(ByVal Value As String)
            viv = Value
        End Set
    End Property
    Public Property Mise_en_Terre() As String
        Get
            Return met
        End Get
        Set(ByVal Value As String)
            met = Value
        End Set
    End Property
    Public Property Recolte() As String
        Get
            Return recolt
        End Get
        Set(ByVal Value As String)
            recolt = Value
        End Set
    End Property
End Class
