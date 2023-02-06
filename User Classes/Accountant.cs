using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TruongMauGiao
{
    class Accountant:User
    {
        AccountantInfo accountantInfo;

        public Accountant(UserInfo userInfo, AccountantInfo accountantInfo)
        {
            this.userInfo = userInfo;
            this.accountantInfo = accountantInfo;
        }
        public void add(FinanceInfo financeInfo)
        {

        }

        public void change(FinanceInfo financeInfo)
        {

        }

        public void remove(FinanceInfo financeInfo)
        {

        }

        public void exportFinance()
        {

        }
    }
}
