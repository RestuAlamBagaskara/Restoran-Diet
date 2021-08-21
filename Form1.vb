Public Class Form1
    'Deklarasi variabel yang akan digunakan
    Dim KaloriKArbo, kaloriLAuk, kaloriLAuk1, kaloriLAuk2, kaloriSayur, KaloriBuah, kaloriMinuman As Double
    Dim hargaKarbo, hargaLauk, hargaLauk1, hargaLauk2, hargaSayur, hargaBuah, hargaMinuman As Integer

    Public Sub IMTdanKaloriHArian()
        'Menghitung Index mssa tubuh dan Kriterianya
        L_IMT.Text = Val(txtBerat.Text) / ((Val(txtTinggi.Text) / 100) ^ 2)
        If Val(L_IMT.Text) > 30 Then
            L_Kriteria.Text = "Obesitas"
        ElseIf Val(L_IMT.Text) >= 25 Then
            L_Kriteria.Text = "Lebih"
        ElseIf Val(L_IMT.Text) >= 18.5 Then
            L_Kriteria.Text = "Ideal"
        Else
            L_Kriteria.Text = "Berat Kurang"
        End If

        'Menghitung Kalori Harian
        If CBAktivitas.SelectedIndex = 0 Then
            L_KaloriHarian.Text = Val(L_BMR.Text) * 1.2
        ElseIf CBAktivitas.SelectedIndex = 1 Then
            L_KaloriHarian.Text = Val(L_BMR.Text) * 1.375
        ElseIf CBAktivitas.SelectedIndex = 2 Then
            L_KaloriHarian.Text = Val(L_BMR.Text) * 1.55
        ElseIf CBAktivitas.SelectedIndex = 3 Then
            L_KaloriHarian.Text = Val(L_BMR.Text) * 1.725
        ElseIf CBAktivitas.SelectedIndex = 4 Then
            L_KaloriHarian.Text = Val(L_BMR.Text) * 1.9
        End If
    End Sub
    Public Sub TotalHargadanKalori()
        'Penentuan Nilai ComboBox Karbohidrat
        Select Case CBKarbohidrat.SelectedIndex
            Case 0
                hargaKarbo = 3000
                KaloriKArbo = 175
            Case 1
                hargaKarbo = 2500
                KaloriKArbo = 90.2
            Case 2
                hargaKarbo = 3000
                KaloriKArbo = 166
            Case 3
                hargaKarbo = 4000
                KaloriKArbo = 211
        End Select
        'Penentuan Nilai ComboBox Lauk
        Select Case CBLauk.SelectedIndex
            Case 0
                hargaLauk = 4000
                kaloriLAuk = 129.4
            Case 1
                hargaLauk = 2000
                kaloriLAuk = 138
            Case 2
                hargaLauk = 1500
                kaloriLAuk = 97
            Case 3
                hargaLauk = 3500
                kaloriLAuk = 57.5
            Case 4
                hargaLauk = 2000
                kaloriLAuk = 118
        End Select
        Select Case CBLauk1.SelectedIndex
            Case 0
                hargaLauk1 = 4000
                kaloriLAuk1 = 129.4
            Case 1
                hargaLauk1 = 2000
                kaloriLAuk1 = 138
            Case 2
                hargaLauk1 = 1500
                kaloriLAuk1 = 97
            Case 3
                hargaLauk1 = 3500
                kaloriLAuk1 = 57.5
            Case 4
                hargaLauk1 = 2000
                kaloriLAuk1 = 118
        End Select
        Select Case CBLauk.SelectedIndex
            Case 0
                hargaLauk2 = 4000
                kaloriLAuk2 = 129.4
            Case 1
                hargaLauk2 = 2000
                kaloriLAuk2 = 138
            Case 2
                hargaLauk2 = 1500
                kaloriLAuk2 = 97
            Case 3
                hargaLauk2 = 3500
                kaloriLAuk2 = 57.5
            Case 4
                hargaLauk2 = 2000
                kaloriLAuk2 = 118
        End Select
        'Penentuan Nilai ComboBox Sayur
        Select Case CBSayur.SelectedIndex
            Case 0
                hargaSayur = 1000
                kaloriSayur = 18
            Case 1
                hargaSayur = 2500
                kaloriSayur = 88
            Case 2
                hargaSayur = 2500
                kaloriSayur = 134
            Case 3
                hargaSayur = 2500
                kaloriSayur = 61
            Case 4
                hargaSayur = 2000
                kaloriSayur = 52
        End Select
        'Penentuan Nilai ComboBox Buah
        Select Case CBBuah.SelectedIndex
            Case 0
                hargaBuah = 2500
                KaloriBuah = 85
            Case 1
                hargaBuah = 3000
                KaloriBuah = 157
            Case 2
                hargaBuah = 2000
                KaloriBuah = 82
            Case 3
                hargaBuah = 2000
                KaloriBuah = 67
            Case 4
                hargaBuah = 2500
                KaloriBuah = 48
            Case 5
                hargaBuah = 2500
                KaloriBuah = 46
            Case 6
                hargaBuah = 2000
                KaloriBuah = 46
            Case 7
                hargaBuah = 2000
                KaloriBuah = 136.5
        End Select
        'Penentuan Nilai ComboBox Minuman
        Select Case CBMinuman.SelectedIndex
            Case 0
                hargaMinuman = 1000
                kaloriMinuman = 0
            Case 1
                hargaMinuman = 2000
                kaloriMinuman = 1.4
            Case 2
                hargaMinuman = 3000
                kaloriMinuman = 18
            Case 3
                hargaMinuman = 3500
                kaloriMinuman = 42
        End Select
    End Sub
    Public Sub MasukkanDatakeComboBox()
        'Menambahkan angka ke dalam Combo Box usia
        Dim a As Integer
        For a = 1 To 100
            CBUsia.Items.Add(a)
        Next
        'Menambahkan Kriteria ke dalam Combo Box Aktivitas
        With CBAktivitas.Items
            .Add("Jarang atau tidak berolahraga")
            .Add("Olahraga ringan (1-3 hari/minggu)")
            .Add("Olahraga sedang (3-5 hari/minggu)")
            .Add("Sangat aktif (6-7 hari/minggu)")
            .Add("Ekstra aktif")
        End With
        'Menambah daftar menu ke ComboBox Karbohidrat
        With CBKarbohidrat.Items
            .Add("Nasi Putih")
            .Add("Jagung Rebus")
            .Add("Kentang Rebus")
            .Add("Kentang Goreng")
        End With
        'Menambah daftar menu ke ComboBox LaukPauk
        With CBLauk.Items
            .Add("Ayam Panggang")
            .Add("Telur Asin Rebus")
            .Add("Telur Ayam Rebus")
            .Add("Lele Goreng")
            .Add("Tempe/Tahu Goreng")
        End With
        With CBLauk1.Items
            .Add("Ayam Panggang")
            .Add("Telur Asin Rebus")
            .Add("Telur Ayam Rebus")
            .Add("Lele Goreng")
            .Add("Tempe/Tahu Goreng")
        End With
        With CBLauk2.Items
            .Add("Ayam Panggang")
            .Add("Telur Asin Rebus")
            .Add("Telur Ayam Rebus")
            .Add("Lele Goreng")
            .Add("Tempe/Tahu Goreng")
        End With
        'Menambah daftar menu ke ComboBox Sayur
        With CBSayur.Items
            .Add("Bening Bayam")
            .Add("Sayur Asam")
            .Add("Sayur Sop")
            .Add("Sayur Lodeh")
            .Add("Tumis Buncis")
        End With
        'Menambah daftar menu ke ComboBox buah
        With CBBuah.Items
            .Add("Alpukat")
            .Add("Jambu Biji")
            .Add("Apel Merah")
            .Add("Jeruk Pontianak")
            .Add("Semangka")
            .Add("Pepaya")
            .Add("Melon")
            .Add("Pisang Rebus")
        End With
        'Menambah daftar menu ke ComboBox Minuman
        With CBMinuman.Items
            .Add("Air putih")
            .Add("Teh Cangkir ")
            .Add("Kopi Cangkir")
            .Add("Kelapa Muda")
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasukkanDatakeComboBox()
    End Sub

    Private Sub btnHitungTotal_Click(sender As Object, e As EventArgs) Handles btnHitungTotal.Click
        TotalHargadanKalori()
        L_SaranKalori.Text = Val(L_KaloriHarian.Text) / 3
        L_TotalHarga.Text = hargaKarbo + hargaLauk + hargaLauk1 + hargaLauk2 + hargaMinuman + hargaSayur + hargaBuah
        L_TotalKalori.Text = KaloriKArbo + kaloriLAuk + kaloriLAuk1 + kaloriLAuk2 + kaloriSayur + KaloriBuah + kaloriMinuman
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Try
            'mengConvert jenis data menjadi integer dan Date
            Masukkan_Data(Integer.Parse(L_TotalHarga.Text), Date.Parse(HariIni.Value))
        Catch ex As Exception
            'Mengeluaran pesan jika terjadi kesalahan
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        'membersihkan halaman
        CBKarbohidrat.Text = ""
        CBLauk.Text = ""
        CBLauk1.Text = ""
        CBLauk2.Text = ""
        CBSayur.Text = ""
        CBBuah.Text = ""
        CBMinuman.Text = ""
        txtAlamat.Focus()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        'penentuan antara BMR laki-laki atau perempuan
        If RBLaki.Checked = True Then
            L_BMR.Text = 66.47 + (13.74 * Val(txtBerat.Text)) + (5.003 * Val(txtTinggi.Text)) - (6.755 * Val(CBUsia.Text))
            IMTdanKaloriHArian()
        Else
            L_BMR.Text = 655.1 + (9.563 * Val(txtBerat.Text)) + (1.85 * Val(txtTinggi.Text)) - (4.676 * Val(CBUsia.Text))
            IMTdanKaloriHArian()
        End If
        txtBerat.Text = ""
        txtTinggi.Text = ""
        CBUsia.Text = ""
        CBAktivitas.Text = ""
        txtBerat.Focus()
    End Sub

    Private Sub TBKalori_Scroll(sender As Object, e As EventArgs) Handles TBKalori.Scroll
        'mengatur nilai minimum dan maximum
        TBKalori.Minimum = 1
        TBKalori.Maximum = 500
    End Sub

    Private Sub btnRencanaDiet_Click(sender As Object, e As EventArgs) Handles btnRencanaDiet.Click
        'melakukan perhitungan kalori dan waktu diet
        L_KaloriDiet.Text = Val(L_KaloriHarian.Text) - TBKalori.Value
        L_WaktuDIet.Text = (Val(txtBeratRencana.Text) - Val(txtTargetBerat.Text)) / (TBKalori.Value / 1000)
        L_KaloriRencana.Text = L_KaloriHarian.Text
    End Sub

    Private Sub Pemesanan_Click(sender As Object, e As EventArgs) Handles Pemesanan.Click
        PanelPemesanan.Visible = True
        PanelHitungKalori.Visible = False
        PanelRencanaDiet.Visible = False
    End Sub

    Private Sub HitungKalori_Click(sender As Object, e As EventArgs) Handles HitungKalori.Click
        PanelPemesanan.Visible = False
        PanelHitungKalori.Visible = True
        PanelRencanaDiet.Visible = False
    End Sub

    Private Sub PanelRencanakanDiet_Click(sender As Object, e As EventArgs) Handles RencanakanDiet.Click
        MessageBox.Show("Lakukan perhitungan Kalori di menu 'Hitung Kalori' terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PanelPemesanan.Visible = False
        PanelHitungKalori.Visible = False
        PanelRencanaDiet.Visible = True
    End Sub
End Class