Public Class DashboardCrud
    Private tareas As New DataTable()

    Private Sub DashboardCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tareas.Columns.Count = 0 Then
            tareas.Columns.Add("Description", GetType(String))
            tareas.Columns.Add("Fecha_Vencimiento", GetType(String))
            tareas.Columns.Add("status", GetType(String))
        End If

        GridControl1.DataSource = tareas

        task_status.Properties.Items.AddRange(New String() {"Pendiente", "En Proceso", "Completado"})

        GridControl1.MainView = GridView1

        ConfigurarColumnasGridView()
    End Sub

    Private Sub ConfigurarColumnasGridView()
        GridView1.Columns.Clear()

        Dim colDescripcion As New DevExpress.XtraGrid.Columns.GridColumn() With {
            .FieldName = "Description",
            .Caption = "Descripción",
            .Visible = True,
            .VisibleIndex = 0
        }
        GridView1.Columns.Add(colDescripcion)

        Dim colFechaVencimiento As New DevExpress.XtraGrid.Columns.GridColumn() With {
            .FieldName = "Fecha_Vencimiento",
            .Caption = "Fecha Vencimiento",
            .Visible = True,
            .VisibleIndex = 1
        }
        GridView1.Columns.Add(colFechaVencimiento)

        Dim colStatus As New DevExpress.XtraGrid.Columns.GridColumn() With {
            .FieldName = "status",
            .Caption = "Estado",
            .Visible = True,
            .VisibleIndex = 2
        }
        GridView1.Columns.Add(colStatus)

        AddHandler GridView1.RowCellStyle, AddressOf GridView1_RowCellStyle
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)

        Dim status As String = gridView.GetRowCellValue(e.RowHandle, "status").ToString()

        Select Case status
            Case "Pendiente"
                e.Appearance.BackColor = ColorTranslator.FromHtml("#e4605e") ' Rojo Flujo
            Case "En Proceso"
                e.Appearance.BackColor = ColorTranslator.FromHtml("#FEFFA7") ' Amarillo Flujo
            Case "Completado"
                e.Appearance.BackColor = ColorTranslator.FromHtml("#C9E9D2") ' Verde Flujo
        End Select
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        If String.IsNullOrEmpty(description_txt.Text) OrElse date_picker.EditValue Is Nothing OrElse String.IsNullOrEmpty(task_status.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim nuevaFila As DataRow = tareas.NewRow()
        nuevaFila("Description") = description_txt.Text
        nuevaFila("Fecha_Vencimiento") = date_picker.DateTime.ToString("dd/MM/yyyy")
        nuevaFila("status") = task_status.Text

        tareas.Rows.Add(nuevaFila)

        GridControl1.RefreshDataSource()

        description_txt.Text = ""
        date_picker.EditValue = Nothing
        task_status.SelectedIndex = -1
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
    End Sub
End Class
