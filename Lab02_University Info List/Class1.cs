using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class1
    {
        public string studentsID;
        public string studentsName;
        public string studentsSemester;
        public string studentsDepart;

        public string getInfo()
        {
            string stdInfo = studentsID + "\t" + studentsName + "\t" + studentsSemester + "\t" + studentsDepart;
            return stdInfo;

        }
    }


    
}
