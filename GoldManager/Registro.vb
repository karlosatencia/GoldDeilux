Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel
Imports ClosedXM
Imports System.IO
Imports ExcelDataReader
Imports MySqlConnector
Imports System.Data
Imports DataTable = System.Data.DataTable
Imports ClosedXML.Excel
Imports K4os.Compression.LZ4.Streams

Public Class Registro
    Dim camposValidados As Boolean
    Dim conn As MySql.Data.MySqlClient.MySqlConnection
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")

    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=containers-us-west-66.railway.app;user=root;password=oKTWCfMb5IuoI1BINHEE;database=railway;port=6516")


    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        tb_precios.Columns.Cast(Of DataGridViewColumn)().ToList().ForEach(Sub(c) c.SortMode = DataGridViewColumnSortMode.NotSortable)
        tb_productos.Columns.Cast(Of DataGridViewColumn)().ToList().ForEach(Sub(c) c.SortMode = DataGridViewColumnSortMode.NotSortable)
        Dim widths() As Integer = {50, 300, 50, 60, 50, 80, 70, 100, 100, 100, 110}
        For i As Integer = 0 To tb_productos.Columns.Count - 1
            tb_productos.Columns(i).Width = widths(i)
        Next
        tb_productos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        tb_productos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Try
            conexion.Open()
            'MessageBox.Show("La conexión a la base de datos se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            Dim query_broches As String = "SELECT peso_broche FROM broches"
            Dim cmd_broches As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_broches, conexion)
            Dim reader_broches As MySql.Data.MySqlClient.MySqlDataReader = cmd_broches.ExecuteReader()
            While reader_broches.Read()
                lst_broche.Items.Add(reader_broches.GetDecimal(0))
            End While
            lst_broche.Items.Insert(0, "Seleccione")
            lst_broche.SelectedIndex = 0
            'lst_broche.SelectedItem = "Seleccione"
            reader_broches.Close()

            conexion.Close()
            jt_peso_total.Text = "Pendiente"

        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function CalcularValorBroche(pesoBroche As Double) As Integer
        Dim valorBroche As Integer = 0
        Try
            conexion.Open()
            Dim query As String = "SELECT precio_broche FROM broches WHERE peso_broche = @pesoBroche"
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
        Dim query As String = "SELECT valor FROM gramonacional WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
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
        Dim query As String = "SELECT valor FROM gramoitaly WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
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

        Dim query As String = "SELECT ct FROM gramonacional WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
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
        'conexion.Close()

        Return ct
    End Function
    Private Function ObtenerCtItaly(peso As Decimal, categoriaPrecio As String) As String
        If jt_peso.Text = "" Or lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            Return ""
        End If

        Dim query As String = "SELECT ct FROM gramoitaly WHERE peso_inicial <= @peso AND peso_final >= @peso AND categoria_precio = @categoria_precio;"
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
        'conexion.Close()

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
                pesoTotal = cantidad * peso
                jt_peso_total.Text = pesoTotal.ToString()
            End If
        Else
            jt_peso_total.Text = "Pendiente"
        End If
    End Sub
    Private Sub ActualizarNombreCompleto()
        Dim nombreCompuesto As String = ""
        If lst_marca.Text = "Italy" Then
            If lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr "
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +2 " & jt_peso.Text & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr "
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr "
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr "
            ElseIf jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_largo.Text & " Cm"
            Else
                nombreCompuesto = lst_tipo_producto.Text & " Italy " & jt_descripcion.Text & " " & jt_peso.Text & " Gr "
            End If
        Else
            If lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr " & jt_largo.Text & " cm "
            ElseIf lst_categoria_precio.Text = "Recargo +1" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +1 " & jt_peso.Text & " Gr "

            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr " & jt_largo.Text & " cm "
            ElseIf lst_categoria_precio.Text = "Recargo +2" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +2 " & jt_peso.Text & " Gr "

            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr " & jt_largo.Text & " cm "
            ElseIf lst_categoria_precio.Text = "Recargo +3" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +3 " & jt_peso.Text & " Gr "

            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr " & jt_largo.Text & " cm "
            ElseIf lst_categoria_precio.Text = "Recargo +4" And jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " +4 " & jt_peso.Text & " Gr "

            ElseIf jt_grosor.Text <> "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm " & jt_largo.Text & " Cm"
            ElseIf jt_grosor.Text <> "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_grosor.Text & " mm "
            ElseIf jt_grosor.Text = "" And jt_largo.Text <> "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " " & jt_peso.Text & " Gr " & jt_largo.Text & " Cm"
            ElseIf jt_grosor.Text = "" And jt_largo.Text = "" Then
                nombreCompuesto = lst_tipo_producto.Text & " " & jt_descripcion.Text & " " & jt_peso.Text & " Gr "
            End If
        End If
        jt_nombre_compuesto.Text = nombreCompuesto
    End Sub
    Private Sub validarCampos()
        camposValidados = False
        If lst_tipo_producto.SelectedItem.ToString() = "Seleccione" Then
            MessageBox.Show("Seleccione el tipo de producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lst_tipo_producto.Focus()
        ElseIf lst_tipo_producto.SelectedItem.ToString() = "Anillo" And rb_mujer.Checked = False And rb_hombre.Checked = False Then
            MessageBox.Show("Seleccione si es Anillo Mujer o Anillo Hombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf jt_descripcion.Text = "" Then
            MessageBox.Show("Ingrese una descripción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_descripcion.Focus()
        ElseIf (lst_tipo_producto.SelectedItem.ToString() = "Cadena" Or lst_tipo_producto.SelectedItem.ToString() = "Pulsera" Or lst_tipo_producto.SelectedItem.ToString() = "Tobillera" Or lst_tipo_producto.SelectedItem.ToString() = "Pulso" Or lst_tipo_producto.SelectedItem.ToString() = "Rosario") And jt_largo.Text = "" Then
            MessageBox.Show("Ingrese el largo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_largo.Focus()
        ElseIf lst_marca.SelectedItem.ToString() = "Seleccione" Then
            MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lst_marca.Focus()
        ElseIf jt_peso.Text = "" Or Val(jt_peso.Text) = 0 Then
            MessageBox.Show("Ingrese el peso del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_peso.Focus()
        ElseIf lst_categoria_precio.SelectedItem.ToString() = "Seleccione" Then
            MessageBox.Show("Seleccione la categoría del precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lst_categoria_precio.Focus()
        ElseIf jt_cantidad.Text = "" Or Val(jt_cantidad.Text) = 0 Then
            MessageBox.Show("Ingrese la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_cantidad.Focus()
        ElseIf jt_compra.Text = "" Or Val(jt_compra.Text) = 0 Then
            MessageBox.Show("Ingrese el valor (Compra) del gramo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_cantidad.Focus()
        Else
            camposValidados = True
        End If
    End Sub
    Private Sub registrar_producto()
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
                End If
            End If
            ' Cálculo del valor_unitario_compra
            Dim valor_unitario_compra As Decimal = Convert.ToDecimal(jt_peso.Text) * Convert.ToDecimal(jt_compra.Text)
            Dim ct As String = ""
            If lst_marca.Text = "Nacional" Then
                ct = ObtenerCtNacional(Convert.ToDecimal(jt_peso.Text), lst_categoria_precio.SelectedItem.ToString())
            ElseIf lst_marca.Text = "Italy" Then
                ct = ObtenerCtItaly(Convert.ToDecimal(jt_peso.Text), lst_categoria_precio.SelectedItem.ToString())
            End If

            ' Inserción de datos en la tabla productos
            Dim query As String = "INSERT INTO productos (nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, ct) VALUES (@nombre, @marca, @cantidad, @peso, @peso_total, @categoria_producto, @valor_unitario, @costo_total, @valor_gramo, @valor_unitario_compra, @ct)"
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
                cmd.ExecuteNonQuery()
            End Using

            ' Obtener el último id registrado
            Dim lastInsertedId As Integer
            Using cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT LAST_INSERT_ID()", conexion)
                lastInsertedId = CInt(cmd.ExecuteScalar())
            End Using

            MessageBox.Show("Producto registrado correctamente. Id: " & lastInsertedId, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lst_tipo_producto.Text = "Seleccione"
            lst_tipo_producto.Text = "Seleccione"

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
        ' Ocultar los botones btn_actualizar y btn_cancelar
        btn_actualizar.Visible = False
        btn_cancelar.Visible = False
        btn_actualizar_valores.Enabled = True
        Try
            conexion.Open()
            Dim query As String = "SELECT peso_inicial, peso_final, categoria_precio, valor FROM gramonacional"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
            'Dim tabla As New DataTable()
            Dim tabla As New System.Data.DataTable()

            adapter.Fill(tabla)
            tb_precios.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False

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
                Dim query As String = "UPDATE gramonacional SET valor = @valor WHERE id = @id"
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
                'ActualizarPreciosNacionalExistentes()
                MessageBox.Show("Actualización completa.")
                tb_precios.ReadOnly = True
                tb_precios.Columns("valor").ReadOnly = True
                ' Ocultar los botones btn_actualizar y btn_cancelar
                btn_actualizar.Visible = False
                btn_cancelar.Visible = False
                btn_actualizar_valores.Enabled = True

                conexion.Close()
                ActualizarValorGramoNacional()
                ActualizarValorUnitarioNacional()
                ActualizarCostosTotalesNacional()
            ElseIf lst_marca_tabla.SelectedItem = "Italy" Then
                Dim query As String = "UPDATE gramoitaly SET valor = @valor WHERE id = @id"
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
                ActualizarValorGramoItaly()
                ActualizarValorUnitarioNacional()
                ActualizarCostosTotalesNacional()
                MsgBox("Actualización completa.", vbInformation, "Éxito")
                tb_precios.ReadOnly = True
                tb_precios.Columns("valor").ReadOnly = True
                ' Ocultar los botones btn_actualizar y btn_cancelar
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
        Dim consultaGramo As String = "SELECT ct, valor FROM gramonacional"
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
            'MsgBox("Actualizado el valor del gramo en productos registrados")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub ActualizarValorUnitarioNacional()
        Dim consultaProductos As String = "SELECT id, peso, valor_gramo FROM productos"
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

                Dim valorUnitarioActual As Decimal = pesoActual * valorGramo
                Dim updateValorUnitario As String = "UPDATE productos SET valor_unitario = @valorUnitarioActual WHERE id = @idActual"

                Using comandoUpdateValorUnitario As New MySql.Data.MySqlClient.MySqlCommand(updateValorUnitario, conexion)
                    comandoUpdateValorUnitario.Parameters.AddWithValue("@valorUnitarioActual", valorUnitarioActual)
                    comandoUpdateValorUnitario.Parameters.AddWithValue("@idActual", idActual)
                    comandoUpdateValorUnitario.ExecuteNonQuery()
                End Using
            Next

            'MsgBox("Actualizado el valor unitario")
        Finally
            conexion.Close()
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

            'MsgBox("Actualizado el costo total")
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub ActualizarValorGramoItaly()
        Dim consultaGramo As String = "SELECT ct, valor FROM gramoitaly"
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
            'MsgBox("Actualizado el valor del gramo Italy")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_effy_Click(sender As Object, e As EventArgs) Handles btn_effy.Click
        Dim rangoIdsForm As New RangoIds()
        If rangoIdsForm.ShowDialog() = DialogResult.OK Then
            Dim valorDesde As Integer = Integer.Parse(rangoIdsForm.jt_desde.Text)
            Dim valorHasta As Integer = Integer.Parse(rangoIdsForm.jt_hasta.Text)
            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

                'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
                Dim sql As String = "SELECT * FROM productos WHERE ID BETWEEN " & valorDesde & " AND " & valorHasta
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
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
                ws.Cell(1, 20).Value = "Valor referencia"
                ws.Cell(1, 21).Value = "Porcentaje referencia"

                'Escribir los datos de la tabla Productos en la hoja de Excel
                Dim row As Integer = 2
                While reader.Read()
                    ws.Cell(row, 1).Value = reader.GetString(1) ' Nombre
                    ws.Cell(row, 2).Value = reader.GetString(0) ' ID
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
                    ws.Cell(row, 18).Value = reader.GetDecimal(7) ' Costo
                    ws.Cell(row, 19).Value = "" ' Precio mínimo venta
                    ws.Cell(row, 20).Value = reader.GetDecimal(4) ' Valor referencia
                    ws.Cell(row, 21).Value = "" ' Porcentaje referencia
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
        Dim rangoIdsForm As New RangoIds()
        If rangoIdsForm.ShowDialog() = DialogResult.OK Then
            Dim valorDesde As Integer = Integer.Parse(rangoIdsForm.jt_desde.Text)
            Dim valorHasta As Integer = Integer.Parse(rangoIdsForm.jt_hasta.Text)
            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

                'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
                Dim sql As String = "SELECT id, nombre, marca, peso, categoria_producto, valor_unitario FROM productos WHERE ID BETWEEN " & valorDesde & " AND " & valorHasta
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    MessageBox.Show("No se encontraron registros en el rango de IDs especificado.")
                    conexion.Close()
                    Return
                End If
                'Agregamos las columnas
                ws.Cell(1, 1).Value = "Handle"
                ws.Cell(1, 2).Value = "Title"
                ws.Cell(1, 3).Value = "Body (HTML)"
                ws.Cell(1, 4).Value = "Vendor"
                ws.Cell(1, 5).Value = "Product Category"
                ws.Cell(1, 6).Value = "Type"
                ws.Cell(1, 7).Value = "Tags"
                ws.Cell(1, 8).Value = "Published"
                ws.Cell(1, 9).Value = "Option1 Name"
                ws.Cell(1, 10).Value = "Option1 Value"
                ws.Cell(1, 11).Value = "Option2 Name"
                ws.Cell(1, 12).Value = "Option2 Value"
                ws.Cell(1, 13).Value = "Option3 Name"
                ws.Cell(1, 14).Value = "Option3 Value"
                ws.Cell(1, 15).Value = "Variant SKU"
                ws.Cell(1, 16).Value = "Variant Grams"
                ws.Cell(1, 17).Value = "Variant Inventory Tracker"
                ws.Cell(1, 18).Value = "Variant Inventory Qty"
                ws.Cell(1, 19).Value = "Variant Inventory Policy"
                ws.Cell(1, 20).Value = "Variant Fulfillment Service"
                ws.Cell(1, 21).Value = "Variant Price"
                ws.Cell(1, 22).Value = "Variant Compare At Price"
                ws.Cell(1, 23).Value = "Variant Requires Shipping"
                ws.Cell(1, 24).Value = "Variant Taxable"
                ws.Cell(1, 25).Value = "Variant Barcode"
                ws.Cell(1, 26).Value = "Image Src"
                ws.Cell(1, 27).Value = "Image Position"
                ws.Cell(1, 28).Value = "Image Alt Text"
                ws.Cell(1, 29).Value = "Gift Card"
                ws.Cell(1, 30).Value = "SEO Title"
                ws.Cell(1, 31).Value = "SEO Description"
                ws.Cell(1, 32).Value = "Google Shopping / Google Product Category"
                ws.Cell(1, 33).Value = "Google Shopping / Gender"
                ws.Cell(1, 34).Value = "Google Shopping / Age Group"
                ws.Cell(1, 35).Value = "Google Shopping / MPN"
                ws.Cell(1, 36).Value = "Google Shopping / AdWords Grouping"
                ws.Cell(1, 37).Value = "Google Shopping / AdWords Labels"
                ws.Cell(1, 38).Value = "Google Shopping / Condition"
                ws.Cell(1, 39).Value = "Google Shopping / Custom Product"
                ws.Cell(1, 40).Value = "Google Shopping / Custom Label 0"
                ws.Cell(1, 41).Value = "Google Shopping / Custom Label 1"
                ws.Cell(1, 42).Value = "Google Shopping / Custom Label 2"
                ws.Cell(1, 43).Value = "Google Shopping / Custom Label 3"
                ws.Cell(1, 44).Value = "Google Shopping / Custom Label 4"
                ws.Cell(1, 45).Value = "Variant Image"
                ws.Cell(1, 46).Value = "Variant Weight Unit"
                ws.Cell(1, 47).Value = "Variant Tax Code"
                ws.Cell(1, 48).Value = "Cost per item"
                ws.Cell(1, 49).Value = "Price / Internacional"
                ws.Cell(1, 50).Value = "Compare At Price / Internacional"
                ws.Cell(1, 51).Value = "Status"

                Dim row As Integer = 2 'Iniciamos en la segunda fila para agregar los datos a partir de allí
                While reader.Read() 'Mientras haya datos en el resultado de la consulta
                    'Obtenemos el valor del campo nombre y eliminamos los espacios en blanco
                    Dim nombre As String = reader.GetString("nombre").Replace(" ", "-")
                    'Agregamos el valor en la columna Handle de la fila correspondiente
                    ws.Cell(row, 1).Value = nombre
                    ws.Cell(row, 2).Value = reader("nombre").ToString()
                    ws.Cell(row, 3).Value = reader("nombre").ToString()
                    ws.Cell(row, 4).Value = "Elite Joyeria"
                    ws.Cell(row, 5).Value = "Ropa y accesorios > Joyería"

                    Dim marca As Integer = reader.GetInt32("marca")
                    Dim type As String = ""
                    If marca = 1 Then
                        type = "Oro Nacional"
                    ElseIf marca = 2 Then
                        type = "Oro Italy"
                    End If
                    ws.Cell(row, 6).Value = type

                    Dim categoria_producto As Integer = reader.GetInt32("categoria_producto")
                    Dim tags As String
                    Select Case categoria_producto
                        Case 4
                            tags = "ROSARIOS"
                        Case 5
                            tags = "PULSERAS,PULSOS"
                        Case 6
                            tags = "DIJES"
                        Case 7
                            tags = "ARETES,TOPOS"
                        Case 8
                            tags = "ARETES,CANDONGAS"
                        Case 9
                            tags = "ANILLOS"
                        Case 11
                            tags = "AROS,PULSERAS"
                        Case 12
                            tags = "TOBILLERAS"
                        Case 14
                            tags = "PULSERAS TEJIDAS,PULSERAS"
                        Case 15
                            tags = "HERRAJE"
                        Case 16
                            tags = "BOLAS"
                        Case 19
                            tags = "CADENAS,CADENA 45"
                        Case 20
                            tags = "CADENAS,CADENA 50"
                        Case 21
                            tags = "CADENAS,CADENA 55"
                        Case 22
                            tags = "CADENAS,CADENA 60"
                        Case 23
                            tags = "CADENAS,CADENA 65"
                        Case 24
                            tags = "CADENAS,CADENA 70"
                        Case 25
                            tags = "CADENAS,CADENA 40"
                        Case 26
                            tags = "ANILLOS,ANILLOS MUJER"
                        Case 27
                            tags = "ANILLOS,ANILLOS HOMBRE"
                        Case 29
                            tags = "PULSERAS,PULSERAS BEBE"
                        Case 33
                            tags = "CADENAS,GARGANTILLAS"
                        Case Else
                            tags = ""
                    End Select
                    ws.Cell(row, 7).Value = tags
                    ws.Cell(row, 8).Value = "VERDADERO"
                    ws.Cell(row, 9).Value = "Title"
                    ws.Cell(row, 10).Value = "Default Title"
                    ws.Cell(row, 11).Value = ""
                    ws.Cell(row, 12).Value = ""
                    ws.Cell(row, 13).Value = ""
                    ws.Cell(row, 14).Value = ""
                    Dim id As Integer = reader("id")
                    ws.Cell(row, 15).Value = id.ToString()
                    Dim peso As Double = reader.GetDouble("peso")
                    ws.Cell(row, 16).Value = peso.ToString()
                    ws.Cell(row, 17).Value = "shopify"
                    ws.Cell(row, 18).Value = ""
                    ws.Cell(row, 19).Value = "deny"
                    ws.Cell(row, 20).Value = "manual"
                    Dim vunitario As String
                    vunitario = reader.GetDecimal("valor_unitario")
                    ws.Cell(row, 21).Value = vunitario
                    ws.Cell(row, 22).Value = ""
                    ws.Cell(row, 23).Value = "VERDADERO"
                    ws.Cell(row, 24).Value = "VERDADERO"
                    ws.Cell(row, 25).Value = ""
                    ws.Cell(row, 26).Value = ""
                    ws.Cell(row, 27).Value = ""
                    ws.Cell(row, 28).Value = ""
                    ws.Cell(row, 29).Value = "FALSO"
                    ws.Cell(row, 30).Value = ""
                    ws.Cell(row, 31).Value = ""
                    ws.Cell(row, 32).Value = ""
                    ws.Cell(row, 33).Value = ""
                    ws.Cell(row, 34).Value = ""
                    ws.Cell(row, 35).Value = ""
                    ws.Cell(row, 36).Value = ""
                    ws.Cell(row, 37).Value = ""
                    ws.Cell(row, 38).Value = ""
                    ws.Cell(row, 39).Value = ""
                    ws.Cell(row, 40).Value = ""
                    ws.Cell(row, 41).Value = ""
                    ws.Cell(row, 42).Value = ""
                    ws.Cell(row, 43).Value = ""
                    ws.Cell(row, 44).Value = ""
                    ws.Cell(row, 45).Value = ""
                    ws.Cell(row, 46).Value = "g"
                    ws.Cell(row, 47).Value = "FALSO"
                    ws.Cell(row, 48).Value = ""
                    ws.Cell(row, 49).Value = ""
                    ws.Cell(row, 50).Value = ""
                    ws.Cell(row, 51).Value = "active"
                    row += 1 'Incrementamos el número de fila para agregar los siguientes datos en la siguiente fila
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
                MessageBox.Show("Ha ocurrido un error al generar el archivo: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Tab_Consultar_Click(sender As Object, e As EventArgs) Handles Tab_Consultar.Click
        Try
            conexion.Open()
            Dim query As String = "SELECT id, nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra FROM productos"
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
            Dim tabla As New System.Data.DataTable()
            adapter.Fill(tabla)
            tb_productos.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False

            ' Asignar los nombres de columna personalizados a cada una de las columnas del control
            tb_productos.Columns(0).HeaderText = "ID"
            tb_productos.Columns(0).DataPropertyName = "id"

            tb_productos.Columns(1).HeaderText = "Nombre"
            tb_productos.Columns(1).DataPropertyName = "nombre"

            tb_productos.Columns(2).HeaderText = "Marca"
            tb_productos.Columns(2).DataPropertyName = "marca"

            tb_productos.Columns(3).HeaderText = "Cantidad"
            tb_productos.Columns(3).DataPropertyName = "cantidad"

            tb_productos.Columns(4).HeaderText = "Peso"
            tb_productos.Columns(4).DataPropertyName = "peso"

            tb_productos.Columns(5).HeaderText = "Peso Total"
            tb_productos.Columns(5).DataPropertyName = "peso_total"

            tb_productos.Columns(6).HeaderText = "Categoría"
            tb_productos.Columns(6).DataPropertyName = "categoria_producto"

            tb_productos.Columns(7).HeaderText = "Valor Unitario"
            tb_productos.Columns(7).DataPropertyName = "valor_unitario"

            tb_productos.Columns(8).HeaderText = "Costo Total"
            tb_productos.Columns(8).DataPropertyName = "costo_total"

            tb_productos.Columns(9).HeaderText = "Valor Gr"
            tb_productos.Columns(9).DataPropertyName = "valor_gramo"

            tb_productos.Columns(10).HeaderText = "Valor Gr (Compra)"
            tb_productos.Columns(10).DataPropertyName = "valor_unitario_compra"

            tb_productos.Visible = True ' Mostrar tabla
            tb_productos.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btn_compra_Click(sender As Object, e As EventArgs) Handles btn_compra.Click
        Dim rangoIdsForm As New RangoIds()
        If rangoIdsForm.ShowDialog() = DialogResult.OK Then
            Dim valorDesde As Integer = Integer.Parse(rangoIdsForm.jt_desde.Text)
            Dim valorHasta As Integer = Integer.Parse(rangoIdsForm.jt_hasta.Text)
            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Productos")

                'Ejecutar la consulta SQL para obtener los datos de la tabla Productos
                Dim sql As String = "SELECT id, cantidad, valor_unitario_compra FROM productos WHERE ID BETWEEN " & valorDesde & " AND " & valorHasta
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    MessageBox.Show("No se encontraron registros en el rango de IDs especificado.")
                    conexion.Close()
                    Return
                End If
                'Escribir los encabezados de las columnas en la hoja de Excel
                ws.Cell(1, 1).Value = "Código de barras, Referencia o ID Effi: Artículo *"
                ws.Cell(1, 2).Value = "Lote"
                ws.Cell(1, 3).Value = "Serie"
                ws.Cell(1, 4).Value = "Observación"
                ws.Cell(1, 5).Value = "Cantidad *"
                ws.Cell(1, 6).Value = "Precio ud. *"
                ws.Cell(1, 7).Value = "Valor descuento total. *"
                ws.Cell(1, 8).Value = "Código Effi Impuesto"

                'Escribir los datos de la tabla Productos en la hoja de Excel
                Dim row As Integer = 2
                While reader.Read()
                    Dim id As Integer = reader("id")
                    ws.Cell(row, 1).Value = id.ToString() ' ID
                    ws.Cell(row, 2).Value = "" ' Lote
                    ws.Cell(row, 3).Value = "" ' Serie
                    ws.Cell(row, 4).Value = "" ' Observación
                    Dim cantidad As Integer = reader.GetInt16("cantidad")
                    ws.Cell(row, 5).Value = cantidad.ToString() ' Cantidad
                    Dim v_compra As Decimal = reader.GetDecimal("valor_unitario_compra")
                    ws.Cell(row, 6).Value = v_compra.ToString() ' Valor unitario de compra
                    ws.Cell(row, 7).Value = 0 ' Valor descuento
                    ws.Cell(row, 8).Value = 2 ' Código Effi impuesto

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

                        ' Verificar que el archivo tenga una sola columna llamada "ID"
                        If worksheet.Cell(1, 1).Value.ToString() = "ID" AndAlso worksheet.Cell(1, 2).IsEmpty() Then
                            ' Leer todos los ID del archivo Excel
                            Dim lastRow As Integer = worksheet.LastRowUsed().RowNumber()
                            Dim idList As New List(Of String)
                            For i As Integer = 2 To lastRow
                                Dim id As String = worksheet.Cell(i, 1).Value.ToString()
                                If Not String.IsNullOrEmpty(id) Then
                                    ' Validar que el valor del ID sea numérico
                                    If IsNumeric(id) Then
                                        idList.Add(id)
                                    Else
                                        MessageBox.Show("La columna ID contiene datos que no son numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("La columna ID tiene campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Next
                            If MessageBox.Show("¿Estás seguro de que deseas eliminar los registros seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim sql As String = "DELETE FROM productos WHERE id IN (" & String.Join(",", idList.ToArray()) & ")"
                                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                                conexion.Open()
                                cmd.ExecuteNonQuery()
                                conexion.Close()

                                MessageBox.Show("Registros eliminados correctamente.", "Depuración completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Tab_Consultar_Click(sender, e)

                            End If
                        Else
                            MessageBox.Show("El archivo debe tener una sola columna llamada 'ID'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Catch ex As InvalidCastException
                MessageBox.Show("La columna ID contiene datos que no son numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.Close()
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
            Dim sql As String = "SELECT id, valor_unitario FROM productos"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            'Escribir los encabezados de las columnas en la hoja de Excel
            ws.Cell(1, 1).Value = "ID artículo Effi *"
            ws.Cell(1, 2).Value = "ID tarifa de precio Effi *"
            ws.Cell(1, 3).Value = "Precio antes de impuestos *"

            'Escribir los datos de la tabla Productos en la hoja de Excel
            Dim row As Integer = 2
            While reader.Read()
                Dim id As Integer = reader("id")
                ws.Cell(row, 1).Value = id.ToString() ' ID

                ws.Cell(row, 2).Value = 1

                Dim v_unitario As Decimal = reader.GetDecimal("valor_unitario")
                ws.Cell(row, 3).Value = v_unitario.ToString()

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
                '        xlWorkBook.SaveAs(saveFileDialog1.FileName)
                '        xlWorkBook.Close()
                '        xlApp.Quit()
                MsgBox("Archivo guardado con éxito", vbInformation, "Guardado")
            Else
                MsgBox("Error al guardar el archivo", vbCritical, "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
            conexion.Close()
        Finally

        End Try
    End Sub

    Private Sub btn_consultar_id_Click(sender As Object, e As EventArgs) Handles btn_consultar_id.Click
        Dim idConsulta As Integer
        ' Validar que el ID ingresado sea un número entero válido
        If Not Integer.TryParse(jt_id_consulta.Text, idConsulta) Then
            MessageBox.Show("El ID ingresado no es válido.")
            Return
        End If

        ' Consultar los datos de la tabla de productos para el ID especificado
        Try
            conexion.Open()
            Dim query As String = "SELECT id, nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra FROM productos WHERE id = " + idConsulta.ToString()
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
            Dim tabla As New System.Data.DataTable()
            adapter.Fill(tabla)

            ' Mostrar los datos en la DataTable
            tb_productos.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False
            tb_productos.Columns(0).HeaderText = "ID"
            tb_productos.Columns(0).DataPropertyName = "id"
            tb_productos.Columns(1).HeaderText = "Nombre"
            tb_productos.Columns(1).DataPropertyName = "nombre"
            tb_productos.Columns(2).HeaderText = "Marca"
            tb_productos.Columns(2).DataPropertyName = "marca"
            tb_productos.Columns(3).HeaderText = "Cantidad"
            tb_productos.Columns(3).DataPropertyName = "cantidad"
            tb_productos.Columns(4).HeaderText = "Peso"
            tb_productos.Columns(4).DataPropertyName = "peso"
            tb_productos.Columns(5).HeaderText = "Peso Total"
            tb_productos.Columns(5).DataPropertyName = "peso_total"
            tb_productos.Columns(6).HeaderText = "Categoría"
            tb_productos.Columns(6).DataPropertyName = "categoria_producto"
            tb_productos.Columns(7).HeaderText = "Valor Unitario"
            tb_productos.Columns(7).DataPropertyName = "valor_unitario"
            tb_productos.Columns(8).HeaderText = "Costo Total"
            tb_productos.Columns(8).DataPropertyName = "costo_total"
            tb_productos.Columns(9).HeaderText = "Valor Gr"
            tb_productos.Columns(9).DataPropertyName = "valor_gramo"
            tb_productos.Columns(10).HeaderText = "Valor Gr (Compra)"
            tb_productos.Columns(10).DataPropertyName = "valor_unitario_compra"

            ' Verificar si se encontraron resultados
            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron resultados para el ID especificado.")
            Else
                ' Mostrar la DataTable
                tb_productos.Visible = True
                tb_productos.DataSource = tabla
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " + ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles icon_actualizar.Click
        Tab_Consultar_Click(sender, e)
        jt_id_consulta.Text = ""
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
    New String() {"Id", "Nombre", "Marca", "Cantidad", "Peso", "Peso total", "Categoría producto", "Valor unitario", "Costo total", "Valor gramo", "Valor unitario compra", "Ct"}
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

End Class
