Public Class RangoIds
    Private Sub RangoIds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer el texto predeterminado en los textBoxes
        jt_desde.Text = "Desde"
        jt_hasta.Text = "Hasta"

        ' Centrar el texto en los textBoxes
        jt_desde.TextAlign = HorizontalAlignment.Center
        jt_hasta.TextAlign = HorizontalAlignment.Center

        jt_desde.ForeColor = Color.FromArgb(150, 150, 150)
        jt_hasta.ForeColor = Color.FromArgb(150, 150, 150)
    End Sub

    Private Sub jt_desde_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles jt_desde.Enter
        If jt_desde.Text = "Desde" Then
            jt_desde.Text = ""
        End If
    End Sub

    Private Sub jt_desde_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles jt_desde.Leave
        If jt_desde.Text = "" Then
            jt_desde.Text = "Desde"
        End If
    End Sub

    Private Sub jt_hasta_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles jt_hasta.Enter
        If jt_hasta.Text = "Hasta" Then
            jt_hasta.Text = ""
        End If
    End Sub

    Private Sub jt_hasta_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles jt_hasta.Leave
        If jt_hasta.Text = "" Then
            jt_hasta.Text = "Hasta"
        End If
    End Sub

    Private Sub jt_desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jt_desde.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub jt_hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jt_hasta.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub jt_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles jt_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_aceptar.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Function ValidarInputs() As Boolean
        ' Verificar que se haya ingresado un valor en ambos textBox
        If String.IsNullOrWhiteSpace(jt_desde.Text) OrElse String.IsNullOrWhiteSpace(jt_hasta.Text) Then
            MessageBox.Show("Debe ingresar un valor en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Verificar que el valor de jt_desde sea menor o igual al valor de jt_hasta
        Dim valorDesde As Integer
        Dim valorHasta As Integer
        If Not Integer.TryParse(jt_desde.Text, valorDesde) OrElse Not Integer.TryParse(jt_hasta.Text, valorHasta) Then
            MessageBox.Show("Debe ingresar números enteros válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If valorDesde > valorHasta Then
            MessageBox.Show("El valor de 'Desde' debe ser menor o igual al valor de 'Hasta'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Si se han pasado todas las validaciones, devolver True
        Return True
    End Function

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If ValidarInputs() Then
            ' Cerrar el formulario para que los valores se puedan utilizar en otro formulario
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class