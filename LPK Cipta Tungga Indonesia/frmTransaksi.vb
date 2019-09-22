Imports System.Data.OleDb
Public Class frmTransaksi
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    Private Conn As OleDbConnection = Nothing
    Private cmd As OleDbCommand = Nothing
    Private sql As String = Nothing
    Private reader As OleDbDataReader = Nothing
    Private da As OleDbDataAdapter = Nothing
    Function Connect()
        If Not Conn Is Nothing Then
            Conn.Close()
        End If
        Conn.Open()
        Return Conn
    End Function
    Function Closedd()
        Conn.Close()
        Return Conn
    End Function
    Sub Tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("select * from tbl_peserta", Conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub LoadData()
        Connect()
        sql = "select id_peserta from tbl_peserta"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cboIDPeserta.Items.Clear()
            While reader.Read
                cboIDPeserta.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub LoadData2()
        Connect()
        sql = "select id_jurusan from tbl_jurusan"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cboIDJurusan.Items.Clear()
            While reader.Read
                cboIDJurusan.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub kunci()

    End Sub
    Sub koneksi()
        Dim ConnString As String
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_lpk.accdb"
        Try
            Conn = New OleDbConnection(ConnString)
            Conn.Open()

            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
    End Sub
    Sub penomoran()
        Koneksi()
        Connect()
        cmd = New OleDbCommand("select * from tbl_pembayaran order by no_faktur desc", Conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            lblNoFaktur.Text = "TR" + "0001"
        Else
            lblNoFaktur.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("no_faktur").ToString, 4, 3)) + 1
            If Len(lblNoFaktur.Text) = 1 Then
                lblNoFaktur.Text = "TR000" & lblNoFaktur.Text & ""
            ElseIf Len(lblNoFaktur.Text) = 2 Then
                lblNoFaktur.Text = "TR00" & lblNoFaktur.Text & ""
            ElseIf Len(lblNoFaktur.Text) = 3 Then
                lblNoFaktur.Text = "TR0" & lblNoFaktur.Text & ""
            End If
        End If
        Me.Focus()
    End Sub
    Sub nohandles()
        cboIDPeserta.Text = cboIDPeserta.Text
    End Sub
    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTPPembayaran.Text = Format(Now, ("dd/MM/yy"))
        penomoran()
        lblAdmin.Text = frmMain.lblAdmin.Text
        LoadData()
        Tampil()
        kunci()
        LoadData2()
        nohandles()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmMain.Show()
    End Sub
    Private Sub cboIDPeserta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIDPeserta.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cboIDPeserta.Text
        sql = "select * from tbl_peserta where id_peserta='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            lblNamaPeserta.Text = reader.Item("nama_peserta")
            'txtAlamat.Text = reader.Item("alamat_peserta")
            'txtJenisKelamin.Text = reader.Item("jenis_kelamin_peserta")
            'txtTglDaftar.Text = reader.Item("tgl_masuk_peserta")
            'txtTglLahir.Text = reader.Item("ttl_peserta")
            'txtNoTelp.Text = reader.Item("no_telp_peserta")
            lblStatusPeserta.Text = reader.Item("status_peserta")
            cboIDJurusan.Text = reader.Item("id_jurusan_peserta")
            'txtNilai.Text = reader.Item("nilai_peserta")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        If txtBayar.Text = "" Then
            txtBayar.Text = "0"
        End If
        'Dim s As Double
        's = txtBayar.Text
        lblKembalian.Text = (Val(lblTotalBayar.Text) - Val(txtBayar.Text)) * -1
    End Sub
    Sub cleaner()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(lblKembalian.Text) < 0 Then
            lblKembalian.Text = Val(lblKembalian.Text) * -1
            MsgBox("Transaksi gagal, kurang Rp. " + lblKembalian.Text, vbExclamation, "Info")
            lblKembalian.Text = Val(lblKembalian.Text) * -1
            txtBayar.Focus()
        Else
            lblStatusPeserta.Text = "Lunas"
            'MULAI INPUT

            Connect()
            Dim insertquery As String
            Dim Hasil As Integer
            Dim cmd As OleDbCommand
            insertquery = ("insert into tbl_laporan(nofaktur,admin,tanggal,nama_peserta,status_peserta,jurusan_diambil,tutor,total_bayar,kembalian,bayar)Values('" & lblNoFaktur.Text & "','" & frmMain.lblAdmin.Text & "','" & DTPPembayaran.Text & "','" & lblNamaPeserta.Text & "','" & lblStatusPeserta.Text & "','" & lblJurusan.Text & "','" & lblTutor.Text & "','" & lblTotalBayar.Text & "','" & lblKembalian.Text & "','" & txtBayar.Text & "')")
            Try
                cmd = New OleDbCommand(insertquery, Conn)
                Hasil = cmd.ExecuteNonQuery
                If Hasil > 0 Then
                    'MessageBox.Show("record Berhasil Dimasukan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Catch ex As OleDbException
                MessageBox.Show("Failed : " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Closedd()
            'insertquery = ("insert into tbl_laporan(nofaktur,admin,tanggal,nama_peserta,status_peserta,jurusan_diambil,tutor,total_bayar,kembalian)Values('" & lblNoFaktur.Text & "','" & frmMain.lblAdmin.Text & "','" & DTPPembayaran.Text & "','" & lblNamaPeserta.Text & "','" & lblStatusPeserta.Text & "','" & lblJurusan.Text & "','" & lblTutor.Text & "','" & lblTotalBayar.Text & "','" & lblKembalian.Text & "')")

            'SELESAI
            If MsgBox("Transaksi berhasil, cetak laporan?", vbYesNo + vbInformation, "Verifikasi") = MsgBoxResult.Yes Then
                'frmLaporan.cmbNoFaktur.text = lblNoFaktur.text
                frmLaporan.Show()
                frmLaporan.cmbNoFaktur.Text = lblNoFaktur.Text
                Me.Close()
            Else
                'nope
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmLaporan.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmJadwal.Show()
    End Sub
    Private Sub cboIDJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIDPeserta.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cboIDJurusan.Text
        sql = "select * from tbl_jurusan where id_jurusan='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            lblJurusan.Text = reader.Item("jurusan")
            cboIDTutor.Text = reader.Item("id_tutor")
            lblTotalBayar.Text = reader.Item("harga")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub

    Private Sub cboIDTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIDPeserta.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cboIDTutor.Text
        sql = "select * from tbl_tutor where id_tutor='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            lblTutor.Text = reader.Item("nama_tutor")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
End Class