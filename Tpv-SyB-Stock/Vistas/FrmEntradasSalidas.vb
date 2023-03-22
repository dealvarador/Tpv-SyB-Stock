Public Class FrmEntradasSalidas
    Dim Guardar As Integer = 0
    Dim VacioEncontrado As String = ""
    Private Sub FrmEntradasSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VentanaActual = "Entradas y Salidas de Productos"
        Call BlocbtnsProds()
        Call BlocTxtProds()
        LvEntrSal.View = View.Details
        LvEntrSal.FullRowSelect = True
        LvEntrSal.Columns.Add("Id", 30, HorizontalAlignment.Center) '0
        LvEntrSal.Columns.Add("Fecha", 70, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Codigo", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("idcat", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Categoria", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("idprod", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Producto", 150, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Entrada", 90, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Salida", 90, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Precio", 90, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Total", 90, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Operacion", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("Operador", 0, HorizontalAlignment.Left) '1
        LvEntrSal.Columns.Add("top", 0, HorizontalAlignment.Left) '1
        If CargarEntradasSalidas() Then
            AgregarEntradasSalidas()
        End If
    End Sub
    Public Sub AgregarEntradasSalidas()
        LvEntrSal.Items.Clear()
        For Each producto In EntradasSalidasArray
            Dim id As Integer = Integer.Parse(producto(0))
            Dim fec As String = producto(1)
            Dim cod As String = producto(2)
            Dim ic As String = producto(3)
            Dim ca As String = producto(4)
            Dim idp As String = producto(5)
            Dim pro As String = producto(6)
            Dim ent As String = producto(7)
            Dim sal As String = producto(8)
            Dim pr As String = producto(9)
            Dim tot As String = producto(10)
            Dim ope As String = producto(11)
            Dim oper As String = producto(12)
            Dim top As String = producto(13)

            Dim lvItem As ListViewItem = LvEntrSal.Items.Add(id.ToString())
            lvItem.SubItems.Add(fec)
            lvItem.SubItems.Add(cod)
            lvItem.SubItems.Add(ic)
            lvItem.SubItems.Add(ca)
            lvItem.SubItems.Add(idp)
            lvItem.SubItems.Add(pro)
            lvItem.SubItems.Add(ent)
            lvItem.SubItems.Add(sal)
            lvItem.SubItems.Add(pr)
            lvItem.SubItems.Add(tot)
            lvItem.SubItems.Add(ope)
            lvItem.SubItems.Add(oper)
            lvItem.SubItems.Add(top)
        Next
    End Sub
    Private Sub BlocTxtProds()
        TxtCodigo.Enabled = False
        txtProducto.Enabled = False
        TxtCantidad.Enabled = False
        TxtPrecio.Enabled = False
        TxtTotal.Enabled = False
        CboTipo.Enabled = False
    End Sub

    Private Sub BlocbtnsProds()
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Private Sub DesbloqTxtprods()
        TxtCodigo.Enabled = True
        txtProducto.Enabled = True
        TxtCantidad.Enabled = True
        TxtPrecio.Enabled = True
        TxtTotal.Enabled = True
        CboTipo.Enabled = True
    End Sub
    Private Sub Limpiartxt()
        Lblid.Text = ""
        LblIdCat.Text = ""
        LblCat.Text = ""
        LblidProd.Text = ""
        TxtCodigo.Text = ""
        txtProducto.Text = ""
        LblInventario.Text = ""
        LblUm.Text = ""
        CboTipo.Text = ""
        TxtCantidad.Text = ""
        TxtPrecio.Text = ""
        TxtTotal.Text = ""
    End Sub
    Private Sub EncontrarVacios()
        If LblIdCat.Text = "" Then
            VacioEncontrado = "Id Cat"
        ElseIf LblCat.Text = "" Then
            VacioEncontrado = "Cat"
        ElseIf LblidProd.Text = "" Then
            VacioEncontrado = "Id Prod"
        ElseIf TxtCodigo.Text = "" Then
            VacioEncontrado = "Codigo"
        ElseIf txtProducto.Text = "" Then
            VacioEncontrado = "Producto"
        ElseIf LblInventario.Text = "" Then
            VacioEncontrado = "Inventario"
        ElseIf LblUm.Text = "" Then
            VacioEncontrado = "Um"
        ElseIf CboTipo.Text = "" Then
            VacioEncontrado = "Tipo Operacion"
        ElseIf TxtCantidad.Text = "" Then
            VacioEncontrado = "Cantidad"
        ElseIf TxtPrecio.Text = "" Then
            VacioEncontrado = "Precio"
        ElseIf TxtTotal.Text = "" Then
            VacioEncontrado = "Total"
        Else
            VacioEncontrado = ""
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        ''Call Limpiartxt()
        Call DesbloqTxtprods()
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True

        Guardar = 1
        TxtCodigo.Focus()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Guardar = 0
        Limpiartxt()
        BlocbtnsProds()
        BlocTxtProds()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Guardar = 2
        DesbloqTxtprods()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
        BtnGuardar.Enabled = True
        BtnNuevo.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call EncontrarVacios()
        If VacioEncontrado <> "" Then
            MessageBox.Show("Campos vacios en: " & VacioEncontrado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Entrada, salida As Double
            If CboTipo.Text = "ENTRADA" Then
                Entrada = Convert.ToDouble(TxtCantidad.Text)
                salida = 0
            Else
                Entrada = 0
                salida = Convert.ToDouble(TxtCantidad.Text)
            End If
            If Guardar = 1 Then
                If AddEntradas(DtpDesde.Text, TxtCodigo.Text, CboTipo.Text, CInt(LblIdCat.Text), CInt(LblidProd.Text), Entrada, salida, Convert.ToDouble(TxtPrecio.Text), "Vendedor") Then
                    MessageBox.Show(MensajeGuardado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Guardar = 0

                    If CargarEntradasSalidas() Then
                        AgregarEntradasSalidas()
                    End If
                    Call Limpiartxt()
                    Call BlocTxtProds()
                    Call BlocbtnsProds()
                Else
                    MessageBox.Show(MensajeError & ErrorEncontrado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf Guardar = 2 And Lblid.Text.Length() > 0 Then
                If UpdateEntradas(CInt(Lblid.Text), DtpDesde.Text, TxtCodigo.Text, CboTipo.Text, CInt(LblIdCat.Text), CInt(LblidProd.Text), Entrada, salida, Convert.ToDouble(TxtPrecio.Text), "Vendedor") Then
                    MessageBox.Show(MensajeActualizado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Guardar = 0

                    If CargarEntradasSalidas() Then
                        AgregarEntradasSalidas()
                    End If
                    Call Limpiartxt()
                    Call BlocTxtProds()
                    Call BlocbtnsProds()
                Else
                    MessageBox.Show(MensajeError & ErrorEncontrado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If Lblid.Text.Length() > 0 Then
            If MessageBox.Show("Esta seguro de eliminar esta Operacion?", VentanaActual, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                If EliminarEntradasSalidas(CInt(Lblid.Text)) Then
                    Guardar = 0
                    MessageBox.Show(MensajeEliminado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If CargarEntradasSalidas() Then
                        AgregarEntradasSalidas()
                    End If
                    Call Limpiartxt()
                    Call BlocTxtProds()
                    Call BlocbtnsProds()
                Else
                    MessageBox.Show(MensajeError, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No se eliminara.", VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class