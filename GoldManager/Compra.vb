Imports MySql.Data.MySqlClient
Public Class Compra
    'Private conexion As MySqlConnection = New MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=shared12.hostgator.co;user=elitejoy_jjaramillo;password=Safra2583*;database=elitejoy_goldmanagerelite;port=3306")
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00002.hostgator.co;user=cdcbfeba_adminelite;password=Safrat2583;database=cdcbfeba_goldmanagerelite;port=3306")
    '("server=shared20.hostgator.co;user=elitejo1_adminelite;password=Safrat2583;database=elitejo1_goldmanagerelite;port=3306")
    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Try
            conexion.Open()

            ' Cargar los valores de la tabla compra en el ComboBox lst_compra
            Dim query_compras As String = "SELECT id FROM compra where estado = 'ABIERTA'"
            Dim cmd_compras As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_compras, conexion)
            Dim reader_compras As MySql.Data.MySqlClient.MySqlDataReader = cmd_compras.ExecuteReader()
            While reader_compras.Read()
                lst_compra.Items.Add(reader_compras.GetString(0))
            End While
            lst_compra.SelectedItem = "Seleccione"
            reader_compras.Close()

            conexion.Close()

        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        If lst_compra.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione una compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Salir de la función si no se ha seleccionado un valor
        End If
        Dim autenticacion As New FormAutenticacion()
        autenticacion.ShowDialog()
        If autenticacion.DialogResult = DialogResult.OK Then

            Dim idCompra As Integer = CInt(lst_compra.SelectedItem) ' Supongo que obtienes el ID de compra desde el ComboBox.

            ' Realizar la actualización en la base de datos para cambiar el estado a 'CERRADA'.
            Dim queryActualizarCompra As String = "UPDATE compra SET estado = 'CERRADA' WHERE id = @idCompra"

            Using cmdActualizarCompra As New MySqlCommand(queryActualizarCompra, conexion)
                cmdActualizarCompra.Parameters.AddWithValue("@idCompra", idCompra)

                conexion.Open()
                cmdActualizarCompra.ExecuteNonQuery()
                conexion.Close()
            End Using

            MessageBox.Show("Compra cerrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            ' Llamar al evento Tab_Consultar_Click del formulario Registro
            Dim registroForm As Registro = Application.OpenForms.OfType(Of Registro).FirstOrDefault()
            If registroForm IsNot Nothing Then
                registroForm.Tab_Consultar_Click(Nothing, Nothing)
            End If
        End If
    End Sub
End Class