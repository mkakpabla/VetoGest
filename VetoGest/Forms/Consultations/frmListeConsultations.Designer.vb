<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeConsultations
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
        Me.dgvListeConsultation = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NomAmlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCompAgtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObsConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RaisonConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrixConsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsConsultations = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvListeConsultation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConsultations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListeConsultation
        '
        Me.dgvListeConsultation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListeConsultation.AutoGenerateColumns = False
        Me.dgvListeConsultation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListeConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListeConsultation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomAmlDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.NomCompAgtDataGridViewTextBoxColumn, Me.DateConsDataGridViewTextBoxColumn, Me.ObsConsDataGridViewTextBoxColumn, Me.RaisonConsDataGridViewTextBoxColumn, Me.PrixConsDataGridViewTextBoxColumn})
        Me.dgvListeConsultation.DataSource = Me.bsConsultations
        Me.dgvListeConsultation.Location = New System.Drawing.Point(12, 114)
        Me.dgvListeConsultation.MultiSelect = False
        Me.dgvListeConsultation.Name = "dgvListeConsultation"
        Me.dgvListeConsultation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListeConsultation.Size = New System.Drawing.Size(861, 375)
        Me.dgvListeConsultation.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(81, 84)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(263, 24)
        Me.txtSearch.TabIndex = 1
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
        Me.Panel1.Size = New System.Drawing.Size(885, 55)
        Me.Panel1.TabIndex = 25
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
        Me.btnNouveau.Location = New System.Drawing.Point(684, 12)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(189, 33)
        Me.btnNouveau.TabIndex = 3
        Me.btnNouveau.Text = "  NOUVELLE CONSULTATION"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Recherche:"
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
        'NomAmlDataGridViewTextBoxColumn
        '
        Me.NomAmlDataGridViewTextBoxColumn.DataPropertyName = "NomAml"
        Me.NomAmlDataGridViewTextBoxColumn.HeaderText = "Animal"
        Me.NomAmlDataGridViewTextBoxColumn.Name = "NomAmlDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Propiétaire"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomCompAgtDataGridViewTextBoxColumn
        '
        Me.NomCompAgtDataGridViewTextBoxColumn.DataPropertyName = "NomCompAgt"
        Me.NomCompAgtDataGridViewTextBoxColumn.HeaderText = "Médécin"
        Me.NomCompAgtDataGridViewTextBoxColumn.Name = "NomCompAgtDataGridViewTextBoxColumn"
        '
        'DateConsDataGridViewTextBoxColumn
        '
        Me.DateConsDataGridViewTextBoxColumn.DataPropertyName = "DateCons"
        Me.DateConsDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateConsDataGridViewTextBoxColumn.Name = "DateConsDataGridViewTextBoxColumn"
        '
        'ObsConsDataGridViewTextBoxColumn
        '
        Me.ObsConsDataGridViewTextBoxColumn.DataPropertyName = "ObsCons"
        Me.ObsConsDataGridViewTextBoxColumn.HeaderText = "Obsservation"
        Me.ObsConsDataGridViewTextBoxColumn.Name = "ObsConsDataGridViewTextBoxColumn"
        '
        'RaisonConsDataGridViewTextBoxColumn
        '
        Me.RaisonConsDataGridViewTextBoxColumn.DataPropertyName = "RaisonCons"
        Me.RaisonConsDataGridViewTextBoxColumn.HeaderText = "Raison"
        Me.RaisonConsDataGridViewTextBoxColumn.Name = "RaisonConsDataGridViewTextBoxColumn"
        '
        'PrixConsDataGridViewTextBoxColumn
        '
        Me.PrixConsDataGridViewTextBoxColumn.DataPropertyName = "PrixCons"
        Me.PrixConsDataGridViewTextBoxColumn.HeaderText = "Prix"
        Me.PrixConsDataGridViewTextBoxColumn.Name = "PrixConsDataGridViewTextBoxColumn"
        '
        'bsConsultations
        '
        Me.bsConsultations.DataSource = GetType(VetoGest.Data.ViewModels.ConsultationViewModel)
        '
        'frmListeConsultations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 501)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvListeConsultation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListeConsultations"
        Me.Text = "frmListeConsultations"
        CType(Me.dgvListeConsultation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConsultations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListeConsultation As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNouveau As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bsConsultations As BindingSource
    Friend WithEvents NomAmlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomCompAgtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObsConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RaisonConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrixConsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
