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
    public partial class StudentList : Form
    {
        private const int ColumnIndex_Avatar = 0;
        private const int ColumnIndex_StudentId = 1;
        private const int ColumnIndex_Name = 2;
        private const int ColumnIndex_Birthday = 3;
        private const int ColumnIndex_Gender = 4;
        private const int ColumnIndex_Disease = 5;
        private const int ColumnIndex_UserId = 6;
        private const int ColumnIndex_ClassId = 7;

        #region creation
        public StudentList()        //Khởi tạo Components & Dữ liệu khởi tạo
        {
            InitializeComponent();
            refreshDataGrid();      //Khởi tạo bảng dữ liệu khi mở form lên
        }

        /*
        private void StudentList_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
        */
        #endregion

        #region refresh, format table and load table to grid
        private void refreshDataGrid()
        {
            MySqlCommand command = CommandGenerator.getAllStudents();
            loadStudentListDataTableToDataGrid(command);
        }

        private void refreshDataGrid(string id, string name)
        {
                MySqlCommand command = CommandGenerator.getStudentsByFilter(id, name);
                loadStudentListDataTableToDataGrid(command);
        }


        private void loadStudentListDataTableToDataGrid(MySqlCommand command)
        {
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            loadStudentListDataTableToDataGrid(table);
        }

        private void loadStudentListDataTableToDataGrid(DataTable table)
        {
            formatTable(table);
            dataGridView_ListOfStudents.DataSource = table;
        }
        private void formatTable(DataTable table)
        {
            table.Columns[ColumnIndex_Avatar].ColumnName = "ẢNH ĐẠI DIỆN";
            table.Columns[ColumnIndex_StudentId].ColumnName = "MÃ HỌC SINH";
            table.Columns[ColumnIndex_Name].ColumnName = "HỌ TÊN";
            table.Columns[ColumnIndex_Birthday].ColumnName = "NGÀY SINH";
            table.Columns[ColumnIndex_Gender].ColumnName = "GIỚI TÍNH";
            table.Columns[ColumnIndex_Disease].ColumnName = "GHI CHÚ";
            table.Columns[ColumnIndex_UserId].ColumnName = "MÃ PHỤ HUYNH";
            table.Columns[ColumnIndex_ClassId].ColumnName = "MÃ LỚP";
        }
        
        private void pictureBox_Refresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
        #endregion

        #region choose one row to pop up and view info
        /// <summary>
        /// Double click to a row of the DataGridView will show up a student form filled with student info
        /// </summary>
        private void dataGridView_StudentsList_DoubleClick(object sender, EventArgs e)
        {
            string studentId = dataGridView_ListOfStudents.CurrentRow.Cells[ColumnIndex_StudentId].Value.ToString();
            StudentInfoForm studentInfoForm = new StudentInfoForm(studentId);
            studentInfoForm.Show();
            studentInfoForm.FormClosed += new FormClosedEventHandler(studentInfoForm_Closed);
        }

        void studentInfoForm_Closed(object sender, FormClosedEventArgs e)
        {
            refreshDataGrid();
        }
        #endregion

        #region search bar
        private void textBox_TimKiemTheoMa_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_TimKiemTheoMa.Text,textBox_TimKiemTheoTen.Text);
        }

        private void textBox_TimKiemTheoTen_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_TimKiemTheoMa.Text,textBox_TimKiemTheoTen.Text);
        }
        #endregion
    }
}
