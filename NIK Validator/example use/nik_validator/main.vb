Imports NikvalidatorLib.NIKvalidator.Properti
Imports NikvalidatorLib
Public Class main
    Dim DATA As New NIKproperti
    Private Sub VIEWDATA()
        If NIKvalidator.Aksi.Checkstatus.NIKfungsi.StatusValidasiNIK = False Then 'jika gagal
            LogInStatusBar1.Text = "Validasi gagal"
            LogInStatusBar1.RectangleColor = Color.Red

        Else
            LogInStatusBar1.Text = "Validasi berhasil"
            LogInStatusBar1.RectangleColor = Color.Lime

            '//// Tampilkan informasi NIK /////
            labelNik.Text = TextBoxNIK.Text
            labelUnik.Text = DATA.kodeUnik
            labelUsia.Text = DATA.usia & " tahun"
            labelTanggal_lahir.Text = DATA.tanggalLahir
            labelJenis_kelamin.Text = DATA.jenisKelamin
            labelUlang_tahun.Text = DATA.ulangTahun
            labelZodiak.Text = DATA.zodiak
            labelProvinsi.Text = DATA.provinsi
            labelKotaKabupaten.Text = DATA.kotaKabupaten
            labelKecamatan.Text = DATA.kecamatan
            labelKode_pos.Text = DATA.kodePos
        End If
    End Sub
    Private Sub butonValidasidata(sender As Object, e As EventArgs) Handles buttonValidasi.Click
        DATA.setNIK = TextBoxNIK.Text
        NIKvalidator.Aksi.ValidasiNIK(DATA)

        'tampilkan informasi data
        VIEWDATA()
    End Sub
    Private Sub FormCenter()
        Me.Top = (My.Computer.Screen.WorkingArea.Height \ 2) - (Me.Height \ 2)
        Me.Left = (My.Computer.Screen.WorkingArea.Width \ 2) - (Me.Width \ 2)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCenter()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        aboutapp.ShowDialog()
    End Sub
End Class