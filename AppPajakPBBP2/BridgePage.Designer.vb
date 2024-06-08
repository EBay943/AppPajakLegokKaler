<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BridgePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BridgePage))
        Me.lblHeader1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoInput = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoSetor = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.logoDesa1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.logoInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.logoSetor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoDesa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader1
        '
        Me.lblHeader1.AutoSize = True
        Me.lblHeader1.Font = New System.Drawing.Font("MS Reference Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader1.Location = New System.Drawing.Point(203, 27)
        Me.lblHeader1.Name = "lblHeader1"
        Me.lblHeader1.Size = New System.Drawing.Size(416, 53)
        Me.lblHeader1.TabIndex = 3
        Me.lblHeader1.Text = "Desa Legok Kaler"
        Me.lblHeader1.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.logoInput)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Location = New System.Drawing.Point(244, 228)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 252)
        Me.Panel1.TabIndex = 5
        '
        'logoInput
        '
        Me.logoInput.Image = Global.AppPajakPBBP2.My.Resources.Resources.input
        Me.logoInput.Location = New System.Drawing.Point(56, 32)
        Me.logoInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.logoInput.Name = "logoInput"
        Me.logoInput.Size = New System.Drawing.Size(133, 123)
        Me.logoInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoInput.TabIndex = 7
        Me.logoInput.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft JhengHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(55, 186)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(134, 47)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "INPUT"
        Me.lblLogin.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.logoSetor)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(579, 228)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 252)
        Me.Panel3.TabIndex = 5
        '
        'logoSetor
        '
        Me.logoSetor.Image = Global.AppPajakPBBP2.My.Resources.Resources.setor
        Me.logoSetor.Location = New System.Drawing.Point(59, 32)
        Me.logoSetor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.logoSetor.Name = "logoSetor"
        Me.logoSetor.Size = New System.Drawing.Size(133, 123)
        Me.logoSetor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoSetor.TabIndex = 8
        Me.logoSetor.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SETOR"
        Me.Label1.UseWaitCursor = True
        '
        'btnHome
        '
        Me.btnHome.Image = Global.AppPajakPBBP2.My.Resources.Resources.home
        Me.btnHome.Location = New System.Drawing.Point(961, 27)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(71, 69)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 16
        Me.btnHome.TabStop = False
        '
        'logoDesa1
        '
        Me.logoDesa1.Image = Global.AppPajakPBBP2.My.Resources.Resources.Lambang_Kabupaten_Sumedang
        Me.logoDesa1.Location = New System.Drawing.Point(29, 27)
        Me.logoDesa1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logoDesa1.Name = "logoDesa1"
        Me.logoDesa1.Size = New System.Drawing.Size(161, 144)
        Me.logoDesa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoDesa1.TabIndex = 2
        Me.logoDesa1.TabStop = False
        '
        'BridgePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 580)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblHeader1)
        Me.Controls.Add(Me.logoDesa1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BridgePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BridgePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logoInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.logoSetor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoDesa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader1 As Label
    Friend WithEvents logoDesa1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoInput As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logoSetor As PictureBox
    Friend WithEvents btnHome As PictureBox
End Class
