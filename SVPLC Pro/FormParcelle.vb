Public Class FormParcelle
    Private Sub FormParcelle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim col As DataGridViewComboBoxColumn = DTGEntretien.Columns(0)
        With FormP.ListViewEntretien
            For i = 0 To .Items.Count - 1
                col.Items.Add(.Items(i).Text)
            Next
        End With
    End Sub

    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click

        Dim Tachesassociées As New List(Of Tache)
        For i = 0 To DTGEntretien.Rows.Count - 2
            Dim NouvTache As New Tache
            With NouvTache
                .Name = DTGEntretien(0, i).Value
                .Action = DTGEntretien(1, i).Value
                .Debut = DTGEntretien(2, i).Value
                .Fin = DTGEntretien(3, i).Value
                .Commentaire = DTGEntretien(4, i).Value
            End With
            Tachesassociées.Add(NouvTache)
        Next

        Dim NouvParcelle As New Parcelle
        With NouvParcelle
            .Name = TextBoxNomParcelle.Text
            .Plante = LabelPlante.Text
            .Debut = DateTimePicker1.Value.ToString("dd/MM/yyyy")
            .Fin = DateTimePicker2.Value.ToString("dd/MM/yyyy")
            .Commentaire = RichTextBoxCommentaires.Text
            .Taches = Tachesassociées
        End With

            NParcelle = NouvParcelle


    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DTGEntretien.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If DTGEntretien.CurrentCell.ColumnIndex = 0 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        With FormP.ListViewEntretien
            For i = 0 To .Items.Count - 1
                If .Items(i).Text = combo.SelectedItem Then
                    DTGEntretien(DTGEntretien.CurrentCell.ColumnIndex + 1, DTGEntretien.CurrentCell.RowIndex).Value = .Items(i).SubItems(1).Text
                End If
            Next
        End With
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            DateTimePicker2.Value = DateTimePicker1.Value
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value < DateTimePicker1.Value Then
            DateTimePicker1.Value = DateTimePicker2.Value
        End If
    End Sub
End Class