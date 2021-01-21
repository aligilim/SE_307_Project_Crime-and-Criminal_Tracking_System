using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CrimeAndCriminalTrackingSystem
{
    class Criminal
    {
        private int criminalID;
        private String criminalName;
        private String criminalSurname;
        private DateTime dateOfBirth;
        private String gender;
        private String crimeRecord;
        private Image photo;

        public int CriminalID   
        {
            get { return criminalID; }
            set { criminalID = value; }
        }

        public String CriminalName
        {
            get { return criminalName; }
            set { criminalName = value; }
        }

        public String CriminalSurname
        {
            get { return criminalSurname; }
            set { criminalSurname = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public String CrimeRecord
        {
            get { return crimeRecord; }
            set { crimeRecord = value; }
        }

        public Image Photo
        {
            get { return photo; }
            set { photo = value; }
        }

    }
}
