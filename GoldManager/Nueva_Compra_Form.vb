Imports MySql.Data.MySqlClient
Public Class Nueva_Compra_Form
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00010.hostgator.co;user=carl1020_adminas;password=Safrat2583;database=carl1020_goldbyzantina;port=3306")


    Public Event NuevaCompraIngresada(sender As Object, e As EventArgs)
    Private Sub jt_compra_it_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_compra_it.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If jt_compra_it.Text.Length >= 8 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub jt_compra_nac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_compra_nac.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If jt_compra_nac.Text.Length >= 8 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_crear_compra_Click(sender As Object, e As EventArgs) Handles btn_crear_compra.Click

        If jt_compra_it.Text.Trim() = "" And jt_compra_nac.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el valor del gramo Italy y Nacional.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra_it.Focus()
            Exit Sub
        End If

        If jt_compra_it.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el valor del gramo Italy.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra_it.Focus()
            Exit Sub
        End If

        If jt_compra_nac.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el valor del gramo Nacional.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra_nac.Focus()
            Exit Sub
        End If

        Dim valorItaly As Decimal = Convert.ToDecimal(jt_compra_it.Text)
        Dim valorNacional As Decimal = Convert.ToDecimal(jt_compra_nac.Text)

        'Validar que ambos no sean 0
        If valorItaly = 0 And valorNacional = 0 Then
            MessageBox.Show("El valor del gramo no puede ser 0 para ambos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra_it.Focus()
            Exit Sub
        End If

        ' Verificar que estás conectado a la base de datos antes de intentar la inserción.
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Try
            ' Construir la consulta SQL para la inserción en la tabla "compra"
            Dim query As String = "INSERT INTO compra (estado, valor_gr_nac, valor_gr_it) VALUES (@estado, @valor_gr_nac, @valor_gr_it)"
            Dim cmd As New MySqlCommand(query, conexion)

            ' Establecer los valores para los parámetros @
            cmd.Parameters.AddWithValue("@estado", "ABIERTA")
            cmd.Parameters.AddWithValue("@valor_gr_nac", Convert.ToDecimal(jt_compra_nac.Text))
            cmd.Parameters.AddWithValue("@valor_gr_it", Convert.ToDecimal(jt_compra_it.Text))

            ' Ejecutar la consulta de inserción
            cmd.ExecuteNonQuery()

            MessageBox.Show("Compra agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RaiseEvent NuevaCompraIngresada(Me, EventArgs.Empty)
            jt_compra_it.Clear()
            jt_compra_nac.Clear()
            jt_compra_it.Focus()

            'Tab_Consultar_Click(Nothing, Nothing)
            '' Notificar al TabPage1 que se ha realizado una inserción
            'RaiseEvent NuevaInsercionRealizada()

        Catch ex As Exception
            MessageBox.Show("Error al agregar compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try

        'Dim query As String = "INSERT INTO compra (nom bre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, ct, sucursal, broche, vbroche, referencia, idcompra) VALUES (@nombre, @marca, @cantidad, @peso, @peso_total, @categoria_producto, @valor_unitario, @costo_total, @valor_gramo, @valor_unitario_compra, @ct, @idsucursal, @broche, @vbroche, @referencia, @idcompra)"
        'Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
        '    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(jt_peso.Text))
        '    cmd.Parameters.AddWithValue("@peso_total", Convert.ToDecimal(jt_peso_total.Text))
    End Sub

    Private Sub btn_cancelar_compra_Click(sender As Object, e As EventArgs) Handles btn_cancelar_compra.Click
        Me.Close()
    End Sub
End Class