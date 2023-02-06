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
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            MySqlCommand command = CommandGenerator.getAllUserInfoExceptPassword();
            loadUserListToDataGrid(command);
        }

        private void loadUserListToDataGrid(MySqlCommand command)
        {
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            loadUserListDataTableToDataGrid(table);
        }

        private void loadUserListDataTableToDataGrid(DataTable table)
        {
            formatTable(table);
            dataGridView_ListOfUsers.DataSource = table;
        }

        private void formatTable(DataTable table)
        {
            table.Columns[0].ColumnName = "ẢNH ĐẠI DIỆN";
            table.Columns[1].ColumnName = "MÃ TÀI KHOẢN";
            table.Columns[2].ColumnName = "TÊN NGƯỜI DÙNG";
            table.Columns[3].ColumnName = "NGÀY SINH";
            table.Columns[4].ColumnName = "GIỚI TÍNH";
            table.Columns[5].ColumnName = "MAIL";
            table.Columns[6].ColumnName = "SỐ ĐIỆN THOẠI";
            table.Columns[7].ColumnName = "ĐỊA CHỈ";
            table.Columns[8].ColumnName = "CHỨC VỤ";
        }

        private void refreshDataGrid(string id, string name)
        {
            try
            {
                MySqlCommand command = CommandGenerator.getUserInfoExceptPasswordByFilter(id, name);
                loadUserListToDataGrid(command);
            }
            catch
            {

            }
        }

        private void dataGridView_ListOfUsers_DoubleClick(object sender, EventArgs e)
        {
            string userId = dataGridView_ListOfUsers.CurrentRow.Cells[1].Value.ToString();
            UserInfoForm userInfoForm = new UserInfoForm(userId);
            userInfoForm.Show();
            userInfoForm.FormClosed += new FormClosedEventHandler(classInfoForm_Closed);
        }

        void classInfoForm_Closed(object sender, FormClosedEventArgs e)
        {
            refreshDataGrid();
        }

        private void textBox_TimKiemTheoMa_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_TimKiemTheoMa.Text, textBox_TimKiemTheoTen.Text);
        }

        private void textBox_TimKiemTheoTen_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_TimKiemTheoMa.Text, textBox_TimKiemTheoTen.Text);
        }

        private void pictureBox_Refresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
    }
}
