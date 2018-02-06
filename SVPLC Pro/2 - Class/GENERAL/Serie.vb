Public Class Serie
    Dim nam, com, plant As String
    Private tach As New List(Of Tache)
    Sub New()
        MyBase.New()
        Me.Name = nam

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
    Public Property Commentaire() As String
        Get
            Return com
        End Get
        Set(ByVal Value As String)
            com = Value
        End Set
    End Property
End Class
