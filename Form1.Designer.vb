<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado1 = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        Me.Dado3 = New System.Windows.Forms.PictureBox()
        Me.Dado4 = New System.Windows.Forms.PictureBox()
        Me.Dado5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(476, 12)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(304, 277)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado1
        '
        Me.Dado1.BackgroundImage = Global.Dados.My.Resources.Resources.dado6
        Me.Dado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dado1.Location = New System.Drawing.Point(89, 104)
        Me.Dado1.Name = "Dado1"
        Me.Dado1.Size = New System.Drawing.Size(94, 95)
        Me.Dado1.TabIndex = 2
        Me.Dado1.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.BackgroundImage = Global.Dados.My.Resources.Resources.dado6
        Me.Dado2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dado2.Location = New System.Drawing.Point(376, 58)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(94, 95)
        Me.Dado2.TabIndex = 3
        Me.Dado2.TabStop = False
        '
        'Dado3
        '
        Me.Dado3.BackgroundImage = Global.Dados.My.Resources.Resources.dado6
        Me.Dado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dado3.Location = New System.Drawing.Point(260, 218)
        Me.Dado3.Name = "Dado3"
        Me.Dado3.Size = New System.Drawing.Size(94, 95)
        Me.Dado3.TabIndex = 4
        Me.Dado3.TabStop = False
        '
        'Dado4
        '
        Me.Dado4.BackgroundImage = Global.Dados.My.Resources.Resources.dado6
        Me.Dado4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dado4.Location = New System.Drawing.Point(104, 379)
        Me.Dado4.Name = "Dado4"
        Me.Dado4.Size = New System.Drawing.Size(94, 95)
        Me.Dado4.TabIndex = 5
        Me.Dado4.TabStop = False
        '
        'Dado5
        '
        Me.Dado5.BackgroundImage = Global.Dados.My.Resources.Resources.dado6
        Me.Dado5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dado5.Location = New System.Drawing.Point(424, 356)
        Me.Dado5.Name = "Dado5"
        Me.Dado5.Size = New System.Drawing.Size(94, 95)
        Me.Dado5.TabIndex = 6
        Me.Dado5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dado 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dado 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Dado 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Dado 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Dado 5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dados.My.Resources.Resources.mesa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dado5)
        Me.Controls.Add(Me.Dado4)
        Me.Controls.Add(Me.Dado3)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado1)
        Me.Controls.Add(Me.Cubilete)
        Me.Name = "Form1"
        Me.Text = "Apretá el Cubilete para tirar los dados"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado1 As PictureBox
    Friend WithEvents Dado2 As PictureBox
    Friend WithEvents Dado3 As PictureBox
    Friend WithEvents Dado4 As PictureBox
    Friend WithEvents Dado5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
