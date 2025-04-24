namespace QLGIAODICH
{
    partial class RutTien
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
            pn1 = new Panel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtTk = new TextBox();
            cbTimkiem = new ComboBox();
            txtTaiKhoan = new TextBox();
            btnSearch = new Button();
            dtTK = new DataGridView();
            groupBox2 = new GroupBox();
            btnSMS = new Button();
            textBox2 = new TextBox();
            txtSoTien = new TextBox();
            btnGui = new Button();
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
            label6 = new Label();
            pn1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTK).BeginInit();
            groupBox2.SuspendLayout();
            pn2.SuspendLayout();
            SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = Color.LightSteelBlue;
            pn1.Controls.Add(groupBox1);
            pn1.Controls.Add(groupBox2);
            pn1.Location = new Point(-5, 0);
            pn1.Name = "pn1";
            pn1.Size = new Size(672, 560);
            pn1.TabIndex = 34;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTk);
            groupBox1.Controls.Add(cbTimkiem);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(dtTK);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 278);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 230);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 9;
            label2.Text = "Tài khoản được chọn";
            // 
            // txtTk
            // 
            txtTk.Enabled = false;
            txtTk.Location = new Point(382, 224);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(226, 34);
            txtTk.TabIndex = 8;
            // 
            // cbTimkiem
            // 
            cbTimkiem.FormattingEnabled = true;
            cbTimkiem.Items.AddRange(new object[] { "Căn Cước", "Số Tài Khoản" });
            cbTimkiem.Location = new Point(308, 45);
            cbTimkiem.Name = "cbTimkiem";
            cbTimkiem.Size = new Size(153, 36);
            cbTimkiem.TabIndex = 7;
            cbTimkiem.Text = "Số Tài Khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(6, 47);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(282, 34);
            txtTaiKhoan.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightBlue;
            btnSearch.Image = Properties.Resources.Search;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(475, 44);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 36);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtTK
            // 
            dtTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTK.Location = new Point(6, 107);
            dtTK.Name = "dtTK";
            dtTK.RowHeadersWidth = 51;
            dtTK.Size = new Size(602, 99);
            dtTK.TabIndex = 2;
            dtTK.CellContentClick += dtTK_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnSMS);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(txtSoTien);
            groupBox2.Controls.Add(btnGui);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(9, 312);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(660, 228);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xác nhận";
            // 
            // btnSMS
            // 
            btnSMS.Font = new Font("Segoe UI", 10.8F);
            btnSMS.Location = new Point(420, 68);
            btnSMS.Name = "btnSMS";
            btnSMS.Size = new Size(168, 34);
            btnSMS.TabIndex = 13;
            btnSMS.Text = "Mã xác nhận";
            btnSMS.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 34);
            textBox2.TabIndex = 11;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(130, 137);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(255, 34);
            txtSoTien.TabIndex = 4;
            txtSoTien.TextChanged += txtSoTien_TextChanged;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.PaleGreen;
            btnGui.Location = new Point(420, 129);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(168, 43);
            btnGui.TabIndex = 5;
            btnGui.Text = "Xác nhận";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
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
            pn2.Location = new Point(673, 0);
            pn2.Name = "pn2";
            pn2.Size = new Size(521, 540);
            pn2.TabIndex = 35;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.Location = new Point(376, 462);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(129, 48);
            btnExport.TabIndex = 45;
            btnExport.Text = "Xuất  biên lai";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F);
            lbTime.Location = new Point(329, 236);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(0, 28);
            lbTime.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(115, 236);
            label9.Name = "label9";
            label9.Size = new Size(107, 28);
            label9.TabIndex = 43;
            label9.Text = "Thời   gian:";
            // 
            // lbEmployee
            // 
            lbEmployee.AutoSize = true;
            lbEmployee.Font = new Font("Segoe UI", 12F);
            lbEmployee.Location = new Point(329, 290);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(0, 28);
            lbEmployee.TabIndex = 42;
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Font = new Font("Segoe UI", 12F);
            lblTransactionAmount.Location = new Point(329, 184);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(0, 28);
            lblTransactionAmount.TabIndex = 41;
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new Font("Segoe UI", 12F);
            lbSTK.Location = new Point(329, 131);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new Size(0, 28);
            lbSTK.TabIndex = 40;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F);
            lbUserName.Location = new Point(329, 77);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(0, 28);
            lbUserName.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(115, 290);
            label5.Name = "label5";
            label5.Size = new Size(190, 28);
            label5.TabIndex = 38;
            label5.Text = "Nhân viên thực hiện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(115, 184);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 37;
            label4.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(115, 131);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 36;
            label3.Text = "Số tài khoản:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(115, 77);
            label.Name = "label";
            label.Size = new Size(153, 28);
            label.TabIndex = 35;
            label.Text = "Tên người dùng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 34;
            label1.Text = "BIÊN LAI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 140);
            label6.Name = "label6";
            label6.Size = new Size(73, 28);
            label6.TabIndex = 14;
            label6.Text = "Số tiền";
            // 
            // RutTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 552);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Name = "RutTien";
            Text = "RutTien";
            Load += RutTien_Load;
            pn1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtTK).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pn2.ResumeLayout(false);
            pn2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pn1;
        private GroupBox groupBox1;
        private TextBox txtTaiKhoan;
        private Button btnSearch;
        private DataGridView dtTK;
        private GroupBox groupBox2;
        private TextBox txtSoTien;
        private Button btnGui;
        private Button btnSMS;
        private TextBox textBox2;
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
        private ComboBox cbTimkiem;
        private Label label2;
        private TextBox txtTk;
        private Label label6;
    }
}