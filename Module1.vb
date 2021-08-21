Imports MySql.Data.MySqlClient
Module Module1
    'Untuk masuk/memberi akses kedalam database
    Dim serv As String = "Server = localhost" & ";"
    Dim dbase As String = "Database = sista" & ";"
    Dim uid As String = "uid = root" & ";"
    Dim pwd As String = "pwd = root" & ";"
    Dim ConString = "server=localhost;user id=root;" & "password=;database=penjualan"

    'Untuk menggunakan fungsi dari MySQL.Data.MysqlClient
    Public db As New MySqlConnection(ConString)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader

    'Menghubungkan/membuka program dengan database
    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'menutup database
    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub

    'menambahkan data ke dalam database
    Public Sub Masukkan_Data(ByVal total As Integer, ByVal tanggal As Date)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO log_penjualan (total, tanggal) VALUES (@total, @tanggal)"
        myCommand.Parameters.AddWithValue("@total", total)
        myCommand.Parameters.AddWithValue("@tanggal", tanggal)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub


End Module
