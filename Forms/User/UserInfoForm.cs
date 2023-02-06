using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TruongMauGiao
{
    public partial class UserInfoForm : Form
    {
        #region Ham khoi tao
        public UserInfoForm()
        {
            InitializeComponent();
            setupForm();
            modeAdmin();
            modeAdd();
        }

        public UserInfoForm(string userId)
        {
            InitializeComponent();
            setupForm();
            showUserInfoToForm(userId);
            modeAdmin();
            modeUpdate();
        }

        public UserInfoForm(UserInfo userInfo)
        {
            InitializeComponent();
            setupForm();
            showUserInfoToForm(userInfo);
            modeUser();
            modeUpdate();
        }

        #endregion

        #region setup form
        private void setupForm()
        {
            //Setup methods here
        }

        #endregion

        #region Form load and save stuffs
        private void showUserInfoToForm(string userId)
        {
            try
            {
                UserInfo userInfo = new UserInfo(userId);
                loadInfoIntoComponent(userInfo);
            }
            catch
            {

            }
        }

        private void showUserInfoToForm(UserInfo userInfo)
        {
            loadInfoIntoComponent(userInfo);
        }

        private void loadInfoIntoComponent(UserInfo userInfo)
        {
            textBox_Id.Text = userInfo.id;
            textBox_Mail.Text = userInfo.mail;
            textBox_PhoneNumber.Text = userInfo.phoneNumber;
            textBox_Name.Text = userInfo.name;
            textBox_Address.Text = userInfo.address;
            dateTimePicker_Birthday.Value = userInfo.birthday;
            comboBox_Gender.Text = userInfo.gender;
            comboBox_Role.Text = userInfo.role;
            pictureBox_Avatar.Image = Image.FromStream(userInfo.avatar);
        }


        private UserInfo getUserInfoFromForm()
        {
            MemoryStream avatar = new MemoryStream();
            pictureBox_Avatar.Image.Save(avatar, pictureBox_Avatar.Image.RawFormat);

            UserInfo userInfo = new UserInfoBuilder()
                                    .addAddress(textBox_Address.Text)
                                    .addAvatar(avatar)
                                    .addBirthday(dateTimePicker_Birthday.Value)
                                    .addGender(comboBox_Gender.Text)
                                    .addId(textBox_Id.Text)
                                    .addMail(textBox_Mail.Text)
                                    .addName(textBox_Name.Text)
                                    .addPassword(textBox_Password.Text)
                                    .addPhoneNumber(textBox_PhoneNumber.Text)
                                    .addRole(comboBox_Role.Text)
                                    .build();
            return userInfo;
        }
        #endregion
        
        private void pictureBox_AnhDaiDien_Click(object sender, EventArgs e)
        {
            PictureBoxImagePicker.pick(pictureBox_Avatar, openFileDialog_Avatar);
        }

        #region Add, Update, Remove


        private void button_UpdateInfo_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                UserInfo userInfo = getUserInfoFromForm();
                if (updateuserInfoToDatabase(userInfo))
                {
                    MessageBox.Show("Đã cập nhật thông tin của tài khoản có mã " + userInfo.id + " thành công.", "ĐÃ CẬP NHẬT THÔNG TIN TÀI KHOẢN", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin của tài khoản có mã " + userInfo.id + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ CẬP NHẬT THÔNG TIN TÀI KHOẢN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool updateuserInfoToDatabase(UserInfo userInfo)
        {
            if(String.IsNullOrEmpty(textBox_Password.Text))
            {
                return updateUserInfoWithoutPasswordIntoDatabase(userInfo);
            }   
            else
            {
                return updateUserInfoWithPasswordIntoDatabase(userInfo);
            }
        }

        private bool updateUserInfoWithoutPasswordIntoDatabase(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.updateUserInfo(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private bool updateUserInfoWithPasswordIntoDatabase(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.updateUserInfoWithPassword(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_CancelChange_Click(object sender, EventArgs e)
        {
            string userId = textBox_Id.Text;
            showUserInfoToForm(userId);
        }

        /*
        TextBoxPass     Text    verify
            0           0       1
            0           1       1
            1           0       0       AB'     
            1           1       1
        */
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                UserInfo userInfo = getUserInfoFromForm();
                if (addUserToDatabase(userInfo))
                {
                    modeUpdate();
                    MessageBox.Show("Thêm tài khoản thành công!", "THÊM THÀNH CÔNG!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "THÊM THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool addUserToDatabase(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.addUser(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string userId = textBox_Id.Text;
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn xóa tài khoản " + userId + "?",
                      "XÓA TÀI KHOẢN " + userId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (removeUserInfoFromDatabase(userId))
                {
                    blankForm();
                    MessageBox.Show("Đã xóa tài khoản có mã " + userId + " thành công.", "ĐÃ XÓA TÀI KHOẢN", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản có mã " + userId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ XÓA TÀI KHOẢN", MessageBoxButtons.OK);
                }
            }
        }

        private bool removeUserInfoFromDatabase(string userId)
        {
            MySqlCommand command = CommandGenerator.removeUser(userId);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        #endregion

        #region other stuffs
        private void blankForm()
        {
            textBox_Id.Text = "";
            blankFormExceptId();
        }

        private void blankFormExceptId()
        {
            textBox_Password.Text = "";
            textBox_Mail.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_Name.Text = "";
            textBox_Address.Text = "";
            dateTimePicker_Birthday.Value = new DateTime(2000, 01, 01);
            comboBox_Gender.Text = "";
            comboBox_Role.Text = "";
            pictureBox_Avatar.Image = Image.FromFile("..\\..\\Resources\\Picture\\DefaultUserAvatar.png");
            modeAdd();
        }

        #endregion



        private void getAccountInfo()
        {
            UserInfo loggedInUserInfo = LoggedInUser.getLoggedInUserInfo();
            textBox_Id.Text = loggedInUserInfo.id;
            textBox_Mail.Text = loggedInUserInfo.mail;
            comboBox_Role.Text = loggedInUserInfo.role;
            textBox_Name.Text = loggedInUserInfo.name;
            textBox_PhoneNumber.Text = loggedInUserInfo.phoneNumber;
            textBox_Address.Text = loggedInUserInfo.address;
            comboBox_Gender.Text = loggedInUserInfo.gender;
            dateTimePicker_Birthday.Value = loggedInUserInfo.birthday;
            pictureBox_Avatar.Image = Image.FromStream(loggedInUserInfo.avatar);
        }

        #region mode
        private void modeUpdate()
        {
            button_Add.Visible = false;
            button_Update.Visible = true;
            button_Remove.Visible = textBox_Password.Visible;
        }

        private void modeAdd()
        {
            button_Add.Visible = true;
            button_Update.Visible = false;
            button_Remove.Visible = false;
        }

        private void modeUser()
        {
            textBox_Id.Enabled = false;
            textBox_Mail.Enabled = false;
            comboBox_Role.Enabled = false;
            passwordVisible(false);
        }

        private void modeAdmin()
        {
            textBox_Id.Enabled = true;
            textBox_Mail.Enabled = true;
            comboBox_Role.Enabled = true;
            passwordVisible(true);
        }

        private void passwordVisible(bool isVisible)
        {
            textBox_Password.Visible = isVisible;
            label_Password.Visible = isVisible;
            label_PasswordRequired.Visible = isVisible;
            pictureBox_Password.Visible = isVisible;
        }


        #endregion

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            string userId = textBox_Id.Text;
            if(isUserExisted(userId))
            {
                modeUpdate();
                UserInfo userInfo = new UserInfo(userId);
                showUserInfoToForm(userInfo);
            }
            else
            {
                blankFormExceptId();
            }
        }

        #region logic and validate
        private bool isVerified()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text) ||
                String.IsNullOrEmpty(textBox_Mail.Text) ||
                String.IsNullOrEmpty(textBox_Name.Text) ||
                String.IsNullOrEmpty(comboBox_Role.Text))
                return false;
            else
                return true;
        }

        /*
            PassVisible     Text        Valid
            0               0           1
            0               1           1
            1               0           0   => PassVisible  & TextIsNullOrEmpty => false
            1               1           1
            
         */

        private bool isUserExisted(string userId)
        {
            return DataTableExtra.hasRow(new MySqlDataToDataTableAdapter(CommandGenerator.getUserInfo(userId)).getDataTable());
        }



        #endregion

        
    }
}
