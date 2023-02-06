using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (User.login(textBox_Mail.Text, textBox_MatKhau.Text))
            {
                MessageBox.Show("Chào mừng " + textBox_Mail.Text, "ĐĂNG NHẬP THÀNH CÔNG!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra thông tin mail đăng nhập, mật khẩu và thử lại...", "KHÔNG THỂ ĐĂNG NHẬP!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {

        }
        private void button_hint_MouseHover_1(object sender, EventArgs e)
        {
            textBox_ThongBao.Visible = true;
        }

        private void button_hint_MouseLeave(object sender, EventArgs e)
        {
            textBox_ThongBao.Visible = false;
        }

        private void pictureBox_ShowPassword_MouseHover(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = false;
            pictureBox_ShowPassword.BackColor = Color.PaleGreen;
        }

        private void pictureBox_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = true;
            pictureBox_ShowPassword.BackColor = Color.Gray;
        }

        private void button_QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMatKhauForm quenMatKhauForm = new QuenMatKhauForm();
            quenMatKhauForm.Show();
        }
    }
}
