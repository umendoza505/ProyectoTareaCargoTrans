Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaLogicaNegocioEstadoTarea
Public Class TareaMantenimiento
    ' Instanciamos las clases de las capa Logica Negocio
    Dim te As New tareaEstadoBL()
    Private Sub TareaMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarComboEstado()
        ListarComboUsuAsignado()
    End Sub

    Private Sub ListarComboEstado()
        If lblEstadoActual.Text = "Nuevo" Then
            'Eliminamos el Primer Registro de seleccion
            Dim dt As DataTable = te.ListarComboEstado()
            dt.Rows.RemoveAt(0)

            'Llenamos el ComboBox de Nombres de Estado
            cbEstado.DataSource = dt

            cbEstado.DisplayMember = "NombreEstado"
            cbEstado.ValueMember = "EstadoId"
            cbEstado.SelectedIndex = -1

        Else
            'Eliminamos el Primer Registro de seleccion
            Dim dt As DataTable = te.ListarComboEstado()
            dt.Rows.RemoveAt(0)

            'Llenamos el ComboBox de Nombres de Estado
            cbEstado.DataSource = dt

            cbEstado.DisplayMember = "NombreEstado"
            cbEstado.ValueMember = "EstadoId"

            'Validamos el campo Estado eliminado, para dejar selecccionado el campo correcto al combobox
            Dim validarguion As String = lblEstadoActual.Text
            If validarguion.Contains("-") Then
                validarguion = lblEstadoActual.Text.Substring(0, lblEstadoActual.Text.IndexOf("-"))
            End If

            'Elijimos el estado actual de la Tarea Segun el datasouce ya cargado del ComboBox.
            Dim estadoActual As String = validarguion.Trim().ToLower() 'Se obtiene el texto del Label y conviértelo a minúsculas para una comparación insensible a mayúsculas y minúsculas.
            Dim indiceCoincidente As Integer = -1 'Se declara Variable para llevar el índice del elemento coincidente.

            'Recorre´mos con for each los elementos del combobox
            For Each item As Object In cbEstado.Items
                'Declaramos variables
                Dim elemento As DataRowView = DirectCast(item, DataRowView)
                Dim campo As String = elemento("NombreEstado").ToString().ToLower()

                ' Compara el valor del "Campo1" del elemento con el texto del Label.
                If String.Equals(campo, estadoActual, StringComparison.OrdinalIgnoreCase) Then
                    ' Si hay una coincidencia, guarda el índice del elemento coincidente.
                    indiceCoincidente = cbEstado.Items.IndexOf(item)
                    Exit For ' Sal del bucle una vez que se haya encontrado la coincidencia.
                End If
            Next

            ' Si se encontró una coincidencia, selecciona ese elemento en el ComboBox.
            If indiceCoincidente <> -1 Then
                cbEstado.SelectedIndex = indiceCoincidente
            End If
        End If
    End Sub

    Private Sub ListarComboUsuAsignado()
        If lblUsuarioAsignado.Text = "Nuevo" Then
            'Eliminamos el Primer Registro de seleccion
            Dim dt As DataTable = te.ListarComboUsuarioAsignado()
            dt.Rows.RemoveAt(0)

            'Llenamos el ComboBox de Nombres de Estado
            cbAsigando.DataSource = dt

            cbAsigando.DisplayMember = "NombreUsuario"
            cbAsigando.ValueMember = "UsarioID"
            cbAsigando.SelectedIndex = -1
        Else
            'Eliminamos el Primer Registro de seleccion
            Dim dt As DataTable = te.ListarComboUsuarioAsignado()
            dt.Rows.RemoveAt(0)

            'Llenamos el ComboBox de Nombres de Estado
            cbAsigando.DataSource = dt

            cbAsigando.DisplayMember = "NombreUsuario"
            cbAsigando.ValueMember = "UsarioID"

            'Elijimos el estado actual de la Tarea Segun el datasouce ya cargado del ComboBox.
            Dim estadoActual As String = lblUsuarioAsignado.Text.ToLower() 'Se obtiene el texto del Label y conviértelo a minúsculas para una comparación insensible a mayúsculas y minúsculas.
            Dim indiceCoincidente As Integer = -1 'Se declara Variable para llevar el índice del elemento coincidente.

            'Recorre´mos con for each los elementos del combobox
            For Each item As Object In cbAsigando.Items
                'Declaramos variables
                Dim elemento As DataRowView = DirectCast(item, DataRowView)
                Dim campo As String = elemento("NombreUsuario").ToString().ToLower()

                ' Compara el valor del "Campo1" del elemento con el texto del Label.
                If String.Equals(campo, estadoActual, StringComparison.OrdinalIgnoreCase) Then
                    ' Si hay una coincidencia, guarda el índice del elemento coincidente.
                    indiceCoincidente = cbAsigando.Items.IndexOf(item)
                    Exit For ' Sal del bucle una vez que se haya encontrado la coincidencia.
                End If
            Next

            ' Si se encontró una coincidencia, selecciona ese elemento en el ComboBox.
            If indiceCoincidente <> -1 Then
                cbAsigando.SelectedIndex = indiceCoincidente
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim msj As String = ""
        Try
            'Capturamos los valores en los parametros de la capa de negocio, quitamos espacios
            te.Tareaid_E = If(txtIDTarea.Text.Trim() = "", "", (txtIDTarea.Text.Trim()))
            te.TituloTarea_E = If(txtTituloTarea.Text.Trim() = "", "", txtTituloTarea.Text.Trim())
            te.DescripcionTarea_E = If(txtDescrpTarea.Text.Trim() = "", "", txtDescrpTarea.Text.Trim())
            te.UsuarioAsignado_E = If(IsNothing(cbAsigando.SelectedValue) OrElse cbAsigando.SelectedValue Is DBNull.Value, 0, Convert.ToInt32(cbAsigando.SelectedValue))
            te.TareaActiva_E = 1

            If lblEstadoActual.Text = "Nuevo" Then
                te.EstadoTarea_E = 1
            Else
                te.EstadoTarea_E = If(IsNothing(cbEstado.SelectedValue) OrElse cbEstado.SelectedValue Is DBNull.Value, 0, Convert.ToInt32(cbEstado.SelectedValue))
            End If

            'VALIDACION DE CAMPOS VACIOS Y OBLIGATORIOS'

            If Not String.IsNullOrWhiteSpace(te.TituloTarea_E) Then
                If Not String.IsNullOrWhiteSpace(te.DescripcionTarea_E) Then
                    If te.UsuarioAsignado_E <> 0 Then

                        msj = te.RegistrarTareasEstado()
                        MessageBox.Show(msj)
                        Me.DialogResult = DialogResult.OK

                    Else
                        'Si el campo esta en 0
                        MessageBox.Show("Seleccione un usuario a asignar la tarea", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    ' Si el campo de Descripcion esta vacio.
                    MessageBox.Show("Descripcion es campo obligatorio, No dejar en Vacio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Si el campo de titulo esta vacio
                MessageBox.Show("Titulo es campo obligatorio, No dejar en Vacio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            'FIN VALIDACION'

        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class