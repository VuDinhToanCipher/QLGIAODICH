namespace QLGIAODICH
{
    partial class Login_MBBank_Crack
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
            lb1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = SystemColors.ControlLightLight;
            lb1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.OrangeRed;
            lb1.Location = new Point(286, 60);
            lb1.Name = "lb1";
            lb1.Size = new Size(199, 37);
            lb1.TabIndex = 0;
            lb1.Text = "ĐĂNG NHẬP";
            lb1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb2
            // 
            lb2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb2.ForeColor = Color.Black;
            lb2.Location = new Point(63, 134);
            lb2.Name = "lb2";
            lb2.Size = new Size(176, 39);
            lb2.TabIndex = 1;
            lb2.Text = "Tên đăng nhập:";
            // 
            // lb3
            // 
            lb3.BackColor = SystemColors.ButtonHighlight;
            lb3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb3.ForeColor = Color.Black;
            lb3.Location = new Point(107, 207);
            lb3.Name = "lb3";
            lb3.Size = new Size(119, 42);
            lb3.TabIndex = 2;
            lb3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Location = new Point(254, 138);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(329, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(254, 212);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(329, 27);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 273);
            button1.Name = "button1";
            button1.Size = new Size(153, 61);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(332, 359);
            button2.Name = "button2";
            button2.Size = new Size(153, 61);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login_MBBank_Crack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(lb1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login_MBBank_Crack";
            Text = "Login_MBBank_Crack";
            FormClosing += Login_MBBank_Crack_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Label lb2;
        private Label lb3;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button button1;
        private Button button2;
    }
}