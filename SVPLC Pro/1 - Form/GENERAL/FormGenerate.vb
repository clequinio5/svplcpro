Imports System.IO
Imports System.Text
Imports System.Threading

Public Class FormGenerate
    Dim NBestResult As Integer = 10000
    Dim sortColumn As Integer = -1
    Dim dtgr As DTGSPACE
    Dim progress As Integer = 0
    Dim MPAss As Integer(,)
    Dim MPRot As Integer()
    Dim PN2I As New Dictionary(Of String, Integer)
    Dim I2PN As New Dictionary(Of Integer, String)
    Dim I2PP As New Dictionary(Of Integer, String)
    Dim BDDRot As New Dictionary(Of String, Integer)
    Dim BDDAss As New Dictionary(Of String, Integer)
    Property DTG() As DTGSPACE
        Get
            Return dtgr
        End Get
        Set(ByVal Value As DTGSPACE)
            dtgr = Value
        End Set
    End Property
    Private Sub FormGenerate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim NParcelles As Integer = DTG.Parcelles.Count
        ReDim MPAss(NParcelles, NParcelles)
        ReDim MPRot(NParcelles)

        Dim strg() As String
        Dim lecture As StreamReader = New StreamReader(PathAssociations, Encoding.Default)
        While lecture.Peek <> -1
            strg = lecture.ReadLine.Split("|")
            Try
                BDDAss.Add(strg(0) & strg(1), strg(2))
                BDDAss.Add(strg(1) & strg(0), strg(2))
            Catch ex As Exception
            End Try
        End While
        lecture.Close()

        lecture = New StreamReader(PathRotations, Encoding.Default)
        While lecture.Peek <> -1
            strg = lecture.ReadLine.Split("|")
            Try
                BDDRot.Add(strg(0) & strg(1), strg(2))
            Catch ex As Exception
            End Try
        End While
        lecture.Close()


        Dim lblplante As String = ""
        Dim compt As Integer = 0
        For Each prc As Parcelle In DTG.Parcelles
            lblplante += prc.Plante & vbCrLf
            PN2I.Add(prc.Name, compt)
            I2PN.Add(compt, prc.Name)
            I2PP.Add(compt, prc.Plante)
            compt += 1
        Next

        Dim maxasso As Integer = 0
        For i = 0 To DTG.ColumnCount - 1
            For j = 0 To DTG.RowCount - 1
                If DTG(i, j).Tag <> "" Then

                    Dim cell As CellSPACE = DTG(i, j)
                    Dim cellInt As Integer = PN2I(cell.Parcelle.Name)
                    MPRot(cellInt) = MPRot(cellInt) + 1
                    Try
                        Dim cellD As CellSPACE = DTG(i + 1, j)
                        If cellD.Parcelle.Name <> cell.Parcelle.Name Then
                            MPAss(PN2I(cellD.Parcelle.Name), cellInt) = MPAss(PN2I(cellD.Parcelle.Name), cellInt) + 1
                            MPAss(cellInt, PN2I(cellD.Parcelle.Name)) = MPAss(cellInt, PN2I(cellD.Parcelle.Name)) + 1
                            maxasso += 1
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        Dim cellH As CellSPACE = DTG(i, j + 1)
                        If cellH.Parcelle.Name <> cell.Parcelle.Name Then
                            MPAss(PN2I(cellH.Parcelle.Name), cellInt) = MPAss(PN2I(cellH.Parcelle.Name), cellInt) + 1
                            MPAss(cellInt, PN2I(cellH.Parcelle.Name)) = MPAss(cellInt, PN2I(cellH.Parcelle.Name)) + 1
                            maxasso += 1
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        Dim cellB As CellSPACE = DTG(i, j - 1)
                        If cellB.Parcelle.Name <> cell.Parcelle.Name Then
                            MPAss(PN2I(cellB.Parcelle.Name), cellInt) = MPAss(PN2I(cellB.Parcelle.Name), cellInt) + 1
                            MPAss(cellInt, PN2I(cellB.Parcelle.Name)) = MPAss(cellInt, PN2I(cellB.Parcelle.Name)) + 1
                            maxasso += 1
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        Dim cellG As CellSPACE = DTG(i - 1, j)
                        If cellG.Parcelle.Name <> cell.Parcelle.Name Then
                            MPAss(PN2I(cellG.Parcelle.Name), cellInt) = MPAss(PN2I(cellG.Parcelle.Name), cellInt) + 1
                            MPAss(cellInt, PN2I(cellG.Parcelle.Name)) = MPAss(cellInt, PN2I(cellG.Parcelle.Name)) + 1
                            maxasso += 1
                        End If
                    Catch ex As Exception
                    End Try
                End If
            Next
        Next

        LabelNParcelle.Text = NParcelles
        LabelMaxRotations.Text = MPRot.Sum()
        LabelNCombinaisons.Text = Factorielle(NParcelles)
        LabelMaxAssociations.Text = maxasso / 2
        RichTextBoxPlantes.Text = lblplante
        Label2.Text = "0 / " & LabelNCombinaisons.Text

    End Sub

    Private Sub ButtonPlay_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPlay.Click
        ListViewCalculations.Items.Clear()
        ProgressBar1.Value = 0
        progress = 0
        'sort by IND
        ListViewCalculations_ColumnClick_1(ListViewCalculations, New ColumnClickEventArgs(7))
        ListViewCalculations_ColumnClick_1(ListViewCalculations, New ColumnClickEventArgs(7))
        BackgroundWorkerPlay.RunWorkerAsync()
        ButtonPlay.Enabled = False
        ButtonStop.Enabled = True
    End Sub

    Private Sub ButtonStop_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStop.Click
        BackgroundWorkerPlay.CancelAsync()
        ButtonPlay.Enabled = True
        ButtonStop.Enabled = False
    End Sub

    Private Sub BackgroundWorkerPlay_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerPlay.DoWork
        Dim alphabet As String = "abcdefghijklmnopqrstuvwxyz"
        Dim str As String = alphabet.Substring(0, DTG.Parcelles.Count)
        Dim n As Integer = str.Length
        permute(str, 0, n - 1)
    End Sub
    Private Function A2I(ByVal c As Char) As Integer
        Return Convert.ToInt16(Char.ToUpper(c)) - 65
    End Function
    Private Sub calculateCombinaison(ByVal str As String)

        Dim chrs() As Char = str.ToCharArray()

        Dim NoteRot As Integer = 0
        Dim RotPlus As Integer = 0
        Dim RotMoins As Integer = 0
        Dim strComb As New List(Of String)
        For prcPos = 0 To chrs.Count - 1
            Dim prcNum As Integer = A2I(chrs(prcPos))
            strComb.Add(I2PN(prcPos) & "->" & I2PN(prcNum))
            Dim pondRot As Integer = If(BDDRot.ContainsKey(I2PP(prcPos) & I2PP(prcNum)), BDDRot(I2PP(prcPos) & I2PP(prcNum)), 0)
            If pondRot > 0 Then
                RotPlus += 1
            End If
            If pondRot < 0 Then
                RotMoins += 1
            End If
            NoteRot = NoteRot + MPRot(prcPos) * pondRot
        Next


        Dim NoteAsso As Integer = 0
        Dim AssoPlus As Integer = 0
        Dim AssoMoins As Integer = 0
        For prcPos1 = 0 To chrs.Count - 2
            For prcPos2 = prcPos1 + 1 To chrs.Count - 1
                Dim prcNum1 As Integer = A2I(chrs(prcPos1))
                Dim prcNum2 As Integer = A2I(chrs(prcPos2))
                Dim pondAss As Integer = If(BDDAss.ContainsKey(I2PP(prcNum1) & I2PP(prcNum2)), BDDAss(I2PP(prcNum1) & I2PP(prcNum2)), 0)
                Dim calc As Integer = MPAss(prcPos1, prcPos2) * pondAss
                If pondAss > 0 And calc <> 0 Then
                    AssoPlus += 1
                End If
                If pondAss < 0 And calc <> 0 Then
                    AssoMoins += 1
                End If
                NoteAsso = NoteAsso + calc
            Next
        Next
        NoteAsso = NoteAsso / 2

        Dim IND As Integer = ((AssoPlus + RotPlus) - (AssoMoins + RotMoins)) * Math.Abs((NoteAsso + NoteRot))

        Dim result As New List(Of String)
        With result
            .Add(progress + 1)
            .Add(NoteAsso)
            .Add(NoteRot)
            .Add(AssoPlus)
            .Add(AssoMoins)
            .Add(RotPlus)
            .Add(RotMoins)
            .Add(IND)
            .Add(String.Join(",", strComb))
        End With

        progress += 1
        BackgroundWorkerPlay.ReportProgress(progress, String.Join(";", result))
    End Sub

    Private Sub BackgroundWorkerPlay_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerPlay.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage * 100 / LabelNCombinaisons.Text
        Label2.Text = e.ProgressPercentage & " / " & LabelNCombinaisons.Text

        ListViewCalculations.BeginUpdate()
        Dim arr() As String = Split(e.UserState, ";")
        Dim l As New ListViewItem(arr(0))
        For i = 1 To arr.Length - 1
            l.SubItems.Add(arr(i))
        Next
        ListViewCalculations.Items.Add(l)
        ListViewCalculations.EndUpdate()

    End Sub

    Private Sub ListViewCalculations_ColumnClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewCalculations.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ListViewCalculations.Sorting = SortOrder.Ascending
        Else
            If ListViewCalculations.Sorting = SortOrder.Ascending Then
                ListViewCalculations.Sorting = SortOrder.Descending
            Else
                ListViewCalculations.Sorting = SortOrder.Ascending
            End If
        End If
        ListViewCalculations.Sort()
        ListViewCalculations.ListViewItemSorter = New ListViewItemComparer(e.Column, ListViewCalculations.Sorting)
    End Sub
    Private Sub BackgroundWorkerPlay_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerPlay.RunWorkerCompleted
        ButtonPlay.Enabled = True
        ButtonStop.Enabled = False
    End Sub
    Private Sub permute(ByVal str As String, ByVal l As Integer, ByVal r As Integer)
        If l = r Then
            calculateCombinaison(str)
        Else
            If BackgroundWorkerPlay.CancellationPending Then
                Exit Sub
            End If
            Thread.Sleep(100)
            For i As Integer = l To r
                str = swap(str, l, i)
                permute(str, l + 1, r)
                str = swap(str, l, i)
            Next
        End If
        If BackgroundWorkerPlay.CancellationPending Then
            Exit Sub
        End If
    End Sub
    Private Function swap(ByVal a As String, ByVal i As Integer, ByVal j As Integer) As String
        Dim temp As Char
        Dim charArray As Char() = a.ToCharArray()
        temp = charArray(i)
        charArray(i) = charArray(j)
        charArray(j) = temp
        Dim s As String = New String(charArray)
        Return s
    End Function

    Private Sub ListViewCalculations_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListViewCalculations.DoubleClick
        Dim solution As String = ListViewCalculations.SelectedItems(0).SubItems(8).Text
        Dim PN2P As New Dictionary(Of String, Parcelle)
        For Each prc As Parcelle In DTG.Parcelles
            PN2P.Add(prc.Name, prc)
        Next

        Dim PN2PN As New Dictionary(Of String, Parcelle)
        Dim prcs() As String = Split(solution, ",")
        For Each prc As String In prcs
            Dim map() As String = Split(prc, "->")
            PN2PN.Add(map(0), PN2P(map(1)))
        Next

        FormP.Ajouter_Phase()
        Dim DTGGenerated As DTGSPACE = FormP.TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
        DTGGenerated.Parcelles = DTG.Parcelles
        ChargerListviewParcelles(DTGGenerated)
        For i = 0 To DTG.ColumnCount - 1
            For j = 0 To DTG.RowCount - 1
                If DTG(i, j).Tag <> "" Then
                    Dim c As CellSPACE = DTG(i, j)
                    Dim cellGenerated As CellSPACE = DTGGenerated(i, j)
                    cellGenerated.Parcelle = PN2PN(c.Parcelle.Name)
                End If
            Next
        Next


        Dim PlanteS As String = ""
        Dim CellB, CellH, CellG, CellD, Cell As CellSPACE
        For i = 0 To DTGGenerated.ColumnCount - 1
            For j = 0 To DTGGenerated.RowCount - 1
                Cell = DTGGenerated(i, j)
                If Cell.Parcelle IsNot Nothing Then

                    'TOOLTIP ET TAG
                    With Cell
                        PlanteS = .Parcelle.Plante
                        .Tag = PlanteS
                        .ToolTipText = Parcelle2Tooltip(.Parcelle)
                    End With

                    'DALLES AVOISINNANTES
                    Try
                        CellB = DTGGenerated(i, j + 1)
                    Catch ex As Exception
                        CellB = Nothing
                    End Try
                    Try
                        CellH = DTGGenerated(i, j - 1)
                    Catch ex As Exception
                        CellH = Nothing
                    End Try
                    Try
                        CellG = DTGGenerated(i - 1, j)
                    Catch ex As Exception
                        CellG = Nothing
                    End Try
                    Try
                        CellD = DTGGenerated(i + 1, j)
                    Catch ex As Exception
                        CellD = Nothing
                    End Try

                    If CellH IsNot Nothing Then
                        CellH.PlanteBas = PlanteS
                    End If
                    If CellB IsNot Nothing Then
                        CellB.PlanteHaut = PlanteS
                    End If
                    If CellD IsNot Nothing Then
                        CellD.PlanteGauche = PlanteS
                    End If
                    If CellG IsNot Nothing Then
                        CellG.PlanteDroite = PlanteS
                    End If

                    'DESSIN
                    DTGGenerated.InvalidateCell(Cell)

                End If
            Next
        Next
           

    End Sub

    Private Sub ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = vbOK Then
            Dim lines As New List(Of String)
            For Each item As ListViewItem In ListViewCalculations.SelectedItems
                Dim line As New List(Of String)
                line.Add(item.Text)
                For Each subitm In item.SubItems
                    line.Add(subitm.Text)
                Next
                lines.Add(Join(line.ToArray(), ";"))
            Next
            File.WriteAllText(SaveFileDialog1.FileName, Join(lines.ToArray(), vbCrLf))
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class