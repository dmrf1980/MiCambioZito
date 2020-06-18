<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dolar", "41,70", "43,90", "U$S"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Euro", "46,24", "51,31", "€"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Argentino", "0,18", "0,64", "A$"}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Real", "7,65", "9,65", "R$"}, -1)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LvwCotizacion = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.ChxEnPesos = New System.Windows.Forms.CheckBox()
        Me.CbxCambiar = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbnVenta = New System.Windows.Forms.RadioButton()
        Me.RbNCompra = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblSignoPeso = New System.Windows.Forms.Label()
        Me.LblSignoMoneda = New System.Windows.Forms.Label()
        Me.LblVuelto = New System.Windows.Forms.Label()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblAccionARealizar = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LvwCotizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización de la Moneda"
        '
        'LvwCotizacion
        '
        Me.LvwCotizacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LvwCotizacion.FullRowSelect = True
        Me.LvwCotizacion.GridLines = True
        Me.LvwCotizacion.HideSelection = False
        Me.LvwCotizacion.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.LvwCotizacion.Location = New System.Drawing.Point(10, 19)
        Me.LvwCotizacion.Name = "LvwCotizacion"
        Me.LvwCotizacion.Size = New System.Drawing.Size(202, 146)
        Me.LvwCotizacion.TabIndex = 0
        Me.LvwCotizacion.UseCompatibleStateImageBehavior = False
        Me.LvwCotizacion.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Moneda"
        Me.ColumnHeader1.Width = 78
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Compra"
        Me.ColumnHeader2.Width = 61
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Venta"
        Me.ColumnHeader3.Width = 61
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Signo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtMonto)
        Me.GroupBox2.Controls.Add(Me.ChxEnPesos)
        Me.GroupBox2.Controls.Add(Me.CbxCambiar)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moneda a Cambiar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Moneda:"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(281, 29)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(100, 20)
        Me.TxtMonto.TabIndex = 2
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChxEnPesos
        '
        Me.ChxEnPesos.AutoSize = True
        Me.ChxEnPesos.Location = New System.Drawing.Point(387, 31)
        Me.ChxEnPesos.Name = "ChxEnPesos"
        Me.ChxEnPesos.Size = New System.Drawing.Size(56, 17)
        Me.ChxEnPesos.TabIndex = 1
        Me.ChxEnPesos.Text = "En $U"
        Me.ChxEnPesos.UseVisualStyleBackColor = True
        Me.ChxEnPesos.Visible = False
        '
        'CbxCambiar
        '
        Me.CbxCambiar.BackColor = System.Drawing.Color.White
        Me.CbxCambiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCambiar.FormattingEnabled = True
        Me.CbxCambiar.Items.AddRange(New Object() {"Dolar", "Euro", "Argentino", "Reales"})
        Me.CbxCambiar.Location = New System.Drawing.Point(77, 29)
        Me.CbxCambiar.Name = "CbxCambiar"
        Me.CbxCambiar.Size = New System.Drawing.Size(121, 21)
        Me.CbxCambiar.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbnVenta)
        Me.GroupBox3.Controls.Add(Me.RbNCompra)
        Me.GroupBox3.Location = New System.Drawing.Point(260, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 89)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operación"
        '
        'RbnVenta
        '
        Me.RbnVenta.AutoSize = True
        Me.RbnVenta.Location = New System.Drawing.Point(19, 60)
        Me.RbnVenta.Name = "RbnVenta"
        Me.RbnVenta.Size = New System.Drawing.Size(53, 17)
        Me.RbnVenta.TabIndex = 0
        Me.RbnVenta.Text = "Venta"
        Me.RbnVenta.UseVisualStyleBackColor = True
        '
        'RbNCompra
        '
        Me.RbNCompra.AutoSize = True
        Me.RbNCompra.Checked = True
        Me.RbNCompra.Location = New System.Drawing.Point(19, 28)
        Me.RbNCompra.Name = "RbNCompra"
        Me.RbNCompra.Size = New System.Drawing.Size(61, 17)
        Me.RbNCompra.TabIndex = 0
        Me.RbNCompra.TabStop = True
        Me.RbNCompra.Text = "Compra"
        Me.RbNCompra.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblSignoPeso)
        Me.GroupBox4.Controls.Add(Me.LblSignoMoneda)
        Me.GroupBox4.Controls.Add(Me.LblVuelto)
        Me.GroupBox4.Controls.Add(Me.LblMonto)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(424, 121)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 91)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cambio"
        '
        'LblSignoPeso
        '
        Me.LblSignoPeso.Location = New System.Drawing.Point(236, 62)
        Me.LblSignoPeso.Name = "LblSignoPeso"
        Me.LblSignoPeso.Size = New System.Drawing.Size(40, 23)
        Me.LblSignoPeso.TabIndex = 6
        Me.LblSignoPeso.Text = "$"
        '
        'LblSignoMoneda
        '
        Me.LblSignoMoneda.Location = New System.Drawing.Point(236, 22)
        Me.LblSignoMoneda.Name = "LblSignoMoneda"
        Me.LblSignoMoneda.Size = New System.Drawing.Size(40, 23)
        Me.LblSignoMoneda.TabIndex = 6
        Me.LblSignoMoneda.Text = "$"
        '
        'LblVuelto
        '
        Me.LblVuelto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVuelto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblVuelto.Location = New System.Drawing.Point(51, 56)
        Me.LblVuelto.Name = "LblVuelto"
        Me.LblVuelto.Size = New System.Drawing.Size(182, 23)
        Me.LblVuelto.TabIndex = 5
        Me.LblVuelto.Text = "0"
        Me.LblVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMonto
        '
        Me.LblMonto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMonto.Location = New System.Drawing.Point(51, 16)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(182, 23)
        Me.LblMonto.TabIndex = 5
        Me.LblMonto.Text = "0"
        Me.LblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Vuelto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Monto:"
        '
        'BtnCambiar
        '
        Me.BtnCambiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiar.Location = New System.Drawing.Point(713, 67)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCambiar.TabIndex = 3
        Me.BtnCambiar.Text = "Cambiar"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Accion:"
        '
        'LblAccionARealizar
        '
        Me.LblAccionARealizar.ForeColor = System.Drawing.Color.Red
        Me.LblAccionARealizar.Location = New System.Drawing.Point(66, 234)
        Me.LblAccionARealizar.Name = "LblAccionARealizar"
        Me.LblAccionARealizar.Size = New System.Drawing.Size(640, 13)
        Me.LblAccionARealizar.TabIndex = 4
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnCambiar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 255)
        Me.Controls.Add(Me.LblAccionARealizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Cambio Zito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbxCambiar As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LvwCotizacion As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents ChxEnPesos As CheckBox
    Friend WithEvents RbnVenta As RadioButton
    Friend WithEvents RbNCompra As RadioButton
    Friend WithEvents LblVuelto As Label
    Friend WithEvents LblMonto As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents LblSignoPeso As Label
    Friend WithEvents LblSignoMoneda As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents LblAccionARealizar As Label
End Class
