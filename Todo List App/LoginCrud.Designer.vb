Partial Public Class LoginCrud
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginCrud))
        Me.username = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.MotivationMessage = New DevExpress.XtraEditors.LabelControl()
        Me.password = New DevExpress.XtraEditors.LabelControl()
        Me.login_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.MvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.password_txt = New DevExpress.XtraEditors.TextEdit()
        Me.username_txt = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_txt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username_txt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Appearance.Options.UseFont = True
        Me.username.Location = New System.Drawing.Point(165, 295)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(80, 23)
        Me.username.TabIndex = 0
        Me.username.Text = "Usuario:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 48)
        Me.Panel1.TabIndex = 1
        '
        'MotivationMessage
        '
        Me.MotivationMessage.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivationMessage.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.MotivationMessage.Appearance.Options.UseFont = True
        Me.MotivationMessage.Appearance.Options.UseForeColor = True
        Me.MotivationMessage.LineColor = System.Drawing.Color.Black
        Me.MotivationMessage.Location = New System.Drawing.Point(299, 241)
        Me.MotivationMessage.Name = "MotivationMessage"
        Me.MotivationMessage.Size = New System.Drawing.Size(253, 19)
        Me.MotivationMessage.TabIndex = 3
        Me.MotivationMessage.Text = "Organiza tu vida, una tarea a la vez"
        '
        'password
        '
        Me.password.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Appearance.Options.UseFont = True
        Me.password.Location = New System.Drawing.Point(130, 353)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(115, 23)
        Me.password.TabIndex = 4
        Me.password.Text = "Contraseña:"
        '
        'login_btn
        '
        Me.login_btn.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.login_btn.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Appearance.Options.UseBackColor = True
        Me.login_btn.Appearance.Options.UseFont = True
        Me.login_btn.Location = New System.Drawing.Point(270, 406)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(322, 33)
        Me.login_btn.TabIndex = 7
        Me.login_btn.Text = "Iniciar Sesión"
        '
        'MvvmContext1
        '
        Me.MvvmContext1.ContainerControl = Me
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(385, 135)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(92, 85)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(270, 350)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Properties.AutoHeight = False
        Me.password_txt.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Properties.UseSystemPasswordChar = True
        Me.password_txt.Size = New System.Drawing.Size(322, 35)
        Me.password_txt.TabIndex = 8
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(270, 293)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Properties.AutoHeight = False
        Me.username_txt.Size = New System.Drawing.Size(322, 35)
        Me.username_txt.TabIndex = 9
        '
        'LoginCrud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 575)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.MotivationMessage)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.username)
        Me.IconOptions.Image = CType(resources.GetObject("LoginCrud.IconOptions.Image"), System.Drawing.Image)
        Me.Name = "LoginCrud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_txt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username_txt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents Logo As PictureBox
    Friend WithEvents password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MotivationMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents login_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents password_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents username_txt As DevExpress.XtraEditors.TextEdit

#End Region

End Class
