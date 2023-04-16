Imports MySqlConnector

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lst_tipo_producto = New ComboBox()
        lst_marca = New ComboBox()
        lst_categoria_precio = New ComboBox()
        lst_broche = New ComboBox()
        jt_descripcion = New TextBox()
        jt_cantidad = New TextBox()
        jt_peso_total = New TextBox()
        jt_grosor = New TextBox()
        jt_valor_broche = New TextBox()
        jt_peso = New TextBox()
        jt_ct = New TextBox()
        jt_largo = New TextBox()
        jt_nombre_compuesto = New TextBox()
        jt_valor_gramo = New TextBox()
        jt_costo_total = New TextBox()
        jt_valor_unitario = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        btn_registrar = New Button()
        SuspendLayout()
        ' 
        ' lst_tipo_producto
        ' 
        lst_tipo_producto.DropDownStyle = ComboBoxStyle.DropDownList
        lst_tipo_producto.FormattingEnabled = True
        lst_tipo_producto.Location = New Point(166, 89)
        lst_tipo_producto.Name = "lst_tipo_producto"
        lst_tipo_producto.Size = New Size(121, 23)
        lst_tipo_producto.TabIndex = 0
        ' 
        ' lst_marca
        ' 
        lst_marca.DropDownStyle = ComboBoxStyle.DropDownList
        lst_marca.FormattingEnabled = True
        lst_marca.Items.AddRange(New Object() {"Seleccione", "Nacional", "Italy"})
        lst_marca.Location = New Point(166, 118)
        lst_marca.Name = "lst_marca"
        lst_marca.Size = New Size(121, 23)
        lst_marca.TabIndex = 1
        ' 
        ' lst_categoria_precio
        ' 
        lst_categoria_precio.DropDownStyle = ComboBoxStyle.DropDownList
        lst_categoria_precio.FormattingEnabled = True
        lst_categoria_precio.Items.AddRange(New Object() {"Seleccione", "Precio contado", "Recargo +1", "Recargo +2", "Recargo +3", "Recargo +4"})
        lst_categoria_precio.Location = New Point(165, 234)
        lst_categoria_precio.Name = "lst_categoria_precio"
        lst_categoria_precio.Size = New Size(121, 23)
        lst_categoria_precio.TabIndex = 0
        ' 
        ' lst_broche
        ' 
        lst_broche.DropDownStyle = ComboBoxStyle.DropDownList
        lst_broche.FormattingEnabled = True
        lst_broche.Items.AddRange(New Object() {"Seleccione", "0.2", "0.25", "0.3", "0.35", "0.4", "0.6", "0.8", "1"})
        lst_broche.Location = New Point(369, 118)
        lst_broche.Name = "lst_broche"
        lst_broche.Size = New Size(88, 23)
        lst_broche.TabIndex = 0
        ' 
        ' jt_descripcion
        ' 
        jt_descripcion.Enabled = False
        jt_descripcion.Location = New Point(166, 147)
        jt_descripcion.Name = "jt_descripcion"
        jt_descripcion.Size = New Size(291, 23)
        jt_descripcion.TabIndex = 4
        ' 
        ' jt_cantidad
        ' 
        jt_cantidad.Location = New Point(166, 205)
        jt_cantidad.Name = "jt_cantidad"
        jt_cantidad.Size = New Size(100, 23)
        jt_cantidad.TabIndex = 5
        ' 
        ' jt_peso_total
        ' 
        jt_peso_total.Location = New Point(357, 234)
        jt_peso_total.Name = "jt_peso_total"
        jt_peso_total.Size = New Size(100, 23)
        jt_peso_total.TabIndex = 7
        ' 
        ' jt_grosor
        ' 
        jt_grosor.Enabled = False
        jt_grosor.Location = New Point(166, 176)
        jt_grosor.Name = "jt_grosor"
        jt_grosor.Size = New Size(100, 23)
        jt_grosor.TabIndex = 6
        ' 
        ' jt_valor_broche
        ' 
        jt_valor_broche.Enabled = False
        jt_valor_broche.Location = New Point(484, 118)
        jt_valor_broche.Name = "jt_valor_broche"
        jt_valor_broche.Size = New Size(100, 23)
        jt_valor_broche.TabIndex = 11
        ' 
        ' jt_peso
        ' 
        jt_peso.Location = New Point(357, 205)
        jt_peso.Name = "jt_peso"
        jt_peso.Size = New Size(100, 23)
        jt_peso.TabIndex = 10
        ' 
        ' jt_ct
        ' 
        jt_ct.Enabled = False
        jt_ct.Location = New Point(484, 384)
        jt_ct.Name = "jt_ct"
        jt_ct.Size = New Size(100, 23)
        jt_ct.TabIndex = 9
        ' 
        ' jt_largo
        ' 
        jt_largo.Enabled = False
        jt_largo.Location = New Point(357, 176)
        jt_largo.Name = "jt_largo"
        jt_largo.Size = New Size(100, 23)
        jt_largo.TabIndex = 8
        ' 
        ' jt_nombre_compuesto
        ' 
        jt_nombre_compuesto.Enabled = False
        jt_nombre_compuesto.Location = New Point(166, 271)
        jt_nombre_compuesto.Name = "jt_nombre_compuesto"
        jt_nombre_compuesto.Size = New Size(291, 23)
        jt_nombre_compuesto.TabIndex = 15
        ' 
        ' jt_valor_gramo
        ' 
        jt_valor_gramo.Enabled = False
        jt_valor_gramo.Location = New Point(484, 171)
        jt_valor_gramo.Name = "jt_valor_gramo"
        jt_valor_gramo.Size = New Size(100, 23)
        jt_valor_gramo.TabIndex = 14
        ' 
        ' jt_costo_total
        ' 
        jt_costo_total.Enabled = False
        jt_costo_total.Location = New Point(484, 271)
        jt_costo_total.Name = "jt_costo_total"
        jt_costo_total.Size = New Size(100, 23)
        jt_costo_total.TabIndex = 13
        ' 
        ' jt_valor_unitario
        ' 
        jt_valor_unitario.Enabled = False
        jt_valor_unitario.Location = New Point(484, 223)
        jt_valor_unitario.Name = "jt_valor_unitario"
        jt_valor_unitario.Size = New Size(100, 23)
        jt_valor_unitario.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 16
        Label1.Text = "Tipo de producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 17
        Label2.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(120, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 18
        Label3.Text = "Marca"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(118, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 19
        Label4.Text = "Grosor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(314, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 20
        Label5.Text = "Largo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(319, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 15)
        Label6.TabIndex = 21
        Label6.Text = "Broche"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(105, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 22
        Label7.Text = "Cantidad"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(319, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 15)
        Label8.TabIndex = 23
        Label8.Text = "Peso"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(65, 237)
        Label9.Name = "Label9"
        Label9.Size = New Size(94, 15)
        Label9.TabIndex = 24
        Label9.Text = "Categoría precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(292, 239)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 25
        Label10.Text = "Peso total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(484, 100)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 15)
        Label11.TabIndex = 26
        Label11.Text = "Valor broche"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(484, 366)
        Label12.Name = "Label12"
        Label12.Size = New Size(21, 15)
        Label12.TabIndex = 27
        Label12.Text = "CT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(484, 153)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 15)
        Label13.TabIndex = 28
        Label13.Text = "Valor gramo"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(484, 205)
        Label14.Name = "Label14"
        Label14.Size = New Size(77, 15)
        Label14.TabIndex = 29
        Label14.Text = "Valor unitario"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(484, 254)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 15)
        Label15.TabIndex = 30
        Label15.Text = "Costo total"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(55, 274)
        Label16.Name = "Label16"
        Label16.Size = New Size(105, 15)
        Label16.TabIndex = 31
        Label16.Text = "Nombre completo"
        ' 
        ' btn_registrar
        ' 
        btn_registrar.Location = New Point(269, 312)
        btn_registrar.Name = "btn_registrar"
        btn_registrar.Size = New Size(142, 35)
        btn_registrar.TabIndex = 32
        btn_registrar.Text = ">> Registrar <<"
        btn_registrar.UseVisualStyleBackColor = True
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 450)
        Controls.Add(btn_registrar)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(jt_nombre_compuesto)
        Controls.Add(jt_valor_gramo)
        Controls.Add(jt_costo_total)
        Controls.Add(jt_valor_unitario)
        Controls.Add(jt_valor_broche)
        Controls.Add(jt_peso)
        Controls.Add(jt_ct)
        Controls.Add(jt_largo)
        Controls.Add(jt_peso_total)
        Controls.Add(jt_grosor)
        Controls.Add(jt_cantidad)
        Controls.Add(jt_descripcion)
        Controls.Add(lst_categoria_precio)
        Controls.Add(lst_broche)
        Controls.Add(lst_marca)
        Controls.Add(lst_tipo_producto)
        Name = "Registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private Sub lst_tipo_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_tipo_producto.SelectedIndexChanged
        jt_grosor.Text = ""
        jt_largo.Text = ""
        jt_descripcion.Text = ""
        lst_marca.Text = "Seleccione"
        lst_broche.Text = "Seleccione"
        jt_cantidad.Text = ""
        jt_peso.Text = ""
        jt_peso_total.Text = ""
        lst_categoria_precio.Text = "Seleccione"
        jt_nombre_compuesto.Text = ""
        jt_valor_gramo.Text = "Pendiente"
        jt_valor_unitario.Text = "Pendiente"
        jt_costo_total.Text = "Pendiente"
        jt_ct.Text = "Pendiente"

        Select Case lst_tipo_producto.Text

            Case "Cadena", "Pulsera", "Pulso", "Tobillera", "Rosario", "Aro"
                jt_grosor.Enabled = True
                jt_largo.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True

            Case "Dije"
                jt_largo.Enabled = True
                jt_cantidad.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True

            Case "Anillo"
                jt_grosor.Enabled = False
                jt_largo.Enabled = False
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True

            Case "Topos"
                jt_grosor.Enabled = True
                jt_largo.Enabled = False
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                'lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True

            Case "Pircing", "Herraje", "Pulsera tejida", "Candonga", "Bola"
                jt_grosor.Enabled = False
                jt_largo.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                jt_peso_total.Enabled = False
                lst_categoria_precio.Enabled = True
                jt_nombre_compuesto.Enabled = False

            Case Else
                jt_grosor.Enabled = False
                jt_largo.Enabled = False
                jt_descripcion.Enabled = False
                lst_marca.Enabled = False
                lst_broche.Enabled = False
                jt_cantidad.Enabled = False
                jt_peso.Enabled = False
                jt_peso_total.Enabled = False
                lst_categoria_precio.Enabled = False
                jt_nombre_compuesto.Enabled = False
        End Select
    End Sub
    Private Sub lst_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_marca.SelectedIndexChanged
        'ActualizarNombreCompleto
        lst_broche.Text = ""

        If lst_tipo_producto.Text = "Cadena" Or lst_tipo_producto.Text = "Pulsera" Or lst_tipo_producto.Text = "Tobillera" Or lst_tipo_producto.Text = "Pulso" Or lst_tipo_producto.Text = "Rosario" Then
            If lst_marca.Text = "Nacional" Then
                lst_broche.Enabled = True
            Else
                lst_broche.Enabled = False
            End If
        End If
        If lst_marca.Text = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
            lst_categoria_precio.Text = "Seleccione"
            jt_ct.Text = "Pendiente"
            lst_broche.Text = "Seleccione"
        ElseIf lst_marca.Text = "Nacional" Then
            'CalcularCategoria()
            'CalcularValorUnitario()
            'CalcularCostoTotal()
        ElseIf lst_marca.Text = "Italy" Then
            lst_broche.Text = "Seleccione"
            'CalcularCategoriaItaly()
            'CalcularValorUnitario()
            'CalcularCostoTotal()
        End If
    End Sub
    Private Sub jt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles jt_cantidad.TextChanged
        'CalcularPesoTotal()

        If jt_peso.Text = "" Then
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf jt_cantidad.Text = "" Then
            jt_costo_total.Text = "Pendiente"
        ElseIf lst_categoria_precio.Text = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf lst_marca.Text = "Nacional" Then
            'CalcularCategoria()
            'CalcularCostoTotal()
        ElseIf lst_marca.Text = "Italy" Then
            'CalcularCategoriaItaly()
            'CalcularCostoTotal()
        End If
    End Sub
    Private Sub jt_peso_TextChanged(sender As Object, e As EventArgs) Handles jt_cantidad.TextChanged
        'ActualizarNombreCompleto
        'CalcularPesoTotal
        If IsNumeric(jt_peso.Text) And jt_peso.Text > 200 Then
            MessageBox.Show("El valor ingresado debe ser menor o igual a 200", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            jt_peso.Text = ""
        End If
        If jt_peso.TextLength > 6 Then
            jt_peso.Text = jt_peso.Text.Substring(0, 6)
        End If
        ' Verificar si jt_peso está vacío
        If jt_peso.Text = "" Then
            jt_ct.Text = ""
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf lst_marca.Text = "Nacional" Then
            'CalcularCategoria
            'CalcularValorUnitario
            'CalcularCostoTotal
        ElseIf lst_marca.Text = "Italy" Then
            'CalcularCategoriaItaly
            'CalcularValorUnitario
            'CalcularCostoTotal
        ElseIf lst_marca.Text = "Seleccione" Then
            jt_ct.Text = "Pendiente"
        End If
    End Sub
    Private Sub lst_broche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_categoria_precio.SelectedIndexChanged
        CalcularValorBroche()
        'CalcularValorUnitario
        'CalcularCostoTotal
    End Sub
    Private Sub lst_categoria_precio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_categoria_precio.SelectedIndexChanged

    End Sub
    Friend WithEvents lst_tipo_producto As ComboBox
    Friend WithEvents lst_marca As ComboBox
    Friend WithEvents lst_categoria_precio As ComboBox
    Friend WithEvents lst_broche As ComboBox
    Friend WithEvents jt_descripcion As TextBox
    Friend WithEvents jt_cantidad As TextBox
    Friend WithEvents jt_peso_total As TextBox
    Friend WithEvents jt_grosor As TextBox
    Friend WithEvents jt_valor_broche As TextBox
    Friend WithEvents jt_peso As TextBox
    Friend WithEvents jt_ct As TextBox
    Friend WithEvents jt_largo As TextBox
    Friend WithEvents jt_nombre_compuesto As TextBox
    Friend WithEvents jt_valor_gramo As TextBox
    Friend WithEvents jt_costo_total As TextBox
    Friend WithEvents jt_valor_unitario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_registrar As Button
End Class
