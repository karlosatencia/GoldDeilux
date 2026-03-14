<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Compra_Form
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
        jt_compra_it = New TextBox()
        jt_compra_nac = New TextBox()
        btn_crear_compra = New Button()
        btn_cancelar_compra = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(153, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 32)
        Label1.TabIndex = 0
        Label1.Text = "Crear compra"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(79, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 1
        Label2.Text = "Varlor Gr Italy"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(229, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 25)
        Label3.TabIndex = 2
        Label3.Text = "Varlor Gr Nacional"
        ' 
        ' jt_compra_it
        ' 
        jt_compra_it.Location = New Point(81, 127)
        jt_compra_it.Name = "jt_compra_it"
        jt_compra_it.Size = New Size(126, 23)
        jt_compra_it.TabIndex = 3
        ' 
        ' jt_compra_nac
        ' 
        jt_compra_nac.Location = New Point(245, 127)
        jt_compra_nac.Name = "jt_compra_nac"
        jt_compra_nac.Size = New Size(126, 23)
        jt_compra_nac.TabIndex = 4
        ' 
        ' btn_crear_compra
        ' 
        btn_crear_compra.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_crear_compra.Location = New Point(95, 184)
        btn_crear_compra.Name = "btn_crear_compra"
        btn_crear_compra.Size = New Size(108, 38)
        btn_crear_compra.TabIndex = 5
        btn_crear_compra.Text = "Crear"
        btn_crear_compra.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar_compra
        ' 
        btn_cancelar_compra.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_cancelar_compra.Location = New Point(245, 184)
        btn_cancelar_compra.Name = "btn_cancelar_compra"
        btn_cancelar_compra.Size = New Size(108, 38)
        btn_cancelar_compra.TabIndex = 6
        btn_cancelar_compra.Text = "Cancelar"
        btn_cancelar_compra.UseVisualStyleBackColor = True
        ' 
        ' Nueva_Compra_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 261)
        Controls.Add(btn_cancelar_compra)
        Controls.Add(btn_crear_compra)
        Controls.Add(jt_compra_nac)
        Controls.Add(jt_compra_it)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Nueva_Compra_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Crear compra"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents jt_compra_it As TextBox
    Friend WithEvents jt_compra_nac As TextBox
    Friend WithEvents btn_crear_compra As Button
    Friend WithEvents btn_cancelar_compra As Button
End Class
