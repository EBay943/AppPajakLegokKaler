<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InputPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputPage))
        Me.inputPanel = New System.Windows.Forms.Panel()
        Me.logoRefresh = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tabelPajak = New System.Windows.Forms.DataGridView()
        Me.homeButton1 = New System.Windows.Forms.PictureBox()
        Me.txtPajakTerhutang = New System.Windows.Forms.TextBox()
        Me.lblPajakTerhutang = New System.Windows.Forms.Label()
        Me.txtLuasBangunan = New System.Windows.Forms.TextBox()
        Me.lblLuasBangunan = New System.Windows.Forms.Label()
        Me.txtLuasBumi = New System.Windows.Forms.TextBox()
        Me.lblLuasBumi = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.txtAlamatWajibPajak = New System.Windows.Forms.TextBox()
        Me.lblAlamatWajibPajak = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtAlamatObjekPajak = New System.Windows.Forms.TextBox()
        Me.txtNamaPajak = New System.Windows.Forms.TextBox()
        Me.txtNoPajak = New System.Windows.Forms.TextBox()
        Me.lblAlamatObjekPajak = New System.Windows.Forms.Label()
        Me.lblNamaPajak = New System.Windows.Forms.Label()
        Me.lblNoPajak = New System.Windows.Forms.Label()
        Me.inputPanel.SuspendLayout()
        CType(Me.logoRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelPajak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.homeButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputPanel
        '
        Me.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPanel.Controls.Add(Me.logoRefresh)
        Me.inputPanel.Controls.Add(Me.txtSearch)
        Me.inputPanel.Controls.Add(Me.btnSearch)
        Me.inputPanel.Controls.Add(Me.btnExit)
        Me.inputPanel.Controls.Add(Me.btnDelete)
        Me.inputPanel.Controls.Add(Me.btnReset)
        Me.inputPanel.Controls.Add(Me.btnUpdate)
        Me.inputPanel.Controls.Add(Me.tabelPajak)
        Me.inputPanel.Controls.Add(Me.homeButton1)
        Me.inputPanel.Controls.Add(Me.txtPajakTerhutang)
        Me.inputPanel.Controls.Add(Me.lblPajakTerhutang)
        Me.inputPanel.Controls.Add(Me.txtLuasBangunan)
        Me.inputPanel.Controls.Add(Me.lblLuasBangunan)
        Me.inputPanel.Controls.Add(Me.txtLuasBumi)
        Me.inputPanel.Controls.Add(Me.lblLuasBumi)
        Me.inputPanel.Controls.Add(Me.txtTahun)
        Me.inputPanel.Controls.Add(Me.lblTahun)
        Me.inputPanel.Controls.Add(Me.txtAlamatWajibPajak)
        Me.inputPanel.Controls.Add(Me.lblAlamatWajibPajak)
        Me.inputPanel.Controls.Add(Me.btnInput)
        Me.inputPanel.Controls.Add(Me.txtAlamatObjekPajak)
        Me.inputPanel.Controls.Add(Me.txtNamaPajak)
        Me.inputPanel.Controls.Add(Me.txtNoPajak)
        Me.inputPanel.Controls.Add(Me.lblAlamatObjekPajak)
        Me.inputPanel.Controls.Add(Me.lblNamaPajak)
        Me.inputPanel.Controls.Add(Me.lblNoPajak)
        Me.inputPanel.Location = New System.Drawing.Point(28, 27)
        Me.inputPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(1122, 690)
        Me.inputPanel.TabIndex = 5
        '
        'logoRefresh
        '
        Me.logoRefresh.Image = Global.AppPajakPBBP2.My.Resources.Resources.refresh
        Me.logoRefresh.Location = New System.Drawing.Point(1052, 261)
        Me.logoRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.logoRefresh.Name = "logoRefresh"
        Me.logoRefresh.Size = New System.Drawing.Size(36, 32)
        Me.logoRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoRefresh.TabIndex = 33
        Me.logoRefresh.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(595, 19)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(289, 30)
        Me.txtSearch.TabIndex = 32
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(900, 16)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 38)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "CARI"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(839, 606)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(156, 57)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "KELUAR"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(659, 606)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(156, 57)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(481, 606)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(156, 57)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(301, 606)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(156, 57)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tabelPajak
        '
        Me.tabelPajak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelPajak.Location = New System.Drawing.Point(35, 299)
        Me.tabelPajak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabelPajak.Name = "tabelPajak"
        Me.tabelPajak.RowHeadersWidth = 51
        Me.tabelPajak.RowTemplate.Height = 24
        Me.tabelPajak.Size = New System.Drawing.Size(1053, 286)
        Me.tabelPajak.TabIndex = 25
        '
        'homeButton1
        '
        Me.homeButton1.Image = Global.AppPajakPBBP2.My.Resources.Resources.home
        Me.homeButton1.Location = New System.Drawing.Point(1028, 2)
        Me.homeButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.homeButton1.Name = "homeButton1"
        Me.homeButton1.Size = New System.Drawing.Size(71, 69)
        Me.homeButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.homeButton1.TabIndex = 15
        Me.homeButton1.TabStop = False
        '
        'txtPajakTerhutang
        '
        Me.txtPajakTerhutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPajakTerhutang.Location = New System.Drawing.Point(795, 222)
        Me.txtPajakTerhutang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPajakTerhutang.Multiline = True
        Me.txtPajakTerhutang.Name = "txtPajakTerhutang"
        Me.txtPajakTerhutang.Size = New System.Drawing.Size(167, 30)
        Me.txtPajakTerhutang.TabIndex = 8
        '
        'lblPajakTerhutang
        '
        Me.lblPajakTerhutang.AutoSize = True
        Me.lblPajakTerhutang.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPajakTerhutang.Location = New System.Drawing.Point(591, 226)
        Me.lblPajakTerhutang.Name = "lblPajakTerhutang"
        Me.lblPajakTerhutang.Size = New System.Drawing.Size(177, 23)
        Me.lblPajakTerhutang.TabIndex = 23
        Me.lblPajakTerhutang.Text = "PAJAK TERHUTANG"
        Me.lblPajakTerhutang.UseWaitCursor = True
        '
        'txtLuasBangunan
        '
        Me.txtLuasBangunan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasBangunan.Location = New System.Drawing.Point(795, 145)
        Me.txtLuasBangunan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLuasBangunan.Multiline = True
        Me.txtLuasBangunan.Name = "txtLuasBangunan"
        Me.txtLuasBangunan.Size = New System.Drawing.Size(113, 30)
        Me.txtLuasBangunan.TabIndex = 7
        '
        'lblLuasBangunan
        '
        Me.lblLuasBangunan.AutoSize = True
        Me.lblLuasBangunan.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuasBangunan.Location = New System.Drawing.Point(591, 151)
        Me.lblLuasBangunan.Name = "lblLuasBangunan"
        Me.lblLuasBangunan.Size = New System.Drawing.Size(165, 23)
        Me.lblLuasBangunan.TabIndex = 21
        Me.lblLuasBangunan.Text = "LUAS BANGUNAN"
        Me.lblLuasBangunan.UseWaitCursor = True
        '
        'txtLuasBumi
        '
        Me.txtLuasBumi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuasBumi.Location = New System.Drawing.Point(795, 80)
        Me.txtLuasBumi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLuasBumi.Multiline = True
        Me.txtLuasBumi.Name = "txtLuasBumi"
        Me.txtLuasBumi.Size = New System.Drawing.Size(113, 30)
        Me.txtLuasBumi.TabIndex = 6
        '
        'lblLuasBumi
        '
        Me.lblLuasBumi.AutoSize = True
        Me.lblLuasBumi.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLuasBumi.Location = New System.Drawing.Point(591, 82)
        Me.lblLuasBumi.Name = "lblLuasBumi"
        Me.lblLuasBumi.Size = New System.Drawing.Size(105, 23)
        Me.lblLuasBumi.TabIndex = 19
        Me.lblLuasBumi.Text = "LUAS BUMI"
        Me.lblLuasBumi.UseWaitCursor = True
        '
        'txtTahun
        '
        Me.txtTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun.Location = New System.Drawing.Point(369, 18)
        Me.txtTahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTahun.Multiline = True
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(108, 30)
        Me.txtTahun.TabIndex = 2
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTahun.Location = New System.Drawing.Point(273, 23)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(74, 23)
        Me.lblTahun.TabIndex = 17
        Me.lblTahun.Text = "TAHUN"
        Me.lblTahun.UseWaitCursor = True
        '
        'txtAlamatWajibPajak
        '
        Me.txtAlamatWajibPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatWajibPajak.Location = New System.Drawing.Point(275, 228)
        Me.txtAlamatWajibPajak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlamatWajibPajak.Multiline = True
        Me.txtAlamatWajibPajak.Name = "txtAlamatWajibPajak"
        Me.txtAlamatWajibPajak.Size = New System.Drawing.Size(289, 30)
        Me.txtAlamatWajibPajak.TabIndex = 5
        '
        'lblAlamatWajibPajak
        '
        Me.lblAlamatWajibPajak.AutoSize = True
        Me.lblAlamatWajibPajak.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamatWajibPajak.Location = New System.Drawing.Point(31, 228)
        Me.lblAlamatWajibPajak.Name = "lblAlamatWajibPajak"
        Me.lblAlamatWajibPajak.Size = New System.Drawing.Size(198, 23)
        Me.lblAlamatWajibPajak.TabIndex = 15
        Me.lblAlamatWajibPajak.Text = "ALAMAT WAJIB PAJAK"
        Me.lblAlamatWajibPajak.UseWaitCursor = True
        '
        'btnInput
        '
        Me.btnInput.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.Location = New System.Drawing.Point(121, 606)
        Me.btnInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(156, 57)
        Me.btnInput.TabIndex = 14
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtAlamatObjekPajak
        '
        Me.txtAlamatObjekPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatObjekPajak.Location = New System.Drawing.Point(275, 150)
        Me.txtAlamatObjekPajak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAlamatObjekPajak.Multiline = True
        Me.txtAlamatObjekPajak.Name = "txtAlamatObjekPajak"
        Me.txtAlamatObjekPajak.Size = New System.Drawing.Size(289, 30)
        Me.txtAlamatObjekPajak.TabIndex = 4
        '
        'txtNamaPajak
        '
        Me.txtNamaPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPajak.Location = New System.Drawing.Point(275, 76)
        Me.txtNamaPajak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNamaPajak.Multiline = True
        Me.txtNamaPajak.Name = "txtNamaPajak"
        Me.txtNamaPajak.Size = New System.Drawing.Size(289, 30)
        Me.txtNamaPajak.TabIndex = 3
        '
        'txtNoPajak
        '
        Me.txtNoPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPajak.Location = New System.Drawing.Point(107, 18)
        Me.txtNoPajak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoPajak.Multiline = True
        Me.txtNoPajak.Name = "txtNoPajak"
        Me.txtNoPajak.Size = New System.Drawing.Size(73, 30)
        Me.txtNoPajak.TabIndex = 1
        '
        'lblAlamatObjekPajak
        '
        Me.lblAlamatObjekPajak.AutoSize = True
        Me.lblAlamatObjekPajak.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamatObjekPajak.Location = New System.Drawing.Point(31, 151)
        Me.lblAlamatObjekPajak.Name = "lblAlamatObjekPajak"
        Me.lblAlamatObjekPajak.Size = New System.Drawing.Size(199, 23)
        Me.lblAlamatObjekPajak.TabIndex = 7
        Me.lblAlamatObjekPajak.Text = "ALAMAT OBJEK PAJAK"
        Me.lblAlamatObjekPajak.UseWaitCursor = True
        '
        'lblNamaPajak
        '
        Me.lblNamaPajak.AutoSize = True
        Me.lblNamaPajak.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPajak.Location = New System.Drawing.Point(31, 79)
        Me.lblNamaPajak.Name = "lblNamaPajak"
        Me.lblNamaPajak.Size = New System.Drawing.Size(182, 23)
        Me.lblNamaPajak.TabIndex = 6
        Me.lblNamaPajak.Text = "NAMA WAJIB PAJAK"
        Me.lblNamaPajak.UseWaitCursor = True
        '
        'lblNoPajak
        '
        Me.lblNoPajak.AutoSize = True
        Me.lblNoPajak.Font = New System.Drawing.Font("Microsoft JhengHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPajak.Location = New System.Drawing.Point(29, 25)
        Me.lblNoPajak.Name = "lblNoPajak"
        Me.lblNoPajak.Size = New System.Drawing.Size(51, 23)
        Me.lblNoPajak.TabIndex = 5
        Me.lblNoPajak.Text = "NOP"
        Me.lblNoPajak.UseWaitCursor = True
        '
        'InputPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 750)
        Me.Controls.Add(Me.inputPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InputPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input"
        Me.inputPanel.ResumeLayout(False)
        Me.inputPanel.PerformLayout()
        CType(Me.logoRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelPajak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.homeButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputPanel As Panel
    Friend WithEvents lblNamaPajak As Label
    Friend WithEvents lblNoPajak As Label
    Friend WithEvents lblAlamatObjekPajak As Label
    Friend WithEvents txtAlamatObjekPajak As TextBox
    Friend WithEvents txtNamaPajak As TextBox
    Friend WithEvents txtNoPajak As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents homeButton1 As PictureBox
    Friend WithEvents lblAlamatWajibPajak As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents lblTahun As Label
    Friend WithEvents txtAlamatWajibPajak As TextBox
    Friend WithEvents lblLuasBangunan As Label
    Friend WithEvents txtLuasBumi As TextBox
    Friend WithEvents lblLuasBumi As Label
    Friend WithEvents txtPajakTerhutang As TextBox
    Friend WithEvents lblPajakTerhutang As Label
    Friend WithEvents txtLuasBangunan As TextBox
    Friend WithEvents tabelPajak As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents logoRefresh As PictureBox
End Class
