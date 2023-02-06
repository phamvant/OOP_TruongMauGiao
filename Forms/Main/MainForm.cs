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
    public partial class MainForm : Form
    {
        /*
        //Yêu cầu người dùng chấp thuận khi muốn đóng form Main
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đóng ứng dụng", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //Yêu cầu người dùng chấp thuận khi muốn đóng form Main
        */

        public MainForm()
        {
            InitializeComponent();
        }
        private void thêmHọcSinhMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfoForm studentform = new StudentInfoForm();
            studentform.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList studentlist = new StudentList();
            studentlist.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo loggedInUserInfo = LoggedInUser.getLoggedInUserInfo();
            UserInfoForm accountInfoForm = new UserInfoForm(loggedInUserInfo);
            accountInfoForm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm doiMatKhauForm = new ChangePasswordForm();
            doiMatKhauForm.Show();
        }

        private void thêmLớpHọcMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassInfoForm classInfoForm = new ClassInfoForm();
            classInfoForm.Show();
        }

        private void danhSáchLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassListForm classListForm = new ClassListForm();
            classListForm.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();
            userListForm.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm();
            userInfoForm.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongForm phanCongForm = new PhanCongForm();
            phanCongForm.Show();
        }

        private void danhSáchPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongList phanCongList = new PhanCongList();
            phanCongList.Show();
        }
    }
}
