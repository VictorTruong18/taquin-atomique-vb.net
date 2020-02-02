Public Class Jeu

    Public TempsTimer As Integer = 60
    Public TempsInitial As Integer = TempsTimer

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Parametres.RBTT_MUSIQUE.Checked = True) Then
            My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Audio - Spy.wav", AudioPlayMode.BackgroundLoop)
        End If
        Me.Timer.Enabled = True
        Initialisation() 'Creation du taquin
        Me.GRP_BOX.Select() 'Focus sur la Group_Box avec les cases du Taquin
        LBL_TIMER.Text = TempsTimer 'Le timer est initialisé

    End Sub

    Private Sub BTT_RETOUR_Click(sender As Object, e As EventArgs) Handles BTT_RETOUR.Click
        If MsgBox("Des vies sont en jeu. Veux-tu vraiment abandonner?", vbYesNo) = vbYes Then
            My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Bruitages\Boom.wav")

            Dim Partie As New Partie
            If (Parametres.TRCK_TEMPS.Value = 0) Then

                Partie.setTps_jouee(TempsInitial - TempsTimer)
                GetJoueurFromList(Accueil.CBOX.Text).AjouterUnePartie(Partie)
            Else

                Partie.setTps_jouee(TempsInitial - Parametres.TRCK_TEMPS.Value)
                GetJoueurFromList(Accueil.CBOX.Text).AjouterUnePartie(Partie)
            End If



            Me.Close()
                Accueil.Show()
            Else

            End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        'Source : https://stackoverflow.com/questions/20026840/form-not-reading-arrow-key-in-keydown-event
        Select Case keyData
            Case Keys.Up
                MouvementHaut()
                If (Gagne()) Then

                    JeuGagne()
                End If
                Debug.Print("Up")
                Return True
            Case Keys.Right

                MouvementDroite()
                If (Gagne()) Then

                    JeuGagne()
                End If
                Debug.Print("Right")
                Return True
            Case Keys.Down
                MouvementBas()

                If (Gagne()) Then

                    JeuGagne()
                End If
                Debug.Print("Down")
                Return True
            Case Keys.Left
                MouvementGauche()

                If (Gagne()) Then

                    JeuGagne()
                End If
                Debug.Print("Left")
                Return True
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick


        If Me.LBL_TIMER.Text.Equals("0") Then
            Me.Timer.Enabled = False
            My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Bruitages\Boom.wav")
            If MsgBox("BOOM ! Tu n'as pas desamorce la bombe ! Souhaites-tu retenter ta chance ?", vbYesNo) = vbYes Then
                My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Audio - Spy.wav", AudioPlayMode.BackgroundLoop)

                Dim Partie As New Partie
                MsgBox(TempsInitial - TempsTimer)
                Partie.setTps_jouee(TempsInitial - TempsTimer)
                GetJoueurFromList(Accueil.CBOX.Text).AjouterUnePartie(Partie)

                Initialisation()
                Me.GRP_BOX.Select()
                If (Parametres.TRCK_TEMPS.Value = 0) Then
                    Me.LBL_TIMER.Text = 60
                    Me.TempsTimer = 60
                Else
                    Me.LBL_TIMER.Text = Parametres.TRCK_TEMPS.Value
                    Me.TempsTimer = Parametres.TRCK_TEMPS.Value
                End If
                Me.Timer.Enabled = True

            Else
                Me.Close()
                Accueil.Show()

            End If



        Else

            Me.TempsTimer = Me.TempsTimer - 1
            Me.LBL_TIMER.Text = Me.TempsTimer

        End If
    End Sub

    Private Sub BTT_SHUFFLE_Click(sender As Object, e As EventArgs) Handles BTT_SHUFFLE.Click
        Initialisation()
    End Sub
End Class