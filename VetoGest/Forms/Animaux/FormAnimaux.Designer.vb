<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnimaux
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvAnimaux = New System.Windows.Forms.DataGridView()
        Me.IdAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexeAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateNaissAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CouleurAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerConsulationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsAnimal = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEsp = New System.Windows.Forms.Button()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxClients = New System.Windows.Forms.ComboBox()
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvAnimaux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.bsAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(620, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(482, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 23)
        Me.TextBox2.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Recherche:"
        '
        'dgvAnimaux
        '
        Me.dgvAnimaux.AllowUserToAddRows = False
        Me.dgvAnimaux.AllowUserToDeleteRows = False
        Me.dgvAnimaux.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAnimaux.AutoGenerateColumns = False
        Me.dgvAnimaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimaux.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAmlDataGridViewTextBoxColumn, Me.NomAmlDataGridViewTextBoxColumn, Me.SexeAmlDataGridViewTextBoxColumn, Me.DateNaissAmlDataGridViewTextBoxColumn, Me.CouleurAmlDataGridViewTextBoxColumn})
        Me.dgvAnimaux.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvAnimaux.DataSource = Me.bsAnimal
        Me.dgvAnimaux.Location = New System.Drawing.Point(12, 114)
        Me.dgvAnimaux.MultiSelect = False
        Me.dgvAnimaux.Name = "dgvAnimaux"
        Me.dgvAnimaux.ReadOnly = True
        Me.dgvAnimaux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAnimaux.Size = New System.Drawing.Size(726, 327)
        Me.dgvAnimaux.TabIndex = 20
        '
        'IdAmlDataGridViewTextBoxColumn
        '
        Me.IdAmlDataGridViewTextBoxColumn.DataPropertyName = "IdAml"
        Me.IdAmlDataGridViewTextBoxColumn.HeaderText = "IdAml"
        Me.IdAmlDataGridViewTextBoxColumn.Name = "IdAmlDataGridViewTextBoxColumn"
        Me.IdAmlDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAmlDataGridViewTextBoxColumn.Visible = False
        '
        'NomAmlDataGridViewTextBoxColumn
        '
        Me.NomAmlDataGridViewTextBoxColumn.DataPropertyName = "NomAml"
        Me.NomAmlDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomAmlDataGridViewTextBoxColumn.Name = "NomAmlDataGridViewTextBoxColumn"
        Me.NomAmlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexeAmlDataGridViewTextBoxColumn
        '
        Me.SexeAmlDataGridViewTextBoxColumn.DataPropertyName = "SexeAml"
        Me.SexeAmlDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.SexeAmlDataGridViewTextBoxColumn.Name = "SexeAmlDataGridViewTextBoxColumn"
        Me.SexeAmlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateNaissAmlDataGridViewTextBoxColumn
        '
        Me.DateNaissAmlDataGridViewTextBoxColumn.DataPropertyName = "DateNaissAml"
        Me.DateNaissAmlDataGridViewTextBoxColumn.HeaderText = "Date de naissance"
        Me.DateNaissAmlDataGridViewTextBoxColumn.Name = "DateNaissAmlDataGridViewTextBoxColumn"
        Me.DateNaissAmlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CouleurAmlDataGridViewTextBoxColumn
        '
        Me.CouleurAmlDataGridViewTextBoxColumn.DataPropertyName = "CouleurAml"
        Me.CouleurAmlDataGridViewTextBoxColumn.HeaderText = "Couleur"
        Me.CouleurAmlDataGridViewTextBoxColumn.Name = "CouleurAmlDataGridViewTextBoxColumn"
        Me.CouleurAmlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem, Me.ImprimerConsulationsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(194, 92)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ImprimerConsulationsToolStripMenuItem
        '
        Me.ImprimerConsulationsToolStripMenuItem.Name = "ImprimerConsulationsToolStripMenuItem"
        Me.ImprimerConsulationsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ImprimerConsulationsToolStripMenuItem.Text = "Imprimer consulations"
        '
        'bsAnimal
        '
        Me.bsAnimal.DataSource = GetType(VetoGest.Data.Models.Animal)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEsp)
        Me.Panel1.Controls.Add(Me.btnNouveau)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 55)
        Me.Panel1.TabIndex = 19
        '
        'btnEsp
        '
        Me.btnEsp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnEsp.BackColor = System.Drawing.Color.Black
        Me.btnEsp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEsp.FlatAppearance.BorderSize = 0
        Me.btnEsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEsp.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsp.ForeColor = System.Drawing.Color.White
        Me.btnEsp.Location = New System.Drawing.Point(538, 12)
        Me.btnEsp.Name = "btnEsp"
        Me.btnEsp.Size = New System.Drawing.Size(97, 33)
        Me.btnEsp.TabIndex = 4
        Me.btnEsp.Text = "  ESPECES"
        Me.btnEsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEsp.UseVisualStyleBackColor = False
        '
        'btnNouveau
        '
        Me.btnNouveau.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnNouveau.BackColor = System.Drawing.Color.Black
        Me.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNouveau.FlatAppearance.BorderSize = 0
        Me.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveau.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNouveau.ForeColor = System.Drawing.Color.White
        Me.btnNouveau.Location = New System.Drawing.Point(641, 12)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(97, 33)
        Me.btnNouveau.TabIndex = 3
        Me.btnNouveau.Text = "  NOUVEAU"
        Me.btnNouveau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNouveau.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Animaux"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.VetoGest.My.Resources.Resources.dog_park_white_35px
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cbxClients
        '
        Me.cbxClients.DataSource = Me.bsClients
        Me.cbxClients.DisplayMember = "FullName"
        Me.cbxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClients.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClients.FormattingEnabled = True
        Me.cbxClients.Location = New System.Drawing.Point(12, 82)
        Me.cbxClients.Name = "cbxClients"
        Me.cbxClients.Size = New System.Drawing.Size(215, 24)
        Me.cbxClients.TabIndex = 24
        Me.cbxClients.ValueMember = "IdClt"
        '
        'bsClients
        '
        Me.bsClients.DataSource = GetType(VetoGest.Data.Models.Client)
        '
        'FormAnimaux
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.cbxClients)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvAnimaux)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAnimaux"
        Me.Text = "FormAnimaux"
        CType(Me.dgvAnimaux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.bsAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvAnimaux As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNouveau As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerConsulationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEsp As Button
    Friend WithEvents bsAnimal As BindingSource
    Friend WithEvents IdAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexeAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateNaissAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CouleurAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspeceIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbxClients As ComboBox
    Friend WithEvents bsClients As BindingSource
End Class
