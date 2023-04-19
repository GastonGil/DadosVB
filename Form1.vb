Public Class Form1
    Dim Azar As Boolean = True
    Dim Contador As Integer = 0, CantidadDeJugadores As Integer, PrimeraVez As Boolean = True, ArrayNombresJugadores() As String

    Private Sub Cubilete_Click(sender As Object, e As EventArgs) Handles Cubilete.Click
        If PrimeraVez Then
            Dim FormIngresarCantidadJugadores As New CantidadJugadores
            FormIngresarCantidadJugadores.tCantidadJugadores.Text = "Ingrese la cantidad de jugadores"
            FormIngresarCantidadJugadores.ShowDialog()
            CantidadDeJugadores = Integer.Parse(FormIngresarCantidadJugadores.tCantidadJugadores.Text)
            ReDim ArrayNombresJugadores(CantidadDeJugadores)
            Dim i As Integer
            For i = 0 To CantidadDeJugadores - 1 Step 1
                Dim FormIngresarNombres As New NombresJugadores
                FormIngresarNombres.tNombreJugador.Text = "Ingrese el nombre del jugador: " & i + 1
                FormIngresarNombres.ShowDialog()
                ArrayNombresJugadores(i) = FormIngresarNombres.tNombreJugador.Text
            Next
            PrimeraVez = False
        End If

        If Contador = CantidadDeJugadores Then Contador = 0

        MessageBox.Show("Es el turno de: " & ArrayNombresJugadores(Contador), "A tirar los dados")
        Dim Num1, Num2, Num3, Num4, Num5 As Integer
        CambiarDado(Dado1, Num1)
        CambiarDado(Dado2, Num2)
        CambiarDado(Dado3, Num3)
        CambiarDado(Dado4, Num4)
        CambiarDado(Dado5, Num5)

        Dim SalioJugadaServida As Boolean
        MostrarMensajesDeJugadas(Num1, Num2, Num3, Num4, Num5, SalioJugadaServida)


       
        If SalioJugadaServida = False Then
            Dim X As Integer
            Dim CambiaDado1 As Boolean = True, CambiaDado2 As Boolean = True, CambiaDado3 As Boolean = True, CambiaDado4 As Boolean = True, CambiaDado5 As Boolean = True
            For X = 0 To 1 Step 1
                If MessageBox.Show("Guardas el valor del dado 1?", "Dado 1", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = DialogResult.Yes Then CambiaDado1 = False
                If MessageBox.Show("Guardas el valor del dado 2?", "Dado 2", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = DialogResult.Yes Then CambiaDado2 = False
                If MessageBox.Show("Guardas el valor del dado 3?", "Dado 3", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = DialogResult.Yes Then CambiaDado3 = False
                If MessageBox.Show("Guardas el valor del dado 4?", "Dado 4", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = DialogResult.Yes Then CambiaDado4 = False
                If MessageBox.Show("Guardas el valor del dado 5?", "Dado 5", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = DialogResult.Yes Then CambiaDado5 = False
                If CambiaDado1 Then CambiarDado(Dado1, Num1)
                If CambiaDado2 Then CambiarDado(Dado2, Num2)
                If CambiaDado3 Then CambiarDado(Dado3, Num3)
                If CambiaDado4 Then CambiarDado(Dado4, Num4)
                If CambiaDado5 Then CambiarDado(Dado5, Num5)

                MostrarMensajesDeJugadas(Num1, Num2, Num3, Num4, Num5, SalioJugadaServida)
            Next

        End If
        Contador += 1
    End Sub

    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function

    Sub CambiarImagenDado(ByRef DadoX As PictureBox, ByVal Num As Integer)
        Select Case Num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6
        End Select
    End Sub

    Sub CambiarTamaño(ByRef DadoX As PictureBox)
        DadoX.Size = New Size(94, 95)
        DadoX.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Sub CambiarDado(ByRef DadoX As PictureBox, ByRef Num As Integer)
        Num = NumDado(True)
        CambiarTamaño(DadoX)
        CambiarImagenDado(DadoX, Num)
    End Sub

    Function EsEscalera(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer) As Boolean
        Dim Numeros() As Integer = {num1, num2, num3, num4, num5}
        Dim I As Integer = 0, HayEscalera As Boolean
        Dim ArrayAVerificar = Numeros.Distinct().ToArray()

        If (Numeros.Length <> ArrayAVerificar.Length) Then
            HayEscalera = False
        Else
            I = 0
            Dim Hay1 As Boolean = False, Hay6 As Boolean = False
            For I = 0 To Numeros.Length - 1 Step 1
                If Numeros(I) = 1 Then Hay1 = True
                If Numeros(I) = 6 Then Hay6 = True
            Next
            If (Hay1 And Hay6) Then HayEscalera = False Else HayEscalera = True
        End If
        Return HayEscalera

    End Function

    Function EsPoker(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer) As Boolean
        Dim Numeros() As Integer = {num1, num2, num3, num4, num5}
        Dim ArrayAVerificar = Numeros.Distinct().ToArray()
        Dim HayPoker As Boolean
        HayPoker = IIf(ArrayAVerificar.Length = 1, True, False)
        Return HayPoker
    End Function

    Function EsFull(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer) As Boolean
        Dim Numeros() As Integer = {num1, num2, num3, num4, num5}
        Dim Contador As Integer = 0, I As Integer = 0, Posible1 As Integer, Posible2 As Integer = 0

        For I = 0 To Numeros.Length - 1 Step 1
            If I = 0 Then Posible1 = Numeros(I)
            If Posible2 = 0 Then
                If (Numeros(I) = Posible1) = False Then Posible2 = Numeros(I)
            End If
        Next
        Dim contadorPosible1 As Integer = 0, contadorPosible2 As Integer = 0
        For I = 0 To Numeros.Length - 1 Step 1
            If Posible1 = Numeros(I) Then contadorPosible1 += 1
            If Posible2 = Numeros(I) Then contadorPosible2 += 1
        Next

        Dim HayFull As Boolean
        HayFull = IIf((contadorPosible1 = 2 And contadorPosible2 = 3) Or (contadorPosible1 = 3 And contadorPosible2 = 2), True, False)
        Return HayFull
    End Function


    Function EsGenerala(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer) As Boolean
        Dim Numeros() As Integer = {num1, num2, num3, num4, num5}
        Dim ArrayAVerificar = Numeros.Distinct().ToArray()
        Dim HayGenerala As Boolean
        HayGenerala = IIf(ArrayAVerificar.Length = 0, True, False)
        Return HayGenerala
    End Function

    Function EsDobleGenerala(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer) As Boolean
        Dim Numeros() As Integer = {num1, num2, num3, num4, num5}
        Dim I As Integer = 0, Contador As Integer = 0
        For I = 0 To Numeros.Length - 1 Step 1
            If Numeros(I) = 1 Then Contador += 1
        Next

        Dim HayGeneralaDoble As Boolean
        HayGeneralaDoble = IIf(Contador = 5, True, False)
        Return HayGeneralaDoble
    End Function

    Sub MostrarMensajesDeJugadas(Num1 As Integer, Num2 As Integer, Num3 As Integer, Num4 As Integer, Num5 As Integer, ByRef Salio As Boolean)
        Salio = False
        If EsEscalera(Num1, Num2, Num3, Num4, Num5) Then
            MessageBox.Show("Hiciste Escalera", "Felicitaciones")
            Salio = True
        End If
        If EsPoker(Num1, Num2, Num3, Num4, Num5) Then
            MessageBox.Show("Hiciste Poker", "Felicitaciones")
            Salio = True
        End If
        If EsFull(Num1, Num2, Num3, Num4, Num5) Then
            MessageBox.Show("Hiciste Full", "Felicitaciones")
            Salio = True
        End If
        If EsGenerala(Num1, Num2, Num3, Num4, Num5) Then
            MessageBox.Show("Hiciste Generala", "Felicitaciones")
            Salio = True
        End If
        If EsDobleGenerala(Num1, Num2, Num3, Num4, Num5) Then
            MessageBox.Show("Hiciste Doble Generala", "Felicitaciones")
            Salio = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim monto As Decimal = 1000
    '    Dim IVA As Decimal = 0, IIBB As Decimal = 0, Interes1 As Decimal = 0
    '    CalculaValores(monto, IVA, IIBB, Interes1)
    '    MessageBox.Show("monto: " & monto & ", IVA: " & IVA & ", IIBB: " & IIBB & ", Interes1: " & Interes1)
    'End Sub

    ''Sub CalculaValores(MontoX As Decimal, ByRef IVA As Decimal, ByRef IB As Decimal, ByRef Interes1 As Decimal)
    ''    IVA = MontoX * 21 / 100
    ''    IB = MontoX * 3 / 100
    ''    Interes1 = MontoX * 5 / 100
    ''End Sub
End Class
