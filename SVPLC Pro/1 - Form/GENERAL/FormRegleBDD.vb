Public Class FormRegleBDD
    Private Sub FormRegleBDD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonCouleurGDC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCouleurGDC.Click
        If BoiteCouleur.ShowDialog() = DialogResult.OK Then
            LabelCouleurGDC.BackColor = BoiteCouleur.Color
        End If
    End Sub
    Private Sub Chargement_Regles()

    End Sub
End Class