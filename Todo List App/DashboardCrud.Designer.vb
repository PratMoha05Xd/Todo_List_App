<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCrud
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dashboardTitle = New DevExpress.XtraEditors.LabelControl()
        Me.description_txt = New DevExpress.XtraEditors.TextEdit()
        Me.date_picker = New DevExpress.XtraEditors.DateEdit()
        Me.task_status = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.save_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DashboardCrudBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DashboardCrudBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DashboardCrudBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Desciption = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha_Vencimiento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.description_txt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_picker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_picker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.task_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardCrudBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardCrudBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardCrudBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboardTitle
        '
        Me.dashboardTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.dashboardTitle.Appearance.Options.UseFont = True
        Me.dashboardTitle.Appearance.Options.UseForeColor = True
        Me.dashboardTitle.LineColor = System.Drawing.Color.Black
        Me.dashboardTitle.Location = New System.Drawing.Point(26, 78)
        Me.dashboardTitle.Name = "dashboardTitle"
        Me.dashboardTitle.Size = New System.Drawing.Size(87, 19)
        Me.dashboardTitle.TabIndex = 4
        Me.dashboardTitle.Text = "Descripcion:"
        '
        'description_txt
        '
        Me.description_txt.Location = New System.Drawing.Point(26, 103)
        Me.description_txt.Name = "description_txt"
        Me.description_txt.Properties.AutoHeight = False
        Me.description_txt.Size = New System.Drawing.Size(365, 34)
        Me.description_txt.TabIndex = 5
        '
        'date_picker
        '
        Me.date_picker.EditValue = Nothing
        Me.date_picker.Location = New System.Drawing.Point(397, 103)
        Me.date_picker.Name = "date_picker"
        Me.date_picker.Properties.AutoHeight = False
        Me.date_picker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_picker.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.date_picker.Size = New System.Drawing.Size(208, 34)
        Me.date_picker.TabIndex = 6
        '
        'task_status
        '
        Me.task_status.Location = New System.Drawing.Point(611, 103)
        Me.task_status.Name = "task_status"
        Me.task_status.Properties.AutoHeight = False
        Me.task_status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.task_status.Size = New System.Drawing.Size(201, 34)
        Me.task_status.TabIndex = 7
        '
        'save_btn
        '
        Me.save_btn.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.save_btn.Appearance.BorderColor = System.Drawing.Color.White
        Me.save_btn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.save_btn.Appearance.Options.UseBackColor = True
        Me.save_btn.Appearance.Options.UseBorderColor = True
        Me.save_btn.Appearance.Options.UseFont = True
        Me.save_btn.Appearance.Options.UseForeColor = True
        Me.save_btn.AppearanceDisabled.Options.UseBorderColor = True
        Me.save_btn.AppearanceHovered.Options.UseBorderColor = True
        Me.save_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.save_btn.Location = New System.Drawing.Point(26, 146)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(71, 22)
        Me.save_btn.TabIndex = 8
        Me.save_btn.Text = "Guardar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.LineColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(397, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(160, 19)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Fecha de Vencimiento:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.LineColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(611, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 19)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Estado:"
        '
        'DashboardCrudBindingSource
        '
        Me.DashboardCrudBindingSource.DataSource = GetType(Todo_List_App.DashboardCrud)
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(Todo_List_App.My.MyApplication)
        '
        'DashboardCrudBindingSource1
        '
        Me.DashboardCrudBindingSource1.DataSource = GetType(Todo_List_App.DashboardCrud)
        '
        'DashboardCrudBindingSource2
        '
        Me.DashboardCrudBindingSource2.DataSource = GetType(Todo_List_App.DashboardCrud)
        '
        'GridControl1
        '
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(26, 210)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(786, 200)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Desciption, Me.Fecha_Vencimiento, Me.status})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Desciption
        '
        Me.Desciption.FieldName = "Descripcion"
        Me.Desciption.Name = "Desciption"
        Me.Desciption.Visible = True
        Me.Desciption.VisibleIndex = 0
        Me.Desciption.Width = 269
        '
        'Fecha_Vencimiento
        '
        Me.Fecha_Vencimiento.FieldName = "Fecha"
        Me.Fecha_Vencimiento.Name = "Fecha_Vencimiento"
        Me.Fecha_Vencimiento.Visible = True
        Me.Fecha_Vencimiento.VisibleIndex = 1
        Me.Fecha_Vencimiento.Width = 186
        '
        'status
        '
        Me.status.FieldName = "Estado"
        Me.status.Name = "status"
        Me.status.Visible = True
        Me.status.VisibleIndex = 2
        Me.status.Width = 279
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 48)
        Me.Panel1.TabIndex = 12
        '
        'DashboardCrud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.task_status)
        Me.Controls.Add(Me.date_picker)
        Me.Controls.Add(Me.description_txt)
        Me.Controls.Add(Me.dashboardTitle)
        Me.IconOptions.Image = Global.Todo_List_App.My.Resources.Resources.to_do_list
        Me.Name = "DashboardCrud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                        "
        CType(Me.description_txt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_picker.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_picker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.task_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardCrudBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardCrudBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardCrudBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dashboardTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents description_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents date_picker As DevExpress.XtraEditors.DateEdit
    Friend WithEvents task_status As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents save_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DashboardCrudBindingSource As BindingSource
    Friend WithEvents MyApplicationBindingSource As BindingSource
    Friend WithEvents DashboardCrudBindingSource1 As BindingSource
    Friend WithEvents DashboardCrudBindingSource2 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Desciption As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha_Vencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
End Class
