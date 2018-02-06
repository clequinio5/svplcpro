Public Class CellTMPA
    Inherits DataGridViewTextBoxCell
    Dim sr As Serie
    Dim H(1), B(1), G(1), D(1), R(1) As String
    Dim sel As New Pen(Brushes.Gray, 2)
    Private pd, pg, ph, pb, pr As String
    Property Serie() As Serie
        ' Sets the method for retrieving the value of your property.
        Get
            Return sr
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As Serie)
            sr = Value
        End Set
    End Property
    Property PlanteDroite() As String
        ' Sets the method for retrieving the value of your property.
        Get
            Return pd
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As String)
            pd = Value
        End Set
    End Property
    Property PlanteGauche() As String
        ' Sets the method for retrieving the value of your property.
        Get
            Return pg
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As String)
            pg = Value
        End Set
    End Property
    Property PlanteHaut() As String
        ' Sets the method for retrieving the value of your property.
        Get
            Return ph
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As String)
            ph = Value
        End Set
    End Property
    Property PlanteBas() As String
        ' Sets the method for retrieving the value of your property.
        Get
            Return pb
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As String)
            pb = Value
        End Set
    End Property
    Property Rotation() As String
        ' Sets the method for retrieving the value of your property.
        Get
            Return pr
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As String)
            pr = Value
        End Set
    End Property
    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)

        'DEFAULT
        Me.Style.BackColor = ColorCell
        Me.Style.SelectionBackColor = ColorCell
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        Dim destRect As Rectangle = New Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 1)

        If Me.Tag <> "" Then
            'DESSINE LE LEGUME
            Dim key As Integer
            key = FormP.ImageListPlantes.Images.IndexOfKey(Me.Tag)
            If key <> -1 Then
                Dim img As Bitmap = FormP.ImageListPlantes.Images(key)
                Dim srcRect As Rectangle = New Rectangle(0, 0, img.Width, img.Height)
                graphics.DrawImage(img, destRect, srcRect, GraphicsUnit.Pixel)
            End If

        Else
            'DESSINE L'ANALYSE
            If Me.PlanteBas <> "" Or Me.PlanteDroite <> "" Or Me.PlanteGauche <> "" Or Me.PlanteHaut <> "" Or Me.Rotation <> "" Then
                Dim PlanteSel As String = FormP.ListViewPlantes.SelectedItems(0).Text
                Dim br As New SolidBrush(Me.DataGridView.BackgroundColor)

                '===================================
                Dim Unit As Integer = cellBounds.Width - 1
                Dim offset As Integer = Unit / 3.5
                Dim OrigX As Integer = cellBounds.X
                Dim OrigY As Integer = cellBounds.Y

                Dim p1 As New Point(OrigX, OrigY)
                Dim p2 As New Point(OrigX + Unit, OrigY)
                Dim p3 As New Point(OrigX + Unit, OrigY + Unit)
                Dim p4 As New Point(OrigX, OrigY + Unit)
                Dim p5 As New Point(OrigX + offset, OrigY + offset)
                Dim p6 As New Point(OrigX + Unit - offset, OrigY + offset)
                Dim p7 As New Point(OrigX + Unit - offset, OrigY + Unit - offset)
                Dim p8 As New Point(OrigX + offset, OrigY + Unit - offset)

                Dim Hpolygon As Point() = {p1, p5, p6, p2}
                Dim Bpolygon As Point() = {p3, p7, p8, p4}
                Dim Gpolygon As Point() = {p4, p8, p5, p1}
                Dim Dpolygon As Point() = {p2, p6, p7, p3}
                Dim Rcarré As Point() = {p5, p6, p7, p8}

                '====================================
                'EMPREINTE DE LA PHASE PRECEDENTE
                If Me.Rotation <> "" Then
                    graphics.FillRectangle(Brushes.LightGray, destRect)
                End If

                H = RechercherBDDDTG(FormP.DataGridViewAssociations, Me.PlanteHaut, PlanteSel)
                Select Case H(0)
                    Case Is > 0
                        graphics.FillPolygon(Brushes.Green, Hpolygon)
                    Case Is < 0
                        graphics.FillPolygon(Brushes.Red, Hpolygon)
                    Case Is = 0
                        If Me.PlanteHaut <> "" Then
                            H(1) = Me.PlanteHaut & "/" & PlanteSel
                        End If
                End Select

                D = RechercherBDDDTG(FormP.DataGridViewAssociations, Me.PlanteDroite, PlanteSel)
                Select Case D(0)
                    Case Is > 0
                        graphics.FillPolygon(Brushes.Green, Dpolygon)
                    Case Is < 0
                        graphics.FillPolygon(Brushes.Red, Dpolygon)
                    Case Is = 0
                        If Me.PlanteDroite <> "" Then
                            D(1) = Me.PlanteDroite & "/" & PlanteSel
                        End If
                End Select

                G = RechercherBDDDTG(FormP.DataGridViewAssociations, Me.PlanteGauche, PlanteSel)
                Select Case G(0)
                    Case Is > 0
                        graphics.FillPolygon(Brushes.Green, Gpolygon)
                    Case Is < 0
                        graphics.FillPolygon(Brushes.Red, Gpolygon)
                    Case Is = 0
                        If Me.PlanteGauche <> "" Then
                            G(1) = Me.PlanteGauche & "/" & PlanteSel
                        End If
                End Select

                B = RechercherBDDDTG(FormP.DataGridViewAssociations, Me.PlanteBas, PlanteSel)
                Select Case B(0)
                    Case Is > 0
                        graphics.FillPolygon(Brushes.Green, Bpolygon)
                    Case Is < 0
                        graphics.FillPolygon(Brushes.Red, Bpolygon)
                    Case Is = 0
                        If Me.PlanteBas <> "" Then
                            B(1) = Me.PlanteBas & "/" & PlanteSel
                        End If
                End Select

                R = RechercherBDDDTG(FormP.DataGridViewRotations, Me.Rotation, PlanteSel)
                Select Case R(0)
                    Case Is > 0
                        graphics.FillPolygon(Brushes.Green, Rcarré)
                    Case Is < 0
                        graphics.FillPolygon(Brushes.Red, Rcarré)
                    Case Is = 0
                        If Me.Rotation <> "" Then
                            R(1) = Me.Rotation & "/" & PlanteSel
                        End If
                End Select
                Me.ToolTipText = "H(" & H(0) & "): " & H(1) & vbCrLf & "D(" & D(0) & "): " & D(1) & vbCrLf & "B(" & B(0) & "): " & B(1) & vbCrLf & "G(" & G(0) & "): " & G(1) & vbCrLf & "R(" & R(0) & "): " & R(1)
            Else
                Me.ToolTipText = ""
            End If

        End If

        'SELECTION
        Dim cursorPosition As Point = Me.DataGridView.PointToClient(Cursor.Position)
        If cellBounds.Contains(cursorPosition) Then
            Dim newRect As New Rectangle(cellBounds.X + 1, cellBounds.Y + 1, cellBounds.Width - 3, cellBounds.Height - 3)
            graphics.DrawRectangle(sel, newRect)
        End If




    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub
End Class
