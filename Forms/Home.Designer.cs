namespace QLGIAODICH
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMenu = new Panel();
            btnDangki = new Button();
            btnUpdateQTV = new Button();
            btnLogout = new Button();
            BtnGiaoDich = new Button();
            btnTruyVanBienLai = new Button();
            btnSuaThongTin = new Button();
            btnTrangchu = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnlData = new Panel();
            pichome = new PictureBox();
            pnlOperation = new Panel();
            dtpkMain = new DateTimePicker();
            lbTenNhanVien = new Label();
            lb1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pichome).BeginInit();
            pnlOperation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.MenuHighlight;
            pnlMenu.Controls.Add(btnDangki);
            pnlMenu.Controls.Add(btnUpdateQTV);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(BtnGiaoDich);
            pnlMenu.Controls.Add(btnTruyVanBienLai);
            pnlMenu.Controls.Add(btnSuaThongTin);
            pnlMenu.Controls.Add(btnTrangchu);
            pnlMenu.Controls.Add(pictureBox2);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 765);
            pnlMenu.TabIndex = 0;
            // 
            // btnDangki
            // 
            btnDangki.Cursor = Cursors.Hand;
            btnDangki.Dock = DockStyle.Top;
            btnDangki.Image = Properties.Resources.Dangki;
            btnDangki.Location = new Point(0, 507);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(250, 103);
            btnDangki.TabIndex = 9;
            btnDangki.Text = "Đăng kí tài khoản";
            btnDangki.TextAlign = ContentAlignment.BottomCenter;
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // btnUpdateQTV
            // 
            btnUpdateQTV.Dock = DockStyle.Bottom;
            btnUpdateQTV.Image = Properties.Resources.Setting;
            btnUpdateQTV.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateQTV.Location = new Point(0, 677);
            btnUpdateQTV.Margin = new Padding(20, 3, 3, 3);
            btnUpdateQTV.Name = "btnUpdateQTV";
            btnUpdateQTV.Size = new Size(250, 47);
            btnUpdateQTV.TabIndex = 8;
            btnUpdateQTV.Text = "Cài đặt quản trị ";
            btnUpdateQTV.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(0, 724);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 41);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // BtnGiaoDich
            // 
            BtnGiaoDich.Dock = DockStyle.Top;
            BtnGiaoDich.Image = Properties.Resources.giaodich;
            BtnGiaoDich.Location = new Point(0, 404);
            BtnGiaoDich.Name = "BtnGiaoDich";
            BtnGiaoDich.Size = new Size(250, 103);
            BtnGiaoDich.TabIndex = 6;
            BtnGiaoDich.Text = "Giao dịch";
            BtnGiaoDich.TextAlign = ContentAlignment.BottomCenter;
            BtnGiaoDich.UseVisualStyleBackColor = true;
            BtnGiaoDich.Click += BtnGiaoDich_Click;
            // 
            // btnTruyVanBienLai
            // 
            btnTruyVanBienLai.Cursor = Cursors.Hand;
            btnTruyVanBienLai.Dock = DockStyle.Top;
            btnTruyVanBienLai.Image = Properties.Resources.Lichsu;
            btnTruyVanBienLai.Location = new Point(0, 301);
            btnTruyVanBienLai.Name = "btnTruyVanBienLai";
            btnTruyVanBienLai.Size = new Size(250, 103);
            btnTruyVanBienLai.TabIndex = 5;
            btnTruyVanBienLai.Text = "Lịch sử giao dịch";
            btnTruyVanBienLai.TextAlign = ContentAlignment.BottomCenter;
            btnTruyVanBienLai.UseVisualStyleBackColor = true;
            btnTruyVanBienLai.Click += btnTruyVanBienLai_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.Cursor = Cursors.Hand;
            btnSuaThongTin.Dock = DockStyle.Top;
            btnSuaThongTin.Image = Properties.Resources.Nguoidung1;
            btnSuaThongTin.Location = new Point(0, 198);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(250, 103);
            btnSuaThongTin.TabIndex = 4;
            btnSuaThongTin.Text = "Người dùng";
            btnSuaThongTin.TextAlign = ContentAlignment.BottomCenter;
            btnSuaThongTin.UseVisualStyleBackColor = true;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnTrangchu
            // 
            btnTrangchu.Cursor = Cursors.Hand;
            btnTrangchu.Dock = DockStyle.Top;
            btnTrangchu.Image = Properties.Resources.Trangchu;
            btnTrangchu.Location = new Point(0, 95);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(250, 103);
            btnTrangchu.TabIndex = 2;
            btnTrangchu.Text = "Trang chủ";
            btnTrangchu.TextAlign = ContentAlignment.BottomCenter;
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.Click += btnTrangchu_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.R;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(377, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlData);
            panel2.Controls.Add(pnlOperation);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 765);
            panel2.TabIndex = 1;
            // 
            // pnlData
            // 
            pnlData.BackColor = SystemColors.ControlLightLight;
            pnlData.Controls.Add(pichome);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 100);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(860, 665);
            pnlData.TabIndex = 1;
            // 
            // pichome
            // 
            pichome.Dock = DockStyle.Fill;
            pichome.Location = new Point(0, 0);
            pichome.Name = "pichome";
            pichome.Size = new Size(860, 665);
            pichome.SizeMode = PictureBoxSizeMode.StretchImage;
            pichome.TabIndex = 0;
            pichome.TabStop = false;
            // 
            // pnlOperation
            // 
            pnlOperation.BackColor = SystemColors.ActiveCaption;
            pnlOperation.Controls.Add(dtpkMain);
            pnlOperation.Controls.Add(lbTenNhanVien);
            pnlOperation.Controls.Add(lb1);
            pnlOperation.Dock = DockStyle.Top;
            pnlOperation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlOperation.Location = new Point(0, 0);
            pnlOperation.Name = "pnlOperation";
            pnlOperation.Size = new Size(860, 100);
            pnlOperation.TabIndex = 0;
            // 
            // dtpkMain
            // 
            dtpkMain.Dock = DockStyle.Left;
            dtpkMain.Format = DateTimePickerFormat.Time;
            dtpkMain.Location = new Point(0, 0);
            dtpkMain.Name = "dtpkMain";
            dtpkMain.Size = new Size(262, 34);
            dtpkMain.TabIndex = 2;
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Location = new Point(115, 72);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(65, 28);
            lbTenNhanVien.TabIndex = 1;
            lbTenNhanVien.Text = "label2";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = SystemColors.MenuHighlight;
            lb1.Dock = DockStyle.Bottom;
            lb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.Location = new Point(0, 72);
            lb1.Name = "lb1";
            lb1.Size = new Size(109, 28);
            lb1.TabIndex = 0;
            lb1.Text = "Nhân viên :";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 765);
            Controls.Add(panel2);
            Controls.Add(pnlMenu);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MBBank_Mod_UnlimitedMoney";
            WindowState = FormWindowState.Maximized;
            FormClosing += formMain_FormClosing;
            Load += formMain_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pichome).EndInit();
            pnlOperation.ResumeLayout(false);
            pnlOperation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel panel2;
        private Panel pnlData;
        private Panel pnlOperation;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnTruyVanBienLai;
        private Button btnSuaThongTin;
        private Button btnTrangchu;
        private Button BtnGiaoDich;
        private Label lbTenNhanVien;
        private Button btnLogout;
        private Button btnUpdateQTV;
        private Button btnDangki;
        private Label lb1;
        private DateTimePicker dtpkMain;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pichome;
    }
}
