Public Class Parcelle
    Private nam, plant, datedebut, datefin, com As String
    Private tach As New List(Of Tache)
    Sub New()
        MyBase.New()
        Me.Name = nam
        Me.Plante = plant
        Me.Debut = datedebut
        Me.Fin = datefin
        Me.Commentaire = ""
        Me.Taches = Nothing
    End Sub
    Public Property Taches() As List(Of Tache)
        Get
            Return tach
        End Get
        Set(ByVal Value As List(Of Tache))
            tach = Value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return nam
        End Get
        Set(ByVal Value As String)
            nam = Value
        End Set
    End Property
    Public Property Plante() As String
        Get
            Return plant
        End Get
        Set(ByVal Value As String)
            plant = Value
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
