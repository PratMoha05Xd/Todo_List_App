Imports System.ComponentModel
Imports System.Text


Partial Public Class LoginCrud
    Public Sub New()
        InitializeComponent()
        If (Not MvvmContext1.IsDesignMode) Then
            InitializeBindings()
        End If
    End Sub

    Sub InitializeBindings()
        Dim fluent = MvvmContext1.OfType(Of LoginCrud)()
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles username.Click

    End Sub

    Private Sub LoginCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ImageListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username As String = Me.username_txt.Text
        Dim password As String = Me.password_txt.Text

        If username = "admin" AndAlso password = "admin" Then
            Dim dashboard As New DashboardCrud
            dashboard.Show()
            Me.Hide()
        Else

            DevExpress.XtraEditors.XtraMessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click

    End Sub

    Private Sub username_txt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub password_txt_EditValueChanged(sender As Object, e As EventArgs) Handles password_txt.EditValueChanged

    End Sub

    Private Sub username_txt_EditValueChanged(sender As Object, e As EventArgs) Handles username_txt.EditValueChanged

    End Sub
End Class
