Imports System.IO
Imports System.Text

Public Class FormPlante

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.Tag = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click

        If Me.Text = "Modifier la plante" Then

            'Chargement de la BDD Plante
            Dim lines As List(Of String) = File.ReadAllLines(PathPlantes, Encoding.Default).ToList
            For i = lines.Count - 1 To 0 Step -1
                If lines(i).Split("|")(0) = Label1.Tag Then
                    lines.RemoveAt(i)
                End If
            Next

            'Ecriture des nouvelles infos
            Dim checkstate As String = ""
            Select Case CheckBox1.Checked
                Case True
                    checkstate = "Oui"
                Case False
                    checkstate = "Non"
            End Select
            Dim miseterre As String = "De " & ComboBox1.Text & " à " & ComboBox2.Text
            Dim recolte As String = "De " & ComboBox3.Text & " à " & ComboBox4.Text
            Dim str As String = TextBox1.Text & "|" & TextBox4.Text & "|" & TextBox5.Text & "|" & TextBox2.Text & "|" & TextBox3.Text & "|" & checkstate & "|" & miseterre & "|" & recolte
            lines.Add(str)
            File.WriteAllLines(PathPlantes, lines, Encoding.Default)

            'LIBERE LE FICHIER SI IL EXISTE
            Try
                'Image
                Dim pathe As String = PathImage & "\" & TextBox1.Text & ".png"
                Dim key As Integer = FormP.ImageListPlantes.Images.IndexOfKey(FormP.ListViewPlantes.SelectedItems(0).Text)
                FormP.ImageListPlantes.Images.RemoveAt(key)
                FormP.ImageListBDDPlantes.Images.RemoveAt(key)

                If PictureBox1.Tag <> pathe Then
                    File.Delete(pathe)
                    If PictureBox1.Tag IsNot Nothing Then
                        File.Copy(PictureBox1.Tag, pathe)
                    Else
                        My.Resources.Appareil_photo.Save(pathe)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Oups!Pour remplacer l'image, soyez sûr qu'elle n'est pas utilisée ailleurs par le logiciel", MsgBoxStyle.Exclamation, "Erreur traitement image")
            End Try

            'SI RENOMME
            Dim oldname As String
            Dim newname As String
            oldname = Label1.Tag
            newname = TextBox1.Text
            If oldname <> newname Then
                Dim fichier As String
                fichier = File.ReadAllText(PathAssociations, Encoding.Default)
                File.WriteAllText(PathAssociations, fichier.Replace(oldname & "|", newname & "|"), Encoding.Default)

                fichier = File.ReadAllText(PathRotations, Encoding.Default)
                File.WriteAllText(PathRotations, fichier.Replace(oldname & "|", newname & "|"), Encoding.Default)
            End If

            Chargement_Images()
            Chargement_Plantes()
            Chargement_Associations()
            Chargement_Rotations()

            Me.Close()

        End If

        If Me.Text = "Ajouter une plante" Then
            Dim lines As List(Of String) = File.ReadAllLines(PathPlantes, Encoding.Default).ToList
            Dim checkstate As String = ""
            Select Case CheckBox1.Checked
                Case True
                    checkstate = "Oui"
                Case False
                    checkstate = "Non"
            End Select
            Dim miseterre As String = "De " & ComboBox1.Text & " à " & ComboBox2.Text
            Dim recolte As String = "De " & ComboBox3.Text & " à " & ComboBox4.Text
            Dim str As String = TextBox1.Text & "|" & TextBox4.Text & "|" & TextBox5.Text & "|" & TextBox2.Text & "|" & TextBox3.Text & "|" & checkstate & "|" & miseterre & "|" & recolte
            lines.Add(str)

            File.WriteAllLines(PathPlantes, lines, Encoding.Default)

            Dim pathe As String = PathImage & "\" & TextBox1.Text & Path.GetExtension(OpenFileDialog1.FileName)
            If File.Exists(pathe) Then
                File.Delete(pathe)
            End If
            If PictureBox1.Tag IsNot Nothing Then
                File.Copy(PictureBox1.Tag, pathe)
            Else
                My.Resources.Appareil_photo.Save(pathe)
            End If

            Chargement_Images()
            Chargement_Plantes()
            Chargement_Associations()
            Chargement_Rotations()

            Me.Close()

        End If

    End Sub

End Class