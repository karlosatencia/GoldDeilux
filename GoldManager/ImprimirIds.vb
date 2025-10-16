Imports ClosedXML.Excel
Imports ClosedXML.Excel.XLPredefinedFormat

Public Class ImprimirIds
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=karlosatencia;password=karlos63527;database=goldmanager")
    'Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=shared12.hostgator.co;user=elitejoy_jjaramillo;password=Safra2583*;database=elitejoy_goldmanagerelite;port=3306")
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00002.hostgator.co;user=cdcbfeba_adminelite;password=Safrat2583;database=cdcbfeba_goldmanagerelite;port=3306")
    '("server=shared20.hostgator.co;user=elitejo1_adminelite;password=Safrat2583;database=elitejo1_goldmanagerelite;port=3306")

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
    Private Sub jt_hasta_KeyDown(sender As Object, e As KeyEventArgs) Handles jt_hasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_imprimir_ids.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Function ValidarInputs() As Boolean
        ' Verificar que se haya ingresado un valor en ambos textBox
        If String.IsNullOrWhiteSpace(jt_desde.Text) OrElse String.IsNullOrWhiteSpace(jt_hasta.Text) Then
            MessageBox.Show("Debe ingresar un valor en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Verificar que el valor de jt_desde y jt_hasta sigan el formato correcto (letra + números)
        Dim regex As New Text.RegularExpressions.Regex("^[A-Za-z]+\d+$")
        If Not regex.IsMatch(jt_desde.Text) OrElse Not regex.IsMatch(jt_hasta.Text) Then
            MessageBox.Show("Debe ingresar valores alfanuméricos válidos en ambos campos (por ejemplo, B100 o D200).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Extraer las partes alfabética y numérica de jt_desde y jt_hasta
        Dim prefixDesde As String = System.Text.RegularExpressions.Regex.Match(jt_desde.Text, "^[A-Za-z]+").Value
        Dim prefixHasta As String = System.Text.RegularExpressions.Regex.Match(jt_hasta.Text, "^[A-Za-z]+").Value
        Dim numeroDesde As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Match(jt_desde.Text, "\d+$").Value)
        Dim numeroHasta As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Match(jt_hasta.Text, "\d+$").Value)

        ' Verificar que los prefijos sean iguales
        If Not prefixDesde.Equals(prefixHasta, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Los prefijos deben ser iguales en ambos campos (por ejemplo, B100 y B200).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Verificar que el valor numérico de jt_hasta sea mayor que el de jt_desde
        If numeroDesde > numeroHasta Then
            MessageBox.Show("El valor numérico de 'Hasta' debe ser mayor o igual al valor numérico de 'Desde'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Si se han pasado todas las validaciones, devolver True
        Return True
    End Function

    Private Sub btn_imprimir_ids_Click(sender As Object, e As EventArgs) Handles btn_imprimir_ids.Click
        If ValidarInputs() Then
            ' Cerrar el formulario para que los valores se puedan utilizar en otro formulario
            Me.DialogResult = DialogResult.OK

            Try
                'Abrir la conexión a la base de datos
                conexion.Open()

                'Crear un objeto para manejar el archivo de Excel
                Dim wb As New ClosedXML.Excel.XLWorkbook()
                Dim ws As IXLWorksheet = wb.Worksheets.Add("Imprimir ids")

                'Obtener los valores de jt_desde y jt_hasta
                Dim jtDesde As String = jt_desde.Text
                Dim jtHasta As String = jt_hasta.Text

                'Separar el prefijo y el número de jtDesde y jtHasta
                Dim prefixDesde As String = System.Text.RegularExpressions.Regex.Match(jtDesde, "^[A-Za-z]+").Value
                Dim numeroDesde As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Match(jtDesde, "\d+$").Value)
                Dim prefixHasta As String = System.Text.RegularExpressions.Regex.Match(jtHasta, "^[A-Za-z]+").Value
                Dim numeroHasta As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Match(jtHasta, "\d+$").Value)

                'Construir la consulta SQL
                Dim sql As String = "SELECT referencia, nombre, cantidad FROM productos WHERE referencia REGEXP @regex AND " &
                                    "CAST(SUBSTRING(referencia, LENGTH(@prefixDesde) + 1) AS UNSIGNED) BETWEEN @numeroDesde AND @numeroHasta"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conexion)
                cmd.Parameters.AddWithValue("@regex", "^" & prefixDesde & "[0-9]+$")
                cmd.Parameters.AddWithValue("@prefixDesde", prefixDesde)
                cmd.Parameters.AddWithValue("@numeroDesde", numeroDesde)
                cmd.Parameters.AddWithValue("@numeroHasta", numeroHasta)

                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                If Not reader.HasRows Then
                    MessageBox.Show("No se encontraron registros para el rango especificado.")
                    conexion.Close()
                    Return
                End If

                'Escribir los encabezados de las columnas en la hoja de Excel
                ws.Cell(1, 1).Value = "Código de referencia"
                ws.Cell(1, 2).Value = "Centímetros"
                ws.Cell(1, 3).Value = "Talla"
                ws.Cell(1, 4).Value = "Cantidad"

                'Escribir los datos de la tabla Productos en la hoja de Excel
                Dim row As Integer = 2
                While reader.Read()
                    ws.Cell(row, 1).Value = reader("referencia").ToString() ' Código de referencia
                    'ws.Cell(row, 2).Value = reader("nombre").ToString() ' Valor auxiliar


                    Dim centimetros As String = ""
                    Dim talla As String = ""
                    Dim nombre As String = ""
                    If Not IsDBNull(reader("nombre")) Then
                        nombre = reader("nombre").ToString()
                    End If
                    ' Usar expresiones regulares para extraer centímetros (e.g., "50 CM")
                    Dim regexCm As New System.Text.RegularExpressions.Regex("\b\d+([.,]\d+)?\s*CM\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    Dim matchCm As System.Text.RegularExpressions.Match = regexCm.Match(nombre)
                    If matchCm.Success Then
                        centimetros = matchCm.Value
                    End If

                    ' Usar expresiones regulares para extraer la talla (e.g., "TALLA 8 1/2")
                    Dim regexTalla As New System.Text.RegularExpressions.Regex("\bTALLA\s+\d+(\s+[1-9]/[1-9])?\b", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    Dim matchTalla As System.Text.RegularExpressions.Match = regexTalla.Match(nombre)
                    If matchTalla.Success Then
                        talla = matchTalla.Value
                    End If

                    ws.Cell(row, 2).Value = centimetros ' Centímetros extraídos
                    ws.Cell(row, 3).Value = talla ' Talla extraída
                    ws.Cell(row, 4).Value = reader.GetInt32("cantidad") ' Cantidad
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
                ' Cerrar la conexión en el bloque finally para asegurarse de que siempre se cierra
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End Try


        End If
    End Sub
End Class
