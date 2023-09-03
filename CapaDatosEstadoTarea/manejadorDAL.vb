Imports System.Data
Imports System.Data.SqlClient


Public Class manejadorDAL
    'Direccionando conexion a la BD ----- Autenticacion con Usuario de Windows.
    Private conexion As New SqlConnection("Data Source = MXSOPORTE3\SQLEXPRESS; Initial Catalog = TareaEstadoTest; Integrated Security = True")

    'Direccionando conexion a la BD ------- Autenticacion con usuario SQLServer , Escribir nombre de servidor, nombre de BD, User, pass.
    'Private conexion As New SqlConnection("Data source= [Nombre servidor]; Initial Catalog=; User ID= **** ; Password= ***")

    'Metodo para abrir conexion a la BD.
    Public Sub abrirConexion()
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
    End Sub

    'Metodo para Cerrar conexion a la BD.
    Public Sub cerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub


    'Ejecutar_SP: Ejecuta procedimientos almacenaos para recuperar, guardar, modificar, eliminar datos en la BD
    Public Sub Ejecutar_sp(NombreSP As String, lst As List(Of parametrosDAL))
        Dim cmd As SqlCommand 'Variable que captura los funciones del SQLComand
        Try
            abrirConexion() 'abrimos conexion
            cmd = New SqlCommand(NombreSP, conexion) 'se espera el nombre del procedimeinto almacena + se pasa la cedena de conexion'
            cmd.CommandType = CommandType.StoredProcedure ' se indica que se ejecuta un procedimiento almacenado
            If lst IsNot Nothing Then 'se captura en forma lista los campos o parametros y se valida si es vacia

                'ciclo para recorrer lista de los campos o parametros
                For i As Integer = 0 To lst.Count - 1

                    ' se valida el tipo de campo o parametro
                    If lst(i).Direccion = ParameterDirection.Input Then
                        cmd.Parameters.AddWithValue(lst(i).Nombre, lst(i).Valor)
                    ElseIf lst(i).Direccion = ParameterDirection.Output Then
                        cmd.Parameters.Add(lst(i).Nombre, lst(i).TipoDato, lst(i).Tamaño).Direction = ParameterDirection.Output
                    End If
                Next
                'ejecucion a la BD
                cmd.ExecuteNonQuery()
                ' Devuelve el valor que envia el SP del procedimiento almacendo.
                For i As Integer = 0 To lst.Count - 1
                    If cmd.Parameters(i).Direction = ParameterDirection.Output Then
                        lst(i).Valor = cmd.Parameters(i).Value.ToString()
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        Finally
            'Se cierra la conexion.
            cerrarConexion()
        End Try
    End Sub

    'Listado: devuelve datos para listar en forma de dataTable dibujar un Datagrid, ListView, combobox ....
    Public Function Listado(NombreSP As String, lst As List(Of parametrosDAL)) As DataTable
        Dim dt As New DataTable() 'se declara variable tipo datatble
        Dim da As SqlDataAdapter ' Variable captura funciones del SQLDataAdapter
        Try
            abrirConexion() 'abrimos conexion
            da = New SqlDataAdapter(NombreSP, conexion) 'Se envia el nombre sp + cadena conexion 
            da.SelectCommand.CommandType = CommandType.StoredProcedure 'se indica que se ejecuta un procedimiento almacenado

            If lst IsNot Nothing Then 'se captura en forma lista los campos o parametros y se valida si es vacia
                'ciclo donde se extrae los datos del SP se dibuja en un dataset.
                For i As Integer = 0 To lst.Count - 1
                    da.SelectCommand.Parameters.AddWithValue(lst(i).Nombre, lst(i).Valor)
                Next
            End If
            da.Fill(dt) 'datos en el dataset.
        Catch ex As Exception
            Throw ex
        Finally
            cerrarConexion() 'Cierra Conexion
        End Try
        Return dt
    End Function

End Class
