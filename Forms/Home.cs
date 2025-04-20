using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QLGIAODICH.Helper;
using QLGIAODICH.Models;
using QLGIAODICH.Services;

namespace QLGIAODICH
{
    public partial class formMain : Form
    {
        private DangKi DangKi;
        private GiaoDich giaoDich;
        private LichSuGiaoDich lichSuGiaoDich;
        private NguoiDung nguoiDung;
        private Form[] openForms = new Form[4];
        CloseandOpenForms OpenClose;
        private string[] imgpath = new string[]
        {
            "D:\\C#\\QLGIAODICH\\QLGIAODICH\\Resources\\home1.jpg",
            "D:\\C#\\QLGIAODICH\\QLGIAODICH\\Resources\\home2.jpg",
            "D:\\C#\\QLGIAODICH\\QLGIAODICH\\Resources\\home3.jpg"
        };
        int currenindex = 0;
        public formMain()
        {
            DangKi = new DangKi();
            giaoDich = new GiaoDich();
            lichSuGiaoDich = new LichSuGiaoDich();
            nguoiDung = new NguoiDung();
            OpenClose = new CloseandOpenForms();
            InitializeComponent();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            //Hieu chinh 
            lbTenNhanVien.Text = Session.TenNhanVien;
            lb1.BackColor = Color.Transparent;
            lbTenNhanVien.BackColor = Color.Transparent;
            ConfiguImage.resizeimg_inbutton(btnTrangchu, 64, 64);
            ConfiguImage.resizeimg_inbutton(BtnGiaoDich, 60, 60);
            ConfiguImage.resizeimg_inbutton(btnSuaThongTin, 64, 64);
            ConfiguImage.resizeimg_inbutton(btnTruyVanBienLai, 64, 63);
            ConfiguImage.resizeimg_inbutton(btnDangki, 64, 64);
            ConfiguImage.resizeimg_inbutton(btnUpdateQTV, 30, 30);
            //Chuyen canh anh
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            LoadImage(); // Load ảnh đầu tiên
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất?",
            "Xác nhận đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login_MBBank_Crack login = (Login_MBBank_Crack)Application.OpenForms["Login_MBBank_Crack"]!;
                if (login != null)
                {
                    login.Show();
                }
                else
                {
                    Login_MBBank_Crack loginn = new Login_MBBank_Crack();
                    loginn.Show();
                }
            }
        }
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login_MBBank_Crack login = (Login_MBBank_Crack)Application.OpenForms["Login_MBBank_Crack"]!;
            if (login != null)
            {

                login.Close();
            }
            else
            {
                Login_MBBank_Crack loginn = new Login_MBBank_Crack();
                loginn.Close();
            }
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            OpenClose.Closeform(openForms);
            this.BringToFront(); // Đảm bảo form chính luôn được đưa ra phía trước
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            DangKi = new DangKi();
            OpenClose.Openform(openForms, DangKi, 0, pnlData); // Mở form DangKi ở vị trí index 0
        }

        private void BtnGiaoDich_Click(object sender, EventArgs e)
        {
            giaoDich = new GiaoDich();
            OpenClose.Openform(openForms, giaoDich, 1, pnlData); // Mở form GiaoDich ở vị trí index 1
        }

        private void btnTruyVanBienLai_Click(object sender, EventArgs e)
        {
            lichSuGiaoDich = new LichSuGiaoDich();
            OpenClose.Openform(openForms, lichSuGiaoDich, 2, pnlData); // Mở form LichSuGiaoDich ở vị trí index 2
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            nguoiDung = new NguoiDung();
            OpenClose.Openform(openForms, nguoiDung, 3, pnlData); // Mở form NguoiDung ở vị trí index 3
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            currenindex++;
            if (currenindex >= imgpath.Length)
            {
                currenindex = 0;
            }

            LoadImage(); // Load ảnh tiếp theo
        }

        private void LoadImage()
        {
            try
            {
                // Giải phóng ảnh cũ nếu có
                if (pichome.Image != null)
                {
                    var oldImage = pichome.Image;
                    pichome.Image = null;
                    oldImage.Dispose();
                }

                // Dùng clone để tránh giữ file
                using (Image img = Image.FromFile(imgpath[currenindex]))
                {
                    pichome.Image = (Image)img.Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }
    }
}
