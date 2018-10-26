<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Me.m2 = New System.Windows.Forms.Label()
        Me.m1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tnom = New System.Windows.Forms.TextBox()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.m4 = New System.Windows.Forms.Label()
        Me.m3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcon = New System.Windows.Forms.TextBox()
        Me.tmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.ForeColor = System.Drawing.Color.Red
        Me.m2.Location = New System.Drawing.Point(182, 116)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(57, 13)
        Me.m2.TabIndex = 15
        Me.m2.Text = "Obligatorio"
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.ForeColor = System.Drawing.Color.Red
        Me.m1.Location = New System.Drawing.Point(182, 62)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(57, 13)
        Me.m1.TabIndex = 14
        Me.m1.Text = "Obligatorio"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(185, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID"
        '
        'tnom
        '
        Me.tnom.Location = New System.Drawing.Point(185, 93)
        Me.tnom.Name = "tnom"
        Me.tnom.Size = New System.Drawing.Size(159, 20)
        Me.tnom.TabIndex = 9
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(185, 39)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(159, 20)
        Me.tid.TabIndex = 8
        '
        'm4
        '
        Me.m4.AutoSize = True
        Me.m4.ForeColor = System.Drawing.Color.Red
        Me.m4.Location = New System.Drawing.Point(182, 240)
        Me.m4.Name = "m4"
        Me.m4.Size = New System.Drawing.Size(57, 13)
        Me.m4.TabIndex = 21
        Me.m4.Text = "Obligatorio"
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.ForeColor = System.Drawing.Color.Red
        Me.m3.Location = New System.Drawing.Point(182, 186)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(57, 13)
        Me.m3.TabIndex = 20
        Me.m3.Text = "Obligatorio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email / Correo"
        '
        'tcon
        '
        Me.tcon.Location = New System.Drawing.Point(185, 217)
        Me.tcon.Name = "tcon"
        Me.tcon.Size = New System.Drawing.Size(159, 20)
        Me.tcon.TabIndex = 17
        '
        'tmail
        '
        Me.tmail.Location = New System.Drawing.Point(185, 163)
        Me.tmail.Name = "tmail"
        Me.tmail.Size = New System.Drawing.Size(159, 20)
        Me.tmail.TabIndex = 16
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 355)
        Me.Controls.Add(Me.m4)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tcon)
        Me.Controls.Add(Me.tmail)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tnom)
        Me.Controls.Add(Me.tid)
        Me.Name = "registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents m2 As Label
    Friend WithEvents m1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tnom As TextBox
    Friend WithEvents tid As TextBox
    Friend WithEvents m4 As Label
    Friend WithEvents m3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tcon As TextBox
    Friend WithEvents tmail As TextBox
End Class
