Public Class CellTMP1
    Inherits DataGridViewTextBoxCell
    Dim sel As New Pen(Brushes.LightGray, 2)
    Dim plch As Planche
    Dim selec As Boolean
    Property Planche() As Planche
        ' Sets the method for retrieving the value of your property.
        Get
            Return plch
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As Planche)
            plch = Value
        End Set
    End Property
    Property SelectedQ As Boolean
        ' Sets the method for retrieving the value of your property.
        Get
            Return selec
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As Boolean)
            selec = Value
        End Set
    End Property
    Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal elementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)

        'DEFAULT
        Me.Style.BackColor = ColorCell
        Me.Style.SelectionBackColor = ColorCell
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

        Dim destRect As Rectangle = New Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 1)
        If Me.SelectedQ = True Then
            If Me.Planche Is Nothing Then
                graphics.FillRectangle(New SolidBrush(Color.LightGray), destRect)
            Else
                graphics.FillRectangle(New SolidBrush(PlancheColor(Me.Planche.Clef - 1)), destRect)
                graphics.DrawString(Me.Planche.Clef, New Font("Microsoft sans Serif", 9), Brushes.Black, New PointF(cellBounds.X, cellBounds.Y))
            End If
        Else
            graphics.FillRectangle(New SolidBrush(ColorCell), destRect)
            If Me.Planche IsNot Nothing Then
                Dim Clef As Integer = Me.Planche.Clef
                If Clef = -1 Then
                    plch = Nothing
                    Me.SelectedQ = False
                Else
                    graphics.FillRectangle(New SolidBrush(PlancheColor(Clef - 1)), destRect)
                    graphics.DrawString(Me.Planche.Clef, New Font("Microsoft sans Serif", 9), Brushes.Black, New PointF(cellBounds.X, cellBounds.Y))
                End If
                
            End If
        End If

        'SELECTION
        Try
            Dim cursorPosition As Point = Me.DataGridView.PointToClient(Cursor.Position)
            If cellBounds.Contains(cursorPosition) Then
                Dim newRect As New Rectangle(cellBounds.X + 1, cellBounds.Y + 1, cellBounds.Width - 3, cellBounds.Height - 3)
                graphics.DrawRectangle(sel, newRect)
            End If
        Catch ex As Exception

        End Try
        
        

    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub
End Class
