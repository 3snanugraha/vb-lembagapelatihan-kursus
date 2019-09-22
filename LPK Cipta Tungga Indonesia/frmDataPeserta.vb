Imports System.Data.OleDb
'============================================
'SISTEM INFORMASI LPK CIPTA TUNGGA INDONESIA
'============================================
'OLEH : TRISNA NUGRAHA
'KELOMPOK : 5
'============================================
Public Class frmDataPeserta
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
            cboID.Items.Clear()
            While reader.Read
                cboID.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub pembuka()
        'Agar bisa ditulis
        txtNamaLengkap.ReadOnly = False
        txtJenisKelamin.ReadOnly = False
        txtIdJurusan.ReadOnly = False
        txtAlamat.ReadOnly = False
        'txtNilai.ReadOnly = False
        txtNoTelp.ReadOnly = False
        txtStatus.ReadOnly = False
        txtTglDaftar.ReadOnly = False
        txtTglLahir.ReadOnly = False
        'Tampilan border tebal
        txtNamaLengkap.BorderStyle = BorderStyle.Fixed3D
        txtJenisKelamin.BorderStyle = BorderStyle.Fixed3D
        txtIdJurusan.BorderStyle = BorderStyle.Fixed3D
        txtAlamat.BorderStyle = BorderStyle.Fixed3D
        'txtNilai.BorderStyle = BorderStyle.Fixed3D
        txtNoTelp.BorderStyle = BorderStyle.Fixed3D
        txtStatus.BorderStyle = BorderStyle.Fixed3D
        txtTglDaftar.BorderStyle = BorderStyle.Fixed3D
        txtTglLahir.BorderStyle = BorderStyle.Fixed3D
        rdMen.Enabled = True
        rdWoman.Enabled = True
    End Sub
    Sub kunci()
        Connect()
        Dim Kunci As String = cboID.Text
        sql = "select * from tbl_peserta where id_peserta='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            txtNamaLengkap.Text = reader.Item("nama_peserta")
            txtAlamat.Text = reader.Item("alamat_peserta")
            txtIdJurusan.Text = reader.Item("id_jurusan_peserta")
            txtJenisKelamin.Text = reader.Item("jenis_kelamin_peserta")
            txtTglDaftar.Text = reader.Item("tgl_masuk_peserta")
            txtTglLahir.Text = reader.Item("ttl_peserta")
            txtNoTelp.Text = reader.Item("no_telp_peserta")
            txtStatus.Text = reader.Item("status_peserta")
            'txtNilai.Text = reader.Item("nilai_peserta")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub penutup()
        'Agar bisa ditulis
        txtNamaLengkap.ReadOnly = True
        txtJenisKelamin.ReadOnly = True
        txtIdJurusan.ReadOnly = True
        txtAlamat.ReadOnly = True
        'txtNilai.ReadOnly = True
        txtNoTelp.ReadOnly = True
        txtStatus.ReadOnly = True
        txtTglDaftar.ReadOnly = True
        txtTglLahir.ReadOnly = True
        'Tampilan border tebal
        txtNamaLengkap.BorderStyle = BorderStyle.None
        txtJenisKelamin.BorderStyle = BorderStyle.None
        txtIdJurusan.BorderStyle = BorderStyle.None
        txtAlamat.BorderStyle = BorderStyle.None
        'txtNilai.BorderStyle = BorderStyle.None
        txtNoTelp.BorderStyle = BorderStyle.None
        txtStatus.BorderStyle = BorderStyle.None
        txtTglDaftar.BorderStyle = BorderStyle.None
        txtTglLahir.BorderStyle = BorderStyle.None
        rdMen.Enabled = False
        rdWoman.Enabled = False
    End Sub
    Sub nohandles()
        cboID.Text = cboID.Text
    End Sub
    Private Sub frmDataPeserta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConnString As String
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_lpk.accdb"
        Try
            Conn = New OleDbConnection(ConnString)
            Conn.Open()
            LoadData()
            Tampil()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
        kunci()
        nohandles()
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        frmPendaftaran.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        frmMain.Show()
    End Sub
    Sub aturpilihan()
        If txtJenisKelamin.Text = "Laki-Laki" Then
            rdMen.Checked = True
            rdWoman.Checked = False
        Else
            rdMen.Checked = False
            rdWoman.Checked = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            pembuka()
            aturpilihan()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kunci()
        If txtJenisKelamin.Text = "Laki-Laki" Then
            rdMen.Checked = True
            rdWoman.Checked = False
        Else
            rdMen.Checked = False
            rdWoman.Checked = True
        End If
    End Sub
    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Call Button1_Click(sender, e)
    End Sub
    Private Sub cboID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboID.KeyPress
        If e.KeyChar = Chr(13) Then Call Button1_Click(sender, e)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            penutup()
            aturpilihan()
        End If
    End Sub

    Private Sub rdMen_CheckedChanged(sender As Object, e As EventArgs) Handles rdMen.CheckedChanged
        If rdMen.Checked = True Then
            rdWoman.Checked = False
            txtJenisKelamin.Text = rdMen.Text
        Else
            rdWoman.Checked = True
        End If
    End Sub

    Private Sub rdWoman_CheckedChanged(sender As Object, e As EventArgs) Handles rdWoman.CheckedChanged
        If rdWoman.Checked = True Then
            rdMen.Checked = False
            txtJenisKelamin.Text = rdWoman.Text
        Else
            rdMen.Checked = True
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        frmTransaksi.cboIDPeserta.Text = cboID.Text
        frmTransaksi.Show()
    End Sub
End Class