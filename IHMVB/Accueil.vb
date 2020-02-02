
Public Class Accueil



    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CBOX.Select()

        For Each Joueur As Joueur In Score.JoueurList
            Me.CBOX.Items.Add(Joueur.getNom())
        Next



    End Sub

    Private Sub TIM_DECO1_Tick(sender As Object, e As EventArgs) Handles TIM_DECO1.Tick
        If Me.LBL_TIM1.Text.Equals("0") Then
            Me.LBL_TIM1.Text = 100
        Else

            Me.TIM_DECO1.Interval = 500
            Me.LBL_TIM1.Text = Me.LBL_TIM1.Text - 1
        End If
    End Sub
    Private Sub TIM_DECO2_Tick(sender As Object, e As EventArgs) Handles TIM_DECO2.Tick
        If Me.LBL_TIM2.Text.Equals("0") Then
            Me.LBL_TIM2.Text = 100
        Else
            Me.TIM_DECO2.Interval = 500
            Me.LBL_TIM2.Text = Me.LBL_TIM2.Text - 1
        End If
    End Sub

    Private Sub CBOX_KeyDown(sender As Object, e As KeyEventArgs) Handles CBOX.KeyDown
        If e.KeyCode = 13 Then
            If BTT_JOUER.Enabled = True Then
                BTT_JOUER.PerformClick()
            End If
        End If
        If e.KeyCode = 27 Then
            BTT_QUITTER.PerformClick()
        End If
    End Sub
    Private Sub CBOX_TextChanged(sender As Object, e As EventArgs) Handles CBOX.TextChanged
        enableBTT_START()
    End Sub

    Private Sub enableBTT_START()
        If (String.IsNullOrEmpty(CBOX.Text) = False) Then
            BTT_JOUER.Enabled = True
            Label1.Visible = False
        Else
            BTT_JOUER.Enabled = False
            Label1.Visible = True
        End If
    End Sub


    Private Sub BTT_PARAM_Click(sender As Object, e As EventArgs) Handles BTT_PARAM.Click
        Me.Hide()
        Parametres.Show()
    End Sub

    Private Sub BTT_JOUER_Click(sender As Object, e As EventArgs) Handles BTT_JOUER.Click
        If (JoueurDejaExistant(Me.CBOX.Text)) Then

        Else
            Dim Joueur As New Joueur
            Joueur.SetNom(Me.CBOX.Text)
            Score.JoueurList.Add(Joueur)
            Me.CBOX.Items.Add(Joueur.getNom)
        End If

        Me.Hide()
        Jeu.Show()
    End Sub

    Private Sub BTT_QUITTER_Click(sender As Object, e As EventArgs) Handles BTT_QUITTER.Click
        If MsgBox("Es-tu sûr de vouloir quitter TAQUIN ATOMIQUE ?", vbYesNo) = vbYes Then
            Me.Close()
        Else
            Me.CBOX.Focus()
        End If
    End Sub


End Class