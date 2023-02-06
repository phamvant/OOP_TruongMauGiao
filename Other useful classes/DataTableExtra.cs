using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    /// <summary>
    /// Class to do some useful stuff with DataTable
    /// </summary>
    class DataTableExtra
    {
        /// <summary>
        /// Check if DataTable have any row or not
        /// </summary>
        /// <param name="table">The DataTable to check</param>
        /// <returns>true - has rows, false - no row</returns>
        public static bool hasRow(DataTable table)
        {
            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static UserInfo getUserInfoFromDataTable(DataTable table, int row)
        {
            try
            {
                UserInfo userInfo = new UserInfoBuilder()
                                .addId(table.Rows[row]["Id"].ToString())
                                .addMail(table.Rows[row]["Mail"].ToString())
                                .addPassword(table.Rows[row]["Password"].ToString())
                                .addPhoneNumber(table.Rows[row]["PhoneNumber"].ToString())
                                .addAddress(table.Rows[row]["Address"].ToString())
                                .addRole(table.Rows[row]["Role"].ToString())
                                .addGender(table.Rows[row]["Gender"].ToString())
                                .addName(table.Rows[row]["Name"].ToString())
                                .addAvatar(new MemoryStream((byte[])table.Rows[row]["Avatar"]))
                                .addBirthday((DateTime)table.Rows[row]["Birthday"])
                                .build();
                return userInfo;
            }
            catch
            {
                return new UserInfo();
            }
        }

        public static StudentInfo getStudentInfoFromDataTable(DataTable table, int row)
        {
            StudentInfo studentInfo = new StudentInfo();
            try
            {
                studentInfo.avatar = new MemoryStream((byte[])table.Rows[row]["Avatar"]);
                studentInfo.id = table.Rows[row]["StudentId"].ToString();
                studentInfo.name = table.Rows[row]["Name"].ToString();
                studentInfo.gender = table.Rows[row]["Gender"].ToString();
                studentInfo.disease = table.Rows[row]["Disease"].ToString();
                studentInfo.parentInfo = new UserInfo(table.Rows[row]["UserId"].ToString());
                studentInfo.classInfo = new ClassInfo(table.Rows[row]["ClassId"].ToString());
                studentInfo.birthday = (DateTime)table.Rows[row]["Birthday"];
                return studentInfo;
            }
            catch
            {
                return studentInfo;
            }
        }

        public static ClassInfo getClassInfoFromDataTable(DataTable table, int row)
        {
            ClassInfo classInfo = new ClassInfo();
            try
            {
                classInfo.classId = table.Rows[row]["ClassId"].ToString();
                classInfo.name = table.Rows[row]["Name"].ToString();
                classInfo.capacity = (int)table.Rows[row]["Capacity"];
                classInfo.year = (int)table.Rows[row]["Year"];
                return classInfo;
            }
            catch
            {
                return classInfo;
            }
        }

        public static PhanCongInfo GetPhanCongInfoFromDataTable(DataTable table, int row)
        {
            PhanCongInfo phanCongInfo = new PhanCongInfo();
            try
            {
                phanCongInfo.year = (int)table.Rows[row]["Year"];
                phanCongInfo.classId = table.Rows[row]["ClassID"].ToString();
                phanCongInfo.teacherId = table.Rows[row]["UserID"].ToString();
                phanCongInfo.phanCongTableId = table.Rows[row]["PhanCongTableId"].ToString();
                return phanCongInfo;
            }
            catch
            {
                return phanCongInfo;
            }
        }

        public static List<UserInfo> getUserInfosFromDataTable(DataTable table)
        {
            List<UserInfo> userInfos = new List<UserInfo>();

            for (int row = 0; row < table.Rows.Count; row++)
            {
                userInfos.Add(getUserInfoFromDataTable(table, row));
            }
            
            return userInfos;
        }

        public static string getUserIdFromDataTable(DataTable table, int row)
        {
            string id = table.Rows[row]["Id"].ToString();
            return id;
        }
    }
}
