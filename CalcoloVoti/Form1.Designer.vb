<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalcoloVoti
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtTitolo = New System.Windows.Forms.Label()
        Me.TxtAlunni = New System.Windows.Forms.Label()
        Me.SelezAlunni = New System.Windows.Forms.NumericUpDown()
        Me.PulsanteVoti = New System.Windows.Forms.Button()
        Me.TxtMedia = New System.Windows.Forms.Label()
        Me.TxtBoxMedia = New System.Windows.Forms.TextBox()
        Me.TxtAutore = New System.Windows.Forms.Label()
        Me.TxtSomma = New System.Windows.Forms.Label()
        Me.TxtBoxSomma = New System.Windows.Forms.TextBox()
        Me.TxtVersione = New System.Windows.Forms.Label()
        Me.TxtMin = New System.Windows.Forms.Label()
        Me.TxtBoxMin = New System.Windows.Forms.TextBox()
        Me.TxtMax = New System.Windows.Forms.Label()
        Me.TxtBoxMax = New System.Windows.Forms.TextBox()
        Me.PulsanteReset = New System.Windows.Forms.Button()
        Me.RadioChiaro = New System.Windows.Forms.RadioButton()
        Me.RadioScuro = New System.Windows.Forms.RadioButton()
        Me.RadioGiallo = New System.Windows.Forms.RadioButton()
        Me.GBoxTemi = New System.Windows.Forms.GroupBox()
        Me.TxtSuff = New System.Windows.Forms.Label()
        Me.TxtBoxSuff = New System.Windows.Forms.TextBox()
        Me.TxtInsuff = New System.Windows.Forms.Label()
        Me.TxtBoxInsuff = New System.Windows.Forms.TextBox()
        CType(Me.SelezAlunni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBoxTemi.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtTitolo
        '
        Me.TxtTitolo.AutoSize = True
        Me.TxtTitolo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitolo.ForeColor = System.Drawing.Color.Black
        Me.TxtTitolo.Location = New System.Drawing.Point(13, 13)
        Me.TxtTitolo.Name = "TxtTitolo"
        Me.TxtTitolo.Size = New System.Drawing.Size(117, 30)
        Me.TxtTitolo.TabIndex = 0
        Me.TxtTitolo.Text = "CalcoloVoti"
        '
        'TxtAlunni
        '
        Me.TxtAlunni.AutoSize = True
        Me.TxtAlunni.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlunni.ForeColor = System.Drawing.Color.Black
        Me.TxtAlunni.Location = New System.Drawing.Point(18, 78)
        Me.TxtAlunni.Name = "TxtAlunni"
        Me.TxtAlunni.Size = New System.Drawing.Size(201, 21)
        Me.TxtAlunni.TabIndex = 1
        Me.TxtAlunni.Text = "Inserisci il numero di alunni"
        '
        'SelezAlunni
        '
        Me.SelezAlunni.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelezAlunni.Location = New System.Drawing.Point(226, 78)
        Me.SelezAlunni.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SelezAlunni.Name = "SelezAlunni"
        Me.SelezAlunni.Size = New System.Drawing.Size(84, 22)
        Me.SelezAlunni.TabIndex = 2
        '
        'PulsanteVoti
        '
        Me.PulsanteVoti.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulsanteVoti.Location = New System.Drawing.Point(22, 119)
        Me.PulsanteVoti.Name = "PulsanteVoti"
        Me.PulsanteVoti.Size = New System.Drawing.Size(288, 23)
        Me.PulsanteVoti.TabIndex = 3
        Me.PulsanteVoti.Text = "Clicca qui per inserire i voti"
        Me.PulsanteVoti.UseVisualStyleBackColor = True
        Me.PulsanteVoti.Visible = False
        '
        'TxtMedia
        '
        Me.TxtMedia.AutoSize = True
        Me.TxtMedia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedia.ForeColor = System.Drawing.Color.Black
        Me.TxtMedia.Location = New System.Drawing.Point(35, 169)
        Me.TxtMedia.Name = "TxtMedia"
        Me.TxtMedia.Size = New System.Drawing.Size(140, 21)
        Me.TxtMedia.TabIndex = 4
        Me.TxtMedia.Text = "La media dei voti è"
        Me.TxtMedia.Visible = False
        '
        'TxtBoxMedia
        '
        Me.TxtBoxMedia.BackColor = System.Drawing.Color.White
        Me.TxtBoxMedia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxMedia.Location = New System.Drawing.Point(181, 168)
        Me.TxtBoxMedia.Name = "TxtBoxMedia"
        Me.TxtBoxMedia.ReadOnly = True
        Me.TxtBoxMedia.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxMedia.TabIndex = 6
        Me.TxtBoxMedia.Visible = False
        '
        'TxtAutore
        '
        Me.TxtAutore.AutoSize = True
        Me.TxtAutore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAutore.ForeColor = System.Drawing.Color.Black
        Me.TxtAutore.Location = New System.Drawing.Point(378, 408)
        Me.TxtAutore.Name = "TxtAutore"
        Me.TxtAutore.Size = New System.Drawing.Size(35, 21)
        Me.TxtAutore.TabIndex = 7
        Me.TxtAutore.Text = "Leo"
        '
        'TxtSomma
        '
        Me.TxtSomma.AutoSize = True
        Me.TxtSomma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSomma.ForeColor = System.Drawing.Color.Black
        Me.TxtSomma.Location = New System.Drawing.Point(26, 204)
        Me.TxtSomma.Name = "TxtSomma"
        Me.TxtSomma.Size = New System.Drawing.Size(149, 21)
        Me.TxtSomma.TabIndex = 8
        Me.TxtSomma.Text = "La somma dei voti è"
        Me.TxtSomma.Visible = False
        '
        'TxtBoxSomma
        '
        Me.TxtBoxSomma.BackColor = System.Drawing.Color.White
        Me.TxtBoxSomma.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxSomma.Location = New System.Drawing.Point(181, 204)
        Me.TxtBoxSomma.Name = "TxtBoxSomma"
        Me.TxtBoxSomma.ReadOnly = True
        Me.TxtBoxSomma.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxSomma.TabIndex = 9
        Me.TxtBoxSomma.Visible = False
        '
        'TxtVersione
        '
        Me.TxtVersione.AutoSize = True
        Me.TxtVersione.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVersione.ForeColor = System.Drawing.Color.Black
        Me.TxtVersione.Location = New System.Drawing.Point(370, 378)
        Me.TxtVersione.Name = "TxtVersione"
        Me.TxtVersione.Size = New System.Drawing.Size(43, 21)
        Me.TxtVersione.TabIndex = 10
        Me.TxtVersione.Text = "1.1.1"
        '
        'TxtMin
        '
        Me.TxtMin.AutoSize = True
        Me.TxtMin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMin.ForeColor = System.Drawing.Color.Black
        Me.TxtMin.Location = New System.Drawing.Point(52, 237)
        Me.TxtMin.Name = "TxtMin"
        Me.TxtMin.Size = New System.Drawing.Size(123, 21)
        Me.TxtMin.TabIndex = 11
        Me.TxtMin.Text = "Il voto minimo è"
        Me.TxtMin.Visible = False
        '
        'TxtBoxMin
        '
        Me.TxtBoxMin.BackColor = System.Drawing.Color.White
        Me.TxtBoxMin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxMin.Location = New System.Drawing.Point(181, 237)
        Me.TxtBoxMin.Name = "TxtBoxMin"
        Me.TxtBoxMin.ReadOnly = True
        Me.TxtBoxMin.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxMin.TabIndex = 12
        Me.TxtBoxMin.Visible = False
        '
        'TxtMax
        '
        Me.TxtMax.AutoSize = True
        Me.TxtMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMax.ForeColor = System.Drawing.Color.Black
        Me.TxtMax.Location = New System.Drawing.Point(43, 270)
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(132, 21)
        Me.TxtMax.TabIndex = 13
        Me.TxtMax.Text = "Il voto massimo è"
        Me.TxtMax.Visible = False
        '
        'TxtBoxMax
        '
        Me.TxtBoxMax.BackColor = System.Drawing.Color.White
        Me.TxtBoxMax.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxMax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBoxMax.Location = New System.Drawing.Point(181, 270)
        Me.TxtBoxMax.Name = "TxtBoxMax"
        Me.TxtBoxMax.ReadOnly = True
        Me.TxtBoxMax.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxMax.TabIndex = 14
        Me.TxtBoxMax.Visible = False
        '
        'PulsanteReset
        '
        Me.PulsanteReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulsanteReset.Location = New System.Drawing.Point(314, 12)
        Me.PulsanteReset.Name = "PulsanteReset"
        Me.PulsanteReset.Size = New System.Drawing.Size(99, 23)
        Me.PulsanteReset.TabIndex = 15
        Me.PulsanteReset.Text = "Reimposta"
        Me.PulsanteReset.UseVisualStyleBackColor = True
        '
        'RadioChiaro
        '
        Me.RadioChiaro.AutoSize = True
        Me.RadioChiaro.Checked = True
        Me.RadioChiaro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioChiaro.ForeColor = System.Drawing.Color.Black
        Me.RadioChiaro.Location = New System.Drawing.Point(6, 24)
        Me.RadioChiaro.Name = "RadioChiaro"
        Me.RadioChiaro.Size = New System.Drawing.Size(59, 17)
        Me.RadioChiaro.TabIndex = 17
        Me.RadioChiaro.TabStop = True
        Me.RadioChiaro.Text = "Chiaro"
        Me.RadioChiaro.UseVisualStyleBackColor = True
        '
        'RadioScuro
        '
        Me.RadioScuro.AutoSize = True
        Me.RadioScuro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioScuro.ForeColor = System.Drawing.Color.Black
        Me.RadioScuro.Location = New System.Drawing.Point(6, 47)
        Me.RadioScuro.Name = "RadioScuro"
        Me.RadioScuro.Size = New System.Drawing.Size(54, 17)
        Me.RadioScuro.TabIndex = 18
        Me.RadioScuro.Text = "Scuro"
        Me.RadioScuro.UseVisualStyleBackColor = True
        '
        'RadioGiallo
        '
        Me.RadioGiallo.AutoSize = True
        Me.RadioGiallo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioGiallo.ForeColor = System.Drawing.Color.Black
        Me.RadioGiallo.Location = New System.Drawing.Point(6, 70)
        Me.RadioGiallo.Name = "RadioGiallo"
        Me.RadioGiallo.Size = New System.Drawing.Size(55, 17)
        Me.RadioGiallo.TabIndex = 19
        Me.RadioGiallo.Text = "Giallo"
        Me.RadioGiallo.UseVisualStyleBackColor = True
        '
        'GBoxTemi
        '
        Me.GBoxTemi.Controls.Add(Me.RadioChiaro)
        Me.GBoxTemi.Controls.Add(Me.RadioGiallo)
        Me.GBoxTemi.Controls.Add(Me.RadioScuro)
        Me.GBoxTemi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxTemi.Location = New System.Drawing.Point(333, 58)
        Me.GBoxTemi.Name = "GBoxTemi"
        Me.GBoxTemi.Size = New System.Drawing.Size(77, 100)
        Me.GBoxTemi.TabIndex = 20
        Me.GBoxTemi.TabStop = False
        Me.GBoxTemi.Text = "Tema"
        '
        'TxtSuff
        '
        Me.TxtSuff.AutoSize = True
        Me.TxtSuff.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuff.Location = New System.Drawing.Point(27, 302)
        Me.TxtSuff.Name = "TxtSuff"
        Me.TxtSuff.Size = New System.Drawing.Size(153, 21)
        Me.TxtSuff.TabIndex = 21
        Me.TxtSuff.Text = "I voti sufficienti sono"
        Me.TxtSuff.Visible = False
        '
        'TxtBoxSuff
        '
        Me.TxtBoxSuff.BackColor = System.Drawing.Color.White
        Me.TxtBoxSuff.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxSuff.Location = New System.Drawing.Point(181, 301)
        Me.TxtBoxSuff.Name = "TxtBoxSuff"
        Me.TxtBoxSuff.ReadOnly = True
        Me.TxtBoxSuff.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxSuff.TabIndex = 22
        Me.TxtBoxSuff.Visible = False
        '
        'TxtInsuff
        '
        Me.TxtInsuff.AutoSize = True
        Me.TxtInsuff.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInsuff.Location = New System.Drawing.Point(14, 335)
        Me.TxtInsuff.Name = "TxtInsuff"
        Me.TxtInsuff.Size = New System.Drawing.Size(166, 21)
        Me.TxtInsuff.TabIndex = 23
        Me.TxtInsuff.Text = "I voti insufficienti sono"
        Me.TxtInsuff.Visible = False
        '
        'TxtBoxInsuff
        '
        Me.TxtBoxInsuff.BackColor = System.Drawing.Color.White
        Me.TxtBoxInsuff.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxInsuff.Location = New System.Drawing.Point(181, 335)
        Me.TxtBoxInsuff.Name = "TxtBoxInsuff"
        Me.TxtBoxInsuff.ReadOnly = True
        Me.TxtBoxInsuff.Size = New System.Drawing.Size(66, 22)
        Me.TxtBoxInsuff.TabIndex = 24
        Me.TxtBoxInsuff.Visible = False
        '
        'CalcoloVoti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 442)
        Me.Controls.Add(Me.TxtBoxInsuff)
        Me.Controls.Add(Me.TxtInsuff)
        Me.Controls.Add(Me.TxtBoxSuff)
        Me.Controls.Add(Me.TxtSuff)
        Me.Controls.Add(Me.GBoxTemi)
        Me.Controls.Add(Me.PulsanteReset)
        Me.Controls.Add(Me.TxtBoxMax)
        Me.Controls.Add(Me.TxtMax)
        Me.Controls.Add(Me.TxtBoxMin)
        Me.Controls.Add(Me.TxtMin)
        Me.Controls.Add(Me.TxtVersione)
        Me.Controls.Add(Me.TxtBoxSomma)
        Me.Controls.Add(Me.TxtSomma)
        Me.Controls.Add(Me.TxtAutore)
        Me.Controls.Add(Me.TxtBoxMedia)
        Me.Controls.Add(Me.TxtMedia)
        Me.Controls.Add(Me.PulsanteVoti)
        Me.Controls.Add(Me.SelezAlunni)
        Me.Controls.Add(Me.TxtAlunni)
        Me.Controls.Add(Me.TxtTitolo)
        Me.Name = "CalcoloVoti"
        Me.Text = "CalcoloVoti"
        CType(Me.SelezAlunni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBoxTemi.ResumeLayout(False)
        Me.GBoxTemi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTitolo As Label
    Friend WithEvents TxtAlunni As Label
    Friend WithEvents SelezAlunni As NumericUpDown
    Friend WithEvents PulsanteVoti As Button
    Friend WithEvents TxtMedia As Label
    Friend WithEvents TxtBoxMedia As TextBox
    Friend WithEvents TxtAutore As Label
    Friend WithEvents TxtSomma As Label
    Friend WithEvents TxtBoxSomma As TextBox
    Friend WithEvents TxtVersione As Label
    Friend WithEvents TxtMin As Label
    Friend WithEvents TxtBoxMin As TextBox
    Friend WithEvents TxtMax As Label
    Friend WithEvents TxtBoxMax As TextBox
    Friend WithEvents PulsanteReset As Button
    Friend WithEvents RadioChiaro As RadioButton
    Friend WithEvents RadioScuro As RadioButton
    Friend WithEvents RadioGiallo As RadioButton
    Friend WithEvents GBoxTemi As GroupBox
    Friend WithEvents TxtSuff As Label
    Friend WithEvents TxtBoxSuff As TextBox
    Friend WithEvents TxtInsuff As Label
    Friend WithEvents TxtBoxInsuff As TextBox
End Class
