using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    public class PhanCongInfo
    {
        public int year;
        public string classId;
        public string teacherId;
        public string phanCongTableId;

        public PhanCongInfo()
        {

        }

        public PhanCongInfo(string phanCongTableId)
        {
            PhanCongInfo phanCongInfo = DataTableExtra.GetPhanCongInfoFromDataTable(new MySqlDataToDataTableAdapter(CommandGenerator.getPhanCongTable(phanCongTableId)).getDataTable(), 0);
            this.year = phanCongInfo.year;
            this.classId = phanCongInfo.classId;
            this.phanCongTableId = phanCongInfo.phanCongTableId;
            this.teacherId = phanCongInfo.teacherId;
        }
    }
}
