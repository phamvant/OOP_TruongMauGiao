using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
	public class LoggedInUser
	{
        public User _loggedInUser;
        private static LoggedInUser _singletonLoggedInUser;

        private LoggedInUser(string loggedInUserId)
        {
            UserInfo loggedInUserInfo = loadUserInfo(loggedInUserId);
            _loggedInUser = loadUser(loggedInUserInfo);
        }

        public static UserInfo getLoggedInUserInfo()
        {
            reload();
            return _singletonLoggedInUser._loggedInUser.userInfo;
        }

        public static User getLoggedInUser()
        {
            reload();
            return _singletonLoggedInUser._loggedInUser;
        }

		public static bool logIn(string loggedInUserId)
        {
            if (_singletonLoggedInUser == null)
            {
                _singletonLoggedInUser = new LoggedInUser(loggedInUserId);
                return true;
            }
            else
                return false;
        }

        public static void reload()
        {
            _singletonLoggedInUser = new LoggedInUser(_singletonLoggedInUser._loggedInUser.userInfo.id);
        }

        private static UserInfo loadUserInfo(string loggedInUserId)
        {
            return new UserInfo(loggedInUserId);
        }

        private static User loadUser(UserInfo loggedInUserInfo)
        {
            string role = loggedInUserInfo.role;
            string id = loggedInUserInfo.id;
            //Missing module to get Role Info from the database
            //Missing database to store Role Info
            switch(role)
            {
                case DefinedConstant.ROLE_ADMIN:
                    AdminInfo adminInfo = new AdminInfo();
                    //
                    Admin admin = new Admin(loggedInUserInfo, adminInfo);
                    return admin;
                case DefinedConstant.ROLE_TEACHER:
                    TeacherInfo teacherInfo = new TeacherInfo();
                    //
                    Teacher teacher = new Teacher(loggedInUserInfo, teacherInfo);
                    return teacher;
                case DefinedConstant.ROLE_ACCOUNTANT:
                    AccountantInfo accountantInfo = new AccountantInfo();
                    //
                    Accountant accountant = new Accountant(loggedInUserInfo, accountantInfo);
                    return accountant;
                case DefinedConstant.ROLE_PARENT:
                    ParentInfo parentInfo = new ParentInfo();
                    //
                    Parent parent = new Parent(loggedInUserInfo, parentInfo);
                    return parent;
                default:
                    return null;
            }
        }
	}
}
