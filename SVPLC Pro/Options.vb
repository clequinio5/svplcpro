Public Class FormOptions

    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelColorGrid.BackColor = ColorGrid
        LabelColorCell.BackColor = ColorCell
    End Sub

    Private Sub LabelColorGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelColorGrid.Click
        If ColorDialog1.ShowDialog = vbOK Then
            LabelColorGrid.BackColor = ColorDialog1.Color
            ColorGrid = LabelColorGrid.BackColor
            Change_Couleurs()
        End If
    End Sub

    Private Sub LabelColorCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelColorCell.Click
        If ColorDialog1.ShowDialog = vbOK Then
            LabelColorCell.BackColor = ColorDialog1.Color
            ColorCell = LabelColorCell.BackColor
            Change_Couleurs()
        End If
    End Sub
End Class