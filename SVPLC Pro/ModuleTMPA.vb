Module ModuleTMPA
    Public Function Serie2Tooltip(ByVal prc As Serie) As String
        With prc
            Serie2Tooltip = .Name & vbCrLf & .Plante
        End With
    End Function
    Public Sub AjouterColumnDTGTMPA(ByVal DTG As DTGTMPA, ByVal c As Integer)
        With DTG
            Dim col As New ColumnCellTMPA()
            .Columns.Add(col)
            col.Width = c
        End With
    End Sub
    Public Sub AjouterLigneDTGTMPA(ByVal DTG As DTGTMPA, ByVal k As Integer, ByVal c As Integer)
        With DTG
            .Rows.Add()
            .Rows(k).Height = c
        End With
    End Sub
    Public Sub ChargerListviewSeries(ByVal dtg As DTGTMPA)
        Dim lv As ListView = dtg.Parent.Parent.Parent.Controls.Find("ListViewSerie", True)(0)
        lv.Items.Clear()
        For Each prc As Serie In dtg.Series
            With prc
                Dim ligne As New ListViewItem({.Name, .Plante, .Commentaire})
                ligne.Tag = prc
                lv.Items.Add(ligne)
                ligne.Selected = True
            End With
        Next
    End Sub
    Public Sub ListViewSerie_Click()
        'AFFICHER LES TACHES ASSOCIEES A LA PARCELLE
        Dim ListViewParcelle As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewSerie", True)(0)
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
    Public Sub ListViewSerie_DoubleClick()
        'MODIFIER UNE PARCELLE
        Dim ListViewP As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewSerie", True)(0)
        Dim DTG As DTGTMPA = FormP.TabControlConstruction.SelectedTab.Controls.Find("DTGridTMPA", True)(0)
        Dim prc As Serie = ListViewP.SelectedItems(0).Tag

        Dim oldttt, newttt As String

        Dim FormModifParcelle As New FormParcelle
        With prc
            oldttt = .Name & vbCrLf & .Plante
        End With
        With FormModifParcelle
            .TextBoxNomParcelle.Text = prc.Name
            .LabelPlante.Text = prc.Plante
            .RichTextBoxCommentaires.Text = prc.Commentaire
        End With

        If FormModifParcelle.ShowDialog() = DialogResult.OK Then
            Dim indexreplace As Integer = ListViewP.SelectedItems(0).Index

            With NParcelle
                newttt = .Name & vbCrLf & .Plante & vbCrLf & "Début: " & .Debut & vbCrLf & "Fin: " & .Fin
            End With

            DTG.Series.RemoveAt(indexreplace)
            DTG.Series.Insert(indexreplace, NSerie)

            For i = 0 To DTG.ColumnCount - 1
                For j = 0 To DTG.RowCount - 1
                    If DTG(i, j).ToolTipText IsNot Nothing Then
                        If DTG(i, j).ToolTipText = oldttt Then
                            DTG(i, j).ToolTipText = newttt
                        End If

                    End If
                Next
            Next

            ChargerListviewSeries(DTG)

        End If

    End Sub
    Public Sub ListViewSerie_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Dim ListviewP As ListView = sender
            Dim DTG As DTGTMPA = FormP.TabControlConstruction.SelectedTab.Controls.Find("DTGridTMPA", True)(0)
            If MsgBox("Etes vous certain de supprimer les series sélectionnées?", MsgBoxStyle.YesNo, "Confirmation de suppression") = MsgBoxResult.Yes Then
                For Each itm As ListViewItem In ListviewP.SelectedItems

                    DTG.Series.Remove(itm.Tag)

                    For i = 0 To DTG.ColumnCount - 1
                        For j = 0 To DTG.RowCount - 1
                            If DTG(i, j).ToolTipText IsNot Nothing Then
                                If DTG(i, j).ToolTipText.ToString.StartsWith(itm.Text) Then

                                    Dim Cell As CellTMPA = DTG(i, j)
                                    With Cell
                                        .Tag = ""
                                        .ToolTipText = ""
                                    End With

                                    Dim CellB As CellTMPA = DTG(i, j + 1)
                                    With CellB
                                        .PlanteHaut = ""
                                    End With
                                    Dim CellH As CellTMPA = DTG(i, j - 1)
                                    With CellH
                                        .PlanteBas = ""
                                    End With
                                    Dim CellG As CellTMPA = DTG(i - 1, j)
                                    With CellG
                                        .PlanteDroite = ""
                                    End With

                                    Dim CellD As CellTMPA = DTG(i + 1, j)
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

                    ChargerListviewSeries(DTG)

                Next

            End If

        End If
    End Sub
End Module
