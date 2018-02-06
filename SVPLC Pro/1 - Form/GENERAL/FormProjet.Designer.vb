<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProjet))
        Me.RadioButtonSPACE = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTMP = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTMPA = New System.Windows.Forms.RadioButton()
        Me.LabelAttention = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RadioButtonSPACE
        '
        Me.RadioButtonSPACE.AutoSize = True
        Me.RadioButtonSPACE.Location = New System.Drawing.Point(25, 24)
        Me.RadioButtonSPACE.Name = "RadioButtonSPACE"
        Me.RadioButtonSPACE.Size = New System.Drawing.Size(223, 17)
        Me.RadioButtonSPACE.TabIndex = 0
        Me.RadioButtonSPACE.TabStop = True
        Me.RadioButtonSPACE.Text = "Projet de conception à dominante spatiale"
        Me.RadioButtonSPACE.UseVisualStyleBackColor = True
        '
        'RadioButtonTMP
        '
        Me.RadioButtonTMP.AutoSize = True
        Me.RadioButtonTMP.Location = New System.Drawing.Point(25, 47)
        Me.RadioButtonTMP.Name = "RadioButtonTMP"
        Me.RadioButtonTMP.Size = New System.Drawing.Size(235, 17)
        Me.RadioButtonTMP.TabIndex = 1
        Me.RadioButtonTMP.TabStop = True
        Me.RadioButtonTMP.Text = "Projet de conception à dominante temporelle"
        Me.RadioButtonTMP.UseVisualStyleBackColor = True
        '
        'RadioButtonTMPA
        '
        Me.RadioButtonTMPA.AutoSize = True
        Me.RadioButtonTMPA.Location = New System.Drawing.Point(25, 70)
        Me.RadioButtonTMPA.Name = "RadioButtonTMPA"
        Me.RadioButtonTMPA.Size = New System.Drawing.Size(289, 17)
        Me.RadioButtonTMPA.TabIndex = 2
        Me.RadioButtonTMPA.TabStop = True
        Me.RadioButtonTMPA.Text = "Projet de conception à dominante temporelle automatisé"
        Me.RadioButtonTMPA.UseVisualStyleBackColor = True
        '
        'LabelAttention
        '
        Me.LabelAttention.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAttention.ForeColor = System.Drawing.Color.Red
        Me.LabelAttention.Location = New System.Drawing.Point(25, 103)
        Me.LabelAttention.Name = "LabelAttention"
        Me.LabelAttention.Size = New System.Drawing.Size(370, 45)
        Me.LabelAttention.TabIndex = 3
        Me.LabelAttention.Text = "LabelAttention"
        '
        'ButtonOk
        '
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOk.Location = New System.Drawing.Point(320, 151)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 4
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(309, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "by Vîle Fertile"
        '
        'FormProjet
        '
        Me.AcceptButton = Me.ButtonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 187)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.LabelAttention)
        Me.Controls.Add(Me.RadioButtonTMPA)
        Me.Controls.Add(Me.RadioButtonTMP)
        Me.Controls.Add(Me.RadioButtonSPACE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProjet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau Projet..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButtonSPACE As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTMP As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTMPA As System.Windows.Forms.RadioButton
    Friend WithEvents LabelAttention As System.Windows.Forms.Label
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
