<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parametres
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBL_PARAM = New System.Windows.Forms.Label()
        Me.LBL_CONFIG = New System.Windows.Forms.Label()
        Me.LBL_LONG = New System.Windows.Forms.Label()
        Me.LBL_LARGE = New System.Windows.Forms.Label()
        Me.CBOX_LONGEUR = New System.Windows.Forms.ComboBox()
        Me.CBOX_LARGEUR = New System.Windows.Forms.ComboBox()
        Me.BTT_RETOUR = New System.Windows.Forms.Button()
        Me.BTT_CONFIRMER = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TRCK_TEMPS = New System.Windows.Forms.TrackBar()
        Me.LBL_TEMPS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RBTT_MUSIQUE = New System.Windows.Forms.CheckBox()
        CType(Me.TRCK_TEMPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_PARAM
        '
        Me.LBL_PARAM.AutoSize = True
        Me.LBL_PARAM.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PARAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_PARAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PARAM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LBL_PARAM.Location = New System.Drawing.Point(103, 25)
        Me.LBL_PARAM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_PARAM.Name = "LBL_PARAM"
        Me.LBL_PARAM.Size = New System.Drawing.Size(230, 46)
        Me.LBL_PARAM.TabIndex = 3
        Me.LBL_PARAM.Text = "Parametres"
        '
        'LBL_CONFIG
        '
        Me.LBL_CONFIG.AutoSize = True
        Me.LBL_CONFIG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CONFIG.Location = New System.Drawing.Point(29, 87)
        Me.LBL_CONFIG.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_CONFIG.Name = "LBL_CONFIG"
        Me.LBL_CONFIG.Size = New System.Drawing.Size(226, 24)
        Me.LBL_CONFIG.TabIndex = 4
        Me.LBL_CONFIG.Text = "Configurations du Jeu :"
        '
        'LBL_LONG
        '
        Me.LBL_LONG.AutoSize = True
        Me.LBL_LONG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LONG.Location = New System.Drawing.Point(30, 124)
        Me.LBL_LONG.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_LONG.Name = "LBL_LONG"
        Me.LBL_LONG.Size = New System.Drawing.Size(87, 17)
        Me.LBL_LONG.TabIndex = 5
        Me.LBL_LONG.Text = "Longueur :"
        '
        'LBL_LARGE
        '
        Me.LBL_LARGE.AutoSize = True
        Me.LBL_LARGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_LARGE.Location = New System.Drawing.Point(206, 122)
        Me.LBL_LARGE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_LARGE.Name = "LBL_LARGE"
        Me.LBL_LARGE.Size = New System.Drawing.Size(75, 17)
        Me.LBL_LARGE.TabIndex = 6
        Me.LBL_LARGE.Text = "Largeur :"
        '
        'CBOX_LONGEUR
        '
        Me.CBOX_LONGEUR.FormattingEnabled = True
        Me.CBOX_LONGEUR.Location = New System.Drawing.Point(117, 124)
        Me.CBOX_LONGEUR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBOX_LONGEUR.Name = "CBOX_LONGEUR"
        Me.CBOX_LONGEUR.Size = New System.Drawing.Size(36, 21)
        Me.CBOX_LONGEUR.TabIndex = 7
        '
        'CBOX_LARGEUR
        '
        Me.CBOX_LARGEUR.FormattingEnabled = True
        Me.CBOX_LARGEUR.Location = New System.Drawing.Point(286, 124)
        Me.CBOX_LARGEUR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBOX_LARGEUR.Name = "CBOX_LARGEUR"
        Me.CBOX_LARGEUR.Size = New System.Drawing.Size(36, 21)
        Me.CBOX_LARGEUR.TabIndex = 8
        '
        'BTT_RETOUR
        '
        Me.BTT_RETOUR.Location = New System.Drawing.Point(103, 348)
        Me.BTT_RETOUR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTT_RETOUR.Name = "BTT_RETOUR"
        Me.BTT_RETOUR.Size = New System.Drawing.Size(82, 38)
        Me.BTT_RETOUR.TabIndex = 9
        Me.BTT_RETOUR.Text = "Retour"
        Me.BTT_RETOUR.UseVisualStyleBackColor = True
        '
        'BTT_CONFIRMER
        '
        Me.BTT_CONFIRMER.Location = New System.Drawing.Point(239, 348)
        Me.BTT_CONFIRMER.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTT_CONFIRMER.Name = "BTT_CONFIRMER"
        Me.BTT_CONFIRMER.Size = New System.Drawing.Size(82, 38)
        Me.BTT_CONFIRMER.TabIndex = 10
        Me.BTT_CONFIRMER.Text = "Confirmer "
        Me.BTT_CONFIRMER.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Temps de resolution  :"
        '
        'TRCK_TEMPS
        '
        Me.TRCK_TEMPS.Location = New System.Drawing.Point(34, 187)
        Me.TRCK_TEMPS.Maximum = 200
        Me.TRCK_TEMPS.MaximumSize = New System.Drawing.Size(1000, 0)
        Me.TRCK_TEMPS.MinimumSize = New System.Drawing.Size(10, 0)
        Me.TRCK_TEMPS.Name = "TRCK_TEMPS"
        Me.TRCK_TEMPS.Size = New System.Drawing.Size(369, 45)
        Me.TRCK_TEMPS.TabIndex = 12
        '
        'LBL_TEMPS
        '
        Me.LBL_TEMPS.AutoSize = True
        Me.LBL_TEMPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TEMPS.Location = New System.Drawing.Point(267, 162)
        Me.LBL_TEMPS.Name = "LBL_TEMPS"
        Me.LBL_TEMPS.Size = New System.Drawing.Size(17, 18)
        Me.LBL_TEMPS.TabIndex = 13
        Me.LBL_TEMPS.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sec"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Musique  :"
        '
        'RBTT_MUSIQUE
        '
        Me.RBTT_MUSIQUE.AutoSize = True
        Me.RBTT_MUSIQUE.Location = New System.Drawing.Point(143, 248)
        Me.RBTT_MUSIQUE.Name = "RBTT_MUSIQUE"
        Me.RBTT_MUSIQUE.Size = New System.Drawing.Size(15, 14)
        Me.RBTT_MUSIQUE.TabIndex = 18
        Me.RBTT_MUSIQUE.UseVisualStyleBackColor = True
        '
        'Parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 433)
        Me.Controls.Add(Me.RBTT_MUSIQUE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_TEMPS)
        Me.Controls.Add(Me.TRCK_TEMPS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTT_CONFIRMER)
        Me.Controls.Add(Me.BTT_RETOUR)
        Me.Controls.Add(Me.CBOX_LARGEUR)
        Me.Controls.Add(Me.CBOX_LONGEUR)
        Me.Controls.Add(Me.LBL_LARGE)
        Me.Controls.Add(Me.LBL_LONG)
        Me.Controls.Add(Me.LBL_CONFIG)
        Me.Controls.Add(Me.LBL_PARAM)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Parametres"
        Me.Text = "Parametres"
        CType(Me.TRCK_TEMPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_PARAM As Label
    Friend WithEvents LBL_CONFIG As Label
    Friend WithEvents LBL_LONG As Label
    Friend WithEvents LBL_LARGE As Label
    Friend WithEvents CBOX_LONGEUR As ComboBox
    Friend WithEvents CBOX_LARGEUR As ComboBox
    Friend WithEvents BTT_RETOUR As Button
    Friend WithEvents BTT_CONFIRMER As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TRCK_TEMPS As TrackBar
    Friend WithEvents LBL_TEMPS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RBTT_MUSIQUE As CheckBox
End Class
