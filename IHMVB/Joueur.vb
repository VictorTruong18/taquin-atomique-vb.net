Public Class Joueur
    Private Nom As String
    Private ListParties As New List(Of Partie)

    Public Sub SetNom(ByRef Surnom As String)
        Me.Nom = Surnom
    End Sub

    Public Sub AjouterUnePartie(ByRef Partie As Partie)
        ListParties.Add(Partie)
    End Sub

    Public Function getNom() As String
        Return Me.Nom
    End Function
    Public Function getTempsCumul() As Double
        Dim tmpsCumul As Integer = 0
        For Each Partie In ListParties
            tmpsCumul += Partie.getTps_jouee
        Next
        Return tmpsCumul
    End Function

    Public Function getNbPartieJouee() As Integer
        Return ListParties.Count
    End Function

    Public Function getMeilleurTemps() As Integer
        Dim MeilleurTps As Integer
        For i As Integer = 0 To ListParties.Count - 1
            If (ListParties.ElementAt(i).getTps_jouee < ListParties.ElementAt(i + 1).getTps_jouee) Then
                MeilleurTps = ListParties.ElementAt(i).getTps_jouee
            End If
        Next i
        Return MeilleurTps
    End Function

End Class
