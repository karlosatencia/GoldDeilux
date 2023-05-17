Imports MySqlConnector
Imports MySql.Data.MySqlClient
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Registro))
        lst_marca_tabla = New ComboBox()
        lst_tipo_producto = New ComboBox()
        lst_marca = New ComboBox()
        lst_categoria_precio = New ComboBox()
        lst_broche = New ComboBox()
        jt_descripcion = New TextBox()
        jt_peso_total = New TextBox()
        jt_grosor = New TextBox()
        jt_valor_broche = New TextBox()
        jt_cantidad = New TextBox()
        jt_peso = New TextBox()
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
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        btn_registrar = New Button()
        rb_mujer = New RadioButton()
        rb_hombre = New RadioButton()
        Tab_Consultar = New TabControl()
        TabPage1 = New TabPage()
        jt_compra = New TextBox()
        Label17 = New Label()
        PictureBox1 = New PictureBox()
        TabPage3 = New TabPage()
        btn_tarifa_precios = New Button()
        btn_compra = New Button()
        btn_shopify = New Button()
        btn_effy = New Button()
        PictureBox2 = New PictureBox()
        TabPage4 = New TabPage()
        GroupBox2 = New GroupBox()
        btn_backup = New Button()
        Label19 = New Label()
        icon_actualizar = New PictureBox()
        jt_id_consulta = New TextBox()
        btn_consultar_id = New Button()
        GroupBox1 = New GroupBox()
        Label18 = New Label()
        btn_depurar = New Button()
        tb_productos = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        marca = New DataGridViewTextBoxColumn()
        cantidad = New DataGridViewTextBoxColumn()
        peso = New DataGridViewTextBoxColumn()
        peso_total = New DataGridViewTextBoxColumn()
        categoria_producto = New DataGridViewTextBoxColumn()
        valor_unitario = New DataGridViewTextBoxColumn()
        costo_total = New DataGridViewTextBoxColumn()
        valor_gramo = New DataGridViewTextBoxColumn()
        valor_unitario_compra = New DataGridViewTextBoxColumn()
        DataSet1BindingSource = New BindingSource(components)
        TabPage2 = New TabPage()
        Panel1 = New Panel()
        btn_cancelar = New Button()
        btn_actualizar = New Button()
        btn_actualizar_valores = New Button()
        tb_precios = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        peso_inicial = New DataGridViewTextBoxColumn()
        peso_final = New DataGridViewTextBoxColumn()
        categoria_precio = New DataGridViewTextBoxColumn()
        valor = New DataGridViewTextBoxColumn()
        Label12 = New Label()
        OFD_depurar = New OpenFileDialog()
        tt_actualizar = New ToolTip(components)
        tt_depurar = New ToolTip(components)
        Tab_Consultar.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(icon_actualizar, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(tb_productos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSet1BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(tb_precios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lst_marca_tabla
        ' 
        lst_marca_tabla.DropDownStyle = ComboBoxStyle.DropDownList
        lst_marca_tabla.Font = New Font("Barlow Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lst_marca_tabla.FormattingEnabled = True
        lst_marca_tabla.Items.AddRange(New Object() {"Seleccione", "Nacional", "Italy"})
        lst_marca_tabla.Location = New Point(322, 57)
        lst_marca_tabla.Margin = New Padding(4, 3, 4, 3)
        lst_marca_tabla.Name = "lst_marca_tabla"
        lst_marca_tabla.Size = New Size(121, 23)
        lst_marca_tabla.TabIndex = 1
        lst_marca_tabla.SelectedIndex = 0
        ' 
        ' lst_tipo_producto
        ' 
        lst_tipo_producto.DropDownStyle = ComboBoxStyle.DropDownList
        lst_tipo_producto.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_tipo_producto.FormattingEnabled = True
        lst_tipo_producto.Location = New Point(161, 84)
        lst_tipo_producto.Margin = New Padding(4, 3, 4, 3)
        lst_tipo_producto.Name = "lst_tipo_producto"
        lst_tipo_producto.Size = New Size(121, 28)
        lst_tipo_producto.TabIndex = 0
        ' 
        ' lst_marca
        ' 
        lst_marca.DropDownStyle = ComboBoxStyle.DropDownList
        lst_marca.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_marca.FormattingEnabled = True
        lst_marca.Items.AddRange(New Object() {"Seleccione", "Nacional", "Italy"})
        lst_marca.Location = New Point(162, 119)
        lst_marca.Margin = New Padding(4, 3, 4, 3)
        lst_marca.Name = "lst_marca"
        lst_marca.Size = New Size(121, 28)
        lst_marca.TabIndex = 3
        ' 
        ' lst_categoria_precio
        ' 
        lst_categoria_precio.DropDownStyle = ComboBoxStyle.DropDownList
        lst_categoria_precio.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_categoria_precio.FormattingEnabled = True
        lst_categoria_precio.Items.AddRange(New Object() {"Seleccione", "Precio contado", "Recargo +1", "Recargo +2", "Recargo +3", "Recargo +4"})
        lst_categoria_precio.Location = New Point(161, 242)
        lst_categoria_precio.Margin = New Padding(4, 3, 4, 3)
        lst_categoria_precio.Name = "lst_categoria_precio"
        lst_categoria_precio.Size = New Size(121, 28)
        lst_categoria_precio.TabIndex = 10
        ' 
        ' lst_broche
        ' 
        lst_broche.DropDownStyle = ComboBoxStyle.DropDownList
        lst_broche.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_broche.FormattingEnabled = True
        lst_broche.Location = New Point(431, 120)
        lst_broche.Margin = New Padding(4, 3, 4, 3)
        lst_broche.Name = "lst_broche"
        lst_broche.Size = New Size(114, 28)
        lst_broche.TabIndex = 4
        ' 
        ' jt_descripcion
        ' 
        jt_descripcion.Enabled = False
        jt_descripcion.Location = New Point(162, 155)
        jt_descripcion.Margin = New Padding(4, 3, 4, 3)
        jt_descripcion.Name = "jt_descripcion"
        jt_descripcion.Size = New Size(383, 23)
        jt_descripcion.TabIndex = 5
        ' 
        ' jt_peso_total
        ' 
        jt_peso_total.Location = New Point(436, 242)
        jt_peso_total.Margin = New Padding(4, 3, 4, 3)
        jt_peso_total.Name = "jt_peso_total"
        jt_peso_total.Size = New Size(109, 23)
        jt_peso_total.TabIndex = 7
        ' 
        ' jt_grosor
        ' 
        jt_grosor.Enabled = False
        jt_grosor.Location = New Point(162, 184)
        jt_grosor.Margin = New Padding(4, 3, 4, 3)
        jt_grosor.MaxLength = 5
        jt_grosor.Name = "jt_grosor"
        jt_grosor.Size = New Size(121, 23)
        jt_grosor.TabIndex = 6
        ' 
        ' jt_valor_broche
        ' 
        jt_valor_broche.Enabled = False
        jt_valor_broche.Location = New Point(565, 126)
        jt_valor_broche.Margin = New Padding(4, 3, 4, 3)
        jt_valor_broche.Name = "jt_valor_broche"
        jt_valor_broche.Size = New Size(100, 23)
        jt_valor_broche.TabIndex = 11
        ' 
        ' jt_cantidad
        ' 
        jt_cantidad.Location = New Point(162, 213)
        jt_cantidad.Margin = New Padding(4, 3, 4, 3)
        jt_cantidad.MaxLength = 4
        jt_cantidad.Name = "jt_cantidad"
        jt_cantidad.Size = New Size(119, 23)
        jt_cantidad.TabIndex = 8
        ' 
        ' jt_peso
        ' 
        jt_peso.Location = New Point(436, 213)
        jt_peso.Margin = New Padding(4, 3, 4, 3)
        jt_peso.MaxLength = 6
        jt_peso.Name = "jt_peso"
        jt_peso.Size = New Size(109, 23)
        jt_peso.TabIndex = 9
        ' 
        ' jt_largo
        ' 
        jt_largo.Enabled = False
        jt_largo.Location = New Point(436, 184)
        jt_largo.Margin = New Padding(4, 3, 4, 3)
        jt_largo.MaxLength = 6
        jt_largo.Name = "jt_largo"
        jt_largo.Size = New Size(109, 23)
        jt_largo.TabIndex = 7
        ' 
        ' jt_nombre_compuesto
        ' 
        jt_nombre_compuesto.Enabled = False
        jt_nombre_compuesto.Location = New Point(162, 279)
        jt_nombre_compuesto.Margin = New Padding(4, 3, 4, 3)
        jt_nombre_compuesto.Name = "jt_nombre_compuesto"
        jt_nombre_compuesto.Size = New Size(383, 23)
        jt_nombre_compuesto.TabIndex = 11
        ' 
        ' jt_valor_gramo
        ' 
        jt_valor_gramo.Enabled = False
        jt_valor_gramo.Location = New Point(565, 179)
        jt_valor_gramo.Margin = New Padding(4, 3, 4, 3)
        jt_valor_gramo.Name = "jt_valor_gramo"
        jt_valor_gramo.Size = New Size(100, 23)
        jt_valor_gramo.TabIndex = 14
        ' 
        ' jt_costo_total
        ' 
        jt_costo_total.Enabled = False
        jt_costo_total.Location = New Point(565, 279)
        jt_costo_total.Margin = New Padding(4, 3, 4, 3)
        jt_costo_total.Name = "jt_costo_total"
        jt_costo_total.Size = New Size(100, 23)
        jt_costo_total.TabIndex = 13
        ' 
        ' jt_valor_unitario
        ' 
        jt_valor_unitario.Enabled = False
        jt_valor_unitario.Location = New Point(565, 231)
        jt_valor_unitario.Margin = New Padding(4, 3, 4, 3)
        jt_valor_unitario.Name = "jt_valor_unitario"
        jt_valor_unitario.Size = New Size(100, 23)
        jt_valor_unitario.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(52, 90)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 17)
        Label1.TabIndex = 16
        Label1.Text = "Tipo de producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(82, 158)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 17
        Label2.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(112, 122)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 17)
        Label3.TabIndex = 18
        Label3.Text = "Marca"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(109, 187)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 19
        Label4.Text = "Grosor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(392, 187)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 17)
        Label5.TabIndex = 20
        Label5.Text = "Largo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(379, 126)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 17)
        Label6.TabIndex = 21
        Label6.Text = "Broche"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(96, 216)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 17)
        Label7.TabIndex = 22
        Label7.Text = "Cantidad"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(396, 216)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 17)
        Label8.TabIndex = 23
        Label8.Text = "Peso"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(56, 245)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 17)
        Label9.TabIndex = 24
        Label9.Text = "Categoría precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(369, 247)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(66, 17)
        Label10.TabIndex = 25
        Label10.Text = "Peso total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(565, 108)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 17)
        Label11.TabIndex = 26
        Label11.Text = "Valor broche"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(565, 161)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 17)
        Label13.TabIndex = 28
        Label13.Text = "Valor gramo"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(565, 213)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(84, 17)
        Label14.TabIndex = 29
        Label14.Text = "Valor unitario"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(565, 262)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 17)
        Label15.TabIndex = 30
        Label15.Text = "Costo total"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(46, 282)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(111, 17)
        Label16.TabIndex = 31
        Label16.Text = "Nombre completo"
        ' 
        ' btn_registrar
        ' 
        btn_registrar.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_registrar.Location = New Point(291, 332)
        btn_registrar.Margin = New Padding(4, 3, 4, 3)
        btn_registrar.Name = "btn_registrar"
        btn_registrar.Size = New Size(142, 35)
        btn_registrar.TabIndex = 12
        btn_registrar.Text = ">> Registrar <<"
        btn_registrar.UseVisualStyleBackColor = True
        ' 
        ' rb_mujer
        ' 
        rb_mujer.AutoSize = True
        rb_mujer.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        rb_mujer.Location = New Point(299, 86)
        rb_mujer.Margin = New Padding(4, 3, 4, 3)
        rb_mujer.Name = "rb_mujer"
        rb_mujer.Size = New Size(57, 21)
        rb_mujer.TabIndex = 1
        rb_mujer.TabStop = True
        rb_mujer.Text = "Mujer"
        rb_mujer.UseVisualStyleBackColor = True
        ' 
        ' rb_hombre
        ' 
        rb_hombre.AutoSize = True
        rb_hombre.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        rb_hombre.Location = New Point(299, 111)
        rb_hombre.Margin = New Padding(4, 3, 4, 3)
        rb_hombre.Name = "rb_hombre"
        rb_hombre.Size = New Size(72, 21)
        rb_hombre.TabIndex = 2
        rb_hombre.TabStop = True
        rb_hombre.Text = "Hombre"
        rb_hombre.UseVisualStyleBackColor = True
        ' 
        ' Tab_Consultar
        ' 
        Tab_Consultar.Controls.Add(TabPage1)
        Tab_Consultar.Controls.Add(TabPage3)
        Tab_Consultar.Controls.Add(TabPage4)
        Tab_Consultar.Controls.Add(TabPage2)
        Tab_Consultar.Dock = DockStyle.Fill
        Tab_Consultar.Font = New Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Tab_Consultar.Location = New Point(0, 0)
        Tab_Consultar.Margin = New Padding(4, 3, 4, 3)
        Tab_Consultar.Name = "Tab_Consultar"
        Tab_Consultar.SelectedIndex = 0
        Tab_Consultar.Size = New Size(720, 429)
        Tab_Consultar.TabIndex = 32
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(jt_compra)
        TabPage1.Controls.Add(Label17)
        TabPage1.Controls.Add(btn_registrar)
        TabPage1.Controls.Add(jt_largo)
        TabPage1.Controls.Add(lst_tipo_producto)
        TabPage1.Controls.Add(rb_hombre)
        TabPage1.Controls.Add(lst_marca)
        TabPage1.Controls.Add(rb_mujer)
        TabPage1.Controls.Add(lst_broche)
        TabPage1.Controls.Add(jt_cantidad)
        TabPage1.Controls.Add(lst_categoria_precio)
        TabPage1.Controls.Add(Label16)
        TabPage1.Controls.Add(jt_descripcion)
        TabPage1.Controls.Add(Label15)
        TabPage1.Controls.Add(jt_grosor)
        TabPage1.Controls.Add(Label14)
        TabPage1.Controls.Add(jt_peso_total)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(jt_peso)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(jt_valor_broche)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(jt_valor_unitario)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(jt_costo_total)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(jt_valor_gramo)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(jt_nombre_compuesto)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(4, 3, 4, 3)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 3, 4, 3)
        TabPage1.Size = New Size(712, 401)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Registro"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' jt_compra
        ' 
        jt_compra.Location = New Point(565, 82)
        jt_compra.Margin = New Padding(4, 3, 4, 3)
        jt_compra.Name = "jt_compra"
        jt_compra.Size = New Size(100, 23)
        jt_compra.TabIndex = 11
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(565, 64)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(106, 17)
        Label17.TabIndex = 32
        Label17.Text = "Valor gr (Compra)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(259, -36)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), Image)
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(btn_tarifa_precios)
        TabPage3.Controls.Add(btn_compra)
        TabPage3.Controls.Add(btn_shopify)
        TabPage3.Controls.Add(btn_effy)
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Margin = New Padding(4, 3, 4, 3)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4, 3, 4, 3)
        TabPage3.Size = New Size(712, 401)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Reportes"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btn_tarifa_precios
        ' 
        btn_tarifa_precios.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_tarifa_precios.Location = New Point(394, 228)
        btn_tarifa_precios.Margin = New Padding(4, 3, 4, 3)
        btn_tarifa_precios.Name = "btn_tarifa_precios"
        btn_tarifa_precios.Size = New Size(201, 70)
        btn_tarifa_precios.TabIndex = 2
        btn_tarifa_precios.Text = "Reporte Actualizar Precios"
        btn_tarifa_precios.UseVisualStyleBackColor = True
        ' 
        ' btn_compra
        ' 
        btn_compra.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_compra.Location = New Point(394, 110)
        btn_compra.Margin = New Padding(4, 3, 4, 3)
        btn_compra.Name = "btn_compra"
        btn_compra.Size = New Size(201, 72)
        btn_compra.TabIndex = 1
        btn_compra.Text = "Generar Reporte Compra"
        btn_compra.UseVisualStyleBackColor = True
        ' 
        ' btn_shopify
        ' 
        btn_shopify.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_shopify.Location = New Point(118, 228)
        btn_shopify.Margin = New Padding(4, 3, 4, 3)
        btn_shopify.Name = "btn_shopify"
        btn_shopify.Size = New Size(201, 72)
        btn_shopify.TabIndex = 0
        btn_shopify.Text = "Generar Reporte Shopy"
        btn_shopify.UseVisualStyleBackColor = True
        ' 
        ' btn_effy
        ' 
        btn_effy.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_effy.Location = New Point(118, 110)
        btn_effy.Margin = New Padding(4, 3, 4, 3)
        btn_effy.Name = "btn_effy"
        btn_effy.Size = New Size(201, 72)
        btn_effy.TabIndex = 0
        btn_effy.Text = "Generar Reporte Effy"
        btn_effy.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(259, -36)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(204, 172)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' TabPage4
        ' 
        TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), Image)
        TabPage4.BackgroundImageLayout = ImageLayout.Stretch
        TabPage4.Controls.Add(GroupBox2)
        TabPage4.Controls.Add(Label19)
        TabPage4.Controls.Add(icon_actualizar)
        TabPage4.Controls.Add(jt_id_consulta)
        TabPage4.Controls.Add(btn_consultar_id)
        TabPage4.Controls.Add(GroupBox1)
        TabPage4.Controls.Add(tb_productos)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Margin = New Padding(4, 3, 4, 3)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(4, 3, 4, 3)
        TabPage4.Size = New Size(712, 401)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Consultar productos"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_backup)
        GroupBox2.Location = New Point(370, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(149, 112)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Backup"
        ' 
        ' btn_backup
        ' 
        btn_backup.Location = New Point(33, 42)
        btn_backup.Name = "btn_backup"
        btn_backup.Size = New Size(85, 32)
        btn_backup.TabIndex = 0
        btn_backup.Text = "Backup"
        btn_backup.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(546, 30)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(102, 17)
        Label19.TabIndex = 6
        Label19.Text = "Consultar por Id:"
        ' 
        ' icon_actualizar
        ' 
        icon_actualizar.Cursor = Cursors.Hand
        icon_actualizar.Image = CType(resources.GetObject("icon_actualizar.Image"), Image)
        icon_actualizar.Location = New Point(670, 6)
        icon_actualizar.Margin = New Padding(4, 3, 4, 3)
        icon_actualizar.Name = "icon_actualizar"
        icon_actualizar.Size = New Size(34, 27)
        icon_actualizar.SizeMode = PictureBoxSizeMode.StretchImage
        icon_actualizar.TabIndex = 5
        icon_actualizar.TabStop = False
        tt_actualizar.SetToolTip(icon_actualizar, "Actualizar consulta")
        ' 
        ' jt_id_consulta
        ' 
        jt_id_consulta.Location = New Point(550, 48)
        jt_id_consulta.Margin = New Padding(4, 3, 4, 3)
        jt_id_consulta.Name = "jt_id_consulta"
        jt_id_consulta.Size = New Size(100, 23)
        jt_id_consulta.TabIndex = 4
        ' 
        ' btn_consultar_id
        ' 
        btn_consultar_id.Font = New Font("Barlow Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_consultar_id.Location = New Point(558, 73)
        btn_consultar_id.Margin = New Padding(4, 3, 4, 3)
        btn_consultar_id.Name = "btn_consultar_id"
        btn_consultar_id.Size = New Size(85, 29)
        btn_consultar_id.TabIndex = 3
        btn_consultar_id.Text = "Consultar"
        btn_consultar_id.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(btn_depurar)
        GroupBox1.Location = New Point(9, 6)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(354, 112)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Depurar productos registrados"
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Barlow Light", 9.749999F, FontStyle.Italic, GraphicsUnit.Point)
        Label18.Location = New Point(6, 19)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(342, 53)
        Label18.TabIndex = 2
        Label18.Text = "Si desea depurar la lista de productos registrados, cargue un archivo excel con una única columna llamada ID en la cual estén los id de los productos que desea eliminar."
        ' 
        ' btn_depurar
        ' 
        btn_depurar.Font = New Font("Barlow Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_depurar.Location = New Point(82, 73)
        btn_depurar.Margin = New Padding(4, 3, 4, 3)
        btn_depurar.Name = "btn_depurar"
        btn_depurar.Size = New Size(159, 33)
        btn_depurar.TabIndex = 1
        btn_depurar.Text = "Depurar"
        tt_depurar.SetToolTip(btn_depurar, "Cargar archivo excel")
        btn_depurar.UseVisualStyleBackColor = True
        ' 
        ' tb_productos
        ' 
        tb_productos.AllowUserToAddRows = False
        tb_productos.AllowUserToResizeColumns = False
        tb_productos.AutoGenerateColumns = False
        tb_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tb_productos.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra})
        tb_productos.DataSource = DataSet1BindingSource
        tb_productos.Location = New Point(4, 124)
        tb_productos.Margin = New Padding(4, 3, 4, 3)
        tb_productos.Name = "tb_productos"
        tb_productos.ReadOnly = True
        tb_productos.RowHeadersVisible = False
        tb_productos.RowTemplate.Height = 25
        tb_productos.RowTemplate.Resizable = DataGridViewTriState.False
        tb_productos.Size = New Size(704, 270)
        tb_productos.TabIndex = 0
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "id"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "nombre"
        nombre.Name = "nombre"
        nombre.ReadOnly = True
        ' 
        ' marca
        ' 
        marca.HeaderText = "marca"
        marca.Name = "marca"
        marca.ReadOnly = True
        ' 
        ' cantidad
        ' 
        cantidad.HeaderText = "cantidad"
        cantidad.Name = "cantidad"
        cantidad.ReadOnly = True
        ' 
        ' peso
        ' 
        peso.HeaderText = "peso"
        peso.Name = "peso"
        peso.ReadOnly = True
        ' 
        ' peso_total
        ' 
        peso_total.HeaderText = "peso_total"
        peso_total.Name = "peso_total"
        peso_total.ReadOnly = True
        ' 
        ' categoria_producto
        ' 
        categoria_producto.HeaderText = "categoria_producto"
        categoria_producto.Name = "categoria_producto"
        categoria_producto.ReadOnly = True
        ' 
        ' valor_unitario
        ' 
        valor_unitario.HeaderText = "valor_unitario"
        valor_unitario.Name = "valor_unitario"
        valor_unitario.ReadOnly = True
        ' 
        ' costo_total
        ' 
        costo_total.HeaderText = "costo_total"
        costo_total.Name = "costo_total"
        costo_total.ReadOnly = True
        ' 
        ' valor_gramo
        ' 
        valor_gramo.HeaderText = "valor_gramo"
        valor_gramo.Name = "valor_gramo"
        valor_gramo.ReadOnly = True
        ' 
        ' valor_unitario_compra
        ' 
        valor_unitario_compra.HeaderText = "valor_unitario_compra"
        valor_unitario_compra.Name = "valor_unitario_compra"
        valor_unitario_compra.ReadOnly = True
        ' 
        ' DataSet1BindingSource
        ' 
        DataSet1BindingSource.DataSource = GetType(GoldManager.DataSet1)
        DataSet1BindingSource.Position = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(Panel1)
        TabPage2.Controls.Add(btn_actualizar_valores)
        TabPage2.Controls.Add(tb_precios)
        TabPage2.Controls.Add(lst_marca_tabla)
        TabPage2.Controls.Add(Label12)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(712, 401)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Tabla de precios"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_cancelar)
        Panel1.Controls.Add(btn_actualizar)
        Panel1.Location = New Point(579, 103)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(106, 77)
        Panel1.TabIndex = 4
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Location = New Point(13, 42)
        btn_cancelar.Margin = New Padding(4, 3, 4, 3)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 23)
        btn_cancelar.TabIndex = 1
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        btn_cancelar.Visible = False
        ' 
        ' btn_actualizar
        ' 
        btn_actualizar.Location = New Point(13, 13)
        btn_actualizar.Margin = New Padding(4, 3, 4, 3)
        btn_actualizar.Name = "btn_actualizar"
        btn_actualizar.Size = New Size(75, 23)
        btn_actualizar.TabIndex = 0
        btn_actualizar.Text = "Acualizar"
        btn_actualizar.UseVisualStyleBackColor = True
        btn_actualizar.Visible = False
        ' 
        ' btn_actualizar_valores
        ' 
        btn_actualizar_valores.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_actualizar_valores.Location = New Point(287, 321)
        btn_actualizar_valores.Margin = New Padding(4, 3, 4, 3)
        btn_actualizar_valores.Name = "btn_actualizar_valores"
        btn_actualizar_valores.Size = New Size(118, 30)
        btn_actualizar_valores.TabIndex = 3
        btn_actualizar_valores.Text = "Actualizar valores"
        btn_actualizar_valores.UseVisualStyleBackColor = True
        btn_actualizar_valores.Visible = False
        ' 
        ' tb_precios
        ' 
        tb_precios.AllowUserToAddRows = False
        tb_precios.AllowUserToResizeColumns = False
        tb_precios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tb_precios.Columns.AddRange(New DataGridViewColumn() {id, peso_inicial, peso_final, categoria_precio, valor})
        tb_precios.Location = New Point(108, 103)
        tb_precios.Margin = New Padding(4, 3, 4, 3)
        tb_precios.Name = "tb_precios"
        tb_precios.ReadOnly = True
        tb_precios.RowHeadersVisible = False
        tb_precios.RowTemplate.Height = 25
        tb_precios.RowTemplate.Resizable = DataGridViewTriState.False
        tb_precios.Size = New Size(464, 203)
        tb_precios.TabIndex = 2
        ' 
        ' id
        ' 
        id.HeaderText = "id"
        id.Name = "id"
        id.ReadOnly = True
        id.Width = 40
        ' 
        ' peso_inicial
        ' 
        peso_inicial.HeaderText = "Peso inicial"
        peso_inicial.Name = "peso_inicial"
        peso_inicial.ReadOnly = True
        ' 
        ' peso_final
        ' 
        peso_final.HeaderText = "Peso final"
        peso_final.Name = "peso_final"
        peso_final.ReadOnly = True
        ' 
        ' categoria_precio
        ' 
        categoria_precio.HeaderText = "Categoria precio"
        categoria_precio.Name = "categoria_precio"
        categoria_precio.ReadOnly = True
        categoria_precio.Width = 120
        ' 
        ' valor
        ' 
        valor.HeaderText = "Valor gramo"
        valor.Name = "valor"
        valor.ReadOnly = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(276, 60)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(43, 17)
        Label12.TabIndex = 0
        Label12.Text = "Marca"
        ' 
        ' OFD_depurar
        ' 
        OFD_depurar.Filter = "Archivos de Excel|*.xlsx;*.xls"
        OFD_depurar.InitialDirectory = "C:\"
        ' 
        ' tt_actualizar
        ' 
        tt_actualizar.ShowAlways = True
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(720, 429)
        Controls.Add(Tab_Consultar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gold Manager"
        Tab_Consultar.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(icon_actualizar, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(tb_productos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataSet1BindingSource, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(tb_precios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Private Sub lst_tipo_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_tipo_producto.SelectedIndexChanged
        ActualizarNombreCompleto()
        jt_grosor.Text = ""
        jt_largo.Text = ""
        jt_descripcion.Text = ""
        lst_marca.Text = "Seleccione"
        lst_broche.Text = "Seleccione"
        jt_cantidad.Text = ""
        jt_peso.Text = ""
        jt_peso_total.Text = "Pendiente"
        lst_categoria_precio.Text = "Seleccione"
        jt_nombre_compuesto.Text = ""
        jt_valor_gramo.Text = "Pendiente"
        jt_valor_unitario.Text = "Pendiente"
        jt_costo_total.Text = "Pendiente"
        jt_compra.Enabled = False
        jt_compra.Text = ""

        Select Case lst_tipo_producto.Text

            Case "Cadena", "Pulso bebé", "Pulso", "Tobillera", "Rosario", "Aro"
                jt_grosor.Enabled = True
                jt_largo.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False

            Case "Dije"
                jt_largo.Enabled = True
                jt_cantidad.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False

            Case "Anillo"
                jt_grosor.Enabled = False
                jt_largo.Enabled = False
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                rb_mujer.Enabled = True
                rb_mujer.Visible = True
                rb_hombre.Enabled = True
                rb_hombre.Visible = True

            Case "Topos"
                jt_grosor.Enabled = True
                jt_largo.Enabled = False
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False

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
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False

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
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False

        End Select
    End Sub
    Private Sub lst_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_marca.SelectedIndexChanged
        ActualizarNombreCompleto()
        lst_broche.Text = ""
        If lst_tipo_producto.Text = "Cadena" Or lst_tipo_producto.Text = "Pulso bebé" Or lst_tipo_producto.Text = "Tobillera" Or lst_tipo_producto.Text = "Pulso" Or lst_tipo_producto.Text = "Rosario" Then
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
            lst_broche.Text = "Seleccione"
            jt_compra.Enabled = False
            jt_compra.Text = ""
        ElseIf lst_marca.Text = "Nacional" Then
            jt_compra.Enabled = True
            jt_compra.Text = ""
            Dim peso As Decimal
            Decimal.TryParse(jt_peso.Text, peso)
            jt_valor_gramo.Text = ObtenerValorGamoNacional(peso, lst_categoria_precio.SelectedItem.ToString())
            CalcularValorUnitario()
            CalcularCostoTotal()
        ElseIf lst_marca.Text = "Italy" Then
            lst_broche.Text = "Seleccione"
            jt_compra.Enabled = True
            jt_compra.Text = ""
            Dim peso As Decimal
            Decimal.TryParse(jt_peso.Text, peso)
            jt_valor_gramo.Text = ObtenerValorGramoItaly(peso, lst_categoria_precio.SelectedItem.ToString())
            CalcularValorUnitario()
            CalcularCostoTotal()
        End If
    End Sub
    Private Sub jt_peso_TextChanged(sender As Object, e As EventArgs) Handles jt_peso.TextChanged
        ActualizarNombreCompleto()
        CalcularPesoTotal()
        Dim peso As Decimal

        If Decimal.TryParse(jt_peso.Text, peso) Then
            If peso > 200 Then
                MessageBox.Show("El valor ingresado debe ser menor o igual a 200", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                jt_peso.Text = ""
            Else
                ' Verificar si jt_peso está vacío
                If String.IsNullOrEmpty(jt_peso.Text) Or jt_peso.Text = "0" Then
                    jt_valor_gramo.Text = "Pendiente"
                    jt_valor_unitario.Text = "Pendiente"
                    jt_costo_total.Text = "Pendiente"
                    jt_peso_total.Text = "Pendiente"
                ElseIf lst_marca.Text = "Nacional" Then
                    jt_valor_gramo.Text = ObtenerValorGamoNacional(peso, lst_categoria_precio.SelectedItem.ToString())
                    CalcularValorUnitario()
                    CalcularCostoTotal()
                ElseIf lst_marca.Text = "Italy" Then
                    jt_valor_gramo.Text = ObtenerValorGramoItaly(peso, lst_categoria_precio.SelectedItem.ToString())
                    CalcularValorUnitario()
                    CalcularCostoTotal()
                End If
            End If
        Else
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        End If
    End Sub
    Private Sub jt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles jt_cantidad.TextChanged
        CalcularPesoTotal()

        If jt_peso.Text = "" Or jt_peso.Text = "0" Then
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
            jt_peso_total.Text = "Pendiente"
        ElseIf jt_cantidad.Text = "" Or jt_cantidad.Text = "0" Then
            jt_costo_total.Text = "Pendiente"
            jt_peso_total.Text = "Pendiente"
        ElseIf lst_categoria_precio.Text = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf lst_marca.Text = "Nacional" Then
            Dim peso As Decimal
            Decimal.TryParse(jt_peso.Text, peso)
            jt_valor_gramo.Text = ObtenerValorGamoNacional(peso, lst_categoria_precio.SelectedItem.ToString())

            CalcularCostoTotal()
        ElseIf lst_marca.Text = "Italy" Then
            Dim peso As Decimal
            Decimal.TryParse(jt_peso.Text, peso)
            jt_valor_gramo.Text = ObtenerValorGramoItaly(peso, lst_categoria_precio.SelectedItem.ToString())
            CalcularCostoTotal()
        End If
    End Sub
    Private Sub lst_broche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_broche.SelectedIndexChanged
        If lst_broche.SelectedItem.ToString() = "Seleccione" Then
            jt_valor_broche.Text = ""
        Else
            jt_valor_broche.Text = CalcularValorBroche(lst_broche.SelectedItem)
        End If
        CalcularValorUnitario()
        CalcularCostoTotal()
    End Sub

    Private Sub lst_categoria_precio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_categoria_precio.SelectedIndexChanged
        If lst_categoria_precio.Text = "Seleccione" Then
            jt_valor_gramo.Text = "Pendiente"
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf jt_peso.Text = "" Then
            jt_valor_unitario.Text = "Pendiente"
            jt_costo_total.Text = "Pendiente"
        ElseIf lst_marca.Text = "Nacional" Then
            jt_valor_gramo.Text = ObtenerValorGamoNacional(jt_peso.Text, lst_categoria_precio.SelectedItem.ToString())
            CalcularValorUnitario()
            CalcularCostoTotal()
        ElseIf lst_marca.Text = "Italy" Then
            jt_valor_gramo.Text = ObtenerValorGramoItaly(jt_peso.Text, lst_categoria_precio.SelectedItem.ToString())
            CalcularValorUnitario()
            CalcularCostoTotal()
        End If
        ActualizarNombreCompleto()
    End Sub
    Private Sub jt_grosor_TextChanged(sender As Object, e As EventArgs) Handles jt_grosor.TextChanged
        ActualizarNombreCompleto()
    End Sub
    Private Sub jt_largo_TextChanged(sender As Object, e As EventArgs) Handles jt_largo.TextChanged
        ActualizarNombreCompleto()
    End Sub
    Private Sub jt_descripcion_TextChanged(sender As Object, e As EventArgs) Handles jt_descripcion.TextChanged
        ActualizarNombreCompleto()
    End Sub
    Private Sub lst_marca_tabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_marca_tabla.SelectedIndexChanged
        Dim marca As String = lst_marca_tabla.SelectedItem.ToString()

        ' Realizar consulta solo si se selecciona la opción "Nacional"
        If marca = "Nacional" Then
            Try
                conexion.Open()
                Dim query As String = "SELECT id, peso_inicial, peso_final, categoria_precio, valor FROM gramonacional"
                Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
                Dim tabla As New System.Data.DataTable()
                adapter.Fill(tabla)
                tb_precios.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False

                ' Asignar los nombres de columna personalizados a cada una de las columnas del control
                tb_precios.Columns(0).HeaderText = "ID"
                tb_precios.Columns(0).DataPropertyName = "id"

                tb_precios.Columns(1).HeaderText = "Peso Inicial"
                tb_precios.Columns(1).DataPropertyName = "peso_inicial"

                tb_precios.Columns(2).HeaderText = "Peso Final"
                tb_precios.Columns(2).DataPropertyName = "peso_final"

                tb_precios.Columns(3).HeaderText = "Categoría Precio"
                tb_precios.Columns(3).DataPropertyName = "categoria_precio"

                tb_precios.Columns(4).HeaderText = "Valor"
                tb_precios.Columns(4).DataPropertyName = "valor"
                tb_precios.Visible = True ' Mostrar tabla
                tb_precios.DataSource = tabla

                btn_actualizar_valores.Visible = True

            Catch ex As Exception
                MessageBox.Show("Error al obtener datos: " + ex.Message)
            Finally
                conexion.Close()
            End Try
        ElseIf marca = "Italy" Then
            Try
                conexion.Open()
                Dim query As String = "SELECT id, peso_inicial, peso_final, categoria_precio, valor FROM gramoitaly"
                Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(query, conexion)
                Dim tabla As New System.Data.DataTable()
                adapter.Fill(tabla)
                tb_precios.AutoGenerateColumns = True ' Establecer AutoGenerateColumns en False

                ' Asignar los nombres de columna personalizados a cada una de las columnas del control
                tb_precios.Columns(0).HeaderText = "ID"
                tb_precios.Columns(0).DataPropertyName = "id"

                tb_precios.Columns(1).HeaderText = "Peso Inicial"
                tb_precios.Columns(1).DataPropertyName = "peso_inicial"

                tb_precios.Columns(2).HeaderText = "Peso Final"
                tb_precios.Columns(2).DataPropertyName = "peso_final"

                tb_precios.Columns(3).HeaderText = "Categoría Precio"
                tb_precios.Columns(3).DataPropertyName = "categoria_precio"

                tb_precios.Columns(4).HeaderText = "Valor"
                tb_precios.Columns(4).DataPropertyName = "valor"
                tb_precios.Visible = True ' Mostrar tabla
                tb_precios.DataSource = tabla

                btn_actualizar_valores.Visible = True

            Catch ex As Exception
                MessageBox.Show("Error al obtener datos: " + ex.Message)
            Finally
                conexion.Close()
            End Try
        ElseIf marca = "Seleccione" Then
            tb_precios.Visible = False ' Ocultar la tabla
            btn_actualizar_valores.Visible = False
            btn_actualizar.Visible = False
            btn_cancelar.Visible = False
        End If

    End Sub

    Private Sub jt_cantidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles jt_cantidad.KeyPress
        ' Permitir solo números enteros
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub jt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_peso.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> "."c) AndAlso (e.KeyChar <> ","c) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True 'Evita que se escriba el caracter no permitido
        End If
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
    End Sub
    Private Sub jt_largo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_largo.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> "."c) AndAlso (e.KeyChar <> ","c) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True 'Evita que se escriba el caracter no permitido
        End If
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
    End Sub
    Private Sub jt_grosor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_grosor.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> "."c) AndAlso (e.KeyChar <> ","c) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True 'Evita que se escriba el caracter no permitido
        End If
        If (e.KeyChar = ".") Then
            e.KeyChar = ","
        End If
    End Sub
    Private Sub jt_peso_LostFocus(sender As Object, e As EventArgs) Handles jt_peso.LostFocus
        Dim peso As Double
        If Double.TryParse(jt_peso.Text, peso) AndAlso peso = 0 Then
            MessageBox.Show("El peso no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_peso.Text = ""
            jt_peso.Focus()
        End If
    End Sub
    Private Sub jt_cantidad_LostFocus(sender As Object, e As EventArgs) Handles jt_cantidad.LostFocus
        Dim cantidad As Double
        If Double.TryParse(jt_cantidad.Text, cantidad) AndAlso cantidad = 0 Then
            MessageBox.Show("La cantidad no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_cantidad.Text = ""
            jt_cantidad.Focus()
        End If
    End Sub
    Private Sub jt_grosor_LostFocus(sender As Object, e As EventArgs) Handles jt_grosor.LostFocus
        Dim grosor As Double
        If Double.TryParse(jt_grosor.Text, grosor) AndAlso grosor = 0 Then
            MessageBox.Show("El grosor no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_grosor.Text = ""
            jt_grosor.Focus()
        End If
    End Sub
    Private Sub jt_largo_LostFocus(sender As Object, e As EventArgs) Handles jt_largo.LostFocus
        Dim largo As Double
        If Double.TryParse(jt_largo.Text, largo) AndAlso largo = 0 Then
            MessageBox.Show("El largo no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_largo.Text = ""
            jt_largo.Focus()
        End If
    End Sub
    Private Sub jt_compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_compra.KeyPress
        ' Permitir solo la entrada de números
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limitar la longitud del texto a 6 caracteres
        If jt_compra.Text.Length >= 6 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub jt_compra_Leave(sender As Object, e As EventArgs) Handles jt_compra.Leave
        If jt_compra.Text = "0" Then
            MessageBox.Show("El valor no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra.Focus()
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        validarCampos()
        If camposValidados Then
            registrar_producto()
        End If
    End Sub
    Private Sub tb_precios_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles tb_precios.DataError
        ' Controlamos la excepción de tipo DataError
        If e.Exception.GetType = GetType(FormatException) Then
            MessageBox.Show("El valor debe ser numérico y no puede ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancelamos la edición de la celda
        End If
    End Sub
    Private Sub tb_precios_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles tb_precios.CellValidating
        If e.ColumnIndex = tb_precios.Columns("valor").Index Then ' Validamos solo la columna "valor"
            Dim valor As String = e.FormattedValue.ToString().Replace(".", "").Replace(",", "") ' Removemos puntos y comas

            If String.IsNullOrWhiteSpace(valor) Then ' Si la celda está vacía o contiene solo espacios en blanco
                e.Cancel = True ' Cancelamos la edición de la celda
                MessageBox.Show("El valor no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_precios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "" ' Limpiamos la celda
            ElseIf valor = "0" Then ' Si el valor ingresado es cero
                e.Cancel = True ' Cancelamos la edición de la celda
                MessageBox.Show("El valor no puede ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_precios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "" ' Limpiamos la celda
            ElseIf valor.Length > 9 Then ' Si se ingresaron más de 6 caracteres
                e.Cancel = True ' Cancelamos la edición de la celda
                MessageBox.Show("El valor no puede tener más de 9 cifras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tb_precios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = valor.Substring(0, 6) ' Limitamos la cantidad de caracteres y asignamos el nuevo valor
            Else ' Si es un número válido
                Dim esNumero As Double
                If Not Double.TryParse(valor, esNumero) Then ' Si no es un número
                    e.Cancel = True ' Cancelamos la edición de la celda
                    MessageBox.Show("El valor debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tb_precios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "" ' Limpiamos la celda
                End If
            End If
        End If
    End Sub
    Private Sub jt_id_consulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_id_consulta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            ' Simula un clic en el botón btn_consultar_id
            btn_consultar_id.PerformClick()
            e.Handled = True ' Marca el evento como manejado
        End If
    End Sub

    Friend WithEvents lst_tipo_producto As ComboBox
    Friend WithEvents lst_marca As ComboBox
    Friend WithEvents lst_categoria_precio As ComboBox
    Friend WithEvents lst_broche As ComboBox
    Friend WithEvents jt_descripcion As TextBox
    Friend WithEvents jt_peso_total As TextBox
    Friend WithEvents jt_grosor As TextBox
    Friend WithEvents jt_valor_broche As TextBox
    Friend WithEvents jt_peso As TextBox
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
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents jt_cantidad As TextBox
    Friend WithEvents rb_mujer As RadioButton
    Friend WithEvents rb_hombre As RadioButton
    Friend WithEvents Tab_Consultar As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tb_precios As DataGridView
    Friend WithEvents lst_marca_tabla As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_actualizar_valores As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents peso_inicial As DataGridViewTextBoxColumn
    Friend WithEvents peso_final As DataGridViewTextBoxColumn
    Friend WithEvents categoria_precio As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_effy As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents tb_productos As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents jt_compra As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents peso_total As DataGridViewTextBoxColumn
    Friend WithEvents categoria_producto As DataGridViewTextBoxColumn
    Friend WithEvents valor_unitario As DataGridViewTextBoxColumn
    Friend WithEvents costo_total As DataGridViewTextBoxColumn
    Friend WithEvents valor_gramo As DataGridViewTextBoxColumn
    Friend WithEvents valor_unitario_compra As DataGridViewTextBoxColumn
    Friend WithEvents btn_shopify As Button
    Friend WithEvents btn_compra As Button
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents OFD_depurar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_depurar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents btn_tarifa_precios As Button
    Friend WithEvents jt_id_consulta As TextBox
    Friend WithEvents btn_consultar_id As Button
    Friend WithEvents icon_actualizar As PictureBox
    Friend WithEvents tt_actualizar As ToolTip
    Friend WithEvents tt_depurar As ToolTip
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_backup As Button
End Class
