<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compra
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
        lst_compra = New ComboBox()
        btn_cerrar = New Button()
        btn_cancelar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Barlow Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 24)
        Label1.TabIndex = 0
        Label1.Text = "Seleccione la compra que desea cerrar"
        ' 
        ' lst_compra
        ' 
        lst_compra.DropDownStyle = ComboBoxStyle.DropDownList
        lst_compra.FormattingEnabled = True
        lst_compra.Location = New Point(126, 79)
        lst_compra.Name = "lst_compra"
        lst_compra.Size = New Size(121, 23)
        lst_compra.TabIndex = 1
        ' 
        ' btn_cerrar
        ' 
        btn_cerrar.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cerrar.Location = New Point(103, 118)
        btn_cerrar.Name = "btn_cerrar"
        btn_cerrar.Size = New Size(75, 30)
        btn_cerrar.TabIndex = 2
        btn_cerrar.Text = "Cerrar"
        btn_cerrar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.Font = New Font("Barlow Light", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cancelar.Location = New Point(193, 118)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 30)
        btn_cancelar.TabIndex = 3
        btn_cancelar.Text = "Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' Compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 206)
        Controls.Add(btn_cancelar)
        Controls.Add(btn_cerrar)
        Controls.Add(lst_compra)
        Controls.Add(Label1)
        Name = "Compra"
        Text = "Compra"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lst_compra As ComboBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_cancelar As Button
End Class
