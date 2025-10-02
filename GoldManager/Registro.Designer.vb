Imports MySqlConnector
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Engines

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
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
        rb_matrimonio = New RadioButton()
        Label20 = New Label()
        lst_compra = New ComboBox()
        lb_talla = New Label()
        jt_talla = New TextBox()
        lb_venta_pircing = New Label()
        jt_venta_pircing = New TextBox()
        lb_compra_pircing = New Label()
        jt_compra_pircing = New TextBox()
        ch_oro_blanco = New CheckBox()
        ch_oro_rosa = New CheckBox()
        ch_oro_amarillo = New CheckBox()
        ch_adicional = New CheckBox()
        lb_adicional = New Label()
        jt_adicional = New TextBox()
        Label21 = New Label()
        lst_sucursall = New ComboBox()
        jt_compra = New TextBox()
        Label17 = New Label()
        PictureBox1 = New PictureBox()
        TabPage3 = New TabPage()
        lblProcesando = New Label()
        ProgressBar1 = New ProgressBar()
        btn_actualizar_precios = New Button()
        btn_imprimir_reporte = New Button()
        Label24 = New Label()
        lst_compra_rep = New ComboBox()
        btn_tarifa_precios = New Button()
        btn_compra = New Button()
        btn_shopify = New Button()
        btn_effy = New Button()
        PictureBox2 = New PictureBox()
        TabPage4 = New TabPage()
        GroupBox3 = New GroupBox()
        Label26 = New Label()
        jt_referencia_traslado = New TextBox()
        btn_trasladar = New Button()
        jt_referencia = New TextBox()
        btn_consultar = New Button()
        Label23 = New Label()
        Label22 = New Label()
        lst_sucursal_consulta = New ComboBox()
        lst_compra_consulta = New ComboBox()
        GroupBox2 = New GroupBox()
        btn_backup = New Button()
        Label19 = New Label()
        icon_actualizar = New PictureBox()
        GroupBox1 = New GroupBox()
        Label18 = New Label()
        btn_depurar = New Button()
        tb_productos = New DataGridView()
        referencia = New DataGridViewTextBoxColumn()
        idcompra = New DataGridViewTextBoxColumn()
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
        broche = New DataGridViewTextBoxColumn()
        vbroche = New DataGridViewTextBoxColumn()
        DataSet1BindingSource = New BindingSource(components)
        TabPage5 = New TabPage()
        Label25 = New Label()
        btn_agregar_compra = New Button()
        btn_cerrar1 = New Button()
        tb_compras = New DataGridView()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        estado = New DataGridViewTextBoxColumn()
        cantidadproductos = New DataGridViewTextBoxColumn()
        DataSet1BindingSource1 = New BindingSource(components)
        TabPage2 = New TabPage()
        btn_act_automatico = New Button()
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
        TabPage6 = New TabPage()
        SplitContainer1 = New SplitContainer()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label30 = New Label()
        Label27 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        ComboBox2 = New ComboBox()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label32 = New Label()
        DataGridView1 = New DataGridView()
        identificacion = New DataGridViewTextBoxColumn()
        nombreMayorista = New DataGridViewTextBoxColumn()
        tipoMayorista = New DataGridViewTextBoxColumn()
        Label31 = New Label()
        OFD_depurar = New OpenFileDialog()
        tt_actualizar = New ToolTip(components)
        tt_depurar = New ToolTip(components)
        tt_backup = New ToolTip(components)
        Tab_Consultar.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(icon_actualizar, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(tb_productos, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSet1BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        TabPage5.SuspendLayout()
        CType(tb_compras, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSet1BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(tb_precios, ComponentModel.ISupportInitialize).BeginInit()
        TabPage6.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lst_marca_tabla
        ' 
        lst_marca_tabla.DropDownStyle = ComboBoxStyle.DropDownList
        lst_marca_tabla.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lst_marca_tabla.FormattingEnabled = True
        lst_marca_tabla.Items.AddRange(New Object() {"Seleccione", "Nacional", "Italy"})
        lst_marca_tabla.Location = New Point(447, 79)
        lst_marca_tabla.Margin = New Padding(4, 3, 4, 3)
        lst_marca_tabla.Name = "lst_marca_tabla"
        lst_marca_tabla.Size = New Size(121, 23)
        lst_marca_tabla.TabIndex = 0
        ' 
        ' lst_tipo_producto
        ' 
        lst_tipo_producto.DropDownStyle = ComboBoxStyle.DropDownList
        lst_tipo_producto.DropDownWidth = 114
        lst_tipo_producto.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_tipo_producto.FormattingEnabled = True
        lst_tipo_producto.Location = New Point(336, 232)
        lst_tipo_producto.Margin = New Padding(4, 3, 4, 3)
        lst_tipo_producto.Name = "lst_tipo_producto"
        lst_tipo_producto.Size = New Size(132, 28)
        lst_tipo_producto.TabIndex = 0
        ' 
        ' lst_marca
        ' 
        lst_marca.DropDownStyle = ComboBoxStyle.DropDownList
        lst_marca.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_marca.FormattingEnabled = True
        lst_marca.Items.AddRange(New Object() {"Seleccione", "Nacional", "Italy"})
        lst_marca.Location = New Point(605, 311)
        lst_marca.Margin = New Padding(4, 3, 4, 3)
        lst_marca.Name = "lst_marca"
        lst_marca.Size = New Size(121, 28)
        lst_marca.TabIndex = 14
        ' 
        ' lst_categoria_precio
        ' 
        lst_categoria_precio.DropDownStyle = ComboBoxStyle.DropDownList
        lst_categoria_precio.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_categoria_precio.FormattingEnabled = True
        lst_categoria_precio.Items.AddRange(New Object() {"Seleccione", "Precio contado", "Recargo +1", "Recargo +2", "Recargo +3", "Recargo +4"})
        lst_categoria_precio.Location = New Point(605, 380)
        lst_categoria_precio.Margin = New Padding(4, 3, 4, 3)
        lst_categoria_precio.Name = "lst_categoria_precio"
        lst_categoria_precio.Size = New Size(120, 28)
        lst_categoria_precio.TabIndex = 16
        ' 
        ' lst_broche
        ' 
        lst_broche.DropDownStyle = ComboBoxStyle.DropDownList
        lst_broche.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_broche.FormattingEnabled = True
        lst_broche.Location = New Point(738, 311)
        lst_broche.Margin = New Padding(4, 3, 4, 3)
        lst_broche.Name = "lst_broche"
        lst_broche.Size = New Size(114, 28)
        lst_broche.TabIndex = 15
        ' 
        ' jt_descripcion
        ' 
        jt_descripcion.Enabled = False
        jt_descripcion.Location = New Point(110, 311)
        jt_descripcion.Margin = New Padding(4, 3, 4, 3)
        jt_descripcion.Name = "jt_descripcion"
        jt_descripcion.Size = New Size(354, 23)
        jt_descripcion.TabIndex = 5
        ' 
        ' jt_peso_total
        ' 
        jt_peso_total.Location = New Point(451, 377)
        jt_peso_total.Margin = New Padding(4, 3, 4, 3)
        jt_peso_total.Name = "jt_peso_total"
        jt_peso_total.Size = New Size(74, 23)
        jt_peso_total.TabIndex = 11
        ' 
        ' jt_grosor
        ' 
        jt_grosor.Enabled = False
        jt_grosor.Location = New Point(191, 376)
        jt_grosor.Margin = New Padding(4, 3, 4, 3)
        jt_grosor.MaxLength = 5
        jt_grosor.Name = "jt_grosor"
        jt_grosor.Size = New Size(85, 23)
        jt_grosor.TabIndex = 8
        ' 
        ' jt_valor_broche
        ' 
        jt_valor_broche.Enabled = False
        jt_valor_broche.Location = New Point(738, 377)
        jt_valor_broche.Margin = New Padding(4, 3, 4, 3)
        jt_valor_broche.Name = "jt_valor_broche"
        jt_valor_broche.Size = New Size(114, 23)
        jt_valor_broche.TabIndex = 11
        ' 
        ' jt_cantidad
        ' 
        jt_cantidad.Location = New Point(110, 376)
        jt_cantidad.Margin = New Padding(4, 3, 4, 3)
        jt_cantidad.MaxLength = 4
        jt_cantidad.Name = "jt_cantidad"
        jt_cantidad.Size = New Size(74, 23)
        jt_cantidad.TabIndex = 7
        ' 
        ' jt_peso
        ' 
        jt_peso.Location = New Point(368, 376)
        jt_peso.Margin = New Padding(4, 3, 4, 3)
        jt_peso.MaxLength = 6
        jt_peso.Name = "jt_peso"
        jt_peso.Size = New Size(74, 23)
        jt_peso.TabIndex = 10
        ' 
        ' jt_largo
        ' 
        jt_largo.Enabled = False
        jt_largo.Location = New Point(284, 376)
        jt_largo.Margin = New Padding(4, 3, 4, 3)
        jt_largo.MaxLength = 6
        jt_largo.Name = "jt_largo"
        jt_largo.Size = New Size(74, 23)
        jt_largo.TabIndex = 9
        ' 
        ' jt_nombre_compuesto
        ' 
        jt_nombre_compuesto.Enabled = False
        jt_nombre_compuesto.Location = New Point(110, 477)
        jt_nombre_compuesto.Margin = New Padding(4, 3, 4, 3)
        jt_nombre_compuesto.Name = "jt_nombre_compuesto"
        jt_nombre_compuesto.Size = New Size(469, 23)
        jt_nombre_compuesto.TabIndex = 11
        ' 
        ' jt_valor_gramo
        ' 
        jt_valor_gramo.Enabled = False
        jt_valor_gramo.Location = New Point(605, 431)
        jt_valor_gramo.Margin = New Padding(4, 3, 4, 3)
        jt_valor_gramo.Name = "jt_valor_gramo"
        jt_valor_gramo.Size = New Size(120, 23)
        jt_valor_gramo.TabIndex = 14
        ' 
        ' jt_costo_total
        ' 
        jt_costo_total.Enabled = False
        jt_costo_total.Location = New Point(738, 477)
        jt_costo_total.Margin = New Padding(4, 3, 4, 3)
        jt_costo_total.Name = "jt_costo_total"
        jt_costo_total.Size = New Size(114, 23)
        jt_costo_total.TabIndex = 13
        ' 
        ' jt_valor_unitario
        ' 
        jt_valor_unitario.Enabled = False
        jt_valor_unitario.Location = New Point(605, 477)
        jt_valor_unitario.Margin = New Padding(4, 3, 4, 3)
        jt_valor_unitario.Name = "jt_valor_unitario"
        jt_valor_unitario.Size = New Size(121, 23)
        jt_valor_unitario.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(335, 212)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 16)
        Label1.TabIndex = 16
        Label1.Text = "Tipo de producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(110, 291)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 16)
        Label2.TabIndex = 17
        Label2.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(605, 291)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 16)
        Label3.TabIndex = 18
        Label3.Text = "Marca"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(191, 359)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 16)
        Label4.TabIndex = 19
        Label4.Text = "Grosor"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(284, 359)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 16)
        Label5.TabIndex = 20
        Label5.Text = "Largo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(738, 291)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 16)
        Label6.TabIndex = 21
        Label6.Text = "Broche"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(110, 359)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 16)
        Label7.TabIndex = 22
        Label7.Text = "Cantidad"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(368, 360)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 16)
        Label8.TabIndex = 23
        Label8.Text = "Peso"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(605, 361)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 16)
        Label9.TabIndex = 24
        Label9.Text = "Categoría precio"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(451, 359)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 16)
        Label10.TabIndex = 25
        Label10.Text = "Peso total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(738, 359)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 16)
        Label11.TabIndex = 26
        Label11.Text = "Valor broche"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(605, 414)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(81, 16)
        Label13.TabIndex = 28
        Label13.Text = "Valor gramo"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(605, 459)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(85, 16)
        Label14.TabIndex = 29
        Label14.Text = "Valor unitario"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(738, 460)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 16)
        Label15.TabIndex = 30
        Label15.Text = "Valor total"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(110, 457)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(115, 16)
        Label16.TabIndex = 31
        Label16.Text = "Nombre completo"
        ' 
        ' btn_registrar
        ' 
        btn_registrar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_registrar.Location = New Point(409, 517)
        btn_registrar.Margin = New Padding(4, 3, 4, 3)
        btn_registrar.Name = "btn_registrar"
        btn_registrar.Size = New Size(142, 35)
        btn_registrar.TabIndex = 18
        btn_registrar.Text = ">> Registrar <<"
        btn_registrar.UseVisualStyleBackColor = True
        ' 
        ' rb_mujer
        ' 
        rb_mujer.AutoSize = True
        rb_mujer.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        rb_mujer.Location = New Point(335, 288)
        rb_mujer.Margin = New Padding(4, 3, 4, 3)
        rb_mujer.Name = "rb_mujer"
        rb_mujer.Size = New Size(58, 20)
        rb_mujer.TabIndex = 3
        rb_mujer.TabStop = True
        rb_mujer.Text = "Mujer"
        rb_mujer.UseVisualStyleBackColor = True
        ' 
        ' rb_hombre
        ' 
        rb_hombre.AutoSize = True
        rb_hombre.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        rb_hombre.Location = New Point(395, 288)
        rb_hombre.Margin = New Padding(4, 3, 4, 3)
        rb_hombre.Name = "rb_hombre"
        rb_hombre.Size = New Size(74, 20)
        rb_hombre.TabIndex = 4
        rb_hombre.TabStop = True
        rb_hombre.Text = "Hombre"
        rb_hombre.UseVisualStyleBackColor = True
        ' 
        ' Tab_Consultar
        ' 
        Tab_Consultar.Controls.Add(TabPage1)
        Tab_Consultar.Controls.Add(TabPage3)
        Tab_Consultar.Controls.Add(TabPage4)
        Tab_Consultar.Controls.Add(TabPage5)
        Tab_Consultar.Controls.Add(TabPage2)
        Tab_Consultar.Controls.Add(TabPage6)
        Tab_Consultar.Dock = DockStyle.Fill
        Tab_Consultar.Font = New Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Tab_Consultar.Location = New Point(0, 0)
        Tab_Consultar.Margin = New Padding(4, 3, 4, 3)
        Tab_Consultar.Name = "Tab_Consultar"
        Tab_Consultar.SelectedIndex = 0
        Tab_Consultar.Size = New Size(982, 600)
        Tab_Consultar.TabIndex = 32
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), Image)
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(rb_matrimonio)
        TabPage1.Controls.Add(Label20)
        TabPage1.Controls.Add(lst_compra)
        TabPage1.Controls.Add(lb_talla)
        TabPage1.Controls.Add(jt_talla)
        TabPage1.Controls.Add(lb_venta_pircing)
        TabPage1.Controls.Add(jt_venta_pircing)
        TabPage1.Controls.Add(lb_compra_pircing)
        TabPage1.Controls.Add(jt_compra_pircing)
        TabPage1.Controls.Add(ch_oro_blanco)
        TabPage1.Controls.Add(ch_oro_rosa)
        TabPage1.Controls.Add(ch_oro_amarillo)
        TabPage1.Controls.Add(ch_adicional)
        TabPage1.Controls.Add(lb_adicional)
        TabPage1.Controls.Add(jt_adicional)
        TabPage1.Controls.Add(Label21)
        TabPage1.Controls.Add(lst_sucursall)
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
        TabPage1.Font = New Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 26)
        TabPage1.Margin = New Padding(4, 3, 4, 3)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4, 3, 4, 3)
        TabPage1.Size = New Size(974, 570)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Registro"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' rb_matrimonio
        ' 
        rb_matrimonio.AutoSize = True
        rb_matrimonio.Location = New Point(239, 289)
        rb_matrimonio.Name = "rb_matrimonio"
        rb_matrimonio.Size = New Size(86, 19)
        rb_matrimonio.TabIndex = 59
        rb_matrimonio.TabStop = True
        rb_matrimonio.Text = "Matrimonio"
        rb_matrimonio.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(416, 156)
        Label20.Name = "Label20"
        Label20.Size = New Size(62, 18)
        Label20.TabIndex = 58
        Label20.Text = "Compra"
        ' 
        ' lst_compra
        ' 
        lst_compra.DropDownStyle = ComboBoxStyle.DropDownList
        lst_compra.FormattingEnabled = True
        lst_compra.Location = New Point(416, 181)
        lst_compra.Name = "lst_compra"
        lst_compra.Size = New Size(121, 23)
        lst_compra.TabIndex = 57
        ' 
        ' lb_talla
        ' 
        lb_talla.AutoSize = True
        lb_talla.Enabled = False
        lb_talla.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        lb_talla.Location = New Point(479, 292)
        lb_talla.Name = "lb_talla"
        lb_talla.Size = New Size(38, 16)
        lb_talla.TabIndex = 56
        lb_talla.Text = "Talla"
        ' 
        ' jt_talla
        ' 
        jt_talla.Enabled = False
        jt_talla.Location = New Point(479, 311)
        jt_talla.Name = "jt_talla"
        jt_talla.Size = New Size(100, 23)
        jt_talla.TabIndex = 6
        ' 
        ' lb_venta_pircing
        ' 
        lb_venta_pircing.AutoSize = True
        lb_venta_pircing.Enabled = False
        lb_venta_pircing.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        lb_venta_pircing.Location = New Point(368, 410)
        lb_venta_pircing.Name = "lb_venta_pircing"
        lb_venta_pircing.Size = New Size(136, 16)
        lb_venta_pircing.TabIndex = 54
        lb_venta_pircing.Text = "Precio Venta Piercing"
        ' 
        ' jt_venta_pircing
        ' 
        jt_venta_pircing.Enabled = False
        jt_venta_pircing.Location = New Point(368, 428)
        jt_venta_pircing.Name = "jt_venta_pircing"
        jt_venta_pircing.Size = New Size(110, 23)
        jt_venta_pircing.TabIndex = 13
        ' 
        ' lb_compra_pircing
        ' 
        lb_compra_pircing.AutoSize = True
        lb_compra_pircing.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        lb_compra_pircing.Location = New Point(220, 410)
        lb_compra_pircing.Name = "lb_compra_pircing"
        lb_compra_pircing.Size = New Size(149, 16)
        lb_compra_pircing.TabIndex = 52
        lb_compra_pircing.Text = "Precio Compra Piercing"
        ' 
        ' jt_compra_pircing
        ' 
        jt_compra_pircing.Enabled = False
        jt_compra_pircing.Location = New Point(220, 428)
        jt_compra_pircing.Name = "jt_compra_pircing"
        jt_compra_pircing.Size = New Size(122, 23)
        jt_compra_pircing.TabIndex = 12
        ' 
        ' ch_oro_blanco
        ' 
        ch_oro_blanco.AutoSize = True
        ch_oro_blanco.Enabled = False
        ch_oro_blanco.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ch_oro_blanco.Location = New Point(284, 337)
        ch_oro_blanco.Name = "ch_oro_blanco"
        ch_oro_blanco.Size = New Size(87, 19)
        ch_oro_blanco.TabIndex = 50
        ch_oro_blanco.Text = "Oro Blanco"
        ch_oro_blanco.UseVisualStyleBackColor = True
        ' 
        ' ch_oro_rosa
        ' 
        ch_oro_rosa.AutoSize = True
        ch_oro_rosa.Enabled = False
        ch_oro_rosa.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ch_oro_rosa.Location = New Point(203, 337)
        ch_oro_rosa.Name = "ch_oro_rosa"
        ch_oro_rosa.Size = New Size(78, 19)
        ch_oro_rosa.TabIndex = 49
        ch_oro_rosa.Text = "Oro Rosa"
        ch_oro_rosa.UseVisualStyleBackColor = True
        ' 
        ' ch_oro_amarillo
        ' 
        ch_oro_amarillo.AutoSize = True
        ch_oro_amarillo.Enabled = False
        ch_oro_amarillo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ch_oro_amarillo.Location = New Point(110, 337)
        ch_oro_amarillo.Name = "ch_oro_amarillo"
        ch_oro_amarillo.Size = New Size(94, 19)
        ch_oro_amarillo.TabIndex = 48
        ch_oro_amarillo.Text = "Oro Amarillo"
        ch_oro_amarillo.UseVisualStyleBackColor = True
        ' 
        ' ch_adicional
        ' 
        ch_adicional.AutoSize = True
        ch_adicional.Location = New Point(336, 263)
        ch_adicional.Name = "ch_adicional"
        ch_adicional.Size = New Size(63, 19)
        ch_adicional.TabIndex = 47
        ch_adicional.Text = "Prenda"
        ch_adicional.UseVisualStyleBackColor = True
        ' 
        ' lb_adicional
        ' 
        lb_adicional.AutoSize = True
        lb_adicional.Enabled = False
        lb_adicional.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        lb_adicional.Location = New Point(110, 410)
        lb_adicional.Name = "lb_adicional"
        lb_adicional.Size = New Size(97, 16)
        lb_adicional.TabIndex = 46
        lb_adicional.Text = "Valor adicional"
        ' 
        ' jt_adicional
        ' 
        jt_adicional.Enabled = False
        jt_adicional.Location = New Point(110, 428)
        jt_adicional.Name = "jt_adicional"
        jt_adicional.Size = New Size(100, 23)
        jt_adicional.TabIndex = 11
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(479, 212)
        Label21.Name = "Label21"
        Label21.Size = New Size(59, 16)
        Label21.TabIndex = 41
        Label21.Text = "Sucursal"
        ' 
        ' lst_sucursall
        ' 
        lst_sucursall.DropDownStyle = ComboBoxStyle.DropDownList
        lst_sucursall.DropDownWidth = 114
        lst_sucursall.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        lst_sucursall.FormattingEnabled = True
        lst_sucursall.Location = New Point(483, 232)
        lst_sucursall.Margin = New Padding(4, 3, 4, 3)
        lst_sucursall.Name = "lst_sucursall"
        lst_sucursall.Size = New Size(132, 28)
        lst_sucursall.TabIndex = 1
        ' 
        ' jt_compra
        ' 
        jt_compra.Location = New Point(738, 431)
        jt_compra.Margin = New Padding(4, 3, 4, 3)
        jt_compra.Name = "jt_compra"
        jt_compra.Size = New Size(114, 23)
        jt_compra.TabIndex = 17
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(738, 414)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(139, 16)
        Label17.TabIndex = 32
        Label17.Text = "Precio de compra (Gr)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(368, 3)
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
        TabPage3.Controls.Add(lblProcesando)
        TabPage3.Controls.Add(ProgressBar1)
        TabPage3.Controls.Add(btn_actualizar_precios)
        TabPage3.Controls.Add(btn_imprimir_reporte)
        TabPage3.Controls.Add(Label24)
        TabPage3.Controls.Add(lst_compra_rep)
        TabPage3.Controls.Add(btn_tarifa_precios)
        TabPage3.Controls.Add(btn_compra)
        TabPage3.Controls.Add(btn_shopify)
        TabPage3.Controls.Add(btn_effy)
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Location = New Point(4, 26)
        TabPage3.Margin = New Padding(4, 3, 4, 3)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4, 3, 4, 3)
        TabPage3.Size = New Size(974, 570)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Reportes"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' lblProcesando
        ' 
        lblProcesando.AutoSize = True
        lblProcesando.Location = New Point(462, 552)
        lblProcesando.Name = "lblProcesando"
        lblProcesando.Size = New Size(89, 19)
        lblProcesando.TabIndex = 9
        lblProcesando.Text = "Procesando..."
        lblProcesando.Visible = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(254, 529)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(477, 23)
        ProgressBar1.TabIndex = 8
        ProgressBar1.Visible = False
        ' 
        ' btn_actualizar_precios
        ' 
        btn_actualizar_precios.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_actualizar_precios.Location = New Point(530, 330)
        btn_actualizar_precios.Name = "btn_actualizar_precios"
        btn_actualizar_precios.Size = New Size(201, 72)
        btn_actualizar_precios.TabIndex = 7
        btn_actualizar_precios.Text = "Actualizar precios"
        btn_actualizar_precios.UseVisualStyleBackColor = True
        ' 
        ' btn_imprimir_reporte
        ' 
        btn_imprimir_reporte.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_imprimir_reporte.Location = New Point(415, 441)
        btn_imprimir_reporte.Name = "btn_imprimir_reporte"
        btn_imprimir_reporte.Size = New Size(153, 69)
        btn_imprimir_reporte.TabIndex = 6
        btn_imprimir_reporte.Text = "Imprimir id's"
        btn_imprimir_reporte.UseVisualStyleBackColor = True
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(415, 152)
        Label24.Name = "Label24"
        Label24.Size = New Size(164, 18)
        Label24.TabIndex = 5
        Label24.Text = "Seleccione una compra"
        ' 
        ' lst_compra_rep
        ' 
        lst_compra_rep.DropDownStyle = ComboBoxStyle.DropDownList
        lst_compra_rep.FormattingEnabled = True
        lst_compra_rep.Location = New Point(432, 174)
        lst_compra_rep.Name = "lst_compra_rep"
        lst_compra_rep.Size = New Size(121, 25)
        lst_compra_rep.TabIndex = 4
        ' 
        ' btn_tarifa_precios
        ' 
        btn_tarifa_precios.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_tarifa_precios.Location = New Point(4, 31)
        btn_tarifa_precios.Margin = New Padding(4, 3, 4, 3)
        btn_tarifa_precios.Name = "btn_tarifa_precios"
        btn_tarifa_precios.Size = New Size(201, 70)
        btn_tarifa_precios.TabIndex = 3
        btn_tarifa_precios.Text = "Reporte Actualizar Precios"
        btn_tarifa_precios.UseVisualStyleBackColor = True
        btn_tarifa_precios.Visible = False
        ' 
        ' btn_compra
        ' 
        btn_compra.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_compra.Location = New Point(530, 212)
        btn_compra.Margin = New Padding(4, 3, 4, 3)
        btn_compra.Name = "btn_compra"
        btn_compra.Size = New Size(201, 72)
        btn_compra.TabIndex = 2
        btn_compra.Text = "Generar Reporte Compra"
        btn_compra.UseVisualStyleBackColor = True
        ' 
        ' btn_shopify
        ' 
        btn_shopify.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_shopify.Location = New Point(254, 330)
        btn_shopify.Margin = New Padding(4, 3, 4, 3)
        btn_shopify.Name = "btn_shopify"
        btn_shopify.Size = New Size(201, 72)
        btn_shopify.TabIndex = 1
        btn_shopify.Text = "Generar Reporte Shopy"
        btn_shopify.UseVisualStyleBackColor = True
        ' 
        ' btn_effy
        ' 
        btn_effy.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_effy.Location = New Point(254, 212)
        btn_effy.Margin = New Padding(4, 3, 4, 3)
        btn_effy.Name = "btn_effy"
        btn_effy.Size = New Size(201, 72)
        btn_effy.TabIndex = 0
        btn_effy.Text = "Generar Reporte Effi"
        btn_effy.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(389, -37)
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
        TabPage4.Controls.Add(GroupBox3)
        TabPage4.Controls.Add(jt_referencia)
        TabPage4.Controls.Add(btn_consultar)
        TabPage4.Controls.Add(Label23)
        TabPage4.Controls.Add(Label22)
        TabPage4.Controls.Add(lst_sucursal_consulta)
        TabPage4.Controls.Add(lst_compra_consulta)
        TabPage4.Controls.Add(GroupBox2)
        TabPage4.Controls.Add(Label19)
        TabPage4.Controls.Add(icon_actualizar)
        TabPage4.Controls.Add(GroupBox1)
        TabPage4.Controls.Add(tb_productos)
        TabPage4.Location = New Point(4, 26)
        TabPage4.Margin = New Padding(4, 3, 4, 3)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(4, 3, 4, 3)
        TabPage4.Size = New Size(974, 570)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Consultar productos"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(jt_referencia_traslado)
        GroupBox3.Controls.Add(btn_trasladar)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.Location = New Point(770, 6)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(175, 112)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Trasladar Producto"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(37, 27)
        Label26.Name = "Label26"
        Label26.Size = New Size(73, 16)
        Label26.TabIndex = 16
        Label26.Text = "Referencia"
        ' 
        ' jt_referencia_traslado
        ' 
        jt_referencia_traslado.Location = New Point(37, 45)
        jt_referencia_traslado.Name = "jt_referencia_traslado"
        jt_referencia_traslado.Size = New Size(100, 22)
        jt_referencia_traslado.TabIndex = 14
        ' 
        ' btn_trasladar
        ' 
        btn_trasladar.Location = New Point(48, 74)
        btn_trasladar.Name = "btn_trasladar"
        btn_trasladar.Size = New Size(77, 23)
        btn_trasladar.TabIndex = 15
        btn_trasladar.Text = "Trasladar"
        btn_trasladar.UseVisualStyleBackColor = True
        ' 
        ' jt_referencia
        ' 
        jt_referencia.Location = New Point(295, 142)
        jt_referencia.Name = "jt_referencia"
        jt_referencia.Size = New Size(100, 25)
        jt_referencia.TabIndex = 13
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_consultar.Location = New Point(427, 142)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(95, 23)
        btn_consultar.TabIndex = 12
        btn_consultar.Text = "Consultar"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(152, 124)
        Label23.Name = "Label23"
        Label23.Size = New Size(59, 16)
        Label23.TabIndex = 11
        Label23.Text = "Sucursal"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(7, 124)
        Label22.Name = "Label22"
        Label22.Size = New Size(55, 16)
        Label22.TabIndex = 10
        Label22.Text = "Compra"
        ' 
        ' lst_sucursal_consulta
        ' 
        lst_sucursal_consulta.DropDownStyle = ComboBoxStyle.DropDownList
        lst_sucursal_consulta.FormattingEnabled = True
        lst_sucursal_consulta.Items.AddRange(New Object() {"Bodega", "Detal", "Todas"})
        lst_sucursal_consulta.Location = New Point(154, 142)
        lst_sucursal_consulta.Name = "lst_sucursal_consulta"
        lst_sucursal_consulta.Size = New Size(121, 25)
        lst_sucursal_consulta.TabIndex = 9
        ' 
        ' lst_compra_consulta
        ' 
        lst_compra_consulta.DropDownStyle = ComboBoxStyle.DropDownList
        lst_compra_consulta.FormattingEnabled = True
        lst_compra_consulta.Location = New Point(9, 142)
        lst_compra_consulta.Name = "lst_compra_consulta"
        lst_compra_consulta.Size = New Size(121, 25)
        lst_compra_consulta.TabIndex = 8
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_backup)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(605, 6)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(159, 112)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Backup"
        ' 
        ' btn_backup
        ' 
        btn_backup.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_backup.Location = New Point(37, 40)
        btn_backup.Name = "btn_backup"
        btn_backup.Size = New Size(85, 32)
        btn_backup.TabIndex = 1
        btn_backup.Text = "Backup"
        tt_backup.SetToolTip(btn_backup, "Descargar backup de productos registrados")
        btn_backup.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(295, 124)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(73, 16)
        Label19.TabIndex = 6
        Label19.Text = "Referencia"
        ' 
        ' icon_actualizar
        ' 
        icon_actualizar.Cursor = Cursors.Hand
        icon_actualizar.Image = CType(resources.GetObject("icon_actualizar.Image"), Image)
        icon_actualizar.Location = New Point(532, 138)
        icon_actualizar.Margin = New Padding(4, 3, 4, 3)
        icon_actualizar.Name = "icon_actualizar"
        icon_actualizar.Size = New Size(34, 27)
        icon_actualizar.SizeMode = PictureBoxSizeMode.StretchImage
        icon_actualizar.TabIndex = 5
        icon_actualizar.TabStop = False
        tt_actualizar.SetToolTip(icon_actualizar, "Limpiar selección")
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(btn_depurar)
        GroupBox1.Location = New Point(9, 6)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(557, 112)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Depurar productos registrados"
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Italic, GraphicsUnit.Point)
        Label18.Location = New Point(6, 19)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(507, 53)
        Label18.TabIndex = 2
        Label18.Text = "Si desea depurar la lista de productos registrados, debe cargar un archivo excel con una única columna llamada Referencia en la cual estén las referencias de los productos que desea eliminar."
        ' 
        ' btn_depurar
        ' 
        btn_depurar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_depurar.Location = New Point(211, 74)
        btn_depurar.Margin = New Padding(4, 3, 4, 3)
        btn_depurar.Name = "btn_depurar"
        btn_depurar.Size = New Size(159, 33)
        btn_depurar.TabIndex = 0
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
        tb_productos.Columns.AddRange(New DataGridViewColumn() {referencia, idcompra, nombre, marca, cantidad, peso, peso_total, categoria_producto, valor_unitario, costo_total, valor_gramo, valor_unitario_compra, broche, vbroche})
        tb_productos.DataSource = DataSet1BindingSource
        tb_productos.Location = New Point(4, 171)
        tb_productos.Margin = New Padding(4, 3, 4, 3)
        tb_productos.Name = "tb_productos"
        tb_productos.ReadOnly = True
        tb_productos.RowHeadersVisible = False
        tb_productos.RowTemplate.Height = 25
        tb_productos.RowTemplate.Resizable = DataGridViewTriState.False
        tb_productos.Size = New Size(962, 405)
        tb_productos.TabIndex = 0
        ' 
        ' referencia
        ' 
        referencia.HeaderText = "referencia"
        referencia.Name = "referencia"
        referencia.ReadOnly = True
        ' 
        ' idcompra
        ' 
        idcompra.HeaderText = "idcompra"
        idcompra.Name = "idcompra"
        idcompra.ReadOnly = True
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
        ' broche
        ' 
        broche.HeaderText = "broche"
        broche.Name = "broche"
        broche.ReadOnly = True
        ' 
        ' vbroche
        ' 
        vbroche.HeaderText = "vbroche"
        vbroche.Name = "vbroche"
        vbroche.ReadOnly = True
        ' 
        ' TabPage5
        ' 
        TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), Image)
        TabPage5.BackgroundImageLayout = ImageLayout.Stretch
        TabPage5.Controls.Add(Label25)
        TabPage5.Controls.Add(btn_agregar_compra)
        TabPage5.Controls.Add(btn_cerrar1)
        TabPage5.Controls.Add(tb_compras)
        TabPage5.Location = New Point(4, 26)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(974, 570)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Gestionar Compras"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(428, 74)
        Label25.Name = "Label25"
        Label25.Size = New Size(134, 33)
        Label25.TabIndex = 3
        Label25.Text = "Compras"
        ' 
        ' btn_agregar_compra
        ' 
        btn_agregar_compra.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_agregar_compra.Location = New Point(357, 446)
        btn_agregar_compra.Name = "btn_agregar_compra"
        btn_agregar_compra.Size = New Size(124, 34)
        btn_agregar_compra.TabIndex = 2
        btn_agregar_compra.Text = "Agregar compra"
        btn_agregar_compra.UseVisualStyleBackColor = True
        ' 
        ' btn_cerrar1
        ' 
        btn_cerrar1.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cerrar1.Location = New Point(487, 446)
        btn_cerrar1.Name = "btn_cerrar1"
        btn_cerrar1.Size = New Size(124, 34)
        btn_cerrar1.TabIndex = 1
        btn_cerrar1.Text = "Cerrar compra"
        btn_cerrar1.UseVisualStyleBackColor = True
        ' 
        ' tb_compras
        ' 
        tb_compras.AllowUserToAddRows = False
        tb_compras.AllowUserToDeleteRows = False
        tb_compras.AutoGenerateColumns = False
        tb_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tb_compras.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, estado, cantidadproductos})
        tb_compras.DataSource = DataSet1BindingSource1
        tb_compras.Location = New Point(336, 124)
        tb_compras.Name = "tb_compras"
        tb_compras.ReadOnly = True
        tb_compras.RowTemplate.Height = 25
        tb_compras.Size = New Size(327, 316)
        tb_compras.TabIndex = 0
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.Frozen = True
        DataGridViewTextBoxColumn2.HeaderText = "id"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' estado
        ' 
        estado.Frozen = True
        estado.HeaderText = "estado"
        estado.Name = "estado"
        estado.ReadOnly = True
        ' 
        ' cantidadproductos
        ' 
        cantidadproductos.Frozen = True
        cantidadproductos.HeaderText = "Cantidad de productos"
        cantidadproductos.Name = "cantidadproductos"
        cantidadproductos.ReadOnly = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), Image)
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(btn_act_automatico)
        TabPage2.Controls.Add(Panel1)
        TabPage2.Controls.Add(btn_actualizar_valores)
        TabPage2.Controls.Add(tb_precios)
        TabPage2.Controls.Add(lst_marca_tabla)
        TabPage2.Controls.Add(Label12)
        TabPage2.Location = New Point(4, 26)
        TabPage2.Margin = New Padding(4, 3, 4, 3)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4, 3, 4, 3)
        TabPage2.Size = New Size(974, 570)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Tabla de precios"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btn_act_automatico
        ' 
        btn_act_automatico.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_act_automatico.Location = New Point(466, 508)
        btn_act_automatico.Name = "btn_act_automatico"
        btn_act_automatico.Size = New Size(190, 39)
        btn_act_automatico.TabIndex = 5
        btn_act_automatico.Text = "Actualizar automático"
        btn_act_automatico.UseVisualStyleBackColor = True
        btn_act_automatico.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_cancelar)
        Panel1.Controls.Add(btn_actualizar)
        Panel1.Location = New Point(700, 103)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(116, 77)
        Panel1.TabIndex = 4
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(13, 42)
        btn_cancelar.Margin = New Padding(4, 3, 4, 3)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(89, 23)
        btn_cancelar.TabIndex = 3
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        btn_cancelar.Visible = False
        ' 
        ' btn_actualizar
        ' 
        btn_actualizar.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_actualizar.Location = New Point(13, 13)
        btn_actualizar.Margin = New Padding(4, 3, 4, 3)
        btn_actualizar.Name = "btn_actualizar"
        btn_actualizar.Size = New Size(89, 23)
        btn_actualizar.TabIndex = 2
        btn_actualizar.Text = "Actualizar"
        btn_actualizar.UseVisualStyleBackColor = True
        btn_actualizar.Visible = False
        ' 
        ' btn_actualizar_valores
        ' 
        btn_actualizar_valores.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        btn_actualizar_valores.Location = New Point(279, 508)
        btn_actualizar_valores.Margin = New Padding(4, 3, 4, 3)
        btn_actualizar_valores.Name = "btn_actualizar_valores"
        btn_actualizar_valores.Size = New Size(167, 39)
        btn_actualizar_valores.TabIndex = 1
        btn_actualizar_valores.Text = "Actualizar manual"
        btn_actualizar_valores.UseVisualStyleBackColor = True
        btn_actualizar_valores.Visible = False
        ' 
        ' tb_precios
        ' 
        tb_precios.AllowUserToAddRows = False
        tb_precios.AllowUserToResizeColumns = False
        tb_precios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tb_precios.Columns.AddRange(New DataGridViewColumn() {id, peso_inicial, peso_final, categoria_precio, valor})
        tb_precios.Location = New Point(234, 116)
        tb_precios.Margin = New Padding(4, 3, 4, 3)
        tb_precios.Name = "tb_precios"
        tb_precios.ReadOnly = True
        tb_precios.RowHeadersVisible = False
        tb_precios.RowTemplate.Height = 25
        tb_precios.RowTemplate.Resizable = DataGridViewTriState.False
        tb_precios.Size = New Size(458, 386)
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
        Label12.Font = New Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(401, 82)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(45, 16)
        Label12.TabIndex = 0
        Label12.Text = "Marca"
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(SplitContainer1)
        TabPage6.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage6.Location = New Point(4, 26)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(974, 570)
        TabPage6.TabIndex = 5
        TabPage6.Text = "Mayoristas"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BorderStyle = BorderStyle.FixedSingle
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(ComboBox1)
        SplitContainer1.Panel1.Controls.Add(TextBox2)
        SplitContainer1.Panel1.Controls.Add(TextBox1)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Label30)
        SplitContainer1.Panel1.Controls.Add(Label27)
        SplitContainer1.Panel1.Controls.Add(Label29)
        SplitContainer1.Panel1.Controls.Add(Label28)
        SplitContainer1.Panel1.Font = New Font("Segoe UI Semilight", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(ComboBox2)
        SplitContainer1.Panel2.Controls.Add(Button2)
        SplitContainer1.Panel2.Controls.Add(TextBox3)
        SplitContainer1.Panel2.Controls.Add(Label32)
        SplitContainer1.Panel2.Controls.Add(DataGridView1)
        SplitContainer1.Panel2.Controls.Add(Label31)
        SplitContainer1.Size = New Size(968, 564)
        SplitContainer1.SplitterDistance = 400
        SplitContainer1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(129, 234)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(240, 29)
        ComboBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(129, 184)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(240, 29)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(129, 134)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 29)
        TextBox1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(129, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 50)
        Button1.TabIndex = 5
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label30.Location = New Point(16, 234)
        Label30.Name = "Label30"
        Label30.Size = New Size(44, 21)
        Label30.TabIndex = 4
        Label30.Text = "Tipo:"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.Location = New Point(16, 184)
        Label27.Name = "Label27"
        Label27.Size = New Size(70, 21)
        Label27.TabIndex = 3
        Label27.Text = "Nombre:"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(82, 37)
        Label29.Name = "Label29"
        Label29.Size = New Size(231, 32)
        Label29.TabIndex = 2
        Label29.Text = "Registrar Mayorista"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label28.Location = New Point(16, 134)
        Label28.Name = "Label28"
        Label28.Size = New Size(106, 21)
        Label28.TabIndex = 1
        Label28.Text = "Identificación:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(190, 84)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(240, 29)
        ComboBox2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(250, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 50)
        Button2.TabIndex = 9
        Button2.Text = "Consultar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(190, 126)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(240, 29)
        TextBox3.TabIndex = 8
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI Semilight", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label32.Location = New Point(105, 87)
        Label32.Name = "Label32"
        Label32.Size = New Size(81, 21)
        Label32.TabIndex = 7
        Label32.Text = "Filtrar por:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {identificacion, nombreMayorista, tipoMayorista})
        DataGridView1.Location = New Point(34, 257)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(495, 286)
        DataGridView1.TabIndex = 1
        ' 
        ' identificacion
        ' 
        identificacion.Frozen = True
        identificacion.HeaderText = "Identificación"
        identificacion.Name = "identificacion"
        identificacion.ReadOnly = True
        ' 
        ' nombreMayorista
        ' 
        nombreMayorista.Frozen = True
        nombreMayorista.HeaderText = "Nombre"
        nombreMayorista.Name = "nombreMayorista"
        nombreMayorista.ReadOnly = True
        ' 
        ' tipoMayorista
        ' 
        tipoMayorista.Frozen = True
        tipoMayorista.HeaderText = "Tipo"
        tipoMayorista.Name = "tipoMayorista"
        tipoMayorista.ReadOnly = True
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI Semilight", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label31.Location = New Point(170, 37)
        Label31.Name = "Label31"
        Label31.Size = New Size(239, 32)
        Label31.TabIndex = 0
        Label31.Text = "Gestionar Mayorista"
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
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(982, 600)
        Controls.Add(Tab_Consultar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gold Manager - Elite"
        Tab_Consultar.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(icon_actualizar, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(tb_productos, ComponentModel.ISupportInitialize).EndInit()
        CType(DataSet1BindingSource, ComponentModel.ISupportInitialize).EndInit()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(tb_compras, ComponentModel.ISupportInitialize).EndInit()
        CType(DataSet1BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(tb_precios, ComponentModel.ISupportInitialize).EndInit()
        TabPage6.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
        lst_sucursall.Text = "Seleccione"
        ch_adicional.Enabled = False
        lb_compra_pircing.Enabled = False
        lb_venta_pircing.Enabled = False
        jt_compra_pircing.Enabled = False
        jt_venta_pircing.Enabled = False
        jt_compra_pircing.Text = ""
        jt_venta_pircing.Text = ""
        jt_talla.Text = ""
        lb_talla.Enabled = False

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
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = False

            Case "Dije"
                jt_largo.Enabled = True
                jt_grosor.Enabled = True
                jt_cantidad.Enabled = True
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = False

            Case "Anillo"
                jt_talla.Enabled = True
                jt_grosor.Enabled = True
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
                rb_matrimonio.Visible = True
                rb_matrimonio.Enabled = True
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                lb_talla.Enabled = True

            Case "Anillo Solitario", "Anillo Matrimonio", "Anillo 15"
                jt_grosor.Enabled = False
                jt_largo.Enabled = False
                jt_descripcion.Enabled = True
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = True
                lst_categoria_precio.Enabled = True
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = True
                lb_talla.Enabled = True

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
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = False

            Case "Herraje", "Pulsera tejida", "Candonga", "Bola"
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
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Checked = False
                ch_adicional.Enabled = True
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                ch_oro_rosa.Enabled = True
                ch_oro_blanco.Enabled = True
                ch_oro_amarillo.Enabled = True
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = False

            Case "Piercing"
                jt_descripcion.Enabled = True
                jt_grosor.Enabled = False
                jt_largo.Enabled = False
                lst_marca.Enabled = True
                lst_broche.Enabled = False
                jt_cantidad.Enabled = True
                jt_peso.Enabled = False
                jt_peso_total.Enabled = False
                lst_categoria_precio.Enabled = False
                jt_nombre_compuesto.Enabled = False
                rb_mujer.Visible = False
                rb_hombre.Visible = False
                rb_mujer.Checked = False
                rb_hombre.Checked = False
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Checked = False
                ch_adicional.Enabled = False
                lb_compra_pircing.Enabled = True
                lb_venta_pircing.Enabled = True
                jt_compra_pircing.Enabled = True
                jt_venta_pircing.Enabled = True
                jt_talla.Enabled = False

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
                rb_matrimonio.Visible = False
                rb_matrimonio.Checked = False
                ch_adicional.Enabled = False
                jt_compra.Enabled = False
                ch_adicional.Checked = False
                lb_adicional.Enabled = False
                jt_adicional.Enabled = False
                jt_adicional.Text = ""
                jt_nombre_compuesto.Text = ""
                lb_compra_pircing.Enabled = False
                lb_venta_pircing.Enabled = False
                jt_compra_pircing.Enabled = False
                jt_venta_pircing.Enabled = False
                jt_compra_pircing.Text = ""
                jt_venta_pircing.Text = ""
                jt_talla.Text = ""
                ch_oro_rosa.Enabled = False
                ch_oro_blanco.Enabled = False
                ch_oro_amarillo.Enabled = False
                ch_oro_amarillo.Checked = False
                ch_oro_blanco.Checked = False
                ch_oro_rosa.Checked = False
                jt_talla.Enabled = False
                lb_talla.Enabled = False
        End Select
    End Sub
    Private Sub lst_sucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_sucursall.SelectedIndexChanged
        ActualizarNombreCompleto()
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
            If lst_tipo_producto.Text = "Piercing" Then
                jt_compra.Enabled = False
            Else
                jt_compra.Enabled = True
                jt_compra.Text = ""
                Dim peso As Decimal
                Decimal.TryParse(jt_peso.Text, peso)
                jt_valor_gramo.Text = ObtenerValorGamoNacional(peso, lst_categoria_precio.SelectedItem.ToString())
                CalcularValorUnitario()
                CalcularCostoTotal()
            End If
        ElseIf lst_marca.Text = "Italy" Then
            If lst_tipo_producto.Text = "Piercing" Then
                jt_compra.Enabled = False
            Else
                lst_broche.Text = "Seleccione"
                jt_compra.Enabled = True
                jt_compra.Text = ""
                Dim peso As Decimal
                Decimal.TryParse(jt_peso.Text, peso)
                jt_valor_gramo.Text = ObtenerValorGramoItaly(peso, lst_categoria_precio.SelectedItem.ToString())
                CalcularValorUnitario()
                CalcularCostoTotal()
            End If
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
    Private Sub jt_talla_TextChanged(sender As Object, e As EventArgs) Handles jt_talla.TextChanged
        ActualizarNombreCompleto()
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
            ActualizarNombreCompleto()
        Else
            jt_valor_broche.Text = CalcularValorBroche(lst_broche.SelectedItem)
            ActualizarNombreCompleto()
        End If
        CalcularPesoTotal()
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
            btn_act_automatico.Visible = True
            Try
                conexion.Open()
                Dim query As String = "SELECT id, peso_inicial, peso_final, categoria_precio, valor FROM gramonacional_new"
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
            btn_act_automatico.Visible = True
            Try
                conexion.Open()
                Dim query As String = "SELECT id, peso_inicial, peso_final, categoria_precio, valor FROM gramoitaly_new"
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
            btn_act_automatico.Visible = False
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
        If jt_compra.Text.Length >= 8 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub jt_compra_Leave(sender As Object, e As EventArgs) Handles jt_compra.Leave
        If jt_compra.Text = "0" Then
            MessageBox.Show("El valor no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra.Focus()
        End If
    End Sub
    Private Sub jt_valor_unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_valor_unitario.KeyPress
        ' Permitir solo la entrada de números
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limitar la longitud del texto a 9 caracteres
        If jt_valor_unitario.Text.Length >= 9 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub jt_valor_unitario_Leave(sender As Object, e As EventArgs) Handles jt_valor_unitario.Leave
        If jt_valor_unitario.Text = "0" Then
            MessageBox.Show("El valor no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_valor_unitario.Focus()
        End If
    End Sub
    Private Sub jt_valor_unitario_TextChanged(sender As Object, e As EventArgs) Handles jt_valor_unitario.TextChanged
        CalcularCostoTotal()
    End Sub
    Private Sub jt_compra_pircing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_compra_pircing.KeyPress
        ' Permitir solo la entrada de números
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        ' Limitar la longitud del texto a 10 caracteres
        If jt_compra_pircing.Text.Length >= 10 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub jt_compra_pircing_Leave(sender As Object, e As EventArgs) Handles jt_compra_pircing.Leave
        If jt_compra_pircing.Text = "0" Then
            MessageBox.Show("El precio de compra del Piercing no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_compra_pircing.Focus()
        End If
    End Sub
    Private Sub jt_venta_pircing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_venta_pircing.KeyPress
        ' Permitir solo la entrada de números
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        ' Limitar la longitud del texto a 10 caracteres
        If jt_venta_pircing.Text.Length >= 10 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub jt_venta_pircing_Leave(sender As Object, e As EventArgs) Handles jt_venta_pircing.Leave
        If jt_venta_pircing.Text = "0" Then
            MessageBox.Show("El precio de venta del Piercing no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_venta_pircing.Focus()
        End If
    End Sub
    Private Sub jt_adicional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jt_adicional.KeyPress
        ' Permitir solo la entrada de números
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        ' Limitar la longitud del texto a 9 caracteres
        If jt_adicional.Text.Length >= 9 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub jt_adicional_Leave(sender As Object, e As EventArgs) Handles jt_adicional.Leave
        If jt_adicional.Text = "0" Then
            MessageBox.Show("El valor adicional no puede ser cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            jt_adicional.Focus()
        End If
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If lst_tipo_producto.Text = "Piercing" Then
            validarCamposPircing()
            If CamposPircingValidados Then
                registrar_pircing()
            End If
        Else
            validarCampos()
            If camposValidados Then
                registrar_producto()
            End If
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
    Private Sub jt_talla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jt_talla.KeyPress
        ' Verificar si la tecla presionada es un número, el caracter /, un espacio o la tecla Backspace
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "/"c AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ControlChars.Back) Then
            ' Si no es un número, el caracter /, un espacio ni la tecla Backspace, cancelar el evento de la tecla presionada
            e.Handled = True
            Return
        End If

        ' Verificar si ya hay un espacio en el texto actual
        If e.KeyChar = " "c AndAlso jt_talla.Text.Contains(" ") Then
            ' Si ya hay un espacio presente en el texto, cancelar el evento de la tecla presionada
            e.Handled = True
            Return
        End If

        ' Verificar la longitud de jt_talla
        Dim maxLength As Integer = 6
        If jt_talla.Text.Length >= maxLength AndAlso e.KeyChar <> ControlChars.Back Then
            ' Si se ha alcanzado la longitud máxima y no es una tecla de retroceso, cancelar el evento de la tecla presionada
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub ch_adicional_CheckedChanged(sender As Object, e As EventArgs) Handles ch_adicional.CheckedChanged
        If ch_adicional.Checked Then
            jt_adicional.Enabled = True
            lb_adicional.Enabled = True
        Else
            jt_adicional.Enabled = False
            jt_adicional.Text = ""
            lb_adicional.Enabled = False

        End If
    End Sub
    Private Sub ch_oro_amarillo_CheckedChanged(sender As Object, e As EventArgs) Handles ch_oro_amarillo.CheckedChanged
        ActualizarNombreCompleto()
    End Sub
    Private Sub ch_oro_blanco_CheckedChanged(sender As Object, e As EventArgs) Handles ch_oro_blanco.CheckedChanged
        ActualizarNombreCompleto()
    End Sub
    Private Sub ch_oro_rosa_CheckedChanged(sender As Object, e As EventArgs) Handles ch_oro_rosa.CheckedChanged
        ActualizarNombreCompleto()
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
    Friend WithEvents btn_shopify As Button
    Friend WithEvents btn_compra As Button
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents OFD_depurar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_depurar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents btn_tarifa_precios As Button
    Friend WithEvents icon_actualizar As PictureBox
    Friend WithEvents tt_actualizar As ToolTip
    Friend WithEvents tt_depurar As ToolTip
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_backup As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents lst_sucursall As ComboBox
    Friend WithEvents tt_backup As ToolTip
    Friend WithEvents ch_adicional As CheckBox
    Friend WithEvents lb_adicional As Label
    Friend WithEvents jt_adicional As TextBox
    Friend WithEvents ch_oro_blanco As CheckBox
    Friend WithEvents ch_oro_rosa As CheckBox
    Friend WithEvents ch_oro_amarillo As CheckBox
    Friend WithEvents lb_venta_pircing As Label
    Friend WithEvents jt_venta_pircing As TextBox
    Friend WithEvents lb_compra_pircing As Label
    Friend WithEvents jt_compra_pircing As TextBox
    Friend WithEvents lb_talla As Label
    Friend WithEvents jt_talla As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lst_compra As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lst_sucursal_consulta As ComboBox
    Friend WithEvents lst_compra_consulta As ComboBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents jt_referencia As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents tb_compras As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents cantidadproductos As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1BindingSource1 As BindingSource
    Friend WithEvents btn_agregar_compra As Button
    Friend WithEvents btn_cerrar1 As Button
    Friend WithEvents lst_compra_rep As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents referencia As DataGridViewTextBoxColumn
    Friend WithEvents idcompra As DataGridViewTextBoxColumn
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
    Friend WithEvents broche As DataGridViewTextBoxColumn
    Friend WithEvents vbroche As DataGridViewTextBoxColumn
    Friend WithEvents btn_trasladar As Button
    Friend WithEvents jt_referencia_traslado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents rb_matrimonio As RadioButton
    Friend WithEvents btn_imprimir_reporte As Button
    Friend WithEvents btn_actualizar_precios As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblProcesando As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents identificacion As DataGridViewTextBoxColumn
    Friend WithEvents nombreMayorista As DataGridViewTextBoxColumn
    Friend WithEvents tipoMayorista As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btn_act_automatico As Button
End Class
