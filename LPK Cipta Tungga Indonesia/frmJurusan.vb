Imports System.Data.OleDb
Public Class frmJurusan
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
            da = New OleDbDataAdapter("select * from tbl_jurusan", Conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub LoadData()
        Connect()
        sql = "select id_jurusan from tbl_jurusan"
        cmd = New OleDbCommand(Sql, Conn)
        reader = cmd.ExecuteReader()
        Try
            cmbIDJurusan.Items.Clear()
            While reader.Read
                cmbIDJurusan.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Sub LoadData2()
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
    Sub koneksikan()
        Dim ConnString As String
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db_lpk.accdb"
        Try
            Conn = New OleDbConnection(ConnString)
            Conn.Open()
            'Me.Text = "Mengubah data Anggota [Connected]"
            LoadData()
            LoadData2()
            Tampil()
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi Error : " + ex.Message)
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmJurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksikan()
    End Sub
    Sub delete()
        Connect()
        Dim index As Integer = cmbIDJurusan.SelectedIndex
        Dim hasil As Integer
        Dim pesan As DialogResult
        sql = "delete from tbl_jurusan where id_jurusan='" & cmbIDJurusan.Text & "'"
        pesan = MessageBox.Show("Yakin Menghapus Data " & Chr(10) & "dengan id " & cmbIDJurusan.Text & "...?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        cmd = New OleDbCommand(sql, Conn)
        Try
            If pesan = DialogResult.Yes = True Then
                hasil = cmd.ExecuteNonQuery
                cmbIDJurusan.Text = "Pilih Jurusan :"
                txtNamaJurusan.Text = ""
                cmbIDTutor.Text = ""
                lblNamaTutor.Text = "-"
                Tampil()
            End If
        Catch ex As OleDbException
            MsgBox("Failed : " & ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub cmbIDJurusan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDJurusan.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cmbIDJurusan.Text
        sql = "select * from tbl_jurusan where id_jurusan='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            txtNamaJurusan.Text = reader.Item("jurusan")
            cmbIDTutor.Text = reader.Item("id_tutor")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Connect()
        Dim hasil As Integer
        sql = "Update tbl_jurusan set jurusan='" & txtNamaJurusan.Text & "',id_tutor='" & cmbIDTutor.Text & "' where id_jurusan='" & cmbIDJurusan.Text & "'"
        cmd = New OleDbCommand(sql, Conn)
        Try
            hasil = cmd.ExecuteNonQuery
            If (hasil > 0) Then
                MessageBox.Show("Berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbIDJurusan.Text = "Pilih Jurusan :"
                txtNamaJurusan.Text = ""
                cmbIDTutor.Text = ""
                lblNamaTutor.Text = "-"
                Tampil()
                LoadData()
            End If
        Catch ex As OleDbException
            MessageBox.Show("Failed : " & ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connect()
        Dim insertquery As String
        Dim Hasil As Integer
        Dim cmd As OleDbCommand
        insertquery = ("insert into tbl_jurusan(id_jurusan,jurusan,id_tutor)Values('" & cmbIDJurusan.Text & "','" & txtNamaJurusan.Text & "','" & cmbIDTutor.Text & "')")
        Try
            cmd = New OleDbCommand(insertquery, Conn)
            Hasil = cmd.ExecuteNonQuery
            If Hasil > 0 Then
                MessageBox.Show("Berhasil Dimasukan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbIDJurusan.Text = "Pilih Jurusan :"
                txtNamaJurusan.Text = ""
                cmbIDTutor.Text = ""
                lblNamaTutor.Text = "-"
                Tampil()
                LoadData()
            End If
        Catch ex As OleDbException
            MessageBox.Show("Failed : " & ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Closedd()
    End Sub
    Private Sub cmbIDTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIDTutor.SelectedIndexChanged
        Connect()
        Dim Kunci As String = cmbIDTutor.Text
        sql = "select * from tbl_tutor where id_tutor='" & Kunci & "'"
        cmd = New OleDbCommand(sql, Conn)
        reader = cmd.ExecuteReader
        Try
            reader.Read()
            lblNamaTutor.Text = reader.Item("nama_tutor")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
End Class