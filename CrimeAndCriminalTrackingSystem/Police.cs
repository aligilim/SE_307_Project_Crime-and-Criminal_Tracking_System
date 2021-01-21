using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CrimeAndCriminalTrackingSystem
{
    class Police
    {
        private int policeID;
        private String policeName;
        private String policeSurname;
        private String department;
        private String rank;
        private int phone;
        private Image photo;


        public int PoliceID
        {
            get { return policeID; }
            set { policeID = value; }
        }

        public String PoliceName
        {
            get { return policeName; }
            set { policeName = value; }
        }

        public String PoliceSurname
        {
            get { return policeSurname; }
            set { policeSurname = value; }
        }

        public String Department
        {
            get { return department; }
            set { department = value; }
        }

        public String Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }

    }
}
