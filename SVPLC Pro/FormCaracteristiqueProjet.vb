Public Class FormCaracteristiqueProjet
    Private Sub FormCaracteristiqueProjet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxDivision.SelectedItem = "1 Semaine - 7 Jours"
        LabelDebut.Text = MonthCalendarDebut.SelectionRange.Start.ToString("dd/MM/yyyy")
        LabelFin.Text = MonthCalendarFin.SelectionRange.Start.ToString("dd/MM/yyyy")
    End Sub
    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        Me.Close()
    End Sub

    
    Private Sub MonthCalendarDebut_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendarDebut.DateSelected
        LabelDebut.Text = MonthCalendarDebut.SelectionRange.Start.ToString("dd/MM/yyyy")
        'Dim str As String = MonthCalendarDebut.SelectionRange.Start.ToString("dd/MM/yyyy")
        'LabelDebut.Text = str & " (sem. " & DatePart(DateInterval.WeekOfYear, CDate(str)) & ")"
    End Sub

    Private Sub MonthCalendarFin_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendarFin.DateSelected
        LabelFin.Text = MonthCalendarFin.SelectionRange.Start.ToString("dd/MM/yyyy")
    End Sub
End Class