<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksi
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboIDTutor = New System.Windows.Forms.ComboBox()
        Me.cboIDJurusan = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblStatusPeserta = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblTotalBayar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboIDPeserta = New System.Windows.Forms.ComboBox()
        Me.lblNoFaktur = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTutor = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.lblNamaPeserta = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPPembayaran = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(691, 37)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 21)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Kembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(136, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(302, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Lembaga Kursus Dan Pelatihan Komputer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(133, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Pembayaran"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.cboIDTutor)
        Me.GroupBox1.Controls.Add(Me.cboIDJurusan)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblStatusPeserta)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtBayar)
        Me.GroupBox1.Controls.Add(Me.lblTotalBayar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboIDPeserta)
        Me.GroupBox1.Controls.Add(Me.lblNoFaktur)
        Me.GroupBox1.Controls.Add(Me.lblAdmin)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblTutor)
        Me.GroupBox1.Controls.Add(Me.lblJurusan)
        Me.GroupBox1.Controls.Add(Me.lblNamaPeserta)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblKembalian)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DTPPembayaran)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 424)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'cboIDTutor
        '
        Me.cboIDTutor.FormattingEnabled = True
        Me.cboIDTutor.Location = New System.Drawing.Point(375, 90)
        Me.cboIDTutor.Name = "cboIDTutor"
        Me.cboIDTutor.Size = New System.Drawing.Size(103, 23)
        Me.cboIDTutor.TabIndex = 8
        Me.cboIDTutor.Visible = False
        '
        'cboIDJurusan
        '
        Me.cboIDJurusan.FormattingEnabled = True
        Me.cboIDJurusan.Location = New System.Drawing.Point(262, 90)
        Me.cboIDJurusan.Name = "cboIDJurusan"
        Me.cboIDJurusan.Size = New System.Drawing.Size(103, 23)
        Me.cboIDJurusan.TabIndex = 8
        Me.cboIDJurusan.Visible = False
        '
        'Button3
        '
        Me.Button3.Image = Global.LPK_Cipta_Tungga_Indonesia.My.Resources.Resources.Purchase_Order_50px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(531, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(239, 72)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Bayar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.LPK_Cipta_Tungga_Indonesia.My.Resources.Resources.News_50px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(531, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(239, 72)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Laporan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.LPK_Cipta_Tungga_Indonesia.My.Resources.Resources.Schedule_50px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(531, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 72)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cetak Jadwal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblStatusPeserta
        '
        Me.lblStatusPeserta.AutoSize = True
        Me.lblStatusPeserta.Location = New System.Drawing.Point(105, 98)
        Me.lblStatusPeserta.Name = "lblStatusPeserta"
        Me.lblStatusPeserta.Size = New System.Drawing.Size(12, 15)
        Me.lblStatusPeserta.TabIndex = 6
        Me.lblStatusPeserta.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 300)
        Me.DataGridView1.TabIndex = 5
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(614, 42)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(143, 23)
        Me.txtBayar.TabIndex = 4
        '
        'lblTotalBayar
        '
        Me.lblTotalBayar.AutoSize = True
        Me.lblTotalBayar.Location = New System.Drawing.Point(641, 71)
        Me.lblTotalBayar.Name = "lblTotalBayar"
        Me.lblTotalBayar.Size = New System.Drawing.Size(12, 15)
        Me.lblTotalBayar.TabIndex = 3
        Me.lblTotalBayar.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(613, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Rp."
        '
        'cboIDPeserta
        '
        Me.cboIDPeserta.FormattingEnabled = True
        Me.cboIDPeserta.Location = New System.Drawing.Point(101, 68)
        Me.cboIDPeserta.Name = "cboIDPeserta"
        Me.cboIDPeserta.Size = New System.Drawing.Size(137, 23)
        Me.cboIDPeserta.TabIndex = 2
        Me.cboIDPeserta.Text = "Pilih ID Peserta :"
        '
        'lblNoFaktur
        '
        Me.lblNoFaktur.AutoSize = True
        Me.lblNoFaktur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoFaktur.Location = New System.Drawing.Point(104, 19)
        Me.lblNoFaktur.Name = "lblNoFaktur"
        Me.lblNoFaktur.Size = New System.Drawing.Size(12, 15)
        Me.lblNoFaktur.TabIndex = 0
        Me.lblNoFaktur.Text = "-"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(613, 20)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(12, 15)
        Me.lblAdmin.TabIndex = 0
        Me.lblAdmin.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Status Peserta  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID Peserta         :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Bayar              :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(267, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tutor                    :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(267, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Jurusan diambil  :"
        '
        'lblTutor
        '
        Me.lblTutor.AutoSize = True
        Me.lblTutor.Location = New System.Drawing.Point(372, 71)
        Me.lblTutor.Name = "lblTutor"
        Me.lblTutor.Size = New System.Drawing.Size(12, 15)
        Me.lblTutor.TabIndex = 0
        Me.lblTutor.Text = "-"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(371, 47)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(12, 15)
        Me.lblJurusan.TabIndex = 0
        Me.lblJurusan.Text = "-"
        '
        'lblNamaPeserta
        '
        Me.lblNamaPeserta.AutoSize = True
        Me.lblNamaPeserta.Location = New System.Drawing.Point(371, 20)
        Me.lblNamaPeserta.Name = "lblNamaPeserta"
        Me.lblNamaPeserta.Size = New System.Drawing.Size(12, 15)
        Me.lblNamaPeserta.TabIndex = 0
        Me.lblNamaPeserta.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(267, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nama Peserta     :"
        '
        'lblKembalian
        '
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(640, 150)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(18, 20)
        Me.lblKembalian.TabIndex = 0
        Me.lblKembalian.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(576, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Rp."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(611, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Kembalian     :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(525, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Bayar     :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(528, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Admin           :"
        '
        'DTPPembayaran
        '
        Me.DTPPembayaran.AutoSize = True
        Me.DTPPembayaran.Location = New System.Drawing.Point(104, 45)
        Me.DTPPembayaran.Name = "DTPPembayaran"
        Me.DTPPembayaran.Size = New System.Drawing.Size(12, 15)
        Me.DTPPembayaran.TabIndex = 0
        Me.DTPPembayaran.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tanggal            :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No Faktur         :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(782, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(297, 17)
        Me.ToolStripStatusLabel1.Text = "LPK Cipta Tungga Indonesia v1.0 ( beta ) - Pembayaran"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LPK_Cipta_Tungga_Indonesia.My.Resources.Resources.Withdrawal_100px
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 94)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(782, 555)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LPK CTP - Transaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblNoFaktur As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatusPeserta As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboIDPeserta As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTutor As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents lblNamaPeserta As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblKembalian As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DTPPembayaran As Label
    Friend WithEvents cboIDTutor As ComboBox
    Friend WithEvents cboIDJurusan As ComboBox
End Class
