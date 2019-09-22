Public Class frmMain
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
    Sub keluar()
        If MsgBox("Anda yakin akan keluar ?", vbYesNo + vbInformation) = MsgBoxResult.Yes Then
            Me.Close()
        Else
            'Nothing
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        keluar()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmLaporan.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmPendaftaran.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDataPeserta.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmTransaksi.Show()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        keluar()
    End Sub

    Private Sub PesertaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesertaToolStripMenuItem.Click
        frmDataPeserta.Show()
    End Sub

    Private Sub PendaftaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendaftaranToolStripMenuItem.Click
        frmPendaftaran.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        frmTransaksi.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmJurusan.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmDataTutor.Show()
    End Sub

    Private Sub TutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorToolStripMenuItem.Click
        frmDataTutor.Show()
    End Sub

    Private Sub JurusanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JurusanToolStripMenuItem.Click
        frmJurusan.Show()
    End Sub
End Class
