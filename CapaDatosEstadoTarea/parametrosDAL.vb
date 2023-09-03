Imports System.Data.SqlClient

Public Class parametrosDAL

    'Parametros esperados para los campos.
    Public Property Nombre As String
    Public Property Valor As Object
    Public Property TipoDato As SqlDbType
    Public Property Tamaño As Int32
    Public Property Direccion As ParameterDirection

    ' Constructor para entrada
    Public Sub New(objNombre As String, objValor As Object)
        Nombre = objNombre
        Valor = objValor
        Direccion = ParameterDirection.Input
    End Sub

    ' Constructor para salida
    Public Sub New(objNombre As String, objTipoDato As SqlDbType, objTamaño As Int32)
        Nombre = objNombre
        TipoDato = objTipoDato
        Tamaño = objTamaño
        Direccion = ParameterDirection.Output
    End Sub

End Class
