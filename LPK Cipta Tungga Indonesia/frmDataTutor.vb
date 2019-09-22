Imports System.Data.OleDb
Public Class frmDataTutor
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
    Sub Tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("select * from tbl_tutor", Conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub LoadData()
        Connect()
        sql = "select id_tutor from tbl_tutor"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cmbIDTutor.Items.Clear()
            While reader.Read
                cmbIDTutor.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub koneksii()
        Dim ConnString As String
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_lpk.accdb"
        Try
            Conn = New OleDbConnection(ConnString)
            Conn.Open()
            'Me.Text = "Mengubah data Anggota [Connected]"
            LoadData()
            Tampil()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
    End Sub
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
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Connect()
        Dim index As Integer = cmbIDTutor.SelectedIndex
        Dim hasil As Integer
        Dim pesan As DialogResult
        sql = "delete from tbl_tutor where id_tutor='" & cmbIDTutor.Text & "'"
        pesan = MessageBox.Show("Yakin Menghapus Data Tutor " & Chr(10) & "dengan ID : " & cmbIDTutor.Text & "...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        cmd = New OleDbCommand(sql, Conn)
        Try
            If pesan = DialogResult.Yes = True Then
                hasil = cmd.ExecuteNonQuery
                cmbIDTutor.Text = "Pilih ID :"
                txtNamaTutor.Text = ""
                txtJenisKelamin.Text = ""
                txtNoTelpon.Clear()
                txtAlamat.Clear()
                Tampil()
            End If
        Catch ex As OleDbException
            MsgBox("Failed : " & ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtJenisKelamin.TextChanged, txtNoTelpon.TextChanged, txtAlamat.TextChanged

    End Sub
    Private Sub frmDataTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksii()
    End Sub
    Private Sub cmbIDTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDTutor.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cmbIDTutor.Text
        sql = "select * from tbl_tutor where id_tutor='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            txtNamaTutor.Text = reader.Item("nama_tutor")
            txtJenisKelamin.Text = reader.Item("jeniskelamin_tutor")
            txtTanggalLahir.Text = reader.Item("ttl_tutor")
            txtAlamat.Text = reader.Item("alamat_tutor")
            txtNoTelpon.Text = reader.Item("no_telp_tutor")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Connect()
        Dim hasil As Integer
        sql = "Update tbl_tutor set nama_tutor='" & txtNamaTutor.Text & "',jeniskelamin_tutor='" & txtJenisKelamin.Text & "', ttl_tutor='" & txtTanggalLahir.Text & "', alamat_tutor='" & txtAlamat.Text & "', no_telp_tutor='" & txtNoTelpon.Text & "' where id_tutor='" & cmbIDTutor.Text & "'"
        cmd = New OleDbCommand(sql, Conn)
        Try
            hasil = cmd.ExecuteNonQuery
            If (hasil > 0) Then
                MessageBox.Show("Berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbIDTutor.Text = "Pilih ID :"
                txtNamaTutor.Text = ""
                txtJenisKelamin.Text = ""
                txtNoTelpon.Clear()
                txtAlamat.Clear()
                Tampil()
                LoadData()
            End If
        Catch ex As OleDbException
            MessageBox.Show("Failed : " & ex.Message)
        End Try
        Closedd()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Connect()
        Dim insertquery As String
        Dim Hasil As Integer
        Dim cmd As OleDbCommand
        insertquery = ("insert into tbl_tutor(id_tutor,nama_tutor,jeniskelamin_tutor,ttl_tutor,alamat_tutor,no_telp_tutor)Values('" & cmbIDTutor.Text & "','" & txtNamaTutor.Text & "','" & txtJenisKelamin.Text & "','" & txtTanggalLahir.Text & "','" & txtAlamat.Text & "','" & txtNoTelpon.Text & "')")
        Try
            cmd = New OleDbCommand(insertquery, Conn)
            Hasil = cmd.ExecuteNonQuery
            If Hasil > 0 Then
                MessageBox.Show("Berhasil Dimasukan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbIDTutor.Text = "Pilih ID Tutor :"
                txtNamaTutor.Clear()
                txtJenisKelamin.Clear()
                txtAlamat.Clear()
                txtNoTelpon.Clear()
                txtTanggalLahir.Text = "01/01/1999"
                Tampil()
                LoadData()
            End If
        Catch ex As OleDbException
            MessageBox.Show("Failed : " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Closedd()
    End Sub
End Class