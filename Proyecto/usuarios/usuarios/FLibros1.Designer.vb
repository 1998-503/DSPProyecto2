<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLibros1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAutor = New System.Windows.Forms.Button()
        Me.btnGenero = New System.Windows.Forms.Button()
        Me.btnEditorial = New System.Windows.Forms.Button()
        Me.dgvLibro = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(765, 52)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Libros"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(765, 44)
        Me.Label5.TabIndex = 19
        '
        'btnAutor
        '
        Me.btnAutor.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAutor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutor.ForeColor = System.Drawing.Color.White
        Me.btnAutor.Location = New System.Drawing.Point(25, 55)
        Me.btnAutor.Name = "btnAutor"
        Me.btnAutor.Size = New System.Drawing.Size(91, 27)
        Me.btnAutor.TabIndex = 20
        Me.btnAutor.Text = "Opciones Autor"
        Me.btnAutor.UseVisualStyleBackColor = False
        '
        'btnGenero
        '
        Me.btnGenero.BackColor = System.Drawing.Color.DarkCyan
        Me.btnGenero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenero.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenero.ForeColor = System.Drawing.Color.White
        Me.btnGenero.Location = New System.Drawing.Point(144, 55)
        Me.btnGenero.Name = "btnGenero"
        Me.btnGenero.Size = New System.Drawing.Size(108, 27)
        Me.btnGenero.TabIndex = 21
        Me.btnGenero.Text = "Opciones Género"
        Me.btnGenero.UseVisualStyleBackColor = False
        '
        'btnEditorial
        '
        Me.btnEditorial.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEditorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditorial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditorial.ForeColor = System.Drawing.Color.White
        Me.btnEditorial.Location = New System.Drawing.Point(270, 55)
        Me.btnEditorial.Name = "btnEditorial"
        Me.btnEditorial.Size = New System.Drawing.Size(105, 27)
        Me.btnEditorial.TabIndex = 22
        Me.btnEditorial.Text = "Opciones Editorial"
        Me.btnEditorial.UseVisualStyleBackColor = False
        '
        'dgvLibro
        '
        Me.dgvLibro.AllowUserToAddRows = False
        Me.dgvLibro.AllowUserToDeleteRows = False
        Me.dgvLibro.AllowUserToResizeColumns = False
        Me.dgvLibro.AllowUserToResizeRows = False
        Me.dgvLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLibro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvLibro.Location = New System.Drawing.Point(6, 143)
        Me.dgvLibro.MultiSelect = False
        Me.dgvLibro.Name = "dgvLibro"
        Me.dgvLibro.ReadOnly = True
        Me.dgvLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibro.Size = New System.Drawing.Size(745, 195)
        Me.dgvLibro.TabIndex = 23
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DarkCyan
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(12, 346)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(105, 46)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(615, 346)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(105, 46)
        Me.btnNuevo.TabIndex = 25
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "&Lista de Libros Registrados"
        '
        'FLibros1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 404)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dgvLibro)
        Me.Controls.Add(Me.btnEditorial)
        Me.Controls.Add(Me.btnGenero)
        Me.Controls.Add(Me.btnAutor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FLibros1"
        Me.Text = "FLibros1"
        CType(Me.dgvLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAutor As Button
    Friend WithEvents btnGenero As Button
    Friend WithEvents btnEditorial As Button
    Friend WithEvents dgvLibro As DataGridView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label3 As Label
End Class
