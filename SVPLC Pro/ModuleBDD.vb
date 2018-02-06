Imports System.IO
Imports System.Text

Module ModuleBDD
    '=================================================================================
    Public Sub Chargement_Associations()
        'CHARGEMENT ASSOCIATIONS
        Try

            FormP.DataGridViewAssociations.Columns.Clear()
            FormP.DataGridViewAssociations.Rows.Clear()

            Dim Str As String
            For i = 0 To FormP.ListViewPlantes.Items.Count - 1
                Str = FormP.ListViewPlantes.Items(i).Text
                With FormP.DataGridViewAssociations
                    .Columns.Add("C" & Str, Str)
                    .Columns(i).Width = 50
                    .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    .Rows.Add()
                    .Rows(i).HeaderCell.Value = Str
                End With
            Next

            With FormP.DataGridViewAssociations
                For i = 0 To .Columns.Count - 1
                    For j = 0 To .Rows.Count - 1
                        If i >= j Then
                            FormP.DataGridViewAssociations(i, j).ReadOnly = True
                            FormP.DataGridViewAssociations(i, j).Style.BackColor = Color.Gray
                        End If
                    Next
                Next
            End With

            Dim strg() As String
            Dim lecture As New StreamReader(PathAssociations, Encoding.Default)
            While lecture.Peek <> -1
                Str = lecture.ReadLine
                strg = Str.Split("|")
                With FormP.DataGridViewAssociations
                    For i = 0 To .Columns.Count - 1
                        If .Columns(i).HeaderText = strg(0) Then
                            For j = 0 To .Rows.Count - 1
                                If .Rows(j).HeaderCell.Value = strg(1) Then
                                    With FormP.DataGridViewAssociations(i, j)
                                        .Value = strg(2)
                                        If strg(2) > 0 Then
                                            .Style.BackColor = Color.Green
                                        End If
                                        If strg(2) < 0 Then
                                            .Style.BackColor = Color.Red
                                        End If
                                        .ToolTipText = strg(3).Replace("`", vbCrLf)
                                    End With
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End With
            End While
            lecture.Close()

        Catch ex As Exception
            MsgBox("Erreur de chargement des associations", MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Public Sub Chargement_Rotations()
        'CHARGEMENT ROTATIONS
        Try
            Dim Str As String
            For i = 0 To FormP.ListViewPlantes.Items.Count - 1
                Str = FormP.ListViewPlantes.Items(i).Text
                With FormP.DataGridViewRotations
                    .Columns.Add("C" & Str, Str)
                    .Columns(i).Width = 50
                    .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    .Rows.Add()
                    .Rows(i).HeaderCell.Value = Str
                End With
            Next

            Dim strg() As String
            Dim lecture As StreamReader
            lecture = New StreamReader(PathRotations, Encoding.Default)
            While lecture.Peek <> -1
                Str = lecture.ReadLine
                strg = Str.Split("|")
                With FormP.DataGridViewRotations
                    For i = 0 To .Columns.Count - 1
                        If .Columns(i).HeaderText = strg(0) Then
                            For j = 0 To .Rows.Count - 1
                                If .Rows(j).HeaderCell.Value = strg(1) Then
                                    With FormP.DataGridViewRotations(i, j)
                                        .Value = strg(2)
                                        If strg(2) > 0 Then
                                            .Style.BackColor = Color.Green
                                        End If
                                        If strg(2) < 0 Then
                                            .Style.BackColor = Color.Red
                                        End If
                                        .ToolTipText = strg(3).Replace("`", vbCrLf)
                                    End With
                                    Exit For
                                End If
                            Next
                        End If
                    Next
                End With
            End While
            lecture.Close()

        Catch ex As Exception
            MsgBox("Erreur de chargement des rotations", MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Public Sub Chargement_Images()
        'CHARGEMENT IMAGES
        Try
            FormP.ImageListBDDPlantes.Images.Clear()
            FormP.ImageListPlantes.Images.Clear()

            Dim img As Image
            Dim name As String

            For Each files As String In My.Computer.FileSystem.GetFiles(PathImage)
                img = Image.FromFile(files)
                name = Path.GetFileNameWithoutExtension(files)
                FormP.ImageListBDDPlantes.Images.Add(name, img)
                FormP.ImageListPlantes.Images.Add(name, img)
            Next

        Catch ex As Exception
            MsgBox("Erreur de chargement des images!", MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Public Sub Chargement_Plantes()
        'CHARGEMENT PLANTES
        Try
            FormP.Cursor = Cursors.WaitCursor

            FormP.ListViewPlantes.Items.Clear()

            Dim str As String
            Dim lecture As StreamReader
            Dim tabsp() As String
            Dim item As ListViewItem
            lecture = New StreamReader(PathPlantes, Encoding.Default)
            While lecture.Peek <> -1
                str = lecture.ReadLine()
                tabsp = str.Split("|")
                item = New ListViewItem(tabsp)
                Dim pl As New Plante
                With pl
                    .Name = tabsp(0)
                    .Famille = tabsp(1)
                    .Type = tabsp(2)
                    .Vivace = tabsp(3)
                    .Mise_en_Terre = tabsp(4)
                    .Recolte = tabsp(5)
                End With
                item.Tag = pl
                item.ImageKey = item.Text
                FormP.ListViewPlantes.Items.Add(item)
            End While
            lecture.Close()

            FormP.ListViewPlantes.Items(0).Selected = True

            FormP.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Erreur de chargement de la BDD Plantes!", MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub
    Public Sub Chargement_Entretien()
        'CHARGEMENT ENTRETIEN
        Try
            FormP.Cursor = Cursors.WaitCursor

            FormP.ListViewEntretien.Items.Clear()

            Dim str As String
            Dim lecture As StreamReader
            Dim tabsp() As String
            Dim item As ListViewItem
            lecture = New StreamReader(PathEntretien, Encoding.Default)
            While lecture.Peek <> -1
                str = lecture.ReadLine()
                tabsp = str.Split("|")
                item = New ListViewItem(tabsp)
                Dim ent As New Entretien
                With ent
                    .Name = tabsp(0)
                    .Type = tabsp(1)
                End With
                item.Tag = ent
                'item.ImageKey = item.Text
                FormP.ListViewEntretien.Items.Add(item)
            End While
            lecture.Close()

            FormP.ListViewEntretien.Items(0).Selected = True

            FormP.ListViewEntretien.ListViewItemSorter = New ListViewItemComparer(1, FormP.ListViewEntretien.Sorting)

            FormP.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Erreur de chargement de la BDD Entretien!", MsgBoxStyle.Exclamation, "Erreur")
        End Try
    End Sub

    '===========================================================================================
    Public Sub Effacer_de_la_BDDPlantes(ByVal NomPlante As String)
        Dim lines As List(Of String) = File.ReadAllLines(PathPlantes, Encoding.Default).ToList
        For i = lines.Count - 1 To 0 Step -1
            If lines(i).Split("|")(0) = NomPlante Then
                lines.RemoveAt(i)
            End If
        Next
        File.WriteAllLines(PathPlantes, lines, Encoding.Default)
    End Sub
    Public Sub Effacer_Image(ByVal NomPlante As String)
        Dim path As String
        path = PathImage & "\" & NomPlante & ".png"
        File.Delete(path)
    End Sub
    Public Sub Effacer_Association(ByVal NomPlante As String)
        Dim lines As List(Of String) = File.ReadAllLines(PathAssociations, Encoding.Default).ToList
        For i = lines.Count - 1 To 0 Step -1
            If lines(i).Split("|")(0) = NomPlante Or lines(i).Split("|")(1) = NomPlante Then
                lines.RemoveAt(i)
            End If
        Next
        File.WriteAllLines(PathAssociations, lines, Encoding.Default)
    End Sub
    Public Sub Effacer_Rotations(ByVal NomPlante As String)
        Dim lines As List(Of String) = File.ReadAllLines(PathRotations, Encoding.Default).ToList
        For i = lines.Count - 1 To 0 Step -1
            If lines(i).Split("|")(0) = NomPlante Or lines(i).Split("|")(1) = NomPlante Then
                lines.RemoveAt(i)
            End If
        Next
        File.WriteAllLines(PathRotations, lines, Encoding.Default)
    End Sub
    Public Sub Effacer_de_la_BDDEntretien(ByVal NomEntretien As String)
        Dim lines As List(Of String) = File.ReadAllLines(PathEntretien, Encoding.Default).ToList
        For i = lines.Count - 1 To 0 Step -1
            If lines(i).Split("|")(0) = NomEntretien Then
                lines.RemoveAt(i)
            End If
        Next
        File.WriteAllLines(PathEntretien, lines, Encoding.Default)
    End Sub
End Module
