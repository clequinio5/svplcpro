Imports System.IO
Imports System.Text
Imports System.Drawing.Drawing2D
Imports unvell.ReoGrid
Public Class FormP
    Dim col
    Dim sortColumn As Integer = -1

    '=========================
    Dim regleBDD As Boolean
    Dim FormRegleBDD As FormRegleBDD
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

        ReDim PlancheColor(PlancheMax - 1)
        PlancheColor(0) = Color.Maroon
        PlancheColor(1) = Color.Crimson
        PlancheColor(2) = Color.Violet
        PlancheColor(3) = Color.SteelBlue
        PlancheColor(4) = Color.GreenYellow
        PlancheColor(5) = Color.DeepSkyBlue
        PlancheColor(6) = Color.Chocolate
        PlancheColor(7) = Color.LawnGreen
        PlancheColor(8) = Color.Goldenrod
        PlancheColor(9) = Color.DarkGreen
        PlancheColor(10) = Color.Coral
        PlancheColor(11) = Color.IndianRed
        PlancheColor(12) = Color.DarkKhaki
        PlancheColor(13) = Color.YellowGreen
        PlancheColor(14) = Color.Orange
        PlancheColor(15) = Color.LightBlue
        PlancheColor(16) = Color.LightGreen
        PlancheColor(17) = Color.LightPink
        PlancheColor(18) = Color.Tomato
        PlancheColor(19) = Color.LightSteelBlue
        PlancheColor(20) = Color.Indigo
        PlancheColor(21) = Color.PaleVioletRed

        NombreTabPageSession = 1

    End Sub
    '=========================================================================================================
    'FICHIER
    Private Sub NouveauProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauProjetToolStripMenuItem.Click

        Select Case ProjectType
            Case TypeProjet.SPACE
                FormProjet.LabelAttention.Text = "Attention! Un projet de conception sur base spaciale est en cours." & vbCrLf & "Si vous choisissez de continuer, toutes les données non enregistrées seront perdues."
                FormProjet.LabelAttention.TextAlign = ContentAlignment.TopLeft
            Case TypeProjet.TMP
                FormProjet.LabelAttention.Text = "Attention! Un projet de conception sur base temporelle est en cours." & vbCrLf & "Si vous choisissez de continuer, toutes les données non enregistrées seront perdues."
                FormProjet.LabelAttention.TextAlign = ContentAlignment.TopLeft
            Case TypeProjet.TMPA
                FormProjet.LabelAttention.Text = "Attention! Un projet de conception sur base temporelle automatisé est en cours." & vbCrLf & "Si vous choisissez de continuer, toutes les données non enregistrées seront perdues."
                FormProjet.LabelAttention.TextAlign = ContentAlignment.TopLeft
            Case Else
                FormProjet.LabelAttention.Text = "***********************"
                FormProjet.LabelAttention.TextAlign = ContentAlignment.MiddleCenter
        End Select

        If FormProjet.ShowDialog = DialogResult.OK Then


            If FormProjet.RadioButtonSPACE.Checked = True Then
                'Nouveau projet SPACE

                FormNomPhaseSPACE.TextBoxNomPhase.Text = "Phase" & NombreTabPageSession
                FormNomPhaseSPACE.TextBoxNomPhase.SelectAll()

                If FormNomPhaseSPACE.ShowDialog = DialogResult.OK Then

                    Reset()

                    NewProjectSPA()

                End If

            Else
                If FormProjet.RadioButtonTMP.Checked = True Then
                    'Nouveau projet TMP

                    Reset()

                    NewProjectTMP()

                Else
                    'Nouveau projet TMPA

                    If FormPlanchesTMPA.ShowDialog = DialogResult.OK Then

                        ProjetTMPNPlanche = CInt(FormPlanchesTMPA.NPlanches.Value)
                        ProjetTMPLongueur = FormPlanchesTMPA.LonPlanche.Value
                        ProjetTMPLargeur = FormPlanchesTMPA.LarPlanche.Value
                        ProjetTMPEspacement = FormPlanchesTMPA.EspPlanche.Value

                        With FormCaracteristiqueProjet
                            .ComboBoxSpatiale.Enabled = True
                            .Label2.Enabled = True
                            Dim compt As Decimal = 0
                            Dim div As Integer = 0
                            Do
                                compt += 0.01
                                If ProjetTMPLongueur Mod compt = 0 Then
                                    div = ProjetTMPLongueur / compt
                                    .ComboBoxSpatiale.Items.Add(compt & " - (" & div & " div.)")
                                    If div >= 20 Then
                                        .ComboBoxSpatiale.SelectedItem = compt & " - (" & div & " div.)"
                                    End If
                                End If
                            Loop Until compt = ProjetTMPLongueur
                        End With

                        If FormCaracteristiqueProjet.ShowDialog = DialogResult.OK Then

                            ProjectTMPDebut = FormCaracteristiqueProjet.LabelDebut.Text
                            ProjectTMPFin = FormCaracteristiqueProjet.LabelFin.Text
                            ProjectTMPDivisionTemps = FormCaracteristiqueProjet.ComboBoxDivision.Text
                            ProjectTMPDivisionSpatial = CDec(Split(FormCaracteristiqueProjet.ComboBoxSpatiale.Text, " - ")(0))
                            NLigneTMPA = CInt(ProjetTMPNPlanche / ProjectTMPDivisionSpatial)

                            Reset()

                            NewProjectTMPA()

                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub NewProjectSPA()
        ProjectType = TypeProjet.SPACE
        LabelProjet.Text = "Projet Spatial"

        Dim str As String = FormNomPhaseSPACE.TextBoxNomPhase.Text
        If str <> "" Then
            Dim NewTabPage As New TabPageSPACE
            NewTabPage.Text = str
            TabControlConstruction.Controls.Add(NewTabPage)
            TabControlConstruction.SelectedTab = NewTabPage
            NombreTabPageSession += 1

            ProjectMenuItem.Visible = True
            EchelleLabel.Visible = True
            Echelle = 0
            EchelleTextbox.Text = "0"
            EchelleTextbox.Visible = True
            EnregistrerLeProjetToolStripMenuItem.Enabled = True

            AjouterPhase.Enabled = True
            SupprimerPhaseActive.Enabled = True

        End If
    End Sub
    Private Sub NewProjectTMPA()
        ProjectType = TypeProjet.TMPA
        LabelProjet.Text = "Projet Temporel Automatisé"
        EchelleLabel.Visible = False
        Echelle = 0
        EchelleTextbox.Text = "0"
        EchelleTextbox.Visible = False
        EnregistrerLeProjetToolStripMenuItem.Enabled = True

        AjouterPhase.Enabled = False
        SupprimerPhaseActive.Enabled = False

        For p = 0 To ProjetTMPNPlanche - 1
            Dim tbp As New TabPageTMPA
            With tbp
                .BackColor = Color.LightGray
                .Tag = New Planche
                .Text = "Planche" & p + 1
                Dim DTG As ReoGridControl = .Controls.Find("DTGrid", True)(0)
                NColumnTMPA = DateDiff(DateInterval.Day, CDate(ProjectTMPDebut), CDate(ProjectTMPFin))
                Select Case ProjectTMPDivisionTemps
                    Case "Jour"
                    Case "1 Semaine - 7 Jours"
                        NColumnTMPA = Int(NColumnTMPA / 7) + 1
                    Case "2 Semaine - 14 Jours "
                        NColumnTMPA = Int(NColumnTMPA / 14) + 1
                    Case "3 Semaine - 21 Jours"
                        NColumnTMPA = Int(NColumnTMPA / 21) + 1
                    Case "Mois"
                        NColumnTMPA = DateDiff(DateInterval.Month, CDate(ProjectTMPDebut), CDate(ProjectTMPFin))
                    Case "Année"
                        DateDiff(DateInterval.Year, CDate(ProjectTMPDebut), CDate(ProjectTMPFin))
                    Case Else
                        Exit Sub
                End Select

                With DTG
                    .ColCount = NColumnTMPA + 2
                    .RowCount = NLigneTMPA + 3
                End With

                DTG(0, 0) = "SEMAINE"
                DTG(1, 0) = "JOUR"
                DTG(2, 0) = "MOIS"

                For j = 3 To NLigneTMPA + 2
                    DTG(j, 0) = CStr((j - 3) * ProjectTMPDivisionSpatial)
                    DTG.SetRowsHeight(j, 1, cDalleSetupTMPA)
                Next

                For i = 1 To NColumnTMPA
                    Dim DateInc As Date = DateAdd(DateInterval.Day, (i - 1) * 7, CDate(ProjectTMPDebut))
                    DTG.SetColsWidth(i, 1, cDalleSetupTMPA)
                    DTG(0, i) = DatePart(DateInterval.WeekOfYear, DateInc)
                    DTG(1, i) = DateInc.Day
                    DTG(2, i) = StrConv(DateInc.ToString("MMMM"), vbProperCase)
                Next

                Dim st As New ReoGridRangeStyle
                With st
                    .Italic = True
                    .BackColor = Color.AliceBlue
                End With
                Dim rg As New ReoGridRange(1, 1, 1, 5)
                DTG.SetRangeStyle(rg, st)

                'fusionnage des cellules au meme mois
                Dim start, term As Integer
                Dim cache As String
                start = 1
                term = 1
                cache = DTG(2, start)
                For i = 1 To NColumnTMPA
                    If cache <> DTG(2, i) Then
                        term = i
                        DTG.MergeRange(2, start, 1, term - start)
                        cache = DTG(2, i)
                        start = i
                    End If
                Next
                DTG.MergeRange(2, start, 1, NColumnTMPA - start + 1)

            End With
            TabControlConstruction.Controls.Add(tbp)
        Next
    End Sub
    Private Sub NewProjectTMP()
        ProjectType = TypeProjet.TMP
        LabelProjet.Text = "Projet Temporel"
        Ajouter_TMP1()
        EchelleLabel.Visible = True
        Echelle = 0
        EchelleTextbox.Text = "0"
        EchelleTextbox.Visible = True
        EnregistrerLeProjetToolStripMenuItem.Enabled = True

        AjouterPhase.Enabled = False
        SupprimerPhaseActive.Enabled = False
    End Sub
    Private Sub Reset()
        'initialisation
        For Each tbp In TabControlConstruction.TabPages
            tbp.dispose()
        Next
        NombreTabPageSession = 1
        ProjectMenuItem.Visible = False
        EchelleLabel.Visible = False
        EchelleTextbox.Visible = False
    End Sub
    Private Sub Ajouter_TMP1()
        Dim NewTabPage As New TabPageTMP1
        With TabControlConstruction
            .TabPages.Add(NewTabPage)
            .SelectedTab = NewTabPage
        End With
    End Sub
    Private Sub EnregistrerLeProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregistrerLeProjetToolStripMenuItem.Click
        Select Case ProjectType
            Case TypeProjet.TMP

            Case TypeProjet.TMPA








            Case TypeProjet.SPACE
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
            Case Else

        End Select
        
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

            EchelleTextbox.Visible = True
            EchelleLabel.Visible = True

        Catch ex As Exception
            MsgBox("Le fichier est corrompu", MsgBoxStyle.Exclamation, "Erreur chargement fichier")
        End Try

    End Sub
    '=====================================================================================================================
    'PROJET
    Private Sub Ajouter_Phase()
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
                    EchelleLabel.Visible = True
                    EchelleTextbox.Visible = True
                Case False
                    EchelleLabel.Visible = False
                    EchelleTextbox.Visible = False
                    ProjectMenuItem.Visible = False
                    ProjectType = ""
                    LabelProjet.Text = "Bienvenue"
            End Select
        End If
    End Sub
    '===============================================================================================================
    '?
    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Pour toute information, remarque, proposition, etc...n'hésitez pas à envoyer un mail à:" & vbCrLf & vbCrLf & "kikil592@gmail.com")
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
            .TextBox2.Text = ListViewPlantes.SelectedItems(0).SubItems(1).Text
            .TextBox3.Text = ListViewPlantes.SelectedItems(0).SubItems(2).Text
            Select Case ListViewPlantes.SelectedItems(0).SubItems(3).Text
                Case "Oui"
                    .CheckBox1.Checked = True
                Case "Non"
                    .CheckBox1.Checked = False
                Case Else
            End Select
            Dim strg() As String
            strg = ListViewPlantes.SelectedItems(0).SubItems(4).Text.Split(" ")
            .ComboBox1.SelectedIndex = Mois2Integer(strg(1) & " " & strg(2))
            .ComboBox2.SelectedIndex = Mois2Integer(strg(4) & " " & strg(5))

            strg = ListViewPlantes.SelectedItems(0).SubItems(5).Text.Split(" ")
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
        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListViewPlantes.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListViewPlantes.Sorting = SortOrder.Ascending Then
                ListViewPlantes.Sorting = SortOrder.Descending
            Else
                ListViewPlantes.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ListViewPlantes.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListViewPlantes.ListViewItemSorter = New ListViewItemComparer(e.Column, ListViewPlantes.Sorting)
    End Sub
    '=============================================================================================================================================
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

        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListViewEntretien.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListViewEntretien.Sorting = SortOrder.Ascending Then
                ListViewEntretien.Sorting = SortOrder.Descending
            Else
                ListViewEntretien.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ListViewEntretien.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
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
    Private Sub AjouterDesRèglesAutomatiquesAuxBDDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormRegleBDD = New FormRegleBDD
        FormRegleBDD.Show()

    End Sub
    '********************************************************************************************
    'SPACE
    Public Sub ListViewPlantes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewPlantes.Click

        'ANALYSE
        Try
            Dim DTG As DTGSPACE = TabControlConstruction.SelectedTab.Controls.Find("DTGridSPACE", True)(0)
            Dim tltip As String = ""

            For i = 0 To DTG.ColumnCount - 1
                For j = 0 To DTG.RowCount - 1
                    If DTG(i, j).Tag = "" Then
                        Dim Cell As CellSPACE = DTG(i, j)
                        DTG.InvalidateCell(Cell)
                    End If
                Next
            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TabControlConstruction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControlConstruction.SelectedIndexChanged

        Select Case ProjectType
            Case "tmp"

            Case "spa"
                'ROTATION
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

            Case Else

        End Select

        

    End Sub
    Private Sub EchelleTextbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EchelleTextbox.KeyDown
        If e.KeyValue = Keys.Enter Then
            Change_Echelle()
            TabControlConstruction.SelectedTab.Focus()
        End If
    End Sub
    Private Sub Change_Echelle()
        Select Case ProjectType
            Case "tmp"
                Try
                    Echelle = CDec(EchelleTextbox.Text)
                    For Each tbp As TabPage In TabControlConstruction.TabPages
                        If TypeOf tbp Is TabPageTMP1 Then
                            Dim DTG As DTGTMP1 = tbp.Controls.Find("DTGridTMP1", True)(0)
                            For Each col As ColumnCellTMP1 In DTG.Columns
                                col.HeaderText = CInt(col.Tag) * Echelle
                            Next
                            For Each lin As DataGridViewRow In DTG.Rows
                                lin.HeaderCell.Value = (CInt(lin.Tag) * Echelle).ToString
                            Next
                        End If
                    Next
                Catch ex As Exception
                    For i = 0 To TabControlConstruction.TabPages.Count - 1
                        If TypeOf TabControlConstruction.TabPages(i) Is TabPageTMP1 Then
                            Dim DTG As DTGTMP1 = TabControlConstruction.TabPages(i).Controls.Find("DTGridTMP1", True)(0)
                            EchelleTextbox.Text = DTG.Columns(1).HeaderText
                            Echelle = CDec(EchelleTextbox.Text)
                            Exit For
                        End If
                    Next
                End Try
            Case "spa"
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
            Case Else

        End Select
        

    End Sub
    '===========================================================================
    'DROP TABCONTROL SPACE
    'Private Function GetTabPageFromPoint(ByVal pt As Point) As TabPage
    '    Dim tp As TabPage = Nothing
    '    For i As Integer = 0 To Me.TabControlBDD.TabPages.Count - 1
    '        If Me.TabControlBDD.GetTabRect(i).Contains(pt) Then
    '            tp = Me.TabControlBDD.TabPages(i)
    '            Exit For
    '        End If
    '    Next i
    '    Return tp
    'End Function
    'Private Function FindTabIndex(ByVal page As TabPage) As Integer
    '    For i As Integer = 0 To Me.TabControlBDD.TabPages.Count - 1
    '        If Me.TabControlBDD.TabPages(i) Is page Then
    '            Return i
    '        End If
    '    Next i
    '    Return -1
    'End Function
    'Private Sub TabEditors_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TabControlBDD.DragOver
    '    Dim pt As New Point(e.X, e.Y)
    '    pt = Me.TabControlBDD.PointToClient(pt)
    '    Dim hover_tab As TabPage = GetTabPageFromPoint(pt)
    '    If Not hover_tab Is Nothing Then
    '        If e.Data.GetDataPresent(GetType(TabPage)) Then
    '            e.Effect = DragDropEffects.Move
    '            Dim drag_tab As TabPage = CType(e.Data.GetData(GetType(TabPage)), TabPage)
    '            Dim item_drag_index As Integer = FindTabIndex(drag_tab)
    '            Dim drop_location_index As Integer = FindTabIndex(hover_tab)
    '            If item_drag_index <> drop_location_index Then
    '                Dim pages As New ArrayList()
    '                For i As Integer = 0 To Me.TabControlBDD.TabPages.Count - 1
    '                    If i <> item_drag_index Then
    '                        pages.Add(Me.TabControlBDD.TabPages(i))
    '                    End If
    '                Next i
    '                pages.Insert(drop_location_index, drag_tab)
    '                Me.TabControlBDD.TabPages.Clear()
    '                Me.TabControlBDD.TabPages.AddRange(CType(pages.ToArray(GetType(TabPage)), TabPage()))
    '                Me.TabControlBDD.SelectedTab = drag_tab
    '            End If
    '        End If
    '    Else
    '        e.Effect = DragDropEffects.None
    '    End If
    'End Sub
    'Private Sub TabEditors_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControlBDD.MouseDown
    '    Dim pt As Point = New Point(e.X, e.Y)
    '    Dim tp As TabPage = GetTabPageFromPoint(pt)
    '    If Not tp Is Nothing Then
    '        DoDragDrop(tp, DragDropEffects.All)
    '    End If
    'End Sub
    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControlConstruction.DrawItem

        With TabControlConstruction.TabPages(e.Index)

            If e.Index = TabControlConstruction.TabPages.Count - 1 Then
                Dim B As Rectangle = New Rectangle(e.Bounds.X, 0, Width, Height)
                e.Graphics.FillRectangle(Brushes.DarkGray, B)
            End If

            If e.State = DrawItemState.Selected Then

                Dim G As Rectangle = New Rectangle(0, 0, e.Bounds.X, 2)
                e.Graphics.FillRectangle(Brushes.DarkGray, G)
                Dim D As Rectangle = New Rectangle(e.Bounds.X + e.Bounds.Width, 0, Width, 2)
                e.Graphics.FillRectangle(Brushes.DarkGray, D)

                Dim x2 As Rectangle = New Rectangle(New Point(e.Bounds.X, e.Bounds.Y), New Size(e.Bounds.Width, e.Bounds.Height))
                Dim myBlend As New ColorBlend()
                myBlend.Colors = {Color.LightGray, .BackColor, .BackColor}
                myBlend.Positions = {0.0F, 0.5F, 1.0F}
                Dim lgBrush As New LinearGradientBrush(x2, Color.Black, Color.Black, 90.0F)
                lgBrush.InterpolationColors = myBlend
                e.Graphics.FillRectangle(lgBrush, x2)

                If .Tag Is "Bienvenue" Then
                    e.Graphics.DrawString(.Text, Me.Font, New SolidBrush(ColorComplementaire(.BackColor)), New Point(e.Bounds.X + 4, e.Bounds.Y + 4))
                Else
                    e.Graphics.DrawString(.Text, Me.Font, Brushes.Black, New Point(e.Bounds.X + 6, e.Bounds.Y + 6))
                End If
            Else
                If e.Index = 0 Then
                    Dim G As Rectangle = New Rectangle(0, 0, 2, e.Bounds.Height)
                    e.Graphics.FillRectangle(Brushes.DarkGray, G)
                End If

                Dim x2 As Rectangle = New Rectangle(New Point(e.Bounds.X, e.Bounds.Y), New Size(e.Bounds.Width, e.Bounds.Height + 2))
                Dim myBlend As New ColorBlend()
                myBlend.Colors = {Color.LightGray, .BackColor, .BackColor}
                myBlend.Positions = {0.0F, 0.5F, 1.0F}
                Dim lgBrush As New LinearGradientBrush(x2, Color.Black, Color.Black, 90.0F)
                lgBrush.InterpolationColors = myBlend
                e.Graphics.FillRectangle(lgBrush, x2)
                ' e.Graphics.DrawRectangle(New Pen(Color.FromArgb(170, 187, 204)), x2)

                If .Tag Is "Bienvenue" Then
                    e.Graphics.DrawString(.Text, Me.Font, New SolidBrush(ColorComplementaire(.BackColor)), New Point(e.Bounds.X + 4, e.Bounds.Y + 4))
                Else
                    e.Graphics.DrawString(.Text, Me.Font, Brushes.Black, New Point(e.Bounds.X + 2, e.Bounds.Y + 4))
                End If
            End If

        End With

    End Sub

    
End Class
