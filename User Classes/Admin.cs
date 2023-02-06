using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
    class Admin:User
    {
        AdminInfo adminInfo;

        public Admin(UserInfo userInfo, AdminInfo adminInfo)
        {
            this.userInfo = userInfo;
            this.adminInfo = adminInfo;
        }

        public bool add(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.addUser(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        public bool remove(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.removeUser(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        public bool remove(string userId)
        {
            MySqlCommand command = CommandGenerator.removeUser(userId);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        public DataTable getAllUserTables()
        {
            MySqlCommand command = CommandGenerator.getAllUser();
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            return table;
        }

        public UserInfo getUserTable(string userId)
        {
            MySqlCommand command = CommandGenerator.getUserInfo(userId);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            if(DataTableExtra.hasRow(table))
            {
                return DataTableExtra.getUserInfoFromDataTable(table, 0);
            }
            else
            {
                return null;
            }
        }


        public void add(ClassInfo classInfo)
        {

        }

        public void add(StudentInfo studentInfo)
        {

        }


        public void update(ClassInfo classInfo)
        {

        }

        public void update(StudentInfo studentInfo)
        {

        }
        

        public void remove(ClassInfo classInfo)
        {

        }

        public void remove(StudentInfo studentInfo)
        {

        }

        public void exportSummarize()
        {

        }
    }
}
