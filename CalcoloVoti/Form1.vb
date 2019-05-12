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
        Dim v As Integer = 1
        'Inserimento dei voti
        For v = 1 To NumAlunni
            NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
            Do
                'Controllo sul numero inserito
                If NumVoti(NumAlunni) < 1 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                ElseIf NumVoti(NumAlunni) > 10 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                ElseIf NumVoti(NumAlunni) = Nothing Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                End If
                'Determinazione voto minimo e massimo
                If NumVoti(NumAlunni) < VotoMin Then
                    VotoMin = NumVoti(NumAlunni)
                ElseIf NumVoti(NumAlunni) > VotoMax Then
                    VotoMax = NumVoti(NumAlunni)
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
            TxtTema.ForeColor = Color.Black
            TxtVersione.ForeColor = Color.Black
            TxtAutore.ForeColor = Color.Black
            RadioChiaro.ForeColor = Color.Black
            RadioScuro.ForeColor = Color.Black
            RadioVerde.ForeColor = Color.Black
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
            TxtTema.ForeColor = Color.White
            TxtVersione.ForeColor = Color.White
            TxtAutore.ForeColor = Color.White
            RadioChiaro.ForeColor = Color.White
            RadioScuro.ForeColor = Color.White
            RadioVerde.ForeColor = Color.White
        End If
    End Sub

    Private Sub RadioVerde_CheckedChanged(sender As Object, e As EventArgs) Handles RadioVerde.CheckedChanged
        If RadioVerde.Checked = True Then
            Me.BackColor = Color.Black
            TxtTitolo.ForeColor = Color.GreenYellow
            TxtAlunni.ForeColor = Color.GreenYellow
            TxtMedia.ForeColor = Color.GreenYellow
            TxtSomma.ForeColor = Color.GreenYellow
            TxtMax.ForeColor = Color.GreenYellow
            TxtMin.ForeColor = Color.GreenYellow
            TxtTema.ForeColor = Color.GreenYellow
            TxtVersione.ForeColor = Color.GreenYellow
            TxtAutore.ForeColor = Color.GreenYellow
            RadioChiaro.ForeColor = Color.GreenYellow
            RadioScuro.ForeColor = Color.GreenYellow
            RadioVerde.ForeColor = Color.GreenYellow
        End If
    End Sub
End Class

