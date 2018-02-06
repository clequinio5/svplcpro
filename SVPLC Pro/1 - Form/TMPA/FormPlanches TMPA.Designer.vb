<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlanchesTMPA
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EspPlanche = New System.Windows.Forms.NumericUpDown()
        Me.LarPlanche = New System.Windows.Forms.NumericUpDown()
        Me.LonPlanche = New System.Windows.Forms.NumericUpDown()
        Me.NPlanches = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.EspPlanche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LarPlanche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LonPlanche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NPlanches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonOk
        '
        Me.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonOk.Location = New System.Drawing.Point(135, 178)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(10)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(76, 25)
        Me.ButtonOk.TabIndex = 9
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre de planches:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 42)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Longueur (m):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 42)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Espacement (m):"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 42)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Largeur (m):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.58363!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.41637!))
        Me.TableLayoutPanel1.Controls.Add(Me.EspPlanche, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LarPlanche, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LonPlanche, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonOk, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NPlanches, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(221, 213)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'EspPlanche
        '
        Me.EspPlanche.DecimalPlaces = 2
        Me.EspPlanche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EspPlanche.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.EspPlanche.Location = New System.Drawing.Point(133, 134)
        Me.EspPlanche.Margin = New System.Windows.Forms.Padding(8)
        Me.EspPlanche.Name = "EspPlanche"
        Me.EspPlanche.Size = New System.Drawing.Size(80, 20)
        Me.EspPlanche.TabIndex = 18
        '
        'LarPlanche
        '
        Me.LarPlanche.DecimalPlaces = 2
        Me.LarPlanche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LarPlanche.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.LarPlanche.Location = New System.Drawing.Point(133, 92)
        Me.LarPlanche.Margin = New System.Windows.Forms.Padding(8)
        Me.LarPlanche.Name = "LarPlanche"
        Me.LarPlanche.Size = New System.Drawing.Size(80, 20)
        Me.LarPlanche.TabIndex = 17
        '
        'LonPlanche
        '
        Me.LonPlanche.DecimalPlaces = 2
        Me.LonPlanche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LonPlanche.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.LonPlanche.Location = New System.Drawing.Point(133, 50)
        Me.LonPlanche.Margin = New System.Windows.Forms.Padding(8)
        Me.LonPlanche.Name = "LonPlanche"
        Me.LonPlanche.Size = New System.Drawing.Size(80, 20)
        Me.LonPlanche.TabIndex = 16
        '
        'NPlanches
        '
        Me.NPlanches.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NPlanches.Location = New System.Drawing.Point(133, 8)
        Me.NPlanches.Margin = New System.Windows.Forms.Padding(8)
        Me.NPlanches.Name = "NPlanches"
        Me.NPlanches.Size = New System.Drawing.Size(80, 20)
        Me.NPlanches.TabIndex = 15
        '
        'FormPlanchesTMPA
        '
        Me.AcceptButton = Me.ButtonOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 213)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPlanchesTMPA"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caractéristique des planches"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.EspPlanche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LarPlanche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LonPlanche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NPlanches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EspPlanche As System.Windows.Forms.NumericUpDown
    Friend WithEvents LarPlanche As System.Windows.Forms.NumericUpDown
    Friend WithEvents LonPlanche As System.Windows.Forms.NumericUpDown
    Friend WithEvents NPlanches As System.Windows.Forms.NumericUpDown
End Class
