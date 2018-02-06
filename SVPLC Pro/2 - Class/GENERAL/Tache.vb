Public Class Tache

    Private nam, act, datedebut, datefin, com As String
    Sub New()
        MyBase.New()
        Me.Name = nam
        Me.Action = act
        Me.Debut = datedebut
        Me.Fin = datefin
        Me.Commentaire = com
    End Sub
    Public Property Name() As String
        Get
            Return nam
        End Get
        Set(ByVal Value As String)
            nam = Value
        End Set
    End Property
    Public Property Action() As String
        Get
            Return act
        End Get
        Set(ByVal Value As String)
            act = Value
        End Set
    End Property
    Public Property Debut() As String
        Get
            Return datedebut
        End Get
        Set(ByVal Value As String)
            datedebut = Value
        End Set
    End Property
    Public Property Fin() As String
        Get
            Return datefin
        End Get
        Set(ByVal Value As String)
            datefin = Value
        End Set
    End Property
    Public Property Commentaire() As String
        Get
            Return com
        End Get
        Set(ByVal Value As String)
            com = Value
        End Set
    End Property
End Class
