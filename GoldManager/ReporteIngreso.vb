Imports MySql.Data.MySqlClient
Public Class ReporteIngreso
    Private conexion As MySql.Data.MySqlClient.MySqlConnection = New MySql.Data.MySqlClient.MySqlConnection("server=sh00010.hostgator.co;user=carl1020_adminas;password=Safrat2583;database=carl1020_goldmanager_deilux;port=3306")

    Private Sub ReporteIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Try
            conexion.Open()

            ' Cargar los valores de la tabla compra en el ComboBox lst_compra
            Dim query_compras As String = "SELECT id FROM compra ORDER BY id DESC"
            Dim cmd_compras As MySql.Data.MySqlClient.MySqlCommand = New MySql.Data.MySqlClient.MySqlCommand(query_compras, conexion)
            Dim reader_compras As MySql.Data.MySqlClient.MySqlDataReader = cmd_compras.ExecuteReader()
            While reader_compras.Read()
                cmbCompras.Items.Add(reader_compras.GetString(0))
            End While
            cmbCompras.SelectedIndex = 0
            reader_compras.Close()

            conexion.Close()

        Catch ex As Exception
            ' Manejar cualquier excepción que se produzca al intentar abrir la conexión
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_rep_ingreso_Click(sender As Object, e As EventArgs) Handles btn_cancelar_rep_ingreso.Click
        Me.Close()
    End Sub

    Private Sub btn_reporte_ingreso_Click(sender As Object, e As EventArgs) Handles btn_reporte_ingreso.Click

        If cmbCompras.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione una compra")
            Exit Sub
        End If

        Dim selectedCompraID As Integer = CInt(cmbCompras.SelectedItem)
        Dim inicioCategoria As Integer = 2

        Try

            conexion.Open()

            Dim wb As New ClosedXML.Excel.XLWorkbook()
            Dim ws As ClosedXML.Excel.IXLWorksheet = wb.Worksheets.Add("Reporte")

            Dim sql As String = "SELECT referencia, nombre, peso, cantidad, categoria_producto, idcompra, broche, marca
                             FROM productos
                             WHERE idcompra = @compraID
                             ORDER BY categoria_producto"

            Dim cmd As New MySqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@compraID", selectedCompraID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If Not reader.HasRows Then
                MessageBox.Show("No hay productos para esta compra")
                conexion.Close()
                Exit Sub
            End If

            'Encabezados
            ws.Cell(1, 1).Value = "Referencia"
            ws.Cell(1, 2).Value = "Nombre"
            ws.Cell(1, 3).Value = "Peso"
            ws.Cell(1, 4).Value = "Cantidad"
            'ws.Cell(1, 5).Value = "Categoria"
            ws.Cell(1, 5).Value = "Compra"

            ws.Range(1, 1, 1, 5).Style.Font.Bold = True

            Dim row As Integer = 2
            Dim categoriaActual As Integer = -1

            Dim totalCategoriaPeso As Decimal = 0
            Dim totalCategoriaCantidad As Integer = 0

            'Totales globales
            Dim totalNacionalGeneral As Decimal = 0
            Dim totalItalianoGeneral As Decimal = 0

            While reader.Read()

                Dim referencia As String = reader("referencia").ToString()
                Dim nombre As String = reader("nombre").ToString()
                Dim peso As Decimal = Convert.ToDecimal(reader("peso"))
                Dim cantidad As Integer = Convert.ToInt32(reader("cantidad"))
                Dim categoria As Integer = Convert.ToInt32(reader("categoria_producto"))
                Dim compra As Integer = Convert.ToInt32(reader("idcompra"))

                Dim broche As Decimal = 0
                If Not IsDBNull(reader("broche")) Then
                    broche = Convert.ToDecimal(reader("broche"))
                End If

                Dim marca As Integer = Convert.ToInt32(reader("marca"))

                'Si cambia la categoria mostramos total categoría
                If categoriaActual <> -1 And categoria <> categoriaActual Then

                    ws.Cell(row, 2).Value = "Total Categoría"
                    ws.Cell(row, 3).Value = totalCategoriaPeso
                    ws.Cell(row, 4).Value = totalCategoriaCantidad
                    ws.Range(row, 2, row, 4).Style.Font.Bold = True

                    Dim rangoCategoria = ws.Range(inicioCategoria, 1, row, 5)
                    rangoCategoria.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
                    ws.Range(1, 1, 1, 5).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center
                    row += 2
                    inicioCategoria = row

                    totalCategoriaPeso = 0
                    totalCategoriaCantidad = 0

                End If

                categoriaActual = categoria

                'Escribir fila
                ws.Cell(row, 1).Value = referencia
                ws.Cell(row, 2).Value = nombre
                ws.Cell(row, 3).Value = peso
                ws.Cell(row, 4).Value = cantidad
                'ws.Cell(row, 5).Value = categoria
                ws.Cell(row, 5).Value = compra

                'Peso del producto
                Dim pesoProducto As Decimal = peso * cantidad

                'Peso del broche (siempre italiano)
                Dim pesoBroche As Decimal = broche * cantidad

                Dim pesoReal As Decimal = pesoProducto + pesoBroche

                totalCategoriaPeso += pesoReal
                totalCategoriaCantidad += cantidad

                'Producto según marca
                If marca = 1 Then
                    totalNacionalGeneral += pesoProducto
                ElseIf marca = 2 Then
                    totalItalianoGeneral += pesoProducto
                End If

                'Broche siempre italiano
                totalItalianoGeneral += pesoBroche

                row += 1

            End While

            'Último total categoría
            ws.Cell(row, 2).Value = "Total Categoría"
            ws.Cell(row, 3).Value = totalCategoriaPeso
            ws.Cell(row, 4).Value = totalCategoriaCantidad
            ws.Range(row, 2, row, 4).Style.Font.Bold = True

            Dim rangoCategoriaFinal = ws.Range(inicioCategoria, 1, row, 5)
            rangoCategoriaFinal.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            row += 2

            'Totales generales de toda la compra
            ws.Cell(row, 2).Value = "Total Nacional"
            ws.Cell(row, 3).Value = totalNacionalGeneral
            ws.Range(row, 2, row, 3).Style.Font.Bold = True

            row += 1

            ws.Cell(row, 2).Value = "Total Italiano"
            ws.Cell(row, 3).Value = totalItalianoGeneral
            ws.Range(row, 2, row, 3).Style.Font.Bold = True
            Dim rangoReporte = ws.Range(1, 1, row, 5)
            rangoReporte.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Medium

            reader.Close()
            conexion.Close()

            'Formato peso
            ws.Column(3).Style.NumberFormat.Format = "#.##0,##"

            ws.Columns().AdjustToContents()
            'Proteger hoja
            ws.Protect("3lit3")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo Excel (*.xlsx)|*.xlsx"
            saveFileDialog1.Title = "Guardar reporte"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then

                wb.SaveAs(saveFileDialog1.FileName)

                MsgBox("Reporte generado correctamente", MsgBoxStyle.Information)
                Me.Close()

            End If

        Catch ex As Exception

            MessageBox.Show("Error generando reporte: " & ex.Message)
            conexion.Close()

        End Try

    End Sub

End Class