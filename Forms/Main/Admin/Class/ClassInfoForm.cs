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
    public partial class ClassInfoForm : Form
    {
        #region ham khoi tao
        
        public ClassInfoForm(string classId)
        {
            InitializeComponent();
            setupForm();
            showClassInfoToForm(classId);
            modeUpdate();
        }

        public ClassInfoForm()
        {
            InitializeComponent();
            setupForm();
            modeAdd();
        }
        #endregion

        #region setup form
        private void setupForm()
        {
            //Other setup methods here
        }
        #endregion

        #region Form load and save stuffs
        private void showClassInfoToForm(string classId)
        {
            try
            {
                ClassInfo classInfo = new ClassInfo(classId);
                loadInfoIntoComponents(classInfo);
            }
            catch
            {

            }
        }

        private void showClassInfoToForm(ClassInfo classInfo)
        {
            loadInfoIntoComponents(classInfo);
        }

        private void loadInfoIntoComponents(ClassInfo classInfo)
        {
            textBox_Year.Text = classInfo.year.ToString();
            textBox_Name.Text = classInfo.name;
            textBox_Id.Text = classInfo.classId;
            textBox_Capacity.Text = classInfo.capacity.ToString();
        }

        private ClassInfo getClassInfoFromForm()
        {
            ClassInfo classInfo = new ClassInfo();
            int.TryParse(textBox_Capacity.Text, out classInfo.capacity);
            int.TryParse(textBox_Year.Text, out classInfo.year);
            classInfo.classId = textBox_Id.Text;
            classInfo.name = textBox_Name.Text;

            return classInfo;
        }
        #endregion

        #region enable, visible logic design
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
        #endregion

        #region add, update, remove
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                ClassInfo classInfo = getClassInfoFromForm();
                if (addClassToDataBase(classInfo))
                {
                    modeUpdate();
                    MessageBox.Show("Thêm lớp thành công!", "THÊM THÀNH CÔNG!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm lớp thất bại!", "THÊM THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool addClassToDataBase(ClassInfo classInfo)
        {
            MySqlCommand command = CommandGenerator.addClassInfo(classInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                ClassInfo classInfo = getClassInfoFromForm();
                if (updateClassInfoToDatabase(classInfo))
                {
                    MessageBox.Show("Đã cập nhật thông tin của lớp có mã " + classInfo.classId + " thành công.", "ĐÃ CẬP NHẬT THÔNG TIN LỚP HỌC", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin của lớp có mã " + classInfo.classId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ CẬP NHẬT THÔNG TIN LỚP HỌC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool updateClassInfoToDatabase(ClassInfo classInfo)
        {
            MySqlCommand command = CommandGenerator.updateClassInfo(classInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            string classId = textBox_Id.Text;
            if (isClassExisted(classId))
            {
                ClassInfo classInfo = new ClassInfo(classId);
                showClassInfoToForm(classInfo);
            }
            else
            {
                blankForm();
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string classId = textBox_Id.Text;
            string className = textBox_Name.Text;
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn xóa lớp " + className + ", mã lớp " + classId + "?",
                      "XÓA LỚP HỌC " + classId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (removeClassInfoFromDatabase(classId))
                {
                    blankForm();
                    MessageBox.Show("Đã xóa lớp có mã " + classId + " thành công.", "ĐÃ XÓA LỚP HỌC", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể xóa lớp có mã " + classId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ XÓA LỚP HỌC", MessageBoxButtons.OK);
                }
            }
        }

        private bool removeClassInfoFromDatabase(string classId)
        {
            MySqlCommand command = CommandGenerator.removeClassInfo(classId);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        #endregion

        #region other stuffs
        private void blankFormExceptId()
        {
            textBox_Capacity.Text = "";
            //textBox_Id.Text = "";
            textBox_Name.Text = "";
            textBox_Year.Text = "";
            modeAdd();
        }

        private void blankForm()
        {
            textBox_Id.Text = "";
            blankFormExceptId();
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            string classId = textBox_Id.Text;
            if(isClassExisted(classId))
            {
                modeUpdate();
                ClassInfo classInfo = new ClassInfo(classId);
                showClassInfoToForm(classInfo);
            }
            else
            {
                blankFormExceptId();
            }
        }

        #endregion

        #region logic and validate

        private bool isClassExisted(string classId)
        {
            return DataTableExtra.hasRow(new MySqlDataToDataTableAdapter(CommandGenerator.getClassInfo(classId)).getDataTable());
        }

        private bool isVerified()
        {
            if (String.IsNullOrEmpty(textBox_Id.Text) || String.IsNullOrEmpty(textBox_Name.Text))
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
