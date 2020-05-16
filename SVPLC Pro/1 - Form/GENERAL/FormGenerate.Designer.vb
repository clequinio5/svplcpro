<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerate
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelMaxRotations = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelMaxAssociations = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelNCombinaisons = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNParcelle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ListViewCalculations = New System.Windows.Forms.ListView()
        Me.ColumnIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNoteAsso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNoteRotation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNAssoPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNAssoNeg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNRotPos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnNRotNeg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnIND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnCombinaison = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBoxPlantes = New System.Windows.Forms.RichTextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorkerPlay = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.59016!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.40984!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelMaxRotations, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelMaxAssociations, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNCombinaisons, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNParcelle, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ListViewCalculations, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBoxPlantes, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 397)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 69)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Plantes"
        '
        'LabelMaxRotations
        '
        Me.LabelMaxRotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMaxRotations.Location = New System.Drawing.Point(137, 80)
        Me.LabelMaxRotations.Name = "LabelMaxRotations"
        Me.LabelMaxRotations.Size = New System.Drawing.Size(409, 20)
        Me.LabelMaxRotations.TabIndex = 9
        Me.LabelMaxRotations.Text = "Données du calcul"
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Note max. rotations"
        '
        'LabelMaxAssociations
        '
        Me.LabelMaxAssociations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMaxAssociations.Location = New System.Drawing.Point(137, 60)
        Me.LabelMaxAssociations.Name = "LabelMaxAssociations"
        Me.LabelMaxAssociations.Size = New System.Drawing.Size(409, 20)
        Me.LabelMaxAssociations.TabIndex = 7
        Me.LabelMaxAssociations.Text = "Données du calcul"
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Note max. associations"
        '
        'LabelNCombinaisons
        '
        Me.LabelNCombinaisons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNCombinaisons.Location = New System.Drawing.Point(137, 40)
        Me.LabelNCombinaisons.Name = "LabelNCombinaisons"
        Me.LabelNCombinaisons.Size = New System.Drawing.Size(409, 20)
        Me.LabelNCombinaisons.TabIndex = 5
        Me.LabelNCombinaisons.Text = "Données du calcul"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre de combinaisons"
        '
        'LabelNParcelle
        '
        Me.LabelNParcelle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNParcelle.Location = New System.Drawing.Point(137, 20)
        Me.LabelNParcelle.Name = "LabelNParcelle"
        Me.LabelNParcelle.Size = New System.Drawing.Size(409, 20)
        Me.LabelNParcelle.TabIndex = 3
        Me.LabelNParcelle.Text = "Données du calcul"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de parcelles"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Données du calcul"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPlay, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonStop, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 172)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(128, 53)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'ButtonPlay
        '
        Me.ButtonPlay.BackgroundImage = Global.SVPLC_Grid.My.Resources.Resources.play
        Me.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPlay.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(58, 47)
        Me.ButtonPlay.TabIndex = 0
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.BackgroundImage = Global.SVPLC_Grid.My.Resources.Resources._stop
        Me.ButtonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonStop.Location = New System.Drawing.Point(67, 3)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(58, 47)
        Me.ButtonStop.TabIndex = 1
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ListViewCalculations
        '
        Me.ListViewCalculations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnIndex, Me.ColumnNoteAsso, Me.ColumnNoteRotation, Me.ColumnNAssoPos, Me.ColumnNAssoNeg, Me.ColumnNRotPos, Me.ColumnNRotNeg, Me.ColumnIND, Me.ColumnCombinaison})
        Me.TableLayoutPanel1.SetColumnSpan(Me.ListViewCalculations, 2)
        Me.ListViewCalculations.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListViewCalculations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewCalculations.FullRowSelect = True
        Me.ListViewCalculations.GridLines = True
        Me.ListViewCalculations.Location = New System.Drawing.Point(3, 231)
        Me.ListViewCalculations.Name = "ListViewCalculations"
        Me.ListViewCalculations.Size = New System.Drawing.Size(543, 163)
        Me.ListViewCalculations.TabIndex = 14
        Me.ListViewCalculations.UseCompatibleStateImageBehavior = False
        Me.ListViewCalculations.View = System.Windows.Forms.View.Details
        '
        'ColumnIndex
        '
        Me.ColumnIndex.Text = "Calcul n°"
        '
        'ColumnNoteAsso
        '
        Me.ColumnNoteAsso.Text = "Note Asso"
        Me.ColumnNoteAsso.Width = 59
        '
        'ColumnNoteRotation
        '
        Me.ColumnNoteRotation.Text = "Note Rot"
        '
        'ColumnNAssoPos
        '
        Me.ColumnNAssoPos.Text = "Asso +"
        '
        'ColumnNAssoNeg
        '
        Me.ColumnNAssoNeg.Text = "Asso -"
        '
        'ColumnNRotPos
        '
        Me.ColumnNRotPos.Text = "Rot +"
        '
        'ColumnNRotNeg
        '
        Me.ColumnNRotNeg.Text = "Rot -"
        '
        'ColumnIND
        '
        Me.ColumnIND.Text = "IND"
        '
        'ColumnCombinaison
        '
        Me.ColumnCombinaison.Text = "Combinaison"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(284, 26)
        '
        'ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem
        '
        Me.ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem.Name = "ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem"
        Me.ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem.Text = "Exporter les lignes selectionnées en CSV"
        '
        'RichTextBoxPlantes
        '
        Me.RichTextBoxPlantes.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBoxPlantes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxPlantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxPlantes.Location = New System.Drawing.Point(137, 3)
        Me.RichTextBoxPlantes.Name = "RichTextBoxPlantes"
        Me.RichTextBoxPlantes.ReadOnly = True
        Me.RichTextBoxPlantes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBoxPlantes.Size = New System.Drawing.Size(409, 14)
        Me.RichTextBoxPlantes.TabIndex = 15
        Me.RichTextBoxPlantes.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 5)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(389, 21)
        Me.ProgressBar1.TabIndex = 13
        '
        'BackgroundWorkerPlay
        '
        Me.BackgroundWorkerPlay.WorkerReportsProgress = True
        Me.BackgroundWorkerPlay.WorkerSupportsCancellation = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "CSV|*.csv"
        Me.SaveFileDialog1.Title = "Exporter en CSV"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ProgressBar1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(137, 172)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(409, 53)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 397)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGenerate"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generate"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelMaxRotations As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelMaxAssociations As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelNCombinaisons As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelNParcelle As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ListViewCalculations As System.Windows.Forms.ListView
    Friend WithEvents ColumnIndex As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNoteAsso As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNoteRotation As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNAssoPos As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNAssoNeg As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNRotPos As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnNRotNeg As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnCombinaison As System.Windows.Forms.ColumnHeader
    Friend WithEvents RichTextBoxPlantes As System.Windows.Forms.RichTextBox
    Friend WithEvents BackgroundWorkerPlay As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColumnIND As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExporterLesLignesSelectionnéesEnCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
