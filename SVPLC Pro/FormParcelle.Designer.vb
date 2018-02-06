<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParcelle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPlante = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNomParcelle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBoxCommentaires = New System.Windows.Forms.RichTextBox()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTGEntretien = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debut = New SVPLC_Grid.CalendarColumn()
        Me.Fin = New SVPLC_Grid.CalendarColumn()
        Me.Commentaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalendarColumn1 = New SVPLC_Grid.CalendarColumn()
        Me.CalendarColumn2 = New SVPLC_Grid.CalendarColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DTGEntretien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plante associée:"
        '
        'LabelPlante
        '
        Me.LabelPlante.AutoSize = True
        Me.LabelPlante.Location = New System.Drawing.Point(122, 53)
        Me.LabelPlante.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPlante.Name = "LabelPlante"
        Me.LabelPlante.Size = New System.Drawing.Size(37, 13)
        Me.LabelPlante.TabIndex = 1
        Me.LabelPlante.Text = "Plante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom de la parcelle:"
        '
        'TextBoxNomParcelle
        '
        Me.TextBoxNomParcelle.Location = New System.Drawing.Point(125, 20)
        Me.TextBoxNomParcelle.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNomParcelle.Name = "TextBoxNomParcelle"
        Me.TextBoxNomParcelle.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxNomParcelle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Du:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Au:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(61, 81)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(61, 113)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Commentaires:"
        '
        'RichTextBoxCommentaires
        '
        Me.RichTextBoxCommentaires.Location = New System.Drawing.Point(15, 165)
        Me.RichTextBoxCommentaires.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBoxCommentaires.Name = "RichTextBoxCommentaires"
        Me.RichTextBoxCommentaires.Size = New System.Drawing.Size(255, 63)
        Me.RichTextBoxCommentaires.TabIndex = 11
        Me.RichTextBoxCommentaires.Text = ""
        '
        'ButtonOk
        '
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOk.Location = New System.Drawing.Point(731, 226)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(64, 26)
        Me.ButtonOk.TabIndex = 12
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxCommentaires)
        Me.GroupBox1.Controls.Add(Me.LabelPlante)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomParcelle)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(278, 246)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parcelle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTGEntretien)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(507, 214)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entretien et Tâches"
        '
        'DTGEntretien
        '
        Me.DTGEntretien.AllowUserToResizeRows = False
        Me.DTGEntretien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DTGEntretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGEntretien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Type, Me.Debut, Me.Fin, Me.Commentaire})
        Me.DTGEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTGEntretien.Location = New System.Drawing.Point(2, 15)
        Me.DTGEntretien.Margin = New System.Windows.Forms.Padding(2)
        Me.DTGEntretien.MultiSelect = False
        Me.DTGEntretien.Name = "DTGEntretien"
        Me.DTGEntretien.RowHeadersVisible = False
        Me.DTGEntretien.RowHeadersWidth = 20
        Me.DTGEntretien.RowTemplate.Height = 28
        Me.DTGEntretien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DTGEntretien.Size = New System.Drawing.Size(503, 197)
        Me.DTGEntretien.TabIndex = 0
        '
        'Nom
        '
        Me.Nom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Debut
        '
        Me.Debut.HeaderText = "Du"
        Me.Debut.Name = "Debut"
        Me.Debut.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Debut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Fin
        '
        Me.Fin.HeaderText = "Au"
        Me.Fin.Name = "Fin"
        Me.Fin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Commentaire
        '
        Me.Commentaire.HeaderText = "Commentaire"
        Me.Commentaire.Name = "Commentaire"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Action"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'CalendarColumn1
        '
        Me.CalendarColumn1.HeaderText = "Du"
        Me.CalendarColumn1.Name = "CalendarColumn1"
        Me.CalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CalendarColumn2
        '
        Me.CalendarColumn2.HeaderText = "Au"
        Me.CalendarColumn2.Name = "CalendarColumn2"
        Me.CalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Commentaire"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FormParcelle
        '
        Me.AcceptButton = Me.ButtonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 257)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormParcelle"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter une parcelle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DTGEntretien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelPlante As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNomParcelle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxCommentaires As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DTGEntretien As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarColumn1 As SVPLC_Grid.CalendarColumn
    Friend WithEvents CalendarColumn2 As SVPLC_Grid.CalendarColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debut As SVPLC_Grid.CalendarColumn
    Friend WithEvents Fin As SVPLC_Grid.CalendarColumn
    Friend WithEvents Commentaire As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
