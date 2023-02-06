using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    public class UserInfo
    {
        public string id;
        public string mail;
        public string password;
        public string phoneNumber;
        public string address;
        public string role;
        public string gender;
        public string name;
        public MemoryStream avatar;
        public DateTime birthday;

        /// <summary>
        /// Create a UserInfo obj by passing 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="role"></param>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <param name="avatar"></param>
        /// <param name="birthday"></param>
        public UserInfo(string id, string mail, string password, string phoneNumber, string address, string role, string gender, string name, MemoryStream avatar, DateTime birthday)
        {
            this.id = id;
            this.mail = mail;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.role = role;
            this.gender = gender;
            this.name = name;
            this.avatar = avatar;
            this.birthday = birthday;
        }

        /// <summary>
        /// Load UserInfo from database base on userId
        /// </summary>
        /// <param name="userId"></param>
        public UserInfo(string userId)
        {
            UserInfo userInfo = DataTableExtra.getUserInfoFromDataTable(new MySqlDataToDataTableAdapter(CommandGenerator.getUserInfo(userId)).getDataTable(), 0);
            this.avatar = userInfo.avatar;
            this.address = userInfo.address;
            this.birthday = userInfo.birthday;
            this.gender = userInfo.gender;
            this.id = userInfo.id;
            this.mail = userInfo.mail;
            this.name = userInfo.name;
            //this.password = userInfo.password;
            this.phoneNumber = userInfo.phoneNumber;
            this.role = userInfo.role;
        }


        public UserInfo() 
        {
            
        }
    }
}
