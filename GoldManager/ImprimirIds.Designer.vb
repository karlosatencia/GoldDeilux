<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirIds
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        jt_desde = New TextBox()
        jt_hasta = New TextBox()
        btn_imprimir_ids = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Barlow Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(39, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(259, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese el rango que desea imprimir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Barlow Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(97, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 1
        Label2.Text = "Desde"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Barlow Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(217, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 15)
        Label3.TabIndex = 2
        Label3.Text = "Hasta"
        ' 
        ' jt_desde
        ' 
        jt_desde.Location = New Point(58, 99)
        jt_desde.Name = "jt_desde"
        jt_desde.Size = New Size(100, 23)
        jt_desde.TabIndex = 3
        ' 
        ' jt_hasta
        ' 
        jt_hasta.Location = New Point(185, 99)
        jt_hasta.Name = "jt_hasta"
        jt_hasta.Size = New Size(100, 23)
        jt_hasta.TabIndex = 4
        ' 
        ' btn_imprimir_ids
        ' 
        btn_imprimir_ids.Font = New Font("Barlow Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btn_imprimir_ids.Location = New Point(129, 137)
        btn_imprimir_ids.Name = "btn_imprimir_ids"
        btn_imprimir_ids.Size = New Size(88, 29)
        btn_imprimir_ids.TabIndex = 5
        btn_imprimir_ids.Text = "Imprimir"
        btn_imprimir_ids.UseVisualStyleBackColor = True
        ' 
        ' ImprimirIds
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(346, 196)
        Controls.Add(btn_imprimir_ids)
        Controls.Add(jt_hasta)
        Controls.Add(jt_desde)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ImprimirIds"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rango id's"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents jt_desde As TextBox
    Friend WithEvents jt_hasta As TextBox
    Friend WithEvents btn_imprimir_ids As Button
End Class
