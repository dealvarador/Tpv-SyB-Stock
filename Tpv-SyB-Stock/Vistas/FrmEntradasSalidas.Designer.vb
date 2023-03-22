<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradasSalidas
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.LblidProd = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblIdCat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtpFechaGuardar = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.LblCat = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblInventario = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblUm = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboTipo = New System.Windows.Forms.ComboBox()
        Me.LvEntrSal = New System.Windows.Forms.ListView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LvEntrSal, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 472)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEliminar, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnCancelar, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnModificar, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnGuardar, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnNuevo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DtpDesde, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DtpHasta, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnBuscar, 8, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 39)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(800, 112)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.125!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.375!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.625!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.875!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.25!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.75!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Lblid, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LblidProd, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LblIdCat, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DtpFechaGuardar, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtProducto, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LblCat, 3, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(800, 56)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IdOpe"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Lblid.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblid.Location = New System.Drawing.Point(3, 36)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(43, 20)
        Me.Lblid.TabIndex = 3
        Me.Lblid.Text = "1"
        Me.Lblid.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblidProd
        '
        Me.LblidProd.AutoSize = True
        Me.LblidProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblidProd.Location = New System.Drawing.Point(403, 27)
        Me.LblidProd.Name = "LblidProd"
        Me.LblidProd.Size = New System.Drawing.Size(68, 29)
        Me.LblidProd.TabIndex = 6
        Me.LblidProd.Text = "1"
        Me.LblidProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(244, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Categoria"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IdCat"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblIdCat
        '
        Me.LblIdCat.AutoSize = True
        Me.LblIdCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblIdCat.Location = New System.Drawing.Point(175, 27)
        Me.LblIdCat.Name = "LblIdCat"
        Me.LblIdCat.Size = New System.Drawing.Size(63, 29)
        Me.LblIdCat.TabIndex = 4
        Me.LblIdCat.Text = "1"
        Me.LblIdCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DtpFechaGuardar
        '
        Me.DtpFechaGuardar.Location = New System.Drawing.Point(52, 30)
        Me.DtpFechaGuardar.Name = "DtpFechaGuardar"
        Me.DtpFechaGuardar.Size = New System.Drawing.Size(117, 20)
        Me.DtpFechaGuardar.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "IdProd"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtCodigo, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(474, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(326, 27)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 27)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Codigo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCodigo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(166, 3)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(157, 27)
        Me.TxtCodigo.TabIndex = 8
        Me.TxtCodigo.Text = "1235"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProducto
        '
        Me.txtProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(477, 30)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(320, 27)
        Me.txtProducto.TabIndex = 11
        Me.txtProducto.Text = "fghfghdfgh"
        '
        'LblCat
        '
        Me.LblCat.AutoSize = True
        Me.LblCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCat.Location = New System.Drawing.Point(244, 27)
        Me.LblCat.Name = "LblCat"
        Me.LblCat.Size = New System.Drawing.Size(153, 29)
        Me.LblCat.TabIndex = 12
        Me.LblCat.Text = "cat1"
        Me.LblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 7
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LblInventario, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label17, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LblUm, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtTotal, 6, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtPrecio, 5, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtCantidad, 4, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 6, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label12, 5, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CboTipo, 3, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.42857!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.57143!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(800, 56)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Inventario"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblInventario
        '
        Me.LblInventario.AutoSize = True
        Me.LblInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInventario.Location = New System.Drawing.Point(3, 25)
        Me.LblInventario.Name = "LblInventario"
        Me.LblInventario.Size = New System.Drawing.Size(108, 31)
        Me.LblInventario.TabIndex = 7
        Me.LblInventario.Text = "10"
        Me.LblInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(117, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "U. Medida"
        '
        'LblUm
        '
        Me.LblUm.AutoSize = True
        Me.LblUm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUm.Location = New System.Drawing.Point(117, 25)
        Me.LblUm.Name = "LblUm"
        Me.LblUm.Size = New System.Drawing.Size(108, 31)
        Me.LblUm.TabIndex = 9
        Me.LblUm.Text = "libra"
        Me.LblUm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotal
        '
        Me.TxtTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTotal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(687, 28)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(110, 26)
        Me.TxtTotal.TabIndex = 5
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtPrecio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(573, 28)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(108, 26)
        Me.TxtPrecio.TabIndex = 3
        Me.TxtPrecio.Text = "2"
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtCantidad.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(459, 28)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(108, 26)
        Me.TxtCantidad.TabIndex = 1
        Me.TxtCantidad.Text = "10"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(687, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Total"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(573, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Precio"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(459, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cantidad"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo Operacion"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CboTipo
        '
        Me.CboTipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.CboTipo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Items.AddRange(New Object() {"ENTRADA", "SALIDA"})
        Me.CboTipo.Location = New System.Drawing.Point(287, 28)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(166, 29)
        Me.CboTipo.TabIndex = 11
        '
        'LvEntrSal
        '
        Me.LvEntrSal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LvEntrSal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvEntrSal.ForeColor = System.Drawing.Color.White
        Me.LvEntrSal.HideSelection = False
        Me.LvEntrSal.Location = New System.Drawing.Point(3, 183)
        Me.LvEntrSal.Name = "LvEntrSal"
        Me.LvEntrSal.Size = New System.Drawing.Size(794, 286)
        Me.LvEntrSal.TabIndex = 3
        Me.LvEntrSal.UseCompatibleStateImageBehavior = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 33)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(91, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(82, 33)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(179, 3)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(82, 33)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(267, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 33)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(355, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(82, 33)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(531, 3)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(82, 20)
        Me.DtpDesde.TabIndex = 5
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(619, 3)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(82, 20)
        Me.DtpHasta.TabIndex = 6
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(707, 3)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(90, 33)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmEntradasSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmEntradasSalidas"
        Me.Text = "Entradas y Salidas de Productos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblid As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblidProd As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblIdCat As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DtpFechaGuardar As DateTimePicker
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LvEntrSal As ListView
    Friend WithEvents LblCat As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblInventario As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LblUm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboTipo As ComboBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents BtnBuscar As Button
End Class
