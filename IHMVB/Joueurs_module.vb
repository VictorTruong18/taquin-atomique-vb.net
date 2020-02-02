Module Joueurs_module
    Public Function JoueurDejaExistant(ByRef Surnom As String) As Boolean
        If (Accueil.CBOX.Items.Contains(Surnom)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetJoueurFromList(ByRef Surnom As String) As Joueur
        For Each Joueur As Joueur In Score.JoueurList
            If (Joueur.getNom().Equals(Surnom)) Then
                Return Joueur
            Else
                Return Nothing
            End If

        Next

    End Function
End Module
