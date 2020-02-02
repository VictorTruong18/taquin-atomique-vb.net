<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GRP_BOX = New System.Windows.Forms.GroupBox()
        Me.BTT_RETOUR = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_TIMER = New System.Windows.Forms.Label()
        Me.BTT_SHUFFLE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GRP_BOX
        '
        Me.GRP_BOX.BackColor = System.Drawing.Color.Transparent
        Me.GRP_BOX.Location = New System.Drawing.Point(285, 49)
        Me.GRP_BOX.Margin = New System.Windows.Forms.Padding(2)
        Me.GRP_BOX.Name = "GRP_BOX"
        Me.GRP_BOX.Padding = New System.Windows.Forms.Padding(2)
        Me.GRP_BOX.Size = New System.Drawing.Size(449, 409)
        Me.GRP_BOX.TabIndex = 0
        Me.GRP_BOX.TabStop = False
        '
        'BTT_RETOUR
        '
        Me.BTT_RETOUR.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BTT_RETOUR.BackgroundImage = Global.IHMVB.My.Resources.Resources.Couleur_Fond
        Me.BTT_RETOUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTT_RETOUR.Location = New System.Drawing.Point(984, 440)
        Me.BTT_RETOUR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTT_RETOUR.Name = "BTT_RETOUR"
        Me.BTT_RETOUR.Size = New System.Drawing.Size(172, 36)
        Me.BTT_RETOUR.TabIndex = 1
        Me.BTT_RETOUR.Text = "Abandon"
        Me.BTT_RETOUR.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'LBL_TIMER
        '
        Me.LBL_TIMER.AutoSize = True
        Me.LBL_TIMER.BackColor = System.Drawing.Color.Black
        Me.LBL_TIMER.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIMER.ForeColor = System.Drawing.Color.DarkRed
        Me.LBL_TIMER.Location = New System.Drawing.Point(955, 166)
        Me.LBL_TIMER.Name = "LBL_TIMER"
        Me.LBL_TIMER.Size = New System.Drawing.Size(0, 73)
        Me.LBL_TIMER.TabIndex = 2
        '
        'BTT_SHUFFLE
        '
        Me.BTT_SHUFFLE.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BTT_SHUFFLE.BackgroundImage = Global.IHMVB.My.Resources.Resources.Couleur_Fond
        Me.BTT_SHUFFLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTT_SHUFFLE.Location = New System.Drawing.Point(984, 317)
        Me.BTT_SHUFFLE.Margin = New System.Windows.Forms.Padding(2)
        Me.BTT_SHUFFLE.Name = "BTT_SHUFFLE"
        Me.BTT_SHUFFLE.Size = New System.Drawing.Size(172, 36)
        Me.BTT_SHUFFLE.TabIndex = 3
        Me.BTT_SHUFFLE.Text = "Shuffle"
        Me.BTT_SHUFFLE.UseVisualStyleBackColor = False
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IHMVB.My.Resources.Resources.Background1
        Me.ClientSize = New System.Drawing.Size(1186, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTT_SHUFFLE)
        Me.Controls.Add(Me.LBL_TIMER)
        Me.Controls.Add(Me.BTT_RETOUR)
        Me.Controls.Add(Me.GRP_BOX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GRP_BOX As GroupBox
    Friend WithEvents BTT_RETOUR As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents LBL_TIMER As Label
    Friend WithEvents BTT_SHUFFLE As Button
End Class
