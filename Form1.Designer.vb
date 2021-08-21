<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Pemesanan = New System.Windows.Forms.ToolStripMenuItem()
        Me.HitungKalori = New System.Windows.Forms.ToolStripMenuItem()
        Me.RencanakanDiet = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelHitungKalori = New System.Windows.Forms.Panel()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.L_KaloriHarian = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.L_BMR = New System.Windows.Forms.Label()
        Me.L_Kriteria = New System.Windows.Forms.Label()
        Me.L_IMT = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBAktivitas = New System.Windows.Forms.ComboBox()
        Me.CBUsia = New System.Windows.Forms.ComboBox()
        Me.txtTinggi = New System.Windows.Forms.TextBox()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.RBPerempuan = New System.Windows.Forms.RadioButton()
        Me.RBLaki = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelPemesanan = New System.Windows.Forms.Panel()
        Me.CBLauk2 = New System.Windows.Forms.ComboBox()
        Me.CBLauk1 = New System.Windows.Forms.ComboBox()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.btnHitungTotal = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CBMinuman = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.L_TotalHarga = New System.Windows.Forms.Label()
        Me.L_TotalKalori = New System.Windows.Forms.Label()
        Me.L_SaranKalori = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CBBuah = New System.Windows.Forms.ComboBox()
        Me.CBSayur = New System.Windows.Forms.ComboBox()
        Me.CBLauk = New System.Windows.Forms.ComboBox()
        Me.CBKarbohidrat = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PanelRencanaDiet = New System.Windows.Forms.Panel()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtBeratRencana = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnRencanaDiet = New System.Windows.Forms.Button()
        Me.txtTargetBerat = New System.Windows.Forms.TextBox()
        Me.L_KaloriRencana = New System.Windows.Forms.Label()
        Me.L_KaloriDiet = New System.Windows.Forms.Label()
        Me.L_WaktuDIet = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TBKalori = New System.Windows.Forms.TrackBar()
        Me.HariIni = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelHitungKalori.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelPemesanan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelRencanaDiet.SuspendLayout()
        CType(Me.TBKalori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pemesanan, Me.HitungKalori, Me.RencanakanDiet})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Pemesanan
        '
        Me.Pemesanan.ForeColor = System.Drawing.SystemColors.Control
        Me.Pemesanan.Name = "Pemesanan"
        Me.Pemesanan.Size = New System.Drawing.Size(117, 29)
        Me.Pemesanan.Text = "Pemesanan"
        '
        'HitungKalori
        '
        Me.HitungKalori.ForeColor = System.Drawing.SystemColors.Control
        Me.HitungKalori.Name = "HitungKalori"
        Me.HitungKalori.Size = New System.Drawing.Size(131, 29)
        Me.HitungKalori.Text = "Hitung Kalori"
        '
        'RencanakanDiet
        '
        Me.RencanakanDiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RencanakanDiet.Name = "RencanakanDiet"
        Me.RencanakanDiet.Size = New System.Drawing.Size(158, 29)
        Me.RencanakanDiet.Text = "Rencanakan Diet"
        '
        'PanelHitungKalori
        '
        Me.PanelHitungKalori.BackColor = System.Drawing.Color.LightSeaGreen
        Me.PanelHitungKalori.Controls.Add(Me.btnHitung)
        Me.PanelHitungKalori.Controls.Add(Me.GroupBox1)
        Me.PanelHitungKalori.Controls.Add(Me.CBAktivitas)
        Me.PanelHitungKalori.Controls.Add(Me.CBUsia)
        Me.PanelHitungKalori.Controls.Add(Me.txtTinggi)
        Me.PanelHitungKalori.Controls.Add(Me.txtBerat)
        Me.PanelHitungKalori.Controls.Add(Me.RBPerempuan)
        Me.PanelHitungKalori.Controls.Add(Me.RBLaki)
        Me.PanelHitungKalori.Controls.Add(Me.Label10)
        Me.PanelHitungKalori.Controls.Add(Me.Label9)
        Me.PanelHitungKalori.Controls.Add(Me.Label8)
        Me.PanelHitungKalori.Controls.Add(Me.Label7)
        Me.PanelHitungKalori.Controls.Add(Me.Label6)
        Me.PanelHitungKalori.Controls.Add(Me.Label5)
        Me.PanelHitungKalori.Controls.Add(Me.Label4)
        Me.PanelHitungKalori.Controls.Add(Me.Label3)
        Me.PanelHitungKalori.Controls.Add(Me.Label2)
        Me.PanelHitungKalori.Controls.Add(Me.Label1)
        Me.PanelHitungKalori.Location = New System.Drawing.Point(13, 37)
        Me.PanelHitungKalori.Name = "PanelHitungKalori"
        Me.PanelHitungKalori.Size = New System.Drawing.Size(669, 428)
        Me.PanelHitungKalori.TabIndex = 1
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(533, 22)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(121, 45)
        Me.btnHitung.TabIndex = 17
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.L_KaloriHarian)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.L_BMR)
        Me.GroupBox1.Controls.Add(Me.L_Kriteria)
        Me.GroupBox1.Controls.Add(Me.L_IMT)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 157)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil"
        '
        'L_KaloriHarian
        '
        Me.L_KaloriHarian.AutoSize = True
        Me.L_KaloriHarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_KaloriHarian.Location = New System.Drawing.Point(229, 124)
        Me.L_KaloriHarian.Name = "L_KaloriHarian"
        Me.L_KaloriHarian.Size = New System.Drawing.Size(14, 20)
        Me.L_KaloriHarian.TabIndex = 25
        Me.L_KaloriHarian.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(203, 125)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 26)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = ":"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 130)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 20)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Kalori Harian"
        '
        'L_BMR
        '
        Me.L_BMR.AutoSize = True
        Me.L_BMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_BMR.Location = New System.Drawing.Point(230, 96)
        Me.L_BMR.Name = "L_BMR"
        Me.L_BMR.Size = New System.Drawing.Size(14, 20)
        Me.L_BMR.TabIndex = 22
        Me.L_BMR.Text = "-"
        '
        'L_Kriteria
        '
        Me.L_Kriteria.AutoSize = True
        Me.L_Kriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Kriteria.Location = New System.Drawing.Point(230, 62)
        Me.L_Kriteria.Name = "L_Kriteria"
        Me.L_Kriteria.Size = New System.Drawing.Size(14, 20)
        Me.L_Kriteria.TabIndex = 21
        Me.L_Kriteria.Text = "-"
        '
        'L_IMT
        '
        Me.L_IMT.AutoSize = True
        Me.L_IMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_IMT.Location = New System.Drawing.Point(230, 30)
        Me.L_IMT.Name = "L_IMT"
        Me.L_IMT.Size = New System.Drawing.Size(14, 20)
        Me.L_IMT.TabIndex = 20
        Me.L_IMT.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(204, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 26)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(204, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 26)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(204, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 26)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Tingkat Metabolisme Basal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Kriteria"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Index Massa Tubuh"
        '
        'CBAktivitas
        '
        Me.CBAktivitas.FormattingEnabled = True
        Me.CBAktivitas.Location = New System.Drawing.Point(196, 153)
        Me.CBAktivitas.Name = "CBAktivitas"
        Me.CBAktivitas.Size = New System.Drawing.Size(281, 28)
        Me.CBAktivitas.TabIndex = 15
        '
        'CBUsia
        '
        Me.CBUsia.FormattingEnabled = True
        Me.CBUsia.Location = New System.Drawing.Point(196, 107)
        Me.CBUsia.Name = "CBUsia"
        Me.CBUsia.Size = New System.Drawing.Size(281, 28)
        Me.CBUsia.TabIndex = 14
        '
        'txtTinggi
        '
        Me.txtTinggi.Location = New System.Drawing.Point(196, 65)
        Me.txtTinggi.Name = "txtTinggi"
        Me.txtTinggi.Size = New System.Drawing.Size(281, 26)
        Me.txtTinggi.TabIndex = 13
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(196, 22)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(281, 26)
        Me.txtBerat.TabIndex = 12
        '
        'RBPerempuan
        '
        Me.RBPerempuan.AutoSize = True
        Me.RBPerempuan.Location = New System.Drawing.Point(361, 201)
        Me.RBPerempuan.Name = "RBPerempuan"
        Me.RBPerempuan.Size = New System.Drawing.Size(116, 24)
        Me.RBPerempuan.TabIndex = 11
        Me.RBPerempuan.Text = "Perempuan"
        Me.RBPerempuan.UseVisualStyleBackColor = True
        '
        'RBLaki
        '
        Me.RBLaki.AutoSize = True
        Me.RBLaki.Checked = True
        Me.RBLaki.Location = New System.Drawing.Point(196, 201)
        Me.RBLaki.Name = "RBLaki"
        Me.RBLaki.Size = New System.Drawing.Size(97, 24)
        Me.RBLaki.TabIndex = 10
        Me.RBLaki.TabStop = True
        Me.RBLaki.Text = "Laki-Laki"
        Me.RBLaki.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(171, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 26)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(171, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 26)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tingkat Aktivitas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usia  (Tahun)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tinggi (cm)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Berat (Kg)"
        '
        'PanelPemesanan
        '
        Me.PanelPemesanan.BackColor = System.Drawing.Color.Red
        Me.PanelPemesanan.Controls.Add(Me.CBLauk2)
        Me.PanelPemesanan.Controls.Add(Me.CBLauk1)
        Me.PanelPemesanan.Controls.Add(Me.btnPesan)
        Me.PanelPemesanan.Controls.Add(Me.btnHitungTotal)
        Me.PanelPemesanan.Controls.Add(Me.Label35)
        Me.PanelPemesanan.Controls.Add(Me.CBMinuman)
        Me.PanelPemesanan.Controls.Add(Me.Label36)
        Me.PanelPemesanan.Controls.Add(Me.txtAlamat)
        Me.PanelPemesanan.Controls.Add(Me.Label34)
        Me.PanelPemesanan.Controls.Add(Me.Label33)
        Me.PanelPemesanan.Controls.Add(Me.Label32)
        Me.PanelPemesanan.Controls.Add(Me.Label31)
        Me.PanelPemesanan.Controls.Add(Me.Label30)
        Me.PanelPemesanan.Controls.Add(Me.Label29)
        Me.PanelPemesanan.Controls.Add(Me.GroupBox2)
        Me.PanelPemesanan.Controls.Add(Me.CBBuah)
        Me.PanelPemesanan.Controls.Add(Me.CBSayur)
        Me.PanelPemesanan.Controls.Add(Me.CBLauk)
        Me.PanelPemesanan.Controls.Add(Me.CBKarbohidrat)
        Me.PanelPemesanan.Controls.Add(Me.Label20)
        Me.PanelPemesanan.Controls.Add(Me.Label19)
        Me.PanelPemesanan.Controls.Add(Me.Label18)
        Me.PanelPemesanan.Controls.Add(Me.Label17)
        Me.PanelPemesanan.Location = New System.Drawing.Point(13, 36)
        Me.PanelPemesanan.Name = "PanelPemesanan"
        Me.PanelPemesanan.Size = New System.Drawing.Size(672, 428)
        Me.PanelPemesanan.TabIndex = 18
        Me.PanelPemesanan.Visible = False
        '
        'CBLauk2
        '
        Me.CBLauk2.FormattingEnabled = True
        Me.CBLauk2.Location = New System.Drawing.Point(410, 57)
        Me.CBLauk2.Name = "CBLauk2"
        Me.CBLauk2.Size = New System.Drawing.Size(118, 28)
        Me.CBLauk2.TabIndex = 26
        '
        'CBLauk1
        '
        Me.CBLauk1.FormattingEnabled = True
        Me.CBLauk1.Location = New System.Drawing.Point(274, 58)
        Me.CBLauk1.Name = "CBLauk1"
        Me.CBLauk1.Size = New System.Drawing.Size(130, 28)
        Me.CBLauk1.TabIndex = 25
        '
        'btnPesan
        '
        Me.btnPesan.Font = New System.Drawing.Font("Myanmar Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.Location = New System.Drawing.Point(550, 93)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(105, 48)
        Me.btnPesan.TabIndex = 24
        Me.btnPesan.Text = "Pesan"
        Me.btnPesan.UseVisualStyleBackColor = True
        '
        'btnHitungTotal
        '
        Me.btnHitungTotal.Font = New System.Drawing.Font("Myanmar Text", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitungTotal.Location = New System.Drawing.Point(550, 22)
        Me.btnHitungTotal.Name = "btnHitungTotal"
        Me.btnHitungTotal.Size = New System.Drawing.Size(105, 48)
        Me.btnHitungTotal.TabIndex = 23
        Me.btnHitungTotal.Text = "Hitung"
        Me.btnHitungTotal.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(114, 164)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 20)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = ":"
        '
        'CBMinuman
        '
        Me.CBMinuman.FormattingEnabled = True
        Me.CBMinuman.Location = New System.Drawing.Point(133, 161)
        Me.CBMinuman.Name = "CBMinuman"
        Me.CBMinuman.Size = New System.Drawing.Size(395, 28)
        Me.CBMinuman.TabIndex = 21
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(18, 164)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(74, 20)
        Me.Label36.TabIndex = 20
        Me.Label36.Text = "Minuman"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(133, 200)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(395, 26)
        Me.txtAlamat.TabIndex = 19
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(115, 203)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 20)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = ":"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(18, 203)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 20)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Alamat"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(114, 26)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 20)
        Me.Label32.TabIndex = 16
        Me.Label32.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(114, 61)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 20)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(114, 94)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 20)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(114, 129)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 20)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox2.Controls.Add(Me.L_TotalHarga)
        Me.GroupBox2.Controls.Add(Me.L_TotalKalori)
        Me.GroupBox2.Controls.Add(Me.L_SaranKalori)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 149)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil"
        '
        'L_TotalHarga
        '
        Me.L_TotalHarga.AutoSize = True
        Me.L_TotalHarga.Location = New System.Drawing.Point(187, 113)
        Me.L_TotalHarga.Name = "L_TotalHarga"
        Me.L_TotalHarga.Size = New System.Drawing.Size(14, 20)
        Me.L_TotalHarga.TabIndex = 17
        Me.L_TotalHarga.Text = "-"
        '
        'L_TotalKalori
        '
        Me.L_TotalKalori.AutoSize = True
        Me.L_TotalKalori.Location = New System.Drawing.Point(187, 71)
        Me.L_TotalKalori.Name = "L_TotalKalori"
        Me.L_TotalKalori.Size = New System.Drawing.Size(14, 20)
        Me.L_TotalKalori.TabIndex = 16
        Me.L_TotalKalori.Text = "-"
        '
        'L_SaranKalori
        '
        Me.L_SaranKalori.AutoSize = True
        Me.L_SaranKalori.Location = New System.Drawing.Point(187, 29)
        Me.L_SaranKalori.Name = "L_SaranKalori"
        Me.L_SaranKalori.Size = New System.Drawing.Size(14, 20)
        Me.L_SaranKalori.TabIndex = 15
        Me.L_SaranKalori.Text = "-"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(168, 113)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 20)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(168, 71)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 20)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(168, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(13, 20)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(22, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(133, 20)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Kalori Disarankan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(22, 113)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 20)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Total Harga"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(22, 71)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Total Kalori"
        '
        'CBBuah
        '
        Me.CBBuah.FormattingEnabled = True
        Me.CBBuah.Location = New System.Drawing.Point(133, 126)
        Me.CBBuah.Name = "CBBuah"
        Me.CBBuah.Size = New System.Drawing.Size(395, 28)
        Me.CBBuah.TabIndex = 7
        '
        'CBSayur
        '
        Me.CBSayur.FormattingEnabled = True
        Me.CBSayur.Location = New System.Drawing.Point(133, 91)
        Me.CBSayur.Name = "CBSayur"
        Me.CBSayur.Size = New System.Drawing.Size(395, 28)
        Me.CBSayur.TabIndex = 6
        '
        'CBLauk
        '
        Me.CBLauk.FormattingEnabled = True
        Me.CBLauk.Location = New System.Drawing.Point(133, 57)
        Me.CBLauk.Name = "CBLauk"
        Me.CBLauk.Size = New System.Drawing.Size(135, 28)
        Me.CBLauk.TabIndex = 5
        '
        'CBKarbohidrat
        '
        Me.CBKarbohidrat.FormattingEnabled = True
        Me.CBKarbohidrat.Location = New System.Drawing.Point(133, 22)
        Me.CBKarbohidrat.Name = "CBKarbohidrat"
        Me.CBKarbohidrat.Size = New System.Drawing.Size(395, 28)
        Me.CBKarbohidrat.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(18, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 20)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Buah"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(18, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 20)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Sayur"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(18, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 20)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Lauk Pauk"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(18, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Karbohidrat"
        '
        'PanelRencanaDiet
        '
        Me.PanelRencanaDiet.BackColor = System.Drawing.Color.MediumTurquoise
        Me.PanelRencanaDiet.Controls.Add(Me.Label48)
        Me.PanelRencanaDiet.Controls.Add(Me.Label47)
        Me.PanelRencanaDiet.Controls.Add(Me.txtBeratRencana)
        Me.PanelRencanaDiet.Controls.Add(Me.Label45)
        Me.PanelRencanaDiet.Controls.Add(Me.Label46)
        Me.PanelRencanaDiet.Controls.Add(Me.btnRencanaDiet)
        Me.PanelRencanaDiet.Controls.Add(Me.txtTargetBerat)
        Me.PanelRencanaDiet.Controls.Add(Me.L_KaloriRencana)
        Me.PanelRencanaDiet.Controls.Add(Me.L_KaloriDiet)
        Me.PanelRencanaDiet.Controls.Add(Me.L_WaktuDIet)
        Me.PanelRencanaDiet.Controls.Add(Me.Label41)
        Me.PanelRencanaDiet.Controls.Add(Me.Label42)
        Me.PanelRencanaDiet.Controls.Add(Me.Label43)
        Me.PanelRencanaDiet.Controls.Add(Me.Label44)
        Me.PanelRencanaDiet.Controls.Add(Me.Label40)
        Me.PanelRencanaDiet.Controls.Add(Me.Label39)
        Me.PanelRencanaDiet.Controls.Add(Me.Label38)
        Me.PanelRencanaDiet.Controls.Add(Me.Label37)
        Me.PanelRencanaDiet.Controls.Add(Me.TBKalori)
        Me.PanelRencanaDiet.Location = New System.Drawing.Point(13, 33)
        Me.PanelRencanaDiet.Name = "PanelRencanaDiet"
        Me.PanelRencanaDiet.Size = New System.Drawing.Size(672, 429)
        Me.PanelRencanaDiet.TabIndex = 27
        Me.PanelRencanaDiet.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(578, 70)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(52, 20)
        Me.Label48.TabIndex = 18
        Me.Label48.Text = "Cepat"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(14, 75)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(63, 20)
        Me.Label47.TabIndex = 17
        Me.Label47.Text = "Lambat"
        '
        'txtBeratRencana
        '
        Me.txtBeratRencana.Location = New System.Drawing.Point(204, 146)
        Me.txtBeratRencana.Name = "txtBeratRencana"
        Me.txtBeratRencana.Size = New System.Drawing.Size(180, 26)
        Me.txtBeratRencana.TabIndex = 16
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(185, 148)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(13, 20)
        Me.Label45.TabIndex = 15
        Me.Label45.Text = ":"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(32, 146)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(107, 20)
        Me.Label46.TabIndex = 14
        Me.Label46.Text = "Berat Saat Ini"
        '
        'btnRencanaDiet
        '
        Me.btnRencanaDiet.Location = New System.Drawing.Point(491, 318)
        Me.btnRencanaDiet.Name = "btnRencanaDiet"
        Me.btnRencanaDiet.Size = New System.Drawing.Size(109, 54)
        Me.btnRencanaDiet.TabIndex = 13
        Me.btnRencanaDiet.Text = "Hitung"
        Me.btnRencanaDiet.UseVisualStyleBackColor = True
        '
        'txtTargetBerat
        '
        Me.txtTargetBerat.Location = New System.Drawing.Point(204, 191)
        Me.txtTargetBerat.Name = "txtTargetBerat"
        Me.txtTargetBerat.Size = New System.Drawing.Size(180, 26)
        Me.txtTargetBerat.TabIndex = 12
        '
        'L_KaloriRencana
        '
        Me.L_KaloriRencana.AutoSize = True
        Me.L_KaloriRencana.Location = New System.Drawing.Point(209, 301)
        Me.L_KaloriRencana.Name = "L_KaloriRencana"
        Me.L_KaloriRencana.Size = New System.Drawing.Size(14, 20)
        Me.L_KaloriRencana.TabIndex = 11
        Me.L_KaloriRencana.Text = "-"
        '
        'L_KaloriDiet
        '
        Me.L_KaloriDiet.AutoSize = True
        Me.L_KaloriDiet.Location = New System.Drawing.Point(209, 267)
        Me.L_KaloriDiet.Name = "L_KaloriDiet"
        Me.L_KaloriDiet.Size = New System.Drawing.Size(14, 20)
        Me.L_KaloriDiet.TabIndex = 10
        Me.L_KaloriDiet.Text = "-"
        '
        'L_WaktuDIet
        '
        Me.L_WaktuDIet.AutoSize = True
        Me.L_WaktuDIet.Location = New System.Drawing.Point(209, 231)
        Me.L_WaktuDIet.Name = "L_WaktuDIet"
        Me.L_WaktuDIet.Size = New System.Drawing.Size(14, 20)
        Me.L_WaktuDIet.TabIndex = 9
        Me.L_WaktuDIet.Text = "-"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(184, 301)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 20)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = ":"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(184, 267)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(13, 20)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = ":"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(184, 231)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 20)
        Me.Label43.TabIndex = 6
        Me.Label43.Text = ":"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(185, 191)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(13, 20)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = ":"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(31, 299)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(99, 20)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Kalori Harian"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(31, 265)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(81, 20)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Kalori Diet"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(31, 229)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(148, 20)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Lama Diet (Minggu)"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(32, 189)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(98, 20)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Target Berat"
        '
        'TBKalori
        '
        Me.TBKalori.Location = New System.Drawing.Point(24, 26)
        Me.TBKalori.Name = "TBKalori"
        Me.TBKalori.Size = New System.Drawing.Size(617, 69)
        Me.TBKalori.TabIndex = 0
        '
        'HariIni
        '
        Me.HariIni.Location = New System.Drawing.Point(482, 4)
        Me.HariIni.Name = "HariIni"
        Me.HariIni.Size = New System.Drawing.Size(200, 26)
        Me.HariIni.TabIndex = 28
        Me.HariIni.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(691, 477)
        Me.Controls.Add(Me.PanelRencanaDiet)
        Me.Controls.Add(Me.HariIni)
        Me.Controls.Add(Me.PanelPemesanan)
        Me.Controls.Add(Me.PanelHitungKalori)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rumah Makan Diet"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelHitungKalori.ResumeLayout(False)
        Me.PanelHitungKalori.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelPemesanan.ResumeLayout(False)
        Me.PanelPemesanan.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelRencanaDiet.ResumeLayout(False)
        Me.PanelRencanaDiet.PerformLayout()
        CType(Me.TBKalori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Pemesanan As ToolStripMenuItem
    Friend WithEvents HitungKalori As ToolStripMenuItem
    Friend WithEvents PanelHitungKalori As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RBPerempuan As RadioButton
    Friend WithEvents RBLaki As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents L_BMR As Label
    Friend WithEvents L_Kriteria As Label
    Friend WithEvents L_IMT As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CBAktivitas As ComboBox
    Friend WithEvents CBUsia As ComboBox
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents L_KaloriHarian As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PanelPemesanan As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBBuah As ComboBox
    Friend WithEvents CBSayur As ComboBox
    Friend WithEvents CBLauk As ComboBox
    Friend WithEvents CBKarbohidrat As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents L_TotalHarga As Label
    Friend WithEvents L_TotalKalori As Label
    Friend WithEvents L_SaranKalori As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents CBMinuman As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents btnPesan As Button
    Friend WithEvents btnHitungTotal As Button
    Friend WithEvents CBLauk2 As ComboBox
    Friend WithEvents CBLauk1 As ComboBox
    Friend WithEvents RencanakanDiet As ToolStripMenuItem
    Friend WithEvents PanelRencanaDiet As Panel
    Friend WithEvents TBKalori As TrackBar
    Friend WithEvents btnRencanaDiet As Button
    Friend WithEvents txtTargetBerat As TextBox
    Friend WithEvents L_KaloriRencana As Label
    Friend WithEvents L_KaloriDiet As Label
    Friend WithEvents L_WaktuDIet As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txtBeratRencana As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents HariIni As DateTimePicker
End Class
