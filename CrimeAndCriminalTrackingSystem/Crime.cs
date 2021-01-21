using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAndCriminalTrackingSystem
{
    class Crime
    {
        private int crimeID;
        private DateTime date;
        private String reportingOfficer;
        private String preparedBy;
        private String criminalName;
        private String type;
        private String details;

        public int CrimeID
        {
            get { return crimeID; }
            set { crimeID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public String ReportingOfficer
        {
            get { return reportingOfficer; }
            set { reportingOfficer = value; }
        }

        public String PreparedBy
        {
            get { return preparedBy; }
            set { preparedBy = value; }
        }

        public String CriminalName
        {
            get { return criminalName; }
            set { criminalName = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Details
        {
            get { return details; }
            set { details = value; }
        }
    }
}
