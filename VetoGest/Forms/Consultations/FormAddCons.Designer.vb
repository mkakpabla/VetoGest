<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCons
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMed = New System.Windows.Forms.ComboBox()
        Me.bsAgents = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textRaisonCons = New System.Windows.Forms.TextBox()
        Me.bsCons = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtObsCons = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnr = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrixCons = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAgents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCons, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(309, 55)
        Me.Panel1.TabIndex = 31
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(61, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(188, 19)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Nouvelle Consulatation"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Médecin"
        '
        'cbxMed
        '
        Me.cbxMed.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsCons, "IdMed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbxMed.DataSource = Me.bsAgents
        Me.cbxMed.DisplayMember = "NomCompAgt"
        Me.cbxMed.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMed.FormattingEnabled = True
        Me.cbxMed.Location = New System.Drawing.Point(15, 100)
        Me.cbxMed.Name = "cbxMed"
        Me.cbxMed.Size = New System.Drawing.Size(281, 25)
        Me.cbxMed.TabIndex = 33
        Me.cbxMed.ValueMember = "IdAgt"
        '
        'bsAgents
        '
        Me.bsAgents.DataSource = GetType(VetoGest.Data.Models.Agent)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Raison"
        '
        'textRaisonCons
        '
        Me.textRaisonCons.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCons, "RaisonCons", True))
        Me.textRaisonCons.Location = New System.Drawing.Point(15, 151)
        Me.textRaisonCons.Multiline = True
        Me.textRaisonCons.Name = "textRaisonCons"
        Me.textRaisonCons.Size = New System.Drawing.Size(281, 52)
        Me.textRaisonCons.TabIndex = 35
        '
        'bsCons
        '
        Me.bsCons.DataSource = GetType(VetoGest.Data.Models.Consultation)
        '
        'txtObsCons
        '
        Me.txtObsCons.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCons, "ObsCons", True))
        Me.txtObsCons.Location = New System.Drawing.Point(15, 224)
        Me.txtObsCons.Multiline = True
        Me.txtObsCons.Name = "txtObsCons"
        Me.txtObsCons.Size = New System.Drawing.Size(281, 101)
        Me.txtObsCons.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Observation"
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(15, 383)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.Size = New System.Drawing.Size(281, 34)
        Me.btnEnr.TabIndex = 38
        Me.btnEnr.Text = "Enrégistrer et Imprimer"
        Me.btnEnr.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Prix"
        '
        'txtPrixCons
        '
        Me.txtPrixCons.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCons, "PrixCons", True))
        Me.txtPrixCons.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrixCons.Location = New System.Drawing.Point(15, 344)
        Me.txtPrixCons.Name = "txtPrixCons"
        Me.txtPrixCons.Size = New System.Drawing.Size(281, 23)
        Me.txtPrixCons.TabIndex = 40
        '
        'FormAddCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 438)
        Me.Controls.Add(Me.txtPrixCons)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEnr)
        Me.Controls.Add(Me.txtObsCons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textRaisonCons)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxMed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouvelle consultation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAgents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxMed As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textRaisonCons As TextBox
    Friend WithEvents txtObsCons As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnr As Button
    Friend WithEvents bsAgents As BindingSource
    Friend WithEvents bsCons As BindingSource
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrixCons As TextBox
End Class
