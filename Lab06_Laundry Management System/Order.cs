using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry
{
    public class Order
    {
        public int UserID;
        public int OrderID;
        public int ShirtsNum;
        public string ShirtType;
        public int PantsNum;
        public string PantType;
        public int SuitsNum;
        public string SuitsType;
        public int BedSheetsNum;
        public string BedSheetType;
        public int SpecificUserAmount;
        public string Status;
        public string Date;



        public Order()
        {

        }

        public Order(int UserID, int ShirtsNum, string ShirtType, int PantsNum, string PantType, int SuitsNum, string SuitsType, int BedSheetsNum, string BedSheetType, int SpecificUserAmount, int OrderID)
        {
            this.UserID = UserID;
            this.ShirtsNum = ShirtsNum;
            this.ShirtType = ShirtType;
            this.PantsNum = PantsNum;
            this.PantType = PantType;
            this.SuitsNum = SuitsNum;
            this.SuitsType = SuitsType;
            this.BedSheetsNum = BedSheetsNum;
            this.BedSheetType = BedSheetType;
            this.SpecificUserAmount = SpecificUserAmount;
            this.OrderID = OrderID;


        }

        public string getOrderList()
        {
            string Orders = "Shirts" + " - " + ShirtsNum + " - " + ShirtType + "  |  "
                +"Pants" + " - " + PantsNum + " - " + PantType + "  |  " 
                +"Suits" + " - " + SuitsNum + " - " + SuitsType + "  |  "
                +"Bedsheets" + " - " + BedSheetsNum + " - " + BedSheetType;
            return Orders;

        }
    }
}
