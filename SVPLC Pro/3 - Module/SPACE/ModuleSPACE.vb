Module ModuleSPACE
    Public Function Parcelle2Tooltip(ByVal prc As Parcelle) As String
        With prc
            Parcelle2Tooltip = .Name & vbCrLf & .Plante & vbCrLf & "Début: " & .Debut & vbCrLf & "Fin: " & .Fin
        End With
    End Function
    Public Sub AjouterColumnDTGSPACE(ByVal DTG As DTGSPACE, ByVal i As Integer, ByVal c As Integer)
        With DTG
            Dim col As New ColumnCellSPACE()
            .Columns.Add(col)
            .Columns(i).HeaderText = i * Echelle
            .Columns(i).Tag = i
            .Columns(i).Width = c
            .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        End With
    End Sub
    Public Sub AjouterLigneDTGSPACE(ByVal DTG As DTGSPACE, ByVal i As Integer, ByVal c As Integer)
        With DTG
            .Rows.Add()
            .Rows(i).HeaderCell.Value = (i * Echelle).ToString
            .Rows(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .Rows(i).Height = c
            .Rows(i).Tag = i
        End With
    End Sub
    Public Sub ChargerListviewParcelles(ByVal dtg As DTGSPACE)
        Dim lv As ListView = dtg.Parent.Parent.Parent.Controls.Find("ListViewParcelle", True)(0)
        lv.Items.Clear()
        For Each prc As Parcelle In dtg.Parcelles
            With prc
                Dim ligne As New ListViewItem({.Name, .Plante, .Debut, .Fin, .Commentaire})
                ligne.Tag = prc
                lv.Items.Add(ligne)
                ligne.Selected = True
            End With
        Next
    End Sub
    Public Sub ListViewParcelle_Click()
        'AFFICHER LES TACHES ASSOCIEES A LA PARCELLE
        Dim ListViewParcelle As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewParcelle", True)(0)
        Dim ListViewTaches As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewTaches", True)(0)
        ListViewTaches.Items.Clear()
        Dim ParcelleSelectionnee As Parcelle = ListViewParcelle.SelectedItems(0).Tag
        If ParcelleSelectionnee.Taches IsNot Nothing Then
            For Each tch As Tache In ParcelleSelectionnee.Taches
                With tch
                    Dim ligne As New ListViewItem({.Name, .Action, .Debut, .Fin, .Commentaire})
                    ligne.Tag = tch
                    ListViewTaches.Items.Add(ligne)
                End With
            Next
        End If
    End Sub
    Public Sub ListViewParcelle_DoubleClick()
        'MODIFIER UNE PARCELLE
        Dim ListViewP As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewParcelle", True)(0)
        Dim DTG As DTGSPACE = FormP.TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
        Dim prc As Parcelle = ListViewP.SelectedItems(0).Tag

        Dim oldttt, newttt As String

        Dim FormModifParcelle As New FormParcelle
        With prc
            oldttt = .Name & vbCrLf & .Plante & vbCrLf & "Début: " & .Debut & vbCrLf & "Fin: " & .Fin
        End With
        With FormModifParcelle
            .TextBoxNomParcelle.Text = prc.Name
            .LabelPlante.Text = prc.Plante
            .DateTimePicker1.Value = CDate(prc.Debut)
            .DateTimePicker2.Value = CDate(prc.Fin)
            .RichTextBoxCommentaires.Text = prc.Commentaire
        End With

        If FormModifParcelle.ShowDialog() = DialogResult.OK Then
            Dim indexreplace As Integer = ListViewP.SelectedItems(0).Index

            With NParcelle
                newttt = .Name & vbCrLf & .Plante & vbCrLf & "Début: " & .Debut & vbCrLf & "Fin: " & .Fin
            End With

            DTG.Parcelles.RemoveAt(indexreplace)
            DTG.Parcelles.Insert(indexreplace, NParcelle)

            For i = 0 To DTG.ColumnCount - 1
                For j = 0 To DTG.RowCount - 1
                    If DTG(i, j).ToolTipText IsNot Nothing Then
                        If DTG(i, j).ToolTipText = oldttt Then
                            DTG(i, j).ToolTipText = newttt
                        End If

                    End If
                Next
            Next

            ChargerListviewParcelles(DTG)

        End If

    End Sub
    Public Sub ListViewParcelle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Dim ListviewP As ListView = sender
            Dim DTG As DTGSPACE = FormP.TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
            If MsgBox("Etes vous certain de supprimer les parcelles sélectionnées?", MsgBoxStyle.YesNo, "Confirmation de suppression") = MsgBoxResult.Yes Then
                For Each itm As ListViewItem In ListviewP.SelectedItems

                    DTG.Parcelles.Remove(itm.Tag)

                    For i = 0 To DTG.ColumnCount - 1
                        For j = 0 To DTG.RowCount - 1
                            If DTG(i, j).ToolTipText IsNot Nothing Then
                                If DTG(i, j).ToolTipText.ToString.StartsWith(itm.Text) Then

                                    Dim Cell As CellSPACE = DTG(i, j)
                                    With Cell
                                        .Tag = ""
                                        .ToolTipText = ""
                                    End With

                                    Dim CellB As CellSPACE = DTG(i, j + 1)
                                    With CellB
                                        .PlanteHaut = ""
                                    End With
                                    Dim CellH As CellSPACE = DTG(i, j - 1)
                                    With CellH
                                        .PlanteBas = ""
                                    End With
                                    Dim CellG As CellSPACE = DTG(i - 1, j)
                                    With CellG
                                        .PlanteDroite = ""
                                    End With

                                    Dim CellD As CellSPACE = DTG(i + 1, j)
                                    With CellD
                                        .PlanteGauche = ""
                                    End With

                                    DTG.InvalidateCell(Cell)
                                    DTG.InvalidateCell(CellB)
                                    DTG.InvalidateCell(CellH)
                                    DTG.InvalidateCell(CellG)
                                    DTG.InvalidateCell(CellD)

                                End If
                            End If
                        Next
                    Next

                    ChargerListviewParcelles(DTG)

                Next

            End If

        End If
    End Sub
    Public Function RechercherBDDDTG(ByVal BDD As DataGridView, ByVal str1 As String, ByVal str2 As String) As String()
        'RECHERCHE UNE VALEUR DANS LA BDD ASSO OU ROT
        If BDD Is FormP.DataGridViewAssociations Then
            If str1 > str2 Then
                Dim stock As String
                stock = str2
                str2 = str1
                str1 = stock
            End If
        End If
        Dim resultat(1) As String
        If str1 <> "" Then
            If str2 <> "" Then
                For i = 0 To BDD.Columns.Count - 1
                    For j = 0 To BDD.Rows.Count - 1
                        If BDD.Columns.Item(i).HeaderText = str1 Then
                            If BDD.Rows.Item(j).HeaderCell.Value = str2 Then
                                If BDD(i, j).Value = "" Then
                                    resultat(0) = 0
                                Else
                                    resultat(0) = BDD(i, j).Value
                                End If
                                resultat(1) = BDD(i, j).ToolTipText
                                Return resultat
                                Exit Function
                            End If
                        End If
                    Next
                Next

            End If
        End If
        resultat(0) = 0
        resultat(1) = ""
        Return resultat
    End Function
    Public Sub Change_Couleurs()
        For Each tbp As TabPage In FormP.TabControlConstruction.TabPages
            If TypeOf tbp Is TabPageSPACE Then
                Dim DTG As DTGSPACE = tbp.Controls.Find("DTGridSPACE", True)(0)
                DTG.GridColor = ColorGrid
                For i = 0 To DTG.Columns.Count - 1
                    For j = 0 To DTG.Rows.Count - 1
                        DTG(i, j).Style.BackColor = ColorCell
                    Next
                Next
            End If
        Next
    End Sub

End Module
