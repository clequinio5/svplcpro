<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaracteristiqueProjet
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
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDebut = New System.Windows.Forms.Label()
        Me.MonthCalendarDebut = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelFin = New System.Windows.Forms.Label()
        Me.MonthCalendarFin = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxDivision = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSpatiale = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonOk
        '
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOk.Location = New System.Drawing.Point(494, 363)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 0
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.LabelDebut)
        Me.GroupBox1.Controls.Add(Me.MonthCalendarDebut)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 239)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Début"
        '
        'LabelDebut
        '
        Me.LabelDebut.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebut.Location = New System.Drawing.Point(12, 200)
        Me.LabelDebut.Name = "LabelDebut"
        Me.LabelDebut.Size = New System.Drawing.Size(249, 23)
        Me.LabelDebut.TabIndex = 2
        Me.LabelDebut.Text = "Label1"
        Me.LabelDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendarDebut
        '
        Me.MonthCalendarDebut.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendarDebut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendarDebut.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendarDebut.MaxSelectionCount = 1
        Me.MonthCalendarDebut.Name = "MonthCalendarDebut"
        Me.MonthCalendarDebut.ShowToday = False
        Me.MonthCalendarDebut.ShowTodayCircle = False
        Me.MonthCalendarDebut.ShowWeekNumbers = True
        Me.MonthCalendarDebut.TabIndex = 1
        Me.MonthCalendarDebut.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.LabelFin)
        Me.GroupBox2.Controls.Add(Me.MonthCalendarFin)
        Me.GroupBox2.Location = New System.Drawing.Point(293, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 240)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fin"
        '
        'LabelFin
        '
        Me.LabelFin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFin.Location = New System.Drawing.Point(12, 201)
        Me.LabelFin.Name = "LabelFin"
        Me.LabelFin.Size = New System.Drawing.Size(249, 23)
        Me.LabelFin.TabIndex = 3
        Me.LabelFin.Text = "Label2"
        Me.LabelFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendarFin
        '
        Me.MonthCalendarFin.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendarFin.MaxSelectionCount = 1
        Me.MonthCalendarFin.Name = "MonthCalendarFin"
        Me.MonthCalendarFin.ShowToday = False
        Me.MonthCalendarFin.ShowTodayCircle = False
        Me.MonthCalendarFin.ShowWeekNumbers = True
        Me.MonthCalendarFin.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ComboBoxSpatiale)
        Me.GroupBox3.Controls.Add(Me.ComboBoxDivision)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(556, 99)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Division"
        '
        'ComboBoxDivision
        '
        Me.ComboBoxDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDivision.FormattingEnabled = True
        Me.ComboBoxDivision.Items.AddRange(New Object() {"Jour", "1 Semaine - 7 Jours", "2 Semaine - 14 Jours ", "3 Semaine - 21 Jours", "Mois", "Année"})
        Me.ComboBoxDivision.Location = New System.Drawing.Point(141, 19)
        Me.ComboBoxDivision.Name = "ComboBoxDivision"
        Me.ComboBoxDivision.Size = New System.Drawing.Size(270, 21)
        Me.ComboBoxDivision.TabIndex = 0
        '
        'ComboBoxSpatiale
        '
        Me.ComboBoxSpatiale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpatiale.FormattingEnabled = True
        Me.ComboBoxSpatiale.Location = New System.Drawing.Point(187, 56)
        Me.ComboBoxSpatiale.Name = "ComboBoxSpatiale"
        Me.ComboBoxSpatiale.Size = New System.Drawing.Size(181, 21)
        Me.ComboBoxSpatiale.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Temporelle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Spatiale:"
        '
        'FormCaracteristiqueProjet
        '
        Me.AcceptButton = Me.ButtonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 398)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCaracteristiqueProjet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caractéristiques du Projet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendarDebut As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendarFin As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDivision As System.Windows.Forms.ComboBox
    Friend WithEvents LabelDebut As System.Windows.Forms.Label
    Friend WithEvents LabelFin As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSpatiale As System.Windows.Forms.ComboBox
End Class
