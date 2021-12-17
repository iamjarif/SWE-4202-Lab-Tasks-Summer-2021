using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Medicine
    {
        public int MedicineID, MedicineQuantity, MedicinePrice;
        public string MedicineName;

        public Medicine ()
        {

        }
        
        
        public Medicine(int MedicineID, string MedicineName, int MedicineQuantity, int MedicinePrice)
        {
            this.MedicineID = MedicineID;
            this.MedicineName = MedicineName;
            this.MedicineQuantity = MedicineQuantity;
            this.MedicinePrice = MedicinePrice;
        }

    }
}
