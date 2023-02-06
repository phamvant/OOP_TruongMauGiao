using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OOP_TruongMauGiao
{
    class MySqlDataToDataTableAdapter
    {
        MySqlDataAdapter adapter;

        /// <summary>
        /// Create a new adapter to convert from MySql data to DataTable
        /// </summary>
        /// <param name="command">The command to get MySql data from the database</param>
        public MySqlDataToDataTableAdapter(MySqlCommand command)
        {
            adapter = new MySqlDataAdapter(command);
        }

        /// <summary>
        /// Get converted DataTable from MySql data
        /// </summary>
        /// <returns></returns>
        public DataTable getDataTable()
        {
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
