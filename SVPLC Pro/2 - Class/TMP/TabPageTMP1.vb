Public Class TabPageTMP1
    Inherits TabPage

    Private WithEvents DTGrid As New DTGTMP1
    Private WithEvents tblayout As New TableLayoutPanel
    Private WithEvents BtnPart As New Button
    Private WithEvents BtnOk As New Button
    Private WithEvents ListViewPlanche As New ListView

    Public Sub New()

        Me.Text = "Partitionnement"

        With DTGrid
            AddHandler .KeyDown, AddressOf DTGrid_KeyDown
        End With

        With BtnOk
            .Text = "Ok"
            .Dock = DockStyle.Fill
            .Name = "BtnOk"
            AddHandler .Click, AddressOf BtnOk_Click
            .Enabled = False
        End With

        With BtnPart
            .Text = "Partitionner"
            .Dock = DockStyle.Fill
            .Name = "BtnPart"
            AddHandler .Click, AddressOf BtnPart_Click
        End With

        With ListViewPlanche
            .Dock = DockStyle.Fill
            .MultiSelect = False
            .FullRowSelect = True
            .Name = "ListViewPlanche"
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Nom", 200)
            .Columns.Add("Couleur", 200)
            AddHandler .DoubleClick, AddressOf ListViewPlanche_DoubleClick
            AddHandler .KeyDown, AddressOf ListViewPlanche_KeyDown
        End With

        With tblayout
            .ColumnCount = 2
            .RowCount = 3
            .Dock = DockStyle.Fill
            .Margin = New Padding(0, 0, 0, 0)
            .ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            .ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 130.0F))
            .RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            .RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
            .RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))
            .SetColumnSpan(DTGrid, 2)
            .Controls.Add(DTGrid, 0, 0)
            .Controls.Add(BtnPart, 1, 1)
            .Controls.Add(BtnOk, 1, 2)
            .SetRowSpan(ListViewPlanche, 2)
            .Controls.Add(ListViewPlanche, 0, 1)
        End With

        Me.Controls.Add(tblayout)

    End Sub
    Private Sub DTGrid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyValue = Keys.Enter Then
            BtnPart.PerformClick()
        End If
    End Sub
    Private Sub BtnOk_Click()

        Dim tbc As TabControl = Me.Parent
        Dim EnCours As Boolean = False
        For i = 0 To tbc.TabPages.Count - 1
            If TypeOf tbc.TabPages.Item(i).Tag Is Planche Then
                EnCours = True
            End If
        Next

        If EnCours = True Then
            If MsgBox("Un projet temporel est déjà en cours, il sera supprimé.", MsgBoxStyle.OkCancel, "Supprimer le projet en cours?") = vbOK Then

                If FormCaracteristiqueProjet.ShowDialog() = vbOK Then

                    For Each tbp As TabPage In tbc.TabPages
                        If TypeOf tbp.Tag Is Planche Then
                            tbp.Dispose()
                        End If
                    Next

                    Dim Tabcontrol As TabControl = Me.Parent
                    ProjectTMPDebut = FormCaracteristiqueProjet.LabelDebut.Text
                    ProjectTMPFin = FormCaracteristiqueProjet.LabelFin.Text
                    ProjectTMPDivisionTemps = FormCaracteristiqueProjet.ComboBoxDivision.Text

                    For i = 0 To ListViewPlanche.Items.Count - 1
                        Dim tbp As New TabPage
                        With tbp
                            .BackColor = PlancheColor(i)
                            .Tag = ListViewPlanche.Items(i).Tag
                            .Text = ListViewPlanche.Items(i).Text
                        End With
                        Tabcontrol.Controls.Add(tbp)
                    Next
                    Tabcontrol.SelectedIndex = 1
                End If
            End If
        Else

            FormCaracteristiqueProjet.ComboBoxSpatiale.Enabled = False
            FormCaracteristiqueProjet.Label2.Enabled = False

            If FormCaracteristiqueProjet.ShowDialog() = DialogResult.OK Then
                Dim Tabcontrol As TabControl = Me.Parent
                ProjectTMPDebut = FormCaracteristiqueProjet.LabelDebut.Text
                ProjectTMPFin = FormCaracteristiqueProjet.LabelFin.Text
                ProjectTMPDivisionTemps = FormCaracteristiqueProjet.ComboBoxDivision.Text

                For i = 0 To ListViewPlanche.Items.Count - 1
                    Dim tbp As New TabPage
                    With tbp
                        .BackColor = PlancheColor(i)
                        .Tag = ListViewPlanche.Items(i).Tag
                        .Text = ListViewPlanche.Items(i).Text
                    End With
                    Tabcontrol.Controls.Add(tbp)
                Next
                Tabcontrol.SelectedIndex = 1

            End If
        End If
       

    End Sub
    Private Sub BtnPart_Click()


        Dim Num As Integer = ListViewPlanche.Items.Count + 1

        If Num < PlancheMax + 1 Then

            Dim NewPlanche As New Planche
            Dim SelectQ As Boolean = False

            For i = 0 To DTGrid.ColumnCount - 1
                For j = 0 To DTGrid.RowCount - 1
                    Dim Cell As CellTMP1 = DTGrid(i, j)
                    With Cell
                        If .SelectedQ = True And .Planche Is Nothing Then
                            .Planche = NewPlanche
                            .SelectedQ = False
                            SelectQ = True
                        End If
                    End With
                    DTGrid.InvalidateCell(Cell)
                Next
            Next

            If SelectQ = False Then
                Exit Sub
            End If


            With NewPlanche
                .Name = "Planche" & Num
                .Clef = Num
                Dim ligne As New ListViewItem({.Name, Num})
                With ligne
                    .UseItemStyleForSubItems = False
                    .SubItems(1).BackColor = PlancheColor(Num - 1)
                    '.SubItems(1).Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    .Tag = NewPlanche
                    .Selected = True
                End With
                ListViewPlanche.Items.Add(ligne)
            End With

            BtnOk.Enabled = True

        Else
            MsgBox("Vous avez atteint le nombre maximum de planches", MsgBoxStyle.Information, "Limite de planches atteintes")
        End If

    End Sub
    Private Sub ListViewPlanche_DoubleClick()

    End Sub
    Private Sub ListViewPlanche_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyValue = Keys.Delete Then
            If MsgBox("Voulez vous vraiment supprimer la planche selectionnée?", MsgBoxStyle.OkCancel, "Suppression d'une planche") = vbOK Then
                'Actualisation listview
                Dim RemovedClef As Integer = ListViewPlanche.SelectedItems(0).SubItems(1).Text

                For i = RemovedClef To ListViewPlanche.Items.Count
                    Dim plch As Planche = ListViewPlanche.Items(i - 1).Tag
                    If RemovedClef = i Then
                        plch.Clef = -1
                    Else
                        plch.Clef -= 1
                        ListViewPlanche.Items(i - 1).Text = "Planche" & plch.Clef
                        With ListViewPlanche.Items(i - 1).SubItems(1)
                            .BackColor = PlancheColor(plch.Clef - 1)
                            .Text = plch.Clef
                        End With
                    End If
                Next
                ListViewPlanche.SelectedItems(0).Remove()

                'Actualisation grille
                For i = 0 To DTGrid.ColumnCount - 1
                    For j = 0 To DTGrid.RowCount - 1
                        DTGrid.InvalidateCell(DTGrid(i, j))
                    Next
                Next

            End If
        End If
        If ListViewPlanche.Items.Count > 0 Then
            BtnOk.Enabled = True
        Else
            BtnOk.Enabled = False
        End If
    End Sub
End Class
