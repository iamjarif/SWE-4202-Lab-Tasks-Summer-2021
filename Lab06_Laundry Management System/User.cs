using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry
{
    public class User
    {
        public string UserName, UserAdress;
        public int UserID, UserAmount;
        
        public User()
        {

        }
        public User (int UserID, string UserName, string UserAddress)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.UserAdress = UserAddress;
            
        }

    }

    
}
