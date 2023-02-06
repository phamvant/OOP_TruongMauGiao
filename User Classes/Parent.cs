using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class Parent:User
    {
        ParentInfo parentInfo;

        public Parent(UserInfo userInfo, ParentInfo parentInfo)
        {
            this.userInfo = userInfo;
            this.parentInfo = parentInfo;
        }

        public void viewStudentInfo()
        {

        }

        public void viewTimeTable()
        {

        }


        
        public void requestEdit(StudentInfo newChangedStudentInfo)
        {

        }
    }
}
