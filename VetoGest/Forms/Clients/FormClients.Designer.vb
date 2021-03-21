<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClients
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
        Me.dgvClients = New System.Windows.Forms.DataGridView()
        Me.IdClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiviliteClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdrClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelClt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(620, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(482, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 23)
        Me.TextBox2.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Recherche:"
        '
        'dgvClients
        '
        Me.dgvClients.AllowUserToAddRows = False
        Me.dgvClients.AllowUserToDeleteRows = False
        Me.dgvClients.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClients.AutoGenerateColumns = False
        Me.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClients.CausesValidation = False
        Me.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClt, Me.CiviliteClt, Me.NomClt, Me.PrenomClt, Me.AdrClt, Me.TelClt})
        Me.dgvClients.ContextMenuStrip = Me.ContextMenuStrip
        Me.dgvClients.DataSource = Me.bsClients
        Me.dgvClients.Location = New System.Drawing.Point(12, 123)
        Me.dgvClients.MultiSelect = False
        Me.dgvClients.Name = "dgvClients"
        Me.dgvClients.ReadOnly = True
        Me.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClients.ShowCellErrors = False
        Me.dgvClients.ShowRowErrors = False
        Me.dgvClients.Size = New System.Drawing.Size(726, 290)
        Me.dgvClients.TabIndex = 30
        '
        'IdClt
        '
        Me.IdClt.DataPropertyName = "IdClt"
        Me.IdClt.HeaderText = "IdClt"
        Me.IdClt.Name = "IdClt"
        Me.IdClt.ReadOnly = True
        Me.IdClt.Visible = False
        '
        'CiviliteClt
        '
        Me.CiviliteClt.DataPropertyName = "CiviliteClt"
        Me.CiviliteClt.HeaderText = "Civilité"
        Me.CiviliteClt.Name = "CiviliteClt"
        Me.CiviliteClt.ReadOnly = True
        '
        'NomClt
        '
        Me.NomClt.DataPropertyName = "NomClt"
        Me.NomClt.HeaderText = "Nom"
        Me.NomClt.Name = "NomClt"
        Me.NomClt.ReadOnly = True
        '
        'PrenomClt
        '
        Me.PrenomClt.DataPropertyName = "PrenomClt"
        Me.PrenomClt.HeaderText = "Prénom"
        Me.PrenomClt.Name = "PrenomClt"
        Me.PrenomClt.ReadOnly = True
        '
        'AdrClt
        '
        Me.AdrClt.DataPropertyName = "AdrClt"
        Me.AdrClt.HeaderText = "Adresse"
        Me.AdrClt.Name = "AdrClt"
        Me.AdrClt.ReadOnly = True
        '
        'TelClt
        '
        Me.TelClt.DataPropertyName = "TelClt"
        Me.TelClt.HeaderText = "Téléphone"
        Me.TelClt.Name = "TelClt"
        Me.TelClt.ReadOnly = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(130, 48)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'bsClients
        '
        Me.bsClients.AllowNew = True
        Me.bsClients.DataSource = GetType(VetoGest.Data.Models.Client)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnNouveau)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 55)
        Me.Panel1.TabIndex = 29
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
        Me.Label1.Location = New System.Drawing.Point(61, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clients"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.VetoGest.My.Resources.Resources.audit_white_35px
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvClients)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormClients"
        Me.Text = "FormClients"
        CType(Me.dgvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvClients As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNouveau As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bsClients As BindingSource
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdClt As DataGridViewTextBoxColumn
    Friend WithEvents CiviliteClt As DataGridViewTextBoxColumn
    Friend WithEvents NomClt As DataGridViewTextBoxColumn
    Friend WithEvents PrenomClt As DataGridViewTextBoxColumn
    Friend WithEvents AdrClt As DataGridViewTextBoxColumn
    Friend WithEvents TelClt As DataGridViewTextBoxColumn
End Class
