Public Class CalcoloVoti

    Public Sub SelezAlunni_ValueChanged(sender As Object, e As EventArgs) Handles SelezAlunni.ValueChanged
        PulsanteVoti.Visible = True 'rende visibile il pulsante per inserire i voti dopo aver inserito il numero di alunni
    End Sub

    Public Sub PulsanteVoti_Click(sender As Object, e As EventArgs) Handles PulsanteVoti.Click

        'Dichiarazione variabili
        Dim NumAlunni As Integer = Convert.ToInt32(SelezAlunni.Value)
        Dim SommaVoti As Integer = 0
        Dim MediaVoti As Double
        Dim VotoMax As Integer
        Dim VotoMin As Integer = 10
        Dim NumVoti(NumAlunni) As Integer
        Dim v As Integer
        Dim Suff As Integer = 0
        Dim Insuff As Integer = 0

        'Inserimento dei voti
        For v = 1 To NumAlunni
            NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
            Do
                'Controllo sul numero inserito
                If NumVoti(NumAlunni) > 10 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                ElseIf NumVoti(NumAlunni) < 1 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                End If

                'Determinazione voto minimo e massimo
                If NumVoti(NumAlunni) < VotoMin Then
                    VotoMin = NumVoti(NumAlunni)
                ElseIf NumVoti(NumAlunni) > VotoMax Then
                    VotoMax = NumVoti(NumAlunni)
                End If

                'Determinazione voti sufficienti e insufficienti
                If NumVoti(NumAlunni) >= 6 Then
                    Suff = Suff + 1
                Else
                    Insuff = Insuff + 1
                End If
            Loop Until NumVoti(NumAlunni) >= 1 & NumVoti(NumAlunni) <= 10
            SommaVoti = SommaVoti + NumVoti(NumAlunni) 'calcolo della somma
        Next v
        MediaVoti = Math.Round(SommaVoti / NumAlunni, 2, MidpointRounding.AwayFromZero) 'calcolo della media

        'Visualizzazione dei risultati
        TxtMedia.Visible = True
        TxtBoxMedia.Text = MediaVoti
        TxtBoxMedia.Visible = True
        TxtSomma.Visible = True
        TxtBoxSomma.Text = SommaVoti
        TxtBoxSomma.Visible = True
        TxtMin.Visible = True
        TxtBoxMin.Text = VotoMin
        TxtBoxMin.Visible = True
        TxtMax.Visible = True
        TxtBoxMax.Text = VotoMax
        TxtBoxMax.Visible = True
        TxtSuff.Visible = True
        TxtBoxSuff.Visible = True
        TxtBoxSuff.Text = Suff
        TxtInsuff.Visible = True
        TxtBoxInsuff.Visible = True
        TxtBoxInsuff.Text = Insuff
    End Sub

    Private Sub PulsanteReset_Click(sender As Object, e As EventArgs) Handles PulsanteReset.Click

        'Reimpostazione
        SelezAlunni.Value = 0
        PulsanteVoti.Visible = False
        TxtMedia.Visible = False
        TxtBoxMedia.Visible = False
        TxtBoxMedia.Text = 0
        TxtSomma.Visible = False
        TxtBoxSomma.Visible = False
        TxtBoxSomma.Text = 0
        TxtMin.Visible = False
        TxtBoxMin.Visible = False
        TxtBoxMin.Text = 0
        TxtMax.Visible = False
        TxtBoxMax.Visible = False
        TxtBoxMax.Text = 0
        TxtSuff.Visible = False
        TxtBoxSuff.Visible = False
        TxtBoxSuff.Text = 0
        TxtInsuff.Visible = False
        TxtBoxInsuff.Visible = False
        TxtBoxInsuff.Text = 0
    End Sub

    Private Sub RadioChiaro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioChiaro.CheckedChanged
        If RadioChiaro.Checked = True Then
            Me.BackColor = Color.White
            TxtTitolo.ForeColor = Color.Black
            TxtAlunni.ForeColor = Color.Black
            TxtMedia.ForeColor = Color.Black
            TxtSomma.ForeColor = Color.Black
            TxtMax.ForeColor = Color.Black
            TxtMin.ForeColor = Color.Black
            GBoxTemi.ForeColor = Color.Black
            TxtVersione.ForeColor = Color.Black
            TxtAutore.ForeColor = Color.Black
            TxtSuff.ForeColor = Color.Black
            TxtInsuff.ForeColor = Color.Black
            RadioChiaro.ForeColor = Color.Black
            RadioScuro.ForeColor = Color.Black
            RadioGiallo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioScuro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioScuro.CheckedChanged
        If RadioScuro.Checked = True Then
            Me.BackColor = Color.Black
            TxtTitolo.ForeColor = Color.White
            TxtAlunni.ForeColor = Color.White
            TxtMedia.ForeColor = Color.White
            TxtSomma.ForeColor = Color.White
            TxtMax.ForeColor = Color.White
            TxtMin.ForeColor = Color.White
            GBoxTemi.ForeColor = Color.White
            TxtVersione.ForeColor = Color.White
            TxtAutore.ForeColor = Color.White
            TxtSuff.ForeColor = Color.White
            TxtInsuff.ForeColor = Color.White
            RadioChiaro.ForeColor = Color.White
            RadioScuro.ForeColor = Color.White
            RadioGiallo.ForeColor = Color.White
        End If
    End Sub

    Private Sub RadioVerde_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGiallo.CheckedChanged
        If RadioGiallo.Checked = True Then
            Me.BackColor = Color.Black
            TxtTitolo.ForeColor = Color.Yellow
            TxtAlunni.ForeColor = Color.Yellow
            TxtMedia.ForeColor = Color.Yellow
            TxtSomma.ForeColor = Color.Yellow
            TxtMax.ForeColor = Color.Yellow
            TxtMin.ForeColor = Color.Yellow
            GBoxTemi.ForeColor = Color.Yellow
            TxtVersione.ForeColor = Color.Yellow
            TxtAutore.ForeColor = Color.Yellow
            TxtSuff.ForeColor = Color.Yellow
            TxtInsuff.ForeColor = Color.Yellow
            RadioChiaro.ForeColor = Color.Yellow
            RadioScuro.ForeColor = Color.Yellow
            RadioGiallo.ForeColor = Color.Yellow
        End If
    End Sub
End Class

