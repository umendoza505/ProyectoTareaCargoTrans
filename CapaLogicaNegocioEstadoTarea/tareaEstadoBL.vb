Imports System.Data.SqlClient
Imports CapaDatosEstadoTarea

Public Class tareaEstadoBL

    'Se declara las entidades de la clase.
    Public Property Tareaid_E As String
    Public Property TituloTarea_E As String
    Public Property DescripcionTarea_E As String
    Public Property UsuarioAsignado_E As Integer
    Public Property EstadoTarea_E As Integer
    Public Property TareaActiva_E As Integer



    ' Realizamos referencias a las clases de las capas a utilizar
    Private mjdor As New manejadorDAL() ' Instancia

    'Metodo Listar Tareas
    Public Function ListarTarea() As DataTable
        Dim lst As New List(Of parametrosDAL)() 'se crea Lista para enviar los datos a los parametros
        Try
            Return mjdor.Listado("spListarTarea", lst) 'Se utiliza metodo listar de la capa de datos, se envia Procedimiento Almacenado, lista.
        Catch ex As Exception
            Throw
        End Try
    End Function

    'Metodo Listar Estado
    Public Function ListarComboEstado() As DataTable
        Dim lst As New List(Of parametrosDAL)()
        Try
            lst.Add(New parametrosDAL("@SP", 1)) 'Se envia el parametro esperado por el SP en la BD
            Return mjdor.Listado("spCargaDatosComboTarea", lst) 'se crea Lista para enviar los datos a los parametros

        Catch ex As Exception
            Throw
        End Try
    End Function

    'Metodo Listar Usuarios Asignados
    Public Function ListarComboUsuarioAsignado() As DataTable
        Dim lst As New List(Of parametrosDAL)()
        Try
            lst.Add(New parametrosDAL("@SP", 2)) 'Se envia el parametro esperado por el SP en la BD
            Return mjdor.Listado("spCargaDatosComboTarea", lst) 'Se utiliza metodo listar de la capa de datos, se envia Procedimiento Almacenado, lista.

        Catch ex As Exception
            Throw
        End Try
    End Function
    'Metodo Listar Activo
    Public Function ListarComboActivo() As DataTable
        Dim lst As New List(Of parametrosDAL)()
        Try
            lst.Add(New parametrosDAL("@SP", 3)) 'Se envia el parametro esperado por el SP en la BD
            Return mjdor.Listado("spCargaDatosComboTarea", lst) 'Se utiliza metodo listar de la capa de datos, se envia Procedimiento Almacenado, lista.

        Catch ex As Exception
            Throw
        End Try
    End Function

    'Metodo para buscar multiples campos
    Public Function BuscarTarea() As DataTable
        Dim lst As New List(Of parametrosDAL)()
        Try
            'Se envia el parametro esperado por el SP en la BD
            lst.Add(New parametrosDAL("@TareaActiva", TareaActiva_E))
            lst.Add(New parametrosDAL("@TareaID", Tareaid_E))
            lst.Add(New parametrosDAL("@TituloTarea", TituloTarea_E))
            lst.Add(New parametrosDAL("@EstadoID", EstadoTarea_E))
            lst.Add(New parametrosDAL("@Usuario", UsuarioAsignado_E))

            'Se utiliza metodo listar de la capa de datos, se envia Procedimiento Almacenado, lista.
            Return mjdor.Listado("spFiltrarTareas", lst)

        Catch ex As Exception
            Throw
        End Try
    End Function

    'Metodo para recuperar datos especificos de Tarea
    Public Function RecuperarDatosTarea() As DataTable
        Dim lst As New List(Of parametrosDAL)()
        Try
            'Se envia el parametro esperado por el SP en la BD
            lst.Add(New parametrosDAL("@TareaID", Tareaid_E))
            'Se utiliza metodo listar de la capa de datos, se envia Procedimiento Almacenado, lista.
            Return mjdor.Listado("spRecuperarDatosTarea", lst)
        Catch ex As Exception
            Throw
        End Try
    End Function
    ' Registra Tarea Insercion y Actualizacion
    Public Function RegistrarTareasEstado()
        Dim msj As String = ""

        Dim lst As New List(Of parametrosDAL)()
        Try
            ' Mandamos los parámetros
            lst.Add(New parametrosDAL("@tareaID", Tareaid_E))
            lst.Add(New parametrosDAL("@tituloTarea", TituloTarea_E))
            lst.Add(New parametrosDAL("@DescripcionTarea", DescripcionTarea_E))
            lst.Add(New parametrosDAL("@UsuAsignado", UsuarioAsignado_E)) ' Usuario 1 Temporal
            lst.Add(New parametrosDAL("@EstadoTarea", EstadoTarea_E))
            lst.Add(New parametrosDAL("@TareaActiva", TareaActiva_E))

            ' Pasamos el parámetro de salida que se envía desde SQL
            lst.Add(New parametrosDAL("@mensaje", SqlDbType.VarChar, 100))

            mjdor.Ejecutar_sp("spRegistrarTareaEstado", lst)
            msj = lst(6).Valor.ToString()

        Catch ex As Exception
            Throw New Exception("Error al Registrar el método Registrar Area Capa Negocio", ex)
        End Try

        Return msj
    End Function

    ' REalizamos el elimanado logico de la tarea
    Public Function EliminadoLogicoTarea()

        Dim msj As String = ""

        Dim lst As New List(Of parametrosDAL)()
        Try
            ' Mandamos los parámetros
            lst.Add(New parametrosDAL("@tareaID", Tareaid_E))

            ' Pasamos el parámetro de salida que se envía desde SQL
            lst.Add(New parametrosDAL("@mensaje", SqlDbType.VarChar, 100))

            mjdor.Ejecutar_sp("spEliminarTareaLogico", lst)
            msj = lst(1).Valor.ToString()

        Catch ex As Exception
            Throw New Exception("Error al Registrar el método Registrar Area Capa Negocio", ex)
        End Try

        Return msj
    End Function

End Class
