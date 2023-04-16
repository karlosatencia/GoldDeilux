Imports MySql.Data.MySqlClient
Public Class Registro
    Dim conn As MySqlConnection
    Private conexion As MySqlConnection = New MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cadena de conexión 
        'Dim connStr As String = "server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager"

        ' Inicializar la conexión
        'conn = New MySqlConnection(connStr)

        Try
            ' Abrir la conexión
            'conn.Open()
            conexion.Open()
            MessageBox.Show("La conexión a la base de datos se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Crear un objeto de comando para la consulta SQL
            Dim cmd As New MySqlCommand("SELECT tipo FROM tiposdeproducto", conexion)

            ' Crear un lector de datos para leer los resultados de la consulta
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Agregar cada nombre de tipo de producto al ComboBox
            While reader.Read()
                lst_tipo_producto.Items.Add(reader.GetString("tipo"))
            End While
            lst_tipo_producto.SelectedItem = "Seleccione"
            lst_marca.SelectedIndex = 0
            lst_broche.SelectedIndex = 0
            ' Cerrar el lector de datos y la conexión
            reader.Close()
            'conn.Close()
            conexion.Close()

        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CalcularValorBroche()
        Dim vbroche As Double
        Dim pesoBroche As Decimal

        ' Verificar si hay un elemento seleccionado en lst_broche
        If Not lst_broche.SelectedItem Is Nothing Then
            pesoBroche = Decimal.Parse(lst_broche.SelectedItem.ToString())

            ' Consulta SQL para obtener el precio del broche según su peso
            Dim sql As String = "SELECT valor_broche FROM broches WHERE peso_broche = " & pesoBroche.ToString()
            Dim cmd As New MySqlCommand(sql, conexion)
            Debug.Print(sql)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Verificar si se obtuvo algún resultado y asignar el valor correspondiente
            If reader.Read() Then
                vbroche = CDbl(reader("valor_broche"))
            Else
                vbroche = 0.0
            End If

            ' Cerrar el objeto MySqlDataReader
            reader.Close()

        Else
            ' Si no hay ningún elemento seleccionado en lst_broche, asignar el valor 0.0 a vbroche
            vbroche = 0.0
        End If

        ' Mostrar el valor de ct en el TextBox jt_ct
        jt_valor_broche.Text = vbroche.ToString()
    End Sub


End Class
