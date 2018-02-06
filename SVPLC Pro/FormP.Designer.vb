<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormP
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormP))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.LabelProjet = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControlBDD = New System.Windows.Forms.TabControl()
        Me.TabPagePlantes = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonSupprimerPlante = New System.Windows.Forms.Button()
        Me.ButtonModifyPlante = New System.Windows.Forms.Button()
        Me.ListViewPlantes = New System.Windows.Forms.ListView()
        Me.ColumnNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnFamille = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnVivace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnSemis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnRecolte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageListBDDPlantes = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonAddPlante = New System.Windows.Forms.Button()
        Me.TabPageAssociations = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewAssociations = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.EnregistrerBDDAssociations = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.EnregistrerComAssociations = New System.Windows.Forms.Button()
        Me.TabPageRotations = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewRotations = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.EnregistrerBDDRotations = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.EnregistrerComRotations = New System.Windows.Forms.Button()
        Me.TabPageEntretien = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonDelEntretien = New System.Windows.Forms.Button()
        Me.ButtonModifyEntretien = New System.Windows.Forms.Button()
        Me.ListViewEntretien = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonADDEntretien = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerLeProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImporterUnProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControlConstruction = New System.Windows.Forms.TabControl()
        Me.TabPageBienvenue = New System.Windows.Forms.TabPage()
        Me.MenuConstruction = New System.Windows.Forms.MenuStrip()
        Me.EchelleTextbox = New System.Windows.Forms.ToolStripTextBox()
        Me.EchelleLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterPhase = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerPhaseActive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListPlantes = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Status.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControlBDD.SuspendLayout()
        Me.TabPagePlantes.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPageAssociations.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridViewAssociations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPageRotations.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.DataGridViewRotations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabPageEntretien.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.TabControlConstruction.SuspendLayout()
        Me.MenuConstruction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabelProjet})
        Me.Status.Location = New System.Drawing.Point(0, 558)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(943, 22)
        Me.Status.TabIndex = 1
        Me.Status.Text = "StatusStrip1"
        '
        'LabelProjet
        '
        Me.LabelProjet.Name = "LabelProjet"
        Me.LabelProjet.Size = New System.Drawing.Size(62, 17)
        Me.LabelProjet.Text = "Bienvenue"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.DarkGray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControlBDD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Menu)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControlConstruction)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuConstruction)
        Me.SplitContainer1.Size = New System.Drawing.Size(943, 558)
        Me.SplitContainer1.SplitterDistance = 313
        Me.SplitContainer1.TabIndex = 2
        '
        'TabControlBDD
        '
        Me.TabControlBDD.AllowDrop = True
        Me.TabControlBDD.Controls.Add(Me.TabPagePlantes)
        Me.TabControlBDD.Controls.Add(Me.TabPageAssociations)
        Me.TabControlBDD.Controls.Add(Me.TabPageRotations)
        Me.TabControlBDD.Controls.Add(Me.TabPageEntretien)
        Me.TabControlBDD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlBDD.ItemSize = New System.Drawing.Size(47, 18)
        Me.TabControlBDD.Location = New System.Drawing.Point(0, 27)
        Me.TabControlBDD.Name = "TabControlBDD"
        Me.TabControlBDD.SelectedIndex = 0
        Me.TabControlBDD.Size = New System.Drawing.Size(313, 531)
        Me.TabControlBDD.TabIndex = 0
        '
        'TabPagePlantes
        '
        Me.TabPagePlantes.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPagePlantes.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlantes.Name = "TabPagePlantes"
        Me.TabPagePlantes.Size = New System.Drawing.Size(305, 505)
        Me.TabPagePlantes.TabIndex = 0
        Me.TabPagePlantes.Text = "Plantes"
        Me.TabPagePlantes.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445!))
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonSupprimerPlante, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonModifyPlante, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.ListViewPlantes, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonAddPlante, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(305, 505)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ButtonSupprimerPlante
        '
        Me.ButtonSupprimerPlante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSupprimerPlante.Location = New System.Drawing.Point(205, 468)
        Me.ButtonSupprimerPlante.Name = "ButtonSupprimerPlante"
        Me.ButtonSupprimerPlante.Size = New System.Drawing.Size(97, 34)
        Me.ButtonSupprimerPlante.TabIndex = 5
        Me.ButtonSupprimerPlante.Text = "Supprimer..."
        Me.ButtonSupprimerPlante.UseVisualStyleBackColor = True
        '
        'ButtonModifyPlante
        '
        Me.ButtonModifyPlante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonModifyPlante.Location = New System.Drawing.Point(104, 468)
        Me.ButtonModifyPlante.Name = "ButtonModifyPlante"
        Me.ButtonModifyPlante.Size = New System.Drawing.Size(95, 34)
        Me.ButtonModifyPlante.TabIndex = 4
        Me.ButtonModifyPlante.Text = "Modifier..."
        Me.ButtonModifyPlante.UseVisualStyleBackColor = True
        '
        'ListViewPlantes
        '
        Me.ListViewPlantes.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewPlantes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnNom, Me.ColumnFamille, Me.ColumnType, Me.ColumnVivace, Me.ColumnSemis, Me.ColumnRecolte})
        Me.TableLayoutPanel3.SetColumnSpan(Me.ListViewPlantes, 3)
        Me.ListViewPlantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewPlantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewPlantes.FullRowSelect = True
        Me.ListViewPlantes.GridLines = True
        Me.ListViewPlantes.HideSelection = False
        Me.ListViewPlantes.Location = New System.Drawing.Point(3, 3)
        Me.ListViewPlantes.MultiSelect = False
        Me.ListViewPlantes.Name = "ListViewPlantes"
        Me.ListViewPlantes.Size = New System.Drawing.Size(299, 459)
        Me.ListViewPlantes.SmallImageList = Me.ImageListBDDPlantes
        Me.ListViewPlantes.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewPlantes.TabIndex = 2
        Me.ListViewPlantes.UseCompatibleStateImageBehavior = False
        Me.ListViewPlantes.View = System.Windows.Forms.View.Details
        '
        'ColumnNom
        '
        Me.ColumnNom.Text = "Nom"
        Me.ColumnNom.Width = 120
        '
        'ColumnFamille
        '
        Me.ColumnFamille.Text = "Famille"
        Me.ColumnFamille.Width = 120
        '
        'ColumnType
        '
        Me.ColumnType.Text = "Type"
        Me.ColumnType.Width = 120
        '
        'ColumnVivace
        '
        Me.ColumnVivace.Text = "Plante Vivace"
        Me.ColumnVivace.Width = 120
        '
        'ColumnSemis
        '
        Me.ColumnSemis.Text = "Mise en Terre"
        Me.ColumnSemis.Width = 120
        '
        'ColumnRecolte
        '
        Me.ColumnRecolte.Text = "Récolte"
        Me.ColumnRecolte.Width = 120
        '
        'ImageListBDDPlantes
        '
        Me.ImageListBDDPlantes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageListBDDPlantes.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBDDPlantes.TransparentColor = System.Drawing.Color.Transparent
        '
        'ButtonAddPlante
        '
        Me.ButtonAddPlante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonAddPlante.Location = New System.Drawing.Point(3, 468)
        Me.ButtonAddPlante.Name = "ButtonAddPlante"
        Me.ButtonAddPlante.Size = New System.Drawing.Size(95, 34)
        Me.ButtonAddPlante.TabIndex = 3
        Me.ButtonAddPlante.Text = "Ajouter..."
        Me.ButtonAddPlante.UseVisualStyleBackColor = True
        '
        'TabPageAssociations
        '
        Me.TabPageAssociations.Controls.Add(Me.SplitContainer2)
        Me.TabPageAssociations.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssociations.Name = "TabPageAssociations"
        Me.TabPageAssociations.Size = New System.Drawing.Size(305, 505)
        Me.TabPageAssociations.TabIndex = 1
        Me.TabPageAssociations.Text = "Associations"
        Me.TabPageAssociations.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DataGridViewAssociations)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(305, 505)
        Me.SplitContainer2.SplitterDistance = 444
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        '
        'DataGridViewAssociations
        '
        Me.DataGridViewAssociations.AllowUserToAddRows = False
        Me.DataGridViewAssociations.AllowUserToDeleteRows = False
        Me.DataGridViewAssociations.AllowUserToResizeRows = False
        Me.DataGridViewAssociations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAssociations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAssociations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewAssociations.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewAssociations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAssociations.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewAssociations.MultiSelect = False
        Me.DataGridViewAssociations.Name = "DataGridViewAssociations"
        Me.DataGridViewAssociations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewAssociations.RowHeadersWidth = 120
        Me.DataGridViewAssociations.RowTemplate.Height = 18
        Me.DataGridViewAssociations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridViewAssociations.Size = New System.Drawing.Size(305, 444)
        Me.DataGridViewAssociations.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.EnregistrerBDDAssociations, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RichTextBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EnregistrerComAssociations, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 58)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'EnregistrerBDDAssociations
        '
        Me.EnregistrerBDDAssociations.BackgroundImage = CType(resources.GetObject("EnregistrerBDDAssociations.BackgroundImage"), System.Drawing.Image)
        Me.EnregistrerBDDAssociations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnregistrerBDDAssociations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnregistrerBDDAssociations.Location = New System.Drawing.Point(260, 2)
        Me.EnregistrerBDDAssociations.Margin = New System.Windows.Forms.Padding(2)
        Me.EnregistrerBDDAssociations.Name = "EnregistrerBDDAssociations"
        Me.EnregistrerBDDAssociations.Size = New System.Drawing.Size(43, 54)
        Me.EnregistrerBDDAssociations.TabIndex = 2
        Me.EnregistrerBDDAssociations.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 2)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(207, 54)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'EnregistrerComAssociations
        '
        Me.EnregistrerComAssociations.BackgroundImage = Global.SVPLC_Grid.My.Resources.Resources.Edit1
        Me.EnregistrerComAssociations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnregistrerComAssociations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnregistrerComAssociations.Location = New System.Drawing.Point(213, 2)
        Me.EnregistrerComAssociations.Margin = New System.Windows.Forms.Padding(2)
        Me.EnregistrerComAssociations.Name = "EnregistrerComAssociations"
        Me.EnregistrerComAssociations.Size = New System.Drawing.Size(43, 54)
        Me.EnregistrerComAssociations.TabIndex = 1
        Me.EnregistrerComAssociations.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EnregistrerComAssociations.UseVisualStyleBackColor = True
        '
        'TabPageRotations
        '
        Me.TabPageRotations.Controls.Add(Me.SplitContainer3)
        Me.TabPageRotations.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRotations.Name = "TabPageRotations"
        Me.TabPageRotations.Size = New System.Drawing.Size(305, 505)
        Me.TabPageRotations.TabIndex = 2
        Me.TabPageRotations.Text = "Rotations"
        Me.TabPageRotations.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.DataGridViewRotations)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer3.Size = New System.Drawing.Size(305, 505)
        Me.SplitContainer3.SplitterDistance = 444
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 0
        '
        'DataGridViewRotations
        '
        Me.DataGridViewRotations.AllowUserToAddRows = False
        Me.DataGridViewRotations.AllowUserToDeleteRows = False
        Me.DataGridViewRotations.AllowUserToResizeRows = False
        Me.DataGridViewRotations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRotations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRotations.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRotations.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewRotations.MultiSelect = False
        Me.DataGridViewRotations.Name = "DataGridViewRotations"
        Me.DataGridViewRotations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewRotations.RowHeadersWidth = 120
        Me.DataGridViewRotations.RowTemplate.Height = 18
        Me.DataGridViewRotations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridViewRotations.Size = New System.Drawing.Size(305, 444)
        Me.DataGridViewRotations.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.EnregistrerBDDRotations, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.EnregistrerComRotations, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(305, 58)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'EnregistrerBDDRotations
        '
        Me.EnregistrerBDDRotations.BackgroundImage = CType(resources.GetObject("EnregistrerBDDRotations.BackgroundImage"), System.Drawing.Image)
        Me.EnregistrerBDDRotations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnregistrerBDDRotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnregistrerBDDRotations.Location = New System.Drawing.Point(260, 2)
        Me.EnregistrerBDDRotations.Margin = New System.Windows.Forms.Padding(2)
        Me.EnregistrerBDDRotations.Name = "EnregistrerBDDRotations"
        Me.EnregistrerBDDRotations.Size = New System.Drawing.Size(43, 54)
        Me.EnregistrerBDDRotations.TabIndex = 2
        Me.EnregistrerBDDRotations.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Location = New System.Drawing.Point(2, 2)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(207, 54)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = ""
        '
        'EnregistrerComRotations
        '
        Me.EnregistrerComRotations.BackgroundImage = Global.SVPLC_Grid.My.Resources.Resources.Edit1
        Me.EnregistrerComRotations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EnregistrerComRotations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnregistrerComRotations.Location = New System.Drawing.Point(213, 2)
        Me.EnregistrerComRotations.Margin = New System.Windows.Forms.Padding(2)
        Me.EnregistrerComRotations.Name = "EnregistrerComRotations"
        Me.EnregistrerComRotations.Size = New System.Drawing.Size(43, 54)
        Me.EnregistrerComRotations.TabIndex = 1
        Me.EnregistrerComRotations.UseVisualStyleBackColor = True
        '
        'TabPageEntretien
        '
        Me.TabPageEntretien.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPageEntretien.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEntretien.Name = "TabPageEntretien"
        Me.TabPageEntretien.Size = New System.Drawing.Size(305, 505)
        Me.TabPageEntretien.TabIndex = 3
        Me.TabPageEntretien.Text = "Entretien"
        Me.TabPageEntretien.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33445!))
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonDelEntretien, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonModifyEntretien, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ListViewEntretien, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ButtonADDEntretien, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(305, 505)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'ButtonDelEntretien
        '
        Me.ButtonDelEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDelEntretien.Location = New System.Drawing.Point(205, 468)
        Me.ButtonDelEntretien.Name = "ButtonDelEntretien"
        Me.ButtonDelEntretien.Size = New System.Drawing.Size(97, 34)
        Me.ButtonDelEntretien.TabIndex = 5
        Me.ButtonDelEntretien.Text = "Supprimer..."
        Me.ButtonDelEntretien.UseVisualStyleBackColor = True
        '
        'ButtonModifyEntretien
        '
        Me.ButtonModifyEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonModifyEntretien.Location = New System.Drawing.Point(104, 468)
        Me.ButtonModifyEntretien.Name = "ButtonModifyEntretien"
        Me.ButtonModifyEntretien.Size = New System.Drawing.Size(95, 34)
        Me.ButtonModifyEntretien.TabIndex = 4
        Me.ButtonModifyEntretien.Text = "Modifier..."
        Me.ButtonModifyEntretien.UseVisualStyleBackColor = True
        '
        'ListViewEntretien
        '
        Me.ListViewEntretien.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewEntretien.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.TableLayoutPanel4.SetColumnSpan(Me.ListViewEntretien, 3)
        Me.ListViewEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewEntretien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewEntretien.FullRowSelect = True
        Me.ListViewEntretien.GridLines = True
        Me.ListViewEntretien.HideSelection = False
        Me.ListViewEntretien.Location = New System.Drawing.Point(3, 3)
        Me.ListViewEntretien.MultiSelect = False
        Me.ListViewEntretien.Name = "ListViewEntretien"
        Me.ListViewEntretien.Size = New System.Drawing.Size(299, 459)
        Me.ListViewEntretien.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListViewEntretien.TabIndex = 2
        Me.ListViewEntretien.UseCompatibleStateImageBehavior = False
        Me.ListViewEntretien.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 166
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 120
        '
        'ButtonADDEntretien
        '
        Me.ButtonADDEntretien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonADDEntretien.Location = New System.Drawing.Point(3, 468)
        Me.ButtonADDEntretien.Name = "ButtonADDEntretien"
        Me.ButtonADDEntretien.Size = New System.Drawing.Size(95, 34)
        Me.ButtonADDEntretien.TabIndex = 3
        Me.ButtonADDEntretien.Text = "Ajouter..."
        Me.ButtonADDEntretien.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.Menu.AutoSize = False
        Me.Menu.BackColor = System.Drawing.Color.DarkGray
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ParamètresToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(313, 27)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauProjetToolStripMenuItem, Me.EnregistrerLeProjetToolStripMenuItem, Me.ImporterUnProjetToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 23)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'NouveauProjetToolStripMenuItem
        '
        Me.NouveauProjetToolStripMenuItem.Name = "NouveauProjetToolStripMenuItem"
        Me.NouveauProjetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauProjetToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.NouveauProjetToolStripMenuItem.Text = "Nouveau projet..."
        '
        'EnregistrerLeProjetToolStripMenuItem
        '
        Me.EnregistrerLeProjetToolStripMenuItem.Name = "EnregistrerLeProjetToolStripMenuItem"
        Me.EnregistrerLeProjetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.EnregistrerLeProjetToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.EnregistrerLeProjetToolStripMenuItem.Text = "Enregistrer le projet..."
        '
        'ImporterUnProjetToolStripMenuItem
        '
        Me.ImporterUnProjetToolStripMenuItem.Name = "ImporterUnProjetToolStripMenuItem"
        Me.ImporterUnProjetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImporterUnProjetToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ImporterUnProjetToolStripMenuItem.Text = "Importer un projet..."
        '
        'ParamètresToolStripMenuItem
        '
        Me.ParamètresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ParamètresToolStripMenuItem.Name = "ParamètresToolStripMenuItem"
        Me.ParamètresToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.ParamètresToolStripMenuItem.Text = "Paramètres"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionsToolStripMenuItem.Text = "Options..."
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(24, 23)
        Me.AProposToolStripMenuItem.Text = "?"
        '
        'TabControlConstruction
        '
        Me.TabControlConstruction.Controls.Add(Me.TabPageBienvenue)
        Me.TabControlConstruction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlConstruction.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControlConstruction.ItemSize = New System.Drawing.Size(63, 20)
        Me.TabControlConstruction.Location = New System.Drawing.Point(0, 24)
        Me.TabControlConstruction.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControlConstruction.Name = "TabControlConstruction"
        Me.TabControlConstruction.Padding = New System.Drawing.Point(0, 0)
        Me.TabControlConstruction.SelectedIndex = 0
        Me.TabControlConstruction.Size = New System.Drawing.Size(626, 534)
        Me.TabControlConstruction.TabIndex = 0
        '
        'TabPageBienvenue
        '
        Me.TabPageBienvenue.BackColor = System.Drawing.Color.Black
        Me.TabPageBienvenue.BackgroundImage = Global.SVPLC_Grid.My.Resources.Resources.Icone_svplcpro_transp3
        Me.TabPageBienvenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPageBienvenue.Location = New System.Drawing.Point(4, 24)
        Me.TabPageBienvenue.Name = "TabPageBienvenue"
        Me.TabPageBienvenue.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBienvenue.Size = New System.Drawing.Size(618, 506)
        Me.TabPageBienvenue.TabIndex = 0
        Me.TabPageBienvenue.Tag = "Bienvenue"
        Me.TabPageBienvenue.Text = "Bienvenue"
        '
        'MenuConstruction
        '
        Me.MenuConstruction.BackColor = System.Drawing.Color.DarkGray
        Me.MenuConstruction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EchelleTextbox, Me.EchelleLabel, Me.ProjectMenuItem})
        Me.MenuConstruction.Location = New System.Drawing.Point(0, 0)
        Me.MenuConstruction.Name = "MenuConstruction"
        Me.MenuConstruction.Size = New System.Drawing.Size(626, 24)
        Me.MenuConstruction.TabIndex = 1
        Me.MenuConstruction.Text = "MenuStrip1"
        '
        'EchelleTextbox
        '
        Me.EchelleTextbox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.EchelleTextbox.Name = "EchelleTextbox"
        Me.EchelleTextbox.Size = New System.Drawing.Size(100, 23)
        Me.EchelleTextbox.Text = "1"
        Me.EchelleTextbox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EchelleTextbox.Visible = False
        '
        'EchelleLabel
        '
        Me.EchelleLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.EchelleLabel.Name = "EchelleLabel"
        Me.EchelleLabel.Size = New System.Drawing.Size(132, 20)
        Me.EchelleLabel.Text = "Echelle du projet (m):"
        Me.EchelleLabel.Visible = False
        '
        'ProjectMenuItem
        '
        Me.ProjectMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterPhase, Me.SupprimerPhaseActive})
        Me.ProjectMenuItem.Name = "ProjectMenuItem"
        Me.ProjectMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ProjectMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ProjectMenuItem.Text = "Projet"
        Me.ProjectMenuItem.Visible = False
        '
        'AjouterPhase
        '
        Me.AjouterPhase.Name = "AjouterPhase"
        Me.AjouterPhase.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AjouterPhase.Size = New System.Drawing.Size(249, 22)
        Me.AjouterPhase.Text = "Ajouter une phase"
        '
        'SupprimerPhaseActive
        '
        Me.SupprimerPhaseActive.Name = "SupprimerPhaseActive"
        Me.SupprimerPhaseActive.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SupprimerPhaseActive.Size = New System.Drawing.Size(249, 22)
        Me.SupprimerPhaseActive.Text = "Supprimer la phase active"
        '
        'ImageListPlantes
        '
        Me.ImageListPlantes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageListPlantes.ImageSize = New System.Drawing.Size(70, 70)
        Me.ImageListPlantes.TransparentColor = System.Drawing.Color.Transparent
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Fichier SVPLCPRO (*.svplcpro)|*.svplcpro"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Fichiers SVPLCPro|*.svplcpro"
        '
        'FormP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 580)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Status)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SVPLC Pro"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControlBDD.ResumeLayout(False)
        Me.TabPagePlantes.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TabPageAssociations.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridViewAssociations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabPageRotations.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.DataGridViewRotations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabPageEntretien.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.TabControlConstruction.ResumeLayout(False)
        Me.MenuConstruction.ResumeLayout(False)
        Me.MenuConstruction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControlConstruction As System.Windows.Forms.TabControl
    Friend WithEvents TabPageBienvenue As System.Windows.Forms.TabPage
    Friend WithEvents TabControlBDD As System.Windows.Forms.TabControl
    Friend WithEvents TabPageRotations As System.Windows.Forms.TabPage
    Friend WithEvents LabelProjet As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImageListBDDPlantes As System.Windows.Forms.ImageList
    Friend WithEvents ImageListPlantes As System.Windows.Forms.ImageList
    Friend WithEvents TabPagePlantes As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAssociations As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewAssociations As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EnregistrerBDDAssociations As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents EnregistrerComAssociations As System.Windows.Forms.Button
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewRotations As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EnregistrerBDDRotations As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents EnregistrerComRotations As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonSupprimerPlante As System.Windows.Forms.Button
    Friend WithEvents ButtonModifyPlante As System.Windows.Forms.Button
    Friend WithEvents ListViewPlantes As System.Windows.Forms.ListView
    Friend WithEvents ColumnNom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnFamille As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnVivace As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnSemis As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnRecolte As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonAddPlante As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauProjetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerLeProjetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImporterUnProjetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamètresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuConstruction As System.Windows.Forms.MenuStrip
    Friend WithEvents EchelleTextbox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EchelleLabel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterPhase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupprimerPhaseActive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPageEntretien As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonDelEntretien As System.Windows.Forms.Button
    Friend WithEvents ButtonModifyEntretien As System.Windows.Forms.Button
    Friend WithEvents ListViewEntretien As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ButtonADDEntretien As System.Windows.Forms.Button

End Class
