<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CantidadJugadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bConfirmar = New System.Windows.Forms.Button()
        Me.tCantidadJugadores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bConfirmar
        '
        Me.bConfirmar.AutoSize = True
        Me.bConfirmar.Location = New System.Drawing.Point(546, 57)
        Me.bConfirmar.Name = "bConfirmar"
        Me.bConfirmar.Size = New System.Drawing.Size(88, 30)
        Me.bConfirmar.TabIndex = 0
        Me.bConfirmar.Text = "Confirmar"
        Me.bConfirmar.UseVisualStyleBackColor = True
        '
        'tCantidadJugadores
        '
        Me.tCantidadJugadores.Location = New System.Drawing.Point(42, 57)
        Me.tCantidadJugadores.Name = "tCantidadJugadores"
        Me.tCantidadJugadores.Size = New System.Drawing.Size(477, 26)
        Me.tCantidadJugadores.TabIndex = 1
        '
        'CantidadJugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 145)
        Me.ControlBox = False
        Me.Controls.Add(Me.tCantidadJugadores)
        Me.Controls.Add(Me.bConfirmar)
        Me.Name = "CantidadJugadores"
        Me.Text = "Ingresar la cantidad de Jugadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bConfirmar As Button
    Friend WithEvents tCantidadJugadores As TextBox
End Class
