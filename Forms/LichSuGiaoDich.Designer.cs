namespace QLGIAODICH
{
    partial class LichSuGiaoDich
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
            pnData = new Panel();
            groupBox1 = new GroupBox();
            dtLichsu = new DataGridView();
            pnThongtin = new Panel();
            groupBox2 = new GroupBox();
            cbReport = new ComboBox();
            lbSTKN = new Label();
            label9 = new Label();
            btnExport = new Button();
            lbTime = new Label();
            lbSotien = new Label();
            lbType = new Label();
            lbSTK = new Label();
            lbName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pnThanhcongcu = new Panel();
            btnReload = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            btnSearch = new Button();
            textBox1 = new TextBox();
            pnData.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtLichsu).BeginInit();
            pnThongtin.SuspendLayout();
            groupBox2.SuspendLayout();
            pnThanhcongcu.SuspendLayout();
            SuspendLayout();
            // 
            // pnData
            // 
            pnData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnData.BackColor = Color.Ivory;
            pnData.Controls.Add(groupBox1);
            pnData.Location = new Point(0, 284);
            pnData.Name = "pnData";
            pnData.Size = new Size(591, 451);
            pnData.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtLichsu);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 451);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "LỊCH SỬ GIAO DỊCH";
            // 
            // dtLichsu
            // 
            dtLichsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtLichsu.Dock = DockStyle.Fill;
            dtLichsu.Location = new Point(3, 23);
            dtLichsu.Name = "dtLichsu";
            dtLichsu.RowHeadersWidth = 51;
            dtLichsu.Size = new Size(585, 425);
            dtLichsu.TabIndex = 0;
            dtLichsu.CellContentClick += dtLichsu_CellContentClick;
            // 
            // pnThongtin
            // 
            pnThongtin.Anchor = AnchorStyles.None;
            pnThongtin.BackColor = SystemColors.AppWorkspace;
            pnThongtin.Controls.Add(groupBox2);
            pnThongtin.Location = new Point(591, 237);
            pnThongtin.Name = "pnThongtin";
            pnThongtin.Size = new Size(572, 448);
            pnThongtin.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(cbReport);
            groupBox2.Controls.Add(lbSTKN);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnExport);
            groupBox2.Controls.Add(lbTime);
            groupBox2.Controls.Add(lbSotien);
            groupBox2.Controls.Add(lbType);
            groupBox2.Controls.Add(lbSTK);
            groupBox2.Controls.Add(lbName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(572, 448);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN CHI  TIẾT";
            // 
            // cbReport
            // 
            cbReport.FormattingEnabled = true;
            cbReport.Items.AddRange(new object[] { "Lịch sử giao dịch", "Thông tin CT" });
            cbReport.Location = new Point(448, 368);
            cbReport.Name = "cbReport";
            cbReport.Size = new Size(124, 28);
            cbReport.TabIndex = 13;
            // 
            // lbSTKN
            // 
            lbSTKN.AutoSize = true;
            lbSTKN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSTKN.Location = new Point(253, 185);
            lbSTKN.Name = "lbSTKN";
            lbSTKN.Size = new Size(76, 28);
            lbSTKN.TabIndex = 12;
            lbSTKN.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 185);
            label9.Name = "label9";
            label9.Size = new Size(173, 28);
            label9.TabIndex = 11;
            label9.Text = "Số tài khoản nhận:";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(448, 402);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(124, 46);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất báo cáo";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += button1_Click;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTime.Location = new Point(253, 371);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(76, 28);
            lbTime.TabIndex = 10;
            lbTime.Text = "label13";
            // 
            // lbSotien
            // 
            lbSotien.AutoSize = true;
            lbSotien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSotien.Location = new Point(253, 304);
            lbSotien.Name = "lbSotien";
            lbSotien.Size = new Size(76, 28);
            lbSotien.TabIndex = 9;
            lbSotien.Text = "label12";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbType.Location = new Point(253, 244);
            lbType.Name = "lbType";
            lbType.Size = new Size(76, 28);
            lbType.TabIndex = 8;
            lbType.Text = "label11";
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSTK.Location = new Point(253, 121);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new Size(76, 28);
            lbSTK.TabIndex = 7;
            lbSTK.Text = "label10";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(253, 59);
            lbName.Name = "lbName";
            lbName.Size = new Size(65, 28);
            lbName.TabIndex = 6;
            lbName.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 371);
            label8.Name = "label8";
            label8.Size = new Size(183, 28);
            label8.TabIndex = 4;
            label8.Text = "Thời gian giao dịch:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 304);
            label7.Name = "label7";
            label7.Size = new Size(77, 28);
            label7.TabIndex = 3;
            label7.Text = "Số tiền:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 244);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 2;
            label6.Text = "Loại giao dịch:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 121);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 1;
            label5.Text = "Số tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 59);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 0;
            label4.Text = "Tên chủ khoản:";
            // 
            // pnThanhcongcu
            // 
            pnThanhcongcu.BackColor = SystemColors.ControlLight;
            pnThanhcongcu.Controls.Add(btnReload);
            pnThanhcongcu.Controls.Add(label3);
            pnThanhcongcu.Controls.Add(label2);
            pnThanhcongcu.Controls.Add(label1);
            pnThanhcongcu.Controls.Add(dateTimePicker2);
            pnThanhcongcu.Controls.Add(dateTimePicker1);
            pnThanhcongcu.Controls.Add(btnSearch);
            pnThanhcongcu.Controls.Add(textBox1);
            pnThanhcongcu.Location = new Point(12, 12);
            pnThanhcongcu.Name = "pnThanhcongcu";
            pnThanhcongcu.Size = new Size(1139, 167);
            pnThanhcongcu.TabIndex = 2;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.Reload;
            btnReload.ImageAlign = ContentAlignment.MiddleLeft;
            btnReload.Location = new Point(3, 129);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(131, 35);
            btnReload.TabIndex = 7;
            btnReload.Text = "Tải lại";
            btnReload.TextAlign = ContentAlignment.MiddleRight;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 6;
            label3.Text = "Số tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 98);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 4;
            label1.Text = "Ngày bắt đầu:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(172, 98);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(266, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.Search;
            btnSearch.Location = new Point(462, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 113);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TextAlign = ContentAlignment.BottomCenter;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(172, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 42);
            textBox1.TabIndex = 0;
            // 
            // LichSuGiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 735);
            Controls.Add(pnThanhcongcu);
            Controls.Add(pnThongtin);
            Controls.Add(pnData);
            Name = "LichSuGiaoDich";
            Text = "LichSuGiaoDich";
            Load += LichSuGiaoDich_Load;
            SizeChanged += LichSuGiaoDich_SizeChanged;
            pnData.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtLichsu).EndInit();
            pnThongtin.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnThanhcongcu.ResumeLayout(false);
            pnThanhcongcu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnData;
        private Panel pnThongtin;
        private Panel pnThanhcongcu;
        private GroupBox groupBox1;
        private DataGridView dtLichsu;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button btnReload;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnExport;
        private Label lbTime;
        private Label lbSotien;
        private Label lbType;
        private Label lbSTK;
        private Label lbName;
        private Label lbSTKN;
        private Label label9;
        private ComboBox cbReport;
    }
}