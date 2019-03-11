Public Class CalcoloVoti

    Public Sub SelezAlunni_ValueChanged(sender As Object, e As EventArgs) Handles SelezAlunni.ValueChanged
        PulsanteVoti.Visible = True
    End Sub

    Public Sub PulsanteVoti_Click(sender As Object, e As EventArgs) Handles PulsanteVoti.Click
        Dim NumAlunni As Integer = Convert.ToInt32(SelezAlunni.Value)
        Dim SommaVoti As Integer = 0
        Dim MediaVoti As Double
        Dim NumVoti(NumAlunni) As Integer
        Dim v As Integer = 1
        For v = 1 To NumAlunni
            NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
            Do
                If NumVoti(NumAlunni) < 1 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                End If
                If NumVoti(NumAlunni) > 10 Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                End If
                If NumVoti(NumAlunni) = Nothing Then
                    MsgBox("Il numero inserito non è valido. Inserire un numero intero compreso tra 1 e 10 inclusi.", MsgBoxStyle.Critical, "Errore")
                    NumVoti(NumAlunni) = InputBox("Inserisci il voto del " & v & "° alunno", "Inserimento voti")
                End If
            Loop Until NumVoti(NumAlunni) >= 1 & NumVoti(NumAlunni) <= 10
            SommaVoti = SommaVoti + NumVoti(NumAlunni)
        Next v
        MediaVoti = Math.Round(SommaVoti / NumAlunni, 2, MidpointRounding.AwayFromZero)
        TxtMedia.Visible = True
        TxtBoxMedia.Text = MediaVoti
        TxtBoxMedia.Visible = True
        TxtSomma.Visible = True
        TxtBoxSomma.Text = SommaVoti
        TxtBoxSomma.Visible = True
    End Sub

End Class
