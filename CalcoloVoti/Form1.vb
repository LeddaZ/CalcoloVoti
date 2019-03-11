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

    Private Sub TxtMedia_Click(sender As Object, e As EventArgs) Handles TxtMedia.Click

    End Sub
End Class
