using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class AdminClass
    {
        public string AdminsID, AdminsName, AdminsDesignation, AdminsSalary;

        public string getInfo()
        {
            string AdminsInfo = AdminsID + "\t" + AdminsName + "\t" + AdminsDesignation + "\t" + AdminsSalary;
            return AdminsInfo;
        }


    }
}
