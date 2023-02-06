using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class Teacher:User
    {
        public TeacherInfo teacherInfo;
        public ClassInfo classInfo;

        public Teacher(UserInfo userInfo, TeacherInfo teacherInfo)
        {
            this.userInfo = userInfo;
            this.teacherInfo = teacherInfo;
        }

        public void addStudent()
        {

        }

        public void updateStudent()
        {

        }

        public void removeStudent()
        {

        }

        public void checkAttendance()
        {

        }

        public void exportStudentList()
        {

        }
    }
}
