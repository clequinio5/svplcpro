Public Class DTGTMP1
    Inherits DataGridView
    Dim MdownQ As Boolean
    Private lp As New List(Of Planche)
    Property Planches As List(Of Planche)
        ' Sets the method for retrieving the value of your property.
        Get
            Return lp
        End Get
        ' Sets the method for setting the value of your property.
        Set(ByVal Value As List(Of Planche))
            lp = Value
        End Set
    End Property
    Public Sub New()

        With Me
            .Name = "DTGridTMP1"
            .Dock = DockStyle.Fill
            .BorderStyle = Windows.Forms.BorderStyle.None
            .GridColor = ColorGrid
            .BackgroundColor = Color.White
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .DefaultCellStyle.SelectionBackColor = .DefaultCellStyle.BackColor
            .DefaultCellStyle.SelectionForeColor = .DefaultCellStyle.ForeColor
            .RowHeadersWidth = 50
            .ShowEditingIcon = False
            .ReadOnly = True
            .MultiSelect = False
            For i = 0 To NDalleSetup
                AjouterColumnDTGTMP1(Me, i, cDalleSetupSPACE)
                AjouterLigneDTGTMP1(Me, i, cDalleSetupSPACE)
            Next
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
    Protected Overrides Sub OnScroll(ByVal e As System.Windows.Forms.ScrollEventArgs)

        'DATAGRID INFINI
        Dim col As Integer = Me.Columns.Count - 1
        Dim row As Integer = Me.Rows.Count - 1
        Dim cell As Integer = Me.Columns(0).Width
        Dim H As Integer = Me.Parent.Width
        Dim V As Integer = Me.Parent.Height
        Dim offset As Integer

        Select Case e.ScrollOrientation
            Case ScrollOrientation.HorizontalScroll
                offset = H - (col * cell - e.NewValue)
                If offset >= 0 Then
                    For i As Integer = col To col + Int(offset / cell) + 1
                        AjouterColumnDTGTMP1(Me, i, cell)
                    Next
                End If
            Case ScrollOrientation.VerticalScroll
                offset = V - (row - e.NewValue) * cell
                If offset >= 0 Then
                    For i = row To row + Int(offset / cell) + 2
                        AjouterLigneDTGTMP1(Me, i, cell)
                    Next
                End If
        End Select
    End Sub
    Protected Overrides Sub OnCellMouseMove(ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try
            If MdownQ = True Then
                Dim Cell As CellTMP1 = Me(e.ColumnIndex, e.RowIndex)
                If Cell.SelectedQ = False Then
                    Cell.SelectedQ = True
                End If
                Me.InvalidateCell(Cell)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnCellMouseUp(ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MdownQ = False
        End If
    End Sub
    Protected Overrides Sub OnCellMouseDown(ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Left Then
            'Gere les exceptions aux frontieres
            Try
                MdownQ = True
                Dim Cell As CellTMP1 = Me(e.ColumnIndex, e.RowIndex)
                If Cell.SelectedQ = True Then
                    Cell.SelectedQ = False
                Else
                    Cell.SelectedQ = True
                End If
                Me.InvalidateCell(Cell)
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Enter Then
            e.Handled = True
        End If
    End Sub
End Class
