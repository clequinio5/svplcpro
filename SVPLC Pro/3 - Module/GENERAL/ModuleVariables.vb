
Module ModuleVariables
    Public MoisCalendrier() As String
    Public Destdir As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\SVPLC Pro"
    Public PathPlantes As String
    Public PathEntretien As String
    Public PathAssociations As String
    Public PathRotations As String
    Public PathImage As String
    Public PathAction As String
    Public NParcelle As Parcelle
    Public NSerie As Serie
    Public NombreTabPageSession As Integer
    Public Echelle As Decimal
    Public NDalleSetup As Integer = 25
    Public cDalleSetupSPACE As Integer = 50
    Public cDalleSetupTMPA As Integer = 25
    Public ColorGrid As Color = Color.LightGray
    Public ColorCell As Color = Color.White
    Public ProjectType As String 'spa ou tmpa ou tmpm

    Enum TypeProjet
        SPACE
        TMP
        TMPA
    End Enum
End Module
