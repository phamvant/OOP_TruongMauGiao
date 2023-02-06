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
    public partial class PhanCongForm : Form
    {

        #region creation - cac ham khoi tao

        /// <summary>
        /// Create a new form and filled with phan cong info
        /// </summary>
        /// <param name="phanCongId"></param>
        public PhanCongForm(string phanCongId)
        {
            InitializeComponent();
            setupForm();
            showPhanCongInfoToForm(phanCongId);
            modeUpdate();
        }

        /// <summary>
        /// Create a new blank InfoForm
        /// </summary>
        public PhanCongForm()
        {
            InitializeComponent();
            setupForm();
            modeAdd();
        }

        #endregion

        #region setup
        private void setupForm()
        {
            loadComboBoxColection();
            //Other setup methods here
        }

        private void loadComboBoxColection()
        {
            loadComboBoxTeacherIdColection();
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

        private void loadComboBoxTeacherIdColection()
        {
            MySqlCommand command = CommandGenerator.getAllUserIdByRole(DefinedConstant.ROLE_TEACHER);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            for (int row = 0; row < table.Rows.Count; row++)
            {
                comboBox_TeacherId.Items.Add(table.Rows[row][0]);
            }
        }
        #endregion

        #region Form load and save stuffs
        private void showPhanCongInfoToForm(string phanCongId)
        {
            PhanCongInfo phanCongInfo = new PhanCongInfo(phanCongId);
            loadInfoIntoComponent(phanCongInfo);
        }

        private void showPhanCongInfoToForm(PhanCongInfo phanCongInfo)
        {
            loadInfoIntoComponent(phanCongInfo);
        }

        private void loadInfoIntoComponent(PhanCongInfo phanCongInfo)
        {
            textBox_PhanCongId.Text = phanCongInfo.phanCongTableId;
            textBox_Year.Text = phanCongInfo.year.ToString();
            comboBox_ClassId.Text = phanCongInfo.classId;
            comboBox_TeacherId.Text = phanCongInfo.teacherId;
        }


        private PhanCongInfo getPhanCongInfoFromForm()
        {
            PhanCongInfo phanCongInfo = new PhanCongInfo();
            phanCongInfo.classId = comboBox_ClassId.Text;
            phanCongInfo.phanCongTableId = textBox_PhanCongId.Text;
            phanCongInfo.teacherId = comboBox_TeacherId.Text;
            int.TryParse(textBox_Year.Text, out phanCongInfo.year);
            return phanCongInfo;
        }
        #endregion


        #region button chuc nang
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                PhanCongInfo phanCongInfo = getPhanCongInfoFromForm();
                if (addPhanCongTableToDataBase(phanCongInfo))
                {
                    modeUpdate();
                    MessageBox.Show("Thêm phân công thành công!", "THÊM THÀNH CÔNG!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm phân công thất bại!", "THÊM THẤT BẠI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool addPhanCongTableToDataBase(PhanCongInfo phanCongInfo)
        {
            MySqlCommand command = CommandGenerator.addPhanCongTable(phanCongInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (isVerified())
            {
                PhanCongInfo phanCongInfo = getPhanCongInfoFromForm();
                if (updatePhanCongTableInfoToDatabase(phanCongInfo))
                {
                    MessageBox.Show("Đã cập nhật phân công có mã " + phanCongInfo.phanCongTableId + " thành công.", "ĐÃ CẬP NHẬT THÔNG TIN", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật phân công có mã " + phanCongInfo.phanCongTableId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ CẬP NHẬT THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xin hãy kiểm tra lại thông tin còn thiếu, những mục đánh dấu sao là bắt buộc", "THIẾU THÔNG TIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool updatePhanCongTableInfoToDatabase(PhanCongInfo phanCongInfo)
        {
            MySqlCommand command = CommandGenerator.updatePhanCongTable(phanCongInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            string phanCongTableId = textBox_PhanCongId.Text;
            if (isPhanCongTableExisted(phanCongTableId))
            {
                modeUpdate();
                PhanCongInfo phanCongInfo = new PhanCongInfo(phanCongTableId);
                showPhanCongInfoToForm(phanCongInfo);
            }
            else
            {
                blankForm();
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string phanCongTableId = textBox_PhanCongId.Text;
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn xóa phân công có mã " + phanCongTableId + " ?",
                      "XÓA PHÂN CÔNG " + textBox_PhanCongId.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (removePhanCongTableInfoFromDatabase(phanCongTableId))
                {
                    blankForm();
                    MessageBox.Show("Đã xóa phân công có mã " + phanCongTableId + " thành công.", "ĐÃ XÓA PHÂN CÔNG", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thể xóa lớp có mã " + phanCongTableId + ". Xin hãy kiểm tra và thử lại.", "KHÔNG THỂ XÓA PHÂN CÔNG", MessageBoxButtons.OK);
                }
            }
        }

        private bool removePhanCongTableInfoFromDatabase(string phanCongTableId)
        {
            MySqlCommand command = CommandGenerator.removePhanCongTable(phanCongTableId);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
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

        private void button_TeacherInfo_Click(object sender, EventArgs e)
        {
            string teacherId = comboBox_TeacherId.Text;
            if(String.IsNullOrEmpty(teacherId))
            {
                UserInfoForm teacherInfoForm = new UserInfoForm();
                teacherInfoForm.Show();
            }
            else
            {
                UserInfoForm teacherInfoForm = new UserInfoForm(teacherId);
                teacherInfoForm.Show();
            }
        }
        #endregion

        #region other stuffs
        private void blankFormExceptId()
        {
            textBox_PhanCongId.Text = "";
            textBox_Year.Text = "";
            //comboBox_ClassId.Text = "";
            comboBox_TeacherId.Text = "";
            modeAdd();
        }

        private void blankForm()
        {
            comboBox_ClassId.Text = "";
            blankFormExceptId();
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            string phanCongTableId = textBox_PhanCongId.Text;
            if (isPhanCongTableExisted(phanCongTableId))
            {
                modeUpdate();
                PhanCongInfo phanCongInfo = new PhanCongInfo(phanCongTableId);
                showPhanCongInfoToForm(phanCongInfo);
            }
            else
            {
                blankFormExceptId();
            }
        }

        #endregion

        #region logic and validate

        private bool isPhanCongTableExisted(string phanCongTableId)
        {
            return DataTableExtra.hasRow(new MySqlDataToDataTableAdapter(CommandGenerator.getPhanCongTable(phanCongTableId)).getDataTable());
        }

        private bool isVerified()
        {
            if (String.IsNullOrEmpty(textBox_PhanCongId.Text) ||
                String.IsNullOrEmpty(textBox_Year.Text)||
                String.IsNullOrEmpty(comboBox_ClassId.Text)||
                String.IsNullOrEmpty(comboBox_TeacherId.Text))
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
