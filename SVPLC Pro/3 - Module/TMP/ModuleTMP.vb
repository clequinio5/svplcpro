Module ModuleTMP
    Public PlancheColor() As Color
    Public ProjectTMPDebut, ProjectTMPFin, ProjectTMPDivisionTemps As String
    Public ProjectTMPDivisionSpatial As Decimal
    Public NColumnTMPA As Integer
    Public NLigneTMPA As Integer
    Public ProjetTMPNPlanche As Integer
    Public ProjetTMPLongueur, ProjetTMPLargeur, ProjetTMPEspacement As Decimal
    Public Sub AjouterColumnDTGTMP1(ByVal DTG As DTGTMP1, ByVal i As Integer, ByVal c As Integer)
        With DTG
            Dim col As New ColumnCellTMP1()
            .Columns.Add(col)
            .Columns(i).HeaderText = i * Echelle
            .Columns(i).Tag = i
            .Columns(i).Width = c
            .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        End With
    End Sub
    Public Sub AjouterLigneDTGTMP1(ByVal DTG As DTGTMP1, ByVal i As Integer, ByVal c As Integer)
        With DTG
            .Rows.Add()
            .Rows(i).HeaderCell.Value = (i * Echelle).ToString
            .Rows(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .Rows(i).Height = c
            .Rows(i).Tag = i
        End With
    End Sub
    Public Function ColorComplementaire(ByVal col As Color) As Color
        Return Color.FromArgb(255, 255 - col.R, 255 - col.G, 255 - col.B)
    End Function
End Module
