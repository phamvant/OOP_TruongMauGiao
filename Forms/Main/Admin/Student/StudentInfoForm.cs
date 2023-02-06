using System;
using System.IO;
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
    public partial class StudentInfoForm : Form
    {
        /*
        //Yêu cầu người dùng chấp thuận khi muốn đóng form Student
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đóng cửa sổ?", "ĐÓNG CỬA SỔ", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        */

        #region Ham khoi tao
        /// <summary>
        /// Create a new form and filled with student info
        /// </summary>
        /// <param name="studentId"></param>
        public StudentInfoForm(string studentId)
        {
            InitializeComponent();
            setupForm();
            showStudentInfoToForm(studentId);
            modeUpdate();
        }

        /// <summary>
        /// Create a new blank InfoForm
        /// </summary>
        public StudentInfoForm()
        {
            InitializeComponent();
            setupForm();
            modeAdd();
        }
        #endregion

        #region setup form
        private void setupForm()
        {
            loadComboBoxColection();
            //Other setup methods here
        }

        private void loadComboBoxColection()
        {
            loadComboBoxParentIdColection();
            loadComboBoxClassIdColection();
        }

        private void loadComboBoxClassIdColection()
        {
            MySqlCommand command = CommandGenerator.getAllClassId();
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            for (int row = 0; row < table.Rows.Count; row++)
            {
                comboBox_ClassId.Items.Add(table.Rows[row][0]);
            }
        }

        private void loadComboBoxParentIdColection()
        {
            MySqlCommand command = CommandGenerator.getAllUserIdByRole(DefinedConstant.ROLE_PARENT);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            for (int row = 0; row < table.Rows.Count; row++)
            {
                comboBox_ParentId.Items.Add(table.Rows[row][0]);
            }
        }
        #endregion

        #region Form load and save stuffs
        private void showStudentInfoToForm(string studentId)
        {
            StudentInfo studentInfo = new StudentInfo(studentId);
            loadInfoIntoComponent(studentInfo);
        }

        private void showStudentInfoToForm(StudentInfo studentInfo)
        {
            loadInfoIntoComponent(studentInfo);
        }

        private void loadInfoIntoComponent(StudentInfo studentInfo)
        {
            comboBox_ParentId.Text = studentInfo.parentInfo.id;
            comboBox_ClassId.Text = studentInfo.classInfo.classId;
            dateTimePicker_Birthday.Value = studentInfo.birthday;
            textBox_Id.Text = studentInfo.id;
            textBox_Name.Text = studentInfo.name;
            textBox_Note.Text = studentInfo.disease;
            comboBox_Gender.Text = studentInfo.gender;
            pictureBox_Avatar.Image = Image.FromStream(studentInfo.avatar);
        }

        
        private StudentInfo getStudentInfoFromForm()
        {
            MemoryStream avatar = new MemoryStream();
            pictureBox_Avatar.Image.Save(avatar, pictureBox_Avatar.Image.RawFormat);

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.avatar = avatar;
            studentInfo.birthday = dateTimePicker_Birthday.Value;
            studentInfo.classInfo.classId = comboBox_ClassId.Text;
            studentInfo.disease = textBox_Note.Text;
            studentInfo.gender = comboBox_Gender.Text;
            studentInfo.id = textBox_Id.Text;
            studentInfo.name = textBox_Name.Text;
            studentInfo.parentInfo.id = comboBox_ParentId.Text;

            return studentInfo;
        }
        #endregion

        #region button chuc nang
        //Khi click button ThemHocSinh, ktra nếu các textBox cần thiết có bị trống không? Nếu không thì đọc dữ liệu và ghi vào database
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                StudentInfo studentInfo = getStudentInfoFromForm();
                if(addStudentToDatabase(studentInfo))
                {
                    modeUpdate();
                    MessageBox.Show("Thêm học sinh thành công!", "THÊM THÀNH CÔNG!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm học sinh thất bại!", "THÊM THẤT BẠI!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }          
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool addStudentToDatabase(StudentInfo studentInfo)
        {
            MySqlCommand command = CommandGenerator.addStudent(studentInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            
            if (isVerified())
            {
                StudentInfo studentInfo = getStudentInfoFromForm();
                if (updateStudentInfoToDatabase(studentInfo))
                {
                    MessageBox.Show("Đã cập nhật thông tin của học sinh có mã " + studentInfo.id + " thành công.", "ĐÃ CẬP NHẬT THÔNG TIN HỌC SINH", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin của học sinh có mã " + studentInfo.id + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ THÊM THÊM HỌC SINH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool updateStudentInfoToDatabase(StudentInfo studentInfo)
        {
            MySqlCommand command = CommandGenerator.updateStudent(studentInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            string studentId = textBox_Id.Text;
            StudentInfo studentInfo = new StudentInfo(studentId);
            showStudentInfoToForm(studentInfo);
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string studentId = textBox_Id.Text;
            string studentName = textBox_Name.Text;
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn xóa học sinh " + studentName + ", mã học sinh " + studentId + "?",
                      "XÓA HỌC SINH " + studentId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (removeStudentInfoFromDatabase(studentId))
                {
                    blankForm();
                    MessageBox.Show("Đã xóa học sinh có mã " + studentId + " thành công.", "ĐÃ XÓA HỌC SINH", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể xóa học sinh có mã " + studentId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ XÓA HỌC SINH", MessageBoxButtons.OK);
                }
            }
        }

        private bool removeStudentInfoFromDatabase(string studentId)
        {
            MySqlCommand command = CommandGenerator.removeStudent(studentId);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void pictureBox_Avatar_Click(object sender, EventArgs e)
        {
            PictureBoxImagePicker.pick(pictureBox_Avatar, openFileDialog_Avatar);
        }
        private void button_ClassInfo_Click(object sender, EventArgs e)
        {
            string classId = comboBox_ClassId.Text;
            if (String.IsNullOrEmpty(classId))
            {
                ClassInfoForm classInfoForm = new ClassInfoForm();
                classInfoForm.Show();
            }
            else
            {
                ClassInfoForm classInfoForm = new ClassInfoForm(classId);
                classInfoForm.Show();
            }
        }

        private void button_ParentInfo_Click(object sender, EventArgs e)
        {
            string parentId = comboBox_ParentId.Text;
            if (String.IsNullOrEmpty(parentId))
            {
                UserInfoForm userInfoForm = new UserInfoForm();
                userInfoForm.Show();
            }
            else
            {
                UserInfoForm userInfoForm = new UserInfoForm(parentId);
                userInfoForm.Show();
            }
        }
        #endregion

        #region other stuffs
        private void blankFormExceptId()
        {
            //textBox_Id.Text = "";
            textBox_Name.Text = "";
            dateTimePicker_Birthday.Value = new DateTime(2000, 01, 01);
            comboBox_Gender.Text = "";
            comboBox_ParentId.Text = "";
            comboBox_ClassId.Text = "";
            textBox_Note.Text = "";
            pictureBox_Avatar.Image = Image.FromFile("..\\..\\Resources\\Picture\\DefaultUserAvatar.png");
            modeAdd();
        }

        private void blankForm()
        {
            textBox_Id.Text = "";
            blankFormExceptId();
        }

        
        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            string studentId = textBox_Id.Text;
            if(isStudentExisted(studentId))
            {
                modeUpdate();
                StudentInfo studentInfo = new StudentInfo(studentId);
                showStudentInfoToForm(studentInfo);
            }
            else
            {
                blankFormExceptId();
            }
        }
        #endregion

        #region logic and validate
        /// <summary>
        /// Check if student id is existed or not
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        private bool isStudentExisted(string studentId)
        {
            return DataTableExtra.hasRow(new MySqlDataToDataTableAdapter(CommandGenerator.getStudent(studentId)).getDataTable());
        }

        //Check textBox_MaHocSinh, textBox_Ten, textBox_TenDem is good (true) or null/empty (false)
        private bool isVerified()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text) ||
                String.IsNullOrEmpty(textBox_Name.Text) ||
                String.IsNullOrEmpty(comboBox_ClassId.Text) ||
                String.IsNullOrEmpty(comboBox_ParentId.Text))
                return false;
            else
                return true;
        }

        #endregion

        #region mode
        private void modeUpdate()
        {
            button_Add.Visible = false;
            button_Update.Visible = true;
            button_Remove.Visible = true;
        }

        private void modeAdd()
        {
            button_Add.Visible = true;
            button_Update.Visible = false;
            button_Remove.Visible = false;
        }

        /*
        private void buttonUpdateEnable()
        {
            button_Update.Enabled = true;
        }

        private void buttonUpdateDisable()
        {
            button_Update.Enabled = false;
        }

        private void buttonAddEnable()
        {
            button_Add.Enabled = true;
        }

        private void buttonAddDisable()
        {
            button_Add.Enabled = false;
        }
        */
        #endregion

        
    }
}
