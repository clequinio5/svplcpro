Public Class DTGTMPA
    Inherits DataGridView
    Private lp As New List(Of Serie)
    Property Series As List(Of Serie)
        ' Sets the method for retrieving the value of your property.
        Get
            Return lp
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As List(Of Serie))
            lp = Value
        End Set
    End Property
    Public Sub New()

        With Me
            .Name = "DTGrid"
            .Dock = DockStyle.Fill
            .GridColor = ColorGrid
            .BackgroundColor = Color.White
            .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
            '.RowHeadersWidth = 0
            .RowHeadersVisible = False
            .ColumnHeadersVisible = False
            '.ColumnHeadersHeight = 0
            .ShowEditingIcon = False
            .ReadOnly = True
            .MultiSelect = False
        End With

    End Sub
    Protected Overrides Sub OnMouseWheel(ByVal e As System.Windows.Forms.MouseEventArgs)

        'ZOOM
        Select Case e.Delta
            Case Is > 0
                With Me
                    Dim DalleInitiale As Integer = .Columns(0).Width
                    For i = 0 To .Columns.Count - 1
                        .Columns(i).Width = DalleInitiale - 5
                    Next
                    For i = 0 To .Rows.Count - 1
                        .Rows(i).Height = DalleInitiale - 5
                    Next
                End With
            Case Is < 0
                With Me
                    Dim DalleInitiale As Integer = .Columns(0).Width
                    For i = 0 To .Columns.Count - 1
                        .Columns(i).Width = DalleInitiale + 5
                    Next
                    For i = 0 To .Rows.Count - 1
                        .Rows(i).Height = DalleInitiale + 5
                    Next
                End With
        End Select

    End Sub

    Protected Overrides Sub OnCellClick(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        If e.ColumnIndex > -1 And e.RowIndex > -1 Then
            'CAST DES CELL AVOISINNANTES (TRY A CAUSE DES PROBLEMES AUX LIMITES)
            Dim CellB, CellH, CellG, CellD, Cell As CellTMPA
            Cell = Me(e.ColumnIndex, e.RowIndex)
            Try
                CellB = Me(e.ColumnIndex, e.RowIndex + 1)
            Catch ex As Exception
                CellB = Nothing
            End Try
            Try
                CellH = Me(e.ColumnIndex, e.RowIndex - 1)
            Catch ex As Exception
                CellH = Nothing
            End Try
            Try
                CellG = Me(e.ColumnIndex - 1, e.RowIndex)
            Catch ex As Exception
                CellG = Nothing
            End Try
            Try
                CellD = Me(e.ColumnIndex + 1, e.RowIndex)
            Catch ex As Exception
                CellD = Nothing
            End Try


            Dim B, H, G, D As String
            Dim prcplus As Serie = Nothing
            Dim PlanteSel As String = FormP.ListViewPlantes.SelectedItems(0).Text

            'CONDITION DE CREATION D'UNE NOUVELLE PARCELLE AUTOMATIQUEMENT
            With Cell
                Try
                    H = CellH.Tag
                    If H = PlanteSel Then
                        prcplus = CellH.Serie
                    End If
                Catch ex As Exception
                    H = Nothing
                End Try
                Try
                    D = CellD.Tag
                    If D = PlanteSel Then
                        prcplus = CellD.Serie
                    End If
                Catch ex As Exception
                    D = Nothing
                End Try
                Try
                    B = CellB.Tag
                    If B = PlanteSel Then
                        prcplus = CellB.Serie
                    End If
                Catch ex As Exception
                    B = Nothing
                End Try
                Try
                    G = CellG.Tag
                    If G = PlanteSel Then
                        prcplus = CellG.Serie
                    End If
                Catch ex As Exception
                    G = Nothing
                End Try


                Select Case .Tag
                    Case ""
                        If H = PlanteSel Or B = PlanteSel Or D = PlanteSel Or G = PlanteSel Then
                            .Tag = PlanteSel
                            If CellH IsNot Nothing Then
                                CellH.PlanteBas = PlanteSel
                            End If
                            If CellB IsNot Nothing Then
                                CellB.PlanteHaut = PlanteSel
                            End If
                            If CellD IsNot Nothing Then
                                CellD.PlanteGauche = PlanteSel
                            End If
                            If CellG IsNot Nothing Then
                                CellG.PlanteDroite = PlanteSel
                            End If

                            If prcplus IsNot Nothing Then
                                .Serie = prcplus
                                .ToolTipText = Serie2Tooltip(.Serie)
                            End If
                        Else
                            Dim FormNouvelleParcelle As New FormParcelle
                            FormNouvelleParcelle.LabelPlante.Text = PlanteSel
                            Dim ListViewP As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewSerie", True)(0)

                            Dim compt As Integer = 1
                            Dim nomprc As String
                            Dim exist As Boolean
                            Do
                                exist = False
                                nomprc = "Parcelle" & compt
                                For Each itm As ListViewItem In ListViewP.Items
                                    If itm.Text = nomprc Then
                                        exist = True
                                        compt += 1
                                        Exit For
                                    End If
                                Next
                            Loop Until exist = False

                            FormNouvelleParcelle.TextBoxNomParcelle.Text = nomprc
                            If FormNouvelleParcelle.ShowDialog() = DialogResult.OK Then 'retourne NParcelle
                                .Tag = PlanteSel
                                If CellH IsNot Nothing Then
                                    CellH.PlanteBas = PlanteSel
                                End If
                                If CellB IsNot Nothing Then
                                    CellB.PlanteHaut = PlanteSel
                                End If
                                If CellD IsNot Nothing Then
                                    CellD.PlanteGauche = PlanteSel
                                End If
                                If CellG IsNot Nothing Then
                                    CellG.PlanteDroite = PlanteSel
                                End If

                                With NSerie
                                    Me.Series.Add(NSerie)
                                    With Cell
                                        .Serie = NSerie
                                        .ToolTipText = Serie2Tooltip(.Serie)
                                    End With
                                    ChargerListviewSeries(Me)

                                    ListViewParcelle_Click()
                                End With
                            End If
                        End If

                    Case Else

                        'CAS OU LE REMPLACEMENT SUPPRIME UNE PARCELLE
                        If H = .Tag Or B = .Tag Or G = .Tag Or D = .Tag Then
                        Else
                            Me.Series.Remove(.Serie)
                            ChargerListviewSeries(Me)
                            ListViewSerie_Click()
                        End If

                        If H = PlanteSel Or B = PlanteSel Or D = PlanteSel Or G = PlanteSel Then
                            .Tag = PlanteSel
                            If CellH IsNot Nothing Then
                                CellH.PlanteBas = PlanteSel
                            End If
                            If CellB IsNot Nothing Then
                                CellB.PlanteHaut = PlanteSel
                            End If
                            If CellD IsNot Nothing Then
                                CellD.PlanteGauche = PlanteSel
                            End If
                            If CellG IsNot Nothing Then
                                CellG.PlanteDroite = PlanteSel
                            End If

                            If prcplus IsNot Nothing Then
                                .Serie = prcplus
                                .ToolTipText = Serie2Tooltip(.Serie)
                            End If
                        Else
                            Dim FormNouvelleParcelle As New FormParcelle
                            FormNouvelleParcelle.LabelPlante.Text = PlanteSel
                            Dim ListViewP As ListView = FormP.TabControlConstruction.SelectedTab.Controls.Find("ListViewParcelle", True)(0)

                            Dim compt As Integer = 1
                            Dim nomprc As String
                            Dim exist As Boolean
                            Do
                                exist = False
                                nomprc = "Parcelle" & compt
                                For Each itm As ListViewItem In ListViewP.Items
                                    If itm.Text = nomprc Then
                                        exist = True
                                        compt += 1
                                        Exit For
                                    End If
                                Next
                            Loop Until exist = False

                            FormNouvelleParcelle.TextBoxNomParcelle.Text = nomprc
                            If FormNouvelleParcelle.ShowDialog() = DialogResult.OK Then 'retourne NParcelle
                                .Tag = PlanteSel
                                If CellH IsNot Nothing Then
                                    CellH.PlanteBas = PlanteSel
                                End If
                                If CellB IsNot Nothing Then
                                    CellB.PlanteHaut = PlanteSel
                                End If
                                If CellD IsNot Nothing Then
                                    CellD.PlanteGauche = PlanteSel
                                End If
                                If CellG IsNot Nothing Then
                                    CellG.PlanteDroite = PlanteSel
                                End If

                                With NSerie
                                    Me.Series.Add(NSerie)
                                    With Cell
                                        .Serie = NSerie
                                        .ToolTipText = Serie2Tooltip(.Serie)
                                    End With
                                    ChargerListviewSeries(Me)

                                    ListViewSerie_Click()
                                End With
                            End If
                        End If

                End Select
            End With

            If Cell IsNot Nothing Then
                Me.InvalidateCell(Cell)
            End If
            If CellB IsNot Nothing Then
                Me.InvalidateCell(CellB)
            End If
            If CellH IsNot Nothing Then
                Me.InvalidateCell(CellH)
            End If
            If CellD IsNot Nothing Then
                Me.InvalidateCell(CellD)
            End If
            If CellG IsNot Nothing Then
                Me.InvalidateCell(CellG)
            End If
        End If

    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.Handled = True
        End If
    End Sub
End Class

