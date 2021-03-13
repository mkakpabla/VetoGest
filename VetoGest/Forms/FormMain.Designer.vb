<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMed = New System.Windows.Forms.Button()
        Me.btnConsultation = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnAnimaux = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContent
        '
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(213, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(773, 542)
        Me.pnlContent.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAnimaux)
        Me.Panel1.Controls.Add(Me.btnClients)
        Me.Panel1.Controls.Add(Me.btnMed)
        Me.Panel1.Controls.Add(Me.btnConsultation)
        Me.Panel1.Controls.Add(Me.btnAccueil)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 542)
        Me.Panel1.TabIndex = 2
        '
        'btnMed
        '
        Me.btnMed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMed.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMed.FlatAppearance.BorderSize = 0
        Me.btnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMed.Image = Global.VetoGest.My.Resources.Resources.lab_coat_25px
        Me.btnMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMed.Location = New System.Drawing.Point(0, 287)
        Me.btnMed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMed.Name = "btnMed"
        Me.btnMed.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMed.Size = New System.Drawing.Size(213, 48)
        Me.btnMed.TabIndex = 3
        Me.btnMed.Text = "Médecins"
        Me.btnMed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMed.UseVisualStyleBackColor = True
        '
        'btnConsultation
        '
        Me.btnConsultation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultation.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultation.FlatAppearance.BorderSize = 0
        Me.btnConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultation.Image = Global.VetoGest.My.Resources.Resources.audit_25px
        Me.btnConsultation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultation.Location = New System.Drawing.Point(0, 239)
        Me.btnConsultation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnConsultation.Size = New System.Drawing.Size(213, 48)
        Me.btnConsultation.TabIndex = 2
        Me.btnConsultation.Text = "Consulations"
        Me.btnConsultation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultation.UseVisualStyleBackColor = True
        '
        'btnAccueil
        '
        Me.btnAccueil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccueil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccueil.FlatAppearance.BorderSize = 0
        Me.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccueil.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccueil.ForeColor = System.Drawing.Color.Black
        Me.btnAccueil.Image = Global.VetoGest.My.Resources.Resources.clinic_25px
        Me.btnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccueil.Location = New System.Drawing.Point(0, 191)
        Me.btnAccueil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnAccueil.Size = New System.Drawing.Size(213, 48)
        Me.btnAccueil.TabIndex = 1
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccueil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.VetoGest.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnClients
        '
        Me.btnClients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClients.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClients.FlatAppearance.BorderSize = 0
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClients.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.Image = Global.VetoGest.My.Resources.Resources.dog_park_25px
        Me.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClients.Location = New System.Drawing.Point(0, 335)
        Me.btnClients.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnClients.Size = New System.Drawing.Size(213, 47)
        Me.btnClients.TabIndex = 5
        Me.btnClients.Text = "Clients"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnAnimaux
        '
        Me.btnAnimaux.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnimaux.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAnimaux.FlatAppearance.BorderSize = 0
        Me.btnAnimaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnimaux.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnimaux.Image = Global.VetoGest.My.Resources.Resources.dog_park_25px
        Me.btnAnimaux.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnimaux.Location = New System.Drawing.Point(0, 382)
        Me.btnAnimaux.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnimaux.Name = "btnAnimaux"
        Me.btnAnimaux.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnAnimaux.Size = New System.Drawing.Size(213, 47)
        Me.btnAnimaux.TabIndex = 6
        Me.btnAnimaux.Text = "Animaux"
        Me.btnAnimaux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnimaux.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAnimaux.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 542)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMed As Button
    Friend WithEvents btnConsultation As Button
    Friend WithEvents btnAccueil As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClients As Button
    Friend WithEvents btnAnimaux As Button
End Class
