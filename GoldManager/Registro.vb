Imports System.IO
Imports System.Text
Imports ClosedXML.Excel
Imports GoldManager.GoldManager
Imports MySql.Data.MySqlClient
Imports DataTable = System.Data.DataTable

Public Class Registro
    Dim camposValidados As Boolean
    Dim CamposPircingValidados As Boolean
    Dim conn As MySql.Data.MySqlClient.MySqlConnection
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00002.hostgator.co;user=cdcbfeba_adminelite;password=Safrat2583;database=cdcbfeba_goldmanagerelite;port=3306")
    '("server=shared20.hostgator.co;user=elitejo1_adminelite;password=Safrat2583;database=elitejo1_goldmanagerelite;port=3306")

    'Evento personalizado
    Public Event NuevaInsercionRealizada()


    Public Function ObtenerEstadoCompraPorID(idCompra As Integer) As String
        Dim estado As String = ""
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            ' Realiza una consulta a la base de datos para obtener el estado de la compra por su ID.
            Dim query As String = "SELECT estado FROM compra WHERE id = @id"
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@id", idCompra)
                estado = CStr(cmd.ExecuteScalar())
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al obtener el estado de la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State <> ConnectionState.Closed Then
                conexion.Close()
            End If
        End Try

        Return estado
    End Function
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        tb_precios.Columns.Cast(Of DataGridViewColumn)().ToList().ForEach(Sub(c) c.SortMode = DataGridViewColumnSortMode.NotSortable)
        tb_productos.Columns.Cast(Of DataGridViewColumn)().ToList().ForEach(Sub(c) c.SortMode = DataGridViewColumnSortMode.NotSortable)
        tb_compras.Columns.Cast(Of DataGridViewColumn)().ToList().ForEach(Sub(c) c.SortMode = DataGridViewColumnSortMode.NotSortable)
        tb_compras.AllowUserToResizeColumns = False
        tb_compras.AllowUserToResizeRows = False
        tb_compras.RowHeadersVisible = False


        Dim widths() As Integer = {80, 80, 500, 50, 60, 50, 80, 70, 100, 100, 100, 110, 50, 110}
        For i As Integer = 0 To tb_productos.Columns.Count - 1
            tb_productos.Columns(i).Width = widths(i)
        Next
        tb_productos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        lst_marca_tabla.SelectedIndex = 0
        jt_nombre_compuesto.Text = ""
        Try
            conexion.Open()

            ' Cargar los valores de la tabla compra en el ComboBox lst_compra_consulta
            Dim query_compras_consulta As String = "SELECT id FROM compra ORDER BY id DESC LIMIT 20"
            Dim cmd_compras_consulta As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_compras_consulta, conexion)
            Dim reader_compras_consulta As MySql.Data.MySqlClient.MySqlDataReader = cmd_compras_consulta.ExecuteReader()
            While reader_compras_consulta.Read()
                lst_compra_consulta.Items.Add(reader_compras_consulta.GetString(0))
            End While
            reader_compras_consulta.Close()
            ' Cargar los valores de la tabla tiposdeproducto en el ComboBox lst_tipo_producto
            Dim query_tipos As String = "SELECT tipo FROM tiposdeproducto"
            Dim cmd_tipos As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_tipos, conexion)
            Dim reader_tipos As MySql.Data.MySqlClient.MySqlDataReader = cmd_tipos.ExecuteReader()
            While reader_tipos.Read()
                lst_tipo_producto.Items.Add(reader_tipos.GetString(0))
            End While
            lst_tipo_producto.SelectedItem = "Seleccione"
            reader_tipos.Close()

            ' Cargar los valores de la tabla broches en el ComboBox lst_broche
            Dim query_broches As String = "SELECT peso_broche FROM broches_new"
            Dim cmd_broches As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_broches, conexion)
            Dim reader_broches As MySql.Data.MySqlClient.MySqlDataReader = cmd_broches.ExecuteReader()
            While reader_broches.Read()
                lst_broche.Items.Add(reader_broches.GetDecimal(0))
            End While
            lst_broche.Items.Insert(0, "Seleccione")
            lst_broche.SelectedIndex = 0
            'lst_broche.SelectedItem = "Seleccione"
            reader_broches.Close()
            '-------------------------------------------------------------------------------------------------------------
            ' Cargar los valores de la tabla sucursales en el ComboBox lst_sucursal
            Dim query_sucursal As String = "SELECT nombresucursal FROM sucursales"
            Dim cmd_sucursal As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_sucursal, conexion)
            Dim reader_sucursal As MySql.Data.MySqlClient.MySqlDataReader = cmd_sucursal.ExecuteReader()
            While reader_sucursal.Read()
                lst_sucursall.Items.Add(reader_sucursal.GetString(0))
            End While
            lst_sucursall.Items.Insert(0, "Seleccione")
            lst_sucursall.SelectedIndex = 0
            reader_sucursal.Close()
            '-------------------------------------------------------------------------------------------------------------

        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function CalcularValorBroche(pesoBroche As Double) As Integer
        Dim valorBroche As Integer = 0
        Try
            conexion.Open()
            Dim query As String = "SELECT precio_broche FROM broches_new WHERE peso_broche = @pesoBroche"
            Dim cmd As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@pesoBroche", pesoBroche)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                valorBroche = reader.GetInt32(0)
            Else
                MessageBox.Show("No se encontró ningún valor de broche para el peso proporcionado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al calcular valor del broche: " + ex.Message)
        Finally
            conexion.Close()
        End Try
        Return valorBroche
    End Function
    Private Function ObtenerValorGamoNacional(peso As Decimal, categoriaPrecio As String)
        If jt_peso.Text = "" Or lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            Return 0
        End If
        Dim query As String = "SELECT valor FROM gramonacional_new WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
        cmd.Parameters.AddWithValue("@peso", peso)
        cmd.Parameters.AddWithValue("@categoria_precio", categoriaPrecio)
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
        Dim valorGamo As Decimal = 0

        If reader.Read() Then
            valorGamo = reader.GetDecimal(0)

        End If
        reader.Close()
        conexion.Close()
        Return valorGamo
    End Function
    Private Function ObtenerValorGramoItaly(peso As Decimal, categoriaPrecio As String) As Decimal
        If jt_peso.Text = "" Or lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            Return 0
        End If
        Dim query As String = "SELECT valor FROM gramoitaly_new WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
        cmd.Parameters.AddWithValue("@peso", peso)
        cmd.Parameters.AddWithValue("@categoria_precio", categoriaPrecio)
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
        Dim valorGamo As Decimal = 0
        If reader.Read() Then
            valorGamo = reader.GetDecimal(0)
        End If
        reader.Close()
        conexion.Close()
        Return valorGamo
    End Function
    Private Function ObtenerCtNacional(peso As Decimal, categoriaPrecio As String) As String
        If jt_peso.Text = "" Or lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            Return ""
        End If

        Dim query As String = "SELECT ct FROM gramonacional_new WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
        cmd.Parameters.AddWithValue("@peso", peso)
        cmd.Parameters.AddWithValue("@categoria_precio", categoriaPrecio)

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
        Dim ct As String = ""

        If reader.Read() Then
            ct = reader.GetString(0)
        End If

        reader.Close()
        conexion.Close()

        Return ct
    End Function
    Private Function ObtenerCtItaly(peso As Decimal, categoriaPrecio As String) As String
        If jt_peso.Text = "" Or lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            Return ""
        End If

        Dim query As String = "SELECT ct FROM gramoitaly_new WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
        Dim cmd As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
        cmd.Parameters.AddWithValue("@peso", peso)
        cmd.Parameters.AddWithValue("@categoria_precio", categoriaPrecio)

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
        Dim ct As String = ""

        If reader.Read() Then
            ct = reader.GetString(0)
        End If

        reader.Close()
        conexion.Close()

        Return ct
    End Function

    Private Sub CalcularCostoTotal()
        If jt_peso.Text = "" Or jt_valor_gramo.Text = "0" Or jt_valor_gramo.Text = "Pendiente" Or jt_cantidad.Text = "" Or jt_valor_unitario.Text = "Pendiente" Then
            jt_costo_total.Text = "Pendiente"
        Else
            Dim ctotal As Double
            Dim jt_cantidad_numerico As Double
            Dim jt_valor_unitario_numerico As Double

            ' Convertir los valores a números
            If Not Double.TryParse(jt_cantidad.Text, jt_cantidad_numerico) Then
                jt_costo_total.Text = "Error"
                Return
            End If

            If Not Double.TryParse(jt_valor_unitario.Text, jt_valor_unitario_numerico) Then
                jt_costo_total.Text = "Error"
                Return
            End If

            ' Calcular el costo total
            ctotal = jt_cantidad_numerico * jt_valor_unitario_numerico
            jt_costo_total.Text = ctotal.ToString("0.00")
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    Private Sub CalcularCostoTotalPrendas()
        If jt_cantidad.Text = "" Or jt_valor_unitario.Text = "Pendiente" Or jt_valor_unitario.Text = "" Then
            jt_costo_total.Text = "Pendiente"
        Else
            Dim ctotal As Double
            Dim jt_cantidad_numerico As Double
            Dim jt_valor_unitario_numerico As Double

            ' Convertir los valores a números
            If Not Double.TryParse(jt_cantidad.Text, jt_cantidad_numerico) Then
                jt_costo_total.Text = "Error"
                Return
            End If

            If Not Double.TryParse(jt_valor_unitario.Text, jt_valor_unitario_numerico) Then
                jt_costo_total.Text = "Error"
                Return
            End If

            ' Calcular el costo total
            ctotal = jt_cantidad_numerico * jt_valor_unitario_numerico
            jt_costo_total.Text = ctotal.ToString("0.00")
        End If
    End Sub

    Private Sub CalcularValorUnitario()
        If jt_peso.Text = "" OrElse jt_valor_gramo.Text = "Pendiente" OrElse lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            jt_valor_unitario.Text = "Pendiente"
        Else
            Try
                Dim valorBroche As Decimal = 0
                If lst_broche.SelectedItem.ToString() <> "Seleccione" Then
                    valorBroche = Convert.ToDecimal(jt_valor_broche.Text)
                End If
                Dim peso As Decimal = Convert.ToDecimal(jt_peso.Text)
                Dim valorGramo As Decimal = Convert.ToDecimal(jt_valor_gramo.Text)
                Dim valorUnitario As Decimal = (valorGramo * peso) + valorBroche
                jt_valor_unitario.Text = valorUnitario.ToString("0.00")

            Catch ex As Exception
                jt_valor_unitario.Text = "Error"
            End Try
        End If
    End Sub
    Private Sub CalcularPesoTotal()
        Dim cantidad As Double
        Dim peso As Double
        Dim pesoTotal As Double

        ' Verificar que los valores ingresados sean numéricos
        If IsNumeric(jt_cantidad.Text) And IsNumeric(jt_peso.Text.Replace(".", ",")) Then
            cantidad = CDbl(jt_cantidad.Text)
            peso = CDbl(jt_peso.Text.Replace(".", ","))
            If cantidad = 0 Or peso = 0 Then
                jt_peso_total.Text = "Pendiente"
            Else
                If lst_broche.SelectedItem IsNot Nothing AndAlso lst_broche.SelectedItem.ToString() <> "Seleccione" Then
                    Dim broche As Double = CDbl(lst_broche.SelectedItem)
                    pesoTotal = cantidad * peso + (cantidad * broche)
                Else
                    pesoTotal = cantidad * peso
                End If
                jt_peso_total.Text = pesoTotal.ToString()
            End If
        Else
            jt_peso_total.Text = "Pendiente"
        End If
    End Sub
    Private Sub ActualizarNombreCompleto()
        Dim nombreCompuesto As String = ""

        If lst_marca.Text = "Italy" Then

            If lst_tipo_producto.Text = "Piercing" Then
                nombreCompuesto = lst_tipo_producto.Text & " It " & jt_descripcion.Text
            Else

                nombreCompuesto = lst_tipo_producto.Text & " It " & jt_descripcion.Text
                ' Agregar información de los checkboxes de oro
                Dim oroSeleccionado As String = ""

                If ch_oro_amarillo.Checked Then
                    oroSeleccionado = "Oro amarillo"
                End If
                If ch_oro_blanco.Checked Then
                    If oroSeleccionado = "" Then
                        oroSeleccionado = "Oro blanco"
                    Else
                        oroSeleccionado = oroSeleccionado & " y Oro blanco"
                    End If
                End If
                If ch_oro_rosa.Checked Then
                    If oroSeleccionado = "" Then
                        oroSeleccionado = "Oro rosa"
                    Else
                        oroSeleccionado = oroSeleccionado & " y Oro rosa"
                    End If
                End If

                ' Evaluar todas las combinaciones posibles de selecciones
                Select Case oroSeleccionado
                    Case "Oro amarillo"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro blanco"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro blanco"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro blanco y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro blanco y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " Tres oros 18k"
                End Select

                If jt_talla.Text <> "" Then
                    ' Concatenar " / " y el valor de jt_talla.Text al final del nombreCompuesto
                    nombreCompuesto = nombreCompuesto & " / Talla " & jt_talla.Text & " /"
                End If

                If lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr"
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr"
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr "
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm"
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr"
                ElseIf jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                ElseIf jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                ElseIf jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm"
                Else
                    nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr"
                End If
            End If
        Else

            If lst_tipo_producto.Text = "Piercing" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text
            Else

                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text
                ' Agregar información de los checkboxes de oro
                Dim oroSeleccionado As String = ""

                If ch_oro_amarillo.Checked Then
                    oroSeleccionado = "Oro amarillo"
                End If
                If ch_oro_blanco.Checked Then
                    If oroSeleccionado = "" Then
                        oroSeleccionado = "Oro blanco"
                    Else
                        oroSeleccionado = oroSeleccionado & " y Oro blanco"
                    End If
                End If
                If ch_oro_rosa.Checked Then
                    If oroSeleccionado = "" Then
                        oroSeleccionado = "Oro rosa"
                    Else
                        oroSeleccionado = oroSeleccionado & " y Oro rosa"
                    End If
                End If

                ' Evaluar todas las combinaciones posibles de selecciones
                Select Case oroSeleccionado
                    Case "Oro amarillo"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro blanco"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro blanco"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro blanco y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " " & oroSeleccionado & " 18k"
                    Case "Oro amarillo y Oro blanco y Oro rosa"
                        nombreCompuesto = nombreCompuesto & " Tres oros 18k"
                End Select

                If jt_talla.Text <> "" Then
                    ' Concatenar " / " y el valor de jt_talla.Text al final del nombreCompuesto
                    nombreCompuesto = nombreCompuesto & " / Talla " & jt_talla.Text & " /"
                End If

                If lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +1 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +1 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +1 / " & valorGramo.ToString("0.00") & " Gr / " & jt_largo.Text & " cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +1 / " & valorGramo.ToString("0.00") & " Gr"
                    Else
                        nombreCompuesto = nombreCompuesto & " +1 / " & jt_peso.Text & " Gr"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +2 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +2 / " & valorGramo.ToString("0.00") & "Gr / " & jt_grosor.Text & " mm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & "Gr / " & jt_grosor.Text & " mm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +2 / " & valorGramo.ToString("0.00") & " Gr / " & jt_largo.Text & " cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +2 / " & valorGramo.ToString("0.00") & " Gr "
                    Else
                        nombreCompuesto = nombreCompuesto & " +2 / " & jt_peso.Text & " Gr"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +3 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +3 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm "
                    Else
                        nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm "
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +3 / " & valorGramo.ToString("0.00") & " Gr / " & jt_largo.Text & " cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " cm "
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +3 / " & valorGramo.ToString("0.00") & " Gr"
                    Else
                        nombreCompuesto = nombreCompuesto & " +3 / " & jt_peso.Text & " Gr"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +4 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +4 / " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm"
                    Else
                        nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm"
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +4 / " & valorGramo.ToString("0.00") & " Gr / " & jt_largo.Text & " cm "
                    Else
                        nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr / " & jt_largo.Text & " cm "
                    End If
                ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " +4 / " & valorGramo.ToString("0.00") & " Gr "
                    Else
                        nombreCompuesto = nombreCompuesto & " +4 / " & jt_peso.Text & " Gr "
                    End If
                ElseIf jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    Else
                        nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm / " & jt_largo.Text & " Cm"
                    End If
                ElseIf jt_grosor.Text <> "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " " & valorGramo.ToString("0.00") & " Gr / " & jt_grosor.Text & " mm "
                    Else
                        nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_grosor.Text & " mm "
                    End If
                ElseIf jt_grosor.Text = "" And jt_largo.Text <> "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " " & valorGramo.ToString("0.00") & " Gr / " & jt_largo.Text & " Cm "
                    Else
                        nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr / " & jt_largo.Text & " Cm "
                    End If
                ElseIf jt_grosor.Text = "" And jt_largo.Text = "" Then
                    If IsNumeric(jt_peso.Text) And IsNumeric(lst_broche.Text) And jt_peso.Text <> "" And lst_broche.Text <> "Seleccione" Then
                        Dim valorGramo As Double = CDbl(jt_peso.Text) + CDbl(lst_broche.Text)
                        nombreCompuesto = nombreCompuesto & " " & valorGramo.ToString("0.00") & " Gr"
                    Else
                        nombreCompuesto = nombreCompuesto & " " & jt_peso.Text & " Gr"
                    End If
                End If
            End If
        End If
        'If lst_sucursall.Text = "Medellín" Then
        'nombreCompuesto = nombreCompuesto + " *"
        'jt_nombre_compuesto.Text = nombreCompuesto
        'Else
        'jt_nombre_compuesto.Text = nombreCompuesto
        'End If
        If lst_broche.Text <> "Seleccione" Then
            nombreCompuesto = nombreCompuesto & " Broche " & lst_broche.Text
        End If
        jt_nombre_compuesto.Text = nombreCompuesto
    End Sub
    Private Sub validarCampos()
        If lst_compra.Text = "" Then
            MessageBox.Show("Seleccione una compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lst_compra.Focus()
        Else
            camposValidados = False
            If ch_adicional.Checked Then

                If lst_tipo_producto.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione el tipo de producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_tipo_producto.Focus()
                ElseIf lst_sucursall.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione la sucursal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_sucursall.Focus()
                ElseIf lst_tipo_producto.SelectedItem.ToString() = "Anillo" And rb_mujer.Checked = False And rb_hombre.Checked = False And rb_matrimonio.Checked = False Then
                    MessageBox.Show("Seleccione si es Anillo Mujer, Anillo Hombre o Anillo Matrimonio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf jt_descripcion.Text = "" Then
                    MessageBox.Show("Ingrese una descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    jt_descripcion.Focus()
                ElseIf (lst_tipo_producto.SelectedItem.ToString() = "Cadena" Or lst_tipo_producto.SelectedItem.ToString() = "Pulsera" Or lst_tipo_producto.SelectedItem.ToString() = "Tobillera" Or lst_tipo_producto.SelectedItem.ToString() = "Pulso" Or lst_tipo_producto.SelectedItem.ToString() = "Rosario") And jt_largo.Text = "" Then
                    MessageBox.Show("Ingrese el largo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    jt_largo.Focus()
                ElseIf lst_marca.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_marca.Focus()
                ElseIf ch_adicional.Checked And jt_adicional.Text = "" Then
                    MessageBox.Show("Si el producto está marcado como prenda se debe ingresar un valor adicional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    jt_adicional.Focus()

                Else
                    Dim peso As Double
                    If Not Double.TryParse(jt_peso.Text, peso) Or peso = 0 Then
                        MessageBox.Show("Ingrese un peso válido del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_peso.Focus()
                    ElseIf lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
                        MessageBox.Show("Seleccione la categoría del precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        lst_categoria_precio.Focus()
                    ElseIf jt_cantidad.Text = "" Or Val(jt_cantidad.Text) = 0 Then
                        MessageBox.Show("Ingrese la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_cantidad.Focus()
                    ElseIf jt_compra.Text = "" Or Val(jt_compra.Text) = 0 Then
                        MessageBox.Show("Ingrese el valor (Compra) del gramo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_compra.Focus()

                    ElseIf (lst_tipo_producto.SelectedItem.ToString() = "Anillo" Or
                        lst_tipo_producto.SelectedItem.ToString() = "Anillo Solitario" Or
                        lst_tipo_producto.SelectedItem.ToString() = "Anillo Matrimonio" Or
                        lst_tipo_producto.SelectedItem.ToString() = "Anillo 15") And String.IsNullOrWhiteSpace(jt_talla.Text) Then
                        MessageBox.Show("Por favor, ingrese la talla del anillo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_talla.Focus()
                    Else
                        camposValidados = True
                    End If
                End If
            Else
                If lst_tipo_producto.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione el tipo de producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_tipo_producto.Focus()
                ElseIf lst_sucursall.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione la sucursal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_sucursall.Focus()
                ElseIf lst_tipo_producto.SelectedItem.ToString() = "Anillo" And rb_mujer.Checked = False And rb_hombre.Checked = False And rb_matrimonio.Checked = False Then
                    MessageBox.Show("Seleccione si es Anillo Mujer, Anillo Hombre o Anillo Matrimonio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf jt_descripcion.Text = "" Then
                    MessageBox.Show("Ingrese una descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    jt_descripcion.Focus()
                ElseIf (lst_tipo_producto.SelectedItem.ToString() = "Cadena" Or lst_tipo_producto.SelectedItem.ToString() = "Pulsera" Or lst_tipo_producto.SelectedItem.ToString() = "Tobillera" Or lst_tipo_producto.SelectedItem.ToString() = "Pulso" Or lst_tipo_producto.SelectedItem.ToString() = "Rosario") And jt_largo.Text = "" Then
                    MessageBox.Show("Ingrese el largo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    jt_largo.Focus()
                ElseIf lst_marca.SelectedItem.ToString() = "Seleccione" Then
                    MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lst_marca.Focus()
                Else
                    Dim peso As Double
                    If Not Double.TryParse(jt_peso.Text, peso) Or peso = 0 Then
                        MessageBox.Show("Ingrese un peso válido del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_peso.Focus()
                    ElseIf lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
                        MessageBox.Show("Seleccione la categoría del precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        lst_categoria_precio.Focus()
                    ElseIf jt_cantidad.Text = "" Or Val(jt_cantidad.Text) = 0 Then
                        MessageBox.Show("Ingrese la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_cantidad.Focus()
                    ElseIf jt_compra.Text = "" Or Val(jt_compra.Text) = 0 Then
                        MessageBox.Show("Ingrese el valor (Compra) del gramo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_compra.Focus()
                    ElseIf (lst_tipo_producto.SelectedItem.ToString() = "Anillo" Or
                            lst_tipo_producto.SelectedItem.ToString() = "Anillo Solitario" Or
                            lst_tipo_producto.SelectedItem.ToString() = "Anillo Matrimonio" Or
                            lst_tipo_producto.SelectedItem.ToString() = "Anillo 15") And String.IsNullOrWhiteSpace(jt_talla.Text) Then

                        MessageBox.Show("Por favor, ingrese la talla del anillo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        jt_talla.Focus()

                    Else
                        camposValidados = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub validarCamposPircing()
        If lst_compra.Text = "" Then
            MessageBox.Show("Seleccione una compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lst_compra.Focus()
        Else
            CamposPircingValidados = False
            If lst_sucursall.SelectedItem.ToString() = "Seleccione" Then
                MessageBox.Show("Seleccione la sucursal", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lst_sucursall.Focus()
            ElseIf jt_descripcion.Text = "" Then
                MessageBox.Show("Ingrese una descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jt_descripcion.Focus()
            ElseIf lst_marca.SelectedItem.ToString() = "Seleccione" Then
                MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lst_marca.Focus()
            ElseIf jt_cantidad.Text = "" Or Val(jt_cantidad.Text) = 0 Then
                MessageBox.Show("Ingrese la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jt_cantidad.Focus()
            ElseIf jt_compra_pircing.Text = "" Or Val(jt_compra_pircing.Text) = 0 Then
                MessageBox.Show("Ingrese el precio de compra del Piercing", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jt_compra_pircing.Focus()
            ElseIf jt_venta_pircing.Text = "" Or Val(jt_venta_pircing.Text) = 0 Then
                MessageBox.Show("Ingrese el precio de venta del Piercing", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jt_venta_pircing.Focus()
            Else
                CamposPircingValidados = True
            End If
        End If
    End Sub
    Private Sub registrar_producto()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Dim nombre_compuesto As String = jt_nombre_compuesto.Text
            'nombre_compuesto = nombre_compuesto.ToUpper()

            ' Consulta a la tabla tiposdeproducto para obtener el valor de id_categoria
            Dim id_categoria As Integer
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT id_categoria FROM tiposdeproducto WHERE tipo = @tipo", conexion)
                cmd.Parameters.AddWithValue("@tipo", lst_tipo_producto.Text)
                'conexion.Open()
                id_categoria = CInt(cmd.ExecuteScalar())
            End Using
            ' Consulta a la tabla sucursales para obtener el valor del id_sucursal
            Dim id_sucursal As Integer
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT id FROM sucursales WHERE nombresucursal = @nombresucursal", conexion)
                cmd.Parameters.AddWithValue("@nombresucursal", lst_sucursall.Text)
                'conexion.Open()
                id_sucursal = CInt(cmd.ExecuteScalar())
            End Using
            ' Validación para el caso de las cadenas
            If lst_tipo_producto.Text = "Cadena" Then
                Dim jt_largo_valor As Integer = CInt(jt_largo.Text)
                If jt_largo_valor >= 40 AndAlso jt_largo_valor <= 44 Then
                    id_categoria = 25
                ElseIf jt_largo_valor >= 45 AndAlso jt_largo_valor <= 49 Then
                    id_categoria = 19
                ElseIf jt_largo_valor >= 50 AndAlso jt_largo_valor <= 54 Then
                    id_categoria = 20
                ElseIf jt_largo_valor >= 55 AndAlso jt_largo_valor <= 59 Then
                    id_categoria = 21
                ElseIf jt_largo_valor >= 60 AndAlso jt_largo_valor <= 64 Then
                    id_categoria = 22
                ElseIf jt_largo_valor >= 65 AndAlso jt_largo_valor <= 69 Then
                    id_categoria = 23
                ElseIf jt_largo_valor >= 70 AndAlso jt_largo_valor <= 74 Then
                    id_categoria = 24
                Else
                    id_categoria = 1
                End If
            End If

            ' Validación para el caso de los anillos
            If lst_tipo_producto.Text = "Anillo" Then
                If rb_mujer.Checked Then
                    id_categoria = 26
                ElseIf rb_hombre.Checked Then
                    id_categoria = 27
                ElseIf rb_matrimonio.Checked Then
                    id_categoria = 30
                End If
            End If

            ' Obtener el valor de idcompra desde lst_compra
            Dim idcompra As Integer
            If Not String.IsNullOrEmpty(lst_compra.Text) Then
                idcompra = CInt(lst_compra.Text)
            Else
                ' Manejo de error en caso de que lst_compra no tenga un valor válido
                MessageBox.Show("Por favor, seleccione un valor válido en compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Cálculo del valor_unitario_compra
            Dim valor_unitario_compra As Decimal
            If Not ch_adicional.Checked Then
                valor_unitario_compra = Convert.ToDecimal(jt_peso.Text) * Convert.ToDecimal(jt_compra.Text)
            Else
                valor_unitario_compra = Convert.ToDecimal(jt_compra.Text)
            End If

            Dim ct As String = ""
            If lst_marca.Text = "Nacional" Then
                ct = ObtenerCtNacional(Convert.ToDecimal(jt_peso.Text), lst_categoria_precio.SelectedItem.ToString())
            ElseIf lst_marca.Text = "Italy" Then
                ct = ObtenerCtItaly(Convert.ToDecimal(jt_peso.Text), lst_categoria_precio.SelectedItem.ToString())
            End If

            ' Obtener el último número de referencia para la sucursal
            Dim ultima_referencia As Integer
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Using cmdRef As New MySql.Data.MySqlClient.MySqlCommand("SELECT MAX(CAST(SUBSTRING(referencia, 2) AS SIGNED)) 
            FROM productos
            WHERE sucursal = @idsucursal
            AND referencia NOT LIKE 'B%';
            ", conexion)
                cmdRef.Parameters.AddWithValue("@idsucursal", id_sucursal)
                Dim resultado As Object = cmdRef.ExecuteScalar()
                If resultado IsNot DBNull.Value Then
                    ultima_referencia = Convert.ToInt32(resultado)
                Else
                    ultima_referencia = 0
                End If
            End Using

            ' Incrementar el número de referencia
            ultima_referencia += 1

            ' Construir la nueva referencia según la lógica establecida
            Dim nueva_referencia As String
            If id_sucursal = 1 Then
                nueva_referencia = "E" & ultima_referencia
            ElseIf id_sucursal = 2 Then
                nueva_referencia = "D" & ultima_referencia
            Else
                nueva_referencia = "Otro" & ultima_referencia
            End If

            ' Inserción de datos en la tabla productos
            If Not ch_adicional.Checked Then
                Dim query As String = "INSERT INTO productos (nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, ct, sucursal, broche, vbroche, referencia, idcompra) VALUES (@nombre, @marca, @cantidad, @peso, @peso_total, @categoria_producto, @valor_unitario, @costo_total, @valor_gramo, @valor_unitario_compra, @ct, @idsucursal, @broche, @vbroche, @referencia, @idcompra)"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@nombre", nombre_compuesto)
                    cmd.Parameters.AddWithValue("@marca", If(lst_marca.Text = "Nacional", 1, 2))
                    cmd.Parameters.AddWithValue("@cantidad", jt_cantidad.Text)
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(jt_peso.Text))
                    cmd.Parameters.AddWithValue("@peso_total", Convert.ToDecimal(jt_peso_total.Text))
                    cmd.Parameters.AddWithValue("@categoria_producto", id_categoria)
                    cmd.Parameters.AddWithValue("@valor_unitario", Convert.ToDecimal(jt_valor_unitario.Text))
                    cmd.Parameters.AddWithValue("@costo_total", Convert.ToDecimal(jt_costo_total.Text))
                    cmd.Parameters.AddWithValue("@valor_gramo", Convert.ToDecimal(jt_valor_gramo.Text))
                    cmd.Parameters.AddWithValue("@valor_unitario_compra", valor_unitario_compra)
                    cmd.Parameters.AddWithValue("@ct", ct)
                    cmd.Parameters.AddWithValue("@referencia", nueva_referencia)
                    cmd.Parameters.AddWithValue("@idsucursal", id_sucursal)

                    If lst_marca.Text = "Nacional" AndAlso lst_broche.Text <> "Seleccione" Then
                        Dim broche As Decimal = Convert.ToDecimal(lst_broche.Text)
                        cmd.Parameters.AddWithValue("@broche", broche)
                        cmd.Parameters.AddWithValue("@vbroche", Convert.ToDecimal(jt_valor_broche.Text))
                    Else
                        cmd.Parameters.AddWithValue("@broche", DBNull.Value)
                        cmd.Parameters.AddWithValue("@vbroche", DBNull.Value)
                    End If
                    cmd.Parameters.AddWithValue("@idcompra", idcompra)
                    If conexion.State = ConnectionState.Closed Then
                        conexion.Open()
                    End If
                    cmd.ExecuteNonQuery()
                End Using

                ' Obtener el último id registrado
                Dim lastInsertedId As Integer
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT LAST_INSERT_ID()", conexion)
                    lastInsertedId = CInt(cmd.ExecuteScalar())
                End Using

                'MessageBox.Show("Producto registrado correctamente. Sin referencia.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim lastReference As String = ""
                If lastInsertedId > 0 Then
                    Dim queryRef As String = "SELECT referencia FROM productos WHERE id = @id"
                    Using cmd As New MySqlCommand(queryRef, conexion)
                        cmd.Parameters.AddWithValue("@id", lastInsertedId)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lastReference = reader("referencia").ToString()
                        End If
                    End Using
                End If

                If Not String.IsNullOrEmpty(lastReference) Then
                    MessageBox.Show("Producto registrado correctamente. Referencia: " & lastReference, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Producto registrado correctamente. No se pudo obtener la última referencia.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                lst_tipo_producto.Text = "Seleccione"
                lst_sucursall.Text = "Seleccione"
                jt_nombre_compuesto.Text = ""
            Else
                Dim valor_adicional As Decimal = Convert.ToDecimal(jt_adicional.Text)
                Dim valor_unitario As Decimal = Convert.ToDecimal(jt_valor_unitario.Text) + valor_adicional

                Dim cantidad As Decimal = Convert.ToDecimal(jt_cantidad.Text)
                Dim costo_total As Decimal = cantidad * valor_unitario

                Dim query As String = "INSERT INTO productos (nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_prenda, valor_unitario_compra, ct, sucursal, referencia, idcompra) VALUES (@nombre, @marca, @cantidad, @peso, @peso_total, @categoria_producto, @valor_unitario, @costo_total, @valor_gramo, @valor_prenda, @valor_unitario_compra, @ct, @idsucursal, @referencia, @idcompra)"

                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@nombre", nombre_compuesto)
                    cmd.Parameters.AddWithValue("@marca", If(lst_marca.Text = "Nacional", 1, 2))
                    cmd.Parameters.AddWithValue("@cantidad", jt_cantidad.Text)
                    cmd.Parameters.AddWithValue("@peso", Convert.ToDecimal(jt_peso.Text))
                    cmd.Parameters.AddWithValue("@peso_total", Convert.ToDecimal(jt_peso_total.Text))
                    cmd.Parameters.AddWithValue("@categoria_producto", id_categoria)
                    cmd.Parameters.AddWithValue("@valor_unitario", valor_unitario)
                    cmd.Parameters.AddWithValue("@costo_total", costo_total)
                    cmd.Parameters.AddWithValue("@valor_gramo", Convert.ToDecimal(jt_valor_gramo.Text))
                    cmd.Parameters.AddWithValue("@valor_prenda", valor_adicional)
                    cmd.Parameters.AddWithValue("@valor_unitario_compra", valor_unitario_compra)
                    cmd.Parameters.AddWithValue("@ct", ct)
                    cmd.Parameters.AddWithValue("@idsucursal", id_sucursal)
                    cmd.Parameters.AddWithValue("@referencia", nueva_referencia)
                    cmd.Parameters.AddWithValue("@idcompra", idcompra)
                    If conexion.State = ConnectionState.Closed Then
                        conexion.Open()
                    End If
                    cmd.ExecuteNonQuery()
                End Using

                ' Obtener el último id registrado
                Dim lastInsertedId As Integer
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT LAST_INSERT_ID()", conexion)
                    lastInsertedId = CInt(cmd.ExecuteScalar())
                End Using

                ' Obtener la referencia asociada al último ID
                Dim lastReference As String = ""
                If lastInsertedId > 0 Then
                    Dim queryRef As String = "SELECT referencia FROM productos WHERE id = @id"
                    Using cmd As New MySqlCommand(queryRef, conexion)
                        cmd.Parameters.AddWithValue("@id", lastInsertedId)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lastReference = reader("referencia").ToString()
                        End If
                    End Using
                End If

                If Not String.IsNullOrEmpty(lastReference) Then
                    MessageBox.Show("Producto registrado correctamente. Referencia: " & lastReference, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Producto registrado correctamente. No se pudo obtener la última referencia.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                lst_tipo_producto.Text = "Seleccione"
                lst_sucursall.Text = "Seleccione"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al registrar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State <> ConnectionState.Closed Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub registrar_pircing()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Dim nombre_compuesto As String = jt_nombre_compuesto.Text

            ' Consulta a la tabla tiposdeproducto para obtener el valor de id_categoria
            Dim id_categoria As Integer
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT id_categoria FROM tiposdeproducto WHERE tipo = @tipo", conexion)
                cmd.Parameters.AddWithValue("@tipo", lst_tipo_producto.Text)
                'conexion.Open()
                id_categoria = CInt(cmd.ExecuteScalar())
            End Using
            ' Consulta a la tabla sucursales para obtener el valor del id_sucursal
            Dim id_sucursal As Integer
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT id FROM sucursales WHERE nombresucursal = @nombresucursal", conexion)
                cmd.Parameters.AddWithValue("@nombresucursal", lst_sucursall.Text)
                'conexion.Open()
                id_sucursal = CInt(cmd.ExecuteScalar())
            End Using

            Dim cantidad As Decimal = Convert.ToDecimal(jt_cantidad.Text)
            Dim valor_unitario_venta As Decimal = Convert.ToDecimal(jt_venta_pircing.Text)
            Dim valor_unitario_compra As Decimal = Convert.ToDecimal(jt_compra_pircing.Text)
            Dim costo_total As Decimal = cantidad * valor_unitario_venta

            ' Obtener el valor de idcompra desde lst_compra
            Dim idcompra As Integer
            If Not String.IsNullOrEmpty(lst_compra.Text) Then
                idcompra = CInt(lst_compra.Text)
            Else
                ' Manejo de error en caso de que lst_compra no tenga un valor válido
                MessageBox.Show("Por favor, seleccione un valor válido en compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Obtener el último número de referencia para la sucursal
            Dim ultima_referencia As Integer
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Using cmdRef As New MySql.Data.MySqlClient.MySqlCommand("SELECT MAX(CAST(SUBSTRING(referencia, 2) AS SIGNED)) 
            FROM productos
            WHERE sucursal = @idsucursal
            AND referencia NOT LIKE 'B%';", conexion)
                cmdRef.Parameters.AddWithValue("@idsucursal", id_sucursal)
                Dim resultado As Object = cmdRef.ExecuteScalar()
                If resultado IsNot DBNull.Value Then
                    ultima_referencia = Convert.ToInt32(resultado)
                Else
                    ultima_referencia = 0
                End If
            End Using

            ' Incrementar el número de referencia
            ultima_referencia += 1

            ' Construir la nueva referencia según la lógica establecida
            Dim nueva_referencia As String
            If id_sucursal = 1 Then
                nueva_referencia = "E" & ultima_referencia
            ElseIf id_sucursal = 2 Then
                nueva_referencia = "D" & ultima_referencia
            Else
                nueva_referencia = "Otro" & ultima_referencia
            End If

            ' Inserción de datos en la tabla productos
            If Not ch_adicional.Checked Then
                Dim query As String = "INSERT INTO productos (nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, ct, sucursal, referencia, idcompra) VALUES (@nombre, @marca, @cantidad, @peso, @peso_total, @categoria_producto, @valor_unitario, @costo_total, @valor_gramo, @valor_unitario_compra, @ct, @idsucursal, @referencia, @idcompra)"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@nombre", nombre_compuesto)
                    cmd.Parameters.AddWithValue("@marca", If(lst_marca.Text = "Nacional", 1, 2))
                    cmd.Parameters.AddWithValue("@cantidad", jt_cantidad.Text)
                    cmd.Parameters.AddWithValue("@peso", 1)
                    cmd.Parameters.AddWithValue("@peso_total", 1)
                    cmd.Parameters.AddWithValue("@categoria_producto", id_categoria)
                    cmd.Parameters.AddWithValue("@valor_unitario", valor_unitario_venta)
                    cmd.Parameters.AddWithValue("@costo_total", costo_total)
                    cmd.Parameters.AddWithValue("@valor_gramo", 1)
                    cmd.Parameters.AddWithValue("@valor_unitario_compra", valor_unitario_compra)
                    cmd.Parameters.AddWithValue("@ct", "pp")
                    cmd.Parameters.AddWithValue("@idsucursal", id_sucursal)
                    cmd.Parameters.AddWithValue("@referencia", nueva_referencia)
                    cmd.Parameters.AddWithValue("@idcompra", idcompra)
                    If conexion.State = ConnectionState.Closed Then
                        conexion.Open()
                    End If
                    cmd.ExecuteNonQuery()
                End Using

                ' Obtener el último id registrado
                Dim lastInsertedId As Integer
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT LAST_INSERT_ID()", conexion)
                    lastInsertedId = CInt(cmd.ExecuteScalar())
                End Using

                ' Obtener la referencia asociada al último ID
                Dim lastReference As String = ""
                If lastInsertedId > 0 Then
                    Dim queryRef As String = "SELECT referencia FROM productos WHERE id = @id"
                    Using cmd As New MySqlCommand(queryRef, conexion)
                        cmd.Parameters.AddWithValue("@id", lastInsertedId)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lastReference = reader("referencia").ToString()
                        End If
                    End Using
                End If

                If Not String.IsNullOrEmpty(lastReference) Then
                    MessageBox.Show("Producto registrado correctamente. Referencia: " & lastReference, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Producto registrado correctamente. No se pudo obtener la última referencia.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                lst_tipo_producto.Text = "Seleccione"
                lst_sucursall.Text = "Seleccione"
                jt_nombre_compuesto.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error al registrar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State <> ConnectionState.Closed Then
                conexion.Close()
            End If
        End Try
    End Sub
    Private Sub btn_actualizar_valores_Click(sender As Object, e As EventArgs) Handles btn_actualizar_valores.Click

        Dim autenticacion As New FormAutenticacion()
        autenticacion.ShowDialog()
        If autenticacion.DialogResult = DialogResult.OK Then

            btn_actualizar.Visible = True
            btn_cancelar.Visible = True
            btn_actualizar_valores.Enabled = False
            ' Habilitar la columna valor
            tb_precios.ReadOnly = False
            tb_precios.Columns("valor").ReadOnly = False

        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        ' Deshabilitar la opción de editar la columna valor de la tabla
        tb_precios.ReadOnly = True
        tb_precios.Columns("valor").ReadOnly = True
        btn_actualizar.Visible = False
        btn_cancelar.Visible = False
        btn_actualizar_valores.Enabled = True
        Try
            conexion.Open()
            Dim query As String = "SELECT peso_inicial, peso_final, categoria_precio, valor FROM gramonacional_new"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
            'Dim tabla As New DataTable()
            Dim tabla As New System.Data.DataTable()

            adapter.Fill(tabla)
            tb_precios.AutoGenerateColumns = True

            ' Asignar los nombres de columna personalizados a cada una de las columnas del control
            tb_precios.Columns(0).HeaderText = "Peso Inicial"
            tb_precios.Columns(0).DataPropertyName = "peso_inicial"

            tb_precios.Columns(1).HeaderText = "Peso Final"
            tb_precios.Columns(1).DataPropertyName = "peso_final"

            tb_precios.Columns(2).HeaderText = "Categoría Precio"
            tb_precios.Columns(2).DataPropertyName = "categoria_precio"

            tb_precios.Columns(3).HeaderText = "Valor"
            tb_precios.Columns(3).DataPropertyName = "valor"
            tb_precios.Visible = True ' Mostrar tabla
            tb_precios.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try

            If lst_marca_tabla.SelectedItem = "Nacional" Then
                Dim query As String = "UPDATE gramonacional_new SET valor = @valor WHERE id = @id"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    conexion.Open()
                    For Each row As DataGridViewRow In tb_precios.Rows
                        Dim id As Integer = row.Cells("id").Value
                        Dim valor As Double = CDbl(row.Cells("valor").Value)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@valor", valor)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    Next
                End Using
                MessageBox.Show("Actualización tabla nacional completa.")
                tb_precios.ReadOnly = True
                tb_precios.Columns("valor").ReadOnly = True
                btn_actualizar.Visible = False
                btn_cancelar.Visible = False
                btn_actualizar_valores.Enabled = True

                conexion.Close()
                Dim queryActualizacion As String = "
                    UPDATE productos p
                    JOIN gramonacional_new g ON p.ct = g.ct
                    SET p.valor_gramo = g.valor;
                    UPDATE productos p
                    LEFT JOIN broches_new b ON p.broche = b.peso_broche
                    SET 
                        p.vbroche = IFNULL(b.precio_broche, 0),
                        p.valor_unitario = (p.peso * p.valor_gramo) + IFNULL(b.precio_broche, 0) + IFNULL(p.valor_prenda, 0);

                    UPDATE productos
                    SET costo_total = cantidad * valor_unitario;
                "

                Try
                    conexion.Open()
                    Dim comando As New MySql.Data.MySqlClient.MySqlCommand(queryActualizacion, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Actualización nacional masiva completada.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conexion.Close()
                End Try

            ElseIf lst_marca_tabla.SelectedItem = "Italy" Then
                Dim query As String = "UPDATE gramoitaly_new SET valor = @valor WHERE id = @id"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    conexion.Open()
                    For Each row As DataGridViewRow In tb_precios.Rows
                        Dim id As Integer = row.Cells("id").Value
                        Dim valor As Double = CDbl(row.Cells("valor").Value)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@valor", valor)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    Next
                End Using
                conexion.Close()
                Dim queryActualizacion As String = "
                    UPDATE productos p
                    JOIN gramoitaly_new g ON p.ct = g.ct
                    SET p.valor_gramo = g.valor;

                    UPDATE broches_new 
                    SET precio_broche = peso_broche * (
                        SELECT valor 
                        FROM gramoitaly_new 
                        WHERE ct = 'ir2-3' 
                        LIMIT 1
                    );

                    UPDATE productos p
                    LEFT JOIN broches_new b ON p.broche = b.peso_broche
                    SET 
                        p.vbroche = IFNULL(b.precio_broche, 0),
                        p.valor_unitario = (p.peso * p.valor_gramo) + IFNULL(b.precio_broche, 0) + IFNULL(p.valor_prenda, 0);

                    UPDATE productos
                    SET costo_total = cantidad * valor_unitario;
                "

                Try
                    conexion.Open()
                    Dim comando As New MySql.Data.MySqlClient.MySqlCommand(queryActualizacion, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Actualización Italy masiva completada.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conexion.Close()
                End Try

                tb_precios.ReadOnly = True
                tb_precios.Columns("valor").ReadOnly = True
                btn_actualizar.Visible = False
                btn_cancelar.Visible = False
                btn_actualizar_valores.Enabled = True
            Else
                MessageBox.Show("Seleccione la opción correcta de la lista desplegable.")
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar la tabla. Detalles del error: " & ex.Message)
        End Try
    End Sub
    Public Sub ActualizarValorGramoNacional()
        Dim consultaGramo As String = "SELECT ct, valor FROM gramonacional_new"
        Dim comandoConsultaGramo As New MySql.Data.MySqlClient.MySqlCommand(consultaGramo, conexion)
        Dim valoresGramo As New Dictionary(Of String, Decimal)

        Try
            conexion.Open()
            Dim readerGramo As MySql.Data.MySqlClient.MySqlDataReader = comandoConsultaGramo.ExecuteReader()

            While readerGramo.Read()
                Dim ctActual As String = readerGramo("ct")
                Dim valorGramo As Decimal = readerGramo("valor")
                valoresGramo(ctActual) = valorGramo
            End While
            readerGramo.Close()

            Dim updateValorGramo As String = "UPDATE productos SET valor_gramo = @valorGramo WHERE ct = @ctActual"

            For Each kvp As KeyValuePair(Of String, Decimal) In valoresGramo
                Using comandoUpdateValorGramo As New MySql.Data.MySqlClient.MySqlCommand(updateValorGramo, conexion)
                    comandoUpdateValorGramo.Parameters.AddWithValue("@valorGramo", kvp.Value)
                    comandoUpdateValorGramo.Parameters.AddWithValue("@ctActual", kvp.Key)
                    comandoUpdateValorGramo.ExecuteNonQuery()
                End Using
            Next
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub ActualizarValorUnitarioNacional()
        Dim consultaProductos As String = "SELECT id, peso, valor_gramo, broche FROM productos"
        Dim comandoConsultaProductos As New MySql.Data.MySqlClient.MySqlCommand(consultaProductos, conexion)
        Dim adaptadorProductos As New MySql.Data.MySqlClient.MySqlDataAdapter(comandoConsultaProductos)
        Dim tablaProductos As New DataTable()

        Try
            conexion.Open()
            adaptadorProductos.Fill(tablaProductos)

            For Each fila As DataRow In tablaProductos.Rows
                Dim idActual As Integer = fila("id")
                Dim pesoActual As Decimal = fila("peso")
                Dim valorGramo As Decimal = fila("valor_gramo")
                Dim broche As Decimal = If(Not IsDBNull(fila("broche")), fila("broche"), 0)

                Dim vbroche As Decimal = 0
                If broche <> 0 Then
                    Dim consultaBroches As String = "SELECT precio_broche FROM broches_new WHERE peso_broche = @broche"
                    Dim comandoConsultaBroches As New MySql.Data.MySqlClient.MySqlCommand(consultaBroches, conexion)
                    comandoConsultaBroches.Parameters.AddWithValue("@broche", broche)
                    Dim resultadoBroche As Object = comandoConsultaBroches.ExecuteScalar()

                    If resultadoBroche IsNot Nothing Then
                        vbroche = Convert.ToDecimal(resultadoBroche)
                    End If
                End If

                Dim updateVBroche As String = "UPDATE productos SET vbroche = @vbroche WHERE id = @idActual"
                Using comandoUpdateVBroche As New MySql.Data.MySqlClient.MySqlCommand(updateVBroche, conexion)
                    comandoUpdateVBroche.Parameters.AddWithValue("@vbroche", vbroche)
                    comandoUpdateVBroche.Parameters.AddWithValue("@idActual", idActual)
                    comandoUpdateVBroche.ExecuteNonQuery()
                End Using

                Dim valorUnitarioActual As Decimal = (pesoActual * valorGramo) + vbroche

                Dim updateValorUnitario As String = "UPDATE productos SET valor_unitario = @valorUnitarioActual WHERE id = @idActual"
                Using comandoUpdateValorUnitario As New MySql.Data.MySqlClient.MySqlCommand(updateValorUnitario, conexion)
                    comandoUpdateValorUnitario.Parameters.AddWithValue("@valorUnitarioActual", valorUnitarioActual)
                    comandoUpdateValorUnitario.Parameters.AddWithValue("@idActual", idActual)
                    comandoUpdateValorUnitario.ExecuteNonQuery()
                End Using
            Next

            'MsgBox("Actualizado el valor unitario y vbroche")
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub ActualizarPrecioBroche()
        'Dim connectionString As String = "server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager"

        Dim connectionString As String = "server=sh00002.hostgator.co;user=cdcbfeba_adminelite;password=Safrat2583;database=cdcbfeba_goldmanagerelite;port=3306"
        '"server=shared20.hostgator.co;user=elitejo1_adminelite;password=Safrat2583;database=elitejo1_goldmanagerelite;port=3306"

        ' Consulta para obtener el valor de gramoitaly donde ct = 'ic-1'
        Dim queryGramoitaly As String = "SELECT valor FROM gramoitaly_new WHERE ct = 'ir1-2'"

        ' Consulta para actualizar precio_broche en la tabla broches
        Dim queryActualizarBroches As String = "UPDATE broches_new SET precio_broche = peso_broche * @valor"
        Try
            Using connection As New MySql.Data.MySqlClient.MySqlConnection(connectionString)
                connection.Open()

                ' Obtener el valor de gramoitaly
                Dim valor As Decimal

                Using commandGramoitaly As New MySql.Data.MySqlClient.MySqlCommand(queryGramoitaly, connection)
                    Using reader As MySql.Data.MySqlClient.MySqlDataReader = commandGramoitaly.ExecuteReader()
                        If reader.Read() Then
                            valor = reader.GetDecimal("valor")
                        End If
                        reader.Close()
                    End Using
                End Using

                ' Actualizar precio_broche en la tabla broches
                Using commandActualizarBroches As New MySql.Data.MySqlClient.MySqlCommand(queryActualizarBroches, connection)
                    commandActualizarBroches.Parameters.AddWithValue("@valor", valor)
                    commandActualizarBroches.ExecuteNonQuery()
                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Error al actualizar el precio del broche: " & ex.Message)
        End Try
    End Sub
    Public Sub ActualizarCostosTotalesNacional()
        Dim consultaProductos As String = "SELECT id, cantidad, valor_unitario FROM productos"
        Dim adapterProductos As New MySql.Data.MySqlClient.MySqlDataAdapter(consultaProductos, conexion)
        Dim tablaProductos As New DataTable()

        Try
            conexion.Open()

            ' Llenar el DataTable con los datos de la consulta
            adapterProductos.Fill(tablaProductos)

            ' Recorrer el DataTable y actualizar los registros
            For Each filaProducto As DataRow In tablaProductos.Rows
                Dim idActual As Integer = CInt(filaProducto("id"))
                Dim cantidadActual As Integer = CInt(filaProducto("cantidad"))
                Dim valorUnitarioActual As Decimal = CDec(filaProducto("valor_unitario"))

                Dim costoTotalActual As Decimal = valorUnitarioActual * cantidadActual
                Dim updateCostoTotal As String = "UPDATE productos SET costo_total = @costoTotalActual WHERE id = @idActual"

                Using comandoUpdateCostoTotal As New MySql.Data.MySqlClient.MySqlCommand(updateCostoTotal, conexion)
                    comandoUpdateCostoTotal.Parameters.AddWithValue("@costoTotalActual", costoTotalActual)
                    comandoUpdateCostoTotal.Parameters.AddWithValue("@idActual", idActual)
                    comandoUpdateCostoTotal.ExecuteNonQuery()
                End Using
            Next
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub ActualizarValorGramoItaly()
        Dim consultaGramo As String = "SELECT ct, valor FROM gramoitaly_new"
        Dim comandoConsultaGramo As New MySql.Data.MySqlClient.MySqlCommand(consultaGramo, conexion)
        Dim valoresGramo As New Dictionary(Of String, Decimal)

        Try
            conexion.Open()
            Dim readerGramo As MySql.Data.MySqlClient.MySqlDataReader = comandoConsultaGramo.ExecuteReader()

            While readerGramo.Read()
                Dim ctActual As String = readerGramo("ct")
                Dim valorGramo As Decimal = readerGramo("valor")
                valoresGramo(ctActual) = valorGramo
            End While
            readerGramo.Close()

            Dim updateValorGramo As String = "UPDATE productos SET valor_gramo = @valorGramo WHERE ct = @ctActual"

            For Each kvp As KeyValuePair(Of String, Decimal) In valoresGramo
                Using comandoUpdateValorGramo As New MySql.Data.MySqlClient.MySqlCommand(updateValorGramo, conexion)
                    comandoUpdateValorGramo.Parameters.AddWithValue("@valorGramo", kvp.Value)
                    comandoUpdateValorGramo.Parameters.AddWithValue("@ctActual", kvp.Key)
                    comandoUpdateValorGramo.ExecuteNonQuery()
                End Using
            Next
        Finally
            conexion.Close()
        End Try
        ActualizarPrecioBroche()
    End Sub

    Private Sub btn_effy_Click(sender As Object, e As EventArgs) Handles btn_effy.Click
        If lst_compra_rep.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione una compra.")
        Else
            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

                'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
                Dim selectedCompraID As Integer = CInt(lst_compra_rep.SelectedItem)
                Dim sql As String = "SELECT * FROM productos WHERE idcompra = @compraID"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                cmd.Parameters.AddWithValue("@compraID", selectedCompraID)

                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                'Verificar si se encontraron registros
                If Not reader.HasRows Then
                    MessageBox.Show("No se encontraron registros en el rango de IDs especificado.")
                    conexion.Close()
                    Return
                End If

                'Escribir los encabezados de las columnas en la hoja de Excel
                ws.Cell(1, 1).Value = "Nombre *"
                ws.Cell(1, 2).Value = "Código de referencia"
                ws.Cell(1, 3).Value = "Sucursal principal"
                ws.Cell(1, 4).Value = "Código de barras"
                ws.Cell(1, 5).Value = "Tipo de artículo *"
                ws.Cell(1, 6).Value = "Categoría"
                ws.Cell(1, 7).Value = "Marca"
                ws.Cell(1, 8).Value = "Gestión de stock *"
                ws.Cell(1, 9).Value = "Stock mínimo"
                ws.Cell(1, 10).Value = "Stock óptimo"
                ws.Cell(1, 11).Value = "Habilitar en compras *"
                ws.Cell(1, 12).Value = "Habilitar en ventas *"
                ws.Cell(1, 13).Value = "Permitir descuento"
                ws.Cell(1, 14).Value = "Compartir en Dropshipping"
                ws.Cell(1, 15).Value = "Habilitar en alquiler *"
                ws.Cell(1, 16).Value = "Depósito"
                ws.Cell(1, 17).Value = "Impuesto"
                ws.Cell(1, 18).Value = "Costo"
                ws.Cell(1, 19).Value = "Precio mínimo venta"
                ws.Cell(1, 20).Value = "Valor auxiliar"
                ws.Cell(1, 21).Value = "Porcentaje auxiliar"
                ws.Cell(1, 22).Value = "Número auxiliar"
                ws.Cell(1, 23).Value = "Texto auxiliar"
                ws.Cell(1, 24).Value = "URL video"
                ws.Cell(1, 25).Value = "URL imagen"
                ws.Cell(1, 26).Value = "Descripción"
                ws.Cell(1, 27).Value = "Tarifa 1"
                ws.Cell(1, 28).Value = "Tarifa 2"
                ws.Cell(1, 29).Value = "Tarifa 3"
                ws.Cell(1, 30).Value = "Tarifa 4"
                ws.Cell(1, 31).Value = "Tarifa 5"
                ws.Cell(1, 32).Value = "Tarifa 6"
                ws.Cell(1, 33).Value = "Tarifa 7"
                ws.Cell(1, 34).Value = "Tarifa 8"
                ws.Cell(1, 35).Value = "Tarifa 9"

                'Escribir los datos de la tabla Productos en la hoja de Excel
                Dim row As Integer = 2
                While reader.Read()
                    ws.Cell(row, 1).Value = reader.GetString(1) ' Nombre
                    ws.Cell(row, 2).Value = reader.GetString(16) ' ID - Referencia
                    'ws.Cell(row, 3).Value = reader.GetInt32(13) ' Sucursal principal
                    ws.Cell(row, 3).Value = 1 ' Sucursal principal
                    ws.Cell(row, 4).Value = "" ' Código de barras
                    ws.Cell(row, 5).Value = 3 ' Tipo de artículo
                    ws.Cell(row, 6).Value = reader.GetInt32(6) ' Categoría
                    ws.Cell(row, 7).Value = reader.GetInt32(2) ' Marca
                    ws.Cell(row, 8).Value = 1 ' Gestión de stock
                    ws.Cell(row, 9).Value = "" ' Stock mínimo
                    ws.Cell(row, 10).Value = "" ' Stock óptimo
                    ws.Cell(row, 11).Value = 1 ' Habilitar en compras
                    ws.Cell(row, 12).Value = 1 ' Habilitar en ventas
                    ws.Cell(row, 13).Value = 1 ' Permitir descuento
                    ws.Cell(row, 14).Value = 1 ' Compartir en Dropshipping
                    ws.Cell(row, 15).Value = 1 ' Habilitar en alquiler
                    ws.Cell(row, 16).Value = "" ' Depósito
                    ws.Cell(row, 17).Value = 2 ' Impuesto
                    ws.Cell(row, 18).Value = reader.GetDecimal(11) ' Valor unitario de compra
                    ws.Cell(row, 19).Value = "" ' Precio mínimo venta
                    ws.Cell(row, 20).Value = reader.GetDecimal(4) ' Valor referencia
                    ws.Cell(row, 21).Value = "" ' Porcentaje referencia
                    ws.Cell(row, 22).Value = "" ' Número auxiliar
                    ws.Cell(row, 23).Value = "" ' Texto auxiliar
                    ws.Cell(row, 24).Value = "" ' URL video
                    ws.Cell(row, 25).Value = "" ' URL imagen
                    ws.Cell(row, 26).Value = "" ' Descripción
                    ws.Cell(row, 27).Value = reader.GetDecimal(7) ' Tarifa 1 - Valor unitario
                    ws.Cell(row, 28).Value = "" ' Tarifa 2
                    ws.Cell(row, 29).Value = "" ' Tarifa 3
                    ws.Cell(row, 30).Value = "" ' Tarifa 4
                    ws.Cell(row, 31).Value = "" ' Tarifa 5
                    ws.Cell(row, 32).Value = "" ' Tarifa 6
                    ws.Cell(row, 33).Value = "" ' Tarifa 7
                    ws.Cell(row, 34).Value = "" ' Tarifa 8
                    ws.Cell(row, 35).Value = "" ' Tarifa 9
                    row += 1
                End While
                'Cerrar el lector y la conexión a la base de datos
                reader.Close()
                conexion.Close()

                'Guardar el archivo de Excel y cerrar la aplicación Excel
                Dim saveFileDialog1 As New SaveFileDialog()
                saveFileDialog1.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
                saveFileDialog1.Title = "Guardar como"
                saveFileDialog1.ShowDialog()

                If saveFileDialog1.FileName <> "" Then
                    wb.SaveAs(saveFileDialog1.FileName)
                    MsgBox("Archivo guardado con éxito", vbInformation, "Guardado")

                Else
                    MsgBox("Error al guardar el archivo", vbCritical, "Error")
                End If

                'Liberar memoria
                cmd.Dispose()
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error al generar el archivo: " & ex.Message)
                conexion.Close()
            End Try
        End If
        'End If
    End Sub


    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_shopify_Click(sender As Object, e As EventArgs) Handles btn_shopify.Click

        If lst_compra_rep.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione una compra.")
            Return
        End If

        Try
            conexion.Open()
            Dim selectedCompraID As Integer = CInt(lst_compra_rep.SelectedItem)

            Dim sql As String = "SELECT referencia, nombre, marca, peso, categoria_producto, valor_unitario FROM productos WHERE idcompra = @compraID"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@compraID", selectedCompraID)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            If Not reader.HasRows Then
                MessageBox.Show("No se encontraron registros para la compra especificada.")
                conexion.Close()
                Return
            End If

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo CSV (*.csv)|*.csv"
            saveFileDialog1.Title = "Guardar como"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName = "" Then
                conexion.Close()
                Return
            End If

            Using sw As New StreamWriter(saveFileDialog1.FileName, False, Encoding.UTF8)

                ' CABECERAS
                Dim headers As String() = {
                "Handle", "Title", "Body (HTML)", "Vendor", "Product Category", "Type", "Tags", "Published",
                "Option1 Name", "Option1 Value", "Option2 Name", "Option2 Value", "Option3 Name", "Option3 Value",
                "Variant SKU", "Variant Grams", "Variant Inventory Tracker", "Variant Inventory Qty",
                "Variant Inventory Policy", "Variant Fulfillment Service", "Variant Price", "Variant Compare At Price",
                "Variant Requires Shipping", "Variant Taxable", "Variant Barcode", "Image Src", "Image Position",
                "Image Alt Text", "Gift Card", "SEO Title", "SEO Description", "Google Shopping / Google Product Category",
                "Google Shopping / Gender", "Google Shopping / Age Group", "Google Shopping / MPN",
                "Google Shopping / AdWords Grouping", "Google Shopping / AdWords Labels",
                "Google Shopping / Condition", "Google Shopping / Custom Product", "Google Shopping / Custom Label 0",
                "Google Shopping / Custom Label 1", "Google Shopping / Custom Label 2", "Google Shopping / Custom Label 3",
                "Google Shopping / Custom Label 4", "Variant Image", "Variant Weight Unit", "Variant Tax Code",
                "Cost per item", "Price / Internacional", "Compare At Price / Internacional", "Status"
            }
                sw.WriteLine(String.Join(",", headers))

                While reader.Read()
                    Dim nombre As String = reader.GetString("nombre")
                    Dim referencia As String = reader("referencia").ToString()
                    Dim handle As String = (nombre & "-" & referencia).Replace(" ", "-")
                    Dim title As String = nombre
                    Dim bodyHTML As String = nombre.ToLower()
                    Dim vendor As String = "Elite Joyería"
                    Dim productCategory As String = "Joyería en Ropa y accesorios"

                    Dim marca As Integer = reader.GetInt32("marca")
                    Dim tipo As String = If(marca = 1, "Oro Nacional", If(marca = 2, "Oro Italy", ""))

                    Dim categoria_producto As Integer = reader.GetInt32("categoria_producto")
                    Dim tags As String = ""
                    Select Case categoria_producto
                        Case 4 : tags = "ROSARIOS"
                        Case 5 : tags = "PULSERAS,PULSOS"
                        Case 6 : tags = "DIJES"
                        Case 7 : tags = "ARETES,TOPOS"
                        Case 8 : tags = "ARETES,CANDONGAS"
                        Case 9 : tags = "ANILLOS"
                        Case 11 : tags = "AROS,PULSERAS"
                        Case 12 : tags = "TOBILLERAS"
                        Case 14 : tags = "PULSERAS TEJIDAS,PULSERAS"
                        Case 15 : tags = "HERRAJE"
                        Case 16 : tags = "BOLAS"
                        Case 19 : tags = "CADENAS,CADENAS 45"
                        Case 20 : tags = "CADENAS,CADENAS 50"
                        Case 21 : tags = "CADENAS,CADENAS 55"
                        Case 22 : tags = "CADENAS,CADENAS 60"
                        Case 23 : tags = "CADENAS,CADENAS 65"
                        Case 24 : tags = "CADENAS,CADENAS 70"
                        Case 25 : tags = "CADENAS,CADENAS 40"
                        Case 26 : tags = "ANILLOS,ANILLOS MUJER"
                        Case 27 : tags = "ANILLOS,ANILLOS HOMBRE"
                        Case 29 : tags = "PULSERAS,PULSERAS BEBE"
                        Case 33 : tags = "CADENAS,GARGANTILLAS"
                        Case 44 : tags = "ARETES,TOPOS"
                        Case 38 : tags = "ANILLOS, ANILLOS 15"
                    End Select

                    'Dim referencia As String = reader("referencia").ToString()
                    Dim peso As Double = reader.GetDouble("peso")
                    Dim pesoStr As String = peso.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) ' Con punto
                    Dim valorUnitario As String = reader.GetDecimal("valor_unitario").ToString("0.00").Replace(".", ",") ' Para CSV con coma decimal

                    ' Datos en el mismo orden que las cabeceras
                    Dim rowData As New List(Of String) From {
                    $"""{handle}""",
                    QuoteIfNeeded(title),
                    QuoteIfNeeded(bodyHTML),
                    vendor,
                    productCategory,
                    tipo,
                    $"""{tags}""",
                    "VERDADERO",
                    "Title",
                    "Default Title",
                    "", "", "", "",
                    referencia,
                    pesoStr,
                    "shopify",
                    "",
                    "deny",
                    "manual",
                    QuoteIfNeeded(valorUnitario),
                    "",
                    "VERDADERO",
                    "VERDADERO",
                    "", "", "", "", "FALSO", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "g", "FALSO", "", "", "", "active"
                }

                    sw.WriteLine(String.Join(",", rowData))
                End While

            End Using

            reader.Close()
            conexion.Close()
            MsgBox("Archivo CSV guardado con éxito", vbInformation, "Guardado")

        Catch ex As Exception
            MessageBox.Show("Error al generar CSV: " & ex.Message)
        End Try
    End Sub

    Private Function QuoteIfNeeded(valor As String) As String
        If valor.Contains(",") Or valor.Contains("""") Or valor.Contains("/") Or valor.Contains(">") Then
            Return $"""{valor.Replace("""", """""")}"""
        End If
        Return valor
    End Function

    Dim selectedCompraID As Integer = -1 ' -1 indica que no se ha seleccionado una compra específica
    Dim selectedSucursal As Integer = -1 ' -1 indica que no se ha seleccionado una sucursal específica
    ' Consultar productos por número de compra
    Private Sub lst_compra_consulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_compra_consulta.SelectedIndexChanged
        If lst_compra_consulta.SelectedIndex >= 0 Then
            selectedCompraID = CInt(lst_compra_consulta.SelectedItem)
        Else
            selectedCompraID = -1
        End If
    End Sub
    ' Consultar productos por Sucursal
    Private Sub lst_sucursal_consulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_sucursal_consulta.SelectedIndexChanged
        If lst_sucursal_consulta.SelectedItem IsNot Nothing Then
            Dim selectedSucursalStr As String = lst_sucursal_consulta.SelectedItem.ToString()

            ' Mapear el valor seleccionado a un ID de sucursal real
            Select Case selectedSucursalStr
                Case "Bodega"
                    selectedSucursal = 1
                Case "Detal"
                    selectedSucursal = 2
                Case Else
                    selectedSucursal = -1 ' -1 indica que no se ha seleccionado una sucursal específica
            End Select
        Else
            ' Si no hay ningún elemento seleccionado, puedes asignar el valor por defecto (-1 o lo que prefieras)
            selectedSucursal = -1
        End If
    End Sub
    ' Consultar productos
    Private Sub ConsultarProductos()
        Try
            conexion.Open()
            Dim query As String = "SELECT nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, broche, vbroche, referencia, idcompra FROM productos WHERE " ' Consulta base

            Dim conditions As New List(Of String) ' Lista para almacenar las condiciones de búsqueda

            ' Agregar la condición de número de compra (si se ha seleccionado)
            If selectedCompraID > 0 Then
                conditions.Add("idcompra = @compraID")
            End If

            ' Agregar la condición de sucursal (si se ha seleccionado)
            If selectedSucursal > 0 Then
                conditions.Add("sucursal = @sucursalID")
            End If

            ' Agregar la condición de referencia (si se ha ingresado)
            Dim referencia As String = jt_referencia.Text.Trim()
            If Not String.IsNullOrEmpty(referencia) Then
                conditions.Add("referencia = @referencia")
            End If

            ' Combinar todas las condiciones en una consulta SQL
            If conditions.Count > 0 Then
                query &= String.Join(" AND ", conditions)
            Else
                ' Si no se ha seleccionado ni número de compra ni sucursal, consulta todos los productos
                query &= "1 = 1"
            End If

            ' Crear el comando SQL
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)

            ' Asignar parámetros de consulta según las condiciones seleccionadas
            If selectedCompraID > 0 Then
                cmd.Parameters.AddWithValue("@compraID", selectedCompraID)
            End If

            If selectedSucursal > 0 Then
                cmd.Parameters.AddWithValue("@sucursalID", selectedSucursal)
            End If

            If Not String.IsNullOrEmpty(referencia) Then
                cmd.Parameters.AddWithValue("@referencia", referencia)
            End If

            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            Dim tabla As New System.Data.DataTable()
            adapter.Fill(tabla)

            tb_productos.AutoGenerateColumns = False ' Establecer AutoGenerateColumns en False
            tb_productos.Columns(0).HeaderText = "Referencia"
            tb_productos.Columns(0).DataPropertyName = "referencia"

            tb_productos.Columns(1).HeaderText = "Compra"
            tb_productos.Columns(1).DataPropertyName = "idcompra"

            tb_productos.Columns(2).HeaderText = "Nombre"
            tb_productos.Columns(2).DataPropertyName = "nombre"

            tb_productos.Columns(3).HeaderText = "Marca"
            tb_productos.Columns(3).DataPropertyName = "marca"

            tb_productos.Columns(4).HeaderText = "Cantidad"
            tb_productos.Columns(4).DataPropertyName = "cantidad"

            tb_productos.Columns(5).HeaderText = "Peso"
            tb_productos.Columns(5).DataPropertyName = "peso"

            tb_productos.Columns(6).HeaderText = "Peso Total"
            tb_productos.Columns(6).DataPropertyName = "peso_total"

            tb_productos.Columns(7).HeaderText = "Categoría"
            tb_productos.Columns(7).DataPropertyName = "categoria_producto"

            tb_productos.Columns(8).HeaderText = "Valor Unitario"
            tb_productos.Columns(8).DataPropertyName = "valor_unitario"

            tb_productos.Columns(9).HeaderText = "Costo Total"
            tb_productos.Columns(9).DataPropertyName = "costo_total"

            tb_productos.Columns(10).HeaderText = "Valor Gr"
            tb_productos.Columns(10).DataPropertyName = "valor_gramo"

            tb_productos.Columns(11).HeaderText = "Valor Compra"
            tb_productos.Columns(11).DataPropertyName = "valor_unitario_compra"

            tb_productos.Columns(12).HeaderText = "Broche"
            tb_productos.Columns(12).DataPropertyName = "broche"

            tb_productos.Columns(13).HeaderText = "Valor Broche"
            tb_productos.Columns(13).DataPropertyName = "vbroche"


            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron productos para los filtros seleccionados.")
            Else
                tb_productos.Visible = True ' Mostrar la tabla
                tb_productos.DataSource = tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Friend Sub Tab_Consultar_Click(sender As Object, e As EventArgs) Handles Tab_Consultar.Click
        Try
            ' Conexión a la base de datos
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Dim query As String = "SELECT compra.id, compra.estado, COUNT(productos.id) AS CantidadProductos " &
                                    "FROM compra LEFT JOIN productos ON compra.id = productos.idcompra " &
                                    "GROUP BY compra.id, compra.estado ORDER BY compra.id DESC"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
            Dim tabla As New System.Data.DataTable()
            adapter.Fill(tabla)
            tb_compras.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False
            tb_compras.Columns(0).HeaderText = "Id"
            tb_compras.Columns(0).DataPropertyName = "id"

            tb_compras.Columns(1).HeaderText = "Estado"
            tb_compras.Columns(1).DataPropertyName = "estado"

            tb_compras.Columns(2).HeaderText = "Total productos"
            tb_compras.Columns(2).DataPropertyName = "CantidadProductos"

            tb_compras.Visible = True ' Mostrar tabla
            tb_compras.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_compra_Click(sender As Object, e As EventArgs) Handles btn_compra.Click

        If lst_compra_rep.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione una compra.")
        Else
            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

                Dim selectedCompraID As Integer = CInt(lst_compra_rep.SelectedItem)

                'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
                Dim sql As String = "SELECT referencia, cantidad, valor_unitario_compra FROM productos WHERE idcompra = @compraID "
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                cmd.Parameters.AddWithValue("@compraID", selectedCompraID)
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    MessageBox.Show("No se encontraron registros para la compra especificada.")
                    conexion.Close()
                    Return
                End If
                'Escribir los encabezados de las columnas en la hoja de Excel
                ws.Cell(1, 1).Value = "Código de barras, Referencia o ID EFFI: Artículo"
                ws.Cell(1, 2).Value = "ID Tipo de Egreso"
                ws.Cell(1, 3).Value = "Lote"
                ws.Cell(1, 4).Value = "Serie"
                ws.Cell(1, 5).Value = "Observación"
                ws.Cell(1, 6).Value = "Cantidad *"
                ws.Cell(1, 7).Value = "Precio ud. *"
                ws.Cell(1, 8).Value = "Valor descuento total. *"
                ws.Cell(1, 9).Value = "Código Effi Impuesto"

                'Escribir los datos de la tabla Productos en la hoja de Excel
                Dim row As Integer = 2
                While reader.Read()
                    'Dim id As Integer = reader("id")
                    ws.Cell(row, 1).Value = reader("referencia").ToString() ' Referencia
                    ws.Cell(row, 2).Value = 2
                    ws.Cell(row, 3).Value = "" ' Lote
                    ws.Cell(row, 4).Value = "" ' Serie
                    ws.Cell(row, 5).Value = "" ' Observación
                    Dim cantidad As Integer = reader.GetInt16("cantidad")
                    ws.Cell(row, 6).Value = cantidad.ToString() ' Cantidad
                    Dim v_compra As Decimal = reader.GetDecimal("valor_unitario_compra")
                    Dim cell As IXLCell = ws.Cell(row, 7)
                    cell.Value = v_compra
                    cell.Style.NumberFormat.NumberFormatId = 4 ' Formato numérico sin decimales
                    ws.Cell(row, 8).Value = 0 ' Valor descuento
                    ws.Cell(row, 9).Value = 2 ' Código Effi impuesto

                    row += 1
                End While

                'Cerrar el lector y la conexión a la base de datos
                reader.Close()
                conexion.Close()

                'Guardar el archivo de Excel y cerrar la aplicación Excel
                Dim saveFileDialog1 As New SaveFileDialog()
                saveFileDialog1.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
                saveFileDialog1.Title = "Guardar como"
                saveFileDialog1.ShowDialog()

                If saveFileDialog1.FileName <> "" Then
                    wb.SaveAs(saveFileDialog1.FileName)

                    MsgBox("Archivo guardado con éxito", vbInformation, "Guardado")
                Else
                    MsgBox("Error al guardar el archivo", vbCritical, "Error")
                End If

            Catch ex As Exception
                MessageBox.Show("Error al obtener datos: " + ex.Message)
                conexion.Close()
            Finally

            End Try
        End If
    End Sub
    Private Sub btn_depurar_Click(sender As Object, e As EventArgs) Handles btn_depurar.Click
        Dim autenticacion As New FormAutenticacion()
        autenticacion.ShowDialog()
        If autenticacion.DialogResult = DialogResult.OK Then
            Try
                ' Abrir cuadro de diálogo para seleccionar archivo Excel
                Dim openFileDialog1 As New OpenFileDialog()
                openFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*"
                openFileDialog1.Title = "Seleccionar archivo Excel"
                openFileDialog1.ShowDialog()

                ' Leer archivo Excel
                If openFileDialog1.FileName <> "" Then
                    Using workbook As New XLWorkbook(openFileDialog1.FileName)
                        Dim worksheet = workbook.Worksheet(1)

                        ' Verificar que el archivo tenga una sola columna llamada "Referencia"
                        If worksheet.Cell(1, 1).Value.ToString() = "Referencia" AndAlso worksheet.Cell(1, 2).IsEmpty() Then
                            ' Leer todas las referencias del archivo Excel
                            Dim lastRow As Integer = worksheet.LastRowUsed().RowNumber()
                            Dim referenciaList As New List(Of String)
                            For i As Integer = 2 To lastRow
                                Dim referencia As String = worksheet.Cell(i, 1).Value.ToString()
                                If Not String.IsNullOrEmpty(referencia) Then
                                    referenciaList.Add(referencia)
                                Else
                                    MessageBox.Show("La columna Referencia tiene campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Next

                            If MessageBox.Show("¿Estás seguro de que deseas eliminar los registros seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                ' Construir la consulta SQL con las referencias
                                Dim sql As String = "DELETE FROM productos WHERE referencia IN ('" & String.Join("','", referenciaList.ToArray()) & "')"
                                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                                conexion.Open()
                                cmd.ExecuteNonQuery()
                                conexion.Close()

                                MessageBox.Show("Registros eliminados correctamente.", "Depuración completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("El archivo debe tener una sola columna llamada 'Referencia'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al depurar los registros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
            End Try
        End If
    End Sub
    Private Sub btn_tarifa_precios_Click(sender As Object, e As EventArgs) Handles btn_tarifa_precios.Click

        Try
            'Abrir la conexión a la base de datos
            conexion.Open()

            'Crear un objeto para manejar el archivo de Excel
            Dim wb As New ClosedXML.Excel.XLWorkbook()
            Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

            'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
            Dim sql As String = "SELECT id, referencia, valor_unitario FROM productos"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            'Escribir los encabezados de las columnas en la hoja de Excel
            ws.Cell(1, 1).Value = "ID artículo Effi *"
            ws.Cell(1, 2).Value = "ID tarifa de precio Effi *"
            ws.Cell(1, 3).Value = "Precio antes de impuestos *"

            'Escribir los datos de la tabla Productos en la hoja de Excel
            Dim row As Integer = 2
            While reader.Read()
                'Obtener referencia y manejar los valores NULL
                Dim referencia As String
                If IsDBNull(reader("referencia")) OrElse reader("referencia").ToString() = "" Then
                    referencia = reader("id").ToString() 'Usar el id si referencia es NULL
                Else
                    referencia = reader("referencia").ToString()
                End If

                'Escribir los datos en el archivo de Excel
                ws.Cell(row, 1).Value = referencia 'Referencia o ID
                ws.Cell(row, 2).Value = 1

                Dim v_unitario As Decimal = reader.GetDecimal("valor_unitario")
                ws.Cell(row, 3).Value = v_unitario.ToString()

                row += 1
            End While

            'Cerrar el lector y la conexión a la base de datos
            reader.Close()
            conexion.Close()

            'Guardar el archivo de Excel
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
            saveFileDialog1.Title = "Guardar como"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                wb.SaveAs(saveFileDialog1.FileName)
                MsgBox("Archivo guardado con éxito, recuerde actualizar manualmente el valor de los productos registrados como 'Prenda' ", vbInformation, "Guardado")
            Else
                MsgBox("Error al guardar el archivo", vbCritical, "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles icon_actualizar.Click
        jt_referencia.Text = ""
        lst_compra_consulta.SelectedIndex = -1
        lst_sucursal_consulta.SelectedIndex = -1
    End Sub

    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        Try
            'Abrir la conexión a la base de datos
            conexion.Open()

            'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
            Dim sql As String = "SELECT * FROM productos"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)

            'Crear un objeto para manejar el archivo de Excel
            Dim dt As New DataTable()
            adapter.Fill(dt)

            'Verificar si se encontraron registros
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron productos registrados.")
                conexion.Close()
                Return
            End If

            'Crear un objeto para manejar el archivo de Excel
            Dim wb As New ClosedXML.Excel.XLWorkbook()
            Dim ws = wb.Worksheets.Add("Productos")

            ' Escribir los encabezados de las columnas en la hoja de Excel
            Dim headerRow = New List(Of String())() From {
            New String() {"Id", "Nombre", "Marca", "Cantidad", "Peso", "Peso total", "Categoría producto", "Valor unitario", "Costo total", "Valor gramo", "Valor unitario compra", "Ct", "Sucursal", "Broche", "Valor  broche", "Referencia", "Compra"}
}
            Dim rowIndex As Integer = 1
            Dim colIndex As Integer = 1
            For Each header As String In headerRow(0)
                ws.Cell(rowIndex, colIndex).Value = XLCellValue.FromObject(header)
                colIndex += 1
            Next

            ' Escribir los datos de la tabla Productos en la hoja de Excel
            rowIndex += 1
            For Each row As DataRow In dt.Rows
                colIndex = 1
                For Each column As DataColumn In dt.Columns
                    ws.Cell(rowIndex, colIndex).Value = XLCellValue.FromObject(row(column))
                    colIndex += 1
                Next
                rowIndex += 1
            Next

            'Guardar el archivo de Excel y cerrar la aplicación Excel
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
            saveFileDialog1.Title = "Guardar como"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                wb.SaveAs(saveFileDialog1.FileName)
                MsgBox("Archivo guardado con éxito", vbInformation, "Guardado")
            Else
                MsgBox("Error al guardar el archivo", vbCritical, "Error")
            End If

            'Liberar memoria
            cmd.Dispose()
            adapter.Dispose()
            dt.Dispose()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al generar el archivo: " & ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub Registro_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Cierra la conexión a la base de datos
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        ConsultarProductos()
    End Sub

    Private Sub btn_cerrar1_Click(sender As Object, e As EventArgs) Handles btn_cerrar1.Click
        Dim compra As New Compra()
        compra.StartPosition = FormStartPosition.CenterScreen
        compra.ShowDialog()
    End Sub

    Private Sub btn_agregar_compra_Click(sender As Object, e As EventArgs) Handles btn_agregar_compra.Click
        ' Verificar que estás conectado a la base de datos antes de intentar la inserción.
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If

        Try
            ' Construir la consulta SQL para la inserción en la tabla "compra"
            Dim query As String = "INSERT INTO compra (estado) VALUES (@estado)"
            Dim cmd As New MySqlCommand(query, conexion)

            ' Establecer el valor para el parámetro @estado
            cmd.Parameters.AddWithValue("@estado", "ABIERTA") ' Estado por defecto "ABIERTA".

            ' Ejecutar la consulta de inserción
            cmd.ExecuteNonQuery()

            MessageBox.Show("Compra agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tab_Consultar_Click(Nothing, Nothing)
            ' Notificar al TabPage1 que se ha realizado una inserción
            RaiseEvent NuevaInsercionRealizada()

        Catch ex As Exception
            MessageBox.Show("Error al agregar compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private datosCargados As Boolean = False
    Private Sub CargarDatosComboBoxRep()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            lst_compra_rep.Items.Clear()
            Dim query_compras_rep As String = "SELECT compra.id FROM compra LEFT JOIN productos ON compra.id = productos.idcompra
                                               WHERE compra.estado = 'CERRADA'                                            
                                               GROUP BY compra.id 
                                               HAVING COUNT(productos.id) > 0
                                               ORDER BY compra.id DESC;"
            Dim cmd_compras_rep As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_compras_rep, conexion)
            Dim reader_compras_rep As MySql.Data.MySqlClient.MySqlDataReader = cmd_compras_rep.ExecuteReader()
            While reader_compras_rep.Read()
                lst_compra_rep.Items.Add(reader_compras_rep.GetString(0))
            End While
            reader_compras_rep.Close()
            conexion.Close()
        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show("Se ha producido un error al cargar los datos de las compra Rep: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarDatosComboBox()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            lst_compra.Items.Clear()
            ' Cargar los valores de la tabla compra en el ComboBox lst_compra
            Dim query_compras As String = "SELECT id FROM compra WHERE estado = 'ABIERTA'"
            Dim cmd_compras As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_compras, conexion)
            Dim reader_compras As MySql.Data.MySqlClient.MySqlDataReader = cmd_compras.ExecuteReader()
            While reader_compras.Read()
                lst_compra.Items.Add(reader_compras.GetString(0))
            End While
            lst_compra.Text = "Seleccione"
            reader_compras.Close()
            conexion.Close()

            ' Marcar los datos como cargados
            datosCargados = True
        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show("Error al cargar los datos de las compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ManejarNuevaInsercion()
        ' Actualizar los datos en el ComboBox cuando se realiza una nueva inserción
        CargarDatosComboBox()
    End Sub
    Private Sub TabPage1_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage1.Enter
        AddHandler Me.NuevaInsercionRealizada, AddressOf ManejarNuevaInsercion
        CargarDatosComboBox()
    End Sub
    Private Sub TabPage3_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage3.Enter
        CargarDatosComboBoxRep()
    End Sub

    Private Sub btn_trasladar_Click(sender As Object, e As EventArgs) Handles btn_trasladar.Click
        Try
            If String.IsNullOrEmpty(jt_referencia_traslado.Text) Then
                MessageBox.Show("Por favor, ingrese una referencia para el traslado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            ' Verificar si existe el producto con la referencia proporcionada
            Dim id_producto As Integer
            Using cmdCheck As New MySqlCommand("SELECT id, sucursal FROM productos WHERE referencia = @referencia", conexion)

                cmdCheck.Parameters.AddWithValue("@referencia", jt_referencia_traslado.Text)
                Dim reader As MySqlDataReader = cmdCheck.ExecuteReader()
                If reader.Read() Then
                    id_producto = reader("id")
                    Dim sucursal_actual As Integer = reader("sucursal")
                    reader.Close()
                    ' Hacer el traslado
                    If sucursal_actual = 1 Then
                        ' Traslado de Bodega a Detal
                        TrasladarProducto(id_producto, 2, "D")
                    ElseIf sucursal_actual = 2 Then
                        ' Traslado de Detal a Bodega
                        TrasladarProducto(id_producto, 1, "B")
                    End If
                Else
                    MessageBox.Show("No se encontró un producto con la referencia proporcionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al realizar el traslado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State <> ConnectionState.Closed Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub TrasladarProducto(id_producto As Integer, nueva_sucursal As Integer, prefijo_nueva_referencia As String)

        ' Consultar la última referencia para la nueva sucursal
        Dim ultima_referencia As Integer
        Using cmdRef As New MySqlCommand("SELECT MAX(CAST(SUBSTRING(referencia, 2) AS SIGNED)) FROM productos WHERE sucursal = @idsucursal", conexion)
            cmdRef.Parameters.AddWithValue("@idsucursal", nueva_sucursal)
            Dim resultado As Object = cmdRef.ExecuteScalar()
            If resultado IsNot DBNull.Value Then
                ultima_referencia = Convert.ToInt32(resultado)
            Else
                ultima_referencia = 0
            End If
        End Using

        ' Incrementar el número de referencia
        ultima_referencia += 1

        ' Construir la nueva referencia según la lógica establecida
        Dim nueva_referencia As String = prefijo_nueva_referencia & ultima_referencia

        ' Actualizar los datos del producto
        Using cmdUpdate As New MySqlCommand("UPDATE productos SET sucursal = @nueva_sucursal, referencia = @nueva_referencia WHERE id = @id_producto", conexion)
            cmdUpdate.Parameters.AddWithValue("@nueva_sucursal", nueva_sucursal)
            cmdUpdate.Parameters.AddWithValue("@nueva_referencia", nueva_referencia)
            cmdUpdate.Parameters.AddWithValue("@id_producto", id_producto)
            cmdUpdate.ExecuteNonQuery()
        End Using

        ' Mostrar el mensaje de traslado
        Dim mensaje As String = $"El producto ha sido trasladado de la sucursal {(If(nueva_sucursal = 1, "Detal", "Bodega"))} a {(If(nueva_sucursal = 1, "Bodega", "Detal"))}, la nueva referencia es: {nueva_referencia}"
        MessageBox.Show(mensaje, "Traslado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        jt_referencia_traslado.Clear()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir_reporte.Click
        Dim rangoids As New ImprimirIds
        rangoids.ShowDialog()
    End Sub

    Private Sub btn_actualizar_precios_Click(sender As Object, e As EventArgs) Handles btn_actualizar_precios.Click
        Try
            ' Seleccionar archivo Excel de entrada
            MessageBox.Show("Por favor, seleccione el archivo descargado desde Effi que contiene los IDs y las Referencias de los productos", "Seleccionar archivo de Effi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx"
            openFileDialog1.Title = "Seleccionar archivo con IDs y Referencias"

            If openFileDialog1.ShowDialog() <> DialogResult.OK Then Exit Sub

            ' Leer el archivo Excel
            Dim dicReferencias As New Dictionary(Of String, String) ' referencia -> id
            Using workbook = New XLWorkbook(openFileDialog1.FileName)
                Dim worksheet = workbook.Worksheets.First()
                Dim row = 2
                While Not String.IsNullOrEmpty(worksheet.Cell(row, 1).GetString())
                    Dim id As String = worksheet.Cell(row, 1).GetString()
                    Dim referencia As String = worksheet.Cell(row, 2).GetString()
                    If Not dicReferencias.ContainsKey(referencia) Then
                        dicReferencias.Add(referencia, id)
                    End If
                    row += 1
                End While
            End Using

            btn_actualizar_precios.Enabled = False
            lblProcesando.Visible = True
            ProgressBar1.Visible = True
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = dicReferencias.Count
            ProgressBar1.Value = 0
            Application.DoEvents()

            ' Consultar base de datos
            Dim resultados As New List(Of Tuple(Of String, Decimal)) ' id, valor_unitario
            conexion.Open()
            Dim i As Integer = 0
            For Each ref In dicReferencias.Keys
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT valor_unitario FROM productos WHERE referencia = @referencia LIMIT 1", conexion)
                cmd.Parameters.AddWithValue("@referencia", ref)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    resultados.Add(Tuple.Create(dicReferencias(ref), Convert.ToDecimal(result)))
                End If
                i += 1
                ProgressBar1.Value = i
                Application.DoEvents()
            Next
            conexion.Close()

            ' Crear archivo Excel de salida
            Dim wb As New XLWorkbook()
            Dim ws = wb.Worksheets.Add("Resultados")
            ws.Cell(1, 1).Value = "ID artículo Effi *"
            ws.Cell(1, 2).Value = "ID tarifa de precio Effi *"
            ws.Cell(1, 3).Value = "Precio antes de impuestos *"

            Dim rowIndex As Integer = 2
            For Each item In resultados
                ws.Cell(rowIndex, 1).Value = item.Item1   ' ID 
                ws.Cell(rowIndex, 2).Value = 1            ' ID tarifa fija
                ws.Cell(rowIndex, 3).Value = item.Item2   ' valor_unitario
                rowIndex += 1
            Next

            ' Guardar archivo
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
            saveFileDialog1.Title = "Guardar archivo generado"
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                wb.SaveAs(saveFileDialog1.FileName)
                MsgBox("Archivo generado correctamente.", vbInformation)
                ProgressBar1.Visible = False
                lblProcesando.Visible = False
                btn_actualizar_precios.Enabled = True
            Else
                MsgBox("No se guardó el archivo.", vbExclamation)
                ProgressBar1.Visible = False
                lblProcesando.Visible = False
                btn_actualizar_precios.Enabled = True
            End If

        Catch ex As IOException When ex.Message.Contains("because it is being used by another process")
            MsgBox("El archivo seleccionado está siendo utilizado por otro programa (como Excel). Por favor, cierre el archivo e intente nuevamente.", vbExclamation, "Archivo en uso")
            If conexion.State = ConnectionState.Open Then conexion.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    Private Sub btn_act_automatico_Click(sender As Object, e As EventArgs) Handles btn_act_automatico.Click
        Dim valorTexto As String
        Dim valorEntero As Integer
        Dim valido As Boolean = False

        Do
            ' Mostrar cuadro de entrada
            valorTexto = InputBox("Ingrese el valor del incremento del gramo", "Incremento automático")

            ' Si el usuario presiona Cancelar o deja vacío
            If valorTexto = "" Then
                MessageBox.Show("Operación cancelada o valor vacío.")
                Exit Sub
            End If

            ' Validar que sea número entero
            If Integer.TryParse(valorTexto, valorEntero) Then
                ' Validar que no sea negativo ni cero y que esté dentro del rango
                If valorEntero >= 1000 AndAlso valorEntero <= 30000 Then
                    valido = True
                Else
                    MessageBox.Show("El valor debe estar entre 1000 y 30000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Debe ingresar solo números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Loop Until valido

        ' Si llegó aquí es porque pasó todas las validaciones
        MessageBox.Show("Valor válido ingresado: " & valorEntero, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Aquí puedes usar valorEntero en tu lógica...
        Try

            If lst_marca_tabla.SelectedItem = "Nacional" Then
                Dim query As String = "UPDATE gramonacional_new SET valor = valor + @incremento"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@incremento", valorEntero)
                    conexion.Open()
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Actualización completa. Filas afectadas: " & filasAfectadas, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                MessageBox.Show("Actualización tabla nacional completa.")
                conexion.Close()

                Dim queryActualizacion As String = "
                    UPDATE productos p
                    JOIN gramonacional_new g ON p.ct = g.ct
                    SET p.valor_gramo = g.valor;
                    UPDATE productos p
                    LEFT JOIN broches_new b ON p.broche = b.peso_broche
                    SET 
                        p.vbroche = IFNULL(b.precio_broche, 0),
                        p.valor_unitario = (p.peso * p.valor_gramo) + IFNULL(b.precio_broche, 0) + IFNULL(p.valor_prenda, 0);

                    UPDATE productos
                    SET costo_total = cantidad * valor_unitario;
                "

                Try
                    conexion.Open()
                    Dim comando As New MySql.Data.MySqlClient.MySqlCommand(queryActualizacion, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Actualización nacional masiva completada.")
                    lst_marca_tabla.SelectedIndex = lst_marca_tabla.SelectedIndex
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conexion.Close()
                End Try
            ElseIf lst_marca_tabla.SelectedItem = "Italy" Then
                Dim query As String = "UPDATE gramoitaly_new SET valor = valor + @incremento"
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conexion)
                    cmd.Parameters.AddWithValue("@incremento", valorEntero)
                    conexion.Open()
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Actualización completa. Filas afectadas: " & filasAfectadas, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                MessageBox.Show("Actualización tabla Italy completa.")
                lst_marca_tabla.SelectedIndex = lst_marca_tabla.SelectedIndex
                conexion.Close()

                Dim queryActualizacion As String = "
                    UPDATE productos p
                    JOIN gramoitaly_new g ON p.ct = g.ct
                    SET p.valor_gramo = g.valor;

                    UPDATE broches_new 
                    SET precio_broche = peso_broche * (
                        SELECT valor 
                        FROM gramoitaly_new 
                        WHERE ct = 'ir2-3' 
                        LIMIT 1
                    );

                    UPDATE productos p
                    LEFT JOIN broches_new b ON p.broche = b.peso_broche
                    SET 
                        p.vbroche = IFNULL(b.precio_broche, 0),
                        p.valor_unitario = (p.peso * p.valor_gramo) + IFNULL(b.precio_broche, 0) + IFNULL(p.valor_prenda, 0);

                    UPDATE productos
                    SET costo_total = cantidad * valor_unitario;
                "

                Try
                    conexion.Open()
                    Dim comando As New MySql.Data.MySqlClient.MySqlCommand(queryActualizacion, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Actualización Italy masiva completada.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conexion.Close()
                End Try

            Else
                MessageBox.Show("Seleccione la tabla que desea actualizar.")
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al actualizar la tabla. Detalles del error: " & ex.Message)
        End Try

    End Sub

End Class
