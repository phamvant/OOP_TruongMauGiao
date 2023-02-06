using System;
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
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
            loadAllClass();
        }

        private void loadAllClass()
        {
            //Load data from database
            MySqlCommand command = CommandGenerator.getAllClassInfos();
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            
        }
    }
}
