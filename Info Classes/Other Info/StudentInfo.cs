using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OOP_TruongMauGiao
{
    class StudentInfo
    {
        public ClassInfo classInfo;
        public UserInfo parentInfo;
        
        public string name;
        public DateTime birthday;
        public string id;
        public string disease;
        public string gender;
        public MemoryStream avatar;

        public StudentInfo()
        {
            classInfo = new ClassInfo();
            parentInfo = new UserInfo();
        }

        public StudentInfo(string studentId)
        {
            MySqlCommand command = CommandGenerator.getStudent(studentId);
            MySqlDataToDataTableAdapter adapter = new MySqlDataToDataTableAdapter(command);
            DataTable table = adapter.getDataTable();
            StudentInfo studentInfo = DataTableExtra.getStudentInfoFromDataTable(table,0);
            this.avatar = studentInfo.avatar;
            this.birthday = studentInfo.birthday;
            this.classInfo = studentInfo.classInfo;
            this.disease = studentInfo.disease;
            this.gender = studentInfo.gender;
            this.id = studentInfo.id;
            this.name = studentInfo.name;
            this.parentInfo = studentInfo.parentInfo;
        }
    }
}
