Imports System.Data.OleDb
Public Class frmPendaftaran
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
    Sub koneksi()
        Dim ConnString As String
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_lpk.accdb"
        Try
            Conn = New OleDbConnection(ConnString)
            Conn.Open()
            LoadData()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
    End Sub
    Sub LoadData()
        Connect()
        sql = "select id_jurusan from tbl_jurusan"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cboJurusan.Items.Clear()
            While reader.Read
                cboJurusan.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked, LinkLabel1.LinkClicked
        Me.Hide()
        frmMain.Show()
    End Sub
    Sub penomoran()
        koneksi()
        Connect()
        cmd = New OleDbCommand("select * from tbl_peserta order by id_peserta desc", Conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            lblIDPeserta.Text = "ID" + "0001"
        Else
            lblIDPeserta.Text = Val(Microsoft.VisualBasic.Mid(reader.Item("id_peserta").ToString, 4, 3)) + 1
            If Len(lblIDPeserta.Text) = 1 Then
                lblIDPeserta.Text = "ID000" & lblIDPeserta.Text & ""
            ElseIf Len(lblIDPeserta.Text) = 2 Then
                lblIDPeserta.Text = "ID00" & lblIDPeserta.Text & ""
            ElseIf Len(lblIDPeserta.Text) = 3 Then
                lblIDPeserta.Text = "ID0" & lblIDPeserta.Text & ""
            End If
        End If
        Closedd()
        Me.Focus()
    End Sub
    Sub LoadJurusan()
        Connect()
        sql = "select nama_jurusan from tbl_jurusan"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cboJurusan.Items.Clear()
            While reader.Read
                cboJurusan.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub expired()
        fnow.Text = Format(Now, "dd")
        Dim y As Integer
        y = fnow.Text
        'Dim DespatchDate As DateTime
        Dim dd As Double
        dd = y
        Exp.Text = Format(Now, dd + "/mm/YY")
    End Sub
    Private Sub frmPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        penomoran()
        'LoadJurusan()
    End Sub
    Sub Pembersih()
        txtNamaLengkap.Clear()
        txtAlamat.Clear()
        txtNoTelp.Clear()
        cboJurusan.Text = "Pilih Jurusan :"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button2.Click
        Me.Hide()
        frmDataPeserta.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Apakah data yang anda masukan benar?", vbYesNo + vbInformation, "Verifikasi") = MsgBoxResult.Yes Then
            If txtNamaLengkap.Text = "" Or DTPtglDaftar.Text = "" Or txtNoTelp.Text = "" Or txtTglLahir.Text = "" Or txtAlamat.Text = "" Or cboJurusan.Text = "Pilih jurusan :" Then
                MsgBox("Data tidak boleh ada yang kosong.", vbExclamation, "Info")
            Else
                'Kode Daftar
                Connect()
                Dim insertquery As String
                Dim Hasil As Integer
                Dim cmd As OleDbCommand
                insertquery = ("insert into tbl_peserta(id_peserta,nama_peserta,tgl_masuk_peserta,jenis_kelamin_peserta,ttl_peserta,alamat_peserta,no_telp_peserta,status_peserta,id_jurusan_peserta)Values('" & lblIDPeserta.Text & "','" & txtNamaLengkap.Text & "','" & DTPtglDaftar.Text & "','" & lblJenisKelamin.Text & "','" & txtTglLahir.Text & "','" & txtAlamat.Text & "','" & txtNoTelp.Text & "','" & lblStatus.Text & "','" & cboJurusan.Text & "')")
                Try
                    cmd = New OleDbCommand(insertquery, Conn)
                    Hasil = cmd.ExecuteNonQuery
                    If Hasil > 0 Then
                        If MsgBox("Pendaftaran berhasil, apakah anda akan mendaftarkan peserta lagi ?", vbYesNo + vbInformation, "Konfirmasi") = MsgBoxResult.Yes Then
                            'MessageBox.Show("Pendaftaran berhasil, silakan proses pembayaran.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Pembersih()
                            penomoran()
                        Else
                            frmDataPeserta.cboID.Text = lblIDPeserta.Text
                            Me.Close()
                            frmDataPeserta.Show()
                        End If
                    End If
                Catch ex As OleDbException
                    MessageBox.Show("Failed : " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Closedd()
                'Kembali
            End If
        End If
    End Sub
    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click, lblIDJurusan.Click

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            lblJenisKelamin.Text = "Laki-Laki"
        Else
            lblJenisKelamin.Text = "Perempuan"
        End If
    End Sub
    Private Sub cboJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJurusan.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pembersih()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked, LinkLabel2.LinkClicked
        frmJurusan.Show()
    End Sub

    Private Sub Exp_Click(sender As Object, e As EventArgs) Handles Exp.Click, fnow.Click

    End Sub
End Class