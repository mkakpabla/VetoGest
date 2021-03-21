<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddAgent
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AdrAgtLabel As System.Windows.Forms.Label
        Dim FoncAgtLabel As System.Windows.Forms.Label
        Dim NomCompAgtLabel As System.Windows.Forms.Label
        Dim TelAgtLabel As System.Windows.Forms.Label
        Dim LoginAgtLabel As System.Windows.Forms.Label
        Dim MdpAgtLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAdr = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.btnEnr = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.bsAgents = New System.Windows.Forms.BindingSource(Me.components)
        AdrAgtLabel = New System.Windows.Forms.Label()
        FoncAgtLabel = New System.Windows.Forms.Label()
        NomCompAgtLabel = New System.Windows.Forms.Label()
        TelAgtLabel = New System.Windows.Forms.Label()
        LoginAgtLabel = New System.Windows.Forms.Label()
        MdpAgtLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bsAgents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdrAgtLabel
        '
        AdrAgtLabel.AutoSize = True
        AdrAgtLabel.Location = New System.Drawing.Point(48, 179)
        AdrAgtLabel.Name = "AdrAgtLabel"
        AdrAgtLabel.Size = New System.Drawing.Size(48, 13)
        AdrAgtLabel.TabIndex = 6
        AdrAgtLabel.Text = "Adresse:"
        '
        'FoncAgtLabel
        '
        FoncAgtLabel.AutoSize = True
        FoncAgtLabel.Location = New System.Drawing.Point(48, 81)
        FoncAgtLabel.Name = "FoncAgtLabel"
        FoncAgtLabel.Size = New System.Drawing.Size(48, 13)
        FoncAgtLabel.TabIndex = 0
        FoncAgtLabel.Text = "Fonction"
        '
        'NomCompAgtLabel
        '
        NomCompAgtLabel.AutoSize = True
        NomCompAgtLabel.Location = New System.Drawing.Point(47, 133)
        NomCompAgtLabel.Name = "NomCompAgtLabel"
        NomCompAgtLabel.Size = New System.Drawing.Size(73, 13)
        NomCompAgtLabel.TabIndex = 2
        NomCompAgtLabel.Text = "Nom Complet:"
        '
        'TelAgtLabel
        '
        TelAgtLabel.AutoSize = True
        TelAgtLabel.Location = New System.Drawing.Point(326, 133)
        TelAgtLabel.Name = "TelAgtLabel"
        TelAgtLabel.Size = New System.Drawing.Size(61, 13)
        TelAgtLabel.TabIndex = 4
        TelAgtLabel.Text = "Téléphone:"
        '
        'LoginAgtLabel
        '
        LoginAgtLabel.AutoSize = True
        LoginAgtLabel.Location = New System.Drawing.Point(16, 16)
        LoginAgtLabel.Name = "LoginAgtLabel"
        LoginAgtLabel.Size = New System.Drawing.Size(53, 13)
        LoginAgtLabel.TabIndex = 0
        LoginAgtLabel.Text = "Identifiant"
        '
        'MdpAgtLabel
        '
        MdpAgtLabel.AutoSize = True
        MdpAgtLabel.Location = New System.Drawing.Point(280, 16)
        MdpAgtLabel.Name = "MdpAgtLabel"
        MdpAgtLabel.Size = New System.Drawing.Size(74, 13)
        MdpAgtLabel.TabIndex = 2
        MdpAgtLabel.Text = "Mot de passe:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 55)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nouveau"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.VetoGest.My.Resources.Resources.lab_coat_white_35px
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtAdr
        '
        Me.txtAdr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "AdrAgt", True))
        Me.txtAdr.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdr.Location = New System.Drawing.Point(51, 195)
        Me.txtAdr.Multiline = True
        Me.txtAdr.Name = "txtAdr"
        Me.txtAdr.Size = New System.Drawing.Size(540, 37)
        Me.txtAdr.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "NomCompAgt", True))
        Me.txtNom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(50, 149)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(252, 23)
        Me.txtNom.TabIndex = 3
        '
        'txtTel
        '
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "TelAgt", True))
        Me.txtTel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(329, 149)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(262, 23)
        Me.txtTel.TabIndex = 5
        '
        'btnEnr
        '
        Me.btnEnr.Location = New System.Drawing.Point(452, 319)
        Me.btnEnr.Name = "btnEnr"
        Me.btnEnr.Size = New System.Drawing.Size(139, 32)
        Me.btnEnr.TabIndex = 9
        Me.btnEnr.Text = "Enregistrer"
        Me.btnEnr.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "FoncAgt", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Médécin", "Infirmier"})
        Me.ComboBox1.Location = New System.Drawing.Point(50, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(252, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(LoginAgtLabel)
        Me.GroupBox1.Controls.Add(Me.txtLogin)
        Me.GroupBox1.Controls.Add(MdpAgtLabel)
        Me.GroupBox1.Controls.Add(Me.txtMdp)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 72)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de connection"
        '
        'txtLogin
        '
        Me.txtLogin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "LoginAgt", True))
        Me.txtLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(19, 32)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(242, 23)
        Me.txtLogin.TabIndex = 1
        '
        'txtMdp
        '
        Me.txtMdp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAgents, "MdpAgt", True))
        Me.txtMdp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdp.Location = New System.Drawing.Point(283, 32)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.Size = New System.Drawing.Size(229, 23)
        Me.txtMdp.TabIndex = 3
        '
        'bsAgents
        '
        Me.bsAgents.DataSource = GetType(VetoGest.Data.Models.Agent)
        '
        'FormAddAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnEnr)
        Me.Controls.Add(AdrAgtLabel)
        Me.Controls.Add(Me.txtAdr)
        Me.Controls.Add(FoncAgtLabel)
        Me.Controls.Add(NomCompAgtLabel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(TelAgtLabel)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddAgent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddAgent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bsAgents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bsAgents As BindingSource
    Friend WithEvents txtAdr As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents btnEnr As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtMdp As TextBox
End Class
