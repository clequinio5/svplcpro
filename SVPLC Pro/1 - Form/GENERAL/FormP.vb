Imports System.IO
Imports System.Text
Imports System.Drawing.Drawing2D
Public Class FormP
    Dim sortColumn As Integer = -1
  Private Sub FormP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strArgs() As String = Environment.GetCommandLineArgs()

        If (strArgs.Length > 1) Then
            Charger_fichier_SPACE(strArgs(1))
        End If

        If Directory.Exists(Destdir) = False Then
            Directory.CreateDirectory(Destdir)
        End If

        EnregistrerLeProjetToolStripMenuItem.Enabled = False
        AjouterPhase.Enabled = False
        SupprimerPhaseActive.Enabled = False

        PathAssociations = Destdir & "\BDD Associations.txt"
        PathRotations = Destdir & "\BDD Rotations.txt"
        PathImage = Destdir & "\IMAGES"
        PathPlantes = Destdir & "\BDD Plantes.txt"
        PathEntretien = Destdir & "\BDD Entretien.txt"

        Chargement_Images()
        Chargement_Plantes()
        Chargement_Associations()
        Chargement_Rotations()
        Chargement_Entretien()

        ReDim MoisCalendrier(23)
        MoisCalendrier(0) = "début Janvier"
        MoisCalendrier(1) = "mi Janvier"
        MoisCalendrier(2) = "début Février"
        MoisCalendrier(3) = "mi Février"
        MoisCalendrier(4) = "début Mars"
        MoisCalendrier(5) = "mi Mars"
        MoisCalendrier(6) = "début Avril"
        MoisCalendrier(7) = "mi Avril"
        MoisCalendrier(8) = "début Mai"
        MoisCalendrier(9) = "mi Mai"
        MoisCalendrier(10) = "début Juin"
        MoisCalendrier(11) = "mi Juin"
        MoisCalendrier(12) = "début Juillet"
        MoisCalendrier(13) = "mi Juillet"
        MoisCalendrier(14) = "début Aout"
        MoisCalendrier(15) = "mi Aout"
        MoisCalendrier(16) = "début Septembre"
        MoisCalendrier(17) = "mi Septembre"
        MoisCalendrier(18) = "début Octobre"
        MoisCalendrier(19) = "mi Octobre"
        MoisCalendrier(20) = "début Novembre"
        MoisCalendrier(21) = "mi Novembre"
        MoisCalendrier(22) = "début Décembre"
        MoisCalendrier(23) = "mi Décembre"

        NombreTabPageSession = 1

        MenuConstructionUnVisible()

    End Sub
    Private Sub MenuConstructionVisible()
        MenuConstruction.Enabled = True
        MenuConstruction.BackColor = Color.DarkOrange
        EchelleLabel.Visible = True
        EchelleTextbox.Visible = True
        ProjectMenuItem.Visible = True
        OutilsToolStripMenuItem.Visible = True
    End Sub
    Private Sub MenuConstructionUnVisible()
        MenuConstruction.Enabled = False
        MenuConstruction.BackColor = Color.DarkGray
        EchelleLabel.Visible = False
        EchelleTextbox.Visible = False
        ProjectMenuItem.Visible = False
        OutilsToolStripMenuItem.Visible = False
    End Sub
    '=========================================================================================================
    'FICHIER
    Private Sub NouveauProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauProjetToolStripMenuItem.Click
        FormNomPhaseSPACE.TextBoxNomPhase.Text = "Phase" & NombreTabPageSession
        FormNomPhaseSPACE.TextBoxNomPhase.SelectAll()
        If FormNomPhaseSPACE.ShowDialog = DialogResult.OK Then
            Reset()
            NewProjectSPA()
        End If
    End Sub
    Private Sub NewProjectSPA()
        ProjectType = TypeProjet.SPACE

        Dim str As String = FormNomPhaseSPACE.TextBoxNomPhase.Text
        If str <> "" Then
            Dim NewTabPage As New TabPageSPACE
            NewTabPage.Text = str
            TabControlConstruction.Controls.Add(NewTabPage)
            TabControlConstruction.SelectedTab = NewTabPage
            NombreTabPageSession += 1

            MenuConstructionVisible()

            Echelle = 0
            EchelleTextbox.Text = "0"
            EnregistrerLeProjetToolStripMenuItem.Enabled = True

            AjouterPhase.Enabled = True
            SupprimerPhaseActive.Enabled = True

        End If
    End Sub
  
    Private Sub Reset()
        'initialisation
        For Each tbp In TabControlConstruction.TabPages
            tbp.dispose()
        Next
        NombreTabPageSession = 1
        MenuConstructionUnVisible()
    End Sub
    
    Private Sub EnregistrerLeProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerLeProjetToolStripMenuItem.Click
      
                Try
                    SaveFileDialog1.FileName = "ProjectSVPLCPro"
                    If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Dim nomfichier As String = SaveFileDialog1.FileName
                        Dim Ecriture As New StreamWriter(nomfichier, False, System.Text.Encoding.Default)
                        Ecriture.WriteLine(Echelle)
                        For Each tbp As TabPage In TabControlConstruction.TabPages
                            If tbp.Tag <> "Bienvenue" Then
                                Dim DTG As DTGSPACE = tbp.Controls.Find("DTGridSPACE", True)(0)

                                'NOM DE LA PAGE
                                Ecriture.WriteLine("PHASE")
                                Ecriture.WriteLine("*" & tbp.Text)
                                Ecriture.WriteLine(DTG.ColumnCount & "|" & DTG.RowCount)

                                'PARCELLES et TACHES
                                Ecriture.WriteLine("PARCELLES ET TACHES")
                                For Each prc As Parcelle In DTG.Parcelles
                                    With prc
                                        Ecriture.WriteLine("`" & .Name & "|" & .Plante & "|" & .Debut & "|" & .Fin & "|" & .Commentaire)
                                        For Each tch As Tache In .Taches
                                            With tch
                                                Ecriture.WriteLine("+" & .Name & "|" & .Action & "|" & .Debut & "|" & .Fin & "|" & .Commentaire)
                                            End With
                                        Next
                                    End With
                                Next

                                'NOM PARCELLE
                                Ecriture.WriteLine("DALLES")
                                For i = 0 To DTG.ColumnCount - 1
                                    For j = 0 To DTG.RowCount - 1
                                        If DTG(i, j).Tag <> "" Then
                                            Dim cell As CellSPACE = DTG(i, j)
                                            With cell
                                                Ecriture.WriteLine("|" & i & "|" & j & "|" & .Parcelle.Name)
                                            End With
                                        End If
                                    Next
                                Next
                            End If
                        Next

                        Ecriture.Close()

                    End If
                Catch ex As Exception
                    MsgBox("Le projet n'a pas pu être enregistré", MsgBoxStyle.Exclamation, "Erreur d'écriture fichier")
                End Try
        
    End Sub
    Private Sub ImporterUnProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImporterUnProjetToolStripMenuItem.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Charger_fichier_SPACE(OpenFileDialog1.FileName)

        End If

    End Sub
    Private Sub Charger_fichier_SPACE(ByVal str As String)

        Try
            Dim lines As String() = File.ReadAllLines(str)
            Dim DTG As DTGSPACE
            Dim tbpselect As TabPageSPACE = Nothing
            Dim prcselect As Parcelle = Nothing
            EchelleTextbox.Text = lines(0)
            Echelle = CDec(EchelleTextbox.Text)
            For i = 0 To lines.Count - 1
                Select Case Mid(lines(i), 1, 1)
                    Case "*"
                        Dim tbp As New TabPageSPACE
                        tbp.Text = Mid(lines(i), 2)
                        DTG = tbp.Controls.Find("DTGridSPACE", True)(0)
                        Dim D As String() = Split(lines(i + 1), "|")
                        For k = NDalleSetup + 1 To CInt(D(0))
                            AjouterColumnDTGSPACE(DTG, k, cDalleSetupSPACE)
                        Next
                        For k = NDalleSetup + 1 To CInt(D(1))
                            AjouterLigneDTGSPACE(DTG, k, cDalleSetupSPACE)
                        Next
                        Me.TabControlConstruction.TabPages.Add(tbp)
                        NombreTabPageSession += 1
                        tbpselect = tbp
                    Case "`"
                        Dim prc As New Parcelle
                        Dim datas() As String = Split(Mid(lines(i), 2), "|")
                        With prc
                            .Name = datas(0)
                            .Plante = datas(1)
                            .Debut = datas(2)
                            .Fin = datas(3)
                            .Commentaire = datas(4)
                        End With
                        DTG = tbpselect.Controls.Find("DTGridSPACE", True)(0)
                        DTG.Parcelles.Add(prc)
                        ChargerListviewParcelles(DTG)
                        prcselect = prc
                    Case "+"
                        Dim tch As New Tache
                        Dim datas() As String = Split(Mid(lines(i), 2), "|")
                        With tch
                            .Name = datas(0)
                            .Action = datas(1)
                            .Debut = datas(2)
                            .Fin = datas(3)
                            .Commentaire = datas(4)
                        End With
                        prcselect.Taches.Add(tch)
                    Case "|"
                        Dim datas() As String = Split(Mid(lines(i), 2), "|")
                        DTG = tbpselect.Controls.Find("DTGridSPACE", True)(0)
                        Dim Cell As CellSPACE = DTG(CInt(datas(0)), CInt(datas(1)))
                        For Each prc As Parcelle In DTG.Parcelles
                            If prc.Name = datas(2) Then
                                Cell.Parcelle = prc
                                Exit Select
                            End If
                        Next
                    Case Else
                End Select
            Next


            For Each tbp As TabPage In Me.TabControlConstruction.TabPages
                If tbp.Text <> "Bienvenue" Then
                    Dim CellB, CellH, CellG, CellD, Cell As CellSPACE
                    Dim PlanteS As String = ""
                    DTG = tbp.Controls.Find("DTGridSPACE", True)(0)
                    For i = 0 To DTG.ColumnCount - 1
                        For j = 0 To DTG.RowCount - 1
                            Cell = DTG(i, j)
                            If Cell.Parcelle IsNot Nothing Then

                                'TOOLTIP ET TAG
                                With Cell
                                    PlanteS = .Parcelle.Plante
                                    .Tag = PlanteS
                                    .ToolTipText = Parcelle2Tooltip(.Parcelle)
                                End With

                                'DALLES AVOISINNANTES
                                Try
                                    CellB = DTG(i, j + 1)
                                Catch ex As Exception
                                    CellB = Nothing
                                End Try
                                Try
                                    CellH = DTG(i, j - 1)
                                Catch ex As Exception
                                    CellH = Nothing
                                End Try
                                Try
                                    CellG = DTG(i - 1, j)
                                Catch ex As Exception
                                    CellG = Nothing
                                End Try
                                Try
                                    CellD = DTG(i + 1, j)
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
                                DTG.InvalidateCell(Cell)

                            End If
                        Next
                    Next
                End If
            Next

            With Me.TabControlConstruction
                .SelectedTab = .TabPages(.TabPages.Count - 1)
            End With

            MenuConstructionVisible()
            EnregistrerLeProjetToolStripMenuItem.Enabled = True


        Catch ex As Exception
            MsgBox("Le fichier est corrompu", MsgBoxStyle.Exclamation, "Erreur chargement fichier")
        End Try

    End Sub
    '=====================================================================================================================
    'PROJET
    Public Sub Ajouter_Phase()
        FormNomPhaseSPACE.TextBoxNomPhase.Text = "Phase" & NombreTabPageSession
        FormNomPhaseSPACE.TextBoxNomPhase.SelectAll()

        If FormNomPhaseSPACE.ShowDialog = DialogResult.OK Then
            Dim str As String = FormNomPhaseSPACE.TextBoxNomPhase.Text
            If str <> "" Then
                Dim NewTabPage As New TabPageSPACE
                NewTabPage.Text = str
                TabControlConstruction.Controls.Add(NewTabPage)
                TabControlConstruction.SelectedTab = NewTabPage
                NombreTabPageSession += 1
            End If
        End If
    End Sub
    Private Sub AjouterUnePhaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterPhase.Click
        Ajouter_Phase()
    End Sub
    Private Sub SupprimerPhaseActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerPhaseActive.Click
        If MsgBox("Etes vous sûr(e) de vouloir supprimer définitivement la phase active?", MsgBoxStyle.OkCancel, "Suppression de la phase active") = vbOK Then
            TabControlConstruction.SelectedTab.Dispose()
            Dim spa As Boolean = False
            For Each tbp In TabControlConstruction.TabPages
                If TypeOf tbp Is TabPageSPACE Then
                    spa = True
                    Exit For
                End If
            Next
            Select Case spa
                Case True
                    MenuConstructionVisible()
                Case False
                    MenuConstructionUnVisible()
                    ProjectType = ""
            End Select
        End If
    End Sub
    Private Sub RenommerLaPhaseActiveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenommerLaPhaseActiveToolStripMenuItem.Click
        TabControlConstruction.SelectedTab.Text = InputBox("Nouveau nom pour la phase active", TabControlConstruction.SelectedTab.Text)
    End Sub
    '===============================================================================================================
    '?
    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Pour toute information, remarque, proposition, etc...n'hésitez pas à envoyer un mail à:" & vbCrLf & vbCrLf & "XXXXXXXX@gmail.com")
    End Sub
    '==============================================================================================================
    'BDD Plante
    Private Sub ListViewPlantes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListViewPlantes.KeyDown
        'SUPPRESSION D'UNE PLANTE
        If e.KeyCode = Keys.Delete Then
            ButtonSupprimerPlante.PerformClick()
        End If
    End Sub
    Private Sub ButtonSupprimerPlante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSupprimerPlante.Click
        Dim NomPlante = ListViewPlantes.SelectedItems(0).Text
        If MsgBox("La plante '" & NomPlante & "' sera supprimée définitivement ainsi que les associations et rotations qui lui sont associées", MsgBoxStyle.YesNo, "Supprimer une plante") = vbYes Then
            Effacer_Image(NomPlante)
            Effacer_de_la_BDDPlantes(NomPlante)
            Effacer_Association(NomPlante)
            Effacer_Rotations(NomPlante)

            Chargement_Images()
            Chargement_Plantes()
            Chargement_Associations()
            Chargement_Rotations()
        End If
    End Sub
    Private Sub ListViewPlantes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewPlantes.DoubleClick
        'MODIFICATION D'UNE PLANTE
        ButtonModifyPlante.PerformClick()
    End Sub
    Private Sub ButtonModifyPlante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyPlante.Click
        Dim FormPlante As New FormPlante
        With FormPlante
            .Text = "Modifier la plante"
            Dim nom As String
            nom = ListViewPlantes.SelectedItems(0).Text
            Dim key As Integer
            key = ImageListPlantes.Images.IndexOfKey(ListViewPlantes.SelectedItems(0).Text)
            If key <> -1 Then
                .PictureBox1.BackgroundImage = ImageListPlantes.Images(key)
                .PictureBox1.Tag = PathImage & "\" & nom & ".png"
            End If
            .Label1.Tag = nom
            .TextBox1.Text = nom
            .TextBox4.Text = ListViewPlantes.SelectedItems(0).SubItems(1).Text
            .TextBox5.Text = ListViewPlantes.SelectedItems(0).SubItems(2).Text
            .TextBox3.Text = ListViewPlantes.SelectedItems(0).SubItems(4).Text
            .TextBox2.Text = ListViewPlantes.SelectedItems(0).SubItems(3).Text
            Select Case ListViewPlantes.SelectedItems(0).SubItems(5).Text
                Case "Oui"
                    .CheckBox1.Checked = True
                Case "Non"
                    .CheckBox1.Checked = False
                Case Else
            End Select
            Dim strg() As String
            strg = ListViewPlantes.SelectedItems(0).SubItems(6).Text.Split(" ")
            .ComboBox1.SelectedIndex = Mois2Integer(strg(1) & " " & strg(2))
            .ComboBox2.SelectedIndex = Mois2Integer(strg(4) & " " & strg(5))

            strg = ListViewPlantes.SelectedItems(0).SubItems(7).Text.Split(" ")
            .ComboBox3.SelectedIndex = Mois2Integer(strg(1) & " " & strg(2))
            .ComboBox4.SelectedIndex = Mois2Integer(strg(4) & " " & strg(5))

            .Label1.Select()

        End With

        FormPlante.Show()

    End Sub
    Private Sub ButtonAddPlante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddPlante.Click
        'AJOUT D'UNE PLANTE
        Dim FormPlante As New FormPlante
        FormPlante.Text = "Ajouter une plante"
        FormPlante.Show()
    End Sub
    Private Sub ListViewPlantes_ColumnClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewPlantes.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ListViewPlantes.Sorting = SortOrder.Ascending
        Else
            If ListViewPlantes.Sorting = SortOrder.Ascending Then
                ListViewPlantes.Sorting = SortOrder.Descending
            Else
                ListViewPlantes.Sorting = SortOrder.Ascending
            End If
        End If
        ListViewPlantes.Sort()
        ListViewPlantes.ListViewItemSorter = New ListViewItemComparer(e.Column, ListViewPlantes.Sorting)
    End Sub
    'BDD ASSOCIATIONS
    Private Sub DataGridViewAssociations_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAssociations.CellEndEdit
        'COLORIE LES BDD APRES EDIT
        With DataGridViewAssociations(e.ColumnIndex, e.RowIndex)
            Try
                Select Case .Value
                    Case Is > 0
                        .Style.BackColor = Color.Green
                        .ToolTipText = DataGridViewAssociations.Columns(e.ColumnIndex).HeaderText & "/" & DataGridViewAssociations.Rows(e.RowIndex).HeaderCell.Value
                    Case Is < 0
                        .Style.BackColor = Color.Red
                        .ToolTipText = DataGridViewAssociations.Columns(e.ColumnIndex).HeaderText & "/" & DataGridViewAssociations.Rows(e.RowIndex).HeaderCell.Value
                    Case 0
                        .Style.BackColor = Color.White
                        .Value = ""
                        .ToolTipText = ""
                End Select
                EnregistrerBDDAssociations.BackgroundImage = My.Resources.Savewrong
            Catch ex As Exception

                .Style.BackColor = Color.White
                .Value = ""
                .ToolTipText = ""

            End Try
        End With
    End Sub
    Private Sub DataGridViewAssociations_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewAssociations.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 Then
            With DataGridViewAssociations(e.ColumnIndex, e.RowIndex)
                If .Value <> "" Then
                    RichTextBox1.Text = .ToolTipText
                Else
                    RichTextBox1.Text = ""
                End If
            End With
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerComAssociations.Click
        DataGridViewAssociations.SelectedCells(0).ToolTipText = RichTextBox1.Text
        EnregistrerBDDAssociations.BackgroundImage = My.Resources.Savewrong
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBDDAssociations.Click

        Dim str As String
        Dim lines As New List(Of String)
        With DataGridViewAssociations
            For i = 0 To .ColumnCount - 1
                For j = 0 To .RowCount - 1
                    With DataGridViewAssociations(i, j)
                        If .Value <> "" Then
                            str = DataGridViewAssociations.Columns(.ColumnIndex).HeaderText & "|" & DataGridViewAssociations.Rows(.RowIndex).HeaderCell.Value & "|" & .Value & "|" & .ToolTipText.Replace(Chr(10), "`")
                            lines.Add(str)
                        End If
                    End With
                Next
            Next
        End With
        File.WriteAllLines(PathAssociations, lines, Encoding.Default)

        EnregistrerBDDAssociations.BackgroundImage = My.Resources.Savetrue

    End Sub
    '=============================================================================================================================================
    'BDD ROTATIONS
    Private Sub DataGridViewRotations_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewRotations.CellEndEdit
        With DataGridViewRotations(e.ColumnIndex, e.RowIndex)
            Try
                Select Case .Value
                    Case Is > 0
                        .Style.BackColor = Color.Green
                        .ToolTipText = DataGridViewRotations.Columns(e.ColumnIndex).HeaderText & "/" & DataGridViewRotations.Rows(e.RowIndex).HeaderCell.Value
                    Case Is < 0
                        .Style.BackColor = Color.Red
                        .ToolTipText = DataGridViewRotations.Columns(e.ColumnIndex).HeaderText & "/" & DataGridViewRotations.Rows(e.RowIndex).HeaderCell.Value
                    Case 0
                        .Style.BackColor = Color.White
                        .Value = ""
                        .ToolTipText = ""
                End Select
                EnregistrerBDDRotations.BackgroundImage = My.Resources.Savewrong
            Catch ex As Exception

                .Style.BackColor = Color.White
                .Value = ""
                .ToolTipText = ""

            End Try
        End With
    End Sub
    Private Sub DataGridViewRotations_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewRotations.CellClick
        If e.ColumnIndex > -1 AndAlso e.RowIndex > -1 Then
            With DataGridViewRotations(e.ColumnIndex, e.RowIndex)
                If .Value <> "" Then
                    RichTextBox2.Text = .ToolTipText
                Else
                    RichTextBox2.Text = ""
                End If
            End With
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerComRotations.Click
        DataGridViewRotations.SelectedCells(0).ToolTipText = RichTextBox2.Text
        EnregistrerBDDRotations.BackgroundImage = My.Resources.Savewrong
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerBDDRotations.Click

        Dim str As String
        Dim lines As New List(Of String)
        With DataGridViewRotations
            For i = 0 To .ColumnCount - 1
                For j = 0 To .RowCount - 1
                    With DataGridViewRotations(i, j)
                        If .Value <> "" Then
                            str = DataGridViewRotations.Columns(.ColumnIndex).HeaderText & "|" & DataGridViewRotations.Rows(.RowIndex).HeaderCell.Value & "|" & .Value & "|" & .ToolTipText.Replace(Chr(10), "`")
                            lines.Add(str)
                        End If
                    End With
                Next
            Next
        End With
        File.WriteAllLines(PathRotations, lines, Encoding.Default)

        EnregistrerBDDRotations.BackgroundImage = My.Resources.Savetrue

    End Sub
    '===============================================================================================================
    'BDD ENTRETIEN
    Private Sub ListViewEntretien_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListViewEntretien.KeyDown
        'SUPPRESSION D'UNE PLANTE
        If e.KeyCode = Keys.Delete Then
            ButtonDelEntretien.PerformClick()
        End If
    End Sub
    Private Sub ButtonSupprimerEntretien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelEntretien.Click
        Dim NomEntretien = ListViewEntretien.SelectedItems(0).Text
        If MsgBox("L'entretien '" & NomEntretien & "' sera supprimé définitivement ", MsgBoxStyle.YesNo, "Supprimer un entretien") = vbYes Then

            Effacer_de_la_BDDEntretien(NomEntretien)

            Chargement_Entretien()

        End If
    End Sub
    Private Sub ListViewEntretien_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEntretien.DoubleClick
        'MODIFICATION D'UNE PLANTE
        ButtonModifyEntretien.PerformClick()
    End Sub
    Private Sub ButtonModifyEntretien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonModifyEntretien.Click
        Dim FormEntretien As New FormEntretien

        Dim OldName As String = ListViewEntretien.SelectedItems(0).Text

        With FormEntretien
            .Text = "Modifier l'entretien"
            .TextBoxName.Text = OldName
            .TextBoxType.Text = ListViewEntretien.SelectedItems(0).SubItems(1).Text
            .Label1.Select()
        End With

        If FormEntretien.ShowDialog = DialogResult.OK Then

            Dim lines As List(Of String) = File.ReadAllLines(PathEntretien, Encoding.Default).ToList
            For i = 0 To lines.Count - 1
                If lines(i).StartsWith(OldName) Then
                    lines.RemoveAt(i)
                    Exit For
                End If
            Next
            Dim str As String = FormEntretien.TextBoxName.Text & "|" & FormEntretien.TextBoxType.Text
            lines.Add(str)
            File.WriteAllLines(PathEntretien, lines, Encoding.Default)

            Chargement_Entretien()

        End If

    End Sub
    Private Sub ButtonAddEntretien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonADDEntretien.Click
        'AJOUT D'UNE PLANTE
        Dim FormEntretien As New FormEntretien
        With FormEntretien
            .Text = "Ajouter un entretien"
            Dim nom As String = ListViewEntretien.SelectedItems(0).Text
            .TextBoxName.Text = ""
            .TextBoxType.Text = ""
            .Label1.Select()
        End With

        If FormEntretien.ShowDialog = DialogResult.OK Then

            Dim lines As List(Of String) = File.ReadAllLines(PathEntretien, Encoding.Default).ToList
            Dim str As String = FormEntretien.TextBoxName.Text & "|" & FormEntretien.TextBoxType.Text
            lines.Add(str)
            File.WriteAllLines(PathEntretien, lines, Encoding.Default)

            Chargement_Entretien()

        End If
    End Sub
    
    Private Sub ListViewEntretien_ColumnClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewEntretien.ColumnClick
        If e.Column <> sortColumn Then
            sortColumn = e.Column
            ListViewEntretien.Sorting = SortOrder.Ascending
        Else
            If ListViewEntretien.Sorting = SortOrder.Ascending Then
                ListViewEntretien.Sorting = SortOrder.Descending
            Else
                ListViewEntretien.Sorting = SortOrder.Ascending
            End If
        End If
        ListViewEntretien.Sort()
        ListViewEntretien.ListViewItemSorter = New ListViewItemComparer(e.Column, ListViewEntretien.Sorting)
    End Sub
    Private Sub FormP_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        With SplitContainer2
            .SplitterDistance = .Size.Height - 58
        End With
        With SplitContainer3
            .SplitterDistance = .Size.Height - 58
        End With

    End Sub

    Private Sub TabControlBDD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlBDD.SelectedIndexChanged
        With SplitContainer2
            .SplitterDistance = .Size.Height - 58
        End With
        With SplitContainer3
            .SplitterDistance = .Size.Height - 58
        End With
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim opt As New FormOptions
        opt.Show()
    End Sub
    Public Sub ListViewPlantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewPlantes.Click

        'ANALYSE

        Try
            Dim DTG As DTGSPACE = TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
            DTG.SuspendLayout()
            For i = 0 To DTG.ColumnCount - 1
                For j = 0 To DTG.RowCount - 1
                    If DTG(i, j).Tag = "" Then
                        Dim Cell As CellSPACE = DTG(i, j)
                        DTG.InvalidateCell(Cell)
                    End If
                Next
            Next
            DTG.ResumeLayout()
        Catch ex As Exception
        End Try


    End Sub

    Private Sub TabControlConstruction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlConstruction.SelectedIndexChanged

        Try
            Dim Cell As CellSPACE
            Dim PreviousDTG As DTGSPACE = TabControlConstruction.TabPages(TabControlConstruction.SelectedIndex - 1).Controls.Find("DTGridSPACE", True)(0)
            Dim DTG As DTGSPACE = TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)

            For i = 0 To DTG.ColumnCount - 1
                For j = 0 To DTG.RowCount - 1
                    If PreviousDTG(i, j) IsNot Nothing Then
                        Cell = DTG(i, j)
                        Cell.Rotation = PreviousDTG(i, j).Tag
                    End If
                Next
            Next
        Catch ex As Exception
        End Try

    End Sub
    Private Sub EchelleTextbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EchelleTextbox.KeyDown
        If e.KeyValue = Keys.Enter Then
            Change_Echelle()
            TabControlConstruction.SelectedTab.Focus()
        End If
    End Sub
    Private Sub Change_Echelle()
        
        Try
            Echelle = CDec(EchelleTextbox.Text)
            For Each tbp As TabPage In TabControlConstruction.TabPages
                If TypeOf tbp Is TabPageSPACE Then
                    Dim DTG As DTGSPACE = tbp.Controls.Find("DTGridSPACE", True)(0)
                    For Each col As ColumnCellSPACE In DTG.Columns
                        col.HeaderText = CInt(col.Tag) * Echelle
                    Next
                    For Each lin As DataGridViewRow In DTG.Rows
                        lin.HeaderCell.Value = (CInt(lin.Tag) * Echelle).ToString
                    Next
                End If
            Next
        Catch ex As Exception
            For i = 0 To TabControlConstruction.TabPages.Count - 1
                If TypeOf TabControlConstruction.TabPages(i) Is TabPageSPACE Then
                    Dim DTG As DTGSPACE = TabControlConstruction.TabPages(i).Controls.Find("DTGridSPACE", True)(0)
                    EchelleTextbox.Text = DTG.Columns(1).HeaderText
                    Echelle = CDec(EchelleTextbox.Text)
                    Exit For
                End If
            Next
        End Try

    End Sub
    
    Private Sub GénérerUneNouvellePhaseOptimiséeÀPartirDuPartitionnementEnParcellesEtDesPlantesDeLaPhaseActiveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GénérerUneNouvellePhaseOptimiséeÀPartirDuPartitionnementEnParcellesEtDesPlantesDeLaPhaseActiveToolStripMenuItem.Click
        Dim FormGenerate As New FormGenerate
        Dim DTG As DTGSPACE = TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
        FormGenerate.DTG = DTG
        FormGenerate.ShowDialog()
    End Sub
End Class
