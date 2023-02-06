using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class UserInfoBuilder
    {
        string id;
        string mail;
        string password;
        string phoneNumber;
        string address;
        string role;
        string gender;
        string name;
        MemoryStream avatar;
        DateTime birthday;

        public UserInfoBuilder()
        {

        }

        #region UserInfo Builder Pattern
        public UserInfoBuilder addId(string id)
        {
            this.id = id;
            return this;
        }
        public UserInfoBuilder addMail(string mail)
        {
            this.mail = mail;
            return this;
        }
        public UserInfoBuilder addPassword(string password)
        {
            this.password = password;
            return this;
        }
        public UserInfoBuilder addPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public UserInfoBuilder addAddress(string address)
        {
            this.address = address;
            return this;
        }

        public UserInfoBuilder addRole(string role)
        {
            this.role = role;
            return this;
        }

        public UserInfoBuilder addGender(string gender)
        {
            this.gender = gender;
            return this;
        }
        public UserInfoBuilder addName(string name)
        {
            this.name = name;
            return this;
        }

        public UserInfoBuilder addAvatar(MemoryStream avatar)
        {
            this.avatar = avatar;
            return this;
        }

        public UserInfoBuilder addBirthday(DateTime birthday)
        {
            this.birthday = birthday;
            return this;
        }


        public UserInfo build()
        {
            return new UserInfo(id, mail, password, phoneNumber, address, role, gender, name, avatar, birthday);
        }
        #endregion
    }
}
