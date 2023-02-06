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
    public partial class PhanCongList : Form
    {
        private const int ColumnIndex_Year = 0;
        private const int ColumnIndex_ClassID = 1;
        private const int ColumnIndex_TeacherID = 2;
        private const int ColumnIndex_PhanCongTableId = 3;


        #region creation
        public PhanCongList()
        {
            InitializeComponent();
            refreshDataGrid();
        }
        #endregion

        #region refresh, format table and load table to grid
        private void refreshDataGrid()
        {
            MySqlCommand command = CommandGenerator.getAllPhanCongTables();
            loadPhanCongTableListDataTableToDataGrid(command);
        }

        private void refreshDataGrid(string classId, string teacherId, string phanCongTableId)
        {
            MySqlCommand command = CommandGenerator.getPhanCongTablesByFilter(classId, teacherId, phanCongTableId);
            loadPhanCongTableListDataTableToDataGrid(command);
        }
        private void loadPhanCongTableListDataTableToDataGrid(MySqlCommand command)
        {
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            loadPhanCongTableListDataTableToDataGrid(table);
        }

        private void loadPhanCongTableListDataTableToDataGrid(DataTable table)
        {
            formatTable(table);
            dataGridView_ListOfPhanCongs.DataSource = table;
        }
        private void formatTable(DataTable table)
        {
            table.Columns[ColumnIndex_Year].ColumnName = "NĂM HỌC";
            table.Columns[ColumnIndex_ClassID].ColumnName = "MÃ LỚP";
            table.Columns[ColumnIndex_TeacherID].ColumnName = "MÃ GIÁO VIÊN";
            table.Columns[ColumnIndex_PhanCongTableId].ColumnName = "MÃ PHÂN CÔNG";
        }

        private void pictureBox_Refresh_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        #endregion


        #region search bar
        private void textBox_PhanCongIdSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_ClassIdSearch.Text, textBox_TeacherIdSearch.Text, textBox_PhanCongIdSearch.Text);
        }

        private void textBox_ClassIdSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_ClassIdSearch.Text, textBox_TeacherIdSearch.Text, textBox_PhanCongIdSearch.Text);
        }

        private void textBox_TeacherIdSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_ClassIdSearch.Text, textBox_TeacherIdSearch.Text, textBox_PhanCongIdSearch.Text);
        }

        private void textBox_YearSearch_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid(textBox_ClassIdSearch.Text, textBox_TeacherIdSearch.Text, textBox_PhanCongIdSearch.Text);
        }
        #endregion

        #region choose one row to pop up and view info
        private void dataGridView_ListOfPhanCongs_DoubleClick(object sender, EventArgs e)
        {
            string phanCongId = dataGridView_ListOfPhanCongs.CurrentRow.Cells[ColumnIndex_PhanCongTableId].Value.ToString();
            PhanCongForm phanCongForm = new PhanCongForm(phanCongId);
            phanCongForm.Show();
            phanCongForm.FormClosed += new FormClosedEventHandler(PhanCongForm_Closed);
        }

        void PhanCongForm_Closed(object sender, FormClosedEventArgs e)
        {
            refreshDataGrid();
        }
        #endregion
    }
}
