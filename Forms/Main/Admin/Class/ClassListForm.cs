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
    public partial class ClassListForm : Form
    {
        private const int ColumnIndex_ClassId = 0;
        private const int ColumnIndex_Year = 1;
        private const int ColumnIndex_Name = 2;
        private const int ColumnIndex_Capacity = 3;

        public ClassListForm()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            MySqlCommand command = CommandGenerator.getAllClassInfos();
            loadClassListToDataGrid(command);
        }

        private void loadClassListToDataGrid(MySqlCommand command)
        {
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            loadClassListDataTableToDataGrid(table);
        }

        private void loadClassListDataTableToDataGrid(DataTable table)
        {
            formatTable(table);
            dataGridView_ListOfClasses.DataSource = table;
        }
        private void formatTable(DataTable table)
        {
            table.Columns[ColumnIndex_ClassId].ColumnName = "MÃ LỚP";
            table.Columns[ColumnIndex_Year].ColumnName = "NĂM HỌC";
            table.Columns[ColumnIndex_Name].ColumnName = "TÊN LỚP";
            table.Columns[ColumnIndex_Capacity].ColumnName = "SỐ HỌC SINH";
        }

        private void refreshDataGrid(string id, string name)
        {
            try
            {
                MySqlCommand command = CommandGenerator.getClassesByFilter(id, name);
                loadClassListToDataGrid(command);
            }
            catch
            {

            }
        }

        private void dataGridView_ListOfClasses_DoubleClick(object sender, EventArgs e)
        {
            string classId = dataGridView_ListOfClasses.CurrentRow.Cells[ColumnIndex_ClassId].Value.ToString();
            ClassInfoForm classInfoForm = new ClassInfoForm(classId);
            classInfoForm.Show();
            classInfoForm.FormClosed += new FormClosedEventHandler(classInfoForm_Closed);
        }

        void classInfoForm_Closed(object sender, FormClosedEventArgs e)
        {
            refreshDataGrid();
        }

        private void pictureBox_Refresh_Click(object sender, EventArgs e)
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
    }
}
