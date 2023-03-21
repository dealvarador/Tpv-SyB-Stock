Imports System.Data.SqlClient

Module Metodos

#Region "Categorias y Productos"
    ' Guardar Categorias
    Public Function AddCategoria(Categoria As String) As Boolean
        Dim result As Boolean = False
        Dim CMD As New SqlCommand("INSERT INTO TbCategorias (cat) values(@cat)", CN)
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Cat", Categoria)
        Try
            CN.Open()
            CMD.ExecuteNonQuery()
            CN.Close()
            result = True

        Catch ex As Exception
            ErrorEncontrado = ": " & ex.Message
            CN.Close()

        End Try
        Return result
    End Function
    ' Guardar productos
    Public Function AddProductos(IdCat As Integer, Producto As String, Codigo As String) As Boolean
        Dim result As Boolean = False
        Dim CMD As New SqlCommand("INSERT INTO TbProductos (IdCat,Producto, Codigo)
        values(@IdCat,@Producto,@Codigo)", CN)
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@IdCat", IdCat)
        CMD.Parameters.AddWithValue("@Producto", Producto)
        CMD.Parameters.AddWithValue("@Codigo", Codigo)
        Try
            CN.Open()
            CMD.ExecuteNonQuery()
            CN.Close()
            result = True
            MessageBox.Show(MensajeGuardado, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ErrorEncontrado As Exception
            CN.Close()
            MessageBox.Show(MensajeError & ErrorEncontrado.Message, VentanaActual, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
    ' Actualizar Categorias

    ' Actualizar productos.
#End Region


End Module
