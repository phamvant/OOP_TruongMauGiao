using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class ClassInfo
    {
        public string classId;
        public string name;
        public int capacity;
        public int year;


        public ClassInfo()
        {

        }
        public ClassInfo(string classId)
        {
            ClassInfo classInfo = DataTableExtra.getClassInfoFromDataTable(new MySqlDataToDataTableAdapter(CommandGenerator.getClassInfo(classId)).getDataTable(), 0);
            this.classId = classId;
            this.name = classInfo.name;
            this.capacity = classInfo.capacity;
            this.year = classInfo.year;
        }
    }
}
