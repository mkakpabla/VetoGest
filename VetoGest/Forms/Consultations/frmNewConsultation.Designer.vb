<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewConsultation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodeAml = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPrixCons = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObsCons = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRaisonCons = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNomAml = New System.Windows.Forms.Label()
        Me.lblSexeAml = New System.Windows.Forms.Label()
        Me.lblNaissAml = New System.Windows.Forms.Label()
        Me.lblEsp = New System.Windows.Forms.Label()
        Me.lblCltNom = New System.Windows.Forms.Label()
        Me.lblCltTel = New System.Windows.Forms.Label()
        Me.lblCltAdr = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imformations sur l'animal"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65217!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.2029!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.43478!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71014!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNomAml, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSexeAml, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNaissAml, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEsp, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCltNom, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCltTel, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCltAdr, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(690, 106)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code animal"
        '
        'txtCodeAml
        '
        Me.txtCodeAml.Location = New System.Drawing.Point(12, 77)
        Me.txtCodeAml.Name = "txtCodeAml"
        Me.txtCodeAml.Size = New System.Drawing.Size(114, 20)
        Me.txtCodeAml.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(132, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Recherche"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 55)
        Me.Panel1.TabIndex = 32
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
        'txtPrixCons
        '
        Me.txtPrixCons.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrixCons.Location = New System.Drawing.Point(79, 256)
        Me.txtPrixCons.Name = "txtPrixCons"
        Me.txtPrixCons.Size = New System.Drawing.Size(635, 23)
        Me.txtPrixCons.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Prix"
        '
        'txtObsCons
        '
        Me.txtObsCons.Location = New System.Drawing.Point(79, 346)
        Me.txtObsCons.Multiline = True
        Me.txtObsCons.Name = "txtObsCons"
        Me.txtObsCons.Size = New System.Drawing.Size(635, 73)
        Me.txtObsCons.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Observation"
        '
        'txtRaisonCons
        '
        Me.txtRaisonCons.Location = New System.Drawing.Point(79, 296)
        Me.txtRaisonCons.Multiline = True
        Me.txtRaisonCons.Name = "txtRaisonCons"
        Me.txtRaisonCons.Size = New System.Drawing.Size(635, 44)
        Me.txtRaisonCons.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Raison"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(561, 429)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 33)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(347, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Propriétaire:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 26)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nom de l'animal:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Sexe:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 26)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Date de naissance:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 28)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Espèces:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(347, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 26)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Téléphone:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(347, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 26)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Addresse:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNomAml
        '
        Me.lblNomAml.AutoSize = True
        Me.lblNomAml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNomAml.Location = New System.Drawing.Point(111, 0)
        Me.lblNomAml.Name = "lblNomAml"
        Me.lblNomAml.Size = New System.Drawing.Size(230, 26)
        Me.lblNomAml.TabIndex = 8
        Me.lblNomAml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSexeAml
        '
        Me.lblSexeAml.AutoSize = True
        Me.lblSexeAml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSexeAml.Location = New System.Drawing.Point(111, 26)
        Me.lblSexeAml.Name = "lblSexeAml"
        Me.lblSexeAml.Size = New System.Drawing.Size(230, 26)
        Me.lblSexeAml.TabIndex = 9
        Me.lblSexeAml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNaissAml
        '
        Me.lblNaissAml.AutoSize = True
        Me.lblNaissAml.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNaissAml.Location = New System.Drawing.Point(111, 52)
        Me.lblNaissAml.Name = "lblNaissAml"
        Me.lblNaissAml.Size = New System.Drawing.Size(230, 26)
        Me.lblNaissAml.TabIndex = 10
        Me.lblNaissAml.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEsp
        '
        Me.lblEsp.AutoSize = True
        Me.lblEsp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEsp.Location = New System.Drawing.Point(111, 78)
        Me.lblEsp.Name = "lblEsp"
        Me.lblEsp.Size = New System.Drawing.Size(230, 28)
        Me.lblEsp.TabIndex = 11
        Me.lblEsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCltNom
        '
        Me.lblCltNom.AutoSize = True
        Me.lblCltNom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCltNom.Location = New System.Drawing.Point(419, 0)
        Me.lblCltNom.Name = "lblCltNom"
        Me.lblCltNom.Size = New System.Drawing.Size(268, 26)
        Me.lblCltNom.TabIndex = 12
        Me.lblCltNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCltTel
        '
        Me.lblCltTel.AutoSize = True
        Me.lblCltTel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCltTel.Location = New System.Drawing.Point(419, 26)
        Me.lblCltTel.Name = "lblCltTel"
        Me.lblCltTel.Size = New System.Drawing.Size(268, 26)
        Me.lblCltTel.TabIndex = 13
        Me.lblCltTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCltAdr
        '
        Me.lblCltAdr.AutoSize = True
        Me.lblCltAdr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCltAdr.Location = New System.Drawing.Point(419, 52)
        Me.lblCltAdr.Name = "lblCltAdr"
        Me.lblCltAdr.Size = New System.Drawing.Size(268, 26)
        Me.lblCltAdr.TabIndex = 14
        Me.lblCltAdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmNewConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 482)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPrixCons)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObsCons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRaisonCons)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCodeAml)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewConsultation"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodeAml As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPrixCons As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtObsCons As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRaisonCons As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNomAml As Label
    Friend WithEvents lblSexeAml As Label
    Friend WithEvents lblNaissAml As Label
    Friend WithEvents lblEsp As Label
    Friend WithEvents lblCltNom As Label
    Friend WithEvents lblCltTel As Label
    Friend WithEvents lblCltAdr As Label
End Class
