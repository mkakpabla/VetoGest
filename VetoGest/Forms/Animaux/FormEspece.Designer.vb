<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEspece
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtLib = New System.Windows.Forms.TextBox()
        Me.bsEspece = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvEsp = New System.Windows.Forms.DataGridView()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LibEspDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEspece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 55)
        Me.Panel1.TabIndex = 31
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(61, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(70, 19)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Espèces"
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
        'txtLib
        '
        Me.txtLib.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEspece, "LibEsp", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLib.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLib.Location = New System.Drawing.Point(12, 71)
        Me.txtLib.Name = "txtLib"
        Me.txtLib.Size = New System.Drawing.Size(249, 23)
        Me.txtLib.TabIndex = 32
        '
        'bsEspece
        '
        Me.bsEspece.DataSource = GetType(VetoGest.Data.Models.Espece)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(290, 69)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Enregistrer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(371, 69)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 25)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvEsp
        '
        Me.dgvEsp.AllowUserToAddRows = False
        Me.dgvEsp.AllowUserToDeleteRows = False
        Me.dgvEsp.AutoGenerateColumns = False
        Me.dgvEsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEsp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LibEspDataGridViewTextBoxColumn})
        Me.dgvEsp.DataSource = Me.bsEspece
        Me.dgvEsp.Location = New System.Drawing.Point(12, 100)
        Me.dgvEsp.MultiSelect = False
        Me.dgvEsp.Name = "dgvEsp"
        Me.dgvEsp.ReadOnly = True
        Me.dgvEsp.Size = New System.Drawing.Size(434, 229)
        Me.dgvEsp.TabIndex = 35
        '
        'btnNouveau
        '
        Me.btnNouveau.Location = New System.Drawing.Point(371, 335)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(75, 23)
        Me.btnNouveau.TabIndex = 36
        Me.btnNouveau.Text = "Nouveau"
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.bsEspece
        '
        'LibEspDataGridViewTextBoxColumn
        '
        Me.LibEspDataGridViewTextBoxColumn.DataPropertyName = "LibEsp"
        Me.LibEspDataGridViewTextBoxColumn.HeaderText = "Libellé"
        Me.LibEspDataGridViewTextBoxColumn.Name = "LibEspDataGridViewTextBoxColumn"
        Me.LibEspDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormEspece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 373)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.dgvEsp)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtLib)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEspece"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Espèces"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEspece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLib As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvEsp As DataGridView
    Friend WithEvents btnNouveau As Button
    Friend WithEvents bsEspece As BindingSource
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents LibEspDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
