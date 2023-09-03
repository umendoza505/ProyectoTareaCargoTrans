Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaLogicaNegocioEstadoTarea

Public Class PrincipalEstadoTarea
    ' Instanciamos las clases de las capa Logica Negocio
    Dim te As New tareaEstadoBL()

    Private Sub PrincipalEstadoTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTarea()
        ListarComboEstado()
        ListarComboUsuarioAsignado()
        ListarComboActivo()
    End Sub

    Private Sub ListarTarea()
        'Llenamos el datagrid
        Dim dt As DataTable = te.ListarTarea()
        dtgTarea.DataSource = dt
    End Sub

    Private Sub ListarComboEstado()
        ' Llenamos el ComboBox de Nombres de Clientes
        cbEstado.DataSource = te.ListarComboEstado()
        cbEstado.DisplayMember = "NombreEstado"
        cbEstado.ValueMember = "EstadoId"

    End Sub

    Private Sub ListarComboUsuarioAsignado()
        ' Llenamos el ComboBox de Nombres de Clientes
        cbAsigando.DataSource = te.ListarComboUsuarioAsignado()
        cbAsigando.DisplayMember = "NombreUsuario"
        cbAsigando.ValueMember = "UsarioID"
    End Sub

    Private Sub ListarComboActivo()
        ' Llenamos el ComboBox de Nombres de Clientes
        cbActivos.DataSource = te.ListarComboActivo()
        cbActivos.DisplayMember = "NombreActivo"
        cbActivos.ValueMember = "Activo"
    End Sub

    Private Sub BusquedaTareaMultiple()
        'Se envia los datos de la interfaz de usuario a los parametros a la capa Logica Negocio
        te.TareaActiva_E = CInt(cbActivos.SelectedValue)
        te.Tareaid_E = txtIDTarea.Text
        te.TituloTarea_E = txtBusquedaTarea.Text
        te.EstadoTarea_E = CInt(cbEstado.SelectedValue)
        te.UsuarioAsignado_E = CInt(cbAsigando.SelectedValue)

        'Se carga el dataGrid y se llama el metodo de la clase modelo de negocio
        Dim dt As DataTable = te.BuscarTarea()
        dtgTarea.DataSource = dt

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BusquedaTareaMultiple()
    End Sub

    'Se utiliza keypres para realizar busqueda al precionar enter en el espacio de textbox para escribir
    Private Sub txtIDTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDTarea.KeyDown
        If e.KeyCode = Keys.Return Then 'Se valida le tecla presionada es el enter
            BusquedaTareaMultiple()
        End If

    End Sub

    'Se utiliza keypres para realizar busqueda al precionar enter en el espacio de textbox para escribir
    Private Sub txtBusquedaTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusquedaTarea.KeyDown
        If e.KeyCode = Keys.Return Then 'Se valida le tecla presionada es el enter
            BusquedaTareaMultiple()
        End If
    End Sub

    Private Sub btnNuevaTarea_Click(sender As Object, e As EventArgs) Handles btnNuevaTarea.Click
        ' Llamamos al formulario Mantenimiento Tarea como Nuevo
        Dim res As DialogResult = DialogResult.OK
        Dim frm As New TareaMantenimiento()

        frm.Text = "Ingreso Tarea"
        frm.lblFechaCreado.Text = "Sin Fecha"
        frm.cbEstado.Enabled = False

        res = frm.ShowDialog()

        'Se vuelve a actualizar el DataGridView
        If res = DialogResult.OK Then
            ListarTarea()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'Pasamos el ID de la tarea para recuperar los datos.
        te.Tareaid_E = dtgTarea.CurrentRow.Cells("tareaID").Value.ToString()
        ' Formulario Nuevo, Validamos si hay una sellecion en el datagrid
        If te.Tareaid_E = "" Then
            MessageBox.Show("Seleccione un Tarea")
        Else ' Formulario para editar
            LlamarFormularioEditar()
        End If
    End Sub

    Private Sub LlamarFormularioEditar()

        te.TareaActiva_E = CInt(cbActivos.SelectedValue)
        Dim res As New DialogResult()
        ' ENVIAMOS DATOS A LA ENTIDAD TAREA
        'te.Tareaid_E = dtgTarea.CurrentRow.Cells("tareaID").Value.ToString()

        ' Recuperamos los datos desde la BD por medio del ID.
        Dim dt As DataTable = te.RecuperarDatosTarea()
        Dim frm As New TareaMantenimiento()
        frm.Text = "Actualizar Tarea"
        frm.lblTitulo.Text = dt.Rows(0)("TituloE").ToString() 'Se envia datos titulo al lblTitulo

        frm.lblFechaCreado.Text = dt.Rows(0)("Fecha").ToString() 'Se envia datos titulo al lblFechaCreado
        frm.txtIDTarea.Text = dt.Rows(0)("TareaID").ToString() 'Se envia datos titulo al txtIDTarea
        frm.txtTituloTarea.Text = dt.Rows(0)("TituloTarea").ToString() 'Se envia datos titulo al txtTituloTarea
        frm.txtDescrpTarea.Text = dt.Rows(0)("DescripcionTarea").ToString() 'Se envia datos titulo al txtDescrpTarea
        frm.lblUsuarioAsignado.Text = dt.Rows(0)("NombreUsuario").ToString()

        If te.TareaActiva_E = 1 Then

            frm.lblEstadoActual.Text = dt.Rows(0)("NombreEstado").ToString() 'Se envia datos titulo al lblEstado
            'Se valida el Icono a presentar segun estado
            If frm.lblEstadoActual.Text = "Creado" Then
                frm.icCompleto.Visible = False
                frm.icCreado.Visible = True
                frm.icEliminado.Visible = False
                frm.icNuevo.Visible = False
                frm.icProcesado.Visible = False
                frm.icSuspendido.Visible = False

            ElseIf frm.lblEstadoActual.Text = "Proceso" Then
                frm.icCompleto.Visible = False
                frm.icCreado.Visible = False
                frm.icEliminado.Visible = False
                frm.icNuevo.Visible = False
                frm.icProcesado.Visible = True
                frm.icSuspendido.Visible = False

            ElseIf frm.lblEstadoActual.Text = "Completado" Then
                frm.icCompleto.Visible = True
                frm.icCreado.Visible = False
                frm.icEliminado.Visible = False
                frm.icNuevo.Visible = False
                frm.icProcesado.Visible = False
                frm.icSuspendido.Visible = False

                frm.btnGuardar.Enabled = False
                frm.btnGuardar.ToolTipText = "Tarea en estado Completado, No se puede realizar modificaciones"

            ElseIf frm.lblEstadoActual.Text = "Suspendido" Then
                frm.icCompleto.Visible = False
                frm.icCreado.Visible = False
                frm.icEliminado.Visible = False
                frm.icNuevo.Visible = False
                frm.icProcesado.Visible = False
                frm.icSuspendido.Visible = True
            Else
                frm.icCompleto.Visible = False
                frm.icCreado.Visible = False
                frm.icEliminado.Visible = True
                frm.icNuevo.Visible = False
                frm.icProcesado.Visible = False
                frm.icSuspendido.Visible = False
            End If

        Else
            frm.lblEstadoActual.Text = dt.Rows(0)("NombreEstado").ToString() + " - Eliminado" 'Se envia datos titulo al lblEstado
            'Se valida el Icono a presentar segun estado

            frm.icCompleto.Visible = False
            frm.icCreado.Visible = False
            frm.icEliminado.Visible = True
            frm.icNuevo.Visible = False
            frm.icProcesado.Visible = False
            frm.icSuspendido.Visible = False

            frm.btnGuardar.Enabled = False
            frm.btnGuardar.ToolTipText = "Tarea se Elimino, No se puede realizar modificaciones"
        End If

        ' SE ACTUALIZA EL DATAGRID
        res = frm.ShowDialog()

        If res = DialogResult.OK Then
            ListarTarea()
        End If
    End Sub

    Private Sub dtgTarea_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgTarea.CellDoubleClick
        'Pasamos el ID de la tarea para recuperar los datos.
        te.Tareaid_E = dtgTarea.CurrentRow.Cells("tareaID").Value.ToString()
        ' Formulario Nuevo, Validamos si hay una sellecion en el datagrid
        If te.Tareaid_E = "" Then
            MessageBox.Show("Seleccione un Tarea")
        Else ' Formulario para editar
            LlamarFormularioEditar()
        End If
    End Sub

    Private Sub cbActivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbActivos.SelectedIndexChanged

        If cbActivos.ValueMember <> "" Then
            BusquedaTareaMultiple()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'SE VALIDA SI ESTA SELECCIONADO UN CAMPO DEL DATAGRID
        If dtgTarea.SelectedRows.Count <> 0 Then
            te.Tareaid_E = dtgTarea.CurrentRow.Cells("tareaID").Value.ToString() 'Se captura el ID de la tarea seleccionada

            Try
                Dim msj As String = ""
                Dim res As DialogResult = New DialogResult()
                res = MessageBox.Show("¿Desea Eliminar el Registro de la Tarea " & te.Tareaid_E, "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                'Se captura la respuesta del dialogo 
                If res = DialogResult.Yes Then

                    ' SE LLAMA EL METODO PARA DUPLICAR UNA LINEA DEL DTG
                    msj = te.EliminadoLogicoTarea()
                    MessageBox.Show(msj, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information) ' MENSAJE DE ÉXITO O ERROR ENVIADO DESDE BD

                    ListarTarea()
                Else
                    Return
                End If
            Catch ex As Exception
                Throw ex
            End Try
        Else
            MessageBox.Show("Selecciona una fila para Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
End Class
