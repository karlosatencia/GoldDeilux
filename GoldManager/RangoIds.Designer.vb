<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RangoIds
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RangoIds))
        btn_aceptar = New Button()
        jt_desde = New TextBox()
        jt_hasta = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.Location = New Point(90, 113)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(78, 26)
        btn_aceptar.TabIndex = 0
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = True
        ' 
        ' jt_desde
        ' 
        jt_desde.Location = New Point(40, 69)
        jt_desde.MaxLength = 7
        jt_desde.Name = "jt_desde"
        jt_desde.Size = New Size(82, 23)
        jt_desde.TabIndex = 1
        ' 
        ' jt_hasta
        ' 
        jt_hasta.Location = New Point(143, 69)
        jt_hasta.MaxLength = 7
        jt_hasta.Name = "jt_hasta"
        jt_hasta.Size = New Size(82, 23)
        jt_hasta.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(127, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(12, 15)
        Label1.TabIndex = 3
        Label1.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 23)
        Label2.TabIndex = 4
        Label2.Text = "Ingrese un rango de Ids"
        ' 
        ' RangoIds
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(266, 163)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(jt_hasta)
        Controls.Add(jt_desde)
        Controls.Add(btn_aceptar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RangoIds"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rango Ids"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_aceptar As Button
    Friend WithEvents jt_desde As TextBox
    Friend WithEvents jt_hasta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
