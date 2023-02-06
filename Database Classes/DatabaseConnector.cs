using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OOP_TruongMauGiao
{
    class DatabaseConnector
    {

        /*
        public string datasource = "localhost";
        public string port = "3306";
        public string username = "root";
        public string password = "";
        public string database = "btl";

        static MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=btl");
        */

        //Setup a MySqlConnection's connection string
        static string datasource = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "btl";

        static string connectionString ="datasource = " + datasource +
                                        "; port     = " + port +
                                        "; username = " + username +
                                        "; password = " + password +
                                        "; database = " + database;
        static MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        /// <summary>
        /// Get connection from the database
        /// </summary>
        public static MySqlConnection getConnection
        {
            get
            {
                return mySqlConnection;
            }
        }

        /// <summary>
        /// Open connection to the database before sending any sql command
        /// </summary>
        public static void openConnection()
        {
            if (mySqlConnection.State == ConnectionState.Closed)
            {
                mySqlConnection.Open();
            }
        }

        /// <summary>
        /// Close connection from the database after sending all sql command
        /// </summary>
        public static void closeConnection()
        {
            if (mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }
    }
}
