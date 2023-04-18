<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NombresJugadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tNombreJugador = New System.Windows.Forms.TextBox()
        Me.bIngresarNombre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tNombreJugador
        '
        Me.tNombreJugador.Location = New System.Drawing.Point(37, 50)
        Me.tNombreJugador.Name = "tNombreJugador"
        Me.tNombreJugador.Size = New System.Drawing.Size(413, 26)
        Me.tNombreJugador.TabIndex = 0
        Me.tNombreJugador.Text = "Ingrese el nombre del Jugador"
        '
        'bIngresarNombre
        '
        Me.bIngresarNombre.AutoSize = True
        Me.bIngresarNombre.Location = New System.Drawing.Point(511, 48)
        Me.bIngresarNombre.Name = "bIngresarNombre"
        Me.bIngresarNombre.Size = New System.Drawing.Size(78, 30)
        Me.bIngresarNombre.TabIndex = 1
        Me.bIngresarNombre.Text = "Ingresar"
        Me.bIngresarNombre.UseVisualStyleBackColor = True
        '
        'NombresJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 117)
        Me.ControlBox = False
        Me.Controls.Add(Me.bIngresarNombre)
        Me.Controls.Add(Me.tNombreJugador)
        Me.Name = "NombresJugadores"
        Me.Text = "Ingresar Nombres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tNombreJugador As TextBox
    Friend WithEvents bIngresarNombre As Button
End Class
