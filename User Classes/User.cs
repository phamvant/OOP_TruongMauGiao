using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    public class User
    {
        public UserInfo userInfo;

        public User()
        {

        }

        public User(string userId)
        {
            userInfo = new UserInfo(userId);
        }


        /// <summary>
        /// Check if user's mail and password are matched with the data from database
        /// </summary>
        /// <param name="mail">User's login mail</param>
        /// <param name="password">User's login password</param>
        /// <returns></returns>
        public static bool login(string mail, string password)
        {
            MySqlCommand command = CommandGenerator.login(mail, password);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            if(DataTableExtra.hasRow(table))
            {
                string loggedInUserId = DataTableExtra.getUserIdFromDataTable(table, 0);
                LoggedInUser.logIn(loggedInUserId);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void logout()
        {

        }

        /*
        public static bool addUser(UserInfo userInfo)
        {
            MySqlCommand command = CommandGenerator.addRegister(userInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }
        */

        public bool changePassword(string newPassword)
        {
            MySqlCommand command = CommandGenerator.updatePassword(newPassword, this.userInfo.id);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        public bool changeInfomation(UserInfo updatedUserInfo)
        {
            //try
            //{
                MySqlCommand command = CommandGenerator.updateUserInfo(updatedUserInfo);
                CommandExecutor executor = new CommandExecutor(command);
                executor.execute();
                return executor.isExecuted;
            //}
            //catch
            //{
                //return false;
            //}
        }

        public bool sendMessage(MessageInfo messageInfo)
        {
            MySqlCommand command = CommandGenerator.addMessage(messageInfo);
            CommandExecutor executor = new CommandExecutor(command);
            executor.execute();
            return executor.isExecuted;
        }

        public void readMessage()
        {

        }
    }
}
