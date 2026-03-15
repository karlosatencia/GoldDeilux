<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteIngreso
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
        cmbCompras = New ComboBox()
        Label1 = New Label()
        btn_reporte_ingreso = New Button()
        btn_cancelar_rep_ingreso = New Button()
        SuspendLayout()
        ' 
        ' cmbCompras
        ' 
        cmbCompras.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCompras.Font = New Font("Mongolian Baiti", 12.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCompras.FormattingEnabled = True
        cmbCompras.Location = New Point(156, 74)
        cmbCompras.Name = "cmbCompras"
        cmbCompras.Size = New Size(121, 24)
        cmbCompras.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(134, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 20)
        Label1.TabIndex = 1
        Label1.Text = "Seleccione la compra"
        ' 
        ' btn_reporte_ingreso
        ' 
        btn_reporte_ingreso.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_reporte_ingreso.Location = New Point(60, 120)
        btn_reporte_ingreso.Name = "btn_reporte_ingreso"
        btn_reporte_ingreso.Size = New Size(138, 49)
        btn_reporte_ingreso.TabIndex = 2
        btn_reporte_ingreso.Text = "Generar"
        btn_reporte_ingreso.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar_rep_ingreso
        ' 
        btn_cancelar_rep_ingreso.Font = New Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cancelar_rep_ingreso.Location = New Point(231, 120)
        btn_cancelar_rep_ingreso.Name = "btn_cancelar_rep_ingreso"
        btn_cancelar_rep_ingreso.Size = New Size(138, 49)
        btn_cancelar_rep_ingreso.TabIndex = 3
        btn_cancelar_rep_ingreso.Text = "Cancelar"
        btn_cancelar_rep_ingreso.UseVisualStyleBackColor = True
        ' 
        ' ReporteIngreso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(422, 241)
        Controls.Add(btn_cancelar_rep_ingreso)
        Controls.Add(btn_reporte_ingreso)
        Controls.Add(Label1)
        Controls.Add(cmbCompras)
        Name = "ReporteIngreso"
        Text = "Generar reporte ingreso"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbCompras As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_reporte_ingreso As Button
    Friend WithEvents btn_cancelar_rep_ingreso As Button
End Class
