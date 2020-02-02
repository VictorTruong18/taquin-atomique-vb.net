Public Class Parametres

    Public X As Integer = 4 'Le nombre de Lignes
    Public Y As Integer = 4 'Le nombre de Colonnes
    Public Const XMAX_PAIR As Integer = 10 'Le nombre MAX de lignes, nombre pair 
    Public Const YMAX_PAIR As Integer = 10 'Le nombre MAX de colonnes, nombre pair
    Public Const XMAX_IMPAIR As Integer = 9 'Le nombre MAX de lignes, nombre impair
    Public Const YMAX_IMPAIR As Integer = 9 'Le nombre MAX de colonnes, nombre impair 


    Private Sub Parametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CBOX_LONGEUR.Text = X
        Me.CBOX_LARGEUR.Text = Y
        Me.CBOX_LONGEUR.Items.AddRange({2, 3, 4, 5, 6, 7, 8}) ' Ajout des valeurs autorisees
        Me.CBOX_LARGEUR.Items.AddRange({2, 3, 4, 5, 6, 7, 8}) ' Ajout des valeurs autorisees

    End Sub

    Private Sub BTT_RETOUR_Click(sender As Object, e As EventArgs) Handles BTT_RETOUR.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub BTT_CONFIRMER_Click(sender As Object, e As EventArgs) Handles BTT_CONFIRMER.Click
        If (String.IsNullOrEmpty(CBOX_LONGEUR.Text) = False) And (String.IsNullOrEmpty(CBOX_LARGEUR.Text) = False And Not Me.TRCK_TEMPS.Value = 0) Then
            X = Me.CBOX_LONGEUR.Text
            Y = Me.CBOX_LARGEUR.Text
            Jeu.TempsTimer = TRCK_TEMPS.Value
            Jeu.Timer.Enabled = False
            MsgBox("Les Changements ont ete effectue avec succes")
            Me.Hide()
            Accueil.Show()
        Else
            MsgBox("Erreur : Veuillez remplir tous les parametres")
        End If
    End Sub

    Private Sub TRCK_TEMPS_Scroll(sender As Object, e As EventArgs) Handles TRCK_TEMPS.Scroll
        LBL_TEMPS.Text = TRCK_TEMPS.Value
    End Sub


End Class