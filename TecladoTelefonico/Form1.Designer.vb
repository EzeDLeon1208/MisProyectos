<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NumTxt = New System.Windows.Forms.TextBox()
        Me.LetTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LetLab = New System.Windows.Forms.Label()
        Me.NumLab = New System.Windows.Forms.Label()
        Me.BtnM1 = New System.Windows.Forms.Button()
        Me.BtnM2 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumTxt
        '
        Me.NumTxt.Location = New System.Drawing.Point(39, 100)
        Me.NumTxt.Name = "NumTxt"
        Me.NumTxt.Size = New System.Drawing.Size(100, 20)
        Me.NumTxt.TabIndex = 0
        '
        'LetTxt
        '
        Me.LetTxt.Location = New System.Drawing.Point(256, 100)
        Me.LetTxt.Name = "LetTxt"
        Me.LetTxt.Size = New System.Drawing.Size(100, 20)
        Me.LetTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Letra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Letras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero"
        '
        'LetLab
        '
        Me.LetLab.Location = New System.Drawing.Point(39, 230)
        Me.LetLab.Name = "LetLab"
        Me.LetLab.Size = New System.Drawing.Size(100, 23)
        Me.LetLab.TabIndex = 6
        Me.LetLab.Text = "-"
        Me.LetLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumLab
        '
        Me.NumLab.Location = New System.Drawing.Point(257, 230)
        Me.NumLab.Name = "NumLab"
        Me.NumLab.Size = New System.Drawing.Size(100, 23)
        Me.NumLab.TabIndex = 7
        Me.NumLab.Text = "-"
        Me.NumLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnM1
        '
        Me.BtnM1.Location = New System.Drawing.Point(39, 296)
        Me.BtnM1.Name = "BtnM1"
        Me.BtnM1.Size = New System.Drawing.Size(100, 50)
        Me.BtnM1.TabIndex = 8
        Me.BtnM1.Text = "Mostrar"
        Me.BtnM1.UseVisualStyleBackColor = True
        '
        'BtnM2
        '
        Me.BtnM2.Location = New System.Drawing.Point(256, 296)
        Me.BtnM2.Name = "BtnM2"
        Me.BtnM2.Size = New System.Drawing.Size(100, 50)
        Me.BtnM2.TabIndex = 9
        Me.BtnM2.Text = "Mostrar"
        Me.BtnM2.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(381, 393)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 50)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(147, 393)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(100, 50)
        Me.BtnBorrar.TabIndex = 11
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 457)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnM2)
        Me.Controls.Add(Me.BtnM1)
        Me.Controls.Add(Me.NumLab)
        Me.Controls.Add(Me.LetLab)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LetTxt)
        Me.Controls.Add(Me.NumTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumTxt As TextBox
    Friend WithEvents LetTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LetLab As Label
    Friend WithEvents NumLab As Label
    Friend WithEvents BtnM1 As Button
    Friend WithEvents BtnM2 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnBorrar As Button
End Class
