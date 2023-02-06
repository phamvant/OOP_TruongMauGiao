using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TruongMauGiao
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        #region Hide/Show password textBox
        private void pictureBox_SowPassword1_MouseHover(object sender, EventArgs e)
        {
            textBox_OldPassword.UseSystemPasswordChar = false;
            pictureBox_ShowPassword1.BackColor = Color.PaleGreen;
        }
        private void pictureBox_SowPassword1_MouseLeave(object sender, EventArgs e)
        {
            textBox_OldPassword.UseSystemPasswordChar = true;
            pictureBox_ShowPassword1.BackColor = Color.Gray;
        }

        private void pictureBox_ShowPassword2_MouseHover(object sender, EventArgs e)
        {
            textBox_NewPassword.UseSystemPasswordChar = false;
            pictureBox_ShowPassword2.BackColor = Color.PaleGreen;
        }

        private void pictureBox_ShowPassword2_MouseLeave(object sender, EventArgs e)
        {
            textBox_NewPassword.UseSystemPasswordChar = true;
            pictureBox_ShowPassword2.BackColor = Color.Gray;
        }

        private void pictureBox_ShowPassword3_MouseHover(object sender, EventArgs e)
        {
            textBox_NewPasswordRetype.UseSystemPasswordChar = false;
            pictureBox_ShowPassword3.BackColor = Color.PaleGreen;
        }

        private void pictureBox_ShowPassword3_MouseLeave(object sender, EventArgs e)
        {
            textBox_NewPasswordRetype.UseSystemPasswordChar = true;
            pictureBox_ShowPassword3.BackColor = Color.Gray;
        }
        #endregion
        private bool isVerified()
        {
            if (String.IsNullOrEmpty(textBox_OldPassword.Text) || String.IsNullOrEmpty(textBox_NewPassword.Text) || String.IsNullOrEmpty(textBox_NewPasswordRetype.Text))
                return false;
            else
                return true;
        }

        private bool isMatch(string stringA, string stringB)
        {
            if (stringA == stringB)
                return true;
            else
                return false;
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            if(isVerified())
            {
                if (isMatch(textBox_NewPassword.Text, textBox_NewPasswordRetype.Text))
                {
                    string a = SHA256Encryptor.encrypt(textBox_OldPassword.Text);
                    string b = LoggedInUser.getLoggedInUserInfo().password;
                    bool test = isMatch(SHA256Encryptor.encrypt(textBox_OldPassword.Text), LoggedInUser.getLoggedInUserInfo().password);
                    if (isMatch(SHA256Encryptor.encrypt(textBox_OldPassword.Text), LoggedInUser.getLoggedInUserInfo().password))
                    {
                        if (LoggedInUser.getLoggedInUser().changePassword(textBox_NewPassword.Text))
                        {
                            MessageBox.Show("Đã đổi mật khẩu", "ĐỔI MẬT KHẨU THÀNH CÔNG", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Không thể đổi mật khẩu, đã có lỗi xảy ra. Xin hãy thử lại sau", "ĐỔI MẬT KHẨU THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Không thể đổi mật khẩu, mật khẩu cũ của tài khoản không trùng khớp", "ĐỔI MẬT KHẨU THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Xin hãy kiểm tra lại, 2 lần nhập mật khẩu mới không trùng khớp", "THÔNG TIN KHÔNG KHỚP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
