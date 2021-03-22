<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrint
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
        Me.crpPrint = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crpPrint
        '
        Me.crpPrint.ActiveViewIndex = -1
        Me.crpPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpPrint.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crpPrint.Location = New System.Drawing.Point(0, 0)
        Me.crpPrint.Name = "crpPrint"
        Me.crpPrint.Size = New System.Drawing.Size(800, 450)
        Me.crpPrint.TabIndex = 0
        Me.crpPrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crpPrint)
        Me.Name = "FormPrint"
        Me.Text = "FormPrint"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents crpPrint As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
