Imports System.Data.OleDb

Public Class loginPage
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Email atau password belum terisi! Silahkan diisi kembali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Text = ""
            txtPassword.Text = ""

        Else
            Call Connection()
            Cmd = New OleDbCommand("select * from Validasi_Email where Email='" & txtEmail.Text & "' and Password='" & txtPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MessageBox.Show("Login berhasil!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmail.Text = ""
                txtPassword.Text = ""
                BridgePage.Show()
                Me.Hide()

            Else
                MessageBox.Show("Email atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Text = ""
                txtPassword.Text = ""
            End If

        End If
    End Sub
End Class
