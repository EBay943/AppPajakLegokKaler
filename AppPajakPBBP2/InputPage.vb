Imports System.Data.OleDb

Public Class InputPage

    Public Sub Reset()

        txtNoPajak.Text = ""
        txtTahun.Text = ""
        txtNamaPajak.Text = ""
        txtAlamatObjekPajak.Text = ""
        txtAlamatWajibPajak.Text = ""
        txtLuasBumi.Text = ""
        txtLuasBangunan.Text = ""
        txtPajakTerhutang.Text = ""

    End Sub

    Public Sub RefreshTable()
        Call Connection()
        Da = New OleDbDataAdapter("Select * from Data_Pajak", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Data_Pajak")
        tabelPajak.DataSource = (Ds.Tables("Data_Pajak"))

        tabelPajak.Columns(0).Width = 60
        tabelPajak.Columns(1).Width = 60
        tabelPajak.Columns(2).Width = 160
        tabelPajak.Columns(3).Width = 160
        tabelPajak.Columns(4).Width = 160
        tabelPajak.Columns(5).Width = 60
        tabelPajak.Columns(6).Width = 60
        tabelPajak.Columns(7).Width = 100

    End Sub

    Private Sub InputPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call RefreshTable()
        txtSearch.Text = "Cari"
        txtSearch.ForeColor = Color.Silver

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        If txtNoPajak.Text = "" Or txtNamaPajak.Text = "" Or txtAlamatObjekPajak.Text = "" Or txtTahun.Text = "" Or txtAlamatWajibPajak.Text = "" Or txtLuasBumi.Text = "" Or txtLuasBangunan.Text = "" Or txtPajakTerhutang.Text = "" Then

            MessageBox.Show("Pastikan semua bagian sudah terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Call Connection()
            Dim simpanData As String = "Insert into Data_Pajak values('" & txtNoPajak.Text & "','" & txtTahun.Text & "',
                                        '" & txtNamaPajak.Text & "','" & txtAlamatObjekPajak.Text & "','" & txtAlamatWajibPajak.Text & "',
                                        '" & txtLuasBumi.Text & "','" & txtLuasBangunan.Text & "','" & txtPajakTerhutang.Text & "')"
            Cmd = New OleDbCommand(simpanData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diinput!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Reset()
            Call RefreshTable()

        End If
    End Sub

    Private Sub homeButton1_Click(sender As Object, e As EventArgs) Handles homeButton1.Click

        loginPage.Show()
        Me.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtNoPajak.Text = "" Or txtNamaPajak.Text = "" Or txtAlamatObjekPajak.Text = "" Or txtTahun.Text = "" Or txtAlamatWajibPajak.Text = "" Or txtLuasBumi.Text = "" Or txtLuasBangunan.Text = "" Or txtPajakTerhutang.Text = "" Then

            MessageBox.Show("Pastikan semua bagian sudah terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Call Connection()
            Dim updateData As String = "Update Data_Pajak set Tahun = '" & txtTahun.Text & "'
                                    , Nama_Wajib_Pajak = '" & txtNamaPajak.Text & "'
                                    , Alamat_Objek_Pajak = '" & txtAlamatObjekPajak.Text & "'
                                    , Alamat_Wajib_Pajak = '" & txtAlamatWajibPajak.Text & "'
                                    , Luas_Bumi = '" & txtLuasBumi.Text & "'
                                    , Luas_Bangunan = '" & txtLuasBangunan.Text & "'
                                    , Pajak_Terhutang = '" & txtPajakTerhutang.Text & "' where NOP = '" & txtNoPajak.Text & "'"
            Cmd = New OleDbCommand(updateData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diupdate!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call RefreshTable()
            Call Reset()

        End If

    End Sub

    Private Sub tabelPajak_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelPajak.CellClick

        Try

            txtNoPajak.Text = tabelPajak.SelectedRows(0).Cells(0).Value.ToString()
            txtTahun.Text = tabelPajak.SelectedRows(0).Cells(1).Value.ToString()
            txtNamaPajak.Text = tabelPajak.SelectedRows(0).Cells(2).Value.ToString()
            txtAlamatWajibPajak.Text = tabelPajak.SelectedRows(0).Cells(3).Value.ToString()
            txtAlamatObjekPajak.Text = tabelPajak.SelectedRows(0).Cells(4).Value.ToString()
            txtLuasBumi.Text = tabelPajak.SelectedRows(0).Cells(5).Value.ToString()
            txtLuasBangunan.Text = tabelPajak.SelectedRows(0).Cells(6).Value.ToString()
            txtPajakTerhutang.Text = tabelPajak.SelectedRows(0).Cells(7).Value.ToString()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Call Reset()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtNoPajak.Text = "" Or txtNamaPajak.Text = "" Or txtAlamatObjekPajak.Text = "" Or txtTahun.Text = "" Or txtAlamatWajibPajak.Text = "" Or txtLuasBumi.Text = "" Or txtLuasBangunan.Text = "" Or txtPajakTerhutang.Text = "" Then

            MessageBox.Show("Pastikan data yang ingin dihapus sudah terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim cfmDelete As DialogResult
            cfmDelete = MessageBox.Show("Apakah Anda yakin ingin hapus data?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If cfmDelete = DialogResult.Yes Then

                Call Connection()
                Dim deleteData As String = "Delete from  Data_Pajak where NOP = '" & txtNoPajak.Text & "'"
                Cmd = New OleDbCommand(deleteData, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil didelete!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call RefreshTable()
                Call Reset()

            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim cfmExit As DialogResult

        cfmExit = MessageBox.Show("Apakah Anda yakin akan menutup aplikasi?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If cfmExit = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Call Connection()
        Cmd = New OleDbCommand("Select * from Data_Pajak where Nama_Wajib_Pajak Like '%" & txtSearch.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()

        If Rd.HasRows Then

            Call Connection()
            Da = New OleDbDataAdapter("Select * from Data_Pajak where Nama_Wajib_Pajak Like '%" & txtSearch.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "Data_Pajak")
            tabelPajak.DataSource = (Ds.Tables("Data_Pajak"))

        End If

    End Sub

    Private Sub logoRefresh_Click(sender As Object, e As EventArgs) Handles logoRefresh.Click

        Call RefreshTable()

    End Sub
End Class