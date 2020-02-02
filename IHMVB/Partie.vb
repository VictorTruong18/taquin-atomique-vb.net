Public Class Partie
    Private Resolue As Boolean = False
    Private Tps_jouee As Integer


    Public Sub setTps_jouee(ByRef TpsJouee As Integer)
        Me.Tps_jouee = TpsJouee
    End Sub
    Public Function getTps_jouee() As Integer
        Return Tps_jouee
    End Function

    Public Sub EstResolue()
        Resolue = True
    End Sub

End Class
