<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutenticacion
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormAutenticacion))
        jt_usuario = New TextBox()
        jt_clave = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btn_ingresar = New Button()
        SuspendLayout()
        ' 
        ' jt_usuario
        ' 
        jt_usuario.Location = New Point(73, 38)
        jt_usuario.Name = "jt_usuario"
        jt_usuario.Size = New Size(100, 23)
        jt_usuario.TabIndex = 0
        ' 
        ' jt_clave
        ' 
        jt_clave.Location = New Point(73, 84)
        jt_clave.Name = "jt_clave"
        jt_clave.Size = New Size(100, 23)
        jt_clave.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(73, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña:"
        ' 
        ' btn_ingresar
        ' 
        btn_ingresar.Location = New Point(83, 113)
        btn_ingresar.Name = "btn_ingresar"
        btn_ingresar.Size = New Size(75, 23)
        btn_ingresar.TabIndex = 4
        btn_ingresar.Text = "Ingresar"
        btn_ingresar.UseVisualStyleBackColor = True
        ' 
        ' FormAutenticacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(247, 147)
        Controls.Add(btn_ingresar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(jt_clave)
        Controls.Add(jt_usuario)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormAutenticacion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Autenticación"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents jt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents jt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
End Class
