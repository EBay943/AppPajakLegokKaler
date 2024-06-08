<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginPage))
        Me.logoDesa1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        CType(Me.logoDesa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'logoDesa1
        '
        Me.logoDesa1.Image = Global.AppPajakPBBP2.My.Resources.Resources.Lambang_Kabupaten_Sumedang
        Me.logoDesa1.Location = New System.Drawing.Point(29, 27)
        Me.logoDesa1.Name = "logoDesa1"
        Me.logoDesa1.Size = New System.Drawing.Size(161, 144)
        Me.logoDesa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoDesa1.TabIndex = 0
        Me.logoDesa1.TabStop = False
        '
        'lblHeader1
        '
        Me.lblHeader1.AutoSize = True
        Me.lblHeader1.Font = New System.Drawing.Font("MS Reference Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.Location = New System.Drawing.Point(202, 27)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(416, 53)
        Me.lblHeader1.TabIndex = 1
        Me.lblHeader1.Text = "Desa Legok Kaler"
        Me.lblHeader1.UseWaitCursor = True
        '
        'loginPanel
        '
        Me.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginPanel.Controls.Add(Me.btnLogin)
        Me.loginPanel.Controls.Add(Me.txtPassword)
        Me.loginPanel.Controls.Add(Me.txtEmail)
        Me.loginPanel.Controls.Add(Me.lblPassword)
        Me.loginPanel.Controls.Add(Me.lblEmail)
        Me.loginPanel.Controls.Add(Me.lblLogin)
        Me.loginPanel.Location = New System.Drawing.Point(372, 198)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(375, 405)
        Me.loginPanel.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(105, 314)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(156, 57)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(38, 250)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(300, 30)
        Me.txtPassword.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(38, 155)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 30)
        Me.txtEmail.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(34, 207)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(98, 23)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Kata sandi"
        Me.lblPassword.UseWaitCursor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(34, 114)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(123, 23)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Alamat email"
        Me.lblEmail.UseWaitCursor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft JhengHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(119, 27)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(138, 47)
        Me.lblLogin.TabIndex = 3
        Me.lblLogin.Text = "LOGIN"
        Me.lblLogin.UseWaitCursor = True
        '
        'loginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 739)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.lblHeader1)
        Me.Controls.Add(Me.logoDesa1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.logoDesa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logoDesa1 As PictureBox
    Friend WithEvents lblHeader1 As Label
    Friend WithEvents loginPanel As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
