<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.tu = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lm = New System.Windows.Forms.Label()
        Me.lm1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tu
        '
        Me.tu.Location = New System.Drawing.Point(202, 63)
        Me.tu.Name = "tu"
        Me.tu.Size = New System.Drawing.Size(159, 20)
        Me.tu.TabIndex = 0
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(202, 117)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(159, 20)
        Me.tc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(65, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Registrarse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lm
        '
        Me.lm.AutoSize = True
        Me.lm.ForeColor = System.Drawing.Color.Red
        Me.lm.Location = New System.Drawing.Point(199, 86)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(70, 13)
        Me.lm.TabIndex = 6
        Me.lm.Text = "Ingrese su ID"
        '
        'lm1
        '
        Me.lm1.AutoSize = True
        Me.lm1.ForeColor = System.Drawing.Color.Red
        Me.lm1.Location = New System.Drawing.Point(199, 140)
        Me.lm1.Name = "lm1"
        Me.lm1.Size = New System.Drawing.Size(107, 13)
        Me.lm1.TabIndex = 7
        Me.lm1.Text = "Ingrese su contraeña"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 261)
        Me.Controls.Add(Me.lm1)
        Me.Controls.Add(Me.lm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tu)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tu As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lm As Label
    Friend WithEvents lm1 As Label
End Class
