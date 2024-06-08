Imports System.Data.OleDb

Public Class SetorPage

    Public Sub Reset()

        txtNOP.Text = ""
        txtNWP.Text = ""
        txtAOP.Text = ""
        txtLBM.Text = ""
        txtLBN.Text = ""
        txtTHN.Text = ""
        txtAWP.Text = ""
        txtPT.Text = ""

    End Sub

    Public Sub RefreshSetorTable()

        Call Connection()
        Da = New OleDbDataAdapter("Select * from Setor_Pajak", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Setor_Pajak")
        tabelPJK.DataSource = (Ds.Tables("Setor_Pajak"))

        tabelPJK.Columns(0).Width = 60
        tabelPJK.Columns(1).Width = 60
        tabelPJK.Columns(2).Width = 160
        tabelPJK.Columns(3).Width = 160
        tabelPJK.Columns(4).Width = 160
        tabelPJK.Columns(5).Width = 60
        tabelPJK.Columns(6).Width = 60
        tabelPJK.Columns(7).Width = 100

    End Sub

    Public Sub RefreshInputTable()

        Call Connection()
        Da = New OleDbDataAdapter("Select * from Data_Pajak", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Data_Pajak")
        tabelPJK.DataSource = (Ds.Tables("Data_Pajak"))

        tabelPJK.Columns(0).Width = 60
        tabelPJK.Columns(1).Width = 60
        tabelPJK.Columns(2).Width = 160
        tabelPJK.Columns(3).Width = 160
        tabelPJK.Columns(4).Width = 160
        tabelPJK.Columns(5).Width = 60
        tabelPJK.Columns(6).Width = 60
        tabelPJK.Columns(7).Width = 100

    End Sub

    Private Sub SetorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call RefreshInputTable()
        txtCari.Text = "Cari"
        txtCari.ForeColor = Color.Silver

    End Sub

    Private Sub btnInput2_Click(sender As Object, e As EventArgs) Handles btnInput2.Click

        If txtNOP.Text = "" Or txtNWP.Text = "" Or txtAOP.Text = "" Or txtTHN.Text = "" Or txtAWP.Text = "" Or txtLBM.Text = "" Or txtLBN.Text = "" Or txtPT.Text = "" Then

            MessageBox.Show("Pastikan semua bagian sudah terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Call Connection()
            Dim simpanData As String = "Insert into Setor_Pajak values('" & txtNOP.Text & "','" & txtTHN.Text & "',
                                        '" & txtNWP.Text & "','" & txtAOP.Text & "','" & txtAWP.Text & "',
                                        '" & txtLBM.Text & "','" & txtLBN.Text & "','" & txtPT.Text & "')"
            Cmd = New OleDbCommand(simpanData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diinput!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Reset()
            Call RefreshSetorTable()

        End If

    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click

        Call Reset()

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        Call Connection()
        Cmd = New OleDbCommand("Select * from Data_Pajak where NOP Like '%" & txtCari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()

        If Rd.HasRows Then

            Call Connection()
            Da = New OleDbDataAdapter("Select * from Data_Pajak where NOP Like '%" & txtCari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "Data_Pajak")
            tabelPJK.DataSource = (Ds.Tables("Data_Pajak"))

        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If txtNOP.Text = "" Or txtNWP.Text = "" Or txtAOP.Text = "" Or txtTHN.Text = "" Or txtAWP.Text = "" Or txtLBM.Text = "" Or txtLBN.Text = "" Or txtPT.Text = "" Then

            MessageBox.Show("Pastikan data yang ingin dihapus sudah terisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim cfmDelete As DialogResult
            cfmDelete = MessageBox.Show("Apakah Anda yakin ingin hapus data?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If cfmDelete = DialogResult.Yes Then

                Call Connection()
                Dim deleteData As String = "Delete from Setor_Pajak where NOP = '" & txtNOP.Text & "'"
                Cmd = New OleDbCommand(deleteData, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil didelete!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call RefreshSetorTable()
                Call Reset()

            End If

        End If

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

        Dim cfmExit As DialogResult

        cfmExit = MessageBox.Show("Apakah Anda yakin akan menutup aplikasi?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If cfmExit = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    Private Sub btnHome2_Click(sender As Object, e As EventArgs) Handles btnHome2.Click

        loginPage.Show()
        Me.Hide()

    End Sub

    Private Sub logoInput_Click(sender As Object, e As EventArgs) Handles logoInput.Click

        RefreshInputTable()

    End Sub

    Private Sub logoSetor_Click(sender As Object, e As EventArgs) Handles logoSetor.Click

        RefreshSetorTable()

    End Sub

    Private Sub tabelPJK_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelPJK.CellClick

        Try

            txtNOP.Text = tabelPJK.SelectedRows(0).Cells(0).Value.ToString()
            txtTHN.Text = tabelPJK.SelectedRows(0).Cells(1).Value.ToString()
            txtNWP.Text = tabelPJK.SelectedRows(0).Cells(2).Value.ToString()
            txtAWP.Text = tabelPJK.SelectedRows(0).Cells(3).Value.ToString()
            txtAOP.Text = tabelPJK.SelectedRows(0).Cells(4).Value.ToString()
            txtLBM.Text = tabelPJK.SelectedRows(0).Cells(5).Value.ToString()
            txtLBN.Text = tabelPJK.SelectedRows(0).Cells(6).Value.ToString()
            txtPT.Text = tabelPJK.SelectedRows(0).Cells(7).Value.ToString()

        Catch ex As Exception

        End Try

    End Sub

End Class