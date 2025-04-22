namespace QLGIAODICH
{
    partial class GiaoDich
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
            panel1 = new Panel();
            btnchuyenkhoan = new Button();
            btnruttien = new Button();
            btnGuitien = new Button();
            pnGiaoDich = new Panel();
            pn2 = new Panel();
            btnExport = new Button();
            lbTime = new Label();
            label9 = new Label();
            lbEmployee = new Label();
            lblTransactionAmount = new Label();
            lbSTK = new Label();
            lbUserName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label = new Label();
            label1 = new Label();
            pn1 = new Panel();
            groupBox2 = new GroupBox();
            btnSMS = new Button();
            btnXNID = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtSoTien = new TextBox();
            btnGui = new Button();
            groupBox1 = new GroupBox();
            dtTK = new DataGridView();
            txtTaiKhoan = new TextBox();
            btnSearch = new Button();
            txtSTK = new TextBox();
            btnTim = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            pnGiaoDich.SuspendLayout();
            pn2.SuspendLayout();
            pn1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTK).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnchuyenkhoan);
            panel1.Controls.Add(btnruttien);
            panel1.Controls.Add(btnGuitien);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 161);
            panel1.TabIndex = 0;
            // 
            // btnchuyenkhoan
            // 
            btnchuyenkhoan.Dock = DockStyle.Left;
            btnchuyenkhoan.Image = Properties.Resources.ChuyenKhoan;
            btnchuyenkhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnchuyenkhoan.Location = new Point(415, 0);
            btnchuyenkhoan.Name = "btnchuyenkhoan";
            btnchuyenkhoan.Size = new Size(235, 161);
            btnchuyenkhoan.TabIndex = 2;
            btnchuyenkhoan.Text = "Chuyển khoản";
            btnchuyenkhoan.TextAlign = ContentAlignment.MiddleRight;
            btnchuyenkhoan.UseVisualStyleBackColor = true;
            btnchuyenkhoan.Click += btnchuyenkhoan_Click;
            // 
            // btnruttien
            // 
            btnruttien.Dock = DockStyle.Left;
            btnruttien.Image = Properties.Resources.RutTien;
            btnruttien.ImageAlign = ContentAlignment.MiddleLeft;
            btnruttien.Location = new Point(215, 0);
            btnruttien.Name = "btnruttien";
            btnruttien.Size = new Size(200, 161);
            btnruttien.TabIndex = 1;
            btnruttien.Text = "Rút tiền";
            btnruttien.TextAlign = ContentAlignment.MiddleRight;
            btnruttien.UseVisualStyleBackColor = true;
            btnruttien.Click += btnruttien_Click;
            // 
            // btnGuitien
            // 
            btnGuitien.BackColor = SystemColors.Window;
            btnGuitien.Dock = DockStyle.Left;
            btnGuitien.Image = Properties.Resources.GuiTien;
            btnGuitien.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuitien.Location = new Point(0, 0);
            btnGuitien.Name = "btnGuitien";
            btnGuitien.Size = new Size(215, 161);
            btnGuitien.TabIndex = 0;
            btnGuitien.Text = "Gửi tiền";
            btnGuitien.TextAlign = ContentAlignment.MiddleRight;
            btnGuitien.UseVisualStyleBackColor = false;
            btnGuitien.Click += btnGuitien_Click;
            // 
            // pnGiaoDich
            // 
            pnGiaoDich.Controls.Add(pn2);
            pnGiaoDich.Controls.Add(pn1);
            pnGiaoDich.Dock = DockStyle.Fill;
            pnGiaoDich.Location = new Point(0, 161);
            pnGiaoDich.Name = "pnGiaoDich";
            pnGiaoDich.Size = new Size(1198, 545);
            pnGiaoDich.TabIndex = 1;
            // 
            // pn2
            // 
            pn2.BackColor = Color.LightSteelBlue;
            pn2.Controls.Add(btnExport);
            pn2.Controls.Add(lbTime);
            pn2.Controls.Add(label9);
            pn2.Controls.Add(lbEmployee);
            pn2.Controls.Add(lblTransactionAmount);
            pn2.Controls.Add(lbSTK);
            pn2.Controls.Add(lbUserName);
            pn2.Controls.Add(label5);
            pn2.Controls.Add(label4);
            pn2.Controls.Add(label3);
            pn2.Controls.Add(label);
            pn2.Controls.Add(label1);
            pn2.Location = new Point(703, 3);
            pn2.Name = "pn2";
            pn2.Size = new Size(495, 542);
            pn2.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(336, 477);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(147, 56);
            btnExport.TabIndex = 43;
            btnExport.Text = "Xuất  biên lai";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F);
            lbTime.Location = new Point(371, 255);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(0, 28);
            lbTime.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(81, 255);
            label9.Name = "label9";
            label9.Size = new Size(107, 28);
            label9.TabIndex = 41;
            label9.Text = "Thời   gian:";
            // 
            // lbEmployee
            // 
            lbEmployee.AutoSize = true;
            lbEmployee.Font = new Font("Segoe UI", 12F);
            lbEmployee.Location = new Point(371, 308);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(0, 28);
            lbEmployee.TabIndex = 40;
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Font = new Font("Segoe UI", 12F);
            lblTransactionAmount.Location = new Point(371, 203);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(0, 28);
            lblTransactionAmount.TabIndex = 39;
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new Font("Segoe UI", 12F);
            lbSTK.Location = new Point(371, 150);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new Size(0, 28);
            lbSTK.TabIndex = 38;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F);
            lbUserName.Location = new Point(371, 96);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(0, 28);
            lbUserName.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(81, 308);
            label5.Name = "label5";
            label5.Size = new Size(190, 28);
            label5.TabIndex = 36;
            label5.Text = "Nhân viên thực hiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(81, 203);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 35;
            label4.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 150);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 34;
            label3.Text = "Số tài khoản:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(81, 96);
            label.Name = "label";
            label.Size = new Size(153, 28);
            label.TabIndex = 33;
            label.Text = "Tên người dùng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(285, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 32;
            label1.Text = "BIÊN LAI";
            // 
            // pn1
            // 
            pn1.BackColor = Color.LightSteelBlue;
            pn1.Controls.Add(groupBox2);
            pn1.Controls.Add(groupBox1);
            pn1.Location = new Point(3, 3);
            pn1.Name = "pn1";
            pn1.Size = new Size(694, 542);
            pn1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSMS);
            groupBox2.Controls.Add(btnXNID);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtSoTien);
            groupBox2.Controls.Add(btnGui);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 342);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 200);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số tiền";
            // 
            // btnSMS
            // 
            btnSMS.Font = new Font("Segoe UI", 10.8F);
            btnSMS.Location = new Point(414, 85);
            btnSMS.Name = "btnSMS";
            btnSMS.Size = new Size(173, 29);
            btnSMS.TabIndex = 9;
            btnSMS.Text = "Mã xác nhận";
            btnSMS.UseVisualStyleBackColor = true;
            // 
            // btnXNID
            // 
            btnXNID.Font = new Font("Segoe UI", 10.8F);
            btnXNID.Location = new Point(414, 36);
            btnXNID.Name = "btnXNID";
            btnXNID.Size = new Size(173, 29);
            btnXNID.TabIndex = 8;
            btnXNID.Text = "Xác nhận căn cước";
            btnXNID.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 34);
            textBox1.TabIndex = 6;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(19, 135);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(360, 34);
            txtSoTien.TabIndex = 4;
            txtSoTien.TextChanged += txtSoTien_TextChanged_1;
            txtSoTien.KeyPress += txtSoTien_KeyPress_1;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.PaleGreen;
            btnGui.Font = new Font("Segoe UI", 10.8F);
            btnGui.Location = new Point(414, 130);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(173, 44);
            btnGui.TabIndex = 5;
            btnGui.Text = "Xác nhận";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnRut_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dtTK);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSTK);
            groupBox1.Controls.Add(btnTim);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 319);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài Khoản";
            // 
            // dtTK
            // 
            dtTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTK.Location = new Point(17, 91);
            dtTK.Name = "dtTK";
            dtTK.RowHeadersWidth = 51;
            dtTK.Size = new Size(602, 159);
            dtTK.TabIndex = 5;
            dtTK.CellContentClick += dtTK_CellContentClick_1;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(19, 39);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(255, 34);
            txtTaiKhoan.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Image = Properties.Resources.Search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(471, 30);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 43);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(-179, -44);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(281, 34);
            txtSTK.TabIndex = 0;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(159, -32);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 17);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Căn Cước", "Số Tài Khoản" });
            comboBox1.Location = new Point(280, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 36);
            comboBox1.TabIndex = 6;
            // 
            // GiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 706);
            Controls.Add(pnGiaoDich);
            Controls.Add(panel1);
            Name = "GiaoDich";
            Text = "GiaoDich";
            Load += GiaoDich_Load;
            panel1.ResumeLayout(false);
            pnGiaoDich.ResumeLayout(false);
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            pn1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtTK).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnchuyenkhoan;
        private Button btnruttien;
        private Button btnGuitien;
        private Panel pnGiaoDich;
        private Panel pn2;
        private Button btnExport;
        private Label lbTime;
        private Label label9;
        private Label lbEmployee;
        private Label lblTransactionAmount;
        private Label lbSTK;
        private Label lbUserName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label;
        private Label label1;
        private Panel pn1;
        private GroupBox groupBox2;
        private TextBox txtSoTien;
        private Button btnGui;
        private GroupBox groupBox1;
        private TextBox txtTaiKhoan;
        private Button btnSearch;
        private TextBox txtSTK;
        private Button btnTim;
        private DataGridView dtTK;
        private Button btnSMS;
        private Button btnXNID;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}