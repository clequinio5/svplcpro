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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTMPM = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSPACE = New System.Windows.Forms.RadioButton()
        Me.LabelAttention = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(38, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButtonTMPM
        '
        Me.RadioButtonTMPM.AutoSize = True
        Me.RadioButtonTMPM.Location = New System.Drawing.Point(38, 52)
        Me.RadioButtonTMPM.Name = "RadioButtonTMPM"
        Me.RadioButtonTMPM.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonTMPM.TabIndex = 1
        Me.RadioButtonTMPM.TabStop = True
        Me.RadioButtonTMPM.Text = "RadioButton2"
        Me.RadioButtonTMPM.UseVisualStyleBackColor = True
        '
        'RadioButtonSPACE
        '
        Me.RadioButtonSPACE.AutoSize = True
        Me.RadioButtonSPACE.Location = New System.Drawing.Point(38, 75)
        Me.RadioButtonSPACE.Name = "RadioButtonSPACE"
        Me.RadioButtonSPACE.Size = New System.Drawing.Size(90, 17)
        Me.RadioButtonSPACE.TabIndex = 2
        Me.RadioButtonSPACE.TabStop = True
        Me.RadioButtonSPACE.Text = "RadioButton3"
        Me.RadioButtonSPACE.UseVisualStyleBackColor = True
        '
        'LabelAttention
        '
        Me.LabelAttention.AutoSize = True
        Me.LabelAttention.Location = New System.Drawing.Point(38, 108)
        Me.LabelAttention.Name = "LabelAttention"
        Me.LabelAttention.Size = New System.Drawing.Size(75, 13)
        Me.LabelAttention.TabIndex = 3
        Me.LabelAttention.Text = "LabelAttention"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(301, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormProjet
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 174)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelAttention)
        Me.Controls.Add(Me.RadioButtonSPACE)
        Me.Controls.Add(Me.RadioButtonTMPM)
        Me.Controls.Add(Me.RadioButton1)
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTMPM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSPACE As System.Windows.Forms.RadioButton
    Friend WithEvents LabelAttention As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
