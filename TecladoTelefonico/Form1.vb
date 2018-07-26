Public Class Form1
    Private Sub BtnM1_Click(sender As Object, e As EventArgs) Handles BtnM1.Click
        Dim num As Double

        If IsNumeric(NumTxt.Text) = True Then
            num = Convert.ToDouble(NumTxt.Text)
            Select Case num
                Case 2
                    LetLab.Text = "A B C"
                Case 3
                    LetLab.Text = "D E F"
                Case 4
                    LetLab.Text = "G H I"
                Case 5
                    LetLab.Text = "J K L"
                Case 6
                    LetLab.Text = "M N O"
                Case 7
                    LetLab.Text = "P Q R S"
                Case 8
                    LetLab.Text = "T U V"
                Case 9
                    LetLab.Text = "W X Y Z"
                Case Else
                    MessageBox.Show("numero no aceptado")
            End Select
        Else
            MessageBox.Show("No puedes ingresar letras, por favor ingresar numeros")
            NumTxt.Clear()
        End If
    End Sub

    Private Sub BtnM2_Click(sender As Object, e As EventArgs) Handles BtnM2.Click
        Dim L As String

        If Not IsNumeric(LetTxt.Text) = True Then
            L = Convert.ToString(LetTxt.Text)
            Select Case L
                Case "A", "B", "C"
                    NumLab.Text = "2"
                Case "D", "E", "F"
                    NumLab.Text = "3"
                Case "G", "H", "I"
                    NumLab.Text = "4"
                Case "J", "K", "L"
                    NumLab.Text = "5"
                Case "M", "N", "O"
                    NumLab.Text = "6"
                Case "P", "Q", "R", "S"
                    NumLab.Text = "7"
                Case "T", "U", "V"
                    NumLab.Text = "8"
                Case "W", "X", "Y", "Z"
                    NumLab.Text = "9"
                Case Else
                    MessageBox.Show("no se aceptan numeros, ingresar letras")
            End Select
        Else
            MessageBox.Show("Caracter no aceptado, por favor ingresar numeros")
            LetTxt.Clear()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea salir del programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True

        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        NumTxt.Clear()
        LetTxt.Clear()
        LetLab.Text = ""
        NumLab.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
