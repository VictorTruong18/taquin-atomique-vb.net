Module Jeu_Module
    Sub Initialisation()


        'Reinitialisation de la groupe box
        Jeu.GRP_BOX.Controls.Clear()




        CreationTaquin()
        AssignationNombre()
        MelangeAleatoire()
        CreationCaseVide()






    End Sub
    Function Deriver(ByRef Valeur) As Integer


        If (Valeur = 2) Then
            Return 5
        End If
        If (Valeur = 3) Then
            Return 4
        End If
        If (Valeur = 4) Then
            Return 4
        End If
        If (Valeur = 5) Then
            Return 3
        End If
        If (Valeur = 6) Then
            Return 3
        End If
        If (Valeur = 7) Then
            Return 2
        End If
        If (Valeur = 8) Then
            Return 2
        End If
        If (Valeur = 9) Then
            Return 1
        End If
        If (Valeur = 10) Then
            Return 1
        End If

    End Function


    '----------------------------------------------------------------------------------Taquin Initialisation------------------------------------------------------------------------------------------------------------------
    Sub CreationTaquin()
        'Decalage
        Const DecalageX As Integer = 41 'Declage vers le bas
        Const DecalageY As Integer = 35 'Declage sur le cote 
        'Position Initial 
        Const PositionInitialXPair As Integer = 20
        Const PositionInitialXImpair As Integer = 38
        'Position
        Dim PositionXPair As Integer = 20 'Localisation du boutton dans l'espace - Ligne
        Dim PositionYPair As Integer = 25 'Localisation du boutton dans l'espace - Colonne
        Dim PositionXImpair As Integer = 50
        Dim PositionYImpair As Integer = 15
        'Taille
        Const TailleLongeur As Integer = 40 'Taille du Bouton - Longueur
        Const TailleLargeur As Integer = 34 'Taille du Bouton - Largeur 
        'Police d'ecriture
        Dim Style As FontStyle = FontStyle.Bold
        Dim Myanmar As Font = New Font(New FontFamily("Myanmar Text"), 10, Style)


        'Creation du Taquin selon les parametres selectionnes
        Select Case Parametres.X AndAlso Parametres.Y
            Case Parametres.X Mod 2 = 0 And Parametres.Y Mod 2 = 0 'X Pair et Y Pair
                For Y As Integer = 0 To Parametres.YMAX_PAIR - 1
                    For X As Integer = 0 To Parametres.XMAX_PAIR - 1
                        Dim Button As New Label
                        Button.Location = New Drawing.Point(PositionXPair, PositionYPair)
                        Button.Size = New System.Drawing.Size(TailleLongeur, TailleLargeur)
                        Button.Visible = False
                        Button.Enabled = False
                        Button.BackColor = Color.DarkGreen
                        Button.Font = Myanmar
                        Button.ForeColor = Color.WhiteSmoke
                        Button.BorderStyle = BorderStyle.FixedSingle
                        Button.TextAlign = ContentAlignment.MiddleCenter


                        Jeu.GRP_BOX.Controls.Add(Button)
                        PositionXPair += DecalageX
                    Next X
                    PositionXPair = PositionInitialXPair
                    PositionYPair += DecalageY
                Next Y
                Dim Coordonne As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
                For Y As Integer = 0 To Parametres.Y - 1


                    For X As Integer = 0 To Parametres.X - 1
                        Jeu.GRP_BOX.Controls(Coordonne).Visible = True
                        Jeu.GRP_BOX.Controls(Coordonne).Enabled = True
                        Coordonne += 1
                    Next X

                    Coordonne += Parametres.XMAX_PAIR - Parametres.X

                Next Y
            Case Parametres.X Mod 2 = 1 And Parametres.Y Mod 2 = 1 'X Impair et Y Impair
                For X As Integer = 0 To Parametres.YMAX_IMPAIR - 1
                    PositionXImpair = PositionInitialXImpair
                    PositionYImpair += DecalageY

                    For Y As Integer = 0 To Parametres.XMAX_IMPAIR - 1

                        Dim Button As New Label

                        Button.Location = New Drawing.Point(PositionXImpair, PositionYImpair)
                        Button.Size = New System.Drawing.Size(TailleLongeur, TailleLargeur)
                        Button.Visible = False
                        Button.Enabled = False
                        Button.BorderStyle = BorderStyle.FixedSingle
                        Button.TextAlign = ContentAlignment.MiddleCenter
                        Button.BackColor = Color.DarkGreen
                        Button.Font = Myanmar
                        Button.ForeColor = Color.WhiteSmoke
                        Jeu.GRP_BOX.Controls.Add(Button)
                        PositionXImpair += DecalageX


                    Next Y

                Next X
                Dim Coordonne As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
                For Y As Integer = 0 To Parametres.Y - 1


                    For X As Integer = 0 To Parametres.X - 1
                        Jeu.GRP_BOX.Controls(Coordonne).Visible = True
                        Jeu.GRP_BOX.Controls(Coordonne).Enabled = True
                        Coordonne += 1
                    Next X

                    Coordonne += Parametres.XMAX_IMPAIR - Parametres.X

                Next Y
            Case Parametres.X Mod 2 = 0 And Parametres.Y Mod 2 = 1 'X Pair et Y Impair
                For Y As Integer = 0 To Parametres.YMAX_IMPAIR - 1
                    PositionXPair = PositionInitialXPair
                    PositionYImpair += DecalageY

                    For X As Integer = 0 To Parametres.XMAX_PAIR - 1

                        Dim Button As New Label
                        Button.Location = New Drawing.Point(PositionXPair, PositionYImpair)
                        Button.Size = New System.Drawing.Size(TailleLongeur, TailleLargeur)
                        Button.Visible = False
                        Button.Enabled = False
                        Button.BorderStyle = BorderStyle.FixedSingle
                        Button.TextAlign = ContentAlignment.MiddleCenter
                        Button.BackColor = Color.DarkGreen
                        Button.Font = Myanmar
                        Button.ForeColor = Color.WhiteSmoke
                        Jeu.GRP_BOX.Controls.Add(Button)
                        PositionXPair += DecalageX


                    Next X

                Next Y
                Dim Coordonne As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
                For Y As Integer = 0 To Parametres.Y - 1


                    For X As Integer = 0 To Parametres.X - 1
                        Jeu.GRP_BOX.Controls(Coordonne).Visible = True
                        Jeu.GRP_BOX.Controls(Coordonne).Enabled = True

                        Coordonne += 1
                    Next X

                    Coordonne += Parametres.XMAX_PAIR - Parametres.X

                Next Y
            Case Parametres.X Mod 2 = 1 And Parametres.Y Mod 2 = 0 'X Impair et Y Pair
                For Y As Integer = 0 To Parametres.YMAX_PAIR - 1
                    PositionXImpair = PositionInitialXImpair
                    PositionYPair += DecalageY

                    For X As Integer = 0 To Parametres.XMAX_IMPAIR - 1

                        Dim Button As New Label
                        Button.Location = New Drawing.Point(PositionXImpair, PositionYPair - 30)
                        Button.Size = New System.Drawing.Size(TailleLongeur, TailleLargeur)
                        Button.Visible = False
                        Button.Enabled = False
                        Button.BorderStyle = BorderStyle.FixedSingle
                        Button.TextAlign = ContentAlignment.MiddleCenter
                        Button.BackColor = Color.DarkGreen
                        Button.Font = Myanmar
                        Button.ForeColor = Color.WhiteSmoke
                        Jeu.GRP_BOX.Controls.Add(Button)
                        PositionXImpair += DecalageX


                    Next X

                Next Y
                Dim Coordonne As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
                For Y As Integer = 0 To Parametres.Y - 1


                    For X As Integer = 0 To Parametres.X - 1
                        Jeu.GRP_BOX.Controls(Coordonne).Visible = True
                        Jeu.GRP_BOX.Controls(Coordonne).Enabled = True
                        Coordonne += 1
                    Next X

                    Coordonne += Parametres.XMAX_IMPAIR - Parametres.X

                Next Y
            Case Else
                MsgBox("Erreur")
        End Select
    End Sub
    Sub AssignationNombre()
        'Assignation des nombres sur les boutons
        Dim Indice As Integer = 1
        For Each Button As Label In Jeu.GRP_BOX.Controls
            If (Button.Visible = True) Then
                Button.Text = Indice
                Indice += 1

            End If
        Next
    End Sub
    Sub CreationCaseVide()
        For Each Button As Label In Jeu.GRP_BOX.Controls
            If (Button.Text = CStr(Parametres.X * Parametres.Y)) Then
                Button.Visible = False
            End If
        Next
    End Sub

    '----------------------------------------------------------------------------------Mélange---------------------------------------------------------------------------------------------------------------------------------
    Sub MelangeAleatoire()
        'Totalement aleatoirement
        Dim id(Parametres.X * Parametres.Y), i, j, R As Integer
        Dim A As Boolean
        A = False
        i = 1
        id(j) = 1

        Do While i <= Parametres.X * Parametres.Y
            Randomize()
            R = CInt(Int(((Parametres.X * Parametres.Y) * Rnd()) + 1))

            For j = 1 To i

                If (id(j) = R) Then
                    A = True
                    Exit For
                End If
            Next

            If A = True Then
                A = False

            Else
                id(i) = R
                i = i + 1
            End If

        Loop
        Dim repere As Integer = 1
        For Each Button As Label In Jeu.GRP_BOX.Controls
            If (Button.Visible) Then
                Button.Text = id(repere)
                repere += 1
            End If
        Next

    End Sub


    '----------------------------------------------------------------------------------Mouvements------------------------------------------------------------------------------------------------------------------------------ 
    Sub MouvementDroite()

        Dim PremiereCasePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonnePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim PremiereCaseIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonneIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        For Y As Integer = 0 To Parametres.Y - 1
            Dim Mouvement_effectue As Boolean = False

            For X As Integer = 0 To Parametres.X - 1


                If (Parametres.X Mod 2 = 0) Then
                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And (CoordonnePAIR - PremiereCasePAIR) Mod (Parametres.X) = 0 And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR + Parametres.X - 1).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR + Parametres.X - 1).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True
                    End If

                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And Not (CoordonnePAIR - PremiereCasePAIR) Mod (Parametres.X) = 0 And Not (Mouvement_effectue)) Then

                        Dim Nombre As String
                        Nombre = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR - 1).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR - 1).Text = Nombre
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()

                    End If

                Else
                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And (CoordonneIMPAIR - PremiereCaseIMPAIR) Mod (Parametres.X) = 0 And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR + Parametres.X - 1).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR + Parametres.X - 1).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True
                    End If

                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And Not (CoordonneIMPAIR - PremiereCaseIMPAIR) Mod (Parametres.X) = 0 And Not (Mouvement_effectue)) Then

                        Dim Nombre As String
                        Nombre = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR - 1).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR - 1).Text = Nombre
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()

                    End If


                End If

                CoordonnePAIR += 1
                CoordonneIMPAIR += 1
            Next X

            CoordonnePAIR += Parametres.XMAX_PAIR - Parametres.X
            PremiereCasePAIR += Parametres.XMAX_PAIR - Parametres.X
            CoordonneIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
            PremiereCaseIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
        Next Y
    End Sub
    Sub MouvementGauche()
        Dim PremiereCasePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonnePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim PremiereCaseIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonneIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1


        For Y As Integer = 0 To Parametres.Y - 1
            Dim Mouvement_effectue As Boolean = False

            For X As Integer = 0 To Parametres.X - 1

                If (Parametres.X Mod 2 = 0) Then
                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And (CoordonnePAIR - PremiereCasePAIR) Mod Parametres.X = (Parametres.X - 1) And Not (Mouvement_effectue)) Then
                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR - Parametres.X + 1).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR - Parametres.X + 1).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True
                    End If

                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And Not ((CoordonnePAIR - PremiereCasePAIR) Mod Parametres.X = (Parametres.X - 1)) And Not (Mouvement_effectue)) Then
                        Dim Nombre As String
                        Nombre = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR + 1).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR + 1).Text = Nombre
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If
                Else
                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And (CoordonneIMPAIR - PremiereCaseIMPAIR) Mod Parametres.X = (Parametres.X - 1) And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR - Parametres.X + 1).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR - Parametres.X + 1).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If

                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And Not ((CoordonneIMPAIR - PremiereCaseIMPAIR) Mod Parametres.X = (Parametres.X - 1)) And Not (Mouvement_effectue)) Then

                        Dim Nombre As String
                        Nombre = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR + 1).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR + 1).Text = Nombre
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If

                End If
                CoordonnePAIR += 1
                CoordonneIMPAIR += 1
            Next X

            CoordonnePAIR += Parametres.XMAX_PAIR - Parametres.X
            PremiereCasePAIR += Parametres.XMAX_PAIR - Parametres.X
            CoordonneIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
            PremiereCaseIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
        Next Y
    End Sub
    Sub MouvementHaut()
        Dim PremiereCasePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonnePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim PremiereCaseIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonneIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim Mouvement_effectue As Boolean = False
        For Y As Integer = 0 To Parametres.Y - 1


            For X As Integer = 0 To Parametres.X - 1

                If (Parametres.X Mod 2 = 0) Then
                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And Jeu.GRP_BOX.Controls(CoordonnePAIR + Parametres.XMAX_PAIR).Visible = True And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR + Parametres.XMAX_PAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR + Parametres.XMAX_PAIR).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If



                Else
                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And Jeu.GRP_BOX.Controls(CoordonneIMPAIR + Parametres.XMAX_IMPAIR).Visible = True And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR + Parametres.XMAX_IMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR + Parametres.XMAX_IMPAIR).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If


                End If
                CoordonnePAIR += 1
                CoordonneIMPAIR += 1
            Next X

            CoordonnePAIR += Parametres.XMAX_PAIR - Parametres.X
            PremiereCasePAIR += Parametres.XMAX_PAIR - Parametres.X
            CoordonneIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
            PremiereCaseIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
        Next Y
    End Sub
    Sub MouvementBas()
        Dim PremiereCasePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonnePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim PremiereCaseIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonneIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim Mouvement_effectue As Boolean = False

        For Y As Integer = 0 To Parametres.Y - 1

            For X As Integer = 0 To Parametres.X - 1

                If (Parametres.X Mod 2 = 0) Then
                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = False And Jeu.GRP_BOX.Controls(CoordonnePAIR - Parametres.XMAX_PAIR).Visible = True And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonnePAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = Jeu.GRP_BOX.Controls(CoordonnePAIR - Parametres.XMAX_PAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonnePAIR - Parametres.XMAX_PAIR).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonnePAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If



                Else
                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = False And Jeu.GRP_BOX.Controls(CoordonneIMPAIR - Parametres.XMAX_IMPAIR).Visible = True And Not (Mouvement_effectue)) Then

                        Dim Nombre2 As String
                        Nombre2 = Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = Jeu.GRP_BOX.Controls(CoordonneIMPAIR - Parametres.XMAX_IMPAIR).Text
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR - Parametres.XMAX_IMPAIR).Text = Nombre2
                        Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Visible = True
                        CreationCaseVide()
                        Mouvement_effectue = True

                    End If


                End If
                CoordonnePAIR += 1
                CoordonneIMPAIR += 1
            Next X

            CoordonnePAIR += Parametres.XMAX_PAIR - Parametres.X
            PremiereCasePAIR += Parametres.XMAX_PAIR - Parametres.X
            CoordonneIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
            PremiereCaseIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
        Next Y
    End Sub

    '-----------------------------------------------------------------------------------Jeu------------------------------------------------------------------------------------------------------------------------------------

    Function Gagne() As Boolean
        Dim PremiereCasePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonnePAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_PAIR) + Deriver(Parametres.X)) - 1
        Dim PremiereCaseIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim CoordonneIMPAIR As Integer = (((Deriver(Parametres.Y) - 1) * Parametres.XMAX_IMPAIR) + Deriver(Parametres.X)) - 1
        Dim Indice As Integer = 0

        For Y As Integer = 0 To Parametres.Y - 1


            For X As Integer = 0 To Parametres.X - 1
                If (Parametres.X Mod 2 = 0) Then
                    If (Jeu.GRP_BOX.Controls(CoordonnePAIR).Text = (CoordonnePAIR - PremiereCasePAIR) + 1) Then

                        Indice += 1
                    End If

                    If (Indice = Parametres.X * Parametres.Y) Then

                        Return True
                    End If

                Else
                    If (Jeu.GRP_BOX.Controls(CoordonneIMPAIR).Text = (CoordonneIMPAIR - PremiereCaseIMPAIR) + 1) Then

                        Indice += 1
                    End If

                    If (Indice = Parametres.X * Parametres.Y) Then

                        Return True
                    End If

                End If
                CoordonnePAIR += 1
                CoordonneIMPAIR += 1
            Next X

            CoordonnePAIR += Parametres.XMAX_PAIR - Parametres.X
            PremiereCasePAIR += Parametres.XMAX_PAIR - Parametres.X
            CoordonneIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
            PremiereCaseIMPAIR += Parametres.XMAX_IMPAIR - Parametres.X
        Next Y




    End Function

    Sub JeuGagne()
        Jeu.Timer.Enabled = False
        My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Bruitages\Clickk.wav")

        If MsgBox("Bien Joue tu as desamorcé la bombe ! Veux tu en désarmorcer une autre ?", vbYesNo) = vbYes Then
            My.Computer.Audio.Play("C:\Users\Victor\Documents\Paris Descartes\Visual Basic\Projet_IHMVB_NouvelTentative\IHMVB\IHMVB\Ressources\Audio - Spy.wav", AudioPlayMode.BackgroundLoop)
            Initialisation()
            Jeu.GRP_BOX.Select()
            If (Parametres.TRCK_TEMPS.Value = 0) Then
                Jeu.LBL_TIMER.Text = 60
                Jeu.TempsTimer = 60
            Else
                Jeu.LBL_TIMER.Text = Parametres.TRCK_TEMPS.Value
                Jeu.TempsTimer = Parametres.TRCK_TEMPS.Value
            End If
            Jeu.Timer.Enabled = True
        Else
            Jeu.Close()
            Accueil.Show()

        End If
    End Sub


End Module
