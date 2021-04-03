<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultations
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCompAgtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RaisonConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAgtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsCons = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxAnimals = New System.Windows.Forms.ComboBox()
        Me.bsAnimals = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxClients = New System.Windows.Forms.ComboBox()
        Me.bsClients = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.bsCons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnimals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 24
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
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultations"
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(621, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 28)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdConsDataGridViewTextBoxColumn, Me.NomCompAgtDataGridViewTextBoxColumn, Me.DateConsDataGridViewTextBoxColumn, Me.ObsConsDataGridViewTextBoxColumn, Me.RaisonConsDataGridViewTextBoxColumn, Me.PrixConsDataGridViewTextBoxColumn, Me.IdMedDataGridViewTextBoxColumn, Me.IdAgtDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip
        Me.DataGridView1.DataSource = Me.bsCons
        Me.DataGridView1.Location = New System.Drawing.Point(269, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(469, 309)
        Me.DataGridView1.TabIndex = 29
        '
        'IdConsDataGridViewTextBoxColumn
        '
        Me.IdConsDataGridViewTextBoxColumn.DataPropertyName = "IdCons"
        Me.IdConsDataGridViewTextBoxColumn.HeaderText = "IdCons"
        Me.IdConsDataGridViewTextBoxColumn.Name = "IdConsDataGridViewTextBoxColumn"
        Me.IdConsDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdConsDataGridViewTextBoxColumn.Visible = False
        '
        'NomCompAgtDataGridViewTextBoxColumn
        '
        Me.NomCompAgtDataGridViewTextBoxColumn.DataPropertyName = "NomCompAgt"
        Me.NomCompAgtDataGridViewTextBoxColumn.HeaderText = "Médécin consultant"
        Me.NomCompAgtDataGridViewTextBoxColumn.Name = "NomCompAgtDataGridViewTextBoxColumn"
        Me.NomCompAgtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateConsDataGridViewTextBoxColumn
        '
        Me.DateConsDataGridViewTextBoxColumn.DataPropertyName = "DateCons"
        Me.DateConsDataGridViewTextBoxColumn.HeaderText = "Date consultation"
        Me.DateConsDataGridViewTextBoxColumn.Name = "DateConsDataGridViewTextBoxColumn"
        Me.DateConsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObsConsDataGridViewTextBoxColumn
        '
        Me.ObsConsDataGridViewTextBoxColumn.DataPropertyName = "ObsCons"
        Me.ObsConsDataGridViewTextBoxColumn.HeaderText = "ObsCons"
        Me.ObsConsDataGridViewTextBoxColumn.Name = "ObsConsDataGridViewTextBoxColumn"
        Me.ObsConsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObsConsDataGridViewTextBoxColumn.Visible = False
        '
        'RaisonConsDataGridViewTextBoxColumn
        '
        Me.RaisonConsDataGridViewTextBoxColumn.DataPropertyName = "RaisonCons"
        Me.RaisonConsDataGridViewTextBoxColumn.HeaderText = "RaisonCons"
        Me.RaisonConsDataGridViewTextBoxColumn.Name = "RaisonConsDataGridViewTextBoxColumn"
        Me.RaisonConsDataGridViewTextBoxColumn.ReadOnly = True
        Me.RaisonConsDataGridViewTextBoxColumn.Visible = False
        '
        'PrixConsDataGridViewTextBoxColumn
        '
        Me.PrixConsDataGridViewTextBoxColumn.DataPropertyName = "PrixCons"
        Me.PrixConsDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixConsDataGridViewTextBoxColumn.Name = "PrixConsDataGridViewTextBoxColumn"
        Me.PrixConsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdMedDataGridViewTextBoxColumn
        '
        Me.IdMedDataGridViewTextBoxColumn.DataPropertyName = "IdMed"
        Me.IdMedDataGridViewTextBoxColumn.HeaderText = "IdMed"
        Me.IdMedDataGridViewTextBoxColumn.Name = "IdMedDataGridViewTextBoxColumn"
        Me.IdMedDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMedDataGridViewTextBoxColumn.Visible = False
        '
        'IdAgtDataGridViewTextBoxColumn
        '
        Me.IdAgtDataGridViewTextBoxColumn.DataPropertyName = "IdAgt"
        Me.IdAgtDataGridViewTextBoxColumn.HeaderText = "IdAgt"
        Me.IdAgtDataGridViewTextBoxColumn.Name = "IdAgtDataGridViewTextBoxColumn"
        Me.IdAgtDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAgtDataGridViewTextBoxColumn.Visible = False
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SupprimerToolStripMenuItem, Me.ImprimerToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(130, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripMenuItem1.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer"
        '
        'bsCons
        '
        Me.bsCons.DataSource = GetType(VetoGest.Data.ViewModels.ConsultationViewModel)
        '
        'cbxAnimals
        '
        Me.cbxAnimals.DataSource = Me.bsAnimals
        Me.cbxAnimals.DisplayMember = "NomAml"
        Me.cbxAnimals.FormattingEnabled = True
        Me.cbxAnimals.Location = New System.Drawing.Point(15, 140)
        Me.cbxAnimals.Name = "cbxAnimals"
        Me.cbxAnimals.Size = New System.Drawing.Size(225, 21)
        Me.cbxAnimals.TabIndex = 28
        Me.cbxAnimals.ValueMember = "IdAml"
        '
        'bsAnimals
        '
        Me.bsAnimals.DataSource = GetType(VetoGest.Data.Models.Animal)
        '
        'cbxClients
        '
        Me.cbxClients.DataSource = Me.bsClients
        Me.cbxClients.DisplayMember = "FullName"
        Me.cbxClients.FormattingEnabled = True
        Me.cbxClients.Location = New System.Drawing.Point(15, 91)
        Me.cbxClients.Name = "cbxClients"
        Me.cbxClients.Size = New System.Drawing.Size(225, 21)
        Me.cbxClients.TabIndex = 27
        Me.cbxClients.ValueMember = "IdClt"
        '
        'bsClients
        '
        Me.bsClients.DataSource = GetType(VetoGest.Data.Models.Client)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Clients"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Animal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Adresse du client"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Téléphone du client"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Age de l'animal"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "AdrClt", True))
        Me.TextBox1.Location = New System.Drawing.Point(15, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 20)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClients, "TelClt", True))
        Me.TextBox2.Location = New System.Drawing.Point(15, 243)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 20)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnimals, "Age", True))
        Me.TextBox3.Location = New System.Drawing.Point(15, 289)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 20)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnimals, "SexeAml", True))
        Me.TextBox4.Location = New System.Drawing.Point(15, 330)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 20)
        Me.TextBox4.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Sexe de l'animal"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnimals, "CouleurAml", True))
        Me.TextBox5.Location = New System.Drawing.Point(15, 373)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(225, 20)
        Me.TextBox5.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Couleur de l'animal"
        '
        'FormConsultations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 445)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbxAnimals)
        Me.Controls.Add(Me.cbxClients)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConsultations"
        Me.Text = "FormConsultations"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.bsCons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnimals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbxAnimals As ComboBox
    Friend WithEvents cbxClients As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNouveau As Button
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bsClients As BindingSource
    Friend WithEvents bsAnimals As BindingSource
    Friend WithEvents IdConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomCompAgtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RaisonConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdMedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAgtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsCons As BindingSource
End Class
