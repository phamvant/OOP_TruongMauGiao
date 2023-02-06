using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
    /// <summary>
    /// Executes a Sql command again the connection using execute() and store the number of rows affected numberOfRowsAffected, isExecute state
    /// </summary>
    class CommandExecutor
    {
        MySqlCommand command;
        /// <summary>
        /// Number of rows affected by the command (UPDATE, INSERT, DELETE statements), all other types of statements will return -1
        /// </summary>
        public int numberOfRowsAffected;
        public bool isExecuted;

        public CommandExecutor(MySqlCommand command)
        {
            this.command = command;
        }

        public void execute()
        {
            try
            {
                DatabaseConnector.openConnection();
                numberOfRowsAffected = command.ExecuteNonQuery();
                if (numberOfRowsAffected >= 1 || numberOfRowsAffected == -1)
                {
                    DatabaseConnector.closeConnection();
                    isExecuted = true;
                }
                else
                {
                    DatabaseConnector.closeConnection();
                    isExecuted = false;
                }
            }
            catch
            {
                isExecuted = false;
            }
        }
    }
}
