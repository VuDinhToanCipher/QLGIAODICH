namespace QLGIAODICH
{
    partial class NguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearchStk = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            txbNgaysSinh = new TextBox();
            txbCCCD = new TextBox();
            label6 = new Label();
            txbLoai = new TextBox();
            txbEmail = new TextBox();
            txbDiaChi = new TextBox();
            txbSDT = new TextBox();
            txbHoTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dtNguoidung = new DataGridView();
            groupBox1 = new GroupBox();
            dtTaikhoan = new DataGridView();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            pnThemTK = new Panel();
            btnXacNhan = new Button();
            label11 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Addcard = new Button();
            btnAddAccount = new Button();
            panel3 = new Panel();
            button1 = new Button();
            tbMK = new TextBox();
            txbTentaikhoan = new TextBox();
            label9 = new Label();
            label10 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtNguoidung).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTaikhoan).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            pnThemTK.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(39, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa tài khoản";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(408, 32);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchStk
            // 
            txtSearchStk.Location = new Point(66, 32);
            txtSearchStk.Name = "txtSearchStk";
            txtSearchStk.Size = new Size(272, 27);
            txtSearchStk.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txbNgaysSinh);
            panel2.Controls.Add(txbCCCD);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txbLoai);
            panel2.Controls.Add(txbEmail);
            panel2.Controls.Add(txbDiaChi);
            panel2.Controls.Add(txbSDT);
            panel2.Controls.Add(txbHoTen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(547, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 779);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 195);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 36;
            label7.Text = "Ngày sinh:";
            // 
            // txbNgaysSinh
            // 
            txbNgaysSinh.Location = new Point(6, 237);
            txbNgaysSinh.Name = "txbNgaysSinh";
            txbNgaysSinh.Size = new Size(383, 27);
            txbNgaysSinh.TabIndex = 35;
            // 
            // txbCCCD
            // 
            txbCCCD.Location = new Point(3, 316);
            txbCCCD.Name = "txbCCCD";
            txbCCCD.Size = new Size(386, 27);
            txbCCCD.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 283);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 33;
            label6.Text = "CCCD:";
            // 
            // txbLoai
            // 
            txbLoai.Location = new Point(3, 535);
            txbLoai.Name = "txbLoai";
            txbLoai.Size = new Size(383, 27);
            txbLoai.TabIndex = 32;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(3, 460);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(383, 27);
            txbEmail.TabIndex = 31;
            // 
            // txbDiaChi
            // 
            txbDiaChi.Location = new Point(3, 388);
            txbDiaChi.Name = "txbDiaChi";
            txbDiaChi.Size = new Size(383, 27);
            txbDiaChi.TabIndex = 30;
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(3, 148);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(383, 27);
            txbSDT.TabIndex = 29;
            // 
            // txbHoTen
            // 
            txbHoTen.Location = new Point(6, 73);
            txbHoTen.Name = "txbHoTen";
            txbHoTen.Size = new Size(383, 27);
            txbHoTen.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 501);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 27;
            label5.Text = "Loại người dùng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 428);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 26;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 356);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 25;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 24;
            label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 23;
            label1.Text = "Họ và Tên :";
            // 
            // button3
            // 
            button3.Location = new Point(258, 577);
            button3.Name = "button3";
            button3.Size = new Size(128, 44);
            button3.TabIndex = 22;
            button3.Text = "Sửa thông tin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dtNguoidung
            // 
            dtNguoidung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtNguoidung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtNguoidung.Location = new Point(0, 26);
            dtNguoidung.Name = "dtNguoidung";
            dtNguoidung.RowHeadersWidth = 51;
            dtNguoidung.Size = new Size(523, 99);
            dtNguoidung.TabIndex = 0;
            dtNguoidung.CellContentClick += dtNguoidung_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtNguoidung);
            groupBox1.Location = new Point(45, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Người dùng";
            // 
            // dtTaikhoan
            // 
            dtTaikhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtTaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTaikhoan.Location = new Point(3, 23);
            dtTaikhoan.Name = "dtTaikhoan";
            dtTaikhoan.RowHeadersWidth = 51;
            dtTaikhoan.Size = new Size(520, 169);
            dtTaikhoan.TabIndex = 0;
            dtTaikhoan.CellContentClick += dtTaikhoan_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtTaikhoan);
            groupBox2.Location = new Point(39, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(529, 198);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tài khoản";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pnThemTK);
            panel1.Controls.Add(Addcard);
            panel1.Controls.Add(btnAddAccount);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchStk);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 779);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pnThemTK
            // 
            pnThemTK.Controls.Add(btnXacNhan);
            pnThemTK.Controls.Add(label11);
            pnThemTK.Controls.Add(label8);
            pnThemTK.Controls.Add(textBox2);
            pnThemTK.Controls.Add(textBox1);
            pnThemTK.Location = new Point(12, 547);
            pnThemTK.Name = "pnThemTK";
            pnThemTK.Size = new Size(529, 152);
            pnThemTK.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(396, 85);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(130, 39);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 74);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 3;
            label11.Text = "Thêm số dư:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 7);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 2;
            label8.Text = "Tên tài khoản:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 0;
            // 
            // Addcard
            // 
            Addcard.BackColor = Color.Turquoise;
            Addcard.Location = new Point(398, 475);
            Addcard.Name = "Addcard";
            Addcard.Size = new Size(146, 46);
            Addcard.TabIndex = 7;
            Addcard.Text = "Thêm thẻ";
            Addcard.UseVisualStyleBackColor = false;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.LimeGreen;
            btnAddAccount.Location = new Point(208, 475);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(147, 46);
            btnAddAccount.TabIndex = 6;
            btnAddAccount.Text = "Thêm tài khoản";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(tbMK);
            panel3.Controls.Add(txbTentaikhoan);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(976, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 779);
            panel3.TabIndex = 34;
            // 
            // button1
            // 
            button1.Location = new Point(199, 228);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 43;
            button1.Text = "Sửa tài khoản";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbMK
            // 
            tbMK.Location = new Point(6, 159);
            tbMK.Name = "tbMK";
            tbMK.Size = new Size(313, 27);
            tbMK.TabIndex = 39;
            // 
            // txbTentaikhoan
            // 
            txbTentaikhoan.Location = new Point(6, 90);
            txbTentaikhoan.Name = "txbTentaikhoan";
            txbTentaikhoan.Size = new Size(313, 27);
            txbTentaikhoan.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 136);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 34;
            label9.Text = "Mật khẩu:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 51);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 33;
            label10.Text = "Tên Tài khoản: :";
            // 
            // NguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 779);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NguoiDung";
            Text = "NguoiDung";
            Load += NguoiDung_Load;
            SizeChanged += NguoiDung_SizeChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtNguoidung).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtTaikhoan).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnThemTK.ResumeLayout(false);
            pnThemTK.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearchStk;
        private Button btnDelete;
        private Button btnSearch;
        private Panel panel2;
        private TextBox txbLoai;
        private TextBox txbEmail;
        private TextBox txbDiaChi;
        private TextBox txbSDT;
        private TextBox txbHoTen;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private DataGridView dtNguoidung;
        private GroupBox groupBox1;
        private DataGridView dtTaikhoan;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel3;
        private Button button1;
        private TextBox tbMK;
        private TextBox txbTentaikhoan;
        private Label label9;
        private Label label10;
        private TextBox txbCCCD;
        private Label label6;
        private Label label7;
        private TextBox txbNgaysSinh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Addcard;
        private Button btnAddAccount;
        private Panel pnThemTK;
        private TextBox textBox1;
        private Button btnXacNhan;
        private Label label11;
        private Label label8;
        private TextBox textBox2;
    }
}