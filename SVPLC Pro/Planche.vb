Public Class Planche
    Private nam, plant, com As String
    Dim cle As Integer
    Private ctct As New List(Of Planche)
    Sub New()
        MyBase.New()
        Me.Name = nam
        Me.Contacts = Nothing
        Me.cle = -1
    End Sub
    Public Property Contacts() As List(Of Planche)
        Get
            Return ctct
        End Get
        Set(ByVal Value As List(Of Planche))
            ctct = Value
        End Set
    End Property
    Public Property Clef() As Integer
        Get
            Return cle
        End Get
        Set(ByVal Value As Integer)
            cle = Value
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
End Class
