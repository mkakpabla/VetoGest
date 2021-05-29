Imports VetoGest.Data
Imports VetoGest.Data.Models

Public Class frmNewConsultation
    Dim CodeAml As Integer = 0
    Dim AmlInfo As AnimalInfo
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        CodeAml = Integer.Parse(txtCodeAml.Text)
        If CodeAml > 0 Then
            AmlInfo = GetAnimalRepository.GetAllInfo(CodeAml)
            If AmlInfo IsNot Nothing Then
                lblNomAml.Text = AmlInfo.NomAml
                lblSexeAml.Text = AmlInfo.SexeAml
                lblNaissAml.Text = AmlInfo.DateNaissAml
                lblEsp.Text = AmlInfo.LibEsp
                lblCltNom.Text = AmlInfo.FullName
                lblCltTel.Text = AmlInfo.TelClt
                lblCltAdr.Text = AmlInfo.AdrClt
                txtCodeAml.Enabled = False
                btnSearch.Enabled = False
            Else
                MessageBox.Show("Aucun animal trouvé avec ce code")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Cons As Consultation = New Consultation()
        Cons.IdAgt = GlobalVar.Agent.IdAgt
        Cons.DateCons = Date.Now
        Cons.IdAml = AmlInfo.IdAml
        Cons.ObsCons = txtObsCons.Text
        Cons.RaisonCons = txtRaisonCons.Text
        If GetConsultationRepository.Insert(Cons) Then
            lblNomAml.Text = Nothing
            lblSexeAml.Text = Nothing
            lblNaissAml.Text = Nothing
            lblEsp.Text = Nothing
            lblCltNom.Text = Nothing
            lblCltTel.Text = Nothing
            lblCltAdr.Text = Nothing
            txtRaisonCons.Clear()
            txtPrixCons.Clear()
            txtObsCons.Clear()
            txtCodeAml.Clear()
            MessageBox.Show("La consulation à été enrégistrer")
        End If

    End Sub
End Class