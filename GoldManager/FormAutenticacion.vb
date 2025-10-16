Imports MySql.Data.MySqlClient

Public Class FormAutenticacion
    'Private conexion As MySqlConnection = New MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=shared12.hostgator.co;user=elitejoy_jjaramillo;password=Safra2583*;database=elitejoy_goldmanagerelite;port=3306")
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00002.hostgator.co;user=cdcbfeba_adminelite;password=Safrat2583;database=cdcbfeba_goldmanagerelite;port=3306")
    '("server=shared20.hostgator.co;user=elitejo1_adminelite;password=Safrat2583;database=elitejo1_goldmanagerelite;port=3306")
    Dim formularioRegistro As Registro = CType(Application.OpenForms("Registro"), Registro)

    Private Sub FormAutenticacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jt_clave.UseSystemPasswordChar = True
    End Sub
    Private Function Autenticar(usuario As String, contrasena As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE BINARY nombre = @usuario AND BINARY clave = @contrasena AND permiso_edicion = 1"
        Dim cmd As New MySqlCommand(query, conexion)
        cmd.Parameters.AddWithValue("@usuario", usuario)
        cmd.Parameters.AddWithValue("@contrasena", contrasena)
        conexion.Open()
        Dim count As Integer = cmd.ExecuteScalar()
        conexion.Close()
        If count > 0 Then
            'Me.Close()
            Return True
        Else
            MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            jt_usuario.Text = ""
            jt_clave.Text = ""
            Return False
        End If
    End Function
    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If String.IsNullOrWhiteSpace(jt_usuario.Text) OrElse String.IsNullOrWhiteSpace(jt_clave.Text) Then
            MessageBox.Show("Debe ingresar usuario y contraseña.")
            Return ' Salir del método sin ejecutar la consulta
        End If

        Dim usuario As String = jt_usuario.Text
        Dim contrasena As String = jt_clave.Text

        If Autenticar(usuario, contrasena) Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Private Sub jt_clave_KeyDown(sender As Object, e As KeyEventArgs) Handles jt_clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_ingresar.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class