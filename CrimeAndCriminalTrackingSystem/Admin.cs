using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAndCriminalTrackingSystem
{
    class Admin
    {
        private int adminID;
        private String username;
        private String password;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
