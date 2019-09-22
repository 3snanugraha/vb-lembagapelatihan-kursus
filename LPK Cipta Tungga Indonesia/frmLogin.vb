Imports System.Data.OleDb
Public Class frmLogin
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
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, lblStatus.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            lblStatus.Text = "Username/password tidak boleh kosong."
        Else
            If txtUsername.Text = "" And txtPassword.Text = "" Then
                lblStatus.Text = "Username dan password tidak boleh kosong."
            Else
                Call Koneksi()
                cmd = New OleDbCommand("select * from tbl_administrator where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", Conn)
                'cmd2 = New OleDbCommand("select * from tbadmin where uang='" & txtUsername.Text & "' and pass='" & txtPassword.Text & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Me.Hide()
                    frmMain.Show()
                    frmMain.lblAdmin.Text = rd.Item("nama")
                Else
                    lblStatus.Text = "Username/password belum cocok."
                End If
            End If
        End If
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then Call Button1_Click(sender, e)
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        lblStatus.Text = "Sedang menginput.."
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class