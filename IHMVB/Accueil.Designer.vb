<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.components = New System.ComponentModel.Container()
        Me.BTT_PARAM = New System.Windows.Forms.Button()
        Me.BTT_JOUER = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTT_QUITTER = New System.Windows.Forms.Button()
        Me.CBOX = New System.Windows.Forms.ComboBox()
        Me.LBL_INSCRIPTION = New System.Windows.Forms.Label()
        Me.LBL_DESC2 = New System.Windows.Forms.Label()
        Me.LBL_DESC1 = New System.Windows.Forms.Label()
        Me.LBL_TITRE = New System.Windows.Forms.Label()
        Me.LBL_TIM1 = New System.Windows.Forms.Label()
        Me.LBL_TIM2 = New System.Windows.Forms.Label()
        Me.TIM_DECO1 = New System.Windows.Forms.Timer(Me.components)
        Me.TIM_DECO2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTT_PARAM
        '
        Me.BTT_PARAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTT_PARAM.Location = New System.Drawing.Point(174, 141)
        Me.BTT_PARAM.Margin = New System.Windows.Forms.Padding(2)
        Me.BTT_PARAM.Name = "BTT_PARAM"
        Me.BTT_PARAM.Size = New System.Drawing.Size(169, 34)
        Me.BTT_PARAM.TabIndex = 0
        Me.BTT_PARAM.Text = "Parametres"
        Me.BTT_PARAM.UseVisualStyleBackColor = True
        '
        'BTT_JOUER
        '
        Me.BTT_JOUER.Enabled = False
        Me.BTT_JOUER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTT_JOUER.Location = New System.Drawing.Point(174, 101)
        Me.BTT_JOUER.Margin = New System.Windows.Forms.Padding(2)
        Me.BTT_JOUER.Name = "BTT_JOUER"
        Me.BTT_JOUER.Size = New System.Drawing.Size(169, 36)
        Me.BTT_JOUER.TabIndex = 1
        Me.BTT_JOUER.Text = "Désamorcer la bombe"
        Me.BTT_JOUER.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BTT_QUITTER)
        Me.GroupBox1.Controls.Add(Me.CBOX)
        Me.GroupBox1.Controls.Add(Me.BTT_PARAM)
        Me.GroupBox1.Controls.Add(Me.BTT_JOUER)
        Me.GroupBox1.Controls.Add(Me.LBL_INSCRIPTION)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 203)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 34)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Score"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Identifiez-vous pour commencer !"
        '
        'BTT_QUITTER
        '
        Me.BTT_QUITTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTT_QUITTER.Location = New System.Drawing.Point(9, 101)
        Me.BTT_QUITTER.Name = "BTT_QUITTER"
        Me.BTT_QUITTER.Size = New System.Drawing.Size(160, 34)
        Me.BTT_QUITTER.TabIndex = 7
        Me.BTT_QUITTER.Text = "Quitter"
        Me.BTT_QUITTER.UseVisualStyleBackColor = True
        '
        'CBOX
        '
        Me.CBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOX.FormattingEnabled = True
        Me.CBOX.Location = New System.Drawing.Point(69, 48)
        Me.CBOX.MaxLength = 21
        Me.CBOX.Name = "CBOX"
        Me.CBOX.Size = New System.Drawing.Size(207, 24)
        Me.CBOX.TabIndex = 6
        '
        'LBL_INSCRIPTION
        '
        Me.LBL_INSCRIPTION.AutoSize = True
        Me.LBL_INSCRIPTION.BackColor = System.Drawing.Color.Maroon
        Me.LBL_INSCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_INSCRIPTION.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBL_INSCRIPTION.Location = New System.Drawing.Point(0, 0)
        Me.LBL_INSCRIPTION.Name = "LBL_INSCRIPTION"
        Me.LBL_INSCRIPTION.Size = New System.Drawing.Size(357, 31)
        Me.LBL_INSCRIPTION.TabIndex = 5
        Me.LBL_INSCRIPTION.Text = "Inscription d'un démineur :"
        '
        'LBL_DESC2
        '
        Me.LBL_DESC2.AutoSize = True
        Me.LBL_DESC2.BackColor = System.Drawing.Color.Maroon
        Me.LBL_DESC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DESC2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBL_DESC2.Location = New System.Drawing.Point(39, 146)
        Me.LBL_DESC2.Name = "LBL_DESC2"
        Me.LBL_DESC2.Size = New System.Drawing.Size(363, 31)
        Me.LBL_DESC2.TabIndex = 8
        Me.LBL_DESC2.Text = "Chaque Seconde Compte !"
        '
        'LBL_DESC1
        '
        Me.LBL_DESC1.AutoSize = True
        Me.LBL_DESC1.BackColor = System.Drawing.Color.Maroon
        Me.LBL_DESC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DESC1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBL_DESC1.Location = New System.Drawing.Point(39, 115)
        Me.LBL_DESC1.Name = "LBL_DESC1"
        Me.LBL_DESC1.Size = New System.Drawing.Size(627, 31)
        Me.LBL_DESC1.TabIndex = 7
        Me.LBL_DESC1.Text = "Désamorcez le Taquin. Sauvez des Innocents. "
        '
        'LBL_TITRE
        '
        Me.LBL_TITRE.AutoSize = True
        Me.LBL_TITRE.BackColor = System.Drawing.Color.Maroon
        Me.LBL_TITRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TITRE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LBL_TITRE.Location = New System.Drawing.Point(41, 31)
        Me.LBL_TITRE.Name = "LBL_TITRE"
        Me.LBL_TITRE.Size = New System.Drawing.Size(648, 73)
        Me.LBL_TITRE.TabIndex = 6
        Me.LBL_TITRE.Text = "TAQUIN ATOMIQUE"
        '
        'LBL_TIM1
        '
        Me.LBL_TIM1.AutoSize = True
        Me.LBL_TIM1.BackColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TIM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIM1.ForeColor = System.Drawing.Color.Maroon
        Me.LBL_TIM1.Location = New System.Drawing.Point(623, 185)
        Me.LBL_TIM1.Name = "LBL_TIM1"
        Me.LBL_TIM1.Size = New System.Drawing.Size(43, 24)
        Me.LBL_TIM1.TabIndex = 10
        Me.LBL_TIM1.Text = "100"
        '
        'LBL_TIM2
        '
        Me.LBL_TIM2.AutoSize = True
        Me.LBL_TIM2.BackColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TIM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIM2.ForeColor = System.Drawing.Color.Chartreuse
        Me.LBL_TIM2.Location = New System.Drawing.Point(623, 426)
        Me.LBL_TIM2.Name = "LBL_TIM2"
        Me.LBL_TIM2.Size = New System.Drawing.Size(43, 24)
        Me.LBL_TIM2.TabIndex = 11
        Me.LBL_TIM2.Text = "195"
        '
        'TIM_DECO1
        '
        Me.TIM_DECO1.Enabled = True
        Me.TIM_DECO1.Interval = 1000
        '
        'TIM_DECO2
        '
        Me.TIM_DECO2.Enabled = True
        Me.TIM_DECO2.Interval = 1000
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IHMVB.My.Resources.Resources.Accueil1
        Me.ClientSize = New System.Drawing.Size(720, 478)
        Me.Controls.Add(Me.LBL_TIM2)
        Me.Controls.Add(Me.LBL_TIM1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBL_DESC2)
        Me.Controls.Add(Me.LBL_DESC1)
        Me.Controls.Add(Me.LBL_TITRE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTT_JOUER As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTT_QUITTER As Button
    Friend WithEvents CBOX As ComboBox
    Friend WithEvents LBL_INSCRIPTION As Label
    Friend WithEvents LBL_DESC2 As Label
    Friend WithEvents LBL_DESC1 As Label
    Friend WithEvents LBL_TITRE As Label
    Friend WithEvents BTT_PARAM As Button
    Friend WithEvents LBL_TIM1 As Label
    Friend WithEvents LBL_TIM2 As Label
    Friend WithEvents TIM_DECO1 As Timer
    Friend WithEvents TIM_DECO2 As Timer
End Class
